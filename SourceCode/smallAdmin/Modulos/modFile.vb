Imports libCommon.Comunes
Module modFile




  Public Function Load(ByVal pathFile As String, ByRef rLista As List(Of String)) As libCommon.Comunes.Result
    Try
      Dim Fila As Integer
      Dim vResult As Result = Result.OK
      If Not IO.File.Exists(pathFile) Then Return Result.NOK
      Fila = FreeFile()
      Try

        FileOpen(Fila, pathFile, OpenMode.Input)
        rLista = New List(Of String)
        Do Until EOF(Fila)
          rLista.Add(LineInput(Fila))
        Loop

        vResult = Result.OK
      Catch ex As Exception
        Print_msg(ex.Message)
        vResult = Result.ErrorEx
      Finally
        FileClose(Fila)
      End Try

      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function Save(ByVal pathFile As String, ByVal rLista As List(Of String)) As libCommon.Comunes.Result
    Try

      Dim vResult As Result = Result.OK
      Dim objWriter As New IO.StreamWriter(pathFile)
      Try
        For Each item In rLista
          objWriter.WriteLine(item)
        Next
        vResult = Result.OK
      Catch ex As Exception
        Print_msg(ex.Message)
        vResult = Result.ErrorEx
      Finally
        objWriter.Close()
      End Try

      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Module
