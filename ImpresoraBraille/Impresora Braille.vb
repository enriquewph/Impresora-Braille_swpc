Public Class ImpresoraBraille
    Dim BCL As New BrailleComLib
    Dim Traductor As New TraductorBraille
    Dim Puerto_Impresora As String
    Dim BitmapHoja As Bitmap
    Dim BitMatrixHoja(55, 71) As Boolean


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
        Dim TextoAjustado As String = Traductor.AjustarRenglones(TextoTraducido, 28)
        TransponerTextoABitArray(TextoAjustado)
        RichTextBox2.Text = TextoAjustado
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

    Private Sub TransponerTextoABitArray(inputString As String)
        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰
        Dim Cord_X As Integer = 0
        Dim Cord_Y As Integer = 0

        For Each bit As Boolean In BitMatrixHoja
            bit = 0
        Next

        For char_index As Integer = 0 To inputString.Length() - 1
            MarcarPuntos(inputString.Chars(char_index), Cord_X, Cord_Y)

            Cord_X = Cord_X + 2

            If (Cord_X = 53) Then
                Cord_X = 0
                Cord_Y = Cord_Y + 3
            End If
        Next
    End Sub

    Private Sub MarcarPuntos(inputChar As Char, x As Integer, y As Integer)
        Dim Dot_TL As Boolean = 0 ' SUPERIOR IZQUIERDO
        Dim Dot_TR As Boolean = 0 ' SUPERIOR DERECHO
        Dim Dot_ML As Boolean = 0 ' MEDIO IZQUIERDA
        Dim Dot_MR As Boolean = 0 ' MEDIO DERECHA
        Dim Dot_BL As Boolean = 0 ' BASE IZQUIERDO
        Dim Dot_BR As Boolean = 0 ' BASE DERECHO

        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰

        Select Case inputChar
            Case " "

            Case "⠁"
                Dot_TL = 1
            Case "⠃"
                Dot_TL = 1
                Dot_ML = 1
            Case "⠉"
                Dot_TL = 1
                Dot_TR = 1
            Case "⠙"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
            Case "⠑"
                Dot_TL = 1
                Dot_MR = 1
            Case "⠋"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
            Case "⠛"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠓"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠊"
                Dot_TR = 1
                Dot_ML = 1
            Case "⠚"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠈"
                Dot_TR = 1
            Case "⠘"
                Dot_TR = 1
                Dot_MR = 1
            Case "⠄"
                Dot_BL = 1
            Case "⠅"
                Dot_TL = 1
                Dot_BL = 1
            Case "⠇"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠍"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BL = 1
            Case "⠝"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠕"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠏"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠟"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠗"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠎"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠞"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠌"
                Dot_TR = 1
                Dot_BL = 1
            Case "⠜"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠤"
                Dot_BL = 1
                Dot_BR = 1
            Case "⠥"
                Dot_BL = 1
                Dot_BR = 1
                Dot_TL = 1
            Case "⠧"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠭"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠽"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠵"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠯"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠿"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠷"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠮"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠾"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠬"
                Dot_TR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠼"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠠"
                Dot_BR = 1
            Case "⠡"
                Dot_TL = 1
                Dot_BR = 1
            Case "⠣"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠩"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BR = 1
            Case "⠹"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠱"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠫"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠻"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠳"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠪"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠺"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠨"
                Dot_TR = 1
                Dot_BR = 1
            Case "⠸"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠂"
                Dot_ML = 1
            Case "⠆"
                Dot_ML = 1
                Dot_BL = 1
            Case "⠒"
                Dot_ML = 1
                Dot_MR = 1
            Case "⠲"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠢"
                Dot_ML = 1
                Dot_BR = 1
            Case "⠖"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠶"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠦"
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠔"
                Dot_MR = 1
                Dot_BL = 1
            Case "⠴"
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠐"
                Dot_MR = 1
            Case "⠰"
                Dot_MR = 1
                Dot_BR = 1
        End Select

        BitMatrixHoja(x, y) = Dot_TL
        BitMatrixHoja(x, y + 1) = Dot_ML
        BitMatrixHoja(x, y + 2) = Dot_BL

        BitMatrixHoja(x + 1, y) = Dot_TR
        BitMatrixHoja(x + 1, y + 1) = Dot_MR
        BitMatrixHoja(x + 1, y + 1) = Dot_BR

    End Sub

    Private Sub DibujarBitmap()
        BitmapHoja = New Bitmap(1204, 1702)

        Dim X As Integer = 142
        Dim Y As Integer = 142

        Dim cuenta_X As Integer = 0
        Dim cuenta_Y As Integer = 0

        For punto_y As Integer = BitMatrixHoja.GetLowerBound(1) To BitMatrixHoja.GetUpperBound(1)
            For punto_x As Integer = BitMatrixHoja.GetLowerBound(0) To BitMatrixHoja.GetUpperBound(0)
                DibujarPunto(X, Y, BitMatrixHoja(punto_x, punto_y))

                cuenta_X = cuenta_X + 1

                If (cuenta_X = 2) Then
                    cuenta_X = 0
                    X = X + 22
                Else
                    X = X + 15
                End If
            Next

            X = 142

            cuenta_Y = cuenta_Y + 1

            If (cuenta_Y = 4) Then
                cuenta_Y = 0
                Y = Y + 32
            Else
                Y = Y + 15
            End If
        Next

        PictureBox1.Image = BitmapHoja
    End Sub

    Private Sub DibujarPunto(x As Integer, y As Integer, valor As Boolean)
        Try
            Dim myColor As Color
            If valor Then
                myColor = Color.Black
            Else
                myColor = Color.White
            End If

            BitmapHoja.SetPixel(x - 1, y + 3, myColor)
            BitmapHoja.SetPixel(x, y + 3, myColor)
            BitmapHoja.SetPixel(x + 1, y + 3, myColor)

            BitmapHoja.SetPixel(x - 2, y + 2, myColor)
            BitmapHoja.SetPixel(x - 1, y + 2, myColor)
            BitmapHoja.SetPixel(x, y + 2, myColor)
            BitmapHoja.SetPixel(x + 1, y + 2, myColor)
            BitmapHoja.SetPixel(x + 2, y + 2, myColor)

            BitmapHoja.SetPixel(x - 3, y + 1, myColor)
            BitmapHoja.SetPixel(x - 2, y + 1, myColor)
            BitmapHoja.SetPixel(x - 1, y + 1, myColor)
            BitmapHoja.SetPixel(x, y + 1, myColor)
            BitmapHoja.SetPixel(x + 1, y + 1, myColor)
            BitmapHoja.SetPixel(x + 2, y + 1, myColor)
            BitmapHoja.SetPixel(x + 3, y + 1, myColor)

            BitmapHoja.SetPixel(x - 3, y, myColor)
            BitmapHoja.SetPixel(x - 2, y, myColor)
            BitmapHoja.SetPixel(x - 1, y, myColor)
            BitmapHoja.SetPixel(x, y, myColor)
            BitmapHoja.SetPixel(x + 1, y, myColor)
            BitmapHoja.SetPixel(x + 2, y, myColor)
            BitmapHoja.SetPixel(x + 3, y, myColor)

            BitmapHoja.SetPixel(x - 3, y - 1, myColor)
            BitmapHoja.SetPixel(x - 2, y - 1, myColor)
            BitmapHoja.SetPixel(x - 1, y - 1, myColor)
            BitmapHoja.SetPixel(x, y - 1, myColor)
            BitmapHoja.SetPixel(x + 1, y - 1, myColor)
            BitmapHoja.SetPixel(x + 2, y - 1, myColor)
            BitmapHoja.SetPixel(x + 3, y - 1, myColor)

            BitmapHoja.SetPixel(x - 2, y - 2, myColor)
            BitmapHoja.SetPixel(x - 1, y - 2, myColor)
            BitmapHoja.SetPixel(x, y - 2, myColor)
            BitmapHoja.SetPixel(x + 1, y - 2, myColor)
            BitmapHoja.SetPixel(x + 2, y - 2, myColor)

            BitmapHoja.SetPixel(x - 1, y - 3, myColor)
            BitmapHoja.SetPixel(x, y - 3, myColor)
            BitmapHoja.SetPixel(x + 1, y - 3, myColor)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class

