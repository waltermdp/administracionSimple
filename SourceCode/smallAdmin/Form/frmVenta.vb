Imports manDB
Imports libCommon.Comunes
Public Class frmVenta

  Private m_Producto As clsInfoProducto
  Private m_skip As Boolean
  Private m_hayCambios As Boolean

  Private m_CurrentPersona As ClsInfoPersona
  Private m_CurrentVendedor As clsInfoVendedor

  Private m_CurrentCuenta As clsInfoCuenta
  Private m_lstPagos As New List(Of clsInfoPagos)

  Private m_objListStock As New clsListStock
  Private m_lstArticulos As clsListArticulos
  Private m_lstArticulosVendidos As New List(Of clsInfoArticuloVendido)
  Private m_lstArticulosEnStock As List(Of clsListaStorage)

  Public Sub New(Optional ByVal vProducto As clsInfoProducto = Nothing)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      If vProducto Is Nothing Then
        m_Producto = New clsInfoProducto
        m_Producto.GuidProducto = Guid.NewGuid
        m_CurrentPersona = Nothing
        m_CurrentVendedor = Nothing
      Else
        m_Producto = vProducto.Clone
        m_CurrentPersona = New ClsInfoPersona
        m_CurrentVendedor = New clsInfoVendedor
        m_CurrentCuenta = New clsInfoCuenta
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      m_skip = True
      Dim vResult As Result = Result.NOK
      DateVenta.Value = Today
      cmbCuotas.DataSource = g_Cuotas

      chkEditarCuotas.Checked = False
      txtValorCuota.Enabled = False

      txtPrecio.Text = 0
      m_hayCambios = False

      ListView1.View = View.Details
      ListView1.Columns(0).Width = CInt(0.7 * ListView1.Width)
      ListView1.Columns(1).Width = ListView1.Width - ListView1.Columns(0).Width - 5



      If m_CurrentPersona Is Nothing AndAlso m_CurrentVendedor Is Nothing Then Exit Sub
      If m_CurrentPersona IsNot Nothing AndAlso m_CurrentVendedor IsNot Nothing Then
        vResult = clsPersona.Load(m_Producto.GuidCliente, m_CurrentPersona)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de cliente")
        End If
        vResult = clsVendedor.Load(m_Producto.GuidVendedor, m_CurrentVendedor)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de vendedor")
        End If
        vResult = clsPago.Load(m_Producto.ListaPagos, m_Producto.GuidProducto)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de Pagos")
        End If
        m_lstPagos = m_Producto.ListaPagos.ToList
        If TerminoDePagar(m_Producto) Then btnSave.Enabled = False

        vResult = clsRelArtProd.Load(m_Producto.ListaArticulos, m_Producto.GuidProducto)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de Articulos Vendidos")
        End If

        vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de cuenta")
        End If

        DateVenta.Value = m_Producto.FechaVenta
        dtDiaVencimiento.Value = m_Producto.FechaPrimerPago.Day
        Exit Sub
      End If
      Call Print_msg("Incongruencia de cliente and vendedor, deben o no existir ambos ")

    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      gpVenta.Enabled = False
      btnSave.Enabled = False
      m_skip = False
    End Try
  End Sub

  Private Sub frmVenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      m_skip = True
      Call Refresh_infoClientVendedor()
      'FillResponsables()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Private Function TerminoDePagar(ByVal vProducto As clsInfoProducto) As Boolean
    Try
      Dim cantCuotas As Integer = vProducto.TotalCuotas
      If vProducto.ListaPagos.Count <= 0 Then Return False
      For Each cuota As clsInfoPagos In vProducto.ListaPagos
        If cuota.EstadoPago = E_EstadoPago.Pago Then cantCuotas -= 1
      Next
      If cantCuotas = 0 Then Return True
      Return False
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Sub FillClientData()
    Try
      With m_CurrentPersona
        txtNombreCliente.Text = .ToString
        txtDNICliente.Text = .DNI
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillVendedorData()
    Try
      With m_CurrentVendedor
        txtNombreVendedor.Text = .ToString
        txtDNIVendedor.Text = .ID
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillVentaData()
    Try
      With m_Producto
        txtPrecio.Text = .Precio
        DateVenta.Value = .FechaVenta
        dtDiaVencimiento.Value = .FechaPrimerPago.Day
        'For Each item As clsCuota In cmbCuotas.Items
        '  If .ListaPagos.Count = item.Cantidad Then
        '    cmbCuotas.SelectedItem = item
        '    Exit For
        '  End If
        'Next
        For Each cuota In g_Cuotas
          If cuota.Cantidad = .TotalCuotas Then
            cmbCuotas.SelectedItem = cuota
            Exit For
          End If
        Next
        If .ListaPagos.Count > 0 Then
          txtValorCuota.Text = .ListaPagos.First.ValorCuota.ToString
        Else
          txtValorCuota.Text = .Precio.ToString
        End If


      End With
      Call FillMedioDePagoDescripcion()
    Catch ex As Exception
      Call Print_msg(ex.Message)
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

  Private Sub Refresh_infoClientVendedor()
    Try
      If m_CurrentPersona IsNot Nothing Then Call FillClientData()
      If m_CurrentVendedor IsNot Nothing Then Call FillVendedorData()
      Call FillVentaData()
      Call PermitirVenta()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Function HayCambios() As Boolean
    Try
      Return m_hayCambios
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Public Sub getCambios(ByRef rProducto As clsInfoProducto)
    Try
      rProducto = m_Producto.Clone

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Try
        Dim auxValue As String = CType(sender, TextBox).Text
        Dim Precio As Decimal
        If text2decimal(auxValue, Precio) Then
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
        text2decimal(txtPrecio.Text, precio)

        txtValorCuota.Text = CuotasIguales(Precio, Cuota.Cantidad).tostring
      Else
        'Dejo el valor que figura en el txt precio cuota
      End If

      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




  Private Function text2decimal(ByVal vText As String, ByRef rValor As Decimal) As Boolean
    Try
      Dim esCorrecto As Boolean = Decimal.TryParse(vText, rValor)
      If esCorrecto = False Then Return False

      Dim auxString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", rValor)
      rValor = FormatNumber(rValor, 2)
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Sub GenerarPlanCuotas()
    Try
      If m_Producto Is Nothing Then Exit Sub
      m_lstPagos.Clear()
      For Each pago In m_Producto.ListaPagos
        m_lstPagos.Add(pago.Clone)
      Next


      Dim Cuota As clsCuota = CType(cmbCuotas.SelectedItem, clsCuota)
      Dim Precio As Decimal
      text2decimal(txtPrecio.Text, Precio)
      Dim ValorCuota As Decimal
      text2decimal(txtValorCuota.Text, ValorCuota)
      Dim auxPago As New clsInfoPagos

      Dim numProxCouta As Integer = 1
      If m_lstPagos.Count > 0 Then
        If m_lstPagos.Last.EstadoPago = E_EstadoPago.Debe Then
          numProxCouta = m_lstPagos.Last.NumCuota
          m_lstPagos.Last.EstadoPago = 2 'editado

        ElseIf m_lstPagos.Last.EstadoPago = E_EstadoPago.Pago Then
          Exit Sub
        End If
      End If
      m_Producto.FechaPrimerPago = New Date(DateVenta.Value.Year, DateVenta.Value.Month, dtDiaVencimiento.Value)


      auxPago = GetProximoPago(m_Producto.GuidProducto, m_Producto.Adelanto, ValorCuota, numProxCouta, m_Producto.FechaVenta, modCommon.Vencimiento(m_Producto.FechaPrimerPago))
      m_lstPagos.Add(auxPago)

      Call ReloadListPagos()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ReloadListPagos()
    Try
      If m_Producto Is Nothing Then Exit Sub
      bsCuotas.DataSource = m_lstPagos ' m_Producto.ListaPagos
      bsCuotas.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function CuotasIguales(ByVal vPrecio As Decimal, ByVal cuotas As Integer) As Decimal
    Try
      Dim valorCuota As Decimal
      If cuotas = 0 Then cuotas = 1
      text2decimal(CDec(vPrecio / cuotas).ToString, valorCuota)
      Return valorCuota
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function

 

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
      m_hayCambios = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSave_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSave.MouseClick
    Try

      Dim vResult As Result
      Dim auxID As Integer
      Dim isNewProducto As Boolean = Not clsProducto.FindGuid(m_Producto.GuidProducto, auxID)

      With m_Producto
        .TotalCuotas = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
        .Precio = CDec(txtPrecio.Text)
        .GuidTipoPago = m_CurrentCuenta.TipoDeCuenta
        .GuidCuenta = m_CurrentCuenta.GuidCuenta
        .Cuenta = m_CurrentCuenta.Clone
        .FechaVenta = DateVenta.Value
        .ListaArticulos = m_lstArticulosVendidos.ToList
        .GuidVendedor = m_CurrentVendedor.GuidVendedor
        .GuidCliente = m_CurrentPersona.GuidCliente
        .ValorCuotaFija = CDec(txtValorCuota.Text)
        If isNewProducto Then
          .CuotasDebe = .TotalCuotas
        End If
        .ListaPagos.Clear()
        .ListaPagos = m_lstPagos.ToList
      End With
      

      'Verificamos campos
      If m_CurrentPersona Is Nothing Then
        MsgBox("No hay ningun Cliente seleccionado")
        Exit Sub
      ElseIf m_CurrentVendedor Is Nothing Then
        MsgBox("No hay ningun Vendedor seleccionado")
        Exit Sub
      ElseIf m_lstArticulosVendidos.Count <= 0 Then
        MsgBox("No hay ningun Articulo Vendido")
        Exit Sub
      ElseIf m_CurrentCuenta Is Nothing Then
        MsgBox("No hay ninguna Cuenta seleccionada")
        Exit Sub
      ElseIf m_Producto.Precio <= 0 Then
        MsgBox("No hay ningun Precio")
        Exit Sub
      ElseIf m_Producto.TotalCuotas < 0 Then
        MsgBox("No hay ninguna Cuota seleccionada")
        Exit Sub
      End If
      m_hayCambios = True


      vResult = clsProducto.Save(m_Producto)
      If vResult <> Result.OK Then
        MsgBox("Fallo save producto")
        Exit Sub
      End If
      Call AplicarPagoAdelantado()


      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AplicarPagoAdelantado()
    Try
      If IsNumeric(txtAdelanto.Text.Trim) Then
        Dim AdelantoCuota As Decimal
        Dim AdelantoVendedor As Decimal
        text2decimal(txtAdelanto.Text, AdelantoCuota)
        text2decimal(txtAdelantoVendedor.Text, AdelantoVendedor)
        Dim Vencimiento As Date
        Dim aux As New clsListPagos
        aux.Cfg_Filtro = "where GuidProducto={" & m_Producto.GuidProducto.ToString & "} and EstadoPago= " & E_EstadoPago.Debe '(Pagos.VencimientoCuota < #" & Format(Today, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
        aux.RefreshData()
        Dim newPago As clsInfoPagos
        'realizar el pago del adelanto

        'pago parte de la cuota actual y genero modifico el valor de la cuota a pagar
        newPago = aux.Items.First.Clone
        newPago.ValorCuota = AdelantoCuota
        newPago.FechaPago = Today
        newPago.EstadoPago = E_EstadoPago.Pago
        Vencimiento = newPago.VencimientoCuota
        clsPago.Save(newPago)

        'proximo pago
        newPago = New clsInfoPagos
        newPago = aux.Items.First.Clone
        newPago = GetProximoPago(m_Producto.GuidProducto, 0, m_Producto.ValorCuotaFija, newPago.NumCuota, m_Producto.FechaVenta, m_Producto.FechaPrimerPago)
        
        If AdelantoCuota < m_Producto.ValorCuotaFija Then
          newPago.ValorCuota = m_Producto.ValorCuotaFija - AdelantoCuota
          newPago.VencimientoCuota = Vencimiento
        Else
          Dim n As Integer = Math.Ceiling(AdelantoCuota / m_Producto.ValorCuotaFija)

          newPago.ValorCuota = m_Producto.ValorCuotaFija * n - AdelantoCuota
          newPago.VencimientoCuota = Vencimiento.AddMonths(n - 1)

        End If

        clsPago.Save(newPago)

        Dim objAdelanto As New clsInfoAdelanto
        objAdelanto.GuidVendedor = m_Producto.GuidVendedor
        objAdelanto.Valor = AdelantoVendedor
        objAdelanto.Fecha = Today
        clsAdelantos.Save(objAdelanto)

      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNewClient_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNewClient.MouseClick
    Try
      Using objForm As New frmCliente(Nothing)
        objForm.ShowDialog()
        Call objForm.GetClient(m_CurrentPersona)
      End Using
      Call Refresh_infoClientVendedor()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSelectClient_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSelectClient.MouseClick
    Try
      Using objForm As New frmListaClientes
        objForm.ShowDialog()
        objForm.GetClienteSelected(m_CurrentPersona)
      End Using
      Call Refresh_infoClientVendedor()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSelectVendedor_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSelectVendedor.MouseClick
    Try
      Using objForm As New frmVendedores
        objForm.ShowDialog()
        objForm.GetVendedorSelected(m_CurrentVendedor)
      End Using
      Call Refresh_infoClientVendedor()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub PermitirVenta()
    Try
      If Not (m_CurrentPersona IsNot Nothing AndAlso m_CurrentVendedor IsNot Nothing) Then
        gpVenta.Enabled = False
        btnSave.Enabled = False
        Exit Sub
      End If
      gpVenta.Enabled = True
      btnSave.Enabled = Not TerminoDePagar(m_Producto)


      Call FillListArticulos()
      Call LoadArticulosVendidos()
      Call FillMedioDePagoDescripcion()
      Call ReloadListPagos()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub FillResponsables()
  '  Try
  '    m_objListStock = New clsListStock
  '    m_objListStock.Cfg_Filtro = "where Cantidad > 0"
  '    m_objListStock.RefreshData()

  '    Dim lstResponsables As New List(Of clsInfoResponsable)
  '    For Each item In m_objListStock.Items
  '      If lstResponsables.Exists(Function(c) c.GuidResponsable = item.GuidResponsable) Then Continue For
  '      lstResponsables.Add(New clsInfoResponsable With {.Nombre = item.Responsable, .Codigo = "", .GuidResponsable = item.GuidResponsable})
  '    Next
  '    cmbResponsables.DataSource = lstResponsables

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub FillListArticulos()
    Try
      If m_lstArticulos IsNot Nothing Then m_lstArticulos.Dispose()

      m_lstArticulos = New clsListArticulos()
      bsArticulos.DataSource = m_lstArticulos.Binding
      m_lstArticulos.RefreshData()
      bsArticulos.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub LoadArticulosVendidos()
    Try
      If clsRelArtProd.Load(m_lstArticulosVendidos, m_Producto.GuidProducto) <> Result.OK Then
        MsgBox("Fallo carga de articulos vendidos")
        Exit Sub
      End If
      Call FillListArticulosVendidos(m_lstArticulosVendidos)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddArticulo.MouseClick
    Try
      If lstArticulos.SelectedIndex < 0 Then Exit Sub
      Dim index As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = (CType(lstArticulos.SelectedItem, clsInfoArticulos).GuidArticulo))
      If index >= 0 Then
        m_lstArticulosVendidos(index).CantidadArticulos += 1
      Else
        Dim auxArticulo As New clsInfoArticuloVendido
        auxArticulo.copy(CType(lstArticulos.SelectedItem, clsInfoArticulos))
        auxArticulo.CantidadArticulos = 1
        m_lstArticulosVendidos.Add(auxArticulo)
      End If
      Call FillListArticulosVendidos(m_lstArticulosVendidos)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemoveArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemoveArticulo.MouseClick
    Try

      If ListView1.SelectedIndices.Count <= 0 Then Exit Sub
      Dim sGuid As Guid = New Guid(ListView1.SelectedItems.Item(0).SubItems(2).Text)
      Dim index As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = sGuid)

      If m_lstArticulosVendidos(index).CantidadArticulos > 1 Then
        m_lstArticulosVendidos(index).CantidadArticulos -= 1
      Else
        m_lstArticulosVendidos.RemoveAt(index)
      End If
      Call FillListArticulosVendidos(m_lstArticulosVendidos)

   
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillListArticulosVendidos(ByVal lstArticulosVendidos As List(Of clsInfoArticuloVendido))
    Try
      ListView1.Items.Clear()
      For Each articulo In lstArticulosVendidos
        Dim item As New ListViewItem

        item.Text = articulo.ToString
        item.SubItems.Add(articulo.CantidadArticulos.ToString)
        item.SubItems.Add(articulo.GuidArticulo.ToString)
        ListView1.Items.Add(item)
      Next
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSeleccionarCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSeleccionarCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_CurrentPersona.GuidCliente)
        objForm.ShowDialog(Me)
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
        Call FillMedioDePagoDescripcion()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_CurrentPersona.GuidCliente)
        objForm.ShowDialog(Me)
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
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
        text2decimal(txtPrecio.Text, precio)
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
        If text2decimal(auxValue, dec) Then
          Call GenerarPlanCuotas()
        End If
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dtDiaVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtDiaVencimiento.ValueChanged
    Try
      If m_skip Then Exit Sub
      If dtDiaVencimiento.Value = 0 Then Exit Sub
      Call GenerarPlanCuotas()
    Catch ex As Exception
      Call Print_msg(ex.Message)
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

  Private Sub txtBuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarArticulo.TextChanged
    Try
      If txtBuscarArticulo.Text.Trim = "" Then
        m_lstArticulos.Cfg_Filtro = ""
      Else
        Dim str As String = txtBuscarArticulo.Text.Trim

        'str = str.Replace("'", "''")
        m_lstArticulos.Cfg_Filtro = "WHERE Nombre Like '%" & str & "%' OR Codigo Like '%" & str & "%'"
      End If
      m_lstArticulos.Items.Clear()
      Call m_lstArticulos.RefreshData()
      bsArticulos.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ListView1_GotFocus(sender As Object, e As EventArgs) Handles ListView1.GotFocus
    Try
      If ListView1.SelectedItems.Count > 0 Then
        ListView1.SelectedItems.Item(0).BackColor = Color.White
        ListView1.SelectedItems.Item(0).ForeColor = Color.Black
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ListView1_LostFocus(sender As Object, e As EventArgs) Handles ListView1.LostFocus
    Try

      If ListView1.SelectedItems.Count > 0 Then
        ListView1.SelectedItems.Item(0).BackColor = SystemColors.Highlight
        ListView1.SelectedItems.Item(0).ForeColor = Color.White
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

 
  'Private Sub cmbResponsables_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbResponsables.SelectedValueChanged
  '  Try
  '    If cmbResponsables.SelectedIndex < 0 Then Exit Sub
  '    Dim ResponsableSeleccionado As clsInfoResponsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable)
  '    m_lstArticulosEnStock = New List(Of clsListaStorage)

  '    For Each objStock In m_objListStock.Items.Where(Function(c) c.GuidResponsable = ResponsableSeleccionado.GuidResponsable)
  '      Dim art As clsInfoArticulos = m_lstArticulos.Items.Where(Function(c) c.GuidArticulo = objStock.GuidArticulo).First
  '      m_lstArticulosEnStock.Add(New clsListaStorage With {.Codigo = art.Codigo, .GuidArticulo = art.GuidArticulo, .Nombre = art.Nombre, .Cantidad = objStock.Cantidad})
  '    Next
  '    lstArticulos.DataSource = Nothing
  '    lstArticulos.DataSource = m_lstArticulosEnStock

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub
End Class