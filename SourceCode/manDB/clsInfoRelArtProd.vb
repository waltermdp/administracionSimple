Public Class clsInfoRelArtProd
  Implements ICloneable
  'Tabla RelArtProd
  'IdRel
  'GuidArticulo
  'GuidProducto
  Private m_IdRel As Integer
  Private m_GuidArticulo As Guid
  Private m_GuidProducto As Guid
  Private m_CantidadArticulos As Integer
  Private m_Entregados As Integer

  Public Property IdRel As Integer
    Get
      Return m_IdRel
    End Get
    Set(value As Integer)
      m_IdRel = value
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

  Public Property GuidProducto As Guid
    Get
      Return m_GuidProducto
    End Get
    Set(value As Guid)
      m_GuidProducto = value
    End Set
  End Property

  Public Property CantidadArticulos As Integer
    Get
      Return m_CantidadArticulos
    End Get
    Set(value As Integer)
      m_CantidadArticulos = value
    End Set
  End Property

  Public Property Entregados As Integer
    Get
      Return m_Entregados
    End Get
    Set(value As Integer)
      m_Entregados = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IdRel = -1
    GuidArticulo = Nothing
    GuidProducto = Nothing
    m_CantidadArticulos = -1
    m_Entregados = 0
  End Sub


#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoRelArtProd
    Return CType(ClonePrivate(), clsInfoRelArtProd)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoRelArtProd

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoRelArtProd)

    Return objResult

  End Function

#End Region

End Class
