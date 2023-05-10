Public Class clsInfoResumenVenta
  Private m_Cliente As String
  Private m_DNI As String
  Private m_Fecha As Date
  Private m_CantItems As Integer
  Private m_Importe As Decimal
  Private m_Cuotas As Integer
  Private m_Vendedor As String
  Private m_Periodo As String
  Private m_Comision As Decimal

  Public Property Cliente As String
    Get
      Return m_Cliente
    End Get
    Set(value As String)
      m_Cliente = value
    End Set
  End Property

  Public Property DNI As String
    Get
      Return m_DNI
    End Get
    Set(value As String)
      m_DNI = value
    End Set
  End Property

  Public Property Fecha As Date
    Get
      Return m_Fecha
    End Get
    Set(value As Date)
      m_Fecha = value
    End Set
  End Property

  Public Property CantItems As Integer
    Get
      Return m_CantItems
    End Get
    Set(value As Integer)
      m_CantItems = value
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

  Public Property Cuotas As Integer
    Get
      Return m_Cuotas
    End Get
    Set(value As Integer)
      m_Cuotas = value
    End Set
  End Property

  Public Property Vendedor As String
    Get
      Return m_Vendedor
    End Get
    Set(value As String)
      m_Vendedor = value
    End Set
  End Property

  Public Property Periodo As String
    Get
      Return m_Periodo
    End Get
    Set(value As String)
      m_Periodo = value
    End Set
  End Property

  Public Property Comision As Decimal
    Get
      Return m_Comision
    End Get
    Set(value As Decimal)
      m_Comision = value
    End Set
  End Property

  Public Sub New()
    Cliente = "--"

  End Sub
End Class
