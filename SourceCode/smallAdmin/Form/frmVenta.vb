Imports manDB
Imports libCommon.Comunes
Public Class frmVenta

  Private m_Producto As clsInfoProducto
  Private m_skip As Boolean
  Private m_hayCambios As Boolean

  Private m_CurrentClient As clsInfoCliente
  Private m_CurrentVendedor As clsInfoVendedor
  Private m_lstArticulos As clsListArticulos
  Private m_lstArticulosVendidos As New List(Of clsInfoArticuloVendido)
  Private m_CurrentCuenta As clsInfoCuenta


  Public Sub New(Optional ByVal vProducto As clsInfoProducto = Nothing)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      If vProducto Is Nothing Then
        m_Producto = New clsInfoProducto
        m_Producto.GuidProducto = Guid.NewGuid
        m_CurrentClient = Nothing
        m_CurrentVendedor = Nothing
      Else
        m_Producto = vProducto.Clone
        m_CurrentClient = New clsInfoCliente
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

      datePrimerPago.Value = Today
      txtPrecio.Text = 0
      m_hayCambios = False

      If m_CurrentClient Is Nothing AndAlso m_CurrentVendedor Is Nothing Then Exit Sub
      If m_CurrentClient IsNot Nothing AndAlso m_CurrentVendedor IsNot Nothing Then
        vResult = clsCliente.Cliente_Load(m_Producto.GuidCliente, m_CurrentClient)
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

        vResult = clsRelArtProd.Load(m_Producto.ListaArticulos, m_Producto.GuidProducto)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de Articulos Vendidos")
        End If

        vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
        If vResult <> Result.OK Then
          Call Print_msg("Falloo carga de cuenta")
        End If

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

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Private Sub FillClientData()
    Try
      With m_CurrentClient
        txtNombreCliente.Text = .Personal.ToString
        txtDNICliente.Text = .Personal.DNI
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
        datePrimerPago.Value = .FechaPrimerPago

        For Each cuota In g_Cuotas
          If cuota.Cantidad = .TotalCuotas Then
            cmbCuotas.SelectedItem = cuota
            Exit For
          End If
        Next

      End With
      Call FillMedioDePagoDescripcion()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillMedioDePagoDescripcion()
    Try
      txtMedioPagoDescripcion.Text = GetStringResumen(m_CurrentCuenta)
    
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_infoClientVendedor()
    Try
      If m_CurrentClient IsNot Nothing Then Call FillClientData()
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
      Dim auxValue As String = CType(sender, TextBox).Text
      Dim dec As Decimal
      If text2decimal(auxValue, dec) Then
        Call GenerarPlanCuotas()
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

 
  Private Sub cmbCuotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuotas.SelectedIndexChanged
    Try
      If m_skip Then Exit Sub
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
      'If txtPrecio.Text = String.Empty Then Exit Sub
      'If Not IsNumeric(txtPrecio.Text) Then Exit Sub

      If cmbCuotas.SelectedIndex < 0 Then Exit Sub

      m_Producto.ListaPagos.Clear()
      Dim auxCuotas As Integer = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
      Dim auxPrecio As Decimal
      If text2decimal(txtPrecio.Text, auxPrecio) = False Then Exit Sub
      Dim auxPrecioCuota As Decimal
      If auxCuotas = 0 Then
        auxPrecioCuota = auxPrecio
      Else
        auxPrecioCuota = CuotasIguales(auxPrecio, auxCuotas)
      End If
      txtValorCuota.Text = auxPrecioCuota.ToString


      Dim auxPago As New clsInfoPagos
      Dim auxinicio As Integer = 0
      If auxCuotas > 0 Then auxinicio = 1
      For i As Integer = auxinicio To auxCuotas
        auxPago = New clsInfoPagos
        auxPago.EstadoPago = 0
        auxPago.GuidProducto = m_Producto.GuidProducto
        auxPago.GuidPago = Guid.NewGuid
        auxPago.FechaPago = Nothing ' Vencimiento(auxCuotas, datePrimerPago.Value)
        auxPago.VencimientoCuota = Vencimiento(i, datePrimerPago.Value)
        auxPago.NumCuota = i
        auxPago.ValorCuota = auxPrecioCuota
        m_Producto.ListaPagos.Add(auxPago)
      Next

      m_Producto.FechaPrimerPago = Vencimiento(auxCuotas, datePrimerPago.Value)
      

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ReloadListPagos()
    Try
      If m_Producto Is Nothing Then Exit Sub
      bsCuotas.DataSource = m_Producto.ListaPagos
      bsCuotas.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function CuotasIguales(ByVal vPrecio As Decimal, ByVal cuotas As Integer) As Decimal
    Try
      Dim valorCuota As Decimal
      text2decimal(CDec(vPrecio / cuotas).ToString, valorCuota)
      Return valorCuota
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function

  Private Function Vencimiento(ByVal Cuota As Integer, ByVal PrimerPago As Date) As Date
    Try

      Return PrimerPago.AddMonths(Cuota)
    Catch ex As Exception
      Print_msg(ex.Message)
      Return PrimerPago
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


      With m_Producto
        .TotalCuotas = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
        .Precio = CDec(txtPrecio.Text)
        .GuidTipoPago = m_CurrentCuenta.TipoDeCuenta
        .GuidCuenta = m_CurrentCuenta.GuidCuenta
        .Cuenta = m_CurrentCuenta.Clone
        .FechaVenta = DateVenta.Value
        .ListaArticulos = m_lstArticulosVendidos.ToList
        .GuidVendedor = m_CurrentVendedor.GuidVendedor
      End With
      'Verificamos campos
      If m_CurrentClient Is Nothing Then
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

      Dim vResult As Result
      vResult = clsProducto.Save(m_Producto)
      If vResult <> Result.OK Then
        MsgBox("Fallo save producto")
        Exit Sub
      End If

      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNewClient_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNewClient.MouseClick
    Try
      Using objForm As New frmCliente(frmCliente.E_Modo.Nuevo)
        objForm.ShowDialog()
        Call objForm.GetClient(m_CurrentClient)
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
        objForm.GetClienteSelected(m_CurrentClient)
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
      If Not (m_CurrentClient IsNot Nothing AndAlso m_CurrentVendedor IsNot Nothing) Then
        gpVenta.Enabled = False
        btnSave.Enabled = False
        Exit Sub
      End If
      gpVenta.Enabled = True
      btnSave.Enabled = True
      Call FillListArticulos()
      Call LoadArticulosVendidos()
      Call FillMedioDePagoDescripcion()
      Call ReloadListPagos()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

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
      lstArticulosVendidos.Items.Clear()
      lstArticulosVendidos.Items.AddRange(m_lstArticulosVendidos.ToArray)

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
      lstArticulosVendidos.Items.Clear()
      lstArticulosVendidos.Items.AddRange(m_lstArticulosVendidos.ToArray)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemoveArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemoveArticulo.MouseClick
    Try
      If lstArticulosVendidos.SelectedIndex < 0 Then Exit Sub
      Dim index As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.Equals(CType(lstArticulosVendidos.SelectedItem, clsInfoArticuloVendido)))
      If m_lstArticulosVendidos(index).CantidadArticulos > 1 Then
        m_lstArticulosVendidos(index).CantidadArticulos -= 1
      Else
        m_lstArticulosVendidos.RemoveAt(index)
      End If
      
      lstArticulosVendidos.Items.Clear()
      lstArticulosVendidos.Items.AddRange(m_lstArticulosVendidos.ToArray)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSeleccionarCuenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSeleccionarCuenta.MouseClick
    Try
      Using objForm As New frmCuenta(m_CurrentClient.Personal.GuidCliente)
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
      Using objForm As New frmCuenta(m_CurrentClient.Personal.GuidCliente)
        objForm.ShowDialog(Me)
        objForm.GetCuentaSeleccionada(m_CurrentCuenta)
        Call FillMedioDePagoDescripcion()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Function IsMoneyFormat(ByVal value As String) As Boolean
  '  Try
  '    If value = String.Empty Then Return False
  '    If value.Trim = String.Empty Then Return False
  '    Dim dec As Decimal
  '    Dim esCorrecto As Boolean = Decimal.TryParse(value, dec)
  '    If (esCorrecto) Then
  '      value = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", dec)
  '    End If


  '    If Not IsNumeric(value) Then
  '      Return False
  '    Else
  '      If value.Contains(",") Then
  '        If (value.Substring(value.IndexOf(",")).Count) > 2 Then
  '          Return False
  '        End If
  '      End If
  '    End If
  '    Return True
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return False
  '  End Try
  'End Function

End Class