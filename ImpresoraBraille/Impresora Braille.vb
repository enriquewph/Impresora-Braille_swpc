Public Class ImpresoraBraille
    Dim BCL As New BrailleComLib
    Dim Traductor As New TraductorBraille
    Dim Puerto_Impresora As String
    Dim BitmapHoja As Bitmap


    Sub SetSerialPortNames()
        ' Show all available COM ports.

        Dim ComboBox As ToolStripComboBox = ToolStripComboBoxPuertos

        Dim ElegidoPrevio As String = My.Settings.COM

        If Not ComboBox.Text = "" Then
            ElegidoPrevio = ComboBox.SelectedItem
        End If

        ComboBox.Items.Clear()

        For Each sp As String In BCL.GetSerialComList()
            ComboBox.Items.Add(sp)
        Next

        If Not ElegidoPrevio = "" Then
            If ComboBox.Items.Contains(ElegidoPrevio) Then
                ComboBox.SelectedIndex = ComboBox.Items.IndexOf(ElegidoPrevio)
            Else
                ComboBox.SelectedIndex = 0
            End If
        Else
            ComboBox.SelectedIndex = 0
        End If

        My.Settings.COM = ComboBox.SelectedItem

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetSerialPortNames()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY) = 0
            Next
            BCL.arrayHoja_a_enviar(0, i_ejeY) = 128
        Next

        DibujarBitmap()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY) = 0
            Next
            BCL.arrayHoja_a_enviar(0, i_ejeY) = i_ejeY * 2
        Next

        BCL.SendHojasTotales(1)
        BCL.SendHoja(1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        RichTextBox2.Clear()
        Dim TextoATraducir As String = RichTextBox1.Text
        Dim TextoTraducido As String = Traductor.TraducirTexto(TextoATraducir)
        RichTextBox2.Text = TextoTraducido
    End Sub

    Private Sub ToolStripButtonConectar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonConectar.Click
        Puerto_Impresora = ToolStripComboBoxPuertos.SelectedItem

        If Not BCL.Impresora_Conectada() Then
            If Not BCL.Conectar_Impresora(Puerto_Impresora) Then
                'Si hubo un error al conectar hacer lo siguiente:
                MsgBox("No se pudo conectar a la impresora.", MsgBoxStyle.Exclamation, "Error de conexion:")
            End If
        Else
            BCL.Desconectar_Impresora()
        End If

        ActualizarLabelsConectar()
        My.Settings.COM = ToolStripComboBoxPuertos.SelectedItem
    End Sub

    Private Sub ToolStripButtonRecargarPuertos_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRecargarPuertos.Click
        SetSerialPortNames()
    End Sub

    Private Sub ActualizarLabelsConectar()
        If (BCL.Impresora_Conectada()) Then
            ToolStripButtonConectar.Text = "Desconectar"
            ToolStripButtonConectar.Image = My.Resources.Resources._01

            ToolStripLabelEstado.Text = "Conectado"
            ToolStripLabelEstado.Image = My.Resources.Resources._021
        Else
            ToolStripButtonConectar.Text = "Conectar"
            ToolStripButtonConectar.Image = My.Resources.Resources._02
            ToolStripLabelEstado.Text = "Desconectado"
            ToolStripLabelEstado.Image = My.Resources.Resources._011
        End If
    End Sub

    Private Sub ToolStripComboBoxPuertos_NoBlue(sender As Object, e As EventArgs) Handles ToolStripComboBoxPuertos.DropDownClosed
        ToolStripComboBoxPuertos.SelectionLength = 0
    End Sub

    Private Sub ToolStripComboBoxPuertos_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxPuertos.Click
        My.Settings.COM = ToolStripComboBoxPuertos.SelectedItem
    End Sub


    Private Sub DibujarBitmap()
        BitmapHoja = New Bitmap(56, 72)

        Dim myByteArray(504) As Byte
        Dim myByteArray_Index As UInteger


        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                myByteArray(myByteArray_Index) = BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY)
                myByteArray_Index = myByteArray_Index + 1
            Next
        Next

        Dim Str As String = ""
        Dim newLineCounter As Integer = 0

        Dim indx As UInt16 = 0

        For indx = 0 To 4032

            Dim bit As Boolean = 0

            If bit Then
                Str += "·"
            Else
                Str += " "
            End If

            newLineCounter = newLineCounter + 1

            If newLineCounter = 56 Then
                Str += vbNewLine
                newLineCounter = 0
            End If
        Next

        MsgBox(Str)

        PictureBox1.Image = BitmapHoja
    End Sub

    Private Sub DibujarPunto(x As Integer, y As Integer, valor As Boolean)
        Dim myColor As Color
        If valor Then
            myColor = Color.Black
        Else
            myColor = Color.White
        End If
        BitmapHoja.SetPixel(x, y, myColor)
    End Sub
End Class

