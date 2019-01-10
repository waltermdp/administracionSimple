Public Class clsListaStorage

  Private m_Nombre As String
  Private m_Codigo As String
  Private m_Descripcion As String
  Private m_Responsable As String
  Private m_Cantidad As Integer

  Private m_GuidArticulo As Guid

  Public Property GuidArticulo As Guid
    Get
      Return m_GuidArticulo
    End Get
    Set(value As Guid)
      m_GuidArticulo = value
    End Set
  End Property


  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
    End Set
  End Property

  Public Property Codigo As String
    Get
      Return m_Codigo
    End Get
    Set(value As String)
      m_Codigo = value
    End Set
  End Property

  Public Property Descripcion As String
    Get
      Return m_Descripcion
    End Get
    Set(value As String)
      m_Descripcion = value
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

  Public Sub New()
    GuidArticulo = Nothing
    Nombre = "--"
    Codigo = "--"
    Descripcion = "--"
    Responsable = "--"
    Cantidad = 0
  End Sub
End Class
