<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarPagos
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
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNumVenta = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtMedioPagoDescripcion = New System.Windows.Forms.TextBox()
    Me.btnSeleccionarCuenta = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtNombreCliente = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtDiaVencimiento = New System.Windows.Forms.TextBox()
    Me.txtFechaVenta = New System.Windows.Forms.TextBox()
    Me.btnClearPago = New System.Windows.Forms.Button()
    Me.btnAplicaPago = New System.Windows.Forms.Button()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.txtPrecioCuota = New main.ucTextBoxNumerico()
    Me.ClsInfoPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.txtPrecioTotal = New main.ucTextBoxNumerico()
    Me.NumCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToFechaDeVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToFechaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetodoDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VencimientoCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Panel1.SuspendLayout()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(10, 637)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 60)
    Me.btnCancel.TabIndex = 10
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1280, 25)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "CONTRATO: EDICION"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtNumVenta
    '
    Me.txtNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNumVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumVenta.Location = New System.Drawing.Point(193, 37)
    Me.txtNumVenta.Name = "txtNumVenta"
    Me.txtNumVenta.ReadOnly = True
    Me.txtNumVenta.Size = New System.Drawing.Size(151, 22)
    Me.txtNumVenta.TabIndex = 63
    Me.txtNumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label16
    '
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.Location = New System.Drawing.Point(27, 39)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(155, 20)
    Me.Label16.TabIndex = 62
    Me.Label16.Text = "Numero de Contrato"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Location = New System.Drawing.Point(149, 536)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(103, 16)
    Me.Label13.TabIndex = 53
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(152, 555)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(319, 22)
    Me.txtMedioPagoDescripcion.TabIndex = 52
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderSize = 2
    Me.btnSeleccionarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionarCuenta.ForeColor = System.Drawing.Color.White
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(30, 542)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnSeleccionarCuenta.TabIndex = 51
    Me.btnSeleccionarCuenta.Text = "Seleccionar"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(27, 67)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(143, 20)
    Me.Label2.TabIndex = 47
    Me.Label2.Text = "FechaVenta"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(489, 37)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(168, 20)
    Me.Label3.TabIndex = 42
    Me.Label3.Text = "Valor Total"
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Location = New System.Drawing.Point(27, 95)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(134, 16)
    Me.Label6.TabIndex = 48
    Me.Label6.Text = "Fecha Proximo Pago"
    '
    'Label7
    '
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(27, 125)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(113, 24)
    Me.Label7.TabIndex = 68
    Me.Label7.Text = "Plan de Pagos"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(10, 35)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 60)
    Me.btnGuardar.TabIndex = 69
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Panel1.Controls.Add(Me.txtPrecioCuota)
    Me.Panel1.Controls.Add(Me.Label9)
    Me.Panel1.Controls.Add(Me.txtNombreVendedor)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.txtNombreCliente)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Controls.Add(Me.txtDiaVencimiento)
    Me.Panel1.Controls.Add(Me.txtFechaVenta)
    Me.Panel1.Controls.Add(Me.btnClearPago)
    Me.Panel1.Controls.Add(Me.btnAplicaPago)
    Me.Panel1.Controls.Add(Me.dgvResumen)
    Me.Panel1.Controls.Add(Me.txtPrecioTotal)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.Label6)
    Me.Panel1.Controls.Add(Me.txtNumVenta)
    Me.Panel1.Controls.Add(Me.Label16)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.btnSeleccionarCuenta)
    Me.Panel1.Controls.Add(Me.txtMedioPagoDescripcion)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Panel1.Location = New System.Drawing.Point(148, 35)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1120, 662)
    Me.Panel1.TabIndex = 70
    '
    'Label9
    '
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Location = New System.Drawing.Point(489, 65)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(135, 20)
    Me.Label9.TabIndex = 83
    Me.Label9.Text = "Valor Cuota"
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.Location = New System.Drawing.Point(663, 6)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.ReadOnly = True
    Me.txtNombreVendedor.Size = New System.Drawing.Size(264, 22)
    Me.txtNombreVendedor.TabIndex = 82
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(489, 9)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(168, 22)
    Me.Label8.TabIndex = 81
    Me.Label8.Text = "Nombre Vendedor:"
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.Location = New System.Drawing.Point(193, 9)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.ReadOnly = True
    Me.txtNombreCliente.Size = New System.Drawing.Size(278, 22)
    Me.txtNombreCliente.TabIndex = 80
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(27, 12)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(155, 23)
    Me.Label5.TabIndex = 79
    Me.Label5.Text = "Nombre Cliente:"
    '
    'txtDiaVencimiento
    '
    Me.txtDiaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDiaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDiaVencimiento.Location = New System.Drawing.Point(193, 93)
    Me.txtDiaVencimiento.Name = "txtDiaVencimiento"
    Me.txtDiaVencimiento.ReadOnly = True
    Me.txtDiaVencimiento.Size = New System.Drawing.Size(43, 22)
    Me.txtDiaVencimiento.TabIndex = 78
    Me.txtDiaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtFechaVenta
    '
    Me.txtFechaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtFechaVenta.Location = New System.Drawing.Point(193, 65)
    Me.txtFechaVenta.Name = "txtFechaVenta"
    Me.txtFechaVenta.ReadOnly = True
    Me.txtFechaVenta.Size = New System.Drawing.Size(151, 22)
    Me.txtFechaVenta.TabIndex = 77
    Me.txtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnClearPago
    '
    Me.btnClearPago.Location = New System.Drawing.Point(719, 549)
    Me.btnClearPago.Name = "btnClearPago"
    Me.btnClearPago.Size = New System.Drawing.Size(139, 33)
    Me.btnClearPago.TabIndex = 76
    Me.btnClearPago.Text = "Debe"
    Me.btnClearPago.UseVisualStyleBackColor = True
    '
    'btnAplicaPago
    '
    Me.btnAplicaPago.Location = New System.Drawing.Point(551, 549)
    Me.btnAplicaPago.Name = "btnAplicaPago"
    Me.btnAplicaPago.Size = New System.Drawing.Size(133, 33)
    Me.btnAplicaPago.TabIndex = 75
    Me.btnAplicaPago.Text = "Pago"
    Me.btnAplicaPago.UseVisualStyleBackColor = True
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AllowUserToResizeRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCuotaDataGridViewTextBoxColumn, Me.ToFechaDeVencimientoDataGridViewTextBoxColumn, Me.ToFechaDePagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn, Me.MetodoDePagoDataGridViewTextBoxColumn, Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn, Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn, Me.FechaUltimaExportacionDataGridViewTextBoxColumn, Me.FechaUltimaImportacionDataGridViewTextBoxColumn, Me.IdPagoDataGridViewTextBoxColumn, Me.NumComprobanteDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.GuidCuentaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoPagosBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(30, 152)
    Me.dgvResumen.MultiSelect = False
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.ReadOnly = True
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvResumen.Size = New System.Drawing.Size(1063, 367)
    Me.dgvResumen.TabIndex = 73
    '
    'txtPrecioCuota
    '
    Me.txtPrecioCuota.Limite = 22
    Me.txtPrecioCuota.Location = New System.Drawing.Point(663, 62)
    Me.txtPrecioCuota.Moneda = True
    Me.txtPrecioCuota.Name = "txtPrecioCuota"
    Me.txtPrecioCuota.ReadOnly = True
    Me.txtPrecioCuota.Size = New System.Drawing.Size(123, 22)
    Me.txtPrecioCuota.TabIndex = 84
    Me.txtPrecioCuota.Text = "$ 0,00"
    Me.txtPrecioCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'ClsInfoPagosBindingSource
    '
    Me.ClsInfoPagosBindingSource.DataSource = GetType(manDB.clsInfoPagos)
    '
    'txtPrecioTotal
    '
    Me.txtPrecioTotal.Limite = 22
    Me.txtPrecioTotal.Location = New System.Drawing.Point(663, 34)
    Me.txtPrecioTotal.Moneda = True
    Me.txtPrecioTotal.Name = "txtPrecioTotal"
    Me.txtPrecioTotal.ReadOnly = True
    Me.txtPrecioTotal.Size = New System.Drawing.Size(123, 22)
    Me.txtPrecioTotal.TabIndex = 70
    Me.txtPrecioTotal.Text = "$ 0,00"
    Me.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    Me.NumCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ToFechaDeVencimientoDataGridViewTextBoxColumn
    '
    Me.ToFechaDeVencimientoDataGridViewTextBoxColumn.DataPropertyName = "toFechaDeVencimiento"
    Me.ToFechaDeVencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
    Me.ToFechaDeVencimientoDataGridViewTextBoxColumn.Name = "ToFechaDeVencimientoDataGridViewTextBoxColumn"
    Me.ToFechaDeVencimientoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ToFechaDePagoDataGridViewTextBoxColumn
    '
    Me.ToFechaDePagoDataGridViewTextBoxColumn.DataPropertyName = "toFechaDePago"
    Me.ToFechaDePagoDataGridViewTextBoxColumn.HeaderText = "Pago"
    Me.ToFechaDePagoDataGridViewTextBoxColumn.Name = "ToFechaDePagoDataGridViewTextBoxColumn"
    Me.ToFechaDePagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "Estado de Pago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    Me.EstadoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'MetodoDePagoDataGridViewTextBoxColumn
    '
    Me.MetodoDePagoDataGridViewTextBoxColumn.DataPropertyName = "MetodoDePago"
    Me.MetodoDePagoDataGridViewTextBoxColumn.HeaderText = "Tipo de Cuenta"
    Me.MetodoDePagoDataGridViewTextBoxColumn.Name = "MetodoDePagoDataGridViewTextBoxColumn"
    Me.MetodoDePagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ToFechaUltimaExportacionDataGridViewTextBoxColumn
    '
    Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn.DataPropertyName = "toFechaUltimaExportacion"
    Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn.HeaderText = "Ultima Exportacion"
    Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn.Name = "ToFechaUltimaExportacionDataGridViewTextBoxColumn"
    Me.ToFechaUltimaExportacionDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ToFechaUltimaimportacionDataGridViewTextBoxColumn
    '
    Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn.DataPropertyName = "toFechaUltimaimportacion"
    Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn.HeaderText = "Ultima Importacion"
    Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn.Name = "ToFechaUltimaimportacionDataGridViewTextBoxColumn"
    Me.ToFechaUltimaimportacionDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaUltimaExportacionDataGridViewTextBoxColumn
    '
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimaExportacion"
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.HeaderText = "FechaUltimaExportacion"
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.Name = "FechaUltimaExportacionDataGridViewTextBoxColumn"
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.Visible = False
    '
    'FechaUltimaImportacionDataGridViewTextBoxColumn
    '
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimaImportacion"
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn.HeaderText = "FechaUltimaImportacion"
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn.Name = "FechaUltimaImportacionDataGridViewTextBoxColumn"
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaUltimaImportacionDataGridViewTextBoxColumn.Visible = False
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
    Me.NumComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.HeaderText = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.Name = "NumComprobanteDataGridViewTextBoxColumn"
    Me.NumComprobanteDataGridViewTextBoxColumn.ReadOnly = True
    Me.NumComprobanteDataGridViewTextBoxColumn.Visible = False
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
    'GuidCuentaDataGridViewTextBoxColumn
    '
    Me.GuidCuentaDataGridViewTextBoxColumn.DataPropertyName = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.HeaderText = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.Name = "GuidCuentaDataGridViewTextBoxColumn"
    Me.GuidCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    Me.ValorCuotaDataGridViewTextBoxColumn.Visible = False
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.ReadOnly = True
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Visible = False
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaPagoDataGridViewTextBoxColumn.Visible = False
    '
    'frmEditarPagos
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEditarPagos"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmEstablecerPagos"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNumVenta As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtMedioPagoDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents btnSeleccionarCuenta As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtPrecioTotal As main.ucTextBoxNumerico
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents ClsInfoPagosBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents btnClearPago As System.Windows.Forms.Button
  Friend WithEvents btnAplicaPago As System.Windows.Forms.Button
  Friend WithEvents txtDiaVencimiento As System.Windows.Forms.TextBox
  Friend WithEvents txtFechaVenta As System.Windows.Forms.TextBox
  Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtPrecioCuota As main.ucTextBoxNumerico
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents MetodoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToFechaDeVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToFechaDePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MetodoDePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToFechaUltimaExportacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToFechaUltimaimportacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaUltimaExportacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaUltimaImportacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
