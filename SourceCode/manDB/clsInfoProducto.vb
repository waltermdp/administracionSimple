Imports libCommon.Comunes
Public Class clsInfoProducto
  Implements ICloneable



  Private m_IdProducto As Integer
  Private m_GuidCliente As Guid
  Private m_GuidVendedor As Guid
  Private m_GuidProducto As Guid
  Private m_GuidTipoPago As Guid
  Private m_TotalCuotas As Integer
  Private m_Precio As Decimal
  Private m_CuotasDebe As Integer
  Private m_FechaPrimerPago As Date
  Private m_FechaVenta As Date
  Private m_GuidCuenta As Guid
  Private m_listPagos As New List(Of clsInfoPagos)
  Private m_Cuenta As clsInfoCuenta
  Private m_listArticulos As New List(Of clsInfoArticuloVendido)
  Private m_Adelanto As Decimal
  Private m_ValorCuotaFija As Decimal
  Private m_NumComprobante As Integer
  Private m_Estado As Integer
  Private m_EstadoStr As String

  Public Property Estado As Integer
    Get
      Return m_Estado
    End Get
    Set(value As Integer)
      m_Estado = value
    End Set
  End Property

  Public Enum E_Estado As Integer
    Normal = 0
    Aplazado = 1
  End Enum

  Private Function ConvertirEstadoToString(ByVal vEnum As E_Estado) As String
    Try
      If vEnum = E_Estado.Normal Then Return "Normal"
      Return "Aplazado"
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function

  Public ReadOnly Property EstadoToString As String
    Get
      Return ConvertirEstadoToString(m_Estado)
    End Get
  End Property
    


  Public Property ListaPagos As List(Of clsInfoPagos)
    Get
      Return m_listPagos
    End Get
    Set(value As List(Of clsInfoPagos))
      m_listPagos = value.ToList
    End Set
  End Property

  Public Property GuidProducto() As Guid
    Get
      Return m_GuidProducto
    End Get
    Set(ByVal value As Guid)
      m_GuidProducto = value
    End Set
  End Property

  Public Property GuidCliente() As Guid
    Get
      Return m_GuidCliente
    End Get
    Set(ByVal value As Guid)
      m_GuidCliente = value
    End Set
  End Property

  Public Property GuidVendedor() As Guid
    Get
      Return m_GuidVendedor
    End Get
    Set(ByVal value As Guid)
      m_GuidVendedor = value
    End Set
  End Property

  Public Property IdProducto() As Integer
    Get
      Return m_IdProducto
    End Get
    Set(ByVal value As Integer)
      m_IdProducto = value
    End Set
  End Property

  Public Property GuidTipoPago As Guid
    Get
      Return m_GuidTipoPago
    End Get
    Set(value As Guid)
      m_GuidTipoPago = value
    End Set
  End Property

  Public Property TotalCuotas As Integer
    Get
      Return m_TotalCuotas
    End Get
    Set(value As Integer)
      m_TotalCuotas = value
    End Set
  End Property

  Public Property Precio As Decimal
    Get
      Return m_Precio
    End Get
    Set(value As Decimal)
      m_Precio = value
    End Set
  End Property

  Public Property CuotasDebe As Integer
    Get
      Return m_CuotasDebe
    End Get
    Set(value As Integer)
      m_CuotasDebe = value
    End Set
  End Property

  Public Property FechaPrimerPago As Date
    Get
      Return m_FechaPrimerPago
    End Get
    Set(value As Date)
      m_FechaPrimerPago = value
    End Set
  End Property

  Public Property FechaVenta As Date
    Get
      Return m_FechaVenta
    End Get
    Set(value As Date)
      m_FechaVenta = value
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

  Public Property Cuenta As clsInfoCuenta
    Get
      Return m_Cuenta
    End Get
    Set(value As clsInfoCuenta)
      m_Cuenta = value
    End Set
  End Property

  Public Property Adelanto As Decimal
    Get
      Return m_Adelanto
    End Get
    Set(value As Decimal)
      m_Adelanto = value
    End Set
  End Property

  Public Property ValorCuotaFija As Decimal
    Get
      Return m_ValorCuotaFija
    End Get
    Set(value As Decimal)
      m_ValorCuotaFija = value
    End Set
  End Property

  Public Property ListaArticulos As List(Of clsInfoArticuloVendido)
    Get
      Return m_listArticulos
    End Get
    Set(value As List(Of clsInfoArticuloVendido))
      m_listArticulos = value.ToList
    End Set
  End Property

  Public Property NumComprobante As Integer
    Get
      Return m_NumComprobante
    End Get
    Set(value As Integer)
      m_NumComprobante = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IdProducto = -1
    GuidProducto = Nothing
    GuidCliente = Nothing
    GuidVendedor = Nothing
    GuidTipoPago = Nothing
    TotalCuotas = 0
    Precio = 0
    FechaPrimerPago = GetAhora()
    FechaVenta = GetAhora()
    GuidCuenta = Nothing
    Adelanto = 0
    ValorCuotaFija = 0
    m_listPagos.Clear()
    Cuenta = New clsInfoCuenta
    m_listArticulos.Clear()
    NumComprobante = -1
    m_CuotasDebe = 0
    m_Estado = 0

  End Sub


#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoProducto
    Return CType(ClonePrivate(), clsInfoProducto)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoProducto

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoProducto)
    objResult.ListaPagos = Me.ListaPagos
    objResult.Cuenta = Me.Cuenta
    objResult.ListaArticulos = Me.ListaArticulos
    Return objResult

  End Function

#End Region


End Class
