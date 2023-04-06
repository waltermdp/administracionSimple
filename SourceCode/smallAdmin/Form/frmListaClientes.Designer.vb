<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaClientes
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaClientes))
    Me.btnEdit = New System.Windows.Forms.Button()
    Me.dgvData1 = New System.Windows.Forms.DataGridView()
    Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProfesionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Calle2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCalle2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsInfoCliente = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.txtFiltro = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnMostrarErrores = New System.Windows.Forms.Button()
    Me.btnMostrarDuplicados = New System.Windows.Forms.Button()
    Me.lblInfo = New System.Windows.Forms.Label()
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsInfoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnEdit
    '
    Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEdit.FlatAppearance.BorderSize = 0
    Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEdit.ForeColor = System.Drawing.Color.White
    Me.btnEdit.Location = New System.Drawing.Point(24, 127)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(110, 61)
    Me.btnEdit.TabIndex = 0
    Me.btnEdit.Text = "Editar"
    Me.btnEdit.UseVisualStyleBackColor = False
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
    Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.GuidClienteDataGridViewTextBoxColumn, Me.NumClienteDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ProfesionDataGridViewTextBoxColumn, Me.Tel1DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.NumCalleDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.Tel2DataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.Calle2DataGridViewTextBoxColumn, Me.NumCalle2DataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn})
    Me.dgvData1.DataSource = Me.bsInfoCliente
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvData1.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvData1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvData1.EnableHeadersVisualStyles = False
    Me.dgvData1.GridColor = System.Drawing.Color.White
    Me.dgvData1.Location = New System.Drawing.Point(183, 158)
    Me.dgvData1.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvData1.MultiSelect = False
    Me.dgvData1.Name = "dgvData1"
    Me.dgvData1.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvData1.RowHeadersVisible = False
    Me.dgvData1.RowTemplate.Height = 24
    Me.dgvData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData1.Size = New System.Drawing.Size(1071, 523)
    Me.dgvData1.TabIndex = 24
    Me.dgvData1.TabStop = False
    '
    'IDClienteDataGridViewTextBoxColumn
    '
    Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
    Me.IDClienteDataGridViewTextBoxColumn.ReadOnly = True
    Me.IDClienteDataGridViewTextBoxColumn.Visible = False
    '
    'GuidClienteDataGridViewTextBoxColumn
    '
    Me.GuidClienteDataGridViewTextBoxColumn.DataPropertyName = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.HeaderText = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.Name = "GuidClienteDataGridViewTextBoxColumn"
    Me.GuidClienteDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidClienteDataGridViewTextBoxColumn.Visible = False
    '
    'NumClienteDataGridViewTextBoxColumn
    '
    Me.NumClienteDataGridViewTextBoxColumn.DataPropertyName = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.HeaderText = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.Name = "NumClienteDataGridViewTextBoxColumn"
    Me.NumClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ApellidoDataGridViewTextBoxColumn
    '
    Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
    Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
    Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
    Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ProfesionDataGridViewTextBoxColumn
    '
    Me.ProfesionDataGridViewTextBoxColumn.DataPropertyName = "Profesion"
    Me.ProfesionDataGridViewTextBoxColumn.HeaderText = "Profesion"
    Me.ProfesionDataGridViewTextBoxColumn.Name = "ProfesionDataGridViewTextBoxColumn"
    Me.ProfesionDataGridViewTextBoxColumn.ReadOnly = True
    '
    'Tel1DataGridViewTextBoxColumn
    '
    Me.Tel1DataGridViewTextBoxColumn.DataPropertyName = "Tel1"
    Me.Tel1DataGridViewTextBoxColumn.HeaderText = "Tel1"
    Me.Tel1DataGridViewTextBoxColumn.Name = "Tel1DataGridViewTextBoxColumn"
    Me.Tel1DataGridViewTextBoxColumn.ReadOnly = True
    '
    'EmailDataGridViewTextBoxColumn
    '
    Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
    Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
    Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
    Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
    '
    'DNIDataGridViewTextBoxColumn
    '
    Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
    Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
    Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
    Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
    Me.DNIDataGridViewTextBoxColumn.Visible = False
    '
    'FechaNacDataGridViewTextBoxColumn
    '
    Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac"
    Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac"
    Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
    Me.FechaNacDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaNacDataGridViewTextBoxColumn.Visible = False
    '
    'CalleDataGridViewTextBoxColumn
    '
    Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
    Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
    Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
    Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumCalleDataGridViewTextBoxColumn
    '
    Me.NumCalleDataGridViewTextBoxColumn.DataPropertyName = "NumCalle"
    Me.NumCalleDataGridViewTextBoxColumn.HeaderText = "NumCalle"
    Me.NumCalleDataGridViewTextBoxColumn.Name = "NumCalleDataGridViewTextBoxColumn"
    Me.NumCalleDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaIngresoDataGridViewTextBoxColumn
    '
    Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso"
    Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso"
    Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
    Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
    Me.FechaIngresoDataGridViewTextBoxColumn.Visible = False
    '
    'Tel2DataGridViewTextBoxColumn
    '
    Me.Tel2DataGridViewTextBoxColumn.DataPropertyName = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.HeaderText = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.Name = "Tel2DataGridViewTextBoxColumn"
    Me.Tel2DataGridViewTextBoxColumn.ReadOnly = True
    '
    'CiudadDataGridViewTextBoxColumn
    '
    Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
    Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
    Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
    Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ProvinciaDataGridViewTextBoxColumn
    '
    Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
    Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
    Me.ProvinciaDataGridViewTextBoxColumn.Visible = False
    '
    'Calle2DataGridViewTextBoxColumn
    '
    Me.Calle2DataGridViewTextBoxColumn.DataPropertyName = "Calle2"
    Me.Calle2DataGridViewTextBoxColumn.HeaderText = "Calle2"
    Me.Calle2DataGridViewTextBoxColumn.Name = "Calle2DataGridViewTextBoxColumn"
    Me.Calle2DataGridViewTextBoxColumn.ReadOnly = True
    Me.Calle2DataGridViewTextBoxColumn.Visible = False
    '
    'NumCalle2DataGridViewTextBoxColumn
    '
    Me.NumCalle2DataGridViewTextBoxColumn.DataPropertyName = "NumCalle2"
    Me.NumCalle2DataGridViewTextBoxColumn.HeaderText = "NumCalle2"
    Me.NumCalle2DataGridViewTextBoxColumn.Name = "NumCalle2DataGridViewTextBoxColumn"
    Me.NumCalle2DataGridViewTextBoxColumn.ReadOnly = True
    Me.NumCalle2DataGridViewTextBoxColumn.Visible = False
    '
    'CodigoPostalDataGridViewTextBoxColumn
    '
    Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal"
    Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal"
    Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
    Me.CodigoPostalDataGridViewTextBoxColumn.ReadOnly = True
    Me.CodigoPostalDataGridViewTextBoxColumn.Visible = False
    '
    'ComentariosDataGridViewTextBoxColumn
    '
    Me.ComentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios"
    Me.ComentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios"
    Me.ComentariosDataGridViewTextBoxColumn.Name = "ComentariosDataGridViewTextBoxColumn"
    Me.ComentariosDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsInfoCliente
    '
    Me.bsInfoCliente.DataSource = GetType(manDB.clsInfoDatabase)
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderSize = 0
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(24, 51)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 61)
    Me.btnNuevo.TabIndex = 25
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEliminar.FlatAppearance.BorderSize = 0
    Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.ForeColor = System.Drawing.Color.White
    Me.btnEliminar.Location = New System.Drawing.Point(24, 203)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(110, 61)
    Me.btnEliminar.TabIndex = 26
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
    Me.btnVolver.TabIndex = 28
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(551, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(180, 20)
    Me.Label1.TabIndex = 29
    Me.Label1.Text = "LISTA DE CLIENTES"
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBuscar.FlatAppearance.BorderSize = 0
    Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ForeColor = System.Drawing.Color.White
    Me.btnBuscar.Location = New System.Drawing.Point(497, 75)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 61)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'txtFiltro
    '
    Me.txtFiltro.Location = New System.Drawing.Point(183, 94)
    Me.txtFiltro.Name = "txtFiltro"
    Me.txtFiltro.Size = New System.Drawing.Size(292, 20)
    Me.txtFiltro.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.White
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(180, 75)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(299, 15)
    Me.Label2.TabIndex = 35
    Me.Label2.Text = "Filtro por DNI, Apellido, Nombre  o Numero de Cliente"
    '
    'btnMostrarErrores
    '
    Me.btnMostrarErrores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnMostrarErrores.FlatAppearance.BorderSize = 0
    Me.btnMostrarErrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMostrarErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMostrarErrores.ForeColor = System.Drawing.Color.White
    Me.btnMostrarErrores.Location = New System.Drawing.Point(926, 75)
    Me.btnMostrarErrores.Name = "btnMostrarErrores"
    Me.btnMostrarErrores.Size = New System.Drawing.Size(224, 26)
    Me.btnMostrarErrores.TabIndex = 38
    Me.btnMostrarErrores.Text = "MostrarSinDNI o numCliente"
    Me.btnMostrarErrores.UseVisualStyleBackColor = False
    Me.btnMostrarErrores.Visible = False
    '
    'btnMostrarDuplicados
    '
    Me.btnMostrarDuplicados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnMostrarDuplicados.FlatAppearance.BorderSize = 0
    Me.btnMostrarDuplicados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnMostrarDuplicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMostrarDuplicados.ForeColor = System.Drawing.Color.White
    Me.btnMostrarDuplicados.Location = New System.Drawing.Point(926, 110)
    Me.btnMostrarDuplicados.Name = "btnMostrarDuplicados"
    Me.btnMostrarDuplicados.Size = New System.Drawing.Size(224, 26)
    Me.btnMostrarDuplicados.TabIndex = 39
    Me.btnMostrarDuplicados.Text = "Mostrar duplicados"
    Me.btnMostrarDuplicados.UseVisualStyleBackColor = False
    Me.btnMostrarDuplicados.Visible = False
    '
    'lblInfo
    '
    Me.lblInfo.AutoSize = True
    Me.lblInfo.BackColor = System.Drawing.Color.White
    Me.lblInfo.Location = New System.Drawing.Point(180, 145)
    Me.lblInfo.Name = "lblInfo"
    Me.lblInfo.Size = New System.Drawing.Size(10, 13)
    Me.lblInfo.TabIndex = 40
    Me.lblInfo.Text = " "
    '
    'frmListaClientes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.lblInfo)
    Me.Controls.Add(Me.btnMostrarDuplicados)
    Me.Controls.Add(Me.btnMostrarErrores)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.txtFiltro)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.dgvData1)
    Me.Controls.Add(Me.btnEdit)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmListaClientes"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Form1"
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsInfoCliente, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Public WithEvents dgvData1 As System.Windows.Forms.DataGridView
  Friend WithEvents bsInfoCliente As System.Windows.Forms.BindingSource
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents IDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProfesionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Calle2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCalle2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComentariosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnMostrarErrores As System.Windows.Forms.Button
  Friend WithEvents btnMostrarDuplicados As System.Windows.Forms.Button
  Friend WithEvents lblInfo As System.Windows.Forms.Label

End Class
