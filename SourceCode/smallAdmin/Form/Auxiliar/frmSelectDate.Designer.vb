<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDate
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
    Me.dtpDate = New System.Windows.Forms.DateTimePicker()
    Me.lblInfoImpExp = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.pnlSeleccionarPago.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlSeleccionarPago
    '
    Me.pnlSeleccionarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.pnlSeleccionarPago.Controls.Add(Me.dtpDate)
    Me.pnlSeleccionarPago.Controls.Add(Me.lblInfoImpExp)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnCancelar)
    Me.pnlSeleccionarPago.Controls.Add(Me.btnAceptar)
    Me.pnlSeleccionarPago.Location = New System.Drawing.Point(12, 12)
    Me.pnlSeleccionarPago.Name = "pnlSeleccionarPago"
    Me.pnlSeleccionarPago.Size = New System.Drawing.Size(325, 172)
    Me.pnlSeleccionarPago.TabIndex = 44
    '
    'dtpDate
    '
    Me.dtpDate.Location = New System.Drawing.Point(67, 75)
    Me.dtpDate.Name = "dtpDate"
    Me.dtpDate.Size = New System.Drawing.Size(200, 20)
    Me.dtpDate.TabIndex = 5
    '
    'lblInfoImpExp
    '
    Me.lblInfoImpExp.ForeColor = System.Drawing.Color.Black
    Me.lblInfoImpExp.Location = New System.Drawing.Point(13, 13)
    Me.lblInfoImpExp.Name = "lblInfoImpExp"
    Me.lblInfoImpExp.Size = New System.Drawing.Size(298, 45)
    Me.lblInfoImpExp.TabIndex = 4
    Me.lblInfoImpExp.Text = "Seleccionar una fecha o Cancelar"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(201, 126)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 35)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAceptar.FlatAppearance.BorderSize = 0
    Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ForeColor = System.Drawing.Color.White
    Me.btnAceptar.Location = New System.Drawing.Point(13, 126)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(110, 35)
    Me.btnAceptar.TabIndex = 2
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'frmSelectDate
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(350, 197)
    Me.Controls.Add(Me.pnlSeleccionarPago)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.Name = "frmSelectDate"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmSelectDate"
    Me.pnlSeleccionarPago.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlSeleccionarPago As System.Windows.Forms.Panel
  Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblInfoImpExp As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
