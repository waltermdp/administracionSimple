﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Me.btnEdit = New System.Windows.Forms.Button()
    Me.dgvData1 = New System.Windows.Forms.DataGridView()
    Me.bsInfoCliente = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProfesionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Tel2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Calle2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCalle2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsInfoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnEdit
    '
    Me.btnEdit.Location = New System.Drawing.Point(30, 180)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(92, 52)
    Me.btnEdit.TabIndex = 0
    Me.btnEdit.Text = "Editar"
    Me.btnEdit.UseVisualStyleBackColor = True
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
    Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.GuidClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.ProfesionDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.NumCalleDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.Tel1DataGridViewTextBoxColumn, Me.Tel2DataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.Calle2DataGridViewTextBoxColumn, Me.NumCalle2DataGridViewTextBoxColumn, Me.NumClienteDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn})
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
    Me.dgvData1.Location = New System.Drawing.Point(165, 122)
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
    Me.dgvData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData1.Size = New System.Drawing.Size(1036, 447)
    Me.dgvData1.TabIndex = 24
    Me.dgvData1.TabStop = False
    '
    'bsInfoCliente
    '
    Me.bsInfoCliente.DataSource = GetType(manDB.clsInfoDatabase)
    '
    'btnNuevo
    '
    Me.btnNuevo.Location = New System.Drawing.Point(30, 122)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(92, 52)
    Me.btnNuevo.TabIndex = 25
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = True
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(30, 238)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(92, 52)
    Me.btnEliminar.TabIndex = 26
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'btnVolver
    '
    Me.btnVolver.Location = New System.Drawing.Point(30, 639)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(92, 52)
    Me.btnVolver.TabIndex = 28
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = True
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
    'DNIDataGridViewTextBoxColumn
    '
    Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
    Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
    Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
    Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ProfesionDataGridViewTextBoxColumn
    '
    Me.ProfesionDataGridViewTextBoxColumn.DataPropertyName = "Profesion"
    Me.ProfesionDataGridViewTextBoxColumn.HeaderText = "Profesion"
    Me.ProfesionDataGridViewTextBoxColumn.Name = "ProfesionDataGridViewTextBoxColumn"
    Me.ProfesionDataGridViewTextBoxColumn.ReadOnly = True
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
    'EmailDataGridViewTextBoxColumn
    '
    Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
    Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
    Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
    Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
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
    Me.Tel2DataGridViewTextBoxColumn.Visible = False
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
    'NumClienteDataGridViewTextBoxColumn
    '
    Me.NumClienteDataGridViewTextBoxColumn.DataPropertyName = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.HeaderText = "NumCliente"
    Me.NumClienteDataGridViewTextBoxColumn.Name = "NumClienteDataGridViewTextBoxColumn"
    Me.NumClienteDataGridViewTextBoxColumn.ReadOnly = True
    Me.NumClienteDataGridViewTextBoxColumn.Visible = False
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
    Me.ComentariosDataGridViewTextBoxColumn.Visible = False
    '
    'frmListaClientes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
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

  End Sub
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Public WithEvents dgvData1 As System.Windows.Forms.DataGridView
  Friend WithEvents bsInfoCliente As System.Windows.Forms.BindingSource
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents IDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProfesionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Tel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Calle2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCalle2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComentariosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
