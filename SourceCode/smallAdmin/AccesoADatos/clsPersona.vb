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
            strSQL.Append("[Nombre],")
            strSQL.Append("[Apellido],")
            strSQL.Append("[DNI],")
            strSQL.Append("[FechaNac],")
            strSQL.Append("[Calle],")
            strSQL.Append("[NumCalle],")
            strSQL.Append("[FechaIngreso],")
            strSQL.Append("[Email],")
            strSQL.Append("[Tel1],")
            strSQL.Append("[Tel2],")
            strSQL.Append("[Ciudad],")
            strSQL.Append("[Provincia],")
            strSQL.Append("[calle2],")
            strSQL.Append("[NumCalle2],")
            strSQL.Append("[NumCliente],")
            strSQL.Append("[CodigoPostal],")
            strSQL.Append("[Comentarios],")
            strSQL.Append("[Profesion]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.DNI) & """,")
            strSQL.Append("""" & .FechaNac & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Calle) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.NumCalle) & """,")
            strSQL.Append("""" & .FechaIngreso & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Email) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Tel1) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Tel2) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Ciudad) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Provincia) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Calle2) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.NumCalle2) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.NumCliente) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.CodigoPostal) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Comentarios) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Profesion) & """")

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
            strSQL.Append("[Nombre]=""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("[Apellido]=""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """,")
            strSQL.Append("[DNI]=""" & libDB.clsAcceso.Field_Correcting(.DNI) & """,")
            strSQL.Append("[FechaNac]=""" & .FechaNac & """,")
            strSQL.Append("[Calle]=""" & libDB.clsAcceso.Field_Correcting(.Calle) & """,")
            strSQL.Append("[NumCalle]=""" & libDB.clsAcceso.Field_Correcting(.NumCalle) & """,")
            strSQL.Append("[FechaIngreso]=""" & .FechaIngreso & """,")
            strSQL.Append("[Email]=""" & libDB.clsAcceso.Field_Correcting(.Email) & """,")
            strSQL.Append("[Tel2]=""" & libDB.clsAcceso.Field_Correcting(.Tel1) & """,")
            strSQL.Append("[Tel1]=""" & libDB.clsAcceso.Field_Correcting(.Tel2) & """,")
            strSQL.Append("[Ciudad]=""" & libDB.clsAcceso.Field_Correcting(.Ciudad) & """,")
            strSQL.Append("[Provincia]=""" & libDB.clsAcceso.Field_Correcting(.Provincia) & """,")
            strSQL.Append("[Calle2]=""" & libDB.clsAcceso.Field_Correcting(.Calle2) & """,")
            strSQL.Append("[NumCalle2]=""" & libDB.clsAcceso.Field_Correcting(.NumCalle2) & """,")
            strSQL.Append("[NumCliente]=""" & libDB.clsAcceso.Field_Correcting(.NumCliente) & """,")
            strSQL.Append("[CodigoPostal]=""" & libDB.clsAcceso.Field_Correcting(.CodigoPostal) & """,")
            strSQL.Append("[Comentarios]=""" & libDB.clsAcceso.Field_Correcting(.Comentarios) & """,")
            strSQL.Append("[Profesion]=""" & libDB.clsAcceso.Field_Correcting(.Profesion) & """")

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
          vInfoPersona.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoPersona.Nombre = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Apellido = CStr(IIf(IsDBNull(.Item("Apellido")), "", .Item("Apellido")))
        Catch ex As Exception
          vInfoPersona.Apellido = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.DNI = CStr(IIf(IsDBNull(.Item("DNI")), "", .Item("DNI")))
        Catch ex As Exception
          vInfoPersona.DNI = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.FechaNac = CDate(IIf(IsDBNull(.Item("FechaNac")), Nothing, .Item("FechaNac")))
        Catch ex As Exception
          vInfoPersona.FechaNac = Date.Today
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Calle = CStr(IIf(IsDBNull(.Item("Calle")), "", .Item("Calle")))
        Catch ex As Exception
          vInfoPersona.Calle = ""
          Call Print_msg(ex.Message)
        End Try


        Try
          vInfoPersona.NumCalle = CStr(IIf(IsDBNull(.Item("NunmCalle")), "", .Item("NumCalle")))
        Catch ex As Exception
          vInfoPersona.NumCalle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.FechaIngreso = CDate(IIf(IsDBNull(.Item("FechaIngreso")), Nothing, .Item("FechaIngreso")))
        Catch ex As Exception
          vInfoPersona.FechaIngreso = Date.Today
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Email = CStr(IIf(IsDBNull(.Item("Email")), "", .Item("Email")))
        Catch ex As Exception
          vInfoPersona.Email = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Tel1 = CStr(IIf(IsDBNull(.Item("Tel1")), "", .Item("Tel1")))
        Catch ex As Exception
          vInfoPersona.Tel1 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Tel2 = CStr(IIf(IsDBNull(.Item("Tel2")), "", .Item("Tel2")))
        Catch ex As Exception
          vInfoPersona.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Ciudad = CStr(IIf(IsDBNull(.Item("Ciudad")), "", .Item("Ciudad")))
        Catch ex As Exception
          vInfoPersona.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Provincia = CStr(IIf(IsDBNull(.Item("Provincia")), "", .Item("Provincia")))
        Catch ex As Exception
          vInfoPersona.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Calle2 = CStr(IIf(IsDBNull(.Item("Calle")), "", .Item("Calle")))
        Catch ex As Exception
          vInfoPersona.Calle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.NumCalle2 = CStr(IIf(IsDBNull(.Item("NunmCalle")), "", .Item("NumCalle")))
        Catch ex As Exception
          vInfoPersona.NumCalle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.NumCliente = CStr(IIf(IsDBNull(.Item("NumCliente")), "", .Item("NumCliente")))
        Catch ex As Exception
          vInfoPersona.NumCliente = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.CodigoPostal = CStr(IIf(IsDBNull(.Item("CodigoPostal")), "", .Item("CodigoPostal")))
        Catch ex As Exception
          vInfoPersona.CodigoPostal = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Comentarios = CStr(IIf(IsDBNull(.Item("Comentarios")), "", .Item("Comentarios")))
        Catch ex As Exception
          vInfoPersona.Comentarios = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPersona.Profesion = CStr(IIf(IsDBNull(.Item("Profesion")), "", .Item("Profesion")))
        Catch ex As Exception
          vInfoPersona.Profesion = ""
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
