Public Class clsInfoConsultaVentas

  Private m_Cliente As String
  Private m_ClienteNombre As String
  Private m_ClienteApellido As String
  Private m_Vendedor As String
  Private m_VendedorNombre As String
  Private m_VendedorApellido As String
  Private m_NumeroCliente As String
  Private m_IDContrato As Integer
  Private m_MetodoPago As String
  Private m_Vendido As Integer
  Private m_TotalCuotas As Integer
  Private m_FechaInicio As Date
  Private m_FechaFin As Date
  Private m_GuidCliente As Guid
  Private m_GuidProducto As Guid
  Private m_GuidVendedor As Guid
  Private m_ValorCuota As Decimal

  Public Property ValorCuota As Decimal
    Get
      Return m_ValorCuota
    End Get
    Set(value As Decimal)
      m_ValorCuota = value
    End Set
  End Property

  Public ReadOnly Property Cliente As String
    Get
      Return String.Format("{0}, {1}", m_ClienteApellido, m_ClienteNombre)
    End Get
    
  End Property

  Public Property ClienteNombre As String
    Get
      Return m_ClienteNombre
    End Get
    Set(value As String)
      m_ClienteNombre = value
    End Set
  End Property

  Public Property ClienteApellido As String
    Get
      Return m_ClienteApellido
    End Get
    Set(value As String)
      m_ClienteApellido = value
    End Set
  End Property

  Public ReadOnly Property Vendedor As String
    Get
      Return String.Format("{0}, {1}", m_VendedorApellido, m_VendedorNombre)
    End Get
  End Property

  Public Property VendedorNombre As String
    Get
      Return m_VendedorNombre
    End Get
    Set(value As String)
      m_VendedorNombre = value
    End Set
  End Property

  Public Property VendedorApellido As String
    Get
      Return m_VendedorApellido
    End Get
    Set(value As String)
      m_VendedorApellido = value
    End Set
  End Property

  Public Property IDCliente As String
    Get
      Return m_NumeroCliente
    End Get
    Set(value As String)
      m_NumeroCliente = value
    End Set
  End Property

  Public Property IDContrato As Integer
    Get
      Return m_IDContrato
    End Get
    Set(value As Integer)
      m_IDContrato = value
    End Set
  End Property


  Public Property MetodoPago As String
    Get
      Return m_MetodoPago
    End Get
    Set(value As String)
      m_MetodoPago = value
    End Set
  End Property

  Public Property Vendidos As Integer
    Get
      Return m_Vendido
    End Get
    Set(value As Integer)
      m_Vendido = value
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


  Public Property FechaInicio As Date
    Get
      Return m_FechaInicio
    End Get
    Set(value As Date)
      m_FechaInicio = value
    End Set
  End Property

  Public Property FechaFin As Date
    Get
      Return m_FechaFin
    End Get
    Set(value As Date)
      m_FechaFin = value
    End Set
  End Property

  Public Property GUID_Cliente As Guid
    Get
      Return m_GuidCliente
    End Get
    Set(value As Guid)
      m_GuidCliente = value
    End Set
  End Property

  Public Property Guid_Producto As Guid
    Get
      Return m_GuidProducto
    End Get
    Set(value As Guid)
      m_GuidProducto = value
    End Set
  End Property

  Public Property Guid_Vendedor As Guid
    Get
      Return m_GuidVendedor
    End Get
    Set(value As Guid)
      m_GuidVendedor = value
    End Set
  End Property

  Public Sub New()
    Try

      m_ClienteNombre = String.Empty
      m_ClienteApellido = String.Empty

      m_VendedorNombre = String.Empty
      m_VendedorApellido = String.Empty
      m_MetodoPago = String.Empty
      m_Vendido = -1
      m_IDContrato = -1
      m_NumeroCliente = "0"
      m_TotalCuotas = 0
      m_FechaInicio = g_Today
      m_FechaFin = g_Today
      m_GuidCliente = Guid.Empty
      m_GuidProducto = Guid.Empty
      m_GuidVendedor = Guid.Empty
      m_ValorCuota = 0
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub
End Class
