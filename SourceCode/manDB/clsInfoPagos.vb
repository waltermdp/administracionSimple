Public Class clsInfoPagos
  Implements ICloneable


  Private m_IdPago As Integer
  Private m_GuidProducto As Guid
  Private m_GuidPago As Guid
  Private m_NumCuota As Integer
  Private m_ValorCuota As Decimal
  Private m_VencimientoCuota As Date
  Private m_FechaPago As Date
  Private m_EstadoPago As libCommon.Comunes.E_EstadoPago
  Private m_NumComprobante As Integer

  Public Property IdPago As Integer
    Get
      Return m_IdPago
    End Get
    Set(value As Integer)
      m_IdPago = value
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

  Public Property NumCuota As Integer
    Get
      Return m_NumCuota
    End Get
    Set(value As Integer)
      m_NumCuota = value
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

  Public Property VencimientoCuota As Date
    Get
      Return m_VencimientoCuota
    End Get
    Set(value As Date)
      m_VencimientoCuota = value
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

  Public Property EstadoPago As libCommon.Comunes.E_EstadoPago
    Get
      Return m_EstadoPago
    End Get
    Set(value As libCommon.Comunes.E_EstadoPago)
      m_EstadoPago = value
    End Set
  End Property



  Public Sub New()
    MyBase.New()
    Try
      IdPago = -1
      GuidPago = Nothing
      GuidProducto = Nothing
      NumCuota = -1
      ValorCuota = 0
      VencimientoCuota = Nothing
      FechaPago = Nothing
      EstadoPago = libCommon.Comunes.E_EstadoPago.NA
      NumComprobante = -1

    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoPagos
    Return CType(ClonePrivate(), clsInfoPagos)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoPagos

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoPagos)

    Return objResult

  End Function

#End Region
End Class
