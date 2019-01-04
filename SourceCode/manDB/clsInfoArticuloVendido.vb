Public Class clsInfoArticuloVendido
  Inherits clsInfoArticulos
  Implements ICloneable

  Private m_CantidadArticulos As Integer

  Public Property CantidadArticulos As Integer
    Get
      Return m_CantidadArticulos
    End Get
    Set(value As Integer)
      m_CantidadArticulos = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    m_CantidadArticulos = -1
  End Sub

  Public Sub copy(ByVal vArticulo As clsInfoArticulos)
    Try
      If vArticulo Is Nothing Then Exit Sub
      With Me
        .IdArticulo = vArticulo.IdArticulo
        .GuidArticulo = vArticulo.GuidArticulo
        .Nombre = vArticulo.Nombre
        .Codigo = vArticulo.Codigo
        .Descripcion = vArticulo.Descripcion
      End With
      Me.CantidadArticulos = -1

    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("{0},({1})", Nombre, Codigo)
  End Function

  Public Overrides Function Equals(ByVal obj As Object) As Boolean

    If obj.GetType Is GetType(clsInfoArticuloVendido) Then
      Return CType(obj, clsInfoArticuloVendido).GuidArticulo.Equals(Me.GuidArticulo)
    Else
      Return False
    End If

  End Function

#Region "Interfaz ICloneable"
  Public Overloads Function Clone() As clsInfoArticuloVendido
    Return CType(ClonePrivate(), clsInfoArticuloVendido)
  End Function
  Private Function ClonePrivate() As Object

    Dim objResult As New clsInfoArticuloVendido

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoArticuloVendido)

    Return objResult

  End Function

#End Region

End Class
