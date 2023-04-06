﻿Imports manDB
Imports libCommon.Comunes
Public Class frmVenta

  Private m_Producto As clsInfoProducto
  Private m_skip As Boolean
  Private m_hayCambios As Boolean

  Private m_CurrentPersona As ClsInfoPersona
  Private m_CurrentVendedor As clsInfoVendedor
  Private m_CurrentCuenta As clsInfoCuenta

  'Private m_lstPagos As New List(Of clsInfoPagos)
  Private m_lstArticulosVendidos As New List(Of clsInfoArticuloVendido)

  'Private m_NumOperacion As Integer

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



      
      m_hayCambios = False

      ListView1.View = View.Details
      ListView1.Columns(0).Width = CInt(0.5 * ListView1.Width)
      ListView1.Columns(1).Width = CInt(0.25 * ListView1.Width)
      ListView1.Columns(2).Width = CInt(ListView1.Width - ListView1.Columns(0).Width - ListView1.Columns(1).Width)
      ListView1.ShowItemToolTips = True


      lblNumeroVenta.Text = GetUltimoComprobante()


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

        vResult = clsCuenta.Load(m_Producto.GuidCuenta, m_CurrentCuenta)
        If vResult <> Result.OK Then
          Call Print_msg("Fallo carga de cuenta")
        End If

        FillVentaData()
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
      Call FillMedioDePagoDescripcion()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillMedioDePagoDescripcion()
    Try
      If m_CurrentCuenta Is Nothing Then
        lblMedioDePago.Text = "--"
      Else
        lblMedioDePago.Text = GetNameOfTipoPago(m_CurrentCuenta.TipoDeCuenta) & " -- " & m_CurrentCuenta.Codigo1.ToString
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

      'Dim vResult As Result
      'Dim auxID As Integer
      'Dim isNewProducto As Boolean = Not clsProducto.FindGuid(m_Producto.GuidProducto, auxID)

      'With m_Producto
      '  .TotalCuotas = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
      '  .Precio = CDec(txtPrecio.Text)
      '  If m_CurrentCuenta Is Nothing Then
      '    MsgBox("No hay ningun Medio de pago seleccionado")
      '    Exit Sub
      '  End If
      '  .GuidTipoPago = m_CurrentCuenta.TipoDeCuenta
      '  .GuidCuenta = m_CurrentCuenta.GuidCuenta
      '  .Cuenta = m_CurrentCuenta.Clone
      '  .FechaVenta = DateVenta.Value
      '  .ListaArticulos = m_lstArticulosVendidos.ToList
      '  .GuidVendedor = m_CurrentVendedor.GuidVendedor
      '  .GuidCliente = m_CurrentPersona.GuidCliente
      '  .ValorCuotaFija = CDec(txtValorCuota.Text)
      '  If isNewProducto Then
      '    .CuotasDebe = .TotalCuotas
      '  End If
      '  .ListaPagos.Clear()
      '  .ListaPagos = m_lstPagos.ToList
      '  .NumComprobante = CInt(txtNumVenta.Text)
      'End With

      'Dim lstpagos As New clsListPagos()
      'lstpagos.Cfg_Filtro = "where NumComprobante=" & m_Producto.NumComprobante.ToString
      'lstpagos.RefreshData()

      ''Verificamos campos
      'If m_CurrentPersona Is Nothing Then
      '  MsgBox("No hay ningun Cliente seleccionado")
      '  Exit Sub
      'ElseIf m_CurrentVendedor Is Nothing Then
      '  MsgBox("No hay ningun Vendedor seleccionado")
      '  Exit Sub
      'ElseIf m_lstArticulosVendidos.Count <= 0 Then
      '  MsgBox("No hay ningun Articulo Vendido")
      '  Exit Sub
      'ElseIf m_CurrentCuenta Is Nothing Then
      '  MsgBox("No hay ninguna Cuenta seleccionada")
      '  Exit Sub
      'ElseIf m_Producto.Precio <= 0 Then
      '  MsgBox("No hay ningun Precio")
      '  Exit Sub
      'ElseIf m_Producto.TotalCuotas < 0 Then
      '  MsgBox("No hay ninguna Cuota seleccionada")
      '  Exit Sub
      'ElseIf CDec(txtValorCuota.Text) < 0 OrElse CDec(txtValorCuota.Text) > CDec(m_Producto.Precio) Then
      '  MsgBox("El valor de la cuota debe ser mayor a cero y menor o igual que el precio")
      '  Exit Sub
      'ElseIf CInt(txtNumVenta.Text.Trim) <= 0 Then
      '  MsgBox("El numero de comprobante es invalido")
      '  Exit Sub
      'ElseIf lstpagos.Items.Count > 0 Then
      '  MsgBox(String.Format("Ya existe el numero de comprobante {0}", m_Producto.NumComprobante))
      '  Exit Sub
      'ElseIf CDec(txtAdelanto.Text) < 0 OrElse CDec(txtAdelanto.Text) > CDec(m_Producto.Precio) Then
      '  MsgBox("El valor de adelanto debe ser mayor o igual a cero y menor o igual al precio de venta")
      '  Exit Sub
      'ElseIf CDec(txtAdelantoVendedor.Text) > CDec(txtAdelanto.Text) Then
      '  MsgBox("El valor de adelantovendendor debe ser menor o igual que el adelanto del cliente")
      '  Exit Sub
      'End If
      'm_hayCambios = True


      'vResult = clsProducto.Save(m_Producto)
      'If vResult <> Result.OK Then
      '  MsgBox("Fallo save producto")
      '  Exit Sub
      'End If

      ''Descontar los libros del vendedor y luego los del grupo, el resto marcar como debe, en esta venta.
      'DescontarArticulos(m_lstArticulosVendidos)
      'Call AplicarPagoAdelantado()


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
        btnEditarArticulosVendidos.Enabled = False
        btnSave.Enabled = False
        Exit Sub
      End If
      gpVenta.Enabled = True
      btnEditarArticulosVendidos.Enabled = True
      btnSave.Enabled = Not TerminoDePagar(m_Producto)



      Call LoadArticulosVendidos()
      Call FillMedioDePagoDescripcion()
      'Call ReloadListPagos()
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




  


  Private Sub btnEditarArticulosVendidos_Click(sender As Object, e As EventArgs) Handles btnEditarArticulosVendidos.Click
    Try

      Using objform As New frmArticulosVendidos(m_lstArticulosVendidos)
        objform.ShowDialog(Me)
        objform.GetLstArtVendidos(m_lstArticulosVendidos)
      End Using
      RefreshResumenProductosVendidos(m_lstArticulosVendidos)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnPagos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPagos.MouseClick
    Try
      Using objForm As New frmEstablecerPagos(m_Producto, m_CurrentPersona, m_CurrentVendedor)
        objForm.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class