<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionVendedores
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionVendedores))
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnLiquidar = New System.Windows.Forms.Button()
    Me.dgvData = New System.Windows.Forms.DataGridView()
    Me.IdVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ComentarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsVendedores = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
    Me.dtFinal = New System.Windows.Forms.DateTimePicker()
    Me.dtInicio = New System.Windows.Forms.DateTimePicker()
    Me.lblNombre = New System.Windows.Forms.Label()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.pbxResumen = New System.Windows.Forms.PictureBox()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Location = New System.Drawing.Point(194, 66)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(39, 13)
    Me.lblFecha.TabIndex = 0
    Me.lblFecha.Text = "Label1"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(193, 94)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Filtro"
    '
    'btnLiquidar
    '
    Me.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLiquidar.FlatAppearance.BorderSize = 0
    Me.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLiquidar.ForeColor = System.Drawing.Color.White
    Me.btnLiquidar.Location = New System.Drawing.Point(987, 65)
    Me.btnLiquidar.Name = "btnLiquidar"
    Me.btnLiquidar.Size = New System.Drawing.Size(110, 61)
    Me.btnLiquidar.TabIndex = 14
    Me.btnLiquidar.Text = "Liquidar"
    Me.btnLiquidar.UseVisualStyleBackColor = False
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
    Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVendedorDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NumVendedorDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.Tel1DataGridViewTextBoxColumn, Me.Tel2DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.ComentarioDataGridViewTextBoxColumn})
    Me.dgvData.DataSource = Me.bsVendedores
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
    Me.dgvData.Location = New System.Drawing.Point(184, 312)
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
    Me.dgvData.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData.Size = New System.Drawing.Size(664, 209)
    Me.dgvData.TabIndex = 34
    Me.dgvData.TabStop = False
    '
    'IdVendedorDataGridViewTextBoxColumn
    '
    Me.IdVendedorDataGridViewTextBoxColumn.DataPropertyName = "IdVendedor"
    Me.IdVendedorDataGridViewTextBoxColumn.HeaderText = "IdVendedor"
    Me.IdVendedorDataGridViewTextBoxColumn.Name = "IdVendedorDataGridViewTextBoxColumn"
    Me.IdVendedorDataGridViewTextBoxColumn.ReadOnly = True
    Me.IdVendedorDataGridViewTextBoxColumn.Visible = False
    '
    'GuidVendedorDataGridViewTextBoxColumn
    '
    Me.GuidVendedorDataGridViewTextBoxColumn.DataPropertyName = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.HeaderText = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.Name = "GuidVendedorDataGridViewTextBoxColumn"
    Me.GuidVendedorDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidVendedorDataGridViewTextBoxColumn.Visible = False
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ApellidoDataGridViewTextBoxColumn
    '
    Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
    Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
    Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
    Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumVendedorDataGridViewTextBoxColumn
    '
    Me.NumVendedorDataGridViewTextBoxColumn.DataPropertyName = "NumVendedor"
    Me.NumVendedorDataGridViewTextBoxColumn.HeaderText = "NumVendedor"
    Me.NumVendedorDataGridViewTextBoxColumn.Name = "NumVendedorDataGridViewTextBoxColumn"
    Me.NumVendedorDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CiudadDataGridViewTextBoxColumn
    '
    Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
    Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
    Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
    Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
    Me.CiudadDataGridViewTextBoxColumn.Visible = False
    '
    'ProvinciaDataGridViewTextBoxColumn
    '
    Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
    Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
    Me.ProvinciaDataGridViewTextBoxColumn.Visible = False
    '
    'CodigoPostalDataGridViewTextBoxColumn
    '
    Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal"
    Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal"
    Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
    Me.CodigoPostalDataGridViewTextBoxColumn.ReadOnly = True
    Me.CodigoPostalDataGridViewTextBoxColumn.Visible = False
    '
    'IDDataGridViewTextBoxColumn
    '
    Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
    Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
    Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
    Me.IDDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GrupoDataGridViewTextBoxColumn
    '
    Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
    Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
    Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
    Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'Tel1DataGridViewTextBoxColumn
    '
    Me.Tel1DataGridViewTextBoxColumn.DataPropertyName = "Tel1"
    Me.Tel1DataGridViewTextBoxColumn.HeaderText = "Tel1"
    Me.Tel1DataGridViewTextBoxColumn.Name = "Tel1DataGridViewTextBoxColumn"
    Me.Tel1DataGridViewTextBoxColumn.ReadOnly = True
    Me.Tel1DataGridViewTextBoxColumn.Visible = False
    '
    'Tel2DataGridViewTextBoxColumn
    '
    Me.Tel2DataGridViewTextBoxColumn.DataPropertyName = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.HeaderText = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.Name = "Tel2DataGridViewTextBoxColumn"
    Me.Tel2DataGridViewTextBoxColumn.ReadOnly = True
    Me.Tel2DataGridViewTextBoxColumn.Visible = False
    '
    'EmailDataGridViewTextBoxColumn
    '
    Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
    Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
    Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
    Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
    Me.EmailDataGridViewTextBoxColumn.Visible = False
    '
    'CategoriaDataGridViewTextBoxColumn
    '
    Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
    Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
    Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
    Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ComentarioDataGridViewTextBoxColumn
    '
    Me.ComentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario"
    Me.ComentarioDataGridViewTextBoxColumn.HeaderText = "Comentario"
    Me.ComentarioDataGridViewTextBoxColumn.Name = "ComentarioDataGridViewTextBoxColumn"
    Me.ComentarioDataGridViewTextBoxColumn.ReadOnly = True
    Me.ComentarioDataGridViewTextBoxColumn.Visible = False
    '
    'bsVendedores
    '
    Me.bsVendedores.DataSource = GetType(manDB.clsInfoVendedor)
    '
    'cmbPeriodo
    '
    Me.cmbPeriodo.FormattingEnabled = True
    Me.cmbPeriodo.Location = New System.Drawing.Point(691, 65)
    Me.cmbPeriodo.Name = "cmbPeriodo"
    Me.cmbPeriodo.Size = New System.Drawing.Size(189, 21)
    Me.cmbPeriodo.TabIndex = 35
    '
    'dtFinal
    '
    Me.dtFinal.Location = New System.Drawing.Point(473, 66)
    Me.dtFinal.Name = "dtFinal"
    Me.dtFinal.Size = New System.Drawing.Size(200, 20)
    Me.dtFinal.TabIndex = 36
    '
    'dtInicio
    '
    Me.dtInicio.Location = New System.Drawing.Point(255, 66)
    Me.dtInicio.Name = "dtInicio"
    Me.dtInicio.Size = New System.Drawing.Size(200, 20)
    Me.dtInicio.TabIndex = 37
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(194, 124)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(39, 13)
    Me.lblNombre.TabIndex = 38
    Me.lblNombre.Text = "Label2"
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(30, 556)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 61)
    Me.btnVolver.TabIndex = 39
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'pbxResumen
    '
    Me.pbxResumen.Location = New System.Drawing.Point(307, 132)
    Me.pbxResumen.Name = "pbxResumen"
    Me.pbxResumen.Size = New System.Drawing.Size(896, 537)
    Me.pbxResumen.TabIndex = 41
    Me.pbxResumen.TabStop = False
    '
    'frmLiquidacionVendedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.pbxResumen)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.lblNombre)
    Me.Controls.Add(Me.dtInicio)
    Me.Controls.Add(Me.dtFinal)
    Me.Controls.Add(Me.cmbPeriodo)
    Me.Controls.Add(Me.dgvData)
    Me.Controls.Add(Me.btnLiquidar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblFecha)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmLiquidacionVendedores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmLiquidacionVendedores"
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnLiquidar As System.Windows.Forms.Button
  Public WithEvents dgvData As System.Windows.Forms.DataGridView
  Friend WithEvents IdVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComentarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsVendedores As System.Windows.Forms.BindingSource
  Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents pbxResumen As System.Windows.Forms.PictureBox
End Class
