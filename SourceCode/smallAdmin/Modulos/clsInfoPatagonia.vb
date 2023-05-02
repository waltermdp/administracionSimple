Imports libCommon.Comunes
Imports manDB

Public Class clsInfoPatagonia


  'body
  Private m_TipoNovedad As String = "D"
  Private m_Cuit_DNI As Decimal
  Private m_CBU As Decimal
  Private m_ID_Cliente_Empresa As String
  Private m_FechaVto As Date
  Private m_Producto As String

  'Debitos
  Private m_tipoMoneda As String = "P"
  Private m_Importe As Decimal
  Private m_ReferenciaDebito As String = "EDIT EL FARO"
  Private m_NroCuitEmpresa As Decimal

  Private m_Nombre As String
  Private m_CuotaActual As Decimal

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
    End Set
  End Property

  Public Property CuotaActual As Decimal
    Get
      Return m_CuotaActual
    End Get
    Set(value As Decimal)
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

  Public Property ID_Cliente_Empresa As String
    Get
      Return m_ID_Cliente_Empresa
    End Get
    Set(value As String)
      m_ID_Cliente_Empresa = value
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
      ID_Cliente_Empresa = " "
      FechaVto = g_Today
      Producto = ""

      TipoMoneda = "P"
      Importe = 0
      ReferenciaDebito = "EDIT EL FARO"
      NroCuitEmpresa = 0

      m_Nombre = ""
      m_CuotaActual = 0
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
