﻿Public Class clsInfoCuenta
  Implements ICloneable

  Private m_IdCuenta As Integer
  Private m_GuidCliente As Guid
  Private m_GuidCuenta As Guid
  Private m_Codigo1 As String
  Private m_Codigo2 As String
  Private m_Codigo3 As String
  Private m_Codigo4 As String
  Private m_Codigo5 As String
  Private m_Codigo6 As String
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

  Public Property Codigo5 As String
    Get
      Return m_Codigo5
    End Get
    Set(value As String)
      m_Codigo5 = value
    End Set
  End Property
  Public Property Codigo6 As String
    Get
      Return m_Codigo6
    End Get
    Set(value As String)
      m_Codigo6 = value
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
    GuidCliente = Guid.Empty
    GuidCuenta = Guid.Empty
    Codigo1 = "0"
    Codigo2 = "0"
    Codigo3 = "0"
    Codigo4 = "0"
    Codigo5 = "0"
    Codigo6 = "0"
    TipoDeCuenta = Guid.Empty
  End Sub

  Public Function IsValid() As Boolean
    Try
      If IdCuenta < 0 Then Return False
      If GuidCliente = Guid.Empty Then Return False
      If GuidCuenta = Guid.Empty Then Return False
      If TipoDeCuenta = Guid.Empty Then Return False
      Return True
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return False
    End Try
  End Function

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

  Public Function GetSimpleString() As String
    Try

      Return String.Format("{0} - {1}", clsModoDebito.ATexto(m_TipoDeCuenta), Codigo1.ToString)
    Catch ex As Exception
      Return "--"
    End Try
  End Function

  Public Function TipoCuentaToString() As String
    Return clsModoDebito.ATexto(m_TipoDeCuenta)
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
