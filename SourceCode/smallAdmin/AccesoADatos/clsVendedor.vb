Imports libCommon.Comunes
Imports manDB
Public Class clsVendedor

  Public Shared Function Load(ByVal vGuidVendedor As Guid, ByRef rVendedor As manDB.clsInfoVendedor) As Result
    Try
      Dim vResult As Result
      Dim vIdVendedor As Integer
      If FindGuid(vGuidVendedor, vIdVendedor) = True Then
        vResult = Init(rVendedor, vGuidVendedor)
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

  Public Shared Function Save(ByRef rVendedor As manDB.clsInfoVendedor) As libCommon.Comunes.Result
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

        objResult = Save(objDB, rVendedor)
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
        strCommand = "DELETE * FROM [Vendedores] WHERE [GuidVendedor]={" & vGuid.ToString & "}"

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

  Private Shared Function Init(ByRef rInfoVendedor As manDB.clsInfoVendedor, ByVal GuidVendedor As Guid) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoVendedor = New clsInfoVendedor
        rInfoVendedor.GuidVendedor = GuidVendedor

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoVendedor, GuidVendedor)
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

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoVendedor As manDB.clsInfoVendedor) As Result
    Try
      Dim objResult As Result

      If Not (rInfoVendedor.GuidVendedor = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdVendedor] FROM [Vendedores] WHERE [GuidVendedor]={" & rInfoVendedor.GuidVendedor.ToString & "}", rInfoVendedor.IdVendedor)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoVendedor

          If rInfoVendedor.IdVendedor <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Vendedores] ")

            strSQL.Append("(")

            strSQL.Append("[GuidVendedor],")
            strSQL.Append("[Nombre],")
            strSQL.Append("[Apellido],")
            strSQL.Append("[NunmVendedor],")
            strSQL.Append("[Ciudad],")
            strSQL.Append("[Provincia],")
            strSQL.Append("[CodigoPostal],")
            strSQL.Append("[ID],")
            strSQL.Append("[Grupo],")
            strSQL.Append("[Tel1],")
            strSQL.Append("[Tel2],")
            strSQL.Append("[Email],")
            strSQL.Append("[Categoria],")
            strSQL.Append("[Comentario]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.NumVendedor) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Ciudad) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Provincia) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.CodigoPostal) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.ID) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Grupo) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Tel1) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Tel2) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Email) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Categoria) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Comentario) & """")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoVendedor.IdVendedor)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Vendedores] SET ")
            strSQL.Append("[GuidVendedor]=""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("[Nombre]=""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("[Apellido]=""" & libDB.clsAcceso.Field_Correcting(.Apellido) & """,")
            strSQL.Append("[NumVendedor]=""" & libDB.clsAcceso.Field_Correcting(.NumVendedor) & """,")
            strSQL.Append("[Ciudad]=""" & libDB.clsAcceso.Field_Correcting(.Ciudad) & """,")
            strSQL.Append("[Provincia]=""" & libDB.clsAcceso.Field_Correcting(.Provincia) & """,")
            strSQL.Append("[CodigoPostal]=""" & libDB.clsAcceso.Field_Correcting(.CodigoPostal) & """,")
            strSQL.Append("[ID]=""" & libDB.clsAcceso.Field_Correcting(.ID) & """,")
            strSQL.Append("[Grupo]=""" & libDB.clsAcceso.Field_Correcting(.Grupo) & """,")
            strSQL.Append("[Tel1]=""" & libDB.clsAcceso.Field_Correcting(.Tel1) & """,")
            strSQL.Append("[Tel2]=""" & libDB.clsAcceso.Field_Correcting(.Tel2) & """,")
            strSQL.Append("[Email]=""" & libDB.clsAcceso.Field_Correcting(.Email) & """,")
            strSQL.Append("[Categoria]=""" & libDB.clsAcceso.Field_Correcting(.Categoria) & """,")
            strSQL.Append("[Comentario]=""" & libDB.clsAcceso.Field_Correcting(.Comentario) & """")
           
            strSQL.Append(" WHERE [IdVendedor]=" & .IdVendedor)

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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoVendedor As clsInfoVendedor, ByVal vGuidVendedor As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      rInfoVendedor = New clsInfoVendedor
      rInfoVendedor.GuidVendedor = vGuidVendedor

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Vendedores] WHERE [GuidVendedor]={" & vGuidVendedor.ToString & "}"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = VendedorIgualDataRow(rInfoVendedor, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      'objResult = Genero_Init(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'If objResult <> libCommon.E_OpResult.OK Then Return objResult

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function FindGuid(ByVal vGuid As Guid, ByRef vIdVendedor As Integer) As Boolean
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = FindGuid(objDB, vGuid, vIdVendedor)
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
      vIdVendedor = -1
      Return False

    End Try

  End Function

  Private Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid, ByRef rIdVendedor As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdVendedor] FROM [Vendedores] WHERE [GuidVendedor]={" & vGuid.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rIdVendedor)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rIdVendedor > 0 Then
        objResult = Result.OK
      Else
        rIdVendedor = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      rIdVendedor = -1
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function VendedorIgualDataRow(ByRef vInfoVendedor As clsInfoVendedor, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoVendedor.IdVendedor = CInt(IIf(IsDBNull(.Item("IdVendedor")), -1, .Item("IdVendedor")))
        Catch ex As Exception
          vInfoVendedor.IdVendedor = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.GuidVendedor = CType(IIf(IsDBNull(.Item("GuidVendedor")), Nothing, .Item("GuidVendedor")), Guid)
        Catch ex As Exception
          vInfoVendedor.GuidVendedor = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoVendedor.Nombre = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Apellido = CStr(IIf(IsDBNull(.Item("Apellido")), "", .Item("Apellido")))
        Catch ex As Exception
          vInfoVendedor.Apellido = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.NumVendedor = CStr(IIf(IsDBNull(.Item("NumVendedor")), "", .Item("NumVendedor")))
        Catch ex As Exception
          vInfoVendedor.NumVendedor = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Ciudad = CStr(IIf(IsDBNull(.Item("Ciudad")), "", .Item("Ciudad")))
        Catch ex As Exception
          vInfoVendedor.Ciudad = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Provincia = CStr(IIf(IsDBNull(.Item("Provincia")), "", .Item("Provincia")))
        Catch ex As Exception
          vInfoVendedor.Provincia = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.CodigoPostal = CStr(IIf(IsDBNull(.Item("CodigoPostal")), "", .Item("CodigoPostal")))
        Catch ex As Exception
          vInfoVendedor.CodigoPostal = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.ID = CStr(IIf(IsDBNull(.Item("ID")), "", .Item("ID")))
        Catch ex As Exception
          vInfoVendedor.ID = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Grupo = CStr(IIf(IsDBNull(.Item("Grupo")), "", .Item("Grupo")))
        Catch ex As Exception
          vInfoVendedor.Grupo = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Tel1 = CStr(IIf(IsDBNull(.Item("Tel1")), "", .Item("Tel1")))
        Catch ex As Exception
          vInfoVendedor.Tel1 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Tel2 = CStr(IIf(IsDBNull(.Item("Tel2")), "", .Item("Tel2")))
        Catch ex As Exception
          vInfoVendedor.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Email = CStr(IIf(IsDBNull(.Item("Email")), "", .Item("Email")))
        Catch ex As Exception
          vInfoVendedor.Email = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Categoria = CStr(IIf(IsDBNull(.Item("Categoria")), "", .Item("Categoria")))
        Catch ex As Exception
          vInfoVendedor.Categoria = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoVendedor.Comentario = CStr(IIf(IsDBNull(.Item("Comentario")), "", .Item("Comentario")))
        Catch ex As Exception
          vInfoVendedor.Comentario = ""
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
