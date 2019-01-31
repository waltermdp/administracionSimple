Imports libCommon.Comunes
Imports manDB

Public Class frmDeben

  Private WithEvents m_objPrincipal As clsListaPrincipal = Nothing
  Private m_CurrentProducto As clsInfoPrincipal = Nothing
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"
  Private m_Movimientos As List(Of clsInfoMovimiento)
  'Private m_ColumnName As String = String.Empty
  'Private m_Order As String = String.Empty

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

      vResult = Entorno.init
      If vResult <> Result.OK Then
        MsgBox("No continua application, error init")
      End If

      dateInicio.Value = New Date(Date.Today.Year, Today.Month, 1)
      dateFin.Value = New Date(Date.Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))
      rbtnVendidos.Checked = True
      cmbTipoPago.DataSource = g_TipoPago
      Dim MetodosBusqueda As New List(Of clsTipoPago)
      MetodosBusqueda.Add(New clsTipoPago With {.GuidTipo = Guid.Empty, .Nombre = "Todos Los Medios"})
      MetodosBusqueda.AddRange(g_TipoPago.ToList)
      cmbMetodosDePago.DataSource = MetodosBusqueda
      cmbMetodosDePago.SelectedIndex = 0
      rbtnClientName.Checked = True
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmDeben_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      'Call MostrarDeben()
      Call FillResumen()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarDeben()
    Try
      If m_objPrincipal IsNot Nothing Then m_objPrincipal.Dispose()

      m_objPrincipal = New clsListaPrincipal()
      Call Filtro("")
      'm_objPrincipal.SetOrder(m_ColumnName, m_Order)
      bsInfoPrincipal.DataSource = m_objPrincipal.Binding
      Call ProductList_RefreshData()



      bsInfoPrincipal.ResetBindings(False)
      FillResumen()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Filtro(ByVal modo As String) As Result
    Try
      Dim sqlDate As String = "Productos.FechaVenta between #" & Format(dateInicio.Value, strFormatoAnsiStdFecha) & "# and #" & Format(dateFin.Value.AddDays(1), strFormatoAnsiStdFecha) & "#"
      Dim sqlClient As String = "GuidCliente in (select GuidCliente from Clientes where Nombre Like '%" & txtBusqueda.Text.Trim & "%' OR Apellido Like '%" & txtBusqueda.Text.Trim & "%' OR NumCliente Like '%" & txtBusqueda.Text.Trim & "%')"
      Dim sqlVendedor As String = "GuidVendedor in (select GuidVendedor from Vendedores where Nombre Like '%" & txtBusqueda.Text.Trim & "%' OR Apellido Like '%" & txtBusqueda.Text.Trim & "%' OR NumVendedor Like '%" & txtBusqueda.Text.Trim & "%' OR Grupo Like '%" & txtBusqueda.Text.Trim & "%')"

      Dim filtrar As String = String.Empty
      If rbtnClientName.Checked Then
        filtrar = " and " & sqlClient
      ElseIf rbtnNombreVendedor.Checked Then
        filtrar = " and " & sqlVendedor
      Else
        filtrar = String.Empty
      End If

      m_objPrincipal.MetodoPago = CType(cmbMetodosDePago.SelectedItem, clsTipoPago).GuidTipo
      m_objPrincipal.Cfg_Filtro = "where " & sqlDate & filtrar

      If rbtnVendidos.Checked = True Then
        m_objPrincipal.Deben = "0"
      ElseIf rbtnDeben.Checked Then
        m_objPrincipal.Deben = "1"
      ElseIf rbtnCancelados.Checked Then
        m_objPrincipal.Deben = "2"
      ElseIf rbtnCuotaPagaron.Checked Then
        m_objPrincipal.Deben = "3"
      Else
        m_objPrincipal.Cfg_Filtro = ""
        m_objPrincipal.Deben = "0"
      End If

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
  Private Sub ProductList_RefreshData()
    Try
      m_objPrincipal.RefreshData()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub dgvData_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.ColumnHeaderMouseClick
    Try
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvData.Columns(e.ColumnIndex)
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
        For Each col As DataGridViewColumn In dgvData.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        bsInfoPrincipal.DataSource = m_objPrincipal.Items.OrderBy(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()

        bsInfoPrincipal.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)

      Else
        For Each col As DataGridViewColumn In dgvData.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        bsInfoPrincipal.DataSource = m_objPrincipal.Items.OrderByDescending(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()

        bsInfoPrincipal.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)

      End If

      'Call MostrarDeben()
      'm_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(IIf(m_Order = "ASC", SortOrder.Ascending, SortOrder.Descending), Windows.Forms.SortOrder)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvData.DataError
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData_SelectionChanged(sender As Object, e As EventArgs) Handles dgvData.SelectionChanged
    Try

      If dgvData.SelectedRows.Count <> 1 Then Exit Sub
      Call Refresh_Selection(dgvData.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvData.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_CurrentProducto = CType(dgvData.Rows(indice).DataBoundItem, manDB.clsInfoPrincipal)

      End If
      If dgvData.Rows(indice).Selected <> True Then
        dgvData.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  'Private Sub btnPagos_Click(sender As Object, e As EventArgs)
  '  Try
  '    If cmbTipoPago.SelectedIndex < 0 Then
  '      MsgBox("Debe Seleccionar un tipo de pago")
  '      Exit Sub
  '    End If
  '    Dim tipoPago As clsTipoPago = CType(cmbTipoPago.SelectedItem, clsTipoPago)
  '    Using objForm As New frmPreviewAplicarPago(tipoPago)
  '      objForm.ShowDialog()
  '      Call ProductList_RefreshData()
  '    End Using
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

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
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditarVenta_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEditarVenta.MouseClick
    Try
      If m_CurrentProducto Is Nothing Then
        MsgBox("Debe seleccionar un producto para modificarlo.")
        Exit Sub
      End If
      Dim auxProducto As New clsInfoProducto
      Dim vResult As Result = clsProducto.Load(m_CurrentProducto.GuidProducto, auxProducto)
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

  Private Sub FillResumen()
    Try
      If m_objPrincipal Is Nothing Then
        lblTotalArticulos.Text = "Total de Articulos = 0"
        lblTotalProductos.Text = "Total de Productos = 0"
      Else
        If m_objPrincipal.Items.Count = 0 Then
          lblTotalArticulos.Text = "Total de Articulos = 0"
          lblTotalProductos.Text = "Total de Productos = 0"
        Else
          lblTotalArticulos.Text = String.Format("Total de Articulos = {0}", m_objPrincipal.Items.Sum(Function(c) c.ArticulosVendidos))
          lblTotalProductos.Text = String.Format("Total de Productos = {0}", m_objPrincipal.Items.Count)
          lblPrecioTotal.Text = String.Format("Total de Vendidos = {0}", m_objPrincipal.Items.Sum(Function(c) c.Precio))
          Dim ValorNominal As Decimal = 0
          Dim parcial As Decimal = 0
          For Each item In m_objPrincipal.Items
            ValorNominal = ValorNominal + item.ValorCuotaFija * item.CuotasTotales
            Dim lstPagos As New List(Of clsInfoPagos)
            clsPago.Load(lstPagos, item.GuidProducto)
            parcial += lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago Or c.EstadoPago = E_EstadoPago.PagoParcial).Sum(Function(c) c.ValorCuota)
          Next
          lblPrecioInteres.Text = String.Format("Total de Vendidos con interes = {0}", ValorNominal)
          lblPagos.Text = String.Format("Total de Pagos = {0}", parcial)
          If ValorNominal > 0 Then
            lblPorcentaje.Text = String.Format("Porcentaje Pagado: {0:N2}%", CDec(parcial * 100 / ValorNominal))
          Else
            lblPorcentaje.Text = ""
          End If


        End If
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

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



  Private Sub btnUpPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnUpPago.MouseClick
    Try
      Dim vResult As Result
      If m_CurrentProducto Is Nothing Then Exit Sub
      If m_CurrentProducto.CuotasTotales > 0 AndAlso m_CurrentProducto.CuotasPagas >= m_CurrentProducto.CuotasTotales Then Exit Sub
      Dim lstPagos As New List(Of manDB.clsInfoPagos)
      vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar pagos")
        Exit Sub
      End If
      If Not DebePeriodoActual(lstPagos) Then Exit Sub
      'collectar la informacion a mostrar antes de aplicar el pago elgido
      Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
                                        "Nombre: {0}" & vbNewLine & _
                                        "DNI: {1}" & vbNewLine & _
                                        "Metodo Pago: {2}" & vbNewLine & _
                                        "Numero: {3}" & vbNewLine & _
                                        "Valor Cuota: {4}" & vbNewLine & _
                                         "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.Cliente, m_CurrentProducto.NumCliente, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.Comprobante, m_CurrentProducto.ValorCuota, Today)
      Dim rsta As MsgBoxResult = MsgBox(msg, MsgBoxStyle.YesNo)

      If rsta = MsgBoxResult.Yes Then

        'Dim lstPagos As New List(Of manDB.clsInfoPagos)
        vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo cargar pagos")
          Exit Sub
        End If

        Dim auxPago As clsInfoPagos = Nothing
        For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota)
          If pago.EstadoPago = E_EstadoPago.Debe Then

            pago.EstadoPago = E_EstadoPago.Pago
            pago.FechaPago = Date.Now
            vResult = clsPago.Save(pago)
            If vResult <> Result.OK Then
              MsgBox("Fallo guardar pagos")
              Exit Sub
            End If

            If (m_CurrentProducto.CuotasPagas + 1) < m_CurrentProducto.CuotasTotales Then
              auxPago = GetProximoPago(m_CurrentProducto.GuidProducto, m_CurrentProducto.Comprobante, m_CurrentProducto.ValorCuotaFija, pago.NumCuota + 1, m_CurrentProducto.FechaVenta, pago.VencimientoCuota)
            End If
            If auxPago IsNot Nothing Then
              vResult = clsPago.Save(auxPago)
              If vResult <> Result.OK Then
                MsgBox("Fallo guardar nuevo pago")
                Exit Sub
              End If
            End If
            Exit For
          End If
        Next



        Call MostrarDeben()


      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnDownPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDownPago.MouseClick
    Try
      If m_CurrentProducto Is Nothing Then Exit Sub
      'If m_CurrentProducto.CuotasDebe >= m_CurrentProducto.TotalCuotas Then Exit Sub

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

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

  Private Sub FillResumenView(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.Columns.Add("NumComprobante")
      lstViewResumen.Columns.Add("NumTarjeta")
      lstViewResumen.Columns.Add("Estado")
      lstViewResumen.Columns.Add("Importe")
      lstViewResumen.Columns.Add("Detalle")
      Dim item As ListViewItem
      For Each movimiento In vMovimientos
        item = New ListViewItem
        item.Text = CInt(movimiento.NumeroComprobante).ToString
        item.SubItems.Add(movimiento.NumeroTarjeta)
        If IsNumeric(movimiento.Codigo) Then
          movimiento.Estado = E_EstadoPago.Debe
          item.SubItems.Add(E_EstadoPago.Debe.ToString)
        Else
          movimiento.Estado = E_EstadoPago.Pago
          item.SubItems.Add(E_EstadoPago.Pago.ToString)
        End If
        item.SubItems.Add(CDec(movimiento.Importe.Insert(movimiento.Importe.Length - 2, ".")).ToString)
        item.SubItems.Add(movimiento.Detalle)
        lstViewResumen.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      pnlResumen.Visible = True
    End Try
  End Sub

  Private Sub FillResumenViewCBU(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.Columns.Add("Identificador")
      lstViewResumen.Columns.Add("CBU")
      lstViewResumen.Columns.Add("Concepto")
      lstViewResumen.Columns.Add("Importe Cobrado")
      lstViewResumen.Columns.Add("Detalle")
      Dim item As ListViewItem

      For Each movimiento In vMovimientos

        item = New ListViewItem
        item.Text = CInt(movimiento.IdentificadorDebito).ToString
        item.SubItems.Add(movimiento.NumeroTarjeta)
        If Not IsNumeric(movimiento.Importe) Then
          movimiento.Estado = E_EstadoPago.Debe
          item.SubItems.Add(E_EstadoPago.Debe.ToString)
          item.SubItems.Add(CDec(0.0))
        Else
          movimiento.Estado = E_EstadoPago.Pago
          item.SubItems.Add(E_EstadoPago.Pago.ToString)
          item.SubItems.Add(CDec(movimiento.Importe.Insert(movimiento.Importe.Length - 2, ".")).ToString)
        End If

        item.SubItems.Add(movimiento.Detalle)
        lstViewResumen.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      pnlResumen.Visible = True
    End Try
  End Sub

  'Private Sub btnRVisaDebito_Click(sender As Object, e As EventArgs) Handles btnRVisaDebito.Click
  '  Try
  '    Dim archivo As New List(Of String)
  '    Dim AbrirArchivo As New OpenFileDialog
  '    If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
  '    modFile.Load(AbrirArchivo.FileName, archivo)
  '    Dim mov As New List(Of clsInfoMovimiento)
  '    GetCuerpo(archivo, mov)
  '    FillResumenView(mov)
  '    m_Movimientos = New List(Of clsInfoMovimiento)
  '    m_Movimientos.AddRange(mov.ToList)
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private m_ExportImport As Integer = 0

  Private Sub btnExportar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnExportar.MouseClick
    Try
      m_ExportImport = 1
      lblInfoImpExp.Text = "Seleccione el tipo de pago a Exportar"
      cmbTipoPago.SelectedIndex = 1
      pnlSeleccionarPago.Visible = True
      

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnImportar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnImportar.MouseClick
    Try
      m_ExportImport = 2
      lblInfoImpExp.Text = "Seleccione el tipo de pago a Importar"
      cmbTipoPago.SelectedIndex = 1
      pnlSeleccionarPago.Visible = True
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnContinuarImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnContinuarImpExp.MouseClick
    Try
      If cmbTipoPago.SelectedIndex < 0 Then
        MsgBox("Debe seleccionar un modo de pago/cobro")
        Exit Sub
      End If
      Dim objPago As clsTipoPago = CType(cmbTipoPago.SelectedItem, clsTipoPago)

      If m_ExportImport = 1 Then 'exportar

        clsCobros.GenerateResumen(objPago)
      ElseIf m_ExportImport = 2 Then 'importar
        Dim archivo As New List(Of String)
        Dim AbrirArchivo As New OpenFileDialog
        If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        modFile.Load(AbrirArchivo.FileName, archivo)
        Dim mov As New List(Of clsInfoMovimiento)
        Select Case objPago.GuidTipo
          Case Guid.Parse("9ebcf274-f84f-42ac-b3de-d375bb3bd314") 'efectivo
            MsgBox("No implementado")
            Exit Sub
          Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito
            GetCuerpoVISADebito(archivo, mov)
            FillResumenView(mov)
          Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
            GetCuerpoCBU(archivo, mov)
            FillResumenViewCBU(mov)
          Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
            GetCuerpoVISACredito(archivo, mov)
            FillResumenView(mov)
          Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito
            MsgBox("No implementado")
            Exit Sub
          Case Guid.Parse("598878be-b8b3-4b1b-9261-f989f0800afc") 'master debito
            MsgBox("No implementado")
            Exit Sub
          Case Else
            MsgBox("No se encuentra tipo de pago")
            Exit Sub
        End Select

        m_Movimientos = New List(Of clsInfoMovimiento)
        m_Movimientos.AddRange(mov.ToList)
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      m_ExportImport = 0
      pnlSeleccionarPago.Visible = False
    End Try
  End Sub

  Private Sub btnCancelImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelImpExp.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      m_ExportImport = 0
      pnlSeleccionarPago.Visible = False
    End Try
  End Sub

  'Private Sub btnWVisaDebito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnWVisaDebito.MouseClick
  '  Try
  '    clsCobros.GenerateResumen(g_TipoPago.Find(Function(c) c.GuidTipo = New Guid("d167e036-b175-4a67-9305-a47c116e8f5c")))

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  'Private Sub btnRVisaCredito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRVisaCredito.MouseClick
  '  Try
  '    Dim archivo As New List(Of String)
  '    Dim AbrirArchivo As New OpenFileDialog
  '    If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
  '    modFile.Load(AbrirArchivo.FileName, archivo)
  '    Dim mov As New List(Of clsInfoMovimiento)
  '    GetCuerpoVISACredito(archivo, mov)
  '    FillResumenView(mov)
  '    m_Movimientos = New List(Of clsInfoMovimiento)
  '    m_Movimientos.AddRange(mov.ToList)
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub btnWVisaCredito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnWVisaCredito.MouseClick
  '  Try
  '    clsCobros.GenerateResumen(g_TipoPago.Find(Function(c) c.GuidTipo = New Guid("7580f2d4-d9ec-477b-9e3a-50afb7141ab5")))
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub btnReadCBU_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReadCBU.MouseClick
  '  Try
  '    Dim archivo As New List(Of String)
  '    Dim AbrirArchivo As New OpenFileDialog
  '    If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
  '    modFile.Load(AbrirArchivo.FileName, archivo)
  '    Dim mov As New List(Of clsInfoMovimiento)
  '    GetCuerpoCBU(archivo, mov)
  '    FillResumenViewCBU(mov)
  '    m_Movimientos = New List(Of clsInfoMovimiento)
  '    m_Movimientos.AddRange(mov.ToList)
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub
  'Private Sub btnWCBU_MouseClick(sender As Object, e As MouseEventArgs) Handles btnWCBU.MouseClick
  '  Try
  '    clsCobros.GenerateResumen(g_TipoPago.Find(Function(c) c.GuidTipo = New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117924")))
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  



  Private Sub btnOK_MouseClick(sender As Object, e As MouseEventArgs) Handles btnOK.MouseClick
    Try
      'aplicar pagos
      If m_Movimientos Is Nothing Then Exit Sub
      Dim vResult As Result
      Dim lstPagos As clsListPagos
      Dim lstProducto = New clsListProductos

      For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        lstPagos = New clsListPagos
        lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante
        lstPagos.RefreshData()
        If lstPagos.Items.Count = 0 Then
          MsgBox("No exite el comprobante " & mov.NumeroComprobante)
          Exit Sub
        End If
        If lstPagos.Items.Count > 1 Then
          MsgBox("Existe mas de un producto con el mismo comprobante " & mov.NumeroComprobante)
          Exit Sub
        End If
        Dim Pago As New clsInfoPagos
        Pago = lstPagos.Items.First.Clone
        lstProducto = New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & Pago.GuidProducto.ToString & "}"
        lstProducto.RefreshData()
        Dim Producto As New clsInfoProducto
        Producto = lstProducto.Items.First.Clone
        Pago.EstadoPago = E_EstadoPago.Pago
        Pago.FechaPago = Date.Now

        vResult = clsPago.Save(Pago)
        If vResult <> Result.OK Then
          MsgBox("Fallo guardar pagos")
          Exit Sub
        End If

        Dim auxPago As New clsInfoPagos
        If (lstProducto.Items.First.CuotasDebe - 1) > 0 Then
          auxPago = GetProximoPago(Pago.GuidProducto, Producto.NumComprobante, Producto.ValorCuotaFija, Pago.NumCuota + 1, Producto.FechaVenta, Pago.VencimientoCuota)
        End If
        If auxPago IsNot Nothing Then
          vResult = clsPago.Save(auxPago)
          If vResult <> Result.OK Then
            MsgBox("Fallo guardar nuevo pago")
            Exit Sub
          End If
        End If

      Next

      ''collectar la informacion a mostrar antes de aplicar el pago elgido
      'Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
      '                                  "Nombre: {0}" & vbNewLine & _
      '                                  "DNI: {1}" & vbNewLine & _
      '                                  "Metodo Pago: {2}" & vbNewLine & _
      '                                  "Numero: {3}" & vbNewLine & _
      '                                  "Valor Cuota: {4}" & vbNewLine & _
      '                                   "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.NombreCliente, m_CurrentProducto.DNI, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.NumPago, m_CurrentProducto.ValorCuota, Today)

      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      pnlResumen.Visible = False
    End Try
  End Sub

  Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      pnlResumen.Visible = False
    End Try
  End Sub



  Private Sub rbtnClientVendeor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnClientName.CheckedChanged, rbtnNombreVendedor.CheckedChanged
    Try
      If rbtnClientName.Checked Then
        lblInfoFiltro.Text = "Nombre, Apellido o Numero de cliente"
      ElseIf rbtnNombreVendedor.Checked Then
        lblInfoFiltro.Text = "Nombre, Apellido, Numero vendedor o grupo"
      Else
        lblInfoFiltro.Text = ""
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class