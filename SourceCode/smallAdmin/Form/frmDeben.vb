Imports libCommon.Comunes
Imports manDB

Public Class frmDeben

  Private WithEvents m_objPrincipal As clsListaPrincipal = Nothing
  Private m_CurrentProducto As clsInfoPrincipal = Nothing
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    Try
      If MsgBox("Desea salir del programa?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        Me.Close()
      End If

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

      dateInicio.Value = New Date(Date.Today.Year, Today.Month, 1)
      dateFin.Value = New Date(Date.Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))
      rbtnVendidos.Checked = True
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
      If m_objPrincipal IsNot Nothing Then m_objPrincipal.Dispose()

      m_objPrincipal = New clsListaPrincipal()
      Call Filtro("")

      bsInfoPrincipal.DataSource = m_objPrincipal.Binding
      Call ProductList_RefreshData()



      bsInfoPrincipal.ResetBindings(False)
     
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Filtro(ByVal modo As String) As Result
    Try
      'strFiltro = "Pac.Fecha between #" & Format(m_dFiltroFechaDesde, strFormatoAnsiStdFecha) & "# and #" & Format(m_dFiltroFechaHasta, strFormatoAnsiStdFecha) & "#"
      If rbtnVendidos.Checked = True Then
        m_objPrincipal.Cfg_Filtro = "where Productos.FechaVenta between #" & Format(dateInicio.Value, strFormatoAnsiStdFecha) & "# and #" & Format(dateFin.Value, strFormatoAnsiStdFecha) & "#"
        m_objPrincipal.Deben = "0"
      ElseIf rbtnDeben.Checked Then
        m_objPrincipal.Cfg_Filtro = ""
        m_objPrincipal.Deben = "1"
      ElseIf rbtnPagados.Checked Then
        m_objPrincipal.Cfg_Filtro = ""
        m_objPrincipal.Deben = "2"
      ElseIf rbtnCuotaPagaron.Checked Then
        m_objPrincipal.Cfg_Filtro = ""
        m_objPrincipal.Deben = "3"
      End If

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
  Private Sub ProductList_RefreshData()
    Try
      m_objPrincipal.RefreshData()

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
        m_CurrentProducto = CType(dgvData.Rows(indice).DataBoundItem, manDB.clsInfoPrincipal)

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

  Private Sub btnLstVendedores_Click(sender As Object, e As EventArgs) Handles btnLstVendedores.Click
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

      Using objVenta As New frmVenta()
        objVenta.ShowDialog()
        If objVenta.HayCambios Then

        End If
      End Using
      Call MostrarDeben()
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
      Dim auxProducto As New clsInfoProducto
      Dim vResult As Result = clsProducto.Load(m_CurrentProducto.GuidProducto, auxProducto)
      If vResult <> Result.OK Then
        MsgBox("Falla al cargar el producto seleccionado")
      End If
      Using objForm As New frmVenta(auxProducto)
        objForm.ShowDialog()
      End Using
      Call MostrarDeben()
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



  Private Sub btnUpPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnUpPago.MouseClick
    Try
      Dim vResult As Result
      If m_CurrentProducto Is Nothing Then Exit Sub
      If m_CurrentProducto.CuotasTotales > 0 AndAlso m_CurrentProducto.CuotasPagas >= m_CurrentProducto.CuotasTotales Then Exit Sub
      Dim lstPagos As New List(Of manDB.clsInfoPagos)
      vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar pagos")
        Exit Sub
      End If
      If Not DebePeriodoActual(lstPagos) Then Exit Sub
      'collectar la informacion a mostrar antes de aplicar el pago elgido
      Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
                                        "Nombre: {0}" & vbNewLine & _
                                        "DNI: {1}" & vbNewLine & _
                                        "Metodo Pago: {2}" & vbNewLine & _
                                        "Numero: {3}" & vbNewLine & _
                                        "Valor Cuota: {4}" & vbNewLine & _
                                         "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.NombreCliente, m_CurrentProducto.DNI, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.NumPago, m_CurrentProducto.ValorCuota, Today)
      Dim rsta As MsgBoxResult = MsgBox(msg, MsgBoxStyle.YesNo)

      If rsta = MsgBoxResult.Yes Then

        'Dim lstPagos As New List(Of manDB.clsInfoPagos)
        vResult = clsPago.Load(lstPagos, m_CurrentProducto.GuidProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo cargar pagos")
          Exit Sub
        End If

        Dim auxPago As clsInfoPagos = Nothing
        For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota)
          If pago.EstadoPago = modCommon.E_EstadoPago.Debe Then

            pago.EstadoPago = modCommon.E_EstadoPago.Pago
            pago.FechaPago = Date.Now
            vResult = clsPago.Save(pago)
            If vResult <> Result.OK Then
              MsgBox("Fallo guardar pagos")
              Exit Sub
            End If

            If (m_CurrentProducto.CuotasPagas + 1) < m_CurrentProducto.CuotasTotales Then
              auxPago = GetProximoPago(m_CurrentProducto.GuidProducto, pago.ValorCuota, pago.NumCuota + 1, m_CurrentProducto.FechaVenta, pago.VencimientoCuota)
            End If
            If auxPago IsNot Nothing Then
              vResult = clsPago.Save(auxPago)
              If vResult <> Result.OK Then
                MsgBox("Fallo guardar nuevo pago")
                Exit Sub
              End If
            End If
            Exit For
          End If
        Next



        Call MostrarDeben()


      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnDownPago_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDownPago.MouseClick
    Try
      If m_CurrentProducto Is Nothing Then Exit Sub
      'If m_CurrentProducto.CuotasDebe >= m_CurrentProducto.TotalCuotas Then Exit Sub

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnBuscar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseClick
    Try
      Call MostrarDeben()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnConfiguracion_MouseClick(sender As Object, e As MouseEventArgs) Handles btnConfiguracion.MouseClick
    Try
      Using objform As New frmConfig
        objform.ShowDialog(Me)
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class