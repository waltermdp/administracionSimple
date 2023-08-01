Public Class clsInfoExportarHipotecario

  Private m_CBU As String
  Private m_NumeroComprobante As Integer
  Private m_FechaVencimiento As Date
  Private m_IdCliente As String
  Private m_Importe As Decimal
  Private m_CodigoBanco As Decimal
  Private m_CodigoSucCuenta As Integer
  Private m_TipoCuenta As String
  Private m_CuentaBanco As Decimal

  Private m_Nombre As String
  Private m_CuotaActual As Integer
  Private m_UltimaFechaPago As Date
  Private m_exportar As Boolean
  Private m_EstadoContrato As Integer
  Private m_FechaUltimaExportacion As Date
  Private m_GuidPago As Guid
  Private m_GuidProducto As Guid


  Public Property GuidPago As Guid
    Get
      Return m_GuidPago
    End Get
    Set(value As Guid)
      m_GuidPago = value
    End Set
  End Property

  Public Property GuidProducto As Guid
    Get
      Return m_GuidProducto
    End Get
    Set(value As Guid)
      m_GuidProducto = value
    End Set
  End Property

  Public Property EstadoContrato As Integer
    Get
      Return m_EstadoContrato
    End Get
    Set(value As Integer)
      m_EstadoContrato = value
    End Set
  End Property

  Public Property FechaUltimaExportacion As Date
    Get
      Return m_FechaUltimaExportacion
    End Get
    Set(value As Date)
      m_FechaUltimaExportacion = value
    End Set
  End Property

  Public Property Exportar As Boolean
    Get
      Return m_exportar
    End Get
    Set(value As Boolean)
      m_exportar = value
    End Set
  End Property

  Public Property CBU As String
    Get
      Return m_CBU
    End Get
    Set(value As String)
      m_CBU = value
    End Set
  End Property

  Public Property NumeroContrato As Integer
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

  Public Property idCliente As String
    Get
      Return m_IdCliente
    End Get
    Set(value As String)
      m_IdCliente = value
    End Set
  End Property

  Public Property CodigoBanco As Decimal
    Get
      Return m_CodigoBanco
    End Get
    Set(value As Decimal)
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
    NumeroContrato = 0
    FechaVencimiento = Date.MinValue
    Importe = 0
    idCliente = "0"
    CodigoBanco = 0
    CodigoSucCuenta = 0
    TipoCuenta = " "
    CuentaBanco = 0
    m_Nombre = String.Empty
    m_CuotaActual = 0
    m_exportar = False
    m_FechaUltimaExportacion = Date.MinValue
    m_GuidPago = Guid.Empty
    m_EstadoContrato = 0
    m_GuidProducto = Guid.Empty
  End Sub

End Class
