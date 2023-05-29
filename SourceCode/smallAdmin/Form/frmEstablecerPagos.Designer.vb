<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstablecerPagos
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNumVenta = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.txtAdelantoVendedor = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtAdelanto = New System.Windows.Forms.TextBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.lblValorCuota = New System.Windows.Forms.Label()
    Me.txtValorCuota = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtMedioPagoDescripcion = New System.Windows.Forms.TextBox()
    Me.btnSeleccionarCuenta = New System.Windows.Forms.Button()
    Me.btnAddCuenta = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtPrecio = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DateVenta = New System.Windows.Forms.DateTimePicker()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmbCuotas = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkEditarCuotas = New System.Windows.Forms.CheckBox()
    Me.dtProximoPago = New System.Windows.Forms.DateTimePicker()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.lvPlanPagos = New System.Windows.Forms.ListView()
    Me.cNCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cFechaCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cValorCuota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cFechaPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.cEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.btnGuardar = New System.Windows.Forms.Button()
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
    Me.btnCancel.TabIndex = 10
    Me.btnCancel.Text = "Cancelar"
    Me.btnCancel.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(1280, 25)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "CONTRATOS: EDICION"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtNumVenta
    '
    Me.txtNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNumVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumVenta.Location = New System.Drawing.Point(339, 42)
    Me.txtNumVenta.Name = "txtNumVenta"
    Me.txtNumVenta.Size = New System.Drawing.Size(273, 21)
    Me.txtNumVenta.TabIndex = 63
    Me.txtNumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.Location = New System.Drawing.Point(336, 24)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(102, 13)
    Me.Label16.TabIndex = 62
    Me.Label16.Text = "Numero de Contrato"
    '
    'txtAdelantoVendedor
    '
    Me.txtAdelantoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelantoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelantoVendedor.Location = New System.Drawing.Point(434, 224)
    Me.txtAdelantoVendedor.Name = "txtAdelantoVendedor"
    Me.txtAdelantoVendedor.Size = New System.Drawing.Size(99, 21)
    Me.txtAdelantoVendedor.TabIndex = 60
    Me.txtAdelantoVendedor.Text = "0"
    Me.txtAdelantoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.BackColor = System.Drawing.Color.Transparent
    Me.Label15.Location = New System.Drawing.Point(431, 203)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(132, 13)
    Me.Label15.TabIndex = 59
    Me.Label15.Text = "Adelanto para el vendedor"
    '
    'txtAdelanto
    '
    Me.txtAdelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdelanto.Location = New System.Drawing.Point(109, 224)
    Me.txtAdelanto.Name = "txtAdelanto"
    Me.txtAdelanto.Size = New System.Drawing.Size(123, 21)
    Me.txtAdelanto.TabIndex = 58
    Me.txtAdelanto.Text = "0"
    Me.txtAdelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.BackColor = System.Drawing.Color.Transparent
    Me.Label14.Location = New System.Drawing.Point(104, 203)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(238, 13)
    Me.Label14.TabIndex = 57
    Me.Label14.Text = "Adelanto de cuota, se aplica el valor en efectivo."
    '
    'lblValorCuota
    '
    Me.lblValorCuota.AutoSize = True
    Me.lblValorCuota.BackColor = System.Drawing.Color.Transparent
    Me.lblValorCuota.Location = New System.Drawing.Point(113, 151)
    Me.lblValorCuota.Name = "lblValorCuota"
    Me.lblValorCuota.Size = New System.Drawing.Size(88, 13)
    Me.lblValorCuota.TabIndex = 55
    Me.lblValorCuota.Text = "Valor de la Cuota"
    '
    'txtValorCuota
    '
    Me.txtValorCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtValorCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValorCuota.Location = New System.Drawing.Point(108, 166)
    Me.txtValorCuota.Name = "txtValorCuota"
    Me.txtValorCuota.Size = New System.Drawing.Size(122, 21)
    Me.txtValorCuota.TabIndex = 54
    Me.txtValorCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Location = New System.Drawing.Point(348, 85)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(81, 13)
    Me.Label13.TabIndex = 53
    Me.Label13.Text = "Medio De Pago"
    '
    'txtMedioPagoDescripcion
    '
    Me.txtMedioPagoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMedioPagoDescripcion.Location = New System.Drawing.Point(351, 101)
    Me.txtMedioPagoDescripcion.Name = "txtMedioPagoDescripcion"
    Me.txtMedioPagoDescripcion.ReadOnly = True
    Me.txtMedioPagoDescripcion.Size = New System.Drawing.Size(273, 21)
    Me.txtMedioPagoDescripcion.TabIndex = 52
    '
    'btnSeleccionarCuenta
    '
    Me.btnSeleccionarCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnSeleccionarCuenta.FlatAppearance.BorderSize = 2
    Me.btnSeleccionarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionarCuenta.ForeColor = System.Drawing.Color.White
    Me.btnSeleccionarCuenta.Location = New System.Drawing.Point(229, 88)
    Me.btnSeleccionarCuenta.Name = "btnSeleccionarCuenta"
    Me.btnSeleccionarCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnSeleccionarCuenta.TabIndex = 51
    Me.btnSeleccionarCuenta.Text = "Seleccionar"
    Me.btnSeleccionarCuenta.UseVisualStyleBackColor = False
    '
    'btnAddCuenta
    '
    Me.btnAddCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAddCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAddCuenta.FlatAppearance.BorderSize = 2
    Me.btnAddCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAddCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAddCuenta.ForeColor = System.Drawing.Color.White
    Me.btnAddCuenta.Location = New System.Drawing.Point(109, 88)
    Me.btnAddCuenta.Name = "btnAddCuenta"
    Me.btnAddCuenta.Size = New System.Drawing.Size(113, 46)
    Me.btnAddCuenta.TabIndex = 50
    Me.btnAddCuenta.Text = "Nuevo"
    Me.btnAddCuenta.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(105, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 47
    Me.Label2.Text = "FechaVenta"
    '
    'txtPrecio
    '
    Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPrecio.Location = New System.Drawing.Point(363, 165)
    Me.txtPrecio.Name = "txtPrecio"
    Me.txtPrecio.Size = New System.Drawing.Size(100, 21)
    Me.txtPrecio.TabIndex = 41
    Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(364, 146)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(37, 13)
    Me.Label3.TabIndex = 42
    Me.Label3.Text = "Precio"
    '
    'DateVenta
    '
    Me.DateVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateVenta.Location = New System.Drawing.Point(106, 42)
    Me.DateVenta.Name = "DateVenta"
    Me.DateVenta.Size = New System.Drawing.Size(227, 21)
    Me.DateVenta.TabIndex = 43
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(104, 70)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(70, 13)
    Me.Label4.TabIndex = 44
    Me.Label4.Text = "Tipo de pago"
    '
    'cmbCuotas
    '
    Me.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmbCuotas.FormattingEnabled = True
    Me.cmbCuotas.Location = New System.Drawing.Point(236, 164)
    Me.cmbCuotas.Name = "cmbCuotas"
    Me.cmbCuotas.Size = New System.Drawing.Size(121, 23)
    Me.cmbCuotas.TabIndex = 45
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Location = New System.Drawing.Point(233, 146)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(95, 13)
    Me.Label5.TabIndex = 46
    Me.Label5.Text = "Numero de Cuotas"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Location = New System.Drawing.Point(580, 170)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(105, 13)
    Me.Label6.TabIndex = 48
    Me.Label6.Text = "Fecha Proximo Pago"
    '
    'chkEditarCuotas
    '
    Me.chkEditarCuotas.AutoSize = True
    Me.chkEditarCuotas.BackColor = System.Drawing.Color.Transparent
    Me.chkEditarCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkEditarCuotas.Location = New System.Drawing.Point(467, 165)
    Me.chkEditarCuotas.Name = "chkEditarCuotas"
    Me.chkEditarCuotas.Size = New System.Drawing.Size(96, 19)
    Me.chkEditarCuotas.TabIndex = 49
    Me.chkEditarCuotas.Text = "EditarCuotas"
    Me.chkEditarCuotas.UseVisualStyleBackColor = False
    '
    'dtProximoPago
    '
    Me.dtProximoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtProximoPago.Location = New System.Drawing.Point(695, 163)
    Me.dtProximoPago.Name = "dtProximoPago"
    Me.dtProximoPago.Size = New System.Drawing.Size(227, 21)
    Me.dtProximoPago.TabIndex = 65
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(106, 265)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(76, 13)
    Me.Label7.TabIndex = 68
    Me.Label7.Text = "Plan de Pagos"
    '
    'lvPlanPagos
    '
    Me.lvPlanPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cNCuota, Me.cFechaCuota, Me.cValorCuota, Me.cFechaPago, Me.cEstado})
    Me.lvPlanPagos.Location = New System.Drawing.Point(109, 283)
    Me.lvPlanPagos.Name = "lvPlanPagos"
    Me.lvPlanPagos.Size = New System.Drawing.Size(597, 364)
    Me.lvPlanPagos.TabIndex = 67
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
    Me.cFechaCuota.Width = 120
    '
    'cValorCuota
    '
    Me.cValorCuota.Text = "Valor cuota"
    Me.cValorCuota.Width = 120
    '
    'cFechaPago
    '
    Me.cFechaPago.Text = "Pagado"
    Me.cFechaPago.Width = 110
    '
    'cEstado
    '
    Me.cEstado.Text = "Estado"
    Me.cEstado.Width = 180
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnGuardar.FlatAppearance.BorderSize = 0
    Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ForeColor = System.Drawing.Color.White
    Me.btnGuardar.Location = New System.Drawing.Point(10, 35)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 60)
    Me.btnGuardar.TabIndex = 69
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.chkEditarCuotas)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.Label6)
    Me.Panel1.Controls.Add(Me.lvPlanPagos)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Controls.Add(Me.dtProximoPago)
    Me.Panel1.Controls.Add(Me.cmbCuotas)
    Me.Panel1.Controls.Add(Me.txtNumVenta)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label16)
    Me.Panel1.Controls.Add(Me.DateVenta)
    Me.Panel1.Controls.Add(Me.txtAdelantoVendedor)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label15)
    Me.Panel1.Controls.Add(Me.txtPrecio)
    Me.Panel1.Controls.Add(Me.txtAdelanto)
    Me.Panel1.Controls.Add(Me.btnAddCuenta)
    Me.Panel1.Controls.Add(Me.Label14)
    Me.Panel1.Controls.Add(Me.btnSeleccionarCuenta)
    Me.Panel1.Controls.Add(Me.lblValorCuota)
    Me.Panel1.Controls.Add(Me.txtMedioPagoDescripcion)
    Me.Panel1.Controls.Add(Me.txtValorCuota)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Location = New System.Drawing.Point(148, 35)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1120, 662)
    Me.Panel1.TabIndex = 70
    '
    'frmEstablecerPagos
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(1280, 720)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEstablecerPagos"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmEstablecerPagos"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNumVenta As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents txtAdelantoVendedor As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents txtAdelanto As System.Windows.Forms.TextBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents lblValorCuota As System.Windows.Forms.Label
  Friend WithEvents txtValorCuota As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtMedioPagoDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents btnSeleccionarCuenta As System.Windows.Forms.Button
  Friend WithEvents btnAddCuenta As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents DateVenta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cmbCuotas As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents chkEditarCuotas As System.Windows.Forms.CheckBox
  Friend WithEvents dtProximoPago As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents lvPlanPagos As System.Windows.Forms.ListView
  Friend WithEvents cNCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cFechaCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cValorCuota As System.Windows.Forms.ColumnHeader
  Friend WithEvents cFechaPago As System.Windows.Forms.ColumnHeader
  Friend WithEvents cEstado As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
