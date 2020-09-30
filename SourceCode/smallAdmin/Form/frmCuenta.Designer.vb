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
    Me.lblCodigo1 = New System.Windows.Forms.Label()
    Me.txtCodigo1 = New System.Windows.Forms.TextBox()
    Me.txtCodigo2 = New System.Windows.Forms.TextBox()
    Me.lblCodigo2 = New System.Windows.Forms.Label()
    Me.txtCodigo3 = New System.Windows.Forms.TextBox()
    Me.lblCodigo3 = New System.Windows.Forms.Label()
    Me.txtCodigo4 = New System.Windows.Forms.TextBox()
    Me.lblCodigo4 = New System.Windows.Forms.Label()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.lblCliente = New System.Windows.Forms.Label()
    Me.lstCuentas = New System.Windows.Forms.ListBox()
    Me.bsCuenta = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnSalirSinCambios = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    CType(Me.bsCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmbTipoDeCuenta
    '
    Me.cmbTipoDeCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipoDeCuenta.FormattingEnabled = True
    Me.cmbTipoDeCuenta.Location = New System.Drawing.Point(413, 38)
    Me.cmbTipoDeCuenta.Name = "cmbTipoDeCuenta"
    Me.cmbTipoDeCuenta.Size = New System.Drawing.Size(174, 21)
    Me.cmbTipoDeCuenta.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(410, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Medio de pago"
    '
    'lblCodigo1
    '
    Me.lblCodigo1.AutoSize = True
    Me.lblCodigo1.Location = New System.Drawing.Point(410, 62)
    Me.lblCodigo1.Name = "lblCodigo1"
    Me.lblCodigo1.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo1.TabIndex = 2
    Me.lblCodigo1.Text = "Label2"
    '
    'txtCodigo1
    '
    Me.txtCodigo1.Location = New System.Drawing.Point(413, 79)
    Me.txtCodigo1.Name = "txtCodigo1"
    Me.txtCodigo1.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo1.TabIndex = 3
    '
    'txtCodigo2
    '
    Me.txtCodigo2.Location = New System.Drawing.Point(413, 119)
    Me.txtCodigo2.Name = "txtCodigo2"
    Me.txtCodigo2.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo2.TabIndex = 5
    '
    'lblCodigo2
    '
    Me.lblCodigo2.AutoSize = True
    Me.lblCodigo2.Location = New System.Drawing.Point(410, 102)
    Me.lblCodigo2.Name = "lblCodigo2"
    Me.lblCodigo2.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo2.TabIndex = 4
    Me.lblCodigo2.Text = "Label3"
    '
    'txtCodigo3
    '
    Me.txtCodigo3.Location = New System.Drawing.Point(413, 159)
    Me.txtCodigo3.Name = "txtCodigo3"
    Me.txtCodigo3.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo3.TabIndex = 7
    '
    'lblCodigo3
    '
    Me.lblCodigo3.AutoSize = True
    Me.lblCodigo3.Location = New System.Drawing.Point(410, 142)
    Me.lblCodigo3.Name = "lblCodigo3"
    Me.lblCodigo3.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo3.TabIndex = 6
    Me.lblCodigo3.Text = "Label4"
    '
    'txtCodigo4
    '
    Me.txtCodigo4.Location = New System.Drawing.Point(413, 199)
    Me.txtCodigo4.Name = "txtCodigo4"
    Me.txtCodigo4.Size = New System.Drawing.Size(366, 20)
    Me.txtCodigo4.TabIndex = 9
    '
    'lblCodigo4
    '
    Me.lblCodigo4.AutoSize = True
    Me.lblCodigo4.Location = New System.Drawing.Point(410, 182)
    Me.lblCodigo4.Name = "lblCodigo4"
    Me.lblCodigo4.Size = New System.Drawing.Size(39, 13)
    Me.lblCodigo4.TabIndex = 8
    Me.lblCodigo4.Text = "Label5"
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(11, 237)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 61)
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
    Me.btnGuardar.Location = New System.Drawing.Point(11, 22)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 61)
    Me.btnGuardar.TabIndex = 11
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'lblCliente
    '
    Me.lblCliente.AutoSize = True
    Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCliente.Location = New System.Drawing.Point(141, 54)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(215, 15)
    Me.lblCliente.TabIndex = 12
    Me.lblCliente.Text = "Medios de pagos asociados al Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'lstCuentas
    '
    Me.lstCuentas.DataSource = Me.bsCuenta
    Me.lstCuentas.FormattingEnabled = True
    Me.lstCuentas.Location = New System.Drawing.Point(144, 72)
    Me.lstCuentas.Name = "lstCuentas"
    Me.lstCuentas.Size = New System.Drawing.Size(247, 147)
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
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(11, 22)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 61)
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
    Me.btnCancelar.Location = New System.Drawing.Point(11, 94)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 61)
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
    Me.btnSalirSinCambios.Location = New System.Drawing.Point(281, 237)
    Me.btnSalirSinCambios.Name = "btnSalirSinCambios"
    Me.btnSalirSinCambios.Size = New System.Drawing.Size(110, 61)
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
    Me.btnEditar.Location = New System.Drawing.Point(11, 161)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 61)
    Me.btnEditar.TabIndex = 17
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'frmCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(810, 310)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnSalirSinCambios)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.lstCuentas)
    Me.Controls.Add(Me.lblCliente)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.btnVolver)
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
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmCuenta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmCuenta"
    CType(Me.bsCuenta, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents lblCliente As System.Windows.Forms.Label
  Friend WithEvents lstCuentas As System.Windows.Forms.ListBox
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents bsCuenta As System.Windows.Forms.BindingSource
  Friend WithEvents btnSalirSinCambios As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
