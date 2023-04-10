Imports manDB
Imports libCommon.Comunes

Public Class frmEstablecerPagos

  Private m_Producto As clsInfoProducto
  Private m_Cliente As ClsInfoPersona
  Private m_Vendedor As clsInfoVendedor
  Private m_CurrentCuenta As clsInfoCuenta
  Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_skip As Boolean

  Private m_Result As Result = Result.CANCEL

  Public Sub New(ByVal vProducto As clsInfoProducto, ByVal vCliente As ClsInfoPersona, ByVal vVendedor As clsInfoVendedor)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      If Not (vProducto Is Nothing) Then
        m_Producto = vProducto.Clone
      End If
      If Not (vCliente Is Nothing) Then
        m_Cliente = vCliente.Clone
      End If
      If Not (vVendedor Is Nothing) Then
        m_Vendedor = vVendedor.Clone
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmEstablecerPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Dim vResult As Result
      m_skip = True
      cmbCuotas.DataSource = g_Cuotas
      chkEditarCuotas.Checked = False
      txtValorCuota.Enabled = False
    

      vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
      If vResult <> Result.OK Then
        Call Print_msg("Fallo carga de cuenta")
      End If
      DateVenta.Value = g_Today
      dtProximoPago.Value = New Date(g_Today.Year, g_Today.AddMonths(1).Month, 1)

    
      FillInformacion()
    
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
          txtPrecio.Text = 0
          txtNumVenta.Text = -1
          cmbCuotas.SelectedItem = 0
          txtValorCuota.Text = 0
          m_lstPagos.Clear()
          lvPlanPagos.Items.Clear()
          

        Else
          DateVenta.Value = .FechaVenta
          dtProximoPago.Value = .FechaPrimerPago
          txtPrecio.Text = .Precio 'precio total
          txtNumVenta.Text = .NumComprobante.ToString
          For Each cuota In g_Cuotas
            If cuota.Cantidad = .TotalCuotas Then
              cmbCuotas.SelectedItem = cuota
              Exit For
            End If
          Next
          If .ListaPagos.Count > 0 Then
            txtValorCuota.Text = .ValorCuotaFija.ToString
          Else
            txtValorCuota.Text = .Precio.ToString
          End If

          lvPlanPagos.Items.Clear()
          For Each pago As clsInfoPagos In m_Producto.ListaPagos
            Dim item As New ListViewItem
            item.Text = pago.NumCuota
            item.SubItems.Add(pago.VencimientoCuota.ToString("dd/MM/yyyy"))
            item.SubItems.Add(pago.ValorCuota)
            item.SubItems.Add(pago.FechaPago.ToString("dd/MM/yyyy")) 'fecha de pago
            item.SubItems.Add(pago.EstadoPago) 'fecha de pago
            lvPlanPagos.Items.Add(item)
          Next

        End If

      End With
      Call FillMedioDePagoDescripcion()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillMedioDePagoDescripcion()
    Try
      If m_CurrentCuenta Is Nothing Then
        txtMedioPagoDescripcion.Text = "--"
      Else
        txtMedioPagoDescripcion.Text = GetNameOfTipoPago(m_CurrentCuenta.TipoDeCuenta) & " -- " & m_CurrentCuenta.Codigo1.ToString
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try

  End Sub




  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      With m_Producto
        Dim adelantoCuota As Decimal = 0
        GetAdelanto(adelantoCuota)
        m_Producto.Adelanto = adelantoCuota
        m_Producto.Cuenta = m_CurrentCuenta
        'm_Producto.CuotasDebe =
        m_Producto.FechaPrimerPago = dtProximoPago.Value
        m_Producto.FechaVenta = DateVenta.Value

        Dim ValorCuota As Decimal
        ConvStr2Dec(txtValorCuota.Text, ValorCuota)
        .ValorCuotaFija = ValorCuota
        Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
        .TotalCuotas = Cuota.Cantidad
        Dim Precio As Decimal
        ConvStr2Dec(txtPrecio.Text, Precio)
        .Precio = Precio
        .NumComprobante = txtNumVenta.Text
        .ListaPagos.Clear()
        .ListaPagos.AddRange(m_lstPagos.ToList)
      End With
      m_Producto.GuidProducto = Guid.NewGuid
      m_Result = Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.CANCEL
    Finally
      Me.Close()
    End Try
  End Sub

  Private Sub GenerarPlanCuotas()
    Try
      If m_Producto Is Nothing Then Exit Sub
      m_lstPagos.Clear()
      For Each pago In m_Producto.ListaPagos
        m_lstPagos.Add(pago.Clone)
      Next

      'No se puede editar lo que ya esta pagado, se puede modificar en adelante, considerando lo ya pagado

      Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
      Dim Precio As Decimal
      ConvStr2Dec(txtPrecio.Text, Precio)
      Dim ValorCuota As Decimal
      ConvStr2Dec(txtValorCuota.Text, ValorCuota)
      Dim adelantoCuota As Decimal = 0
      If Precio <= 0 Then Exit Sub


      If m_lstPagos.Count <= 0 Then
        'aun no existen proximos pagos a debitar
        If GetAdelanto(adelantoCuota) <> Result.OK Then
          MsgBox("El valor de adelanto de cuota no es valido, se considera 0")
          adelantoCuota = 0
        End If
        lvPlanPagos.Items.Clear()
        Dim Diferencia As Integer = 0
        For i As Integer = 1 To Cuota.Cantidad
          Dim item As New ListViewItem
          Dim auxFechaDebitoCuota As Date
          item.Text = i
          If FechaProximoDebito(DateVenta.Value, dtProximoPago.Value, i, auxFechaDebitoCuota) <> Result.OK Then
            MsgBox("No se puede estimar el valor de las proximas cuotas")
            Exit Sub
          End If
          item.SubItems.Add(auxFechaDebitoCuota.ToString("dd/MM/yyyy"))

          If (ValorCuota * i - adelantoCuota) <= 0 Then
            item.SubItems.Add(ValorCuota)
            item.SubItems.Add(DateVenta.Value.ToString("dd/MM/yyyy")) 'fecha de pago
            item.SubItems.Add(E_EstadoPago.Pago) 'fecha de pago
          Else
            If (ValorCuota * i - adelantoCuota) < ValorCuota Then
              item.SubItems.Add(ValorCuota * i - adelantoCuota)
            Else
              item.SubItems.Add(ValorCuota)
            End If
            item.SubItems.Add("") 'fecha de pago
            item.SubItems.Add(E_EstadoPago.Debe) 'fecha de pago
          End If
          
          lvPlanPagos.Items.Add(item)
        Next
      End If
      'Dim auxPago As New clsInfoPagos

      'Dim numProxCouta As Integer = 1
      'If m_lstPagos.Count > 0 Then
      '  If m_lstPagos.Last.EstadoPago = E_EstadoPago.Debe Then
      '    numProxCouta = m_lstPagos.Last.NumCuota
      'm_lstPagos.Last.EstadoPago = E_EstadoPago.Anulo_Editado

      '  ElseIf m_lstPagos.Last.EstadoPago = E_EstadoPago.Pago Then
      '    Exit Sub
      '  End If
      'End If
      'm_Producto.FechaPrimerPago = New Date(DateVenta.Value.Year, DateVenta.Value.Month, dtDiaVencimiento.Value)

      'auxPago = GetProximoPago(m_Producto.GuidProducto, CInt(txtNumVenta.Text.Trim), ValorCuota, numProxCouta, m_Producto.FechaVenta, modCommon.Vencimiento(m_Producto.FechaPrimerPago))

      ''lblNumComprobante.Text = auxPago.NumComprobante.ToString
      'm_lstPagos.Add(auxPago)

      'Call ReloadListPagos()
      Dim j As Integer = 0
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
        rFecha = DateAdd(DateInterval.Month, nCuota, vFPrimerPago)
      End If
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GetAdelanto(ByRef rValor As Decimal) As Result
    Try
      Dim value As Decimal = 0
      If String.IsNullOrEmpty(txtAdelanto.Text.Trim) Then
        rValor = 0
        Return Result.OK
      End If
      If IsNumeric(txtAdelanto.Text.Trim) Then
        If ConvStr2Dec(txtAdelanto.Text, value) Then
          If value >= 0 Then
            rValor = value
            Return Result.OK
          End If

        End If
      End If
      Return Result.NOK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Sub AplicarPagoAdelantado()
    Try
      If IsNumeric(txtAdelanto.Text.Trim) Then
        If CDec(txtAdelanto.Text) <= 0 Then Exit Sub
        Dim AdelantoCuota As Decimal
        Dim AdelantoVendedor As Decimal
        ConvStr2Dec(txtAdelanto.Text, AdelantoCuota)
        ConvStr2Dec(txtAdelantoVendedor.Text, AdelantoVendedor)
        Dim Vencimiento As Date




        While AdelantoCuota > 0
          Dim aux As New clsListPagos
          aux.Cfg_Filtro = "where GuidProducto={" & m_Producto.GuidProducto.ToString & "} and EstadoPago= " & E_EstadoPago.Debe '(Pagos.VencimientoCuota < #" & Format(Today, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
          aux.RefreshData()
          Dim newPago As clsInfoPagos
          newPago = aux.Items.First.Clone

          If AdelantoCuota < newPago.ValorCuota Then
            Dim ProximoPago As Decimal = newPago.ValorCuota - AdelantoCuota
            newPago.EstadoPago = E_EstadoPago.PagoParcial
            newPago.ValorCuota = AdelantoCuota
            newPago.FechaPago = GetAhora()
            Vencimiento = newPago.VencimientoCuota
            clsPago.Save(newPago)
            AdelantoCuota = 0
            'proximo pago
            newPago = New clsInfoPagos
            newPago = aux.Items.First.Clone
            newPago = GetProximoPago(m_Producto.GuidProducto, m_Producto.NumComprobante, ProximoPago, newPago.NumCuota, m_Producto.FechaVenta, m_Producto.FechaPrimerPago)
            newPago.VencimientoCuota = Vencimiento 'uso la misma fecha de vencimiento
            clsPago.Save(newPago)
          Else
            newPago.EstadoPago = E_EstadoPago.Pago
            newPago.ValorCuota = newPago.ValorCuota
            newPago.FechaPago = GetAhora()
            Vencimiento = newPago.VencimientoCuota
            clsPago.Save(newPago)
            AdelantoCuota = AdelantoCuota - newPago.ValorCuota
            'proximo Pago
            newPago = New clsInfoPagos
            newPago = aux.Items.First.Clone
            newPago = GetProximoPago(m_Producto.GuidProducto, m_Producto.NumComprobante, m_Producto.ValorCuotaFija, newPago.NumCuota + 1, m_Producto.FechaVenta, m_Producto.FechaPrimerPago)
            newPago.VencimientoCuota = Vencimiento.AddMonths(1)
            clsPago.Save(newPago)
            'If (AdelantoCuota = newPago.ValorCuota) Then
            '  'marcarla como pagada
            'Else
            '  'es mayor al valor de parte de la cuota a pagar
            '  Dim n As Integer = Math.Ceiling(AdelantoCuota / m_Producto.ValorCuotaFija)
            '  If n = 0 Then
            '  Else
            '  End If
            'End If
          End If

        End While
        'If AdelantoCuota < m_Producto.ValorCuotaFija Then
        '  newPago.ValorCuota = m_Producto.ValorCuotaFija - AdelantoCuota
        '  newPago.VencimientoCuota = Vencimiento
        'Else
        '  Dim n As Integer = Math.Ceiling(AdelantoCuota / m_Producto.ValorCuotaFija)
        '  newPago.ValorCuota = m_Producto.ValorCuotaFija * n - AdelantoCuota
        '  newPago.VencimientoCuota = Vencimiento.AddMonths(n - 1)
        'End If
        'clsPago.Save(newPago)
        If AdelantoVendedor > 0 Then
          Dim objAdelanto As New clsInfoAdelanto
          objAdelanto.GuidVendedor = m_Producto.GuidVendedor
          objAdelanto.Valor = AdelantoVendedor
          objAdelanto.Fecha = GetAhora()
          clsAdelantos.Save(objAdelanto)
        End If


      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


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

  Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Try
        Dim auxValue As String = CType(sender, TextBox).Text
        Dim Precio As Decimal
        If ConvStr2Dec(auxValue, Precio) Then
          'El valor ingresado es valido
          Dim NCuotas As Integer
          If cmbCuotas.SelectedIndex >= 0 Then
            NCuotas = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
          Else
            'TODO: seleccionar por defecto cuotas 0
            For Each item As clsCuota In cmbCuotas.Items
              If item.Cantidad = 0 Then
                cmbCuotas.SelectedItem = item
                Exit For
              End If
            Next
            NCuotas = 0
          End If

          If chkEditarCuotas.Checked = False Then
            txtValorCuota.Text = CuotasIguales(Precio, NCuotas).ToString
          Else
            'Dejo el valor que figura en el txt precio cuota
          End If

          Call GenerarPlanCuotas()
        End If
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
      If chkEditarCuotas.Checked = False Then
        Dim precio As Decimal
        ConvStr2Dec(txtPrecio.Text, precio)

        txtValorCuota.Text = CuotasIguales(precio, Cuota.Cantidad).ToString
      Else
        'Dejo el valor que figura en el txt precio cuota
      End If

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
        Call FillMedioDePagoDescripcion()
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
        Call FillMedioDePagoDescripcion()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub chkEditarCuotas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEditarCuotas.CheckedChanged
    Try
      txtValorCuota.Enabled = chkEditarCuotas.Checked
      If chkEditarCuotas.Checked = False Then
        Dim precio As Decimal
        ConvStr2Dec(txtPrecio.Text, precio)
        txtValorCuota.Text = CuotasIguales(precio, CType(cmbCuotas.SelectedItem, clsCuota).Cantidad).ToString
        Call GenerarPlanCuotas()
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtValorCuota_TextChanged(sender As Object, e As EventArgs) Handles txtValorCuota.TextChanged
    Try
      If chkEditarCuotas.Checked = True Then
        Dim auxValue As String = CType(sender, TextBox).Text
        Dim dec As Decimal
        If ConvStr2Dec(auxValue, dec) Then
          Call GenerarPlanCuotas()
        Else
          txtValorCuota.Text = ""
          GenerarPlanCuotas()
        End If
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtAdelanto_TextChanged(sender As Object, e As EventArgs) Handles txtAdelanto.TextChanged
    Try
      Dim dec As Decimal
      If ConvStr2Dec(txtAdelanto.Text, dec) Then
        GenerarPlanCuotas()
      Else
        txtAdelanto.Text = ""
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
 

  Private Sub DateVenta_ValueChanged(sender As Object, e As EventArgs) Handles DateVenta.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_Producto.FechaVenta = DateVenta.Value
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
      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetProducto(ByRef rProducto As clsInfoProducto) As Result
    Try
      If m_Result = Result.OK Then
        rProducto = m_Producto.Clone
      End If
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

  Private Function GetUltimoComprobante() As Integer
    Try
      Dim lstpagos As New clsListPagos
      lstpagos.Cfg_Filtro = "WHERE NumComprobante=(SELECT max(NumComprobante) FROM Pagos);"
      lstpagos.RefreshData()

      If lstpagos.Items.Count > 0 Then
        Return lstpagos.Items.First.NumComprobante + 1
      Else
        Return -1
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      Return -1
    End Try
  End Function
 
End Class