<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.gbProducto = New System.Windows.Forms.GroupBox()
    Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.dgvStock = New System.Windows.Forms.DataGridView()
    Me.GuidArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmbResponsables = New System.Windows.Forms.ComboBox()
    Me.btnGrupos = New System.Windows.Forms.Button()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.rbtnBuscarResponsables = New System.Windows.Forms.RadioButton()
    Me.rbnBuscarPalabra = New System.Windows.Forms.RadioButton()
    Me.chkDescripcion = New System.Windows.Forms.CheckBox()
    Me.chkCodigoBarras = New System.Windows.Forms.CheckBox()
    Me.chkCodigo = New System.Windows.Forms.CheckBox()
    Me.chkNombre = New System.Windows.Forms.CheckBox()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.txtPalabraBuscar = New System.Windows.Forms.TextBox()
    Me.gbAcciones = New System.Windows.Forms.GroupBox()
    Me.gbAccionDeposito = New System.Windows.Forms.GroupBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.nIncrementar = New System.Windows.Forms.NumericUpDown()
    Me.btnIngresarArticulos = New System.Windows.Forms.Button()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.nDescontar = New System.Windows.Forms.NumericUpDown()
    Me.btnDescontarArticulo = New System.Windows.Forms.Button()
    Me.btnMoverArticulo = New System.Windows.Forms.Button()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.cmbDestinoResp = New System.Windows.Forms.ComboBox()
    Me.lblResponsableFuente = New System.Windows.Forms.Label()
    Me.nMover = New System.Windows.Forms.NumericUpDown()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
    Me.gbProducto.SuspendLayout()
    CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox3.SuspendLayout()
    Me.gbAcciones.SuspendLayout()
    Me.gbAccionDeposito.SuspendLayout()
    CType(Me.nIncrementar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nDescontar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nMover, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.SystemColors.Control
    Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombre.Location = New System.Drawing.Point(30, 41)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(337, 24)
    Me.txtNombre.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(27, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(57, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Nombre"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(27, 65)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(52, 16)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Codigo"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(27, 158)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(80, 16)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Descripcion"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.SystemColors.Control
    Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodigo.Location = New System.Drawing.Point(30, 81)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(160, 24)
    Me.txtCodigo.TabIndex = 4
    '
    'txtDescripcion
    '
    Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Control
    Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDescripcion.Location = New System.Drawing.Point(30, 177)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(431, 98)
    Me.txtDescripcion.TabIndex = 5
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditar.FlatAppearance.BorderSize = 0
    Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ForeColor = System.Drawing.Color.White
    Me.btnEditar.Location = New System.Drawing.Point(24, 126)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 61)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEliminar.FlatAppearance.BorderSize = 0
    Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.ForeColor = System.Drawing.Color.White
    Me.btnEliminar.Location = New System.Drawing.Point(24, 202)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(110, 61)
    Me.btnEliminar.TabIndex = 8
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(24, 636)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 61)
    Me.btnVolver.TabIndex = 9
    Me.btnVolver.Text = "Atras"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderSize = 0
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(24, 53)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 61)
    Me.btnNuevo.TabIndex = 11
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'gbProducto
    '
    Me.gbProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.gbProducto.Controls.Add(Me.txtCodigoBarras)
    Me.gbProducto.Controls.Add(Me.Label16)
    Me.gbProducto.Controls.Add(Me.Label10)
    Me.gbProducto.Controls.Add(Me.txtPrecio)
    Me.gbProducto.Controls.Add(Me.Label1)
    Me.gbProducto.Controls.Add(Me.txtNombre)
    Me.gbProducto.Controls.Add(Me.Label2)
    Me.gbProducto.Controls.Add(Me.Label3)
    Me.gbProducto.Controls.Add(Me.txtCodigo)
    Me.gbProducto.Controls.Add(Me.txtDescripcion)
    Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbProducto.Location = New System.Drawing.Point(792, 220)
    Me.gbProducto.Name = "gbProducto"
    Me.gbProducto.Size = New System.Drawing.Size(476, 281)
    Me.gbProducto.TabIndex = 27
    Me.gbProducto.TabStop = False
    Me.gbProducto.Text = "Informacion del Articulo"
    '
    'txtCodigoBarras
    '
    Me.txtCodigoBarras.BackColor = System.Drawing.SystemColors.Control
    Me.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodigoBarras.Location = New System.Drawing.Point(199, 87)
    Me.txtCodigoBarras.Name = "txtCodigoBarras"
    Me.txtCodigoBarras.Size = New System.Drawing.Size(160, 24)
    Me.txtCodigoBarras.TabIndex = 9
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.Location = New System.Drawing.Point(196, 68)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(92, 16)
    Me.Label16.TabIndex = 8
    Me.Label16.Text = "CodigoBarras"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(32, 112)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(47, 16)
    Me.Label10.TabIndex = 6
    Me.Label10.Text = "Precio"
    '
    'txtPrecio
    '
    Me.txtPrecio.BackColor = System.Drawing.SystemColors.Control
    Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPrecio.Location = New System.Drawing.Point(30, 131)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(168, 24)
    Me.txtPrecio.TabIndex = 7
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(550, 9)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(195, 20)
    Me.Label4.TabIndex = 28
    Me.Label4.Text = "LISTA DE ARTICULOS"
    '
    'dgvStock
    '
    Me.dgvStock.AllowUserToAddRows = False
    Me.dgvStock.AllowUserToDeleteRows = False
    Me.dgvStock.AllowUserToResizeRows = False
    Me.dgvStock.AutoGenerateColumns = False
    Me.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvStock.ColumnHeadersHeight = 24
    Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuidArticuloDataGridViewTextBoxColumn, Me.ResponsableDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.GuidResponsableDataGridViewTextBoxColumn})
    Me.dgvStock.DataSource = Me.BindingSource1
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvStock.EnableHeadersVisualStyles = False
    Me.dgvStock.GridColor = System.Drawing.Color.White
    Me.dgvStock.Location = New System.Drawing.Point(177, 217)
    Me.dgvStock.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvStock.MultiSelect = False
    Me.dgvStock.Name = "dgvStock"
    Me.dgvStock.ReadOnly = True
    Me.dgvStock.RowHeadersVisible = False
    Me.dgvStock.RowTemplate.Height = 24
    Me.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvStock.Size = New System.Drawing.Size(602, 284)
    Me.dgvStock.TabIndex = 33
    Me.dgvStock.TabStop = False
    '
    'GuidArticuloDataGridViewTextBoxColumn
    '
    Me.GuidArticuloDataGridViewTextBoxColumn.DataPropertyName = "GuidArticulo"
    Me.GuidArticuloDataGridViewTextBoxColumn.HeaderText = "GuidArticulo"
    Me.GuidArticuloDataGridViewTextBoxColumn.Name = "GuidArticuloDataGridViewTextBoxColumn"
    Me.GuidArticuloDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidArticuloDataGridViewTextBoxColumn.Visible = False
    '
    'ResponsableDataGridViewTextBoxColumn
    '
    Me.ResponsableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ResponsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable"
    Me.ResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable"
    Me.ResponsableDataGridViewTextBoxColumn.Name = "ResponsableDataGridViewTextBoxColumn"
    Me.ResponsableDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CodigoDataGridViewTextBoxColumn
    '
    Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
    Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CantidadDataGridViewTextBoxColumn
    '
    Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
    Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
    Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
    Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
    '
    'PrecioDataGridViewTextBoxColumn
    '
    Me.PrecioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
    Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
    '
    'DescripcionDataGridViewTextBoxColumn
    '
    Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
    Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
    Me.DescripcionDataGridViewTextBoxColumn.Visible = False
    '
    'GuidResponsableDataGridViewTextBoxColumn
    '
    Me.GuidResponsableDataGridViewTextBoxColumn.DataPropertyName = "GuidResponsable"
    Me.GuidResponsableDataGridViewTextBoxColumn.HeaderText = "GuidResponsable"
    Me.GuidResponsableDataGridViewTextBoxColumn.Name = "GuidResponsableDataGridViewTextBoxColumn"
    Me.GuidResponsableDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidResponsableDataGridViewTextBoxColumn.Visible = False
    '
    'BindingSource1
    '
    Me.BindingSource1.DataSource = GetType(main.clsListaStorage)
    '
    'cmbResponsables
    '
    Me.cmbResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbResponsables.FormattingEnabled = True
    Me.cmbResponsables.Location = New System.Drawing.Point(259, 71)
    Me.cmbResponsables.Name = "cmbResponsables"
    Me.cmbResponsables.Size = New System.Drawing.Size(210, 24)
    Me.cmbResponsables.TabIndex = 38
    '
    'btnGrupos
    '
    Me.btnGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGrupos.FlatAppearance.BorderSize = 0
    Me.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGrupos.ForeColor = System.Drawing.Color.White
    Me.btnGrupos.Location = New System.Drawing.Point(24, 283)
    Me.btnGrupos.Name = "btnGrupos"
    Me.btnGrupos.Size = New System.Drawing.Size(110, 61)
    Me.btnGrupos.TabIndex = 45
    Me.btnGrupos.Text = "Grupos"
    Me.btnGrupos.UseVisualStyleBackColor = False
    '
    'GroupBox3
    '
    Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.GroupBox3.Controls.Add(Me.rbtnBuscarResponsables)
    Me.GroupBox3.Controls.Add(Me.rbnBuscarPalabra)
    Me.GroupBox3.Controls.Add(Me.chkDescripcion)
    Me.GroupBox3.Controls.Add(Me.chkCodigoBarras)
    Me.GroupBox3.Controls.Add(Me.chkCodigo)
    Me.GroupBox3.Controls.Add(Me.chkNombre)
    Me.GroupBox3.Controls.Add(Me.btnBuscar)
    Me.GroupBox3.Controls.Add(Me.txtPalabraBuscar)
    Me.GroupBox3.Controls.Add(Me.cmbResponsables)
    Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox3.Location = New System.Drawing.Point(177, 67)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(1091, 147)
    Me.GroupBox3.TabIndex = 46
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Buscar Articulos"
    '
    'rbtnBuscarResponsables
    '
    Me.rbtnBuscarResponsables.AutoSize = True
    Me.rbtnBuscarResponsables.Location = New System.Drawing.Point(23, 70)
    Me.rbtnBuscarResponsables.Name = "rbtnBuscarResponsables"
    Me.rbtnBuscarResponsables.Size = New System.Drawing.Size(125, 20)
    Me.rbtnBuscarResponsables.TabIndex = 36
    Me.rbtnBuscarResponsables.Text = "Por Responsable"
    Me.rbtnBuscarResponsables.UseVisualStyleBackColor = True
    '
    'rbnBuscarPalabra
    '
    Me.rbnBuscarPalabra.AutoSize = True
    Me.rbnBuscarPalabra.Checked = True
    Me.rbnBuscarPalabra.Location = New System.Drawing.Point(23, 27)
    Me.rbnBuscarPalabra.Name = "rbnBuscarPalabra"
    Me.rbnBuscarPalabra.Size = New System.Drawing.Size(127, 20)
    Me.rbnBuscarPalabra.TabIndex = 35
    Me.rbnBuscarPalabra.TabStop = True
    Me.rbnBuscarPalabra.Text = "Por Palabra clave"
    Me.rbnBuscarPalabra.UseVisualStyleBackColor = True
    '
    'chkDescripcion
    '
    Me.chkDescripcion.AutoSize = True
    Me.chkDescripcion.Location = New System.Drawing.Point(673, 51)
    Me.chkDescripcion.Name = "chkDescripcion"
    Me.chkDescripcion.Size = New System.Drawing.Size(95, 20)
    Me.chkDescripcion.TabIndex = 34
    Me.chkDescripcion.Text = "Descripcion"
    Me.chkDescripcion.UseVisualStyleBackColor = True
    '
    'chkCodigoBarras
    '
    Me.chkCodigoBarras.AutoSize = True
    Me.chkCodigoBarras.Location = New System.Drawing.Point(673, 27)
    Me.chkCodigoBarras.Name = "chkCodigoBarras"
    Me.chkCodigoBarras.Size = New System.Drawing.Size(127, 20)
    Me.chkCodigoBarras.TabIndex = 33
    Me.chkCodigoBarras.Text = "Codigo de Barras"
    Me.chkCodigoBarras.UseVisualStyleBackColor = True
    '
    'chkCodigo
    '
    Me.chkCodigo.AutoSize = True
    Me.chkCodigo.Location = New System.Drawing.Point(571, 51)
    Me.chkCodigo.Name = "chkCodigo"
    Me.chkCodigo.Size = New System.Drawing.Size(67, 20)
    Me.chkCodigo.TabIndex = 32
    Me.chkCodigo.Text = "Codigo"
    Me.chkCodigo.UseVisualStyleBackColor = True
    '
    'chkNombre
    '
    Me.chkNombre.AutoSize = True
    Me.chkNombre.Location = New System.Drawing.Point(571, 27)
    Me.chkNombre.Name = "chkNombre"
    Me.chkNombre.Size = New System.Drawing.Size(72, 20)
    Me.chkNombre.TabIndex = 31
    Me.chkNombre.Text = "Nombre"
    Me.chkNombre.UseVisualStyleBackColor = True
    '
    'btnBuscar
    '
    Me.btnBuscar.Location = New System.Drawing.Point(23, 111)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(126, 23)
    Me.btnBuscar.TabIndex = 30
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'txtPalabraBuscar
    '
    Me.txtPalabraBuscar.Location = New System.Drawing.Point(259, 27)
    Me.txtPalabraBuscar.Name = "txtPalabraBuscar"
    Me.txtPalabraBuscar.Size = New System.Drawing.Size(265, 22)
    Me.txtPalabraBuscar.TabIndex = 28
    '
    'gbAcciones
    '
    Me.gbAcciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.gbAcciones.Controls.Add(Me.gbAccionDeposito)
    Me.gbAcciones.Controls.Add(Me.btnMoverArticulo)
    Me.gbAcciones.Controls.Add(Me.Label15)
    Me.gbAcciones.Controls.Add(Me.cmbDestinoResp)
    Me.gbAcciones.Controls.Add(Me.lblResponsableFuente)
    Me.gbAcciones.Controls.Add(Me.nMover)
    Me.gbAcciones.Controls.Add(Me.Label12)
    Me.gbAcciones.Location = New System.Drawing.Point(177, 504)
    Me.gbAcciones.Name = "gbAcciones"
    Me.gbAcciones.Size = New System.Drawing.Size(1091, 193)
    Me.gbAcciones.TabIndex = 47
    Me.gbAcciones.TabStop = False
    Me.gbAcciones.Text = "Acciones"
    '
    'gbAccionDeposito
    '
    Me.gbAccionDeposito.Controls.Add(Me.Label11)
    Me.gbAccionDeposito.Controls.Add(Me.nIncrementar)
    Me.gbAccionDeposito.Controls.Add(Me.btnIngresarArticulos)
    Me.gbAccionDeposito.Controls.Add(Me.Label13)
    Me.gbAccionDeposito.Controls.Add(Me.nDescontar)
    Me.gbAccionDeposito.Controls.Add(Me.btnDescontarArticulo)
    Me.gbAccionDeposito.Location = New System.Drawing.Point(23, 19)
    Me.gbAccionDeposito.Name = "gbAccionDeposito"
    Me.gbAccionDeposito.Size = New System.Drawing.Size(446, 79)
    Me.gbAccionDeposito.TabIndex = 17
    Me.gbAccionDeposito.TabStop = False
    Me.gbAccionDeposito.Text = "Deposito"
    '
    'Label11
    '
    Me.Label11.Location = New System.Drawing.Point(14, 16)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(170, 15)
    Me.Label11.TabIndex = 0
    Me.Label11.Text = "INGRESAR:"
    '
    'nIncrementar
    '
    Me.nIncrementar.Location = New System.Drawing.Point(190, 14)
    Me.nIncrementar.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
    Me.nIncrementar.Name = "nIncrementar"
    Me.nIncrementar.ReadOnly = True
    Me.nIncrementar.Size = New System.Drawing.Size(55, 20)
    Me.nIncrementar.TabIndex = 1
    '
    'btnIngresarArticulos
    '
    Me.btnIngresarArticulos.Location = New System.Drawing.Point(251, 11)
    Me.btnIngresarArticulos.Name = "btnIngresarArticulos"
    Me.btnIngresarArticulos.Size = New System.Drawing.Size(145, 23)
    Me.btnIngresarArticulos.TabIndex = 4
    Me.btnIngresarArticulos.Text = "Ingresar"
    Me.btnIngresarArticulos.UseVisualStyleBackColor = True
    '
    'Label13
    '
    Me.Label13.Location = New System.Drawing.Point(14, 53)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(170, 15)
    Me.Label13.TabIndex = 5
    Me.Label13.Text = "ELIMINAR:"
    '
    'nDescontar
    '
    Me.nDescontar.Location = New System.Drawing.Point(190, 51)
    Me.nDescontar.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
    Me.nDescontar.Name = "nDescontar"
    Me.nDescontar.ReadOnly = True
    Me.nDescontar.Size = New System.Drawing.Size(55, 20)
    Me.nDescontar.TabIndex = 6
    '
    'btnDescontarArticulo
    '
    Me.btnDescontarArticulo.Location = New System.Drawing.Point(251, 48)
    Me.btnDescontarArticulo.Name = "btnDescontarArticulo"
    Me.btnDescontarArticulo.Size = New System.Drawing.Size(145, 23)
    Me.btnDescontarArticulo.TabIndex = 9
    Me.btnDescontarArticulo.Text = "Eliminar"
    Me.btnDescontarArticulo.UseVisualStyleBackColor = True
    '
    'btnMoverArticulo
    '
    Me.btnMoverArticulo.Location = New System.Drawing.Point(789, 129)
    Me.btnMoverArticulo.Name = "btnMoverArticulo"
    Me.btnMoverArticulo.Size = New System.Drawing.Size(145, 23)
    Me.btnMoverArticulo.TabIndex = 16
    Me.btnMoverArticulo.Text = "Mover"
    Me.btnMoverArticulo.UseVisualStyleBackColor = True
    '
    'Label15
    '
    Me.Label15.Location = New System.Drawing.Point(519, 134)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(32, 23)
    Me.Label15.TabIndex = 15
    Me.Label15.Text = "-->"
    '
    'cmbDestinoResp
    '
    Me.cmbDestinoResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbDestinoResp.FormattingEnabled = True
    Me.cmbDestinoResp.Location = New System.Drawing.Point(557, 131)
    Me.cmbDestinoResp.Name = "cmbDestinoResp"
    Me.cmbDestinoResp.Size = New System.Drawing.Size(226, 21)
    Me.cmbDestinoResp.TabIndex = 14
    '
    'lblResponsableFuente
    '
    Me.lblResponsableFuente.Location = New System.Drawing.Point(271, 131)
    Me.lblResponsableFuente.Name = "lblResponsableFuente"
    Me.lblResponsableFuente.Size = New System.Drawing.Size(243, 18)
    Me.lblResponsableFuente.TabIndex = 12
    Me.lblResponsableFuente.Text = "Label12"
    Me.lblResponsableFuente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'nMover
    '
    Me.nMover.Location = New System.Drawing.Point(196, 132)
    Me.nMover.Name = "nMover"
    Me.nMover.ReadOnly = True
    Me.nMover.Size = New System.Drawing.Size(55, 20)
    Me.nMover.TabIndex = 11
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(37, 134)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(140, 17)
    Me.Label12.TabIndex = 10
    Me.Label12.Text = "MOVER:"
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'frmArticulos
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.gbAcciones)
    Me.Controls.Add(Me.GroupBox3)
    Me.Controls.Add(Me.btnGrupos)
    Me.Controls.Add(Me.dgvStock)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.gbProducto)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnEditar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmArticulos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmArticulos"
    Me.gbProducto.ResumeLayout(False)
    Me.gbProducto.PerformLayout()
    CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.gbAcciones.ResumeLayout(False)
    Me.gbAccionDeposito.ResumeLayout(False)
    CType(Me.nIncrementar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nDescontar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nMover, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
  Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Public WithEvents dgvStock As System.Windows.Forms.DataGridView
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents cmbResponsables As System.Windows.Forms.ComboBox
  Friend WithEvents btnGrupos As System.Windows.Forms.Button
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents GuidArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ResponsableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidResponsableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents txtPalabraBuscar As System.Windows.Forms.TextBox
  Friend WithEvents chkDescripcion As System.Windows.Forms.CheckBox
  Friend WithEvents chkCodigoBarras As System.Windows.Forms.CheckBox
  Friend WithEvents chkCodigo As System.Windows.Forms.CheckBox
  Friend WithEvents chkNombre As System.Windows.Forms.CheckBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents rbtnBuscarResponsables As System.Windows.Forms.RadioButton
  Friend WithEvents rbnBuscarPalabra As System.Windows.Forms.RadioButton
  Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
  Friend WithEvents btnIngresarArticulos As System.Windows.Forms.Button
  Friend WithEvents nIncrementar As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents btnMoverArticulo As System.Windows.Forms.Button
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents cmbDestinoResp As System.Windows.Forms.ComboBox
  Friend WithEvents lblResponsableFuente As System.Windows.Forms.Label
  Friend WithEvents nMover As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents btnDescontarArticulo As System.Windows.Forms.Button
  Friend WithEvents nDescontar As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents gbAccionDeposito As System.Windows.Forms.GroupBox
End Class
