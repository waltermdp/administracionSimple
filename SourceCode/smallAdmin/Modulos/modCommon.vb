Module modCommon


  Public Enum E_EstadoPago As Integer
    Debe = 0
    Pago = 1
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

  Public Function GetProximoPago(ByVal vGuidProducto As Guid, ByVal vValorCuota As Decimal, ByVal vNumCuota As Integer, ByVal vPrimerVencimiento As Date) As manDB.clsInfoPagos
    Try
      Dim pago As New manDB.clsInfoPagos
      pago.EstadoPago = E_EstadoPago.Debe
      pago.GuidProducto = vGuidProducto
      pago.GuidPago = Guid.NewGuid
      pago.FechaPago = Date.MaxValue ' Vencimiento(auxCuotas, datePrimerPago.Value)
      pago.VencimientoCuota = Vencimiento(vNumCuota, vPrimerVencimiento)
      pago.NumCuota = vNumCuota
      pago.ValorCuota = vValorCuota
      Return pago
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return Nothing
    End Try
  End Function

  Private Function Vencimiento(ByVal Cuota As Integer, ByVal vPrimerVencimiento As Date) As Date
    Try

      Return vPrimerVencimiento.AddMonths(Cuota)
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return vPrimerVencimiento
    End Try
  End Function
End Module
