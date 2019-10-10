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
        RichTextBox2.Text = Traductor.AjustarRenglones(TextoTraducido, 28)
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
        Dim myBitArray(4032) As Boolean
        Dim myBitArray_index As UInteger
        Dim BitInByte_index As UInteger
        Dim myBitMatrix(55, 71) As Boolean


        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                myByteArray(myByteArray_Index) = BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY)
                myByteArray_Index = myByteArray_Index + 1
            Next
        Next

        myByteArray_Index = 0

        For myBitArray_index = 0 To 4032
            myBitArray(myBitArray_index) = (myByteArray(myByteArray_Index) And (&H80 >> BitInByte_index))
            BitInByte_index = BitInByte_index + 1
            If (BitInByte_index = 8) Then
                BitInByte_index = 0
                myByteArray_Index = myByteArray_Index + 1
            End If
        Next

        Dim cuenta As Integer = 0
        For y As Integer = myBitMatrix.GetLowerBound(1) To myBitMatrix.GetUpperBound(1)
            For x As Integer = myBitMatrix.GetLowerBound(0) To myBitMatrix.GetUpperBound(0)
                DibujarPunto(x, y, myBitArray(cuenta))
                cuenta = cuenta + 1
            Next
        Next

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

