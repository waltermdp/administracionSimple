Imports libCommon.Comunes
Imports manDB
Public Class clsRelArtProd

  Public Shared Function Load(ByRef rlistArticulos As List(Of clsInfoArticuloVendido), ByVal vGuidProducto As Guid) As Result

    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rlistArticulos, vGuidProducto)
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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rlistArticulos As List(Of clsInfoArticuloVendido), ByVal vGuidProducto As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result = Result.OK
      Dim dt As DataTable = Nothing
      Dim strSQL As String

      'strSQL = "SELECT * FROM [Articulos] INNER JOIN [RelArtProd] ON Articulos.GuidArticulo = RelArtProd.GuidArticulo WHERE [RelArtProd.GuidProducto]={" & vGuidProducto.ToString & "}"

      strSQL = "SELECT * FROM [RelArtProd] WHERE [GuidProducto]={" & vGuidProducto.ToString & "}"

      objResult = vObjDB.GetDato(strSQL, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---


      Dim auxInfoRel As clsInfoRelArtProd = Nothing
      Dim auxInfoArticulo As clsInfoArticulos
      For Each dr As DataRow In dt.Rows
        auxInfoRel = New clsInfoRelArtProd
        auxInfoArticulo = New clsInfoArticulos
        objResult = RelArtProdIgualDataRow(auxInfoRel, dr)
        If objResult <> Result.OK Then Exit For
        objResult = clsArticulo.Load(auxInfoRel.GuidArticulo, auxInfoArticulo)
        If objResult <> Result.OK Then Exit For
        rlistArticulos.Add(New clsInfoArticuloVendido)
        rlistArticulos.Last.copy(auxInfoArticulo)
        rlistArticulos.Last.CantidadArticulos = auxInfoRel.CantidadArticulos
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Save(ByRef rListArticulos As List(Of clsInfoArticuloVendido), ByVal vGuidProducto As Guid) As Result

    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        For Each articulo In rListArticulos
          objResult = SaveRel(objDB, articulo.GuidArticulo, vGuidProducto, articulo.CantidadArticulos)
          If objResult <> Result.OK Then Exit For
        Next


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

  Private Shared Function SaveRel(ByVal vObjDB As libDB.clsAcceso, ByVal vGuidArticulo As Guid, ByVal vGuidProducto As Guid, ByVal vCantidadArticulos As Integer) As Result
    Try
      Dim objResult As Result

      If Not (vGuidProducto = Nothing) AndAlso Not (vGuidArticulo = Nothing) Then
        '--- Comando en DB -->
        Dim IdRel As String = -1
        objResult = vObjDB.EjecutarConsulta("SELECT [IdRel] FROM [RelArtProd] WHERE ([GuidArticulo]={" & vGuidArticulo.ToString & "} AND [GuidProducto]={" & vGuidProducto.ToString & "})", IdRel)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")


        If IdRel <= 0 Then
          'Insert
          strSQL.Append("INSERT INTO [RelArtProd] ")
          strSQL.Append("(")

          strSQL.Append("[GuidArticulo],")
          strSQL.Append("[GuidProducto],")
          strSQL.Append("[CantidadArticulos]")

          strSQL.Append(") VALUES (")

          strSQL.Append("""{" & vGuidArticulo.ToString & "}"",")
          strSQL.Append("""{" & vGuidProducto.ToString & "}"",")
          strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(vCantidadArticulos.ToString) & """")

          strSQL.Append(")")

          objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
          If objResult <> Result.OK Then Return objResult
          Dim strCommand As String


          strCommand = "Select @@IDENTITY"


          objResult = vObjDB.EjecutarConsulta(strCommand, IdRel)
          If objResult <> Result.OK Then Return objResult

        Else

          'Update
          strSQL.Append("UPDATE [RelArtProd] SET ")
          strSQL.Append("[GuidArticulo]=""{" & vGuidArticulo.ToString & "}"",")
          strSQL.Append("[GuidProducto]=""{" & vGuidProducto.ToString & "}"",")
          strSQL.Append("[CantidadArticulos]=""" & libDB.clsAcceso.Field_Correcting(vCantidadArticulos) & """")
          strSQL.Append(" WHERE [IdRel]=" & IdRel)

          objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
          If objResult <> Result.OK Then Return objResult

        End If
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

  Private Shared Function RelArtProdIgualDataRow(ByRef vInfoArticulo As clsInfoRelArtProd, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoArticulo.IdRel = CInt(IIf(IsDBNull(.Item("IdRel")), -1, .Item("IdRel")))
        Catch ex As Exception
          vInfoArticulo.IdRel = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.GuidArticulo = CType(IIf(IsDBNull(.Item("GuidArticulo")), Nothing, .Item("GuidArticulo")), Guid)
        Catch ex As Exception
          vInfoArticulo.GuidArticulo = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.GuidProducto = CType(IIf(IsDBNull(.Item("GuidProducto")), Nothing, .Item("GuidProducto")), Guid)
        Catch ex As Exception
          vInfoArticulo.GuidProducto = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoArticulo.CantidadArticulos = CStr(IIf(IsDBNull(.Item("CantidadArticulos")), "", .Item("CantidadArticulos")))
        Catch ex As Exception
          vInfoArticulo.CantidadArticulos = ""
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
