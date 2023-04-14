Imports libCommon.Comunes
Public Class clsInfoAdelanto

  Implements ICloneable

  Private m_IdAdelanto As Integer
  Private m_GuidVendedor As Guid
  Private m_Valor As Decimal
  Private m_Fecha As Date
  Private m_Estado As Integer
  Private m_Observacion As String
  Private m_GuidProducto As Guid

  Public Property IdAdelanto As Integer
    Get
      Return m_IdAdelanto
    End Get
    Set(value As Integer)
      m_IdAdelanto = value
    End Set
  End Property

  Public Property GuidVendedor As Guid
    Get
      Return m_GuidVendedor
    End Get
    Set(value As Guid)
      m_GuidVendedor = value
    End Set
  End Property

  Public Property Valor As Decimal
    Get
      Return m_Valor
    End Get
    Set(value As Decimal)
      m_Valor = value
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

  Public Property Estado As Integer
    Get
      Return m_Estado
    End Get
    Set(value As Integer)
      m_Estado = value
    End Set
  End Property

  Public Property Observacion As String
    Get
      Return m_Observacion
    End Get
    Set(value As String)
      m_Observacion = value
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


  Public Sub New()
    MyBase.New()
    IdAdelanto = -1
    GuidVendedor = Nothing
    Valor = 0
    Fecha = GetHoy()
    Estado = 0
    Observacion = String.Empty
    GuidProducto = Nothing

  End Sub

  Public Function Clone() As clsInfoAdelanto
    Return CType(ClonePrivate(), clsInfoAdelanto)
  End Function

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New clsInfoAdelanto
    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoAdelanto)
    Return objResult
  End Function
End Class
