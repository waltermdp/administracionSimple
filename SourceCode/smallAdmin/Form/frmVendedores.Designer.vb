<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btnBorrar = New System.Windows.Forms.Button()
    Me.bsVendedores = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.IdVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.dgvListVendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVendedorDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn})
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
    Me.dgvListVendedores.Location = New System.Drawing.Point(141, 52)
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
    Me.dgvListVendedores.RowTemplate.Height = 24
    Me.dgvListVendedores.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvListVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvListVendedores.Size = New System.Drawing.Size(808, 322)
    Me.dgvListVendedores.TabIndex = 25
    Me.dgvListVendedores.TabStop = False
    '
    'btnNuevo
    '
    Me.btnNuevo.Location = New System.Drawing.Point(23, 52)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
    Me.btnNuevo.TabIndex = 26
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = True
    '
    'btnEditar
    '
    Me.btnEditar.Location = New System.Drawing.Point(23, 81)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(75, 23)
    Me.btnEditar.TabIndex = 27
    Me.btnEditar.Text = "btnEditar"
    Me.btnEditar.UseVisualStyleBackColor = True
    '
    'btnBorrar
    '
    Me.btnBorrar.Location = New System.Drawing.Point(23, 110)
    Me.btnBorrar.Name = "btnBorrar"
    Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
    Me.btnBorrar.TabIndex = 28
    Me.btnBorrar.Text = "btnEliminar"
    Me.btnBorrar.UseVisualStyleBackColor = True
    '
    'bsVendedores
    '
    Me.bsVendedores.DataSource = GetType(manDB.clsInfoVendedor)
    '
    'btnVolver
    '
    Me.btnVolver.Location = New System.Drawing.Point(23, 430)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(75, 23)
    Me.btnVolver.TabIndex = 29
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = True
    '
    'IdVendedorDataGridViewTextBoxColumn
    '
    Me.IdVendedorDataGridViewTextBoxColumn.DataPropertyName = "IdVendedor"
    Me.IdVendedorDataGridViewTextBoxColumn.HeaderText = "IdVendedor"
    Me.IdVendedorDataGridViewTextBoxColumn.Name = "IdVendedorDataGridViewTextBoxColumn"
    Me.IdVendedorDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidVendedorDataGridViewTextBoxColumn
    '
    Me.GuidVendedorDataGridViewTextBoxColumn.DataPropertyName = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.HeaderText = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.Name = "GuidVendedorDataGridViewTextBoxColumn"
    Me.GuidVendedorDataGridViewTextBoxColumn.ReadOnly = True
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
    'frmVendedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1002, 475)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnBorrar)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.dgvListVendedores)
    Me.Name = "frmVendedores"
    Me.Text = "frmVendedores"
    CType(Me.dgvListVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Public WithEvents dgvListVendedores As System.Windows.Forms.DataGridView
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents btnBorrar As System.Windows.Forms.Button
  Friend WithEvents bsVendedores As System.Windows.Forms.BindingSource
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents IdVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
