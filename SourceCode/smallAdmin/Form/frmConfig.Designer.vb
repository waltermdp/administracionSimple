<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
    Me.btnBack = New System.Windows.Forms.Button()
    Me.btnActualizarPagos = New System.Windows.Forms.Button()
    Me.btnNewGroup = New System.Windows.Forms.Button()
    Me.btnRemGroup = New System.Windows.Forms.Button()
    Me.btnRemCategoria = New System.Windows.Forms.Button()
    Me.btnNewCategoria = New System.Windows.Forms.Button()
    Me.lstvCategoria = New System.Windows.Forms.ListView()
    Me.txtInGrupo = New System.Windows.Forms.TextBox()
    Me.txtInCategoria = New System.Windows.Forms.TextBox()
    Me.bsGrupos = New System.Windows.Forms.BindingSource(Me.components)
    Me.lstGrupo = New System.Windows.Forms.ListBox()
    Me.cmbModosPagos = New System.Windows.Forms.ComboBox()
    Me.btnLoadTipoPagos = New System.Windows.Forms.Button()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.lblNombre = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtCodigo1 = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodigo2 = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtCodigo3 = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtCodigo4 = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtGUID = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.rbtnSi = New System.Windows.Forms.RadioButton()
    Me.rbtnNo = New System.Windows.Forms.RadioButton()
    Me.btnGuardarCambios = New System.Windows.Forms.Button()
    Me.btnGuardarComoNuevo = New System.Windows.Forms.Button()
    CType(Me.bsGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnBack
    '
    Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBack.FlatAppearance.BorderSize = 0
    Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBack.ForeColor = System.Drawing.Color.White
    Me.btnBack.Location = New System.Drawing.Point(10, 637)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(110, 60)
    Me.btnBack.TabIndex = 0
    Me.btnBack.Text = "Volver"
    Me.btnBack.UseVisualStyleBackColor = False
    '
    'btnActualizarPagos
    '
    Me.btnActualizarPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnActualizarPagos.FlatAppearance.BorderSize = 0
    Me.btnActualizarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnActualizarPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizarPagos.ForeColor = System.Drawing.Color.White
    Me.btnActualizarPagos.Location = New System.Drawing.Point(10, 35)
    Me.btnActualizarPagos.Name = "btnActualizarPagos"
    Me.btnActualizarPagos.Size = New System.Drawing.Size(110, 60)
    Me.btnActualizarPagos.TabIndex = 1
    Me.btnActualizarPagos.Text = "Actualizar Pagos"
    Me.btnActualizarPagos.UseVisualStyleBackColor = False
    Me.btnActualizarPagos.Visible = False
    '
    'btnNewGroup
    '
    Me.btnNewGroup.Location = New System.Drawing.Point(351, 64)
    Me.btnNewGroup.Name = "btnNewGroup"
    Me.btnNewGroup.Size = New System.Drawing.Size(66, 55)
    Me.btnNewGroup.TabIndex = 3
    Me.btnNewGroup.Text = "+"
    Me.btnNewGroup.UseVisualStyleBackColor = True
    '
    'btnRemGroup
    '
    Me.btnRemGroup.Location = New System.Drawing.Point(351, 125)
    Me.btnRemGroup.Name = "btnRemGroup"
    Me.btnRemGroup.Size = New System.Drawing.Size(66, 52)
    Me.btnRemGroup.TabIndex = 4
    Me.btnRemGroup.Text = "-"
    Me.btnRemGroup.UseVisualStyleBackColor = True
    '
    'btnRemCategoria
    '
    Me.btnRemCategoria.Location = New System.Drawing.Point(639, 123)
    Me.btnRemCategoria.Name = "btnRemCategoria"
    Me.btnRemCategoria.Size = New System.Drawing.Size(66, 52)
    Me.btnRemCategoria.TabIndex = 7
    Me.btnRemCategoria.Text = "-"
    Me.btnRemCategoria.UseVisualStyleBackColor = True
    '
    'btnNewCategoria
    '
    Me.btnNewCategoria.Location = New System.Drawing.Point(639, 64)
    Me.btnNewCategoria.Name = "btnNewCategoria"
    Me.btnNewCategoria.Size = New System.Drawing.Size(66, 53)
    Me.btnNewCategoria.TabIndex = 6
    Me.btnNewCategoria.Text = "+"
    Me.btnNewCategoria.UseVisualStyleBackColor = True
    '
    'lstvCategoria
    '
    Me.lstvCategoria.Location = New System.Drawing.Point(463, 97)
    Me.lstvCategoria.Name = "lstvCategoria"
    Me.lstvCategoria.Size = New System.Drawing.Size(170, 209)
    Me.lstvCategoria.TabIndex = 5
    Me.lstvCategoria.UseCompatibleStateImageBehavior = False
    Me.lstvCategoria.View = System.Windows.Forms.View.List
    '
    'txtInGrupo
    '
    Me.txtInGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInGrupo.Location = New System.Drawing.Point(175, 64)
    Me.txtInGrupo.Name = "txtInGrupo"
    Me.txtInGrupo.Size = New System.Drawing.Size(170, 21)
    Me.txtInGrupo.TabIndex = 8
    '
    'txtInCategoria
    '
    Me.txtInCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInCategoria.Location = New System.Drawing.Point(463, 64)
    Me.txtInCategoria.Name = "txtInCategoria"
    Me.txtInCategoria.Size = New System.Drawing.Size(170, 21)
    Me.txtInCategoria.TabIndex = 9
    '
    'bsGrupos
    '
    Me.bsGrupos.DataSource = GetType(manDB.clsInfoGrupo)
    '
    'lstGrupo
    '
    Me.lstGrupo.DataSource = Me.bsGrupos
    Me.lstGrupo.DisplayMember = "Nombre"
    Me.lstGrupo.FormattingEnabled = True
    Me.lstGrupo.Location = New System.Drawing.Point(175, 94)
    Me.lstGrupo.Name = "lstGrupo"
    Me.lstGrupo.Size = New System.Drawing.Size(170, 212)
    Me.lstGrupo.TabIndex = 10
    '
    'cmbModosPagos
    '
    Me.cmbModosPagos.FormattingEnabled = True
    Me.cmbModosPagos.Location = New System.Drawing.Point(977, 93)
    Me.cmbModosPagos.Name = "cmbModosPagos"
    Me.cmbModosPagos.Size = New System.Drawing.Size(239, 21)
    Me.cmbModosPagos.TabIndex = 11
    '
    'btnLoadTipoPagos
    '
    Me.btnLoadTipoPagos.Location = New System.Drawing.Point(844, 91)
    Me.btnLoadTipoPagos.Name = "btnLoadTipoPagos"
    Me.btnLoadTipoPagos.Size = New System.Drawing.Size(127, 23)
    Me.btnLoadTipoPagos.TabIndex = 12
    Me.btnLoadTipoPagos.Text = "Cargar Modos Pagos"
    Me.btnLoadTipoPagos.UseVisualStyleBackColor = True
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(977, 125)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(239, 20)
    Me.txtNombre.TabIndex = 13
    '
    'lblNombre
    '
    Me.lblNombre.BackColor = System.Drawing.Color.Transparent
    Me.lblNombre.Location = New System.Drawing.Point(844, 125)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(127, 20)
    Me.lblNombre.TabIndex = 14
    Me.lblNombre.Text = "Nombre"
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(844, 151)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(127, 20)
    Me.Label2.TabIndex = 16
    Me.Label2.Text = "Codigo 1"
    '
    'txtCodigo1
    '
    Me.txtCodigo1.Location = New System.Drawing.Point(977, 151)
    Me.txtCodigo1.Name = "txtCodigo1"
    Me.txtCodigo1.Size = New System.Drawing.Size(239, 20)
    Me.txtCodigo1.TabIndex = 15
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(844, 177)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(127, 20)
    Me.Label3.TabIndex = 18
    Me.Label3.Text = "Codigo 2"
    '
    'txtCodigo2
    '
    Me.txtCodigo2.Location = New System.Drawing.Point(977, 177)
    Me.txtCodigo2.Name = "txtCodigo2"
    Me.txtCodigo2.Size = New System.Drawing.Size(239, 20)
    Me.txtCodigo2.TabIndex = 17
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(844, 203)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(127, 20)
    Me.Label1.TabIndex = 20
    Me.Label1.Text = "Codigo 3"
    '
    'txtCodigo3
    '
    Me.txtCodigo3.Location = New System.Drawing.Point(977, 203)
    Me.txtCodigo3.Name = "txtCodigo3"
    Me.txtCodigo3.Size = New System.Drawing.Size(239, 20)
    Me.txtCodigo3.TabIndex = 19
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(844, 229)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(127, 20)
    Me.Label4.TabIndex = 22
    Me.Label4.Text = "Codigo 4"
    '
    'txtCodigo4
    '
    Me.txtCodigo4.Location = New System.Drawing.Point(977, 229)
    Me.txtCodigo4.Name = "txtCodigo4"
    Me.txtCodigo4.Size = New System.Drawing.Size(239, 20)
    Me.txtCodigo4.TabIndex = 21
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Location = New System.Drawing.Point(844, 255)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(127, 20)
    Me.Label5.TabIndex = 24
    Me.Label5.Text = "GUID"
    '
    'txtGUID
    '
    Me.txtGUID.Location = New System.Drawing.Point(977, 255)
    Me.txtGUID.Name = "txtGUID"
    Me.txtGUID.ReadOnly = True
    Me.txtGUID.Size = New System.Drawing.Size(239, 20)
    Me.txtGUID.TabIndex = 23
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Location = New System.Drawing.Point(844, 275)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(127, 20)
    Me.Label6.TabIndex = 25
    Me.Label6.Text = "Cuotas"
    '
    'rbtnSi
    '
    Me.rbtnSi.AutoSize = True
    Me.rbtnSi.BackColor = System.Drawing.Color.Transparent
    Me.rbtnSi.Location = New System.Drawing.Point(993, 295)
    Me.rbtnSi.Name = "rbtnSi"
    Me.rbtnSi.Size = New System.Drawing.Size(34, 17)
    Me.rbtnSi.TabIndex = 26
    Me.rbtnSi.TabStop = True
    Me.rbtnSi.Text = "Si"
    Me.rbtnSi.UseVisualStyleBackColor = False
    '
    'rbtnNo
    '
    Me.rbtnNo.AutoSize = True
    Me.rbtnNo.BackColor = System.Drawing.Color.Transparent
    Me.rbtnNo.Location = New System.Drawing.Point(1099, 297)
    Me.rbtnNo.Name = "rbtnNo"
    Me.rbtnNo.Size = New System.Drawing.Size(39, 17)
    Me.rbtnNo.TabIndex = 27
    Me.rbtnNo.TabStop = True
    Me.rbtnNo.Text = "No"
    Me.rbtnNo.UseVisualStyleBackColor = False
    '
    'btnGuardarCambios
    '
    Me.btnGuardarCambios.Location = New System.Drawing.Point(847, 332)
    Me.btnGuardarCambios.Name = "btnGuardarCambios"
    Me.btnGuardarCambios.Size = New System.Drawing.Size(98, 30)
    Me.btnGuardarCambios.TabIndex = 28
    Me.btnGuardarCambios.Text = "Guardar Cambios"
    Me.btnGuardarCambios.UseVisualStyleBackColor = True
    '
    'btnGuardarComoNuevo
    '
    Me.btnGuardarComoNuevo.Location = New System.Drawing.Point(977, 332)
    Me.btnGuardarComoNuevo.Name = "btnGuardarComoNuevo"
    Me.btnGuardarComoNuevo.Size = New System.Drawing.Size(92, 30)
    Me.btnGuardarComoNuevo.TabIndex = 29
    Me.btnGuardarComoNuevo.Text = "Guardar Nuevo"
    Me.btnGuardarComoNuevo.UseVisualStyleBackColor = True
    '
    'frmConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.btnGuardarComoNuevo)
    Me.Controls.Add(Me.btnGuardarCambios)
    Me.Controls.Add(Me.rbtnNo)
    Me.Controls.Add(Me.rbtnSi)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtGUID)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtCodigo4)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtCodigo3)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtCodigo2)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtCodigo1)
    Me.Controls.Add(Me.lblNombre)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.btnLoadTipoPagos)
    Me.Controls.Add(Me.cmbModosPagos)
    Me.Controls.Add(Me.lstGrupo)
    Me.Controls.Add(Me.txtInCategoria)
    Me.Controls.Add(Me.txtInGrupo)
    Me.Controls.Add(Me.btnRemCategoria)
    Me.Controls.Add(Me.btnNewCategoria)
    Me.Controls.Add(Me.lstvCategoria)
    Me.Controls.Add(Me.btnRemGroup)
    Me.Controls.Add(Me.btnNewGroup)
    Me.Controls.Add(Me.btnActualizarPagos)
    Me.Controls.Add(Me.btnBack)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmConfig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmConfig"
    CType(Me.bsGrupos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents btnActualizarPagos As System.Windows.Forms.Button
  Friend WithEvents btnNewGroup As System.Windows.Forms.Button
  Friend WithEvents btnRemGroup As System.Windows.Forms.Button
  Friend WithEvents btnRemCategoria As System.Windows.Forms.Button
  Friend WithEvents btnNewCategoria As System.Windows.Forms.Button
  Friend WithEvents lstvCategoria As System.Windows.Forms.ListView
  Friend WithEvents txtInGrupo As System.Windows.Forms.TextBox
  Friend WithEvents txtInCategoria As System.Windows.Forms.TextBox
  Friend WithEvents bsGrupos As System.Windows.Forms.BindingSource
  Friend WithEvents lstGrupo As System.Windows.Forms.ListBox
  Friend WithEvents cmbModosPagos As System.Windows.Forms.ComboBox
  Friend WithEvents btnLoadTipoPagos As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo1 As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo3 As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo4 As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtGUID As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents rbtnSi As System.Windows.Forms.RadioButton
  Friend WithEvents rbtnNo As System.Windows.Forms.RadioButton
  Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
  Friend WithEvents btnGuardarComoNuevo As System.Windows.Forms.Button
End Class
