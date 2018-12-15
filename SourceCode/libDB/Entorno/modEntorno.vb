Imports libCommon.Comunes

Module modEntorno

  Public g_PathDB As String
  Public g_PassDB As String
  Public Function Init(ByVal pathApp As String, ByVal NameDB As String, ByVal claveDB As String) As libCommon.Comunes.Result
    Try
      g_PathDB = IO.Path.Combine(pathApp, NameDB)
      g_PassDB = claveDB

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.NOK
    End Try
  End Function
End Module
