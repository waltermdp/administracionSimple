Imports manDB
Imports libCommon.Comunes

Public Class frmArticulosVendidos

  Private m_lstArticulosVendidos As New List(Of clsInfoArticuloVendido)
  Private m_lstArticulos As New clsListArticulos
  Private m_result As Result = Result.CANCEL

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      m_result = Result.CANCEL
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    Try
      m_result = Result.OK
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetResult() As Result
    Try
      Return m_result
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Sub New(ByVal vListaArtVendidos As List(Of clsInfoArticuloVendido))
    ' This call is required by the designer.
    InitializeComponent()
    Try
      If Not (vListaArtVendidos Is Nothing) Then
        If vListaArtVendidos.Count > 0 Then
          m_lstArticulosVendidos.Clear()
          m_lstArticulosVendidos.AddRange(vListaArtVendidos.ToList)
        End If
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmArticulosVendidos_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      ListView1.View = View.Details
      ListView1.Columns(0).Width = CInt(0.5 * ListView1.Width)
      ListView1.Columns(1).Width = CInt(0.25 * ListView1.Width)
      ListView1.Columns(2).Width = CInt(0.25 * ListView1.Width)
      ListView1.ShowItemToolTips = True
      If m_lstArticulosVendidos.Count > 0 Then
        FillListArticulosVendidos(m_lstArticulosVendidos)
      End If

      If m_lstArticulos IsNot Nothing Then m_lstArticulos.Dispose()
      m_lstArticulos = New clsListArticulos()
      bsArticulos.DataSource = m_lstArticulos.Binding
      m_lstArticulos.RefreshData()
      bsArticulos.ResetBindings(False)
      txtBuscarArticulo.Select()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnAddArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddArticulo.MouseClick
    Try
      If lstArticulos.SelectedIndex < 0 Then Exit Sub
      Dim index As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = (CType(lstArticulos.SelectedItem, clsInfoArticulos).GuidArticulo))
      If index >= 0 Then
        m_lstArticulosVendidos(index).CantidadArticulos += 1
        m_lstArticulosVendidos(index).Entregados += 1
      Else
        Dim auxArticulo As New clsInfoArticuloVendido
        auxArticulo.copy(CType(lstArticulos.SelectedItem, clsInfoArticulos))
        auxArticulo.CantidadArticulos = 1
        auxArticulo.Entregados = 1
        m_lstArticulosVendidos.Add(auxArticulo)
      End If
      Call FillListArticulosVendidos(m_lstArticulosVendidos)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRemoveArticulo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemoveArticulo.MouseClick
    Try

      If ListView1.SelectedIndices.Count <= 0 Then Exit Sub

      Dim sGuid As Guid = New Guid(ListView1.SelectedItems.Item(0).SubItems(3).Text)
      Dim index As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = sGuid)

      If m_lstArticulosVendidos(index).CantidadArticulos > 1 Then
        m_lstArticulosVendidos(index).CantidadArticulos -= 1
        m_lstArticulosVendidos(index).Entregados -= 1
      Else
        m_lstArticulosVendidos.RemoveAt(index)
      End If
      Call FillListArticulosVendidos(m_lstArticulosVendidos)
      If m_lstArticulosVendidos.Exists(Function(c) c.GuidArticulo = sGuid) Then
        For Each item As ListViewItem In ListView1.Items
          Dim aGuid As Guid = New Guid(item.SubItems(3).Text)
          If aGuid = sGuid Then
            item.Selected = True
            ListView1.Select()
            Exit For
          End If
        Next
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtBuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarArticulo.TextChanged
    Try
      If txtBuscarArticulo.Text.Trim = "" Then
        m_lstArticulos.Cfg_Filtro = ""
      Else
        Dim str As String = txtBuscarArticulo.Text.Trim

        'str = str.Replace("'", "''")
        m_lstArticulos.Cfg_Filtro = "WHERE Nombre Like '%" & str & "%' OR Codigo Like '%" & str & "%'"
      End If
      m_lstArticulos.Items.Clear()
      Call m_lstArticulos.RefreshData()
      lstArticulos.DataSource = bsArticulos
      bsArticulos.ResetBindings(False)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ListView1_GotFocus(sender As Object, e As EventArgs) Handles ListView1.GotFocus
    Try
      If ListView1.SelectedItems.Count > 0 Then
        ListView1.SelectedItems.Item(0).BackColor = Color.White
        ListView1.SelectedItems.Item(0).ForeColor = Color.Black
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    Try

      If ListView1.SelectedItems.Count > 0 Then
        pnlCtrlEntregados.Visible = True
        pnlCtrlEntregados.Location = New Point(pnlCtrlEntregados.Location.X, ListView1.Location.Y + ListView1.SelectedItems.Item(0).Position.Y)
      Else
        pnlCtrlEntregados.Visible = False
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnUP_MouseClick(sender As Object, e As MouseEventArgs) Handles btnUP.MouseClick
    Try
      If ListView1.SelectedItems.Count > 0 Then
        Dim GuidArticulo As Guid = New Guid(ListView1.SelectedItems.Item(0).SubItems(3).Text)
        Dim indice As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = GuidArticulo)

        If m_lstArticulosVendidos(indice).Entregados < m_lstArticulosVendidos(indice).CantidadArticulos Then
          m_lstArticulosVendidos(indice).Entregados += 1
        Else
          m_lstArticulosVendidos(indice).Entregados = m_lstArticulosVendidos(indice).CantidadArticulos
        End If
        Call FillListArticulosVendidos(m_lstArticulosVendidos)

      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDown.MouseDown
    Try
      If ListView1.SelectedItems.Count > 0 Then
        Dim GuidArticulo As Guid = New Guid(ListView1.SelectedItems.Item(0).SubItems(3).Text)
        Dim indice As Integer = m_lstArticulosVendidos.FindIndex(Function(c) c.GuidArticulo = GuidArticulo)

        If m_lstArticulosVendidos(indice).Entregados > 0 Then
          m_lstArticulosVendidos(indice).Entregados -= 1
        Else
          m_lstArticulosVendidos(indice).Entregados = 0
        End If
        Call FillListArticulosVendidos(m_lstArticulosVendidos)

      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ListView1_LostFocus(sender As Object, e As EventArgs) Handles ListView1.LostFocus
    Try

      If ListView1.SelectedItems.Count > 0 Then
        ListView1.SelectedItems.Item(0).BackColor = SystemColors.Highlight
        ListView1.SelectedItems.Item(0).ForeColor = Color.White
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillListArticulos()
    Try
      If m_lstArticulos IsNot Nothing Then m_lstArticulos.Dispose()

      m_lstArticulos = New clsListArticulos()
      bsArticulos.DataSource = m_lstArticulos.Binding
      m_lstArticulos.RefreshData()
      bsArticulos.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetLstArtVendidos(ByRef rLstArtVendidos As List(Of clsInfoArticuloVendido)) As Result
    Try
      If m_lstArticulosVendidos Is Nothing Then Return Result.NOK
      If m_lstArticulosVendidos.Count <= 0 Then Return Result.NOK
      If rLstArtVendidos Is Nothing Then
        rLstArtVendidos = New List(Of clsInfoArticuloVendido)
      End If
      rLstArtVendidos.Clear()
      rLstArtVendidos.AddRange(m_lstArticulosVendidos.ToList)
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub FillListArticulosVendidos(ByVal lstArticulosVendidos As List(Of clsInfoArticuloVendido))
    Try
      ListView1.Items.Clear()
      pnlCtrlEntregados.Visible = False
      For Each articulo In lstArticulosVendidos
        Dim item As New ListViewItem

        item.Text = articulo.ToString
        item.SubItems.Add(articulo.CantidadArticulos.ToString)
        item.SubItems.Add(articulo.Entregados.ToString)
        item.SubItems.Add(articulo.GuidArticulo.ToString)
        ListView1.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private m_index As Integer = -1

  Private Sub lstArticulos_MouseMove1(sender As Object, e As MouseEventArgs) Handles lstArticulos.MouseMove
    Try

      Dim index As Integer = lstArticulos.IndexFromPoint(e.Location)
      If m_index = index Then Exit Sub
      If index < 0 Then Exit Sub
      m_index = index
      Dim itemOver As clsInfoArticulos = CType(lstArticulos.Items(index), clsInfoArticulos)
      If itemOver.ToString.Length <= 30 Then
        tTip.RemoveAll()
        Exit Sub
      End If

      tTip.SetToolTip(lstArticulos, itemOver.ToString)



    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



End Class