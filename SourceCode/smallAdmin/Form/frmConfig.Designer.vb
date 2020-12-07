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
    Me.components = New System.ComponentModel.Container()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.btnActualizarPagos = New System.Windows.Forms.Button()
    Me.btnNewGroup = New System.Windows.Forms.Button()
    Me.btnRemGroup = New System.Windows.Forms.Button()
    Me.btnRemCategoria = New System.Windows.Forms.Button()
    Me.btnNewCategoria = New System.Windows.Forms.Button()
    Me.lstvCategoria = New System.Windows.Forms.ListView()
    Me.txtInGrupo = New System.Windows.Forms.TextBox()
    Me.txtInCategoria = New System.Windows.Forms.TextBox()
    Me.bsGrupos = New System.Windows.Forms.BindingSource(Me.components)
    Me.lstGrupo = New System.Windows.Forms.ListBox()
    CType(Me.bsGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.btnActualizarPagos.Location = New System.Drawing.Point(118, 64)
    Me.btnActualizarPagos.Name = "btnActualizarPagos"
    Me.btnActualizarPagos.Size = New System.Drawing.Size(92, 52)
    Me.btnActualizarPagos.TabIndex = 1
    Me.btnActualizarPagos.Text = "ActualizarPagos"
    Me.btnActualizarPagos.UseVisualStyleBackColor = True
    Me.btnActualizarPagos.Visible = False
    '
    'btnNewGroup
    '
    Me.btnNewGroup.Location = New System.Drawing.Point(561, 62)
    Me.btnNewGroup.Name = "btnNewGroup"
    Me.btnNewGroup.Size = New System.Drawing.Size(66, 55)
    Me.btnNewGroup.TabIndex = 3
    Me.btnNewGroup.Text = "+"
    Me.btnNewGroup.UseVisualStyleBackColor = True
    '
    'btnRemGroup
    '
    Me.btnRemGroup.Location = New System.Drawing.Point(561, 123)
    Me.btnRemGroup.Name = "btnRemGroup"
    Me.btnRemGroup.Size = New System.Drawing.Size(66, 52)
    Me.btnRemGroup.TabIndex = 4
    Me.btnRemGroup.Text = "-"
    Me.btnRemGroup.UseVisualStyleBackColor = True
    '
    'btnRemCategoria
    '
    Me.btnRemCategoria.Location = New System.Drawing.Point(849, 121)
    Me.btnRemCategoria.Name = "btnRemCategoria"
    Me.btnRemCategoria.Size = New System.Drawing.Size(66, 52)
    Me.btnRemCategoria.TabIndex = 7
    Me.btnRemCategoria.Text = "-"
    Me.btnRemCategoria.UseVisualStyleBackColor = True
    '
    'btnNewCategoria
    '
    Me.btnNewCategoria.Location = New System.Drawing.Point(849, 62)
    Me.btnNewCategoria.Name = "btnNewCategoria"
    Me.btnNewCategoria.Size = New System.Drawing.Size(66, 53)
    Me.btnNewCategoria.TabIndex = 6
    Me.btnNewCategoria.Text = "+"
    Me.btnNewCategoria.UseVisualStyleBackColor = True
    '
    'lstvCategoria
    '
    Me.lstvCategoria.Location = New System.Drawing.Point(673, 95)
    Me.lstvCategoria.Name = "lstvCategoria"
    Me.lstvCategoria.Size = New System.Drawing.Size(170, 209)
    Me.lstvCategoria.TabIndex = 5
    Me.lstvCategoria.UseCompatibleStateImageBehavior = False
    Me.lstvCategoria.View = System.Windows.Forms.View.List
    '
    'txtInGrupo
    '
    Me.txtInGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInGrupo.Location = New System.Drawing.Point(385, 62)
    Me.txtInGrupo.Name = "txtInGrupo"
    Me.txtInGrupo.Size = New System.Drawing.Size(170, 21)
    Me.txtInGrupo.TabIndex = 8
    '
    'txtInCategoria
    '
    Me.txtInCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInCategoria.Location = New System.Drawing.Point(673, 62)
    Me.txtInCategoria.Name = "txtInCategoria"
    Me.txtInCategoria.Size = New System.Drawing.Size(170, 21)
    Me.txtInCategoria.TabIndex = 9
    '
    'bsGrupos
    '
    Me.bsGrupos.DataSource = GetType(manDB.clsInfoGrupo)
    '
    'lstGrupo
    '
    Me.lstGrupo.DataSource = Me.bsGrupos
    Me.lstGrupo.DisplayMember = "Nombre"
    Me.lstGrupo.FormattingEnabled = True
    Me.lstGrupo.Location = New System.Drawing.Point(385, 92)
    Me.lstGrupo.Name = "lstGrupo"
    Me.lstGrupo.Size = New System.Drawing.Size(170, 212)
    Me.lstGrupo.TabIndex = 10
    '
    'frmConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.lstGrupo)
    Me.Controls.Add(Me.txtInCategoria)
    Me.Controls.Add(Me.txtInGrupo)
    Me.Controls.Add(Me.btnRemCategoria)
    Me.Controls.Add(Me.btnNewCategoria)
    Me.Controls.Add(Me.lstvCategoria)
    Me.Controls.Add(Me.btnRemGroup)
    Me.Controls.Add(Me.btnNewGroup)
    Me.Controls.Add(Me.btnActualizarPagos)
    Me.Controls.Add(Me.btnBack)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmConfig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmConfig"
    CType(Me.bsGrupos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents btnActualizarPagos As System.Windows.Forms.Button
  Friend WithEvents btnNewGroup As System.Windows.Forms.Button
  Friend WithEvents btnRemGroup As System.Windows.Forms.Button
  Friend WithEvents btnRemCategoria As System.Windows.Forms.Button
  Friend WithEvents btnNewCategoria As System.Windows.Forms.Button
  Friend WithEvents lstvCategoria As System.Windows.Forms.ListView
  Friend WithEvents txtInGrupo As System.Windows.Forms.TextBox
  Friend WithEvents txtInCategoria As System.Windows.Forms.TextBox
  Friend WithEvents bsGrupos As System.Windows.Forms.BindingSource
  Friend WithEvents lstGrupo As System.Windows.Forms.ListBox
End Class
