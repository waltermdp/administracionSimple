﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstablecerPagos
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNumVenta = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.lblNumComprobante = New System.Windows.Forms.Label()
    Me.txtAdelantoVendedor = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtAdelanto = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.txtValorCuota = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtMedioPagoDescripcion = New System.Windows.Forms.TextBox()
    Me.btnSeleccionarCuenta = New System.Windows.Forms.Button()
    Me.btnAddCuenta = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DateVenta = New System.Windows.Forms.DateTimePicker()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmbCuotas = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkEditarCuotas = New System.Windows.Forms.CheckBox()
    Me.dgvCuotas = New System.Windows.Forms.DataGridView()
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
    Me.dtProximoPago = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.lvPlanPagos = New System.Windows.Forms.ListView()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.btnCancel.Location = New System.Drawing.Point(12, 624)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 10
    Me.btnCancel.Text = "Volver"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(30, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1194, 23)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Forma de Realizar Pagos"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtNumVenta
    '
    Me.txtNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNumVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumVenta.Location = New System.Drawing.Point(495, 90)
    Me.txtNumVenta.Name = "txtNumVenta"
    Me.txtNumVenta.Size = New System.Drawing.Size(273, 21)
    Me.txtNumVenta.TabIndex = 63
    Me.txtNumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(492, 72)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(90, 13)
    Me.Label16.TabIndex = 62
    Me.Label16.Text = "Numero de Venta"
    '
    'lblNumComprobante
    '
    Me.lblNumComprobante.AutoSize = True
    Me.lblNumComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumComprobante.Location = New System.Drawing.Point(876, 326)
    Me.lblNumComprobante.Name = "lblNumComprobante"
    Me.lblNumComprobante.Size = New System.Drawing.Size(42, 15)
    Me.lblNumComprobante.TabIndex = 61
    Me.lblNumComprobante.Text = "#####"
    '
    'txtAdelantoVendedor
    '
    Me.txtAdelantoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelantoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelantoVendedor.Location = New System.Drawing.Point(451, 360)
    Me.txtAdelantoVendedor.Name = "txtAdelantoVendedor"
    Me.txtAdelantoVendedor.Size = New System.Drawing.Size(99, 21)
    Me.txtAdelantoVendedor.TabIndex = 60
    Me.txtAdelantoVendedor.Text = "0"
    Me.txtAdelantoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(448, 338)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(132, 13)
    Me.Label15.TabIndex = 59
    Me.Label15.Text = "Adelanto para el vendedor"
    '
    'txtAdelanto
    '
    Me.txtAdelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelanto.Location = New System.Drawing.Point(279, 359)
    Me.txtAdelanto.Name = "txtAdelanto"
    Me.txtAdelanto.Size = New System.Drawing.Size(123, 21)
    Me.txtAdelanto.TabIndex = 58
    Me.txtAdelanto.Text = "0"
    Me.txtAdelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(280, 338)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(94, 13)
    Me.Label14.TabIndex = 57
    Me.Label14.Text = "Adelanto de cuota"
    '
    'lblValorCuota
    '
    Me.lblValorCuota.AutoSize = True
    Me.lblValorCuota.Location = New System.Drawing.Point(517, 235)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(88, 13)
    Me.lblValorCuota.TabIndex = 55
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'txtValorCuota
    '
    Me.txtValorCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtValorCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValorCuota.Location = New System.Drawing.Point(512, 250)
    Me.txtValorCuota.Name = "txtValorCuota"
    Me.txtValorCuota.Size = New System.Drawing.Size(122, 21)
    Me.txtValorCuota.TabIndex = 54
    Me.txtValorCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(510, 147)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(81, 13)
    Me.Label13.TabIndex = 53
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(513, 163)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(273, 21)
    Me.txtMedioPagoDescripcion.TabIndex = 52
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderSize = 2
    Me.btnSeleccionarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(391, 150)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnSeleccionarCuenta.TabIndex = 51
    Me.btnSeleccionarCuenta.Text = "Seleccionar"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = True
    '
    'btnAddCuenta
    '
    Me.btnAddCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAddCuenta.FlatAppearance.BorderSize = 2
    Me.btnAddCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAddCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAddCuenta.Location = New System.Drawing.Point(271, 150)
    Me.btnAddCuenta.Name = "btnAddCuenta"
    Me.btnAddCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnAddCuenta.TabIndex = 50
    Me.btnAddCuenta.Text = "Nuevo"
    Me.btnAddCuenta.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(261, 72)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 47
    Me.Label2.Text = "FechaVenta"
    '
    'txtPrecio
    '
    Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPrecio.Location = New System.Drawing.Point(279, 251)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 21)
    Me.txtPrecio.TabIndex = 41
    Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(280, 232)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(37, 13)
    Me.Label3.TabIndex = 42
    Me.Label3.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateVenta.Location = New System.Drawing.Point(262, 90)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(227, 21)
    Me.DateVenta.TabIndex = 43
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(266, 132)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(70, 13)
    Me.Label4.TabIndex = 44
    Me.Label4.Text = "Tipo de pago"
    '
    'cmbCuotas
    '
    Me.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Location = New System.Drawing.Point(385, 250)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 23)
    Me.cmbCuotas.TabIndex = 45
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(382, 232)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(95, 13)
    Me.Label5.TabIndex = 46
    Me.Label5.Text = "Numero de Cuotas"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(280, 291)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(105, 13)
    Me.Label6.TabIndex = 48
    Me.Label6.Text = "Fecha Proximo Pago"
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkEditarCuotas.Location = New System.Drawing.Point(640, 250)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(96, 19)
    Me.chkEditarCuotas.TabIndex = 49
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = True
    '
    'dgvCuotas
    '
    Me.dgvCuotas.AutoGenerateColumns = False
    Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.NumComprobanteDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.NumCuotaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
    Me.dgvCuotas.DataSource = Me.bsCuotas
    Me.dgvCuotas.Location = New System.Drawing.Point(171, 497)
    Me.dgvCuotas.MultiSelect = False
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.ReadOnly = True
    Me.dgvCuotas.RowHeadersVisible = False
    Me.dgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCuotas.Size = New System.Drawing.Size(1053, 120)
    Me.dgvCuotas.TabIndex = 64
    '
    'IdPagoDataGridViewTextBoxColumn
    '
    Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
    Me.IdPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumComprobanteDataGridViewTextBoxColumn
    '
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
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    Me.GuidPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    Me.NumCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    Me.EstadoPagoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'bsCuotas
    '
    Me.bsCuotas.DataSource = GetType(manDB.clsInfoPagos)
    '
    'dtProximoPago
    '
    Me.dtProximoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtProximoPago.Location = New System.Drawing.Point(391, 284)
    Me.dtProximoPago.Name = "dtProximoPago"
    Me.dtProximoPago.Size = New System.Drawing.Size(227, 21)
    Me.dtProximoPago.TabIndex = 65
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(665, 326)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(76, 13)
    Me.Label7.TabIndex = 68
    Me.Label7.Text = "Plan de Pagos"
    '
    'lvPlanPagos
    '
    Me.lvPlanPagos.Location = New System.Drawing.Point(668, 344)
    Me.lvPlanPagos.Name = "lvPlanPagos"
    Me.lvPlanPagos.Size = New System.Drawing.Size(418, 364)
    Me.lvPlanPagos.TabIndex = 67
    Me.lvPlanPagos.UseCompatibleStateImageBehavior = False
    Me.lvPlanPagos.View = System.Windows.Forms.View.Details
    '
    'frmEstablecerPagos
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.lvPlanPagos)
    Me.Controls.Add(Me.dtProximoPago)
    Me.Controls.Add(Me.dgvCuotas)
    Me.Controls.Add(Me.txtNumVenta)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.lblNumComprobante)
    Me.Controls.Add(Me.txtAdelantoVendedor)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.txtAdelanto)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.lblValorCuota)
    Me.Controls.Add(Me.txtValorCuota)
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.txtMedioPagoDescripcion)
    Me.Controls.Add(Me.btnSeleccionarCuenta)
    Me.Controls.Add(Me.btnAddCuenta)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtPrecio)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.DateVenta)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cmbCuotas)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.chkEditarCuotas)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEstablecerPagos"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmEstablecerPagos"
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNumVenta As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents lblNumComprobante As System.Windows.Forms.Label
  Friend WithEvents txtAdelantoVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents txtAdelanto As System.Windows.Forms.TextBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents txtValorCuota As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtMedioPagoDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents btnSeleccionarCuenta As System.Windows.Forms.Button
  Friend WithEvents btnAddCuenta As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents DateVenta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cmbCuotas As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents chkEditarCuotas As System.Windows.Forms.CheckBox
  Friend WithEvents dgvCuotas As System.Windows.Forms.DataGridView
  Friend WithEvents bsCuotas As System.Windows.Forms.BindingSource
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtProximoPago As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents lvPlanPagos As System.Windows.Forms.ListView
End Class
