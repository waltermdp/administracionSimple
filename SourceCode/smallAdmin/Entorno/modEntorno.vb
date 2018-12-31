Imports libCommon.Comunes
Module Entorno

  Public Const NameSoftware As String = "NA"
  Public DB_path As String = String.Empty
  Public App_path As String = String.Empty
  Public NameDB As String = String.Empty
  Public DB_SLocal_ConnectionString As String = String.Empty
  Private dbpw As String = String.Empty

  Public g_TipoPago As New List(Of manDB.clsTipoPago)
  Public g_Cuotas As New List(Of clsCuota)

  Public Function init() As Result
    Try
      NameDB = "bdcli.mdb"
      App_path = My.Application.Info.DirectoryPath
      If App_path.Contains("SourceCode") Then
        Dim tmop As String = App_path.Substring(0, App_path.IndexOf("SourceCode"))
        App_path = IO.Path.Combine(tmop, "work")
      End If


      'App_path = "c:\repositorio\personal\smallAdmin\work\"


      DB_path = IO.Path.Combine(App_path, NameDB)
      If IO.File.Exists(DB_path) = False Then
        MsgBox("Database missing")
      End If
      DB_SLocal_ConnectionString = GetAccessConectionStringDBS(DB_path)

      'TODO:CARGAR
      CargarTipoPago(g_TipoPago)
      CargarCuotas(g_Cuotas)


      Return Result.OK
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GetAccessConectionStringDBS(ByVal vPathDB As String) As String
    Try

      Return libDB.clsAcceso.GetConectionString_MAccess(vPathDB, dbpw)

    Catch ex As Exception
      Print_msg(ex.Message)
      Return ""
    End Try
  End Function


  Public Function GuardarTipoPago(ByRef rListTipoListaPago As List(Of manDB.clsTipoPago)) As Result

    Try

      Dim Fila As Integer
      Dim objResult As Result

      Fila = FreeFile()

      If rListTipoListaPago Is Nothing Then
        rListTipoListaPago = New List(Of manDB.clsTipoPago)
      End If

      Try
        FileOpen(Fila, IO.Path.Combine(App_path, "TipoPagos.inf"), OpenMode.Output)
        Dim auxstr As String = ""

        auxstr = rListTipoListaPago.Count.ToString
        WriteLine(Fila, auxstr)
        For i = 0 To rListTipoListaPago.Count - 1
          auxstr = rListTipoListaPago(i).Nombre
          WriteLine(Fila, auxstr)
          auxstr = CInt(rListTipoListaPago(i).PermiteCuotas).ToString
          WriteLine(Fila, auxstr)
          auxstr = CStr(rListTipoListaPago(i).GuidTipo.ToString)
          WriteLine(Fila, auxstr)

        Next
        objResult = Result.OK

      Catch ex As Exception
        Print_msg(ex.Message)
        objResult = Result.ErrorEx
      Finally
        FileClose(Fila)
      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try


  End Function

  Public Function CargarTipoPago(ByRef rListTipoPago As List(Of manDB.clsTipoPago), Optional ByVal ShowMessage As Boolean = False) As Result

    Try
      Dim objResult As Result
      Dim Fila As Integer
      Fila = FreeFile()

      If rListTipoPago Is Nothing Then
        rListTipoPago = New List(Of manDB.clsTipoPago)
      Else
        rListTipoPago.Clear()
      End If

      Try

        FileOpen(Fila, IO.Path.Combine(App_path, "TipoPagos.inf"), OpenMode.Input)
        Dim auxstr As String = ""
        Dim auxTipoPago As manDB.clsTipoPago

        Input(Fila, auxstr)

        objResult = Result.OK
        For i = 0 To Val(auxstr) - 1
          Try
            auxTipoPago = New manDB.clsTipoPago
            Input(Fila, auxstr)
            auxTipoPago.Nombre = auxstr
            Input(Fila, auxstr)
            Dim aux As Integer = CInt(auxstr)
            If aux <= 0 Then
              auxTipoPago.PermiteCuotas = False
            Else
              auxTipoPago.PermiteCuotas = True
            End If

            Input(Fila, auxstr)
            auxTipoPago.GuidTipo = New Guid(auxstr)

            rListTipoPago.Add(auxTipoPago)
          Catch ex As Exception
            objResult = Result.ErrorEx
            Exit For
          End Try
        Next


      Catch ex As Exception
        Print_msg(ex.Message)
        Return Result.ErrorEx

      Finally
        FileClose(Fila)

        If objResult <> Result.OK Then
          If ShowMessage = True Then
            MsgBox("_EL_ARCHIVO_NO_FUE_CARGADO_CORRECTAMENTE", MsgBoxStyle.Information)
          End If


        End If


      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

  Public Function GuardarCuotas(ByRef rListCuotas As List(Of clsCuota)) As Result

    Try

      Dim Fila As Integer
      Dim objResult As Result

      Fila = FreeFile()

      If rListCuotas Is Nothing Then
        rListCuotas = New List(Of clsCuota)
      End If

      Try
        FileOpen(Fila, IO.Path.Combine(App_path, "Cuotas.inf"), OpenMode.Output)
        Dim auxstr As String = ""

        auxstr = rListCuotas.Count.ToString
        WriteLine(Fila, auxstr)
        For i = 0 To rListCuotas.Count - 1
          auxstr = rListCuotas(i).Nombre
          WriteLine(Fila, auxstr)
          auxstr = CStr(rListCuotas(i).GuidCuota.ToString)
          WriteLine(Fila, auxstr)
          auxstr = rListCuotas(i).Cantidad.ToString
          WriteLine(Fila, auxstr)
        Next
        objResult = Result.OK

      Catch ex As Exception
        Print_msg(ex.Message)
        objResult = Result.ErrorEx
      Finally
        FileClose(Fila)
      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try


  End Function

  Public Function CargarCuotas(ByRef rListCuotas As List(Of clsCuota), Optional ByVal ShowMessage As Boolean = False) As Result

    Try
      Dim objResult As Result
      Dim Fila As Integer
      Fila = FreeFile()

      If rListCuotas Is Nothing Then
        rListCuotas = New List(Of clsCuota)
      Else
        rListCuotas.Clear()
      End If

      Try

        FileOpen(Fila, IO.Path.Combine(App_path, "Cuotas.inf"), OpenMode.Input)
        Dim auxstr As String = ""
        Dim auxTipoPago As clsCuota

        Input(Fila, auxstr)

        objResult = Result.OK
        For i = 0 To Val(auxstr) - 1
          Try
            auxTipoPago = New clsCuota
            Input(Fila, auxstr)
            auxTipoPago.Nombre = auxstr
            Input(Fila, auxstr)
            auxTipoPago.GuidCuota = New Guid(auxstr)
            Input(Fila, auxstr)
            auxTipoPago.Cantidad = CInt(auxstr)
            rListCuotas.Add(auxTipoPago)
          Catch ex As Exception
            objResult = Result.ErrorEx
            Exit For
          End Try
        Next


      Catch ex As Exception
        Print_msg(ex.Message)
        Return Result.ErrorEx

      Finally
        FileClose(Fila)

        If objResult <> Result.OK Then
          If ShowMessage = True Then
            MsgBox("_EL_ARCHIVO_NO_FUE_CARGADO_CORRECTAMENTE", MsgBoxStyle.Information)
          End If


        End If


      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

End Module
