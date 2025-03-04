﻿Imports System.IO.Ports
Imports System.Threading

Public Class BrailleComLib

#Region "Constantes de comandos UART"
    Public ReadOnly BCLS_HANDSHAKE As Byte = &HF0
    Public ReadOnly BCLS_PREPARAR_IMPRESION As Byte = &HF1
    Public ReadOnly BCLS_HOJA_NUMERO As Byte = &HF2
    Public ReadOnly BCLS_HOJA_ACTUAL As Byte = &HF3
    Public ReadOnly BCLS_ABORTAR As Byte = &HF4
    Public ReadOnly BCLS_SACAR_HOJA As Byte = &HF5
    Public ReadOnly BCLS_ESTADO_ACTUAL As Byte = &HF6

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

#Region "Inicializacion de objetos"
    Private Shared SerialPort1 As New SerialPort
    Public Impresora_Conectada As Boolean = False
    Private hoja_mem As Hoja_c
    Private _trabajoAct As TrabajoActual_c
    Private _sender As Object
    Private timer1 As Timer

    Public Event impresion_ok()   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event impresion_fail(dato As Byte)   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event linea_terminada(dato As Byte)   'Evento alzado por la libreria , utilizar constantes de arriba.
    Public Event shutdown()   'Evento alzado por la libreria , utilizar constantes de arriba.

    Private Shared responseReceived As New ManualResetEvent(False)
#End Region

#Region "Conexion, desconexion y handshake"

    Public Function Conectar_Impresora(ByVal Puerto As String) As ConnectionResponse
        'Verificar si el driver SerialPort1 esta abierto y cerrarlo.

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        'Asignar nuevos valores a SerialPort1
        SerialPort1 = New SerialPort With {
            .PortName = Puerto,
            .BaudRate = 115200,
            .ReadBufferSize = 128,
            .WriteBufferSize = 512,
            .ReadTimeout = 200
            }

        AddHandler SerialPort1.DataReceived, AddressOf DataReceivedHandler
        Try
            'Abrir puerto
            SerialPort1.Open()
        Catch ex As Exception
            Return New ConnectionResponse(False, "Error al abrir el puerto:" + vbNewLine + ex.Message)
        End Try

        'Enviar handshake
        If Handshake() Then
            Impresora_Conectada = True
            Return New ConnectionResponse(True, "Se realizó la conexión con éxito.")
        Else
            Return New ConnectionResponse(False, "La impresora no responde, ¿Es ese el puerto correcto?")
        End If
    End Function

    Public Sub Desconectar_Impresora()

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Impresora_Conectada = False
        End If

    End Sub

    Public Function Handshake() As Boolean
        'Si recibe esto la impresora, debe continuar su funcionamiento normal
        Try
            responseReceived.Reset()
            SendCommand(BCLS_HANDSHAKE, 0)
            Return GetResponse().Equals(BCLR_CMD_VALIDO)
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Rutinas varias"
    Public Sub New(ByRef sender As Object, ByRef trabajoAct As Object)
        _sender = sender
        _trabajoAct = trabajoAct
    End Sub
    Public Function GetSerialComList() As List(Of String)
        Dim SerialPortList As New List(Of String)(My.Computer.Ports.SerialPortNames)
        Return SerialPortList
    End Function
    Public Function SendHojasTotales(Hojas As Byte)
        Dim retorno As Boolean = False
        SerialEventEnable = False
        SendCommand(BCLS_HOJA_NUMERO, Hojas)
        retorno = GetResponse().Equals(BCLR_CMD_VALIDO)
        SerialEventEnable = True
        Return retorno
    End Function

    Public Function SendHojaActual(Hoja As Byte)
        Dim retorno As Boolean = False
        SerialEventEnable = False
        SendCommand(BCLS_HOJA_ACTUAL, Hoja)
        retorno = GetResponse().Equals(BCLR_CMD_VALIDO)
        SerialEventEnable = True
        Return retorno
    End Function

    Public Function ConsultarEstadoActual() 'Si retorna 1, está imprimiendo.
        SerialEventEnable = False
        SendCommand(BCLS_ESTADO_ACTUAL, 0)
        Dim response As Byte = GetResponse()
        SerialEventEnable = True
        If (response <> UART_TIMEOUT) Then
            If response = 1 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Sub ReiniciarImpresora()
        If Impresora_Conectada Then
            SerialPort1.RtsEnable = True
            Thread.Sleep(500)
            SerialPort1.RtsEnable = False
            Thread.Sleep(6000)
        End If
    End Sub

    Public Function SacarHoja()
        Dim retorno As Boolean = False
        SerialEventEnable = False
        SendCommand(BCLS_SACAR_HOJA, 0)
        retorno = GetResponse().Equals(BCLR_CMD_VALIDO)
        SerialEventEnable = True
        Return retorno
    End Function

    Public Function PrepararImpresion()
        Dim retorno As Boolean = False
        SerialEventEnable = False
        SendCommand(BCLS_PREPARAR_IMPRESION, 0)
        retorno = GetResponse().Equals(BCLR_CMD_VALIDO)
        SerialEventEnable = True
        Return retorno
    End Function
