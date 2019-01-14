Imports libCommon.Comunes
Public Class clsCobros


  Public Shared Function ShowResumen(ByVal vListMov As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lstResumen As New List(Of clsInfoResumen)

      For Each mov In vListMov
        Dim lstPago As New clsListPagos
        Dim Resumen As New clsInfoResumen
        lstPago.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante
        lstPago.RefreshData()
        Resumen.Pago = lstPago.Items.First().Clone
        If IsNumeric(mov.Codigo) Then
          Resumen.Estado = E_EstadoPago.Debe
        End If

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & Resumen.Pago.GuidProducto.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()
        Resumen.Producto = lstProducto.Items.First.Clone

        Dim lstCliente As New clsListDatabase("", "")
        lstCliente.Cfg_Filtro = "where GuidCliente={" & Resumen.Producto.GuidCliente.ToString & "}"
        lstCliente.RefreshData()
        Resumen.Cliente = lstCliente.Items.First.Clone


      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Public Shared Function GenerateResumen(ByVal vListMov As List(Of clsInfoMovimiento)) As Result
    Try

      For Each mov In vListMov

      Next
      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class
