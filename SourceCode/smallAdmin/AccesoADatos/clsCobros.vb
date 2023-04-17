Option Strict Off

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

  Public Shared Function ActualizarEstadosDePagos(ByVal vFechaReferencia As Date) As Result
    Try
      'buscar en la tabla pagos si debe modificar algun estado con respecto a la fecha y al debe actual
      Dim lstPago As New clsListPagos
      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe & " or EstadoPago=" & E_EstadoPago.DebeProximo & " or EstadoPago=" & E_EstadoPago.DebePendiente
      lstPago.RefreshData()

      Dim pre As New Func(Of System.Linq.IGrouping(Of System.Guid, manDB.clsInfoPagos), Boolean)(AddressOf NoContieneDebeActual)
      For Each item In lstPago.Items.GroupBy(Function(c) c.GuidProducto).Where(pre)
        If item.Where(Function(c) (c.VencimientoCuota <= vFechaReferencia) AndAlso (c.EstadoPago = E_EstadoPago.DebeProximo)).Count > 0 Then
          'actualizar EstadosPago
          'debeproximo -> debe
          'debePendiente (primero) ->debe proximo

          Dim auxLista As New List(Of manDB.clsInfoPagos)
          Dim auxPago As New manDB.clsInfoPagos
          Dim indiceNewDebe As Integer = item.ToList.FindIndex(Function(c) c.EstadoPago = E_EstadoPago.DebeProximo)
          Dim indiceNewProximo As Integer = -1
          If indiceNewDebe < 0 Then
            MsgBox("Fallo busqueda")
            Return Result.NOK
          End If
          auxPago = item.ToList(indiceNewDebe).Clone
          auxPago.EstadoPago = E_EstadoPago.Debe
          auxLista.Add(auxPago)
          If item.ToList(indiceNewDebe).NumCuota = item.Count Then
            'ultima cuota, no habra proximo pago
            indiceNewProximo = -1
          Else
            Dim nextCuota As Integer = item.ToList(indiceNewDebe).NumCuota + 1
            indiceNewProximo = item.ToList.FindIndex(Function(c) (c.EstadoPago = E_EstadoPago.DebePendiente) AndAlso (c.NumCuota = item.ToList(indiceNewDebe).NumCuota + 1))
            auxPago = New manDB.clsInfoPagos
            auxPago = item.ToList(indiceNewProximo).Clone
            auxPago.EstadoPago = E_EstadoPago.DebeProximo
            auxLista.Add(auxPago)
          End If
          'guardar cambios
          For Each pagoModificado In auxLista
            If clsPago.Save(pagoModificado) <> Result.OK Then
              MsgBox("Fallo al guardar pago")
              Return Result.NOK
            End If

          Next


        End If
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Private Shared Function NoContieneDebeActual(ByVal v As System.Linq.IGrouping(Of System.Guid, manDB.clsInfoPagos)) As Boolean
    Try
      Dim debitar As Boolean = True
      For Each item In v
        If item.EstadoPago = E_EstadoPago.Debe Then
          debitar = False
          Exit For
        End If
      Next
      Return debitar
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function




  Public Shared Function GenerateResumen(ByVal vTipoPago As manDB.clsTipoPago, ByRef rMovimientos As List(Of clsInfoMovimiento)) As Result
    Try

      Dim lstPago As New clsListPagos
      rMovimientos = New List(Of clsInfoMovimiento)
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


        'auxPrimerPago.Cfg_Filtro = "where (TotalCuotas-CuotasDebe)>=1 and GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
        'auxPrimerPago.RefreshData()
        Dim bCodigoAlta As Boolean
        If item.NumCuota > 1 Then
          bCodigoAlta = False
        Else
          'verificar si es la primer cuota, buscan si la cuenta se uso en algun pago de cuota
          Dim auxPrimerPago As New clsListProductos
          Dim bAlta As Boolean = True
          auxPrimerPago.Cfg_Filtro = "where GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
          auxPrimerPago.RefreshData()
          If auxPrimerPago.Items.Count > 1 Then

            For Each producto In auxPrimerPago.Items
              Dim aux As New clsListPagos
              aux.Cfg_Filtro = "where GuidProducto={" & producto.GuidProducto.ToString & "}"
              aux.RefreshData()
              For Each pago In aux.Items
                If pago.EstadoPago = E_EstadoPago.Pago Then
                  bAlta = False
                  Exit For
                End If
              Next
              If bAlta = False Then Exit For
            Next
          End If
          bCodigoAlta = bAlta
        End If
      
        With movimiento
          .NumeroTarjeta = lstCuenta.Items.First.Codigo1
          .NumeroComprobante = lstProducto.Items.First.NumComprobante
          .Importe = item.ValorCuota
          .IdentificadorDebito = lstCliente.Items.First.NumCliente
          .Fecha = g_Today

          If bCodigoAlta = False Then
            .CodigoDeAlta = "N"
            Dim aux As New clsListPagos
            aux.Cfg_Filtro = "where NumComprobante=" & lstProducto.Items.First.NumComprobante
            aux.RefreshData()
            For Each pago In aux.Items.OrderByDescending(Function(c) c.NumCuota)
              If pago.EstadoPago <> E_EstadoPago.Pago Then Continue For
              .CuotaActual = pago.NumCuota
              .UltimaFechPago = pago.FechaPago.ToString("dd/MM/yy")
              Exit For
            Next

          Else
            .CodigoDeAlta = "E"
          End If
          .Param2 = lstProducto.Items.First.TotalCuotas  'NUMERO TOTAL DE CUOTAS
          .Nombre = lstCliente.Items.First.ToString

        End With
        rMovimientos.Add(movimiento)
      Next
      If rMovimientos.Count < 0 Then
        MsgBox("Nada que exportar")
      End If








      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Sub Exportar(ByVal vMovimientos As List(Of clsInfoMovimiento), ByVal vGuidTipoPago As Guid)
    Try
      Select Case vGuidTipoPago
        Case Guid.Parse("9ebcf274-f84f-42ac-b3de-d375bb3bd314") 'efectivo
          ExportAEfectivo(vMovimientos)
        Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito 
          ExportarAVisaDebito(vMovimientos)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
          ExportarACBU(vMovimientos)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117926") 'CBU Hipotecario
          ExportarADebitoHipotecario(vMovimientos)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117927") 'CBU Patagonia
          ExportarADebitoPatagonia(vMovimientos)
        Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
          ExportarAVisaCredito(vMovimientos)
        Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito
          ExportAMaster(vMovimientos)
        Case Guid.Parse("598878be-b8b3-4b1b-9261-f989f0800afc") 'Mercado Pago
          ExportAMercadoPago(vMovimientos)
        Case Else
          MsgBox("No se encuentra tipo de pago")
      End Select
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  'Verificado
  Private Shared Function ExportarAVisaDebito(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      ExportVisaTXT(vMovimientos, "DEBLIQD")
      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      IO.File.Copy(IO.Path.Combine(MODEL_PATH, "DEBLIQDempty.xls"), IO.Path.Combine(TEMP_PATH, "DEBLIQD.xls"), True)

      workbook = xls.Workbooks.Open(IO.Path.Combine(TEMP_PATH, "DEBLIQD.xls"))
      Try
        worksheet = workbook.Worksheets("Facturas")
        For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
          worksheet.Cells(i + 2, 1).value = vMovimientos(i).NumeroTarjeta
          worksheet.Cells(i + 2, 2).value = vMovimientos(i).NumeroComprobante
          worksheet.Cells(i + 2, 3).value = GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
          worksheet.Cells(i + 2, 4).value = vMovimientos(i).Importe 'acepta 1.23
          worksheet.Cells(i + 2, 5).value = vMovimientos(i).IdentificadorDebito
          worksheet.Cells(i + 2, 6).value = vMovimientos(i).CodigoDeAlta  ' N o E ver especificacion
        Next

        workbook.SaveCopyAs(IO.Path.Combine(EXPORT_PATH, GetHoy.ToString("yyMMdd") & "_DEBLIQD.10.xls"))
      Finally
        workbook.Close(False)
      End Try



      MsgBox("Finalizo exportacion a excel")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try
  End Function

  Private Shared Function ExportVisaTXT(ByVal vMovimientos As List(Of clsInfoMovimiento), ByVal constante As String) As Result
    Try
      Dim lineas As New List(Of String)
      Dim aux As String = String.Empty
      Dim FechaGeneracion As Date = GetAhora()
      'HEADER
      aux = "0"
      aux += constante.PadRight(8, " ")
      aux += "40832883".PadLeft(10, "0") 'NUMERO DE ESTABLECIMIENTO 900000
      aux += "900000".PadRight(10, " ")
      aux += FechaGeneracion.ToString("yyyyMMdd").PadLeft(8)
      aux += FechaGeneracion.ToString("hhmm").PadLeft(4)
      aux += "0".PadLeft(1)
      aux += " ".PadLeft(2, " ")
      aux += " ".PadLeft(55, " ")
      aux += "*".PadLeft(1)
      lineas.Add(aux)

      'BODY
      For Each movimiento In vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante))
        aux = "1"
        aux += movimiento.NumeroTarjeta.PadLeft(16)
        aux += " ".PadLeft(3, " ")
        aux += movimiento.NumeroComprobante.PadLeft(8, "0")
        aux += GetHoy.ToString("yyyyMMdd").PadLeft(8)
        aux += "0005".PadLeft(4)
        aux += CInt(CSng(movimiento.Importe) * 100).ToString.PadLeft(15, "0")
        aux += movimiento.IdentificadorDebito.PadLeft(15, "0")
        aux += IIf(movimiento.CodigoDeAlta = "E", "E", " ").ToString
        aux += " ".PadLeft(2, " ")
        aux += " ".PadLeft(26, " ")
        aux += "*".PadLeft(1)
        lineas.Add(aux)
      Next

      'TAIL
      aux = "9"
      aux += constante.PadRight(8, " ")
      aux += "40832883".PadLeft(10, "0") 'NUMERO DE ESTABLECIMIENTO
      aux += "900000".PadRight(10, " ")
      aux += FechaGeneracion.ToString("yyyyMMdd").PadLeft(8)
      aux += FechaGeneracion.ToString("hhmm").PadLeft(4)
      aux += vMovimientos.Count.ToString.PadLeft(7, "0")
      aux += CInt(vMovimientos.Sum(Function(c) CSng(c.Importe)) * 100).ToString.PadLeft(15, "0")
      aux += " ".PadLeft(36, " ")
      aux += "*".PadLeft(1)
      lineas.Add(aux)

      Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, FechaGeneracion.ToString("yyyyMMddhhmm") & "_" & constante & ".txt"), lineas)
      Return vResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  'verificado
  Private Shared Function ExportarAVisaCredito(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      ExportVisaTXT(vMovimientos, "DEBLIQC")
      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      IO.File.Copy(IO.Path.Combine(MODEL_PATH, "DEBLIQCempty.xls"), IO.Path.Combine(TEMP_PATH, "DEBLIQC.xls"), True)
      workbook = xls.Workbooks.Open(IO.Path.Combine(TEMP_PATH, "DEBLIQC.xls"))
      Try
        worksheet = workbook.Worksheets("Facturas")
        Dim lista As List(Of clsInfoMovimiento) = vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante)).ToList
        For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
          worksheet.Cells(i + 2, 1).value = lista(i).NumeroTarjeta
          worksheet.Cells(i + 2, 2).value = lista(i).NumeroComprobante
          worksheet.Cells(i + 2, 3).value = GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
          worksheet.Cells(i + 2, 4).value = lista(i).Importe 'acepta 1.23
          worksheet.Cells(i + 2, 5).value = lista(i).IdentificadorDebito
          worksheet.Cells(i + 2, 6).value = lista(i).CodigoDeAlta  ' N o E ver especificacion
        Next

        workbook.SaveCopyAs(IO.Path.Combine(EXPORT_PATH, GetHoy.ToString("yyMMdd") & "_DEBLIQC.ree.xls"))

      Finally
        workbook.Close(False)
      End Try

      MsgBox("Finalizo GeneracionArchivo")


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportAMaster(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try

      Dim lineas As New List(Of String)
      'NUMERO DE COMERCIO
      For Each item In vMovimientos
        item.Param1 = "24063119"
      Next
      Dim periodo As String = GetAhora.ToString("MM/yy")

      'HEADER
      Dim header As String = String.Empty
      header += vMovimientos.First.Param1.PadLeft(8, "0") 'Numero de comercio
      header += "1" 'identificador fijo
      header += GetAhora.ToString("ddMMyy").PadLeft(6)
      header += vMovimientos.Count.ToString.PadLeft(7, "0") 'Cantidad de registros
      header += "0" 'signo
      header += vMovimientos.Sum(Function(c) c.Importe * 100).ToString.PadLeft(14, "0")
      header += " ".PadLeft(91, " ")


      lineas.Add(header)
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1
        linea = vMovimientos(i).Param1.PadLeft(8, "0") 'NUMERO DE COMERCIO
        linea += "2" 'Tipo de registro 2 o 3
        linea += vMovimientos(i).NumeroTarjeta.PadLeft(16, "0")
        linea += vMovimientos(i).IdentificadorDebito.PadLeft(12, "0") 'NUMERO DE REFERENCIA' identificacion del socio
        linea += "1".PadLeft(3, "0")  'cuotas
        linea += vMovimientos(i).Param2.PadLeft(3, "0") 'CUOTAS PLAN
        linea += "01" 'FRECUENCIA DB
        linea += (vMovimientos(i).Importe * 100).ToString.PadLeft(11, "0") 'IMPORTE
        linea += periodo.PadLeft(5, " ") 'PERIODO
        linea += " "
        linea += GetAhora.AddMonths(1).ToString("ddMMyy").PadLeft(6) 'FECHA VENCIMIENTO PAGO
        linea += vMovimientos(i).NumeroComprobante.PadLeft(40, " ") 'datos auxiliares
        linea += " ".PadLeft(20, " ") 'filler
        lineas.Add(linea)
      Next
      Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_Master.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  'no es real
  Private Shared Function ExportarACBU(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lineas As New List(Of String)

      lineas.Add("Cantidad: " & vMovimientos.Count.ToString)
      lineas.Add("CBU;NumComprobante;Fecha;Importe;Identificador")
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        linea = vMovimientos(i).NumeroTarjeta.ToString
        linea += ";"
        linea += vMovimientos(i).NumeroComprobante
        linea += ";"
        linea += GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        linea += ";"
        linea += vMovimientos(i).Importe 'acepta 1.23
        linea += ";"
        linea += vMovimientos(i).IdentificadorDebito
        linea += ";"
        lineas.Add(linea)
      Next

      'workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))
      Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_CBU.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportarADebitoHipotecario(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lineas As New List(Of String)
      Dim objHipotecario As New clsHipotecario

      lineas.Add("Cantidad: " & vMovimientos.Count.ToString)
      lineas.Add("CBU;NumComprobante;Fecha;Importe;Identificador")
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos
        linea = vMovimientos(i).NumeroTarjeta.ToString
        linea += ";"
        linea += vMovimientos(i).NumeroComprobante
        linea += ";"
        linea += GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        linea += ";"
        linea += vMovimientos(i).Importe 'acepta 1.23
        linea += ";"
        linea += vMovimientos(i).IdentificadorDebito
        linea += ";"
        lineas.Add(linea)
      Next

      'workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))
      Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_CBU.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function ExportarADebitoPatagonia(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
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
        linea += GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        linea += ";"
        linea += vMovimientos(i).Importe 'acepta 1.23
        linea += ";"
        linea += vMovimientos(i).IdentificadorDebito
        linea += ";"
        lineas.Add(linea)
      Next

      'workbook.SaveCopyAs(IO.Path.Combine(Entorno.App_path, Today.ToString("yyMMdd") & "_DEBLIQD.10.xls"))
      Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_CBU.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  'customizado
  Private Shared Function ExportAEfectivo(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lineas As New List(Of String)

      lineas.Add("Cantidad: " & vMovimientos.Count.ToString)
      lineas.Add("NumComprobante;".PadLeft(15) & "Identificador;".PadLeft(14) & "Fecha;".PadLeft(12) & "Importe;".PadLeft(10))
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1
        linea = String.Format("{0};", vMovimientos(i).NumeroComprobante).PadLeft(15)
        linea += String.Format("{0};", vMovimientos(i).IdentificadorDebito).PadLeft(14)
        linea += String.Format("{0};", GetHoy.ToString("dd/MM/yyyy")).PadLeft(12)
        linea += String.Format("{0};", vMovimientos(i).Importe).PadLeft(10)
        lineas.Add(linea)
      Next
      Dim vResult As Result = Save(IO.Path.Combine(GetAhora.ToString("yyyyMMddhhmmss") & "_Efectivo.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  'customizado
  Private Shared Function ExportAMercadoPago(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      Dim lineas As New List(Of String)

      lineas.Add("Cantidad: " & vMovimientos.Count.ToString)
      lineas.Add("NumComprobante;".PadLeft(15) & "Identificador;".PadLeft(14) & "Fecha;".PadLeft(12) & "Importe;".PadLeft(10))
      Dim linea As String = String.Empty
      For i As Integer = 0 To vMovimientos.Count - 1
        linea = String.Format("{0};", vMovimientos(i).NumeroComprobante).PadLeft(15)
        linea += String.Format("{0};", vMovimientos(i).IdentificadorDebito).PadLeft(14)
        linea += String.Format("{0};", GetHoy.ToString("dd/MM/yyyy")).PadLeft(12)
        linea += String.Format("{0};", vMovimientos(i).Importe).PadLeft(10)
        lineas.Add(linea)
      Next
      Dim vResult As Result = Save(IO.Path.Combine(GetAhora.ToString("yyyyMMddhhmmss") & "_MercadoPago.txt"), lineas)
      MsgBox("Finalizo exportacion a txt")

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function





End Class
