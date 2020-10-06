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
    Me.btnReprocesarFile = New System.Windows.Forms.Button()
    Me.lblAprobados = New System.Windows.Forms.Label()
    Me.lblConflictos = New System.Windows.Forms.Label()
    Me.lblRechazados = New System.Windows.Forms.Label()
    Me.lblResumen = New System.Windows.Forms.Label()
    Me.lblDetalle = New System.Windows.Forms.Label()
    Me.btnViewDetail = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lstViewResumen
    '
    Me.lstViewResumen.Location = New System.Drawing.Point(177, 64)
    Me.lstViewResumen.Name = "lstViewResumen"
    Me.lstViewResumen.Size = New System.Drawing.Size(1080, 510)
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
    Me.btnOK.Text = "Liquidar Archivo"
    Me.btnOK.UseVisualStyleBackColor = False
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(47, 610)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 42
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'btnReprocesarFile
    '
    Me.btnReprocesarFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnReprocesarFile.FlatAppearance.BorderSize = 0
    Me.btnReprocesarFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnReprocesarFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReprocesarFile.ForeColor = System.Drawing.Color.White
    Me.btnReprocesarFile.Location = New System.Drawing.Point(47, 126)
    Me.btnReprocesarFile.Name = "btnReprocesarFile"
    Me.btnReprocesarFile.Size = New System.Drawing.Size(110, 61)
    Me.btnReprocesarFile.TabIndex = 45
    Me.btnReprocesarFile.Text = "Reprocesar Archivo"
    Me.btnReprocesarFile.UseVisualStyleBackColor = False
    '
    'lblAprobados
    '
    Me.lblAprobados.AutoSize = True
    Me.lblAprobados.Location = New System.Drawing.Point(220, 590)
    Me.lblAprobados.Name = "lblAprobados"
    Me.lblAprobados.Size = New System.Drawing.Size(10, 13)
    Me.lblAprobados.TabIndex = 46
    Me.lblAprobados.Text = "."
    '
    'lblConflictos
    '
    Me.lblConflictos.AutoSize = True
    Me.lblConflictos.Location = New System.Drawing.Point(220, 612)
    Me.lblConflictos.Name = "lblConflictos"
    Me.lblConflictos.Size = New System.Drawing.Size(10, 13)
    Me.lblConflictos.TabIndex = 47
    Me.lblConflictos.Text = "."
    '
    'lblRechazados
    '
    Me.lblRechazados.AutoSize = True
    Me.lblRechazados.Location = New System.Drawing.Point(220, 635)
    Me.lblRechazados.Name = "lblRechazados"
    Me.lblRechazados.Size = New System.Drawing.Size(10, 13)
    Me.lblRechazados.TabIndex = 48
    Me.lblRechazados.Text = "."
    '
    'lblResumen
    '
    Me.lblResumen.AutoSize = True
    Me.lblResumen.Location = New System.Drawing.Point(220, 657)
    Me.lblResumen.Name = "lblResumen"
    Me.lblResumen.Size = New System.Drawing.Size(10, 13)
    Me.lblResumen.TabIndex = 49
    Me.lblResumen.Text = "."
    '
    'lblDetalle
    '
    Me.lblDetalle.AutoSize = True
    Me.lblDetalle.Location = New System.Drawing.Point(692, 604)
    Me.lblDetalle.Name = "lblDetalle"
    Me.lblDetalle.Size = New System.Drawing.Size(10, 13)
    Me.lblDetalle.TabIndex = 50
    Me.lblDetalle.Text = "."
    '
    'btnViewDetail
    '
    Me.btnViewDetail.Location = New System.Drawing.Point(695, 638)
    Me.btnViewDetail.Name = "btnViewDetail"
    Me.btnViewDetail.Size = New System.Drawing.Size(143, 32)
    Me.btnViewDetail.TabIndex = 51
    Me.btnViewDetail.Text = "Ver Detalle"
    Me.btnViewDetail.UseVisualStyleBackColor = True
    Me.btnViewDetail.Visible = False
    '
    'frmResumen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.btnViewDetail)
    Me.Controls.Add(Me.lblDetalle)
    Me.Controls.Add(Me.lblResumen)
    Me.Controls.Add(Me.lblRechazados)
    Me.Controls.Add(Me.lblConflictos)
    Me.Controls.Add(Me.lblAprobados)
    Me.Controls.Add(Me.btnReprocesarFile)
    Me.Controls.Add(Me.lstViewResumen)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmResumen"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmResumen"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstViewResumen As System.Windows.Forms.ListView
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnReprocesarFile As System.Windows.Forms.Button
  Friend WithEvents lblAprobados As System.Windows.Forms.Label
  Friend WithEvents lblConflictos As System.Windows.Forms.Label
  Friend WithEvents lblRechazados As System.Windows.Forms.Label
  Friend WithEvents lblResumen As System.Windows.Forms.Label
  Friend WithEvents lblDetalle As System.Windows.Forms.Label
  Friend WithEvents btnViewDetail As System.Windows.Forms.Button
End Class
