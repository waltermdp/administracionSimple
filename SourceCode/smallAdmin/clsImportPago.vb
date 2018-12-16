Imports libCommon.Comunes
Public Class clsImportPago

  Private m_CBU As Integer
  Private m_Detalle As String
  Private m_ValorPago As Decimal
  Private m_Estado As Boolean

  Public Property CBU As Integer
    Get
      Return m_CBU
    End Get
    Set(value As Integer)
      m_CBU = value
    End Set
  End Property

  Public Property Detalle As String
    Get
      Return m_Detalle
    End Get
    Set(value As String)
      m_Detalle = value
    End Set
  End Property

  Public Property valorPago As Decimal
    Get
      Return m_ValorPago
    End Get
    Set(value As Decimal)
      m_ValorPago = value
    End Set
  End Property

  Public Property Estado As Boolean
    Get
      Return m_Estado
    End Get
    Set(value As Boolean)
      m_Estado = value
    End Set
  End Property

  Public Sub New()
    Try
      m_CBU = 0
      m_Detalle = String.Empty
      m_ValorPago = 0
      m_Estado = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


End Class
