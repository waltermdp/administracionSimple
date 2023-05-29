<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarResumen
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
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.btnProcesar = New System.Windows.Forms.Button()
    Me.lstViewResumen = New System.Windows.Forms.ListView()
    Me.btnReload = New System.Windows.Forms.Button()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
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
    Me.btnProcesar.Location = New System.Drawing.Point(10, 35)
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(110, 60)
    Me.btnProcesar.TabIndex = 44
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.UseVisualStyleBackColor = False
    '
    'lstViewResumen
    '
    Me.lstViewResumen.Location = New System.Drawing.Point(20, 44)
    Me.lstViewResumen.Name = "lstViewResumen"
    Me.lstViewResumen.Size = New System.Drawing.Size(1080, 468)
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
    Me.btnReload.Location = New System.Drawing.Point(10, 105)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(110, 60)
    Me.btnReload.TabIndex = 46
    Me.btnReload.Text = "Volver a Cargar"
    Me.btnReload.UseVisualStyleBackColor = False
    '
    'lblResumen
    '
    Me.lblResumen.BackColor = System.Drawing.Color.Transparent
    Me.lblResumen.Location = New System.Drawing.Point(20, 515)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(1080, 139)
    Me.lblResumen.TabIndex = 47
    Me.lblResumen.Text = "Resumen"
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(20, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1083, 23)
    Me.Label1.TabIndex = 48
    Me.Label1.Text = "Registro a exportar"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.lstViewResumen)
    Me.Panel1.Controls.Add(Me.lblResumen)
    Me.Panel1.Location = New System.Drawing.Point(143, 36)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1120, 672)
    Me.Panel1.TabIndex = 49
    '
    'frmExportarResumen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnReload)
    Me.Controls.Add(Me.btnProcesar)
    Me.Controls.Add(Me.btnCancel)
    Me.DoubleBuffered = True
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmExportarResumen"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmExportarResumen"
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnProcesar As System.Windows.Forms.Button
  Friend WithEvents lstViewResumen As System.Windows.Forms.ListView
  Friend WithEvents btnReload As System.Windows.Forms.Button
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
