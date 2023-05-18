Imports manDB
Imports libCommon.Comunes

Public Class clsDDPatagonia

  Private m_tipoPago As clsTipoPago = Nothing
  Public Sub New(ByVal vInfoPago As clsTipoPago)
    Try
      m_tipoPago = vInfoPago.Clone
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
