Public Class clsInfoStock
  Implements ICloneable

  Private m_IdStock As Integer
  Private m_GuidArticulo As Guid
  Private m_Responsable As String
  Private m_Cantidad As Integer
  Private m_GuidResponsable As Guid

  Public Property IdStock As Integer
    Get
      Return m_IdStock
    End Get
    Set(value As Integer)
      m_IdStock = value
    End Set
  End Property

  Public Property GuidArticulo As Guid
    Get
      Return m_GuidArticulo
    End Get
    Set(value As Guid)
      m_GuidArticulo = value
    End Set
  End Property

  Public Property Responsable As String
    Get
      Return m_Responsable
    End Get
    Set(value As String)
      m_Responsable = value
    End Set
  End Property

  Public Property Cantidad As Integer
    Get
      Return m_Cantidad
    End Get
    Set(value As Integer)
      m_Cantidad = value
    End Set
  End Property

  Public Property GuidResponsable As Guid
    Get
      Return m_GuidResponsable
    End Get
    Set(value As Guid)
      m_GuidResponsable = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IdStock = -1
    GuidArticulo = Nothing
    Responsable = "--"
    Cantidad = -1
    GuidResponsable = Nothing
  End Sub

#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoStock
    Return CType(ClonePrivate(), clsInfoStock)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoStock

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoStock)

    Return objResult

  End Function

#End Region
End Class
