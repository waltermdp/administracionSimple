<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeben
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeben))
    Me.dateInicio = New System.Windows.Forms.DateTimePicker()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.dateFin = New System.Windows.Forms.DateTimePicker()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.rbtnVendidos = New System.Windows.Forms.RadioButton()
    Me.rbtnDeben = New System.Windows.Forms.RadioButton()
    Me.rbtnCuotaPagaron = New System.Windows.Forms.RadioButton()
    Me.rbtnCancelados = New System.Windows.Forms.RadioButton()
    Me.btnLstVendedores = New System.Windows.Forms.Button()
    Me.btnListaClientes = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEditarVenta = New System.Windows.Forms.Button()
    Me.btnArticulos = New System.Windows.Forms.Button()
    Me.btnUpPago = New System.Windows.Forms.Button()
    Me.btnDownPago = New System.Windows.Forms.Button()
    Me.dgvData = New System.Windows.Forms.DataGridView()
    Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ArticulosVendidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasTotalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasPagasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetodoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaUltimoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.AdelantoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaFijaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsInfoPrincipal = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnLiquidVendedores = New System.Windows.Forms.Button()
    Me.btnConfiguracion = New System.Windows.Forms.Button()
    Me.txtBusqueda = New System.Windows.Forms.TextBox()
    Me.gpxBuscar = New System.Windows.Forms.GroupBox()
    Me.rbtnSinEntregar = New System.Windows.Forms.RadioButton()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.rbtnClientName = New System.Windows.Forms.RadioButton()
    Me.cmbMetodosDePago = New System.Windows.Forms.ComboBox()
    Me.lblInfoFiltro = New System.Windows.Forms.Label()
    Me.rbtnNombreVendedor = New System.Windows.Forms.RadioButton()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.lblTotalProductos = New System.Windows.Forms.Label()
    Me.lblTotalArticulos = New System.Windows.Forms.Label()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.lblPrecioInteres = New System.Windows.Forms.Label()
    Me.lblPorcentaje = New System.Windows.Forms.Label()
    Me.lblPagos = New System.Windows.Forms.Label()
    Me.lblPrecioTotal = New System.Windows.Forms.Label()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.tbBuscar = New System.Windows.Forms.TabPage()
    Me.tbResumen = New System.Windows.Forms.TabPage()
    Me.tbPagos = New System.Windows.Forms.TabPage()
    Me.tbOperaciones = New System.Windows.Forms.TabPage()
    Me.btnModificarFormadePago = New System.Windows.Forms.Button()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.gpPagarCuota = New System.Windows.Forms.GroupBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cmbNumCuotasCancelar = New System.Windows.Forms.ComboBox()
    Me.lblInfodeFormadePago = New System.Windows.Forms.Label()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsInfoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpxBuscar.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.tbBuscar.SuspendLayout()
    Me.tbResumen.SuspendLayout()
    Me.tbPagos.SuspendLayout()
    Me.tbOperaciones.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.gpPagarCuota.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.SuspendLayout()
    '
    'dateInicio
    '
    Me.dateInicio.Location = New System.Drawing.Point(18, 39)
    Me.dateInicio.Name = "dateInicio"
    Me.dateInicio.Size = New System.Drawing.Size(235, 21)
    Me.dateInicio.TabIndex = 2
    '
    'btnBack
    '
    Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBack.FlatAppearance.BorderSize = 0
    Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
    Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBack.ForeColor = System.Drawing.Color.White
    Me.btnBack.Location = New System.Drawing.Point(24, 636)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(110, 61)
    Me.btnBack.TabIndex = 3
    Me.btnBack.Text = "Cerrar"
    Me.btnBack.UseVisualStyleBackColor = False
    '
    'dateFin
    '
    Me.dateFin.Location = New System.Drawing.Point(259, 39)
    Me.dateFin.Name = "dateFin"
    Me.dateFin.Size = New System.Drawing.Size(232, 21)
    Me.dateFin.TabIndex = 28
    '
    'btnBuscar
    '
    Me.btnBuscar.Location = New System.Drawing.Point(548, 30)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(85, 43)
    Me.btnBuscar.TabIndex = 29
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(15, 23)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(90, 15)
    Me.Label3.TabIndex = 32
    Me.Label3.Text = "Fecha de Inicio"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(256, 23)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(71, 15)
    Me.Label4.TabIndex = 33
    Me.Label4.Text = "Fecha Final"
    '
    'rbtnVendidos
    '
    Me.rbtnVendidos.AutoSize = True
    Me.rbtnVendidos.Location = New System.Drawing.Point(18, 76)
    Me.rbtnVendidos.Name = "rbtnVendidos"
    Me.rbtnVendidos.Size = New System.Drawing.Size(134, 19)
    Me.rbtnVendidos.TabIndex = 34
    Me.rbtnVendidos.TabStop = True
    Me.rbtnVendidos.Text = "Productos Vendidos"
    Me.rbtnVendidos.UseVisualStyleBackColor = True
    '
    'rbtnDeben
    '
    Me.rbtnDeben.AutoSize = True
    Me.rbtnDeben.Location = New System.Drawing.Point(18, 99)
    Me.rbtnDeben.Name = "rbtnDeben"
    Me.rbtnDeben.Size = New System.Drawing.Size(155, 19)
    Me.rbtnDeben.TabIndex = 35
    Me.rbtnDeben.TabStop = True
    Me.rbtnDeben.Text = "Productos Deben Cuota"
    Me.rbtnDeben.UseVisualStyleBackColor = True
    '
    'rbtnCuotaPagaron
    '
    Me.rbtnCuotaPagaron.AutoSize = True
    Me.rbtnCuotaPagaron.Location = New System.Drawing.Point(171, 99)
    Me.rbtnCuotaPagaron.Name = "rbtnCuotaPagaron"
    Me.rbtnCuotaPagaron.Size = New System.Drawing.Size(130, 19)
    Me.rbtnCuotaPagaron.TabIndex = 37
    Me.rbtnCuotaPagaron.TabStop = True
    Me.rbtnCuotaPagaron.Text = "Productos Pagaron"
    Me.rbtnCuotaPagaron.UseVisualStyleBackColor = True
    '
    'rbtnCancelados
    '
    Me.rbtnCancelados.AutoSize = True
    Me.rbtnCancelados.Location = New System.Drawing.Point(171, 76)
    Me.rbtnCancelados.Name = "rbtnCancelados"
    Me.rbtnCancelados.Size = New System.Drawing.Size(148, 19)
    Me.rbtnCancelados.TabIndex = 36
    Me.rbtnCancelados.TabStop = True
    Me.rbtnCancelados.Text = "Productos Cancelados"
    Me.rbtnCancelados.UseVisualStyleBackColor = True
    '
    'btnLstVendedores
    '
    Me.btnLstVendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLstVendedores.FlatAppearance.BorderSize = 0
    Me.btnLstVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLstVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLstVendedores.ForeColor = System.Drawing.Color.White
    Me.btnLstVendedores.Location = New System.Drawing.Point(24, 489)
    Me.btnLstVendedores.Name = "btnLstVendedores"
    Me.btnLstVendedores.Size = New System.Drawing.Size(110, 61)
    Me.btnLstVendedores.TabIndex = 38
    Me.btnLstVendedores.Text = "Lista de Vendedores"
    Me.btnLstVendedores.UseVisualStyleBackColor = False
    '
    'btnListaClientes
    '
    Me.btnListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnListaClientes.FlatAppearance.BorderSize = 0
    Me.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListaClientes.ForeColor = System.Drawing.Color.White
    Me.btnListaClientes.Location = New System.Drawing.Point(24, 416)
    Me.btnListaClientes.Margin = New System.Windows.Forms.Padding(0)
    Me.btnListaClientes.Name = "btnListaClientes"
    Me.btnListaClientes.Size = New System.Drawing.Size(110, 61)
    Me.btnListaClientes.TabIndex = 39
    Me.btnListaClientes.Text = "Lista de Clientes"
    Me.btnListaClientes.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(24, 51)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 61)
    Me.btnNuevo.TabIndex = 40
    Me.btnNuevo.Text = "Venta Nueva"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnEditarVenta
    '
    Me.btnEditarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditarVenta.FlatAppearance.BorderSize = 0
    Me.btnEditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditarVenta.ForeColor = System.Drawing.Color.White
    Me.btnEditarVenta.Location = New System.Drawing.Point(24, 125)
    Me.btnEditarVenta.Name = "btnEditarVenta"
    Me.btnEditarVenta.Size = New System.Drawing.Size(110, 61)
    Me.btnEditarVenta.TabIndex = 41
    Me.btnEditarVenta.Text = "Modificar Venta"
    Me.btnEditarVenta.UseVisualStyleBackColor = False
    '
    'btnArticulos
    '
    Me.btnArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnArticulos.FlatAppearance.BorderSize = 0
    Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnArticulos.ForeColor = System.Drawing.Color.White
    Me.btnArticulos.Location = New System.Drawing.Point(24, 343)
    Me.btnArticulos.Margin = New System.Windows.Forms.Padding(0)
    Me.btnArticulos.Name = "btnArticulos"
    Me.btnArticulos.Size = New System.Drawing.Size(110, 61)
    Me.btnArticulos.TabIndex = 42
    Me.btnArticulos.Text = "Lista de Articulos"
    Me.btnArticulos.UseVisualStyleBackColor = False
    '
    'btnUpPago
    '
    Me.btnUpPago.Location = New System.Drawing.Point(224, 19)
    Me.btnUpPago.Name = "btnUpPago"
    Me.btnUpPago.Size = New System.Drawing.Size(99, 23)
    Me.btnUpPago.TabIndex = 33
    Me.btnUpPago.Text = "Pagar"
    Me.btnUpPago.UseVisualStyleBackColor = True
    '
    'btnDownPago
    '
    Me.btnDownPago.Location = New System.Drawing.Point(17, 27)
    Me.btnDownPago.Name = "btnDownPago"
    Me.btnDownPago.Size = New System.Drawing.Size(276, 24)
    Me.btnDownPago.TabIndex = 43
    Me.btnDownPago.Text = "Anular 1 cuota"
    Me.btnDownPago.UseVisualStyleBackColor = True
    '
    'dgvData
    '
    Me.dgvData.AllowUserToAddRows = False
    Me.dgvData.AllowUserToDeleteRows = False
    Me.dgvData.AllowUserToResizeRows = False
    Me.dgvData.AutoGenerateColumns = False
    Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvData.ColumnHeadersHeight = 24
    Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaVentaDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.ArticulosVendidosDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CuotasTotalesDataGridViewTextBoxColumn, Me.CuotasPagasDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.MetodoPagoDataGridViewTextBoxColumn, Me.FechaUltimoPagoDataGridViewTextBoxColumn, Me.NumClienteDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.VendedorDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.AdelantoDataGridViewTextBoxColumn, Me.ValorCuotaFijaDataGridViewTextBoxColumn})
    Me.dgvData.DataSource = Me.bsInfoPrincipal
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvData.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvData.EnableHeadersVisualStyles = False
    Me.dgvData.GridColor = System.Drawing.Color.White
    Me.dgvData.Location = New System.Drawing.Point(186, 65)
    Me.dgvData.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvData.MultiSelect = False
    Me.dgvData.Name = "dgvData"
    Me.dgvData.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvData.RowHeadersVisible = False
    Me.dgvData.RowTemplate.Height = 24
    Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData.Size = New System.Drawing.Size(1069, 339)
    Me.dgvData.TabIndex = 44
    Me.dgvData.TabStop = False
    '
    'FechaVentaDataGridViewTextBoxColumn
    '
    Me.FechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.Name = "FechaVentaDataGridViewTextBoxColumn"
    Me.FechaVentaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ComprobanteDataGridViewTextBoxColumn
    '
    Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
    Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
    Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
    Me.ComprobanteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ArticulosVendidosDataGridViewTextBoxColumn
    '
    Me.ArticulosVendidosDataGridViewTextBoxColumn.DataPropertyName = "ArticulosVendidos"
    Me.ArticulosVendidosDataGridViewTextBoxColumn.HeaderText = "ArticulosVendidos"
    Me.ArticulosVendidosDataGridViewTextBoxColumn.Name = "ArticulosVendidosDataGridViewTextBoxColumn"
    Me.ArticulosVendidosDataGridViewTextBoxColumn.ReadOnly = True
    '
    'PrecioDataGridViewTextBoxColumn
    '
    Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
    Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotasTotalesDataGridViewTextBoxColumn
    '
    Me.CuotasTotalesDataGridViewTextBoxColumn.DataPropertyName = "CuotasTotales"
    Me.CuotasTotalesDataGridViewTextBoxColumn.HeaderText = "CuotasTotales"
    Me.CuotasTotalesDataGridViewTextBoxColumn.Name = "CuotasTotalesDataGridViewTextBoxColumn"
    Me.CuotasTotalesDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotasPagasDataGridViewTextBoxColumn
    '
    Me.CuotasPagasDataGridViewTextBoxColumn.DataPropertyName = "CuotasPagas"
    Me.CuotasPagasDataGridViewTextBoxColumn.HeaderText = "CuotasPagas"
    Me.CuotasPagasDataGridViewTextBoxColumn.Name = "CuotasPagasDataGridViewTextBoxColumn"
    Me.CuotasPagasDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'MetodoPagoDataGridViewTextBoxColumn
    '
    Me.MetodoPagoDataGridViewTextBoxColumn.DataPropertyName = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn.HeaderText = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn.Name = "MetodoPagoDataGridViewTextBoxColumn"
    Me.MetodoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaUltimoPagoDataGridViewTextBoxColumn
    '
    Me.FechaUltimoPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimoPago"
    Me.FechaUltimoPagoDataGridViewTextBoxColumn.HeaderText = "FechaUltimoPago"
    Me.FechaUltimoPagoDataGridViewTextBoxColumn.Name = "FechaUltimoPagoDataGridViewTextBoxColumn"
    Me.FechaUltimoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumClienteDataGridViewTextBoxColumn
    '
    Me.NumClienteDataGridViewTextBoxColumn.DataPropertyName = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.HeaderText = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.Name = "NumClienteDataGridViewTextBoxColumn"
    Me.NumClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ClienteDataGridViewTextBoxColumn
    '
    Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
    Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'VendedorDataGridViewTextBoxColumn
    '
    Me.VendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor"
    Me.VendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
    Me.VendedorDataGridViewTextBoxColumn.Name = "VendedorDataGridViewTextBoxColumn"
    Me.VendedorDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    Me.GuidProductoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidProductoDataGridViewTextBoxColumn.Visible = False
    '
    'AdelantoDataGridViewTextBoxColumn
    '
    Me.AdelantoDataGridViewTextBoxColumn.DataPropertyName = "Adelanto"
    Me.AdelantoDataGridViewTextBoxColumn.HeaderText = "Adelanto"
    Me.AdelantoDataGridViewTextBoxColumn.Name = "AdelantoDataGridViewTextBoxColumn"
    Me.AdelantoDataGridViewTextBoxColumn.ReadOnly = True
    Me.AdelantoDataGridViewTextBoxColumn.Visible = False
    '
    'ValorCuotaFijaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuotaFija"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.HeaderText = "ValorCuotaFija"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.Name = "ValorCuotaFijaDataGridViewTextBoxColumn"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.ReadOnly = True
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.Visible = False
    '
    'bsInfoPrincipal
    '
    Me.bsInfoPrincipal.DataSource = GetType(manDB.clsInfoPrincipal)
    '
    'btnLiquidVendedores
    '
    Me.btnLiquidVendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLiquidVendedores.FlatAppearance.BorderSize = 0
    Me.btnLiquidVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLiquidVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLiquidVendedores.ForeColor = System.Drawing.Color.White
    Me.btnLiquidVendedores.Location = New System.Drawing.Point(24, 201)
    Me.btnLiquidVendedores.Name = "btnLiquidVendedores"
    Me.btnLiquidVendedores.Size = New System.Drawing.Size(110, 61)
    Me.btnLiquidVendedores.TabIndex = 45
    Me.btnLiquidVendedores.Text = "Liquidacion Vendedores"
    Me.btnLiquidVendedores.UseVisualStyleBackColor = False
    '
    'btnConfiguracion
    '
    Me.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnConfiguracion.Location = New System.Drawing.Point(157, 24)
    Me.btnConfiguracion.Name = "btnConfiguracion"
    Me.btnConfiguracion.Size = New System.Drawing.Size(92, 25)
    Me.btnConfiguracion.TabIndex = 46
    Me.btnConfiguracion.Text = "Configuracion"
    Me.btnConfiguracion.UseVisualStyleBackColor = False
    '
    'txtBusqueda
    '
    Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtBusqueda.Location = New System.Drawing.Point(268, 26)
    Me.txtBusqueda.Name = "txtBusqueda"
    Me.txtBusqueda.Size = New System.Drawing.Size(278, 21)
    Me.txtBusqueda.TabIndex = 47
    '
    'gpxBuscar
    '
    Me.gpxBuscar.BackColor = System.Drawing.Color.White
    Me.gpxBuscar.Controls.Add(Me.rbtnSinEntregar)
    Me.gpxBuscar.Controls.Add(Me.Panel1)
    Me.gpxBuscar.Controls.Add(Me.rbtnCuotaPagaron)
    Me.gpxBuscar.Controls.Add(Me.rbtnCancelados)
    Me.gpxBuscar.Controls.Add(Me.Label3)
    Me.gpxBuscar.Controls.Add(Me.dateInicio)
    Me.gpxBuscar.Controls.Add(Me.rbtnVendidos)
    Me.gpxBuscar.Controls.Add(Me.dateFin)
    Me.gpxBuscar.Controls.Add(Me.rbtnDeben)
    Me.gpxBuscar.Controls.Add(Me.Label4)
    Me.gpxBuscar.Controls.Add(Me.btnBuscar)
    Me.gpxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpxBuscar.Location = New System.Drawing.Point(6, 6)
    Me.gpxBuscar.Name = "gpxBuscar"
    Me.gpxBuscar.Size = New System.Drawing.Size(665, 230)
    Me.gpxBuscar.TabIndex = 48
    Me.gpxBuscar.TabStop = False
    Me.gpxBuscar.Text = "Buscar Producto"
    '
    'rbtnSinEntregar
    '
    Me.rbtnSinEntregar.AutoSize = True
    Me.rbtnSinEntregar.Location = New System.Drawing.Point(325, 76)
    Me.rbtnSinEntregar.Name = "rbtnSinEntregar"
    Me.rbtnSinEntregar.Size = New System.Drawing.Size(139, 19)
    Me.rbtnSinEntregar.TabIndex = 64
    Me.rbtnSinEntregar.TabStop = True
    Me.rbtnSinEntregar.Text = "Articulos sin entregar"
    Me.rbtnSinEntregar.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.rbtnClientName)
    Me.Panel1.Controls.Add(Me.cmbMetodosDePago)
    Me.Panel1.Controls.Add(Me.lblInfoFiltro)
    Me.Panel1.Controls.Add(Me.txtBusqueda)
    Me.Panel1.Controls.Add(Me.rbtnNombreVendedor)
    Me.Panel1.Location = New System.Drawing.Point(14, 131)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(633, 91)
    Me.Panel1.TabIndex = 63
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(163, 57)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(98, 15)
    Me.Label1.TabIndex = 64
    Me.Label1.Text = "Metodo de Pago"
    '
    'rbtnClientName
    '
    Me.rbtnClientName.AutoSize = True
    Me.rbtnClientName.Location = New System.Drawing.Point(4, 10)
    Me.rbtnClientName.Name = "rbtnClientName"
    Me.rbtnClientName.Size = New System.Drawing.Size(85, 19)
    Me.rbtnClientName.TabIndex = 48
    Me.rbtnClientName.TabStop = True
    Me.rbtnClientName.Text = "Por Cliente"
    Me.rbtnClientName.UseVisualStyleBackColor = True
    '
    'cmbMetodosDePago
    '
    Me.cmbMetodosDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbMetodosDePago.FormattingEnabled = True
    Me.cmbMetodosDePago.Location = New System.Drawing.Point(267, 56)
    Me.cmbMetodosDePago.Name = "cmbMetodosDePago"
    Me.cmbMetodosDePago.Size = New System.Drawing.Size(162, 23)
    Me.cmbMetodosDePago.TabIndex = 50
    '
    'lblInfoFiltro
    '
    Me.lblInfoFiltro.AutoSize = True
    Me.lblInfoFiltro.Location = New System.Drawing.Point(268, 10)
    Me.lblInfoFiltro.Name = "lblInfoFiltro"
    Me.lblInfoFiltro.Size = New System.Drawing.Size(45, 15)
    Me.lblInfoFiltro.TabIndex = 51
    Me.lblInfoFiltro.Text = "Label1"
    '
    'rbtnNombreVendedor
    '
    Me.rbtnNombreVendedor.AutoSize = True
    Me.rbtnNombreVendedor.Location = New System.Drawing.Point(157, 10)
    Me.rbtnNombreVendedor.Name = "rbtnNombreVendedor"
    Me.rbtnNombreVendedor.Size = New System.Drawing.Size(100, 19)
    Me.rbtnNombreVendedor.TabIndex = 49
    Me.rbtnNombreVendedor.TabStop = True
    Me.rbtnNombreVendedor.Text = "Por Vendedor"
    Me.rbtnNombreVendedor.UseVisualStyleBackColor = True
    '
    'btnMinimize
    '
    Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.btnMinimize.FlatAppearance.BorderSize = 0
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMinimize.Location = New System.Drawing.Point(1246, 3)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(31, 26)
    Me.btnMinimize.TabIndex = 49
    Me.btnMinimize.Text = "_"
    Me.btnMinimize.UseVisualStyleBackColor = False
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(616, 3)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(217, 20)
    Me.Label5.TabIndex = 50
    Me.Label5.Text = "PRODUCTOS VENDIDOS"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.btnImportar)
    Me.GroupBox1.Controls.Add(Me.btnExportar)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(481, 230)
    Me.GroupBox1.TabIndex = 60
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Pagos - Cobros"
    '
    'btnImportar
    '
    Me.btnImportar.Location = New System.Drawing.Point(228, 26)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(92, 35)
    Me.btnImportar.TabIndex = 62
    Me.btnImportar.Text = "Importar"
    Me.btnImportar.UseVisualStyleBackColor = True
    '
    'btnExportar
    '
    Me.btnExportar.Location = New System.Drawing.Point(16, 23)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(92, 38)
    Me.btnExportar.TabIndex = 61
    Me.btnExportar.Text = "Exportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(954, 132)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 63
    Me.Button2.Text = "Button2"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'lblTotalProductos
    '
    Me.lblTotalProductos.AutoSize = True
    Me.lblTotalProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalProductos.Location = New System.Drawing.Point(6, 16)
    Me.lblTotalProductos.Name = "lblTotalProductos"
    Me.lblTotalProductos.Size = New System.Drawing.Size(45, 15)
    Me.lblTotalProductos.TabIndex = 61
    Me.lblTotalProductos.Text = "Label1"
    '
    'lblTotalArticulos
    '
    Me.lblTotalArticulos.AutoSize = True
    Me.lblTotalArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalArticulos.Location = New System.Drawing.Point(7, 42)
    Me.lblTotalArticulos.Name = "lblTotalArticulos"
    Me.lblTotalArticulos.Size = New System.Drawing.Size(45, 15)
    Me.lblTotalArticulos.TabIndex = 62
    Me.lblTotalArticulos.Text = "Label2"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.lblResumen)
    Me.GroupBox2.Controls.Add(Me.lblPrecioInteres)
    Me.GroupBox2.Controls.Add(Me.lblPorcentaje)
    Me.GroupBox2.Controls.Add(Me.lblPagos)
    Me.GroupBox2.Controls.Add(Me.lblPrecioTotal)
    Me.GroupBox2.Controls.Add(Me.lblTotalProductos)
    Me.GroupBox2.Controls.Add(Me.lblTotalArticulos)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(1040, 252)
    Me.GroupBox2.TabIndex = 63
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Resumen"
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(6, 142)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(45, 15)
    Me.lblResumen.TabIndex = 67
    Me.lblResumen.Text = "Label2"
    '
    'lblPrecioInteres
    '
    Me.lblPrecioInteres.AutoSize = True
    Me.lblPrecioInteres.Location = New System.Drawing.Point(6, 66)
    Me.lblPrecioInteres.Margin = New System.Windows.Forms.Padding(3)
    Me.lblPrecioInteres.Name = "lblPrecioInteres"
    Me.lblPrecioInteres.Size = New System.Drawing.Size(45, 15)
    Me.lblPrecioInteres.TabIndex = 66
    Me.lblPrecioInteres.Text = "Label2"
    '
    'lblPorcentaje
    '
    Me.lblPorcentaje.AutoSize = True
    Me.lblPorcentaje.Location = New System.Drawing.Point(6, 115)
    Me.lblPorcentaje.Margin = New System.Windows.Forms.Padding(3)
    Me.lblPorcentaje.Name = "lblPorcentaje"
    Me.lblPorcentaje.Size = New System.Drawing.Size(45, 15)
    Me.lblPorcentaje.TabIndex = 65
    Me.lblPorcentaje.Text = "Label2"
    '
    'lblPagos
    '
    Me.lblPagos.AutoSize = True
    Me.lblPagos.Location = New System.Drawing.Point(6, 91)
    Me.lblPagos.Name = "lblPagos"
    Me.lblPagos.Size = New System.Drawing.Size(45, 15)
    Me.lblPagos.TabIndex = 64
    Me.lblPagos.Text = "Label2"
    '
    'lblPrecioTotal
    '
    Me.lblPrecioTotal.AutoSize = True
    Me.lblPrecioTotal.Location = New System.Drawing.Point(272, 67)
    Me.lblPrecioTotal.Name = "lblPrecioTotal"
    Me.lblPrecioTotal.Size = New System.Drawing.Size(45, 15)
    Me.lblPrecioTotal.TabIndex = 63
    Me.lblPrecioTotal.Text = "Label2"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tbBuscar)
    Me.TabControl1.Controls.Add(Me.tbResumen)
    Me.TabControl1.Controls.Add(Me.tbPagos)
    Me.TabControl1.Controls.Add(Me.tbOperaciones)
    Me.TabControl1.Location = New System.Drawing.Point(186, 416)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1069, 290)
    Me.TabControl1.TabIndex = 64
    '
    'tbBuscar
    '
    Me.tbBuscar.Controls.Add(Me.gpxBuscar)
    Me.tbBuscar.Location = New System.Drawing.Point(4, 22)
    Me.tbBuscar.Name = "tbBuscar"
    Me.tbBuscar.Padding = New System.Windows.Forms.Padding(3)
    Me.tbBuscar.Size = New System.Drawing.Size(1061, 264)
    Me.tbBuscar.TabIndex = 0
    Me.tbBuscar.Text = "Buscar Productos"
    Me.tbBuscar.UseVisualStyleBackColor = True
    '
    'tbResumen
    '
    Me.tbResumen.Controls.Add(Me.GroupBox2)
    Me.tbResumen.Location = New System.Drawing.Point(4, 22)
    Me.tbResumen.Name = "tbResumen"
    Me.tbResumen.Padding = New System.Windows.Forms.Padding(3)
    Me.tbResumen.Size = New System.Drawing.Size(1061, 264)
    Me.tbResumen.TabIndex = 1
    Me.tbResumen.Text = "Resumen"
    Me.tbResumen.UseVisualStyleBackColor = True
    '
    'tbPagos
    '
    Me.tbPagos.Controls.Add(Me.GroupBox1)
    Me.tbPagos.Location = New System.Drawing.Point(4, 22)
    Me.tbPagos.Name = "tbPagos"
    Me.tbPagos.Size = New System.Drawing.Size(1061, 264)
    Me.tbPagos.TabIndex = 2
    Me.tbPagos.Text = "Pagos - Cobros"
    Me.tbPagos.UseVisualStyleBackColor = True
    '
    'tbOperaciones
    '
    Me.tbOperaciones.Controls.Add(Me.GroupBox3)
    Me.tbOperaciones.Controls.Add(Me.GroupBox4)
    Me.tbOperaciones.Controls.Add(Me.gpPagarCuota)
    Me.tbOperaciones.Controls.Add(Me.Button3)
    Me.tbOperaciones.Controls.Add(Me.Button2)
    Me.tbOperaciones.Location = New System.Drawing.Point(4, 22)
    Me.tbOperaciones.Name = "tbOperaciones"
    Me.tbOperaciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tbOperaciones.Size = New System.Drawing.Size(1061, 264)
    Me.tbOperaciones.TabIndex = 3
    Me.tbOperaciones.Text = "Operaciones"
    Me.tbOperaciones.UseVisualStyleBackColor = True
    '
    'btnModificarFormadePago
    '
    Me.btnModificarFormadePago.Location = New System.Drawing.Point(241, 65)
    Me.btnModificarFormadePago.Name = "btnModificarFormadePago"
    Me.btnModificarFormadePago.Size = New System.Drawing.Size(156, 23)
    Me.btnModificarFormadePago.TabIndex = 69
    Me.btnModificarFormadePago.Text = "Modificar Forma de Pago"
    Me.btnModificarFormadePago.UseVisualStyleBackColor = True
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.btnDownPago)
    Me.GroupBox4.Location = New System.Drawing.Point(23, 85)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(327, 70)
    Me.GroupBox4.TabIndex = 68
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Anular Pago de cuota"
    '
    'gpPagarCuota
    '
    Me.gpPagarCuota.Controls.Add(Me.btnUpPago)
    Me.gpPagarCuota.Controls.Add(Me.Label6)
    Me.gpPagarCuota.Controls.Add(Me.cmbNumCuotasCancelar)
    Me.gpPagarCuota.Location = New System.Drawing.Point(23, 20)
    Me.gpPagarCuota.Name = "gpPagarCuota"
    Me.gpPagarCuota.Size = New System.Drawing.Size(354, 59)
    Me.gpPagarCuota.TabIndex = 67
    Me.gpPagarCuota.TabStop = False
    Me.gpPagarCuota.Text = "Aplicar Pago de Cuota"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(8, 24)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(152, 13)
    Me.Label6.TabIndex = 66
    Me.Label6.Text = "Cantidad de cuotas a cancelar"
    '
    'cmbNumCuotasCancelar
    '
    Me.cmbNumCuotasCancelar.FormattingEnabled = True
    Me.cmbNumCuotasCancelar.Location = New System.Drawing.Point(166, 21)
    Me.cmbNumCuotasCancelar.Name = "cmbNumCuotasCancelar"
    Me.cmbNumCuotasCancelar.Size = New System.Drawing.Size(52, 21)
    Me.cmbNumCuotasCancelar.TabIndex = 65
    '
    'lblInfodeFormadePago
    '
    Me.lblInfodeFormadePago.AutoSize = True
    Me.lblInfodeFormadePago.Location = New System.Drawing.Point(6, 19)
    Me.lblInfodeFormadePago.Name = "lblInfodeFormadePago"
    Me.lblInfodeFormadePago.Size = New System.Drawing.Size(13, 13)
    Me.lblInfodeFormadePago.TabIndex = 64
    Me.lblInfodeFormadePago.Text = "d"
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(983, 235)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(75, 23)
    Me.Button3.TabIndex = 61
    Me.Button3.Text = "Button3"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(321, 24)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 65
    Me.Button1.Text = "Service"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.btnModificarFormadePago)
    Me.GroupBox3.Controls.Add(Me.lblInfodeFormadePago)
    Me.GroupBox3.Location = New System.Drawing.Point(401, 20)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(419, 100)
    Me.GroupBox3.TabIndex = 70
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Forma de pago"
    '
    'frmDeben
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.btnLstVendedores)
    Me.Controls.Add(Me.btnListaClientes)
    Me.Controls.Add(Me.btnMinimize)
    Me.Controls.Add(Me.btnArticulos)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnConfiguracion)
    Me.Controls.Add(Me.btnLiquidVendedores)
    Me.Controls.Add(Me.dgvData)
    Me.Controls.Add(Me.btnEditarVenta)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.TabControl1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmDeben"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmDeben"
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsInfoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gpxBuscar.ResumeLayout(False)
    Me.gpxBuscar.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.tbBuscar.ResumeLayout(False)
    Me.tbResumen.ResumeLayout(False)
    Me.tbPagos.ResumeLayout(False)
    Me.tbOperaciones.ResumeLayout(False)
    Me.GroupBox4.ResumeLayout(False)
    Me.gpPagarCuota.ResumeLayout(False)
    Me.gpPagarCuota.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dateInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents TipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dateFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents rbtnVendidos As System.Windows.Forms.RadioButton
  Friend WithEvents rbtnDeben As System.Windows.Forms.RadioButton
  Friend WithEvents btnLstVendedores As System.Windows.Forms.Button
  Friend WithEvents btnListaClientes As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEditarVenta As System.Windows.Forms.Button
  Friend WithEvents btnArticulos As System.Windows.Forms.Button
  Friend WithEvents btnUpPago As System.Windows.Forms.Button
  Friend WithEvents btnDownPago As System.Windows.Forms.Button
  Public WithEvents dgvData As System.Windows.Forms.DataGridView
  Friend WithEvents bsInfoPrincipal As System.Windows.Forms.BindingSource
  Friend WithEvents btnLiquidVendedores As System.Windows.Forms.Button
  Friend WithEvents rbtnCancelados As System.Windows.Forms.RadioButton
  Friend WithEvents rbtnCuotaPagaron As System.Windows.Forms.RadioButton
  Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
  Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
  Friend WithEvents gpxBuscar As System.Windows.Forms.GroupBox
  Friend WithEvents rbtnNombreVendedor As System.Windows.Forms.RadioButton
  Friend WithEvents rbtnClientName As System.Windows.Forms.RadioButton
  Friend WithEvents btnMinimize As System.Windows.Forms.Button
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents NombreClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ArticulosVendidodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ArticulosVendidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotasTotalesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotasPagasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MetodoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaUltimoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents AdelantoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaFijaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblTotalProductos As System.Windows.Forms.Label
  Friend WithEvents lblTotalArticulos As System.Windows.Forms.Label
  Friend WithEvents cmbMetodosDePago As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents lblInfoFiltro As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tbBuscar As System.Windows.Forms.TabPage
  Friend WithEvents tbResumen As System.Windows.Forms.TabPage
  Friend WithEvents tbPagos As System.Windows.Forms.TabPage
  Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
  Friend WithEvents lblPagos As System.Windows.Forms.Label
  Friend WithEvents lblPrecioTotal As System.Windows.Forms.Label
  Friend WithEvents lblPrecioInteres As System.Windows.Forms.Label
  Friend WithEvents rbtnSinEntregar As System.Windows.Forms.RadioButton
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents tbOperaciones As System.Windows.Forms.TabPage
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cmbNumCuotasCancelar As System.Windows.Forms.ComboBox
  Friend WithEvents lblInfodeFormadePago As System.Windows.Forms.Label
  Friend WithEvents btnModificarFormadePago As System.Windows.Forms.Button
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents gpPagarCuota As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
