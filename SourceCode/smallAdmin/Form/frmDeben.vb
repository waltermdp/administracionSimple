Imports libCommon.Comunes
Imports manDB

Public Class frmDeben

  Private WithEvents m_objProductoList As clsListProductos = Nothing
  Private m_CurrentProducto As clsInfoProducto = Nothing

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    Try
      Me.Close()
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
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmDeben_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarDeben()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarDeben()
    Try
      If m_objProductoList IsNot Nothing Then m_objProductoList.Dispose()

      m_objProductoList = New clsListProductos()
      bsDeben.DataSource = m_objProductoList.Binding
      Call ProductList_RefreshData()
      bsDeben.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ProductList_RefreshData()
    Try
      m_objProductoList.RefreshData()
    Catch ex As Exception
      Print_msg(ex.Message)
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
        m_CurrentProducto = CType(dgvData.Rows(indice).DataBoundItem, manDB.clsInfoProducto)

      End If
      If dgvData.Rows(indice).Selected <> True Then
        dgvData.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
    Try
      If cmbTipoPago.SelectedIndex < 0 Then
        MsgBox("Debe Seleccionar un tipo de pago")
        Exit Sub
      End If
      Dim tipoPago As clsTipoPago = CType(cmbTipoPago.SelectedItem, clsTipoPago)
      Using objForm As New frmPreviewAplicarPago(tipoPago)
        objForm.ShowDialog()
        Call ProductList_RefreshData()
      End Using
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLstVendedores.Click
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
      Dim lProducto As New clsInfoProducto

      Using objVenta As New frmVenta()
        objVenta.ShowDialog()
        If objVenta.HayCambios Then
          objVenta.getCambios(lProducto)
          'TODO: resolver dentro del formulario venta

        End If
      End Using

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

      Using objForm As New frmVenta(m_CurrentProducto)
        objForm.ShowDialog()

      End Using
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


End Class