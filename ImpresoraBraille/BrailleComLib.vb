Public Class BrailleComLib

#Region "Constantes de comandos UART"
    Private Const BCLS_HANDSHAKE As Byte = &HF0
    Private Const BCLS_PREPARAR_IMPRESION As Byte = &HF1
    Private Const BCLS_HOJA_NUMERO As Byte = &HF2
    Private Const BCLS_HOJA_ACTUAL As Byte = &HF3
    Private Const BCLR_CMD_VALIDO As Byte = &HF4
    Private Const BCLR_CMD_INVALIDO As Byte = &HF5
    Private Const BCLE_IMPRESION_OK As Byte = &HF6
    Private Const BCLE_IMPRESION_ERROR As Byte = &HF7
    Private Const BCLE_RECEPCION_OK As Byte = &HF8
    Private Const BCLE_RECEPCION_ERROR As Byte = &HF9

    Private Const UART_TIMEOUT As Byte = &HFD
#End Region

    'Inicializacion de objetos
    Public arrayHoja_a_enviar(6, 71) As Byte
    Private SerialPort1 As New System.IO.Ports.SerialPort
    Private Puerto_Iniciado As Boolean = False

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
            MsgBox(SendArray().ToString)
        End If
    End Sub

    Public Function SendArray() ' Retorna 1 si fue exitoso 0 si hubo algun error
        If SerialPort1.IsOpen Then
            Dim SerialSendBuffer(504) As Byte
            Dim Index As Integer = 0

            For i_ejeY As Integer = arrayHoja_a_enviar.GetLowerBound(1) To arrayHoja_a_enviar.GetUpperBound(1)
                For i_ejeX As Integer = arrayHoja_a_enviar.GetLowerBound(0) To arrayHoja_a_enviar.GetUpperBound(0)
                    SerialSendBuffer(Index) = arrayHoja_a_enviar(i_ejeX, i_ejeY)
                    Index = Index + 1
                Next
            Next

            SerialPort1.Write(SerialSendBuffer, 0, 504)

            Dim recepcion_OK As Boolean = GetResponse().Equals(BCLE_RECEPCION_OK)

            If recepcion_OK Then
                'CALCULAR CRC8
                Dim checksum As Byte = Serial_GetByte()
                MsgBox("Checksum PC: " + Crc8(SerialSendBuffer, 504).ToString() + " - Checksum ARD: " + checksum.ToString())
            End If

        End If

        Return False
    End Function

    Public Shared Function Crc8(ByVal data As Byte(), ByVal size As Integer) As Byte
        Dim checksum As Byte = 0
        For i As Integer = 0 To size - 1
            checksum = (CInt(checksum) + data(i)) Mod 256
        Next
        If checksum = 0 Then
            Return 0
        Else
            Return CByte(256 - checksum)
        End If
    End Function


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
