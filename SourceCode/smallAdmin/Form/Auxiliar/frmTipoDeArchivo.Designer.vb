<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDeArchivo
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoDeArchivo))
    Me.pnlSeleccionarPago = New System.Windows.Forms.Panel()
    Me.lblInfoImpExp = New System.Windows.Forms.Label()
    Me.btnCancelImpExp = New System.Windows.Forms.Button()
    Me.btnContinuarImpExp = New System.Windows.Forms.Button()
    Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
    Me.pnlSeleccionarPago.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlSeleccionarPago
    '
    Me.pnlSeleccionarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.pnlSeleccionarPago.Controls.Add(Me.lblInfoImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnCancelImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnContinuarImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.cmbTipoPago)
    Me.pnlSeleccionarPago.Location = New System.Drawing.Point(12, 12)
    Me.pnlSeleccionarPago.Name = "pnlSeleccionarPago"
    Me.pnlSeleccionarPago.Size = New System.Drawing.Size(325, 172)
    Me.pnlSeleccionarPago.TabIndex = 43
    '
    'lblInfoImpExp
    '
    Me.lblInfoImpExp.ForeColor = System.Drawing.Color.Black
    Me.lblInfoImpExp.Location = New System.Drawing.Point(13, 13)
    Me.lblInfoImpExp.Name = "lblInfoImpExp"
    Me.lblInfoImpExp.Size = New System.Drawing.Size(298, 59)
    Me.lblInfoImpExp.TabIndex = 4
    Me.lblInfoImpExp.Text = "Label1"
    '
    'btnCancelImpExp
    '
    Me.btnCancelImpExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelImpExp.FlatAppearance.BorderSize = 0
    Me.btnCancelImpExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelImpExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelImpExp.ForeColor = System.Drawing.Color.White
    Me.btnCancelImpExp.Location = New System.Drawing.Point(227, 126)
    Me.btnCancelImpExp.Name = "btnCancelImpExp"
    Me.btnCancelImpExp.Size = New System.Drawing.Size(84, 37)
    Me.btnCancelImpExp.TabIndex = 3
    Me.btnCancelImpExp.Text = "Cancelar"
    Me.btnCancelImpExp.UseVisualStyleBackColor = False
    '
    'btnContinuarImpExp
    '
    Me.btnContinuarImpExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnContinuarImpExp.FlatAppearance.BorderSize = 0
    Me.btnContinuarImpExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnContinuarImpExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnContinuarImpExp.ForeColor = System.Drawing.Color.White
    Me.btnContinuarImpExp.Location = New System.Drawing.Point(13, 126)
    Me.btnContinuarImpExp.Name = "btnContinuarImpExp"
    Me.btnContinuarImpExp.Size = New System.Drawing.Size(90, 37)
    Me.btnContinuarImpExp.TabIndex = 2
    Me.btnContinuarImpExp.Text = "Continuar"
    Me.btnContinuarImpExp.UseVisualStyleBackColor = False
    '
    'cmbTipoPago
    '
    Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipoPago.FormattingEnabled = True
    Me.cmbTipoPago.Location = New System.Drawing.Point(70, 81)
    Me.cmbTipoPago.Name = "cmbTipoPago"
    Me.cmbTipoPago.Size = New System.Drawing.Size(188, 23)
    Me.cmbTipoPago.TabIndex = 0
    '
    'frmTipoDeArchivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(349, 196)
    Me.Controls.Add(Me.pnlSeleccionarPago)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmTipoDeArchivo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmTipoDeArchivo"
    Me.pnlSeleccionarPago.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlSeleccionarPago As System.Windows.Forms.Panel
  Friend WithEvents lblInfoImpExp As System.Windows.Forms.Label
  Friend WithEvents btnCancelImpExp As System.Windows.Forms.Button
  Friend WithEvents btnContinuarImpExp As System.Windows.Forms.Button
  Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
End Class
