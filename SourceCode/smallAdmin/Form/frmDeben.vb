Imports libCommon.Comunes
Public Class frmDeben

  Private WithEvents m_objProductoList As clsListProductos = Nothing

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmDeben_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

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
 

  Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class