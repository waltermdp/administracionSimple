Imports Excel = Microsoft.Office.Interop.Excel
Imports libCommon.Comunes
Public Class clsCobros


  Public Shared Function ShowResumen(ByVal vListMov As List(Of clsInfoMovimiento), ByRef rResumen As String) As Result
    Try
      Dim lstResumen As New List(Of clsInfoResumen)
      Dim lineas As New List(Of String)
      lineas.Add("Resumen")
      'ConvertirEnArchivo(vListMov)
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
        lineas.Add(String.Format("{},{}", Resumen.Cliente.ToString, Resumen.Estado.ToString))
      Next

      For Each lin In lineas
        rResumen += lin + vbNewLine
      Next


      'ConvertirEnArchivo(vListMov)
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

  Private Shared Function ConvertirEnArchivo(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      workbook = xls.Workbooks.Open(IO.Path.Combine(Entorno.App_path, "DEBLIQDempty.xls"))
      worksheet = workbook.Worksheets("Facturas")
      For i As Integer = 2 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        worksheet.Cells(i, 1).value = vMovimientos(i - 2).NumeroTarjeta
        worksheet.Cells(i, 2).value = vMovimientos(i - 2).NumeroComprobante
        worksheet.Cells(i, 3).value = Today.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        worksheet.Cells(i, 4).value = vMovimientos(i - 2).Importe 'acepta 1.23
        worksheet.Cells(i, 5).value = vMovimientos(i - 2).IdentificadorDebito
        worksheet.Cells(i, 6).value = vMovimientos(i - 2).Param1 ' N o E ver especificacion
      Next

      workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))

      MsgBox("Finalizo exportacion a excel")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class
