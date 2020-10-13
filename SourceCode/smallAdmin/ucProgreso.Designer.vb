<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProgreso
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.pbBarra = New System.Windows.Forms.ProgressBar()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.lblDescription = New System.Windows.Forms.Label()
    Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pbBarra
    '
    Me.pbBarra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pbBarra.Location = New System.Drawing.Point(3, 3)
    Me.pbBarra.Name = "pbBarra"
    Me.pbBarra.Size = New System.Drawing.Size(15, 23)
    Me.pbBarra.TabIndex = 0
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.Location = New System.Drawing.Point(24, 2)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'lblDescription
    '
    Me.lblDescription.AutoSize = True
    Me.lblDescription.Location = New System.Drawing.Point(3, 29)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(39, 13)
    Me.lblDescription.TabIndex = 2
    Me.lblDescription.Text = "Label1"
    '
    'BackgroundWorker1
    '
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(374, -11)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(326, 311)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pbBarra)
    Me.Panel1.Controls.Add(Me.lblDescription)
    Me.Panel1.Controls.Add(Me.btnCancelar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(111, 106)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(102, 97)
    Me.Panel1.TabIndex = 4
    '
    'ucProgreso
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "ucProgreso"
    Me.Size = New System.Drawing.Size(700, 300)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pbBarra As System.Windows.Forms.ProgressBar
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
