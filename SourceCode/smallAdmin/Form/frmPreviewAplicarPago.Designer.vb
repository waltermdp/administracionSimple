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
    Me.SuspendLayout()
    '
    'lstPagoAplicar
    '
    Me.lstPagoAplicar.Location = New System.Drawing.Point(28, 41)
    Me.lstPagoAplicar.Name = "lstPagoAplicar"
    Me.lstPagoAplicar.Size = New System.Drawing.Size(228, 268)
    Me.lstPagoAplicar.TabIndex = 0
    Me.lstPagoAplicar.UseCompatibleStateImageBehavior = False
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(25, 25)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(39, 13)
    Me.lblTipo.TabIndex = 1
    Me.lblTipo.Text = "Label1"
    '
    'frmPreviewAplicarPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(587, 415)
    Me.Controls.Add(Me.lblTipo)
    Me.Controls.Add(Me.lstPagoAplicar)
    Me.Name = "frmPreviewAplicarPago"
    Me.Text = "frmPreviewAplicarPago"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstPagoAplicar As System.Windows.Forms.ListView
  Friend WithEvents lblTipo As System.Windows.Forms.Label
End Class
