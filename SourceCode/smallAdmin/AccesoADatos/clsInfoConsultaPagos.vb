Public Class clsInfoConsultaPagos
  Implements IComparer(Of Integer)


  Private m_Cliente As String
  Private m_ClienteNombre As String
  Private m_ClienteApellido As String
  Private m_NumeroCliente As String
  Private m_IDContrato As Integer
  Private m_MetodoPago As String
  Private m_Telefono1 As String

  Private m_TotalCuotas As Integer
  Private m_FechaPago As Date
  Private m_GuidCuenta As Guid
  Private m_ValorCuota As Decimal
  Private m_CuotaNumero As Integer
  Private m_ValorTotal As Decimal
  Private m_Mensaje As String


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

  Public Property Telefono1 As String
    Get
      Return m_Telefono1
    End Get
    Set(value As String)
      m_Telefono1 = value
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


  Public Property FechaPago As Date
    Get
      Return m_FechaPago
    End Get
    Set(value As Date)
      m_FechaPago = value
    End Set
  End Property

  Public Property GUID_Cuenta As Guid
    Get
      Return m_GuidCuenta
    End Get
    Set(value As Guid)
      m_GuidCuenta = value
    End Set
  End Property

  Public Property ValorCuota As Decimal
    Get
      Return m_ValorCuota
    End Get
    Set(value As Decimal)
      m_ValorCuota = value
    End Set
  End Property

  Public Property CuotaNumero As Integer
    Get
      Return m_CuotaNumero
    End Get
    Set(value As Integer)
      m_CuotaNumero = value
    End Set
  End Property

  Public Property ValorTotal As Decimal
    Get
      Return m_ValorTotal
    End Get
    Set(value As Decimal)
      m_ValorTotal = value
    End Set
  End Property

  Public Property Mensaje As String
    Get
      Return m_Mensaje
    End Get
    Set(value As String)
      m_Mensaje = value
    End Set
  End Property


  Public Sub SetMensajePatron(ByVal vMensaje As String)
    Try
      m_Mensaje = String.Format(vMensaje, ClienteNombre, TotalCuotas, CuotaNumero, ValorCuota)
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub New()
    Try
      m_ClienteNombre = String.Empty
      m_ClienteApellido = String.Empty
      m_NumeroCliente = "0"
      m_IDContrato = -1
      m_MetodoPago = String.Empty
      m_Telefono1 = String.Empty

      m_TotalCuotas = -1
      m_FechaPago = g_Today
      m_GuidCuenta = Guid.Empty
      m_ValorCuota = 0
      m_CuotaNumero = -1
      m_ValorTotal = 0
      m_Mensaje = String.Empty
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub


  Public Function Compare(x As Integer, y As Integer) As Integer Implements IComparer(Of Integer).Compare
    If x > y Then Return 1
    If x = y Then Return 0
    Return -1
  End Function
End Class
