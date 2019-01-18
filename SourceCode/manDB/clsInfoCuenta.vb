Public Class clsInfoCuenta
  Implements ICloneable

  Private m_IdCuenta As Integer
  Private m_GuidCliente As Guid
  Private m_GuidCuenta As Guid
  Private m_Codigo1 As String
  Private m_Codigo2 As String
  Private m_Codigo3 As String
  Private m_Codigo4 As String
  Private m_TipoDeCuenta As Guid

  Public Delegate Function delToString(ByVal vGuidTipoCuenta As Guid) As String
  Private m_del As delToString = Nothing

  Public Property IdCuenta As Integer
    Get
      Return m_IdCuenta
    End Get
    Set(value As Integer)
      m_IdCuenta = value
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

  Public Property GuidCuenta As Guid
    Get
      Return m_GuidCuenta
    End Get
    Set(value As Guid)
      m_GuidCuenta = value
    End Set
  End Property

  Public Property Codigo1 As String
    Get
      Return m_Codigo1
    End Get
    Set(value As String)
      m_Codigo1 = value
    End Set
  End Property

  Public Property Codigo2 As String
    Get
      Return m_Codigo2
    End Get
    Set(value As String)
      m_Codigo2 = value
    End Set
  End Property
  Public Property Codigo3 As String
    Get
      Return m_Codigo3
    End Get
    Set(value As String)
      m_Codigo3 = value
    End Set
  End Property
  Public Property Codigo4 As String
    Get
      Return m_Codigo4
    End Get
    Set(value As String)
      m_Codigo4 = value
    End Set
  End Property


  Public Property TipoDeCuenta As Guid
    Get
      Return m_TipoDeCuenta
    End Get
    Set(value As Guid)
      m_TipoDeCuenta = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    IdCuenta = -1
    GuidCliente = Nothing
    GuidCuenta = Nothing
    Codigo1 = "--"
    Codigo2 = "--"
    Codigo3 = "--"
    Codigo4 = "--"
    TipoDeCuenta = Nothing
  End Sub

 

  Public Sub SetDelegadoCustomString(ByRef vSub As delToString)
    Try
      m_del = vSub
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Public Overrides Function ToString() As String
    Try
      If m_del Is Nothing Then
        Return Codigo1.ToString
      Else
        Return m_del.Invoke(m_TipoDeCuenta) & " -- " & Codigo1.ToString
      End If
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return "--"
    End Try


  End Function

  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoCuenta) Then
      Return CType(obj, clsInfoCuenta).GuidCuenta.Equals(Me.GuidCuenta)
    Else
      Return False
    End If

  End Function

  Public Function Clone() As clsInfoCuenta
    Return CType(ClonePrivate(), clsInfoCuenta)
  End Function

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    Dim objResult As New clsInfoCuenta
    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoCuenta)
    Return objResult
  End Function
End Class
