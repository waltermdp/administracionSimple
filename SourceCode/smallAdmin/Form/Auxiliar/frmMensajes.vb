Option Strict Off
Imports libCommon.Comunes
Imports manDB
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmMensajes

  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"
  Private m_MensajePatron As String = String.Empty
  Private m_lstConsulta As New List(Of clsInfoConsultaPagos)


  Private Sub Pagaron()
    Try
      Dim vResult As libCommon.Comunes.Result = Result.NOK
      'get Query
      Dim rConsulta As String = String.Empty
      vResult = Consulta(rConsulta)
      If vResult = Result.OK Then
        m_lstConsulta.Clear()
        vResult = clsConsulta.ConsultaPagos(rConsulta, m_lstConsulta)
      End If
      For Each item In m_lstConsulta
        item.Mensaje = GetMensaje(item)
      Next
      ClsInfoConsultaPagosBindingSource.DataSource = m_lstConsulta
      ClsInfoConsultaPagosBindingSource.ResetBindings(False)
      Dim resultxmetodo As String = String.Empty

      lblCount.Text = String.Format("Cantidad: {0}", m_lstConsulta.Count.ToString("00"))

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GetMensaje(ByVal item As clsInfoConsultaPagos) As String
    Try
      'Dim b As New Uri("https://web.whatsapp.com/send?phone={0}&text=El dia {1} se realizo el cobro automatico de la cuota {2}/{3} de {4} pesos.")

      ' "https://web.whatsapp.com/send?phone={0}&text=El dia {1} se realizo el cobro automatico de la cuota {2}/{3} de {4} pesos."
      Return String.Format(m_MensajePatron, item.Telefono1, item.FechaPago.ToString("dd/MM/yyyy"), item.CuotaNumero, item.TotalCuotas, String.Format(g_Cultura, "{0:C}", item.ValorCuota))
    Catch ex As Exception
      Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function

  Private Function Consulta(ByRef rconsulta As String) As libCommon.Comunes.Result
    Try

      'cuotas pagas
      Dim qGuidMetodoPago As String = String.Empty
     

      Dim qPagosRealizados As String = String.Empty
      If chkPagosIngresados.Checked = True Then

        qPagosRealizados = "(Pagos.FechaPago>=#" & Format(dtPagadosDesde.Value, strFormatoAnsiStdFecha) & "#) AND (Pagos.FechaPago<=#" & Format(dtPagadosHasta.Value, strFormatoAnsiStdFecha) & "#) AND (Pagos.EstadoPago=1)"
      End If

      If Not String.IsNullOrEmpty(qPagosRealizados) Then
        If Not String.IsNullOrEmpty(rconsulta) Then rconsulta = rconsulta & " AND "
        rconsulta = rconsulta & qPagosRealizados
      End If

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    Try
      Pagaron()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
  '  Try
  '    If m_lstConsulta Is Nothing Then Exit Sub
  '    If m_lstConsulta.Count <= 0 Then Exit Sub
  '    Dim vResult As DialogResult
  '    Dim pathFileFullName As String
  '    Using dialogGuardarFile As New Windows.Forms.SaveFileDialog
  '      dialogGuardarFile.AddExtension = True
  '      dialogGuardarFile.DefaultExt = "xls"
  '      dialogGuardarFile.OverwritePrompt = True
  '      dialogGuardarFile.Filter = "Excel files (*.xls)|*.xls"

  '      vResult = dialogGuardarFile.ShowDialog(Me)
  '      pathFileFullName = dialogGuardarFile.FileName
  '    End Using
  '    If vResult <> Windows.Forms.DialogResult.OK Then Exit Sub

  '    Dim xls As New Excel.Application
  '    Dim misValue As Object = System.Reflection.Missing.Value
  '    Dim workbook As Excel.Workbook = xls.Workbooks.Add(misValue)
  '    Dim worksheet As Excel.Worksheet = CType(workbook.Worksheets(1), Excel.Worksheet)

  '    Try
  '      'worksheet.Cells(1, 1) = "23"
  '      '  worksheet = CType(workbook.Worksheets("Facturas"), Excel.Worksheet)
  '      '  Dim lista As List(Of clsInfoExportarVisaCredito) = vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante)).ToList

  '      worksheet.Cells(1, 1).value = "Cliente" ' dgvData1.Columns(i - 1).HeaderText
  '      worksheet.Cells(1, 2).value = "Telefono 1"
  '      worksheet.Cells(1, 3).value = "Fecha Pago"
  '      worksheet.Cells(1, 4).value = "Cuota #"
  '      worksheet.Cells(1, 5).value = "Cuota Total"
  '      worksheet.Cells(1, 6).value = "Valor cuota"
  '      worksheet.Cells(1, 7).value = "Mensaje"

  '      'Dim cell3 As Excel.Worksheet.CellRange = sheet.Range("B7")
  '      'Dim fileLink As Excel.Hyperlink  HyperLink = sheet.HyperLinks.Add(cell3)
  '      'fileLink.Type = HyperLinkType.File
  '      'fileLink.TextToDisplay = "Link to an external file"
  '      'fileLink.Address = "C:\\Users\\Administrator\\Desktop\\Report.xlsx"


  '      For i As Integer = 0 To m_lstConsulta.Count - 1 ' Each Movimiento In vMovimientos
  '        worksheet.Cells(i + 2, 1).value = m_lstConsulta(i).Cliente.ToString
  '        worksheet.Cells(i + 2, 2).value = m_lstConsulta(i).Telefono1.ToString
  '        worksheet.Cells(i + 2, 3).value = m_lstConsulta(i).FechaPago.ToString("dd/MM/yyyy")
  '        worksheet.Cells(i + 2, 4).value = m_lstConsulta(i).CuotaNumero.ToString
  '        worksheet.Cells(i + 2, 5).value = m_lstConsulta(i).TotalCuotas.ToString
  '        worksheet.Cells(i + 2, 6).value = String.Format("{0:N2}", m_lstConsulta(i).ValorCuota)
  '        worksheet.Hyperlinks.Add(worksheet.Cells(i + 2, 7), m_lstConsulta(i).Mensaje.ToString, , "WhatsApp", "LINK")
  '        worksheet.Cells(i + 2, 8).value = m_lstConsulta(i).Mensaje.ToString  'a modo de saber lo que hay en el link mas rapido

  '      Next

  '      worksheet.SaveAs(pathFileFullName)

  '      workbook.Close(False)
  '      worksheet = Nothing
  '      workbook = Nothing
  '      xls = Nothing
  '    Finally


  '    End Try


  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub


  Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
    Try

      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      IO.File.Copy(IO.Path.Combine(MODEL_PATH, "msg.xls"), IO.Path.Combine(TEMP_PATH, "msg.xls"), True)
      workbook = xls.Workbooks.Open(IO.Path.Combine(TEMP_PATH, "msg.xls"))
      Try
        worksheet = CType(workbook.Worksheets("mensajes"), Excel.Worksheet)

        For i As Integer = 0 To m_lstConsulta.Count - 1 ' Each Movimiento In vMovimientos
          worksheet.Cells(i + 2, 1).value = m_lstConsulta(i).Cliente.ToString
          worksheet.Cells(i + 2, 2).value = m_lstConsulta(i).Telefono1.ToString
          worksheet.Cells(i + 2, 3).value = m_lstConsulta(i).FechaPago.ToString("dd/MM/yyyy")
          worksheet.Cells(i + 2, 4).value = m_lstConsulta(i).CuotaNumero.ToString
          worksheet.Cells(i + 2, 5).value = m_lstConsulta(i).TotalCuotas.ToString
          worksheet.Cells(i + 2, 6).value = String.Format("{0:N2}", m_lstConsulta(i).ValorCuota)
          worksheet.Hyperlinks.Add(worksheet.Cells(i + 2, 7), m_lstConsulta(i).Mensaje.ToString, , "WhatsApp", "LINK")
          worksheet.Cells(i + 2, 8).value = m_lstConsulta(i).Mensaje.ToString  'a modo de saber lo que hay en el link mas rapido

        Next

        workbook.SaveCopyAs(IO.Path.Combine(App_path, GetHoy.ToString("yyMMdd") & "_mensajes.xls"))

      Finally
        workbook.Close(False)
      End Try

      MsgBox("Finalizo exportacion")

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub dgvData1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData1.CellContentClick
  '  Try



  '    Dim columna As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
  '    If columna.DataPropertyName.ToUpper.Equals("MENSAJE") Then
  '      If e.ColumnIndex <> -1 And e.RowIndex <> -1 Then
  '        Process.Start(CStr(dgvData1.Item(e.ColumnIndex, e.RowIndex).Value))
  '      End If


  '    End If

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub ttCopiar_Click(sender As Object, e As EventArgs) Handles ttCopiar.Click
    Try
      Dim valor As String = TryCast(ttCopiar.Tag, String)
      If Not (valor Is Nothing) Then
        My.Computer.Clipboard.SetText(valor)
        valor = String.Empty
      End If
      ContextMenuStrip1.Hide()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.CellMouseDown
    Try

      Dim columna As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
      If columna.DataPropertyName.ToUpper.Equals("MENSAJE") Then
        If e.ColumnIndex <> -1 And e.RowIndex <> -1 Then
          If e.Button = Windows.Forms.MouseButtons.Left Then
            Process.Start(CStr(dgvData1.Item(e.ColumnIndex, e.RowIndex).Value))
          ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            dgvData1.Rows(e.RowIndex).Selected = True
            Dim aux As Rectangle = dgvData1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            ContextMenuStrip1.Show(dgvData1, aux.X, aux.Y)
            ttCopiar.Tag = CStr(dgvData1.Item(e.ColumnIndex, e.RowIndex).Value)
          End If
        End If
      End If
      
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub dgvData1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.CellMouseClick
  '  Try
  '    If e.Button = Windows.Forms.MouseButtons.Left Then

  '    End If
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  

  Private Sub dgv_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.ColumnHeaderMouseClick
    Try
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
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
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next


        ClsInfoConsultaPagosBindingSource.DataSource = m_lstConsulta.OrderBy(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)).ToList()

        ClsInfoConsultaPagosBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)

      Else
        For Each col As DataGridViewColumn In dgvData1.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        ClsInfoConsultaPagosBindingSource.DataSource = m_lstConsulta.OrderByDescending(Function(c) c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)).ToList()

        ClsInfoConsultaPagosBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)

      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmMensajes_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      'Cargar Mensaje patron
      CargarMensajePatron(m_MensajePatron)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarMensajePatron(ByRef rMensaje As String)
    Try
      Dim lineas As New List(Of String)
      Dim bNoCargado As Boolean = False
      Dim vResult As Result = modFile.Load(IO.Path.Combine(CONFIG_PATH, "mensaje.dat"), lineas)
      If vResult <> Result.OK Then bNoCargado = True
      If vResult = Result.OK Then
        If lineas(2).Trim Is Nothing Then bNoCargado = True
        If String.IsNullOrEmpty(lineas(2)) Then bNoCargado = True
      End If
      If bNoCargado = True Then
        MsgBox("No se pudo cargar el archivo del mensaje para enviar, se utilizara uno por defecto.")
        'item.Cliente, item.ValorCuota, item.FechaPago, item.Telefono1
        rMensaje = "https://web.whatsapp.com/send?phone={0}&text=El dia {1} se realizo el cobro automatico de la cuota {2} de {3} pesos."
        lineas.Add("100")
        lineas.Add("1")
        lineas.Add(rMensaje)
        modFile.Save(IO.Path.Combine(CONFIG_PATH, "mensaje.dat"), lineas)
      End If
      rMensaje = lineas(2).Trim

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



End Class