<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCBU
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.lblCodigo1 = New System.Windows.Forms.Label()
    Me.UctxtCBU = New main.ucTextBoxNumerico()
    Me.SuspendLayout()
    '
    'lblCodigo1
    '
    Me.lblCodigo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo1.Location = New System.Drawing.Point(3, 9)
    Me.lblCodigo1.Name = "lblCodigo1"
    Me.lblCodigo1.Size = New System.Drawing.Size(106, 19)
    Me.lblCodigo1.TabIndex = 22
    Me.lblCodigo1.Text = "CBU"
    '
    'UctxtCBU
    '
    Me.UctxtCBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UctxtCBU.Limite = 22
    Me.UctxtCBU.Location = New System.Drawing.Point(125, 6)
    Me.UctxtCBU.Moneda = False
    Me.UctxtCBU.Name = "UctxtCBU"
    Me.UctxtCBU.Size = New System.Drawing.Size(244, 22)
    Me.UctxtCBU.TabIndex = 31
    Me.UctxtCBU.Text = "0"
    Me.UctxtCBU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ucCBU
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.UctxtCBU)
    Me.Controls.Add(Me.lblCodigo1)
    Me.Name = "ucCBU"
    Me.Size = New System.Drawing.Size(375, 219)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
  Friend WithEvents UctxtCBU As main.ucTextBoxNumerico

End Class
