Imports libCommon.Comunes
Public Class frmVendedores
  Private WithEvents m_objVendedoresList As clsListVendedores = Nothing
  Private m_objVendedorCurrent As manDB.clsInfoVendedor = Nothing

  Private m_Modo As Boolean = False
  Private m_Grupos As New clsListGrupos
  Private m_result As Result = Result.CANCEL

  Public Sub New(Optional ByVal vModo As Boolean = False)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    m_Modo = vModo

  End Sub

  Private Sub frmVendedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      If m_Modo Then
        btnEditar.Visible = False
        btnNuevo.Visible = False
        btnBorrar.Visible = False
        btnLiquidar.Visible = True
      End If
      m_Grupos.RefreshData()
      cmbGrupo.DataSource = m_Grupos.Items ' [Enum].GetNames(GetType(GRUPOS))
      txtFiltro.Select()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarListaVendedores()
    Try
      If m_objVendedoresList IsNot Nothing Then m_objVendedoresList.Dispose()

      m_objVendedoresList = New clsListVendedores()
      m_objVendedoresList.Cfg_Filtro = GetFiltro()
      bsVendedores.DataSource = m_objVendedoresList.Binding
      Call VendedoresList_RefreshData()
      bsVendedores.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GetFiltro() As String
    Try
      Dim Command As String = "where Nombre Like '%" & txtFiltro.Text.Trim & _
                              "%' OR Apellido Like '%" & txtFiltro.Text.Trim & _
                              "%' OR NumVendedor Like '%" & txtFiltro.Text.Trim & _
                              "%' OR Grupo like '%" & txtFiltro.Text.Trim & "%'"
      Return Command
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return ""
    End Try
  End Function

  Private Sub VendedoresList_RefreshData()
    Try
      m_objVendedoresList.RefreshData()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvListVendedores_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListVendedores.ColumnHeaderMouseClick
    Try
      If m_objVendedoresList Is Nothing Then Exit Sub
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvListVendedores.Columns(e.ColumnIndex)
      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvListVendedores.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsVendedores.DataSource = m_objVendedoresList.Items.OrderBy(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


        bsVendedores.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)
      Else
        For Each col As DataGridViewColumn In dgvListVendedores.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsVendedores.DataSource = m_objVendedoresList.Items.OrderByDescending(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


        bsVendedores.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvListVendedores_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvListVendedores.DataError
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvListVendedores_DoubleClick(sender As Object, e As EventArgs) Handles dgvListVendedores.DoubleClick
    Try
      btnSeleccionar.PerformClick()
    Catch ex As Exception
      Call Print_msg(ex.Message)
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
        m_objVendedorCurrent = Nothing
        cmbGrupo.SelectedIndex = Nothing
        Exit Sub
      End If
      If (indice >= 0) Then
        m_objVendedorCurrent = CType(dgvListVendedores.Rows(indice).DataBoundItem, manDB.clsInfoVendedor)
        cmbGrupo.SelectedItem = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = m_objVendedorCurrent.Grupo.ToUpper) ' m_objVendedorCurrent.Grupo
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
        Exit Sub
      End If
      rVendedor = m_objVendedorCurrent.Clone
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetResult() As Result
    Try
      Return m_result
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    Try
      m_result = Result.CANCEL
      Me.Close()
      Exit Sub
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnLiquidar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLiquidar.MouseClick
    Try
      If m_objVendedorCurrent Is Nothing Then
        MsgBox("Debe seleccionar un Vendedor de la lista")
        Exit Sub
      End If

      Using objForm As New frmLiquidacionVendedores(m_objVendedorCurrent)
        objForm.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnBuscar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseClick
    Try
      Call MostrarListaVendedores()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub cmbGrupo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGrupo.SelectedValueChanged
    Try
      If m_objVendedorCurrent Is Nothing Then Exit Sub
      If m_objVendedorCurrent.Grupo = cmbGrupo.SelectedItem.ToString Then Exit Sub
      m_objVendedorCurrent.Grupo = cmbGrupo.SelectedItem.ToString
      Dim vResult As Result = clsVendedor.Save(m_objVendedorCurrent)
      If vResult <> Result.OK Then
        MsgBox("No se puedo guardar el grupo seleccionado")
      End If

      dgvListVendedores.Refresh()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
    Try
      If String.IsNullOrEmpty(txtFiltro.Text) Then
        m_objVendedorCurrent = Nothing
        bsVendedores.DataSource = Nothing
        bsVendedores.ResetBindings(False)
        Exit Sub
      End If
      MostrarListaVendedores()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
    Try
      If m_objVendedorCurrent Is Nothing Then Exit Sub
      m_result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


End Class