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
  Private m_listPagos As New List(Of clsInfoPagos)

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

  Public Sub New()
    MyBase.New()
    IdProducto = -1
    GuidProducto = Nothing
    GuidCliente = Nothing
    GuidVendedor = Nothing
    GuidTipoPago = Guid.Empty
    TotalCuotas = 0
    Precio = 0
    FechaPrimerPago = Nothing
    FechaVenta = Nothing
    m_listPagos.Clear()
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
    Return objResult

  End Function

#End Region
End Class
