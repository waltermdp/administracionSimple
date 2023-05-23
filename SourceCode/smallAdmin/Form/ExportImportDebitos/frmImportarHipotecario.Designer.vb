<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarHipotecario
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
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtConvenio = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.txtFechaEjecucion = New System.Windows.Forms.TextBox()
    Me.lblRechazados = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.ImportarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NroAbonadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NroCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteADebitarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDebitadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteBHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MotivoRechazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoImportarHipotecarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoImportarHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImportarDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NroAbonadoDataGridViewTextBoxColumn, Me.NroCuentaDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.FechaDebitoDataGridViewTextBoxColumn, Me.ImporteADebitarDataGridViewTextBoxColumn, Me.ImporteDebitadoDataGridViewTextBoxColumn, Me.ImporteBHDataGridViewTextBoxColumn, Me.MotivoRechazoDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.GuidCuentaDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoImportarHipotecarioBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(169, 113)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.ReadOnly = True
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 495)
    Me.dgvResumen.TabIndex = 54
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.BackColor = System.Drawing.Color.Transparent
    Me.lblResumen.Location = New System.Drawing.Point(166, 88)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 53
    Me.lblResumen.Text = "Resumen"
    '
    'btnReload
    '
    Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReload.FlatAppearance.BorderSize = 0
    Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.ForeColor = System.Drawing.Color.White
    Me.btnReload.Location = New System.Drawing.Point(10, 105)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 60)
    Me.btnReload.TabIndex = 52
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
    Me.btnProcesar.Location = New System.Drawing.Point(10, 35)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 60)
    Me.btnProcesar.TabIndex = 51
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
    Me.btnCancel.Location = New System.Drawing.Point(10, 637)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 60)
    Me.btnCancel.TabIndex = 50
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(166, 54)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(52, 13)
    Me.Label1.TabIndex = 55
    Me.Label1.Text = "Convenio"
    '
    'txtConvenio
    '
    Me.txtConvenio.Location = New System.Drawing.Point(224, 51)
    Me.txtConvenio.Name = "txtConvenio"
    Me.txtConvenio.ReadOnly = True
    Me.txtConvenio.Size = New System.Drawing.Size(131, 20)
    Me.txtConvenio.TabIndex = 56
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(361, 54)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(115, 13)
    Me.Label2.TabIndex = 57
    Me.Label2.Text = "Importe Debitado Total"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(670, 54)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 13)
    Me.Label3.TabIndex = 58
    Me.Label3.Text = "Fecha Ejecucion"
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(482, 51)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(182, 20)
    Me.txtImporteTotal.TabIndex = 59
    '
    'txtFechaEjecucion
    '
    Me.txtFechaEjecucion.Location = New System.Drawing.Point(763, 51)
    Me.txtFechaEjecucion.Name = "txtFechaEjecucion"
    Me.txtFechaEjecucion.ReadOnly = True
    Me.txtFechaEjecucion.Size = New System.Drawing.Size(146, 20)
    Me.txtFechaEjecucion.TabIndex = 60
    '
    'lblRechazados
    '
    Me.lblRechazados.AutoSize = True
    Me.lblRechazados.BackColor = System.Drawing.Color.Transparent
    Me.lblRechazados.Location = New System.Drawing.Point(361, 88)
    Me.lblRechazados.Name = "lblRechazados"
    Me.lblRechazados.Size = New System.Drawing.Size(67, 13)
    Me.lblRechazados.TabIndex = 61
    Me.lblRechazados.Text = "Rechazados"
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(0, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(1280, 25)
    Me.Label5.TabIndex = 77
    Me.Label5.Text = "Hipotecario: Importar Debitos Directos"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'ImportarDataGridViewCheckBoxColumn
    '
    Me.ImportarDataGridViewCheckBoxColumn.DataPropertyName = "Importar"
    Me.ImportarDataGridViewCheckBoxColumn.HeaderText = "Importar"
    Me.ImportarDataGridViewCheckBoxColumn.Name = "ImportarDataGridViewCheckBoxColumn"
    Me.ImportarDataGridViewCheckBoxColumn.ReadOnly = True
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NroAbonadoDataGridViewTextBoxColumn
    '
    Me.NroAbonadoDataGridViewTextBoxColumn.DataPropertyName = "NroAbonado"
    Me.NroAbonadoDataGridViewTextBoxColumn.HeaderText = "NroAbonado"
    Me.NroAbonadoDataGridViewTextBoxColumn.Name = "NroAbonadoDataGridViewTextBoxColumn"
    Me.NroAbonadoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NroCuentaDataGridViewTextBoxColumn
    '
    Me.NroCuentaDataGridViewTextBoxColumn.DataPropertyName = "NroCuenta"
    Me.NroCuentaDataGridViewTextBoxColumn.HeaderText = "NroCuenta"
    Me.NroCuentaDataGridViewTextBoxColumn.Name = "NroCuentaDataGridViewTextBoxColumn"
    Me.NroCuentaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotaDataGridViewTextBoxColumn
    '
    Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.HeaderText = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
    Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
    Me.CuotaDataGridViewTextBoxColumn.Visible = False
    '
    'FechaDebitoDataGridViewTextBoxColumn
    '
    Me.FechaDebitoDataGridViewTextBoxColumn.DataPropertyName = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.HeaderText = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.Name = "FechaDebitoDataGridViewTextBoxColumn"
    Me.FechaDebitoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteADebitarDataGridViewTextBoxColumn
    '
    Me.ImporteADebitarDataGridViewTextBoxColumn.DataPropertyName = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.HeaderText = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.Name = "ImporteADebitarDataGridViewTextBoxColumn"
    Me.ImporteADebitarDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteDebitadoDataGridViewTextBoxColumn
    '
    Me.ImporteDebitadoDataGridViewTextBoxColumn.DataPropertyName = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.HeaderText = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.Name = "ImporteDebitadoDataGridViewTextBoxColumn"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteBHDataGridViewTextBoxColumn
    '
    Me.ImporteBHDataGridViewTextBoxColumn.DataPropertyName = "ImporteBH"
    Me.ImporteBHDataGridViewTextBoxColumn.HeaderText = "ImporteBH"
    Me.ImporteBHDataGridViewTextBoxColumn.Name = "ImporteBHDataGridViewTextBoxColumn"
    Me.ImporteBHDataGridViewTextBoxColumn.ReadOnly = True
    Me.ImporteBHDataGridViewTextBoxColumn.Visible = False
    '
    'MotivoRechazoDataGridViewTextBoxColumn
    '
    Me.MotivoRechazoDataGridViewTextBoxColumn.DataPropertyName = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.HeaderText = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.Name = "MotivoRechazoDataGridViewTextBoxColumn"
    Me.MotivoRechazoDataGridViewTextBoxColumn.ReadOnly = True
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
    'GuidCuentaDataGridViewTextBoxColumn
    '
    Me.GuidCuentaDataGridViewTextBoxColumn.DataPropertyName = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.HeaderText = "GuidCuenta"
    Me.GuidCuentaDataGridViewTextBoxColumn.Name = "GuidCuentaDataGridViewTextBoxColumn"
    Me.GuidCuentaDataGridViewTextBoxColumn.ReadOnly = True
    Me.GuidCuentaDataGridViewTextBoxColumn.Visible = False
    '
    'ClsInfoImportarHipotecarioBindingSource
    '
    Me.ClsInfoImportarHipotecarioBindingSource.DataSource = GetType(main.clsInfoImportarHipotecario)
    '
    'frmImportarHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.lblRechazados)
    Me.Controls.Add(Me.txtFechaEjecucion)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtConvenio)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmImportarHipotecario"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmImportarHipotecario"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoImportarHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents ClsInfoImportarHipotecarioBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtConvenio As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents txtFechaEjecucion As System.Windows.Forms.TextBox
  Friend WithEvents ImportarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroAbonadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteADebitarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDebitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteBHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MotivoRechazoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblRechazados As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
