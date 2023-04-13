Imports manDB
Imports libCommon.Comunes
Public Class frmVenta

  Private m_Producto As clsInfoProducto
  Private m_skip As Boolean
  Private m_hayCambios As Boolean
  Private m_CurrentPersona As ClsInfoPersona
  Private m_CurrentVendedor As clsInfoVendedor
  Private m_lstArticulosVendidos As New List(Of clsInfoArticuloVendido)


  Public Sub New(Optional ByVal vProducto As clsInfoProducto = Nothing)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      If vProducto Is Nothing Then
        m_Producto = New clsInfoProducto
        m_Producto.GuidProducto = Guid.Empty  'Solo se genera cuando se guarda la venta' Guid.NewGuid
        m_CurrentPersona = Nothing
        m_CurrentVendedor = Nothing
      Else
        m_Producto = vProducto.Clone
        m_CurrentPersona = New ClsInfoPersona
        m_CurrentVendedor = New clsInfoVendedor
        'm_CurrentCuenta = New clsInfoCuenta
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
      m_hayCambios = False

      ListView1.View = View.Details
      ListView1.Columns(0).Width = CInt(0.5 * ListView1.Width)
      ListView1.Columns(1).Width = CInt(0.25 * ListView1.Width)
      ListView1.Columns(2).Width = CInt(ListView1.Width - ListView1.Columns(0).Width - ListView1.Columns(1).Width)
      ListView1.ShowItemToolTips = True

      lblNumeroVenta.Text = GetUltimoComprobante()
      lblFechaVenta.Text = GetAhora.ToString("dd/MM/yyyy")


      If m_CurrentPersona Is Nothing AndAlso m_CurrentVendedor Is Nothing Then Exit Sub
      If m_CurrentPersona IsNot Nothing AndAlso m_CurrentVendedor IsNot Nothing Then
        vResult = clsPersona.Load(m_Producto.GuidCliente, m_CurrentPersona)
        If vResult <> Result.OK Then
          Call Print_msg("Fallo carga de cliente")
        End If
        vResult = clsVendedor.Load(m_Producto.GuidVendedor, m_CurrentVendedor)
        If vResult <> Result.OK Then
          Call Print_msg("Fallo carga de vendedor")
        End If
        vResult = clsPago.Load(m_Producto.ListaPagos, m_Producto.GuidProducto)
        If vResult <> Result.OK Then
          Call Print_msg("Fallo carga de Pagos")
        End If

        vResult = clsRelArtProd.Load(m_Producto.ListaArticulos, m_Producto.GuidProducto)
        If vResult <> Result.OK Then
          Call Print_msg("Fallo carga de Articulos Vendidos")
        End If

       

        FillClientData()
        FillVendedorData()
        LoadArticulosVendidos()
        FillVentaData()
        FillVenta()
        If TerminoDePagar(m_Producto) Then btnSave.Enabled = False

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
      'm_lstPagos = m_Producto.ListaPagos.ToList
      'm_NumOperacion = m_lstPagos.Last.NumComprobante
      'lblNumComprobante.Text = m_NumOperacion.ToString



      'DateVenta.Value = m_Producto.FechaVenta
      'dtDiaVencimiento.Value = m_Producto.FechaPrimerPago.Day

      With m_Producto

        lblFechaVenta.Text = .FechaVenta.ToString("dd/MM/yyyy")
        'If .FechaPrimerPago.Day > 30 Then
        '  dtDiaVencimiento.Value = dtDiaVencimiento.Maximum
        'Else
        '  dtDiaVencimiento.Value = .FechaPrimerPago.Day
        'End If
        lblTotalCuotas.Text = .TotalCuotas
        lblTotal.Text = .Precio.ToString
        lblCuota.Text = .ValorCuotaFija.ToString
        lblNumeroVenta.Text = .NumComprobante.ToString
        'For Each cuota In g_Cuotas
        '  If cuota.Cantidad = .TotalCuotas Then
        '    cmbCuotas.SelectedItem = cuota
        '    Exit For
        '  End If
        'Next
        'If .ListaPagos.Count > 0 Then
        '  txtValorCuota.Text = .ValorCuotaFija.ToString  ' .ListaPagos.Last.ValorCuota.ToString
        'Else
        '  txtValorCuota.Text = .Precio.ToString
        'End If


      End With
      lblMedioDePago.Text = FillMedioDePagoDescripcion()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  '
  Private Function FillMedioDePagoDescripcion() As String
    Try
      Dim vResult As Result
      Dim auxCuenta As clsInfoCuenta = Nothing
      vResult = clsCuenta.Load(m_Producto.GuidCuenta, auxCuenta)
      If vResult <> Result.OK Then
        Call Print_msg("Fallo carga de cuenta")
        Return "--"
      End If
      If auxCuenta Is Nothing Then
        Return "--"
      Else
        Return GetNameOfTipoPago(auxCuenta.TipoDeCuenta) & " -- " & auxCuenta.Codigo1.ToString
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
      Return "--"
    End Try
  End Function

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


  'Private Sub ReloadListPagos()
  '  Try
  '    If m_Producto Is Nothing Then Exit Sub
  '    bsCuotas.DataSource = m_lstPagos ' m_Producto.ListaPagos
  '    bsCuotas.ResetBindings(False)
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

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
      'validar el cliente
      'validar el vendedor
      'validar la lista de productos
      'validar la relacion de los pagos, cliente, vendedor
      'guardar en DB

      If m_CurrentPersona.GuidCliente = Guid.Empty Then
        MsgBox("Debe elegir o crear un cliente")
        Exit Sub
      End If
      If m_CurrentVendedor.GuidVendedor = Guid.Empty Then
        MsgBox("Debe elegir o crear un vendedor")
        Exit Sub
      End If

      If m_lstArticulosVendidos.Count <= 0 Then
        MsgBox("Debe elegir al menos un producto para generar una venta")
        Exit Sub
      End If

      If Not (m_Producto.GuidCliente = m_CurrentPersona.GuidCliente) Then
        MsgBox("los datos del producto y del cliente son diferentes")
        Exit Sub
      End If
      If Not (m_Producto.GuidVendedor = m_CurrentVendedor.GuidVendedor) Then
        MsgBox("los datos del producto y del vendedor son diferentes")
        Exit Sub
      End If




      Dim auxCuenta As clsInfoCuenta = Nothing

      If clsCuenta.Load(m_Producto.GuidCuenta, auxCuenta) = Result.OK Then
        If auxCuenta.GuidCliente = Guid.Empty Then
          MsgBox("Verifique los datos del cliente y los de la cuenta para pagar utilizados")
          Exit Sub
        End If
        If Not (m_Producto.GuidCliente = auxCuenta.GuidCliente) Then
          MsgBox("los datos de la cuenta y del cliente son diferentes")
          Exit Sub
        End If
      Else
        MsgBox("Los datos de la cuenta son incongruentes")
        Exit Sub
      End If
      m_Producto.ListaArticulos.Clear()
      For Each item In m_lstArticulosVendidos
        m_Producto.ListaArticulos.Add(item)
      Next


      If clsProducto.Save(m_Producto) <> Result.OK Then
        MsgBox("Fallo al guardar la venta en la base de datos")
        Exit Sub
      End If

      DescontarArticulos(m_lstArticulosVendidos)



      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub DescontarArticulos(ByVal vArticulos As List(Of clsInfoArticuloVendido))
    Try
      Dim ArtParaVender As New clsListStock
      ArtParaVender.RefreshData()
      Dim lstResponsables As New List(Of Guid)
      lstResponsables.Add(m_CurrentVendedor.GuidVendedor)
      lstResponsables.Add(clsGrupo.GetByName(m_CurrentVendedor.Grupo))


      For Each articuloVendido In vArticulos
        'si el vendedor es responsable
        Dim CantidadArticuloDebe As Integer = articuloVendido.Entregados

        For Each responsable In lstResponsables
          If ArtParaVender.Items.Exists(Function(c) (c.GuidResponsable = responsable AndAlso c.GuidArticulo = articuloVendido.GuidArticulo)) Then
            Dim auxArtStock As clsInfoStock = ArtParaVender.Items.Find(Function(c) (c.GuidResponsable = responsable AndAlso c.GuidArticulo = articuloVendido.GuidArticulo))
            If auxArtStock.Cantidad >= CantidadArticuloDebe Then
              'descontar
              auxArtStock.Cantidad = auxArtStock.Cantidad - CantidadArticuloDebe
              CantidadArticuloDebe = 0
            Else
              'descontar los que se puedan
              auxArtStock.Cantidad = 0
              CantidadArticuloDebe = CantidadArticuloDebe - auxArtStock.Cantidad
            End If
            clsStock.Save(auxArtStock)
            If CantidadArticuloDebe <= 0 Then Exit For
          End If

        Next
        'If CantidadArticuloDebe > 0 Then
        '  'La cantidad de articulos entregados es mayor a la cantidad de articulos diponibles en el grupo/vendedor, desea disminuir la cantidad de articulos entregados?
        '  Dim mResult As MsgBoxResult = MsgBox("La cantidad de articulos entregados es mayor a la cantidad de articulos diponibles en el grupo/vendedor, desea disminuir la cantidad de articulos entregados?", MsgBoxStyle.YesNo)
        '  If mResult = MsgBoxResult.Yes Then
        '    articuloVendido.Entregados -= CantidadArticuloDebe
        '    clsRelArtProd.Save()
        '  End If

        'End If



      Next
    Catch ex As Exception
      Print_msg(ex.Message)
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
        objForm.ShowDialog(Me)
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
        objForm.ShowDialog(Me)
        If objForm.GetResult = Result.OK Then
          objForm.GetVendedorSelected(m_CurrentVendedor)
        End If

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
        btnEditarArticulosVendidos.Enabled = False
        btnSave.Enabled = False
        Exit Sub
      End If
      gpVenta.Enabled = True
      btnEditarArticulosVendidos.Enabled = True
      btnSave.Enabled = Not TerminoDePagar(m_Producto)



      Call LoadArticulosVendidos()
      lblMedioDePago.Text = FillMedioDePagoDescripcion()

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



  Private Sub LoadArticulosVendidos()
    Try
      'cargar a la lista los articulos vendidos
      If clsRelArtProd.Load(m_lstArticulosVendidos, m_Producto.GuidProducto) <> Result.OK Then
        MsgBox("Fallo carga de articulos vendidos")
        Exit Sub
      End If

      RefreshResumenProductosVendidos(m_lstArticulosVendidos)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub RefreshResumenProductosVendidos(ByVal lstArticulosVendidos As List(Of clsInfoArticuloVendido))
    Try
      ListView1.Items.Clear()
      For Each articulo In lstArticulosVendidos
        Dim item As New ListViewItem

        item.Text = articulo.ToString
        item.SubItems.Add(articulo.CantidadArticulos.ToString)
        item.SubItems.Add(articulo.Entregados.ToString)
        item.SubItems.Add(articulo.GuidArticulo.ToString)
        ListView1.Items.Add(item)
      Next
    Catch ex As Exception
      Print_msg(ex.Message)
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



  Private Sub FillVenta()
    Try
      If m_Producto Is Nothing Then Exit Sub

      'No se puede editar lo que ya esta pagado, se puede modificar en adelante, considerando lo ya pagado
      Dim Precio As Decimal
      Dim ValorCuota As Decimal
      lblFechaVenta.Text = m_Producto.FechaVenta.ToString("dd/MM/yyyy")
      lblNumeroVenta.Text = m_Producto.NumComprobante
      lblMedioDePago.Text = FillMedioDePagoDescripcion()
      lblTotal.Text = m_Producto.Precio
      lblTotalCuotas.Text = m_Producto.TotalCuotas
      lblCuota.Text = m_Producto.ValorCuotaFija

      ConvStr2Dec(m_Producto.Precio, Precio)
      ConvStr2Dec(m_Producto.ValorCuotaFija, ValorCuota)




      lvPlanPagos.Items.Clear()
      For Each pago As clsInfoPagos In m_Producto.ListaPagos
        Dim item As New ListViewItem
        item.Text = pago.NumCuota
        item.SubItems.Add(pago.VencimientoCuota.ToString("dd/MM/yyyy"))
        item.SubItems.Add(pago.ValorCuota)
        item.SubItems.Add(Date2String(pago.FechaPago)) 'fecha de pago

        item.SubItems.Add(EstadoPagos2String(pago.EstadoPago)) 'fecha de pago
        lvPlanPagos.Items.Add(item)
      Next



    Catch ex As Exception
      Print_msg(ex.Message)
    End Try


  End Sub



  Private Sub btnEditarArticulosVendidos_Click(sender As Object, e As EventArgs) Handles btnEditarArticulosVendidos.Click
    Try

      Using objform As New frmArticulosVendidos(m_lstArticulosVendidos)
        objform.ShowDialog(Me)
        If objform.GetResult = Result.OK Then
          objform.GetLstArtVendidos(m_lstArticulosVendidos)
        End If

      End Using
      RefreshResumenProductosVendidos(m_lstArticulosVendidos)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnPagos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPagos.MouseClick
    Try
      If m_CurrentPersona.GuidCliente = Guid.Empty Then
        MsgBox("Primero debe elegir o crear un cliente")
        Exit Sub
      End If
      If m_CurrentVendedor.GuidVendedor = Guid.Empty Then
        MsgBox("Primero debe elegir o crear un vendedor")
        Exit Sub
      End If
      Using objForm As New frmEstablecerPagos(m_Producto, m_CurrentPersona, m_CurrentVendedor)
        objForm.ShowDialog(Me)
        If objForm.GetResult = Result.OK Then
          objForm.GetProducto(m_Producto)
        End If

      End Using
      FillVenta()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class