<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDDHipotecario
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
    Me.lblCodigo5 = New System.Windows.Forms.Label()
    Me.lblCodigo4 = New System.Windows.Forms.Label()
    Me.lblCodigo3 = New System.Windows.Forms.Label()
    Me.lblCodigo2 = New System.Windows.Forms.Label()
    Me.lblCodigo1 = New System.Windows.Forms.Label()
    Me.UctxtCBU = New main.ucTextBoxNumerico()
    Me.uctxtCodigoBanco = New main.ucTextBoxNumerico()
    Me.uctxtSucursal = New main.ucTextBoxNumerico()
    Me.uctxtCuenta = New main.ucTextBoxNumerico()
    Me.uctxtTipoCuenta = New main.ucTextBoxNumerico()
    Me.SuspendLayout()
    '
    'lblCodigo5
    '
    Me.lblCodigo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo5.Location = New System.Drawing.Point(3, 122)
    Me.lblCodigo5.Name = "lblCodigo5"
    Me.lblCodigo5.Size = New System.Drawing.Size(106, 18)
    Me.lblCodigo5.TabIndex = 30
    Me.lblCodigo5.Text = "TIPO CUENTA"
    '
    'lblCodigo4
    '
    Me.lblCodigo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo4.Location = New System.Drawing.Point(3, 96)
    Me.lblCodigo4.Name = "lblCodigo4"
    Me.lblCodigo4.Size = New System.Drawing.Size(106, 14)
    Me.lblCodigo4.TabIndex = 28
    Me.lblCodigo4.Text = "CUENTA"
    '
    'lblCodigo3
    '
    Me.lblCodigo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo3.Location = New System.Drawing.Point(3, 66)
    Me.lblCodigo3.Name = "lblCodigo3"
    Me.lblCodigo3.Size = New System.Drawing.Size(106, 19)
    Me.lblCodigo3.TabIndex = 26
    Me.lblCodigo3.Text = "SUCURSAL"
    '
    'lblCodigo2
    '
    Me.lblCodigo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo2.Location = New System.Drawing.Point(3, 35)
    Me.lblCodigo2.Name = "lblCodigo2"
    Me.lblCodigo2.Size = New System.Drawing.Size(114, 20)
    Me.lblCodigo2.TabIndex = 24
    Me.lblCodigo2.Text = "CODIGO BANCO"
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
    'uctxtCodigoBanco
    '
    Me.uctxtCodigoBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtCodigoBanco.Limite = 22
    Me.uctxtCodigoBanco.Location = New System.Drawing.Point(125, 32)
    Me.uctxtCodigoBanco.Moneda = False
    Me.uctxtCodigoBanco.Name = "uctxtCodigoBanco"
    Me.uctxtCodigoBanco.Size = New System.Drawing.Size(244, 22)
    Me.uctxtCodigoBanco.TabIndex = 32
    Me.uctxtCodigoBanco.Text = "0"
    Me.uctxtCodigoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'uctxtSucursal
    '
    Me.uctxtSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtSucursal.Limite = 22
    Me.uctxtSucursal.Location = New System.Drawing.Point(125, 63)
    Me.uctxtSucursal.Moneda = False
    Me.uctxtSucursal.Name = "uctxtSucursal"
    Me.uctxtSucursal.Size = New System.Drawing.Size(244, 22)
    Me.uctxtSucursal.TabIndex = 33
    Me.uctxtSucursal.Text = "0"
    Me.uctxtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'uctxtCuenta
    '
    Me.uctxtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtCuenta.Limite = 22
    Me.uctxtCuenta.Location = New System.Drawing.Point(125, 93)
    Me.uctxtCuenta.Moneda = False
    Me.uctxtCuenta.Name = "uctxtCuenta"
    Me.uctxtCuenta.Size = New System.Drawing.Size(244, 22)
    Me.uctxtCuenta.TabIndex = 34
    Me.uctxtCuenta.Text = "0"
    Me.uctxtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'uctxtTipoCuenta
    '
    Me.uctxtTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.uctxtTipoCuenta.Limite = 22
    Me.uctxtTipoCuenta.Location = New System.Drawing.Point(125, 119)
    Me.uctxtTipoCuenta.Moneda = False
    Me.uctxtTipoCuenta.Name = "uctxtTipoCuenta"
    Me.uctxtTipoCuenta.Size = New System.Drawing.Size(244, 22)
    Me.uctxtTipoCuenta.TabIndex = 35
    Me.uctxtTipoCuenta.Text = "0"
    Me.uctxtTipoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ucDDHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.uctxtTipoCuenta)
    Me.Controls.Add(Me.uctxtCuenta)
    Me.Controls.Add(Me.uctxtSucursal)
    Me.Controls.Add(Me.uctxtCodigoBanco)
    Me.Controls.Add(Me.UctxtCBU)
    Me.Controls.Add(Me.lblCodigo5)
    Me.Controls.Add(Me.lblCodigo4)
    Me.Controls.Add(Me.lblCodigo3)
    Me.Controls.Add(Me.lblCodigo2)
    Me.Controls.Add(Me.lblCodigo1)
    Me.Name = "ucDDHipotecario"
    Me.Size = New System.Drawing.Size(375, 219)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCodigo5 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo4 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo3 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
  Friend WithEvents UctxtCBU As main.ucTextBoxNumerico
  Friend WithEvents uctxtCodigoBanco As main.ucTextBoxNumerico
  Friend WithEvents uctxtSucursal As main.ucTextBoxNumerico
  Friend WithEvents uctxtCuenta As main.ucTextBoxNumerico
  Friend WithEvents uctxtTipoCuenta As main.ucTextBoxNumerico

End Class
