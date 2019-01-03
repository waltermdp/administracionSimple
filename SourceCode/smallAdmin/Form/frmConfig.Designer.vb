<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
    Me.btnBack = New System.Windows.Forms.Button()
    Me.btnActualizarPagos = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnBack
    '
    Me.btnBack.Location = New System.Drawing.Point(54, 635)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(92, 52)
    Me.btnBack.TabIndex = 0
    Me.btnBack.Text = "Volver"
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'btnActualizarPagos
    '
    Me.btnActualizarPagos.Location = New System.Drawing.Point(152, 64)
    Me.btnActualizarPagos.Name = "btnActualizarPagos"
    Me.btnActualizarPagos.Size = New System.Drawing.Size(92, 52)
    Me.btnActualizarPagos.TabIndex = 1
    Me.btnActualizarPagos.Text = "ActualizarPagos"
    Me.btnActualizarPagos.UseVisualStyleBackColor = True
    '
    'frmConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.btnActualizarPagos)
    Me.Controls.Add(Me.btnBack)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmConfig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmConfig"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents btnActualizarPagos As System.Windows.Forms.Button
End Class
