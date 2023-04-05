Imports libCommon.Comunes
Imports System.ComponentModel
Public Class frmArticulos
  Private WithEvents m_objArticulosList As clsListArticulos = Nothing
  Private WithEvents m_ObjListaStock As clsListStock = Nothing
  Private m_objStock As List(Of clsListaStorage)
  Private m_ObjCurrent As clsListaStorage
  Private m_listResponsables As New List(Of clsInfoResponsable)
  Private m_listResponsablesDestino As New List(Of clsInfoResponsable)
  Private m_Skip As Boolean = False
  Private m_Deposito As manDB.clsInfoGrupo
  Private m_LastColumnEvent As DataGridViewCellMouseEventArgs = Nothing
  Private m_Grupos As New clsListGrupos

  Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call AllowEditNew(False)
      m_Grupos.Cfg_Filtro = "WHERE NOT GuidGrupo={788FEC0E-01B4-4AC2-840A-235C3A075B1D}"
      m_Grupos.Cfg_Orden = "ORDER BY Nombre ASC"
      m_Grupos.RefreshData()
      chkCodigoBarras.Checked = True
      chkCodigo.Checked = True
      chkNombre.Checked = True
      m_Deposito = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO")
      LoadTodoslosResponsables()
      cmbResponsables.Enabled = False
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnBuscar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseClick
    Try
      'buscar los articulos
      If rbtnBuscarResponsables.Checked Then
        If cmbResponsables.SelectedIndex < 0 Then
          MsgBox("Debe seleccionar un responsable para realizar una busqueda")
          Exit Sub
        End If

        BuscarArtPorResponsable(CType(cmbResponsables.SelectedItem, clsInfoResponsable))
      ElseIf rbnBuscarPalabra.Checked Then
        If String.IsNullOrEmpty(txtPalabraBuscar.Text.Trim) Then
          MsgBox("No se pueden buscar palabras vacias")
          Exit Sub
        End If
        If chkCodigo.Checked = False AndAlso chkCodigoBarras.Checked = False AndAlso chkDescripcion.Checked = False AndAlso chkNombre.Checked = False Then
          MsgBox("Al menos debe seleccionar un parametro de busqueda por palabra")
          Exit Sub
        End If
        BuscarArtPorPalabra(txtPalabraBuscar.Text.Trim)
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub BuscarArtPorPalabra(ByVal vPalabra As String)
    Try
      If m_objArticulosList IsNot Nothing Then m_objArticulosList.Dispose()
      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_objArticulosList = New clsListArticulos()
      m_ObjListaStock = New clsListStock
      bsArticulos.DataSource = m_objArticulosList.Binding

      m_objArticulosList.Cfg_Orden = "ORDER BY Codigo ASC"
      Dim sAux As String = "WHERE "
      If chkCodigo.Checked Then
        sAux += "Codigo Like '%" & vPalabra & "%'"
      End If
      If chkCodigoBarras.Checked Then
        If chkCodigo.Checked Then sAux += " OR "
        sAux += "CodigoBarras Like '%" & vPalabra & "%'"
      End If
      If chkNombre.Checked Then
        If chkCodigo.Checked OrElse chkCodigoBarras.Checked Then sAux += " OR "
        sAux += "Nombre Like '%" & vPalabra & "%'"
      End If
      If chkDescripcion.Checked Then
        If chkCodigo.Checked OrElse chkCodigoBarras.Checked OrElse chkNombre.Checked Then sAux += " OR "
        sAux += "Descripcion Like '%" & vPalabra & "%'"
      End If

      m_objArticulosList.Cfg_Filtro = sAux  ' "WHERE Codigo Like '%" & vPalabra & "%' OR CodigoBarras Like '%" & vPalabra & "%' OR Nombre Like '%" & vPalabra & "%' OR Descripcion Like '%" & vPalabra & "%'"
      Call ArticulosList_RefreshData()
      If m_objArticulosList.Items.Count <= 0 Then
        MsgBox(String.Format("No se encontraron articulos que contengan la palabra ""{0}"".", vPalabra))
        dgvStock.DataSource = Nothing
        dgvStock.Refresh()
        Exit Sub
      End If
      'existen articulos

      m_ObjListaStock.Cfg_Orden = "ORDER BY Responsable ASC"
      'Armar Filtro tomando el guid de cada articulo
      Dim strFiltro As String = "WHERE "
      'GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
      For Each item In m_objArticulosList.Items
        strFiltro += "GuidArticulo={" & item.GuidArticulo.ToString & "}"
        If Not m_objArticulosList.Items.Last.Equals(item) Then
          strFiltro += " OR "
        End If
      Next
      m_ObjListaStock.Cfg_Filtro = strFiltro
      Call ListaStock_RefreshData()
      'Las listas de los articulos y la del stock estan actualizadas con los datos buscados


      'Preparo lista a mostrar
      Dim auxArticulo As clsListaStorage
      m_objStock = New List(Of clsListaStorage)

      BindingSource1.DataSource = m_objStock
      dgvStock.DataSource = BindingSource1


      For Each item In m_objArticulosList.Items
        auxArticulo = New clsListaStorage
        auxArticulo.GuidArticulo = item.GuidArticulo
        auxArticulo.Nombre = item.Nombre
        auxArticulo.Codigo = item.Codigo
        auxArticulo.CodigoBarras = item.CodigoBarras
        auxArticulo.Descripcion = item.Descripcion
        auxArticulo.Precio = item.Precio

        For Each elemento In m_ObjListaStock.Items
          If elemento.GuidArticulo = item.GuidArticulo Then
            auxArticulo.Cantidad = elemento.Cantidad
            auxArticulo.Responsable = elemento.Responsable
            auxArticulo.GuidResponsable = elemento.GuidResponsable
            Dim art As New clsListaStorage
            art = auxArticulo.Clone
            m_objStock.Add(art)
          End If
        Next
      Next
      
      BindingSource1.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub BuscarArtPorResponsable(ByVal vResponsable As clsInfoResponsable)
    Try
      If m_objArticulosList IsNot Nothing Then m_objArticulosList.Dispose()
      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_objArticulosList = New clsListArticulos()
      m_ObjListaStock = New clsListStock
      

      m_ObjListaStock.Cfg_Orden = "ORDER BY Responsable ASC"

      'GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
      m_ObjListaStock.Cfg_Filtro = "WHERE GuidResponsable={" & vResponsable.GuidResponsable.ToString & "}"
      Call ListaStock_RefreshData()
      If m_ObjListaStock.Items.Count <= 0 Then
        MsgBox(String.Format("No se encontraron articulos en ""{0}"".", vResponsable.Nombre))
        dgvStock.DataSource = Nothing
        dgvStock.Refresh()
        Exit Sub
      End If
      'El responsable tiene 0 o mas articulos


      bsArticulos.DataSource = m_objArticulosList.Binding
      m_objArticulosList.Cfg_Orden = "ORDER BY Codigo ASC"
      Dim strFiltro As String = "WHERE "
      For Each item In m_ObjListaStock.Items
        strFiltro += "GuidArticulo={" & item.GuidArticulo.ToString & "}"
        If Not m_ObjListaStock.Items.Last.Equals(item) Then
          strFiltro += " OR "
        End If
      Next
      m_objArticulosList.Cfg_Filtro = strFiltro
      Call ArticulosList_RefreshData()
      ''existen articulos


      'Preparo lista a mostrar
      Dim auxArticulo As clsListaStorage
      m_objStock = New List(Of clsListaStorage)

      BindingSource1.DataSource = m_objStock
      dgvStock.DataSource = BindingSource1


      For Each item In m_objArticulosList.Items
        auxArticulo = New clsListaStorage
        auxArticulo.GuidArticulo = item.GuidArticulo
        auxArticulo.Nombre = item.Nombre
        auxArticulo.Codigo = item.Codigo
        auxArticulo.CodigoBarras = item.CodigoBarras
        auxArticulo.Descripcion = item.Descripcion
        auxArticulo.Precio = item.Precio

        For Each elemento In m_ObjListaStock.Items
          If elemento.GuidArticulo = item.GuidArticulo Then
            auxArticulo.Cantidad = elemento.Cantidad
            auxArticulo.Responsable = elemento.Responsable
            auxArticulo.GuidResponsable = elemento.GuidResponsable
            Dim art As New clsListaStorage
            art = auxArticulo.Clone
            m_objStock.Add(art)
          End If
        Next
      Next

      BindingSource1.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  'Private Sub MostrarListaArticulos()
  '  Try

  '    If m_objArticulosList IsNot Nothing Then m_objArticulosList.Dispose()
  '    If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
  '    m_objArticulosList = New clsListArticulos()
  '    m_ObjListaStock = New clsListStock
  '    bsArticulos.DataSource = m_objArticulosList.Binding

  '    'm_objArticulosList.Cfg_Orden = "ORDER BY Codigo ASC"
  '    Call ArticulosList_RefreshData()
  '    Call ListaStock_RefreshData()
  '    'Las listas de los articulos y la del stock estan actualizadas


  '    Dim auxArticulo As clsListaStorage
  '    m_objStock = New List(Of clsListaStorage)

  '    BindingSource1.DataSource = m_objStock
  '    dgvStock.DataSource = BindingSource1

  '    For Each item In m_objArticulosList.Items
  '      auxArticulo = New clsListaStorage
  '      auxArticulo.GuidArticulo = item.GuidArticulo
  '      auxArticulo.Nombre = item.Nombre
  '      auxArticulo.Codigo = item.Codigo
  '      auxArticulo.Descripcion = item.Descripcion
  '      auxArticulo.Precio = item.Precio

  '      If rbtnByStock.Checked Then
  '        For Each elemento In m_ObjListaStock.Items
  '          If elemento.GuidArticulo = item.GuidArticulo Then
  '            auxArticulo.Cantidad += elemento.Cantidad
  '          End If
  '        Next
  '        auxArticulo.GuidResponsable = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo  ' m_Deposito.GuidResponsable
  '        m_objStock.Add(auxArticulo)
  '      Else
  '        For Each elemento In m_ObjListaStock.Items
  '          If elemento.GuidArticulo = item.GuidArticulo Then
  '            auxArticulo.Cantidad = elemento.Cantidad
  '            auxArticulo.Responsable = elemento.Responsable
  '            auxArticulo.GuidResponsable = elemento.GuidResponsable
  '            Dim art As New clsListaStorage
  '            art = auxArticulo.Clone
  '            m_objStock.Add(art)
  '          End If
  '        Next
  '      End If
  '    Next
  '    If rbtnByStock.Checked Then
  '      m_objStock.Sort(Function(x, y) x.Codigo.CompareTo(y.Codigo))
  '    Else
  '      m_objStock.Sort(Function(x, y) x.Responsable.CompareTo(y.Responsable))
  '    End If

  '    If txtFiltro.Enabled Then
  '      If Not String.IsNullOrEmpty(txtFiltro.Text.Trim) Then
  '        BindingSource1.DataSource = m_objStock.FindAll(Function(c) c.Responsable.ToUpper.Contains(txtFiltro.Text.ToUpper.Trim))
  '      End If
  '    End If
  '    BindingSource1.ResetBindings(False)

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  Finally

  '  End Try
  'End Sub


  Private Sub ArticulosList_RefreshData()
    Try
      m_objArticulosList.RefreshData()
      bsArticulos.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ListaStock_RefreshData()
    Try
      m_ObjListaStock.RefreshData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If m_Skip Then Exit Sub
      If indice < 0 Then
        dgvStock.ClearSelection()
        gbAcciones.Enabled = False
        'Call FillArticuloData()
        txtNombre.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtPrecio.Text = String.Empty
        Exit Sub
      End If
      If (indice >= 0) Then
        m_ObjCurrent = CType(dgvStock.Rows(indice).DataBoundItem, clsListaStorage)
        'If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable <> m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo Then
        '  cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_ObjCurrent.GuidResponsable)

        'End If
        'If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo AndAlso m_ObjCurrent.Cantidad = 0 Then
        '  cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_Grupos.Items.First(Function(d) d.Nombre.ToUpper = "DEPOSITO").GuidGrupo)
        'End If


        'For Each grupo In m_Grupos.Items
        '  m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = grupo.Nombre, .GuidResponsable = grupo.GuidGrupo, .Codigo = ""})
        'Next
        'cmbAccionResponsable.DataSource = m_listResponsables
        'cmbAccionResponsable.SelectedItem =
        If m_ObjCurrent.GuidResponsable = m_Deposito.GuidGrupo Then
          gbAccionDeposito.Enabled = True
          nDescontar.Maximum = m_ObjCurrent.Cantidad
        Else
          gbAccionDeposito.Enabled = False
        End If

        nMover.Maximum = m_ObjCurrent.Cantidad
        lblResponsableFuente.Text = m_ObjCurrent.Responsable
      End If
      If dgvStock.Rows(indice).Selected <> True Then
        dgvStock.Rows(indice).Selected = True
      End If
      gbAcciones.Enabled = True
      Call FillArticuloData()

      'Actualizar combo de destino
      m_listResponsablesDestino.Clear()
      If m_listResponsables.Count > 0 Then
        m_listResponsablesDestino.AddRange(m_listResponsables.ToList)
        indice = -1
        indice = m_listResponsablesDestino.FindIndex(Function(c) c.GuidResponsable = m_ObjCurrent.GuidResponsable)
        If indice < 0 Then
          'No se encuentra el guid del responsable
          'deshabilitar mover
          cmbDestinoResp.Enabled = False
          btnMoverArticulo.Enabled = False
          Exit Sub
        End If
        m_listResponsablesDestino.RemoveAt(indice)
        cmbDestinoResp.DataSource = Nothing
        cmbDestinoResp.DataSource = m_listResponsablesDestino
        cmbDestinoResp.SelectedIndex = 0
        If nMover.Maximum > 0 Then
          btnMoverArticulo.Enabled = True
          cmbDestinoResp.Enabled = True
        Else
          btnMoverArticulo.Enabled = False
          cmbDestinoResp.Enabled = False
        End If
      Else
        btnMoverArticulo.Enabled = False
        cmbDestinoResp.Enabled = False
      End If



    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub




  Private Sub dgvStock_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStock.ColumnHeaderMouseClick
    Try
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvStock.Columns(e.ColumnIndex)
      m_LastColumnEvent = e
      Cursor = Cursors.WaitCursor
      Try
      
      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvStock.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        BindingSource1.DataSource = m_objStock.OrderBy(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()

        BindingSource1.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)

      Else
        For Each col As DataGridViewColumn In dgvStock.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        BindingSource1.DataSource = m_objStock.OrderByDescending(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()

        BindingSource1.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)

        End If
      Finally
        Cursor = Cursors.Default
      End Try
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub dgvStock_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvStock.DataError
    Try
      Dim j As Integer = 0
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvStock_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStock.SelectionChanged
    Try
      'If m_Skip Then Exit Sub
      If dgvStock.SelectedRows.Count <> 1 Then
        gbAcciones.Enabled = False
        Call Refresh_Selection(-1)
        Exit Sub
      End If


      Call Refresh_Selection(dgvStock.SelectedRows(0).Index)



    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then
        MsgBox("Debe seleccionar un articulo de la lista")
        Exit Sub
      End If
      Using objForm As New frmArticulo()
        objForm.SetListaResponsables(m_listResponsables)
        objForm.EditArticulo(m_ObjCurrent)
        objForm.ShowDialog(Me)
      End Using
      'TODO: refrescar el objeto y dejarlo nuevamente seleccionado
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseClick
    Try
      Using objForm As New frmArticulo()
        objForm.SetListaResponsables(m_listResponsables)
        objForm.ShowDialog(Me)
      End Using
      'TODO: refrescar el objeto y dejarlo seleccionado solo el ultimo agregado
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEliminar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseClick
    Try
      Exit Sub
      If m_ObjCurrent Is Nothing Then
        MsgBox("Debe seleccionar un articulo de la lista")
        Exit Sub
      End If
      'If clsArticulo.Delete(m_objArticuloCurrent.GuidArticulo) <> Result.OK Then
      '  MsgBox("No se pudo eliminar el articulo seleccionado.")
      'End If
      m_ObjCurrent = Nothing
      Call Refresh_Selection(-1)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  
  Private Sub CargarData()
    Try
      With m_ObjCurrent
        .Nombre = txtNombre.Text.Trim
        If .Nombre = "" Then .Nombre = "--"
        .Codigo = txtCodigo.Text.Trim
        If .Codigo = "" Then .Codigo = "--"
        .Descripcion = txtDescripcion.Text.Trim
        If .Descripcion = "" Then .Descripcion = "--"
        .Precio = 0
        ConvStr2Dec(txtPrecio.Text.Trim, .Precio)

      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillArticuloData()
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      With m_ObjCurrent
        txtNombre.Text = .Nombre
        txtCodigo.Text = .Codigo
        txtDescripcion.Text = .Descripcion
        txtPrecio.Text = .Precio
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AllowEditNew(ByVal permitir As Boolean)
    Try

      txtNombre.ReadOnly = True
      txtCodigo.ReadOnly = True
      txtCodigoBarras.ReadOnly = True
      txtPrecio.ReadOnly = True
      txtDescripcion.ReadOnly = True



      btnEliminar.Visible = Not permitir
      
      btnVolver.Visible = Not permitir

    
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnVolver_MouseClick(sender As Object, e As MouseEventArgs) Handles btnVolver.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  


  'Private Sub rbtnResponsables_CheckedChanged(sender As Object, e As EventArgs)
  '  Try
  '    cmbResponsables.Enabled = rbtnResponsables.Checked
  '    txtFiltro.Enabled = rbtnResponsables.Checked

  '    If rbtnResponsables.Checked = False Then
  '      cmbResponsables.SelectedIndex = 0
  '    End If

  '    For Each column As DataGridViewColumn In dgvStock.Columns
  '      If column.DataPropertyName = "Responsable" Then
  '        column.Visible = rbtnResponsables.Checked
  '      End If
  '    Next


  '    Call MostrarListaArticulos()


  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub LoadTodoslosResponsables()
    Try
      m_listResponsables.Clear()


      For Each grupo In m_Grupos.Items
        m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = grupo.Nombre, .GuidResponsable = grupo.GuidGrupo, .Codigo = ""})
      Next
      'For Each responsable In m_ObjListaStock.Items
      '  If m_listResponsables.Exists(Function(c) c.GuidResponsable = responsable.GuidResponsable) Then Continue For
      '  m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = responsable.Responsable, .GuidResponsable = responsable.GuidResponsable, .Codigo = ""})
      'Next

      cmbResponsables.DataSource = m_listResponsables

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub btnAddDeposito_MouseClick(sender As Object, e As MouseEventArgs)
  '  Try

  '    If m_ObjCurrent Is Nothing Then Exit Sub
  '    If nIncrementar.Value <= 0 Then
  '      MsgBox("El valor deve ser mayor que cero")
  '      Exit Sub
  '    End If
  '    Dim cCantidad As Integer = nIncrementar.Value
  '    Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
  '    Dim ArticuloSeleccionado As clsListaStorage = CType(dgvStock.Rows(objSelectedIndex).DataBoundItem, clsListaStorage)
  '    Try


  '      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
  '      m_ObjListaStock = New clsListStock
  '      m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidGrupo.ToString & "}" 'and Cantidad > 0
  '      m_ObjListaStock.RefreshData()

  '      If m_ObjListaStock.Items.Count > 0 Then
  '        'existe en deposito
  '        Dim GuidResponsable As Guid
  '        Dim Responsable As String
  '        If rbtnByStock.Checked = True Then
  '          GuidResponsable = m_Deposito.GuidGrupo
  '          Responsable = m_Deposito.Nombre
  '        Else
  '          If cmbResponsables.SelectedIndex < 0 Then Exit Sub
  '          GuidResponsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).GuidResponsable
  '          Responsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).ToString
  '        End If

  '        Dim ArticuloDelDeposito As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
  '        Dim ArticuloDelResponsable As manDB.clsInfoStock
  '        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
  '        m_ObjListaStock = New clsListStock
  '        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "}"
  '        m_ObjListaStock.RefreshData()
  '        If m_ObjListaStock.Items.Count > 0 Then
  '          'ya tenia articulos
  '          ArticuloDelResponsable = m_ObjListaStock.Items.First.Clone

  '        Else
  '          'no tenia este articulo
  '          ArticuloDelResponsable = New manDB.clsInfoStock
  '          ArticuloDelResponsable.GuidArticulo = m_ObjCurrent.GuidArticulo
  '          ArticuloDelResponsable.GuidResponsable = GuidResponsable
  '          ArticuloDelResponsable.Responsable = Responsable
  '          ArticuloDelResponsable.Cantidad = 0

  '        End If
  '        If GuidResponsable <> m_Deposito.GuidGrupo Then
  '          If cCantidad > ArticuloDelDeposito.Cantidad Then
  '            MsgBox("No se mover esa cantidad al responsable, elija un valor menor o igual al maximo disponibles en stock")
  '            Exit Sub
  '          End If
  '          ArticuloDelDeposito.Cantidad -= cCantidad
  '        End If

  '        ArticuloDelResponsable.Cantidad += cCantidad
  '        clsStock.Save(ArticuloDelDeposito)
  '        clsStock.Save(ArticuloDelResponsable)
  '      Else
  '        'No existe en deposito
  '        If m_ObjCurrent.GuidResponsable = m_Deposito.GuidGrupo Then


  '          Dim ArticuloNuevoEnStock As New manDB.clsInfoStock
  '          ArticuloNuevoEnStock.GuidArticulo = m_ObjCurrent.GuidArticulo
  '          ArticuloNuevoEnStock.Responsable = m_Deposito.ToString
  '          ArticuloNuevoEnStock.GuidResponsable = m_Deposito.GuidGrupo
  '          ArticuloNuevoEnStock.Cantidad = cCantidad
  '          clsStock.Save(ArticuloNuevoEnStock)
  '        End If
  '      End If


  '      m_Skip = True
  '      Call MostrarListaArticulos()
  '      If m_LastColumnEvent IsNot Nothing Then Call dgvStock_ColumnHeaderMouseClick(dgvStock, m_LastColumnEvent)
  '      m_Skip = False
  '    Finally

  '      For Each item As DataGridViewRow In dgvStock.Rows
  '        If CType(item.DataBoundItem, clsListaStorage).Equals(ArticuloSeleccionado) Then
  '          Refresh_Selection(dgvStock.Rows.IndexOf(item))
  '          Exit For
  '        End If
  '      Next

  '    End Try

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Function UpdateStock(ByVal vGuidArticulo As Guid, ByVal vCantidad As Integer) As libCommon.Comunes.Result
    Try

      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_ObjListaStock = New clsListStock
      m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & vGuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidGrupo.ToString & "}" 'and Cantidad > 0
      m_ObjListaStock.RefreshData()

      If m_ObjListaStock.Items.Count = 1 Then
        Dim ArticuloDelDeposito As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
        ArticuloDelDeposito.Cantidad = vCantidad
        If clsStock.Save(ArticuloDelDeposito) = Result.OK Then
          For Each item In m_objStock
            If item.GuidArticulo = ArticuloDelDeposito.GuidArticulo AndAlso item.GuidResponsable = ArticuloDelDeposito.GuidResponsable Then
              item.Cantidad = ArticuloDelDeposito.Cantidad
              Exit For
            End If

          Next

          BindingSource1.ResetBindings(False)
        End If
        

      Else
        'No existe en deposito
        MsgBox("No se puede aplicar al elementos seleccionado actualmente")
        Return Result.NOK
      End If

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function MoverArticulo(ByVal vGuidArticulo As Guid, ByVal vGuidResponsableFuente As Guid, ByVal vGuidResponsableDestino As Guid, ByVal NombreDestino As String, ByVal vCantidadMover As Integer) As libCommon.Comunes.Result
    Try

      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_ObjListaStock = New clsListStock
      m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & vGuidArticulo.ToString & "} and GuidResponsable={" & vGuidResponsableFuente.ToString & "}"
      m_ObjListaStock.RefreshData()

      If m_ObjListaStock.Items.Count = 1 Then
        Dim ArticuloFuente As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
        Dim ArticuloDestino As New manDB.clsInfoStock
        Dim vResultFuente As Result
        Dim vResultDestino As Result
        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & vGuidArticulo.ToString & "} and GuidResponsable={" & vGuidResponsableDestino.ToString & "}"
        m_ObjListaStock.RefreshData()
        If m_ObjListaStock.Items.Count = 1 Then
          ArticuloDestino = m_ObjListaStock.Items.First.Clone
        Else
          'el destino responsable no ha tenido este articulo
          'agregarlo
          ArticuloDestino.Cantidad = 0
          ArticuloDestino.GuidArticulo = vGuidArticulo
          ArticuloDestino.GuidResponsable = vGuidResponsableDestino
          ArticuloDestino.Responsable = NombreDestino
          vResultDestino = clsStock.Save(ArticuloDestino)
          If vResultDestino <> Result.OK Then
            MsgBox("No se pudo actualizar")
            Return Result.NOK
          End If
        End If
        ArticuloFuente.Cantidad = ArticuloFuente.Cantidad - vCantidadMover
        vResultFuente = clsStock.Save(ArticuloFuente)
        ArticuloDestino.Cantidad = ArticuloDestino.Cantidad + vCantidadMover
        vResultDestino = clsStock.Save(ArticuloDestino)
        If vResultDestino = Result.OK AndAlso vResultFuente = Result.OK Then
          For Each item In m_objStock
            If item.GuidArticulo = ArticuloFuente.GuidArticulo AndAlso item.GuidResponsable = ArticuloFuente.GuidResponsable Then
              item.Cantidad = ArticuloFuente.Cantidad
            End If
            If item.GuidArticulo = ArticuloDestino.GuidArticulo AndAlso item.GuidResponsable = ArticuloDestino.GuidResponsable Then
              item.Cantidad = ArticuloDestino.Cantidad
            End If
          Next
          BindingSource1.ResetBindings(False)

        Else
          MsgBox("No se pudo actualizar")
          Return Result.NOK
        End If

      Else
        'No existe en deposito
        MsgBox("No se puede aplicar al elementos seleccionado actualmente")
        Return Result.NOK
      End If

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Sub btnIngresarArticulos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnIngresarArticulos.MouseClick
    Try
      'incrementa el articulo en el deposito
      If Not m_ObjCurrent.GuidResponsable = m_Deposito.GuidGrupo Then
        MsgBox("El incremento o decremento de valores solo es permitido para los articulos que estan en el stock")
        Exit Sub
      End If
      If m_ObjCurrent Is Nothing Then Exit Sub
      If nIncrementar.Value <= 0 Then
        MsgBox("El valor deve ser mayor que cero")
        Exit Sub
      End If

      UpdateStock(m_ObjCurrent.GuidArticulo, m_ObjCurrent.Cantidad + nIncrementar.Value)
      nIncrementar.Value = 0
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnDescontarArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDescontarArticulo.MouseClick
    Try
      'decrementa el articulo en el deposito
      If Not m_ObjCurrent.GuidResponsable = m_Deposito.GuidGrupo Then
        MsgBox("El incremento o decremento de valores solo es permitido para los articulos que estan en el stock")
        Exit Sub
      End If
      If m_ObjCurrent Is Nothing Then Exit Sub
      If nDescontar.Value <= 0 Then
        MsgBox("El valor deve ser mayor que cero")
        Exit Sub
      End If

      Dim Cantidad As Integer = m_ObjCurrent.Cantidad - nDescontar.Value
      If Cantidad < 0 Then
        MsgBox("Esta intentando descontar mas productos de los que hay es Deposito")
        Exit Sub
      End If
      UpdateStock(m_ObjCurrent.GuidArticulo, Cantidad)
      nDescontar.Value = 0
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnMoverArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnMoverArticulo.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      If nMover.Value <= 0 Then
        MsgBox("El valor deve ser mayor que cero")
        Exit Sub
      End If


      If m_ObjCurrent.Cantidad - nMover.Value < 0 Then
        MsgBox("Esta intentando descontar mas productos de los que hay es Deposito")
        Exit Sub
      End If
      Dim Cantidad As Integer = nMover.Value
      MoverArticulo(m_ObjCurrent.GuidArticulo, m_ObjCurrent.GuidResponsable, CType(cmbDestinoResp.SelectedItem, clsInfoResponsable).GuidResponsable, CType(cmbDestinoResp.SelectedItem, clsInfoResponsable).Nombre, Cantidad)
      nMover.Value = 0
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub btnRemDeposito_MouseClick(sender As Object, e As MouseEventArgs)
  '  Try
  '    If m_ObjCurrent Is Nothing Then Exit Sub
  '    If txtDecrementar.Text.Trim <= 0 Then
  '      MsgBox("El valor deve ser mayor que cero")
  '      Exit Sub
  '    End If
  '    Dim cCantidad As Integer = CInt(txtDecrementar.Text)
  '    Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
  '    Dim ArticuloSeleccionado As clsListaStorage = CType(dgvStock.Rows(objSelectedIndex).DataBoundItem, clsListaStorage)
  '    Try


  '      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
  '      m_ObjListaStock = New clsListStock
  '      Dim GuidResponsable As Guid
  '      Dim Responsable As String
  '      If rbtnByStock.Checked = True Then
  '        GuidResponsable = m_Deposito.GuidGrupo
  '        Responsable = m_Deposito.ToString
  '      Else
  '        GuidResponsable = m_ObjCurrent.GuidResponsable
  '        Responsable = m_ObjCurrent.Responsable
  '      End If
  '      m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
  '      m_ObjListaStock.RefreshData()

  '      If m_ObjListaStock.Items.Count > 0 Then
  '        'El responsable tiene objetos
  '        Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
  '        Dim ArticuloDelDeposito As manDB.clsInfoStock

  '        'Cargo el articulo del deposito
  '        m_ObjListaStock = New clsListStock
  '        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & ArticuloDelResponsable.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidGrupo.ToString & "}"
  '        m_ObjListaStock.RefreshData()
  '        If m_ObjListaStock.Items.Count > 0 Then
  '          ArticuloDelDeposito = m_ObjListaStock.Items.First.Clone
  '        Else
  '          MsgBox("No estaba en stock")
  '          Exit Sub
  '        End If

  '        If cCantidad > ArticuloDelDeposito.Cantidad Then
  '          MsgBox("No se mover esa cantidad al responsable, elija un valor menor o igual al maximo disponibles en stock")
  '          Exit Sub
  '        End If

  '        If GuidResponsable <> m_Deposito.GuidGrupo Then
  '          'mover a deposito
  '          ArticuloDelDeposito.Cantidad += cCantidad
  '        End If

  '        ArticuloDelResponsable.Cantidad -= cCantidad
  '        clsStock.Save(ArticuloDelDeposito)
  '        clsStock.Save(ArticuloDelResponsable)

  '      End If


  '      m_Skip = True
  '      Call MostrarListaArticulos()
  '      If m_LastColumnEvent IsNot Nothing Then Call dgvStock_ColumnHeaderMouseClick(dgvStock, m_LastColumnEvent)
  '      m_Skip = False

  '    Finally
  '      For Each item As DataGridViewRow In dgvStock.Rows
  '        If CType(item.DataBoundItem, clsListaStorage).Equals(ArticuloSeleccionado) Then
  '          Refresh_Selection(dgvStock.Rows.IndexOf(item))
  '          Exit For
  '        End If
  '      Next
  '    End Try
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub


  'Private Sub btnVendido_MouseClick(sender As Object, e As MouseEventArgs)
  '  Try
  '    If m_ObjCurrent Is Nothing Then Exit Sub
  '    Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
  '    Try


  '      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
  '      m_ObjListaStock = New clsListStock
  '      Dim GuidResponsable As Guid
  '      Dim Responsable As String
  '      If rbtnByStock.Checked = True Then
  '        GuidResponsable = m_Deposito.GuidGrupo
  '        Responsable = m_Deposito.ToString
  '      Else
  '        GuidResponsable = m_ObjCurrent.GuidResponsable
  '        Responsable = m_ObjCurrent.Responsable
  '      End If
  '      m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
  '      m_ObjListaStock.RefreshData()

  '      If m_ObjListaStock.Items.Count > 0 Then

  '        Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
  '        ArticuloDelResponsable.Cantidad -= 1
  '        clsStock.Save(ArticuloDelResponsable)
  '      End If



  '      Call MostrarListaArticulos()
  '    Finally
  '      Refresh_Selection(objSelectedIndex)
  '    End Try
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs)
  '  Try
  '    BindingSource1.DataSource = m_objStock.FindAll(Function(c) c.Responsable.ToUpper.Contains(txtFiltro.Text.ToUpper.Trim))
  '    BindingSource1.ResetBindings(False)
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub btnGrupos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGrupos.MouseClick
    Try
      Using objForm As New frmVendedores
        objForm.ShowDialog()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  

  

 
  Private Sub rbtnBuscarResponsables_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarResponsables.CheckedChanged
    Try
      If rbtnBuscarResponsables.Checked = True Then
        cmbResponsables.Enabled = True
        txtPalabraBuscar.Enabled = False
        chkCodigo.Enabled = False
        chkCodigoBarras.Enabled = False
        chkDescripcion.Enabled = False
        chkNombre.Enabled = False
      Else
        cmbResponsables.Enabled = False
        txtPalabraBuscar.Enabled = True
        chkCodigo.Enabled = True
        chkCodigoBarras.Enabled = True
        chkDescripcion.Enabled = True
        chkNombre.Enabled = True
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class