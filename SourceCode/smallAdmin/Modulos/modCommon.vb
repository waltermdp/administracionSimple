Imports libCommon.Comunes
Module modCommon

  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"


  Public Function GetNameOfTipoPago(ByVal vGuid As Guid) As String
    Try
      If g_TipoPago Is Nothing Then Return "--"
      For Each item In g_TipoPago
        If item.GuidTipo = vGuid Then
          Return item.ToString
        End If
      Next
      Return "--"
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return "--"
    End Try
  End Function

  Public Function GetProximoPago(ByVal vGuidProducto As Guid, ByVal NumComprobante As Integer, ByVal vValorCuota As Decimal, ByVal vNumCuota As Integer, ByVal vFechaVenta As Date, ByVal vPrimerVencimiento As Date, Optional ByVal vFechaVencimiento As Date = Nothing) As manDB.clsInfoPagos
    Try
      Dim pago As New manDB.clsInfoPagos
      pago.EstadoPago = libCommon.Comunes.E_EstadoPago.Debe
      pago.GuidProducto = vGuidProducto
      pago.GuidPago = Guid.NewGuid
      pago.FechaPago = Date.MaxValue ' Vencimiento(auxCuotas, datePrimerPago.Value)
      If vFechaVencimiento = Nothing Then
        pago.VencimientoCuota = Vencimiento(vPrimerVencimiento)
      Else
        pago.VencimientoCuota = vFechaVencimiento
      End If
      pago.NumCuota = vNumCuota
      pago.ValorCuota = vValorCuota
      pago.NumComprobante = NumComprobante


      Return pago
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return Nothing
    End Try
  End Function

  Public Function Vencimiento(ByVal PrimerPago As Date, Optional ByVal fechaInicial As Date = Nothing) As Date
    Try
      If fechaInicial = Nothing Then
        fechaInicial = Today
      End If
      Dim DiaDePago As Integer = PrimerPago.Day
      fechaInicial = fechaInicial.AddMonths(1)
      If PrimerPago.Day > DateTime.DaysInMonth(fechaInicial.Year, fechaInicial.Month) Then
        DiaDePago = DateTime.DaysInMonth(fechaInicial.Year, fechaInicial.Month)
      End If
      Dim auxFecha As New Date(fechaInicial.Year, fechaInicial.Month, DiaDePago)

      Return auxFecha
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return PrimerPago
    End Try
  End Function

  Public Function DebePeriodoActual(ByVal lstPagos As List(Of manDB.clsInfoPagos)) As Boolean
    Try
      Dim pagadas As Integer = 0
      If lstPagos.Where(Function(c) c.EstadoPago = 1).ToList.Count <= 0 Then Return True
      Dim auxpago As manDB.clsInfoPagos = lstPagos.Where(Function(c) c.EstadoPago = 1).OrderBy(Function(c) c.NumCuota).ToList.Last
      If Today < auxpago.VencimientoCuota Then
        Return False
      End If
      Return True
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return True
    End Try
  End Function

  Public Function FillString(ByVal texto As String, ByVal lenFinal As Integer, ByVal caracter As Char) As String
    Try
      If caracter = String.Empty Then Return texto

      For i As Integer = 0 To lenFinal - texto.Length
        texto = texto.Insert(0, caracter)
      Next
      Return texto
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return texto
    End Try
  End Function

  Public Sub ActualizarCuotasVencidas()
    Try
      'Marcar los pagos vencidos como Vencidos y crear un nuevo talon de pago
      Dim vResult As libCommon.Comunes.Result
      Dim lstPago As New List(Of manDB.clsInfoPagos)
      Dim aux As New clsListPagos
      aux.Cfg_Filtro = "where (Pagos.VencimientoCuota < #" & Format(Today, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
      aux.RefreshData()
      lstPago.AddRange(aux.Items)
      For Each item In aux.Items
        item.EstadoPago = E_EstadoPago.Vencido
        vResult = clsPago.Save(item)
        If vResult <> Result.OK Then
          MsgBox("Fallo update pago")
          Exit Sub
        End If
        Dim objProducto As New manDB.clsInfoProducto
        vResult = clsProducto.Load(item.GuidProducto, objProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo load producto")
          Exit Sub
        End If
        Dim newpago As manDB.clsInfoPagos = GetProximoPago(item.GuidProducto, objProducto.NumComprobante, objProducto.ValorCuotaFija, item.NumCuota, objProducto.FechaVenta, objProducto.FechaPrimerPago)
        If newpago IsNot Nothing Then
          vResult = clsPago.Save(newpago)
        Else
          MsgBox("Fallo guardar newpago")
        End If
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Module
