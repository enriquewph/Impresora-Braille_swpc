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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.LabelEst = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonConectar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelEstado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonRecargarPuertos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBoxPuertos = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabelPuerto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(581, 209)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(599, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Traducir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 246)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(581, 187)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonConectar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "Herramientas"
        '
        'ToolStripButtonConectar
        '
        Me.ToolStripButtonConectar.Image = Global.ImpresoraBraille.My.Resources.Resources._02
        Me.ToolStripButtonConectar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonConectar.Name = "ToolStripButtonConectar"
        Me.ToolStripButtonConectar.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButtonConectar.Text = "Conectar"
        Me.ToolStripButtonConectar.ToolTipText = "Conectarse / Desconectarse de la impresora"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabelEstado, Me.ToolStripSeparator4, Me.ToolStripButtonRecargarPuertos, Me.ToolStripComboBoxPuertos, Me.ToolStripLabelPuerto, Me.ToolStripLabel2, Me.ToolStripProgressBar1})
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
        Me.ToolStripComboBoxPuertos.Size = New System.Drawing.Size(75, 25)
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.Image = Global.ImpresoraBraille.My.Resources.Resources._011
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel2.Text = "Progreso:"
        Me.ToolStripLabel2.ToolTipText = "Progreso"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(300, 22)
        Me.ToolStripProgressBar1.ToolTipText = "Progreso"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(599, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Mostrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(599, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Enviar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ImpresoraBraille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelEst)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents LabelEst As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButtonRecargarPuertos As ToolStripButton
    Friend WithEvents ToolStripComboBoxPuertos As ToolStripComboBox
    Friend WithEvents ToolStripLabelEstado As ToolStripLabel
    Friend WithEvents ToolStripLabelPuerto As ToolStripLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolStripButtonConectar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
