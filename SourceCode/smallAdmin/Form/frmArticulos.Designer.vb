<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnVolver = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
    Me.dgvListArticulos = New System.Windows.Forms.DataGridView()
    Me.IdArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GuidArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbProducto = New System.Windows.Forms.GroupBox()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvListArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbProducto.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(9, 32)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(289, 20)
    Me.txtNombre.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Nombre"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 55)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Codigo"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(301, 16)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(63, 13)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Descripcion"
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(9, 71)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(289, 20)
    Me.txtCodigo.TabIndex = 4
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(304, 32)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(302, 59)
    Me.txtDescripcion.TabIndex = 5
    '
    'btnGuardar
    '
    Me.btnGuardar.Location = New System.Drawing.Point(48, 231)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
    Me.btnGuardar.TabIndex = 6
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = True
    '
    'btnEditar
    '
    Me.btnEditar.Location = New System.Drawing.Point(48, 84)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(75, 23)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = True
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(48, 113)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
    Me.btnEliminar.TabIndex = 8
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'btnVolver
    '
    Me.btnVolver.Location = New System.Drawing.Point(48, 166)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(75, 23)
    Me.btnVolver.TabIndex = 9
    Me.btnVolver.Text = "Atras"
    Me.btnVolver.UseVisualStyleBackColor = True
    '
    'btnNuevo
    '
    Me.btnNuevo.Location = New System.Drawing.Point(48, 55)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
    Me.btnNuevo.TabIndex = 11
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(48, 260)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 12
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'dgvListArticulos
    '
    Me.dgvListArticulos.AllowUserToAddRows = False
    Me.dgvListArticulos.AllowUserToDeleteRows = False
    Me.dgvListArticulos.AllowUserToResizeRows = False
    Me.dgvListArticulos.AutoGenerateColumns = False
    Me.dgvListArticulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvListArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvListArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvListArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvListArticulos.ColumnHeadersHeight = 24
    Me.dgvListArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvListArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticuloDataGridViewTextBoxColumn, Me.GuidArticuloDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
    Me.dgvListArticulos.DataSource = Me.bsArticulos
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvListArticulos.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvListArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvListArticulos.EnableHeadersVisualStyles = False
    Me.dgvListArticulos.GridColor = System.Drawing.Color.White
    Me.dgvListArticulos.Location = New System.Drawing.Point(191, 166)
    Me.dgvListArticulos.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvListArticulos.MultiSelect = False
    Me.dgvListArticulos.Name = "dgvListArticulos"
    Me.dgvListArticulos.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvListArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvListArticulos.RowHeadersVisible = False
    Me.dgvListArticulos.RowTemplate.Height = 24
    Me.dgvListArticulos.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvListArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvListArticulos.Size = New System.Drawing.Size(613, 285)
    Me.dgvListArticulos.TabIndex = 26
    Me.dgvListArticulos.TabStop = False
    '
    'IdArticuloDataGridViewTextBoxColumn
    '
    Me.IdArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo"
    Me.IdArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo"
    Me.IdArticuloDataGridViewTextBoxColumn.Name = "IdArticuloDataGridViewTextBoxColumn"
    Me.IdArticuloDataGridViewTextBoxColumn.ReadOnly = True
    '
    'GuidArticuloDataGridViewTextBoxColumn
    '
    Me.GuidArticuloDataGridViewTextBoxColumn.DataPropertyName = "GuidArticulo"
    Me.GuidArticuloDataGridViewTextBoxColumn.HeaderText = "GuidArticulo"
    Me.GuidArticuloDataGridViewTextBoxColumn.Name = "GuidArticuloDataGridViewTextBoxColumn"
    Me.GuidArticuloDataGridViewTextBoxColumn.ReadOnly = True
    '
    'NombreDataGridViewTextBoxColumn
    '
    Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
    Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CodigoDataGridViewTextBoxColumn
    '
    Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
    Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'DescripcionDataGridViewTextBoxColumn
    '
    Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
    Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
    '
    'gbProducto
    '
    Me.gbProducto.Controls.Add(Me.Label1)
    Me.gbProducto.Controls.Add(Me.txtNombre)
    Me.gbProducto.Controls.Add(Me.Label2)
    Me.gbProducto.Controls.Add(Me.Label3)
    Me.gbProducto.Controls.Add(Me.txtCodigo)
    Me.gbProducto.Controls.Add(Me.txtDescripcion)
    Me.gbProducto.Location = New System.Drawing.Point(191, 55)
    Me.gbProducto.Name = "gbProducto"
    Me.gbProducto.Size = New System.Drawing.Size(613, 108)
    Me.gbProducto.TabIndex = 27
    Me.gbProducto.TabStop = False
    Me.gbProducto.Text = "Info Producto"
    '
    'frmArticulos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.gbProducto)
    Me.Controls.Add(Me.dgvListArticulos)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnGuardar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmArticulos"
    Me.Text = "frmArticulos"
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvListArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbProducto.ResumeLayout(False)
    Me.gbProducto.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnVolver As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
  Public WithEvents dgvListArticulos As System.Windows.Forms.DataGridView
  Friend WithEvents IdArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GuidArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
End Class
