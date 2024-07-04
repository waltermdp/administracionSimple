<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarVisaCredito
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
    Me.txtRazonSocial = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtProducto = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtVencimiento = New System.Windows.Forms.DateTimePicker()
    Me.dtCurrent = New System.Windows.Forms.DateTimePicker()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.ExportarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdentificadorDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumeroTarjetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumeroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoDeAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoExportarVisaCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.txtReferencia = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtNroCUIT = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cmbEstado = New System.Windows.Forms.ComboBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.pnlFiltrado = New System.Windows.Forms.Panel()
    Me.rbAplicaMesesAnteriores = New System.Windows.Forms.RadioButton()
    Me.rbMesesAnterioresSinFiltro = New System.Windows.Forms.RadioButton()
    Me.rbAplicaMesActual = New System.Windows.Forms.RadioButton()
    Me.dnDayFrom = New System.Windows.Forms.NumericUpDown()
    Me.dnDayTo = New System.Windows.Forms.NumericUpDown()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.chkEnableFrom = New System.Windows.Forms.CheckBox()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoExportarVisaCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlFiltrado.SuspendLayout()
    CType(Me.dnDayFrom, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dnDayTo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtRazonSocial
    '
    Me.txtRazonSocial.Location = New System.Drawing.Point(433, 42)
    Me.txtRazonSocial.Name = "txtRazonSocial"
    Me.txtRazonSocial.Size = New System.Drawing.Size(306, 20)
    Me.txtRazonSocial.TabIndex = 84
    '
    'Label7
    '
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(355, 41)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 20)
    Me.Label7.TabIndex = 83
    Me.Label7.Text = "Razon Social"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtProducto
    '
    Me.txtProducto.Location = New System.Drawing.Point(247, 97)
    Me.txtProducto.Name = "txtProducto"
    Me.txtProducto.Size = New System.Drawing.Size(133, 20)
    Me.txtProducto.TabIndex = 82
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(169, 97)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 20)
    Me.Label1.TabIndex = 81
    Me.Label1.Text = "Producto"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtVencimiento
    '
    Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtVencimiento.Location = New System.Drawing.Point(1122, 40)
    Me.dtVencimiento.Name = "dtVencimiento"
    Me.dtVencimiento.Size = New System.Drawing.Size(130, 20)
    Me.dtVencimiento.TabIndex = 80
    '
    'dtCurrent
    '
    Me.dtCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtCurrent.Location = New System.Drawing.Point(836, 39)
    Me.dtCurrent.Name = "dtCurrent"
    Me.dtCurrent.Size = New System.Drawing.Size(130, 20)
    Me.dtCurrent.TabIndex = 79
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Location = New System.Drawing.Point(1016, 42)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 23)
    Me.Label5.TabIndex = 76
    Me.Label5.Text = "Fecha Vencimiento"
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(754, 42)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 23)
    Me.Label4.TabIndex = 75
    Me.Label4.Text = "Fecha Actual"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(169, 77)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 20)
    Me.Label3.TabIndex = 74
    Me.Label3.Text = "IMPORTE TOTAL"
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(275, 74)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(133, 20)
    Me.txtImporteTotal.TabIndex = 73
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExportarDataGridViewCheckBoxColumn, Me.FechaUltimaExportacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IdentificadorDebitoDataGridViewTextBoxColumn, Me.NumeroTarjetaDataGridViewTextBoxColumn, Me.NumeroComprobanteDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CuotaActualDataGridViewTextBoxColumn, Me.FechaVtoDataGridViewTextBoxColumn, Me.EstadoContratoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.CodigoDeAltaDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoExportarVisaCreditoBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(172, 148)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 462)
    Me.dgvResumen.TabIndex = 70
    '
    'ExportarDataGridViewCheckBoxColumn
    '
    Me.ExportarDataGridViewCheckBoxColumn.DataPropertyName = "Exportar"
    Me.ExportarDataGridViewCheckBoxColumn.HeaderText = "Exportar"
    Me.ExportarDataGridViewCheckBoxColumn.Name = "ExportarDataGridViewCheckBoxColumn"
    '
    'FechaUltimaExportacionDataGridViewTextBoxColumn
    '
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimaExportacion"
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.HeaderText = "FechaUltimaExportacion"
    Me.FechaUltimaExportacionDataGridViewTextBoxColumn.Name = "FechaUltimaExportacionDataGridViewTextBoxColumn"
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    '
    'IdentificadorDebitoDataGridViewTextBoxColumn
    '
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorDebito"
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.HeaderText = "IdentificadorDebito"
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.Name = "IdentificadorDebitoDataGridViewTextBoxColumn"
    '
    'NumeroTarjetaDataGridViewTextBoxColumn
    '
    Me.NumeroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NumeroTarjeta"
    Me.NumeroTarjetaDataGridViewTextBoxColumn.HeaderText = "NumeroTarjeta"
    Me.NumeroTarjetaDataGridViewTextBoxColumn.Name = "NumeroTarjetaDataGridViewTextBoxColumn"
    '
    'NumeroComprobanteDataGridViewTextBoxColumn
    '
    Me.NumeroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumeroComprobante"
    Me.NumeroComprobanteDataGridViewTextBoxColumn.HeaderText = "NumeroComprobante"
    Me.NumeroComprobanteDataGridViewTextBoxColumn.Name = "NumeroComprobanteDataGridViewTextBoxColumn"
    '
    'ImporteDataGridViewTextBoxColumn
    '
    Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
    '
    'CuotaActualDataGridViewTextBoxColumn
    '
    Me.CuotaActualDataGridViewTextBoxColumn.DataPropertyName = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.HeaderText = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.Name = "CuotaActualDataGridViewTextBoxColumn"
    '
    'FechaVtoDataGridViewTextBoxColumn
    '
    Me.FechaVtoDataGridViewTextBoxColumn.DataPropertyName = "FechaVto"
    Me.FechaVtoDataGridViewTextBoxColumn.HeaderText = "FechaVto"
    Me.FechaVtoDataGridViewTextBoxColumn.Name = "FechaVtoDataGridViewTextBoxColumn"
    '
    'EstadoContratoDataGridViewTextBoxColumn
    '
    Me.EstadoContratoDataGridViewTextBoxColumn.DataPropertyName = "EstadoContrato"
    Me.EstadoContratoDataGridViewTextBoxColumn.HeaderText = "EstadoContrato"
    Me.EstadoContratoDataGridViewTextBoxColumn.Name = "EstadoContratoDataGridViewTextBoxColumn"
    Me.EstadoContratoDataGridViewTextBoxColumn.Visible = False
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    Me.GuidPagoDataGridViewTextBoxColumn.Visible = False
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    Me.GuidProductoDataGridViewTextBoxColumn.Visible = False
    '
    'CodigoDeAltaDataGridViewTextBoxColumn
    '
    Me.CodigoDeAltaDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeAlta"
    Me.CodigoDeAltaDataGridViewTextBoxColumn.HeaderText = "CodigoDeAlta"
    Me.CodigoDeAltaDataGridViewTextBoxColumn.Name = "CodigoDeAltaDataGridViewTextBoxColumn"
    '
    'ClsInfoExportarVisaCreditoBindingSource
    '
    Me.ClsInfoExportarVisaCreditoBindingSource.DataSource = GetType(main.clsInfoExportarVisaCredito)
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.BackColor = System.Drawing.Color.Transparent
    Me.lblResumen.Location = New System.Drawing.Point(169, 646)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 69
    Me.lblResumen.Text = "Resumen"
    '
    'btnReload
    '
    Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReload.FlatAppearance.BorderSize = 0
    Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.ForeColor = System.Drawing.Color.White
    Me.btnReload.Location = New System.Drawing.Point(10, 105)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 60)
    Me.btnReload.TabIndex = 68
    Me.btnReload.Text = "Volver a Cargar"
    Me.btnReload.UseVisualStyleBackColor = False
    '
    'btnProcesar
    '
    Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnProcesar.FlatAppearance.BorderSize = 0
    Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcesar.ForeColor = System.Drawing.Color.White
    Me.btnProcesar.Location = New System.Drawing.Point(10, 35)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 60)
    Me.btnProcesar.TabIndex = 67
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = False
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
    Me.btnCancel.TabIndex = 66
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'txtReferencia
    '
    Me.txtReferencia.Location = New System.Drawing.Point(539, 74)
    Me.txtReferencia.Name = "txtReferencia"
    Me.txtReferencia.Size = New System.Drawing.Size(191, 20)
    Me.txtReferencia.TabIndex = 86
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Location = New System.Drawing.Point(432, 74)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(101, 20)
    Me.Label8.TabIndex = 85
    Me.Label8.Text = "Referencia Debito"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtNroCUIT
    '
    Me.txtNroCUIT.Location = New System.Drawing.Point(247, 42)
    Me.txtNroCUIT.Name = "txtNroCUIT"
    Me.txtNroCUIT.Size = New System.Drawing.Size(100, 20)
    Me.txtNroCUIT.TabIndex = 88
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(169, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 16)
    Me.Label2.TabIndex = 87
    Me.Label2.Text = "Nro CUIT"
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.White
    Me.Label6.Location = New System.Drawing.Point(0, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(1280, 25)
    Me.Label6.TabIndex = 89
    Me.Label6.Text = "Visa Credito: Exportar Debitos Directos"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'cmbEstado
    '
    Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmbEstado.FormattingEnabled = True
    Me.cmbEstado.Location = New System.Drawing.Point(353, 617)
    Me.cmbEstado.Name = "cmbEstado"
    Me.cmbEstado.Size = New System.Drawing.Size(138, 21)
    Me.cmbEstado.TabIndex = 93
    '
    'Label9
    '
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Location = New System.Drawing.Point(169, 620)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(178, 16)
    Me.Label9.TabIndex = 92
    Me.Label9.Text = "Estado del Contrato"
    '
    'pnlFiltrado
    '
    Me.pnlFiltrado.Controls.Add(Me.rbAplicaMesesAnteriores)
    Me.pnlFiltrado.Controls.Add(Me.rbMesesAnterioresSinFiltro)
    Me.pnlFiltrado.Controls.Add(Me.rbAplicaMesActual)
    Me.pnlFiltrado.Controls.Add(Me.dnDayFrom)
    Me.pnlFiltrado.Controls.Add(Me.dnDayTo)
    Me.pnlFiltrado.Controls.Add(Me.Label10)
    Me.pnlFiltrado.Controls.Add(Me.Label11)
    Me.pnlFiltrado.Location = New System.Drawing.Point(868, 65)
    Me.pnlFiltrado.Name = "pnlFiltrado"
    Me.pnlFiltrado.Size = New System.Drawing.Size(384, 77)
    Me.pnlFiltrado.TabIndex = 101
    '
    'rbAplicaMesesAnteriores
    '
    Me.rbAplicaMesesAnteriores.AutoSize = True
    Me.rbAplicaMesesAnteriores.Location = New System.Drawing.Point(163, 33)
    Me.rbAplicaMesesAnteriores.Name = "rbAplicaMesesAnteriores"
    Me.rbAplicaMesesAnteriores.Size = New System.Drawing.Size(148, 17)
    Me.rbAplicaMesesAnteriores.TabIndex = 102
    Me.rbAplicaMesesAnteriores.Text = "Aplicar a meses anteriores"
    Me.rbAplicaMesesAnteriores.UseVisualStyleBackColor = True
    '
    'rbMesesAnterioresSinFiltro
    '
    Me.rbMesesAnterioresSinFiltro.AutoSize = True
    Me.rbMesesAnterioresSinFiltro.Location = New System.Drawing.Point(21, 53)
    Me.rbMesesAnterioresSinFiltro.Name = "rbMesesAnterioresSinFiltro"
    Me.rbMesesAnterioresSinFiltro.Size = New System.Drawing.Size(185, 17)
    Me.rbMesesAnterioresSinFiltro.TabIndex = 101
    Me.rbMesesAnterioresSinFiltro.Text = "Incluir meses anteriores sin filtrado"
    Me.rbMesesAnterioresSinFiltro.UseVisualStyleBackColor = True
    '
    'rbAplicaMesActual
    '
    Me.rbAplicaMesActual.AutoSize = True
    Me.rbAplicaMesActual.Checked = True
    Me.rbAplicaMesActual.Location = New System.Drawing.Point(21, 33)
    Me.rbAplicaMesActual.Name = "rbAplicaMesActual"
    Me.rbAplicaMesActual.Size = New System.Drawing.Size(99, 17)
    Me.rbAplicaMesActual.TabIndex = 100
    Me.rbAplicaMesActual.TabStop = True
    Me.rbAplicaMesActual.Text = "Solo MesActual"
    Me.rbAplicaMesActual.UseVisualStyleBackColor = True
    '
    'dnDayFrom
    '
    Me.dnDayFrom.Location = New System.Drawing.Point(90, 5)
    Me.dnDayFrom.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
    Me.dnDayFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.dnDayFrom.Name = "dnDayFrom"
    Me.dnDayFrom.Size = New System.Drawing.Size(44, 20)
    Me.dnDayFrom.TabIndex = 93
    Me.dnDayFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'dnDayTo
    '
    Me.dnDayTo.Location = New System.Drawing.Point(209, 5)
    Me.dnDayTo.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
    Me.dnDayTo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.dnDayTo.Name = "dnDayTo"
    Me.dnDayTo.Size = New System.Drawing.Size(44, 20)
    Me.dnDayTo.TabIndex = 94
    Me.dnDayTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label10
    '
    Me.Label10.BackColor = System.Drawing.Color.Transparent
    Me.Label10.Location = New System.Drawing.Point(18, 7)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(63, 23)
    Me.Label10.TabIndex = 95
    Me.Label10.Text = "Desde:"
    '
    'Label11
    '
    Me.Label11.BackColor = System.Drawing.Color.Transparent
    Me.Label11.Location = New System.Drawing.Point(140, 7)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(63, 23)
    Me.Label11.TabIndex = 96
    Me.Label11.Text = "Hasta:"
    '
    'chkEnableFrom
    '
    Me.chkEnableFrom.BackColor = System.Drawing.Color.Transparent
    Me.chkEnableFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkEnableFrom.Location = New System.Drawing.Point(776, 65)
    Me.chkEnableFrom.Name = "chkEnableFrom"
    Me.chkEnableFrom.Size = New System.Drawing.Size(86, 24)
    Me.chkEnableFrom.TabIndex = 100
    Me.chkEnableFrom.Text = "Intervalo"
    Me.chkEnableFrom.UseVisualStyleBackColor = False
    '
    'frmExportarVisaCredito
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.pnlFiltrado)
    Me.Controls.Add(Me.chkEnableFrom)
    Me.Controls.Add(Me.cmbEstado)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtNroCUIT)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtReferencia)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtRazonSocial)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtProducto)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtVencimiento)
    Me.Controls.Add(Me.dtCurrent)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarVisaCredito"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmExportarPatagonia"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoExportarVisaCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlFiltrado.ResumeLayout(False)
    Me.pnlFiltrado.PerformLayout()
    CType(Me.dnDayFrom, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dnDayTo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout

End Sub
  Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtProducto As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtCurrent As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtNroCUIT As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents IDClienteEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents ClsInfoExportarVisaCreditoBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ExportarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents FechaUltimaExportacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdentificadorDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumeroTarjetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumeroComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaActualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoDeAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents pnlFiltrado As System.Windows.Forms.Panel
  Friend WithEvents rbAplicaMesesAnteriores As System.Windows.Forms.RadioButton
  Friend WithEvents rbMesesAnterioresSinFiltro As System.Windows.Forms.RadioButton
  Friend WithEvents rbAplicaMesActual As System.Windows.Forms.RadioButton
  Friend WithEvents dnDayFrom As System.Windows.Forms.NumericUpDown
  Friend WithEvents dnDayTo As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents chkEnableFrom As System.Windows.Forms.CheckBox
End Class
