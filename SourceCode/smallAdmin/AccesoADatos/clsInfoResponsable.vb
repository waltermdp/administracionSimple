Public Class clsInfoResponsable
  Private m_Nombre As String
  Private m_GuidResponsable As Guid
  Private m_Codigo As String

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
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

  Public Property Codigo As String
    Get
      Return m_codigo
    End Get
    Set(value As String)
      m_codigo = value
    End Set
  End Property

  Public Sub New()
    Nombre = "--"
    GuidResponsable = Nothing
    Codigo = "--"
  End Sub

  Public Overrides Function ToString() As String
    If m_Codigo <> "--" AndAlso m_Codigo <> String.Empty Then
      Return String.Format("{0},{1}", Nombre, Codigo)
    Else
      Return String.Format("{0}", Nombre)
    End If


  End Function



End Class
