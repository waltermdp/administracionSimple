Public Class clsInfoVendedor
  Implements ICloneable

  Private m_IdVendedor As Integer
  Private m_GuidVendedor As Guid
  Private m_Nombre As String
  Private m_Apellido As String

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

  Public Sub New()
    MyBase.New()
    IdVendedor = -1
    GuidVendedor = Nothing
    Nombre = "--"
    Apellido = "--"
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
