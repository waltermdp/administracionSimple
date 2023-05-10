Imports libCommon.Comunes
Imports manDB

Public Class clsAdelantos

  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"

  Public Shared Function Load(ByVal vGuidVendedor As Guid, ByVal vGuidProducto As Guid, ByRef rAdelanto As clsInfoAdelanto) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try


        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, vGuidVendedor, vGuidProducto, rAdelanto)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally
        If objDB IsNot Nothing Then
          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If
        End If
      End Try

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Public Shared Function Save(ByRef rAdelanto As manDB.clsInfoAdelanto) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Save(objDB, rAdelanto)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
      Finally
        If objDB IsNot Nothing Then
          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If
        End If
      End Try


      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByVal vGuidVendedor As Guid, ByVal vGuidProducto As Guid, ByRef rAdelanto As clsInfoAdelanto, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Adelantos] WHERE [GuidVendedor]={" & vGuidVendedor.ToString & "}" & _
                   " and [GuidProducto]={" & vGuidProducto.ToString & "}"  '   BETWEEN #" & Format(vInicial, strFormatoAnsiStdFecha) & "# and #" & Format(vFinal, strFormatoAnsiStdFecha) & "#"
      '" and [Fecha] BETWEEN #" & Format(vInicial, strFormatoAnsiStdFecha) & "# and #" & Format(vFinal, strFormatoAnsiStdFecha) & "#"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---


      If dt.Rows.Count > 1 Then Return Result.NOK
      If dt.Rows.Count <= 0 Then Return Result.NOK
      Dim auxInfoAdelanto As New clsInfoAdelanto
      objResult = AdelantoIgualDataRow(auxInfoAdelanto, dt.Rows(0))
      If objResult <> Result.OK Then
        MsgBox("No se pudo cargar el dinero adelantado al vendedor para esta venta")
        Return Result.NOK
      End If
      rAdelanto = auxInfoAdelanto.Clone
      

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoAdelanto As manDB.clsInfoAdelanto) As Result
    Try
      Dim objResult As Result

      If Not (rInfoAdelanto.GuidVendedor = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdAdelanto] FROM [Adelantos] WHERE [GuidVendedor]={" & rInfoAdelanto.GuidVendedor.ToString & "} and [GuidProducto] ={" & rInfoAdelanto.GuidProducto.ToString & "}", rInfoAdelanto.IdAdelanto) ' & Format(rInfoAdelanto.Fecha, strFormatoAnsiStdFecha) & "#", rInfoAdelanto.IdAdelanto) ' AND [Valor]=" & rInfoAdelanto.Valor
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoAdelanto

          If rInfoAdelanto.IdAdelanto <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Adelantos] ")
            strSQL.Append("(")
            strSQL.Append("[GuidVendedor],")
            strSQL.Append("[Valor],")
            strSQL.Append("[Fecha],")
            strSQL.Append("[Estado],")
            strSQL.Append("[Observacion],")
            strSQL.Append("[GuidProducto]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("""" & .Valor.ToString & """,")
            strSQL.Append("""" & .Fecha & """,")
            strSQL.Append("""" & .Estado.ToString & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Observacion) & """,")
            strSQL.Append("""{" & .GuidProducto.ToString & "}""")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoAdelanto.IdAdelanto)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Adelantos] SET ")
            strSQL.Append("[GuidVendedor]=""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("[Valor]=""" & .Valor.ToString & """,")
            strSQL.Append("[Fecha]=""" & .Fecha & """,")
            strSQL.Append("[Estado]=""" & .Estado.ToString & """,")
            strSQL.Append("[Observacion]=""" & libDB.clsAcceso.Field_Correcting(.observacion) & """,")
            strSQL.Append("[GuidProducto]=""{" & .GuidProducto.ToString & "}""")

            strSQL.Append(" WHERE [IdAdelanto]=" & .IdAdelanto)

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult

          End If

        End With
        '<-- Comando en DB ---

      Else
        objResult = Result.ErrorInt
      End If

      'If objResult = Result.OK Then
      '  objResult = Genero_Save(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'End If


      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function AdelantoIgualDataRow(ByRef vInfo As clsInfoAdelanto, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfo.IdAdelanto = CInt(IIf(IsDBNull(.Item("IdAdelanto")), -1, .Item("IdAdelanto")))
        Catch ex As Exception
          vInfo.IdAdelanto = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.GuidVendedor = CType(IIf(IsDBNull(.Item("GuidVendedor")), Nothing, .Item("GuidVendedor")), Guid)
        Catch ex As Exception
          vInfo.GuidVendedor = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.Valor = CDec(IIf(IsDBNull(.Item("Valor")), "0", .Item("Valor")))
        Catch ex As Exception
          vInfo.Valor = 0
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.Fecha = CDate(IIf(IsDBNull(.Item("Fecha")), Nothing, .Item("Fecha")))
        Catch ex As Exception
          vInfo.Fecha = Date.Today
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.Estado = CInt(IIf(IsDBNull(.Item("Estado")), 0, .Item("Estado")))
        Catch ex As Exception
          vInfo.estado = 0
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.Observacion = CStr(IIf(IsDBNull(.Item("Observacion")), "", .Item("Observacion")))
        Catch ex As Exception
          vInfo.Observacion = ""
          Call Print_msg(ex.Message)
        End Try


        Try
          vInfo.GuidProducto = CType(IIf(IsDBNull(.Item("GuidProducto")), Nothing, .Item("GuidProducto")), Guid)
        Catch ex As Exception
          vInfo.GuidProducto = Nothing
          Call Print_msg(ex.Message)

        End Try

      End With

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class