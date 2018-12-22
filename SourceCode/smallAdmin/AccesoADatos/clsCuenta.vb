Imports libCommon.Comunes
Imports manDB
Public Class clsCuenta

  Public Shared Function Load(ByVal vGuidCuenta As Guid, ByRef rCuenta As manDB.clsInfoCuenta) As Result
    Try
      Dim vResult As Result
      Dim vIdCuenta As Integer
      If FindGuid(vGuidCuenta, vIdCuenta) = True Then
        vResult = init(rCuenta, vGuidCuenta)
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

  Public Shared Function Save(ByRef rCuenta As manDB.clsInfoCuenta) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        'Dim LCliente As New manDB.clsInfoCliente
        'LCliente = rCliente.Clone
        'objResult = Cliente_Load(rCliente.Personal.GuidCliente, rCliente)
        'If objResult <> Result.OK Then Exit Try

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Save(objDB, rCuenta)
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

  Public Shared Function Delete(ByVal vGuid As Guid) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        objDB = New libDB.clsAcceso

        '--- Comando en DB -->
        Dim strCommand As String
        strCommand = "DELETE * FROM [Cuentas] WHERE [GuidCuenta]={" & vGuid.ToString & "}"

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

  Private Shared Function Init(ByRef rInfoCuenta As manDB.clsInfoCuenta, ByVal GuidCuenta As Guid) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoCuenta = New clsInfoCuenta
        rInfoCuenta.GuidCuenta = GuidCuenta

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoCuenta, GuidCuenta)
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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoCuenta As clsInfoCuenta, ByVal vGuidCuenta As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      rInfoCuenta = New clsInfoCuenta
      rInfoCuenta.GuidCuenta = vGuidCuenta

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Cuentas] WHERE [GuidCuenta]={" & vGuidCuenta.ToString & "}"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = CuentaIgualDataRow(rInfoCuenta, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      'objResult = Genero_Init(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'If objResult <> libCommon.E_OpResult.OK Then Return objResult

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoCuenta As manDB.clsInfoCuenta) As Result
    Try
      Dim objResult As Result

      If Not (rInfoCuenta.GuidCuenta = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdCuenta] FROM [Cuentas] WHERE [GuidCuenta]={" & rInfoCuenta.GuidCuenta.ToString & "}", rInfoCuenta.IdCuenta)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoCuenta

          If rInfoCuenta.IdCuenta <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Cuentas] ")

            strSQL.Append("(")

            strSQL.Append("[GuidCliente],")
            strSQL.Append("[GuidCuenta],")
            strSQL.Append("[Codigo1],")
            strSQL.Append("[Codigo2],")
            strSQL.Append("[Codigo3],")
            strSQL.Append("[Codigo4],")
            strSQL.Append("[TipoDeCuenta]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("""{" & .GuidCuenta.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Codigo1) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Codigo2) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Codigo3) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Codigo4) & """,")
            strSQL.Append("""{" & .TipoDeCuenta.ToString & "}""")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoCuenta.IdCuenta)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Cuentas] SET ")
            strSQL.Append("[GuidCliente]=""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("[GuidCuenta]=""{" & .GuidCuenta.ToString & "}"",")
            strSQL.Append("[Codigo1]=""" & libDB.clsAcceso.Field_Correcting(.Codigo1) & """,")
            strSQL.Append("[Codigo2]=""" & libDB.clsAcceso.Field_Correcting(.Codigo2) & """,")
            strSQL.Append("[Codigo3]=""" & libDB.clsAcceso.Field_Correcting(.Codigo3) & """,")
            strSQL.Append("[Codigo4]=""" & libDB.clsAcceso.Field_Correcting(.Codigo4) & """,")
            strSQL.Append("[GuidCuenta]=""{" & .TipoDeCuenta.ToString & "}""")

            strSQL.Append(" WHERE [IdCuenta]=" & .IdCuenta)

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

  Private Shared Function FindGuid(ByVal vGuid As Guid, ByRef vIdCuenta As Integer) As Boolean
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = FindGuid(objDB, vGuid, vIdCuenta)
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
      vIdCuenta = -1
      Return False

    End Try

  End Function

  Private Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid, ByRef rIdCuenta As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdCuenta] FROM [Cuentas] WHERE [GuidCuenta]={" & vGuid.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rIdCuenta)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rIdCuenta > 0 Then
        objResult = Result.OK
      Else
        rIdCuenta = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      rIdCuenta = -1
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function CuentaIgualDataRow(ByRef vInfoCuenta As clsInfoCuenta, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoCuenta.IdCuenta = CInt(IIf(IsDBNull(.Item("IdCuenta")), -1, .Item("IdCuenta")))
        Catch ex As Exception
          vInfoCuenta.IdCuenta = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.GuidCliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Nothing, .Item("GuidCliente")), Guid)
        Catch ex As Exception
          vInfoCuenta.GuidCliente = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.GuidCuenta = CType(IIf(IsDBNull(.Item("GuidCuenta")), Nothing, .Item("GuidCuenta")), Guid)
        Catch ex As Exception
          vInfoCuenta.GuidCuenta = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.Codigo1 = CStr(IIf(IsDBNull(.Item("Codigo1")), "", .Item("Codigo1")))
        Catch ex As Exception
          vInfoCuenta.Codigo1 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.Codigo2 = CStr(IIf(IsDBNull(.Item("Codigo2")), "", .Item("Codigo2")))
        Catch ex As Exception
          vInfoCuenta.Codigo2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.Codigo3 = CStr(IIf(IsDBNull(.Item("Codigo3")), "", .Item("Codigo3")))
        Catch ex As Exception
          vInfoCuenta.Codigo3 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.Codigo4 = CStr(IIf(IsDBNull(.Item("Codigo4")), "", .Item("Codigo4")))
        Catch ex As Exception
          vInfoCuenta.Codigo4 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoCuenta.TipoDeCuenta = CType(IIf(IsDBNull(.Item("TipoDeCuenta")), Nothing, .Item("TipoDeCuenta")), Guid)
        Catch ex As Exception
          vInfoCuenta.TipoDeCuenta = Nothing
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
