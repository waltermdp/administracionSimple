Imports libCommon.Comunes

Public Class clsTipoPago
  Implements ICloneable


  Private m_GuidTipoPago As Guid
  Private m_Nombre As String
  Private m_PermiteCuotas As Boolean
  Private m_NombreCodigo1 As String
  Private m_NombreCodigo2 As String
  Private m_NombreCodigo3 As String
  Private m_NombreCodigo4 As String
  Private m_NombreCodigo5 As String
  Private m_NombreCodigo6 As String

  Public Property Nombre As String
    Get
      Return m_Nombre
    End Get
    Set(value As String)
      m_Nombre = value
    End Set
  End Property

  Public Property GuidTipo As Guid
    Get
      Return m_GuidTipoPago
    End Get
    Set(value As Guid)
      m_GuidTipoPago = value
    End Set
  End Property

  Public Property PermiteCuotas As Boolean
    Get
      Return m_PermiteCuotas
    End Get
    Set(value As Boolean)
      m_PermiteCuotas = value
    End Set
  End Property

  Public Property NombreCodigo1 As String
    Get
      Return m_NombreCodigo1
    End Get
    Set(value As String)
      m_NombreCodigo1 = value
    End Set
  End Property

  Public Property NombreCodigo2 As String
    Get
      Return m_NombreCodigo2
    End Get
    Set(value As String)
      m_NombreCodigo2 = value
    End Set
  End Property
  Public Property NombreCodigo3 As String
    Get
      Return m_NombreCodigo3
    End Get
    Set(value As String)
      m_NombreCodigo3 = value
    End Set
  End Property
  Public Property NombreCodigo4 As String
    Get
      Return m_NombreCodigo4
    End Get
    Set(value As String)
      m_NombreCodigo4 = value
    End Set
  End Property

  Public Property NombreCodigo5 As String
    Get
      Return m_NombreCodigo5
    End Get
    Set(value As String)
      m_NombreCodigo5 = value
    End Set
  End Property

  Public Property NombreCodigo6 As String
    Get
      Return m_NombreCodigo6
    End Get
    Set(value As String)
      m_NombreCodigo6 = value
    End Set
  End Property

  Public Sub New()
    Try
      m_Nombre = ""
      m_GuidTipoPago = Guid.Empty
      m_PermiteCuotas = False
      NombreCodigo1 = ""
      NombreCodigo2 = ""
      NombreCodigo3 = ""
      NombreCodigo4 = ""
      NombreCodigo5 = ""
      NombreCodigo6 = ""
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
      If obj.GetType Is GetType(clsTipoPago) Then

        bEq = bEq And CType(obj, clsTipoPago).Nombre.Equals(Me.Nombre)
        bEq = bEq And CType(obj, clsTipoPago).GuidTipo.Equals(Me.GuidTipo)

      Else
        bEq = False
      End If
      Return bEq
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Public Function Clone() As clsTipoPago
    Return CType(ClonePrivate(), clsTipoPago)
  End Function

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New clsTipoPago
    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsTipoPago)
    Return objResult
  End Function
End Class
