﻿Imports libCommon.Comunes
Public Class clsConsulta

  Public Shared Function ConsultaProductos(ByVal query As String, ByRef lstConsulta As List(Of clsInfoConsultaVentas)) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = queryVentas(objDB, query, lstConsulta)
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

  Private Shared Function queryVentas(ByVal vObjDB As libDB.clsAcceso, ByVal vQquery As String, ByRef lstConsulta As List(Of clsInfoConsultaVentas)) As Result
    Try
      Dim objResult As Result = Result.OK
      Dim dt As DataTable = Nothing
      Dim strSQL As String

      strSQL = "SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor, Productos.ValorCuotaFija FROM Clientes, Productos, Vendedores WHERE (Clientes.GuidCliente=Productos.GuidCliente) AND (Vendedores.GuidVendedor=Productos.GuidVendedor) AND " & vQquery
      '"SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "}"
      'strSQL = "SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "})"
      'strSQL = "SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor FROM Clientes, Productos, Vendedores WHERE (Clientes.GuidCliente=Productos.GuidCliente) AND (Vendedores.GuidVendedor=Productos.GuidVendedor) AND " & "Productos.GuidProducto IN (SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "}))"
      'strSQL = "SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor, Productos.ValorCuotaFija FROM Clientes, Productos, Vendedores WHERE (Clientes.GuidCliente=Productos.GuidCliente) AND (Vendedores.GuidVendedor=Productos.GuidVendedor) AND (Productos.NumComprobante Like '%15%')"
      objResult = vObjDB.GetDato(strSQL, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---


      Dim infoConsulta As clsInfoConsultaVentas = Nothing
      For Each dr As DataRow In dt.Rows
        infoConsulta = New clsInfoConsultaVentas
        objResult = CargarRow(infoConsulta, dr)
        If objResult <> Result.OK Then Exit For
        lstConsulta.Add(infoConsulta)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function CargarRow(ByRef vConsulta As clsInfoConsultaVentas, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vConsulta.IDCliente = CStr(IIf(IsDBNull(.Item("NumCliente")), "", .Item("NumCliente")))
        Catch ex As Exception
          vConsulta.IDCliente = ""
          Call Print_msg(ex.Message)
        End Try
        Try
          vConsulta.ClienteNombre = CStr(IIf(IsDBNull(.Item("Clientes.Nombre")), "", .Item("Clientes.Nombre")))
        Catch ex As Exception
          vConsulta.ClienteNombre = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vConsulta.ClienteApellido = CStr(IIf(IsDBNull(.Item("Clientes.Apellido")), "", .Item("Clientes.Apellido")))
        Catch ex As Exception
          vConsulta.ClienteApellido = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vConsulta.VendedorNombre = CStr(IIf(IsDBNull(.Item("Vendedores.Nombre")), "", .Item("Vendedores.Nombre")))
        Catch ex As Exception
          vConsulta.VendedorNombre = ""
          Call Print_msg(ex.Message)
        End Try
        Try
          vConsulta.VendedorApellido = CStr(IIf(IsDBNull(.Item("Vendedores.Apellido")), "", .Item("Vendedores.Apellido")))
        Catch ex As Exception
          vConsulta.VendedorApellido = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vConsulta.IDContrato = CInt(IIf(IsDBNull(.Item("NumComprobante")), -1, .Item("NumComprobante")))
        Catch ex As Exception
          vConsulta.IDContrato = -1
          Call Print_msg(ex.Message)
        End Try

       

        Try
          vConsulta.TotalCuotas = CInt(IIf(IsDBNull(.Item("TotalCuotas")), 0, .Item("TotalCuotas")))
        Catch ex As Exception
          vConsulta.TotalCuotas = 0
          Call Print_msg(ex.Message)
        End Try



        Try
          vConsulta.GUID_Cliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Guid.Empty, .Item("GuidCliente")), Guid)
        Catch ex As Exception
          vConsulta.GUID_Cliente = Guid.Empty
          Call Print_msg(ex.Message)
        End Try

        Try
          vConsulta.Guid_Producto = CType(IIf(IsDBNull(.Item("GuidProducto")), Guid.Empty, .Item("GuidProducto")), Guid)
        Catch ex As Exception
          vConsulta.Guid_Producto = Guid.Empty
          Call Print_msg(ex.Message)
        End Try

        Try
          vConsulta.Guid_Vendedor = CType(IIf(IsDBNull(.Item("GuidVendedor")), Guid.Empty, .Item("GuidVendedor")), Guid)
        Catch ex As Exception
          vConsulta.Guid_Vendedor = Guid.Empty
          Call Print_msg(ex.Message)
        End Try

        
        Try
          vConsulta.ValorCuota = CDec(IIf(IsDBNull(.Item("ValorCuotaFija")), -1, .Item("ValorCuotaFija")))
        Catch ex As Exception
          vConsulta.ValorCuota = -1
          Call Print_msg(ex.Message)
        End Try

      End With

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  'Public Shared Function ConsultaInformacionPrincipal(ByVal vConsulta As clsInfoConsultaVentas, ByRef rInfoAdicional As clsInfoPrincipal) As Result
  '  Try
  '    Dim objDB As libDB.clsAcceso = Nothing
  '    Dim objResult As Result = Result.OK
  '    Try
  '      objDB = New libDB.clsAcceso

  '      objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
  '      If objResult <> Result.OK Then Exit Try

  '      objResult = queryInfoPrincipal(objDB, vConsulta, rInfoAdicional)
  '      If objResult <> Result.OK Then Exit Try

  '    Catch ex As Exception
  '      Call Print_msg(ex.Message)
  '      objResult = Result.ErrorEx

  '    Finally
  '      If objDB IsNot Nothing Then
  '        If objResult <> Result.OK Then
  '          objDB.CloseDB()
  '        Else
  '          objResult = objDB.CloseDB()
  '        End If
  '      End If
  '    End Try

  '    Return objResult

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  'Private Shared Function queryInfoPrincipal(ByVal vObjDB As libDB.clsAcceso, ByVal vConsulta As clsInfoConsultaVentas, ByRef rInfoAdicional As clsInfoPrincipal) As Result
  '  Try
  '    Dim objResult As Result = Result.OK
  '    Dim dt As DataTable = Nothing
  '    Dim strSQL As String

  '    strSQL = "SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor FROM Clientes, Productos, Vendedores WHERE (Clientes.GuidCliente=Productos.GuidCliente) AND (Vendedores.GuidVendedor=Productos.GuidVendedor) AND " & vQquery
  '    '"SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "}"
  '    'strSQL = "SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "})"
  '    'strSQL = "SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor FROM Clientes, Productos, Vendedores WHERE (Clientes.GuidCliente=Productos.GuidCliente) AND (Vendedores.GuidVendedor=Productos.GuidVendedor) AND " & "Productos.GuidProducto IN (SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "}))"
  '    objResult = vObjDB.GetDato(strSQL, dt)

  '    '--- Devuelvo OK cuando no hay resultados -->
  '    If objResult = Result.NOK Then Return Result.OK
  '    If objResult <> Result.OK Then Return objResult
  '    '<-- Devuelvo OK cuando no hay resultados ---

  '    '<-- Comando en DB ---


  '    Dim infoConsulta As clsInfoConsultaVentas = Nothing
  '    For Each dr As DataRow In dt.Rows
  '      infoConsulta = New clsInfoConsultaVentas
  '      objResult = CargarRow(infoConsulta, dr)
  '      If objResult <> Result.OK Then Exit For
  '      lstConsulta.Add(infoConsulta)
  '    Next

  '    Return Result.OK
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

End Class
