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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
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
    Me.txtAdelanto = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.cArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cGuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.dtDiaVencimiento = New System.Windows.Forms.NumericUpDown()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.txtValorCuota = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtMedioPagoDescripcion = New System.Windows.Forms.TextBox()
    Me.btnSeleccionarCuenta = New System.Windows.Forms.Button()
    Me.btnAddCuenta = New System.Windows.Forms.Button()
    Me.btnRemoveArticulo = New System.Windows.Forms.Button()
    Me.btnAddArticulo = New System.Windows.Forms.Button()
    Me.txtBuscarArticulo = New System.Windows.Forms.TextBox()
    Me.lstArticulos = New System.Windows.Forms.ListBox()
    Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtAdelantoVendedor = New System.Windows.Forms.TextBox()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpVenta.SuspendLayout()
    CType(Me.dtDiaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtPrecio
    '
    Me.txtPrecio.Location = New System.Drawing.Point(553, 207)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
    Me.txtPrecio.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(554, 188)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Location = New System.Drawing.Point(553, 69)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(200, 20)
    Me.DateVenta.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(550, 96)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Tipo de pago"
    '
    'btnSave
    '
    Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSave.FlatAppearance.BorderSize = 0
    Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSave.ForeColor = System.Drawing.Color.White
    Me.btnSave.Location = New System.Drawing.Point(24, 51)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(110, 61)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "Guardar"
    Me.btnSave.UseVisualStyleBackColor = False
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(12, 648)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'cmbCuotas
    '
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Items.AddRange(New Object() {"Contado", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cmbCuotas.Location = New System.Drawing.Point(659, 206)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 21)
    Me.cmbCuotas.TabIndex = 9
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(656, 188)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(40, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Cuotas"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(550, 53)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "FechaVenta"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(901, 191)
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
    Me.dgvCuotas.Location = New System.Drawing.Point(254, 406)
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.Size = New System.Drawing.Size(831, 67)
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
    Me.Label6.Location = New System.Drawing.Point(234, 137)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(128, 13)
    Me.Label6.TabIndex = 17
    Me.Label6.Text = "Informacion del Vendedor"
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.Location = New System.Drawing.Point(786, 231)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(86, 17)
    Me.chkEditarCuotas.TabIndex = 18
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(234, 38)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(114, 13)
    Me.Label7.TabIndex = 20
    Me.Label7.Text = "Informacion del Cliente"
    '
    'btnSelectClient
    '
    Me.btnSelectClient.Location = New System.Drawing.Point(237, 65)
    Me.btnSelectClient.Name = "btnSelectClient"
    Me.btnSelectClient.Size = New System.Drawing.Size(125, 23)
    Me.btnSelectClient.TabIndex = 21
    Me.btnSelectClient.Text = "Seleccionar Cliente"
    Me.btnSelectClient.UseVisualStyleBackColor = True
    '
    'btnNewClient
    '
    Me.btnNewClient.Location = New System.Drawing.Point(237, 94)
    Me.btnNewClient.Name = "btnNewClient"
    Me.btnNewClient.Size = New System.Drawing.Size(125, 23)
    Me.btnNewClient.TabIndex = 22
    Me.btnNewClient.Text = "Cliente Nuevo"
    Me.btnNewClient.UseVisualStyleBackColor = True
    '
    'btnSelectVendedor
    '
    Me.btnSelectVendedor.Location = New System.Drawing.Point(237, 153)
    Me.btnSelectVendedor.Name = "btnSelectVendedor"
    Me.btnSelectVendedor.Size = New System.Drawing.Size(125, 23)
    Me.btnSelectVendedor.TabIndex = 23
    Me.btnSelectVendedor.Text = "Seleccionar Vendedor"
    Me.btnSelectVendedor.UseVisualStyleBackColor = True
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtNombreCliente.Location = New System.Drawing.Point(424, 81)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.ReadOnly = True
    Me.txtNombreCliente.Size = New System.Drawing.Size(230, 20)
    Me.txtNombreCliente.TabIndex = 24
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(421, 65)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(44, 13)
    Me.Label8.TabIndex = 25
    Me.Label8.Text = "Nombre"
    '
    'txtDNICliente
    '
    Me.txtDNICliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtDNICliente.Location = New System.Drawing.Point(660, 81)
    Me.txtDNICliente.Name = "txtDNICliente"
    Me.txtDNICliente.ReadOnly = True
    Me.txtDNICliente.Size = New System.Drawing.Size(184, 20)
    Me.txtDNICliente.TabIndex = 26
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(657, 65)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(26, 13)
    Me.Label9.TabIndex = 27
    Me.Label9.Text = "DNI"
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtNombreVendedor.Location = New System.Drawing.Point(424, 169)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.ReadOnly = True
    Me.txtNombreVendedor.Size = New System.Drawing.Size(230, 20)
    Me.txtNombreVendedor.TabIndex = 28
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(421, 153)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(53, 13)
    Me.Label10.TabIndex = 29
    Me.Label10.Text = "Vendedor"
    '
    'txtDNIVendedor
    '
    Me.txtDNIVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtDNIVendedor.Location = New System.Drawing.Point(660, 169)
    Me.txtDNIVendedor.Name = "txtDNIVendedor"
    Me.txtDNIVendedor.ReadOnly = True
    Me.txtDNIVendedor.Size = New System.Drawing.Size(184, 20)
    Me.txtDNIVendedor.TabIndex = 30
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(657, 153)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(26, 13)
    Me.Label11.TabIndex = 32
    Me.Label11.Text = "DNI"
    '
    'gpVenta
    '
    Me.gpVenta.Controls.Add(Me.txtAdelantoVendedor)
    Me.gpVenta.Controls.Add(Me.Label15)
    Me.gpVenta.Controls.Add(Me.txtAdelanto)
    Me.gpVenta.Controls.Add(Me.Label14)
    Me.gpVenta.Controls.Add(Me.ListView1)
    Me.gpVenta.Controls.Add(Me.dtDiaVencimiento)
    Me.gpVenta.Controls.Add(Me.lblValorCuota)
    Me.gpVenta.Controls.Add(Me.txtValorCuota)
    Me.gpVenta.Controls.Add(Me.Label13)
    Me.gpVenta.Controls.Add(Me.txtMedioPagoDescripcion)
    Me.gpVenta.Controls.Add(Me.btnSeleccionarCuenta)
    Me.gpVenta.Controls.Add(Me.btnAddCuenta)
    Me.gpVenta.Controls.Add(Me.btnRemoveArticulo)
    Me.gpVenta.Controls.Add(Me.btnAddArticulo)
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
    Me.gpVenta.Location = New System.Drawing.Point(170, 221)
    Me.gpVenta.Name = "gpVenta"
    Me.gpVenta.Size = New System.Drawing.Size(1098, 487)
    Me.gpVenta.TabIndex = 33
    Me.gpVenta.TabStop = False
    Me.gpVenta.Text = "Venta"
    '
    'txtAdelanto
    '
    Me.txtAdelanto.Location = New System.Drawing.Point(553, 275)
    Me.txtAdelanto.Name = "txtAdelanto"
    Me.txtAdelanto.Size = New System.Drawing.Size(100, 20)
    Me.txtAdelanto.TabIndex = 35
    Me.txtAdelanto.Text = "0"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(554, 254)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(94, 13)
    Me.Label14.TabIndex = 34
    Me.Label14.Text = "Adelanto de cuota"
    '
    'ListView1
    '
    Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cArticulos, Me.cCantidad, Me.cGuid})
    Me.ListView1.FullRowSelect = True
    Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.ListView1.Location = New System.Drawing.Point(295, 96)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(223, 173)
    Me.ListView1.TabIndex = 33
    Me.ListView1.UseCompatibleStateImageBehavior = False
    '
    'cArticulos
    '
    Me.cArticulos.Text = "Articulos"
    '
    'cCantidad
    '
    Me.cCantidad.Text = "Cantidad"
    Me.cCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cGuid
    '
    Me.cGuid.Width = 0
    '
    'dtDiaVencimiento
    '
    Me.dtDiaVencimiento.Location = New System.Drawing.Point(904, 207)
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
    Me.lblValorCuota.Location = New System.Drawing.Point(791, 191)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(88, 13)
    Me.lblValorCuota.TabIndex = 31
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'txtValorCuota
    '
    Me.txtValorCuota.Location = New System.Drawing.Point(786, 206)
    Me.txtValorCuota.Name = "txtValorCuota"
    Me.txtValorCuota.Size = New System.Drawing.Size(96, 20)
    Me.txtValorCuota.TabIndex = 30
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(762, 112)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(81, 13)
    Me.Label13.TabIndex = 29
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(765, 128)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(303, 20)
    Me.txtMedioPagoDescripcion.TabIndex = 28
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(553, 141)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(117, 23)
    Me.btnSeleccionarCuenta.TabIndex = 27
    Me.btnSeleccionarCuenta.Text = "Seleccionar Cuenta"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = True
    '
    'btnAddCuenta
    '
    Me.btnAddCuenta.Location = New System.Drawing.Point(553, 112)
    Me.btnAddCuenta.Name = "btnAddCuenta"
    Me.btnAddCuenta.Size = New System.Drawing.Size(117, 23)
    Me.btnAddCuenta.TabIndex = 26
    Me.btnAddCuenta.Text = "Agregar Cuenta"
    Me.btnAddCuenta.UseVisualStyleBackColor = True
    '
    'btnRemoveArticulo
    '
    Me.btnRemoveArticulo.Location = New System.Drawing.Point(244, 168)
    Me.btnRemoveArticulo.Name = "btnRemoveArticulo"
    Me.btnRemoveArticulo.Size = New System.Drawing.Size(45, 24)
    Me.btnRemoveArticulo.TabIndex = 25
    Me.btnRemoveArticulo.Text = "<-"
    Me.btnRemoveArticulo.UseVisualStyleBackColor = True
    '
    'btnAddArticulo
    '
    Me.btnAddArticulo.Location = New System.Drawing.Point(244, 139)
    Me.btnAddArticulo.Name = "btnAddArticulo"
    Me.btnAddArticulo.Size = New System.Drawing.Size(45, 23)
    Me.btnAddArticulo.TabIndex = 24
    Me.btnAddArticulo.Text = "->"
    Me.btnAddArticulo.UseVisualStyleBackColor = True
    '
    'txtBuscarArticulo
    '
    Me.txtBuscarArticulo.Location = New System.Drawing.Point(15, 72)
    Me.txtBuscarArticulo.Name = "txtBuscarArticulo"
    Me.txtBuscarArticulo.Size = New System.Drawing.Size(223, 20)
    Me.txtBuscarArticulo.TabIndex = 21
    '
    'lstArticulos
    '
    Me.lstArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lstArticulos.DataSource = Me.bsArticulos
    Me.lstArticulos.FormattingEnabled = True
    Me.lstArticulos.Location = New System.Drawing.Point(15, 96)
    Me.lstArticulos.Name = "lstArticulos"
    Me.lstArticulos.Size = New System.Drawing.Size(223, 171)
    Me.lstArticulos.TabIndex = 20
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(12, 27)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(47, 13)
    Me.Label12.TabIndex = 19
    Me.Label12.Text = "Articulos"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(682, 253)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(132, 13)
    Me.Label15.TabIndex = 36
    Me.Label15.Text = "Adelanto para el vendedor"
    '
    'txtAdelantoVendedor
    '
    Me.txtAdelantoVendedor.Location = New System.Drawing.Point(685, 275)
    Me.txtAdelantoVendedor.Name = "txtAdelantoVendedor"
    Me.txtAdelantoVendedor.Size = New System.Drawing.Size(100, 20)
    Me.txtAdelantoVendedor.TabIndex = 37
    Me.txtAdelantoVendedor.Text = "0"
    '
    'frmVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
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
  Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
  Friend WithEvents btnAddCuenta As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionarCuenta As System.Windows.Forms.Button
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtMedioPagoDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents txtValorCuota As System.Windows.Forms.TextBox
  Friend WithEvents dtDiaVencimiento As System.Windows.Forms.NumericUpDown
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents cArticulos As System.Windows.Forms.ColumnHeader
  Friend WithEvents cCantidad As System.Windows.Forms.ColumnHeader
  Friend WithEvents cGuid As System.Windows.Forms.ColumnHeader
  Friend WithEvents txtAdelanto As System.Windows.Forms.TextBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents txtAdelantoVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
