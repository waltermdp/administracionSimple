Public Class clsInfoHipotecario

  Private m_CBU As String
  Private m_NumeroComprobante As Integer
  Private m_FechaVencimiento As Date
  Private m_IdentificadorDebito As String
  Private m_Importe As Decimal
  Private m_CodigoBanco As Decimal
  Private m_CodigoSucCuenta As Integer
  Private m_TipoCuenta As String
  Private m_CuentaBanco As Decimal

  Private m_Nombre As String
  Private m_CuotaActual As Integer
  Private m_UltimaFechaPago As Date



  Public Property CBU As String
    Get
      Return m_CBU
    End Get
    Set(value As String)
      m_CBU = value
    End Set
  End Property

  Public Property NumeroComprobante As Integer
    Get
      Return m_NumeroComprobante
    End Get
    Set(value As Integer)
      m_NumeroComprobante = value
    End Set
  End Property

  Public Property FechaVencimiento As Date
    Get
      Return m_FechaVencimiento
    End Get
    Set(value As Date)
      m_FechaVencimiento = value
    End Set
  End Property

  Public Property Importe As Decimal
    Get
      Return m_Importe
    End Get
    Set(value As Decimal)
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

  Public Property CodigoBanco As Integer
    Get
      Return m_CodigoBanco
    End Get
    Set(value As Integer)
      m_CodigoBanco = value
    End Set
  End Property

  Public Property CodigoSucCuenta As Integer
    Get
      Return m_CodigoSucCuenta
    End Get
    Set(value As Integer)
      m_CodigoSucCuenta = value
    End Set
  End Property
  Public Property TipoCuenta As String
    Get
      Return m_TipoCuenta
    End Get
    Set(value As String)
      m_TipoCuenta = value
    End Set
  End Property
  Public Property CuentaBanco As Decimal
    Get
      Return m_CuentaBanco
    End Get
    Set(value As Decimal)
      m_CuentaBanco = value
    End Set
  End Property

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
    End Set
  End Property

  Public Property CuotaActual As Integer
    Get
      Return m_CuotaActual
    End Get
    Set(value As Integer)
      m_CuotaActual = value
    End Set
  End Property



  Public Sub New()
    MyBase.New()
    CBU = ""
    NumeroComprobante = "0"
    FechaVencimiento = Date.MinValue
    Importe = 0
    IdentificadorDebito = "0"
    CodigoBanco = 0
    CodigoSucCuenta = 0
    TipoCuenta = " "
    CuentaBanco = 0
    m_Nombre = String.Empty
    m_CuotaActual = 0

  End Sub

End Class
