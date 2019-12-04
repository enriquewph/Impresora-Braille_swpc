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
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ButtonTraducir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxTraductor = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxTeclas = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ButtonGuardarPDF = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNL_Palabra = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNL_Fijo = New System.Windows.Forms.RadioButton()
        Me.ButtonProcesar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCopias = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.TextBoxPaginas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonPag_Custom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPag_Actual = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPag_Todo = New System.Windows.Forms.RadioButton()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.ButtonRecargarPuertos = New System.Windows.Forms.Button()
        Me.ComboBoxPuertos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TrackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10)
        Me.LabelPaginas = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelRevision = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TimeLabel = New Syncfusion.Windows.Forms.Tools.StatusStripLabel()
        Me.StatusStripButton1 = New Syncfusion.Windows.Forms.Tools.StatusStripButton()
        Me.TimerImpresion = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.TabSplitterContainer1.SuspendLayout()
        Me.TabSplitterPage1.SuspendLayout()
        Me.TabSplitterPage2.SuspendLayout()
        Me.TabPageAdv2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPageAdv3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TextBoxCopias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(1045, 541)
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
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdv1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark
        Me.TabControlAdv1.ShowSeparator = False
        Me.TabControlAdv1.Size = New System.Drawing.Size(1045, 541)
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
        Me.TabPageAdv1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(1042, 505)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = " Editor de texto"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'TabSplitterContainer1
        '
        Me.TabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSplitterContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TabSplitterContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabSplitterContainer1.Name = "TabSplitterContainer1"
        Me.TabSplitterContainer1.PrimaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.TabSplitterPage1})
        Me.TabSplitterContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabSplitterContainer1.SecondaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.TabSplitterPage2})
        Me.TabSplitterContainer1.Size = New System.Drawing.Size(1042, 505)
        Me.TabSplitterContainer1.SplitterBackColor = System.Drawing.Color.White
        Me.TabSplitterContainer1.SplitterPosition = 253
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
        Me.TabSplitterPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabSplitterPage1.Name = "TabSplitterPage1"
        Me.TabSplitterPage1.Size = New System.Drawing.Size(1042, 253)
        Me.TabSplitterPage1.TabIndex = 1
        Me.TabSplitterPage1.Text = " Texto normal"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(1042, 253)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabSplitterPage2
        '
        Me.TabSplitterPage2.AutoScroll = True
        Me.TabSplitterPage2.Controls.Add(Me.RichTextBoxVisor)
        Me.TabSplitterPage2.Hide = False
        Me.TabSplitterPage2.Image = Global.ImpresoraBraille.My.Resources.Resources._461
        Me.TabSplitterPage2.Location = New System.Drawing.Point(0, 274)
        Me.TabSplitterPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabSplitterPage2.Name = "TabSplitterPage2"
        Me.TabSplitterPage2.Size = New System.Drawing.Size(1042, 231)
        Me.TabSplitterPage2.TabIndex = 2
        Me.TabSplitterPage2.Text = "Traduccion en tiempo real"
        '
        'RichTextBoxVisor
        '
        Me.RichTextBoxVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxVisor.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxVisor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBoxVisor.Name = "RichTextBoxVisor"
        Me.RichTextBoxVisor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxVisor.Size = New System.Drawing.Size(1042, 231)
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
        Me.TabPageAdv2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(1042, 505)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "Traducción"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RichTextBox2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1042, 505)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(4, 35)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(1034, 466)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonTraducir, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ComboBoxTraductor, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ComboBoxTeclas})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1042, 28)
        Me.ToolStrip3.TabIndex = 12
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ButtonTraducir
        '
        Me.ButtonTraducir.ForeColor = System.Drawing.Color.White
        Me.ButtonTraducir.Image = Global.ImpresoraBraille.My.Resources.Resources._49
        Me.ButtonTraducir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonTraducir.Name = "ButtonTraducir"
        Me.ButtonTraducir.Size = New System.Drawing.Size(94, 25)
        Me.ButtonTraducir.Text = "  Traducir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.ImpresoraBraille.My.Resources.Resources._431
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(139, 25)
        Me.ToolStripButton1.Text = "  Visor de atajos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripLabel1.Text = "Traductor:"
        '
        'ComboBoxTraductor
        '
        Me.ComboBoxTraductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTraductor.Items.AddRange(New Object() {"Español - 1", "Español - 2"})
        Me.ComboBoxTraductor.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxTraductor.Name = "ComboBoxTraductor"
        Me.ComboBoxTraductor.Size = New System.Drawing.Size(159, 28)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(113, 25)
        Me.ToolStripLabel2.Text = "Mapa de teclas:"
        '
        'ComboBoxTeclas
        '
        Me.ComboBoxTeclas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTeclas.Items.AddRange(New Object() {"Por defecto"})
        Me.ComboBoxTeclas.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxTeclas.Name = "ComboBoxTeclas"
        Me.ComboBoxTeclas.Size = New System.Drawing.Size(159, 28)
        '
        'TabPageAdv3
        '
        Me.TabPageAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageAdv3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageAdv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPageAdv3.Image = Global.ImpresoraBraille.My.Resources.Resources.file
        Me.TabPageAdv3.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabPageAdv3.Location = New System.Drawing.Point(1, 33)
        Me.TabPageAdv3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageAdv3.Name = "TabPageAdv3"
        Me.TabPageAdv3.ShowCloseButton = True
        Me.TabPageAdv3.Size = New System.Drawing.Size(1042, 505)
        Me.TabPageAdv3.TabIndex = 3
        Me.TabPageAdv3.Text = "Previsualización"
        Me.TabPageAdv3.ThemesEnabled = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 667.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1042, 505)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox7)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ListBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(659, 497)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ButtonGuardarPDF)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.ButtonProcesar)
        Me.GroupBox7.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(313, 278)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Documento:"
        '
        'ButtonGuardarPDF
        '
        Me.ButtonGuardarPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarPDF.Image = Global.ImpresoraBraille.My.Resources.Resources._462
        Me.ButtonGuardarPDF.Location = New System.Drawing.Point(8, 218)
        Me.ButtonGuardarPDF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGuardarPDF.Name = "ButtonGuardarPDF"
        Me.ButtonGuardarPDF.Size = New System.Drawing.Size(297, 52)
        Me.ButtonGuardarPDF.TabIndex = 5
        Me.ButtonGuardarPDF.Text = "    Guardar en PDF"
        Me.ButtonGuardarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonGuardarPDF.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(296, 128)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Opciones:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButtonNL_Palabra)
        Me.GroupBox6.Controls.Add(Me.RadioButtonNL_Fijo)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 22)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(277, 97)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Nuevo renglón:"
        '
        'RadioButtonNL_Palabra
        '
        Me.RadioButtonNL_Palabra.AutoSize = True
        Me.RadioButtonNL_Palabra.Location = New System.Drawing.Point(8, 52)
        Me.RadioButtonNL_Palabra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonNL_Palabra.Name = "RadioButtonNL_Palabra"
        Me.RadioButtonNL_Palabra.Size = New System.Drawing.Size(131, 38)
        Me.RadioButtonNL_Palabra.TabIndex = 5
        Me.RadioButtonNL_Palabra.Text = "Fín de palabra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "próximo a borde"
        Me.RadioButtonNL_Palabra.UseVisualStyleBackColor = True
        '
        'RadioButtonNL_Fijo
        '
        Me.RadioButtonNL_Fijo.AutoSize = True
        Me.RadioButtonNL_Fijo.Checked = True
        Me.RadioButtonNL_Fijo.Location = New System.Drawing.Point(8, 23)
        Me.RadioButtonNL_Fijo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonNL_Fijo.Name = "RadioButtonNL_Fijo"
        Me.RadioButtonNL_Fijo.Size = New System.Drawing.Size(174, 21)
        Me.RadioButtonNL_Fijo.TabIndex = 4
        Me.RadioButtonNL_Fijo.TabStop = True
        Me.RadioButtonNL_Fijo.Text = "Fijo, por ancho de hoja"
        Me.RadioButtonNL_Fijo.UseVisualStyleBackColor = True
        '
        'ButtonProcesar
        '
        Me.ButtonProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProcesar.Image = Global.ImpresoraBraille.My.Resources.Resources.select_all_16x16
        Me.ButtonProcesar.Location = New System.Drawing.Point(8, 159)
        Me.ButtonProcesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonProcesar.Name = "ButtonProcesar"
        Me.ButtonProcesar.Size = New System.Drawing.Size(297, 52)
        Me.ButtonProcesar.TabIndex = 4
        Me.ButtonProcesar.Text = "  Procesar Documento"
        Me.ButtonProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonProcesar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.ButtonEnviar)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox4.Location = New System.Drawing.Point(325, 4)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(313, 298)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Impresión:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCopias)
        Me.GroupBox2.Controls.Add(Me.TextBoxPaginas)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioButtonPag_Custom)
        Me.GroupBox2.Controls.Add(Me.RadioButtonPag_Actual)
        Me.GroupBox2.Controls.Add(Me.RadioButtonPag_Todo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 117)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(297, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Páginas"
        '
        'TextBoxCopias
        '
        Me.TextBoxCopias.BeforeTouchSize = New System.Drawing.Size(60, 22)
        Me.TextBoxCopias.IntegerValue = CType(1, Long)
        Me.TextBoxCopias.Location = New System.Drawing.Point(224, 23)
        Me.TextBoxCopias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxCopias.MaxValue = CType(100, Long)
        Me.TextBoxCopias.MinValue = CType(1, Long)
        Me.TextBoxCopias.Name = "TextBoxCopias"
        Me.TextBoxCopias.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxCopias.TabIndex = 1
        Me.TextBoxCopias.Text = "1"
        '
        'TextBoxPaginas
        '
        Me.TextBoxPaginas.Location = New System.Drawing.Point(103, 79)
        Me.TextBoxPaginas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPaginas.Name = "TextBoxPaginas"
        Me.TextBoxPaginas.Size = New System.Drawing.Size(181, 22)
        Me.TextBoxPaginas.TabIndex = 3
        Me.TextBoxPaginas.Text = "1-3;5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copias:"
        '
        'RadioButtonPag_Custom
        '
        Me.RadioButtonPag_Custom.AutoSize = True
        Me.RadioButtonPag_Custom.Location = New System.Drawing.Point(7, 80)
        Me.RadioButtonPag_Custom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonPag_Custom.Name = "RadioButtonPag_Custom"
        Me.RadioButtonPag_Custom.Size = New System.Drawing.Size(84, 21)
        Me.RadioButtonPag_Custom.TabIndex = 2
        Me.RadioButtonPag_Custom.Text = "Páginas:"
        Me.RadioButtonPag_Custom.UseVisualStyleBackColor = True
        '
        'RadioButtonPag_Actual
        '
        Me.RadioButtonPag_Actual.AutoSize = True
        Me.RadioButtonPag_Actual.Location = New System.Drawing.Point(7, 52)
        Me.RadioButtonPag_Actual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonPag_Actual.Name = "RadioButtonPag_Actual"
        Me.RadioButtonPag_Actual.Size = New System.Drawing.Size(116, 21)
        Me.RadioButtonPag_Actual.TabIndex = 1
        Me.RadioButtonPag_Actual.Text = "Página Actual"
        Me.RadioButtonPag_Actual.UseVisualStyleBackColor = True
        '
        'RadioButtonPag_Todo
        '
        Me.RadioButtonPag_Todo.AutoSize = True
        Me.RadioButtonPag_Todo.Checked = True
        Me.RadioButtonPag_Todo.Location = New System.Drawing.Point(7, 23)
        Me.RadioButtonPag_Todo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonPag_Todo.Name = "RadioButtonPag_Todo"
        Me.RadioButtonPag_Todo.Size = New System.Drawing.Size(62, 21)
        Me.RadioButtonPag_Todo.TabIndex = 0
        Me.RadioButtonPag_Todo.TabStop = True
        Me.RadioButtonPag_Todo.Text = "Todo"
        Me.RadioButtonPag_Todo.UseVisualStyleBackColor = True
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.Image = Global.ImpresoraBraille.My.Resources.Resources._12
        Me.ButtonEnviar.Location = New System.Drawing.Point(8, 238)
        Me.ButtonEnviar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(233, 52)
        Me.ButtonEnviar.TabIndex = 3
        Me.ButtonEnviar.Text = "         Imprimir"
        Me.ButtonEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impresora"
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Location = New System.Drawing.Point(44, 58)
        Me.LabelEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(99, 17)
        Me.LabelEstado.TabIndex = 4
        Me.LabelEstado.Text = "Desconectado"
        Me.LabelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Image = Global.ImpresoraBraille.My.Resources.Resources._02
        Me.ButtonConectar.Location = New System.Drawing.Point(155, 52)
        Me.ButtonConectar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(131, 28)
        Me.ButtonConectar.TabIndex = 3
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'ButtonRecargarPuertos
        '
        Me.ButtonRecargarPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRecargarPuertos.Image = Global.ImpresoraBraille.My.Resources.Resources._25
        Me.ButtonRecargarPuertos.Location = New System.Drawing.Point(257, 22)
        Me.ButtonRecargarPuertos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRecargarPuertos.Name = "ButtonRecargarPuertos"
        Me.ButtonRecargarPuertos.Size = New System.Drawing.Size(28, 26)
        Me.ButtonRecargarPuertos.TabIndex = 2
        Me.ButtonRecargarPuertos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonRecargarPuertos.UseVisualStyleBackColor = True
        '
        'ComboBoxPuertos
        '
        Me.ComboBoxPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPuertos.FormattingEnabled = True
        Me.ComboBoxPuertos.Location = New System.Drawing.Point(71, 22)
        Me.ComboBoxPuertos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPuertos.Name = "ComboBoxPuertos"
        Me.ComboBoxPuertos.Size = New System.Drawing.Size(177, 24)
        Me.ComboBoxPuertos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Puerto:"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Image = Global.ImpresoraBraille.My.Resources.Resources._01
        Me.ButtonCancelar.Location = New System.Drawing.Point(249, 238)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(56, 52)
        Me.ButtonCancelar.TabIndex = 7
        Me.ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(325, 310)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(312, 164)
        Me.ListBox1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(671, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(367, 497)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(359, 474)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.PrintPreviewControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(359, 419)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 419)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(359, 55)
        Me.TableLayoutPanel3.TabIndex = 13
        '
        'TrackBarEx1
        '
        Me.TrackBarEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarEx1.BackColor = System.Drawing.Color.Transparent
        Me.TrackBarEx1.BeforeTouchSize = New System.Drawing.Size(351, 20)
        Me.TrackBarEx1.Location = New System.Drawing.Point(4, 4)
        Me.TrackBarEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TrackBarEx1.Name = "TrackBarEx1"
        Me.TrackBarEx1.Size = New System.Drawing.Size(351, 20)
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
        Me.LabelPaginas.Location = New System.Drawing.Point(4, 27)
        Me.LabelPaginas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPaginas.Name = "LabelPaginas"
        Me.LabelPaginas.Size = New System.Drawing.Size(351, 28)
        Me.LabelPaginas.TabIndex = 7
        Me.LabelPaginas.Text = "Página 1 de 1"
        Me.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControlAdv1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 541)
        Me.Panel1.TabIndex = 18
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelRevision, Me.ToolStripStatusLabel2, Me.ToolStripProgressBar1, Me.TimeLabel, Me.StatusStripButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1045, 26)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelRevision
        '
        Me.LabelRevision.Name = "LabelRevision"
        Me.LabelRevision.Size = New System.Drawing.Size(78, 21)
        Me.LabelRevision.Text = "Rev 1.0.0.0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(71, 21)
        Me.ToolStripStatusLabel2.Text = "Progreso:"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(400, 20)
        Me.ToolStripProgressBar1.Step = 1
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'TimeLabel
        '
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(319, 21)
        Me.TimeLabel.Text = "100% - T. Transcurrido: 2' 15' - Restante: 10' 30"""
        Me.TimeLabel.Visible = False
        '
        'StatusStripButton1
        '
        Me.StatusStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusStripButton1.Image = Global.ImpresoraBraille.My.Resources.Resources._31
        Me.StatusStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StatusStripButton1.Name = "StatusStripButton1"
        Me.StatusStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.StatusStripButton1.Text = "Debug"
        '
        'TimerImpresion
        '
        Me.TimerImpresion.Interval = 500
        '
        'ImpresoraBraille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1061, 603)
        Me.Name = "ImpresoraBraille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresora Braille"
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabSplitterContainer1.ResumeLayout(False)
        Me.TabSplitterPage1.ResumeLayout(False)
        Me.TabSplitterPage2.ResumeLayout(False)
        Me.TabPageAdv2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabPageAdv3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TextBoxCopias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LabelPaginas As Label
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
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
    Friend WithEvents TextBoxCopias As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents TextBoxPaginas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonPag_Custom As RadioButton
    Friend WithEvents RadioButtonPag_Actual As RadioButton
    Friend WithEvents RadioButtonPag_Todo As RadioButton
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButtonNL_Palabra As RadioButton
    Friend WithEvents RadioButtonNL_Fijo As RadioButton
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ButtonTraducir As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelRevision As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ButtonProcesar As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBoxTeclas As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ComboBoxTraductor As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ButtonGuardarPDF As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TimeLabel As Syncfusion.Windows.Forms.Tools.StatusStripLabel
    Friend WithEvents TimerImpresion As Timer
    Friend WithEvents StatusStripButton1 As Syncfusion.Windows.Forms.Tools.StatusStripButton
    Friend WithEvents ButtonCancelar As Button
End Class
