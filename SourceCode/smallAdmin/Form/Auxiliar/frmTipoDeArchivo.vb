Imports libCommon.Comunes
Imports manDB
Public Class frmTipoDeArchivo

  Private m_ExportImport As E_TIPO_INTERCAMBIO

  Private m_TipoPagoSeleccionado As clsTipoPago = Nothing

  Public Enum E_TIPO_INTERCAMBIO As Integer
    Importar = 1
    Exportar = 2
  End Enum

  Public ReadOnly Property TipoPagoSeleccionado As clsTipoPago
    Get
      Return m_TipoPagoSeleccionado
    End Get
  End Property

  Public Sub New(ByVal vMood As E_TIPO_INTERCAMBIO)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      m_ExportImport = vMood
      Select Case vMood
        Case E_TIPO_INTERCAMBIO.Importar
          lblInfoImpExp.Text = "Seleccione el tipo de pago a Importar"
        Case E_TIPO_INTERCAMBIO.Exportar
          lblInfoImpExp.Text = "Seleccione el tipo de pago a Exportar"
        Case Else
          lblInfoImpExp.Text = "Seleccione el tipo de pago"
      End Select

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmTipoDeArchivo_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      cmbTipoPago.DataSource = g_TipoPago
      cmbTipoPago.SelectedIndex = 1
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelImpExp.MouseClick
    Try
      DialogResult = Windows.Forms.DialogResult.Cancel
      Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnContinuarImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnContinuarImpExp.MouseClick
    Try
      If cmbTipoPago.SelectedIndex < 0 Then
        MsgBox("Debe seleccionar un modo de pago/cobro")
        DialogResult = Windows.Forms.DialogResult.Cancel
        Exit Sub
      End If
      m_TipoPagoSeleccionado = CType(cmbTipoPago.SelectedItem, clsTipoPago)
      DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnContinuarImpExp_Click(sender As Object, e As EventArgs) Handles btnContinuarImpExp.Click
    Try

    Catch ex As Exception

    End Try
  End Sub
End Class