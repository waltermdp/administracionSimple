Imports libCommon.Comunes
Imports manDB
Public Class clsGrupo



  Public Shared Function Save(ByRef rObj As manDB.clsInfoGrupo) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Save(objDB, rObj)
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

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfo As manDB.clsInfoGrupo) As Result
    Try
      Dim objResult As Result

      If Not (rInfo.GuidGrupo = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdGrupo] FROM [Grupos] WHERE [GuidGrupo]={" & rInfo.GuidGrupo.ToString & "}", rInfo.IdGrupo)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfo

          If rInfo.IdGrupo <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Grupos] ")
            strSQL.Append("(")
            strSQL.Append("[GuidGrupo],")
            strSQL.Append("[Nombre]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidGrupo.ToString & "}"",")
            strSQL.Append("""" & .Nombre & """")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfo.IdGrupo)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [grupos] SET ")
            strSQL.Append("[Guidgrupo]=""{" & .GuidGrupo.ToString & "}"",")
            strSQL.Append("[Nombre]=""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")

            strSQL.Append(" WHERE [IdAdelanto]=" & .IdGrupo)

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult

          End If

        End With
        '<-- Comando en DB ---

      Else
        objResult = Result.ErrorInt
      End If


      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Utilizado(ByVal vGrupo As manDB.clsInfoGrupo) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        '--- Comando en DB -->
        Dim strCommand As String

        'strCommand = "SELECT [IdGrupo] FROM [Grupos] WHERE [Nombre] = '" & name & "'"
        strCommand = "SELECT [IdVendedor] FROM [Vendedores] WHERE [Grupo] = '" & vGrupo.Nombre & "'" '{" & vGrupo.GuidGrupo.ToString & "}"

        Dim rID As Integer
        objResult = objDB.EjecutarConsulta(strCommand, rID)
        If objResult <> Result.OK Then Return objResult
        '<-- Comando en DB ---

        If rID > 0 Then
          objResult = Result.OK
        Else
          rID = -1
          objResult = Result.NOK
        End If

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
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Delete(ByVal vGuid As Guid) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        objDB = New libDB.clsAcceso

        '--- Comando en DB -->
        Dim strCommand As String
        strCommand = "DELETE * FROM [Grupos] WHERE [GuidGrupo]={" & vGuid.ToString & "}"

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = objDB.ExecuteNonQuery(strCommand)
        If objResult <> Result.OK Then Exit Try
        '<-- Comando en DB ---

        objResult = Result.OK

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

  Public Shared Function GetByName(ByVal Nombre As String) As Guid
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        '--- Comando en DB -->
        Dim strCommand As String

        strCommand = "SELECT [IdGrupo] FROM [Grupos] WHERE [Nombre] = '" & Nombre & "'"
        'strCommand = "SELECT [IdGrupo] FROM [Grupos] WHERE [GuidGrupo] = {" & vGrupo.GuidGrupo.ToString & "}"

        Dim rID As Integer
        objResult = objDB.EjecutarConsulta(strCommand, rID)
        If objResult <> Result.OK Then Return Guid.Empty
        '<-- Comando en DB ---
        If rID > 0 Then
          Dim dt As DataTable = Nothing
          objResult = objDB.GetDato(strCommand, dt)

          '--- Devuelvo OK cuando no hay resultados -->
          If objResult = Result.NOK Then Return Guid.Empty
          If objResult <> Result.OK Then Return Guid.Empty
          '<-- Devuelvo OK cuando no hay resultados ---

          '<-- Comando en DB ---
          Dim vGrupo As New clsInfoGrupo
          objResult = GrupoIgualDataRow(vGrupo, dt.Rows(0))
          If objResult <> Result.OK Then Return Guid.Empty
          Return vGrupo.GuidGrupo
        Else
          Return Guid.Empty
        End If

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

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Guid.Empty
    End Try
  End Function

  Public Shared Function Find(ByVal vGrupo As manDB.clsInfoGrupo) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        '--- Comando en DB -->
        Dim strCommand As String

        strCommand = "SELECT [IdGrupo] FROM [Grupos] WHERE [Nombre] = '" & vGrupo.Nombre & "'"
        'strCommand = "SELECT [IdGrupo] FROM [Grupos] WHERE [GuidGrupo] = {" & vGrupo.GuidGrupo.ToString & "}"

        Dim rID As Integer
        objResult = objDB.EjecutarConsulta(strCommand, rID)
        If objResult <> Result.OK Then Return objResult
        '<-- Comando en DB ---

        If rID > 0 Then
          objResult = Result.OK
        Else
          rID = -1
          objResult = Result.NOK
        End If

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
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function GrupoIgualDataRow(ByRef vInfo As clsInfoGrupo, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfo.IdGrupo = CInt(IIf(IsDBNull(.Item("IdGrupo")), -1, .Item("IdGrupo")))
        Catch ex As Exception
          vInfo.IdGrupo = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.GuidGrupo = CType(IIf(IsDBNull(.Item("GuidGrupo")), Nothing, .Item("GuidGrupo")), Guid)
        Catch ex As Exception
          vInfo.GuidGrupo = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfo.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfo.Nombre = ""
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
