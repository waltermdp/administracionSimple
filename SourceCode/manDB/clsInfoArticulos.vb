Public Class clsInfoArticulos
  Implements ICloneable
  'Tabla Articulos
  Private m_IdArticulo As Integer
  Private m_GuidArticulo As Guid
  Private m_Nombre As String
  Private m_Codigo As String
  Private m_Descripcion As String
  Private m_Precio As Decimal

  Public Property IdArticulo As Integer
    Get
      Return m_IdArticulo
    End Get
    Set(value As Integer)
      m_IdArticulo = value
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

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
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
  Public Sub New()
    MyBase.New()
    IdArticulo = -1
    GuidArticulo = Nothing
    Nombre = "--"
    Codigo = "--"
    Descripcion = "--"
    Precio = 0
  End Sub

#Region "Overrides"

  Public Overrides Function ToString() As String
    Return String.Format("{0}, ({1})", Nombre, Codigo)
  End Function


  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoArticulos) Then
      Return CType(obj, clsInfoArticulos).GuidArticulo.Equals(Me.GuidArticulo)
    Else
      Return False
    End If

  End Function

#End Region


#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoArticulos
    Return CType(ClonePrivate(), clsInfoArticulos)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoArticulos

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoArticulos)

    Return objResult

  End Function

#End Region
End Class
