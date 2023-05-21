<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTarjeta
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
    Me.lblCodigo3 = New System.Windows.Forms.Label()
    Me.lblCodigo2 = New System.Windows.Forms.Label()
    Me.lblCodigo1 = New System.Windows.Forms.Label()
    Me.UctxtNumTarjeta = New main.ucTextBoxNumerico()
    Me.uctxtCodSeguridad = New main.ucTextBoxNumerico()
    Me.uctxtFechaVto = New main.ucTextBoxNumerico()
    Me.SuspendLayout()
    '
    'lblCodigo3
    '
    Me.lblCodigo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo3.Location = New System.Drawing.Point(3, 66)
    Me.lblCodigo3.Name = "lblCodigo3"
    Me.lblCodigo3.Size = New System.Drawing.Size(106, 19)
    Me.lblCodigo3.TabIndex = 26
    Me.lblCodigo3.Text = "FECHA VTO"
    '
    'lblCodigo2
    '
    Me.lblCodigo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo2.Location = New System.Drawing.Point(3, 35)
    Me.lblCodigo2.Name = "lblCodigo2"
    Me.lblCodigo2.Size = New System.Drawing.Size(124, 20)
    Me.lblCodigo2.TabIndex = 24
    Me.lblCodigo2.Text = "COD SEGURIDAD"
    '
    'lblCodigo1
    '
    Me.lblCodigo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo1.Location = New System.Drawing.Point(3, 9)
    Me.lblCodigo1.Name = "lblCodigo1"
    Me.lblCodigo1.Size = New System.Drawing.Size(106, 19)
    Me.lblCodigo1.TabIndex = 22
    Me.lblCodigo1.Text = "NUM TARJETA"
    '
    'UctxtNumTarjeta
    '
    Me.UctxtNumTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UctxtNumTarjeta.Limite = 22
    Me.UctxtNumTarjeta.Location = New System.Drawing.Point(125, 6)
    Me.UctxtNumTarjeta.Moneda = False
    Me.UctxtNumTarjeta.Name = "UctxtNumTarjeta"
    Me.UctxtNumTarjeta.Size = New System.Drawing.Size(244, 22)
    Me.UctxtNumTarjeta.TabIndex = 31
    Me.UctxtNumTarjeta.Text = "0"
    Me.UctxtNumTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'uctxtCodSeguridad
    '
    Me.uctxtCodSeguridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtCodSeguridad.Limite = 22
    Me.uctxtCodSeguridad.Location = New System.Drawing.Point(125, 32)
    Me.uctxtCodSeguridad.Moneda = False
    Me.uctxtCodSeguridad.Name = "uctxtCodSeguridad"
    Me.uctxtCodSeguridad.Size = New System.Drawing.Size(244, 22)
    Me.uctxtCodSeguridad.TabIndex = 32
    Me.uctxtCodSeguridad.Text = "0"
    Me.uctxtCodSeguridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'uctxtFechaVto
    '
    Me.uctxtFechaVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtFechaVto.Limite = 22
    Me.uctxtFechaVto.Location = New System.Drawing.Point(125, 63)
    Me.uctxtFechaVto.Moneda = False
    Me.uctxtFechaVto.Name = "uctxtFechaVto"
    Me.uctxtFechaVto.Size = New System.Drawing.Size(244, 22)
    Me.uctxtFechaVto.TabIndex = 33
    Me.uctxtFechaVto.Text = "0"
    Me.uctxtFechaVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ucTarjeta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.uctxtFechaVto)
    Me.Controls.Add(Me.uctxtCodSeguridad)
    Me.Controls.Add(Me.UctxtNumTarjeta)
    Me.Controls.Add(Me.lblCodigo3)
    Me.Controls.Add(Me.lblCodigo2)
    Me.Controls.Add(Me.lblCodigo1)
    Me.Name = "ucTarjeta"
    Me.Size = New System.Drawing.Size(375, 219)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCodigo3 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
  Friend WithEvents UctxtNumTarjeta As main.ucTextBoxNumerico
  Friend WithEvents uctxtCodSeguridad As main.ucTextBoxNumerico
  Friend WithEvents uctxtFechaVto As main.ucTextBoxNumerico

End Class
