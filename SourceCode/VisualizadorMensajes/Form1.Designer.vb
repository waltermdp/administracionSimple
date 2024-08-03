<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvData1 = New System.Windows.Forms.DataGridView()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCuotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhatsappLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.MensajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsIntercambioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttCopiar = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tp01 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tp02 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ttlineaactual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsIntercambioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'dgvData1
        '
        Me.dgvData1.AllowUserToAddRows = False
        Me.dgvData1.AllowUserToDeleteRows = False
        Me.dgvData1.AllowUserToResizeRows = False
        Me.dgvData1.AutoGenerateColumns = False
        Me.dgvData1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvData1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData1.ColumnHeadersHeight = 24
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.TotalCuotasDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.WhatsappLinkDataGridViewTextBoxColumn, Me.MensajeDataGridViewTextBoxColumn})
        Me.dgvData1.DataSource = Me.ClsIntercambioBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvData1.EnableHeadersVisualStyles = False
        Me.dgvData1.GridColor = System.Drawing.Color.White
        Me.dgvData1.Location = New System.Drawing.Point(0, 24)
        Me.dgvData1.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvData1.MultiSelect = False
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData1.RowHeadersVisible = False
        Me.dgvData1.RowTemplate.Height = 24
        Me.dgvData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData1.Size = New System.Drawing.Size(956, 526)
        Me.dgvData1.TabIndex = 25
        Me.dgvData1.TabStop = False
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Telefono1DataGridViewTextBoxColumn
        '
        Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
        Me.Telefono1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha_Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuotaDataGridViewTextBoxColumn
        '
        Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
        Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCuotasDataGridViewTextBoxColumn
        '
        Me.TotalCuotasDataGridViewTextBoxColumn.DataPropertyName = "Total_Cuotas"
        Me.TotalCuotasDataGridViewTextBoxColumn.HeaderText = "Total_Cuotas"
        Me.TotalCuotasDataGridViewTextBoxColumn.Name = "TotalCuotasDataGridViewTextBoxColumn"
        Me.TotalCuotasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorCuotaDataGridViewTextBoxColumn
        '
        Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "Valor_Cuota"
        Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "Valor_Cuota"
        Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
        Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhatsappLinkDataGridViewTextBoxColumn
        '
        Me.WhatsappLinkDataGridViewTextBoxColumn.DataPropertyName = "Whatsapp_Link"
        Me.WhatsappLinkDataGridViewTextBoxColumn.HeaderText = "Whatsapp_Link"
        Me.WhatsappLinkDataGridViewTextBoxColumn.Name = "WhatsappLinkDataGridViewTextBoxColumn"
        Me.WhatsappLinkDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhatsappLinkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WhatsappLinkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MensajeDataGridViewTextBoxColumn
        '
        Me.MensajeDataGridViewTextBoxColumn.DataPropertyName = "Mensaje"
        Me.MensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje"
        Me.MensajeDataGridViewTextBoxColumn.Name = "MensajeDataGridViewTextBoxColumn"
        Me.MensajeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClsIntercambioBindingSource1
        '
        Me.ClsIntercambioBindingSource1.DataSource = GetType(VisualizadorMensajes.clsIntercambio)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttCopiar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 22)
        '
        'ttCopiar
        '
        Me.ttCopiar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ttCopiar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ttCopiar.Name = "ttCopiar"
        Me.ttCopiar.ReadOnly = True
        Me.ttCopiar.Size = New System.Drawing.Size(100, 16)
        Me.ttCopiar.Text = "Copiar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tp01, Me.tp02, Me.ttlineaactual})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(956, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tp01
        '
        Me.tp01.Name = "tp01"
        Me.tp01.Size = New System.Drawing.Size(119, 17)
        Me.tp01.Text = "ToolStripStatusLabel1"
        '
        'tp02
        '
        Me.tp02.Name = "tp02"
        Me.tp02.Size = New System.Drawing.Size(119, 17)
        Me.tp02.Text = "ToolStripStatusLabel2"
        '
        'ttlineaactual
        '
        Me.ttlineaactual.Name = "ttlineaactual"
        Me.ttlineaactual.Size = New System.Drawing.Size(10, 17)
        Me.ttlineaactual.Text = " "
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'EnviarToolStripMenuItem
        '
        Me.EnviarToolStripMenuItem.Name = "EnviarToolStripMenuItem"
        Me.EnviarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnviarToolStripMenuItem.Text = "Enviar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 550)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Visor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsIntercambioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Public WithEvents dgvData1 As DataGridView
    Friend WithEvents ClsIntercambioBindingSource1 As BindingSource
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ttCopiar As ToolStripTextBox
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCuotasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WhatsappLinkDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents MensajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tp01 As ToolStripStatusLabel
    Friend WithEvents tp02 As ToolStripStatusLabel
    Friend WithEvents ttlineaactual As ToolStripStatusLabel
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarToolStripMenuItem As ToolStripMenuItem
End Class
