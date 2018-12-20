<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedorData
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
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.txtApellido = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtId = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnGuardar
    '
    Me.btnGuardar.Location = New System.Drawing.Point(12, 55)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
    Me.btnGuardar.TabIndex = 0
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(12, 347)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(86, 26)
    Me.btnCancel.TabIndex = 1
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(105, 39)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Nombre"
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(108, 55)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(230, 20)
    Me.txtNombre.TabIndex = 3
    '
    'txtApellido
    '
    Me.txtApellido.Location = New System.Drawing.Point(364, 55)
    Me.txtApellido.Name = "txtApellido"
    Me.txtApellido.Size = New System.Drawing.Size(230, 20)
    Me.txtApellido.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(361, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Apellido"
    '
    'txtId
    '
    Me.txtId.Location = New System.Drawing.Point(108, 108)
    Me.txtId.Name = "txtId"
    Me.txtId.Size = New System.Drawing.Size(230, 20)
    Me.txtId.TabIndex = 7
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(105, 92)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(26, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "DNI"
    '
    'frmVendedorData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(743, 385)
    Me.Controls.Add(Me.txtId)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtApellido)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnGuardar)
    Me.Name = "frmVendedorData"
    Me.Text = "vendedorData"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtApellido As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtId As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
