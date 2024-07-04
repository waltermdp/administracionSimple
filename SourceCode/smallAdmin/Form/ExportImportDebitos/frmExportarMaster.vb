Imports libCommon.Comunes
Imports manDB
Public Class frmExportarMaster

  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_TipoPago As clsTipoPago

  '
  Private m_Banco As clsMaster
  Private m_skip As Boolean = False

  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_TipoPago = vTipoPago.Clone

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub frmExportarPatagonia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      m_Banco = New clsMaster(m_TipoPago.GuidTipo)
      m_skip = True
      cmbEstado.DataSource = [Enum].GetValues(GetType(manDB.clsInfoProducto.E_Estado))

      dtCurrent.Value = m_Banco.FechaPresentacion
      dtVencimiento.MinDate = dtCurrent.Value
      dtVencimiento.Value = Today.AddDays(2)
      m_Banco.FechaVencimiento = dtVencimiento.Value
      m_Banco.FechaPresentacion = dtCurrent.Value
      txtProducto.Text = m_Banco.Producto
      txtRazonSocial.Text = m_Banco.RazonSocial
      txtNroComercio.Text = m_Banco.NroComercio.ToString
      txtReferencia.Text = m_Banco.ReferenciaDebito
      chkEnableFrom.Checked = False
      pnlFiltrado.Enabled = False
      InitFiltrado()
      m_skip = False
      RecargarValores()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub RecargarValores()
    Try
      ValidarFiltro()
      updateOpcionesFiltrado()

      Dim vResult As Result = m_Banco.CargarContratosAExportar(Me)

      ClsInfoExportarMasterBindingSource.DataSource = m_Banco.m_RegistrosExportar
      ClsInfoExportarMasterBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}/{1}", m_Banco.countRegistrosAExportar, m_Banco.countTotalRegistros)
      txtImporteTotal.Text = m_Banco.ImporteTotalAExportar.ToString
      txtProducto.Text = m_Banco.Producto
      txtRazonSocial.Text = m_Banco.RazonSocial
      txtNroComercio.Text = m_Banco.NroComercio.ToString
      txtReferencia.Text = m_Banco.ReferenciaDebito

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub InitFiltrado()
    Try
      dnDayFrom.Minimum = 1
      dnDayFrom.Maximum = Date.DaysInMonth(m_Banco.FechaPresentacion.Year, m_Banco.FechaPresentacion.Month)
      dnDayTo.Minimum = 1
      dnDayTo.Maximum = Date.DaysInMonth(m_Banco.FechaPresentacion.Year, m_Banco.FechaPresentacion.Month)
      dnDayFrom.Value = 1
      dnDayTo.Value = m_Banco.FechaPresentacion.Day
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function ValidarFiltro() As Boolean
    Try
      If dnDayFrom.Value > dnDayTo.Value Then
        MsgBox("El intevalo de busqueda no esta correctamente ingresado #Desde<=#hasta")
        dnDayFrom.Value = 1
        Return False
      End If
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Function updateOpcionesFiltrado() As Boolean
    Try
      m_Banco.AplicarFiltradoFechas(chkEnableFrom.Checked)
      m_Banco.DayFrom = CInt(dnDayFrom.Value)
      m_Banco.DayTo = CInt(dnDayTo.Value)
      If rbAplicaMesesAnteriores.Checked Then
        m_Banco.ModoFiltrado = clsMaster.E_FiltroMesesAnteriores.MESES_ANT_CON_FILTRO
      ElseIf rbMesesAnterioresSinFiltro.Checked Then
        m_Banco.ModoFiltrado = clsMaster.E_FiltroMesesAnteriores.MESES_ANT_SIN_FILTRO
      Else
        m_Banco.ModoFiltrado = clsMaster.E_FiltroMesesAnteriores.SOLO_MES_ACTUAL
        rbAplicaMesActual.Checked = True
      End If
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Sub chkEnableFrom_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableFrom.CheckedChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      pnlFiltrado.Enabled = chkEnableFrom.Checked
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub


  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_Result = Result.CANCEL
    End Try
  End Sub


  Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    Try
      If MsgBox("Desea exportar el registro actual?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub
      With m_Banco
        .RazonSocial = txtRazonSocial.Text
        .Producto = txtProducto.Text
        '.NroComercio = CDec(txtNroComercio.Text)
        .FechaPresentacion = dtCurrent.Value
        .FechaVencimiento = dtVencimiento.Value
      End With
      Dim vResult As Result
      vResult = m_Banco.GenerarExportacion(Me)

      If vResult = Result.OK Then
        Dim msgResult As MsgBoxResult = MsgBox("Desea abrir la carpeta del archivo exportado?", MsgBoxStyle.YesNo)
        If msgResult = MsgBoxResult.Yes Then
          Process.Start(m_Banco.GetFolderExportacion)
        End If
        m_Result = Result.OK
        Me.Close()
      End If



    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.ErrorEx
    End Try
  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try
      RecargarValores()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dtCurrent_ValueChanged(sender As Object, e As EventArgs) Handles dtCurrent.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Dim auxVen As Date = dtVencimiento.Value
      dtVencimiento.MinDate = dtCurrent.Value
      m_Banco.FechaPresentacion = dtCurrent.Value
      If auxVen <> dtVencimiento.Value Then
        Call clsCobros.ActualizarEstadosDePagos(dtVencimiento.Value)
        RecargarValores()
        m_Banco.UpdateFechaVencimientoExportar(dtVencimiento.Value)
        RefeshGrilla()
      End If
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub dtVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtVencimiento.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Call clsCobros.ActualizarEstadosDePagos(dtVencimiento.Value)
      RecargarValores()
      m_Banco.UpdateFechaVencimientoExportar(dtVencimiento.Value)
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub



  Private Sub txtNroCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroComercio.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
      End If
      If txtNroComercio.Text.Length >= 11 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtNroCUIT_TextChanged(sender As Object, e As EventArgs) Handles txtNroComercio.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not IsNumeric(txtNroComercio.Text.Trim) Then
        m_skip = False
        Exit Sub
      End If

      'If txtNumeroConvenio.Text.Length <= 0 Then txtNumeroConvenio.Text = 0
      'If txtNumeroConvenio.Text.Length > 5 Then txtNumeroConvenio.Text = txtNumeroConvenio.Text.Substring(0, 5)
      'm_Banco.NroCuitEmpresa = CDec(txtNroComercio.Text)
      'For Each registro In m_Banco.m_RegistrosExportar
      '  registro.NroCuitEmpresa = m_Banco.NroCuitEmpresa
      'Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      If txtReferencia.Text.Length >= 15 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.ReferenciaDebito = txtReferencia.Text
      For Each registro In m_Banco.m_RegistrosExportar
        registro.ReferenciaDebito = m_Banco.ReferenciaDebito
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub


  Private Sub RefeshGrilla()
    Try
      ClsInfoExportarMasterBindingSource.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If txtProducto.Text.Length >= 10 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.Producto = txtProducto.Text
      For Each registro In m_Banco.m_RegistrosExportar
        registro.Producto = m_Banco.Producto
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If txtRazonSocial.Text.Length >= 35 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.RazonSocial = txtRazonSocial.Text
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvResumen_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResumen.CellMouseUp
    Try
      If e.ColumnIndex = 0 Then
        Dim auxInfo As New clsInfoExportarMaster
        auxInfo = CType(dgvResumen.Rows(e.RowIndex).DataBoundItem, clsInfoExportarMaster)
        If auxInfo.EstadoContrato > 0 Then
          CType(dgvResumen.Rows(e.RowIndex).DataBoundItem, clsInfoExportarMaster).Exportar = False
        Else
          CType(dgvResumen.Rows(e.RowIndex).DataBoundItem, clsInfoExportarMaster).Exportar = Not CType(dgvResumen.Rows(e.RowIndex).DataBoundItem, clsInfoExportarMaster).Exportar
        End If
        ClsInfoExportarMasterBindingSource.ResetBindings(False)
        dgvResumen.Refresh()
        lblResumen.Text = String.Format("Total de registros: {0}/{1}", m_Banco.countRegistrosAExportar, m_Banco.countTotalRegistros)
        txtImporteTotal.Text = m_Banco.ImporteTotalAExportar.ToString
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvResumen_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResumen.ColumnHeaderMouseClick
    Try
      'If m_objDatabaseList Is Nothing Then Exit Sub
      Dim m_CurrentSortColumn As DataGridViewColumn = dgvResumen.Columns(e.ColumnIndex)
      If m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending Or m_CurrentSortColumn.HeaderCell.SortGlyphDirection = SortOrder.None Then
        For Each col As DataGridViewColumn In dgvResumen.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        ClsInfoExportarMasterBindingSource.DataSource = m_Banco.m_RegistrosExportar.OrderBy(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


        ClsInfoExportarMasterBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Ascending, Windows.Forms.SortOrder)
      Else
        For Each col As DataGridViewColumn In dgvResumen.Columns
          col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        ClsInfoExportarMasterBindingSource.DataSource = m_Banco.m_RegistrosExportar.OrderByDescending(Function(c) CStr(c.GetType.GetProperty(m_CurrentSortColumn.DataPropertyName).GetValue(c)), New clsComparar).ToList()


        ClsInfoExportarMasterBindingSource.ResetBindings(False)
        m_CurrentSortColumn.HeaderCell.SortGlyphDirection = CType(SortOrder.Descending, Windows.Forms.SortOrder)
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  'Private Sub dgvResumen_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvResumen.CurrentCellDirtyStateChanged
  '  Try
  '    dgvResumen.EndEdit()
  '    lblResumen.Text = String.Format("Total de registros: {0}/{1}", m_Banco.countRegistrosAExportar, m_Banco.countTotalRegistros)
  '    txtImporteTotal.Text = m_Banco.ImporteTotalAExportar.ToString
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub


  Private Sub dgvResumen_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResumen.SelectionChanged
    Try

      If dgvResumen.SelectedRows.Count <> 1 Then Exit Sub
      Call Refresh_Selection(dgvResumen.SelectedRows(0).Index)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        dgvResumen.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        Dim auxInfo As New clsInfoExportarMaster
        auxInfo = CType(dgvResumen.Rows(indice).DataBoundItem, clsInfoExportarMaster)
        cmbEstado.SelectedItem = CType(auxInfo.EstadoContrato, manDB.clsInfoProducto.E_Estado)

      End If
      If dgvResumen.Rows(indice).Selected <> True Then
        dgvResumen.Rows(indice).Selected = True
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub cmbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEstado.SelectionChangeCommitted
    Try
      If dgvResumen.SelectedRows.Count <> 1 Then Exit Sub
      If (dgvResumen.SelectedRows(0).Index >= 0) Then
        Dim auxInfo As New clsInfoExportarMaster
        auxInfo = CType(dgvResumen.Rows(dgvResumen.SelectedRows(0).Index).DataBoundItem, clsInfoExportarMaster)
        Dim indiceContrato As Integer = m_Banco.m_RegistrosExportar.FindIndex(Function(c) c.Contrato = auxInfo.Contrato)
        If indiceContrato >= 0 Then
          m_Banco.m_RegistrosExportar(indiceContrato).EstadoContrato = CInt(cmbEstado.SelectedItem)

          If m_Banco.m_RegistrosExportar(indiceContrato).EstadoContrato > 0 Then
            m_Banco.m_RegistrosExportar(indiceContrato).Exportar = False
            CType(dgvResumen.SelectedRows(0).Cells(0), DataGridViewCheckBoxCell).ReadOnly = True
          End If

          Dim auxProducto As New clsInfoProducto
          If clsProducto.Load(m_Banco.m_RegistrosExportar(indiceContrato).GuidProducto, auxProducto) = Result.OK Then
            auxProducto.Estado = m_Banco.m_RegistrosExportar(indiceContrato).EstadoContrato
            clsProducto.Save(auxProducto)
          Else
            MsgBox("No se puede guardar el cambio de Estado")
          End If
          ClsInfoExportarMasterBindingSource.ResetBindings(False)
          dgvResumen.Refresh()
        End If


      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class