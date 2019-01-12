Imports libCommon.Comunes
Imports System.ComponentModel
Public Class frmArticulos
  Private WithEvents m_objArticulosList As clsListArticulos = Nothing
  Private WithEvents m_ObjListaStock As clsListStock = Nothing
  Private m_objStock As BindingList(Of clsListaStorage)
  Private m_ObjCurrent As clsListaStorage
  Private m_listResponsables As New List(Of clsInfoResponsable)
  Private m_Skip As Boolean = False
  Private m_Deposito As New clsInfoResponsable With {.Nombre = "Deposito", .GuidResponsable = New Guid("7b841601-2cd4-4e0e-b75b-b3a072b58eb1"), .Codigo = "0000"}

  Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Call AllowEditNew(False)
      cmbResponsables.Enabled = False
      For Each column As DataGridViewColumn In dgvStock.Columns
        If column.DataPropertyName = "Responsable" Then
          column.Visible = False
        End If
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarListaArticulos()
      Call FillResponsables()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarListaArticulos()
    Try


      If m_objArticulosList IsNot Nothing Then m_objArticulosList.Dispose()
      If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
      m_objArticulosList = New clsListArticulos()
      m_ObjListaStock = New clsListStock
      bsArticulos.DataSource = m_objArticulosList.Binding

      Call ArticulosList_RefreshData()
      Call ListaStock_RefreshData()
      'ya tengo las dos lista actualizadas


      Dim auxArticulo As clsListaStorage
      m_objStock = New BindingList(Of clsListaStorage)
      BindingSource1.DataSource = m_objStock
      dgvStock.DataSource = BindingSource1

      For Each item In m_objArticulosList.Items
        auxArticulo = New clsListaStorage
        auxArticulo.GuidArticulo = item.GuidArticulo
        auxArticulo.Nombre = item.Nombre
        auxArticulo.Codigo = item.Codigo
        auxArticulo.Descripcion = item.Descripcion

        If rbtnByStock.Checked Then
          For Each elemento In m_ObjListaStock.Items
            If elemento.GuidArticulo = item.GuidArticulo Then
              auxArticulo.Cantidad += elemento.Cantidad
            End If
          Next
          auxArticulo.GuidResponsable = m_Deposito.GuidResponsable
          m_objStock.Add(auxArticulo)
        Else
          For Each elemento In m_ObjListaStock.Items
            If elemento.GuidArticulo = item.GuidArticulo Then
              auxArticulo.Cantidad = elemento.Cantidad
              auxArticulo.Responsable = elemento.Responsable
              auxArticulo.GuidResponsable = elemento.GuidResponsable
              Dim art As New clsListaStorage
              art = auxArticulo.Clone
              m_objStock.Add(art)
            End If
          Next
        End If


      Next

      BindingSource1.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally

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

  Private Sub ListaStock_RefreshData()
    Try
      m_ObjListaStock.RefreshData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub dgvListArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListArticulos.SelectionChanged
  '  Try
  '    If dgvListArticulos.SelectedRows.Count <> 1 Then Exit Sub

  '    Call Refresh_Selection(dgvListArticulos.SelectedRows(0).Index)

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If m_Skip Then Exit Sub
      If indice < 0 Then
        dgvStock.ClearSelection()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_ObjCurrent = CType(dgvStock.Rows(indice).DataBoundItem, clsListaStorage)
        If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable <> m_Deposito.GuidResponsable Then
          cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_ObjCurrent.GuidResponsable)
        End If
        If rbtnResponsables.Checked = True AndAlso m_ObjCurrent.GuidResponsable = m_Deposito.GuidResponsable AndAlso m_ObjCurrent.Cantidad = 0 Then
          cmbResponsables.SelectedItem = m_listResponsables.First(Function(c) c.GuidResponsable = m_Deposito.GuidResponsable)
        End If
      End If
      If dgvStock.Rows(indice).Selected <> True Then
        dgvStock.Rows(indice).Selected = True
      End If

      Call FillArticuloData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvStock_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStock.SelectionChanged
    Try
      'If m_Skip Then Exit Sub
      If dgvStock.SelectedRows.Count <> 1 Then Exit Sub

      Call Refresh_Selection(dgvStock.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEditar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then
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
      m_ObjCurrent = New clsListaStorage
      m_ObjCurrent.GuidArticulo = Guid.NewGuid
      Call FillArticuloData()
      Call AllowEditNew(True)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnEliminar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseClick
    Try
      Exit Sub
      If m_ObjCurrent Is Nothing Then
        MsgBox("Debe seleccionar un articulo de la lista")
        Exit Sub
      End If
      'If clsArticulo.Delete(m_objArticuloCurrent.GuidArticulo) <> Result.OK Then
      '  MsgBox("No se pudo eliminar el articulo seleccionado.")
      'End If
      m_ObjCurrent = Nothing
      Call Refresh_Selection(-1)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      Call CargarData()
      Dim aux As New manDB.clsInfoArticulos
      aux.GuidArticulo = m_ObjCurrent.GuidArticulo
      aux.Nombre = m_ObjCurrent.Nombre
      aux.Codigo = m_ObjCurrent.Codigo
      aux.Descripcion = m_ObjCurrent.Descripcion
      If clsArticulo.Save(aux) <> Result.OK Then
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
      With m_ObjCurrent
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
      If m_ObjCurrent Is Nothing Then Exit Sub
      With m_ObjCurrent
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

  


  Private Sub rbtnResponsables_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnResponsables.CheckedChanged
    Try
      cmbResponsables.Enabled = rbtnResponsables.Checked
      If rbtnResponsables.Checked = False Then
        cmbResponsables.SelectedIndex = 0
      End If
      For Each column As DataGridViewColumn In dgvStock.Columns
        If column.DataPropertyName = "Responsable" Then
          column.Visible = rbtnResponsables.Checked
        End If
      Next

      Call MostrarListaArticulos()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillResponsables()
    Try
      m_listResponsables.Clear()
      Dim objlistVendedores As clsListVendedores = New clsListVendedores()
      objlistVendedores.RefreshData()
      m_listResponsables.Add(m_Deposito)
      For Each vendedor In objlistVendedores.Items
        m_listResponsables.Add(New clsInfoResponsable() With {.Nombre = vendedor.ToString, .GuidResponsable = vendedor.GuidVendedor, .Codigo = vendedor.NumVendedor})
      Next
      cmbResponsables.DataSource = m_listResponsables
      'TODO: llenar la lista
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnAddDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddDeposito.MouseClick
    Try

      If m_ObjCurrent Is Nothing Then Exit Sub
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidResponsable.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then
          'existe en deposito
          Dim GuidResponsable As Guid
          Dim Responsable As String
          If rbtnByStock.Checked = True Then
            GuidResponsable = m_Deposito.GuidResponsable
            Responsable = m_Deposito.Codigo
          Else
            If cmbResponsables.SelectedIndex < 0 Then Exit Sub
            GuidResponsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).GuidResponsable
            Responsable = CType(cmbResponsables.SelectedItem, clsInfoResponsable).ToString
          End If

          Dim ArticuloDelDeposito As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          Dim ArticuloDelResponsable As manDB.clsInfoStock
          If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
          m_ObjListaStock = New clsListStock
          m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "}"
          m_ObjListaStock.RefreshData()
          If m_ObjListaStock.Items.Count > 0 Then
            'ya tenia articulos
            ArticuloDelResponsable = m_ObjListaStock.Items.First.Clone

          Else
            'no tenia este articulo
            ArticuloDelResponsable = New manDB.clsInfoStock
            ArticuloDelResponsable.GuidArticulo = m_ObjCurrent.GuidArticulo
            ArticuloDelResponsable.GuidResponsable = GuidResponsable
            ArticuloDelResponsable.Responsable = Responsable
            ArticuloDelResponsable.Cantidad = 0

          End If
          If GuidResponsable <> m_Deposito.GuidResponsable Then
            ArticuloDelDeposito.Cantidad -= 1
          End If

          ArticuloDelResponsable.Cantidad += 1
          clsStock.Save(ArticuloDelDeposito)
          clsStock.Save(ArticuloDelResponsable)
        Else
          'No existe en deposito
          If m_ObjCurrent.GuidResponsable = m_Deposito.GuidResponsable Then


            Dim ArticuloNuevoEnStock As New manDB.clsInfoStock
            ArticuloNuevoEnStock.GuidArticulo = m_ObjCurrent.GuidArticulo
            ArticuloNuevoEnStock.Responsable = m_Deposito.ToString
            ArticuloNuevoEnStock.GuidResponsable = m_Deposito.GuidResponsable
            ArticuloNuevoEnStock.Cantidad = 1
            clsStock.Save(ArticuloNuevoEnStock)
          End If
        End If


        m_Skip = True
        Call MostrarListaArticulos()
        m_Skip = False
      Finally
        Refresh_Selection(objSelectedIndex)
      End Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemDeposito_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemDeposito.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        Dim GuidResponsable As Guid
        Dim Responsable As String
        If rbtnByStock.Checked = True Then
          GuidResponsable = m_Deposito.GuidResponsable
          Responsable = m_Deposito.ToString
        Else
          GuidResponsable = m_ObjCurrent.GuidResponsable
          Responsable = m_ObjCurrent.Responsable
        End If
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then
          'El responsable tiene objetos
          Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          Dim ArticuloDelDeposito As manDB.clsInfoStock

          'Cargo el articulo del deposito
          m_ObjListaStock = New clsListStock
          m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & ArticuloDelResponsable.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidResponsable.ToString & "}"
          m_ObjListaStock.RefreshData()
          If m_ObjListaStock.Items.Count > 0 Then
            ArticuloDelDeposito = m_ObjListaStock.Items.First.Clone
          Else
            MsgBox("No estaba en stock")
            Exit Sub
          End If

          If GuidResponsable <> m_Deposito.GuidResponsable Then
            'mover a deposito
            ArticuloDelDeposito.Cantidad += 1
          End If

          ArticuloDelResponsable.Cantidad -= 1
          clsStock.Save(ArticuloDelDeposito)
          clsStock.Save(ArticuloDelResponsable)

        End If



        Call MostrarListaArticulos()
      Finally
        Refresh_Selection(objSelectedIndex)
      End Try
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnVendido_MouseClick(sender As Object, e As MouseEventArgs) Handles btnVendido.MouseClick
    Try
      If m_ObjCurrent Is Nothing Then Exit Sub
      Dim objSelectedIndex As Integer = dgvStock.SelectedRows(0).Index
      Try


        If m_ObjListaStock IsNot Nothing Then m_ObjListaStock.Dispose()
        m_ObjListaStock = New clsListStock
        Dim GuidResponsable As Guid
        Dim Responsable As String
        If rbtnByStock.Checked = True Then
          GuidResponsable = m_Deposito.GuidResponsable
          Responsable = m_Deposito.ToString
        Else
          GuidResponsable = m_ObjCurrent.GuidResponsable
          Responsable = m_ObjCurrent.Responsable
        End If
        m_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & m_ObjCurrent.GuidArticulo.ToString & "} and GuidResponsable={" & GuidResponsable.ToString & "} and Cantidad > 0"
        m_ObjListaStock.RefreshData()

        If m_ObjListaStock.Items.Count > 0 Then
          'El responsable tiene objetos
          Dim ArticuloDelResponsable As manDB.clsInfoStock = m_ObjListaStock.Items.First.Clone
          'Dim ArticuloDelDeposito As manDB.clsInfoStock

          'Cargo el articulo del deposito
          'm_ObjListaStock = New clsListStock
          'm_ObjListaStock.Cfg_Filtro = "where GuidArticulo={" & ArticuloDelResponsable.GuidArticulo.ToString & "} and GuidResponsable={" & m_Deposito.GuidResponsable.ToString & "}"
          'm_ObjListaStock.RefreshData()
          'If m_ObjListaStock.Items.Count > 0 Then
          '  ArticuloDelDeposito = m_ObjListaStock.Items.First.Clone
          'Else
          '  MsgBox("No estaba en stock")
          '  Exit Sub
          'End If

          'If GuidResponsable <> m_Deposito.GuidResponsable Then
          'mover a deposito
          '  ArticuloDelDeposito.Cantidad += 1
          'End If

          ArticuloDelResponsable.Cantidad -= 1
          'clsStock.Save(ArticuloDelDeposito)
          clsStock.Save(ArticuloDelResponsable)

        End If



        Call MostrarListaArticulos()
      Finally
        Refresh_Selection(objSelectedIndex)
      End Try
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class