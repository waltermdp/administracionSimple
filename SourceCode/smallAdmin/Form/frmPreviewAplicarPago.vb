Imports libCommon.Comunes
Imports manDB

Public Class frmPreviewAplicarPago

  Private m_listPagos As New List(Of clsImportPago)
  Private m_tipoPago As clsTipoPago

  Public Sub New(ByVal vTipo As clsTipoPago)
    Try
      InitializeComponent()
      m_tipoPago = vTipo

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmPreviewAplicarPago_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      lblTipo.Text = m_tipoPago.ToString
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmPreviewAplicarPago_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Dim selectfile As New OpenFileDialog
      If selectfile.ShowDialog = Windows.Forms.DialogResult.OK Then
        Dim pathFile As String = selectfile.FileName
        If LoadFromFile(pathFile, m_listPagos) = Result.OK Then
          'cargar los pagos/acciones a realizarse
          Exit Sub
        End If
      End If
      MsgBox("No se puede cargar el archivo")
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Function LoadFromFile(ByVal pathfile As String, ByRef rPagos As List(Of clsImportPago)) As Result
    Try
      'leer el archivo y le convierte en un lista de la clase importpago
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub MostrarAcciones(ByVal listaPagos As List(Of clsImportPago))
    Try
      'mostrar en forma coloquial y lista las acciones que se van a realizar, informar de errores o atenciones etc
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function AplicarAccion(ByVal listPagos As List(Of clsImportPago)) As Result
    Try
      'bucar en la base de datos los pagos
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub btnAplicar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAplicar.MouseClick
    Try
      If AplicarAccion(m_listPagos) = Result.OK Then
        Me.Close()
        Exit Sub
      End If
      MsgBox("No se pudo aplicar la lista de pagos")
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class