Public Class BrailleComLib

    Public arrayHoja_a_enviar(6, 71) As Byte
    Private SerialPort1 As New System.IO.Ports.SerialPort
    Private Puerto_Iniciado As Boolean = False

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
            Try
                Dim ByteRecibido As Byte = SerialPort1.ReadByte()
                If ByteRecibido = BCLR_CMD_VALIDO Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    'Funciones varias
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

    'Funciones HAL
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

    'Invalidaciones, obviarlas.
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
End Class
