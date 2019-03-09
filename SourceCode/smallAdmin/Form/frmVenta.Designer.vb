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
    Me.NumComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VencimientoCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsCuotas = New System.Windows.Forms.BindingSource(Me.components)
    Me.chkEditarCuotas = New System.Windows.Forms.CheckBox()
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
    Me.pnlCtrlEntregados = New System.Windows.Forms.Panel()
    Me.btnUP = New System.Windows.Forms.Button()
    Me.btnDown = New System.Windows.Forms.Button()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtNumVenta = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.lblNumComprobante = New System.Windows.Forms.Label()
    Me.txtAdelantoVendedor = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtAdelanto = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.cArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cEntregados = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpVenta.SuspendLayout()
    Me.pnlCtrlEntregados.SuspendLayout()
    CType(Me.dtDiaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtPrecio
    '
    Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPrecio.Location = New System.Drawing.Point(554, 204)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 21)
    Me.txtPrecio.TabIndex = 0
    Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(555, 185)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 15)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateVenta.Location = New System.Drawing.Point(553, 43)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(227, 21)
    Me.DateVenta.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(551, 83)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(91, 15)
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
    Me.btnSave.Location = New System.Drawing.Point(24, 50)
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
    Me.btnCancel.Location = New System.Drawing.Point(24, 636)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'cmbCuotas
    '
    Me.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Location = New System.Drawing.Point(660, 203)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 23)
    Me.cmbCuotas.TabIndex = 9
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(657, 185)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(126, 15)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Numero de Cuotas"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(550, 27)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 15)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "FechaVenta"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(555, 244)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(112, 15)
    Me.Label5.TabIndex = 13
    Me.Label5.Text = "Dia Vencimiento"
    '
    'dgvCuotas
    '
    Me.dgvCuotas.AutoGenerateColumns = False
    Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.NumComprobanteDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.NumCuotaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
    Me.dgvCuotas.DataSource = Me.bsCuotas
    Me.dgvCuotas.Location = New System.Drawing.Point(15, 361)
    Me.dgvCuotas.MultiSelect = False
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.ReadOnly = True
    Me.dgvCuotas.RowHeadersVisible = False
    Me.dgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCuotas.Size = New System.Drawing.Size(1053, 120)
    Me.dgvCuotas.TabIndex = 15
    '
    'IdPagoDataGridViewTextBoxColumn
    '
    Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
    Me.IdPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.IdPagoDataGridViewTextBoxColumn.Visible = False
    '
    'NumComprobanteDataGridViewTextBoxColumn
    '
    Me.NumComprobanteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NumComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.HeaderText = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.Name = "NumComprobanteDataGridViewTextBoxColumn"
    Me.NumComprobanteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    Me.GuidProductoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidProductoDataGridViewTextBoxColumn.Visible = False
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    Me.GuidPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidPagoDataGridViewTextBoxColumn.Visible = False
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    Me.NumCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    Me.EstadoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsCuotas
    '
    Me.bsCuotas.DataSource = GetType(manDB.clsInfoPagos)
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkEditarCuotas.Location = New System.Drawing.Point(915, 203)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(96, 19)
    Me.chkEditarCuotas.TabIndex = 18
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = True
    '
    'btnSelectClient
    '
    Me.btnSelectClient.BackColor = System.Drawing.Color.White
    Me.btnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSelectClient.FlatAppearance.BorderSize = 2
    Me.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSelectClient.Location = New System.Drawing.Point(23, 26)
    Me.btnSelectClient.Name = "btnSelectClient"
    Me.btnSelectClient.Size = New System.Drawing.Size(113, 49)
    Me.btnSelectClient.TabIndex = 21
    Me.btnSelectClient.Text = "Seleccionar"
    Me.btnSelectClient.UseVisualStyleBackColor = False
    '
    'btnNewClient
    '
    Me.btnNewClient.BackColor = System.Drawing.Color.White
    Me.btnNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNewClient.FlatAppearance.BorderSize = 2
    Me.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNewClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNewClient.Location = New System.Drawing.Point(23, 79)
    Me.btnNewClient.Name = "btnNewClient"
    Me.btnNewClient.Size = New System.Drawing.Size(113, 46)
    Me.btnNewClient.TabIndex = 22
    Me.btnNewClient.Text = "Nuevo"
    Me.btnNewClient.UseVisualStyleBackColor = False
    '
    'btnSelectVendedor
    '
    Me.btnSelectVendedor.BackColor = System.Drawing.Color.White
    Me.btnSelectVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSelectVendedor.FlatAppearance.BorderSize = 2
    Me.btnSelectVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSelectVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSelectVendedor.Location = New System.Drawing.Point(18, 31)
    Me.btnSelectVendedor.Name = "btnSelectVendedor"
    Me.btnSelectVendedor.Size = New System.Drawing.Size(112, 43)
    Me.btnSelectVendedor.TabIndex = 23
    Me.btnSelectVendedor.Text = "Seleccionar"
    Me.btnSelectVendedor.UseVisualStyleBackColor = False
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.BackColor = System.Drawing.SystemColors.Control
    Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreCliente.Location = New System.Drawing.Point(227, 36)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.ReadOnly = True
    Me.txtNombreCliente.Size = New System.Drawing.Size(273, 21)
    Me.txtNombreCliente.TabIndex = 24
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.BackColor = System.Drawing.Color.White
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(224, 17)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(52, 15)
    Me.Label8.TabIndex = 25
    Me.Label8.Text = "Nombre"
    '
    'txtDNICliente
    '
    Me.txtDNICliente.BackColor = System.Drawing.SystemColors.Control
    Me.txtDNICliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDNICliente.Location = New System.Drawing.Point(227, 79)
    Me.txtDNICliente.Name = "txtDNICliente"
    Me.txtDNICliente.ReadOnly = True
    Me.txtDNICliente.Size = New System.Drawing.Size(273, 21)
    Me.txtDNICliente.TabIndex = 26
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.BackColor = System.Drawing.Color.White
    Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(224, 60)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(28, 15)
    Me.Label9.TabIndex = 27
    Me.Label9.Text = "DNI"
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.BackColor = System.Drawing.SystemColors.Control
    Me.txtNombreVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreVendedor.Location = New System.Drawing.Point(185, 36)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.ReadOnly = True
    Me.txtNombreVendedor.Size = New System.Drawing.Size(281, 21)
    Me.txtNombreVendedor.TabIndex = 28
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.BackColor = System.Drawing.Color.White
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(182, 18)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(52, 15)
    Me.Label10.TabIndex = 29
    Me.Label10.Text = "Nombre"
    '
    'txtDNIVendedor
    '
    Me.txtDNIVendedor.BackColor = System.Drawing.SystemColors.Control
    Me.txtDNIVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDNIVendedor.Location = New System.Drawing.Point(185, 80)
    Me.txtDNIVendedor.Name = "txtDNIVendedor"
    Me.txtDNIVendedor.ReadOnly = True
    Me.txtDNIVendedor.Size = New System.Drawing.Size(281, 21)
    Me.txtDNIVendedor.TabIndex = 30
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.BackColor = System.Drawing.Color.White
    Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(182, 60)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(28, 15)
    Me.Label11.TabIndex = 32
    Me.Label11.Text = "DNI"
    '
    'gpVenta
    '
    Me.gpVenta.BackColor = System.Drawing.Color.White
    Me.gpVenta.Controls.Add(Me.pnlCtrlEntregados)
    Me.gpVenta.Controls.Add(Me.Label18)
    Me.gpVenta.Controls.Add(Me.Label17)
    Me.gpVenta.Controls.Add(Me.Label7)
    Me.gpVenta.Controls.Add(Me.Label6)
    Me.gpVenta.Controls.Add(Me.txtNumVenta)
    Me.gpVenta.Controls.Add(Me.Label16)
    Me.gpVenta.Controls.Add(Me.lblNumComprobante)
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
    Me.gpVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpVenta.Location = New System.Drawing.Point(170, 221)
    Me.gpVenta.Name = "gpVenta"
    Me.gpVenta.Size = New System.Drawing.Size(1098, 487)
    Me.gpVenta.TabIndex = 33
    Me.gpVenta.TabStop = False
    Me.gpVenta.Text = "3- Venta"
    '
    'pnlCtrlEntregados
    '
    Me.pnlCtrlEntregados.Controls.Add(Me.btnUP)
    Me.pnlCtrlEntregados.Controls.Add(Me.btnDown)
    Me.pnlCtrlEntregados.Location = New System.Drawing.Point(464, 98)
    Me.pnlCtrlEntregados.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlCtrlEntregados.Name = "pnlCtrlEntregados"
    Me.pnlCtrlEntregados.Size = New System.Drawing.Size(65, 30)
    Me.pnlCtrlEntregados.TabIndex = 48
    '
    'btnUP
    '
    Me.btnUP.Location = New System.Drawing.Point(0, 0)
    Me.btnUP.Name = "btnUP"
    Me.btnUP.Size = New System.Drawing.Size(22, 23)
    Me.btnUP.TabIndex = 46
    Me.btnUP.Text = "+"
    Me.btnUP.UseVisualStyleBackColor = True
    '
    'btnDown
    '
    Me.btnDown.Location = New System.Drawing.Point(28, 0)
    Me.btnDown.Name = "btnDown"
    Me.btnDown.Size = New System.Drawing.Size(22, 23)
    Me.btnDown.TabIndex = 47
    Me.btnDown.Text = "-"
    Me.btnDown.UseVisualStyleBackColor = True
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(398, 80)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(70, 15)
    Me.Label18.TabIndex = 45
    Me.Label18.Text = "Entregados"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(12, 80)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(95, 15)
    Me.Label17.TabIndex = 43
    Me.Label17.Text = "Articulo (codigo)"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(235, 80)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(95, 15)
    Me.Label7.TabIndex = 42
    Me.Label7.Text = "Articulo (codigo)"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(336, 80)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(56, 15)
    Me.Label6.TabIndex = 41
    Me.Label6.Text = "Cantidad"
    '
    'txtNumVenta
    '
    Me.txtNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNumVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumVenta.Location = New System.Drawing.Point(795, 43)
    Me.txtNumVenta.Name = "txtNumVenta"
    Me.txtNumVenta.Size = New System.Drawing.Size(273, 21)
    Me.txtNumVenta.TabIndex = 40
    Me.txtNumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(792, 27)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(118, 15)
    Me.Label16.TabIndex = 39
    Me.Label16.Text = "Numero de Venta"
    '
    'lblNumComprobante
    '
    Me.lblNumComprobante.AutoSize = True
    Me.lblNumComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumComprobante.Location = New System.Drawing.Point(783, 244)
    Me.lblNumComprobante.Name = "lblNumComprobante"
    Me.lblNumComprobante.Size = New System.Drawing.Size(42, 15)
    Me.lblNumComprobante.TabIndex = 38
    Me.lblNumComprobante.Text = "#####"
    '
    'txtAdelantoVendedor
    '
    Me.txtAdelantoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelantoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelantoVendedor.Location = New System.Drawing.Point(726, 313)
    Me.txtAdelantoVendedor.Name = "txtAdelantoVendedor"
    Me.txtAdelantoVendedor.Size = New System.Drawing.Size(99, 21)
    Me.txtAdelantoVendedor.TabIndex = 37
    Me.txtAdelantoVendedor.Text = "0"
    Me.txtAdelantoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(723, 291)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(175, 15)
    Me.Label15.TabIndex = 36
    Me.Label15.Text = "Adelanto para el vendedor"
    '
    'txtAdelanto
    '
    Me.txtAdelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelanto.Location = New System.Drawing.Point(554, 312)
    Me.txtAdelanto.Name = "txtAdelanto"
    Me.txtAdelanto.Size = New System.Drawing.Size(123, 21)
    Me.txtAdelanto.TabIndex = 35
    Me.txtAdelanto.Text = "0"
    Me.txtAdelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(555, 291)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(122, 15)
    Me.Label14.TabIndex = 34
    Me.Label14.Text = "Adelanto de cuota"
    '
    'ListView1
    '
    Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cArticulos, Me.cCantidad, Me.cEntregados, Me.cGuid})
    Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListView1.FullRowSelect = True
    Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.ListView1.Location = New System.Drawing.Point(238, 98)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(223, 257)
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
    'cEntregados
    '
    Me.cEntregados.DisplayIndex = 3
    Me.cEntregados.Text = "Entregados"
    Me.cEntregados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cGuid
    '
    Me.cGuid.DisplayIndex = 2
    Me.cGuid.Width = 0
    '
    'dtDiaVencimiento
    '
    Me.dtDiaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtDiaVencimiento.Location = New System.Drawing.Point(679, 244)
    Me.dtDiaVencimiento.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
    Me.dtDiaVencimiento.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.dtDiaVencimiento.Name = "dtDiaVencimiento"
    Me.dtDiaVencimiento.ReadOnly = True
    Me.dtDiaVencimiento.Size = New System.Drawing.Size(60, 21)
    Me.dtDiaVencimiento.TabIndex = 32
    Me.dtDiaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.dtDiaVencimiento.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblValorCuota
    '
    Me.lblValorCuota.AutoSize = True
    Me.lblValorCuota.Location = New System.Drawing.Point(792, 188)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(117, 15)
    Me.lblValorCuota.TabIndex = 31
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'txtValorCuota
    '
    Me.txtValorCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtValorCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValorCuota.Location = New System.Drawing.Point(787, 203)
    Me.txtValorCuota.Name = "txtValorCuota"
    Me.txtValorCuota.Size = New System.Drawing.Size(122, 21)
    Me.txtValorCuota.TabIndex = 30
    Me.txtValorCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(792, 100)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(106, 15)
    Me.Label13.TabIndex = 29
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(795, 116)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(273, 21)
    Me.txtMedioPagoDescripcion.TabIndex = 28
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderSize = 2
    Me.btnSeleccionarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(673, 103)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnSeleccionarCuenta.TabIndex = 27
    Me.btnSeleccionarCuenta.Text = "Seleccionar"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = True
    '
    'btnAddCuenta
    '
    Me.btnAddCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAddCuenta.FlatAppearance.BorderSize = 2
    Me.btnAddCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAddCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAddCuenta.Location = New System.Drawing.Point(553, 103)
    Me.btnAddCuenta.Name = "btnAddCuenta"
    Me.btnAddCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnAddCuenta.TabIndex = 26
    Me.btnAddCuenta.Text = "Nuevo"
    Me.btnAddCuenta.UseVisualStyleBackColor = True
    '
    'btnRemoveArticulo
    '
    Me.btnRemoveArticulo.Location = New System.Drawing.Point(187, 168)
    Me.btnRemoveArticulo.Name = "btnRemoveArticulo"
    Me.btnRemoveArticulo.Size = New System.Drawing.Size(45, 24)
    Me.btnRemoveArticulo.TabIndex = 25
    Me.btnRemoveArticulo.Text = "<-"
    Me.btnRemoveArticulo.UseVisualStyleBackColor = True
    '
    'btnAddArticulo
    '
    Me.btnAddArticulo.Location = New System.Drawing.Point(187, 139)
    Me.btnAddArticulo.Name = "btnAddArticulo"
    Me.btnAddArticulo.Size = New System.Drawing.Size(45, 23)
    Me.btnAddArticulo.TabIndex = 24
    Me.btnAddArticulo.Text = "->"
    Me.btnAddArticulo.UseVisualStyleBackColor = True
    '
    'txtBuscarArticulo
    '
    Me.txtBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtBuscarArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuscarArticulo.Location = New System.Drawing.Point(15, 53)
    Me.txtBuscarArticulo.Name = "txtBuscarArticulo"
    Me.txtBuscarArticulo.Size = New System.Drawing.Size(223, 21)
    Me.txtBuscarArticulo.TabIndex = 21
    '
    'lstArticulos
    '
    Me.lstArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lstArticulos.DataSource = Me.bsArticulos
    Me.lstArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstArticulos.FormattingEnabled = True
    Me.lstArticulos.ItemHeight = 15
    Me.lstArticulos.Location = New System.Drawing.Point(15, 98)
    Me.lstArticulos.Name = "lstArticulos"
    Me.lstArticulos.ScrollAlwaysVisible = True
    Me.lstArticulos.Size = New System.Drawing.Size(166, 257)
    Me.lstArticulos.TabIndex = 20
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(12, 27)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(62, 15)
    Me.Label12.TabIndex = 19
    Me.Label12.Text = "Articulos"
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Controls.Add(Me.txtDNICliente)
    Me.GroupBox1.Controls.Add(Me.btnSelectClient)
    Me.GroupBox1.Controls.Add(Me.btnNewClient)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(170, 78)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(535, 131)
    Me.GroupBox1.TabIndex = 34
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "1- Informacion Del Cliente"
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.Label10)
    Me.GroupBox2.Controls.Add(Me.txtNombreVendedor)
    Me.GroupBox2.Controls.Add(Me.Label11)
    Me.GroupBox2.Controls.Add(Me.btnSelectVendedor)
    Me.GroupBox2.Controls.Add(Me.txtDNIVendedor)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(711, 78)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(557, 131)
    Me.GroupBox2.TabIndex = 35
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "2- Informacion del Vendedor"
    '
    'frmVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.gpVenta)
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
    Me.pnlCtrlEntregados.ResumeLayout(False)
    CType(Me.dtDiaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

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
  Friend WithEvents chkEditarCuotas As System.Windows.Forms.CheckBox
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
  Friend WithEvents lblNumComprobante As System.Windows.Forms.Label
  Friend WithEvents txtNumVenta As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents cEntregados As System.Windows.Forms.ColumnHeader
  Friend WithEvents pnlCtrlEntregados As System.Windows.Forms.Panel
  Friend WithEvents btnUP As System.Windows.Forms.Button
  Friend WithEvents btnDown As System.Windows.Forms.Button
End Class
