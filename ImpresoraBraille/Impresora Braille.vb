Imports ImpresoraBraille

Public Class ImpresoraBraille
    Dim BCL As New BrailleComLib
    Dim Traductor As New TraductorBraille
    Dim Puerto_Impresora As String

    Dim ListaHojas As New List(Of Hoja_c)

#Region "Conexion y puerto serie"
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

    Private Sub ToolStripComboBoxPuertos_NoBlue(sender As Object, e As EventArgs) Handles ToolStripComboBoxPuertos.DropDownClosed
        ToolStripComboBoxPuertos.SelectionLength = 0
    End Sub

    Private Sub ToolStripComboBoxPuertos_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxPuertos.Click
        My.Settings.COM = ToolStripComboBoxPuertos.SelectedItem
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

    Private Sub SetSerialPortNames()
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
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetSerialPortNames()
    End Sub

    Private Sub ToolStripButtonEnviar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEnviar.Click
        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY) = 0
            Next
            BCL.arrayHoja_a_enviar(0, i_ejeY) = i_ejeY * 2
        Next

        'TransponerTextoABitArray(TextoAjustado)

        BCL.SendHojasTotales(1)
        BCL.SendHoja(1)
    End Sub

    Private Sub ToolStrip1ButtonTraducir_Click(sender As Object, e As EventArgs) Handles ToolStrip1ButtonTraducir.Click
        RichTextBox2.Clear()
        Dim TextoATraducir As String = RichTextBox1.Text

        Dim TextoTraducido As String = Traductor.TraducirTexto(TextoATraducir)
        'Dim TextoAjustado As String = Traductor.AjustarRenglones(TextoTraducido, 28)


        RichTextBox2.Text = TextoTraducido
    End Sub

    Private Sub ToolStripButtonVistaPrevia_Click(sender As Object, e As EventArgs) Handles ToolStripButtonVistaPrevia.Click

    End Sub

    Private Sub TransponerTextoABitArray(inputString As String, Hoja As Hoja_c)
        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰
        Dim Cord_X As Integer = 0
        Dim Cord_Y As Integer = 0

        For Each bit As Boolean In Hoja.BitMatrix
            bit = 0
        Next

        For char_index As Integer = 0 To inputString.Length() - 1
            MarcarPuntos(inputString.Chars(char_index), Cord_X, Cord_Y, Hoja)

            Cord_X = Cord_X + 2

            If (Cord_X > 52) Then
                Cord_X = 0
                Cord_Y = Cord_Y + 3
            End If
        Next
    End Sub

    Private Sub MarcarPuntos(inputChar As Char, x As Integer, y As Integer, Hoja As Hoja_c)
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
            Case "⠀"

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

        Hoja.BitMatrix(x, y) = Dot_TL
        Hoja.BitMatrix(x, y + 1) = Dot_ML
        Hoja.BitMatrix(x, y + 2) = Dot_BL

        Hoja.BitMatrix(x + 1, y) = Dot_TR
        Hoja.BitMatrix(x + 1, y + 1) = Dot_MR
        Hoja.BitMatrix(x + 1, y + 2) = Dot_BR

    End Sub


    Private Sub ButtonTrackBarL_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarL.Click
        If TrackBar1.Value > 1 Then
            TrackBar1.Value = TrackBar1.Value - 1
        End If
    End Sub

    Private Sub ButtonTrackBarR_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarR.Click

    End Sub
End Class

Class Hoja_c
    Public Texto As String
    Public BitMatrix(55, 71) As Boolean
    Public Numero As UInt16

    Public Sub New(texto As String, numero As UShort)
        Me.Texto = texto
        Me.BitMatrix = BitMatrix
        Me.Numero = numero
    End Sub
End Class