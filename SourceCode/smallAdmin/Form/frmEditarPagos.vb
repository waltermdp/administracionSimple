Imports manDB
Imports libCommon.Comunes

Public Class frmEditarPagos

  Private m_Producto As clsInfoProducto
  Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_skip As Boolean
  Private m_CurrentCuota As New clsInfoPagos
  Private m_Result As Result = Result.CANCEL

  Public Sub New(ByVal vProducto As clsInfoProducto)

    ' This call is required by the designer.

    Try
      m_skip = True
      InitializeComponent()
      m_skip = False
      If Not (vProducto Is Nothing) Then
        m_Producto = vProducto.Clone
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Private Sub frmEstablecerPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      m_skip = True




      DesactivarBotones()


      InformacionCuotas()

      m_skip = False

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub DesactivarBotones()
    Try
      btnAplicaPago.Enabled = False
      btnClearPago.Enabled = False
      btnSeleccionarCuenta.Enabled = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Function GetFormaDePago(ByVal vGuid As Guid) As String
    Try
      Return clsModoDebito.ATexto(vGuid)
    Catch ex As Exception
      Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function

  Public Sub InformacionCuotas()
    Try

      Dim vResult As libCommon.Comunes.Result = clsPago.Load(m_lstPagos, m_Producto.GuidProducto) 'desde la base de datos

      If vResult = Result.OK Then
        For Each cuota In m_lstPagos
          Dim objCuenta As New clsInfoCuenta
          If clsCuenta.Load(cuota.GuidCuenta, objCuenta) <> Result.OK Then
            ' MsgBox("No se puede cargar el valor actual de la cuenta de la cuota seleccionada")
          End If
          cuota.MetodoDePago = objCuenta.TipoCuentaToString
        Next
        ClsInfoPagosBindingSource.DataSource = m_lstPagos
        ClsInfoPagosBindingSource.ResetBindings(False)
      End If
      With m_Producto
        txtNumVenta.Text = .NumComprobante.ToString
        txtFechaVenta.Text = .FechaVenta.ToString("dd/MM/yyyy")
        txtPrecioTotal.Text = .Precio.ToString
        txtDiaVencimiento.Text = .FechaPrimerPago.Day.ToString
        txtPrecioCuota.Text = .ValorCuotaFija.ToString
        Dim vCliente As ClsInfoPersona = Nothing
        If clsPersona.Load(.GuidCliente, vCliente) = Result.OK Then
          txtNombreCliente.Text = vCliente.ToString
        End If
        Dim vVendedor As clsInfoVendedor = Nothing
        If clsVendedor.Load(.GuidVendedor, vVendedor) = Result.OK Then
          txtNombreVendedor.Text = vVendedor.ToString
        End If
      End With



      'With m_Producto
      '  If m_Producto.GuidProducto = Guid.Empty Then
      '    'valores iniciales
      '    DateVenta.Value = g_Today
      '    dtProximoPago.Value = New Date(g_Today.Year, g_Today.AddMonths(1).Month, 1)
      '    txtPrecioTotal.SetDecimalMonedaValue(0)
      '    txtNumVenta.Text = GetProximoComprobanteDisponible().ToString
      '    cmbCuotas.SelectedItem = 0
      '    txtValorCuota.SetDecimalMonedaValue(0)
      '    m_lstPagos.Clear()
      '    lvPlanPagos.Items.Clear()
      '    txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
      '    txtAdelanto.SetDecimalMonedaValue(0)
      '    txtAdelantoVendedor.SetDecimalMonedaValue(0)
      '  Else
      '    DateVenta.Value = .FechaVenta
      '    dtProximoPago.MinDate = DateVenta.Value
      '    dtProximoPago.Value = .FechaPrimerPago
      '    txtPrecioTotal.SetDecimalMonedaValue(.Precio) '.Text = .Precio.ToString  'precio total
      '    txtNumVenta.Text = .NumComprobante.ToString
      '    For Each cuota In g_Cuotas
      '      If cuota.Cantidad = .TotalCuotas Then
      '        cmbCuotas.SelectedItem = cuota
      '        Exit For
      '      End If
      '    Next
      '    If .ListaPagos.Count > 0 Then
      '      txtValorCuota.SetDecimalMonedaValue(.ValorCuotaFija) '.Text = .ValorCuotaFija.ToString
      '    Else
      '      txtValorCuota.SetDecimalMonedaValue(.Precio) '.Text = .Precio.ToString
      '    End If
      '    txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
      '    lvPlanPagos.Items.Clear()
      '    txtAdelanto.SetDecimalMonedaValue(.Adelanto)
      '    If m_Adelanto IsNot Nothing Then
      '      txtAdelantoVendedor.SetDecimalMonedaValue(m_Adelanto.Valor)
      '    Else
      '      txtAdelantoVendedor.SetDecimalMonedaValue(0)
      '    End If

      '    For Each pago As clsInfoPagos In .ListaPagos
      '      Dim item As New ListViewItem
      '      item.Text = pago.NumCuota.ToString
      '      item.SubItems.Add(pago.VencimientoCuota.ToString("dd/MM/yyyy"))
      '      item.SubItems.Add(pago.ValorCuota.ToString)
      '      item.SubItems.Add(Date2String(pago.FechaPago)) 'fecha de pago
      '      item.SubItems.Add(EstadoPagos2String(pago.EstadoPago)) 'fecha de pago
      '      lvPlanPagos.Items.Add(item)
      '      m_lstPagos.Add(pago)
      '    Next

      '  End If

      'End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try

      Dim vResult As libCommon.Comunes.Result
      For Each cuota In m_lstPagos
        vResult = clsPago.Save(cuota)
        If vResult <> Result.OK Then
          MsgBox("No se puede guardar la modificacion de cuota")
        End If
      Next

      m_Result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.CANCEL
    End Try
  End Sub


  






 

 


  




  Private Sub btnSeleccionarCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSeleccionarCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_Producto.GuidCliente)
        objForm.ShowDialog(Me)

        Dim objCuenta As clsInfoCuenta = Nothing
        objForm.GetCuentaSeleccionada(objCuenta)
        If Not objCuenta Is Nothing Then
          m_CurrentCuota.GuidCuenta = objCuenta.GuidCuenta
          Dim indice As Integer = m_lstPagos.FindIndex(Function(c) c.NumCuota = m_CurrentCuota.NumCuota)
          If indice >= 0 Then
            If MsgBox("Desea aplicar este metodo de pago para los futuros debitos de cuotas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
              For i As Integer = indice To m_lstPagos.Count - 1
                m_lstPagos(i).GuidCuenta = objCuenta.GuidCuenta
                m_lstPagos(i).MetodoDePago = objCuenta.TipoCuentaToString
              Next
            Else
              m_lstPagos(indice).GuidCuenta = objCuenta.GuidCuenta
              m_lstPagos(indice).MetodoDePago = objCuenta.TipoCuentaToString
            End If

          End If

          txtMedioPagoDescripcion.Text = objCuenta.GetSimpleString
          ClsInfoPagosBindingSource.ResetBindings(False)
          dgvResumen.Refresh()
        End If
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetResult() As Result
    Try
      Return m_Result
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick
    Try
      m_Result = Result.CANCEL
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  
 

  Private Sub dgvData_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResumen.SelectionChanged
    Try

      If dgvResumen.SelectedRows.Count <> 1 Then Exit Sub
      Call Refresh_Selection(dgvResumen.SelectedRows(0).Index)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvResumen.ClearSelection()
        DesactivarBotones()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_CurrentCuota = CType(dgvResumen.Rows(indice).DataBoundItem, manDB.clsInfoPagos)
        Dim objCuenta As New clsInfoCuenta
        If clsCuenta.Load(m_CurrentCuota.GuidCuenta, objCuenta) <> Result.OK Then
          MsgBox("No se puede cargar el valor actual de la cuenta de la cuota seleccionada")
        End If
        txtMedioPagoDescripcion.Text = objCuenta.GetSimpleString
      End If
      If dgvResumen.Rows(indice).Selected <> True Then
        dgvResumen.Rows(indice).Selected = True
      End If
      DesactivarBotones()
      If EsEditable() Then
        If m_CurrentCuota.EstadoPago = E_EstadoPago.Pago Then
          btnClearPago.Enabled = True
        End If
        If m_CurrentCuota.EstadoPago = E_EstadoPago.Debe Then
          btnAplicaPago.Enabled = True
          btnSeleccionarCuenta.Enabled = True
        End If
      End If




    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Function EsEditable() As Boolean
    Try
      If m_CurrentCuota Is Nothing Then Return False
      If m_CurrentCuota.EstadoPago = E_EstadoPago.Debe Then Return True
      If m_CurrentCuota.EstadoPago <> E_EstadoPago.Pago Then Return False
      'estado=pago
      If m_lstPagos.Exists(Function(c) (c.NumCuota > m_CurrentCuota.NumCuota) AndAlso (c.EstadoPago = E_EstadoPago.Pago)) Then Return False
      Return True
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return False
    End Try
  End Function
 
  Private Sub btnAplicaPago_Click(sender As Object, e As EventArgs) Handles btnAplicaPago.Click
    Try
      If m_CurrentCuota.EstadoPago = E_EstadoPago.Debe Then
        m_CurrentCuota.EstadoPago = E_EstadoPago.Pago
        m_CurrentCuota.FechaPago = g_Today
        If m_CurrentCuota.NumCuota < m_Producto.TotalCuotas Then
          'establecer proxima cuota como debe
          'get proxima cuota->establecerla como debe
          Dim indice As Integer = m_lstPagos.FindIndex(Function(c) c.NumCuota = (m_CurrentCuota.NumCuota + 1))

          m_lstPagos(indice).EstadoPago = E_EstadoPago.Debe
          For i As Integer = indice + 1 To m_Producto.TotalCuotas - 1
            If (i = indice + 1) Then
              m_lstPagos(i).EstadoPago = E_EstadoPago.DebeProximo
              Continue For
            End If
            m_lstPagos(i).EstadoPago = E_EstadoPago.DebePendiente
          Next
        End If
      End If
      'ClsInfoPagosBindingSource.DataSource = m_lstPagos
      ClsInfoPagosBindingSource.ResetBindings(False)
      dgvResumen.Refresh()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnClearPago_Click(sender As Object, e As EventArgs) Handles btnClearPago.Click
    Try
      If (m_CurrentCuota.EstadoPago = E_EstadoPago.Pago) AndAlso EsEditable() Then
        m_CurrentCuota.EstadoPago = E_EstadoPago.Debe
        m_CurrentCuota.FechaPago = Date.MinValue

        Dim indice As Integer = m_lstPagos.FindIndex(Function(c) c.NumCuota = (m_CurrentCuota.NumCuota + 1))
        If indice > 0 Then
          For i As Integer = indice To m_Producto.TotalCuotas - 1
            If (i = indice) Then
              m_lstPagos(i).EstadoPago = E_EstadoPago.DebeProximo
              Continue For
            End If

            m_lstPagos(i).EstadoPago = E_EstadoPago.DebePendiente
          Next
        End If

      End If
      ClsInfoPagosBindingSource.ResetBindings(False)
      dgvResumen.Refresh()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class