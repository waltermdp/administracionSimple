Imports libCommon.Comunes
Imports manDB
Public Class clsProducto

  Public Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rlistProductos As List(Of clsInfoProducto), ByVal vGuidCliente As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result = Result.OK
      Dim dt As DataTable = Nothing
      Dim strSQL As String

      'strSQL = "SELECT Pat.* FROM Pat INNER JOIN PatPac ON Pat.IdPat = PatPac.IdPat WHERE [Pagos.GuidProducto]={" & vGuidProducto.ToString & "}" ' WHERE [Pagos.GuidProducto]= " & vGuidProducto.ToString
      strSQL = "SELECT * FROM [Productos] WHERE [Productos.GuidCliente]={" & vGuidCliente.ToString & "}" ' WHERE [Pagos.GuidProducto]= " & vGuidProducto.ToString

      objResult = vObjDB.GetDato(strSQL, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---


      Dim auxInfoProducto As clsInfoProducto = Nothing
      For Each dr As DataRow In dt.Rows
        auxInfoProducto = New clsInfoProducto
        objResult = clsProducto.ProductoIgualDataRow(auxInfoProducto, dr)
        If objResult <> Result.OK Then Exit For
        rlistProductos.Add(auxInfoProducto)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function ProductoIgualDataRow(ByRef vInfoProducto As clsInfoProducto, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoProducto.IdProducto = CInt(IIf(IsDBNull(.Item("IdProducto")), -1, .Item("IdProducto")))
        Catch ex As Exception
          vInfoProducto.IdProducto = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.GuidCliente = CType(IIf(IsDBNull(.Item("Guidcliente")), Nothing, .Item("Guidcliente")), Guid)
        Catch ex As Exception
          vInfoProducto.GuidCliente = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.GuidVendedor = CType(IIf(IsDBNull(.Item("GuidVendedor")), Nothing, .Item("GuidVendedor")), Guid)
        Catch ex As Exception
          vInfoProducto.GuidVendedor = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.GuidProducto = CType(IIf(IsDBNull(.Item("GuidProducto")), Nothing, .Item("GuidProducto")), Guid)
        Catch ex As Exception
          vInfoProducto.GuidProducto = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.GuidTipoPago = CType(IIf(IsDBNull(.Item("GuidTipoPago")), Nothing, .Item("GuidTipoPago")), Guid)
        Catch ex As Exception
          vInfoProducto.GuidTipoPago = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.Precio = CDec(IIf(IsDBNull(.Item("Precio")), 0, .Item("Precio")))
        Catch ex As Exception
          vInfoProducto.Precio = 0
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.TotalCuotas = CInt(IIf(IsDBNull(.Item("TotalCuotas")), -1, .Item("TotalCuotas")))
        Catch ex As Exception
          vInfoProducto.TotalCuotas = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.CuotasDebe = CInt(IIf(IsDBNull(.Item("CuotasDebe")), -1, .Item("CuotasDebe")))
        Catch ex As Exception
          vInfoProducto.CuotasDebe = -1
          Call Print_msg(ex.Message)
        End Try


        Try
          vInfoProducto.FechaVenta = CDate(IIf(IsDBNull(.Item("FechaVenta")), Nothing, .Item("FechaVenta")))
        Catch ex As Exception
          vInfoProducto.FechaVenta = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.FechaPrimerPago = CDate(IIf(IsDBNull(.Item("FechaPrimerPago")), Nothing, .Item("FechaPrimerPago")))
        Catch ex As Exception
          vInfoProducto.FechaPrimerPago = Nothing
          Call Print_msg(ex.Message)
        End Try

      End With

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByVal vGuidCliente As Guid, ByRef rInfoProducto As manDB.clsInfoProducto) As Result
    Try
      Dim objResult As Result
      objResult = SaveProducto(vObjDB, rInfoProducto)
      If objResult <> Result.OK Then Return objResult

      objResult = Save_InfoPagos(vObjDB, rInfoProducto.ListaPagos)
      If objResult <> Result.OK Then Return objResult

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function Save_InfoPagos(ByVal vObjDB As libDB.clsAcceso, ByVal vPagos As List(Of clsInfoPagos)) As Result
    Try
      If vPagos IsNot Nothing Then
        Return clsPago.Save(vObjDB, vPagos)
      End If
      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function SaveProducto(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoProducto As manDB.clsInfoProducto) As Result
    Try
      Dim objResult As Result

      If Not (rInfoProducto.GuidProducto = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdProducto] FROM [Productos] WHERE [GuidProducto]={" & rInfoProducto.GuidProducto.ToString & "}", rInfoProducto.IdProducto)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoProducto

          If rInfoProducto.IdProducto <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Productos] ")

            strSQL.Append("(")

            strSQL.Append("[GuidCliente],")
            strSQL.Append("[GuidVendedor],")
            strSQL.Append("[GuidProducto],")
            strSQL.Append("[GuidTipoPago],")
            strSQL.Append("[Precio],")
            strSQL.Append("[TotalCuotas],")
            strSQL.Append("[CuotasDebe],")
            strSQL.Append("[FechaVenta],")
            strSQL.Append("[FechaPrimerPago]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("""{" & .GuidProducto.ToString & "}"",")
            strSQL.Append("""{" & .GuidTipoPago.ToString & "}"",")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.Precio) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.TotalCuotas) & """,")
            strSQL.Append("""" & libDB.clsAcceso.Field_Correcting(.CuotasDebe) & """,")
            strSQL.Append("""" & .FechaVenta & """,")
            strSQL.Append("""" & .FechaPrimerPago & """")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoProducto.IdProducto)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Productos] SET ")
            strSQL.Append("[GuidCliente]=""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("[GuidVendedor]=""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("[GuidProducto]=""{" & .GuidProducto.ToString & "}"",")
            strSQL.Append("[GuidTipoPago]=""{" & .GuidTipoPago.ToString & "}"",")
            strSQL.Append("[Precio]=""" & libDB.clsAcceso.Field_Correcting(.Precio) & """,")
            strSQL.Append("[TotalCuotas]=""" & libDB.clsAcceso.Field_Correcting(.TotalCuotas) & """,")
            strSQL.Append("[CuotasDebe]=""" & libDB.clsAcceso.Field_Correcting(.CuotasDebe) & """,")
            strSQL.Append("[FechaVenta]=""" & .FechaVenta & """,")
            strSQL.Append("[FechaPrimerPago]=""" & .FechaPrimerPago & """")

            strSQL.Append(" WHERE [IdProducto]=" & .IdProducto)

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


End Class
