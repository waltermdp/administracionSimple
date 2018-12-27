Imports libCommon.Comunes

Public Class frmArticulos
  Private WithEvents m_objArticulosList As clsListArticulos = Nothing
  Private m_objArticuloCurrent As manDB.clsInfoArticulos = Nothing

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

      m_objArticulosList = New clsListArticulos()
      bsArticulos.DataSource = m_objArticulosList.Binding
      Call ArticulosList_RefreshData()

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

  Private Sub dgvListArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListArticulos.SelectionChanged
    Try
      If dgvListArticulos.SelectedRows.Count <> 1 Then Exit Sub

      Call Refresh_Selection(dgvListArticulos.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvListArticulos.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_objArticuloCurrent = CType(dgvListArticulos.Rows(indice).DataBoundItem, manDB.clsInfoArticulos)

      End If
      If dgvListArticulos.Rows(indice).Selected <> True Then
        dgvListArticulos.Rows(indice).Selected = True
      End If
      Call FillArticuloData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseClick
    Try
      If m_objArticuloCurrent Is Nothing Then
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
      m_objArticuloCurrent = New manDB.clsInfoArticulos
      m_objArticuloCurrent.GuidArticulo = Guid.NewGuid
      Call FillArticuloData()
      Call AllowEditNew(True)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEliminar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseClick
    Try
      If m_objArticuloCurrent Is Nothing Then
        MsgBox("Debe seleccionar un articulo de la lista")
        Exit Sub
      End If
      If clsArticulo.Delete(m_objArticuloCurrent.GuidArticulo) <> Result.OK Then
        MsgBox("No se pudo eliminar el articulo seleccionado.")
      End If
      m_objArticuloCurrent = Nothing
      Call Refresh_Selection(-1)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      Call CargarData()

      If clsArticulo.Save(m_objArticuloCurrent) <> Result.OK Then
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
      With m_objArticuloCurrent
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
      If m_objArticuloCurrent Is Nothing Then Exit Sub
      With m_objArticuloCurrent
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

  


End Class