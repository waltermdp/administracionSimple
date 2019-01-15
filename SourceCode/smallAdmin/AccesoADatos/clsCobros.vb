Imports libCommon.Comunes
Public Class clsCobros


  Public Shared Function ShowResumen(ByVal vListMov As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lstResumen As New List(Of clsInfoResumen)

      For Each mov In vListMov
        Dim lstPago As New clsListPagos
        Dim Resumen As New clsInfoResumen

        lstPago.Cfg_Filtro = "where NumComprobante=" & CInt(mov.NumeroComprobante)
        lstPago.RefreshData()

        Resumen.Pago = lstPago.Items.First().Clone
        If IsNumeric(mov.Codigo) Then
          Resumen.Estado = E_EstadoPago.Debe
        End If

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & Resumen.Pago.GuidProducto.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()
        Resumen.Producto = lstProducto.Items.First.Clone

        Dim lstCliente As New clsListDatabase()
        lstCliente.Cfg_Filtro = "where GuidCliente={" & Resumen.Producto.GuidCliente.ToString & "}"
        lstCliente.RefreshData()
        Resumen.Cliente = lstCliente.Items.First.Clone
        lstResumen.Add(Resumen)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Public Shared Function GenerateResumen() As Result
    Try
      Dim lstPago As New clsListPagos
      Dim ListMov As New List(Of clsInfoMovimiento)
      Dim movimiento As New clsInfoMovimiento

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()

      For Each item In lstPago.Items
        movimiento = New clsInfoMovimiento

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()

        Dim lstCuenta As New clsListaCuentas
        lstCuenta.Cfg_Filtro = "where GuidCuenta={" & lstProducto.Items.First.GuidCuenta.ToString & "}"
        lstCuenta.RefreshData()

        Dim lstCliente As New clsListDatabase
        lstCliente.Cfg_Filtro = "where GuidCliente={" & lstProducto.Items.First.GuidCliente.ToString & "}"
        lstCliente.RefreshData()

        With movimiento
          .NumeroTarjeta = lstCuenta.Items.First.Codigo1
          .NumeroComprobante = item.NumComprobante
          .Importe = item.ValorCuota
          .IdentificadorDebito = lstCliente.Items.First.NumCliente
          .Fecha = Today
        End With
      Next


        Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class
