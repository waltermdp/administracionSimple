<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.txtApellido = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnAgregarProducto = New System.Windows.Forms.Button()
    Me.dgvProductos = New System.Windows.Forms.DataGridView()
    Me.bsinfoProductos = New System.Windows.Forms.BindingSource(Me.components)
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidTipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasDebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPrimerPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsinfoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnGuardar
    '
    Me.btnGuardar.Location = New System.Drawing.Point(33, 54)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
    Me.btnGuardar.TabIndex = 0
    Me.btnGuardar.Text = "guardar"
    Me.btnGuardar.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(33, 83)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(169, 57)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(100, 20)
    Me.txtNombre.TabIndex = 2
    '
    'txtApellido
    '
    Me.txtApellido.Location = New System.Drawing.Point(169, 97)
    Me.txtApellido.Name = "txtApellido"
    Me.txtApellido.Size = New System.Drawing.Size(100, 20)
    Me.txtApellido.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(166, 41)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Nombre"
    '
    'btnAgregarProducto
    '
    Me.btnAgregarProducto.Location = New System.Drawing.Point(33, 152)
    Me.btnAgregarProducto.Name = "btnAgregarProducto"
    Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 23)
    Me.btnAgregarProducto.TabIndex = 5
    Me.btnAgregarProducto.Text = "NuevoVenta"
    Me.btnAgregarProducto.UseVisualStyleBackColor = True
    '
    'dgvProductos
    '
    Me.dgvProductos.AllowUserToAddRows = False
    Me.dgvProductos.AllowUserToDeleteRows = False
    Me.dgvProductos.AllowUserToResizeRows = False
    Me.dgvProductos.AutoGenerateColumns = False
    Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvProductos.ColumnHeadersHeight = 24
    Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidClienteDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.GuidTipoPagoDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CuotasDebeDataGridViewTextBoxColumn, Me.FechaPrimerPagoDataGridViewTextBoxColumn, Me.FechaVentaDataGridViewTextBoxColumn})
    Me.dgvProductos.DataSource = Me.bsinfoProductos
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvProductos.EnableHeadersVisualStyles = False
    Me.dgvProductos.GridColor = System.Drawing.Color.White
    Me.dgvProductos.Location = New System.Drawing.Point(137, 130)
    Me.dgvProductos.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvProductos.MultiSelect = False
    Me.dgvProductos.Name = "dgvProductos"
    Me.dgvProductos.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvProductos.RowHeadersVisible = False
    Me.dgvProductos.RowTemplate.Height = 24
    Me.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvProductos.Size = New System.Drawing.Size(785, 205)
    Me.dgvProductos.TabIndex = 25
    Me.dgvProductos.TabStop = False
    '
    'bsinfoProductos
    '
    Me.bsinfoProductos.DataSource = GetType(manDB.clsInfoProducto)
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    Me.GuidProductoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidClienteDataGridViewTextBoxColumn
    '
    Me.GuidClienteDataGridViewTextBoxColumn.DataPropertyName = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.HeaderText = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.Name = "GuidClienteDataGridViewTextBoxColumn"
    Me.GuidClienteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidVendedorDataGridViewTextBoxColumn
    '
    Me.GuidVendedorDataGridViewTextBoxColumn.DataPropertyName = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.HeaderText = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.Name = "GuidVendedorDataGridViewTextBoxColumn"
    Me.GuidVendedorDataGridViewTextBoxColumn.ReadOnly = True
    '
    'IdProductoDataGridViewTextBoxColumn
    '
    Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
    Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
    Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
    Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidTipoPagoDataGridViewTextBoxColumn
    '
    Me.GuidTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidTipoPago"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.HeaderText = "GuidTipoPago"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.Name = "GuidTipoPagoDataGridViewTextBoxColumn"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'TotalCuotasDataGridViewTextBoxColumn
    '
    Me.TotalCuotasDataGridViewTextBoxColumn.DataPropertyName = "TotalCuotas"
    Me.TotalCuotasDataGridViewTextBoxColumn.HeaderText = "TotalCuotas"
    Me.TotalCuotasDataGridViewTextBoxColumn.Name = "TotalCuotasDataGridViewTextBoxColumn"
    Me.TotalCuotasDataGridViewTextBoxColumn.ReadOnly = True
    '
    'PrecioDataGridViewTextBoxColumn
    '
    Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
    Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
    Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotasDebeDataGridViewTextBoxColumn
    '
    Me.CuotasDebeDataGridViewTextBoxColumn.DataPropertyName = "CuotasDebe"
    Me.CuotasDebeDataGridViewTextBoxColumn.HeaderText = "CuotasDebe"
    Me.CuotasDebeDataGridViewTextBoxColumn.Name = "CuotasDebeDataGridViewTextBoxColumn"
    Me.CuotasDebeDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaPrimerPagoDataGridViewTextBoxColumn
    '
    Me.FechaPrimerPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrimerPago"
    Me.FechaPrimerPagoDataGridViewTextBoxColumn.HeaderText = "FechaPrimerPago"
    Me.FechaPrimerPagoDataGridViewTextBoxColumn.Name = "FechaPrimerPagoDataGridViewTextBoxColumn"
    Me.FechaPrimerPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaVentaDataGridViewTextBoxColumn
    '
    Me.FechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.Name = "FechaVentaDataGridViewTextBoxColumn"
    Me.FechaVentaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'frmCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(980, 470)
    Me.Controls.Add(Me.dgvProductos)
    Me.Controls.Add(Me.btnAgregarProducto)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtApellido)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnGuardar)
    Me.Name = "frmCliente"
    Me.Text = "frmCliente"
    CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsinfoProductos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtApellido As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
  Public WithEvents dgvProductos As System.Windows.Forms.DataGridView
  Friend WithEvents bsinfoProductos As System.Windows.Forms.BindingSource
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidTipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotasDebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPrimerPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
