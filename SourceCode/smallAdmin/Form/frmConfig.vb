Imports libCommon.Comunes
Public Class frmConfig
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"

  Private Sub btnBack_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBack.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnActualizarPagos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnActualizarPagos.MouseClick
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
        Dim newpago As manDB.clsInfoPagos = GetProximoPago(item.GuidProducto, objProducto.Adelanto, objProducto.ValorCuotaFija, item.NumCuota, objProducto.FechaVenta, objProducto.FechaPrimerPago)
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
End Class