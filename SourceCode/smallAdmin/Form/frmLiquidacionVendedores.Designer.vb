﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionVendedores))
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnLiquidar = New System.Windows.Forms.Button()
    Me.dtInicio = New System.Windows.Forms.DateTimePicker()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.pbxResumen = New System.Windows.Forms.PictureBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.chkAuto = New System.Windows.Forms.CheckBox()
    Me.chkZona = New System.Windows.Forms.CheckBox()
    Me.chkAguinaldo = New System.Windows.Forms.CheckBox()
    Me.chkVendedores = New System.Windows.Forms.CheckBox()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtVale = New System.Windows.Forms.TextBox()
    Me.bsVendedores = New System.Windows.Forms.BindingSource(Me.components)
    Me.lblAdelantos = New System.Windows.Forms.Label()
    CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.BackColor = System.Drawing.Color.White
    Me.lblFecha.Location = New System.Drawing.Point(193, 72)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(43, 13)
    Me.lblFecha.TabIndex = 0
    Me.lblFecha.Text = "Periodo"
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
    Me.btnLiquidar.Size = New System.Drawing.Size(110, 61)
    Me.btnLiquidar.TabIndex = 14
    Me.btnLiquidar.Text = "Liquidar"
    Me.btnLiquidar.UseVisualStyleBackColor = False
    '
    'dtInicio
    '
    Me.dtInicio.Location = New System.Drawing.Point(255, 66)
    Me.dtInicio.Name = "dtInicio"
    Me.dtInicio.ShowUpDown = True
    Me.dtInicio.Size = New System.Drawing.Size(200, 20)
    Me.dtInicio.TabIndex = 37
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(30, 556)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 61)
    Me.btnVolver.TabIndex = 39
    Me.btnVolver.Text = "Volver"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'pbxResumen
    '
    Me.pbxResumen.BackColor = System.Drawing.Color.White
    Me.pbxResumen.Location = New System.Drawing.Point(22, 26)
    Me.pbxResumen.Name = "pbxResumen"
    Me.pbxResumen.Size = New System.Drawing.Size(988, 537)
    Me.pbxResumen.TabIndex = 41
    Me.pbxResumen.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.BackColor = System.Drawing.Color.Silver
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel1.Controls.Add(Me.pbxResumen)
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
    Me.chkAuto.Size = New System.Drawing.Size(48, 17)
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
    Me.chkZona.Size = New System.Drawing.Size(51, 17)
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
    Me.chkAguinaldo.Size = New System.Drawing.Size(73, 17)
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
    Me.chkVendedores.Size = New System.Drawing.Size(83, 17)
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
    Me.btnImprimir.Size = New System.Drawing.Size(110, 61)
    Me.btnImprimir.TabIndex = 47
    Me.btnImprimir.Text = "Imprimir"
    Me.btnImprimir.UseVisualStyleBackColor = False
    Me.btnImprimir.Visible = False
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.lblAdelantos)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.txtVale)
    Me.GroupBox1.Controls.Add(Me.chkAuto)
    Me.GroupBox1.Controls.Add(Me.chkZona)
    Me.GroupBox1.Controls.Add(Me.chkVendedores)
    Me.GroupBox1.Controls.Add(Me.chkAguinaldo)
    Me.GroupBox1.Location = New System.Drawing.Point(196, 108)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(625, 66)
    Me.GroupBox1.TabIndex = 48
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Aplicar"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(241, 20)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(36, 13)
    Me.Label2.TabIndex = 48
    Me.Label2.Text = "Vales:"
    '
    'txtVale
    '
    Me.txtVale.Location = New System.Drawing.Point(283, 16)
    Me.txtVale.Name = "txtVale"
    Me.txtVale.Size = New System.Drawing.Size(127, 20)
    Me.txtVale.TabIndex = 47
    Me.txtVale.Text = "0"
    Me.txtVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'bsVendedores
    '
    Me.bsVendedores.DataSource = GetType(manDB.clsInfoVendedor)
    '
    'lblAdelantos
    '
    Me.lblAdelantos.AutoSize = True
    Me.lblAdelantos.Location = New System.Drawing.Point(241, 43)
    Me.lblAdelantos.Name = "lblAdelantos"
    Me.lblAdelantos.Size = New System.Drawing.Size(66, 13)
    Me.lblAdelantos.TabIndex = 49
    Me.lblAdelantos.Text = "Adelantos: 0"
    '
    'frmLiquidacionVendedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.dtInicio)
    Me.Controls.Add(Me.btnLiquidar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblFecha)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmLiquidacionVendedores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmLiquidacionVendedores"
    CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.bsVendedores, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnLiquidar As System.Windows.Forms.Button
  Friend WithEvents bsVendedores As System.Windows.Forms.BindingSource
  Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents pbxResumen As System.Windows.Forms.PictureBox
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
End Class
