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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnEdit = New System.Windows.Forms.Button()
    Me.dgvData1 = New System.Windows.Forms.DataGridView()
    Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsInfoCliente = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsInfoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnEdit
    '
    Me.btnEdit.Location = New System.Drawing.Point(12, 82)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(98, 46)
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
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvData1.ColumnHeadersHeight = 24
    Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.GuidClienteDataGridViewTextBoxColumn})
    Me.dgvData1.DataSource = Me.bsInfoCliente
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvData1.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgvData1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvData1.EnableHeadersVisualStyles = False
    Me.dgvData1.GridColor = System.Drawing.Color.White
    Me.dgvData1.Location = New System.Drawing.Point(113, 35)
    Me.dgvData1.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvData1.MultiSelect = False
    Me.dgvData1.Name = "dgvData1"
    Me.dgvData1.ReadOnly = True
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgvData1.RowHeadersVisible = False
    Me.dgvData1.RowTemplate.Height = 24
    Me.dgvData1.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvData1.Size = New System.Drawing.Size(865, 243)
    Me.dgvData1.TabIndex = 24
    Me.dgvData1.TabStop = False
    '
    'IDClienteDataGridViewTextBoxColumn
    '
    Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente"
    Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
    Me.IDClienteDataGridViewTextBoxColumn.ReadOnly = True
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
    'GuidClienteDataGridViewTextBoxColumn
    '
    Me.GuidClienteDataGridViewTextBoxColumn.DataPropertyName = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.HeaderText = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.Name = "GuidClienteDataGridViewTextBoxColumn"
    Me.GuidClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsInfoCliente
    '
    Me.bsInfoCliente.DataSource = GetType(manDB.clsInfoDatabase)
    '
    'btnNuevo
    '
    Me.btnNuevo.Location = New System.Drawing.Point(12, 35)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(98, 41)
    Me.btnNuevo.TabIndex = 25
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = True
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(12, 134)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(98, 40)
    Me.btnEliminar.TabIndex = 26
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'btnRefresh
    '
    Me.btnRefresh.Location = New System.Drawing.Point(903, 406)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
    Me.btnRefresh.TabIndex = 27
    Me.btnRefresh.Text = "refresh"
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'btnVolver
    '
    Me.btnVolver.Location = New System.Drawing.Point(12, 339)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(75, 23)
    Me.btnVolver.TabIndex = 28
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = True
    '
    'frmListaClientes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1102, 551)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnRefresh)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.dgvData1)
    Me.Controls.Add(Me.btnEdit)
    Me.Name = "frmListaClientes"
    Me.Text = "Form1"
    CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsInfoCliente, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Public WithEvents dgvData1 As System.Windows.Forms.DataGridView
  Friend WithEvents bsInfoCliente As System.Windows.Forms.BindingSource
  Friend WithEvents IDClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnRefresh As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
