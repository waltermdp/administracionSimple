<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
    Me.components = New System.ComponentModel.Container()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.txtApellido = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.bsinfoProductos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtID = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtProfesion = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.lblProvincia = New System.Windows.Forms.Label()
    Me.txtProvincia = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtCiudad = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtCP = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtCalle1 = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtNumero1 = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtCalle2 = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txtNumero2 = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.txtTelefono1 = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtTelefono2 = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.txtComentario = New System.Windows.Forms.TextBox()
    Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.dtFechaNac = New System.Windows.Forms.DateTimePicker()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.txtNumCliente = New System.Windows.Forms.TextBox()
    CType(Me.bsinfoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnGuardar
    '
    Me.btnGuardar.Location = New System.Drawing.Point(33, 54)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
    Me.btnGuardar.TabIndex = 0
    Me.btnGuardar.Text = "guardar"
    Me.btnGuardar.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(33, 83)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(172, 70)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(341, 20)
    Me.txtNombre.TabIndex = 2
    '
    'txtApellido
    '
    Me.txtApellido.Location = New System.Drawing.Point(530, 70)
    Me.txtApellido.Name = "txtApellido"
    Me.txtApellido.Size = New System.Drawing.Size(341, 20)
    Me.txtApellido.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(169, 54)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Nombre"
    '
    'bsinfoProductos
    '
    Me.bsinfoProductos.DataSource = GetType(manDB.clsInfoProducto)
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(527, 54)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 13)
    Me.Label2.TabIndex = 26
    Me.Label2.Text = "Apellido"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(169, 93)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(26, 13)
    Me.Label3.TabIndex = 28
    Me.Label3.Text = "DNI"
    '
    'txtID
    '
    Me.txtID.Location = New System.Drawing.Point(172, 109)
    Me.txtID.Name = "txtID"
    Me.txtID.Size = New System.Drawing.Size(341, 20)
    Me.txtID.TabIndex = 27
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(169, 171)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(51, 13)
    Me.Label4.TabIndex = 29
    Me.Label4.Text = "Profesion"
    '
    'txtProfesion
    '
    Me.txtProfesion.Location = New System.Drawing.Point(172, 187)
    Me.txtProfesion.Name = "txtProfesion"
    Me.txtProfesion.Size = New System.Drawing.Size(217, 20)
    Me.txtProfesion.TabIndex = 30
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(527, 93)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(32, 13)
    Me.Label5.TabIndex = 32
    Me.Label5.Text = "Email"
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(530, 109)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(341, 20)
    Me.txtEmail.TabIndex = 31
    '
    'lblProvincia
    '
    Me.lblProvincia.AutoSize = True
    Me.lblProvincia.Location = New System.Drawing.Point(169, 210)
    Me.lblProvincia.Name = "lblProvincia"
    Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
    Me.lblProvincia.TabIndex = 34
    Me.lblProvincia.Text = "Provincia"
    '
    'txtProvincia
    '
    Me.txtProvincia.Location = New System.Drawing.Point(172, 226)
    Me.txtProvincia.Name = "txtProvincia"
    Me.txtProvincia.Size = New System.Drawing.Size(271, 20)
    Me.txtProvincia.TabIndex = 33
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(446, 209)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 13)
    Me.Label6.TabIndex = 36
    Me.Label6.Text = "Ciudad"
    '
    'txtCiudad
    '
    Me.txtCiudad.Location = New System.Drawing.Point(449, 226)
    Me.txtCiudad.Name = "txtCiudad"
    Me.txtCiudad.Size = New System.Drawing.Size(257, 20)
    Me.txtCiudad.TabIndex = 35
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(709, 209)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(21, 13)
    Me.Label7.TabIndex = 38
    Me.Label7.Text = "CP"
    '
    'txtCP
    '
    Me.txtCP.Location = New System.Drawing.Point(712, 226)
    Me.txtCP.Name = "txtCP"
    Me.txtCP.Size = New System.Drawing.Size(159, 20)
    Me.txtCP.TabIndex = 37
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(169, 132)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(96, 13)
    Me.Label8.TabIndex = 40
    Me.Label8.Text = "Domicilio Particular"
    '
    'txtCalle1
    '
    Me.txtCalle1.Location = New System.Drawing.Point(172, 148)
    Me.txtCalle1.Name = "txtCalle1"
    Me.txtCalle1.Size = New System.Drawing.Size(248, 20)
    Me.txtCalle1.TabIndex = 39
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(423, 132)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(44, 13)
    Me.Label9.TabIndex = 42
    Me.Label9.Text = "Numero"
    '
    'txtNumero1
    '
    Me.txtNumero1.Location = New System.Drawing.Point(426, 148)
    Me.txtNumero1.Name = "txtNumero1"
    Me.txtNumero1.Size = New System.Drawing.Size(87, 20)
    Me.txtNumero1.TabIndex = 41
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(527, 132)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(87, 13)
    Me.Label10.TabIndex = 44
    Me.Label10.Text = "Domicilio Laboral"
    '
    'txtCalle2
    '
    Me.txtCalle2.Location = New System.Drawing.Point(530, 148)
    Me.txtCalle2.Name = "txtCalle2"
    Me.txtCalle2.Size = New System.Drawing.Size(248, 20)
    Me.txtCalle2.TabIndex = 43
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(781, 132)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(44, 13)
    Me.Label11.TabIndex = 46
    Me.Label11.Text = "Numero"
    '
    'txtNumero2
    '
    Me.txtNumero2.Location = New System.Drawing.Point(784, 148)
    Me.txtNumero2.Name = "txtNumero2"
    Me.txtNumero2.Size = New System.Drawing.Size(87, 20)
    Me.txtNumero2.TabIndex = 45
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(397, 170)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(58, 13)
    Me.Label12.TabIndex = 48
    Me.Label12.Text = "Telefono 1"
    '
    'txtTelefono1
    '
    Me.txtTelefono1.Location = New System.Drawing.Point(400, 186)
    Me.txtTelefono1.Name = "txtTelefono1"
    Me.txtTelefono1.Size = New System.Drawing.Size(214, 20)
    Me.txtTelefono1.TabIndex = 47
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(617, 170)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(58, 13)
    Me.Label13.TabIndex = 50
    Me.Label13.Text = "Telefono 2"
    '
    'txtTelefono2
    '
    Me.txtTelefono2.Location = New System.Drawing.Point(620, 186)
    Me.txtTelefono2.Name = "txtTelefono2"
    Me.txtTelefono2.Size = New System.Drawing.Size(251, 20)
    Me.txtTelefono2.TabIndex = 49
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(169, 290)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(60, 13)
    Me.Label14.TabIndex = 52
    Me.Label14.Text = "Comentario"
    '
    'txtComentario
    '
    Me.txtComentario.Location = New System.Drawing.Point(172, 306)
    Me.txtComentario.Multiline = True
    Me.txtComentario.Name = "txtComentario"
    Me.txtComentario.Size = New System.Drawing.Size(699, 72)
    Me.txtComentario.TabIndex = 51
    '
    'dtFechaIngreso
    '
    Me.dtFechaIngreso.Location = New System.Drawing.Point(172, 31)
    Me.dtFechaIngreso.Name = "dtFechaIngreso"
    Me.dtFechaIngreso.Size = New System.Drawing.Size(200, 20)
    Me.dtFechaIngreso.TabIndex = 53
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(169, 15)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(90, 13)
    Me.Label15.TabIndex = 54
    Me.Label15.Text = "Fecha de Ingreso"
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(169, 249)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(108, 13)
    Me.Label16.TabIndex = 55
    Me.Label16.Text = "Fecha de Nacimiento"
    '
    'dtFechaNac
    '
    Me.dtFechaNac.Location = New System.Drawing.Point(172, 265)
    Me.dtFechaNac.Name = "dtFechaNac"
    Me.dtFechaNac.Size = New System.Drawing.Size(200, 20)
    Me.dtFechaNac.TabIndex = 56
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(375, 248)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(64, 13)
    Me.Label17.TabIndex = 58
    Me.Label17.Text = "Num Cliente"
    '
    'txtNumCliente
    '
    Me.txtNumCliente.Location = New System.Drawing.Point(378, 265)
    Me.txtNumCliente.Name = "txtNumCliente"
    Me.txtNumCliente.Size = New System.Drawing.Size(159, 20)
    Me.txtNumCliente.TabIndex = 57
    '
    'frmCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.Label17)
    Me.Controls.Add(Me.txtNumCliente)
    Me.Controls.Add(Me.dtFechaNac)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.dtFechaIngreso)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.txtComentario)
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.txtTelefono2)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.txtTelefono1)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.txtNumero2)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.txtCalle2)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtNumero1)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtCalle1)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtCP)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtCiudad)
    Me.Controls.Add(Me.lblProvincia)
    Me.Controls.Add(Me.txtProvincia)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtEmail)
    Me.Controls.Add(Me.txtProfesion)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtID)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtApellido)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnGuardar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmCliente"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmCliente"
    CType(Me.bsinfoProductos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtApellido As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents bsinfoProductos As System.Windows.Forms.BindingSource
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtID As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtProfesion As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtEmail As System.Windows.Forms.TextBox
  Friend WithEvents lblProvincia As System.Windows.Forms.Label
  Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtCP As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtCalle1 As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtNumero1 As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtCalle2 As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txtNumero2 As System.Windows.Forms.TextBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txtComentario As System.Windows.Forms.TextBox
  Friend WithEvents dtFechaIngreso As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents dtFechaNac As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents txtNumCliente As System.Windows.Forms.TextBox
End Class
