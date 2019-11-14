Imports System.Drawing.Printing
Public Class ImpresoraBraille
#Region "Invocacion de clases"
    Private Const HOJA_CARACTERESxRENGLON As Integer = 28
    Private Const HOJA_LINEASxHOJA As Integer = 24
    Public ListaHojas As New List(Of Hoja_c)
    Dim TrabajoActual As New TrabajoActual_c
    Dim Hoja_Funciones As New Hoja_Funciones_c
    Dim Traductor As New TraductorBraille
    Dim Preview As Preview_c
    Dim WithEvents BCL As New BrailleComLib(Me, TrabajoActual)
    Dim Puerto_Impresora As String
#End Region

#Region "Conexion y puerto serie"
    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        Puerto_Impresora = ComboBoxPuertos.SelectedItem
        If BCL.Impresora_Conectada = False Then
            Dim conexion As BrailleComLib.ConnectionResponse = BCL.Conectar_Impresora(Puerto_Impresora)

            If conexion.result = False Then
                MsgBox(conexion.message, MsgBoxStyle.Exclamation, "Error de conexion:")
            End If
        Else
            BCL.Desconectar_Impresora()
        End If


        ActualizarLabelsConectar()

        My.Settings.COM = ComboBoxPuertos.SelectedItem
    End Sub

    Private Sub ButtonRecargarPuertos_Click(sender As Object, e As EventArgs) Handles ButtonRecargarPuertos.Click
        SetSerialPortNames()
    End Sub

    Private Sub ComboBoxPuertos_NoBlue(sender As Object, e As EventArgs) Handles ComboBoxPuertos.LostFocus
        ComboBoxPuertos.SelectionLength = 0
    End Sub

    Private Sub ComboBoxPuertos_Click(sender As Object, e As EventArgs) Handles ComboBoxPuertos.Click
        My.Settings.COM = ComboBoxPuertos.SelectedItem
    End Sub

    Private Sub ActualizarLabelsConectar()
        If (BCL.Impresora_Conectada) Then
            ButtonConectar.Text = "Desconectar"
            ButtonConectar.Image = My.Resources.Resources._01

            LabelEstado.Text = "Conectado"
            PictureBox1.Image = My.Resources.Resources._021
        Else
            ButtonConectar.Text = "Conectar"
            ButtonConectar.Image = My.Resources.Resources._02
            LabelEstado.Text = "Desconectado"
            PictureBox1.Image = My.Resources.Resources._011
        End If
    End Sub

    Private Sub SetSerialPortNames()
        ' Show all available COM ports.

        Dim ComboBox As ComboBox = ComboBoxPuertos

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

    Private Sub ButtonProcesar_Click(sender As Object, e As EventArgs) Handles ButtonProcesar.Click
        Try
            ProcesarVistaPrevia()
            ProcesarHojasGeneradas() ' luego sacar esto de aca ya que lagea el programa, dejarlo solamenta para imprimir.
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace, MsgBoxStyle.Exclamation, ex.Source)
        End Try
        TrackBarEx1.Minimum = 1
        TrackBarEx1.Maximum = TrabajoActual.Hojas
        TrackBarEx1.Value = 1
        LabelPaginas.Text = "Página " + TrackBarEx1.Value.ToString + " de " + TrackBarEx1.Maximum.ToString


        Preview = New Preview_c(Me)
        PrintPreviewControl1.Document = Preview.PreviewDocument
        PrintPreviewControl1.StartPage = TrackBarEx1.Value - 1
        PrintPreviewControl1.AutoZoom = 1

        TrabajoActual.hojas_procesadas = True
    End Sub

    Private Sub TrackBarEx1_Click(sender As Object, e As EventArgs) Handles TrackBarEx1.Scroll
        LabelPaginas.Text = "Página " + TrackBarEx1.Value.ToString + " de " + TrackBarEx1.Maximum.ToString
        PrintPreviewControl1.StartPage = TrackBarEx1.Value - 1
    End Sub

    Private Sub ProcesarVistaPrevia()
        TrackBarEx1.Value = 1
        LabelPaginas.Text = "Página " + TrackBarEx1.Value.ToString + " de " + TrackBarEx1.Maximum.ToString

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
    End Sub

    Private Sub ProcesarHojasGeneradas()
        For Each hoja In ListaHojas
            Hoja_Funciones.TransponerTextoABitArray(hoja)
        Next
    End Sub

    Private Sub ProcesarVistaPrevia_Documento()

        Preview.Guardar()
        'PrintPreviewControl1.Document = Preview.Generar_Documento(ListaHojas)
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

