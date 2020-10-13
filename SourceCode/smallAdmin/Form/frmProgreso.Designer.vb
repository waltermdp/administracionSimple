<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgreso
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
    Me.pbBarra = New System.Windows.Forms.ProgressBar()
    Me.lblDescription = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    Me.SuspendLayout()
    '
    'pbBarra
    '
    Me.pbBarra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pbBarra.Location = New System.Drawing.Point(12, 12)
    Me.pbBarra.MarqueeAnimationSpeed = 0
    Me.pbBarra.Name = "pbBarra"
    Me.pbBarra.Size = New System.Drawing.Size(323, 23)
    Me.pbBarra.Style = System.Windows.Forms.ProgressBarStyle.Marquee
    Me.pbBarra.TabIndex = 3
    '
    'lblDescription
    '
    Me.lblDescription.AutoSize = True
    Me.lblDescription.Location = New System.Drawing.Point(12, 38)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(39, 13)
    Me.lblDescription.TabIndex = 5
    Me.lblDescription.Text = "Label1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.Location = New System.Drawing.Point(260, 12)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'BackgroundWorker1
    '
    '
    'frmProgreso
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlDark
    Me.ClientSize = New System.Drawing.Size(347, 53)
    Me.Controls.Add(Me.pbBarra)
    Me.Controls.Add(Me.lblDescription)
    Me.Controls.Add(Me.btnCancelar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmProgreso"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmProgreso"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pbBarra As System.Windows.Forms.ProgressBar
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
