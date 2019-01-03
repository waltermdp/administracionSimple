<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DateVenta = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.cmbCuotas = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.dgvCuotas = New System.Windows.Forms.DataGridView()
    Me.IdPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VencimientoCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsCuotas = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkEditarCuotas = New System.Windows.Forms.CheckBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.btnSelectClient = New System.Windows.Forms.Button()
    Me.btnNewClient = New System.Windows.Forms.Button()
    Me.btnSelectVendedor = New System.Windows.Forms.Button()
    Me.txtNombreCliente = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtDNICliente = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtDNIVendedor = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.gpVenta = New System.Windows.Forms.GroupBox()
    Me.dtDiaVencimiento = New System.Windows.Forms.NumericUpDown()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.txtValorCuota = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtMedioPagoDescripcion = New System.Windows.Forms.TextBox()
    Me.btnSeleccionarCuenta = New System.Windows.Forms.Button()
    Me.btnAddCuenta = New System.Windows.Forms.Button()
    Me.btnRemoveArticulo = New System.Windows.Forms.Button()
    Me.btnAddArticulo = New System.Windows.Forms.Button()
    Me.lstArticulosVendidos = New System.Windows.Forms.ListBox()
    Me.txtBuscarArticulo = New System.Windows.Forms.TextBox()
    Me.lstArticulos = New System.Windows.Forms.ListBox()
    Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label12 = New System.Windows.Forms.Label()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpVenta.SuspendLayout()
    CType(Me.dtDiaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtPrecio
    '
    Me.txtPrecio.Location = New System.Drawing.Point(560, 180)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
    Me.txtPrecio.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(561, 161)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Location = New System.Drawing.Point(560, 42)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(200, 20)
    Me.DateVenta.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(557, 69)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Tipo de pago"
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(12, 69)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(92, 52)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "Guardar"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(12, 648)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(92, 52)
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'cmbCuotas
    '
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Items.AddRange(New Object() {"Contado", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cmbCuotas.Location = New System.Drawing.Point(666, 179)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 21)
    Me.cmbCuotas.TabIndex = 9
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(663, 161)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(40, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Cuotas"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(557, 26)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "FechaVenta"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(908, 164)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(124, 13)
    Me.Label5.TabIndex = 13
    Me.Label5.Text = "FechaPrimerVencimiento"
    '
    'dgvCuotas
    '
    Me.dgvCuotas.AutoGenerateColumns = False
    Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.NumCuotaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
    Me.dgvCuotas.DataSource = Me.bsCuotas
    Me.dgvCuotas.Location = New System.Drawing.Point(31, 318)
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.Size = New System.Drawing.Size(832, 131)
    Me.dgvCuotas.TabIndex = 15
    '
    'IdPagoDataGridViewTextBoxColumn
    '
    Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    '
    'bsCuotas
    '
    Me.bsCuotas.DataSource = GetType(manDB.clsInfoPagos)
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(138, 108)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(128, 13)
    Me.Label6.TabIndex = 17
    Me.Label6.Text = "Informacion del Vendedor"
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.Location = New System.Drawing.Point(793, 204)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(86, 17)
    Me.chkEditarCuotas.TabIndex = 18
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(138, 9)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(114, 13)
    Me.Label7.TabIndex = 20
    Me.Label7.Text = "Informacion del Cliente"
    '
    'btnSelectClient
    '
    Me.btnSelectClient.Location = New System.Drawing.Point(141, 36)
    Me.btnSelectClient.Name = "btnSelectClient"
    Me.btnSelectClient.Size = New System.Drawing.Size(125, 23)
    Me.btnSelectClient.TabIndex = 21
    Me.btnSelectClient.Text = "Seleccionar Cliente"
    Me.btnSelectClient.UseVisualStyleBackColor = True
    '
    'btnNewClient
    '
    Me.btnNewClient.Location = New System.Drawing.Point(141, 65)
    Me.btnNewClient.Name = "btnNewClient"
    Me.btnNewClient.Size = New System.Drawing.Size(125, 23)
    Me.btnNewClient.TabIndex = 22
    Me.btnNewClient.Text = "Cliente Nuevo"
    Me.btnNewClient.UseVisualStyleBackColor = True
    '
    'btnSelectVendedor
    '
    Me.btnSelectVendedor.Location = New System.Drawing.Point(141, 124)
    Me.btnSelectVendedor.Name = "btnSelectVendedor"
    Me.btnSelectVendedor.Size = New System.Drawing.Size(125, 23)
    Me.btnSelectVendedor.TabIndex = 23
    Me.btnSelectVendedor.Text = "Seleccionar Vendedor"
    Me.btnSelectVendedor.UseVisualStyleBackColor = True
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.Location = New System.Drawing.Point(328, 52)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.ReadOnly = True
    Me.txtNombreCliente.Size = New System.Drawing.Size(230, 20)
    Me.txtNombreCliente.TabIndex = 24
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(325, 36)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(44, 13)
    Me.Label8.TabIndex = 25
    Me.Label8.Text = "Nombre"
    '
    'txtDNICliente
    '
    Me.txtDNICliente.Location = New System.Drawing.Point(564, 52)
    Me.txtDNICliente.Name = "txtDNICliente"
    Me.txtDNICliente.ReadOnly = True
    Me.txtDNICliente.Size = New System.Drawing.Size(184, 20)
    Me.txtDNICliente.TabIndex = 26
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(561, 36)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(26, 13)
    Me.Label9.TabIndex = 27
    Me.Label9.Text = "DNI"
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.Location = New System.Drawing.Point(328, 140)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.ReadOnly = True
    Me.txtNombreVendedor.Size = New System.Drawing.Size(230, 20)
    Me.txtNombreVendedor.TabIndex = 28
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(325, 124)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(53, 13)
    Me.Label10.TabIndex = 29
    Me.Label10.Text = "Vendedor"
    '
    'txtDNIVendedor
    '
    Me.txtDNIVendedor.Location = New System.Drawing.Point(564, 140)
    Me.txtDNIVendedor.Name = "txtDNIVendedor"
    Me.txtDNIVendedor.ReadOnly = True
    Me.txtDNIVendedor.Size = New System.Drawing.Size(184, 20)
    Me.txtDNIVendedor.TabIndex = 30
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(561, 124)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(26, 13)
    Me.Label11.TabIndex = 32
    Me.Label11.Text = "DNI"
    '
    'gpVenta
    '
    Me.gpVenta.Controls.Add(Me.dtDiaVencimiento)
    Me.gpVenta.Controls.Add(Me.lblValorCuota)
    Me.gpVenta.Controls.Add(Me.txtValorCuota)
    Me.gpVenta.Controls.Add(Me.Label13)
    Me.gpVenta.Controls.Add(Me.txtMedioPagoDescripcion)
    Me.gpVenta.Controls.Add(Me.btnSeleccionarCuenta)
    Me.gpVenta.Controls.Add(Me.btnAddCuenta)
    Me.gpVenta.Controls.Add(Me.btnRemoveArticulo)
    Me.gpVenta.Controls.Add(Me.btnAddArticulo)
    Me.gpVenta.Controls.Add(Me.lstArticulosVendidos)
    Me.gpVenta.Controls.Add(Me.txtBuscarArticulo)
    Me.gpVenta.Controls.Add(Me.lstArticulos)
    Me.gpVenta.Controls.Add(Me.Label12)
    Me.gpVenta.Controls.Add(Me.Label2)
    Me.gpVenta.Controls.Add(Me.txtPrecio)
    Me.gpVenta.Controls.Add(Me.Label1)
    Me.gpVenta.Controls.Add(Me.DateVenta)
    Me.gpVenta.Controls.Add(Me.Label3)
    Me.gpVenta.Controls.Add(Me.cmbCuotas)
    Me.gpVenta.Controls.Add(Me.Label4)
    Me.gpVenta.Controls.Add(Me.Label5)
    Me.gpVenta.Controls.Add(Me.dgvCuotas)
    Me.gpVenta.Controls.Add(Me.chkEditarCuotas)
    Me.gpVenta.Location = New System.Drawing.Point(141, 180)
    Me.gpVenta.Name = "gpVenta"
    Me.gpVenta.Size = New System.Drawing.Size(1098, 520)
    Me.gpVenta.TabIndex = 33
    Me.gpVenta.TabStop = False
    Me.gpVenta.Text = "Venta"
    '
    'dtDiaVencimiento
    '
    Me.dtDiaVencimiento.Location = New System.Drawing.Point(911, 180)
    Me.dtDiaVencimiento.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
    Me.dtDiaVencimiento.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.dtDiaVencimiento.Name = "dtDiaVencimiento"
    Me.dtDiaVencimiento.Size = New System.Drawing.Size(60, 20)
    Me.dtDiaVencimiento.TabIndex = 32
    Me.dtDiaVencimiento.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblValorCuota
    '
    Me.lblValorCuota.AutoSize = True
    Me.lblValorCuota.Location = New System.Drawing.Point(798, 164)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(88, 13)
    Me.lblValorCuota.TabIndex = 31
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'txtValorCuota
    '
    Me.txtValorCuota.Location = New System.Drawing.Point(793, 179)
    Me.txtValorCuota.Name = "txtValorCuota"
    Me.txtValorCuota.Size = New System.Drawing.Size(96, 20)
    Me.txtValorCuota.TabIndex = 30
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(769, 85)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(81, 13)
    Me.Label13.TabIndex = 29
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(772, 101)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(303, 20)
    Me.txtMedioPagoDescripcion.TabIndex = 28
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(560, 114)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(117, 23)
    Me.btnSeleccionarCuenta.TabIndex = 27
    Me.btnSeleccionarCuenta.Text = "Seleccionar Cuenta"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = True
    '
    'btnAddCuenta
    '
    Me.btnAddCuenta.Location = New System.Drawing.Point(560, 85)
    Me.btnAddCuenta.Name = "btnAddCuenta"
    Me.btnAddCuenta.Size = New System.Drawing.Size(117, 23)
    Me.btnAddCuenta.TabIndex = 26
    Me.btnAddCuenta.Text = "Agregar Cuenta"
    Me.btnAddCuenta.UseVisualStyleBackColor = True
    '
    'btnRemoveArticulo
    '
    Me.btnRemoveArticulo.Location = New System.Drawing.Point(251, 141)
    Me.btnRemoveArticulo.Name = "btnRemoveArticulo"
    Me.btnRemoveArticulo.Size = New System.Drawing.Size(45, 24)
    Me.btnRemoveArticulo.TabIndex = 25
    Me.btnRemoveArticulo.Text = "<-"
    Me.btnRemoveArticulo.UseVisualStyleBackColor = True
    '
    'btnAddArticulo
    '
    Me.btnAddArticulo.Location = New System.Drawing.Point(251, 112)
    Me.btnAddArticulo.Name = "btnAddArticulo"
    Me.btnAddArticulo.Size = New System.Drawing.Size(45, 23)
    Me.btnAddArticulo.TabIndex = 24
    Me.btnAddArticulo.Text = "->"
    Me.btnAddArticulo.UseVisualStyleBackColor = True
    '
    'lstArticulosVendidos
    '
    Me.lstArticulosVendidos.FormattingEnabled = True
    Me.lstArticulosVendidos.Location = New System.Drawing.Point(302, 68)
    Me.lstArticulosVendidos.Name = "lstArticulosVendidos"
    Me.lstArticulosVendidos.Size = New System.Drawing.Size(223, 173)
    Me.lstArticulosVendidos.TabIndex = 23
    '
    'txtBuscarArticulo
    '
    Me.txtBuscarArticulo.Location = New System.Drawing.Point(22, 45)
    Me.txtBuscarArticulo.Name = "txtBuscarArticulo"
    Me.txtBuscarArticulo.Size = New System.Drawing.Size(223, 20)
    Me.txtBuscarArticulo.TabIndex = 21
    '
    'lstArticulos
    '
    Me.lstArticulos.DataSource = Me.bsArticulos
    Me.lstArticulos.FormattingEnabled = True
    Me.lstArticulos.Location = New System.Drawing.Point(22, 69)
    Me.lstArticulos.Name = "lstArticulos"
    Me.lstArticulos.Size = New System.Drawing.Size(223, 173)
    Me.lstArticulos.TabIndex = 20
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(19, 26)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(47, 13)
    Me.Label12.TabIndex = 19
    Me.Label12.Text = "Articulos"
    '
    'frmVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.gpVenta)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.txtDNIVendedor)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.txtNombreVendedor)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtDNICliente)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtNombreCliente)
    Me.Controls.Add(Me.btnSelectVendedor)
    Me.Controls.Add(Me.btnNewClient)
    Me.Controls.Add(Me.btnSelectClient)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnSave)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmVenta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmVenta"
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gpVenta.ResumeLayout(False)
    Me.gpVenta.PerformLayout()
    CType(Me.dtDiaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DateVenta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents cmbCuotas As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents dgvCuotas As System.Windows.Forms.DataGridView
  Friend WithEvents bsCuotas As System.Windows.Forms.BindingSource
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents chkEditarCuotas As System.Windows.Forms.CheckBox
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents btnSelectClient As System.Windows.Forms.Button
  Friend WithEvents btnNewClient As System.Windows.Forms.Button
  Friend WithEvents btnSelectVendedor As System.Windows.Forms.Button
  Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtDNICliente As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtDNIVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents gpVenta As System.Windows.Forms.GroupBox
  Friend WithEvents txtBuscarArticulo As System.Windows.Forms.TextBox
  Friend WithEvents lstArticulos As System.Windows.Forms.ListBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents btnRemoveArticulo As System.Windows.Forms.Button
  Friend WithEvents btnAddArticulo As System.Windows.Forms.Button
  Friend WithEvents lstArticulosVendidos As System.Windows.Forms.ListBox
  Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
  Friend WithEvents btnAddCuenta As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionarCuenta As System.Windows.Forms.Button
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtMedioPagoDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents txtValorCuota As System.Windows.Forms.TextBox
  Friend WithEvents dtDiaVencimiento As System.Windows.Forms.NumericUpDown
End Class
