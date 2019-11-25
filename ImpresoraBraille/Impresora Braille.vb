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
            If BCL.Impresora_Conectada Then
                Imprimir()
            Else
                MsgBox("Por favor, conecte la impresora primero.", MsgBoxStyle.OkOnly, "Error en la impresión")
            End If
        Else
            MsgBox("Por favor, procese el documento primero.", MsgBoxStyle.OkOnly, "Error en la impresión")
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

    Private Sub StatusStripButton1_Click(sender As Object, e As EventArgs) Handles StatusStripButton1.Click
        DumpTiempos()
    End Sub

#Region "rutinas de impresion"

    Private Imprimiendo As Boolean = False
    Private TimeSpan_Impresion_Start As TimeSpan
    Private TimeSpan_Last_Line As TimeSpan
    Private DateTime_Impresion_Start As Date
    Private DateTime_Last_Line As Date
    Private TimeSpan_Restante As TimeSpan
    Dim tiemposDeLinea As List(Of TimeSpan)
    Dim eventMessage() As String =
    {
        "No hay hoja en la impresora",
        "Error random 1"
    }

    Private Sub DumpTiempos()
        Dim outTxt As String = ""
        For Each tl In tiemposDeLinea
            outTxt += tl.TotalMilliseconds.ToString + vbNewLine
        Next

        Dim SaveFileDialog1 As New SaveFileDialog With {
            .DefaultExt = "*.txt",
            .Filter = "Archivo de texto|*.txt",
            .CreatePrompt = True
        }
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Using outputFile As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                outputFile.Write(outTxt)
            End Using
        End If
    End Sub

    Private Sub Imprimir()
        If Imprimiendo = False Then
            TrabajoActual.listaHojas = ListaHojas

            TrabajoActual.hojaActual = 1
            TrabajoActual.Hojas = TrabajoActual.listaHojas.Count

            ToolStripProgressBar1.Minimum = 0

            TrabajoActual.LineaActual = 0
            ToolStripProgressBar1.Value = TrabajoActual.LineaActual

            TrabajoActual.LineasTotales = 0

            For Each hoja In TrabajoActual.listaHojas
                TrabajoActual.LineasTotales += hoja.ContarLineas()
            Next

            ToolStripProgressBar1.Maximum = TrabajoActual.LineasTotales

            BCL.SendHojasTotales(TrabajoActual.Hojas)
            Imprimiendo = True
            DateTime_Impresion_Start = Date.Now()
            DateTime_Last_Line = Date.Now()
            ActualizarTimeLabel()
            TimeLabel.Visible = True
            TimerImpresion.Enabled = True
            TimerImpresion.Start()
            tiemposDeLinea = New List(Of TimeSpan)
            Imprimir_handler()
        Else
            MsgBox("Ya está imprimiendo un documento.", MsgBoxStyle.OkOnly, "Error en la impresión")
        End If
    End Sub
    Private Sub Impresion_Terminada()
        TrabajoActual.LineaActual = 0
        ToolStripProgressBar1.Value = TrabajoActual.LineaActual
        MsgBox("Se termino la impresión")
        TimeLabel.Visible = False
        TimerImpresion.Enabled = False
        TimerImpresion.Stop()
        Imprimiendo = False
        tiemposDeLinea = New List(Of TimeSpan)
    End Sub
    Private Sub Cancelar_Impresion()
        TrabajoActual.hojaActual = 1

        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = TrabajoActual.Hojas * HOJA_LINEASxHOJA * 3

        TrabajoActual.LineaActual = 0
        ToolStripProgressBar1.Value = TrabajoActual.LineaActual
        Imprimiendo = False
        TimeLabel.Visible = False
        TimerImpresion.Enabled = False
        TimerImpresion.Stop()
        tiemposDeLinea = New List(Of TimeSpan)
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
        If (MsgBox(eventMessage(dato) + vbNewLine + "¿Desea reintentar la impresión?", MsgBoxStyle.RetryCancel, "Error en la impresión") = MsgBoxResult.Retry) Then
            BCL.SendHoja(TrabajoActual.listaHojas(TrabajoActual.hojaActual - 1))
        Else
            Cancelar_Impresion()
        End If
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
    Private Sub LineaTerminada() Handles BCL.linea_terminada
        TrabajoActual.LineaActual += 1
        ToolStripProgressBar1.Value = TrabajoActual.LineaActual

        TimeSpan_Last_Line = Date.Now().Subtract(DateTime_Last_Line)
        DateTime_Last_Line = Date.Now()
        tiemposDeLinea.Add(TimeSpan_Last_Line)

        'ya se actualizo TimeSpan_Last_Line con el ultimo tiempo de linea

        TimeSpan_Restante = New TimeSpan(0)

        For i As Integer = TrabajoActual.LineaActual To TrabajoActual.LineasTotales
            TimeSpan_Restante = TimeSpan_Restante.Add(TimeSpan_Last_Line)
        Next
    End Sub
    Private Sub TimerImpresion_Tick(sender As Object, e As EventArgs) Handles TimerImpresion.Tick
        ActualizarTimeLabel()
    End Sub
    Private Sub ActualizarTimeLabel()
        'actualizar TimeSpan
        Dim newDateTime As Date = Date.Now()
        TimeSpan_Impresion_Start = newDateTime.Subtract(DateTime_Impresion_Start)
        Dim porcentaje As Integer = (ToolStripProgressBar1.Value / ToolStripProgressBar1.Maximum) * 100
        TimeLabel.Text = porcentaje.ToString + "% - T. Transcurrido: " + TimeSpan_Impresion_Start.Minutes.ToString + "' " + TimeSpan_Impresion_Start.Seconds.ToString + """ - Restante: " + TimeSpan_Restante.Minutes.ToString + "' " + TimeSpan_Restante.Seconds.ToString + """"
    End Sub
#End Region
End Class