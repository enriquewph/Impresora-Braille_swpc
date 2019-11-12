Imports System.IO.Ports

Public Class BrailleComLib

#Region "Constantes de comandos UART"
    Public ReadOnly BCLS_HANDSHAKE As Byte = &HF0
    Public ReadOnly BCLS_PREPARAR_IMPRESION As Byte = &HF1
    Public ReadOnly BCLS_HOJA_NUMERO As Byte = &HF2
    Public ReadOnly BCLS_HOJA_ACTUAL As Byte = &HF3
    Public ReadOnly BCLR_CMD_VALIDO As Byte = &HF4
    Public ReadOnly BCLR_CMD_INVALIDO As Byte = &HF5
    Public ReadOnly BCLE_RECEPCION_OK As Byte = &HF6
    Public ReadOnly BCLE_RECEPCION_ERROR As Byte = &HF7

    Public ReadOnly UART_TIMEOUT As Byte = &HFD


    'Respuestas dadas por eventos.
    Public ReadOnly BCLE_EVENTO_PREFIX As Byte = &HF8             'Para indicar un evento de los de abajo:
    Public ReadOnly BCLE_EVENTO_IMPRESION_OK As Byte = &HA1       'Para indicar que la hoja se termino de imprimir.
    Public ReadOnly BCLE_EVENTO_IMPRESION_FAIL As Byte = &HA2     'Para indicar que hubo un Error al imprimir la hoja.
    Public ReadOnly BCLE_EVENTO_SHUTDOWN As Byte = &HA3           'Para indicar que el usuario presiono el boton de apagado.
    Public ReadOnly BCLE_EVENTO_LINEA_TERMINADA As Byte = &HA4    'Va acompañada de el numero de linea justo a continuacion.

