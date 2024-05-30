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
    Me.components = New System.ComponentModel.Container()
    Me.cmbTipoDeCuenta = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.lblCliente = New System.Windows.Forms.Label()
    Me.lstCuentas = New System.Windows.Forms.ListBox()
    Me.bsCuenta = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnSalirSinCambios = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.UcTarjeta1 = New main.ucTarjeta()
    Me.UcCBU1 = New main.ucCBU()
    Me.UcDDHipotecario1 = New main.ucDDHipotecario()
    Me.UcServicioVirtual1 = New main.ucServicioVirtual()
    CType(Me.bsCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmbTipoDeCuenta
    '
    Me.cmbTipoDeCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipoDeCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmbTipoDeCuenta.FormattingEnabled = True
    Me.cmbTipoDeCuenta.Location = New System.Drawing.Point(614, 36)
    Me.cmbTipoDeCuenta.Name = "cmbTipoDeCuenta"
    Me.cmbTipoDeCuenta.Size = New System.Drawing.Size(174, 24)
    Me.cmbTipoDeCuenta.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(410, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(170, 19)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Medio de pago"
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(10, 300)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 60)
    Me.btnVolver.TabIndex = 10
    Me.btnVolver.Text = "OK"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(10, 35)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 61)
    Me.btnGuardar.TabIndex = 11
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'lblCliente
    '
    Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCliente.Location = New System.Drawing.Point(141, 51)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(250, 18)
    Me.lblCliente.TabIndex = 12
    Me.lblCliente.Text = "Medios de pagos asociados al Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'lstCuentas
    '
    Me.lstCuentas.DataSource = Me.bsCuenta
    Me.lstCuentas.FormattingEnabled = True
    Me.lstCuentas.Location = New System.Drawing.Point(144, 72)
    Me.lstCuentas.Name = "lstCuentas"
    Me.lstCuentas.Size = New System.Drawing.Size(247, 212)
    Me.lstCuentas.TabIndex = 13
    '
    'bsCuenta
    '
    Me.bsCuenta.DataSource = GetType(manDB.clsInfoCuenta)
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderSize = 0
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(10, 36)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 60)
    Me.btnNuevo.TabIndex = 14
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(10, 105)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 60)
    Me.btnCancelar.TabIndex = 15
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnSalirSinCambios
    '
    Me.btnSalirSinCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSalirSinCambios.FlatAppearance.BorderSize = 0
    Me.btnSalirSinCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSalirSinCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSalirSinCambios.ForeColor = System.Drawing.Color.White
    Me.btnSalirSinCambios.Location = New System.Drawing.Point(281, 300)
    Me.btnSalirSinCambios.Name = "btnSalirSinCambios"
    Me.btnSalirSinCambios.Size = New System.Drawing.Size(110, 60)
    Me.btnSalirSinCambios.TabIndex = 16
    Me.btnSalirSinCambios.Text = "Cancelar"
    Me.btnSalirSinCambios.UseVisualStyleBackColor = False
    Me.btnSalirSinCambios.Visible = False
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditar.FlatAppearance.BorderSize = 0
    Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ForeColor = System.Drawing.Color.White
    Me.btnEditar.Location = New System.Drawing.Point(10, 175)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 60)
    Me.btnEditar.TabIndex = 17
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(0, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(810, 25)
    Me.Label2.TabIndex = 21
    Me.Label2.Text = "MEDIO DE PAGO"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'UcTarjeta1
    '
    Me.UcTarjeta1.Location = New System.Drawing.Point(413, 65)
    Me.UcTarjeta1.Name = "UcTarjeta1"
    Me.UcTarjeta1.Size = New System.Drawing.Size(375, 219)
    Me.UcTarjeta1.TabIndex = 20
    '
    'UcCBU1
    '
    Me.UcCBU1.Location = New System.Drawing.Point(413, 65)
    Me.UcCBU1.Name = "UcCBU1"
    Me.UcCBU1.Size = New System.Drawing.Size(375, 219)
    Me.UcCBU1.TabIndex = 19
    '
    'UcDDHipotecario1
    '
    Me.UcDDHipotecario1.Location = New System.Drawing.Point(413, 65)
    Me.UcDDHipotecario1.Name = "UcDDHipotecario1"
    Me.UcDDHipotecario1.Size = New System.Drawing.Size(375, 219)
    Me.UcDDHipotecario1.TabIndex = 18
    '
    'UcServicioVirtual1
    '
    Me.UcServicioVirtual1.Location = New System.Drawing.Point(413, 65)
    Me.UcServicioVirtual1.Name = "UcServicioVirtual1"
    Me.UcServicioVirtual1.Size = New System.Drawing.Size(375, 219)
    Me.UcServicioVirtual1.TabIndex = 22
    '
    'frmCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.BackgroundImage = Global.main.My.Resources.Resources.Fondo810x370
    Me.ClientSize = New System.Drawing.Size(810, 370)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.UcTarjeta1)
    Me.Controls.Add(Me.UcCBU1)
    Me.Controls.Add(Me.UcDDHipotecario1)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnSalirSinCambios)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.lstCuentas)
    Me.Controls.Add(Me.lblCliente)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmbTipoDeCuenta)
    Me.Controls.Add(Me.UcServicioVirtual1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmCuenta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmCuenta"
    CType(Me.bsCuenta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cmbTipoDeCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents lblCliente As System.Windows.Forms.Label
  Friend WithEvents lstCuentas As System.Windows.Forms.ListBox
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents bsCuenta As System.Windows.Forms.BindingSource
  Friend WithEvents btnSalirSinCambios As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents UcDDHipotecario1 As main.ucDDHipotecario
  Friend WithEvents UcCBU1 As main.ucCBU
  Friend WithEvents UcTarjeta1 As main.ucTarjeta
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents UcServicioVirtual1 As main.ucServicioVirtual
End Class
