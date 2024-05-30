<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajes
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnSeleccionar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.chkPagosIngresados = New System.Windows.Forms.CheckBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.dtPagadosHasta = New System.Windows.Forms.DateTimePicker()
    Me.dtPagadosDesde = New System.Windows.Forms.DateTimePicker()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dgvData1 = New System.Windows.Forms.DataGridView()
    Me.IDContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaNumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MensajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
    Me.MetodoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GUIDCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoConsultaPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.lblCount = New System.Windows.Forms.Label()
    Me.txtFiltro = New System.Windows.Forms.TextBox()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ttCopiar = New System.Windows.Forms.ToolStripTextBox()
    Me.Panel1.SuspendLayout()
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoConsultaPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1280, 25)
    Me.Label1.TabIndex = 30
    Me.Label1.Text = "LISTA DE CLIENTES"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionar.FlatAppearance.BorderSize = 0
    Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
    Me.btnSeleccionar.Location = New System.Drawing.Point(10, 46)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 60)
    Me.btnSeleccionar.TabIndex = 43
    Me.btnSeleccionar.Text = "Seleccionar"
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    Me.btnSeleccionar.Visible = False
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(10, 637)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 60)
    Me.btnVolver.TabIndex = 42
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Panel1.Controls.Add(Me.chkPagosIngresados)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.dtPagadosHasta)
    Me.Panel1.Controls.Add(Me.dtPagadosDesde)
    Me.Panel1.Controls.Add(Me.btnExportar)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dgvData1)
    Me.Panel1.Controls.Add(Me.lblCount)
    Me.Panel1.Controls.Add(Me.txtFiltro)
    Me.Panel1.Controls.Add(Me.btnBuscar)
    Me.Panel1.Location = New System.Drawing.Point(138, 46)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1120, 662)
    Me.Panel1.TabIndex = 44
    '
    'chkPagosIngresados
    '
    Me.chkPagosIngresados.Checked = True
    Me.chkPagosIngresados.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkPagosIngresados.Location = New System.Drawing.Point(386, 12)
    Me.chkPagosIngresados.Name = "chkPagosIngresados"
    Me.chkPagosIngresados.Size = New System.Drawing.Size(123, 25)
    Me.chkPagosIngresados.TabIndex = 48
    Me.chkPagosIngresados.Text = "Pagos Ingresados"
    Me.chkPagosIngresados.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(20, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(67, 24)
    Me.Label3.TabIndex = 47
    Me.Label3.Text = "Hasta:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtPagadosHasta
    '
    Me.dtPagadosHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtPagadosHasta.Location = New System.Drawing.Point(110, 41)
    Me.dtPagadosHasta.Name = "dtPagadosHasta"
    Me.dtPagadosHasta.Size = New System.Drawing.Size(235, 22)
    Me.dtPagadosHasta.TabIndex = 45
    '
    'dtPagadosDesde
    '
    Me.dtPagadosDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtPagadosDesde.Location = New System.Drawing.Point(110, 13)
    Me.dtPagadosDesde.Name = "dtPagadosDesde"
    Me.dtPagadosDesde.Size = New System.Drawing.Size(235, 22)
    Me.dtPagadosDesde.TabIndex = 46
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnExportar.FlatAppearance.BorderSize = 0
    Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ForeColor = System.Drawing.Color.White
    Me.btnExportar.Location = New System.Drawing.Point(984, 17)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 60)
    Me.btnExportar.TabIndex = 44
    Me.btnExportar.Text = "Exportar"
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(20, 13)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(67, 24)
    Me.Label2.TabIndex = 35
    Me.Label2.Text = "Desde:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dgvData1
    '
    Me.dgvData1.AllowUserToAddRows = False
    Me.dgvData1.AllowUserToDeleteRows = False
    Me.dgvData1.AllowUserToResizeRows = False
    Me.dgvData1.AutoGenerateColumns = False
    Me.dgvData1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvData1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvData1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvData1.ColumnHeadersHeight = 24
    Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDContratoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.IDClienteDataGridViewTextBoxColumn, Me.ClienteNombreDataGridViewTextBoxColumn, Me.ClienteApellidoDataGridViewTextBoxColumn, Me.CuotaNumeroDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.ValorTotalDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.MensajeDataGridViewTextBoxColumn, Me.MetodoPagoDataGridViewTextBoxColumn, Me.GUIDCuentaDataGridViewTextBoxColumn})
    Me.dgvData1.DataSource = Me.ClsInfoConsultaPagosBindingSource
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvData1.DefaultCellStyle = DataGridViewCellStyle10
    Me.dgvData1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvData1.EnableHeadersVisualStyles = False
    Me.dgvData1.GridColor = System.Drawing.Color.White
    Me.dgvData1.Location = New System.Drawing.Point(23, 109)
    Me.dgvData1.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvData1.MultiSelect = False
    Me.dgvData1.Name = "dgvData1"
    Me.dgvData1.ReadOnly = True
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
    Me.dgvData1.RowHeadersVisible = False
    Me.dgvData1.RowTemplate.Height = 24
    Me.dgvData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData1.Size = New System.Drawing.Size(1071, 523)
    Me.dgvData1.TabIndex = 24
    Me.dgvData1.TabStop = False
    '
    'IDContratoDataGridViewTextBoxColumn
    '
    Me.IDContratoDataGridViewTextBoxColumn.DataPropertyName = "IDContrato"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.IDContratoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
    Me.IDContratoDataGridViewTextBoxColumn.HeaderText = "IDContrato"
    Me.IDContratoDataGridViewTextBoxColumn.Name = "IDContratoDataGridViewTextBoxColumn"
    Me.IDContratoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ClienteDataGridViewTextBoxColumn
    '
    Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
    Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'IDClienteDataGridViewTextBoxColumn
    '
    Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.IDClienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
    Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
    Me.IDClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ClienteNombreDataGridViewTextBoxColumn
    '
    Me.ClienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre"
    Me.ClienteNombreDataGridViewTextBoxColumn.HeaderText = "ClienteNombre"
    Me.ClienteNombreDataGridViewTextBoxColumn.Name = "ClienteNombreDataGridViewTextBoxColumn"
    Me.ClienteNombreDataGridViewTextBoxColumn.ReadOnly = True
    Me.ClienteNombreDataGridViewTextBoxColumn.Visible = False
    '
    'ClienteApellidoDataGridViewTextBoxColumn
    '
    Me.ClienteApellidoDataGridViewTextBoxColumn.DataPropertyName = "ClienteApellido"
    Me.ClienteApellidoDataGridViewTextBoxColumn.HeaderText = "ClienteApellido"
    Me.ClienteApellidoDataGridViewTextBoxColumn.Name = "ClienteApellidoDataGridViewTextBoxColumn"
    Me.ClienteApellidoDataGridViewTextBoxColumn.ReadOnly = True
    Me.ClienteApellidoDataGridViewTextBoxColumn.Visible = False
    '
    'CuotaNumeroDataGridViewTextBoxColumn
    '
    Me.CuotaNumeroDataGridViewTextBoxColumn.DataPropertyName = "CuotaNumero"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.CuotaNumeroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
    Me.CuotaNumeroDataGridViewTextBoxColumn.HeaderText = "CuotaNumero"
    Me.CuotaNumeroDataGridViewTextBoxColumn.Name = "CuotaNumeroDataGridViewTextBoxColumn"
    Me.CuotaNumeroDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.ValorCuotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.FechaPagoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'TotalCuotasDataGridViewTextBoxColumn
    '
    Me.TotalCuotasDataGridViewTextBoxColumn.DataPropertyName = "TotalCuotas"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.TotalCuotasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
    Me.TotalCuotasDataGridViewTextBoxColumn.HeaderText = "TotalCuotas"
    Me.TotalCuotasDataGridViewTextBoxColumn.Name = "TotalCuotasDataGridViewTextBoxColumn"
    Me.TotalCuotasDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorTotalDataGridViewTextBoxColumn
    '
    Me.ValorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.ValorTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
    Me.ValorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal"
    Me.ValorTotalDataGridViewTextBoxColumn.Name = "ValorTotalDataGridViewTextBoxColumn"
    Me.ValorTotalDataGridViewTextBoxColumn.ReadOnly = True
    '
    'Telefono1DataGridViewTextBoxColumn
    '
    Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.Telefono1DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
    Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1"
    Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
    Me.Telefono1DataGridViewTextBoxColumn.ReadOnly = True
    '
    'MensajeDataGridViewTextBoxColumn
    '
    Me.MensajeDataGridViewTextBoxColumn.DataPropertyName = "Mensaje"
    Me.MensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje"
    Me.MensajeDataGridViewTextBoxColumn.Name = "MensajeDataGridViewTextBoxColumn"
    Me.MensajeDataGridViewTextBoxColumn.ReadOnly = True
    Me.MensajeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MensajeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'MetodoPagoDataGridViewTextBoxColumn
    '
    Me.MetodoPagoDataGridViewTextBoxColumn.DataPropertyName = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn.HeaderText = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn.Name = "MetodoPagoDataGridViewTextBoxColumn"
    Me.MetodoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GUIDCuentaDataGridViewTextBoxColumn
    '
    Me.GUIDCuentaDataGridViewTextBoxColumn.DataPropertyName = "GUID_Cuenta"
    Me.GUIDCuentaDataGridViewTextBoxColumn.HeaderText = "GUID_Cuenta"
    Me.GUIDCuentaDataGridViewTextBoxColumn.Name = "GUIDCuentaDataGridViewTextBoxColumn"
    Me.GUIDCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.GUIDCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'ClsInfoConsultaPagosBindingSource
    '
    Me.ClsInfoConsultaPagosBindingSource.DataSource = GetType(main.clsInfoConsultaPagos)
    '
    'lblCount
    '
    Me.lblCount.BackColor = System.Drawing.Color.Transparent
    Me.lblCount.Location = New System.Drawing.Point(20, 70)
    Me.lblCount.Name = "lblCount"
    Me.lblCount.Size = New System.Drawing.Size(214, 26)
    Me.lblCount.TabIndex = 40
    Me.lblCount.Text = " "
    '
    'txtFiltro
    '
    Me.txtFiltro.Location = New System.Drawing.Point(271, 76)
    Me.txtFiltro.Name = "txtFiltro"
    Me.txtFiltro.Size = New System.Drawing.Size(292, 20)
    Me.txtFiltro.TabIndex = 1
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBuscar.FlatAppearance.BorderSize = 0
    Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ForeColor = System.Drawing.Color.White
    Me.btnBuscar.Location = New System.Drawing.Point(868, 17)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 61)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttCopiar})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 22)
    '
    'ttCopiar
    '
    Me.ttCopiar.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.ttCopiar.Name = "ttCopiar"
    Me.ttCopiar.ReadOnly = True
    Me.ttCopiar.Size = New System.Drawing.Size(100, 16)
    Me.ttCopiar.Text = "Copiar"
    '
    'frmMensajes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmMensajes"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmMensajes"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoConsultaPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ContextMenuStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Public WithEvents dgvData1 As System.Windows.Forms.DataGridView
  Friend WithEvents lblCount As System.Windows.Forms.Label
  Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents dtPagadosHasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtPagadosDesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkPagosIngresados As System.Windows.Forms.CheckBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents VendidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaFinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GUIDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClsInfoConsultaPagosBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents IDContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaNumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Telefono1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MensajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewLinkColumn
  Friend WithEvents MetodoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GUIDCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents ttCopiar As System.Windows.Forms.ToolStripTextBox
End Class
