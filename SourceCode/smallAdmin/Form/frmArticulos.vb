Imports libCommon.Comunes
Imports System.ComponentModel
Public Class frmArticulos
  Private WithEvents m_objArticulosList As clsListArticulos = Nothing
  'Private m_objArticuloCurrent As manDB.clsInfoArticulos = Nothing
  Private WithEvents m_ObjListaStock As clsListStock = Nothing
  Private m_objStock As BindingList(Of clsListaStorage)
  Private m_ObjCurrent As clsListaStorage
  Private m_listResponsables As New List(Of clsInfoResponsable)

  Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call AllowEditNew(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarListaArticulos()
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

      Call ArticulosList_RefreshData()
      Call ListaStock_RefreshData()
      'ya tengo las dos lista actualizadas


      Dim auxArticulo As clsListaStorage
      m_objStock = New BindingList(Of clsListaStorage)
      BindingSource1.DataSource = m_objStock
      dgvStock.DataSource = BindingSource1

      For Each item In m_objArticulosList.Items
        auxArticulo = New clsListaStorage
        auxArticulo.GuidArticulo = item.GuidArticulo
        auxArticulo.Nombre = item.Nombre
        auxArticulo.Codigo = item.Codigo
        auxArticulo.Descripcion = item.Descripcion
        If rbtnByStock.Checked Then
          For Each elemento In m_ObjListaStock.Items
            If elemento.GuidArticulo = item.GuidArticulo Then
              auxArticulo.Cantidad += elemento.Cantidad
            End If
          Next
          m_objStock.Add(auxArticulo)
        Else
          For Each elemento In m_ObjListaStock.Items
            If elemento.GuidArticulo = item.GuidArticulo Then
              auxArticulo.Cantidad = elemento.Cantidad
              auxArticulo.Responsable = elemento.Responsable
              m_objStock.Add(auxArticulo)
            End If
          Next
        End If


      Next
      
      BindingSource1.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
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

  'Private Sub dgvListArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListArticulos.SelectionChanged
  '  Try
  '    If dgvListArticulos.SelectedRows.Count <> 1 Then Exit Sub

  '    Call Refresh_Selection(dgvListArticulos.SelectedRows(0).Index)

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvStock.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_objCurrent = CType(dgvStock.Rows(indice).DataBoundItem, clsListaStorage)

      End If
      If dgvStock.Rows(indice).Selected <> True Then
        dgvStock.Rows(indice).Selected = True
      End If

      Call FillArticuloData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvStock_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStock.SelectionChanged
    Try
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
      Dim aux As New manDB.clsInfoArticulos
      aux.GuidArticulo = m_ObjCurrent.GuidArticulo
      aux.Nombre = m_ObjCurrent.Nombre
      aux.Codigo = m_ObjCurrent.Codigo
      aux.Descripcion = m_ObjCurrent.Descripcion
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
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AllowEditNew(ByVal permitir As Boolean)
    Try

      txtNombre.ReadOnly = Not permitir
      txtCodigo.ReadOnly = Not permitir
      txtDescripcion.ReadOnly = Not permitir
      btnNuevo.Visible = Not permitir
      btnEditar.Visible = Not permitir
      btnEliminar.Visible = Not permitir
      btnGuardar.Visible = permitir
      btnCancelar.Visible = permitir
      dgvListArticulos.Visible = Not permitir
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

  


  Private Sub rbtnResponsables_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnResponsables.CheckedChanged
    Try

      Call MostrarListaArticulos()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillResponsables()
    Try
      m_listResponsables.Clear()
      Dim objlistVendedores As clsListVendedores = New clsListVendedores()
      objlistVendedores.RefreshData()
      For Each vendedor In objlistVendedores.Items
        m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = vendedor.Nombre, .GuidResponsable = vendedor.GuidVendedor, .Codigo = vendedor.NumVendedor})
      Next
      'TODO: llenar la lista
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddDeposito.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      m_ObjCurrent.Cantidad += 1
      Dim aux As New manDB.clsInfoStock
      aux.GuidArticulo = m_ObjCurrent.GuidArticulo
      aux.Responsable = m_ObjCurrent.Responsable
      aux.Cantidad = m_ObjCurrent.Cantidad
      clsStock.Save(aux)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemDeposito.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


End Class