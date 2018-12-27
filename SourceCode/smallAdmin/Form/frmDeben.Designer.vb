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
    Me.btnPagos = New System.Windows.Forms.Button()
    Me.dateInicio = New System.Windows.Forms.DateTimePicker()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.dgvData = New System.Windows.Forms.DataGridView()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasDebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsDeben = New System.Windows.Forms.BindingSource(Me.components)
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dateFin = New System.Windows.Forms.DateTimePicker()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.RadioButton1 = New System.Windows.Forms.RadioButton()
    Me.RadioButton2 = New System.Windows.Forms.RadioButton()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.btnLstVendedores = New System.Windows.Forms.Button()
    Me.btnListaClientes = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnEditarVenta = New System.Windows.Forms.Button()
    Me.btnArticulos = New System.Windows.Forms.Button()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsDeben, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnPagos
    '
    Me.btnPagos.Location = New System.Drawing.Point(552, 5)
    Me.btnPagos.Name = "btnPagos"
    Me.btnPagos.Size = New System.Drawing.Size(95, 22)
    Me.btnPagos.TabIndex = 1
    Me.btnPagos.Text = "InsertarPagos"
    Me.btnPagos.UseVisualStyleBackColor = True
    '
    'dateInicio
    '
    Me.dateInicio.Location = New System.Drawing.Point(124, 33)
    Me.dateInicio.Name = "dateInicio"
    Me.dateInicio.Size = New System.Drawing.Size(200, 20)
    Me.dateInicio.TabIndex = 2
    '
    'btnBack
    '
    Me.btnBack.Location = New System.Drawing.Point(12, 441)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(75, 23)
    Me.btnBack.TabIndex = 3
    Me.btnBack.Text = "Cerrar"
    Me.btnBack.UseVisualStyleBackColor = True
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
    Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidClienteDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CuotasDebeDataGridViewTextBoxColumn, Me.FechaVentaDataGridViewTextBoxColumn})
    Me.dgvData.DataSource = Me.bsDeben
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
    Me.dgvData.Location = New System.Drawing.Point(124, 175)
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
    Me.dgvData.Size = New System.Drawing.Size(865, 243)
    Me.dgvData.TabIndex = 25
    Me.dgvData.TabStop = False
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
    'FechaVentaDataGridViewTextBoxColumn
    '
    Me.FechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta"
    Me.FechaVentaDataGridViewTextBoxColumn.Name = "FechaVentaDataGridViewTextBoxColumn"
    Me.FechaVentaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsDeben
    '
    Me.bsDeben.DataSource = GetType(manDB.clsInfoProducto)
    '
    'ComboBox1
    '
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(97, 5)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
    Me.ComboBox1.TabIndex = 26
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(14, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 27
    Me.Label1.Text = "Estado"
    '
    'dateFin
    '
    Me.dateFin.Location = New System.Drawing.Point(371, 33)
    Me.dateFin.Name = "dateFin"
    Me.dateFin.Size = New System.Drawing.Size(200, 20)
    Me.dateFin.TabIndex = 28
    '
    'btnBuscar
    '
    Me.btnBuscar.Location = New System.Drawing.Point(619, 17)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(85, 43)
    Me.btnBuscar.TabIndex = 29
    Me.btnBuscar.Text = "Button1"
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'cmbTipoPago
    '
    Me.cmbTipoPago.FormattingEnabled = True
    Me.cmbTipoPago.Location = New System.Drawing.Point(301, 5)
    Me.cmbTipoPago.Name = "cmbTipoPago"
    Me.cmbTipoPago.Size = New System.Drawing.Size(121, 21)
    Me.cmbTipoPago.TabIndex = 30
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(242, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(53, 13)
    Me.Label2.TabIndex = 31
    Me.Label2.Text = "TipoPago"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(121, 17)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(32, 13)
    Me.Label3.TabIndex = 32
    Me.Label3.Text = "Inicio"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(368, 17)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(21, 13)
    Me.Label4.TabIndex = 33
    Me.Label4.Text = "Fin"
    '
    'RadioButton1
    '
    Me.RadioButton1.AutoSize = True
    Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
    Me.RadioButton1.TabIndex = 34
    Me.RadioButton1.TabStop = True
    Me.RadioButton1.Text = "Vendido"
    Me.RadioButton1.UseVisualStyleBackColor = True
    '
    'RadioButton2
    '
    Me.RadioButton2.AutoSize = True
    Me.RadioButton2.Location = New System.Drawing.Point(122, 18)
    Me.RadioButton2.Name = "RadioButton2"
    Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
    Me.RadioButton2.TabIndex = 35
    Me.RadioButton2.TabStop = True
    Me.RadioButton2.Text = "Cobros"
    Me.RadioButton2.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.RadioButton1)
    Me.GroupBox1.Controls.Add(Me.RadioButton2)
    Me.GroupBox1.Location = New System.Drawing.Point(124, 70)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(200, 44)
    Me.GroupBox1.TabIndex = 36
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Estado"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Button1)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.cmbTipoPago)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.ComboBox1)
    Me.Panel1.Controls.Add(Me.btnPagos)
    Me.Panel1.Location = New System.Drawing.Point(339, 79)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(650, 93)
    Me.Panel1.TabIndex = 37
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(552, 33)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(95, 23)
    Me.Button1.TabIndex = 32
    Me.Button1.Text = "ExportarPagos"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'btnLstVendedores
    '
    Me.btnLstVendedores.Location = New System.Drawing.Point(12, 395)
    Me.btnLstVendedores.Name = "btnLstVendedores"
    Me.btnLstVendedores.Size = New System.Drawing.Size(109, 23)
    Me.btnLstVendedores.TabIndex = 38
    Me.btnLstVendedores.Text = "ListaVendedores"
    Me.btnLstVendedores.UseVisualStyleBackColor = True
    '
    'btnListaClientes
    '
    Me.btnListaClientes.Location = New System.Drawing.Point(12, 366)
    Me.btnListaClientes.Name = "btnListaClientes"
    Me.btnListaClientes.Size = New System.Drawing.Size(109, 23)
    Me.btnListaClientes.TabIndex = 39
    Me.btnListaClientes.Text = "ListaClientes"
    Me.btnListaClientes.UseVisualStyleBackColor = True
    '
    'btnNuevo
    '
    Me.btnNuevo.Location = New System.Drawing.Point(12, 175)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(109, 34)
    Me.btnNuevo.TabIndex = 40
    Me.btnNuevo.Text = "Venta Nueva"
    Me.btnNuevo.UseVisualStyleBackColor = True
    '
    'btnEditarVenta
    '
    Me.btnEditarVenta.Location = New System.Drawing.Point(12, 215)
    Me.btnEditarVenta.Name = "btnEditarVenta"
    Me.btnEditarVenta.Size = New System.Drawing.Size(109, 30)
    Me.btnEditarVenta.TabIndex = 41
    Me.btnEditarVenta.Text = "Modificar Venta"
    Me.btnEditarVenta.UseVisualStyleBackColor = True
    '
    'btnArticulos
    '
    Me.btnArticulos.Location = New System.Drawing.Point(12, 337)
    Me.btnArticulos.Name = "btnArticulos"
    Me.btnArticulos.Size = New System.Drawing.Size(109, 23)
    Me.btnArticulos.TabIndex = 42
    Me.btnArticulos.Text = "Articulos"
    Me.btnArticulos.UseVisualStyleBackColor = True
    '
    'frmDeben
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1091, 476)
    Me.Controls.Add(Me.btnArticulos)
    Me.Controls.Add(Me.btnEditarVenta)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnListaClientes)
    Me.Controls.Add(Me.btnLstVendedores)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dateFin)
    Me.Controls.Add(Me.dgvData)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.dateInicio)
    Me.Name = "frmDeben"
    Me.Text = "frmDeben"
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsDeben, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnPagos As System.Windows.Forms.Button
  Friend WithEvents dateInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents bsDeben As System.Windows.Forms.BindingSource
  Public WithEvents dgvData As System.Windows.Forms.DataGridView
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotasDebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dateFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents btnLstVendedores As System.Windows.Forms.Button
  Friend WithEvents btnListaClientes As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEditarVenta As System.Windows.Forms.Button
  Friend WithEvents btnArticulos As System.Windows.Forms.Button
End Class