#Region "Subrutinas varias"
    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        If TrabajoActual.hojas_procesadas Then
            Imprimir()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        SetSerialPortNames()
        CenterForm(Me)
        TrackBarEx1.Minimum = 1
        TrackBarEx1.Maximum = 1
        TrackBarEx1.Value = 1
        LabelPaginas.Text = "Página " + TrackBarEx1.Value.ToString + " de " + TrackBarEx1.Maximum.ToString
        ComboBoxTeclas.SelectedIndex = 0
        ComboBoxTraductor.SelectedIndex = 0

        LabelRevision.Text = "Rev " + My.Application.Info.Version.ToString
    End Sub

    Private Sub Form1SizeChanged() Handles Me.SizeChanged
        UI_UPDATE()
    End Sub

    Private Sub UI_UPDATE()
        LabelPaginas.Text = "Página " + TrackBarEx1.Value.ToString + " de " + TrackBarEx1.Maximum.ToString
        PrintPreviewControl1.StartPage = TrackBarEx1.Value - 1
    End Sub

    Private Sub ButtonTraducir_Click(sender As Object, e As EventArgs) Handles ButtonTraducir.Click
        RichTextBox2.Text = Traductor.TraducirTexto(RichTextBox1.Text)
    End Sub

    Private Sub CenterForm(ByRef form As Form)
        Dim screenSize As Size = My.Computer.Screen.Bounds.Size
        Dim formSize As Size = form.Size
        Dim newFormPos As New Point((screenSize.Width - form.Width) / 2, (screenSize.Height - form.Height) / 2)
        form.Location = newFormPos
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBoxVisor.Text = Traductor.TraducirTexto(RichTextBox1.Text)
    End Sub
#End Region

#Region "editor de texto traducido"
    Sub Form1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles RichTextBox2.KeyPress
        e.Handled = True
    End Sub
#End Region

#Region "rutinas de impresion"

    Private Sub Imprimir()
        TrabajoActual.listaHojas = ListaHojas

        TrabajoActual.hojaActual = 1
        TrabajoActual.Hojas = TrabajoActual.listaHojas.Count

        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = TrabajoActual.Hojas * HOJA_LINEASxHOJA * 3

        BCL.SendHojasTotales(TrabajoActual.Hojas)
        Imprimir_handler()
    End Sub

    Private Sub Impresion_Terminada()
        ToolStripProgressBar1.Value = 0
        MsgBox("Se termino la impresión")
    End Sub

    Private Sub Cancelar_Impresion()
        TrabajoActual.hojaActual = 1

        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = TrabajoActual.Hojas * HOJA_LINEASxHOJA * 3

        MsgBox("Hubo un error y se canceló la impresion.")
    End Sub

    Private Sub Imprimir_handler()
        If BCL.SendHoja(TrabajoActual.listaHojas(TrabajoActual.hojaActual - 1)) = False Then
            Cancelar_Impresion()
        End If
    End Sub

    Private Sub Impresion_ok() Handles BCL.impresion_ok
        If (TrabajoActual.hojaActual < TrabajoActual.Hojas) Then
            TrabajoActual.hojaActual += 1
            Imprimir_handler()
        Else
            Impresion_Terminada()
        End If
    End Sub

    Private Sub Impresion_fail(dato As Byte) Handles BCL.impresion_fail
        If (MsgBox("Codigo de error: " + dato.ToString + vbNewLine + "Desea reintentar?", MsgBoxStyle.RetryCancel, "Error en la impresión") = MsgBoxResult.Retry) Then
            BCL.SendHoja(TrabajoActual.listaHojas(TrabajoActual.hojaActual - 1))
        Else
            MsgBox("Se canceló la impresión.")
        End If
    End Sub

    Private Sub LineaTerminada() Handles BCL.linea_terminada
        ToolStripProgressBar1.PerformStep()
    End Sub

    Private Sub Printer_Shutdown() Handles BCL.shutdown
        MsgBox("Printer shutdown..")
    End Sub

    Private Sub TextBoxPaginas_keyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPaginas.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonGuardarPDF_Click(sender As Object, e As EventArgs) Handles ButtonGuardarPDF.Click
        If TrabajoActual.hojas_procesadas Then
            Preview.PreviewDocument.Print()
        End If
    End Sub
#End Region
End Class