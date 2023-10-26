Public Class frmSelectDate

  Private m_minDate As Date
  Private m_SelectedDate As Date
  Private m_Result As libCommon.Comunes.Result = libCommon.Comunes.Result.NOK
  Public Sub New(ByVal vDateMin As Date)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      m_minDate = vDateMin
      m_SelectedDate = vDateMin
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub
  Private Sub frmSelectDate_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      dtpDate.MinDate = m_minDate
      dtpDate.Value = m_minDate
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetResult(ByRef rSelectedDate As Date) As libCommon.Comunes.Result
    Try
      rSelectedDate = m_SelectedDate
      Return m_Result
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return libCommon.Comunes.Result.ErrorEx
    End Try
  End Function

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Try
      m_SelectedDate = m_minDate
      m_Result = libCommon.Comunes.Result.CANCEL
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    Finally
      Close()
    End Try
  End Sub

  Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    Try
      m_SelectedDate = dtpDate.Value
      m_Result = libCommon.Comunes.Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    Finally
      Close()
    End Try
  End Sub
End Class