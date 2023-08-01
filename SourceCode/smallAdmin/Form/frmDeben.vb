Imports libCommon.Comunes
Imports manDB

Public Class frmDeben

  Private m_CurrentVenta As clsInfoConsultaVentas = Nothing
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"
  Private m_lstConsulta As New List(Of clsInfoConsultaVentas)

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    Try
      If MsgBox("Desea salir del programa?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        Me.Close()
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmDeben_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Dim vResult As libCommon.Comunes.Result
      lblSoftwareInfo.Text = Entorno.GetSoftwareInfo
      vResult = Entorno.init
      If vResult <> Result.OK Then
        MsgBox("No continua application, error init")
      End If
      lblFechaHoy.Text = String.Format("Fecha: {0}", g_Today.ToString("dd/MM/yyyy"))

      dateInicio.Value = New Date(g_Today.Year, g_Today.Month, 1)
      dateFin.Value = g_Today
      dtDebenHasta.Value = g_Today

      Dim MetodosBusqueda As New List(Of clsTipoPago)
      'MetodosBusqueda.Add(New clsTipoPago With {.GuidTipo = Guid.Empty, .Nombre = "Todos Los Medios"})
      MetodosBusqueda.AddRange(g_TipoPago.ToList)
      cmbMetodosDePago.DataSource = MetodosBusqueda
      cmbMetodosDePago.SelectedIndex = 0

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmDeben_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try

      Call FillResumen()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub Button4_Click(sender As Object, e As EventArgs)
  '  Try
  '    If m_objPrincipal IsNot Nothing Then m_objPrincipal.Dispose()
  '    m_objPrincipal = New clsListaPrincipal()
  '    Dim auxGuid As New Guid("7580f2d4-d9ec-477b-9e3a-50afb7141ab5")
  '    m_objPrincipal.MetodoPago = g_TipoPago.Where(Function(c) c.GuidTipo.ToString = auxGuid.ToString).First.GuidTipo
  '    m_objPrincipal.Cfg_Filtro = "where Productos.FechaVenta between #" & Format(Date.MinValue, strFormatoAnsiStdFecha) & "# and #" & Format(Date.MaxValue, strFormatoAnsiStdFecha) & "#"
  '    m_objPrincipal.Deben = "1"
  '    bsInfoPrincipal.DataSource = m_objPrincipal.Binding
  '    Call ProductList_RefreshData()



  '    bsInfoPrincipal.ResetBindings(False)
  '    FillResumen()
  '    Call RefreshDataOperaciones()

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Function Consulta(ByRef rconsulta As String) As libCommon.Comunes.Result
    Try
      Dim qNombreCliente As String = String.Empty
      If Not String.IsNullOrEmpty(txtNombreCliente.Text.Trim) Then
        'crear consulta nombre, apellido
        '"SELECT Clientes.NumCliente, Clientes.Nombre, Clientes.Apellido, Vendedores.Nombre, Vendedores.Apellido, Productos.TotalCuotas, Productos.NumComprobante, Productos.GuidProducto, Productos.GuidCliente, Productos.GuidVendedor FROM Clientes, Productos, Vendedores WHERE Clientes.Nombre Like '%" & txtNombreCliente.Text.Trim & "%' OR Clientes.Apellido Like '%" & txtNombreCliente.Text.Trim & "%'"
        qNombreCliente = "Clientes.Nombre Like '%" & txtNombreCliente.Text.Trim & "%' OR Clientes.Apellido Like '%" & txtNombreCliente.Text.Trim & "%'"
      End If
      Dim qNombreVendedor As String = String.Empty
      If Not String.IsNullOrEmpty(txtNombreVendedor.Text.Trim) Then
        'crear consulta nombre, apellido
        qNombreVendedor = "Vendedores.Nombre Like '%" & txtNombreVendedor.Text.Trim & "%' OR Vendedores.Apellido Like '%" & txtNombreVendedor.Text.Trim & "%'"
      End If
      'cuotas pagas
      Dim qGuidMetodoPago As String = String.Empty
      If chkMetodoPago.Checked Then
        If cmbMetodosDePago.SelectedIndex >= 0 Then
          Dim auxPago As clsTipoPago = CType(cmbMetodosDePago.SelectedItem, clsTipoPago)
          'qGuidMetodoPago = "Cuentas.TipoDeCuentas={" & auxPago.GuidTipo.ToString & "}"
          '"SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & "D1F63B6F-81A0-4699-924B-16A219B44EF7" & "})"
          qGuidMetodoPago = "GuidProducto IN (SELECT DISTINCT GuidProducto FROM Pagos WHERE GuidCuenta IN (SELECT GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & auxPago.GuidTipo.ToString & "}))"  'auxPago.GuidTipo.ToString
        End If

      End If

      Dim qVentaEstados As String = String.Empty
      If chkEnableDateTo.Checked = True Then
        'qVentaEstados = "GuidProducto IN (SELECT DISTINCT GuidProducto FROM Pagos Where EstadoPago=" & "0" & ")"  'DEBE}
        '"where Productos.FechaVenta between #" & Format(Date.MinValue, strFormatoAnsiStdFecha) & "# and #" & Format(Date.MaxValue, strFormatoAnsiStdFecha) & "#"
        qVentaEstados = "GuidProducto IN (SELECT DISTINCT GuidProducto FROM Pagos Where (VencimientoCuota<=#" & Format(dateFin.Value, strFormatoAnsiStdFecha) & "#) AND EstadoPago<>1 )"
      End If

      Dim qVentasDesde As String = String.Empty
      If chkEnableDateFrom.Checked = True Then
        qVentasDesde = "Productos.FechaVenta>=#" & Format(dateFin.Value, strFormatoAnsiStdFecha) & "#"
      End If
      Dim qVentasHasta As String = String.Empty
      If chkEnableDateTo.Checked = True Then
        qVentasHasta = "Productos.FechaVenta<=#" & Format(dateFin.Value, strFormatoAnsiStdFecha) & "#"
      End If

      If Not String.IsNullOrEmpty(qNombreCliente) Then
        rconsulta = qNombreCliente
      End If

      If Not String.IsNullOrEmpty(qNombreVendedor) Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qNombreVendedor
      End If
      If Not String.IsNullOrEmpty(qNombreVendedor) Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qNombreVendedor
      End If
      If Not String.IsNullOrEmpty(qGuidMetodoPago) AndAlso chkMetodoPago.Checked Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qGuidMetodoPago
      End If

      If Not String.IsNullOrEmpty(qVentaEstados) AndAlso chkEnableDateTo.Checked Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qVentaEstados
      End If

      'Ventas Realizadas
      If Not String.IsNullOrEmpty(qVentasHasta) AndAlso chkEnableDateTo.Checked Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qVentasHasta
      End If

      If Not String.IsNullOrEmpty(qVentasDesde) AndAlso chkEnableDateFrom.Checked Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qVentasDesde
      End If

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub MostrarDeben()
    Try
      Dim vResult As libCommon.Comunes.Result
      'get Query
      Dim rConsulta As String = String.Empty
      vResult = Consulta(rConsulta)
      If vResult <> Result.OK Then
        MsgBox("No se puede obtener la consulta")
        Exit Sub
      End If
      m_lstConsulta.Clear()
      vResult = clsConsulta.ConsultaProductos(rConsulta, m_lstConsulta)
      If vResult <> Result.OK Then
        MsgBox("No se puede realizar la consulta")
      End If
      ClsInfoConsultaVentasBindingSource.DataSource = m_lstConsulta
      ClsInfoConsultaVentasBindingSource.ResetBindings(False)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Function Filtro(ByVal modo As String) As Result
  '  Try
  '    Dim sqlDate As String = "Productos.FechaVenta between #" & Format(dateInicio.Value, strFormatoAnsiStdFecha) & "# and #" & Format(dateFin.Value.AddDays(1), strFormatoAnsiStdFecha) & "#"
  '    Dim sqlClient As String = "GuidCliente in (select GuidCliente from Clientes where Nombre Like '%" & txtBusqueda.Text.Trim & "%' OR Apellido Like '%" & txtBusqueda.Text.Trim & "%' OR NumCliente Like '%" & txtBusqueda.Text.Trim & "%')"
  '    Dim sqlVendedor As String = "GuidVendedor in (select GuidVendedor from Vendedores where Nombre Like '%" & txtBusqueda.Text.Trim & "%' OR Apellido Like '%" & txtBusqueda.Text.Trim & "%' OR NumVendedor Like '%" & txtBusqueda.Text.Trim & "%' OR Grupo Like '%" & txtBusqueda.Text.Trim & "%')"

  '    Dim filtrar As String = String.Empty
  '    If rbtnClientName.Checked Then
  '      filtrar = " and " & sqlClient
  '    ElseIf rbtnNombreVendedor.Checked Then
  '      filtrar = " and " & sqlVendedor
  '    Else
  '      filtrar = String.Empty
  '    End If

  '    m_objPrincipal.MetodoPago = CType(cmbMetodosDePago.SelectedItem, clsTipoPago).GuidTipo
  '    m_objPrincipal.Cfg_Filtro = "where " & sqlDate & filtrar

  '    If rbtnVendidos.Checked = True Then
  '      m_objPrincipal.Deben = "0"
  '    ElseIf rbtnDeben.Checked Then
  '      m_objPrincipal.Deben = "1"
  '    ElseIf rbtnCancelados.Checked Then
  '      m_objPrincipal.Deben = "2"
  '    ElseIf rbtnCuotaPagaron.Checked Then
  '      m_objPrincipal.Deben = "3"
  '    ElseIf rbtnSinEntregar.Checked Then
  '      m_objPrincipal.Deben = "4"
  '    Else
  '      m_objPrincipal.Cfg_Filtro = ""
  '      m_objPrincipal.Deben = "0"
  '    End If

  '    Return Result.OK
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  'Private Sub ProductList_RefreshData()
  '  Try
  '    m_objPrincipal.RefreshData()

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub dgvVentas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVentas.ColumnHeaderMouseClick
    Try
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvVentas.Columns(e.ColumnIndex)
      'm_ColumnName = m_CurrentSortColumn.DataPropertyName


      'If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
      '  m_Order = "ASC"
      'ElseIf m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
      '  m_Order = "DESC"
      'Else
      '  m_Order = "ASC"
      'End If
      'm_objPrincipal.SetOrder(m_ColumnName, m_Order)

      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvVentas.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        ClsInfoConsultaVentasBindingSource.DataSource = m_lstConsulta.OrderBy(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c))).ToList()

        ClsInfoConsultaVentasBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)

      Else
        For Each col As DataGridViewColumn In dgvVentas.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        ClsInfoConsultaVentasBindingSource.DataSource = m_lstConsulta.OrderByDescending(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c))).ToList()

        ClsInfoConsultaVentasBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)

      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvVentas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentas.SelectionChanged
    Try
      If dgvVentas.SelectedRows.Count <> 1 Then Exit Sub
      Call Refresh_Selection(dgvVentas.SelectedRows(0).Index)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub dgvData_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
  '  Try
  '    Dim m_CurrentSortColumn As DataGridViewColumn = dgvData.Columns(e.ColumnIndex)
  '    'm_ColumnName = m_CurrentSortColumn.DataPropertyName


  '    'If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
  '    '  m_Order = "ASC"
  '    'ElseIf m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
  '    '  m_Order = "DESC"
  '    'Else
  '    '  m_Order = "ASC"
  '    'End If
  '    'm_objPrincipal.SetOrder(m_ColumnName, m_Order)

  '    If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
  '      For Each col As DataGridViewColumn In dgvData.Columns
  '        col.HeaderCell.SortGlyphDirection = SortOrder.None
  '      Next
  '      bsInfoPrincipal.DataSource = m_objPrincipal.Items.OrderBy(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()

  '      bsInfoPrincipal.ResetBindings(False)
  '      m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)

  '    Else
  '      For Each col As DataGridViewColumn In dgvData.Columns
  '        col.HeaderCell.SortGlyphDirection = SortOrder.None
  '      Next
  '      bsInfoPrincipal.DataSource = m_objPrincipal.Items.OrderByDescending(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()

  '      bsInfoPrincipal.ResetBindings(False)
  '      m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)

  '    End If

  '    'Call MostrarDeben()
  '    'm_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(IIf(m_Order = "ASC", SortOrder.Ascending, SortOrder.Descending), Windows.Forms.SortOrder)
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvVentas.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_CurrentVenta = CType(dgvVentas.Rows(indice).DataBoundItem, clsInfoConsultaVentas)

      End If
      If dgvVentas.Rows(indice).Selected <> True Then
        dgvVentas.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnLstVendedores_Click(sender As Object, e As EventArgs) Handles btnLstVendedores.Click
    Try
      Using objForm As New frmVendedores
        objForm.ShowDialog()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnListaClientes_Click(sender As Object, e As EventArgs) Handles btnListaClientes.Click
    Try
      Using objForm As New frmListaClientes
        objForm.ShowDialog()
      End Using
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    Try
    

      Using objVenta As New frmVenta()
        objVenta.ShowDialog()
        If objVenta.HayCambios Then

        End If
      End Using
      clsCobros.ActualizarEstadosDePagos(g_Today)
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditarVenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEditarVenta.MouseClick
    Try
      If m_CurrentVenta Is Nothing Then
        MsgBox("Debe seleccionar un producto para modificarlo.")
        Exit Sub
      End If
      Dim auxProducto As New clsInfoProducto
      Dim vResult As Result = clsProducto.Load(m_CurrentVenta.Guid_Producto, auxProducto)
      If vResult <> Result.OK Then
        MsgBox("Falla al cargar el producto seleccionado")
      End If
      Using objForm As New frmVenta(auxProducto)
        objForm.ShowDialog()
      End Using
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditarPagos_Click(sender As Object, e As EventArgs) Handles btnEditarPagos.Click
    Try
      If m_CurrentVenta Is Nothing Then
        MsgBox("Debe seleccionar un producto para modificarlo.")
        Exit Sub
      End If
      Dim auxProducto As New clsInfoProducto
      Dim vResult As Result = clsProducto.Load(m_CurrentVenta.Guid_Producto, auxProducto)
      If vResult <> Result.OK Then
        MsgBox("Falla al cargar el producto seleccionado")
      End If
      Using objForm As New frmEditarPagos(auxProducto)
        objForm.ShowDialog()
      End Using
      Call MostrarDeben()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
    Try

      Dim vResult As libCommon.Comunes.Result
      vResult = clsProducto.Delete(New Guid("6f9f3b59-e694-44b2-b77b-c0cee41e2266"))
      If vResult <> Result.OK Then
        MsgBox("No se pudo eliminar la venta")
      End If

      If m_CurrentVenta Is Nothing Then
        MsgBox("Debe seleccionar un producto para modificarlo.")
        Exit Sub
      End If

      '1- RESTAURAR Articulos Vendidos a STOCK
      Dim listArticulos As New List(Of clsInfoArticuloVendido)
      vResult = clsRelArtProd.Load(listArticulos, m_CurrentVenta.Guid_Producto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar Articulos vendidos")
        Exit Sub
      End If

      For Each articulo In listArticulos
        'busco el art viejo en stock e imcremento la cantidad del art vendido
        Dim auxStock As New manDB.clsInfoStock
        auxStock.GuidArticulo = articulo.GuidArticulo
        auxStock.GuidResponsable = New Guid("B7B5BDDF-8EA5-406A-A5BC-A01723CFD25D")
        vResult = clsStock.Load(auxStock)
        If vResult <> Result.OK Then
          MsgBox("No se pudo cargar el articulo")
        End If
        auxStock.Cantidad = auxStock.Cantidad + articulo.Entregados
        vResult = clsStock.Save(auxStock)
        If vResult <> Result.OK Then
          MsgBox("No se pudo guardar el articulo")
        End If
      Next

      '2- ELIMINAR REL ARTICULO VENDIDO ASOCIADO A LA VENTA
      vResult = clsRelArtProd.DeleteTodos(m_CurrentVenta.Guid_Producto)
      If vResult <> Result.OK Then
        MsgBox("No se pudo eliminar la relacion de productos vendidos")
      End If

      '3- ELIMINAR RELACIONES DE ADELANTOS
      vResult = clsAdelantos.Delete(m_CurrentVenta.Guid_Producto)
      If vResult <> Result.OK Then
        MsgBox("No se pudo eliminar la relacion de Adelantos al vendedor")
      End If

      '4- ELIMNAR TODOS LOS TICKET de PAGO
      vResult = clsPago.Delete(m_CurrentVenta.Guid_Producto)
      If vResult <> Result.OK Then
        MsgBox("No se pudo eliminar los ticket de cuotas generados")
      End If

      vResult = clsProducto.Delete(m_CurrentVenta.Guid_Producto)
      If vResult <> Result.OK Then
        MsgBox("No se pudo eliminar la venta")
      End If

      'Refrescar grilla
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillResumen()
    Try
      If m_CurrentVenta Is Nothing Then
        lblTotalArticulos.Text = "Total de Articulos = 0"
        lblTotalProductos.Text = "Total de Productos = 0"
        lblPorcentaje.Text = "Porcentaje Pagado: --"
        lblPrecioInteres.Text = String.Format("Total de Vendidos con interes = --")
        lblPagos.Text = String.Format("Total de Pagos = --")
      Else
        'If m_CurrentVenta.Items.Count = 0 Then
        '  lblTotalArticulos.Text = "Total de Articulos = 0"
        '  lblTotalProductos.Text = "Total de Productos = 0"
        'Else
        '  lblTotalArticulos.Text = String.Format("Total de Articulos = {0}", m_CurrentVenta.Items.Sum(Function(c) c.ArticulosVendidos))
        '  lblTotalProductos.Text = String.Format("Total de Productos = {0}", m_CurrentVenta.Items.Count)
        '  lblPrecioTotal.Text = String.Format("Total de Vendidos = {0}", m_CurrentVenta.Items.Sum(Function(c) c.Precio))
        '  Dim ValorNominal As Decimal = 0
        '  Dim parcial As Decimal = 0
        '  For Each item In m_CurrentVenta.Items
        '    ValorNominal = ValorNominal + item.ValorCuotaFija * item.CuotasTotales
        '    Dim lstPagos As New List(Of clsInfoPagos)
        '    clsPago.Load(lstPagos, item.GuidProducto)
        '    parcial += lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago Or c.EstadoPago = E_EstadoPago.PagoParcial).Sum(Function(c) c.ValorCuota)
        '  Next
        '  lblPrecioInteres.Text = String.Format("Total de Vendidos con interes = {0}", ValorNominal)
        '  lblPagos.Text = String.Format("Total de Pagos = {0}", parcial)
        '  If ValorNominal > 0 Then
        '    lblPorcentaje.Text = String.Format("Porcentaje Pagado: {0:N2}%", CDec(parcial * 100 / ValorNominal))
        '  Else
        '    lblPorcentaje.Text = "Porcentaje Pagado: --"
        '  End If

        '  '''''RESUMEN INTERNO
        '  Dim auxStr As String = String.Empty

        '  auxStr = String.Format("LIQUIDADO:{0}", m_CurrentVenta.Items.Where(Function(c) c.CuotasPagas = c.CuotasTotales).Count)


        '  lblResumen.Text = auxStr
        'End If


      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub RefreshDataOperaciones()
  '  Try
  '    gpPagarCuota.Enabled = False
  '    gbModificarFormadePago.Enabled = False
  '    gbAnularPago.Enabled = False
  '    chkPagoParcial.Checked = False
  '    txtImporteParcial.Enabled = False

  '    If m_CurrentProducto Is Nothing Then Exit Sub
  '    lblInfodeFormadePago.Text = String.Format("Forma de Pago Actual: {0}", m_CurrentProducto.MetodoPago)
  '    If m_CurrentProducto.CuotasPagas >= 1 Then
  '      gbAnularPago.Enabled = True
  '    End If
  '    If m_CurrentProducto.CuotasPagas < m_CurrentProducto.CuotasTotales Then
  '      gpPagarCuota.Enabled = True
  '      cmbNumCuotasCancelar.Items.Clear()
  '      Dim c As Integer = 0
  '      Do
  '        c = c + 1
  '        cmbNumCuotasCancelar.Items.Add(c)
  '      Loop Until m_CurrentProducto.CuotasTotales = (m_CurrentProducto.CuotasPagas + c)
  '      cmbNumCuotasCancelar.SelectedIndex = 0

  '      gbModificarFormadePago.Enabled = True

  '      'Call CargarMetodosDePago()
  '      'For Each item As clsInfoCuenta In cmbFormaDePago.Items
  '      '  If item.ToString = m_CurrentProducto.MetodoPago Then
  '      '    cmbFormaDePago.SelectedItem = item
  '      '    Exit For
  '      '  End If

  '      'Next

  '      'seleccionar el metodo de pago actual



  '    End If
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  Private Sub btnArticulos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnArticulos.MouseClick
    Try
      'llamar a form articulos
      Using objForm As New frmArticulos
        objForm.ShowDialog()
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  'Private Sub btnUpPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnUpPago.MouseClick
  '  Try
  '    Dim vResult As Result
  '    If m_CurrentProducto Is Nothing Then
  '      MsgBox("Debe seleccionar un producto")
  '      Exit Sub
  '    End If

  '    If m_CurrentProducto.CuotasTotales > 0 AndAlso m_CurrentProducto.CuotasPagas >= m_CurrentProducto.CuotasTotales Then
  '      MsgBox("No hay cuotas pendientes, no se puede aplicar un pago")
  '      Exit Sub
  '    End If

  '    Dim lstPagos As New List(Of manDB.clsInfoPagos)
  '    vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
  '    If vResult <> Result.OK Then
  '      MsgBox("Fallo cargar pagos")
  '      Exit Sub
  '    End If
  '    Dim rsta As MsgBoxResult
  '    If Not DebePeriodoActual(lstPagos) Then
  '      rsta = MsgBox("Las cuotas estan al dia, desea continuar?", MsgBoxStyle.YesNo)
  '      If rsta <> MsgBoxResult.Yes Then Exit Sub

  '    End If
  '    'If chkPagoParcial.Checked = True Then
  '    '  Call IngresarPagoParcial(m_CurrentProducto)
  '    '  Exit Sub
  '    'End If
  '    Dim nPagar As Integer = CInt(cmbNumCuotasCancelar.SelectedItem)
  '    'collectar la informacion a mostrar antes de aplicar el pago elgido
  '    Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
  '                                      "Nombre: {0}" & vbNewLine & _
  '                                      "DNI: {1}" & vbNewLine & _
  '                                      "Metodo Pago: {2}" & vbNewLine & _
  '                                      "Numero: {3}" & vbNewLine & _
  '                                      "Valor Cuota: {4}" & vbNewLine & _
  '                                       "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.Cliente, m_CurrentProducto.NumCliente, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.Comprobante, m_CurrentProducto.ValorCuota, dtpFechaPago)

  '    rsta = MsgBox(msg, MsgBoxStyle.YesNo)
  '    If rsta = MsgBoxResult.Yes Then

  '      Dim vFechaPago As Date = dtpFechaPago.Value
  '      Call AplicarCuota(nPagar, m_CurrentProducto.GuidProducto, vFechaPago)



  '      Call MostrarDeben()


  '    End If
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub IngresarPagoParcial(ByVal vProducto As clsInfoPrincipal)
  '  Try


  '    If CDec(txtImporteParcial.Text) < 0 OrElse CDec(txtImporteParcial.Text) > CDec(vProducto.ValorCuotaFija) Then
  '      MsgBox("El valor del importe debe ser mayor o igual a cero y menor o igual al precio de venta")
  '      Exit Sub
  '    End If




  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub CargarMetodosDePago()
  '  Try

  '    If m_CurrentProducto Is Nothing Then Exit Sub
  '    cmbFormaDePago.Items.Clear()

  '    Dim lstProducto = New clsListProductos
  '    lstProducto = New clsListProductos
  '    lstProducto.Cfg_Filtro = "where GuidProducto={" & m_CurrentProducto.GuidProducto.ToString & "}"
  '    lstProducto.RefreshData()
  '    Dim Producto As New clsInfoProducto
  '    If lstProducto.Items.Count <= 0 Then
  '      MsgBox("No existe el producto")
  '      Exit Sub
  '    End If
  '    Producto = lstProducto.Items.First.Clone
  '    Dim lstFormasDePagosAsociadas As New List(Of clsInfoCuenta)
  '    clsCuenta.Load(Producto.GuidCliente, lstFormasDePagosAsociadas)
  '    For Each forma In lstFormasDePagosAsociadas
  '      forma.SetDelegadoCustomString(New clsInfoCuenta.delToString(AddressOf GetNameOfTipoPago))
  '      cmbFormaDePago.Items.Add(forma)
  '    Next



  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub btnDownPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDownPago.MouseClick
  '  Try
  '    Dim vResult As Result

  '    If m_CurrentProducto Is Nothing Then
  '      MsgBox("Debe seleccionar un producto")
  '      Exit Sub
  '    End If

  '    'If m_CurrentProducto.CuotasDebe >= m_CurrentProducto.TotalCuotas Then Exit Sub
  '    If m_CurrentProducto.CuotasTotales > 0 AndAlso m_CurrentProducto.CuotasPagas <= 0 Then
  '      MsgBox("No hay ningun pago aplicado para eliminar")
  '      Exit Sub
  '    End If

  '    Dim lstPagos As New List(Of manDB.clsInfoPagos)
  '    vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
  '    If vResult <> Result.OK Then
  '      MsgBox("Fallo cargar pagos")
  '      Exit Sub
  '    End If
  '    Dim rsta As MsgBoxResult
  '    Dim msg As String = String.Format("Se descontara el ultimo pago a: " & vbNewLine & _
  '                                     "Nombre: {0}" & vbNewLine & _
  '                                     "DNI: {1}" & vbNewLine & _
  '                                     "Metodo Pago: {2}" & vbNewLine & _
  '                                     "Numero: {3}" & vbNewLine & _
  '                                     "Valor Cuota: {4}" & vbNewLine & _
  '                                      "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.Cliente, m_CurrentProducto.NumCliente, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.Comprobante, m_CurrentProducto.ValorCuota, GetAhora)

  '    rsta = MsgBox(msg, MsgBoxStyle.YesNo)
  '    If rsta = MsgBoxResult.Yes Then

  '      vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
  '      If vResult <> Result.OK Then
  '        MsgBox("Fallo cargar pagos")
  '        Exit Sub
  '      End If

  '      Dim auxPago As clsInfoPagos = Nothing
  '      For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota).Reverse
  '        If pago.EstadoPago = E_EstadoPago.Debe Then 'pago.EstadoPago = E_EstadoPago.Pago OrElse pago.EstadoPago = E_EstadoPago.PagoParcial Then
  '          pago.EstadoPago = E_EstadoPago.Anulo_Editado
  '          vResult = clsPago.Save(pago)
  '          If vResult <> Result.OK Then
  '            MsgBox("Fallo guardar pagos")
  '            Exit Sub
  '          End If
  '          Exit For
  '        End If
  '      Next

  '      For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota).Reverse
  '        If pago.EstadoPago = E_EstadoPago.Pago OrElse pago.EstadoPago = E_EstadoPago.PagoParcial Then
  '          pago.EstadoPago = E_EstadoPago.Debe
  '          vResult = clsPago.Save(pago)
  '          If vResult <> Result.OK Then
  '            MsgBox("Fallo guardar pagos")
  '            Exit Sub
  '          End If
  '          Exit For

  '        End If
  '      Next





  '      Call MostrarDeben()


  '    End If


  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub btnBuscar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseClick
    Try
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnConfiguracion_MouseClick(sender As Object, e As MouseEventArgs) Handles btnConfiguracion.MouseClick
    Try
      Using objform As New frmConfig
        objform.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnMinimize_MouseClick(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseClick
    Try
      Me.WindowState = FormWindowState.Minimized
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnLiquidVendedores_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLiquidVendedores.MouseClick
    Try
      Using objForm As New frmVendedores(True)
        objForm.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub btnExportar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnExportar.MouseClick
    Try
      Call clsCobros.ActualizarEstadosDePagos(g_Today.AddDays(2))

      Dim vTipoPagoSeleccionado As clsTipoPago = Nothing

      Using objForm As New frmTipoDeArchivo(frmTipoDeArchivo.E_TIPO_INTERCAMBIO.Exportar)
        If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
          vTipoPagoSeleccionado = objForm.TipoPagoSeleccionado.Clone
        Else
          Exit Sub
        End If
      End Using
      'Procesar
      If vTipoPagoSeleccionado.Es(clsModoDebito.GUID_HIPOTECARIO) Then
        Using objFormulario As New frmExportarHipotecario(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_PATAGONIA) Then
        Using objFormulario As New frmExportarPatagonia(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_HIPOTECARIO_7464) Then
        Using objFormulario As New frmExportarHipotecario(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_VISA_CREDITO) Then
        Using objFormulario As New frmExportarVisaCredito(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_VISA_DEBITO) Then
        Using objFormulario As New frmExportarVisaDebito(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_CBU) Then
        Using objFormulario As New frmExportarCBU(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_EFECTIVO) Then
        Using objFormulario As New frmExportarCBU(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_MERCADO_PAGO) Then
        Using objFormulario As New frmExportarCBU(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      Else

        Using objFormulario As New frmExportarResumen(vTipoPagoSeleccionado)
          objFormulario.ShowDialog(Me)
        End Using
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnImportar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnImportar.MouseClick
    Try
      Call clsCobros.ActualizarEstadosDePagos(g_Today)


      Dim vTipoPagoSeleccionado As clsTipoPago = Nothing

      Using objForm As New frmTipoDeArchivo(frmTipoDeArchivo.E_TIPO_INTERCAMBIO.Importar)
        If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
          vTipoPagoSeleccionado = objForm.TipoPagoSeleccionado.Clone
        Else
          Exit Sub
        End If
      End Using

      'Procesar los movimientos entrantes
      If vTipoPagoSeleccionado.Es(clsModoDebito.GUID_HIPOTECARIO) Then
        Using objFormImportar As New frmImportarHipotecario(vTipoPagoSeleccionado)
          objFormImportar.ShowDialog(Me)
        End Using

      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_PATAGONIA) Then
        Using objFormImportar As New frmImportarPatagonia(vTipoPagoSeleccionado)
          objFormImportar.ShowDialog(Me)
        End Using

      ElseIf vTipoPagoSeleccionado.Es(clsModoDebito.GUID_HIPOTECARIO_7464) Then
        Using objFormImportar As New frmImportarHipotecario(vTipoPagoSeleccionado)
          objFormImportar.ShowDialog(Me)
        End Using
      Else
        Using objFormResumen As New frmResumen(vTipoPagoSeleccionado)
          objFormResumen.ShowDialog(Me)
        End Using

        Call MostrarDeben()
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub btnOK_MouseClick(sender As Object, e As MouseEventArgs) Handles btnOK.MouseClick
  '  Try
  '    'aplicar pagos
  '    If m_Movimientos Is Nothing Then Exit Sub
  '    Dim vResult As Result
  '    Dim lstPagos As clsListPagos
  '    Dim lstProducto = New clsListProductos

  '    For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
  '      lstPagos = New clsListPagos
  '      lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante
  '      lstPagos.RefreshData()
  '      If lstPagos.Items.Count = 0 Then
  '        MsgBox("No exite el comprobante " & mov.NumeroComprobante)
  '        Exit Sub
  '      End If
  '      If lstPagos.Items.Count > 1 Then
  '        MsgBox("Existe mas de un producto con el mismo comprobante " & mov.NumeroComprobante)
  '        Exit Sub
  '      End If
  '      Dim Pago As New clsInfoPagos
  '      Pago = lstPagos.Items.First.Clone
  '      lstProducto = New clsListProductos
  '      lstProducto.Cfg_Filtro = "where GuidProducto={" & Pago.GuidProducto.ToString & "}"
  '      lstProducto.RefreshData()
  '      Dim Producto As New clsInfoProducto
  '      Producto = lstProducto.Items.First.Clone
  '      Pago.EstadoPago = E_EstadoPago.Pago
  '      Pago.FechaPago = Date.Now

  '      vResult = clsPago.Save(Pago)
  '      If vResult <> Result.OK Then
  '        MsgBox("Fallo guardar pagos")
  '        Exit Sub
  '      End If

  '      Dim auxPago As New clsInfoPagos
  '      If (lstProducto.Items.First.CuotasDebe - 1) > 0 Then
  '        auxPago = GetProximoPago(Pago.GuidProducto, Producto.NumComprobante, Producto.ValorCuotaFija, Pago.NumCuota + 1, Producto.FechaVenta, Pago.VencimientoCuota)
  '      End If
  '      If auxPago IsNot Nothing Then
  '        vResult = clsPago.Save(auxPago)
  '        If vResult <> Result.OK Then
  '          MsgBox("Fallo guardar nuevo pago")
  '          Exit Sub
  '        End If
  '      End If

  '    Next

  '    ''collectar la informacion a mostrar antes de aplicar el pago elgido
  '    'Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
  '    '                                  "Nombre: {0}" & vbNewLine & _
  '    '                                  "DNI: {1}" & vbNewLine & _
  '    '                                  "Metodo Pago: {2}" & vbNewLine & _
  '    '                                  "Numero: {3}" & vbNewLine & _
  '    '                                  "Valor Cuota: {4}" & vbNewLine & _
  '    '                                   "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.NombreCliente, m_CurrentProducto.DNI, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.NumPago, m_CurrentProducto.ValorCuota, Today)

  '    Call MostrarDeben()
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  Finally
  '    pnlResumen.Visible = False
  '  End Try
  'End Sub

  'Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick
  '  Try

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  Finally
  '    pnlResumen.Visible = False
  '  End Try
  'End Sub





  'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  '  Try
  '    Dim vResult As Result
  '    Dim iPagosRepetidos As Integer
  '    Dim iDebeRepetidos As Integer
  '    Dim iDebeYPago As Integer
  '    Dim iProductos As Integer
  '    If m_objPrincipal IsNot Nothing Then


  '      Dim lstPagos As List(Of manDB.clsInfoPagos) = Nothing
  '      For Each item In m_objPrincipal.Items

  '        lstPagos = New List(Of manDB.clsInfoPagos)
  '        vResult = clsPago.Load(lstPagos, item.GuidProducto)
  '        If vResult <> Result.OK Then
  '          MsgBox("Fallo cargar pagos")
  '          Exit Sub
  '        End If
  '        If CInt(item.Comprobante) = 3838 Then
  '          Continue For
  '        End If
  '        Dim issue As Boolean = False
  '        Dim numCuota As Integer = 1
  '        numCuota = item.CuotasPagas - item.CuotasTotales
  '        While numCuota > 0
  '          Dim index As Integer = lstPagos.FindIndex(Function(c) c.EstadoPago = E_EstadoPago.Pago)
  '          If index >= 0 Then
  '            lstPagos(index).EstadoPago = E_EstadoPago.Eliminado
  '            vResult = clsPago.Save(lstPagos(index))
  '            If vResult <> Result.OK Then
  '              MsgBox("Fallo save pago")
  '            End If
  '          End If
  '          numCuota = numCuota - 1
  '        End While

  '        numCuota = 1
  '        If item.CuotasPagas = item.CuotasTotales AndAlso lstPagos.Count = item.CuotasTotales Then
  '          For Each pago In lstPagos.OrderBy(Function(d) d.NumCuota)
  '            If numCuota <> pago.NumCuota Then
  '              iPagosRepetidos = iPagosRepetidos + 1
  '            End If
  '          Next

  '        End If

  '        Dim iCount As Integer = lstPagos.FindAll(Function(c) c.EstadoPago = E_EstadoPago.Debe).Count
  '        If iCount > 1 Then
  '          While iCount > 1
  '            Dim index As Integer = lstPagos.FindIndex(Function(c) c.EstadoPago = E_EstadoPago.Debe)
  '            If index >= 0 Then
  '              lstPagos(index).EstadoPago = E_EstadoPago.Eliminado
  '              vResult = clsPago.Save(lstPagos(index))
  '              If vResult <> Result.OK Then
  '                MsgBox("Fallo save pago")
  '              End If
  '            End If
  '            iCount = iCount - 1

  '          End While
  '        End If

  '        If item.CuotasPagas = item.CuotasTotales Then
  '          Dim index As Integer = lstPagos.FindIndex(Function(c) c.EstadoPago = E_EstadoPago.Debe)
  '          If index >= 0 Then
  '            lstPagos(index).EstadoPago = E_EstadoPago.Eliminado
  '            vResult = clsPago.Save(lstPagos(index))
  '            If vResult <> Result.OK Then
  '              MsgBox("Fallo save pago")
  '            End If
  '          End If

  '        End If

  '        If item.CuotasPagas <= item.CuotasTotales Then
  '          numCuota = 1
  '          For Each pago In lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago).OrderBy(Function(d) d.IdPago)

  '            Dim index As Integer = lstPagos.FindIndex(Function(c) c.GuidPago = pago.GuidPago)
  '            If index >= 0 Then
  '              lstPagos(index).NumCuota = numCuota
  '              vResult = clsPago.Save(lstPagos(index))
  '              If vResult <> Result.OK Then
  '                MsgBox("Fallo save pago")
  '              End If
  '            End If
  '            numCuota = numCuota + 1
  '          Next
  '        End If





  '        'For i As Integer = 1 To item.CuotasTotales
  '        '  Dim j As Integer = i

  '        '  If lstPagos.Exists(Function(c) c.NumCuota = j AndAlso c.EstadoPago = E_EstadoPago.Pago) AndAlso lstPagos.Exists(Function(c) c.NumCuota = j AndAlso c.EstadoPago = E_EstadoPago.Debe) Then
  '        '    iDebeYPago = iDebeYPago + 1
  '        '    issue = True
  '        '    'analizar manual
  '        '    Exit For
  '        '  End If

  '        '  While (lstPagos.FindAll(Function(c) c.NumCuota = j AndAlso c.EstadoPago = E_EstadoPago.Pago).Count > 1)
  '        '    iPagosRepetidos = iPagosRepetidos + 1
  '        '    issue = True
  '        '    Dim index As Integer = lstPagos.FindLastIndex(Function(c) c.NumCuota = j AndAlso c.EstadoPago = E_EstadoPago.Pago)
  '        '    lstPagos(index).EstadoPago = E_EstadoPago.Eliminado
  '        '    vResult = clsPago.Save(lstPagos(index))
  '        '    If vResult <> Result.OK Then
  '        '      MsgBox("Fallo save pago")
  '        '    End If
  '        '  End While


  '        'Next
  '        'iDebeRepetidos = iDebeRepetidos + lstPagos.FindAll(Function(c) c.EstadoPago = E_EstadoPago.Debe).Count - 1
  '        'If lstPagos.FindAll(Function(c) c.EstadoPago = E_EstadoPago.Debe).Count > 1 Then
  '        '  issue = True
  '        'End If

  '        'If issue = True Then iProductos = iProductos + 1
  '      Next
  '    End If
  '    MsgBox(String.Format("pagos repetid = {0}   debe repetidos = {1}  debeypago = {2}  productosModificar = {3}", iPagosRepetidos, iDebeRepetidos, iDebeYPago, iProductos))

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  '  Try
  '    Dim vResult As Result
  '    If m_CurrentProducto Is Nothing Then
  '      MsgBox("Debe seleccionar un producto")
  '      Exit Sub
  '    End If

  '    If m_CurrentProducto.CuotasTotales > 0 AndAlso m_CurrentProducto.CuotasPagas >= m_CurrentProducto.CuotasTotales Then
  '      MsgBox("No hay cuotas pendientes, no se puede aplicar un pago")
  '      Exit Sub
  '    End If

  '    Dim lstPagos As New List(Of manDB.clsInfoPagos)
  '    vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
  '    If vResult <> Result.OK Then
  '      MsgBox("Fallo cargar pagos")
  '      Exit Sub
  '    End If
  '    Dim rsta As MsgBoxResult
  '    'If Not DebePeriodoActual(lstPagos) Then
  '    '  rsta = MsgBox("Las cuotas estan al dia, desea continuar?", MsgBoxStyle.YesNo)
  '    '  If rsta <> MsgBoxResult.Yes Then Exit Sub

  '    'End If

  '    'collectar la informacion a mostrar antes de aplicar el pago elgido
  '    'Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
  '    '                                  "Nombre: {0}" & vbNewLine & _
  '    '                                  "DNI: {1}" & vbNewLine & _
  '    '                                  "Metodo Pago: {2}" & vbNewLine & _
  '    '                                  "Numero: {3}" & vbNewLine & _
  '    '                                  "Valor Cuota: {4}" & vbNewLine & _
  '    '                                   "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.Cliente, m_CurrentProducto.NumCliente, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.Comprobante, m_CurrentProducto.ValorCuota, GetAhora)
  '    Dim msg As String = "Desea liquidar todas las cuotas?"
  '    rsta = MsgBox(msg, MsgBoxStyle.YesNo)
  '    If rsta = MsgBoxResult.Yes Then

  '      Dim CuotasRestantes As Integer = m_CurrentProducto.CuotasTotales - m_CurrentProducto.CuotasPagas
  '      Dim CuotasAPagar As Integer
  '      CuotasAPagar = CuotasRestantes
  '      Call AplicarCuota(CuotasAPagar, m_CurrentProducto.GuidProducto, Today)
  '      Call MostrarDeben()


  '    End If
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

 


  'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  '  Try
  '    '  Dim rsta As MsgBoxResult = MsgBox("DEBUG CONTINUAR?", MsgBoxStyle.YesNo)
  '    '  If rsta = MsgBoxResult.Yes Then
  '    '    Dim lstProductos As New List(Of Integer)({2426, 2631, 2713, 2718, 2757, 2760, 2766, 2811, 2814, 2816, 2832, 2836, 2857, 2868, 2875, 2884, 2887, 2908, 2916, 2921, 2922, 2935, 2938, 2939, 2947, 3012, 3016, 3027, 3058, 3065, 3082, 3084, 3088, 3117, 3122, 3148, 3161, 3172, 3188, 3189, 3200, 3214, 3323, 3356, 3374, 3472, 3510, 3516, 3728, 3730, 3838, 3858, 3871, 3880, 3896, 3927, 3934, 3973, 4067, 4081, 4082, 4087, 4118, 4124, 4132, 4139, 4141, 4317, 4318, 4433, 4580, 4582, 4674, 4704, 4755, 4804, 4813, 5044, 5054, 5265, 6132, 6307, 6383, 6909})
  '    '    For Each item In m_objPrincipal.Items
  '    '      If lstProductos.Contains(item.Comprobante) Then
  '    '        Dim cuotasAPagar As Integer = item.CuotasTotales - item.CuotasPagas
  '    '        If cuotasAPagar > 0 Then
  '    '          Call AplicarCuota(cuotasAPagar, item.GuidProducto)
  '    '        End If
  '    '      End If
  '    '    Next
  '    '    Call MostrarDeben()
  '    '  End If
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  'Private Sub btnModificarFormadePago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnModificarFormadePago.MouseClick
  '  Try
  '    'Mostrar ventana con las opciones de pago o para agregar o modificar los datos y forma de pago
  '    Dim objInfoProducto As New clsInfoProducto
  '    If clsProducto.Load(m_CurrentProducto.GuidProducto, objInfoProducto) <> Result.OK Then
  '      MsgBox("No se puede obtener datos del producto vendido o del cliente")
  '      Exit Sub
  '    End If
  '    If clsPago.Load(objInfoProducto.ListaPagos, m_CurrentProducto.GuidProducto) <> Result.OK Then
  '      MsgBox("No se puede obtener datos del producto vendido o del cliente")
  '      Exit Sub
  '    End If
  '    If clsRelArtProd.Load(objInfoProducto.ListaArticulos, m_CurrentProducto.GuidProducto) <> Result.OK Then
  '      MsgBox("No se puede obtener datos del producto vendido o del cliente")
  '      Exit Sub
  '    End If
  '    If clsCuenta.Load(objInfoProducto.GuidCuenta, objInfoProducto.Cuenta) <> Result.OK Then
  '      MsgBox("No se puede obtener datos del producto vendido o del cliente")
  '      Exit Sub
  '    End If

  '    Dim vInfoCuenta As clsInfoCuenta = Nothing
  '    Using objCuenta As New frmCuenta(objInfoProducto.GuidCliente, True)
  '      objCuenta.ShowDialog(Me)
  '      objCuenta.GetCuentaSeleccionada(vInfoCuenta)
  '    End Using
  '    If vInfoCuenta Is Nothing Then
  '      'Sin cambios. salir
  '      Exit Sub
  '    End If
  '    '


  '    'se eligio otro forma de pago distinta a la actual.
  '    'establecer como nueva forma de pago, y actualizar tb en la cuota que se debe.
  '    objInfoProducto.Cuenta = vInfoCuenta.Clone
  '    objInfoProducto.GuidCuenta = vInfoCuenta.GuidCuenta
  '    If clsProducto.Save(objInfoProducto) <> Result.OK Then
  '      MsgBox("Ocurrio un error al guardar el cambio.")
  '    End If
  '    Call MostrarDeben()
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub





  




 


  Private m_currentLocationMain As Point
  Private m_MovingMain As Boolean = False

  Private Sub lblTitulo_MouseEnter(sender As Object, e As EventArgs) Handles lblTitulo.MouseEnter
    Try
      Me.Cursor = Cursors.SizeAll
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub lblTitulo_MouseLeave(sender As Object, e As EventArgs) Handles lblTitulo.MouseLeave
    Try
      Me.Cursor = Cursors.Default
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub lblTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseDown
    Try
      If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub

      m_currentLocationMain = New Point(-e.X, -e.Y)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub lblTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseMove
    Try
      If m_currentLocationMain.IsEmpty Then Exit Sub
      If m_MovingMain Then Exit Sub
      m_MovingMain = True
      Dim posicion As Point = Control.MousePosition
      posicion.Offset(m_currentLocationMain.X, m_currentLocationMain.Y)
      Location = posicion


    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_MovingMain = False
    End Try

  End Sub

  Private Sub lblTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTitulo.MouseUp
    Try
      m_currentLocationMain = Point.Empty
      m_MovingMain = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


 

  


  

  Private Sub btnprocesar_Click(sender As Object, e As EventArgs) Handles btnprocesar.Click
    Try
      'completar metodo de pago en tabla de coutas.
      If _Update() <> Result.OK Then
        MsgBox("No continuar")
        Exit Sub
      End If
      Dim objPrincipal = New clsListaPrincipal()
      objPrincipal.RefreshData()
      For Each venta In objPrincipal.Items
        Dim infoVenta As New clsInfoProducto
        'infoVenta.Estado = 0 ' o aplicarlo directamente en la tabla
        If clsProducto.Load(venta.GuidProducto, infoVenta) = Result.OK Then
          infoVenta.Estado = 0
          Dim ListaCuotas As New List(Of clsInfoPagos)
          If clsPago.Load(ListaCuotas, venta.GuidProducto) = Result.OK Then
            For Each cuota In ListaCuotas
              cuota.GuidCuenta = infoVenta.GuidCuenta
              If clsPago.Save(cuota) <> Result.OK Then
                MsgBox("Revisar get info pagos")
                Exit Sub
              End If
            Next

          Else
            MsgBox("Revisar get info pagos")
            Exit Sub
          End If
        Else
          MsgBox("Revisar get info pagos")
          Exit Sub
        End If
      Next
      MsgBox("UPDATE FINALIZADO")

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function _Update(Optional ByVal bShowMsg As Boolean = False) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As libCommon.Comunes.Result = Result.OK
      Dim intCodeError As Integer

      intCodeError = 0

      Try
        Dim strCommand As String
        Dim dt As System.Data.DataTable = Nothing

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then
          Print_msg("c1")
          Return objResult
        End If



        objResult = CamboCrearSiNoExiste(objDB, "Productos", "Estado", "byte")
        If objResult <> Result.OK Then
          Print_msg("c2")
          Return objResult
        End If

        strCommand = "UPDATE [Productos] SET [Estado]= 0"
        objResult = objDB.ExecuteNonQuery(strCommand)
        If objResult <> Result.OK Then
          Print_msg("c3")
        End If


        objResult = CamboCrearSiNoExiste(objDB, "Pagos", "GuidCuenta", "UNIQUEIDENTIFIER")
        If objResult <> Result.OK Then
          Print_msg("c4")
          Return objResult
        End If

        'strCommand = "UPDATE [Clientes] SET [Recurso]= ' '"
        'objResult = objDB.ExecuteNonQuery(strCommand, intCodeError)
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c5")
        '  Return objResult
        'End If



        'objResult = CamboCrearSiNoExiste(objDB, "BcosPac", "AtDoctor", "TEXT (255)")
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c6")
        '  Return objResult
        'End If

        'objResult = CamboCrearSiNoExiste(objDB, "BcosPac", "RefDoctor", "TEXT (255)")
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c7")
        '  Return objResult
        'End If

        'objResult = CamboCrearSiNoExiste(objDB, "BcosPac", "AdmitDoctor", "TEXT (255)")
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c8")
        '  Return objResult
        'End If


        'objResult = CamboCrearSiNoExiste(objDB, "Pac", "Alergias", "Memo")
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c9")
        '  Return objResult
        'End If


        ''Crear Install 
        'objResult = objDB.ExisteTabla("tbSetup")
        'Select Case objResult
        '  Case libCommon.E_OpResult.OK
        '  Case libCommon.E_OpResult.NOK
        '    strCommand = "CREATE TABLE tbSetup ( Ids  COUNTER PRIMARY KEY, " & _
        '                            " NomParam TEXT (255) NOT NULL, " & _
        '                            " Valor TEXT (255) NOT NULL) "
        '    objResult = objDB.ExecuteNonQuery(strCommand, intCodeError)
        '    If objResult <> libCommon.E_OpResult.OK Then
        '      libCommon.Debug.Print_MsgBox("c10")
        '      Return objResult
        '    End If
        '  Case Else
        '    libCommon.Debug.Print_MsgBox("c11")
        '    Return objResult
        'End Select


        'strCommand = "UPDATE [Version] SET [version]= 6001"
        'objResult = objDB.ExecuteNonQuery(strCommand, intCodeError)
        'If objResult <> libCommon.E_OpResult.OK Then
        '  libCommon.Debug.Print_MsgBox("c12")
        '  Return objResult
        'End If


      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally

        If objDB IsNot Nothing Then

          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If

        End If

      End Try

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try
  End Function

  Private Function CamboCrearSiNoExiste(ByVal vObjDB As libDB.clsAcceso, ByVal NombreTabla As String, ByVal NombreCampo As String, ByVal TipoCampo As String) As libCommon.Comunes.Result
    Try

      Dim strCommand As String
      Dim objResult As libCommon.Comunes.Result
      Dim dt As System.Data.DataTable = Nothing
      Dim bExiste As Boolean

      strCommand = "SELECT * FROM " & NombreTabla
      objResult = vObjDB.GetDato(strCommand, dt)


      Select Case objResult
        Case Result.NOK
        Case Result.OK
        Case Else
          'Error
          Return objResult
      End Select

      bExiste = False
      For Each col In dt.Columns
        If col.ToString.ToUpper = NombreCampo.ToUpper Then
          bExiste = True
          Exit For
        End If
      Next
      If Not bExiste Then
        strCommand = "ALTER TABLE " & NombreTabla & " ADD " & NombreCampo & " " & TipoCampo
        objResult = vObjDB.ExecuteNonQuery(strCommand)
        If objResult <> Result.OK Then Return objResult
      End If

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try


  End Function






End Class