Public Class ImpresoraBraille
    'Invocacion de clases

    Private Const HOJA_CARACTERESxRENGLON As Integer = 28
    Private Const HOJA_LINEASxHOJA As Integer = 24
    Dim TrabajoActual As New TrabajoActual_c
    Dim Hoja_Funciones As New Hoja_Funciones_c

    Dim WithEvents BCL As New BrailleComLib

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
    Private Sub RecortePorFinDePalabraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecortePorFinDePalabraToolStripMenuItem.Click
        My.Settings.REC_PALABRA = RecortePorFinDePalabraToolStripMenuItem.Checked
    End Sub

    Private Sub ToolStripButtonVistaPrevia_Click(sender As Object, e As EventArgs) Handles ToolStripButtonVistaPrevia.Click
        Try
            ProcesarVistaPrevia()
            ProcesarHojasGeneradas() ' luego sacar esto de aca ya que lagea el programa, dejarlo solamenta para imprimir.
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace, MsgBoxStyle.Exclamation, ex.Source)
        End Try

        TrackBar1.Minimum = 1
        TrackBar1.Maximum = TrabajoActual.Hojas
        TrackBar1.Value = 1
        LabelPaginas.Text = "Página " + TrackBar1.Value.ToString + " de " + TrackBar1.Maximum.ToString
    End Sub

    Private Sub ButtonTrackBarL_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarL.Click
        If TrackBar1.Value > TrackBar1.Minimum Then
            TrackBar1.Value = TrackBar1.Value - 1
        End If
        LabelPaginas.Text = "Página " + TrackBar1.Value.ToString + " de " + TrackBar1.Maximum.ToString
        RichTextBox3.Text = ListaHojas(TrackBar1.Value - 1).Texto
    End Sub

    Private Sub ButtonTrackBarR_Click(sender As Object, e As EventArgs) Handles ButtonTrackBarR.Click
        If (TrackBar1.Value < TrackBar1.Maximum) Then
            TrackBar1.Value = TrackBar1.Value + 1
        End If
        LabelPaginas.Text = "Página " + TrackBar1.Value.ToString + " de " + TrackBar1.Maximum.ToString
        RichTextBox3.Text = ListaHojas(TrackBar1.Value - 1).Texto
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        LabelPaginas.Text = "Página " + TrackBar1.Value.ToString + " de " + TrackBar1.Maximum.ToString
        RichTextBox3.Text = ListaHojas(TrackBar1.Value - 1).Texto
    End Sub

    Private Sub ProcesarVistaPrevia()
        RichTextBox3.Clear()
        TrackBar1.Value = 1
        LabelPaginas.Text = "Página " + TrackBar1.Value.ToString + " de " + TrackBar1.Maximum.ToString

        Dim TextoTraducido As String = RichTextBox2.Text
        'implementar corte x fin de palabra.
        Dim TextoRecortado As String = Traductor.AjustarRenglones(TextoTraducido, HOJA_CARACTERESxRENGLON)

        Dim TextoDividido As String() = TextoRecortado.Split(vbLf)

        Dim Renglones_Cantidad As Integer = TextoDividido.Length

        TrabajoActual.Hojas = Math.Ceiling(Renglones_Cantidad / HOJA_LINEASxHOJA)

        ListaHojas.Clear()

        If TrabajoActual.Hojas = 1 Then
            Dim hoja As New Hoja_c(TextoRecortado, 1)
            ListaHojas.Add(hoja)
        Else
            Dim startLine As Integer = 0
            Dim endLine As Integer = HOJA_LINEASxHOJA - 1
            Dim TextoHoja As String

            For Hojas_Index As Integer = 1 To TrabajoActual.Hojas
                TextoHoja = ""

                If (endLine > TextoDividido.GetUpperBound(0)) Then
                    endLine = TextoDividido.GetUpperBound(0)
                End If

                For i As Integer = startLine To endLine
                    TextoHoja += TextoDividido(i)
                    If (i < endLine) Then
                        TextoHoja += vbLf
                    End If
                Next

                Dim Hoja As New Hoja_c(TextoHoja, Hojas_Index)
                ListaHojas.Add(Hoja)

                startLine = startLine + HOJA_LINEASxHOJA
                endLine = endLine + HOJA_LINEASxHOJA
            Next
        End If

        RichTextBox3.Text = ListaHojas(TrackBar1.Value - 1).Texto
    End Sub

    Private Sub ProcesarHojasGeneradas()
        For Each hoja In ListaHojas
            Hoja_Funciones.TransponerTextoABitArray(hoja)
        Next
    End Sub

    Private Sub DebugBitArray()
        Dim txt As String = ""
        For Each hoja In ListaHojas
            txt += "HOJA: " + hoja.Numero.ToString + vbLf
            Dim cuentaCaracteres As Integer = 1
            Dim cuentaRenglones As Integer = 1

            For y As Integer = hoja.BitMatrix.GetLowerBound(1) To hoja.BitMatrix.GetUpperBound(1)
                For x As Integer = hoja.BitMatrix.GetLowerBound(0) To hoja.BitMatrix.GetUpperBound(0)
                    If hoja.BitMatrix(x, y) Then
                        txt += "1"
                    Else
                        txt += "0"
                    End If
                    If (cuentaCaracteres = 2) Then
                        txt += " "
                        cuentaCaracteres = 0
                    End If
                    cuentaCaracteres = cuentaCaracteres + 1
                Next

                txt += vbLf
                If (cuentaRenglones = 3) Then
                    txt += vbLf
                    cuentaRenglones = 0
                End If
                cuentaRenglones = cuentaRenglones + 1
            Next
            txt += "-----------------------------------" + vbLf
        Next

        Dim SaveFileDialog1 As New SaveFileDialog With {
            .DefaultExt = "*.txt",
            .Filter = "Archivo de texto|*.txt",
            .CreatePrompt = True
        }
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Using outputFile As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                outputFile.Write(txt)
            End Using
        End If
    End Sub
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetSerialPortNames()
        CenterForm(Me)
        RecortePorFinDePalabraToolStripMenuItem.CheckOnClick = True
        RecortePorFinDePalabraToolStripMenuItem.Checked = My.Settings.REC_PALABRA
    End Sub

    Private Sub ToolStripButtonEnviar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEnviar.Click
        For i_ejeY As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(1) To BCL.arrayHoja_a_enviar.GetUpperBound(1)
            For i_ejeX As Integer = BCL.arrayHoja_a_enviar.GetLowerBound(0) To BCL.arrayHoja_a_enviar.GetUpperBound(0)
                BCL.arrayHoja_a_enviar(i_ejeX, i_ejeY) = 0
            Next
            BCL.arrayHoja_a_enviar(0, i_ejeY) = i_ejeY * 2
        Next

        BCL.SendHojasTotales(1)
        BCL.SendHoja(1)
    End Sub

    Private Sub ToolStrip1ButtonTraducir_Click(sender As Object, e As EventArgs) Handles ToolStrip1ButtonTraducir.Click
        RichTextBox2.Text = Traductor.TraducirTexto(RichTextBox1.Text)
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        DebugBitArray()
    End Sub

    Private Sub StatusUpdateEv(ByVal Args As BrailleComLib.StatusUpdateArgs) Handles BCL.StatusUpdate
        MsgBox("Evento:" + Args.IdEvento.ToString + " " + Args.Dato.ToString)
    End Sub
End Class