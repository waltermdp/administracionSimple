﻿Imports libCommon.Comunes

Public Class clsTipoPago

  Private m_GuidTipoPago As Guid
  Private m_Nombre As String

  'TODO: VALIDAR

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


  Public Sub New()
    Try
      m_Nombre = ""
      m_GuidTipoPago = Guid.Empty
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

End Class
