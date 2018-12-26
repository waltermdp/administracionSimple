Imports libCommon.Comunes
Public Class clsParsear

  Private m_RawInput As New List(Of String)

  Public Sub New(ByVal vList As List(Of String))
    Try
      m_RawInput = vList.ToList
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetPagos() As Result
    Try

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
End Class
