Imports libCommon.Comunes
Imports manDB
Public Class frmListaClientes

  Private m_CurrentSortColumnName As String
  Private m_CurrentSortDirection As String
  Private m_CurrentSortColumn As DataGridViewColumn
  Private WithEvents m_objDatabaseList As clsListDatabase = Nothing
  Private Const CONST_COUNT_PACS_FOR_PAGE As Integer = 10
  Private m_objPersona_Current As ClsInfoPersona = Nothing

  Private m_SelectedClient As clsInfoCliente


  Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try


      m_CurrentSortColumnName = "Nombre"
      m_CurrentSortDirection = "DESC"
      txtFiltro.Select()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetClienteSelected(ByRef objCliente As ClsInfoPersona)
    Try
      If m_SelectedClient Is Nothing Then
        objCliente = Nothing
        Exit Sub
      End If
      objCliente = m_SelectedClient.Personal.Clone
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
    Try
      If String.IsNullOrEmpty(txtFiltro.Text) Then
        m_objPersona_Current = Nothing
        bsInfoCliente.DataSource = Nothing
        bsInfoCliente.ResetBindings(False)
        Exit Sub
      End If
      MostrarClientes()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarClientes()
    Try
      Dim strFilterUser As String = ""

      If m_objDatabaseList IsNot Nothing Then m_objDatabaseList.Dispose()



      m_objDatabaseList = New clsListDatabase()
      m_objDatabaseList.Cfg_Filtro = GetFiltro()
      bsInfoCliente.DataSource = m_objDatabaseList.Binding

      m_objPersona_Current = Nothing
      Call ClientList_RefreshData()
      bsInfoCliente.ResetBindings(False)

      lblInfo.Text = String.Format("Resultados: {0}", m_objDatabaseList.Items.Count)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GetFiltro() As String
    Try
      If txtFiltro.Text = "*" Then
        Return String.Empty
      End If
      Dim Command As String = "where Nombre Like '%" & txtFiltro.Text.Trim & _
                              "%' OR Apellido Like '%" & txtFiltro.Text.Trim & _
                              "%' OR ID Like '%" & txtFiltro.Text.Trim & _
                              "%' OR NumCliente Like '%" & txtFiltro.Text.Trim & "%'"

      Return Command
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return ""
    End Try
  End Function

  Private Sub ClientList_RefreshData()
    Try
      m_objDatabaseList.RefreshData()


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.ColumnHeaderMouseClick
    Try
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsInfoCliente.DataSource = m_objDatabaseList.Items.OrderBy(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()


        bsInfoCliente.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)
      Else
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsInfoCliente.DataSource = m_objDatabaseList.Items.OrderByDescending(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c), New clsComparar).ToList()


        bsInfoCliente.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvData1.SelectionChanged

    Try

      If dgvData1.SelectedRows.Count <> 1 Then Exit Sub

      Call Refresh_Selection(dgvData1.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub dgvData_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvData1.DataError
    Try
      Dim ew As Integer = 0
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub bsInfoCliente_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsInfoCliente.ListChanged
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub Refresh_Selection(ByVal indice As Integer)

    Try


      If indice < 0 Then
        dgvData1.ClearSelection()
        Exit Sub
      End If

      If (indice >= 0) Then
        m_objPersona_Current = CType(dgvData1.Rows(indice).DataBoundItem, ClsInfoPersona)
      End If

      If dgvData1.Rows(indice).Selected <> True Then
        dgvData1.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)

    End Try

  End Sub




  Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    Try
      Dim vResult As Result
      If m_objPersona_Current Is Nothing Then
        MsgBox("Debe seleccionar un cliente")
        Exit Sub
      End If
      Dim LDataCliente As New clsInfoCliente
      vResult = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, LDataCliente)
      If vResult <> Result.OK Then
        MsgBox("no existe cliente")
        Exit Sub
      End If

      Dim objDialog As New frmCliente(LDataCliente.Personal)
      objDialog.ShowDialog()
      objDialog.Dispose()

      Call MostrarClientes()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    Try

      Dim objDialog As New frmCliente(Nothing)
      objDialog.ShowDialog(Me)
      objDialog.Dispose()

      Call MostrarClientes()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    Try

      Dim vResult As Result
      If m_objPersona_Current Is Nothing Then
        m_SelectedClient = Nothing
      Else
        vResult = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
        If vResult <> Result.OK Then
          m_SelectedClient = Nothing
        End If

      End If
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  
  Private Sub btnBuscar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseClick
    Try
      Call MostrarClientes()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnMostrarErrores_Click(sender As Object, e As EventArgs) Handles btnMostrarErrores.Click
    Try
      Dim strFilterUser As String = ""

      If m_objDatabaseList IsNot Nothing Then m_objDatabaseList.Dispose()
      m_objDatabaseList = New clsListDatabase()
      'm_CurrentSortDirection = "DESC"
      'm_CurrentSortColumnName = "Nombre" 'Nothing
      'm_objDatabaseList.Cfg_Orden = "ORDER BY " & m_CurrentSortColumnName & " " & m_CurrentSortDirection
      Dim Command As String = "where ID='" & String.Empty & _
                              "' OR NumCliente='" & String.Empty & "'"
      m_objDatabaseList.Cfg_Filtro = Command

      bsInfoCliente.DataSource = m_objDatabaseList.Binding

      m_objPersona_Current = Nothing
      Call ClientList_RefreshData()

      bsInfoCliente.ResetBindings(False)
      lblInfo.Text = String.Format("Resultados: {0}", m_objDatabaseList.Items.Count)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnMostrarDuplicados_Click(sender As Object, e As EventArgs) Handles btnMostrarDuplicados.Click
    Try
      Dim strFilterUser As String = ""

      If m_objDatabaseList IsNot Nothing Then m_objDatabaseList.Dispose()
      m_objDatabaseList = New clsListDatabase()
      'm_CurrentSortDirection = "DESC"
      'm_CurrentSortColumnName = "Nombre" 'Nothing
      'm_objDatabaseList.Cfg_Orden = "ORDER BY " & m_CurrentSortColumnName & " " & m_CurrentSortDirection
      Dim Command As String = "GROUP BY ID"
      m_objDatabaseList.Cfg_Filtro = Command

      bsInfoCliente.DataSource = m_objDatabaseList.Binding

      m_objPersona_Current = Nothing
      Call ClientList_RefreshData()

      bsInfoCliente.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

 
  Private Sub dgvData1_DoubleClick(sender As Object, e As EventArgs) Handles dgvData1.DoubleClick
    Try

      Dim vResult As Result = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
      If vResult <> Result.OK Then
        Exit Sub
      End If
      btnVolver.PerformClick()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
