<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Me.cmbTipoDeCuenta = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblCodigo1 = New System.Windows.Forms.Label()
    Me.txtCodigo1 = New System.Windows.Forms.TextBox()
    Me.txtCodigo2 = New System.Windows.Forms.TextBox()
    Me.lblCodigo2 = New System.Windows.Forms.Label()
    Me.txtCodigo3 = New System.Windows.Forms.TextBox()
    Me.lblCodigo3 = New System.Windows.Forms.Label()
    Me.txtCodigo4 = New System.Windows.Forms.TextBox()
    Me.lblCodigo4 = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.lblCliente = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmbTipoDeCuenta
    '
    Me.cmbTipoDeCuenta.FormattingEnabled = True
    Me.cmbTipoDeCuenta.Location = New System.Drawing.Point(83, 25)
    Me.cmbTipoDeCuenta.Name = "cmbTipoDeCuenta"
    Me.cmbTipoDeCuenta.Size = New System.Drawing.Size(174, 21)
    Me.cmbTipoDeCuenta.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(80, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(76, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "TipoDeCuenta"
    '
    'lblCodigo1
    '
    Me.lblCodigo1.AutoSize = True
    Me.lblCodigo1.Location = New System.Drawing.Point(80, 49)
    Me.lblCodigo1.Name = "lblCodigo1"
    Me.lblCodigo1.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo1.TabIndex = 2
    Me.lblCodigo1.Text = "Label2"
    '
    'txtCodigo1
    '
    Me.txtCodigo1.Location = New System.Drawing.Point(83, 66)
    Me.txtCodigo1.Name = "txtCodigo1"
    Me.txtCodigo1.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo1.TabIndex = 3
    '
    'txtCodigo2
    '
    Me.txtCodigo2.Location = New System.Drawing.Point(83, 106)
    Me.txtCodigo2.Name = "txtCodigo2"
    Me.txtCodigo2.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo2.TabIndex = 5
    '
    'lblCodigo2
    '
    Me.lblCodigo2.AutoSize = True
    Me.lblCodigo2.Location = New System.Drawing.Point(80, 89)
    Me.lblCodigo2.Name = "lblCodigo2"
    Me.lblCodigo2.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo2.TabIndex = 4
    Me.lblCodigo2.Text = "Label3"
    '
    'txtCodigo3
    '
    Me.txtCodigo3.Location = New System.Drawing.Point(83, 146)
    Me.txtCodigo3.Name = "txtCodigo3"
    Me.txtCodigo3.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo3.TabIndex = 7
    '
    'lblCodigo3
    '
    Me.lblCodigo3.AutoSize = True
    Me.lblCodigo3.Location = New System.Drawing.Point(80, 129)
    Me.lblCodigo3.Name = "lblCodigo3"
    Me.lblCodigo3.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo3.TabIndex = 6
    Me.lblCodigo3.Text = "Label4"
    '
    'txtCodigo4
    '
    Me.txtCodigo4.Location = New System.Drawing.Point(83, 186)
    Me.txtCodigo4.Name = "txtCodigo4"
    Me.txtCodigo4.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo4.TabIndex = 9
    '
    'lblCodigo4
    '
    Me.lblCodigo4.AutoSize = True
    Me.lblCodigo4.Location = New System.Drawing.Point(80, 169)
    Me.lblCodigo4.Name = "lblCodigo4"
    Me.lblCodigo4.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo4.TabIndex = 8
    Me.lblCodigo4.Text = "Label5"
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(44, 234)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 10
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnGuardar
    '
    Me.btnGuardar.Location = New System.Drawing.Point(368, 234)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
    Me.btnGuardar.TabIndex = 11
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = True
    '
    'lblCliente
    '
    Me.lblCliente.AutoSize = True
    Me.lblCliente.Location = New System.Drawing.Point(281, 25)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(39, 13)
    Me.lblCliente.TabIndex = 12
    Me.lblCliente.Text = "Label6"
    '
    'frmCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(680, 281)
    Me.Controls.Add(Me.lblCliente)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.txtCodigo4)
    Me.Controls.Add(Me.lblCodigo4)
    Me.Controls.Add(Me.txtCodigo3)
    Me.Controls.Add(Me.lblCodigo3)
    Me.Controls.Add(Me.txtCodigo2)
    Me.Controls.Add(Me.lblCodigo2)
    Me.Controls.Add(Me.txtCodigo1)
    Me.Controls.Add(Me.lblCodigo1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmbTipoDeCuenta)
    Me.Name = "frmCuenta"
    Me.Text = "frmCuenta"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmbTipoDeCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo1 As System.Windows.Forms.TextBox
  Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
  Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo3 As System.Windows.Forms.TextBox
  Friend WithEvents lblCodigo3 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo4 As System.Windows.Forms.TextBox
  Friend WithEvents lblCodigo4 As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents lblCliente As System.Windows.Forms.Label
End Class
