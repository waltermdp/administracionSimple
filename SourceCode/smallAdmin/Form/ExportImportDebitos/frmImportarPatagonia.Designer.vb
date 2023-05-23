<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarPatagonia
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
    Me.lblRechazados = New System.Windows.Forms.Label()
    Me.txtFechaEjecucion = New System.Windows.Forms.TextBox()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtCUITEmpresa = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.txtTotalRegistrosDebitar = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.ImportarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DNIIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDebitadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MotivoRechazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteADebitarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClsInfoImportarPatagoniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoImportarPatagoniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblRechazados
    '
    Me.lblRechazados.AutoSize = True
    Me.lblRechazados.BackColor = System.Drawing.Color.Transparent
    Me.lblRechazados.Location = New System.Drawing.Point(654, 80)
    Me.lblRechazados.Name = "lblRechazados"
    Me.lblRechazados.Size = New System.Drawing.Size(67, 13)
    Me.lblRechazados.TabIndex = 73
    Me.lblRechazados.Text = "Rechazados"
    '
    'txtFechaEjecucion
    '
    Me.txtFechaEjecucion.Location = New System.Drawing.Point(766, 43)
    Me.txtFechaEjecucion.Name = "txtFechaEjecucion"
    Me.txtFechaEjecucion.ReadOnly = True
    Me.txtFechaEjecucion.Size = New System.Drawing.Size(146, 20)
    Me.txtFechaEjecucion.TabIndex = 72
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(485, 43)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(182, 20)
    Me.txtImporteTotal.TabIndex = 71
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(673, 46)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 13)
    Me.Label3.TabIndex = 70
    Me.Label3.Text = "Fecha Ejecucion"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(364, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(115, 13)
    Me.Label2.TabIndex = 69
    Me.Label2.Text = "Importe Debitado Total"
    '
    'txtCUITEmpresa
    '
    Me.txtCUITEmpresa.Location = New System.Drawing.Point(227, 43)
    Me.txtCUITEmpresa.Name = "txtCUITEmpresa"
    Me.txtCUITEmpresa.ReadOnly = True
    Me.txtCUITEmpresa.Size = New System.Drawing.Size(131, 20)
    Me.txtCUITEmpresa.TabIndex = 68
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(169, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(32, 13)
    Me.Label1.TabIndex = 67
    Me.Label1.Text = "CUIT"
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImportarDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DNIIDDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.ContratoDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.ImporteDebitadoDataGridViewTextBoxColumn, Me.FechaDebitoDataGridViewTextBoxColumn, Me.MotivoRechazoDataGridViewTextBoxColumn, Me.ImporteADebitarDataGridViewTextBoxColumn, Me.GuidProductoDataGridViewTextBoxColumn, Me.GuidPagoDataGridViewTextBoxColumn, Me.GuidCuentaDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoImportarPatagoniaBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(172, 105)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.ReadOnly = True
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 495)
    Me.dgvResumen.TabIndex = 66
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.BackColor = System.Drawing.Color.Transparent
    Me.lblResumen.Location = New System.Drawing.Point(427, 80)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 65
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
    Me.btnReload.TabIndex = 64
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
    Me.btnProcesar.TabIndex = 63
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
    Me.btnCancel.TabIndex = 62
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'txtTotalRegistrosDebitar
    '
    Me.txtTotalRegistrosDebitar.Location = New System.Drawing.Point(271, 77)
    Me.txtTotalRegistrosDebitar.Name = "txtTotalRegistrosDebitar"
    Me.txtTotalRegistrosDebitar.ReadOnly = True
    Me.txtTotalRegistrosDebitar.Size = New System.Drawing.Size(131, 20)
    Me.txtTotalRegistrosDebitar.TabIndex = 75
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(170, 80)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(95, 13)
    Me.Label4.TabIndex = 74
    Me.Label4.Text = "Registros a debitar"
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(0, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(1280, 25)
    Me.Label5.TabIndex = 76
    Me.Label5.Text = "Patagonia: Importar Debitos Directos"
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
    'DNIIDDataGridViewTextBoxColumn
    '
    Me.DNIIDDataGridViewTextBoxColumn.DataPropertyName = "DNI_ID"
    Me.DNIIDDataGridViewTextBoxColumn.HeaderText = "DNI_ID"
    Me.DNIIDDataGridViewTextBoxColumn.Name = "DNIIDDataGridViewTextBoxColumn"
    Me.DNIIDDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CBUDataGridViewTextBoxColumn
    '
    Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
    Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
    Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
    Me.CBUDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ContratoDataGridViewTextBoxColumn
    '
    Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
    Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Contrato"
    Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
    Me.ContratoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CuotaDataGridViewTextBoxColumn
    '
    Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.HeaderText = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
    Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteDebitadoDataGridViewTextBoxColumn
    '
    Me.ImporteDebitadoDataGridViewTextBoxColumn.DataPropertyName = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.HeaderText = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.Name = "ImporteDebitadoDataGridViewTextBoxColumn"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FechaDebitoDataGridViewTextBoxColumn
    '
    Me.FechaDebitoDataGridViewTextBoxColumn.DataPropertyName = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.HeaderText = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.Name = "FechaDebitoDataGridViewTextBoxColumn"
    Me.FechaDebitoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'MotivoRechazoDataGridViewTextBoxColumn
    '
    Me.MotivoRechazoDataGridViewTextBoxColumn.DataPropertyName = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.HeaderText = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.Name = "MotivoRechazoDataGridViewTextBoxColumn"
    Me.MotivoRechazoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'ImporteADebitarDataGridViewTextBoxColumn
    '
    Me.ImporteADebitarDataGridViewTextBoxColumn.DataPropertyName = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.HeaderText = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.Name = "ImporteADebitarDataGridViewTextBoxColumn"
    Me.ImporteADebitarDataGridViewTextBoxColumn.ReadOnly = True
    Me.ImporteADebitarDataGridViewTextBoxColumn.Visible = False
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
    'ClsInfoImportarPatagoniaBindingSource
    '
    Me.ClsInfoImportarPatagoniaBindingSource.DataSource = GetType(main.clsInfoImportarPatagonia)
    '
    'frmImportarPatagonia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtTotalRegistrosDebitar)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblRechazados)
    Me.Controls.Add(Me.txtFechaEjecucion)
    Me.Controls.Add(Me.txtImporteTotal)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtCUITEmpresa)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dgvResumen)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmImportarPatagonia"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmImportarPatagonia"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoImportarPatagoniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblRechazados As System.Windows.Forms.Label
  Friend WithEvents txtFechaEjecucion As System.Windows.Forms.TextBox
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtCUITEmpresa As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents NroAbonadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ClsInfoImportarPatagoniaBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents txtTotalRegistrosDebitar As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents ImportarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DNIIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDebitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MotivoRechazoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteADebitarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
