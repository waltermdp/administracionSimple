Public Class ClsInfoPersona
  Implements ICloneable

  Private m_IdCliente As Integer
  Private m_Version As Integer = 1 'Agrego campo genero
  Private m_GuidCliente As Guid
  Private m_GuidOwner As Guid
  Private m_Nombre As String
  Private m_Apellido As String
  Private m_DNI As String
  Private m_NHC As String
  Private m_FechaNac As Date
  Private m_Telefono1 As String
  Private m_Email1 As String
  Private m_Ciudad As String
  Private m_CodPost As String
  Private m_ProvEstado As String
  Private m_Calle1 As String
  Private m_NumCalle1 As String
  Private m_Fecha As Date
  Private m_Comentarios As String
  Private m_Genero As Integer

  Public Property IDCliente() As Integer
    Get
      Return m_IdCliente
    End Get
    Set(value As Integer)
      m_IdCliente = value
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

  Public Property Apellido() As String
    Get
      Return m_Apellido
    End Get
    Set(value As String)
      m_Apellido = value
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


  Public Sub New()
    MyBase.New()
    GuidCliente = Nothing
    'GuidOwner = Nothing
    IDCliente = -1
    Nombre = "--"
    Apellido = "--"
    'DNI = "--"
    'NHC = "--"
    'FechaNac = Date.Now
    'Telefono1 = "--"
    'Email1 = "--"
    'Ciudad = "--"
    'CodPost = "--"
    'ProvEstado = "--"
    'Calle1 = "--"
    'NumCalle1 = "--"
    'Fecha = Date.Now
    'Institucion = "--"
    'Comentarios = "--"
    'PathPac = "--"
    'Genero = 0

    'Acceso = &H50 'OffLine
  End Sub

  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoPersona) Then
      Return CType(obj, ClsInfoPersona).GuidCliente.Equals(Me.GuidCliente)
    Else
      Return False
    End If

  End Function

  Public Function Clone() As ClsInfoPersona
    Return CType(ClonePrivate(), clsInfoPersona)
  End Function

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New clsInfoPersona
    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoPersona)
    Return objResult
  End Function

End Class
