Imports libCommon.Comunes
Imports manDB
Public Class clsArticulo


  Public Shared Function Load(ByVal vGuidArticulo As Guid, ByRef rArticulo As manDB.clsInfoArticulos) As Result
    Try
      Dim vResult As Result
      Dim vIdArticulo As Integer
      If FindGuid(vGuidArticulo, vIdArticulo) = True Then
        vResult = Init(rArticulo, vGuidArticulo)
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

  Public Shared Function Save(ByRef rArticulo As manDB.clsInfoArticulos) As libCommon.Comunes.Result
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

        objResult = Save(objDB, rArticulo)
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
        strCommand = "DELETE * FROM [Articulos] WHERE [GuidArticulo]={" & vGuid.ToString & "}"

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
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

  Public Function FindArticulos(ByVal vParametro As String, ByRef rListArticulos As List(Of clsInfoArticulos)) As Result
    Try

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Shared Function Init(ByRef rInfoArticulo As manDB.clsInfoArticulos, ByVal GuidArticulo As Guid) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoArticulo = New clsInfoArticulos
        rInfoArticulo.GuidArticulo = GuidArticulo

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoArticulo, GuidArticulo)
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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoArticulo As clsInfoArticulos, ByVal vGuidArticulo As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      rInfoArticulo = New clsInfoArticulos
      rInfoArticulo.GuidArticulo = vGuidArticulo

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Articulos] WHERE [GuidArticulo]={" & vGuidArticulo.ToString & "}"

      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = ArticuloIgualDataRow(rInfoArticulo, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      'objResult = Genero_Init(vObjDB, rInfoPersona.IdPac, rInfoPersona.Genero)
      'If objResult <> libCommon.E_OpResult.OK Then Return objResult

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoArticulo As manDB.clsInfoArticulos) As Result
    Try
      Dim objResult As Result

      If Not (rInfoArticulo.GuidArticulo = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdArticulo] FROM [Articulos] WHERE [GuidArticulo]={" & rInfoArticulo.GuidArticulo.ToString & "}", rInfoArticulo.IdArticulo)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoArticulo

          If rInfoArticulo.IdArticulo <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Articulos] ")
            strSQL.Append("(")
            strSQL.Append("[GuidArticulo],")
            strSQL.Append("[Nombre],")
            strSQL.Append("[Codigo],")
            strSQL.Append("[Descripcion],")
            strSQL.Append("[Precio],")
            strSQL.Append("[CodigoBarras]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidArticulo.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Codigo) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Descripcion) & """,")
            strSQL.Append("""" & .Precio.ToString & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.CodigoBarras) & """")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoArticulo.IdArticulo)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Articulos] SET ")
            strSQL.Append("[GuidArticulo]=""{" & .GuidArticulo.ToString & "}"",")
            strSQL.Append("[Nombre]=""" & libDB.clsAcceso.Field_Correcting(.Nombre) & """,")
            strSQL.Append("[Codigo]=""" & libDB.clsAcceso.Field_Correcting(.Codigo) & """,")
            strSQL.Append("[Descripcion]=""" & libDB.clsAcceso.Field_Correcting(.Descripcion) & """,")
            strSQL.Append("[Precio]=""" & .Precio.ToString & """,")
            strSQL.Append("[CodigoBarras]=""" & libDB.clsAcceso.Field_Correcting(.CodigoBarras) & """")

            strSQL.Append(" WHERE [IdArticulo]=" & .IdArticulo)

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

  Private Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid, ByRef rIdArticulo As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdArticulo] FROM [Articulos] WHERE [GuidArticulo]={" & vGuid.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rIdArticulo)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rIdArticulo > 0 Then
        objResult = Result.OK
      Else
        rIdArticulo = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      rIdArticulo = -1
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function ArticuloIgualDataRow(ByRef vInfoArticulo As clsInfoArticulos, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoArticulo.IdArticulo = CInt(IIf(IsDBNull(.Item("IdArticulo")), -1, .Item("IdArticulo")))
        Catch ex As Exception
          vInfoArticulo.IdArticulo = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.GuidArticulo = CType(IIf(IsDBNull(.Item("GuidArticulo")), Nothing, .Item("GuidArticulo")), Guid)
        Catch ex As Exception
          vInfoArticulo.GuidArticulo = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoArticulo.Nombre = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.Codigo = CStr(IIf(IsDBNull(.Item("Codigo")), "", .Item("Codigo")))
        Catch ex As Exception
          vInfoArticulo.Codigo = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.Descripcion = CStr(IIf(IsDBNull(.Item("Descripcion")), "", .Item("Descripcion")))
        Catch ex As Exception
          vInfoArticulo.Descripcion = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.Precio = CDec(IIf(IsDBNull(.Item("Precio")), 0, .Item("Precio")))
        Catch ex As Exception
          vInfoArticulo.Precio = 0
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.CodigoBarras = CStr(IIf(IsDBNull(.Item("CodigoBarras")), "", .Item("CodigoBarras")))
        Catch ex As Exception
          vInfoArticulo.CodigoBarras = ""
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
