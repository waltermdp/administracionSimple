<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnSelectClient = New System.Windows.Forms.Button()
    Me.btnNewClient = New System.Windows.Forms.Button()
    Me.btnSelectVendedor = New System.Windows.Forms.Button()
    Me.txtNombreCliente = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtDNICliente = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtDNIVendedor = New System.Windows.Forms.TextBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.gpVenta = New System.Windows.Forms.GroupBox()
    Me.lvPlanPagos = New System.Windows.Forms.ListView()
    Me.cNCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cFechaCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cValorCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cFechaPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblCuota = New System.Windows.Forms.Label()
    Me.lblTotalCuotas = New System.Windows.Forms.Label()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblMedioDePago = New System.Windows.Forms.Label()
    Me.lblNumeroVenta = New System.Windows.Forms.Label()
    Me.lblFechaVenta = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.btnPagos = New System.Windows.Forms.Button()
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.cArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cEntregados = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cGuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.btnEditarArticulosVendidos = New System.Windows.Forms.Button()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.lblTitulo = New System.Windows.Forms.Label()
    Me.gpVenta.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(538, 154)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 15)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Precio"
    '
    'btnSave
    '
    Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSave.FlatAppearance.BorderSize = 0
    Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSave.ForeColor = System.Drawing.Color.White
    Me.btnSave.Location = New System.Drawing.Point(12, 49)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(110, 61)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "Guardar"
    Me.btnSave.UseVisualStyleBackColor = False
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
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(538, 185)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(126, 15)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Numero de Cuotas"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(536, 67)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(120, 19)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "FechaVenta"
    '
    'btnSelectClient
    '
    Me.btnSelectClient.BackColor = System.Drawing.Color.White
    Me.btnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSelectClient.FlatAppearance.BorderSize = 2
    Me.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSelectClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSelectClient.Location = New System.Drawing.Point(23, 26)
    Me.btnSelectClient.Name = "btnSelectClient"
    Me.btnSelectClient.Size = New System.Drawing.Size(96, 31)
    Me.btnSelectClient.TabIndex = 21
    Me.btnSelectClient.Text = "Seleccionar"
    Me.btnSelectClient.UseVisualStyleBackColor = False
    '
    'btnNewClient
    '
    Me.btnNewClient.BackColor = System.Drawing.Color.White
    Me.btnNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnNewClient.FlatAppearance.BorderSize = 2
    Me.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnNewClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNewClient.Location = New System.Drawing.Point(23, 69)
    Me.btnNewClient.Name = "btnNewClient"
    Me.btnNewClient.Size = New System.Drawing.Size(96, 31)
    Me.btnNewClient.TabIndex = 22
    Me.btnNewClient.Text = "Nuevo"
    Me.btnNewClient.UseVisualStyleBackColor = False
    '
    'btnSelectVendedor
    '
    Me.btnSelectVendedor.BackColor = System.Drawing.Color.White
    Me.btnSelectVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSelectVendedor.FlatAppearance.BorderSize = 2
    Me.btnSelectVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSelectVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSelectVendedor.Location = New System.Drawing.Point(17, 26)
    Me.btnSelectVendedor.Name = "btnSelectVendedor"
    Me.btnSelectVendedor.Size = New System.Drawing.Size(108, 31)
    Me.btnSelectVendedor.TabIndex = 23
    Me.btnSelectVendedor.Text = "Seleccionar"
    Me.btnSelectVendedor.UseVisualStyleBackColor = False
    '
    'txtNombreCliente
    '
    Me.txtNombreCliente.BackColor = System.Drawing.SystemColors.Control
    Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreCliente.Location = New System.Drawing.Point(227, 36)
    Me.txtNombreCliente.Name = "txtNombreCliente"
    Me.txtNombreCliente.ReadOnly = True
    Me.txtNombreCliente.Size = New System.Drawing.Size(273, 21)
    Me.txtNombreCliente.TabIndex = 24
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.BackColor = System.Drawing.Color.White
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(224, 17)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(52, 15)
    Me.Label8.TabIndex = 25
    Me.Label8.Text = "Nombre"
    '
    'txtDNICliente
    '
    Me.txtDNICliente.BackColor = System.Drawing.SystemColors.Control
    Me.txtDNICliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDNICliente.Location = New System.Drawing.Point(227, 79)
    Me.txtDNICliente.Name = "txtDNICliente"
    Me.txtDNICliente.ReadOnly = True
    Me.txtDNICliente.Size = New System.Drawing.Size(273, 21)
    Me.txtDNICliente.TabIndex = 26
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.BackColor = System.Drawing.Color.White
    Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(224, 60)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(28, 15)
    Me.Label9.TabIndex = 27
    Me.Label9.Text = "DNI"
    '
    'txtNombreVendedor
    '
    Me.txtNombreVendedor.BackColor = System.Drawing.SystemColors.Control
    Me.txtNombreVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreVendedor.Location = New System.Drawing.Point(185, 36)
    Me.txtNombreVendedor.Name = "txtNombreVendedor"
    Me.txtNombreVendedor.ReadOnly = True
    Me.txtNombreVendedor.Size = New System.Drawing.Size(281, 21)
    Me.txtNombreVendedor.TabIndex = 28
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.BackColor = System.Drawing.Color.White
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(182, 18)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(52, 15)
    Me.Label10.TabIndex = 29
    Me.Label10.Text = "Nombre"
    '
    'txtDNIVendedor
    '
    Me.txtDNIVendedor.BackColor = System.Drawing.SystemColors.Control
    Me.txtDNIVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDNIVendedor.Location = New System.Drawing.Point(185, 80)
    Me.txtDNIVendedor.Name = "txtDNIVendedor"
    Me.txtDNIVendedor.ReadOnly = True
    Me.txtDNIVendedor.Size = New System.Drawing.Size(281, 21)
    Me.txtDNIVendedor.TabIndex = 30
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.BackColor = System.Drawing.Color.White
    Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(182, 60)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(28, 15)
    Me.Label11.TabIndex = 32
    Me.Label11.Text = "DNI"
    '
    'gpVenta
    '
    Me.gpVenta.BackColor = System.Drawing.Color.White
    Me.gpVenta.Controls.Add(Me.lvPlanPagos)
    Me.gpVenta.Controls.Add(Me.Label5)
    Me.gpVenta.Controls.Add(Me.Label3)
    Me.gpVenta.Controls.Add(Me.lblCuota)
    Me.gpVenta.Controls.Add(Me.lblTotalCuotas)
    Me.gpVenta.Controls.Add(Me.lblTotal)
    Me.gpVenta.Controls.Add(Me.lblMedioDePago)
    Me.gpVenta.Controls.Add(Me.lblNumeroVenta)
    Me.gpVenta.Controls.Add(Me.lblFechaVenta)
    Me.gpVenta.Controls.Add(Me.Label6)
    Me.gpVenta.Controls.Add(Me.btnPagos)
    Me.gpVenta.Controls.Add(Me.ListView1)
    Me.gpVenta.Controls.Add(Me.btnEditarArticulosVendidos)
    Me.gpVenta.Controls.Add(Me.Label16)
    Me.gpVenta.Controls.Add(Me.Label15)
    Me.gpVenta.Controls.Add(Me.lblValorCuota)
    Me.gpVenta.Controls.Add(Me.Label13)
    Me.gpVenta.Controls.Add(Me.Label12)
    Me.gpVenta.Controls.Add(Me.Label2)
    Me.gpVenta.Controls.Add(Me.Label1)
    Me.gpVenta.Controls.Add(Me.Label4)
    Me.gpVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpVenta.Location = New System.Drawing.Point(170, 196)
    Me.gpVenta.Name = "gpVenta"
    Me.gpVenta.Size = New System.Drawing.Size(1098, 512)
    Me.gpVenta.TabIndex = 33
    Me.gpVenta.TabStop = False
    Me.gpVenta.Text = "3- Venta"
    '
    'lvPlanPagos
    '
    Me.lvPlanPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cNCuota, Me.cFechaCuota, Me.cValorCuota, Me.cFechaPago, Me.cEstado})
    Me.lvPlanPagos.Location = New System.Drawing.Point(541, 262)
    Me.lvPlanPagos.Name = "lvPlanPagos"
    Me.lvPlanPagos.Size = New System.Drawing.Size(529, 244)
    Me.lvPlanPagos.TabIndex = 68
    Me.lvPlanPagos.UseCompatibleStateImageBehavior = False
    Me.lvPlanPagos.View = System.Windows.Forms.View.Details
    '
    'cNCuota
    '
    Me.cNCuota.Text = "Cuota"
    '
    'cFechaCuota
    '
    Me.cFechaCuota.Text = "Debitar"
    Me.cFechaCuota.Width = 100
    '
    'cValorCuota
    '
    Me.cValorCuota.Text = "Valor cuota"
    Me.cValorCuota.Width = 92
    '
    'cFechaPago
    '
    Me.cFechaPago.Text = "Pagado"
    Me.cFechaPago.Width = 100
    '
    'cEstado
    '
    Me.cEstado.Text = "Estado"
    Me.cEstado.Width = 160
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(538, 244)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 15)
    Me.Label5.TabIndex = 66
    Me.Label5.Text = "Plan de Pagos"
    '
    'Label3
    '
    Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(719, 214)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(351, 19)
    Me.Label3.TabIndex = 64
    '
    'lblCuota
    '
    Me.lblCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuota.Location = New System.Drawing.Point(928, 185)
    Me.lblCuota.Name = "lblCuota"
    Me.lblCuota.Size = New System.Drawing.Size(142, 19)
    Me.lblCuota.TabIndex = 63
    '
    'lblTotalCuotas
    '
    Me.lblTotalCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblTotalCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalCuotas.Location = New System.Drawing.Point(665, 184)
    Me.lblTotalCuotas.Name = "lblTotalCuotas"
    Me.lblTotalCuotas.Size = New System.Drawing.Size(121, 19)
    Me.lblTotalCuotas.TabIndex = 62
    '
    'lblTotal
    '
    Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(665, 154)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(405, 19)
    Me.lblTotal.TabIndex = 61
    '
    'lblMedioDePago
    '
    Me.lblMedioDePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblMedioDePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMedioDePago.Location = New System.Drawing.Point(665, 126)
    Me.lblMedioDePago.Name = "lblMedioDePago"
    Me.lblMedioDePago.Size = New System.Drawing.Size(405, 19)
    Me.lblMedioDePago.TabIndex = 60
    '
    'lblNumeroVenta
    '
    Me.lblNumeroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblNumeroVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumeroVenta.Location = New System.Drawing.Point(665, 96)
    Me.lblNumeroVenta.Name = "lblNumeroVenta"
    Me.lblNumeroVenta.Size = New System.Drawing.Size(405, 19)
    Me.lblNumeroVenta.TabIndex = 59
    '
    'lblFechaVenta
    '
    Me.lblFechaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVenta.Location = New System.Drawing.Point(665, 67)
    Me.lblFechaVenta.Name = "lblFechaVenta"
    Me.lblFechaVenta.Size = New System.Drawing.Size(405, 19)
    Me.lblFechaVenta.TabIndex = 58
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(555, 27)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(136, 23)
    Me.Label6.TabIndex = 57
    Me.Label6.Text = "Forma de Pago"
    '
    'btnPagos
    '
    Me.btnPagos.BackColor = System.Drawing.Color.White
    Me.btnPagos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnPagos.FlatAppearance.BorderSize = 2
    Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPagos.Location = New System.Drawing.Point(719, 19)
    Me.btnPagos.Name = "btnPagos"
    Me.btnPagos.Size = New System.Drawing.Size(96, 31)
    Me.btnPagos.TabIndex = 56
    Me.btnPagos.Text = "Editar"
    Me.btnPagos.UseVisualStyleBackColor = False
    '
    'ListView1
    '
    Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cArticulos, Me.cCantidad, Me.cEntregados, Me.cGuid})
    Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListView1.FullRowSelect = True
    Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.ListView1.Location = New System.Drawing.Point(23, 57)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(477, 449)
    Me.ListView1.TabIndex = 55
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
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
    'btnEditarArticulosVendidos
    '
    Me.btnEditarArticulosVendidos.BackColor = System.Drawing.Color.White
    Me.btnEditarArticulosVendidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnEditarArticulosVendidos.FlatAppearance.BorderSize = 2
    Me.btnEditarArticulosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnEditarArticulosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditarArticulosVendidos.Location = New System.Drawing.Point(204, 19)
    Me.btnEditarArticulosVendidos.Name = "btnEditarArticulosVendidos"
    Me.btnEditarArticulosVendidos.Size = New System.Drawing.Size(96, 31)
    Me.btnEditarArticulosVendidos.TabIndex = 41
    Me.btnEditarArticulosVendidos.Text = "Editar"
    Me.btnEditarArticulosVendidos.UseVisualStyleBackColor = False
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(538, 96)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(95, 15)
    Me.Label16.TabIndex = 39
    Me.Label16.Text = "Num Contrato"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(538, 214)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(175, 15)
    Me.Label15.TabIndex = 36
    Me.Label15.Text = "Adelanto para el vendedor"
    '
    'lblValorCuota
    '
    Me.lblValorCuota.AutoSize = True
    Me.lblValorCuota.Location = New System.Drawing.Point(805, 185)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(117, 15)
    Me.lblValorCuota.TabIndex = 31
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(538, 126)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(106, 15)
    Me.Label13.TabIndex = 29
    Me.Label13.Text = "Medio De Pago"
    '
    'Label12
    '
    Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(12, 27)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(186, 23)
    Me.Label12.TabIndex = 19
    Me.Label12.Text = "Articulos Vendidos"
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Controls.Add(Me.txtDNICliente)
    Me.GroupBox1.Controls.Add(Me.btnSelectClient)
    Me.GroupBox1.Controls.Add(Me.btnNewClient)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(170, 78)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(535, 112)
    Me.GroupBox1.TabIndex = 34
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "1- Informacion Del Cliente"
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.White
    Me.GroupBox2.Controls.Add(Me.Label10)
    Me.GroupBox2.Controls.Add(Me.txtNombreVendedor)
    Me.GroupBox2.Controls.Add(Me.Label11)
    Me.GroupBox2.Controls.Add(Me.btnSelectVendedor)
    Me.GroupBox2.Controls.Add(Me.txtDNIVendedor)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(711, 78)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(557, 112)
    Me.GroupBox2.TabIndex = 35
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "2- Informacion del Vendedor"
    '
    'lblTitulo
    '
    Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
    Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitulo.Location = New System.Drawing.Point(222, 9)
    Me.lblTitulo.Name = "lblTitulo"
    Me.lblTitulo.Size = New System.Drawing.Size(853, 23)
    Me.lblTitulo.TabIndex = 61
    Me.lblTitulo.Text = "Venta"
    Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'frmVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.lblTitulo)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.gpVenta)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnSave)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmVenta"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmVenta"
    Me.gpVenta.ResumeLayout(False)
    Me.gpVenta.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnSelectClient As System.Windows.Forms.Button
  Friend WithEvents btnNewClient As System.Windows.Forms.Button
  Friend WithEvents btnSelectVendedor As System.Windows.Forms.Button
  Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtDNICliente As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtDNIVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents gpVenta As System.Windows.Forms.GroupBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents tTip As System.Windows.Forms.ToolTip
  Friend WithEvents btnEditarArticulosVendidos As System.Windows.Forms.Button
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents cArticulos As System.Windows.Forms.ColumnHeader
  Friend WithEvents cCantidad As System.Windows.Forms.ColumnHeader
  Friend WithEvents cEntregados As System.Windows.Forms.ColumnHeader
  Friend WithEvents cGuid As System.Windows.Forms.ColumnHeader
  Friend WithEvents lblTitulo As System.Windows.Forms.Label
  Friend WithEvents btnPagos As System.Windows.Forms.Button
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblCuota As System.Windows.Forms.Label
  Friend WithEvents lblTotalCuotas As System.Windows.Forms.Label
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents lblMedioDePago As System.Windows.Forms.Label
  Friend WithEvents lblNumeroVenta As System.Windows.Forms.Label
  Friend WithEvents lblFechaVenta As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents lvPlanPagos As System.Windows.Forms.ListView
  Friend WithEvents cNCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cFechaCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cValorCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cFechaPago As System.Windows.Forms.ColumnHeader
  Friend WithEvents cEstado As System.Windows.Forms.ColumnHeader
End Class
