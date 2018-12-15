Imports libCommon.Comunes
Imports manDB
Public Class clsPersona

  Public Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoPersona As manDB.ClsInfoPersona) As Result
    Try
      Dim objResult As Result

      If Not (rInfoPersona.GuidCliente = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdCliente] FROM [Clientes] WHERE [GuidCliente]={" & rInfoPersona.GuidCliente.ToString & "}", rInfoPersona.IDCliente)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoPersona

          If rInfoPersona.IDCliente <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Clientes] ")

            strSQL.Append("(")

            strSQL.Append("[GuidCliente],")
            'strSQL.Append("[GuidOwner],")
            strSQL.Append("[Apellido],")
            strSQL.Append("[Nombre]")
            'strSQL.Append("[NHC],")
            'strSQL.Append("[DNI],")
            'strSQL.Append("[FechaNac],")
            'strSQL.Append("[Telefono1],")
            'strSQL.Append("[Email1],")
            'strSQL.Append("[Ciudad],")
            'strSQL.Append("[ProvEstado],")
            'strSQL.Append("[CodPost],")
            'strSQL.Append("[Calle1],")
            'strSQL.Append("[NumCalle1],")
            'strSQL.Append("[Fecha],")
            'strSQL.Append("[Institucion],")
            'strSQL.Append("[Comentarios],")
            'strSQL.Append("[PathPac],")
            'strSQL.Append("[Acceso]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidCliente.ToString & "}"",")
            'strSQL.Append("""{" & .GuidOwner.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.NHC) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.DNI) & """,")
            'strSQL.Append("""" & .FechaNac & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Telefono1) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Email1) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Ciudad) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.ProvEstado) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.CodPost) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Calle1) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.NumCalle1) & """,")
            'strSQL.Append("""" & .Fecha & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Institucion) & """,")
            'strSQL.Append("""" & libDB.clsDB_Access.Field_Correcting(.Comentarios) & """,")
            'strSQL.Append("""" & .PathPac & """,")
            'strSQL.Append("""" & .Acceso & """")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String

 
              strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoPersona.IDCliente)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Clientes] SET ")
            strSQL.Append("[GuidCliente]=""{" & .GuidCliente.ToString & "}"",")
            'strSQL.Append("[GuidOwner]=""{" & .GuidOwner.ToString & "}"",")
            strSQL.Append("[Nombre]=""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("[Apellido]=""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """")
            'strSQL.Append("[DNI]=""" & libDB.clsDB_Access.Field_Correcting(.DNI) & """,")
            'strSQL.Append("[NHC]=""" & libDB.clsDB_Access.Field_Correcting(.NHC) & """,")
            'strSQL.Append("[FechaNac]=""" & .FechaNac & """,")
            'strSQL.Append("[Telefono1]=""" & libDB.clsDB_Access.Field_Correcting(.Telefono1) & """,")
            'strSQL.Append("[Email1]=""" & libDB.clsDB_Access.Field_Correcting(.Email1) & """,")
            'strSQL.Append("[Ciudad]=""" & libDB.clsDB_Access.Field_Correcting(.Ciudad) & """,")
            'strSQL.Append("[ProvEstado]=""" & libDB.clsDB_Access.Field_Correcting(.ProvEstado) & """,")
            'strSQL.Append("[CodPost]=""" & libDB.clsDB_Access.Field_Correcting(.CodPost) & """,")
            'strSQL.Append("[Calle1]=""" & libDB.clsDB_Access.Field_Correcting(.Calle1) & """,")
            'strSQL.Append("[NumCalle1]=""" & libDB.clsDB_Access.Field_Correcting(.NumCalle1) & """,")
            'strSQL.Append("[Fecha]=""" & .Fecha & """,")
            'strSQL.Append("[Institucion]=""" & libDB.clsDB_Access.Field_Correcting(.Institucion) & """,")
            'strSQL.Append("[Comentarios]=""" & libDB.clsDB_Access.Field_Correcting(.Comentarios) & """,")
            'strSQL.Append("[PathPac] = """ & .PathPac & """,")

            'strSQL.Append("[Acceso]=""" & .Acceso & """")
            strSQL.Append(" WHERE [IdCliente]=" & .IDCliente)

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

  Public Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoPersona As ClsInfoPersona, ByVal vGuidcliente As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      rInfoPersona = New ClsInfoPersona
      rInfoPersona.GuidCliente = vGuidcliente

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Clientes] WHERE [GuidCliente]={" & vGuidcliente.ToString & "}"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = PersonaIgualDataRow(rInfoPersona, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      'objResult = Genero_Init(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'If objResult <> libCommon.E_OpResult.OK Then Return objResult

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function FindGuid(ByVal vGuid As Guid, ByRef vIdCliente As Integer) As Boolean
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = FindGuid(objDB, vGuid, vIdcliente)
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
      vIdCliente = -1
      Return False

    End Try

  End Function

  Public Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid, ByRef rIdCliente As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdCliente] FROM [Clientes] WHERE [GuidCliente]={" & vGuid.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rIdCliente)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rIdCliente > 0 Then
        objResult = Result.OK
      Else
        rIdCliente = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)

      rIdCliente = -1
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function PersonaIgualDataRow(ByRef vInfoPersona As ClsInfoPersona, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoPersona.IDCliente = CInt(IIf(IsDBNull(.Item("IdCliente")), -1, .Item("IdCliente")))
        Catch ex As Exception
          vInfoPersona.IDCliente = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.GuidCliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Nothing, .Item("GuidCliente")), Guid)
        Catch ex As Exception
          vInfoPersona.GuidCliente = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Apellido = CStr(IIf(IsDBNull(.Item("Apellido")), "", .Item("Apellido")))
        Catch ex As Exception
          vInfoPersona.Apellido = ""
          Call Print_msg(ex.Message)
        End Try


        'Try
        '  vInfoPersona.Calle1 = CStr(IIf(IsDBNull(.Item("Calle1")), "", .Item("Calle1")))
        'Catch ex As Exception
        '  vInfoPersona.Calle1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


        'Try
        '  vInfoPersona.Ciudad = CStr(IIf(IsDBNull(.Item("Ciudad")), "", .Item("Ciudad")))
        'Catch ex As Exception
        '  vInfoPersona.Ciudad = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.CodPost = CStr(IIf(IsDBNull(.Item("CodPost")), "", .Item("CodPost")))
        'Catch ex As Exception
        '  vInfoPersona.CodPost = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try

        '  If Entorno.cEndoSOLO Then
        '    vInfoPersona.Comentarios = CStr(IIf(IsDBNull(.Item("Comentarios")), "", .Item("Comentarios")))
        '    EnterEndoSOLO2Manager(vInfoPersona.Comentarios)
        '  Else
        '    vInfoPersona.Comentarios = CStr(IIf(IsDBNull(.Item("Comentarios")), "", .Item("Comentarios")))
        '  End If

        'Catch ex As Exception
        '  vInfoPersona.Comentarios = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.DNI = CStr(IIf(IsDBNull(.Item("DNI")), "", .Item("DNI")))
        'Catch ex As Exception
        '  vInfoPersona.DNI = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.Email1 = CStr(IIf(IsDBNull(.Item("Email1")), "", .Item("Email1")))
        'Catch ex As Exception
        '  vInfoPersona.Email1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.Fecha = CDate(IIf(IsDBNull(.Item("Fecha")), Nothing, .Item("Fecha")))
        'Catch ex As Exception
        '  vInfoPersona.Fecha = Date.Today
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.FechaNac = CDate(IIf(IsDBNull(.Item("FechaNac")), Nothing, .Item("FechaNac")))
        'Catch ex As Exception
        '  vInfoPersona.FechaNac = Date.Today
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try

        '  If Entorno.cEndoSOLO Then
        '    vInfoPersona.GuidPac = CType(IIf(IsDBNull(.Item("GuidPac")), Nothing, New Guid(CStr(.Item("GuidPac")))), Guid)
        '  Else
        '    vInfoPersona.GuidPac = CType(IIf(IsDBNull(.Item("GuidPac")), Nothing, .Item("GuidPac")), Guid)
        '  End If

        'Catch ex As Exception
        '  vInfoPersona.GuidPac = Nothing
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


 

        'Try
        '  vInfoPersona.Acceso = CInt(IIf(IsDBNull(.Item("Acceso")), Nothing, .Item("Acceso")))
        'Catch ex As Exception
        '  vInfoPersona.Acceso = Nothing
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.Institucion = CStr(IIf(IsDBNull(.Item("Institucion")), "", .Item("Institucion")))
        'Catch ex As Exception
        '  vInfoPersona.Institucion = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.NHC = CStr(IIf(IsDBNull(.Item("NHC")), "", .Item("NHC")))

        'Catch ex As Exception
        '  vInfoPersona.NHC = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


        Try
          vInfoPersona.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoPersona.Nombre = ""
          Call Print_msg(ex.Message)
        End Try


        'Try
        '  vInfoPersona.NumCalle1 = CStr(IIf(IsDBNull(.Item("NumCalle1")), "", .Item("NumCalle1")))
        'Catch ex As Exception
        '  vInfoPersona.NumCalle1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.PathPac = CStr(IIf(IsDBNull(.Item("PathPac")), "", .Item("PathPac")))
        'Catch ex As Exception
        '  vInfoPersona.PathPac = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.ProvEstado = CStr(IIf(IsDBNull(.Item("ProvEstado")), "", .Item("ProvEstado")))
        'Catch ex As Exception
        '  vInfoPersona.ProvEstado = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoPersona.Telefono1 = CStr(IIf(IsDBNull(.Item("Telefono1")), "", .Item("Telefono1")))
        'Catch ex As Exception
        '  vInfoPersona.Telefono1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

      End With

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class
