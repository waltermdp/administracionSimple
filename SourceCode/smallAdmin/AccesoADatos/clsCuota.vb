Imports libCommon.Comunes

Public Class clsCuota
  Private m_GuidCuota As Guid
  Private m_Nombre As String
  Private m_Valor As Integer

  'TODO: VALIDAR

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
    End Set
  End Property

  Public Property Cantidad As Integer
    Get
      Return m_Valor
    End Get
    Set(value As Integer)
      m_Valor = value
    End Set
  End Property

  Public Property GuidCuota As Guid
    Get
      Return m_GuidCuota
    End Get
    Set(value As Guid)
      m_GuidCuota = value
    End Set
  End Property


  Public Sub New()
    Try
      m_Nombre = String.Empty
      m_Valor = -1
      m_GuidCuota = Guid.Empty
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Public Overrides Function ToString() As String
    Return m_Nombre
  End Function



  Public Function EsValido() As Boolean
    Try
      If m_Nombre = String.Empty Then
        Return False
      End If
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Public Overrides Function Equals(ByVal obj As Object) As Boolean
    Try
      Dim bEq As Boolean

      bEq = True
      If obj.GetType Is GetType(clsCuota) Then

        bEq = bEq And CType(obj, clsCuota).Nombre.Equals(Me.Nombre)
        bEq = bEq And CType(obj, clsCuota).GuidCuota.Equals(Me.GuidCuota)
        bEq = bEq And CType(obj, clsCuota).Cantidad.Equals(Me.Cantidad)

      Else
        bEq = False
      End If
      Return bEq
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function
End Class
