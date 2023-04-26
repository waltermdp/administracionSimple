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
    Me.txtConcepto = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtIdDebito = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtVencimiento = New System.Windows.Forms.DateTimePicker()
    Me.dtCurrent = New System.Windows.Forms.DateTimePicker()
    Me.txtSecuencial = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtImporteTotal = New System.Windows.Forms.TextBox()
    Me.txtNumeroConvenio = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dgvResumen = New System.Windows.Forms.DataGridView()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtConcepto
    '
    Me.txtConcepto.Location = New System.Drawing.Point(758, 72)
    Me.txtConcepto.Name = "txtConcepto"
    Me.txtConcepto.Size = New System.Drawing.Size(372, 20)
    Me.txtConcepto.TabIndex = 84
    '
    'Label7
    '
    Me.Label7.Location = New System.Drawing.Point(680, 71)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 20)
    Me.Label7.TabIndex = 83
    Me.Label7.Text = "Concepto"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtIdDebito
    '
    Me.txtIdDebito.Location = New System.Drawing.Point(451, 71)
    Me.txtIdDebito.Name = "txtIdDebito"
    Me.txtIdDebito.Size = New System.Drawing.Size(191, 20)
    Me.txtIdDebito.TabIndex = 82
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(373, 71)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 20)
    Me.Label1.TabIndex = 81
    Me.Label1.Text = "Id. Debito"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtVencimiento
    '
    Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtVencimiento.Location = New System.Drawing.Point(1000, 42)
    Me.dtVencimiento.Name = "dtVencimiento"
    Me.dtVencimiento.Size = New System.Drawing.Size(130, 20)
    Me.dtVencimiento.TabIndex = 80
    '
    'dtCurrent
    '
    Me.dtCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtCurrent.Location = New System.Drawing.Point(714, 41)
    Me.dtCurrent.Name = "dtCurrent"
    Me.dtCurrent.Size = New System.Drawing.Size(130, 20)
    Me.dtCurrent.TabIndex = 79
    '
    'txtSecuencial
    '
    Me.txtSecuencial.Location = New System.Drawing.Point(247, 71)
    Me.txtSecuencial.Name = "txtSecuencial"
    Me.txtSecuencial.Size = New System.Drawing.Size(100, 20)
    Me.txtSecuencial.TabIndex = 78
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(169, 71)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 20)
    Me.Label6.TabIndex = 77
    Me.Label6.Text = "Secuencial"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(894, 44)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 23)
    Me.Label5.TabIndex = 76
    Me.Label5.Text = "Fecha Vencimiento"
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(629, 44)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 23)
    Me.Label4.TabIndex = 75
    Me.Label4.Text = "Fecha Actual"
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(373, 44)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 20)
    Me.Label3.TabIndex = 74
    Me.Label3.Text = "IMPORTE TOTAL"
    '
    'txtImporteTotal
    '
    Me.txtImporteTotal.Location = New System.Drawing.Point(479, 44)
    Me.txtImporteTotal.Name = "txtImporteTotal"
    Me.txtImporteTotal.ReadOnly = True
    Me.txtImporteTotal.Size = New System.Drawing.Size(133, 20)
    Me.txtImporteTotal.TabIndex = 73
    '
    'txtNumeroConvenio
    '
    Me.txtNumeroConvenio.Location = New System.Drawing.Point(247, 44)
    Me.txtNumeroConvenio.Name = "txtNumeroConvenio"
    Me.txtNumeroConvenio.Size = New System.Drawing.Size(100, 20)
    Me.txtNumeroConvenio.TabIndex = 72
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(169, 48)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 16)
    Me.Label2.TabIndex = 71
    Me.Label2.Text = "CONVENIO"
    '
    'dgvResumen
    '
    Me.dgvResumen.AllowUserToAddRows = False
    Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
    'frmExportarPatagonia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.txtConcepto)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtIdDebito)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtVencimiento)
    Me.Controls.Add(Me.dtCurrent)
    Me.Controls.Add(Me.txtSecuencial)
    Me.Controls.Add(Me.Label6)
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
    Me.Name = "frmExportarPatagonia"
    Me.Text = "frmExportarPatagonia"
    CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtIdDebito As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtCurrent As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtSecuencial As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
  Friend WithEvents txtNumeroConvenio As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
