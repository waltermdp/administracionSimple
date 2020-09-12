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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
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
    Me.Label17 = New System.Windows.Forms.Label()
    Me.txtNumCliente = New System.Windows.Forms.TextBox()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.chkUsarDNI = New System.Windows.Forms.CheckBox()
    CType(Me.bsinfoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(24, 51)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 61)
    Me.btnGuardar.TabIndex = 0
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(24, 132)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 61)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.Color.White
    Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.Location = New System.Drawing.Point(364, 203)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(341, 21)
    Me.txtNombre.TabIndex = 2
    '
    'txtApellido
    '
    Me.txtApellido.BackColor = System.Drawing.Color.White
    Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtApellido.Location = New System.Drawing.Point(722, 203)
    Me.txtApellido.Name = "txtApellido"
    Me.txtApellido.Size = New System.Drawing.Size(341, 21)
    Me.txtApellido.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.White
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(361, 187)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(52, 15)
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
    Me.Label2.BackColor = System.Drawing.Color.White
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(719, 187)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(51, 15)
    Me.Label2.TabIndex = 26
    Me.Label2.Text = "Apellido"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.White
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(361, 226)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(28, 15)
    Me.Label3.TabIndex = 28
    Me.Label3.Text = "DNI"
    '
    'txtID
    '
    Me.txtID.BackColor = System.Drawing.Color.White
    Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtID.Location = New System.Drawing.Point(364, 242)
    Me.txtID.Name = "txtID"
    Me.txtID.Size = New System.Drawing.Size(248, 21)
    Me.txtID.TabIndex = 27
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.White
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(361, 304)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(59, 15)
    Me.Label4.TabIndex = 29
    Me.Label4.Text = "Profesion"
    '
    'txtProfesion
    '
    Me.txtProfesion.BackColor = System.Drawing.Color.White
    Me.txtProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtProfesion.Location = New System.Drawing.Point(364, 320)
    Me.txtProfesion.Name = "txtProfesion"
    Me.txtProfesion.Size = New System.Drawing.Size(217, 21)
    Me.txtProfesion.TabIndex = 30
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.White
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(361, 382)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(39, 15)
    Me.Label5.TabIndex = 32
    Me.Label5.Text = "Email"
    '
    'txtEmail
    '
    Me.txtEmail.BackColor = System.Drawing.Color.White
    Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmail.Location = New System.Drawing.Point(364, 400)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(341, 21)
    Me.txtEmail.TabIndex = 31
    '
    'lblProvincia
    '
    Me.lblProvincia.AutoSize = True
    Me.lblProvincia.BackColor = System.Drawing.Color.White
    Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProvincia.Location = New System.Drawing.Point(361, 343)
    Me.lblProvincia.Name = "lblProvincia"
    Me.lblProvincia.Size = New System.Drawing.Size(57, 15)
    Me.lblProvincia.TabIndex = 34
    Me.lblProvincia.Text = "Provincia"
    '
    'txtProvincia
    '
    Me.txtProvincia.BackColor = System.Drawing.Color.White
    Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtProvincia.Location = New System.Drawing.Point(364, 359)
    Me.txtProvincia.Name = "txtProvincia"
    Me.txtProvincia.Size = New System.Drawing.Size(271, 21)
    Me.txtProvincia.TabIndex = 33
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.White
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(638, 342)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(46, 15)
    Me.Label6.TabIndex = 36
    Me.Label6.Text = "Ciudad"
    '
    'txtCiudad
    '
    Me.txtCiudad.BackColor = System.Drawing.Color.White
    Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCiudad.Location = New System.Drawing.Point(641, 359)
    Me.txtCiudad.Name = "txtCiudad"
    Me.txtCiudad.Size = New System.Drawing.Size(257, 21)
    Me.txtCiudad.TabIndex = 35
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.BackColor = System.Drawing.Color.White
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(901, 342)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(23, 15)
    Me.Label7.TabIndex = 38
    Me.Label7.Text = "CP"
    '
    'txtCP
    '
    Me.txtCP.BackColor = System.Drawing.Color.White
    Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCP.Location = New System.Drawing.Point(904, 359)
    Me.txtCP.Name = "txtCP"
    Me.txtCP.Size = New System.Drawing.Size(159, 21)
    Me.txtCP.TabIndex = 37
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.BackColor = System.Drawing.Color.White
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(361, 265)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(114, 15)
    Me.Label8.TabIndex = 40
    Me.Label8.Text = "Domicilio Particular"
    '
    'txtCalle1
    '
    Me.txtCalle1.BackColor = System.Drawing.Color.White
    Me.txtCalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCalle1.Location = New System.Drawing.Point(364, 281)
    Me.txtCalle1.Name = "txtCalle1"
    Me.txtCalle1.Size = New System.Drawing.Size(248, 21)
    Me.txtCalle1.TabIndex = 39
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.BackColor = System.Drawing.Color.White
    Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(615, 265)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(52, 15)
    Me.Label9.TabIndex = 42
    Me.Label9.Text = "Numero"
    '
    'txtNumero1
    '
    Me.txtNumero1.BackColor = System.Drawing.Color.White
    Me.txtNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumero1.Location = New System.Drawing.Point(618, 281)
    Me.txtNumero1.Name = "txtNumero1"
    Me.txtNumero1.Size = New System.Drawing.Size(87, 21)
    Me.txtNumero1.TabIndex = 41
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.BackColor = System.Drawing.Color.White
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(719, 265)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(104, 15)
    Me.Label10.TabIndex = 44
    Me.Label10.Text = "Domicilio Laboral"
    '
    'txtCalle2
    '
    Me.txtCalle2.BackColor = System.Drawing.Color.White
    Me.txtCalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCalle2.Location = New System.Drawing.Point(722, 281)
    Me.txtCalle2.Name = "txtCalle2"
    Me.txtCalle2.Size = New System.Drawing.Size(248, 21)
    Me.txtCalle2.TabIndex = 43
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.BackColor = System.Drawing.Color.White
    Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(977, 265)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(52, 15)
    Me.Label11.TabIndex = 46
    Me.Label11.Text = "Numero"
    '
    'txtNumero2
    '
    Me.txtNumero2.BackColor = System.Drawing.Color.White
    Me.txtNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumero2.Location = New System.Drawing.Point(980, 281)
    Me.txtNumero2.Name = "txtNumero2"
    Me.txtNumero2.Size = New System.Drawing.Size(83, 21)
    Me.txtNumero2.TabIndex = 45
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.BackColor = System.Drawing.Color.White
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(589, 303)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(65, 15)
    Me.Label12.TabIndex = 48
    Me.Label12.Text = "Telefono 1"
    '
    'txtTelefono1
    '
    Me.txtTelefono1.BackColor = System.Drawing.Color.White
    Me.txtTelefono1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelefono1.Location = New System.Drawing.Point(592, 319)
    Me.txtTelefono1.Name = "txtTelefono1"
    Me.txtTelefono1.Size = New System.Drawing.Size(214, 21)
    Me.txtTelefono1.TabIndex = 47
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.White
    Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.Location = New System.Drawing.Point(809, 303)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(65, 15)
    Me.Label13.TabIndex = 50
    Me.Label13.Text = "Telefono 2"
    '
    'txtTelefono2
    '
    Me.txtTelefono2.BackColor = System.Drawing.Color.White
    Me.txtTelefono2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelefono2.Location = New System.Drawing.Point(812, 319)
    Me.txtTelefono2.Name = "txtTelefono2"
    Me.txtTelefono2.Size = New System.Drawing.Size(251, 21)
    Me.txtTelefono2.TabIndex = 49
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.BackColor = System.Drawing.Color.White
    Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.Location = New System.Drawing.Point(361, 423)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(71, 15)
    Me.Label14.TabIndex = 52
    Me.Label14.Text = "Comentario"
    '
    'txtComentario
    '
    Me.txtComentario.BackColor = System.Drawing.Color.White
    Me.txtComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtComentario.Location = New System.Drawing.Point(364, 439)
    Me.txtComentario.Multiline = True
    Me.txtComentario.Name = "txtComentario"
    Me.txtComentario.Size = New System.Drawing.Size(699, 72)
    Me.txtComentario.TabIndex = 51
    '
    'dtFechaIngreso
    '
    Me.dtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtFechaIngreso.Location = New System.Drawing.Point(364, 164)
    Me.dtFechaIngreso.Name = "dtFechaIngreso"
    Me.dtFechaIngreso.Size = New System.Drawing.Size(200, 21)
    Me.dtFechaIngreso.TabIndex = 53
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.BackColor = System.Drawing.Color.White
    Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.Location = New System.Drawing.Point(361, 148)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(102, 15)
    Me.Label15.TabIndex = 54
    Me.Label15.Text = "Fecha de Ingreso"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.BackColor = System.Drawing.Color.White
    Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(831, 224)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(75, 15)
    Me.Label17.TabIndex = 58
    Me.Label17.Text = "Num Cliente"
    '
    'txtNumCliente
    '
    Me.txtNumCliente.BackColor = System.Drawing.Color.White
    Me.txtNumCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumCliente.Location = New System.Drawing.Point(834, 242)
    Me.txtNumCliente.Name = "txtNumCliente"
    Me.txtNumCliente.Size = New System.Drawing.Size(229, 21)
    Me.txtNumCliente.TabIndex = 57
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(588, 9)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(147, 20)
    Me.Label18.TabIndex = 59
    Me.Label18.Text = "Datos del Cliente"
    '
    'chkUsarDNI
    '
    Me.chkUsarDNI.AutoSize = True
    Me.chkUsarDNI.Checked = True
    Me.chkUsarDNI.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkUsarDNI.Location = New System.Drawing.Point(636, 242)
    Me.chkUsarDNI.Name = "chkUsarDNI"
    Me.chkUsarDNI.Size = New System.Drawing.Size(189, 17)
    Me.chkUsarDNI.TabIndex = 60
    Me.chkUsarDNI.Text = "Usar DNI Como Numero de cliente"
    Me.chkUsarDNI.UseVisualStyleBackColor = True
    '
    'frmCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.chkUsarDNI)
    Me.Controls.Add(Me.Label18)
    Me.Controls.Add(Me.Label17)
    Me.Controls.Add(Me.txtNumCliente)
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
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents txtNumCliente As System.Windows.Forms.TextBox
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents chkUsarDNI As System.Windows.Forms.CheckBox
End Class
