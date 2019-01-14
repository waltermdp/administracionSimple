Public Class clsInfoMovimiento

  Private m_NumeroTarjeta As String
  Private m_NumeroComprobante As String
  Private m_Fecha As String
  Private m_Importe As String
  Private m_IdentificadorDebito As String
  Private m_param1 As String
  Private m_param2 As String
  Private m_Codigo As String
  Private m_Detalle As String

  Public Property NumeroTarjeta As String
    Get
      Return m_NumeroTarjeta
    End Get
    Set(value As String)
      m_NumeroTarjeta = value
    End Set
  End Property

  Public Property NumeroComprobante As String
    Get
      Return m_NumeroComprobante
    End Get
    Set(value As String)
      m_NumeroComprobante = value
    End Set
  End Property

  Public Property Fecha As String
    Get
      Return m_Fecha
    End Get
    Set(value As String)
      m_Fecha = value
    End Set
  End Property

  Public Property Importe As String
    Get
      Return m_Importe
    End Get
    Set(value As String)
      m_Importe = value
    End Set
  End Property

  Public Property IdentificadorDebito As String
    Get
      Return m_IdentificadorDebito
    End Get
    Set(value As String)
      m_IdentificadorDebito = value
    End Set
  End Property

  Public Property Param1 As String
    Get
      Return m_param1
    End Get
    Set(value As String)
      m_param1 = value
    End Set
  End Property
  Public Property Param2 As String
    Get
      Return m_param2
    End Get
    Set(value As String)
      m_param2 = value
    End Set
  End Property

  Public Property Codigo As String
    Get
      Return m_Codigo
    End Get
    Set(value As String)
      m_Codigo = value
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


  Public Sub New()
    MyBase.New()
    NumeroTarjeta = String.Empty
    NumeroComprobante = String.Empty
    Fecha = String.Empty
    Importe = String.Empty
    IdentificadorDebito = String.Empty
    Param1 = String.Empty
    Param2 = String.Empty
    Codigo = String.Empty
    Detalle = String.Empty

  End Sub
End Class
