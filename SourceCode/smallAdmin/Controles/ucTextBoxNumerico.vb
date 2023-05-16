Imports libCommon.Comunes
Imports manDB
Public Class ucTextBoxNumerico

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Try
      Me.Text = "0"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
    Try
      MyBase.OnKeyPress(e)
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
      End If


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
