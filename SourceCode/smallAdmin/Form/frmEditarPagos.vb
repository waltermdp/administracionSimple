Imports manDB
Imports libCommon.Comunes

Public Class frmEditarPagos


  Private m_Producto As clsInfoProducto
  Private m_Cliente As ClsInfoPersona
  Private m_Vendedor As clsInfoVendedor

  Private m_Adelanto As clsInfoAdelanto

  Private m_CurrentCuenta As clsInfoCuenta
  Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_skip As Boolean

  Private m_ListCuotas As New clsListPagos
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
      Dim vResult As Result
      m_skip = True
     
      vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
      If vResult <> Result.OK Then
        Call Print_msg("Fallo carga de cuenta")
      End If
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




  Public Sub InformacionCuotas()
    Try

      Dim vResult As libCommon.Comunes.Result = clsPago.Load(m_lstPagos, m_Producto.GuidProducto) 'desde la base de datos
      If vResult = Result.OK Then
        ClsInfoPagosBindingSource.DataSource = m_lstPagos
        ClsInfoPagosBindingSource.ResetBindings(False)
      End If
      With m_Producto
        txtNumVenta.Text = .NumComprobante.ToString
        txtFechaVenta.Text = .FechaVenta.ToString("dd/MM/yyyy")
        txtPrecioTotal.Text = .Precio.ToString
        txtDiaVencimiento.Text = .FechaPrimerPago.Day.ToString
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

  Private Function FillMedioDePagoDescripcion() As String
    Try

      If m_CurrentCuenta Is Nothing Then
        Return "--"
      End If
      Return GetNameOfTipoPago(m_CurrentCuenta.TipoDeCuenta) & " -- " & m_CurrentCuenta.Codigo1.ToString

    Catch ex As Exception
      Print_msg(ex.Message)
      Return "--"
    End Try
  End Function




  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try

      With m_Producto

        

        If m_CurrentCuenta Is Nothing Then
          MsgBox("Debe seleccionar una cuenta")
          Exit Sub
        End If
        If Not m_CurrentCuenta.IsValid Then
          MsgBox("El valor del modo de pago es invalido")
          Exit Sub
        End If


        m_Producto.Cuenta = m_CurrentCuenta




        If m_Cliente.GuidCliente = Guid.Empty Then
          MsgBox("El cliente es invalido")
          Exit Sub
        End If
        If m_Vendedor.GuidVendedor = Guid.Empty Then
          MsgBox("El vendedor es invalido")
          Exit Sub
        End If
        .GuidCliente = m_Cliente.GuidCliente
        .GuidVendedor = m_Vendedor.GuidVendedor
        .GuidCuenta = m_CurrentCuenta.GuidCuenta
        .GuidTipoPago = m_CurrentCuenta.TipoDeCuenta
        If .GuidProducto = Guid.Empty Then
          .GuidProducto = Guid.NewGuid
          If Not EsValidoNumComprobante(CInt(txtNumVenta.Text)) Then
            MsgBox("El numero del comprobate es invalido")
            Exit Sub
          End If
          .NumComprobante = CInt(txtNumVenta.Text)
        Else
          'ya existe
          If CInt(txtNumVenta.Text) <> .NumComprobante Then
            If Not EsValidoNumComprobante(CInt(txtNumVenta.Text)) Then
              MsgBox("El numero del comprobate es invalido")
              Exit Sub
            End If
            .NumComprobante = CInt(txtNumVenta.Text) ' no cambia 
          Else 'iguales
            .NumComprobante = CInt(txtNumVenta.Text) ' no cambia 
          End If
        End If

        .ListaPagos.Clear()
        For Each item In m_lstPagos
          item.GuidProducto = .GuidProducto
          item.NumComprobante = .NumComprobante
          .ListaPagos.Add(item)
        Next

      End With


      m_Result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.CANCEL
    End Try
  End Sub


  
  Private Function FechaProximoDebito(ByVal vFVenta As Date, ByVal vFPrimerPago As Date, ByVal nCuota As Integer, ByRef rFecha As Date) As Result
    Try
      If nCuota < 1 Then Return Result.NOK
      If nCuota = 1 Then
        rFecha = vFPrimerPago
      Else
        rFecha = DateAdd(DateInterval.Month, nCuota - 1, vFPrimerPago)
      End If
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  'Private Sub AplicarPagoAdelantado()
  '  Try
  '    If IsNumeric(txtAdelanto.Text.Trim) Then
  '      If CDec(txtAdelanto.Text) <= 0 Then Exit Sub
  '      Dim AdelantoCuota As Decimal
  '      Dim AdelantoVendedor As Decimal
  '      ConvStr2Dec(txtAdelanto.Text, AdelantoCuota)
  '      ConvStr2Dec(txtAdelantoVendedor.Text, AdelantoVendedor)
  '      Dim Vencimiento As Date




  '      While AdelantoCuota > 0
  '        Dim aux As New clsListPagos
  '        aux.Cfg_Filtro = "where GuidProducto={" & m_Producto.GuidProducto.ToString & "} and EstadoPago= " & E_EstadoPago.Debe '(Pagos.VencimientoCuota < #" & Format(Today, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
  '        aux.RefreshData()
  '        Dim newPago As clsInfoPagos
  '        newPago = aux.Items.First.Clone

  '        If AdelantoCuota < newPago.ValorCuota Then
  '          Dim ProximoPago As Decimal = newPago.ValorCuota - AdelantoCuota
  '          newPago.EstadoPago = E_EstadoPago.PagoParcial
  '          newPago.ValorCuota = AdelantoCuota
  '          newPago.FechaPago = GetAhora()
  '          Vencimiento = newPago.VencimientoCuota
  '          clsPago.Save(newPago)
  '          AdelantoCuota = 0
  '          'proximo pago
  '          newPago = New clsInfoPagos
  '          newPago = aux.Items.First.Clone
  '          newPago = GetProximoPago(m_Producto.GuidProducto, m_Producto.NumComprobante, ProximoPago, newPago.NumCuota, m_Producto.FechaVenta, m_Producto.FechaPrimerPago)
  '          newPago.VencimientoCuota = Vencimiento 'uso la misma fecha de vencimiento
  '          clsPago.Save(newPago)
  '        Else
  '          newPago.EstadoPago = E_EstadoPago.Pago
  '          newPago.ValorCuota = newPago.ValorCuota
  '          newPago.FechaPago = GetAhora()
  '          Vencimiento = newPago.VencimientoCuota
  '          clsPago.Save(newPago)
  '          AdelantoCuota = AdelantoCuota - newPago.ValorCuota
  '          'proximo Pago
  '          newPago = New clsInfoPagos
  '          newPago = aux.Items.First.Clone
  '          newPago = GetProximoPago(m_Producto.GuidProducto, m_Producto.NumComprobante, m_Producto.ValorCuotaFija, newPago.NumCuota + 1, m_Producto.FechaVenta, m_Producto.FechaPrimerPago)
  '          newPago.VencimientoCuota = Vencimiento.AddMonths(1)
  '          clsPago.Save(newPago)
  '          'If (AdelantoCuota = newPago.ValorCuota) Then
  '          '  'marcarla como pagada
  '          'Else
  '          '  'es mayor al valor de parte de la cuota a pagar
  '          '  Dim n As Integer = Math.Ceiling(AdelantoCuota / m_Producto.ValorCuotaFija)
  '          '  If n = 0 Then
  '          '  Else
  '          '  End If
  '          'End If
  '        End If

  '      End While
  '      'If AdelantoCuota < m_Producto.ValorCuotaFija Then
  '      '  newPago.ValorCuota = m_Producto.ValorCuotaFija - AdelantoCuota
  '      '  newPago.VencimientoCuota = Vencimiento
  '      'Else
  '      '  Dim n As Integer = Math.Ceiling(AdelantoCuota / m_Producto.ValorCuotaFija)
  '      '  newPago.ValorCuota = m_Producto.ValorCuotaFija * n - AdelantoCuota
  '      '  newPago.VencimientoCuota = Vencimiento.AddMonths(n - 1)
  '      'End If
  '      'clsPago.Save(newPago)
  '      If AdelantoVendedor > 0 Then
  '        Dim objAdelanto As New clsInfoAdelanto
  '        objAdelanto.GuidVendedor = m_Producto.GuidVendedor
  '        objAdelanto.Valor = AdelantoVendedor
  '        objAdelanto.Fecha = GetAhora()
  '        clsAdelantos.Save(objAdelanto)
  '      End If


  '    End If


  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  Private Function CuotasIguales(ByVal vPrecio As Decimal, ByVal cuotas As Integer) As Decimal
    Try
      Dim valorCuota As Decimal
      If cuotas = 0 Then cuotas = 1
      ConvStr2Dec(CDec(vPrecio / cuotas).ToString, valorCuota)
      Return valorCuota
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function


  ''PARA MAS ADELANTE automaticamente permite solo numero y preparar que para ingrese coma en pos correcta
  'Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
  '  Try
  '    If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
  '      e.Handled = True
  '    End If

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub


 


  




  Private Sub btnSeleccionarCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSeleccionarCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_Cliente.GuidCliente)
        objForm.ShowDialog(Me)
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
        txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_Cliente.GuidCliente)
        objForm.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

 

  

 


 

  Private Sub txtNumVenta_TextChanged(sender As Object, e As EventArgs) Handles txtNumVenta.TextChanged
    Try
      If String.IsNullOrEmpty(txtNumVenta.Text.Trim) Then Exit Sub
      If Not IsNumeric(txtNumVenta.Text.Trim) Then

        MsgBox("Solo ingresar numeros menores a " + Integer.MaxValue.ToString)
      ElseIf CDbl(txtNumVenta.Text.Trim) >= Integer.MaxValue Then
        MsgBox("Solo ingresar numeros menores a " + Integer.MaxValue.ToString)
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GetFechaSugeridaPrimerVencimiento(ByVal vFechaInicial As Date) As Date
    Try
      Dim auxFecha As Date = vFechaInicial.AddMonths(1)
      Return New Date(auxFecha.Year, auxFecha.Month, 1)
    Catch ex As Exception
      Print_msg(ex.Message)
      Return g_Today
    End Try
  End Function

  Public Function GetResult() As Result
    Try
      Return m_Result
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetProducto(ByRef rProducto As clsInfoProducto, ByRef rAdelantoVendedor As clsInfoAdelanto) As Result
    Try

      rProducto = m_Producto.Clone
      rAdelantoVendedor = m_Adelanto.Clone
      Return Result.OK
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

  
  Private Function EsValidoNumComprobante(ByVal vNumComprobante As Integer) As Boolean
    Try
      If vNumComprobante <= 0 Then Return False 'asumo que ya existe asi no se pueden utilizar
      Dim lstpagos As New clsListPagos
      lstpagos.Cfg_Filtro = "WHERE NumComprobante=" & vNumComprobante
      lstpagos.RefreshData()
      If lstpagos.Items.Count > 0 Then Return False
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

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
        If clsCuenta.Load(m_CurrentCuota.GuidCuenta, m_CurrentCuenta) <> Result.OK Then
          MsgBox("No se puede editar la cuenta")
        End If

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