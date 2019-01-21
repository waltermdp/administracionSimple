Imports Excel = Microsoft.Office.Interop.Excel
Imports libCommon.Comunes
Public Class clsCobros


  Public Shared Function ShowResumen(ByVal vListMov As List(Of clsInfoMovimiento), ByRef rResumen As String) As Result
    Try
      Dim lstResumen As New List(Of clsInfoResumen)
      Dim lineas As New List(Of String)
      lineas.Add("Resumen")

      For Each mov In vListMov



        Dim lstPago As New clsListPagos
        Dim Resumen As New clsInfoResumen

        lstPago.Cfg_Filtro = "where NumComprobante=" & CInt(mov.NumeroComprobante)
        lstPago.RefreshData()
        If lstPago.Items.Count <= 0 Then Continue For

        Resumen.Pago = lstPago.Items.First().Clone
        If IsNumeric(mov.Codigo) Then
          Resumen.Estado = E_EstadoPago.Debe
        End If

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & Resumen.Pago.GuidProducto.ToString & "}"
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



      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Public Shared Function GenerateResumen(ByVal vTipoPago As manDB.clsTipoPago) As Result
    Try
      Dim lstPago As New clsListPagos
      Dim ListMov As New List(Of clsInfoMovimiento)
      Dim movimiento As New clsInfoMovimiento

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()

      For Each item In lstPago.Items
        movimiento = New clsInfoMovimiento

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "} and GuidTipoPago = {" & vTipoPago.GuidTipo.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()
        If lstProducto.Items.Count <= 0 Then Continue For


        Dim lstCuenta As New clsListaCuentas
        lstCuenta.Cfg_Filtro = "where GuidCuenta={" & lstProducto.Items.First.GuidCuenta.ToString & "}"
        lstCuenta.RefreshData()

        Dim lstCliente As New clsListDatabase
        lstCliente.Cfg_Filtro = "where GuidCliente={" & lstProducto.Items.First.GuidCliente.ToString & "}"
        lstCliente.RefreshData()

        Dim auxPrimerPago As New clsListProductos
        auxPrimerPago.Cfg_Filtro = "where (TotalCuotas-CuotasDebe)>=1 and GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
        auxPrimerPago.RefreshData()

        With movimiento
          .NumeroTarjeta = lstCuenta.Items.First.Codigo1
          .NumeroComprobante = item.NumComprobante
          .Importe = item.ValorCuota
          .IdentificadorDebito = lstCliente.Items.First.NumCliente
          .Fecha = Today
          If auxPrimerPago.Items.Count > 0 Then
            .CodigoDeAlta = "N"
          Else
            .CodigoDeAlta = "E"
          End If
        End With
        ListMov.Add(movimiento)
      Next
      If ListMov.Count < 0 Then
        MsgBox("Nada que exportar")
        Return Result.OK
      End If




      Dim rLineas As New List(Of String)
      Select Case vTipoPago.GuidTipo
        Case Guid.Parse("9ebcf274-f84f-42ac-b3de-d375bb3bd314") 'efectivo

        Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito 
          ExportarAVisaDebito(ListMov)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
          ExportarACBU(ListMov)
        Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
          ExportarAVisaCredito(ListMov)
        Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito

        Case Else
          MsgBox("No se encuentra tipo de pago")
      End Select



      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportarAVisaDebito(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      workbook = xls.Workbooks.Open(IO.Path.Combine(Entorno.App_path, "DEBLIQDempty.xls"))
      worksheet = workbook.Worksheets("Facturas")
      For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        worksheet.Cells(i + 2, 1).value = vMovimientos(i).NumeroTarjeta
        worksheet.Cells(i + 2, 2).value = vMovimientos(i).NumeroComprobante
        worksheet.Cells(i + 2, 3).value = Today.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        worksheet.Cells(i + 2, 4).value = vMovimientos(i).Importe 'acepta 1.23
        worksheet.Cells(i + 2, 5).value = vMovimientos(i).IdentificadorDebito
        worksheet.Cells(i + 2, 6).value = vMovimientos(i).CodigoDeAlta  ' N o E ver especificacion
      Next

      workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))

      MsgBox("Finalizo exportacion a excel")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportarAVisaCredito(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      workbook = xls.Workbooks.Open(IO.Path.Combine(Entorno.App_path, "DEBLIQCempty.xls"))
      worksheet = workbook.Worksheets("Facturas")
      For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        worksheet.Cells(i + 2, 1).value = vMovimientos(i).NumeroTarjeta
        worksheet.Cells(i + 2, 2).value = vMovimientos(i).NumeroComprobante
        worksheet.Cells(i + 2, 3).value = Today.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        worksheet.Cells(i + 2, 4).value = vMovimientos(i).Importe 'acepta 1.23
        worksheet.Cells(i + 2, 5).value = vMovimientos(i).IdentificadorDebito
        worksheet.Cells(i + 2, 6).value = vMovimientos(i).CodigoDeAlta  ' N o E ver especificacion
      Next

      workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQC.ree.xls"))

      MsgBox("Finalizo GeneracionArchivo")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportarACBU(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lineas As New List(Of String)
      'Dim xls As New Excel.Application
      'Dim worksheet As Excel.Worksheet
      'Dim workbook As Excel.Workbook
      'workbook = xls.Workbooks.Open(IO.Path.Combine(Entorno.App_path, "DEBLIQDempty.xls"))
      'worksheet = workbook.Worksheets("Facturas")
      lineas.Add("Cantidad: " & vMovimientos.Count.ToString)
      lineas.Add("CBU;NumComprobante;Fecha;Importe;Identificador")
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        linea = vMovimientos(i).NumeroTarjeta.ToString
        linea += ";"
        linea += vMovimientos(i).NumeroComprobante
        linea += ";"
        linea += Today.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        linea += ";"
        linea += vMovimientos(i).Importe 'acepta 1.23
        linea += ";"
        linea += vMovimientos(i).IdentificadorDebito
        linea += ";"
        lineas.Add(linea)
        'Today.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        'worksheet.Cells(i + 2, 2).value = vMovimientos(i).NumeroComprobante
        'worksheet.Cells(i + 2, 3).value =
        'worksheet.Cells(i + 2, 4).value =
        'worksheet.Cells(i + 2, 5).value =
        'worksheet.Cells(i + 2, 6).value = vMovimientos(i).CodigoDeAlta  ' N o E ver especificacion
      Next

      'workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))
      Dim vResult As Result = Save(Today.ToString("yyyyMMddhhmmss") & "_CBU.txt", lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
End Class
