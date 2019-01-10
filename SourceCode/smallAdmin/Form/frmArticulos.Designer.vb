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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
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
    Me.gbProducto = New System.Windows.Forms.GroupBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.rbtnResponsables = New System.Windows.Forms.RadioButton()
    Me.rbtnByStock = New System.Windows.Forms.RadioButton()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.dgvStock = New System.Windows.Forms.DataGridView()
    Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnAddDeposito = New System.Windows.Forms.Button()
    Me.btnRemDeposito = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.cmbResponsables = New System.Windows.Forms.ComboBox()
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbProducto.SuspendLayout()
    CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombre.Location = New System.Drawing.Point(30, 41)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(337, 22)
    Me.txtNombre.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(27, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(57, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Nombre"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(27, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(52, 16)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Codigo"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(473, 25)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(80, 16)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Descripcion"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodigo.Location = New System.Drawing.Point(30, 80)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(337, 22)
    Me.txtCodigo.TabIndex = 4
    '
    'txtDescripcion
    '
    Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDescripcion.Location = New System.Drawing.Point(476, 41)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(523, 61)
    Me.txtDescripcion.TabIndex = 5
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(24, 51)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 61)
    Me.btnGuardar.TabIndex = 6
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditar.FlatAppearance.BorderSize = 0
    Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ForeColor = System.Drawing.Color.White
    Me.btnEditar.Location = New System.Drawing.Point(24, 126)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 61)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "Editar"
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEliminar.FlatAppearance.BorderSize = 0
    Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.ForeColor = System.Drawing.Color.White
    Me.btnEliminar.Location = New System.Drawing.Point(24, 202)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(110, 61)
    Me.btnEliminar.TabIndex = 8
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'btnVolver
    '
    Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnVolver.FlatAppearance.BorderSize = 0
    Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVolver.ForeColor = System.Drawing.Color.White
    Me.btnVolver.Location = New System.Drawing.Point(24, 636)
    Me.btnVolver.Name = "btnVolver"
    Me.btnVolver.Size = New System.Drawing.Size(110, 61)
    Me.btnVolver.TabIndex = 9
    Me.btnVolver.Text = "Atras"
    Me.btnVolver.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNuevo.FlatAppearance.BorderSize = 0
    Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ForeColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(24, 51)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 61)
    Me.btnNuevo.TabIndex = 11
    Me.btnNuevo.Text = "Nuevo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(24, 126)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 61)
    Me.btnCancelar.TabIndex = 12
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'bsArticulos
    '
    Me.bsArticulos.DataSource = GetType(manDB.clsInfoArticulos)
    '
    'gbProducto
    '
    Me.gbProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.gbProducto.Controls.Add(Me.Label1)
    Me.gbProducto.Controls.Add(Me.txtNombre)
    Me.gbProducto.Controls.Add(Me.Label2)
    Me.gbProducto.Controls.Add(Me.Label3)
    Me.gbProducto.Controls.Add(Me.txtCodigo)
    Me.gbProducto.Controls.Add(Me.txtDescripcion)
    Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbProducto.Location = New System.Drawing.Point(200, 62)
    Me.gbProducto.Name = "gbProducto"
    Me.gbProducto.Size = New System.Drawing.Size(1038, 125)
    Me.gbProducto.TabIndex = 27
    Me.gbProducto.TabStop = False
    Me.gbProducto.Text = "Informacion del Articulo"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(550, 9)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(195, 20)
    Me.Label4.TabIndex = 28
    Me.Label4.Text = "LISTA DE ARTICULOS"
    '
    'rbtnResponsables
    '
    Me.rbtnResponsables.AutoSize = True
    Me.rbtnResponsables.Location = New System.Drawing.Point(269, 210)
    Me.rbtnResponsables.Name = "rbtnResponsables"
    Me.rbtnResponsables.Size = New System.Drawing.Size(92, 17)
    Me.rbtnResponsables.TabIndex = 29
    Me.rbtnResponsables.Text = "Responsables"
    Me.rbtnResponsables.UseVisualStyleBackColor = True
    '
    'rbtnByStock
    '
    Me.rbtnByStock.AutoSize = True
    Me.rbtnByStock.Checked = True
    Me.rbtnByStock.Location = New System.Drawing.Point(200, 210)
    Me.rbtnByStock.Name = "rbtnByStock"
    Me.rbtnByStock.Size = New System.Drawing.Size(51, 17)
    Me.rbtnByStock.TabIndex = 30
    Me.rbtnByStock.TabStop = True
    Me.rbtnByStock.Text = "stock"
    Me.rbtnByStock.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(1051, 212)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(187, 20)
    Me.TextBox1.TabIndex = 31
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(890, 214)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(39, 13)
    Me.Label5.TabIndex = 32
    Me.Label5.Text = "Label5"
    '
    'dgvStock
    '
    Me.dgvStock.AllowUserToAddRows = False
    Me.dgvStock.AllowUserToDeleteRows = False
    Me.dgvStock.AllowUserToResizeRows = False
    Me.dgvStock.AutoGenerateColumns = False
    Me.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    Me.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvStock.ColumnHeadersHeight = 24
    Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn1, Me.CodigoDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.ResponsableDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
    Me.dgvStock.DataSource = Me.BindingSource1
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dgvStock.EnableHeadersVisualStyles = False
    Me.dgvStock.GridColor = System.Drawing.Color.White
    Me.dgvStock.Location = New System.Drawing.Point(200, 246)
    Me.dgvStock.Margin = New System.Windows.Forms.Padding(0)
    Me.dgvStock.MultiSelect = False
    Me.dgvStock.Name = "dgvStock"
    Me.dgvStock.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvStock.RowHeadersVisible = False
    Me.dgvStock.RowTemplate.Height = 24
    Me.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.None
    Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvStock.Size = New System.Drawing.Size(497, 343)
    Me.dgvStock.TabIndex = 33
    Me.dgvStock.TabStop = False
    '
    'NombreDataGridViewTextBoxColumn1
    '
    Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
    Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
    Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
    Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'CodigoDataGridViewTextBoxColumn1
    '
    Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
    Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
    Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DescripcionDataGridViewTextBoxColumn1
    '
    Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion"
    Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
    Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
    '
    'ResponsableDataGridViewTextBoxColumn
    '
    Me.ResponsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable"
    Me.ResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable"
    Me.ResponsableDataGridViewTextBoxColumn.Name = "ResponsableDataGridViewTextBoxColumn"
    Me.ResponsableDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CantidadDataGridViewTextBoxColumn
    '
    Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
    Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
    Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
    Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
    '
    'BindingSource1
    '
    Me.BindingSource1.DataSource = GetType(main.clsListaStorage)
    '
    'btnAddDeposito
    '
    Me.btnAddDeposito.Location = New System.Drawing.Point(727, 293)
    Me.btnAddDeposito.Name = "btnAddDeposito"
    Me.btnAddDeposito.Size = New System.Drawing.Size(26, 23)
    Me.btnAddDeposito.TabIndex = 34
    Me.btnAddDeposito.Text = "+"
    Me.btnAddDeposito.UseVisualStyleBackColor = True
    '
    'btnRemDeposito
    '
    Me.btnRemDeposito.Location = New System.Drawing.Point(727, 322)
    Me.btnRemDeposito.Name = "btnRemDeposito"
    Me.btnRemDeposito.Size = New System.Drawing.Size(26, 23)
    Me.btnRemDeposito.TabIndex = 35
    Me.btnRemDeposito.Text = "-"
    Me.btnRemDeposito.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(727, 374)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(69, 23)
    Me.Button1.TabIndex = 37
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'cmbResponsables
    '
    Me.cmbResponsables.FormattingEnabled = True
    Me.cmbResponsables.Location = New System.Drawing.Point(893, 295)
    Me.cmbResponsables.Name = "cmbResponsables"
    Me.cmbResponsables.Size = New System.Drawing.Size(121, 21)
    Me.cmbResponsables.TabIndex = 38
    '
    'frmArticulos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.Controls.Add(Me.cmbResponsables)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.btnRemDeposito)
    Me.Controls.Add(Me.btnAddDeposito)
    Me.Controls.Add(Me.dgvStock)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.rbtnByStock)
    Me.Controls.Add(Me.rbtnResponsables)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.gbProducto)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnVolver)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btnGuardar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmArticulos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmArticulos"
    CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbProducto.ResumeLayout(False)
    Me.gbProducto.PerformLayout()
    CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

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
  Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents rbtnResponsables As System.Windows.Forms.RadioButton
  Friend WithEvents rbtnByStock As System.Windows.Forms.RadioButton
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Public WithEvents dgvStock As System.Windows.Forms.DataGridView
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ResponsableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnAddDeposito As System.Windows.Forms.Button
  Friend WithEvents btnRemDeposito As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents cmbResponsables As System.Windows.Forms.ComboBox
End Class
