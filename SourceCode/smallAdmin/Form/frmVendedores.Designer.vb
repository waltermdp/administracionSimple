﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
    Me.dgvListVendedores = New System.Windows.Forms.DataGridView()
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
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btnBorrar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnLiquidar = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.txtFiltro = New System.Windows.Forms.TextBox()
    Me.cmbGrupo = New System.Windows.Forms.ComboBox()
    Me.btnSeleccionar = New System.Windows.Forms.Button()
    CType(Me.dgvListVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvListVendedores
    '
    Me.dgvListVendedores.AllowUserToAddRows = False
    Me.dgvListVendedores.AllowUserToDeleteRows = False
    Me.dgvListVendedores.AllowUserToResizeRows = False
    Me.dgvListVendedores.AutoGenerateColumns = False
    Me.dgvListVendedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvListVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvListVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvListVendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvListVendedores.ColumnHeadersHeight = 24
    Me.dgvListVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvListVendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVendedorDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NumVendedorDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.Tel1DataGridViewTextBoxColumn, Me.Tel2DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.ComentarioDataGridViewTextBoxColumn})
    Me.dgvListVendedores.DataSource = Me.bsVendedores
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvListVendedores.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvListVendedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvListVendedores.EnableHeadersVisualStyles = False
    Me.dgvListVendedores.GridColor = System.Drawing.Color.White
    Me.dgvListVendedores.Location = New System.Drawing.Point(183, 158)
    Me.dgvListVendedores.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvListVendedores.MultiSelect = False
    Me.dgvListVendedores.Name = "dgvListVendedores"
    Me.dgvListVendedores.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvListVendedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvListVendedores.RowHeadersVisible = False
    Me.dgvListVendedores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.dgvListVendedores.RowTemplate.Height = 24
    Me.dgvListVendedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvListVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvListVendedores.Size = New System.Drawing.Size(1071, 523)
    Me.dgvListVendedores.TabIndex = 25
    Me.dgvListVendedores.TabStop = False
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
    '
    'ProvinciaDataGridViewTextBoxColumn
    '
    Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
    Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
    Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
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
    Me.IDDataGridViewTextBoxColumn.Visible = False
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
    '
    'Tel2DataGridViewTextBoxColumn
    '
    Me.Tel2DataGridViewTextBoxColumn.DataPropertyName = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.HeaderText = "Tel2"
    Me.Tel2DataGridViewTextBoxColumn.Name = "Tel2DataGridViewTextBoxColumn"
    Me.Tel2DataGridViewTextBoxColumn.ReadOnly = True
    '
    'EmailDataGridViewTextBoxColumn
    '
    Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
    Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
    Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
    Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CategoriaDataGridViewTextBoxColumn
    '
    Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
    Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
    Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
    Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
    Me.CategoriaDataGridViewTextBoxColumn.Visible = False
    '
    'ComentarioDataGridViewTextBoxColumn
    '
    Me.ComentarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ComentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario"
    Me.ComentarioDataGridViewTextBoxColumn.HeaderText = "Comentario"
    Me.ComentarioDataGridViewTextBoxColumn.Name = "ComentarioDataGridViewTextBoxColumn"
    Me.ComentarioDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsVendedores
    '
    Me.bsVendedores.DataSource = GetType(manDB.clsInfoVendedor)
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderSize = 0
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(10, 105)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 60)
    Me.btnNuevo.TabIndex = 26
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditar.FlatAppearance.BorderSize = 0
    Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ForeColor = System.Drawing.Color.White
    Me.btnEditar.Location = New System.Drawing.Point(10, 245)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 60)
    Me.btnEditar.TabIndex = 27
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btnBorrar
    '
    Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBorrar.FlatAppearance.BorderSize = 0
    Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBorrar.ForeColor = System.Drawing.Color.White
    Me.btnBorrar.Location = New System.Drawing.Point(10, 315)
    Me.btnBorrar.Name = "btnBorrar"
    Me.btnBorrar.Size = New System.Drawing.Size(110, 60)
    Me.btnBorrar.TabIndex = 28
    Me.btnBorrar.Text = "Eliminar"
    Me.btnBorrar.UseVisualStyleBackColor = False
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
    Me.btnVolver.TabIndex = 29
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
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
    Me.Label1.Text = "LISTA DE VENDEDORES"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'btnLiquidar
    '
    Me.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLiquidar.FlatAppearance.BorderSize = 0
    Me.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLiquidar.ForeColor = System.Drawing.Color.White
    Me.btnLiquidar.Location = New System.Drawing.Point(10, 175)
    Me.btnLiquidar.Name = "btnLiquidar"
    Me.btnLiquidar.Size = New System.Drawing.Size(110, 60)
    Me.btnLiquidar.TabIndex = 31
    Me.btnLiquidar.Text = "Liquidar"
    Me.btnLiquidar.UseVisualStyleBackColor = False
    Me.btnLiquidar.Visible = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(180, 75)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(322, 15)
    Me.Label2.TabIndex = 32
    Me.Label2.Text = "Filtro por Apellido, Nombre, Numero de vendedor o Grupo"
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnBuscar.FlatAppearance.BorderSize = 0
    Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ForeColor = System.Drawing.Color.White
    Me.btnBuscar.Location = New System.Drawing.Point(520, 75)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 61)
    Me.btnBuscar.TabIndex = 34
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'txtFiltro
    '
    Me.txtFiltro.Location = New System.Drawing.Point(183, 93)
    Me.txtFiltro.Name = "txtFiltro"
    Me.txtFiltro.Size = New System.Drawing.Size(319, 20)
    Me.txtFiltro.TabIndex = 33
    '
    'cmbGrupo
    '
    Me.cmbGrupo.FormattingEnabled = True
    Me.cmbGrupo.Location = New System.Drawing.Point(753, 96)
    Me.cmbGrupo.Name = "cmbGrupo"
    Me.cmbGrupo.Size = New System.Drawing.Size(206, 21)
    Me.cmbGrupo.TabIndex = 35
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionar.FlatAppearance.BorderSize = 0
    Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
    Me.btnSeleccionar.Location = New System.Drawing.Point(10, 35)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 60)
    Me.btnSeleccionar.TabIndex = 36
    Me.btnSeleccionar.Text = "Seleccionar"
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'frmVendedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.cmbGrupo)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.txtFiltro)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnBorrar)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.dgvListVendedores)
    Me.Controls.Add(Me.btnLiquidar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmVendedores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmVendedores"
    CType(Me.dgvListVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Public WithEvents dgvListVendedores As System.Windows.Forms.DataGridView
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents btnBorrar As System.Windows.Forms.Button
  Friend WithEvents bsVendedores As System.Windows.Forms.BindingSource
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnLiquidar As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
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
  Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
End Class
