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
    Me.bsDeben = New System.Windows.Forms.BindingSource(Me.components)
    Me.dgvData = New System.Windows.Forms.DataGridView()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasDebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dateFin = New System.Windows.Forms.DateTimePicker()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.ComboBox2 = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    CType(Me.bsDeben, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnPagos
    '
    Me.btnPagos.Location = New System.Drawing.Point(808, 434)
    Me.btnPagos.Name = "btnPagos"
    Me.btnPagos.Size = New System.Drawing.Size(95, 30)
    Me.btnPagos.TabIndex = 1
    Me.btnPagos.Text = "Button1"
    Me.btnPagos.UseVisualStyleBackColor = True
    '
    'dateInicio
    '
    Me.dateInicio.Location = New System.Drawing.Point(52, 27)
    Me.dateInicio.Name = "dateInicio"
    Me.dateInicio.Size = New System.Drawing.Size(200, 20)
    Me.dateInicio.TabIndex = 2
    '
    'btnBack
    '
    Me.btnBack.Location = New System.Drawing.Point(52, 451)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(75, 23)
    Me.btnBack.TabIndex = 3
    Me.btnBack.Text = "Volver"
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'bsDeben
    '
    Me.bsDeben.DataSource = GetType(manDB.clsInfoProducto)
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
    Me.dgvData.Location = New System.Drawing.Point(52, 188)
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
    'ComboBox1
    '
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(106, 67)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
    Me.ComboBox1.TabIndex = 26
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(49, 70)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 27
    Me.Label1.Text = "Estado"
    '
    'dateFin
    '
    Me.dateFin.Location = New System.Drawing.Point(299, 27)
    Me.dateFin.Name = "dateFin"
    Me.dateFin.Size = New System.Drawing.Size(200, 20)
    Me.dateFin.TabIndex = 28
    '
    'btnBuscar
    '
    Me.btnBuscar.Location = New System.Drawing.Point(547, 18)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(85, 43)
    Me.btnBuscar.TabIndex = 29
    Me.btnBuscar.Text = "Button1"
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'ComboBox2
    '
    Me.ComboBox2.FormattingEnabled = True
    Me.ComboBox2.Location = New System.Drawing.Point(299, 80)
    Me.ComboBox2.Name = "ComboBox2"
    Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
    Me.ComboBox2.TabIndex = 30
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(296, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(53, 13)
    Me.Label2.TabIndex = 31
    Me.Label2.Text = "TipoPago"
    '
    'frmDeben
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(953, 476)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.ComboBox2)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dateFin)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.dgvData)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.dateInicio)
    Me.Controls.Add(Me.btnPagos)
    Me.Name = "frmDeben"
    Me.Text = "frmDeben"
    CType(Me.bsDeben, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
