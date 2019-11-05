<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImpresoraBraille
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpresoraBraille))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.LabelEst = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RecortePorFinDePalabraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonConectar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1ButtonTraducir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonVisorEnVivo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonVistaPrevia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonEnviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelEstado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonRecargarPuertos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBoxPuertos = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabelPuerto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.LabelPaginas = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ButtonTrackBarL = New System.Windows.Forms.Button()
        Me.ButtonTrackBarR = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(770, 375)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(770, 375)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'LabelEst
        '
        Me.LabelEst.AutoSize = True
        Me.LabelEst.Location = New System.Drawing.Point(663, 445)
        Me.LabelEst.Name = "LabelEst"
        Me.LabelEst.Size = New System.Drawing.Size(118, 13)
        Me.LabelEst.TabIndex = 12
        Me.LabelEst.Text = "Conectado en: COMXX"
        Me.LabelEst.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator7, Me.ToolStripButtonConectar, Me.ToolStripSeparator1, Me.ToolStrip1ButtonTraducir, Me.ToolStripSeparator6, Me.ToolStripButtonVisorEnVivo, Me.ToolStripSeparator5, Me.ToolStripButtonVistaPrevia, Me.ToolStripSeparator3, Me.ToolStripButtonEnviar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "Herramientas"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecortePorFinDePalabraToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.ImpresoraBraille.My.Resources.Resources._41
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripDropDownButton1.Text = "Opciones"
        '
        'RecortePorFinDePalabraToolStripMenuItem
        '
        Me.RecortePorFinDePalabraToolStripMenuItem.Name = "RecortePorFinDePalabraToolStripMenuItem"
        Me.RecortePorFinDePalabraToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RecortePorFinDePalabraToolStripMenuItem.Text = "Recorte por fin de palabra"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonConectar
        '
        Me.ToolStripButtonConectar.Image = Global.ImpresoraBraille.My.Resources.Resources._02
        Me.ToolStripButtonConectar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonConectar.Name = "ToolStripButtonConectar"
        Me.ToolStripButtonConectar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonConectar.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButtonConectar.Text = "Conectar"
        Me.ToolStripButtonConectar.ToolTipText = "Conectarse / Desconectarse de la impresora"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1ButtonTraducir
        '
        Me.ToolStrip1ButtonTraducir.Image = Global.ImpresoraBraille.My.Resources.Resources._49
        Me.ToolStrip1ButtonTraducir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip1ButtonTraducir.Name = "ToolStrip1ButtonTraducir"
        Me.ToolStrip1ButtonTraducir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1ButtonTraducir.Size = New System.Drawing.Size(70, 22)
        Me.ToolStrip1ButtonTraducir.Text = "Traducir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonVisorEnVivo
        '
        Me.ToolStripButtonVisorEnVivo.Image = Global.ImpresoraBraille.My.Resources.Resources._461
        Me.ToolStripButtonVisorEnVivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVisorEnVivo.Name = "ToolStripButtonVisorEnVivo"
        Me.ToolStripButtonVisorEnVivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonVisorEnVivo.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButtonVisorEnVivo.Text = "Visor en vivo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonVistaPrevia
        '
        Me.ToolStripButtonVistaPrevia.Image = Global.ImpresoraBraille.My.Resources.Resources.select_all_16x16
        Me.ToolStripButtonVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVistaPrevia.Name = "ToolStripButtonVistaPrevia"
        Me.ToolStripButtonVistaPrevia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonVistaPrevia.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButtonVistaPrevia.Text = "Vista Previa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonEnviar
        '
        Me.ToolStripButtonEnviar.Image = Global.ImpresoraBraille.My.Resources.Resources._12
        Me.ToolStripButtonEnviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEnviar.Name = "ToolStripButtonEnviar"
        Me.ToolStripButtonEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonEnviar.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButtonEnviar.Text = "Imprimir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.ImpresoraBraille.My.Resources.Resources._31
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButton1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton1.Text = "DEBUG"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabelEstado, Me.ToolStripSeparator4, Me.ToolStripButtonRecargarPuertos, Me.ToolStripComboBoxPuertos, Me.ToolStripLabelPuerto, Me.ToolStripProgressBar1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 436)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip2.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "Estado"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel1.Text = "Rev 1.0"
        Me.ToolStripLabel1.ToolTipText = "Revision 1.0 2019"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabelEstado
        '
        Me.ToolStripLabelEstado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabelEstado.AutoSize = False
        Me.ToolStripLabelEstado.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabelEstado.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.ToolStripLabelEstado.Name = "ToolStripLabelEstado"
        Me.ToolStripLabelEstado.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabelEstado.Text = "Desconectado"
        Me.ToolStripLabelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabelEstado.ToolTipText = "Estado de la impresora"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonRecargarPuertos
        '
        Me.ToolStripButtonRecargarPuertos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonRecargarPuertos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRecargarPuertos.Image = Global.ImpresoraBraille.My.Resources.Resources._25
        Me.ToolStripButtonRecargarPuertos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRecargarPuertos.Name = "ToolStripButtonRecargarPuertos"
        Me.ToolStripButtonRecargarPuertos.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRecargarPuertos.Text = "ToolStripButton1"
        Me.ToolStripButtonRecargarPuertos.ToolTipText = "Recargar puertos"
        '
        'ToolStripComboBoxPuertos
        '
        Me.ToolStripComboBoxPuertos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBoxPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPuertos.Name = "ToolStripComboBoxPuertos"
        Me.ToolStripComboBoxPuertos.Size = New System.Drawing.Size(85, 25)
        Me.ToolStripComboBoxPuertos.ToolTipText = "Puerto de la impresora"
        '
        'ToolStripLabelPuerto
        '
        Me.ToolStripLabelPuerto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabelPuerto.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabelPuerto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabelPuerto.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.ToolStripLabelPuerto.Name = "ToolStripLabelPuerto"
        Me.ToolStripLabelPuerto.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabelPuerto.Text = "Puerto:"
        Me.ToolStripLabelPuerto.ToolTipText = "Puerto de la impresora"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(450, 22)
        Me.ToolStripProgressBar1.ToolTipText = "Progreso"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bmp"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 407)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 381)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor de texto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 381)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editor de texto traducido"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PrintPreviewControl1)
        Me.TabPage3.Controls.Add(Me.LabelPaginas)
        Me.TabPage3.Controls.Add(Me.TrackBar1)
        Me.TabPage3.Controls.Add(Me.ButtonTrackBarL)
        Me.TabPage3.Controls.Add(Me.ButtonTrackBarR)
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(776, 381)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Previsualización"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(541, 3)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(227, 321)
        Me.PrintPreviewControl1.TabIndex = 12
        Me.PrintPreviewControl1.UseAntiAlias = True
        Me.PrintPreviewControl1.Zoom = 0.25R
        '
        'LabelPaginas
        '
        Me.LabelPaginas.AutoSize = True
        Me.LabelPaginas.Location = New System.Drawing.Point(618, 362)
        Me.LabelPaginas.Name = "LabelPaginas"
        Me.LabelPaginas.Size = New System.Drawing.Size(73, 13)
        Me.LabelPaginas.TabIndex = 7
        Me.LabelPaginas.Text = "Página 1 de 1"
        Me.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.Location = New System.Drawing.Point(567, 330)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(175, 45)
        Me.TrackBar1.TabIndex = 8
        '
        'ButtonTrackBarL
        '
        Me.ButtonTrackBarL.Location = New System.Drawing.Point(541, 330)
        Me.ButtonTrackBarL.Name = "ButtonTrackBarL"
        Me.ButtonTrackBarL.Size = New System.Drawing.Size(20, 30)
        Me.ButtonTrackBarL.TabIndex = 9
        Me.ButtonTrackBarL.Text = "<"
        Me.ButtonTrackBarL.UseVisualStyleBackColor = True
        '
        'ButtonTrackBarR
        '
        Me.ButtonTrackBarR.Location = New System.Drawing.Point(748, 330)
        Me.ButtonTrackBarR.Name = "ButtonTrackBarR"
        Me.ButtonTrackBarR.Size = New System.Drawing.Size(20, 30)
        Me.ButtonTrackBarR.TabIndex = 10
        Me.ButtonTrackBarR.Text = ">"
        Me.ButtonTrackBarR.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(532, 375)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = ""
        Me.RichTextBox3.WordWrap = False
        '
        'ImpresoraBraille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelEst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "ImpresoraBraille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresora Braille"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents LabelEst As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButtonRecargarPuertos As ToolStripButton
    Friend WithEvents ToolStripComboBoxPuertos As ToolStripComboBox
    Friend WithEvents ToolStripLabelEstado As ToolStripLabel
    Friend WithEvents ToolStripLabelPuerto As ToolStripLabel
    Friend WithEvents ToolStripButtonConectar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStrip1ButtonTraducir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButtonEnviar As ToolStripButton
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents LabelPaginas As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ButtonTrackBarL As Button
    Friend WithEvents ButtonTrackBarR As Button
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButtonVistaPrevia As ToolStripButton
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButtonVisorEnVivo As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents RecortePorFinDePalabraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
