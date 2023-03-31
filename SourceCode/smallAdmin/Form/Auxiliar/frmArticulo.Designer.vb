<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulo
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
    Me.gbProducto = New System.Windows.Forms.GroupBox()
    Me.btnCopi2Code = New System.Windows.Forms.Button()
    Me.btnCopi2Bar = New System.Windows.Forms.Button()
    Me.gbAvanzadas = New System.Windows.Forms.GroupBox()
    Me.nCantidad = New System.Windows.Forms.NumericUpDown()
    Me.lblCantidad = New System.Windows.Forms.Label()
    Me.cmbResponsable = New System.Windows.Forms.ComboBox()
    Me.lblResponsable = New System.Windows.Forms.Label()
    Me.chkAvanzadas = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.btnLimpiarCampos = New System.Windows.Forms.Button()
    Me.gbProducto.SuspendLayout()
    Me.gbAvanzadas.SuspendLayout()
    CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbProducto
    '
    Me.gbProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.gbProducto.Controls.Add(Me.btnCopi2Code)
    Me.gbProducto.Controls.Add(Me.btnCopi2Bar)
    Me.gbProducto.Controls.Add(Me.gbAvanzadas)
    Me.gbProducto.Controls.Add(Me.chkAvanzadas)
    Me.gbProducto.Controls.Add(Me.Label4)
    Me.gbProducto.Controls.Add(Me.txtCodigoBarras)
    Me.gbProducto.Controls.Add(Me.Label10)
    Me.gbProducto.Controls.Add(Me.txtPrecio)
    Me.gbProducto.Controls.Add(Me.Label1)
    Me.gbProducto.Controls.Add(Me.txtNombre)
    Me.gbProducto.Controls.Add(Me.Label2)
    Me.gbProducto.Controls.Add(Me.Label3)
    Me.gbProducto.Controls.Add(Me.txtCodigo)
    Me.gbProducto.Controls.Add(Me.txtDescripcion)
    Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbProducto.Location = New System.Drawing.Point(135, 32)
    Me.gbProducto.Name = "gbProducto"
    Me.gbProducto.Size = New System.Drawing.Size(898, 494)
    Me.gbProducto.TabIndex = 28
    Me.gbProducto.TabStop = False
    Me.gbProducto.Text = "Informacion del Articulo"
    '
    'btnCopi2Code
    '
    Me.btnCopi2Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCopi2Code.Location = New System.Drawing.Point(473, 133)
    Me.btnCopi2Code.Name = "btnCopi2Code"
    Me.btnCopi2Code.Size = New System.Drawing.Size(212, 23)
    Me.btnCopi2Code.TabIndex = 16
    Me.btnCopi2Code.Text = "Copiar a Codigo Interno"
    Me.btnCopi2Code.UseVisualStyleBackColor = True
    '
    'btnCopi2Bar
    '
    Me.btnCopi2Bar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCopi2Bar.Location = New System.Drawing.Point(473, 86)
    Me.btnCopi2Bar.Name = "btnCopi2Bar"
    Me.btnCopi2Bar.Size = New System.Drawing.Size(212, 24)
    Me.btnCopi2Bar.TabIndex = 15
    Me.btnCopi2Bar.Text = "Copiar a Codigo de Barras"
    Me.btnCopi2Bar.UseVisualStyleBackColor = True
    '
    'gbAvanzadas
    '
    Me.gbAvanzadas.Controls.Add(Me.nCantidad)
    Me.gbAvanzadas.Controls.Add(Me.lblCantidad)
    Me.gbAvanzadas.Controls.Add(Me.cmbResponsable)
    Me.gbAvanzadas.Controls.Add(Me.lblResponsable)
    Me.gbAvanzadas.Location = New System.Drawing.Point(30, 390)
    Me.gbAvanzadas.Name = "gbAvanzadas"
    Me.gbAvanzadas.Size = New System.Drawing.Size(846, 98)
    Me.gbAvanzadas.TabIndex = 14
    Me.gbAvanzadas.TabStop = False
    '
    'nCantidad
    '
    Me.nCantidad.Location = New System.Drawing.Point(570, 18)
    Me.nCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
    Me.nCantidad.Name = "nCantidad"
    Me.nCantidad.Size = New System.Drawing.Size(54, 24)
    Me.nCantidad.TabIndex = 3
    '
    'lblCantidad
    '
    Me.lblCantidad.Location = New System.Drawing.Point(453, 20)
    Me.lblCantidad.Name = "lblCantidad"
    Me.lblCantidad.Size = New System.Drawing.Size(111, 23)
    Me.lblCantidad.TabIndex = 2
    Me.lblCantidad.Text = "Cantidad:"
    '
    'cmbResponsable
    '
    Me.cmbResponsable.FormattingEnabled = True
    Me.cmbResponsable.Location = New System.Drawing.Point(120, 17)
    Me.cmbResponsable.Name = "cmbResponsable"
    Me.cmbResponsable.Size = New System.Drawing.Size(317, 26)
    Me.cmbResponsable.TabIndex = 1
    '
    'lblResponsable
    '
    Me.lblResponsable.Location = New System.Drawing.Point(6, 20)
    Me.lblResponsable.Name = "lblResponsable"
    Me.lblResponsable.Size = New System.Drawing.Size(121, 20)
    Me.lblResponsable.TabIndex = 0
    Me.lblResponsable.Text = "Responsable"
    '
    'chkAvanzadas
    '
    Me.chkAvanzadas.AutoSize = True
    Me.chkAvanzadas.Location = New System.Drawing.Point(30, 362)
    Me.chkAvanzadas.Name = "chkAvanzadas"
    Me.chkAvanzadas.Size = New System.Drawing.Size(99, 22)
    Me.chkAvanzadas.TabIndex = 13
    Me.chkAvanzadas.Text = "Avanzadas"
    Me.chkAvanzadas.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(27, 113)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(95, 16)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Codigo Barras"
    '
    'txtCodigoBarras
    '
    Me.txtCodigoBarras.BackColor = System.Drawing.Color.White
    Me.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodigoBarras.Location = New System.Drawing.Point(30, 132)
    Me.txtCodigoBarras.Name = "txtCodigoBarras"
    Me.txtCodigoBarras.Size = New System.Drawing.Size(437, 24)
    Me.txtCodigoBarras.TabIndex = 11
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(27, 159)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(47, 16)
    Me.Label10.TabIndex = 6
    Me.Label10.Text = "Precio"
    '
    'txtPrecio
    '
    Me.txtPrecio.BackColor = System.Drawing.Color.White
    Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPrecio.Location = New System.Drawing.Point(30, 178)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(217, 24)
    Me.txtPrecio.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(27, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(57, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Nombre"
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.Color.White
    Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombre.Location = New System.Drawing.Point(30, 41)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(437, 24)
    Me.txtNombre.TabIndex = 0
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(27, 70)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(164, 16)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Codigo Interno del Articulo"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(27, 217)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(80, 16)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Descripcion"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.Color.White
    Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodigo.Location = New System.Drawing.Point(30, 86)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(437, 24)
    Me.txtCodigo.TabIndex = 4
    '
    'txtDescripcion
    '
    Me.txtDescripcion.BackColor = System.Drawing.Color.White
    Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDescripcion.Location = New System.Drawing.Point(30, 236)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(846, 120)
    Me.txtDescripcion.TabIndex = 5
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(471, 9)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(98, 20)
    Me.Label5.TabIndex = 29
    Me.Label5.Text = "ARTICULO"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(12, 459)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 61)
    Me.btnCancelar.TabIndex = 31
    Me.btnCancelar.Text = "Salir"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(12, 32)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 61)
    Me.btnGuardar.TabIndex = 30
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'btnLimpiarCampos
    '
    Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnLimpiarCampos.FlatAppearance.BorderSize = 0
    Me.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnLimpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.White
    Me.btnLimpiarCampos.Location = New System.Drawing.Point(12, 100)
    Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
    Me.btnLimpiarCampos.Size = New System.Drawing.Size(110, 61)
    Me.btnLimpiarCampos.TabIndex = 32
    Me.btnLimpiarCampos.Text = "Limpiar Campos"
    Me.btnLimpiarCampos.UseVisualStyleBackColor = False
    '
    'frmArticulo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Silver
    Me.ClientSize = New System.Drawing.Size(1051, 538)
    Me.Controls.Add(Me.btnLimpiarCampos)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.gbProducto)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmArticulo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmArticulo"
    Me.gbProducto.ResumeLayout(False)
    Me.gbProducto.PerformLayout()
    Me.gbAvanzadas.ResumeLayout(False)
    CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents gbAvanzadas As System.Windows.Forms.GroupBox
  Friend WithEvents nCantidad As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblCantidad As System.Windows.Forms.Label
  Friend WithEvents cmbResponsable As System.Windows.Forms.ComboBox
  Friend WithEvents lblResponsable As System.Windows.Forms.Label
  Friend WithEvents chkAvanzadas As System.Windows.Forms.CheckBox
  Friend WithEvents btnCopi2Code As System.Windows.Forms.Button
  Friend WithEvents btnCopi2Bar As System.Windows.Forms.Button
  Friend WithEvents btnLimpiarCampos As System.Windows.Forms.Button
End Class
