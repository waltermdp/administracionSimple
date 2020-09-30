Imports manDB
Imports libCommon.Comunes

Public Class frmDetalle
  Private m_CurrentCuenta As clsInfoCuenta
  Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_Cliente As New clsInfoCliente


  Public Sub New(ByVal vPersona As ClsInfoPersona, ByVal vResumen As String, ByVal vSResumen As frmResumen.S_EntradaCredito)
    Try
      InitializeComponent()
      If vPersona.GuidCliente = Guid.Empty Then
        Exit Sub
      End If
      lblResumen.Text = "Resumen: " & vResumen
      If clsCliente.Cliente_Load(vPersona.GuidCliente, m_Cliente) <> Result.OK Then
        MsgBox("no existe cliente")
        Exit Sub
      End If

      Call ReloadListProductos()
      txtEntrada.Text = txtEntrada.Text & "DNI: " & vSResumen.IDCliente & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "NOMBRE:: " & vSResumen.Nombre & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "NUM TARJETA: " & vSResumen.NumTarjeta & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "IMPORTE: " & vSResumen.Importe & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "ESTADO: " & vSResumen.Estado & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "NUM COMPROBANTE: " & vSResumen.Comprobante & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "ULTIMA CUOTA PAGA: " & vSResumen.UltimaCuotapaga & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "ULTIMO PAGO: " & vSResumen.FechaUltimoPago & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "FECHA PAGO ACTUAL: " & vSResumen.FechapagoActual & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "DETALLE: " & vSResumen.Detalle & vbNewLine
      txtEntrada.Text = txtEntrada.Text & "HABILITADO: " & vSResumen.AplicarPago
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub ReloadListPagos()
    Try

      bsCuotas.DataSource = m_lstPagos ' m_Producto.ListaPagos
      bsCuotas.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ReloadListProductos()
    Try
      bsProducto.DataSource = m_Cliente.ListaProductos
      bsProducto.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call ReloadListPagos()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvProductos_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvProductos.DataError
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
    Try
      If dgvProductos.SelectedRows.Count <> 1 Then Exit Sub
      Dim index As Integer = dgvProductos.SelectedRows(0).Index
      If dgvProductos.Rows(index).Selected <> True Then
        dgvProductos.Rows(index).Selected = True
      End If
      Call CargarListaPagos()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarListaPagos()
    Try
      Dim index As Integer = dgvProductos.SelectedRows(0).Index
      Dim aux As clsInfoProducto = CType(dgvProductos.Rows(index).DataBoundItem, manDB.clsInfoProducto)
      m_lstPagos.Clear()
      If clsPago.Load(m_lstPagos, aux.GuidProducto) <> Result.OK Then
        Exit Sub
      End If


      Call ReloadListPagos()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Try

      Dim vInfoCuenta As clsInfoCuenta = Nothing
      Using objCuenta As New frmCuenta(m_Cliente.Personal.GuidCliente, True)
        objCuenta.ShowDialog(Me)
        objCuenta.GetCuentaSeleccionada(vInfoCuenta)
      End Using
      If vInfoCuenta Is Nothing Then
        'Sin cambios. salir
        Exit Sub
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class