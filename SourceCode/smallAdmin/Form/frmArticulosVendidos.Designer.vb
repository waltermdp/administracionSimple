<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosVendidos
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
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.pnlCtrlEntregados = New System.Windows.Forms.Panel()
    Me.btnUP = New System.Windows.Forms.Button()
    Me.btnDown = New System.Windows.Forms.Button()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.cArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cEntregados = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cGuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.btnRemoveArticulo = New System.Windows.Forms.Button()
    Me.btnAddArticulo = New System.Windows.Forms.Button()
    Me.txtBuscarArticulo = New System.Windows.Forms.TextBox()
    Me.lstArticulos = New System.Windows.Forms.ListBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.lblTitulo = New System.Windows.Forms.Label()
    Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlCtrlEntregados.SuspendLayout()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancel
    '
    Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancel.FlatAppearance.BorderSize = 0
    Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.ForeColor = System.Drawing.Color.White
    Me.btnCancel.Location = New System.Drawing.Point(12, 641)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(110, 61)
    Me.btnCancel.TabIndex = 9
    Me.btnCancel.Text = "Volver"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'pnlCtrlEntregados
    '
    Me.pnlCtrlEntregados.Controls.Add(Me.btnUP)
    Me.pnlCtrlEntregados.Controls.Add(Me.btnDown)
    Me.pnlCtrlEntregados.Location = New System.Drawing.Point(1052, 138)
    Me.pnlCtrlEntregados.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlCtrlEntregados.Name = "pnlCtrlEntregados"
    Me.pnlCtrlEntregados.Size = New System.Drawing.Size(65, 30)
    Me.pnlCtrlEntregados.TabIndex = 59
    '
    'btnUP
    '
    Me.btnUP.Location = New System.Drawing.Point(0, 0)
    Me.btnUP.Name = "btnUP"
    Me.btnUP.Size = New System.Drawing.Size(22, 23)
    Me.btnUP.TabIndex = 46
    Me.btnUP.Text = "+"
    Me.btnUP.UseVisualStyleBackColor = True
    '
    'btnDown
    '
    Me.btnDown.Location = New System.Drawing.Point(28, 0)
    Me.btnDown.Name = "btnDown"
    Me.btnDown.Size = New System.Drawing.Size(22, 23)
    Me.btnDown.TabIndex = 47
    Me.btnDown.Text = "-"
    Me.btnDown.UseVisualStyleBackColor = True
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(804, 111)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(70, 15)
    Me.Label18.TabIndex = 58
    Me.Label18.Text = "Entregados"
    '
    'Label17
    '
    Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(190, 111)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(220, 24)
    Me.Label17.TabIndex = 57
    Me.Label17.Text = "Articulo (codigo)"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(648, 111)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(95, 15)
    Me.Label7.TabIndex = 56
    Me.Label7.Text = "Articulo (codigo)"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(742, 111)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(56, 15)
    Me.Label6.TabIndex = 55
    Me.Label6.Text = "Cantidad"
    '
    'ListView1
    '
    Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cArticulos, Me.cCantidad, Me.cEntregados, Me.cGuid})
    Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListView1.FullRowSelect = True
    Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.ListView1.Location = New System.Drawing.Point(651, 138)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(395, 257)
    Me.ListView1.TabIndex = 54
    Me.ListView1.UseCompatibleStateImageBehavior = False
    '
    'cArticulos
    '
    Me.cArticulos.Text = "Articulos"
    '
    'cCantidad
    '
    Me.cCantidad.Text = "Cantidad"
    Me.cCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cEntregados
    '
    Me.cEntregados.DisplayIndex = 3
    Me.cEntregados.Text = "Entregados"
    Me.cEntregados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cGuid
    '
    Me.cGuid.DisplayIndex = 2
    Me.cGuid.Width = 0
    '
    'btnRemoveArticulo
    '
    Me.btnRemoveArticulo.Location = New System.Drawing.Point(600, 217)
    Me.btnRemoveArticulo.Name = "btnRemoveArticulo"
    Me.btnRemoveArticulo.Size = New System.Drawing.Size(45, 24)
    Me.btnRemoveArticulo.TabIndex = 53
    Me.btnRemoveArticulo.Text = "<-"
    Me.btnRemoveArticulo.UseVisualStyleBackColor = True
    '
    'btnAddArticulo
    '
    Me.btnAddArticulo.Location = New System.Drawing.Point(600, 188)
    Me.btnAddArticulo.Name = "btnAddArticulo"
    Me.btnAddArticulo.Size = New System.Drawing.Size(45, 23)
    Me.btnAddArticulo.TabIndex = 52
    Me.btnAddArticulo.Text = "->"
    Me.btnAddArticulo.UseVisualStyleBackColor = True
    '
    'txtBuscarArticulo
    '
    Me.txtBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtBuscarArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuscarArticulo.Location = New System.Drawing.Point(258, 62)
    Me.txtBuscarArticulo.Name = "txtBuscarArticulo"
    Me.txtBuscarArticulo.Size = New System.Drawing.Size(223, 21)
    Me.txtBuscarArticulo.TabIndex = 51
    '
    'lstArticulos
    '
    Me.lstArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lstArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstArticulos.FormattingEnabled = True
    Me.lstArticulos.HorizontalScrollbar = True
    Me.lstArticulos.ItemHeight = 15
    Me.lstArticulos.Location = New System.Drawing.Point(193, 138)
    Me.lstArticulos.Name = "lstArticulos"
    Me.lstArticulos.ScrollAlwaysVisible = True
    Me.lstArticulos.Size = New System.Drawing.Size(398, 257)
    Me.lstArticulos.TabIndex = 50
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(190, 64)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(62, 15)
    Me.Label12.TabIndex = 49
    Me.Label12.Text = "Articulos"
    '
    'lblTitulo
    '
    Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitulo.Location = New System.Drawing.Point(193, 12)
    Me.lblTitulo.Name = "lblTitulo"
    Me.lblTitulo.Size = New System.Drawing.Size(853, 23)
    Me.lblTitulo.TabIndex = 60
    Me.lblTitulo.Text = "Articulos Vendidos"
    Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'frmArticulosVendidos
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.lblTitulo)
    Me.Controls.Add(Me.pnlCtrlEntregados)
    Me.Controls.Add(Me.Label18)
    Me.Controls.Add(Me.Label17)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.ListView1)
    Me.Controls.Add(Me.btnRemoveArticulo)
    Me.Controls.Add(Me.btnAddArticulo)
    Me.Controls.Add(Me.txtBuscarArticulo)
    Me.Controls.Add(Me.lstArticulos)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmArticulosVendidos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Articulos Vendidos"
    Me.pnlCtrlEntregados.ResumeLayout(False)
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents pnlCtrlEntregados As System.Windows.Forms.Panel
  Friend WithEvents btnUP As System.Windows.Forms.Button
  Friend WithEvents btnDown As System.Windows.Forms.Button
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents cArticulos As System.Windows.Forms.ColumnHeader
  Friend WithEvents cCantidad As System.Windows.Forms.ColumnHeader
  Friend WithEvents cEntregados As System.Windows.Forms.ColumnHeader
  Friend WithEvents cGuid As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnRemoveArticulo As System.Windows.Forms.Button
  Friend WithEvents btnAddArticulo As System.Windows.Forms.Button
  Friend WithEvents txtBuscarArticulo As System.Windows.Forms.TextBox
  Friend WithEvents lstArticulos As System.Windows.Forms.ListBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblTitulo As System.Windows.Forms.Label
  Friend WithEvents tTip As System.Windows.Forms.ToolTip
  Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
End Class
