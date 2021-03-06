﻿Imports libCommon.Comunes
Imports System.ComponentModel
Public Class frmArticulos
  Private WithEvents m_objArticulosList As clsListArticulos = Nothing
  Private WithEvents m_ObjListaStock As clsListStock = Nothing
  Private m_objStock As List(Of clsListaStorage)
  Private m_ObjCurrent As clsListaStorage
  Private m_listResponsables As New List(Of clsInfoResponsable)
  Private m_Skip As Boolean = False
  Private m_Deposito As manDB.clsInfoGrupo
  Private m_LastColumnEvent As DataGridViewCellMouseEventArgs = Nothing
  Private m_Grupos As New clsListGrupos

  Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call AllowEditNew(False)
      cmbResponsables.Enabled = False
      For Each column As DataGridViewColumn In dgvStock.Columns
        If column.DataPropertyName = "Responsable" Then
          column.Visible = False
        End If
      Next
      lblDetalle.Text = "Accion:" & vbNewLine & _
                        "+: Suma 1 unidad al responsable, si el responsable es Stock entonces el stock crece en 1 unidad, si el responsable es otro entonces, descuenta una unidad de Stock y se la pasa al responsable" & vbNewLine & _
                        "-: Resta 1 unidad al responsable, si el responsable es Stock entonces el stock descuenta en 1 unidad, si el responsable es otro entonces, descuenta una unidad al Responsable e incrementa a Stock" & vbNewLine & _
                        "Vendido: Resta una unidad al responsable" & vbNewLine & _
                        "Solo es posible seleccionar un responsable distinto de stock cuando esta seleccionado la opcion Articulo Distribuidos"
      m_Grupos.RefreshData()
      m_Deposito = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO")
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarListaArticulos()
      Call FillResponsables()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarListaArticulos()
    Try


      If m_objArticulosList IsNot Nothing Then m_objArticulosList.Dispose()
      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_objArticulosList = New clsListArticulos()
      m_ObjListaStock = New clsListStock
      bsArticulos.DataSource = m_objArticulosList.Binding

      'm_objArticulosList.Cfg_Orden = "ORDER BY Codigo ASC"
      Call ArticulosList_RefreshData()
      Call ListaStock_RefreshData()
      'Las listas de los articulos y la del stock estan actualizadas


      Dim auxArticulo As clsListaStorage
      m_objStock = New List(Of clsListaStorage)

      BindingSource1.DataSource = m_objStock
      dgvStock.DataSource = BindingSource1

      For Each item In m_objArticulosList.Items
        auxArticulo = New clsListaStorage
        auxArticulo.GuidArticulo = item.GuidArticulo
        auxArticulo.Nombre = item.Nombre
        auxArticulo.Codigo = item.Codigo
        auxArticulo.Descripcion = item.Descripcion
        auxArticulo.Precio = item.Precio

        If rbtnByStock.Checked Then
          For Each elemento In m_ObjListaStock.Items
            If elemento.GuidArticulo = item.GuidArticulo Then
              auxArticulo.Cantidad += elemento.Cantidad
            End If
          Next
          auxArticulo.GuidResponsable = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo  ' m_Deposito.GuidResponsable
          m_objStock.Add(auxArticulo)
        Else
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
        End If
      Next
      If rbtnByStock.Checked Then
        m_objStock.Sort(Function(x, y) x.Codigo.CompareTo(y.Codigo))
      Else
        m_objStock.Sort(Function(x, y) x.Responsable.CompareTo(y.Responsable))
      End If

      If txtFiltro.Enabled Then
        If Not String.IsNullOrEmpty(txtFiltro.Text.Trim) Then
          BindingSource1.DataSource = m_objStock.FindAll(Function(c) c.Responsable.ToUpper.Contains(txtFiltro.Text.ToUpper.Trim))
        End If
      End If
      BindingSource1.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally

    End Try
  End Sub


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
        Exit Sub
      End If
      If (indice >= 0) Then
        m_ObjCurrent = CType(dgvStock.Rows(indice).DataBoundItem, clsListaStorage)
        If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable <> m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo Then
          cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_ObjCurrent.GuidResponsable)

        End If
        If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "DEPOSITO").GuidGrupo AndAlso m_ObjCurrent.Cantidad = 0 Then
          cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_Grupos.Items.First(Function(d) d.Nombre.ToUpper = "DEPOSITO").GuidGrupo)
        End If
      End If
      If dgvStock.Rows(indice).Selected <> True Then
        dgvStock.Rows(indice).Selected = True
      End If

      Call FillArticuloData()

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

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvStock_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStock.SelectionChanged
    Try
      'If m_Skip Then Exit Sub
      If dgvStock.SelectedRows.Count <> 1 Then Exit Sub

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
      Call AllowEditNew(True)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseClick
    Try
      m_ObjCurrent = New clsListaStorage
      m_ObjCurrent.GuidArticulo = Guid.NewGuid
      Call FillArticuloData()
      Call AllowEditNew(True)
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

  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      Call CargarData()
      Dim auxD As Decimal = 0
      If Not ConvStr2Dec(txtPrecio.Text.Trim, auxD) Then
        MsgBox("El precio no corresponde a un valor valido")
        Exit Sub
      End If
      Dim aux As New manDB.clsInfoArticulos
      aux.GuidArticulo = m_ObjCurrent.GuidArticulo
      aux.Nombre = m_ObjCurrent.Nombre
      aux.Codigo = m_ObjCurrent.Codigo
      aux.Descripcion = m_ObjCurrent.Descripcion
      aux.Precio = m_ObjCurrent.Precio
      If clsArticulo.Save(aux) <> Result.OK Then
        MsgBox("No se puede guardar vendedor en la Base de Datos")
        Exit Sub
      End If
      Call AllowEditNew(False)
      Call MostrarListaArticulos()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseClick
    Try
      Call AllowEditNew(False)
      Call MostrarListaArticulos()
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

      txtNombre.ReadOnly = Not permitir
      txtCodigo.ReadOnly = Not permitir
      txtPrecio.ReadOnly = Not permitir
      txtDescripcion.ReadOnly = Not permitir
      btnNuevo.Visible = Not permitir
      btnEditar.Visible = Not permitir
      btnEliminar.Visible = Not permitir
      btnGuardar.Visible = permitir
      btnCancelar.Visible = permitir
      btnVolver.Visible = Not permitir
      If permitir Then
        txtNombre.BackColor = Color.White
        txtCodigo.BackColor = Color.White
        txtPrecio.BackColor = Color.White
        txtDescripcion.BackColor = Color.White
      Else
        txtNombre.BackColor = SystemColors.Control
        txtCodigo.BackColor = SystemColors.Control
        txtDescripcion.BackColor = SystemColors.Control
        txtPrecio.BackColor = SystemColors.Control
      End If
      GroupBox1.Enabled = Not permitir
      GroupBox2.Enabled = Not permitir
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

  


  Private Sub rbtnResponsables_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnResponsables.CheckedChanged
    Try
      cmbResponsables.Enabled = rbtnResponsables.Checked
      txtFiltro.Enabled = rbtnResponsables.Checked

      'dgvStock.Columns("Responsable").Visible = rbtnResponsables.Checked

      If rbtnResponsables.Checked = False Then
        cmbResponsables.SelectedIndex = 0
      End If

      For Each column As DataGridViewColumn In dgvStock.Columns
        If column.DataPropertyName = "Responsable" Then
          column.Visible = rbtnResponsables.Checked
        End If
      Next


      Call MostrarListaArticulos()
     

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillResponsables()
    Try
      m_listResponsables.Clear()


      For Each grupo In m_Grupos.Items
        m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = grupo.Nombre, .GuidResponsable = grupo.GuidGrupo, .Codigo = ""})
      Next
      For Each responsable In m_ObjListaStock.Items
        If m_listResponsables.Exists(Function(c) c.GuidResponsable = responsable.GuidResponsable) Then Continue For
        m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = responsable.Responsable, .GuidResponsable = responsable.GuidResponsable, .Codigo = ""})
      Next
     
      cmbResponsables.DataSource = m_listResponsables

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddDeposito.MouseClick
    Try

      If m_ObjCurrent Is Nothing Then Exit Sub
      If txtIncrementar.Text.Trim <= 0 Then
        MsgBox("El valor deve ser mayor que cero")
        Exit Sub
      End If
      Dim cCantidad As Integer = CInt(txtIncrementar.Text)
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Dim ArticuloSeleccionado As clsListaStorage = CType(dgvStock.Rows(objSelectedIndex).DataBoundItem, clsListaStorage)
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidGrupo.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then
          'existe en deposito
          Dim GuidResponsable As Guid
          Dim Responsable As String
          If rbtnByStock.Checked = True Then
            GuidResponsable = m_Deposito.GuidGrupo
            Responsable = m_Deposito.Nombre
          Else
            If cmbResponsables.SelectedIndex < 0 Then Exit Sub
            GuidResponsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).GuidResponsable
            Responsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).ToString
          End If

          Dim ArticuloDelDeposito As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          Dim ArticuloDelResponsable As manDB.clsInfoStock
          If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
          m_ObjListaStock = New clsListStock
          m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "}"
          m_ObjListaStock.RefreshData()
          If m_ObjListaStock.Items.Count > 0 Then
            'ya tenia articulos
            ArticuloDelResponsable = m_ObjListaStock.Items.First.Clone

          Else
            'no tenia este articulo
            ArticuloDelResponsable = New manDB.clsInfoStock
            ArticuloDelResponsable.GuidArticulo = m_ObjCurrent.GuidArticulo
            ArticuloDelResponsable.GuidResponsable = GuidResponsable
            ArticuloDelResponsable.Responsable = Responsable
            ArticuloDelResponsable.Cantidad = 0

          End If
          If GuidResponsable <> m_Deposito.GuidGrupo Then
            If cCantidad > ArticuloDelDeposito.Cantidad Then
              MsgBox("No se mover esa cantidad al responsable, elija un valor menor o igual al maximo disponibles en stock")
              Exit Sub
            End If
            ArticuloDelDeposito.Cantidad -= cCantidad
          End If

          ArticuloDelResponsable.Cantidad += cCantidad
          clsStock.Save(ArticuloDelDeposito)
          clsStock.Save(ArticuloDelResponsable)
        Else
          'No existe en deposito
          If m_ObjCurrent.GuidResponsable = m_Deposito.GuidGrupo Then


            Dim ArticuloNuevoEnStock As New manDB.clsInfoStock
            ArticuloNuevoEnStock.GuidArticulo = m_ObjCurrent.GuidArticulo
            ArticuloNuevoEnStock.Responsable = m_Deposito.ToString
            ArticuloNuevoEnStock.GuidResponsable = m_Deposito.GuidGrupo
            ArticuloNuevoEnStock.Cantidad = cCantidad
            clsStock.Save(ArticuloNuevoEnStock)
          End If
        End If


        m_Skip = True
        Call MostrarListaArticulos()
        If m_LastColumnEvent IsNot Nothing Then Call dgvStock_ColumnHeaderMouseClick(dgvStock, m_LastColumnEvent)
        m_Skip = False
      Finally

        For Each item As DataGridViewRow In dgvStock.Rows
          If CType(item.DataBoundItem, clsListaStorage).Equals(ArticuloSeleccionado) Then
            Refresh_Selection(dgvStock.Rows.IndexOf(item))
            Exit For
          End If
        Next

      End Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemDeposito.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      If txtDecrementar.Text.Trim <= 0 Then
        MsgBox("El valor deve ser mayor que cero")
        Exit Sub
      End If
      Dim cCantidad As Integer = CInt(txtDecrementar.Text)
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Dim ArticuloSeleccionado As clsListaStorage = CType(dgvStock.Rows(objSelectedIndex).DataBoundItem, clsListaStorage)
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        Dim GuidResponsable As Guid
        Dim Responsable As String
        If rbtnByStock.Checked = True Then
          GuidResponsable = m_Deposito.GuidGrupo
          Responsable = m_Deposito.ToString
        Else
          GuidResponsable = m_ObjCurrent.GuidResponsable
          Responsable = m_ObjCurrent.Responsable
        End If
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then
          'El responsable tiene objetos
          Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          Dim ArticuloDelDeposito As manDB.clsInfoStock

          'Cargo el articulo del deposito
          m_ObjListaStock = New clsListStock
          m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & ArticuloDelResponsable.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidGrupo.ToString & "}"
          m_ObjListaStock.RefreshData()
          If m_ObjListaStock.Items.Count > 0 Then
            ArticuloDelDeposito = m_ObjListaStock.Items.First.Clone
          Else
            MsgBox("No estaba en stock")
            Exit Sub
          End If

          If cCantidad > ArticuloDelDeposito.Cantidad Then
            MsgBox("No se mover esa cantidad al responsable, elija un valor menor o igual al maximo disponibles en stock")
            Exit Sub
          End If

          If GuidResponsable <> m_Deposito.GuidGrupo Then
            'mover a deposito
            ArticuloDelDeposito.Cantidad += cCantidad
          End If

          ArticuloDelResponsable.Cantidad -= cCantidad
          clsStock.Save(ArticuloDelDeposito)
          clsStock.Save(ArticuloDelResponsable)

        End If


        m_Skip = True
        Call MostrarListaArticulos()
        If m_LastColumnEvent IsNot Nothing Then Call dgvStock_ColumnHeaderMouseClick(dgvStock, m_LastColumnEvent)
        m_Skip = False

      Finally
        For Each item As DataGridViewRow In dgvStock.Rows
          If CType(item.DataBoundItem, clsListaStorage).Equals(ArticuloSeleccionado) Then
            Refresh_Selection(dgvStock.Rows.IndexOf(item))
            Exit For
          End If
        Next
      End Try
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnVendido_MouseClick(sender As Object, e As MouseEventArgs) Handles btnVendido.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        Dim GuidResponsable As Guid
        Dim Responsable As String
        If rbtnByStock.Checked = True Then
          GuidResponsable = m_Deposito.GuidGrupo
          Responsable = m_Deposito.ToString
        Else
          GuidResponsable = m_ObjCurrent.GuidResponsable
          Responsable = m_ObjCurrent.Responsable
        End If
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then

          Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          ArticuloDelResponsable.Cantidad -= 1
          clsStock.Save(ArticuloDelResponsable)
        End If



        Call MostrarListaArticulos()
      Finally
        Refresh_Selection(objSelectedIndex)
      End Try
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
    Try
      BindingSource1.DataSource = m_objStock.FindAll(Function(c) c.Responsable.ToUpper.Contains(txtFiltro.Text.ToUpper.Trim))
      BindingSource1.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGrupos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGrupos.MouseClick
    Try
      Using objForm As New frmVendedores
        objForm.ShowDialog()
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class