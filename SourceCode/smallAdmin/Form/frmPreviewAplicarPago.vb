Imports libCommon.Comunes
Imports manDB

Public Class frmPreviewAplicarPago

  Private m_listPagos As New List(Of clsImportPago)
  Private m_tipoPago As clsTipoPago

  Public Sub New(ByVal vPathfile As String, ByVal vTipo As clsTipoPago)
    Try
      InitializeComponent()
      m_tipoPago = vTipo

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmPreviewAplicarPago_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Function LoadFromFile(ByRef rPagos As List(Of clsImportPago)) As Result
    Try

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



End Class