<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarHipotecario
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
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.Exportar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.FechaUltimaExportacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumeroContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoSucCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TipoCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuentaBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoHipotecarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNumeroConvenio = New System.Windows.Forms.TextBox()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtSecuencial = New System.Windows.Forms.TextBox()
    Me.dtCurrent = New System.Windows.Forms.DateTimePicker()
    Me.dtVencimiento = New System.Windows.Forms.DateTimePicker()
    Me.txtIdDebito = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtConcepto = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cmbEstado = New System.Windows.Forms.ComboBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.chkEnableFrom = New System.Windows.Forms.CheckBox()
    Me.dnDayFrom = New System.Windows.Forms.NumericUpDown()
    Me.dnDayTo = New System.Windows.Forms.NumericUpDown()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.pnlFiltrado = New System.Windows.Forms.Panel()
    Me.rbAplicaMesesAnteriores = New System.Windows.Forms.RadioButton()
    Me.rbMesesAnterioresSinFiltro = New System.Windows.Forms.RadioButton()
    Me.rbAplicaMesActual = New System.Windows.Forms.RadioButton()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dnDayFrom, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dnDayTo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlFiltrado.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(10, 637)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 60)
    Me.btnCancel.TabIndex = 43
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'btnProcesar
    '
    Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnProcesar.FlatAppearance.BorderSize = 0
    Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcesar.ForeColor = System.Drawing.Color.White
    Me.btnProcesar.Location = New System.Drawing.Point(10, 35)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 60)
    Me.btnProcesar.TabIndex = 44
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = False
    '
    'btnReload
    '
    Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReload.FlatAppearance.BorderSize = 0
    Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.ForeColor = System.Drawing.Color.White
    Me.btnReload.Location = New System.Drawing.Point(10, 105)
    Me.btnReload.Margin = New System.Windows.Forms.Padding(10)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 60)
    Me.btnReload.TabIndex = 46
    Me.btnReload.Text = "Volver a Cargar"
    Me.btnReload.UseVisualStyleBackColor = False
    '
    'lblResumen
    '
    Me.lblResumen.BackColor = System.Drawing.Color.Transparent
    Me.lblResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblResumen.Location = New System.Drawing.Point(174, 646)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(1078, 65)
    Me.lblResumen.TabIndex = 47
    Me.lblResumen.Text = "Resumen"
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AllowUserToDeleteRows = False
    Me.dgvResumen.AllowUserToResizeRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Exportar, Me.FechaUltimaExportacion, Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.NumeroContratoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CuotaActualDataGridViewTextBoxColumn, Me.CodigoBancoDataGridViewTextBoxColumn, Me.CodigoSucCuentaDataGridViewTextBoxColumn, Me.TipoCuentaDataGridViewTextBoxColumn, Me.CuentaBancoDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoHipotecarioBindingSource
    Me.dgvResumen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvResumen.Location = New System.Drawing.Point(172, 158)
    Me.dgvResumen.MultiSelect = False
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 452)
    Me.dgvResumen.TabIndex = 49
    '
    'Exportar
    '
    Me.Exportar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
    Me.Exportar.DataPropertyName = "Exportar"
    Me.Exportar.FillWeight = 55.39341!
    Me.Exportar.HeaderText = "Exportar"
    Me.Exportar.Name = "Exportar"
    Me.Exportar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
    Me.Exportar.Width = 71
    '
    'FechaUltimaExportacion
    '
    Me.FechaUltimaExportacion.DataPropertyName = "FechaUltimaExportacion"
    Me.FechaUltimaExportacion.FillWeight = 55.39341!
    Me.FechaUltimaExportacion.HeaderText = "FechaUltimaExportacion"
    Me.FechaUltimaExportacion.Name = "FechaUltimaExportacion"
    Me.FechaUltimaExportacion.ReadOnly = True
    '
    'IdClienteDataGridViewTextBoxColumn
    '
    Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
    Me.IdClienteDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
    Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
    Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CBUDataGridViewTextBoxColumn
    '
    Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
    Me.CBUDataGridViewTextBoxColumn.FillWeight = 70.0!
    Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
    Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
    Me.CBUDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumeroContratoDataGridViewTextBoxColumn
    '
    Me.NumeroContratoDataGridViewTextBoxColumn.DataPropertyName = "NumeroContrato"
    Me.NumeroContratoDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.NumeroContratoDataGridViewTextBoxColumn.HeaderText = "NumeroContrato"
    Me.NumeroContratoDataGridViewTextBoxColumn.Name = "NumeroContratoDataGridViewTextBoxColumn"
    Me.NumeroContratoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaVencimientoDataGridViewTextBoxColumn
    '
    Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
    Me.FechaVencimientoDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
    Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
    Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteDataGridViewTextBoxColumn
    '
    Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
    Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotaActualDataGridViewTextBoxColumn
    '
    Me.CuotaActualDataGridViewTextBoxColumn.DataPropertyName = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.FillWeight = 55.39341!
    Me.CuotaActualDataGridViewTextBoxColumn.HeaderText = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.Name = "CuotaActualDataGridViewTextBoxColumn"
    Me.CuotaActualDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CodigoBancoDataGridViewTextBoxColumn
    '
    Me.CodigoBancoDataGridViewTextBoxColumn.DataPropertyName = "CodigoBanco"
    Me.CodigoBancoDataGridViewTextBoxColumn.HeaderText = "CodigoBanco"
    Me.CodigoBancoDataGridViewTextBoxColumn.Name = "CodigoBancoDataGridViewTextBoxColumn"
    Me.CodigoBancoDataGridViewTextBoxColumn.ReadOnly = True
    Me.CodigoBancoDataGridViewTextBoxColumn.Visible = False
    '
    'CodigoSucCuentaDataGridViewTextBoxColumn
    '
    Me.CodigoSucCuentaDataGridViewTextBoxColumn.DataPropertyName = "CodigoSucCuenta"
    Me.CodigoSucCuentaDataGridViewTextBoxColumn.HeaderText = "CodigoSucCuenta"
    Me.CodigoSucCuentaDataGridViewTextBoxColumn.Name = "CodigoSucCuentaDataGridViewTextBoxColumn"
    Me.CodigoSucCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.CodigoSucCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'TipoCuentaDataGridViewTextBoxColumn
    '
    Me.TipoCuentaDataGridViewTextBoxColumn.DataPropertyName = "TipoCuenta"
    Me.TipoCuentaDataGridViewTextBoxColumn.HeaderText = "TipoCuenta"
    Me.TipoCuentaDataGridViewTextBoxColumn.Name = "TipoCuentaDataGridViewTextBoxColumn"
    Me.TipoCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.TipoCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'CuentaBancoDataGridViewTextBoxColumn
    '
    Me.CuentaBancoDataGridViewTextBoxColumn.DataPropertyName = "CuentaBanco"
    Me.CuentaBancoDataGridViewTextBoxColumn.HeaderText = "CuentaBanco"
    Me.CuentaBancoDataGridViewTextBoxColumn.Name = "CuentaBancoDataGridViewTextBoxColumn"
    Me.CuentaBancoDataGridViewTextBoxColumn.ReadOnly = True
    Me.CuentaBancoDataGridViewTextBoxColumn.Visible = False
    '
    'ClsInfoHipotecarioBindingSource
    '
    Me.ClsInfoHipotecarioBindingSource.DataSource = GetType(main.clsInfoExportarHipotecario)
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
    Me.Label2.Location = New System.Drawing.Point(174, 52)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(110, 19)
    Me.Label2.TabIndex = 50
    Me.Label2.Text = "CONVENIO"
    '
    'txtNumeroConvenio
    '
    Me.txtNumeroConvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
    Me.txtNumeroConvenio.Location = New System.Drawing.Point(252, 50)
    Me.txtNumeroConvenio.Name = "txtNumeroConvenio"
    Me.txtNumeroConvenio.Size = New System.Drawing.Size(100, 21)
    Me.txtNumeroConvenio.TabIndex = 51
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(484, 53)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(191, 20)
    Me.txtImporteTotal.TabIndex = 52
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(378, 53)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 20)
    Me.Label3.TabIndex = 53
    Me.Label3.Text = "IMPORTE TOTAL"
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(773, 49)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 23)
    Me.Label4.TabIndex = 54
    Me.Label4.Text = "Fecha Actual"
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Location = New System.Drawing.Point(1016, 49)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 23)
    Me.Label5.TabIndex = 55
    Me.Label5.Text = "Fecha Vencimiento"
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(174, 80)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 20)
    Me.Label6.TabIndex = 58
    Me.Label6.Text = "Secuencial"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtSecuencial
    '
    Me.txtSecuencial.Location = New System.Drawing.Point(252, 80)
    Me.txtSecuencial.Name = "txtSecuencial"
    Me.txtSecuencial.Size = New System.Drawing.Size(100, 20)
    Me.txtSecuencial.TabIndex = 59
    '
    'dtCurrent
    '
    Me.dtCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtCurrent.Location = New System.Drawing.Point(868, 47)
    Me.dtCurrent.Name = "dtCurrent"
    Me.dtCurrent.Size = New System.Drawing.Size(130, 20)
    Me.dtCurrent.TabIndex = 60
    '
    'dtVencimiento
    '
    Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtVencimiento.Location = New System.Drawing.Point(1122, 49)
    Me.dtVencimiento.Name = "dtVencimiento"
    Me.dtVencimiento.Size = New System.Drawing.Size(130, 20)
    Me.dtVencimiento.TabIndex = 61
    '
    'txtIdDebito
    '
    Me.txtIdDebito.Location = New System.Drawing.Point(484, 82)
    Me.txtIdDebito.Name = "txtIdDebito"
    Me.txtIdDebito.Size = New System.Drawing.Size(191, 20)
    Me.txtIdDebito.TabIndex = 63
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(378, 80)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 20)
    Me.Label1.TabIndex = 62
    Me.Label1.Text = "Id. Debito"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtConcepto
    '
    Me.txtConcepto.Location = New System.Drawing.Point(252, 111)
    Me.txtConcepto.Name = "txtConcepto"
    Me.txtConcepto.Size = New System.Drawing.Size(489, 20)
    Me.txtConcepto.TabIndex = 65
    '
    'Label7
    '
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(174, 110)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 20)
    Me.Label7.TabIndex = 64
    Me.Label7.Text = "Concepto"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.White
    Me.Label8.Location = New System.Drawing.Point(0, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(1280, 25)
    Me.Label8.TabIndex = 78
    Me.Label8.Text = "HIPOTECARIO: EXPORTAR DEBITOS DIRECTOS"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'cmbEstado
    '
    Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmbEstado.FormattingEnabled = True
    Me.cmbEstado.Location = New System.Drawing.Point(353, 622)
    Me.cmbEstado.Name = "cmbEstado"
    Me.cmbEstado.Size = New System.Drawing.Size(138, 21)
    Me.cmbEstado.TabIndex = 89
    '
    'Label9
    '
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Location = New System.Drawing.Point(169, 625)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(178, 16)
    Me.Label9.TabIndex = 88
    Me.Label9.Text = "Estado del Contrato"
    '
    'chkEnableFrom
    '
    Me.chkEnableFrom.BackColor = System.Drawing.Color.Transparent
    Me.chkEnableFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkEnableFrom.Location = New System.Drawing.Point(776, 75)
    Me.chkEnableFrom.Name = "chkEnableFrom"
    Me.chkEnableFrom.Size = New System.Drawing.Size(86, 24)
    Me.chkEnableFrom.TabIndex = 92
    Me.chkEnableFrom.Text = "Intervalo"
    Me.chkEnableFrom.UseVisualStyleBackColor = False
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
    'pnlFiltrado
    '
    Me.pnlFiltrado.Controls.Add(Me.rbAplicaMesesAnteriores)
    Me.pnlFiltrado.Controls.Add(Me.rbMesesAnterioresSinFiltro)
    Me.pnlFiltrado.Controls.Add(Me.rbAplicaMesActual)
    Me.pnlFiltrado.Controls.Add(Me.dnDayFrom)
    Me.pnlFiltrado.Controls.Add(Me.dnDayTo)
    Me.pnlFiltrado.Controls.Add(Me.Label10)
    Me.pnlFiltrado.Controls.Add(Me.Label11)
    Me.pnlFiltrado.Location = New System.Drawing.Point(868, 75)
    Me.pnlFiltrado.Name = "pnlFiltrado"
    Me.pnlFiltrado.Size = New System.Drawing.Size(384, 77)
    Me.pnlFiltrado.TabIndex = 99
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
    'frmExportarHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.pnlFiltrado)
    Me.Controls.Add(Me.chkEnableFrom)
    Me.Controls.Add(Me.cmbEstado)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtConcepto)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtIdDebito)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtVencimiento)
    Me.Controls.Add(Me.dtCurrent)
    Me.Controls.Add(Me.txtSecuencial)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.txtNumeroConvenio)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.DoubleBuffered = True
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarHipotecario"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmExportarResumen"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dnDayFrom, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dnDayTo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlFiltrado.ResumeLayout(False)
    Me.pnlFiltrado.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents ClsInfoHipotecarioBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtNumeroConvenio As System.Windows.Forms.TextBox
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtSecuencial As System.Windows.Forms.TextBox
  Friend WithEvents dtCurrent As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtIdDebito As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Exportar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents FechaUltimaExportacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumeroContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaActualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoBancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoSucCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TipoCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuentaBancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents chkEnableFrom As System.Windows.Forms.CheckBox
  Friend WithEvents dnDayFrom As System.Windows.Forms.NumericUpDown
  Friend WithEvents dnDayTo As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents pnlFiltrado As System.Windows.Forms.Panel
  Friend WithEvents rbAplicaMesesAnteriores As System.Windows.Forms.RadioButton
  Friend WithEvents rbMesesAnterioresSinFiltro As System.Windows.Forms.RadioButton
  Friend WithEvents rbAplicaMesActual As System.Windows.Forms.RadioButton
End Class
