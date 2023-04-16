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
    Me.lstViewResumen = New System.Windows.Forms.ListView()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.ClsInfoHipotecarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IdentificadorDebitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NumeroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CuotaActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'lstViewResumen
    '
    Me.lstViewResumen.Location = New System.Drawing.Point(177, 463)
    Me.lstViewResumen.Name = "lstViewResumen"
    Me.lstViewResumen.Size = New System.Drawing.Size(1080, 92)
    Me.lstViewResumen.TabIndex = 45
    Me.lstViewResumen.UseCompatibleStateImageBehavior = False
    Me.lstViewResumen.View = System.Windows.Forms.View.Details
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
    Me.lblResumen.Location = New System.Drawing.Point(174, 568)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(52, 13)
    Me.lblResumen.TabIndex = 47
    Me.lblResumen.Text = "Resumen"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(48, 463)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(96, 13)
    Me.Label1.TabIndex = 48
    Me.Label1.Text = "Registro a exportar"
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.IdentificadorDebitoDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.NumeroComprobanteDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CodigoBancoDataGridViewTextBoxColumn, Me.CuotaActualDataGridViewTextBoxColumn})
    Me.DataGridView1.DataSource = Me.ClsInfoHipotecarioBindingSource
    Me.DataGridView1.Location = New System.Drawing.Point(177, 91)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(1080, 299)
    Me.DataGridView1.TabIndex = 49
    '
    'ClsInfoHipotecarioBindingSource
    '
    Me.ClsInfoHipotecarioBindingSource.DataSource = GetType(main.clsInfoHipotecario)
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(174, 45)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 16)
    Me.Label2.TabIndex = 50
    Me.Label2.Text = "CONVENIO"
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(252, 41)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ReadOnly = True
    Me.TextBox1.Size = New System.Drawing.Size(100, 20)
    Me.TextBox1.TabIndex = 51
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
    'frmExportarHipotecario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.DataGridView1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.lstViewResumen)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarHipotecario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmExportarResumen"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ClsInfoHipotecarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents lstViewResumen As System.Windows.Forms.ListView
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
