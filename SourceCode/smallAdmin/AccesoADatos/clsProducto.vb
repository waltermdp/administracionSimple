Imports libCommon.Comunes
Imports manDB
Public Class clsProducto

  Public Shared Function Save(ByRef rInfoProducto As manDB.clsInfoProducto) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

      

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Save(objDB, rInfoProducto.GuidCliente, rInfoProducto)
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

  Public Shared Function Load(ByVal vGuid As Guid, ByRef rInfoProducto As clsInfoProducto) As Result
    Try
      Dim vResult As Result
      Dim vIdProducto As Integer
      If vGuid = Guid.Empty Then Return Result.NOK
      If FindGuid(vGuid, vIdProducto) = True Then
        vResult = Init(rInfoProducto, vGuid)
        Return vResult
      Else

      End If

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

 

  Public Shared Function Delete(ByVal vGuidProducto As Guid) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Delete(objDB, vGuidProducto)
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

  Private Shared Function Delete(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid) As Result
    Try

      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String = "DELETE * FROM [Productos] WHERE [GuidProducto]={" & vGuid.ToString & "}"


      objResult = vObjDB.ExecuteNonQuery(strCommand)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

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

  Private Shared Function Init(ByRef rInfoProducto As clsInfoProducto, ByVal vGuid As Guid) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoProducto = New clsInfoProducto
        rInfoProducto.GuidCliente = vGuid

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoProducto, vGuid)
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

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoProductos As clsInfoProducto, ByVal vGuid As Guid) As Result
    Try

      Dim objResult As Result

      '--- Comando en DB -->
      Dim dt As DataTable = Nothing
      Dim strCommand As String

      strCommand = "SELECT * FROM [Productos] WHERE [GuidProducto]={" & vGuid.ToString & "}"


      objResult = vObjDB.GetDato(strCommand, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---

      objResult = ProductoIgualDataRow(rInfoProductos, dt.Rows(0))
      If objResult <> Result.OK Then Return objResult

      Return objResult

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
          vInfoProducto.GuidCliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Nothing, .Item("GuidCliente")), Guid)
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

        Try
          vInfoProducto.GuidCuenta = CType(IIf(IsDBNull(.Item("GuidCuenta")), Nothing, .Item("GuidCuenta")), Guid)
        Catch ex As Exception
          vInfoProducto.GuidCuenta = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.Adelanto = CDec(IIf(IsDBNull(.Item("Adelanto")), -1, .Item("Adelanto")))
        Catch ex As Exception
          vInfoProducto.Adelanto = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.ValorCuotaFija = CDec(IIf(IsDBNull(.Item("ValorCuotaFija")), -1, .Item("ValorCuotaFija")))
        Catch ex As Exception
          vInfoProducto.ValorCuotaFija = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoProducto.NumComprobante = CInt(IIf(IsDBNull(.Item("NumComprobante")), -1, .Item("NumComprobante")))
        Catch ex As Exception
          vInfoProducto.NumComprobante = -1
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

      objResult = Save_Cuenta(vObjDB, rInfoProducto.Cuenta)
      If objResult <> Result.OK Then Return objResult

      objResult = Save_ArticulosVendidos(vObjDB, rInfoProducto.ListaArticulos, rInfoProducto.GuidProducto)
      If objResult <> Result.OK Then Return objResult

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function FindGuid(ByVal vGuid As Guid, ByRef vIdProducto As Integer) As Boolean
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK


      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = FindGuid(objDB, vGuid, vIdProducto)
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
      vIdProducto = -1
      Return False

    End Try

  End Function

  Public Shared Function FindGuid(ByVal vObjDB As libDB.clsAcceso, ByVal vGuid As Guid, ByRef rIdProducto As Integer) As Result
    Try
      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String

      strCommand = "SELECT [IdProducto] FROM [Productos] WHERE [GuidProducto]={" & vGuid.ToString & "}"


      objResult = vObjDB.EjecutarConsulta(strCommand, rIdProducto)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      If rIdProducto > 0 Then
        objResult = Result.OK
      Else
        rIdProducto = -1
        objResult = Result.NOK
      End If

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)

      rIdProducto = -1
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
            strSQL.Append("[FechaPrimerPago],")
            strSQL.Append("[GuidCuenta],")
            strSQL.Append("[Adelanto],")
            strSQL.Append("[ValorCuotaFija],")
            strSQL.Append("[NumComprobante]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidCliente.ToString & "}"",")
            strSQL.Append("""{" & .GuidVendedor.ToString & "}"",")
            strSQL.Append("""{" & .GuidProducto.ToString & "}"",")
            strSQL.Append("""{" & .GuidTipoPago.ToString & "}"",")
            strSQL.Append("""" & .Precio.ToString & """,")
            strSQL.Append("""" & .TotalCuotas.ToString & """,")
            strSQL.Append("""" & .CuotasDebe.ToString & """,")
            strSQL.Append("""" & .FechaVenta & """,")
            strSQL.Append("""" & .FechaPrimerPago & """,")
            strSQL.Append("""{" & .GuidCuenta.ToString & "}"",")
            strSQL.Append("""" & .Adelanto.ToString & """,")
            strSQL.Append("""" & .ValorCuotaFija.ToString & """,")
            strSQL.Append("""" & .NumComprobante.ToString & """")
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
            strSQL.Append("[Precio]=""" & .Precio.ToString & """,")
            strSQL.Append("[TotalCuotas]=""" & .TotalCuotas.ToString & """,")
            strSQL.Append("[CuotasDebe]=""" & .CuotasDebe.ToString & """,")
            strSQL.Append("[FechaVenta]=""" & .FechaVenta & """,")
            strSQL.Append("[FechaPrimerPago]=""" & .FechaPrimerPago & """,")
            strSQL.Append("[GuidCuenta]=""{" & .GuidCuenta.ToString & "}"",")
            strSQL.Append("[Adelanto]=""" & .Adelanto.ToString & """,")
            strSQL.Append("[ValorCuotaFija]=""" & .ValorCuotaFija.ToString & """,")
            strSQL.Append("[NumComprobante]=""" & .NumComprobante.ToString & """")

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

  Private Shared Function Save_Cuenta(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoCuenta As manDB.clsInfoCuenta) As Result
    Try
      Return clsCuenta.Save(rInfoCuenta)
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function Save_ArticulosVendidos(ByVal vObjDB As libDB.clsAcceso, ByRef rArticulosVendidos As List(Of clsInfoArticuloVendido), ByVal vGuidProducto As Guid) As Result
    Try

      Return clsRelArtProd.Save(rArticulosVendidos, vGuidProducto)
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
End Class
