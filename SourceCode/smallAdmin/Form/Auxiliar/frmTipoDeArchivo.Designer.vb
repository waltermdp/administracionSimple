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
    Me.pnlSeleccionarPago.Controls.Add(Me.lblInfoImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnCancelImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnContinuarImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.cmbTipoPago)
    Me.pnlSeleccionarPago.Location = New System.Drawing.Point(12, 12)
    Me.pnlSeleccionarPago.Name = "pnlSeleccionarPago"
    Me.pnlSeleccionarPago.Size = New System.Drawing.Size(325, 172)
    Me.pnlSeleccionarPago.TabIndex = 43
    Me.pnlSeleccionarPago.Visible = False
    '
    'lblInfoImpExp
    '
    Me.lblInfoImpExp.Location = New System.Drawing.Point(13, 13)
    Me.lblInfoImpExp.Name = "lblInfoImpExp"
    Me.lblInfoImpExp.Size = New System.Drawing.Size(298, 59)
    Me.lblInfoImpExp.TabIndex = 4
    Me.lblInfoImpExp.Text = "Label1"
    '
    'btnCancelImpExp
    '
    Me.btnCancelImpExp.Location = New System.Drawing.Point(239, 126)
    Me.btnCancelImpExp.Name = "btnCancelImpExp"
    Me.btnCancelImpExp.Size = New System.Drawing.Size(72, 37)
    Me.btnCancelImpExp.TabIndex = 3
    Me.btnCancelImpExp.Text = "Cancelar"
    Me.btnCancelImpExp.UseVisualStyleBackColor = True
    '
    'btnContinuarImpExp
    '
    Me.btnContinuarImpExp.Location = New System.Drawing.Point(13, 126)
    Me.btnContinuarImpExp.Name = "btnContinuarImpExp"
    Me.btnContinuarImpExp.Size = New System.Drawing.Size(71, 37)
    Me.btnContinuarImpExp.TabIndex = 2
    Me.btnContinuarImpExp.Text = "Continuar"
    Me.btnContinuarImpExp.UseVisualStyleBackColor = True
    '
    'cmbTipoPago
    '
    Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipoPago.FormattingEnabled = True
    Me.cmbTipoPago.Location = New System.Drawing.Point(70, 85)
    Me.cmbTipoPago.Name = "cmbTipoPago"
    Me.cmbTipoPago.Size = New System.Drawing.Size(188, 23)
    Me.cmbTipoPago.TabIndex = 0
    '
    'frmTipoDeArchivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
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
