<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumen
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumen))
    Me.lstViewResumen = New System.Windows.Forms.ListView()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lstViewResumen
    '
    Me.lstViewResumen.Location = New System.Drawing.Point(177, 64)
    Me.lstViewResumen.Name = "lstViewResumen"
    Me.lstViewResumen.Size = New System.Drawing.Size(778, 348)
    Me.lstViewResumen.TabIndex = 44
    Me.lstViewResumen.UseCompatibleStateImageBehavior = False
    Me.lstViewResumen.View = System.Windows.Forms.View.Details
    '
    'btnOK
    '
    Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnOK.FlatAppearance.BorderSize = 0
    Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOK.ForeColor = System.Drawing.Color.White
    Me.btnOK.Location = New System.Drawing.Point(47, 37)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(110, 61)
    Me.btnOK.TabIndex = 43
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = False
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(47, 458)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 42
    Me.btnCancel.Text = "Salir"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'frmResumen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(993, 559)
    Me.Controls.Add(Me.lstViewResumen)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmResumen"
    Me.Text = "frmResumen"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstViewResumen As System.Windows.Forms.ListView
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
