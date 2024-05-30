<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServicioVirtual
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
    Me.uctxtCVU = New main.ucTextBoxNumerico()
    Me.lblCVU = New System.Windows.Forms.Label()
    Me.lblAlias = New System.Windows.Forms.Label()
    Me.txtAlias = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'uctxtCVU
    '
    Me.uctxtCVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtCVU.Limite = 22
    Me.uctxtCVU.Location = New System.Drawing.Point(126, 36)
    Me.uctxtCVU.Moneda = False
    Me.uctxtCVU.Name = "uctxtCVU"
    Me.uctxtCVU.Size = New System.Drawing.Size(244, 22)
    Me.uctxtCVU.TabIndex = 33
    Me.uctxtCVU.Text = "0"
    Me.uctxtCVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblCVU
    '
    Me.lblCVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCVU.Location = New System.Drawing.Point(4, 39)
    Me.lblCVU.Name = "lblCVU"
    Me.lblCVU.Size = New System.Drawing.Size(106, 19)
    Me.lblCVU.TabIndex = 32
    Me.lblCVU.Text = "CVU"
    '
    'lblAlias
    '
    Me.lblAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlias.Location = New System.Drawing.Point(4, 10)
    Me.lblAlias.Name = "lblAlias"
    Me.lblAlias.Size = New System.Drawing.Size(106, 19)
    Me.lblAlias.TabIndex = 34
    Me.lblAlias.Text = "ALIAS"
    '
    'txtAlias
    '
    Me.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtAlias.Location = New System.Drawing.Point(126, 10)
    Me.txtAlias.Name = "txtAlias"
    Me.txtAlias.Size = New System.Drawing.Size(244, 20)
    Me.txtAlias.TabIndex = 35
    Me.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ucServicioVirtual
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtAlias)
    Me.Controls.Add(Me.lblAlias)
    Me.Controls.Add(Me.uctxtCVU)
    Me.Controls.Add(Me.lblCVU)
    Me.Name = "ucServicioVirtual"
    Me.Size = New System.Drawing.Size(375, 219)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents uctxtCVU As main.ucTextBoxNumerico
  Friend WithEvents lblCVU As System.Windows.Forms.Label
  Friend WithEvents lblAlias As System.Windows.Forms.Label
  Friend WithEvents txtAlias As System.Windows.Forms.TextBox

End Class
