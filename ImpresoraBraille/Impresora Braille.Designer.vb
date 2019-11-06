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
        Me.LabelEst = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxPuertos = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TabSplitterContainer1 = New Syncfusion.Windows.Forms.Tools.TabSplitterContainer()
        Me.TabSplitterPage1 = New Syncfusion.Windows.Forms.Tools.TabSplitterPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabSplitterPage2 = New Syncfusion.Windows.Forms.Tools.TabSplitterPage()
        Me.RichTextBoxVisor = New System.Windows.Forms.RichTextBox()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.LabelPaginas = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.ButtonTrackBarR = New System.Windows.Forms.Button()
        Me.ButtonTrackBarL = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelEstado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonRecargarPuertos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelPuerto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RecortePorFinDePalabraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButtonConectar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1ButtonTraducir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVistaPrevia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEnviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.TabSplitterContainer1.SuspendLayout()
        Me.TabSplitterPage1.SuspendLayout()
        Me.TabSplitterPage2.SuspendLayout()
        Me.TabPageAdv2.SuspendLayout()
        Me.TabPageAdv3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator7, Me.ToolStripButtonConectar, Me.ToolStripSeparator1, Me.ToolStrip1ButtonTraducir, Me.ToolStripSeparator6, Me.ToolStripButtonVistaPrevia, Me.ToolStripSeparator3, Me.ToolStripButtonEnviar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "Herramientas"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabelEstado, Me.ToolStripSeparator4, Me.ToolStripButtonRecargarPuertos, Me.ToolStripComboBoxPuertos, Me.ToolStripLabelPuerto, Me.ToolStripSeparator8, Me.ToolStripLabel2, Me.ToolStripProgressBar1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 436)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip2.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "Estado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBoxPuertos
        '
        Me.ToolStripComboBoxPuertos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBoxPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPuertos.Name = "ToolStripComboBoxPuertos"
        Me.ToolStripComboBoxPuertos.Size = New System.Drawing.Size(85, 25)
        Me.ToolStripComboBoxPuertos.ToolTipText = "Puerto de la impresora"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(350, 22)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar1.ToolTipText = "Progreso"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bmp"
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(784, 411)
        Me.TabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty
        Me.TabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty
        Me.TabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty
        Me.TabControlAdv1.CloseTabOnMiddleClick = False
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv3)
        Me.TabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark
        Me.TabControlAdv1.ShowSeparator = False
        Me.TabControlAdv1.Size = New System.Drawing.Size(784, 411)
        Me.TabControlAdv1.TabIndex = 16
        Me.TabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful)
        Me.TabControlAdv1.ThemeName = "TabRendererOffice2016Colorful"
        Me.TabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = Nothing
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageAdv1.Controls.Add(Me.TabSplitterContainer1)
        Me.TabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPageAdv1.Image = Global.ImpresoraBraille.My.Resources.Resources.left_align
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabPageAdv1.Location = New System.Drawing.Point(1, 33)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(781, 376)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = " Editor de texto"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'TabSplitterContainer1
        '
        Me.TabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSplitterContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TabSplitterContainer1.Name = "TabSplitterContainer1"
        Me.TabSplitterContainer1.PrimaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.TabSplitterPage1})
        Me.TabSplitterContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabSplitterContainer1.SecondaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.TabSplitterPage2})
        Me.TabSplitterContainer1.Size = New System.Drawing.Size(781, 376)
        Me.TabSplitterContainer1.SplitterBackColor = System.Drawing.Color.White
        Me.TabSplitterContainer1.SplitterPosition = 188
        Me.TabSplitterContainer1.Style = Syncfusion.Windows.Forms.Tools.TabSplitterContainerStyle.Office2016Colorful
        Me.TabSplitterContainer1.TabIndex = 0
        Me.TabSplitterContainer1.Text = "Texto normal"
        Me.TabSplitterContainer1.ThemeName = "Office2016Colorful"
        '
        'TabSplitterPage1
        '
        Me.TabSplitterPage1.AutoScroll = True
        Me.TabSplitterPage1.Controls.Add(Me.RichTextBox1)
        Me.TabSplitterPage1.Hide = False
        Me.TabSplitterPage1.Image = Global.ImpresoraBraille.My.Resources.Resources.notepad_16x16
        Me.TabSplitterPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabSplitterPage1.Name = "TabSplitterPage1"
        Me.TabSplitterPage1.Size = New System.Drawing.Size(781, 188)
        Me.TabSplitterPage1.TabIndex = 1
        Me.TabSplitterPage1.Text = " Texto normal"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(781, 188)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabSplitterPage2
        '
        Me.TabSplitterPage2.AutoScroll = True
        Me.TabSplitterPage2.Controls.Add(Me.RichTextBoxVisor)
        Me.TabSplitterPage2.Hide = False
        Me.TabSplitterPage2.Image = Global.ImpresoraBraille.My.Resources.Resources._461
        Me.TabSplitterPage2.Location = New System.Drawing.Point(0, 208)
        Me.TabSplitterPage2.Name = "TabSplitterPage2"
        Me.TabSplitterPage2.Size = New System.Drawing.Size(781, 168)
        Me.TabSplitterPage2.TabIndex = 2
        Me.TabSplitterPage2.Text = "Traduccion en tiempo real"
        '
        'RichTextBoxVisor
        '
        Me.RichTextBoxVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxVisor.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxVisor.Name = "RichTextBoxVisor"
        Me.RichTextBoxVisor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxVisor.Size = New System.Drawing.Size(781, 168)
        Me.RichTextBoxVisor.TabIndex = 1
        Me.RichTextBoxVisor.Text = ""
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageAdv2.Controls.Add(Me.RichTextBox2)
        Me.TabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPageAdv2.Image = Global.ImpresoraBraille.My.Resources.Resources.braille
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 33)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(781, 376)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "Texto Traducido"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(781, 376)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'TabPageAdv3
        '
        Me.TabPageAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageAdv3.Controls.Add(Me.PrintPreviewControl1)
        Me.TabPageAdv3.Controls.Add(Me.LabelPaginas)
        Me.TabPageAdv3.Controls.Add(Me.RichTextBox3)
        Me.TabPageAdv3.Controls.Add(Me.ButtonTrackBarR)
        Me.TabPageAdv3.Controls.Add(Me.ButtonTrackBarL)
        Me.TabPageAdv3.Controls.Add(Me.TrackBar1)
        Me.TabPageAdv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPageAdv3.Image = Global.ImpresoraBraille.My.Resources.Resources.file
        Me.TabPageAdv3.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabPageAdv3.Location = New System.Drawing.Point(1, 33)
        Me.TabPageAdv3.Name = "TabPageAdv3"
        Me.TabPageAdv3.ShowCloseButton = True
        Me.TabPageAdv3.Size = New System.Drawing.Size(781, 376)
        Me.TabPageAdv3.TabIndex = 3
        Me.TabPageAdv3.Text = "Previsualización"
        Me.TabPageAdv3.ThemesEnabled = False
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(544, 8)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(227, 321)
        Me.PrintPreviewControl1.TabIndex = 12
        Me.PrintPreviewControl1.UseAntiAlias = True
        Me.PrintPreviewControl1.Zoom = 0.25R
        '
        'LabelPaginas
        '
        Me.LabelPaginas.AutoSize = True
        Me.LabelPaginas.Location = New System.Drawing.Point(621, 367)
        Me.LabelPaginas.Name = "LabelPaginas"
        Me.LabelPaginas.Size = New System.Drawing.Size(73, 13)
        Me.LabelPaginas.TabIndex = 7
        Me.LabelPaginas.Text = "Página 1 de 1"
        Me.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(11, 8)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(400, 372)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = ""
        Me.RichTextBox3.WordWrap = False
        '
        'ButtonTrackBarR
        '
        Me.ButtonTrackBarR.Location = New System.Drawing.Point(751, 335)
        Me.ButtonTrackBarR.Name = "ButtonTrackBarR"
        Me.ButtonTrackBarR.Size = New System.Drawing.Size(20, 30)
        Me.ButtonTrackBarR.TabIndex = 10
        Me.ButtonTrackBarR.Text = ">"
        Me.ButtonTrackBarR.UseVisualStyleBackColor = True
        '
        'ButtonTrackBarL
        '
        Me.ButtonTrackBarL.Location = New System.Drawing.Point(544, 335)
        Me.ButtonTrackBarL.Name = "ButtonTrackBarL"
        Me.ButtonTrackBarL.Size = New System.Drawing.Size(20, 30)
        Me.ButtonTrackBarL.TabIndex = 9
        Me.ButtonTrackBarL.Text = "<"
        Me.ButtonTrackBarL.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.Location = New System.Drawing.Point(570, 335)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(175, 45)
        Me.TrackBar1.TabIndex = 8
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel2.Text = "Progreso:"
        Me.ToolStripLabel2.ToolTipText = "Puerto de la impresora"
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
        'ToolStrip1ButtonTraducir
        '
        Me.ToolStrip1ButtonTraducir.Image = Global.ImpresoraBraille.My.Resources.Resources._49
        Me.ToolStrip1ButtonTraducir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip1ButtonTraducir.Name = "ToolStrip1ButtonTraducir"
        Me.ToolStrip1ButtonTraducir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1ButtonTraducir.Size = New System.Drawing.Size(70, 22)
        Me.ToolStrip1ButtonTraducir.Text = "Traducir"
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
        'ImpresoraBraille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelEst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "ImpresoraBraille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresora Braille"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabSplitterContainer1.ResumeLayout(False)
        Me.TabSplitterPage1.ResumeLayout(False)
        Me.TabSplitterPage2.ResumeLayout(False)
        Me.TabPageAdv2.ResumeLayout(False)
        Me.TabPageAdv3.ResumeLayout(False)
        Me.TabPageAdv3.PerformLayout()
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
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButtonEnviar As ToolStripButton
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents LabelPaginas As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ButtonTrackBarL As Button
    Friend WithEvents ButtonTrackBarR As Button
    Friend WithEvents ToolStripButtonVistaPrevia As ToolStripButton
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents RecortePorFinDePalabraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents RichTextBoxVisor As RichTextBox
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabSplitterContainer1 As Syncfusion.Windows.Forms.Tools.TabSplitterContainer
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabSplitterPage1 As Syncfusion.Windows.Forms.Tools.TabSplitterPage
    Friend WithEvents TabSplitterPage2 As Syncfusion.Windows.Forms.Tools.TabSplitterPage
End Class