#End Region

#Region "Envio de hojas"
    Public Function SendHoja(hoja As Hoja_c) As Boolean ' prepara la impresora para recibir el array, manda la hoja y espera el OK.

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

        SendHojaActual(hoja.Numero)
        PrepararImpresion()
        Return SendArray(SerialSendBuffer)

    End Function
    Private Function SendArray(array() As Byte) As Boolean ' Retorna 1 si fue exitoso 0 si hubo algun error
        'TODO: Cambiar tipo a UINT8 para definir retornos personalizados que indiquen checksum malo y demas.

        'calculo del checksum
        Dim csum_long As Long = 0
        For Each dato In array
            csum_long += dato
        Next
        Dim checksum(0) As Byte
        checksum(0) = csum_long Mod 256

        'envio del checksum
        SerialEventEnable = False
        SerialClearBuffer()
        'envio de la hoja
        SerialPort1.Write(array, 0, array.Count)
        SerialPort1.Write(checksum, 0, 1)
        Dim respuesta As Byte = GetResponse()
        SerialEventEnable = True

        If (respuesta = BCLE_RECEPCION_OK) Then
            Return True
        Else
            Return False
        End If

    End Function
#End Region

#Region "Envio de datos"
    Private Function SendCommand(ByVal cmd As Byte, ByVal val As Byte) As Boolean
        Try
            Dim SerialSendBuffer(1) As Byte
            SerialSendBuffer(0) = cmd
            SerialSendBuffer(1) = val
            SerialPort1.Write(SerialSendBuffer, 0, 2)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Recepcion de datos"
    Private lastResponse() As Byte
    Private SerialEventEnable As Boolean = True

    Private Sub SerialClearBuffer()
        SerialPort1.DiscardInBuffer()
        responseReceived.Reset()
    End Sub

    Private Function GetResponse() As Byte 'lee un solo byte.
        Try
            Dim inputByte As Byte = SerialPort1.ReadByte
            Return inputByte
        Catch ex As Exception
            Return UART_TIMEOUT
        End Try
    End Function

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        If SerialEventEnable Then
            Thread.Sleep(100)
            Dim sp As SerialPort = CType(sender, SerialPort)

            Try
                If (sp.BytesToRead < 3) Then
                    Thread.Sleep(100)
                End If

                Dim InBuffer(sp.BytesToRead - 1) As Byte
                Dim AssignedBytes As Integer = sp.Read(InBuffer, 0, sp.BytesToRead)

                Dim InString As String = ""
                For Each dato In InBuffer
                    InString += "{" + Hex(dato) + "}"
                Next
                Dim sn As ImpresoraBraille = CType(_sender, ImpresoraBraille)
                sn.ListBox1.Items.Add(InString)

                If AssignedBytes = 3 Then
                    If InBuffer(0) = BCLE_EVENTO_PREFIX Then
                        'el dato recibido es un evento.
                        Dim args As New StatusUpdateArgs(InBuffer(1), InBuffer(2))
                        SerialClearBuffer()
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
                Else
                    lastResponse = InBuffer
                    responseReceived.Set()
                End If
                SerialPort1.DiscardInBuffer()
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en ""DataReceivedHandler"":")
            End Try
        End If
    End Sub
#End Region

#Region "Debug"
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
#End Region

#Region "Estructuras"
    Public Structure StatusUpdateArgs
        Dim IdEvento As Byte
        Dim Dato As Byte
        Public Sub New(idEvento As Byte, dato As Byte)
            Me.IdEvento = idEvento
            Me.Dato = dato
        End Sub
    End Structure

    Public Structure ConnectionResponse
        Dim result As Boolean
        Dim message As String

        Public Sub New(_result As Boolean, _message As String)
            result = _result
            message = _message
        End Sub
    End Structure
#End Region
End Class
