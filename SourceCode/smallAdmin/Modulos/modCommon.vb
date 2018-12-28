Module modCommon
  Public gCliente As manDB.clsInfoCliente

  Public Enum E_EstadoPago As Integer
    Debe = 0
    Pago = 1
  End Enum

  Public Function GetStringResumen(ByVal vTipoPago As manDB.clsInfoCuenta) As String
    Try
      If g_TipoPago Is Nothing Then Return "--"
      If vTipoPago Is Nothing Then Return "--"
      For Each item In g_TipoPago
        If item.GuidTipo = vTipoPago.TipoDeCuenta Then
          Return item.ToString & "--" & vTipoPago.Codigo1.ToString
        End If
      Next
      Return "--"
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return "--"
    End Try
  End Function

End Module
