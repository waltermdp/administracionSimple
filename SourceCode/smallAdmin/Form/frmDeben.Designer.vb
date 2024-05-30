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
    Me.dtVendidosHasta = New System.Windows.Forms.DateTimePicker()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.dtVendidosDesde = New System.Windows.Forms.DateTimePicker()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.btnLstVendedores = New System.Windows.Forms.Button()
    Me.btnListaClientes = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEditarVenta = New System.Windows.Forms.Button()
    Me.btnArticulos = New System.Windows.Forms.Button()
    Me.btnLiquidVendedores = New System.Windows.Forms.Button()
    Me.btnConfiguracion = New System.Windows.Forms.Button()
    Me.chkMetodoPago = New System.Windows.Forms.CheckBox()
    Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
    Me.cmbMetodosDePago = New System.Windows.Forms.ComboBox()
    Me.txtNombreCliente = New System.Windows.Forms.TextBox()
    Me.chkVendidosHasta = New System.Windows.Forms.CheckBox()
    Me.chkVendidosDesde = New System.Windows.Forms.CheckBox()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.lblTitulo = New System.Windows.Forms.Label()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNombreProducto = New System.Windows.Forms.TextBox()
    Me.lblNroContrato = New System.Windows.Forms.Label()
    Me.txtNroContrato = New System.Windows.Forms.TextBox()
    Me.btnLimpiarCampos = New System.Windows.Forms.Button()
    Me.dtDebenHasta = New System.Windows.Forms.DateTimePicker()
    Me.chkDebenHasta = New System.Windows.Forms.CheckBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.tbResumen = New System.Windows.Forms.TabPage()
    Me.tbOperaciones = New System.Windows.Forms.TabPage()
    Me.btnprocesar = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.btnEditarPagos = New System.Windows.Forms.Button()
    Me.lblFechaHoy = New System.Windows.Forms.Label()
    Me.lblSoftwareInfo = New System.Windows.Forms.Label()
    Me.btnEliminarVenta = New System.Windows.Forms.Button()
    Me.dgvVentas = New System.Windows.Forms.DataGridView()
    Me.IDContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VendedorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetodoPagoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClienteApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VendedorNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VendedorApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VendidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GUIDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoConsultaVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.lblCount = New System.Windows.Forms.Label()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.lblFechaUltimoPago = New System.Windows.Forms.Label()
    Me.lblCuotasConvenio = New System.Windows.Forms.Label()
    Me.txtPagosYTipos = New System.Windows.Forms.TextBox()
    Me.lblNumUltimaCuotaPaga = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btnMensajes = New System.Windows.Forms.Button()
    Me.GroupBox2.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.tbBuscar.SuspendLayout()
    Me.tbResumen.SuspendLayout()
    Me.tbOperaciones.SuspendLayout()
    CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoConsultaVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'dtVendidosHasta
    '
    Me.dtVendidosHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtVendidosHasta.Location = New System.Drawing.Point(639, 9)
    Me.dtVendidosHasta.Name = "dtVendidosHasta"
    Me.dtVendidosHasta.Size = New System.Drawing.Size(235, 22)
    Me.dtVendidosHasta.TabIndex = 2
    '
    'btnBack
    '
    Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBack.FlatAppearance.BorderSize = 0
    Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
    Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBack.ForeColor = System.Drawing.Color.White
    Me.btnBack.Location = New System.Drawing.Point(10, 637)
    Me.btnBack.Margin = New System.Windows.Forms.Padding(10, 10, 3, 25)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(110, 60)
    Me.btnBack.TabIndex = 3
    Me.btnBack.Text = "Cerrar"
    Me.btnBack.UseVisualStyleBackColor = False
    '
    'dtVendidosDesde
    '
    Me.dtVendidosDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtVendidosDesde.Location = New System.Drawing.Point(639, 37)
    Me.dtVendidosDesde.Name = "dtVendidosDesde"
    Me.dtVendidosDesde.Size = New System.Drawing.Size(235, 22)
    Me.dtVendidosDesde.TabIndex = 28
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ForeColor = System.Drawing.Color.White
    Me.btnBuscar.Location = New System.Drawing.Point(945, 6)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 60)
    Me.btnBuscar.TabIndex = 29
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'btnLstVendedores
    '
    Me.btnLstVendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLstVendedores.FlatAppearance.BorderSize = 0
    Me.btnLstVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLstVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLstVendedores.ForeColor = System.Drawing.Color.White
    Me.btnLstVendedores.Location = New System.Drawing.Point(273, 13)
    Me.btnLstVendedores.Margin = New System.Windows.Forms.Padding(10)
    Me.btnLstVendedores.Name = "btnLstVendedores"
    Me.btnLstVendedores.Size = New System.Drawing.Size(110, 60)
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
    Me.btnListaClientes.Location = New System.Drawing.Point(143, 13)
    Me.btnListaClientes.Margin = New System.Windows.Forms.Padding(10)
    Me.btnListaClientes.Name = "btnListaClientes"
    Me.btnListaClientes.Size = New System.Drawing.Size(110, 60)
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
    Me.btnNuevo.Location = New System.Drawing.Point(10, 35)
    Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 60)
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
    Me.btnEditarVenta.Location = New System.Drawing.Point(10, 105)
    Me.btnEditarVenta.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
    Me.btnEditarVenta.Name = "btnEditarVenta"
    Me.btnEditarVenta.Size = New System.Drawing.Size(110, 60)
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
    Me.btnArticulos.Location = New System.Drawing.Point(13, 13)
    Me.btnArticulos.Margin = New System.Windows.Forms.Padding(10)
    Me.btnArticulos.Name = "btnArticulos"
    Me.btnArticulos.Size = New System.Drawing.Size(110, 60)
    Me.btnArticulos.TabIndex = 42
    Me.btnArticulos.Text = "Lista de Articulos"
    Me.btnArticulos.UseVisualStyleBackColor = False
    '
    'btnLiquidVendedores
    '
    Me.btnLiquidVendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLiquidVendedores.FlatAppearance.BorderSize = 0
    Me.btnLiquidVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLiquidVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLiquidVendedores.ForeColor = System.Drawing.Color.White
    Me.btnLiquidVendedores.Location = New System.Drawing.Point(403, 13)
    Me.btnLiquidVendedores.Margin = New System.Windows.Forms.Padding(10)
    Me.btnLiquidVendedores.Name = "btnLiquidVendedores"
    Me.btnLiquidVendedores.Size = New System.Drawing.Size(110, 60)
    Me.btnLiquidVendedores.TabIndex = 45
    Me.btnLiquidVendedores.Text = "Liquidacion Vendedores"
    Me.btnLiquidVendedores.UseVisualStyleBackColor = False
    '
    'btnConfiguracion
    '
    Me.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnConfiguracion.Location = New System.Drawing.Point(882, 59)
    Me.btnConfiguracion.Name = "btnConfiguracion"
    Me.btnConfiguracion.Size = New System.Drawing.Size(92, 25)
    Me.btnConfiguracion.TabIndex = 46
    Me.btnConfiguracion.Text = "Configuracion"
    Me.btnConfiguracion.UseVisualStyleBackColor = False
    '
    'chkMetodoPago
    '
    Me.chkMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkMetodoPago.Location = New System.Drawing.Point(17, 123)
    Me.chkMetodoPago.Name = "chkMetodoPago"
    Me.chkMetodoPago.Size = New System.Drawing.Size(154, 23)
    Me.chkMetodoPago.TabIndex = 71
    Me.chkMetodoPago.Text = "Metodo De Pago"
    Me.chkMetodoPago.UseVisualStyleBackColor = True
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreVendedor.Location = New System.Drawing.Point(161, 38)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.Size = New System.Drawing.Size(275, 22)
    Me.txtNombreVendedor.TabIndex = 68
    '
    'cmbMetodosDePago
    '
    Me.cmbMetodosDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbMetodosDePago.FormattingEnabled = True
    Me.cmbMetodosDePago.Location = New System.Drawing.Point(177, 124)
    Me.cmbMetodosDePago.Name = "cmbMetodosDePago"
    Me.cmbMetodosDePago.Size = New System.Drawing.Size(259, 24)
    Me.cmbMetodosDePago.TabIndex = 50
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreCliente.Location = New System.Drawing.Point(161, 11)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.Size = New System.Drawing.Size(275, 22)
    Me.txtNombreCliente.TabIndex = 67
    '
    'chkVendidosHasta
    '
    Me.chkVendidosHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkVendidosHasta.Location = New System.Drawing.Point(488, 12)
    Me.chkVendidosHasta.Name = "chkVendidosHasta"
    Me.chkVendidosHasta.Size = New System.Drawing.Size(145, 19)
    Me.chkVendidosHasta.TabIndex = 66
    Me.chkVendidosHasta.Text = "Vendidos Hasta"
    Me.chkVendidosHasta.UseVisualStyleBackColor = True
    '
    'chkVendidosDesde
    '
    Me.chkVendidosDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkVendidosDesde.Location = New System.Drawing.Point(488, 36)
    Me.chkVendidosDesde.Name = "chkVendidosDesde"
    Me.chkVendidosDesde.Size = New System.Drawing.Size(145, 23)
    Me.chkVendidosDesde.TabIndex = 65
    Me.chkVendidosDesde.Text = "Vendido Desde"
    Me.chkVendidosDesde.UseVisualStyleBackColor = True
    '
    'btnMinimize
    '
    Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
    Me.btnMinimize.FlatAppearance.BorderSize = 0
    Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMinimize.Location = New System.Drawing.Point(1220, 1)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(31, 24)
    Me.btnMinimize.TabIndex = 49
    Me.btnMinimize.Text = "_"
    Me.btnMinimize.UseVisualStyleBackColor = False
    '
    'lblTitulo
    '
    Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
    Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitulo.ForeColor = System.Drawing.Color.White
    Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
    Me.lblTitulo.Name = "lblTitulo"
    Me.lblTitulo.Size = New System.Drawing.Size(1280, 25)
    Me.lblTitulo.TabIndex = 50
    Me.lblTitulo.Text = "PRODUCTOS VENDIDOS"
    Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'btnImportar
    '
    Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ForeColor = System.Drawing.Color.White
    Me.btnImportar.Location = New System.Drawing.Point(10, 441)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(110, 60)
    Me.btnImportar.TabIndex = 62
    Me.btnImportar.Text = "Importar"
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ForeColor = System.Drawing.Color.White
    Me.btnExportar.Location = New System.Drawing.Point(10, 362)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 60)
    Me.btnExportar.TabIndex = 61
    Me.btnExportar.Text = "Exportar"
    Me.btnExportar.UseVisualStyleBackColor = False
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
    Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
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
    Me.TabControl1.Controls.Add(Me.tbOperaciones)
    Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabControl1.Location = New System.Drawing.Point(148, 407)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1107, 290)
    Me.TabControl1.TabIndex = 64
    '
    'tbBuscar
    '
    Me.tbBuscar.Controls.Add(Me.Label1)
    Me.tbBuscar.Controls.Add(Me.txtNombreProducto)
    Me.tbBuscar.Controls.Add(Me.lblNroContrato)
    Me.tbBuscar.Controls.Add(Me.txtNroContrato)
    Me.tbBuscar.Controls.Add(Me.btnLimpiarCampos)
    Me.tbBuscar.Controls.Add(Me.dtDebenHasta)
    Me.tbBuscar.Controls.Add(Me.chkDebenHasta)
    Me.tbBuscar.Controls.Add(Me.chkVendidosHasta)
    Me.tbBuscar.Controls.Add(Me.dtVendidosHasta)
    Me.tbBuscar.Controls.Add(Me.dtVendidosDesde)
    Me.tbBuscar.Controls.Add(Me.chkMetodoPago)
    Me.tbBuscar.Controls.Add(Me.chkVendidosDesde)
    Me.tbBuscar.Controls.Add(Me.Label7)
    Me.tbBuscar.Controls.Add(Me.Label6)
    Me.tbBuscar.Controls.Add(Me.txtNombreCliente)
    Me.tbBuscar.Controls.Add(Me.cmbMetodosDePago)
    Me.tbBuscar.Controls.Add(Me.txtNombreVendedor)
    Me.tbBuscar.Controls.Add(Me.btnBuscar)
    Me.tbBuscar.Location = New System.Drawing.Point(4, 25)
    Me.tbBuscar.Name = "tbBuscar"
    Me.tbBuscar.Padding = New System.Windows.Forms.Padding(3)
    Me.tbBuscar.Size = New System.Drawing.Size(1099, 261)
    Me.tbBuscar.TabIndex = 0
    Me.tbBuscar.Text = "Filtros"
    Me.tbBuscar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(14, 92)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(100, 23)
    Me.Label1.TabIndex = 80
    Me.Label1.Text = "Producto:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtNombreProducto
    '
    Me.txtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreProducto.Location = New System.Drawing.Point(161, 94)
    Me.txtNombreProducto.Name = "txtNombreProducto"
    Me.txtNombreProducto.Size = New System.Drawing.Size(275, 22)
    Me.txtNombreProducto.TabIndex = 79
    '
    'lblNroContrato
    '
    Me.lblNroContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNroContrato.Location = New System.Drawing.Point(14, 64)
    Me.lblNroContrato.Name = "lblNroContrato"
    Me.lblNroContrato.Size = New System.Drawing.Size(100, 23)
    Me.lblNroContrato.TabIndex = 78
    Me.lblNroContrato.Text = "Nro Contrato:"
    Me.lblNroContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtNroContrato
    '
    Me.txtNroContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroContrato.Location = New System.Drawing.Point(161, 66)
    Me.txtNroContrato.Name = "txtNroContrato"
    Me.txtNroContrato.Size = New System.Drawing.Size(275, 22)
    Me.txtNroContrato.TabIndex = 77
    '
    'btnLimpiarCampos
    '
    Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLimpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.White
    Me.btnLimpiarCampos.Location = New System.Drawing.Point(945, 72)
    Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
    Me.btnLimpiarCampos.Size = New System.Drawing.Size(110, 60)
    Me.btnLimpiarCampos.TabIndex = 76
    Me.btnLimpiarCampos.Text = "Limpiar campos"
    Me.btnLimpiarCampos.UseVisualStyleBackColor = False
    '
    'dtDebenHasta
    '
    Me.dtDebenHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtDebenHasta.Location = New System.Drawing.Point(177, 151)
    Me.dtDebenHasta.Name = "dtDebenHasta"
    Me.dtDebenHasta.Size = New System.Drawing.Size(259, 22)
    Me.dtDebenHasta.TabIndex = 75
    '
    'chkDebenHasta
    '
    Me.chkDebenHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkDebenHasta.Location = New System.Drawing.Point(17, 152)
    Me.chkDebenHasta.Name = "chkDebenHasta"
    Me.chkDebenHasta.Size = New System.Drawing.Size(154, 23)
    Me.chkDebenHasta.TabIndex = 74
    Me.chkDebenHasta.Text = "Deben Hasta"
    Me.chkDebenHasta.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(14, 36)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(100, 23)
    Me.Label7.TabIndex = 73
    Me.Label7.Text = "Vendedor:"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(14, 11)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(100, 23)
    Me.Label6.TabIndex = 72
    Me.Label6.Text = "Cliente:"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'tbResumen
    '
    Me.tbResumen.Controls.Add(Me.GroupBox2)
    Me.tbResumen.Location = New System.Drawing.Point(4, 25)
    Me.tbResumen.Name = "tbResumen"
    Me.tbResumen.Padding = New System.Windows.Forms.Padding(3)
    Me.tbResumen.Size = New System.Drawing.Size(1099, 261)
    Me.tbResumen.TabIndex = 1
    Me.tbResumen.Text = "Resumen"
    Me.tbResumen.UseVisualStyleBackColor = True
    '
    'tbOperaciones
    '
    Me.tbOperaciones.Controls.Add(Me.btnMensajes)
    Me.tbOperaciones.Controls.Add(Me.btnArticulos)
    Me.tbOperaciones.Controls.Add(Me.btnLiquidVendedores)
    Me.tbOperaciones.Controls.Add(Me.btnListaClientes)
    Me.tbOperaciones.Controls.Add(Me.btnLstVendedores)
    Me.tbOperaciones.Controls.Add(Me.btnprocesar)
    Me.tbOperaciones.Controls.Add(Me.btnConfiguracion)
    Me.tbOperaciones.Controls.Add(Me.Button1)
    Me.tbOperaciones.Location = New System.Drawing.Point(4, 25)
    Me.tbOperaciones.Name = "tbOperaciones"
    Me.tbOperaciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tbOperaciones.Size = New System.Drawing.Size(1099, 261)
    Me.tbOperaciones.TabIndex = 3
    Me.tbOperaciones.Text = "Otras Operaciones"
    Me.tbOperaciones.UseVisualStyleBackColor = True
    '
    'btnprocesar
    '
    Me.btnprocesar.Location = New System.Drawing.Point(899, 30)
    Me.btnprocesar.Name = "btnprocesar"
    Me.btnprocesar.Size = New System.Drawing.Size(75, 23)
    Me.btnprocesar.TabIndex = 69
    Me.btnprocesar.Text = "pro"
    Me.btnprocesar.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(882, 90)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 65
    Me.Button1.Text = "Service"
    Me.Button1.UseVisualStyleBackColor = True
    Me.Button1.Visible = False
    '
    'btnEditarPagos
    '
    Me.btnEditarPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditarPagos.FlatAppearance.BorderSize = 0
    Me.btnEditarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditarPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditarPagos.ForeColor = System.Drawing.Color.White
    Me.btnEditarPagos.Location = New System.Drawing.Point(10, 251)
    Me.btnEditarPagos.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
    Me.btnEditarPagos.Name = "btnEditarPagos"
    Me.btnEditarPagos.Size = New System.Drawing.Size(110, 60)
    Me.btnEditarPagos.TabIndex = 73
    Me.btnEditarPagos.Text = "Editar Pago"
    Me.btnEditarPagos.UseVisualStyleBackColor = False
    '
    'lblFechaHoy
    '
    Me.lblFechaHoy.BackColor = System.Drawing.Color.Transparent
    Me.lblFechaHoy.ForeColor = System.Drawing.Color.White
    Me.lblFechaHoy.Location = New System.Drawing.Point(9, 2)
    Me.lblFechaHoy.Name = "lblFechaHoy"
    Me.lblFechaHoy.Size = New System.Drawing.Size(108, 23)
    Me.lblFechaHoy.TabIndex = 66
    Me.lblFechaHoy.Text = "Label5"
    Me.lblFechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblSoftwareInfo
    '
    Me.lblSoftwareInfo.BackColor = System.Drawing.Color.Transparent
    Me.lblSoftwareInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSoftwareInfo.Location = New System.Drawing.Point(968, 696)
    Me.lblSoftwareInfo.Name = "lblSoftwareInfo"
    Me.lblSoftwareInfo.Size = New System.Drawing.Size(287, 23)
    Me.lblSoftwareInfo.TabIndex = 67
    Me.lblSoftwareInfo.Text = "AdminVentas"
    Me.lblSoftwareInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'btnEliminarVenta
    '
    Me.btnEliminarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEliminarVenta.FlatAppearance.BorderSize = 0
    Me.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEliminarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminarVenta.ForeColor = System.Drawing.Color.White
    Me.btnEliminarVenta.Location = New System.Drawing.Point(10, 178)
    Me.btnEliminarVenta.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
    Me.btnEliminarVenta.Name = "btnEliminarVenta"
    Me.btnEliminarVenta.Size = New System.Drawing.Size(110, 60)
    Me.btnEliminarVenta.TabIndex = 68
    Me.btnEliminarVenta.Text = "Eliminar Venta"
    Me.btnEliminarVenta.UseVisualStyleBackColor = False
    '
    'dgvVentas
    '
    Me.dgvVentas.AllowUserToAddRows = False
    Me.dgvVentas.AllowUserToDeleteRows = False
    Me.dgvVentas.AllowUserToResizeRows = False
    Me.dgvVentas.AutoGenerateColumns = False
    Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvVentas.ColumnHeadersHeight = 24
    Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDContratoDataGridViewTextBoxColumn, Me.IDClienteDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn1, Me.VendedorDataGridViewTextBoxColumn1, Me.MetodoPagoDataGridViewTextBoxColumn1, Me.ClienteNombreDataGridViewTextBoxColumn, Me.ClienteApellidoDataGridViewTextBoxColumn, Me.VendedorNombreDataGridViewTextBoxColumn, Me.VendedorApellidoDataGridViewTextBoxColumn, Me.VendidosDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaFinDataGridViewTextBoxColumn, Me.GUIDClienteDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn1, Me.GuidVendedorDataGridViewTextBoxColumn})
    Me.dgvVentas.DataSource = Me.ClsInfoConsultaVentasBindingSource
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvVentas.EnableHeadersVisualStyles = False
    Me.dgvVentas.GridColor = System.Drawing.Color.White
    Me.dgvVentas.Location = New System.Drawing.Point(148, 35)
    Me.dgvVentas.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvVentas.MultiSelect = False
    Me.dgvVentas.Name = "dgvVentas"
    Me.dgvVentas.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvVentas.RowHeadersVisible = False
    Me.dgvVentas.RowTemplate.Height = 24
    Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvVentas.Size = New System.Drawing.Size(768, 345)
    Me.dgvVentas.TabIndex = 70
    Me.dgvVentas.TabStop = False
    '
    'IDContratoDataGridViewTextBoxColumn
    '
    Me.IDContratoDataGridViewTextBoxColumn.DataPropertyName = "IDContrato"
    Me.IDContratoDataGridViewTextBoxColumn.HeaderText = "IDContrato"
    Me.IDContratoDataGridViewTextBoxColumn.Name = "IDContratoDataGridViewTextBoxColumn"
    Me.IDContratoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'IDClienteDataGridViewTextBoxColumn
    '
    Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
    Me.IDClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ClienteDataGridViewTextBoxColumn1
    '
    Me.ClienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn1.HeaderText = "Cliente"
    Me.ClienteDataGridViewTextBoxColumn1.Name = "ClienteDataGridViewTextBoxColumn1"
    Me.ClienteDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'VendedorDataGridViewTextBoxColumn1
    '
    Me.VendedorDataGridViewTextBoxColumn1.DataPropertyName = "Vendedor"
    Me.VendedorDataGridViewTextBoxColumn1.HeaderText = "Vendedor"
    Me.VendedorDataGridViewTextBoxColumn1.Name = "VendedorDataGridViewTextBoxColumn1"
    Me.VendedorDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'MetodoPagoDataGridViewTextBoxColumn1
    '
    Me.MetodoPagoDataGridViewTextBoxColumn1.DataPropertyName = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn1.HeaderText = "MetodoPago"
    Me.MetodoPagoDataGridViewTextBoxColumn1.Name = "MetodoPagoDataGridViewTextBoxColumn1"
    Me.MetodoPagoDataGridViewTextBoxColumn1.ReadOnly = True
    Me.MetodoPagoDataGridViewTextBoxColumn1.Visible = False
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
    'VendedorNombreDataGridViewTextBoxColumn
    '
    Me.VendedorNombreDataGridViewTextBoxColumn.DataPropertyName = "VendedorNombre"
    Me.VendedorNombreDataGridViewTextBoxColumn.HeaderText = "VendedorNombre"
    Me.VendedorNombreDataGridViewTextBoxColumn.Name = "VendedorNombreDataGridViewTextBoxColumn"
    Me.VendedorNombreDataGridViewTextBoxColumn.ReadOnly = True
    Me.VendedorNombreDataGridViewTextBoxColumn.Visible = False
    '
    'VendedorApellidoDataGridViewTextBoxColumn
    '
    Me.VendedorApellidoDataGridViewTextBoxColumn.DataPropertyName = "VendedorApellido"
    Me.VendedorApellidoDataGridViewTextBoxColumn.HeaderText = "VendedorApellido"
    Me.VendedorApellidoDataGridViewTextBoxColumn.Name = "VendedorApellidoDataGridViewTextBoxColumn"
    Me.VendedorApellidoDataGridViewTextBoxColumn.ReadOnly = True
    Me.VendedorApellidoDataGridViewTextBoxColumn.Visible = False
    '
    'VendidosDataGridViewTextBoxColumn
    '
    Me.VendidosDataGridViewTextBoxColumn.DataPropertyName = "Vendidos"
    Me.VendidosDataGridViewTextBoxColumn.HeaderText = "Vendidos"
    Me.VendidosDataGridViewTextBoxColumn.Name = "VendidosDataGridViewTextBoxColumn"
    Me.VendidosDataGridViewTextBoxColumn.ReadOnly = True
    Me.VendidosDataGridViewTextBoxColumn.Visible = False
    '
    'TotalCuotasDataGridViewTextBoxColumn
    '
    Me.TotalCuotasDataGridViewTextBoxColumn.DataPropertyName = "TotalCuotas"
    Me.TotalCuotasDataGridViewTextBoxColumn.HeaderText = "TotalCuotas"
    Me.TotalCuotasDataGridViewTextBoxColumn.Name = "TotalCuotasDataGridViewTextBoxColumn"
    Me.TotalCuotasDataGridViewTextBoxColumn.ReadOnly = True
    Me.TotalCuotasDataGridViewTextBoxColumn.Visible = False
    '
    'FechaInicioDataGridViewTextBoxColumn
    '
    Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
    Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio"
    Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
    Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaInicioDataGridViewTextBoxColumn.Visible = False
    '
    'FechaFinDataGridViewTextBoxColumn
    '
    Me.FechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin"
    Me.FechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin"
    Me.FechaFinDataGridViewTextBoxColumn.Name = "FechaFinDataGridViewTextBoxColumn"
    Me.FechaFinDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaFinDataGridViewTextBoxColumn.Visible = False
    '
    'GUIDClienteDataGridViewTextBoxColumn
    '
    Me.GUIDClienteDataGridViewTextBoxColumn.DataPropertyName = "GUID_Cliente"
    Me.GUIDClienteDataGridViewTextBoxColumn.HeaderText = "GUID_Cliente"
    Me.GUIDClienteDataGridViewTextBoxColumn.Name = "GUIDClienteDataGridViewTextBoxColumn"
    Me.GUIDClienteDataGridViewTextBoxColumn.ReadOnly = True
    Me.GUIDClienteDataGridViewTextBoxColumn.Visible = False
    '
    'GuidProductoDataGridViewTextBoxColumn1
    '
    Me.GuidProductoDataGridViewTextBoxColumn1.DataPropertyName = "Guid_Producto"
    Me.GuidProductoDataGridViewTextBoxColumn1.HeaderText = "Guid_Producto"
    Me.GuidProductoDataGridViewTextBoxColumn1.Name = "GuidProductoDataGridViewTextBoxColumn1"
    Me.GuidProductoDataGridViewTextBoxColumn1.ReadOnly = True
    Me.GuidProductoDataGridViewTextBoxColumn1.Visible = False
    '
    'GuidVendedorDataGridViewTextBoxColumn
    '
    Me.GuidVendedorDataGridViewTextBoxColumn.DataPropertyName = "Guid_Vendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.HeaderText = "Guid_Vendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.Name = "GuidVendedorDataGridViewTextBoxColumn"
    Me.GuidVendedorDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidVendedorDataGridViewTextBoxColumn.Visible = False
    '
    'ClsInfoConsultaVentasBindingSource
    '
    Me.ClsInfoConsultaVentasBindingSource.DataSource = GetType(main.clsInfoConsultaVentas)
    '
    'lblCount
    '
    Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCount.Location = New System.Drawing.Point(149, 380)
    Me.lblCount.Name = "lblCount"
    Me.lblCount.Size = New System.Drawing.Size(767, 23)
    Me.lblCount.TabIndex = 77
    Me.lblCount.Text = "Cantidad: 000"
    Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblValorCuota
    '
    Me.lblValorCuota.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblValorCuota.Location = New System.Drawing.Point(5, 34)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(307, 23)
    Me.lblValorCuota.TabIndex = 79
    Me.lblValorCuota.Text = "Label2"
    Me.lblValorCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblFechaUltimoPago
    '
    Me.lblFechaUltimoPago.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaUltimoPago.Location = New System.Drawing.Point(5, 57)
    Me.lblFechaUltimoPago.Name = "lblFechaUltimoPago"
    Me.lblFechaUltimoPago.Size = New System.Drawing.Size(307, 23)
    Me.lblFechaUltimoPago.TabIndex = 80
    Me.lblFechaUltimoPago.Text = "Label2"
    Me.lblFechaUltimoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblCuotasConvenio
    '
    Me.lblCuotasConvenio.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuotasConvenio.Location = New System.Drawing.Point(5, 107)
    Me.lblCuotasConvenio.Name = "lblCuotasConvenio"
    Me.lblCuotasConvenio.Size = New System.Drawing.Size(307, 23)
    Me.lblCuotasConvenio.TabIndex = 81
    Me.lblCuotasConvenio.Text = "Label2"
    Me.lblCuotasConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtPagosYTipos
    '
    Me.txtPagosYTipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.txtPagosYTipos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtPagosYTipos.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPagosYTipos.Location = New System.Drawing.Point(8, 133)
    Me.txtPagosYTipos.Multiline = True
    Me.txtPagosYTipos.Name = "txtPagosYTipos"
    Me.txtPagosYTipos.ReadOnly = True
    Me.txtPagosYTipos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtPagosYTipos.Size = New System.Drawing.Size(304, 232)
    Me.txtPagosYTipos.TabIndex = 82
    Me.txtPagosYTipos.Text = "List"
    '
    'lblNumUltimaCuotaPaga
    '
    Me.lblNumUltimaCuotaPaga.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumUltimaCuotaPaga.Location = New System.Drawing.Point(5, 80)
    Me.lblNumUltimaCuotaPaga.Name = "lblNumUltimaCuotaPaga"
    Me.lblNumUltimaCuotaPaga.Size = New System.Drawing.Size(307, 23)
    Me.lblNumUltimaCuotaPaga.TabIndex = 83
    Me.lblNumUltimaCuotaPaga.Text = "Label2"
    Me.lblNumUltimaCuotaPaga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.Panel1.Controls.Add(Me.lblValorCuota)
    Me.Panel1.Controls.Add(Me.lblNumUltimaCuotaPaga)
    Me.Panel1.Controls.Add(Me.lblFechaUltimoPago)
    Me.Panel1.Controls.Add(Me.txtPagosYTipos)
    Me.Panel1.Controls.Add(Me.lblCuotasConvenio)
    Me.Panel1.Location = New System.Drawing.Point(935, 35)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(320, 368)
    Me.Panel1.TabIndex = 84
    '
    'btnMensajes
    '
    Me.btnMensajes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnMensajes.FlatAppearance.BorderSize = 0
    Me.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMensajes.ForeColor = System.Drawing.Color.White
    Me.btnMensajes.Location = New System.Drawing.Point(13, 90)
    Me.btnMensajes.Margin = New System.Windows.Forms.Padding(10)
    Me.btnMensajes.Name = "btnMensajes"
    Me.btnMensajes.Size = New System.Drawing.Size(110, 60)
    Me.btnMensajes.TabIndex = 70
    Me.btnMensajes.Text = "Mensajes"
    Me.btnMensajes.UseVisualStyleBackColor = False
    '
    'frmDeben
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.lblCount)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnEditarPagos)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.dgvVentas)
    Me.Controls.Add(Me.btnEliminarVenta)
    Me.Controls.Add(Me.lblSoftwareInfo)
    Me.Controls.Add(Me.btnMinimize)
    Me.Controls.Add(Me.lblFechaHoy)
    Me.Controls.Add(Me.lblTitulo)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnEditarVenta)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.TabControl1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmDeben"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmDeben"
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.tbBuscar.ResumeLayout(False)
    Me.tbBuscar.PerformLayout()
    Me.tbResumen.ResumeLayout(False)
    Me.tbOperaciones.ResumeLayout(False)
    CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoConsultaVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dtVendidosHasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents TipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtVendidosDesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btnLstVendedores As System.Windows.Forms.Button
  Friend WithEvents btnListaClientes As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEditarVenta As System.Windows.Forms.Button
  Friend WithEvents btnArticulos As System.Windows.Forms.Button
  Friend WithEvents btnLiquidVendedores As System.Windows.Forms.Button
  Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
  Friend WithEvents btnMinimize As System.Windows.Forms.Button
  Friend WithEvents lblTitulo As System.Windows.Forms.Label
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents NombreClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ArticulosVendidodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblTotalProductos As System.Windows.Forms.Label
  Friend WithEvents lblTotalArticulos As System.Windows.Forms.Label
  Friend WithEvents cmbMetodosDePago As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tbBuscar As System.Windows.Forms.TabPage
  Friend WithEvents tbResumen As System.Windows.Forms.TabPage
  Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
  Friend WithEvents lblPagos As System.Windows.Forms.Label
  Friend WithEvents lblPrecioTotal As System.Windows.Forms.Label
  Friend WithEvents lblPrecioInteres As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents tbOperaciones As System.Windows.Forms.TabPage
  Friend WithEvents lblFechaHoy As System.Windows.Forms.Label
  Friend WithEvents lblSoftwareInfo As System.Windows.Forms.Label
  Friend WithEvents btnEliminarVenta As System.Windows.Forms.Button
  Friend WithEvents btnEditarPagos As System.Windows.Forms.Button
  Friend WithEvents chkVendidosDesde As System.Windows.Forms.CheckBox
  Friend WithEvents btnprocesar As System.Windows.Forms.Button
  Friend WithEvents chkVendidosHasta As System.Windows.Forms.CheckBox
  Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
  Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
  Public WithEvents dgvVentas As System.Windows.Forms.DataGridView
  Friend WithEvents ClsInfoConsultaVentasBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents chkMetodoPago As System.Windows.Forms.CheckBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents dtDebenHasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkDebenHasta As System.Windows.Forms.CheckBox
  Friend WithEvents btnLimpiarCampos As System.Windows.Forms.Button
  Friend WithEvents lblCount As System.Windows.Forms.Label
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents lblFechaUltimoPago As System.Windows.Forms.Label
  Friend WithEvents lblCuotasConvenio As System.Windows.Forms.Label
  Friend WithEvents txtPagosYTipos As System.Windows.Forms.TextBox
  Friend WithEvents lblNumUltimaCuotaPaga As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents IDContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VendedorDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MetodoPagoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClienteApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VendedorNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VendedorApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VendidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaFinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GUIDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblNroContrato As System.Windows.Forms.Label
  Friend WithEvents txtNroContrato As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNombreProducto As System.Windows.Forms.TextBox
  Friend WithEvents btnMensajes As System.Windows.Forms.Button
End Class
