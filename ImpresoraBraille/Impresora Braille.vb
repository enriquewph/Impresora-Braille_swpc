Public Class Form1
#Region "variables"
    Dim arrayHoja(6, 71) As Byte
#End Region

    Sub GetSerialPortNames()
        ' Show all available COM ports.
        ComboBox1.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ButtonReloadCom_Click(sender As Object, e As EventArgs) Handles ButtonReloadCom.Click
        GetSerialPortNames()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not SerialPort1.IsOpen Then
                SerialPort1.BaudRate = 115200
                SerialPort1.PortName = ComboBox1.SelectedItem.ToString()
                SerialPort1.Open()
                LabelEstado.Text = "CONECTADO"
                Button1.Text = "DESCONECTAR"
            Else
                SerialPort1.Close()
                LabelEstado.Text = "DESCONECTADO"
                Button1.Text = "CONECTAR"
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i_ejeY As Integer = arrayHoja.GetLowerBound(1) To arrayHoja.GetUpperBound(1)
            For i_ejeX As Integer = arrayHoja.GetLowerBound(0) To arrayHoja.GetUpperBound(0)
                arrayHoja(i_ejeX, i_ejeY) = 0
            Next
            arrayHoja(0, i_ejeY) = 128
        Next

        RichTextBox1.Clear()

        Dim contador_renglones As Integer = 0
        For i_ejeY As Integer = arrayHoja.GetLowerBound(1) To arrayHoja.GetUpperBound(1)
            For i_ejeX As Integer = arrayHoja.GetLowerBound(0) To arrayHoja.GetUpperBound(0)

                RichTextBox1.Text += Convert.ToString(arrayHoja(i_ejeX, i_ejeY), 2).PadLeft(8, "0")
                If i_ejeX < arrayHoja.GetUpperBound(0) Then
                    RichTextBox1.Text += "-"
                End If
            Next
            RichTextBox1.Text += Environment.NewLine

            contador_renglones += 1

            If contador_renglones = 3 Then
                RichTextBox1.Text += Environment.NewLine
                contador_renglones = 0
            End If
        Next
    End Sub

    Sub SendArrayHoja()
        If SerialPort1.IsOpen Then
            For i_ejeY As Integer = arrayHoja.GetLowerBound(1) To arrayHoja.GetUpperBound(1)
                For i_ejeX As Integer = arrayHoja.GetLowerBound(0) To arrayHoja.GetUpperBound(0)
                    SerialPort1.Write(arrayHoja(i_ejeX, i_ejeY))
                Next
                SerialPort1.Write(Environment.NewLine)
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendArrayHoja()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Traductor As New TraductorBraille
        RichTextBox2.Clear()
        Dim TextoATraducir As String = RichTextBox1.Text
        Dim TextoTraducido As String = Traductor.TraducirTexto(TextoATraducir)
        RichTextBox2.Text = TextoTraducido
    End Sub
End Class
