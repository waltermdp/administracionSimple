Imports libCommon.Comunes
Imports manDB
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmListaClientes

  Private m_CurrentSortColumnName As String
  Private m_CurrentSortDirection As String
  Private m_CurrentSortColumn As DataGridViewColumn
  Private WithEvents m_objDatabaseList As clsListDatabase = Nothing
  Private Const CONST_COUNT_PACS_FOR_PAGE As Integer = 10
  Private m_objPersona_Current As ClsInfoPersona = Nothing

  Private m_SelectedClient As clsInfoCliente
  Private m_Result As Result = Result.CANCEL

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

  Private Sub chkAddCiudad_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddCiudad.CheckedChanged, chkAddProfesion.CheckedChanged, chkAddComentarios.CheckedChanged
    Try
      Call MostrarClientes()
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

      If chkAddCiudad.Checked Then
        Command = Command & " OR Ciudad LIKE '%" & txtFiltro.Text.Trim & "%' OR Provincia LIKE '%" & txtFiltro.Text.Trim & "%'"
      End If
      If chkAddProfesion.Checked Then
        Command = Command & " OR Profesion LIKE '%" & txtFiltro.Text.Trim & "%'"
      End If
      If chkAddComentarios.Checked Then
        Command = Command & " OR Comentarios LIKE '%" & txtFiltro.Text.Trim & "%'"
      End If

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
      If m_objDatabaseList Is Nothing Then Exit Sub
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsInfoCliente.DataSource = m_objDatabaseList.Items.OrderBy(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


        bsInfoCliente.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)
      Else
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        bsInfoCliente.DataSource = m_objDatabaseList.Items.OrderByDescending(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


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

      m_Result = Result.CANCEL
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


  Private Sub dgvData1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData1.CellContentDoubleClick
    Try

      If m_objPersona_Current Is Nothing Then Exit Sub

      Dim vResult As Result = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
      If vResult <> Result.OK Then
        Exit Sub
      End If
      btnSeleccionar.PerformClick()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub dgvData1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData1.CellDoubleClick
  
  End Sub
 
  Private Sub dgvData1_DoubleClick(sender As Object, e As EventArgs) Handles dgvData1.DoubleClick
    Try

      'If m_objPersona_Current Is Nothing Then Exit Sub

      'Dim vResult As Result = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
      'If vResult <> Result.OK Then
      '  Exit Sub
      'End If
      'btnSeleccionar.PerformClick()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetResult() As Result
    Try
      Return m_Result
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
    Try
      Dim vResult As Result = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
      If vResult <> Result.OK Then
        Exit Sub
      End If

      If m_objPersona_Current Is Nothing Then
        m_SelectedClient = Nothing
      Else
        vResult = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, m_SelectedClient)
        If vResult <> Result.OK Then
          m_SelectedClient = Nothing
        End If
      End If
      If m_SelectedClient Is Nothing Then
        MsgBox("Debe elegir un cliente de la lista")
        Exit Sub
      End If
      m_Result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


 


  Private Sub dgvData1_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.ColumnHeaderMouseDoubleClick
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub Exportar (ByVal path As String, ByVal Lista

  Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
    Try
      If m_objDatabaseList Is Nothing Then Exit Sub
      If m_objDatabaseList.Items.Count <= 0 Then Exit Sub
      Dim vResult As DialogResult
      Dim pathFileFullName As String
      Using dialogGuardarFile As New Windows.Forms.SaveFileDialog
        dialogGuardarFile.AddExtension = True
        dialogGuardarFile.DefaultExt = "xls"
        dialogGuardarFile.OverwritePrompt = True
        dialogGuardarFile.Filter = "Excel files (*.xls)|*.xls"

        vResult = dialogGuardarFile.ShowDialog(Me)
        pathFileFullName = dialogGuardarFile.FileName
      End Using
      If vResult <> Windows.Forms.DialogResult.OK Then Exit Sub

      Dim xls As New Excel.Application
      Dim misValue As Object = System.Reflection.Missing.Value
      Dim workbook As Excel.Workbook = xls.Workbooks.Add(misValue)
      Dim worksheet As Excel.Worksheet = CType(workbook.Worksheets(1), Excel.Worksheet)

      Try
        worksheet.Cells(1, 1) = "23"
        '  worksheet = CType(workbook.Worksheets("Facturas"), Excel.Worksheet)
        '  Dim lista As List(Of clsInfoExportarVisaCredito) = vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante)).ToList
        '  For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos

        '  worksheet.Cells(i + 2, 1).value = lista(i).NumeroTarjeta.ToString
        '  worksheet.Cells(i + 2, 2).value = lista(i).NumeroComprobante
        '  worksheet.Cells(i + 2, 3).value = GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
        '  worksheet.Cells(i + 2, 4).value = lista(i).Importe 'acepta 1.23
        '  worksheet.Cells(i + 2, 5).value = lista(i).IdentificadorDebito
        '  worksheet.Cells(i + 2, 6).value = lista(i).CodigoDeAlta  ' N o E ver especificacion
        '  Next

        '  workbook.SaveCopyAs(IO.Path.Combine(GetFolderExportacion, GetHoy.ToString("yyMMdd") & "_DEBLIQC.ree.xls"))
        worksheet.SaveAs(pathFileFullName)

        workbook.Close(False)
        worksheet = Nothing
        workbook = Nothing
        xls = Nothing
      Finally


      End Try






    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
