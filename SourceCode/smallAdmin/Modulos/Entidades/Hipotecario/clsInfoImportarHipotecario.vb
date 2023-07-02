Imports libCommon.Comunes

Public Class clsInfoImportarHipotecario

  Private m_NroAbonado As Integer
  Private m_NroCuenta As String
  Private m_cuota As Integer
  Private m_FechaDebito As Date
  Private m_ImporteADebitar As Decimal
  Private m_importeDebitado As Decimal
  Private m_ImporteBH As Decimal
  Private m_MotivoRechazo As String
  Private m_Importar As Boolean
  Private m_GuidProducto As Guid
  Private m_GuidPago As Guid
  Private m_GuidCuenta As Guid
  Private m_Nombre As String
  Private m_FechaUltimaImportacion As Date

  Public Property FechaUltimaImportacion As Date
    Get
      Return m_FechaUltimaImportacion
    End Get
    Set(value As Date)
      m_FechaUltimaImportacion = value
    End Set
  End Property

  Public Property NroAbonado As Integer
    Get
      Return m_NroAbonado
    End Get
    Set(value As Integer)
      m_NroAbonado = value
    End Set
  End Property
  Public Property NroCuenta As String
    Get
      Return m_NroCuenta
    End Get
    Set(value As String)
      m_NroCuenta = value
    End Set
  End Property
  Public Property cuota As Integer
    Get
      Return m_cuota
    End Get
    Set(value As Integer)
      m_cuota = value
    End Set
  End Property
  Public Property FechaDebito As Date
    Get
      Return m_FechaDebito
    End Get
    Set(value As Date)
      m_FechaDebito = value
    End Set
  End Property
  Public Property ImporteADebitar As Decimal
    Get
      Return m_ImporteADebitar
    End Get
    Set(value As Decimal)
      m_ImporteADebitar = value
    End Set
  End Property
  Public Property importeDebitado As Decimal
    Get
      Return m_importeDebitado
    End Get
    Set(value As Decimal)
      m_importeDebitado = value
    End Set
  End Property
  Public Property ImporteBH As Decimal
    Get
      Return ImporteBH
    End Get
    Set(value As Decimal)
      m_ImporteBH = value
    End Set
  End Property
  Public Property MotivoRechazo As String
    Get
      Return m_MotivoRechazo
    End Get
    Set(value As String)
      m_MotivoRechazo = value
    End Set
  End Property

  Public Property Importar As Boolean
    Get
      Return m_Importar
    End Get
    Set(value As Boolean)
      m_Importar = value
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

  Public Property GuidPago As Guid
    Get
      Return m_GuidPago
    End Get
    Set(value As Guid)
      m_GuidPago = value
    End Set
  End Property

  Public Property GuidCuenta As Guid
    Get
      Return m_GuidCuenta
    End Get
    Set(value As Guid)
      m_GuidCuenta = value
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

  Public Sub New()
    Try
      m_NroAbonado = 0
      m_NroCuenta = "0000000000000000000000"  'CBU 22 digitos
      m_cuota = 0
      m_FechaDebito = g_Today
      m_ImporteADebitar = 0
      m_importeDebitado = 0
      m_ImporteBH = 0
      m_MotivoRechazo = ""
      m_Importar = False
      m_GuidCuenta = Guid.Empty
      m_GuidPago = Guid.Empty
      m_GuidProducto = Guid.Empty
      m_Nombre = String.Empty
      m_FechaUltimaImportacion = Date.MinValue
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
