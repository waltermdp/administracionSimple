Imports manDB
Imports libCommon.Comunes

Public Class frmEstablecerPagos

  Private m_Producto As clsInfoProducto
  Private m_Cliente As ClsInfoPersona
  Private m_Vendedor As clsInfoVendedor
  Private m_CurrentCuenta As clsInfoCuenta
  Private m_Adelanto As clsInfoAdelanto
  Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_skip As Boolean

  Private m_Result As Result = Result.CANCEL

  Public Sub New(ByVal vProducto As clsInfoProducto, ByVal vCliente As ClsInfoPersona, ByVal vVendedor As clsInfoVendedor, ByVal vAdelantoVendedor As clsInfoAdelanto)

    ' This call is required by the designer.

    Try
      m_skip = True
      InitializeComponent()
      m_skip = False
      If Not (vProducto Is Nothing) Then
        m_Producto = vProducto.Clone
      End If
      If Not (vCliente Is Nothing) Then
        m_Cliente = vCliente.Clone
      End If
      If Not (vVendedor Is Nothing) Then
        m_Vendedor = vVendedor.Clone
      End If

      If Not (vAdelantoVendedor Is Nothing) Then
        m_Adelanto = vAdelantoVendedor.Clone
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
      cmbCuotas.DataSource = g_Cuotas
      chkEditarCuotas.Checked = True
      txtValorCuota.Enabled = True
    

      vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
      If vResult <> Result.OK Then
        Call Print_msg("Fallo carga de cuenta")
      End If
      DateVenta.Value = g_Today
      dtProximoPago.MinDate = DateVenta.Value
      dtProximoPago.Value = GetFechaSugeridaPrimerVencimiento(DateVenta.Value)

    
      FillInformacion()
      GenerarPlanCuotas()
      m_skip = False

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Public Sub FillInformacion()
    Try
     
      With m_Producto
        If m_Producto.GuidProducto = Guid.Empty Then
          'valores iniciales
          DateVenta.Value = g_Today
          dtProximoPago.Value = New Date(g_Today.Year, g_Today.AddMonths(1).Month, 1)
          txtPrecioTotal.SetDecimalMonedaValue(0)
          txtNumVenta.Text = GetProximoComprobanteDisponible().ToString
          cmbCuotas.SelectedItem = 0
          txtValorCuota.SetDecimalMonedaValue(0)
          m_lstPagos.Clear()
          lvPlanPagos.Items.Clear()
          txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
          txtAdelanto.SetDecimalMonedaValue(0)
          txtAdelantoVendedor.SetDecimalMonedaValue(0)
        Else
          DateVenta.Value = .FechaVenta
          dtProximoPago.MinDate = DateVenta.Value
          dtProximoPago.Value = .FechaPrimerPago
          txtPrecioTotal.SetDecimalMonedaValue(.Precio) '.Text = .Precio.ToString  'precio total
          txtNumVenta.Text = .NumComprobante.ToString
          For Each cuota In g_Cuotas
            If cuota.Cantidad = .TotalCuotas Then
              cmbCuotas.SelectedItem = cuota
              Exit For
            End If
          Next
          If .ListaPagos.Count > 0 Then
            txtValorCuota.SetDecimalMonedaValue(.ValorCuotaFija) '.Text = .ValorCuotaFija.ToString
          Else
            txtValorCuota.SetDecimalMonedaValue(.Precio) '.Text = .Precio.ToString
          End If
          txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
          lvPlanPagos.Items.Clear()
          txtAdelanto.SetDecimalMonedaValue(.Adelanto)
          If m_Adelanto IsNot Nothing Then
            txtAdelantoVendedor.SetDecimalMonedaValue(m_Adelanto.Valor)
          Else
            txtAdelantoVendedor.SetDecimalMonedaValue(0)
          End If

          For Each pago As clsInfoPagos In .ListaPagos
            Dim item As New ListViewItem
            item.Text = pago.NumCuota.ToString
            item.SubItems.Add(pago.VencimientoCuota.ToString("dd/MM/yyyy"))
            item.SubItems.Add(pago.ValorCuota.ToString)
            item.SubItems.Add(Date2String(pago.FechaPago)) 'fecha de pago
            item.SubItems.Add(EstadoPagos2String(pago.EstadoPago)) 'fecha de pago
            lvPlanPagos.Items.Add(item)
            m_lstPagos.Add(pago)
          Next

        End If

      End With
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
        
        .Precio = txtPrecioTotal.GetDecimalMonedaValue
        .ValorCuotaFija = txtValorCuota.GetDecimalMonedaValue
        Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
        .TotalCuotas = Cuota.Cantidad

        Dim adelantoCuota As Decimal = 0
        If GetAdelanto(adelantoCuota) <> Result.OK Then
          MsgBox("El valor del adelanto es invalido")
          Exit Sub
        End If
        m_Producto.Adelanto = adelantoCuota

        If m_CurrentCuenta Is Nothing Then
          MsgBox("Debe seleccionar una cuenta")
          Exit Sub
        End If
        If Not m_CurrentCuenta.IsValid Then
          MsgBox("El valor del modo de pago es invalido")
          Exit Sub
        End If


        m_Producto.Cuenta = m_CurrentCuenta

        m_Producto.FechaPrimerPago = dtProximoPago.Value
        m_Producto.FechaVenta = DateVenta.Value



        
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

        'Adelanto para el vendedor
        Dim AdelantoVendedor As Decimal
        AdelantoVendedor = txtAdelantoVendedor.GetDecimalMonedaValue
        'If Not ConvStr2Dec(txtAdelantoVendedor.Text, AdelantoVendedor) Then
        '  MsgBox("El valor de la cuota es invalido")
        '  Exit Sub
        'End If
        If m_Adelanto Is Nothing Then m_Adelanto = New clsInfoAdelanto
        m_Adelanto.Valor = AdelantoVendedor
        m_Adelanto.Fecha = m_Producto.FechaVenta
        m_Adelanto.GuidVendedor = m_Producto.GuidVendedor
        m_Adelanto.GuidProducto = m_Producto.GuidProducto


      End With


      m_Result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.CANCEL
    End Try
  End Sub


  Private Sub GenerarPlanCuotas()
    Try
      If m_Producto Is Nothing Then Exit Sub
      m_lstPagos.Clear()



      Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
      
      Dim ValorCuota As Decimal
      ValorCuota = txtValorCuota.GetDecimalMonedaValue

      Dim adelantoCuota As Decimal = 0
      If txtPrecioTotal.GetDecimalMonedaValue <= 0 Then Exit Sub


      If m_lstPagos.Count <= 0 Then ' m_Producto.GuidProducto = Guid.Empty Then
        m_lstPagos.Clear()
        'aun no existen proximos pagos a debitar
        If GetAdelanto(adelantoCuota) <> Result.OK Then
          MsgBox("El valor de adelanto de cuota no es valido, se considera 0")
          adelantoCuota = 0
        End If
        lvPlanPagos.Items.Clear()
        Dim Diferencia As Integer = 0
        Dim SetPrimerPago As Boolean = True
        For i As Integer = 1 To Cuota.Cantidad
          Dim item As New ListViewItem
          Dim auxFechaDebitoCuota As Date
          Dim cuotaPagar As New clsInfoPagos

          cuotaPagar.GuidPago = Guid.NewGuid
          cuotaPagar.NumComprobante = CInt(txtNumVenta.Text)

          cuotaPagar.NumCuota = i
          If FechaProximoDebito(DateVenta.Value, dtProximoPago.Value, i, auxFechaDebitoCuota) <> Result.OK Then
            MsgBox("No se puede estimar el valor de las proximas cuotas")
            Exit Sub
          End If
          cuotaPagar.VencimientoCuota = auxFechaDebitoCuota

          If (ValorCuota * i - adelantoCuota) <= 0 Then
            cuotaPagar.ValorCuota = ValorCuota
            cuotaPagar.FechaPago = DateVenta.Value
            cuotaPagar.EstadoPago = E_EstadoPago.Pago

          Else
            If (ValorCuota * i - adelantoCuota) < ValorCuota Then
              cuotaPagar.ValorCuota = ValorCuota * i - adelantoCuota
            Else
              cuotaPagar.ValorCuota = ValorCuota
            End If
            cuotaPagar.FechaPago = Date.MinValue
            If SetPrimerPago Then
              cuotaPagar.EstadoPago = libCommon.Comunes.E_EstadoPago.DebeProximo
              SetPrimerPago = False
            Else
              cuotaPagar.EstadoPago = libCommon.Comunes.E_EstadoPago.DebePendiente
            End If


          End If

          item.Text = cuotaPagar.NumCuota.ToString
          item.SubItems.Add(Date2String(auxFechaDebitoCuota))
          item.SubItems.Add(cuotaPagar.ValorCuota.ToString)
          item.SubItems.Add(Date2String(cuotaPagar.FechaPago)) 'fecha de pago
          item.SubItems.Add(EstadoPagos2String(cuotaPagar.EstadoPago)) 'fecha de pago

          m_lstPagos.Add(cuotaPagar)
          lvPlanPagos.Items.Add(item)
        Next
      Else
        'el producto venta ya esta generado, podria estar en la DB o solo en memoria


      End If

    Catch ex As Exception
      Print_msg(ex.Message)
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

  Private Function GetAdelanto(ByRef rValor As Decimal) As Result
    Try
      rValor = txtAdelanto.GetDecimalMonedaValue
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

  
  Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioTotal.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Try


      Finally
        m_skip = False
      End Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub cmbCuotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuotas.SelectedIndexChanged
    Try
      If m_skip Then Exit Sub
      Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
      Dim precio As Decimal
      precio = txtValorCuota.GetDecimalMonedaValue
      txtPrecioTotal.SetDecimalMonedaValue(CDec(precio * Cuota.Cantidad))


      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




  Private Sub btnSeleccionarCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSeleccionarCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_Cliente.GuidCliente)
        objForm.ShowDialog(Me)
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
        Call GenerarPlanCuotas()
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
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
        Call GenerarPlanCuotas()
        txtMedioPagoDescripcion.Text = FillMedioDePagoDescripcion()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub chkEditarCuotas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEditarCuotas.CheckedChanged
    Try
      'txtValorCuota.Enabled = chkEditarCuotas.Checked
      'If chkEditarCuotas.Checked = False Then
      '  Dim precio As Decimal
      '  ConvStr2Dec(txtPrecio.Text, precio)
      '  txtValorCuota.Text = CuotasIguales(precio, CType(cmbCuotas.SelectedItem, clsCuota).Cantidad).ToString
      '  Call GenerarPlanCuotas()
      'End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtValorCuota_TextChanged(sender As Object, e As EventArgs) Handles txtValorCuota.TextChanged
    Try

      ' Dim auxValue As String = CType(sender, TextBox).Text
      Dim dec As Decimal
      dec = txtValorCuota.GetDecimalMonedaValue
      'If ConvStr2Dec(auxValue, dec) Then
      If cmbCuotas.Items.Count <= 0 Then
        txtPrecioTotal.SetDecimalMonedaValue(0) '.Text = "0"
        Exit Sub
      End If
      txtPrecioTotal.SetDecimalMonedaValue(CDec(dec * CType(cmbCuotas.SelectedItem, clsCuota).Cantidad))
      '  Call GenerarPlanCuotas()
      'Else
      '  txtValorCuota.Text = "0"
      '  txtPrecio.Text = "0"

      'End If
      GenerarPlanCuotas()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtAdelanto_TextChanged(sender As Object, e As EventArgs) Handles txtAdelanto.TextChanged
    Try
      'Dim dec As Decimal

      'If ConvStr2Dec(txtAdelanto.Text, dec) Then
      '  GenerarPlanCuotas()
      'Else
      '  txtAdelanto.Text = ""
      'End If
      GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
 

  Private Sub DateVenta_ValueChanged(sender As Object, e As EventArgs) Handles DateVenta.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_Producto.FechaVenta = DateVenta.Value
      dtProximoPago.MinDate = DateVenta.Value
      Call GenerarPlanCuotas()
    Catch ex As Exception
      Call Print_msg(ex.Message)
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

  Private Sub dtProximoPago_ValueChanged(sender As Object, e As EventArgs) Handles dtProximoPago.ValueChanged
    Try
      If m_skip Then Exit Sub
      If dtProximoPago.Value < DateVenta.Value Then
        MsgBox("La fecha del primer pago debe ser mayor o igual a la fecha de venta")
        dtProximoPago.Value = GetFechaSugeridaPrimerVencimiento(dtProximoPago.Value)
        Exit Sub
      End If

      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
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

  Private Function GetProximoComprobanteDisponible() As Integer
    Try
      Dim lstpagos As New clsListPagos
      lstpagos.Cfg_Filtro = "WHERE NumComprobante=(SELECT max(NumComprobante) FROM Pagos);"
      lstpagos.RefreshData()

      If lstpagos.Items.Count > 0 Then
        Return lstpagos.Items.First.NumComprobante + 1
      Else
        Return 1
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      Return -1
    End Try
  End Function

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
 
End Class