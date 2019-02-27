Imports libCommon.Comunes
Public Class clsParsear

  Public Shared Function GetList(ByVal rList As List(Of String)) As List(Of clsPar)
    Try
      If rList Is Nothing Then Return New List(Of clsPar)
      If rList.Count <= 0 Then Return New List(Of clsPar)
      Dim lst As New List(Of clsPar)
      Dim cantidad As Integer = CInt(rList(0))

      For i As Integer = 1 To cantidad
        lst.Add(New clsPar With {.Guid = New Guid(rList(i * 2 - 1)), .Nombre = rList(i * 2)})
      Next
      Return lst
    Catch ex As Exception
      Print_msg(ex.Message)
      Return New List(Of clsPar)
    End Try
  End Function

  Public Shared Function setList(ByVal rList As List(Of clsPar)) As List(Of String)
    Try
      If rList Is Nothing Then Return New List(Of String)
      If rList.Count <= 0 Then Return New List(Of String)
      Dim lst As New List(Of String)

      For Each item As clsPar In rList
        lst.AddRange(item.ToListOfString)
      Next
      Return lst
    Catch ex As Exception
      Print_msg(ex.Message)
      Return New List(Of String)
    End Try
  End Function

End Class
