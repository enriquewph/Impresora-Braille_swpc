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
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RecortePorFinDePalabraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonVistaPrevia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonTraducir = New System.Windows.Forms.Button()
        Me.TabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IntegerTextBox1 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.ButtonRecargarPuertos = New System.Windows.Forms.Button()
        Me.ComboBoxPuertos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TrackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10)
        Me.LabelPaginas = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.TabSplitterContainer1.SuspendLayout()
        Me.TabSplitterPage1.SuspendLayout()
        Me.TabSplitterPage2.SuspendLayout()
        Me.TabPageAdv2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabPageAdv3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IntegerTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator7, Me.ToolStripButtonVistaPrevia, Me.ToolStripButton1})
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
        'ToolStripButtonVistaPrevia
        '
        Me.ToolStripButtonVistaPrevia.Image = Global.ImpresoraBraille.My.Resources.Resources.select_all_16x16
        Me.ToolStripButtonVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVistaPrevia.Name = "ToolStripButtonVistaPrevia"
        Me.ToolStripButtonVistaPrevia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonVistaPrevia.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButtonVistaPrevia.Text = "Vista Previa"
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.ToolStripLabel2, Me.ToolStripProgressBar1})
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(300, 22)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar1.ToolTipText = "Progreso"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bmp"
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.ActiveTabColor = System.Drawing.Color.RoyalBlue
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
        Me.TabControlAdv1.Margin = New System.Windows.Forms.Padding(0)
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
        Me.TabPageAdv2.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPageAdv2.Image = Global.ImpresoraBraille.My.Resources.Resources.braille
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 33)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(781, 376)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "Traducción"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RichTextBox2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(781, 376)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 36)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(775, 337)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonTraducir)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(781, 33)
        Me.FlowLayoutPanel2.TabIndex = 12
        '
        'ButtonTraducir
        '
        Me.ButtonTraducir.Image = Global.ImpresoraBraille.My.Resources.Resources._49
        Me.ButtonTraducir.Location = New System.Drawing.Point(0, 0)
        Me.ButtonTraducir.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonTraducir.Name = "ButtonTraducir"
        Me.ButtonTraducir.Size = New System.Drawing.Size(109, 31)
        Me.ButtonTraducir.TabIndex = 4
        Me.ButtonTraducir.Text = "  Traducir"
        Me.ButtonTraducir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTraducir.UseVisualStyleBackColor = True
        '
        'TabPageAdv3
        '
        Me.TabPageAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageAdv3.Controls.Add(Me.TableLayoutPanel1)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.9411!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0589!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(781, 376)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox5)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox7)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(508, 370)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(235, 104)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Opciones:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton5)
        Me.GroupBox6.Controls.Add(Me.RadioButton4)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(223, 79)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Nuevo renglón:"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(100, 30)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Fín de palabra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "próximo a borde"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Fijo, por ancho de hoja"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.ButtonEnviar)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 243)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Impresión:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IntegerTextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Páginas"
        '
        'IntegerTextBox1
        '
        Me.IntegerTextBox1.BeforeTouchSize = New System.Drawing.Size(46, 20)
        Me.IntegerTextBox1.IntegerValue = CType(1, Long)
        Me.IntegerTextBox1.Location = New System.Drawing.Point(168, 19)
        Me.IntegerTextBox1.Name = "IntegerTextBox1"
        Me.IntegerTextBox1.Size = New System.Drawing.Size(46, 20)
        Me.IntegerTextBox1.TabIndex = 1
        Me.IntegerTextBox1.Text = "1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copias:"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(5, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Páginas:"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Página Actual"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.Location = New System.Drawing.Point(6, 195)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(223, 42)
        Me.ButtonEnviar.TabIndex = 3
        Me.ButtonEnviar.Text = "Imprimir"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelEstado)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonConectar)
        Me.GroupBox1.Controls.Add(Me.ButtonRecargarPuertos)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPuertos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impresora"
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Location = New System.Drawing.Point(33, 47)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(77, 13)
        Me.LabelEstado.TabIndex = 4
        Me.LabelEstado.Text = "Desconectado"
        Me.LabelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.PictureBox1.Location = New System.Drawing.Point(9, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Image = Global.ImpresoraBraille.My.Resources.Resources._02
        Me.ButtonConectar.Location = New System.Drawing.Point(128, 42)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(86, 23)
        Me.ButtonConectar.TabIndex = 3
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'ButtonRecargarPuertos
        '
        Me.ButtonRecargarPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRecargarPuertos.Image = Global.ImpresoraBraille.My.Resources.Resources._25
        Me.ButtonRecargarPuertos.Location = New System.Drawing.Point(193, 18)
        Me.ButtonRecargarPuertos.Name = "ButtonRecargarPuertos"
        Me.ButtonRecargarPuertos.Size = New System.Drawing.Size(21, 21)
        Me.ButtonRecargarPuertos.TabIndex = 2
        Me.ButtonRecargarPuertos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonRecargarPuertos.UseVisualStyleBackColor = True
        '
        'ComboBoxPuertos
        '
        Me.ComboBoxPuertos.FormattingEnabled = True
        Me.ComboBoxPuertos.Location = New System.Drawing.Point(53, 18)
        Me.ComboBoxPuertos.Name = "ComboBoxPuertos"
        Me.ComboBoxPuertos.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxPuertos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Puerto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(517, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 370)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vista Previa:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PrintPreviewControl1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(255, 351)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.PrintPreviewControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(255, 306)
        Me.PrintPreviewControl1.TabIndex = 12
        Me.PrintPreviewControl1.UseAntiAlias = True
        Me.PrintPreviewControl1.Zoom = 0.25R
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TrackBarEx1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPaginas, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 306)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(255, 45)
        Me.TableLayoutPanel3.TabIndex = 13
        '
        'TrackBarEx1
        '
        Me.TrackBarEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarEx1.BackColor = System.Drawing.Color.Transparent
        Me.TrackBarEx1.BeforeTouchSize = New System.Drawing.Size(249, 20)
        Me.TrackBarEx1.Location = New System.Drawing.Point(3, 3)
        Me.TrackBarEx1.Name = "TrackBarEx1"
        Me.TrackBarEx1.Size = New System.Drawing.Size(249, 20)
        Me.TrackBarEx1.TabIndex = 16
        Me.TrackBarEx1.Text = "TrackBarEx1"
        Me.TrackBarEx1.TimerInterval = 100
        Me.TrackBarEx1.Transparent = True
        Me.TrackBarEx1.Value = 5
        '
        'LabelPaginas
        '
        Me.LabelPaginas.AutoSize = True
        Me.LabelPaginas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaginas.Location = New System.Drawing.Point(3, 22)
        Me.LabelPaginas.Name = "LabelPaginas"
        Me.LabelPaginas.Size = New System.Drawing.Size(249, 23)
        Me.LabelPaginas.TabIndex = 7
        Me.LabelPaginas.Text = "Página 1 de 1"
        Me.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(244, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(255, 98)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.RadioButton6)
        Me.GroupBox8.Controls.Add(Me.RadioButton7)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(243, 72)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Nuevo renglón:"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(216, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Fín de palabra próximo a recorte de hoja"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton7.TabIndex = 4
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Fijo, por ancho de hoja"
        Me.RadioButton7.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TabPageAdv3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.IntegerTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents LabelEst As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LabelPaginas As Label
    Friend WithEvents ToolStripButtonVistaPrevia As ToolStripButton
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents RecortePorFinDePalabraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents RichTextBoxVisor As RichTextBox
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabSplitterContainer1 As Syncfusion.Windows.Forms.Tools.TabSplitterContainer
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabSplitterPage1 As Syncfusion.Windows.Forms.Tools.TabSplitterPage
    Friend WithEvents TabSplitterPage2 As Syncfusion.Windows.Forms.Tools.TabSplitterPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TrackBarEx1 As Syncfusion.Windows.Forms.Tools.TrackBarEx
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IntegerTextBox1 As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LabelEstado As Label
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents ButtonRecargarPuertos As Button
    Friend WithEvents ComboBoxPuertos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ButtonTraducir As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
End Class
