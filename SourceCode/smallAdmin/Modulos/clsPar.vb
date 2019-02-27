Imports manDB
Imports libCommon.Comunes
Public Class clsPar


  Private m_Guid As Guid
  Private m_Nombre As String

  Public Property Guid As Guid
    Get
      Return m_Guid
    End Get
    Set(value As Guid)
      m_Guid = value
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

  Public Sub New()
    m_Guid = System.Guid.Empty
    Nombre = String.Empty
  End Sub

  Public Function ToListOfString() As List(Of String)
    Try
      Return New List(Of String) From {m_Guid.ToString, m_Nombre}

    Catch ex As Exception
      Print_msg(ex.Message)
      Return New List(Of String)
    End Try
  End Function
End Class
