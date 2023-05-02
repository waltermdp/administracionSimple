<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarPatagonia
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
    Me.txtRazonSocial = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtProducto = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtVencimiento = New System.Windows.Forms.DateTimePicker()
    Me.dtCurrent = New System.Windows.Forms.DateTimePicker()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.txtReferencia = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtNroCUIT = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.ClsInfoPatagoniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuitDNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IDClienteEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ReferenciaDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TipoNovedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TipoMonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NroCuitEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoPatagoniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtRazonSocial
    '
    Me.txtRazonSocial.Location = New System.Drawing.Point(433, 34)
    Me.txtRazonSocial.Name = "txtRazonSocial"
    Me.txtRazonSocial.Size = New System.Drawing.Size(306, 20)
    Me.txtRazonSocial.TabIndex = 84
    '
    'Label7
    '
    Me.Label7.Location = New System.Drawing.Point(355, 33)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 20)
    Me.Label7.TabIndex = 83
    Me.Label7.Text = "Razon Social"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtProducto
    '
    Me.txtProducto.Location = New System.Drawing.Point(838, 33)
    Me.txtProducto.Name = "txtProducto"
    Me.txtProducto.Size = New System.Drawing.Size(133, 20)
    Me.txtProducto.TabIndex = 82
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(760, 33)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 20)
    Me.Label1.TabIndex = 81
    Me.Label1.Text = "Producto"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtVencimiento
    '
    Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtVencimiento.Location = New System.Drawing.Point(1124, 67)
    Me.dtVencimiento.Name = "dtVencimiento"
    Me.dtVencimiento.Size = New System.Drawing.Size(130, 20)
    Me.dtVencimiento.TabIndex = 80
    '
    'dtCurrent
    '
    Me.dtCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtCurrent.Location = New System.Drawing.Point(838, 66)
    Me.dtCurrent.Name = "dtCurrent"
    Me.dtCurrent.Size = New System.Drawing.Size(130, 20)
    Me.dtCurrent.TabIndex = 79
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(1018, 69)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 23)
    Me.Label5.TabIndex = 76
    Me.Label5.Text = "Fecha Vencimiento"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(753, 69)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 23)
    Me.Label4.TabIndex = 75
    Me.Label4.Text = "Fecha Actual"
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(169, 69)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 20)
    Me.Label3.TabIndex = 74
    Me.Label3.Text = "IMPORTE TOTAL"
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(275, 66)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(133, 20)
    Me.txtImporteTotal.TabIndex = 73
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.CuitDNIDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.IDClienteEmpresaDataGridViewTextBoxColumn, Me.CuotaActual, Me.FechaVtoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.ReferenciaDebitoDataGridViewTextBoxColumn, Me.TipoNovedadDataGridViewTextBoxColumn, Me.TipoMonedaDataGridViewTextBoxColumn, Me.NroCuitEmpresaDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoPatagoniaBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(172, 107)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.ReadOnly = True
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 495)
    Me.dgvResumen.TabIndex = 70
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(169, 618)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 69
    Me.lblResumen.Text = "Resumen"
    '
    'btnReload
    '
    Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReload.FlatAppearance.BorderSize = 0
    Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.ForeColor = System.Drawing.Color.White
    Me.btnReload.Location = New System.Drawing.Point(29, 142)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 61)
    Me.btnReload.TabIndex = 68
    Me.btnReload.Text = "Volver a Cargar"
    Me.btnReload.UseVisualStyleBackColor = False
    '
    'btnProcesar
    '
    Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnProcesar.FlatAppearance.BorderSize = 0
    Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcesar.ForeColor = System.Drawing.Color.White
    Me.btnProcesar.Location = New System.Drawing.Point(29, 48)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 61)
    Me.btnProcesar.TabIndex = 67
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = False
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(29, 618)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 66
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'txtReferencia
    '
    Me.txtReferencia.Location = New System.Drawing.Point(539, 66)
    Me.txtReferencia.Name = "txtReferencia"
    Me.txtReferencia.Size = New System.Drawing.Size(191, 20)
    Me.txtReferencia.TabIndex = 86
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(432, 66)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(101, 20)
    Me.Label8.TabIndex = 85
    Me.Label8.Text = "Referencia Debito"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtNroCUIT
    '
    Me.txtNroCUIT.Location = New System.Drawing.Point(247, 34)
    Me.txtNroCUIT.Name = "txtNroCUIT"
    Me.txtNroCUIT.Size = New System.Drawing.Size(100, 20)
    Me.txtNroCUIT.TabIndex = 88
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(169, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 16)
    Me.Label2.TabIndex = 87
    Me.Label2.Text = "Nro CUIT"
    '
    'ClsInfoPatagoniaBindingSource
    '
    Me.ClsInfoPatagoniaBindingSource.DataSource = GetType(main.clsInfoPatagonia)
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuitDNIDataGridViewTextBoxColumn
    '
    Me.CuitDNIDataGridViewTextBoxColumn.DataPropertyName = "Cuit_DNI"
    Me.CuitDNIDataGridViewTextBoxColumn.HeaderText = "Cuit_DNI"
    Me.CuitDNIDataGridViewTextBoxColumn.Name = "CuitDNIDataGridViewTextBoxColumn"
    Me.CuitDNIDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CBUDataGridViewTextBoxColumn
    '
    Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
    Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
    Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
    Me.CBUDataGridViewTextBoxColumn.ReadOnly = True
    '
    'IDClienteEmpresaDataGridViewTextBoxColumn
    '
    Me.IDClienteEmpresaDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente_Empresa"
    Me.IDClienteEmpresaDataGridViewTextBoxColumn.HeaderText = "ID_Cliente_Empresa"
    Me.IDClienteEmpresaDataGridViewTextBoxColumn.Name = "IDClienteEmpresaDataGridViewTextBoxColumn"
    Me.IDClienteEmpresaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotaActual
    '
    Me.CuotaActual.DataPropertyName = "CuotaActual"
    Me.CuotaActual.HeaderText = "CuotaActual"
    Me.CuotaActual.Name = "CuotaActual"
    Me.CuotaActual.ReadOnly = True
    '
    'FechaVtoDataGridViewTextBoxColumn
    '
    Me.FechaVtoDataGridViewTextBoxColumn.DataPropertyName = "FechaVto"
    Me.FechaVtoDataGridViewTextBoxColumn.HeaderText = "FechaVto"
    Me.FechaVtoDataGridViewTextBoxColumn.Name = "FechaVtoDataGridViewTextBoxColumn"
    Me.FechaVtoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteDataGridViewTextBoxColumn
    '
    Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
    Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ProductoDataGridViewTextBoxColumn
    '
    Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
    Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
    Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
    Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ReferenciaDebitoDataGridViewTextBoxColumn
    '
    Me.ReferenciaDebitoDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaDebito"
    Me.ReferenciaDebitoDataGridViewTextBoxColumn.HeaderText = "ReferenciaDebito"
    Me.ReferenciaDebitoDataGridViewTextBoxColumn.Name = "ReferenciaDebitoDataGridViewTextBoxColumn"
    Me.ReferenciaDebitoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'TipoNovedadDataGridViewTextBoxColumn
    '
    Me.TipoNovedadDataGridViewTextBoxColumn.DataPropertyName = "TipoNovedad"
    Me.TipoNovedadDataGridViewTextBoxColumn.HeaderText = "TipoNovedad"
    Me.TipoNovedadDataGridViewTextBoxColumn.Name = "TipoNovedadDataGridViewTextBoxColumn"
    Me.TipoNovedadDataGridViewTextBoxColumn.ReadOnly = True
    Me.TipoNovedadDataGridViewTextBoxColumn.Visible = False
    '
    'TipoMonedaDataGridViewTextBoxColumn
    '
    Me.TipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda"
    Me.TipoMonedaDataGridViewTextBoxColumn.HeaderText = "TipoMoneda"
    Me.TipoMonedaDataGridViewTextBoxColumn.Name = "TipoMonedaDataGridViewTextBoxColumn"
    Me.TipoMonedaDataGridViewTextBoxColumn.ReadOnly = True
    Me.TipoMonedaDataGridViewTextBoxColumn.Visible = False
    '
    'NroCuitEmpresaDataGridViewTextBoxColumn
    '
    Me.NroCuitEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NroCuitEmpresa"
    Me.NroCuitEmpresaDataGridViewTextBoxColumn.HeaderText = "NroCuitEmpresa"
    Me.NroCuitEmpresaDataGridViewTextBoxColumn.Name = "NroCuitEmpresaDataGridViewTextBoxColumn"
    Me.NroCuitEmpresaDataGridViewTextBoxColumn.ReadOnly = True
    Me.NroCuitEmpresaDataGridViewTextBoxColumn.Visible = False
    '
    'frmExportarPatagonia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.txtNroCUIT)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtReferencia)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtRazonSocial)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtProducto)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtVencimiento)
    Me.Controls.Add(Me.dtCurrent)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarPatagonia"
    Me.Text = "frmExportarPatagonia"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoPatagoniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtProducto As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtCurrent As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents ClsInfoPatagoniaBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtNroCUIT As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuitDNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IDClienteEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaActual As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ReferenciaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TipoNovedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TipoMonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroCuitEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
