Imports System.IO.Ports

Public Class BrailleComLib

#Region "Constantes de comandos UART"
    Public Const BCLS_HANDSHAKE As Byte = &HF0
    Public Const BCLS_PREPARAR_IMPRESION As Byte = &HF1
    Public Const BCLS_HOJA_NUMERO As Byte = &HF2
    Public Const BCLS_HOJA_ACTUAL As Byte = &HF3
    Public Const BCLR_CMD_VALIDO As Byte = &HF4
    Public Const BCLR_CMD_INVALIDO As Byte = &HF5
    Public Const BCLE_RECEPCION_OK As Byte = &HF6
    Public Const BCLE_RECEPCION_ERROR As Byte = &HF7

    Public Const UART_TIMEOUT As Byte = &HFD


    'Respuestas dadas por eventos.
    Public Const BCLE_EVENTO_PREFIX As Byte = &HF8             'Para indicar un evento de los de abajo:
    Public Const BCLE_EVENTO_IMPRESION_OK As Byte = &HA1       'Para indicar que la hoja se termino de imprimir.
    Public Const BCLE_EVENTO_IMPRESION_FAIL As Byte = &HA2     'Para indicar que hubo un Error al imprimir la hoja.
    Public Const BCLE_EVENTO_SHUTDOWN As Byte = &HA3           'Para indicar que el usuario presiono el boton de apagado.
    Public Const BCLE_EVENTO_LINEA_TERMINADA As Byte = &HA4    'Va acompañada de el numero de linea justo a continuacion.

#End Region

    'Inicializacion de objetos
    Public arrayHoja_a_enviar(6, 71) As Byte
    Private SerialPort1 As New SerialPort
    Private Puerto_Iniciado As Boolean = False

    Public Event StatusUpdate(ByVal Args As StatusUpdateArgs)   'Evento alzado por la libreria , utilizar constantes de arriba.

#Region "Rutinas de Conexion, desconexion y handshake"

    Public Function Conectar_Impresora(ByVal Puerto As String)
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        SerialPort1.PortName = Puerto

        If GetSerialComList().Contains(Puerto) And Not SerialPort1.IsOpen Then
            If PortIsAvailable(Puerto) Then
                SerialPort1.ReadTimeout = 200
                SerialPort1.BaudRate = 115200
                AddHandler SerialPort1.DataReceived, AddressOf DataReceivedHandler
                SerialPort1.Open()
                Puerto_Iniciado = True
            End If
        End If

        If Impresora_Conectada() Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Desconectar_Impresora()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Puerto_Iniciado = False
        End If
    End Sub

    Public Function Impresora_Conectada() As Boolean
        'verificar si sigue conectada la impresora en caso que COM este abierto
        'Si COM no esta abierto, retornar false
        ' en todo caso actualizar impresora vinculada
        If Puerto_Iniciado Then
            If Not SerialPort1.IsOpen Then
                Return False
            Else
                Return Handshake()
            End If
        Else
            Return False
        End If
    End Function

    Public Function Handshake() As Boolean
        'Si recibe esto la impresora, debe continuar su funcionamiento normal
        If SerialPort1.IsOpen Then
            SendCommand(BCLS_HANDSHAKE, 0)
            Return GetResponse().Equals(BCLR_CMD_VALIDO)
        End If
        Return False
    End Function

    Private Function Serial_GetByte() As Byte
        Dim ByteRecibido As Byte

        Try
            ByteRecibido = SerialPort1.ReadByte()
            Return ByteRecibido
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Function GetResponse() As Byte
        Dim ByteRecibido As Byte
        Try
            ByteRecibido = SerialPort1.ReadByte()
        Catch ex As Exception
            Return UART_TIMEOUT
        End Try

        If ByteRecibido <> UART_TIMEOUT Then
            Return ByteRecibido
        End If
        Return UART_TIMEOUT
    End Function

    Public Function SendHojasTotales(Hojas As Byte)
        SendCommand(BCLS_HOJA_NUMERO, Hojas)
        Return GetResponse().Equals(BCLR_CMD_VALIDO)
    End Function

    Public Function SendHojaActual(Hoja As Byte)
        SendCommand(BCLS_HOJA_ACTUAL, Hoja)
        Return GetResponse().Equals(BCLR_CMD_VALIDO)
    End Function

    Public Function PrepararImpresion()
        SendCommand(BCLS_PREPARAR_IMPRESION, 0)
        Return GetResponse().Equals(BCLR_CMD_VALIDO)
    End Function

