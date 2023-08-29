<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionVendedores
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
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnLiquidar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.chkEnable = New System.Windows.Forms.PictureBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.chkAuto = New System.Windows.Forms.CheckBox()
    Me.chkZona = New System.Windows.Forms.CheckBox()
    Me.chkAguinaldo = New System.Windows.Forms.CheckBox()
    Me.chkVendedores = New System.Windows.Forms.CheckBox()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.chk110 = New System.Windows.Forms.CheckBox()
    Me.chk90 = New System.Windows.Forms.CheckBox()
    Me.chk70 = New System.Windows.Forms.CheckBox()
    Me.chk50 = New System.Windows.Forms.CheckBox()
    Me.chkPremio80Vent = New System.Windows.Forms.CheckBox()
    Me.chkCarpetaProb = New System.Windows.Forms.CheckBox()
    Me.lblAdelantos = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtVale = New System.Windows.Forms.TextBox()
    Me.bsVendedores = New System.Windows.Forms.BindingSource(Me.components)
    Me.lblTitulo = New System.Windows.Forms.Label()
    Me.dtFrom = New System.Windows.Forms.DateTimePicker()
    Me.dtTo = New System.Windows.Forms.DateTimePicker()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkEnablePorcentaje1 = New System.Windows.Forms.CheckBox()
    Me.nPorcentaje1 = New System.Windows.Forms.NumericUpDown()
    CType(Me.chkEnable, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nPorcentaje1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblFecha
    '
    Me.lblFecha.BackColor = System.Drawing.Color.Transparent
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(193, 58)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(97, 22)
    Me.lblFecha.TabIndex = 0
    Me.lblFecha.Text = "Fecha Inicio:"
    Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(193, 94)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(0, 13)
    Me.Label1.TabIndex = 1
    '
    'btnLiquidar
    '
    Me.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLiquidar.FlatAppearance.BorderSize = 0
    Me.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLiquidar.ForeColor = System.Drawing.Color.White
    Me.btnLiquidar.Location = New System.Drawing.Point(1142, 66)
    Me.btnLiquidar.Name = "btnLiquidar"
    Me.btnLiquidar.Size = New System.Drawing.Size(110, 60)
    Me.btnLiquidar.TabIndex = 14
    Me.btnLiquidar.Text = "Liquidar"
    Me.btnLiquidar.UseVisualStyleBackColor = False
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(10, 637)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 60)
    Me.btnVolver.TabIndex = 39
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'chkEnable
    '
    Me.chkEnable.BackColor = System.Drawing.Color.White
    Me.chkEnable.Location = New System.Drawing.Point(22, 26)
    Me.chkEnable.Name = "chkEnable"
    Me.chkEnable.Size = New System.Drawing.Size(988, 537)
    Me.chkEnable.TabIndex = 41
    Me.chkEnable.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.BackColor = System.Drawing.Color.Silver
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel1.Controls.Add(Me.chkEnable)
    Me.Panel1.Location = New System.Drawing.Point(196, 213)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1056, 485)
    Me.Panel1.TabIndex = 42
    '
    'chkAuto
    '
    Me.chkAuto.AutoSize = True
    Me.chkAuto.BackColor = System.Drawing.Color.White
    Me.chkAuto.Location = New System.Drawing.Point(6, 19)
    Me.chkAuto.Name = "chkAuto"
    Me.chkAuto.Size = New System.Drawing.Size(50, 19)
    Me.chkAuto.TabIndex = 43
    Me.chkAuto.Text = "Auto"
    Me.chkAuto.UseVisualStyleBackColor = False
    '
    'chkZona
    '
    Me.chkZona.AutoSize = True
    Me.chkZona.BackColor = System.Drawing.Color.White
    Me.chkZona.Location = New System.Drawing.Point(6, 42)
    Me.chkZona.Name = "chkZona"
    Me.chkZona.Size = New System.Drawing.Size(54, 19)
    Me.chkZona.TabIndex = 44
    Me.chkZona.Text = "Zona"
    Me.chkZona.UseVisualStyleBackColor = False
    '
    'chkAguinaldo
    '
    Me.chkAguinaldo.AutoSize = True
    Me.chkAguinaldo.BackColor = System.Drawing.Color.White
    Me.chkAguinaldo.Location = New System.Drawing.Point(121, 19)
    Me.chkAguinaldo.Name = "chkAguinaldo"
    Me.chkAguinaldo.Size = New System.Drawing.Size(81, 19)
    Me.chkAguinaldo.TabIndex = 45
    Me.chkAguinaldo.Text = "Aguinaldo"
    Me.chkAguinaldo.UseVisualStyleBackColor = False
    '
    'chkVendedores
    '
    Me.chkVendedores.AutoSize = True
    Me.chkVendedores.BackColor = System.Drawing.Color.White
    Me.chkVendedores.Location = New System.Drawing.Point(121, 42)
    Me.chkVendedores.Name = "chkVendedores"
    Me.chkVendedores.Size = New System.Drawing.Size(92, 19)
    Me.chkVendedores.TabIndex = 46
    Me.chkVendedores.Text = "Vendedores"
    Me.chkVendedores.UseVisualStyleBackColor = False
    '
    'btnImprimir
    '
    Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnImprimir.FlatAppearance.BorderSize = 0
    Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ForeColor = System.Drawing.Color.White
    Me.btnImprimir.Location = New System.Drawing.Point(1142, 133)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(110, 60)
    Me.btnImprimir.TabIndex = 47
    Me.btnImprimir.Text = "Imprimir"
    Me.btnImprimir.UseVisualStyleBackColor = False
    Me.btnImprimir.Visible = False
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.nPorcentaje1)
    Me.GroupBox1.Controls.Add(Me.chkEnablePorcentaje1)
    Me.GroupBox1.Controls.Add(Me.chk110)
    Me.GroupBox1.Controls.Add(Me.chk90)
    Me.GroupBox1.Controls.Add(Me.chk70)
    Me.GroupBox1.Controls.Add(Me.chk50)
    Me.GroupBox1.Controls.Add(Me.chkPremio80Vent)
    Me.GroupBox1.Controls.Add(Me.chkCarpetaProb)
    Me.GroupBox1.Controls.Add(Me.lblAdelantos)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.txtVale)
    Me.GroupBox1.Controls.Add(Me.chkAuto)
    Me.GroupBox1.Controls.Add(Me.chkZona)
    Me.GroupBox1.Controls.Add(Me.chkVendedores)
    Me.GroupBox1.Controls.Add(Me.chkAguinaldo)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(196, 86)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(924, 107)
    Me.GroupBox1.TabIndex = 48
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Aplicar"
    '
    'chk110
    '
    Me.chk110.AutoSize = True
    Me.chk110.BackColor = System.Drawing.Color.White
    Me.chk110.Location = New System.Drawing.Point(526, 41)
    Me.chk110.Name = "chk110"
    Me.chk110.Size = New System.Drawing.Size(87, 19)
    Me.chk110.TabIndex = 55
    Me.chk110.Text = "Vta Liq 110"
    Me.chk110.UseVisualStyleBackColor = False
    '
    'chk90
    '
    Me.chk90.AutoSize = True
    Me.chk90.BackColor = System.Drawing.Color.White
    Me.chk90.Location = New System.Drawing.Point(440, 41)
    Me.chk90.Name = "chk90"
    Me.chk90.Size = New System.Drawing.Size(80, 19)
    Me.chk90.TabIndex = 54
    Me.chk90.Text = "Vta Liq 90"
    Me.chk90.UseVisualStyleBackColor = False
    '
    'chk70
    '
    Me.chk70.AutoSize = True
    Me.chk70.BackColor = System.Drawing.Color.White
    Me.chk70.Location = New System.Drawing.Point(342, 41)
    Me.chk70.Name = "chk70"
    Me.chk70.Size = New System.Drawing.Size(80, 19)
    Me.chk70.TabIndex = 53
    Me.chk70.Text = "Vta Liq 70"
    Me.chk70.UseVisualStyleBackColor = False
    '
    'chk50
    '
    Me.chk50.AutoSize = True
    Me.chk50.BackColor = System.Drawing.Color.White
    Me.chk50.Location = New System.Drawing.Point(244, 41)
    Me.chk50.Name = "chk50"
    Me.chk50.Size = New System.Drawing.Size(80, 19)
    Me.chk50.TabIndex = 52
    Me.chk50.Text = "Vta Liq 50"
    Me.chk50.UseVisualStyleBackColor = False
    '
    'chkPremio80Vent
    '
    Me.chkPremio80Vent.AutoSize = True
    Me.chkPremio80Vent.BackColor = System.Drawing.Color.White
    Me.chkPremio80Vent.Location = New System.Drawing.Point(385, 19)
    Me.chkPremio80Vent.Name = "chkPremio80Vent"
    Me.chkPremio80Vent.Size = New System.Drawing.Size(152, 19)
    Me.chkPremio80Vent.TabIndex = 51
    Me.chkPremio80Vent.Text = "Premio mensual 80 vta"
    Me.chkPremio80Vent.UseVisualStyleBackColor = False
    '
    'chkCarpetaProb
    '
    Me.chkCarpetaProb.AutoSize = True
    Me.chkCarpetaProb.BackColor = System.Drawing.Color.White
    Me.chkCarpetaProb.Location = New System.Drawing.Point(244, 19)
    Me.chkCarpetaProb.Name = "chkCarpetaProb"
    Me.chkCarpetaProb.Size = New System.Drawing.Size(135, 19)
    Me.chkCarpetaProb.TabIndex = 50
    Me.chkCarpetaProb.Text = "Carpeta de Prob + 5"
    Me.chkCarpetaProb.UseVisualStyleBackColor = False
    '
    'lblAdelantos
    '
    Me.lblAdelantos.AutoSize = True
    Me.lblAdelantos.Location = New System.Drawing.Point(543, 20)
    Me.lblAdelantos.Name = "lblAdelantos"
    Me.lblAdelantos.Size = New System.Drawing.Size(74, 15)
    Me.lblAdelantos.TabIndex = 49
    Me.lblAdelantos.Text = "Adelantos: 0"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(742, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 15)
    Me.Label2.TabIndex = 48
    Me.Label2.Text = "Vales:"
    '
    'txtVale
    '
    Me.txtVale.Location = New System.Drawing.Point(784, 13)
    Me.txtVale.Name = "txtVale"
    Me.txtVale.Size = New System.Drawing.Size(127, 21)
    Me.txtVale.TabIndex = 47
    Me.txtVale.Text = "0"
    Me.txtVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'bsVendedores
    '
    Me.bsVendedores.DataSource = GetType(manDB.clsInfoVendedor)
    '
    'lblTitulo
    '
    Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
    Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitulo.ForeColor = System.Drawing.Color.White
    Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
    Me.lblTitulo.Name = "lblTitulo"
    Me.lblTitulo.Size = New System.Drawing.Size(1280, 25)
    Me.lblTitulo.TabIndex = 49
    Me.lblTitulo.Text = "VENDEDOR"
    Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'dtFrom
    '
    Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFrom.Location = New System.Drawing.Point(296, 60)
    Me.dtFrom.Name = "dtFrom"
    Me.dtFrom.Size = New System.Drawing.Size(141, 20)
    Me.dtFrom.TabIndex = 50
    '
    'dtTo
    '
    Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtTo.Location = New System.Drawing.Point(565, 58)
    Me.dtTo.Name = "dtTo"
    Me.dtTo.Size = New System.Drawing.Size(120, 20)
    Me.dtTo.TabIndex = 51
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(452, 58)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(97, 22)
    Me.Label3.TabIndex = 52
    Me.Label3.Text = "Fecha Fin:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'chkEnablePorcentaje1
    '
    Me.chkEnablePorcentaje1.AutoSize = True
    Me.chkEnablePorcentaje1.BackColor = System.Drawing.Color.White
    Me.chkEnablePorcentaje1.Location = New System.Drawing.Point(6, 67)
    Me.chkEnablePorcentaje1.Name = "chkEnablePorcentaje1"
    Me.chkEnablePorcentaje1.Size = New System.Drawing.Size(90, 19)
    Me.chkEnablePorcentaje1.TabIndex = 56
    Me.chkEnablePorcentaje1.Text = "% PorVenta"
    Me.chkEnablePorcentaje1.UseVisualStyleBackColor = False
    '
    'nPorcentaje1
    '
    Me.nPorcentaje1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.nPorcentaje1.DecimalPlaces = 1
    Me.nPorcentaje1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
    Me.nPorcentaje1.Location = New System.Drawing.Point(100, 66)
    Me.nPorcentaje1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
    Me.nPorcentaje1.Name = "nPorcentaje1"
    Me.nPorcentaje1.Size = New System.Drawing.Size(81, 21)
    Me.nPorcentaje1.TabIndex = 57
    Me.nPorcentaje1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'frmLiquidacionVendedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.dtTo)
    Me.Controls.Add(Me.dtFrom)
    Me.Controls.Add(Me.lblTitulo)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnLiquidar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblFecha)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmLiquidacionVendedores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmLiquidacionVendedores"
    CType(Me.chkEnable, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nPorcentaje1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnLiquidar As System.Windows.Forms.Button
  Friend WithEvents bsVendedores As System.Windows.Forms.BindingSource
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents chkEnable As System.Windows.Forms.PictureBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
  Friend WithEvents chkZona As System.Windows.Forms.CheckBox
  Friend WithEvents chkAguinaldo As System.Windows.Forms.CheckBox
  Friend WithEvents chkVendedores As System.Windows.Forms.CheckBox
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtVale As System.Windows.Forms.TextBox
  Friend WithEvents lblAdelantos As System.Windows.Forms.Label
  Friend WithEvents lblTitulo As System.Windows.Forms.Label
  Friend WithEvents chkCarpetaProb As System.Windows.Forms.CheckBox
  Friend WithEvents chkPremio80Vent As System.Windows.Forms.CheckBox
  Friend WithEvents chk90 As System.Windows.Forms.CheckBox
  Friend WithEvents chk70 As System.Windows.Forms.CheckBox
  Friend WithEvents chk50 As System.Windows.Forms.CheckBox
  Friend WithEvents chk110 As System.Windows.Forms.CheckBox
  Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
  Friend WithEvents nPorcentaje1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents chkEnablePorcentaje1 As System.Windows.Forms.CheckBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
