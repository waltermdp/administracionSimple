<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalle
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
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.dgvCuotas = New System.Windows.Forms.DataGridView()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.dgvProductos = New System.Windows.Forms.DataGridView()
    Me.txtEntrada = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.NumComprobanteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidTipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotasDebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPrimerPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.AdelantoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaFijaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsProducto = New System.Windows.Forms.BindingSource(Me.components)
    Me.IdPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VencimientoCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsCuotas = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnCambiarEstado = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.btnEditNumComprobante = New System.Windows.Forms.Button()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsProducto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(25, 596)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 43
    Me.btnCancel.Text = "Volver"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'dgvCuotas
    '
    Me.dgvCuotas.AllowUserToAddRows = False
    Me.dgvCuotas.AllowUserToDeleteRows = False
    Me.dgvCuotas.AllowUserToResizeRows = False
    Me.dgvCuotas.AutoGenerateColumns = False
    Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.NumComprobanteDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.NumCuotaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
    Me.dgvCuotas.DataSource = Me.bsCuotas
    Me.dgvCuotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvCuotas.Location = New System.Drawing.Point(157, 342)
    Me.dgvCuotas.MultiSelect = False
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.ReadOnly = True
    Me.dgvCuotas.RowHeadersVisible = False
    Me.dgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCuotas.Size = New System.Drawing.Size(836, 315)
    Me.dgvCuotas.TabIndex = 44
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(154, 9)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(39, 13)
    Me.lblResumen.TabIndex = 45
    Me.lblResumen.Text = "Label1"
    '
    'dgvProductos
    '
    Me.dgvProductos.AllowUserToAddRows = False
    Me.dgvProductos.AllowUserToDeleteRows = False
    Me.dgvProductos.AllowUserToResizeRows = False
    Me.dgvProductos.AutoGenerateColumns = False
    Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumComprobanteDataGridViewTextBoxColumn1, Me.GuidProductoDataGridViewTextBoxColumn1, Me.GuidClienteDataGridViewTextBoxColumn, Me.GuidVendedorDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.GuidTipoPagoDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CuotasDebeDataGridViewTextBoxColumn, Me.FechaPrimerPagoDataGridViewTextBoxColumn, Me.FechaVentaDataGridViewTextBoxColumn, Me.GuidCuentaDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.AdelantoDataGridViewTextBoxColumn, Me.ValorCuotaFijaDataGridViewTextBoxColumn})
    Me.dgvProductos.DataSource = Me.bsProducto
    Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvProductos.Location = New System.Drawing.Point(434, 48)
    Me.dgvProductos.MultiSelect = False
    Me.dgvProductos.Name = "dgvProductos"
    Me.dgvProductos.ReadOnly = True
    Me.dgvProductos.RowHeadersVisible = False
    Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvProductos.Size = New System.Drawing.Size(818, 205)
    Me.dgvProductos.TabIndex = 46
    '
    'txtEntrada
    '
    Me.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtEntrada.Location = New System.Drawing.Point(157, 48)
    Me.txtEntrada.Multiline = True
    Me.txtEntrada.Name = "txtEntrada"
    Me.txtEntrada.ReadOnly = True
    Me.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtEntrada.Size = New System.Drawing.Size(260, 205)
    Me.txtEntrada.TabIndex = 47
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(154, 32)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 48
    Me.Label1.Text = "Entrada"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(157, 259)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(150, 54)
    Me.Button1.TabIndex = 49
    Me.Button1.Text = "Mostrar Cuentas"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'NumComprobanteDataGridViewTextBoxColumn1
    '
    Me.NumComprobanteDataGridViewTextBoxColumn1.DataPropertyName = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn1.HeaderText = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn1.Name = "NumComprobanteDataGridViewTextBoxColumn1"
    Me.NumComprobanteDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'GuidProductoDataGridViewTextBoxColumn1
    '
    Me.GuidProductoDataGridViewTextBoxColumn1.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn1.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn1.Name = "GuidProductoDataGridViewTextBoxColumn1"
    Me.GuidProductoDataGridViewTextBoxColumn1.ReadOnly = True
    Me.GuidProductoDataGridViewTextBoxColumn1.Visible = False
    '
    'GuidClienteDataGridViewTextBoxColumn
    '
    Me.GuidClienteDataGridViewTextBoxColumn.DataPropertyName = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.HeaderText = "GuidCliente"
    Me.GuidClienteDataGridViewTextBoxColumn.Name = "GuidClienteDataGridViewTextBoxColumn"
    Me.GuidClienteDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidClienteDataGridViewTextBoxColumn.Visible = False
    '
    'GuidVendedorDataGridViewTextBoxColumn
    '
    Me.GuidVendedorDataGridViewTextBoxColumn.DataPropertyName = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.HeaderText = "GuidVendedor"
    Me.GuidVendedorDataGridViewTextBoxColumn.Name = "GuidVendedorDataGridViewTextBoxColumn"
    Me.GuidVendedorDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidVendedorDataGridViewTextBoxColumn.Visible = False
    '
    'IdProductoDataGridViewTextBoxColumn
    '
    Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
    Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
    Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
    Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
    Me.IdProductoDataGridViewTextBoxColumn.Visible = False
    '
    'GuidTipoPagoDataGridViewTextBoxColumn
    '
    Me.GuidTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidTipoPago"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.HeaderText = "GuidTipoPago"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.Name = "GuidTipoPagoDataGridViewTextBoxColumn"
    Me.GuidTipoPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidTipoPagoDataGridViewTextBoxColumn.Visible = False
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
    'GuidCuentaDataGridViewTextBoxColumn
    '
    Me.GuidCuentaDataGridViewTextBoxColumn.DataPropertyName = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.HeaderText = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.Name = "GuidCuentaDataGridViewTextBoxColumn"
    Me.GuidCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'CuentaDataGridViewTextBoxColumn
    '
    Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
    Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta"
    Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
    Me.CuentaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'AdelantoDataGridViewTextBoxColumn
    '
    Me.AdelantoDataGridViewTextBoxColumn.DataPropertyName = "Adelanto"
    Me.AdelantoDataGridViewTextBoxColumn.HeaderText = "Adelanto"
    Me.AdelantoDataGridViewTextBoxColumn.Name = "AdelantoDataGridViewTextBoxColumn"
    Me.AdelantoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaFijaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuotaFija"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.HeaderText = "ValorCuotaFija"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.Name = "ValorCuotaFijaDataGridViewTextBoxColumn"
    Me.ValorCuotaFijaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsProducto
    '
    Me.bsProducto.DataSource = GetType(manDB.clsInfoProducto)
    '
    'IdPagoDataGridViewTextBoxColumn
    '
    Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
    Me.IdPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.IdPagoDataGridViewTextBoxColumn.Visible = False
    '
    'NumComprobanteDataGridViewTextBoxColumn
    '
    Me.NumComprobanteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NumComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.HeaderText = "NumComprobante"
    Me.NumComprobanteDataGridViewTextBoxColumn.Name = "NumComprobanteDataGridViewTextBoxColumn"
    Me.NumComprobanteDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    Me.GuidProductoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidProductoDataGridViewTextBoxColumn.Visible = False
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    Me.GuidPagoDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidPagoDataGridViewTextBoxColumn.Visible = False
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    Me.NumCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    Me.EstadoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsCuotas
    '
    Me.bsCuotas.DataSource = GetType(manDB.clsInfoPagos)
    '
    'btnCambiarEstado
    '
    Me.btnCambiarEstado.Location = New System.Drawing.Point(1122, 435)
    Me.btnCambiarEstado.Name = "btnCambiarEstado"
    Me.btnCambiarEstado.Size = New System.Drawing.Size(75, 23)
    Me.btnCambiarEstado.TabIndex = 50
    Me.btnCambiarEstado.Text = "CambiarEstado"
    Me.btnCambiarEstado.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(1020, 363)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(177, 32)
    Me.Button3.TabIndex = 51
    Me.Button3.Text = "Revertir el ultimo Pago"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'btnEditNumComprobante
    '
    Me.btnEditNumComprobante.Location = New System.Drawing.Point(434, 259)
    Me.btnEditNumComprobante.Name = "btnEditNumComprobante"
    Me.btnEditNumComprobante.Size = New System.Drawing.Size(129, 54)
    Me.btnEditNumComprobante.TabIndex = 52
    Me.btnEditNumComprobante.Text = "Cambiar Numero de Comprobante"
    Me.btnEditNumComprobante.UseVisualStyleBackColor = True
    '
    'frmDetalle
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1264, 681)
    Me.Controls.Add(Me.btnEditNumComprobante)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.btnCambiarEstado)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtEntrada)
    Me.Controls.Add(Me.dgvProductos)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.dgvCuotas)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmDetalle"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmDetalle"
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsProducto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents bsCuotas As System.Windows.Forms.BindingSource
  Friend WithEvents dgvCuotas As System.Windows.Forms.DataGridView
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
  Friend WithEvents bsProducto As System.Windows.Forms.BindingSource
  Friend WithEvents NumComprobanteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidTipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotasDebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPrimerPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents AdelantoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaFijaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtEntrada As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents btnEditNumComprobante As System.Windows.Forms.Button
End Class
