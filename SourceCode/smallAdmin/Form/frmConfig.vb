Imports libCommon.Comunes
Public Class frmConfig
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"
  Private m_listGrupos As clsListGrupos = Nothing

  Private Sub btnBack_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBack.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnActualizarPagos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnActualizarPagos.MouseClick
    Try
      'Marcar los pagos vencidos como Vencidos y crear un nuevo talon de pago
      Dim vResult As libCommon.Comunes.Result
      Dim lstPago As New List(Of manDB.clsInfoPagos)
      Dim aux As New clsListPagos
      aux.Cfg_Filtro = "where (Pagos.VencimientoCuota < #" & Format(GetHoy, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
      aux.RefreshData()
      lstPago.AddRange(aux.Items)
      For Each item In aux.Items
        item.EstadoPago = E_EstadoPago.Vencido
        vResult = clsPago.Save(item)
        If vResult <> Result.OK Then
          MsgBox("Fallo update pago")
          Exit Sub
        End If
        Dim objProducto As New manDB.clsInfoProducto
        vResult = clsProducto.Load(item.GuidProducto, objProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo load producto")
          Exit Sub
        End If
        Dim newpago As manDB.clsInfoPagos = GetProximoPago(item.GuidProducto, CInt(objProducto.Adelanto), objProducto.ValorCuotaFija, item.NumCuota, objProducto.FechaVenta, objProducto.FechaPrimerPago)
        If newpago IsNot Nothing Then
          vResult = clsPago.Save(newpago)
        Else
          MsgBox("Fallo guardar newpago")
        End If
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub CargarGrupos()
    Try
      m_listGrupos = New clsListGrupos

      bsGrupos.DataSource = m_listGrupos.Binding
      m_listGrupos.RefreshData()
      bsGrupos.ResetBindings(False)

      Dim j As Integer = 0
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarCategorias()
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNewCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNewCategoria.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemCategoria.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnNewGroup_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNewGroup.MouseClick
    Try
      Dim nGrupo As New manDB.clsInfoGrupo
      If txtInGrupo.Text.Trim Is String.Empty Then
        MsgBox("Nombre invalido")
        Exit Sub
      End If
      If clsGrupo.Find(New manDB.clsInfoGrupo With {.Nombre = txtInGrupo.Text}) = Result.OK Then
        MsgBox("El nombre ya existe, debe modificarlo")
        Exit Sub
      End If
      nGrupo.Nombre = txtInGrupo.Text.Trim
      nGrupo.GuidGrupo = Guid.NewGuid
      If clsGrupo.Save(nGrupo) <> Result.OK Then
        MsgBox("No se pudo guardar el grupo")
        Exit Sub
      End If
      Call CargarGrupos()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemGroup_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemGroup.MouseClick
    Try
      If lstGrupo.SelectedIndex < 0 Then Exit Sub
      Dim aux As manDB.clsInfoGrupo = CType(lstGrupo.SelectedItem, manDB.clsInfoGrupo)
      If clsGrupo.Utilizado(aux) = Result.OK Then
        MsgBox("El grupo esta en uso, debe desasociar a los vendedores del grupo antes de eliminarlo")
        Exit Sub
      End If
      If clsGrupo.Delete(aux.GuidGrupo) <> Result.OK Then
        MsgBox("No se pudo eliminar el grupo")
        Exit Sub
      End If
      Call CargarGrupos()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call CargarGrupos()
      Call CargarCategorias()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private m_ModosPagos As New List(Of manDB.clsTipoPago)

  Private Sub btnTipoPagos_Click(sender As Object, e As EventArgs) Handles btnLoadTipoPagos.Click
    Try
      m_ModosPagos.Clear()
      CargarTipoPago(m_ModosPagos)
      cmbModosPagos.DataSource = m_ModosPagos


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub cmbModosPagos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModosPagos.SelectedIndexChanged
    Try

      Dim objSeleccionado As manDB.clsTipoPago = TryCast(cmbModosPagos.SelectedItem, manDB.clsTipoPago)
      If objSeleccionado Is Nothing Then Exit Sub
      txtNombre.Text = objSeleccionado.Nombre
      txtCodigo1.Text = objSeleccionado.NombreCodigo1
      txtCodigo2.Text = objSeleccionado.NombreCodigo2
      txtCodigo3.Text = objSeleccionado.NombreCodigo3
      txtCodigo4.Text = objSeleccionado.NombreCodigo4
      If objSeleccionado.PermiteCuotas Then
        rbtnSi.Checked = True
      Else
        rbtnNo.Checked = True
      End If
      txtGUID.Text = objSeleccionado.GuidTipo.ToString
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  
  Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
    Try
      m_ModosPagos(cmbModosPagos.SelectedIndex).Nombre = txtNombre.Text
      m_ModosPagos(cmbModosPagos.SelectedIndex).NombreCodigo1 = txtCodigo1.Text
      m_ModosPagos(cmbModosPagos.SelectedIndex).NombreCodigo2 = txtCodigo2.Text
      m_ModosPagos(cmbModosPagos.SelectedIndex).NombreCodigo3 = txtCodigo3.Text
      m_ModosPagos(cmbModosPagos.SelectedIndex).NombreCodigo4 = txtCodigo4.Text
      m_ModosPagos(cmbModosPagos.SelectedIndex).GuidTipo = New Guid(txtGUID.Text)
      m_ModosPagos(cmbModosPagos.SelectedIndex).PermiteCuotas = rbtnSi.Checked
      GuardarTipoPago(m_ModosPagos)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardarComoNuevo_Click(sender As Object, e As EventArgs) Handles btnGuardarComoNuevo.Click
    Try
      Dim NewModo As New manDB.clsTipoPago

      NewModo.Nombre = txtNombre.Text
      NewModo.NombreCodigo1 = txtCodigo1.Text
      NewModo.NombreCodigo2 = txtCodigo2.Text
      NewModo.NombreCodigo3 = txtCodigo3.Text
      NewModo.NombreCodigo4 = txtCodigo4.Text
      NewModo.GuidTipo = Guid.NewGuid
      NewModo.PermiteCuotas = rbtnSi.Checked
      m_ModosPagos.Add(NewModo)
      If GuardarTipoPago(m_ModosPagos) = Result.OK Then
        MsgBox("Realizado OK")
      Else
        MsgBox("Fallo al guardar")
      End If
      btnLoadTipoPagos.PerformClick()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class