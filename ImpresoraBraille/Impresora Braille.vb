Public Class ImpresoraBraille
    'Invocacion de clases
    Dim TrabajoActual As New TrabajoActual_c
    Dim Hoja_Funciones As Hoja_Funciones_c
    Dim BCL As New BrailleComLib
    Dim Traductor As New TraductorBraille
    Dim ListaHojas As New List(Of Hoja_c)

    Dim Puerto_Impresora As String

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

#Region "Previsualizacion"
    Private Sub ToolStripButtonVistaPrevia_Click(sender As Object, e As EventArgs) Handles ToolStripButtonVistaPrevia.Click

    End Sub

    Private Sub ButtonTrackBarL_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarL.Click
        If TrackBar1.Value > 1 Then
            TrackBar1.Value = TrackBar1.Value - 1
        End If
    End Sub

    Private Sub ButtonTrackBarR_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarR.Click
        If (TrackBar1.Value < TrabajoActual.Hojas) Then

        End If
    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetSerialPortNames()
        CenterForm(Me)
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

    Private Sub CenterForm(ByRef form As Form)
        Dim screenSize As Size = My.Computer.Screen.Bounds.Size
        Dim formSize As Size = form.Size
        Dim newFormPos As New Point((screenSize.Width - form.Width) / 2, (screenSize.Height - form.Height) / 2)
        form.Location = newFormPos
    End Sub

    Private Sub ToolStripButtonVisorEnVivo_Click(sender As Object, e As EventArgs) Handles ToolStripButtonVisorEnVivo.Click
        Dim totalSize As New Size(Me.Size.Width + VisorEnVivo.Size.Width, Me.Size.Height)
        Dim newFormPos As New Point((My.Computer.Screen.Bounds.Size.Width - totalSize.Width) / 2, Me.Location.Y)
        Dim visorFormPos As New Point(newFormPos.X + Me.Size.Width, newFormPos.Y)

        If VisorEnVivo.Visible = False Then
            VisorEnVivo.Show()
            Me.Location = newFormPos
            VisorEnVivo.Location = visorFormPos
        Else
            VisorEnVivo.Hide()
            CenterForm(Me)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If VisorEnVivo.Visible Then
            VisorEnVivo.RichTextBoxVisor.Text = Traductor.TraducirTexto(RichTextBox1.Text)
        End If
    End Sub
End Class