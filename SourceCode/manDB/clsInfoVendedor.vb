Public Class clsInfoVendedor
  Implements ICloneable

  Private m_IdVendedor As Integer
  Private m_GuidVendedor As Guid
  Private m_Nombre As String
  Private m_Apellido As String
  Private m_NumVendedor As String
  Private m_Ciudad As String
  Private m_Provincia As String
  Private m_CodigoPostal As String
  Private m_ID As String
  Private m_Grupo As String
  Private m_Tel1 As String
  Private m_Tel2 As String
  Private m_Email As String
  Private m_Categoria As String
  Private m_Comentario As String


  Public Property IdVendedor() As Integer
    Get
      Return m_IdVendedor
    End Get
    Set(ByVal value As Integer)
      m_IdVendedor = value
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

  Public Property Nombre() As String
    Get
      Return m_Nombre
    End Get
    Set(ByVal value As String)
      m_Nombre = value
    End Set
  End Property


  Public Property Apellido() As String
    Get
      Return m_Apellido
    End Get
    Set(ByVal value As String)
      m_Apellido = value
    End Set
  End Property

  Public Property NumVendedor() As String
    Get
      Return m_NumVendedor
    End Get
    Set(ByVal value As String)
      m_NumVendedor = value
    End Set
  End Property

  Public Property Ciudad() As String
    Get
      Return m_Ciudad
    End Get
    Set(ByVal value As String)
      m_Ciudad = value
    End Set
  End Property

  Public Property Provincia() As String
    Get
      Return m_Provincia
    End Get
    Set(ByVal value As String)
      m_Provincia = value
    End Set
  End Property

  Public Property CodigoPostal() As String
    Get
      Return m_CodigoPostal
    End Get
    Set(ByVal value As String)
      m_CodigoPostal = value
    End Set
  End Property

  Public Property ID() As String
    Get
      Return m_ID
    End Get
    Set(ByVal value As String)
      m_ID = value
    End Set
  End Property

  Public Property Grupo() As String
    Get
      Return m_Grupo
    End Get
    Set(ByVal value As String)
      m_Grupo = value
    End Set
  End Property

  Public Property Tel1() As String
    Get
      Return m_Tel1
    End Get
    Set(ByVal value As String)
      m_Tel1 = value
    End Set
  End Property

  Public Property Tel2() As String
    Get
      Return m_Tel2
    End Get
    Set(ByVal value As String)
      m_Tel2 = value
    End Set
  End Property

  Public Property Email() As String
    Get
      Return m_Email
    End Get
    Set(ByVal value As String)
      m_Email = value
    End Set
  End Property

  Public Property Categoria() As String
    Get
      Return m_Categoria
    End Get
    Set(ByVal value As String)
      m_Categoria = value
    End Set
  End Property

  Public Property Comentario() As String
    Get
      Return m_Comentario
    End Get
    Set(ByVal value As String)
      m_Comentario = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IdVendedor = -1
    GuidVendedor = Nothing
    Nombre = "--"
    Apellido = "--"
    NumVendedor = "--"
    Ciudad = "--"
    Provincia = "--"
    CodigoPostal = "--"
    ID = "--"
    Grupo = "--"
    Tel1 = "--"
    Tel2 = "--"
    Email = "--"
    Categoria = "--"
    Comentario = "--"
  End Sub

#Region "Overrides"

  Public Overrides Function ToString() As String

    Return Apellido & ", " & Nombre

  End Function

  'Las Igualdades se establecen a partir del campo Guid
  'OJO!!! si no se incluye esta sobrecarga, la búsqueda implementada en Find
  'en clsList no arroja resultados
  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoVendedor) Then
      Return CType(obj, clsInfoVendedor).GuidVendedor.Equals(Me.GuidVendedor)
    Else
      Return False
    End If

  End Function

#End Region

#Region "Interface: ICloneable"

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    'Clonación Superficial
    Return Me.MemberwiseClone()
  End Function

  Public Function Clone() As clsInfoVendedor
    Return CType(ClonePrivate(), clsInfoVendedor)
  End Function

#End Region
End Class
