Public Class clsInfoGrupo
  Implements ICloneable

  Private m_IdGrupo As Integer
  Private m_Nombre As String
  Private m_GuidGrupo As Guid

  Public Property IdGrupo As Integer
    Get
      Return m_IdGrupo
    End Get
    Set(value As Integer)
      m_IdGrupo = value
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

  Public Property GuidGrupo As Guid
    Get
      Return m_GuidGrupo
    End Get
    Set(value As Guid)
      m_GuidGrupo = value
    End Set
  End Property


  Public Sub New()
    IdGrupo = -1
    Nombre = "--"
    GuidGrupo = Nothing
  End Sub

  Public Overrides Function ToString() As String
    Return Nombre
  End Function

#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoGrupo
    Return CType(ClonePrivate(), clsInfoGrupo)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New clsInfoGrupo

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoGrupo)
    Return objResult

  End Function

#End Region
End Class
