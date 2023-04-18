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
    Me.ClsInfoImportarHipotecarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.ImportarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.NroAbonadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NroCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteADebitarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDebitadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteBHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MotivoRechazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ClsInfoImportarHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoGenerateColumns = False
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImportarDataGridViewCheckBoxColumn, Me.NroAbonadoDataGridViewTextBoxColumn, Me.NroCuentaDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.FechaDebitoDataGridViewTextBoxColumn, Me.ImporteADebitarDataGridViewTextBoxColumn, Me.ImporteDebitadoDataGridViewTextBoxColumn, Me.ImporteBHDataGridViewTextBoxColumn, Me.MotivoRechazoDataGridViewTextBoxColumn})
    Me.dgvResumen.DataSource = Me.ClsInfoImportarHipotecarioBindingSource
    Me.dgvResumen.Location = New System.Drawing.Point(169, 80)
    Me.dgvResumen.Name = "dgvResumen"
    Me.dgvResumen.RowHeadersVisible = False
    Me.dgvResumen.Size = New System.Drawing.Size(1080, 495)
    Me.dgvResumen.TabIndex = 54
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(166, 591)
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
    Me.btnReload.Location = New System.Drawing.Point(26, 115)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 61)
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
    Me.btnProcesar.Location = New System.Drawing.Point(26, 21)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 61)
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
    Me.btnCancel.Location = New System.Drawing.Point(26, 591)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 50
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'ClsInfoImportarHipotecarioBindingSource
    '
    Me.ClsInfoImportarHipotecarioBindingSource.DataSource = GetType(main.clsInfoImportarHipotecario)
    '
    'ImportarDataGridViewCheckBoxColumn
    '
    Me.ImportarDataGridViewCheckBoxColumn.DataPropertyName = "Importar"
    Me.ImportarDataGridViewCheckBoxColumn.HeaderText = "Importar"
    Me.ImportarDataGridViewCheckBoxColumn.Name = "ImportarDataGridViewCheckBoxColumn"
    '
    'NroAbonadoDataGridViewTextBoxColumn
    '
    Me.NroAbonadoDataGridViewTextBoxColumn.DataPropertyName = "NroAbonado"
    Me.NroAbonadoDataGridViewTextBoxColumn.HeaderText = "NroAbonado"
    Me.NroAbonadoDataGridViewTextBoxColumn.Name = "NroAbonadoDataGridViewTextBoxColumn"
    '
    'NroCuentaDataGridViewTextBoxColumn
    '
    Me.NroCuentaDataGridViewTextBoxColumn.DataPropertyName = "NroCuenta"
    Me.NroCuentaDataGridViewTextBoxColumn.HeaderText = "NroCuenta"
    Me.NroCuentaDataGridViewTextBoxColumn.Name = "NroCuentaDataGridViewTextBoxColumn"
    '
    'CuotaDataGridViewTextBoxColumn
    '
    Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.HeaderText = "cuota"
    Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
    '
    'FechaDebitoDataGridViewTextBoxColumn
    '
    Me.FechaDebitoDataGridViewTextBoxColumn.DataPropertyName = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.HeaderText = "FechaDebito"
    Me.FechaDebitoDataGridViewTextBoxColumn.Name = "FechaDebitoDataGridViewTextBoxColumn"
    '
    'ImporteADebitarDataGridViewTextBoxColumn
    '
    Me.ImporteADebitarDataGridViewTextBoxColumn.DataPropertyName = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.HeaderText = "ImporteADebitar"
    Me.ImporteADebitarDataGridViewTextBoxColumn.Name = "ImporteADebitarDataGridViewTextBoxColumn"
    '
    'ImporteDebitadoDataGridViewTextBoxColumn
    '
    Me.ImporteDebitadoDataGridViewTextBoxColumn.DataPropertyName = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.HeaderText = "importeDebitado"
    Me.ImporteDebitadoDataGridViewTextBoxColumn.Name = "ImporteDebitadoDataGridViewTextBoxColumn"
    '
    'ImporteBHDataGridViewTextBoxColumn
    '
    Me.ImporteBHDataGridViewTextBoxColumn.DataPropertyName = "ImporteBH"
    Me.ImporteBHDataGridViewTextBoxColumn.HeaderText = "ImporteBH"
    Me.ImporteBHDataGridViewTextBoxColumn.Name = "ImporteBHDataGridViewTextBoxColumn"
    '
    'MotivoRechazoDataGridViewTextBoxColumn
    '
    Me.MotivoRechazoDataGridViewTextBoxColumn.DataPropertyName = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.HeaderText = "MotivoRechazo"
    Me.MotivoRechazoDataGridViewTextBoxColumn.Name = "MotivoRechazoDataGridViewTextBoxColumn"
    '
    'frmImportarHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1275, 672)
    Me.ControlBox = False
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
  Friend WithEvents ImportarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents NroAbonadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NroCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FechaDebitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteADebitarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteDebitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ImporteBHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MotivoRechazoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
