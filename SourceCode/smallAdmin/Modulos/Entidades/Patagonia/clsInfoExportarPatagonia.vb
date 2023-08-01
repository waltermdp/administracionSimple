Imports libCommon.Comunes
Imports manDB

Public Class clsInfoExportarPatagonia


  'body
  Private m_TipoNovedad As String = "D"
  Private m_Cuit_DNI As Decimal
  Private m_CBU As Decimal

  Private m_Contrato As Integer
  Private m_FechaVto As Date
  Private m_Producto As String

  'Debitos
  Private m_tipoMoneda As String = "P"
  Private m_Importe As Decimal
  Private m_ReferenciaDebito As String = "EDIT EL FARO"
  Private m_NroCuitEmpresa As Decimal

  Private m_Nombre As String
  Private m_CuotaActual As Integer
  Private m_Exportar As Boolean
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
      Return m_Exportar
    End Get
    Set(value As Boolean)
      m_Exportar = value
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

  Public Property TipoNovedad As String
    Get
      Return m_TipoNovedad
    End Get
    Set(value As String)
      m_TipoNovedad = value
    End Set
  End Property

  Public Property Cuit_DNI As Decimal
    Get
      Return m_Cuit_DNI
    End Get
    Set(value As Decimal)
      m_Cuit_DNI = value
    End Set
  End Property

  Public Property CBU As Decimal
    Get
      Return m_CBU
    End Get
    Set(value As Decimal)
      m_CBU = value
    End Set
  End Property

  Public Property Contrato As Integer
    Get
      Return m_Contrato
    End Get
    Set(value As Integer)
      m_Contrato = value
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

  Public Property Producto As String
    Get
      Return m_Producto
    End Get
    Set(value As String)
      m_Producto = value
    End Set
  End Property


  Public Property TipoMoneda As String
    Get
      Return m_tipoMoneda
    End Get
    Set(value As String)
      m_tipoMoneda = value
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

  Public Property ReferenciaDebito As String
    Get
      Return m_ReferenciaDebito
    End Get
    Set(value As String)
      m_ReferenciaDebito = value
    End Set
  End Property

  Public Property NroCuitEmpresa As Decimal
    Get
      Return m_NroCuitEmpresa
    End Get
    Set(value As Decimal)
      m_NroCuitEmpresa = value
    End Set
  End Property

  Public Sub New()
    Try
      TipoNovedad = "D"
      Cuit_DNI = 0
      CBU = 0
      m_Contrato = 0
      FechaVto = g_Today
      Producto = ""

      TipoMoneda = "P"
      Importe = 0
      ReferenciaDebito = "EDIT EL FARO"
      NroCuitEmpresa = 0
      m_Exportar = False
      m_Nombre = ""
      m_CuotaActual = 0
      m_FechaUltimaExportacion = Date.MinValue
      m_EstadoContrato = 0
      m_GuidPago = Guid.Empty
      m_GuidProducto = Guid.Empty
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