#End Region

    'Inicializacion de objetos
    Private arrayHoja_a_enviar(6, 71) As Byte
    Private SerialPort1 As New SerialPort
    Private Puerto_Iniciado As Boolean = False
    Private hoja_mem As Hoja_c
    Private _trabajoAct As TrabajoActual_c

    Public Event impresion_ok()   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event impresion_fail(dato As Byte)   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event linea_terminada(dato As Byte)   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event shutdown()   'Evento alzado por la libreria , utilizar constantes de arriba.

    Public Sub New(ByRef trabajoAct As Object)
        _trabajoAct = trabajoAct
    End Sub
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

        If ByteRecibido <> UART_TIMEOUT Then 'fabriestuvoaqui
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
        Dim TempPort As New System.IO.Ports.SerialPort With {
            .PortName = port
        }
        'Surely there's a better way to test for availability
        'than trying to open the port and catching errors.
        Try
            TempPort.Open()
            TempPort.Close()
        Catch ex As UnauthorizedAccessException
            Return False
        End Try
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

    Public Sub SendHoja(hoja As Hoja_c) ' prepara la impresora para recibir el array, manda la hoja y espera el OK.

        'Transferir BitMatrix a BitArray
        Dim bitArray(hoja.BitMatrix.Length - 1) As Boolean
        Dim index As Integer = 0

        For y As Integer = hoja.BitMatrix.GetLowerBound(1) To hoja.BitMatrix.GetUpperBound(1)
            For x As Integer = hoja.BitMatrix.GetLowerBound(0) To hoja.BitMatrix.GetUpperBound(0)
                bitArray(index) = hoja.BitMatrix(x, y)
                index += 1
            Next
        Next

        'Convertir BitArray en ByteArray

        Dim SerialSendBuffer(Math.Ceiling(hoja.BitMatrix.Length / 8) - 1) As Byte 'excluye byte de checksum

        For Each dato In SerialSendBuffer
            dato = 0
        Next

        For i As Integer = SerialSendBuffer.GetLowerBound(0) To SerialSendBuffer.GetUpperBound(0)
            If (8 * i) <= bitArray.GetUpperBound(0) Then
                If bitArray(8 * i) Then
                    SerialSendBuffer(i) += 1
                End If
            End If

            If ((8 * i) + 1) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 1) Then
                    SerialSendBuffer(i) += 2
                End If
            End If

            If ((8 * i) + 2) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 2) Then
                    SerialSendBuffer(i) += 4
                End If
            End If

            If ((8 * i) + 3) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 3) Then
                    SerialSendBuffer(i) += 8
                End If
            End If

            If ((8 * i) + 4) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 4) Then
                    SerialSendBuffer(i) += 16
                End If
            End If

            If ((8 * i) + 5) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 5) Then
                    SerialSendBuffer(i) += 32
                End If
            End If

            If ((8 * i) + 6) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 6) Then
                    SerialSendBuffer(i) += 64
                End If
            End If

            If ((8 * i) + 7) <= bitArray.GetUpperBound(0) Then
                If bitArray((8 * i) + 7) Then
                    SerialSendBuffer(i) += 128
                End If
            End If
        Next

        Dim reintentar As Boolean = True
        While reintentar
            SendHojaActual(hoja.Numero)
            SendCommand(BCLS_PREPARAR_IMPRESION, 0)
            If SendArray(SerialSendBuffer) = False Then
                If MsgBox("Hubo un error al enviar la hoja..." + vbNewLine + "¿Desea reintentar?", MsgBoxStyle.RetryCancel, "Error de comunicacion") = MsgBoxResult.Retry Then
                    reintentar = True
                Else
                    reintentar = False
                End If
            Else
                reintentar = False
            End If
        End While

    End Sub

    Private Sub DebugBitArray_arduino(hoja As Hoja_c)
        Dim txt As String = "bool bitArray["
        txt += (hoja.BitMatrix.GetUpperBound(0) + 1).ToString
        txt += "]["
        txt += (hoja.BitMatrix.GetUpperBound(1) + 1).ToString
        txt += "] = {"
        For y As Integer = hoja.BitMatrix.GetLowerBound(1) To hoja.BitMatrix.GetUpperBound(1)
            If y > hoja.BitMatrix.GetLowerBound(1) Then
                txt += "                         "
            End If
            For x As Integer = hoja.BitMatrix.GetLowerBound(0) To hoja.BitMatrix.GetUpperBound(0)
                If hoja.BitMatrix(x, y) Then
                    txt += "1"
                Else
                    txt += "0"
                End If

                If y < hoja.BitMatrix.GetUpperBound(1) Or x < hoja.BitMatrix.GetUpperBound(0) Then
                    txt += ", "
                End If
            Next
            If y < hoja.BitMatrix.GetUpperBound(1) Then
                txt += vbNewLine
            End If
        Next
        txt += "};"

        Dim SaveFileDialog1 As New SaveFileDialog With {
            .DefaultExt = "*.c",
            .Filter = "c program file|*.c",
            .CreatePrompt = True
        }
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Using outputFile As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                outputFile.Write(txt)
            End Using
        End If
    End Sub

    Private Sub DebugArray(array() As Byte)
        Dim txt As String = "uint8_t SerialSendBuffer["
        txt += array.Count.ToString
        txt += "] = {"

        For i As Integer = array.GetLowerBound(0) To array.GetUpperBound(0)
            txt += array(i).ToString
            If i < array.GetUpperBound(0) Then
                txt += ", "
            End If
        Next
        txt += "};"

        Dim SaveFileDialog1 As New SaveFileDialog With {
            .DefaultExt = "*.c",
            .Filter = "c program file|*.c",
            .CreatePrompt = True
        }
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Using outputFile As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                outputFile.Write(txt)
            End Using
        End If
    End Sub

    Private Function SendArray(array() As Byte) As Boolean ' Retorna 1 si fue exitoso 0 si hubo algun error
        'TODO: Cambiar tipo a UINT8 para definir retornos personalizados que indiquen checksum malo y demas.

        If SerialPort1.IsOpen Then

            'calculo del checksum
            Dim csum_long As Long = 0
            For Each dato In array
                csum_long += dato
            Next
            Dim checksum(0) As Byte
            checksum(0) = csum_long Mod 256

            'envio de la hoja
            SerialPort1.Write(array, 0, array.Count)

            'envio del checksum
            SerialPort1.Write(checksum, 0, 1)


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
        Try
            If (sp.Read(InData, 0, 3) = 3 And InData(0) = BCLE_EVENTO_PREFIX) Then
                'el dato recibido es un evento.
                Dim args As New StatusUpdateArgs(InData(1), InData(2))

                MsgBox("Evento:" + args.IdEvento.ToString + " " + args.Dato.ToString)

                Select Case args.IdEvento
                    Case BCLE_EVENTO_IMPRESION_FAIL
                        RaiseEvent impresion_fail(args.Dato)
                    Case BCLE_EVENTO_IMPRESION_OK
                        RaiseEvent impresion_ok()
                    Case BCLE_EVENTO_LINEA_TERMINADA
                        RaiseEvent linea_terminada(args.Dato)
                    Case BCLE_EVENTO_SHUTDOWN
                        RaiseEvent shutdown()
                End Select
            End If
        Catch ex As Exception

        End Try
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
