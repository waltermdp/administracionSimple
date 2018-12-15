Imports libCommon.Comunes
Public Class clsInfoCliente
  Implements ICloneable

  Private m_Personal As ClsInfoPersona
  Private m_ListaProducto As New List(Of clsInfoProducto)



  Public Property Personal() As ClsInfoPersona
    Get
      Return m_Personal
    End Get
    Set(ByVal value As ClsInfoPersona)
      m_Personal = value
    End Set
  End Property

  Public Property ListaProductos As List(Of clsInfoProducto)
    Get
      Return m_ListaProducto
    End Get
    Set(value As List(Of clsInfoProducto))
      m_ListaProducto = value.ToList
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    Try
      m_Personal = New ClsInfoPersona
      m_ListaProducto.Clear()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoCliente) Then
      Return CType(obj, clsInfoCliente).Personal.GuidCliente.Equals(Me.Personal.GuidCliente)
    Else
      Return False
    End If

  End Function

#Region "Interfaz ICloneable"

  Public Function Clone() As clsInfoCliente

    Return CType(ClonePrivate(), clsInfoCliente)

  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoCliente


    objResult = CType(Me.MemberwiseClone, clsInfoCliente)
    objResult.Personal = Me.Personal.Clone
    objResult.ListaProductos = Me.ListaProductos
    

    Return objResult

  End Function

#End Region


End Class
