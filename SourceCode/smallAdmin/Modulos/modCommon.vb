Module modCommon


  Public Enum E_EstadoPago As Integer
    Debe = 0
    Pago = 1
    Anulo_Editado = 2  'Se anula el pago para generar uno nuevo
    Vencido = 3  'se anula el pago porque no pago dentro del plazo
  End Enum

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

  Public Function GetProximoPago(ByVal vGuidProducto As Guid, ByVal vValorCuota As Decimal, ByVal vNumCuota As Integer, ByVal vFechaVenta As Date, ByVal vPrimerVencimiento As Date) As manDB.clsInfoPagos
    Try
      Dim pago As New manDB.clsInfoPagos
      pago.EstadoPago = E_EstadoPago.Debe
      pago.GuidProducto = vGuidProducto
      pago.GuidPago = Guid.NewGuid
      pago.FechaPago = Date.MaxValue ' Vencimiento(auxCuotas, datePrimerPago.Value)
      pago.VencimientoCuota = Vencimiento(vNumCuota, vFechaVenta, vPrimerVencimiento)
      pago.NumCuota = vNumCuota
      pago.ValorCuota = vValorCuota
      Return pago
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return Nothing
    End Try
  End Function


  Public Function Vencimiento(ByVal Cuota As Integer, ByVal vFechaVenta As Date, ByVal PrimerPago As Date) As Date
    Try

      vFechaVenta = vFechaVenta.AddMonths(Cuota)
      Dim auxFecha As New Date(vFechaVenta.Year, vFechaVenta.Month, PrimerPago.Day)
      If auxFecha < Today Then
        aux()
        auxFecha = New Date(vFechaVenta.Year, vFechaVenta.Month, PrimerPago.Day)
      End If
      Return New Date(vFechaVenta.Year, vFechaVenta.Month, PrimerPago.Day)
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


End Module
