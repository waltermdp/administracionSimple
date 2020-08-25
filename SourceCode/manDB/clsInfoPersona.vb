Imports libCommon.Comunes

Public Class ClsInfoPersona
  Implements ICloneable

  Private m_IdCliente As Integer
  Private m_GuidCliente As Guid
  Private m_Nombre As String
  Private m_Apellido As String
  Private m_DNI As String
  Private m_FechaNac As Date
  Private m_Calle As String
  Private m_NumCalle As String
  Private m_FechaIngreso As Date
  Private m_Email As String
  Private m_Tel1 As String
  Private m_Tel2 As String
  Private m_Ciudad As String
  Private m_Provincia As String
  Private m_Calle2 As String
  Private m_NumCalle2 As String
  Private m_NumCliente As String
  Private m_CodigoPostal As String
  Private m_Comentarios As String
  Private m_Profesion As String

  Public Property IDCliente() As Integer
    Get
      Return m_IdCliente
    End Get
    Set(value As Integer)
      m_IdCliente = value
    End Set
  End Property

  Public Property GuidCliente As Guid
    Get
      Return m_GuidCliente
    End Get
    Set(value As Guid)
      m_GuidCliente = value
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

  Public Property Apellido As String
    Get
      Return m_Apellido
    End Get
    Set(value As String)
      m_Apellido = value
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

  Public Property FechaNac As Date
    Get
      Return m_FechaNac
    End Get
    Set(value As Date)
      m_FechaNac = value
    End Set
  End Property

  Public Property Calle As String
    Get
      Return m_Calle
    End Get
    Set(value As String)
      m_Calle = value
    End Set
  End Property

  Public Property NumCalle As String
    Get
      Return m_NumCalle
    End Get
    Set(value As String)
      m_NumCalle = value
    End Set
  End Property

  Public Property FechaIngreso As Date
    Get
      Return m_FechaIngreso
    End Get
    Set(value As Date)
      m_FechaIngreso = value
    End Set
  End Property

  Public Property Email As String
    Get
      Return m_Email
    End Get
    Set(value As String)
      m_Email = value
    End Set
  End Property

  Public Property Tel1 As String
    Get
      Return m_Tel1
    End Get
    Set(value As String)
      m_Tel1 = value
    End Set
  End Property

  Public Property Tel2 As String
    Get
      Return m_Tel2
    End Get
    Set(value As String)
      m_Tel2 = value
    End Set
  End Property

  Public Property Ciudad As String
    Get
      Return m_Ciudad
    End Get
    Set(value As String)
      m_Ciudad = value
    End Set
  End Property

  Public Property Provincia As String
    Get
      Return m_Provincia
    End Get
    Set(value As String)
      m_Provincia = value
    End Set
  End Property

  Public Property Calle2 As String
    Get
      Return m_Calle2
    End Get
    Set(value As String)
      m_Calle2 = value
    End Set
  End Property

  Public Property NumCalle2 As String
    Get
      Return m_NumCalle2
    End Get
    Set(value As String)
      m_NumCalle2 = value
    End Set
  End Property

  Public Property NumCliente As String
    Get
      Return m_NumCliente
    End Get
    Set(value As String)
      m_NumCliente = value
    End Set
  End Property

  Public Property CodigoPostal As String
    Get
      Return m_CodigoPostal
    End Get
    Set(value As String)
      m_CodigoPostal = value
    End Set
  End Property

  Public Property Comentarios As String
    Get
      Return m_Comentarios
    End Get
    Set(value As String)
      m_Comentarios = value
    End Set
  End Property

  Public Property Profesion As String
    Get
      Return m_Profesion
    End Get
    Set(value As String)
      m_Profesion = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IDCliente = -1
    GuidCliente = Nothing
    Nombre = "--"
    Apellido = "--"
    DNI = "--"
    FechaNac = GetAhora
    Calle = "--"
    NumCalle = "--"
    FechaIngreso = GetAhora
    Email = "--"
    Tel1 = "--"
    Tel2 = "--"
    Ciudad = "--"
    Provincia = "--"
    Calle2 = "--"
    NumCalle2 = "--"
    NumCliente = "--"
    CodigoPostal = "--"
    Comentarios = "--"
    Profesion = "--"
  End Sub

  Public Overrides Function ToString() As String

    Return Apellido & ", " & Nombre

  End Function

  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(ClsInfoPersona) Then
      Return CType(obj, ClsInfoPersona).GuidCliente.Equals(Me.GuidCliente)
    Else
      Return False
    End If

  End Function

  Public Function Clone() As ClsInfoPersona
    Return CType(ClonePrivate(), ClsInfoPersona)
  End Function

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New ClsInfoPersona
    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, ClsInfoPersona)
    Return objResult
  End Function

End Class
