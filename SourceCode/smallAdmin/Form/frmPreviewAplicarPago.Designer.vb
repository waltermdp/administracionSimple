﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewAplicarPago
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
    Me.lstPagoAplicar = New System.Windows.Forms.ListView()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.btnAplicar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lstPagoAplicar
    '
    Me.lstPagoAplicar.Location = New System.Drawing.Point(155, 41)
    Me.lstPagoAplicar.Name = "lstPagoAplicar"
    Me.lstPagoAplicar.Size = New System.Drawing.Size(267, 268)
    Me.lstPagoAplicar.TabIndex = 0
    Me.lstPagoAplicar.UseCompatibleStateImageBehavior = False
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(152, 25)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(39, 13)
    Me.lblTipo.TabIndex = 1
    Me.lblTipo.Text = "Label1"
    '
    'btnAplicar
    '
    Me.btnAplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnAplicar.FlatAppearance.BorderSize = 0
    Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAplicar.ForeColor = System.Drawing.Color.White
    Me.btnAplicar.Location = New System.Drawing.Point(10, 35)
    Me.btnAplicar.Name = "btnAplicar"
    Me.btnAplicar.Size = New System.Drawing.Size(110, 60)
    Me.btnAplicar.TabIndex = 2
    Me.btnAplicar.Text = "Aplicar y salir"
    Me.btnAplicar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
    Me.btnCancelar.FlatAppearance.BorderSize = 0
    Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ForeColor = System.Drawing.Color.White
    Me.btnCancelar.Location = New System.Drawing.Point(10, 346)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 60)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'frmPreviewAplicarPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.main.My.Resources.Resources.FondoGral
    Me.ClientSize = New System.Drawing.Size(816, 415)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnAplicar)
    Me.Controls.Add(Me.lblTipo)
    Me.Controls.Add(Me.lstPagoAplicar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmPreviewAplicarPago"
    Me.Text = "frmPreviewAplicarPago"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstPagoAplicar As System.Windows.Forms.ListView
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents btnAplicar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
