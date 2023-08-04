Public Class clsInfoExportarEfectivo
 
  Private m_NumeroComprobante As Integer
  Private m_FechaVto As Date
  Private m_Importe As Decimal
  Private m_IdentificadorDebito As Decimal
  Private m_CodigoDeALta As String
  Private m_GuidPago As Guid
  Private m_GuidProducto As Guid
  Private m_FechaUltimaExportacion As Date


  'Personales
  Private m_Nombre As String
  Private m_CuotaActual As Integer
  Private m_Exportar As Boolean
  Private m_EstadoContrato As Integer

  Public Property FechaUltimaExportacion As Date
    Get
      Return m_FechaUltimaExportacion
    End Get
    Set(value As Date)
      m_FechaUltimaExportacion = value
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

  Public Property CodigoDeAlta As String
    Get
      Return m_CodigoDeALta
    End Get
    Set(value As String)
      m_CodigoDeALta = value
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

  Public Property FechaVto As Date
    Get
      Return m_FechaVto
    End Get
    Set(value As Date)
      m_FechaVto = value
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

  Public Property IdentificadorDebito As Decimal
    Get
      Return m_IdentificadorDebito
    End Get
    Set(value As Decimal)
      m_IdentificadorDebito = value
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

  Public Property Exportar As Boolean
    Get
      Return m_Exportar
    End Get
    Set(value As Boolean)
      m_Exportar = value
    End Set
  End Property

  Public Sub New()
    Try
     
      m_NumeroComprobante = 0
      m_FechaVto = g_Today
      m_Importe = 0
      m_IdentificadorDebito = 0
      m_CodigoDeALta = ""
      m_FechaUltimaExportacion = Date.MinValue
      m_Nombre = ""
      m_CuotaActual = 0
      m_Exportar = False
      m_GuidPago = Guid.Empty
      m_GuidProducto = Guid.Empty
      m_EstadoContrato = 0
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub
End Class
