<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarHipotecario
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
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNumeroConvenio = New System.Windows.Forms.TextBox()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtFechaActual = New System.Windows.Forms.TextBox()
    Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtSecuencial = New System.Windows.Forms.TextBox()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdentificadorDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumeroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoHipotecarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.dtCurrent = New System.Windows.Forms.DateTimePicker()
    Me.dtVencimiento = New System.Windows.Forms.DateTimePicker()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(34, 615)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 43
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'btnProcesar
    '
    Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnProcesar.FlatAppearance.BorderSize = 0
    Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcesar.ForeColor = System.Drawing.Color.White
    Me.btnProcesar.Location = New System.Drawing.Point(34, 45)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 61)
    Me.btnProcesar.TabIndex = 44
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = False
    '
    'btnReload
    '
    Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReload.FlatAppearance.BorderSize = 0
    Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.ForeColor = System.Drawing.Color.White
    Me.btnReload.Location = New System.Drawing.Point(34, 139)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 61)
    Me.btnReload.TabIndex = 46
    Me.btnReload.Text = "Volver a Cargar"
    Me.btnReload.UseVisualStyleBackColor = False
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(174, 615)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 47
    Me.lblResumen.Text = "Resumen"
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.IdentificadorDebitoDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.NumeroComprobanteDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CodigoBancoDataGridViewTextBoxColumn, Me.CuotaActualDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoHipotecarioBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(177, 104)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 495)
    Me.dgvResumen.TabIndex = 49
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(174, 45)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 16)
    Me.Label2.TabIndex = 50
    Me.Label2.Text = "CONVENIO"
    '
    'txtNumeroConvenio
    '
    Me.txtNumeroConvenio.Location = New System.Drawing.Point(252, 41)
    Me.txtNumeroConvenio.Name = "txtNumeroConvenio"
    Me.txtNumeroConvenio.ReadOnly = True
    Me.txtNumeroConvenio.Size = New System.Drawing.Size(100, 20)
    Me.txtNumeroConvenio.TabIndex = 51
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(484, 41)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(133, 20)
    Me.txtImporteTotal.TabIndex = 52
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(378, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 20)
    Me.Label3.TabIndex = 53
    Me.Label3.Text = "IMPORTE TOTAL"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(634, 41)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 23)
    Me.Label4.TabIndex = 54
    Me.Label4.Text = "Fecha Actual"
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(899, 41)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 23)
    Me.Label5.TabIndex = 55
    Me.Label5.Text = "Fecha Vencimiento"
    '
    'txtFechaActual
    '
    Me.txtFechaActual.Location = New System.Drawing.Point(719, 38)
    Me.txtFechaActual.Name = "txtFechaActual"
    Me.txtFechaActual.ReadOnly = True
    Me.txtFechaActual.Size = New System.Drawing.Size(133, 20)
    Me.txtFechaActual.TabIndex = 56
    '
    'txtFechaVencimiento
    '
    Me.txtFechaVencimiento.Location = New System.Drawing.Point(1005, 38)
    Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
    Me.txtFechaVencimiento.ReadOnly = True
    Me.txtFechaVencimiento.Size = New System.Drawing.Size(133, 20)
    Me.txtFechaVencimiento.TabIndex = 57
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(174, 65)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 23)
    Me.Label6.TabIndex = 58
    Me.Label6.Text = "Secuencial"
    '
    'txtSecuencial
    '
    Me.txtSecuencial.Location = New System.Drawing.Point(252, 68)
    Me.txtSecuencial.Name = "txtSecuencial"
    Me.txtSecuencial.Size = New System.Drawing.Size(100, 20)
    Me.txtSecuencial.TabIndex = 59
    Me.txtSecuencial.Text = "000"
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    '
    'IdentificadorDebitoDataGridViewTextBoxColumn
    '
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorDebito"
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.HeaderText = "IdentificadorDebito"
    Me.IdentificadorDebitoDataGridViewTextBoxColumn.Name = "IdentificadorDebitoDataGridViewTextBoxColumn"
    '
    'CBUDataGridViewTextBoxColumn
    '
    Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
    Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
    Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
    '
    'NumeroComprobanteDataGridViewTextBoxColumn
    '
    Me.NumeroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumeroComprobante"
    Me.NumeroComprobanteDataGridViewTextBoxColumn.HeaderText = "NumeroComprobante"
    Me.NumeroComprobanteDataGridViewTextBoxColumn.Name = "NumeroComprobanteDataGridViewTextBoxColumn"
    '
    'FechaVencimientoDataGridViewTextBoxColumn
    '
    Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
    Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
    Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
    '
    'ImporteDataGridViewTextBoxColumn
    '
    Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
    Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
    '
    'CodigoBancoDataGridViewTextBoxColumn
    '
    Me.CodigoBancoDataGridViewTextBoxColumn.DataPropertyName = "CodigoBanco"
    Me.CodigoBancoDataGridViewTextBoxColumn.HeaderText = "CodigoBanco"
    Me.CodigoBancoDataGridViewTextBoxColumn.Name = "CodigoBancoDataGridViewTextBoxColumn"
    '
    'CuotaActualDataGridViewTextBoxColumn
    '
    Me.CuotaActualDataGridViewTextBoxColumn.DataPropertyName = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.HeaderText = "CuotaActual"
    Me.CuotaActualDataGridViewTextBoxColumn.Name = "CuotaActualDataGridViewTextBoxColumn"
    '
    'ClsInfoHipotecarioBindingSource
    '
    Me.ClsInfoHipotecarioBindingSource.DataSource = GetType(main.clsInfoHipotecario)
    '
    'dtCurrent
    '
    Me.dtCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtCurrent.Location = New System.Drawing.Point(722, 76)
    Me.dtCurrent.Name = "dtCurrent"
    Me.dtCurrent.Size = New System.Drawing.Size(130, 20)
    Me.dtCurrent.TabIndex = 60
    '
    'dtVencimiento
    '
    Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtVencimiento.Location = New System.Drawing.Point(1005, 76)
    Me.dtVencimiento.Name = "dtVencimiento"
    Me.dtVencimiento.Size = New System.Drawing.Size(130, 20)
    Me.dtVencimiento.TabIndex = 61
    '
    'frmExportarHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.dtVencimiento)
    Me.Controls.Add(Me.dtCurrent)
    Me.Controls.Add(Me.txtSecuencial)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtFechaVencimiento)
    Me.Controls.Add(Me.txtFechaActual)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.txtNumeroConvenio)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarHipotecario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmExportarResumen"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents ClsInfoHipotecarioBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IdentificadorDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NumeroComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoBancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaActualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtNumeroConvenio As System.Windows.Forms.TextBox
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtFechaActual As System.Windows.Forms.TextBox
  Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtSecuencial As System.Windows.Forms.TextBox
  Friend WithEvents dtCurrent As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
End Class
