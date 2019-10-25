<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisorEnVivo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBoxVisor = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBoxVisor
        '
        Me.RichTextBoxVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxVisor.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxVisor.Name = "RichTextBoxVisor"
        Me.RichTextBoxVisor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxVisor.Size = New System.Drawing.Size(534, 461)
        Me.RichTextBoxVisor.TabIndex = 0
        Me.RichTextBoxVisor.Text = ""
        '
        'VisorEnVivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 461)
        Me.Controls.Add(Me.RichTextBoxVisor)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 500)
        Me.MinimumSize = New System.Drawing.Size(550, 500)
        Me.Name = "VisorEnVivo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisorEnVivo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxVisor As RichTextBox
End Class
