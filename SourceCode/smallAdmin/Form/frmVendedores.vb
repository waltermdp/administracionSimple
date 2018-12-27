Imports libCommon.Comunes
Public Class frmVendedores
  Private WithEvents m_objVendedoresList As clsListVendedores = Nothing
  Private m_objVendedorCurrent As manDB.clsInfoVendedor = Nothing

  Private Sub frmVendedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarListaVendedores()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarListaVendedores()
    Try
      If m_objVendedoresList IsNot Nothing Then m_objVendedoresList.Dispose()

      m_objVendedoresList = New clsListVendedores()
      bsVendedores.DataSource = m_objVendedoresList.Binding
      Call VendedoresList_RefreshData()
      bsVendedores.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub VendedoresList_RefreshData()
    Try
      m_objVendedoresList.RefreshData()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvListVendedores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListVendedores.SelectionChanged
    Try

      If dgvListVendedores.SelectedRows.Count <> 1 Then Exit Sub

      Call Refresh_Selection(dgvListVendedores.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvListVendedores.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_objVendedorCurrent = CType(dgvListVendedores.Rows(indice).DataBoundItem, manDB.clsInfoVendedor)

      End If
      If dgvListVendedores.Rows(indice).Selected <> True Then
        dgvListVendedores.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    Try
      Using objForm As New frmVendedorData(Nothing)
        objForm.ShowDialog()
      End Using
      Call MostrarListaVendedores()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
    Try
      If m_objVendedorCurrent Is Nothing Then
        MsgBox("Debe seleccionar un Vendedor de la lista")
        Exit Sub
      End If
      Using objForm As New frmVendedorData(m_objVendedorCurrent)
        objForm.ShowDialog()
      End Using
      Call MostrarListaVendedores()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
    Try
      If m_objVendedorCurrent Is Nothing Then
        MsgBox("Debe seleccionar un vendedor")
        Exit Sub
      End If
      If MsgBox("Desea eliminar el Vendedor seleccionado?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        If clsVendedor.Delete(m_objVendedorCurrent.GuidVendedor) <> Result.OK Then
          MsgBox("No se puede eliminar el Vendedor seleccionado")
          Exit Sub
        End If
      End If
      Call MostrarListaVendedores()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetVendedorSelected(ByRef rVendedor As manDB.clsInfoVendedor)
    Try
      If m_objVendedorCurrent Is Nothing Then
        rVendedor = Nothing
        Exit Sub
      End If
      rVendedor = m_objVendedorCurrent.Clone
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    Try
      Me.Close()
      Exit Sub
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class