#End Region

#Region "Rutinas de manejo de puerto serie"
    Public Function GetSerialComList() As List(Of String)
        Dim SerialPortList As New List(Of String)(My.Computer.Ports.SerialPortNames)
        Return SerialPortList
    End Function

    Public Function PortIsAvailable(ByVal port As String) As Boolean
        Dim TempPort As New System.IO.Ports.SerialPort
        TempPort.PortName = port
        'Surely there's a better way to test for availability
        'than trying to open the port and catching errors.
        Try
            TempPort.Open()
        Catch ex As UnauthorizedAccessException
            Return False
        End Try
        TempPort.Close()
        Return True
    End Function


    Private Sub SendCommand(ByVal cmd As Byte, ByVal val As Byte)
        If SerialPort1.IsOpen Then
            Try
                Dim SerialSendBuffer(1) As Byte
                SerialSendBuffer(0) = cmd
                SerialSendBuffer(1) = val
                SerialPort1.Write(SerialSendBuffer, 0, 2)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub
#End Region

    Public Sub SendHoja(HojaActual As Byte) ' prepara la impresora para recibir el array, manda la hoja y espera el OK.
        SendHojaActual(HojaActual)

        If (PrepararImpresion()) Then
            If Not SendArray() Then
                MsgBox("Hubo un error al comunicarse con la impresora")
            End If
        End If

    End Sub

    Public Function SendArray() ' Retorna 1 si fue exitoso 0 si hubo algun error
        If SerialPort1.IsOpen Then

            Dim SerialSendBuffer(505) As Byte

            For Each dato In SerialSendBuffer
                dato = 0
            Next

            Dim Index As Integer = 0
            Dim csum_long As Long = 0

            For i_ejeY As Integer = arrayHoja_a_enviar.GetLowerBound(1) To arrayHoja_a_enviar.GetUpperBound(1)
                For i_ejeX As Integer = arrayHoja_a_enviar.GetLowerBound(0) To arrayHoja_a_enviar.GetUpperBound(0)
                    SerialSendBuffer(Index) = arrayHoja_a_enviar(i_ejeX, i_ejeY)
                    csum_long += SerialSendBuffer(Index)
                    Index = Index + 1
                Next
            Next

            'calculo del checksum
            SerialSendBuffer(504) = csum_long Mod 256

            'envio de la hoja
            SerialPort1.Write(SerialSendBuffer, 0, 505)


            Dim respuesta As Byte = GetResponse()
            If respuesta = BCLE_RECEPCION_OK Then
                Return True
            ElseIf respuesta = BCLE_RECEPCION_ERROR Then
                Return False
            End If
        End If
        Return False
    End Function

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim InData(3) As Byte
        If (sp.Read(InData, 0, 3) = 3 And InData(0) = BCLE_EVENTO_PREFIX) Then
            'el dato recibido es un evento.
            Dim args As New StatusUpdateArgs(InData(1), InData(2))
            RaiseEvent StatusUpdate(args)
        End If
    End Sub

    Public Structure StatusUpdateArgs
        Dim IdEvento As Byte
        Dim Dato As Byte
        Public Sub New(idEvento As Byte, dato As Byte)
            Me.IdEvento = idEvento
            Me.Dato = dato
        End Sub
    End Structure
#Region "Rutinas de invalidaciones"
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
#End Region
End Class
