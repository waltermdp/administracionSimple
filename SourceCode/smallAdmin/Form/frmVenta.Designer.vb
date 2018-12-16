<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DateVenta = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.cmbCuotas = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.datePrimerPago = New System.Windows.Forms.DateTimePicker()
    Me.dgvCuotas = New System.Windows.Forms.DataGridView()
    Me.bsCuotas = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmbVendedor = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkEditarCuotas = New System.Windows.Forms.CheckBox()
    Me.ListBox1 = New System.Windows.Forms.ListBox()
    Me.IdPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VencimientoCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtPrecio
    '
    Me.txtPrecio.Location = New System.Drawing.Point(227, 120)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
    Me.txtPrecio.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(224, 105)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Location = New System.Drawing.Point(95, 39)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(200, 20)
    Me.DateVenta.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(92, 105)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Tipo de pago"
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(84, 403)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(75, 23)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "guardar"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(186, 403)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "cancelar"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'cmbCuotas
    '
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Items.AddRange(New Object() {"Contado", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cmbCuotas.Location = New System.Drawing.Point(337, 121)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 21)
    Me.cmbCuotas.TabIndex = 9
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(334, 105)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(40, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Cuotas"
    '
    'cmbTipoPago
    '
    Me.cmbTipoPago.FormattingEnabled = True
    Me.cmbTipoPago.Location = New System.Drawing.Point(95, 120)
    Me.cmbTipoPago.Name = "cmbTipoPago"
    Me.cmbTipoPago.Size = New System.Drawing.Size(112, 21)
    Me.cmbTipoPago.TabIndex = 11
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(92, 23)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "FechaVenta"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(488, 105)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(91, 13)
    Me.Label5.TabIndex = 13
    Me.Label5.Text = "FechaPrimerPago"
    '
    'datePrimerPago
    '
    Me.datePrimerPago.Location = New System.Drawing.Point(491, 121)
    Me.datePrimerPago.Name = "datePrimerPago"
    Me.datePrimerPago.Size = New System.Drawing.Size(200, 20)
    Me.datePrimerPago.TabIndex = 14
    '
    'dgvCuotas
    '
    Me.dgvCuotas.AutoGenerateColumns = False
    Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.NumCuotaDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.VencimientoCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
    Me.dgvCuotas.DataSource = Me.bsCuotas
    Me.dgvCuotas.Location = New System.Drawing.Point(95, 150)
    Me.dgvCuotas.Name = "dgvCuotas"
    Me.dgvCuotas.Size = New System.Drawing.Size(310, 176)
    Me.dgvCuotas.TabIndex = 15
    '
    'bsCuotas
    '
    Me.bsCuotas.DataSource = GetType(manDB.clsInfoPagos)
    '
    'cmbVendedor
    '
    Me.cmbVendedor.FormattingEnabled = True
    Me.cmbVendedor.Location = New System.Drawing.Point(453, 305)
    Me.cmbVendedor.Name = "cmbVendedor"
    Me.cmbVendedor.Size = New System.Drawing.Size(178, 21)
    Me.cmbVendedor.TabIndex = 16
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(454, 285)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(53, 13)
    Me.Label6.TabIndex = 17
    Me.Label6.Text = "Vendedor"
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.Location = New System.Drawing.Point(426, 162)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(86, 17)
    Me.chkEditarCuotas.TabIndex = 18
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.Location = New System.Drawing.Point(710, 162)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(163, 199)
    Me.ListBox1.TabIndex = 19
    '
    'IdPagoDataGridViewTextBoxColumn
    '
    Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "IdPago"
    Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
    '
    'GuidProductoDataGridViewTextBoxColumn
    '
    Me.GuidProductoDataGridViewTextBoxColumn.DataPropertyName = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.HeaderText = "GuidProducto"
    Me.GuidProductoDataGridViewTextBoxColumn.Name = "GuidProductoDataGridViewTextBoxColumn"
    '
    'GuidPagoDataGridViewTextBoxColumn
    '
    Me.GuidPagoDataGridViewTextBoxColumn.DataPropertyName = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.HeaderText = "GuidPago"
    Me.GuidPagoDataGridViewTextBoxColumn.Name = "GuidPagoDataGridViewTextBoxColumn"
    '
    'NumCuotaDataGridViewTextBoxColumn
    '
    Me.NumCuotaDataGridViewTextBoxColumn.DataPropertyName = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.HeaderText = "NumCuota"
    Me.NumCuotaDataGridViewTextBoxColumn.Name = "NumCuotaDataGridViewTextBoxColumn"
    '
    'ValorCuotaDataGridViewTextBoxColumn
    '
    Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "ValorCuota"
    Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
    '
    'VencimientoCuotaDataGridViewTextBoxColumn
    '
    Me.VencimientoCuotaDataGridViewTextBoxColumn.DataPropertyName = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.HeaderText = "VencimientoCuota"
    Me.VencimientoCuotaDataGridViewTextBoxColumn.Name = "VencimientoCuotaDataGridViewTextBoxColumn"
    '
    'FechaPagoDataGridViewTextBoxColumn
    '
    Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
    Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
    '
    'EstadoPagoDataGridViewTextBoxColumn
    '
    Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "EstadoPago"
    Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
    '
    'frmVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(896, 481)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.chkEditarCuotas)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cmbVendedor)
    Me.Controls.Add(Me.dgvCuotas)
    Me.Controls.Add(Me.datePrimerPago)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cmbTipoPago)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cmbCuotas)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnSave)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.DateVenta)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtPrecio)
    Me.Name = "frmVenta"
    Me.Text = "frmVenta"
    CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsCuotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DateVenta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents cmbCuotas As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents datePrimerPago As System.Windows.Forms.DateTimePicker
  Friend WithEvents dgvCuotas As System.Windows.Forms.DataGridView
  Friend WithEvents bsCuotas As System.Windows.Forms.BindingSource
  Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents chkEditarCuotas As System.Windows.Forms.CheckBox
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents VencimientoCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
