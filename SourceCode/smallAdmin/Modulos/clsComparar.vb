
Public Class clsComparar
  Implements IComparer(Of String)



  Public Function Compare(x As String, y As String) As Integer Implements IComparer(Of String).Compare
    Try
      If IsNumeric(x) AndAlso Not IsNumeric(y) Then
        Return 1
      ElseIf Not IsNumeric(x) AndAlso IsNumeric(y) Then
        Return -1
      ElseIf IsNumeric(x) AndAlso IsNumeric(y) Then
        Return CInt(x).CompareTo(CInt(y))
      Else
        'Not IsNumeric(x) AndAlso Not IsNumeric(y) Then
        Return x.CompareTo(y)
      End If
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return 0
    End Try
  End Function
End Class
