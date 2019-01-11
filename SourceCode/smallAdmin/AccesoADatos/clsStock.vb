Imports libCommon.Comunes
Imports manDB

Public Class clsStock
  Public Shared Function Load(ByRef rStock As manDB.clsInfoStock) As Result
    Try
      Dim vResult As Result
      Dim vId As Integer
      If FindGuid(rStock, vId) = True Then
        vResult = Init(rStock, vId)
        Return vResult
      Else
        'crea un Cliente vacio con vGuid. 
      End If

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Save(ByRef rStock As manDB.clsInfoStock) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Save(objDB, rStock)
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


  Private Shared Function Init(ByRef rInfoStock As manDB.clsInfoStock, ByVal vID As Integer) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoStock = New clsInfoStock
        rInfoStock.IdStock = vID

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoStock, vID)
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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoStock As clsInfoStock, ByVal vID As Integer, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      rInfoStock = New clsInfoStock
      rInfoStock.IdStock = vID

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Stock] WHERE [IdStock]={" & vID.ToString & "}"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = StockIgualDataRow(rInfoStock, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      'objResult = Genero_Init(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'If objResult <> libCommon.E_OpResult.OK Then Return objResult

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoStock As manDB.clsInfoStock) As Result
    Try
      Dim objResult As Result

      If Not (rInfoStock.GuidArticulo = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdStock] FROM [Stock] WHERE [GuidArticulo]={" & rInfoStock.GuidArticulo.ToString & "} AND [GuidResponsable]={" & rInfoStock.GuidResponsable.ToString & "}", rInfoStock.IdStock)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoStock

          If rInfoStock.IdStock <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Stock] ")

            strSQL.Append("(")

            strSQL.Append("[GuidArticulo],")
            strSQL.Append("[Responsable],")
            strSQL.Append("[Cantidad],")
            strSQL.Append("[GuidResponsable]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidArticulo.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Responsable) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Cantidad) & """,")
            strSQL.Append("""{" & .GuidResponsable.ToString & "}""")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoStock.IdStock)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Stock] SET ")
            strSQL.Append("[GuidArticulo]=""{" & .GuidArticulo.ToString & "}"",")
            strSQL.Append("[Responsable]=""" & libDB.clsAcceso.Field_Correcting(.Responsable) & """,")
            strSQL.Append("[Cantidad]=""" & libDB.clsAcceso.Field_Correcting(.Cantidad) & """,")
            strSQL.Append("[GuidResponsable]=""{" & .GuidResponsable.ToString & "}""")

            strSQL.Append(" WHERE [Idstock]=" & .IdStock)

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

  Public Shared Function StockIgualDataRow(ByRef vInfoStock As clsInfoStock, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoStock.IdStock = CInt(IIf(IsDBNull(.Item("IdStock")), -1, .Item("IdStock")))
        Catch ex As Exception
          vInfoStock.IdStock = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoStock.GuidArticulo = CType(IIf(IsDBNull(.Item("GuidArticulo")), Nothing, .Item("GuidArticulo")), Guid)
        Catch ex As Exception
          vInfoStock.GuidArticulo = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoStock.Responsable = CStr(IIf(IsDBNull(.Item("Responsable")), "", .Item("Responsable")))
        Catch ex As Exception
          vInfoStock.Responsable = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoStock.Cantidad = CStr(IIf(IsDBNull(.Item("Cantidad")), "", .Item("Cantidad")))
        Catch ex As Exception
          vInfoStock.Cantidad = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoStock.GuidResponsable = CType(IIf(IsDBNull(.Item("GuidResponsable")), Nothing, .Item("GuidResponsable")), Guid)
        Catch ex As Exception
          vInfoStock.GuidResponsable = Nothing
          Call Print_msg(ex.Message)
        End Try

      End With

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function FindGuid(ByVal rStock As manDB.clsInfoStock, ByRef vId As Integer) As Boolean
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = FindGuid(objDB, rStock, vId)
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

      If objResult = Result.OK Then
        Return True
      Else
        Return False
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
      vId = -1
      Return False

    End Try

  End Function

  Private Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal rStock As clsInfoStock, ByRef rId As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdStock] FROM [Stock] WHERE [GuidArticulo]={" & rStock.GuidArticulo.ToString & "} AND [GuidResponsable]={" & rStock.GuidResponsable.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rId)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rId > 0 Then
        objResult = Result.OK
      Else
        rId = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      rId = -1
      Return Result.ErrorEx

    End Try

  End Function

End Class
