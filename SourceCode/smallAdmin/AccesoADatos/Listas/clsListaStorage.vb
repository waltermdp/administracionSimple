﻿Public Class clsListaStorage
  Implements ICloneable
  Implements IComparable(Of clsListaStorage)

  Private m_Nombre As String
  Private m_Codigo As String
  Private m_Descripcion As String
  Private m_Responsable As String
  Private m_GuidResponsable As Guid
  Private m_GuidArticulo As Guid
  Private m_Cantidad As Integer
  Private m_Precio As Decimal
  Private m_CodigoBarras As String



  Public Property GuidArticulo As Guid
    Get
      Return m_GuidArticulo
    End Get
    Set(value As Guid)
      m_GuidArticulo = value
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

  Public Property Codigo As String
    Get
      Return m_Codigo
    End Get
    Set(value As String)
      m_Codigo = value
    End Set
  End Property

  Public Property CodigoBarras As String
    Get
      Return m_CodigoBarras
    End Get
    Set(value As String)
      m_CodigoBarras = value
    End Set
  End Property

  Public Property Descripcion As String
    Get
      Return m_Descripcion
    End Get
    Set(value As String)
      m_Descripcion = value
    End Set
  End Property

  Public Property Responsable As String
    Get
      Return m_Responsable
    End Get
    Set(value As String)
      m_Responsable = value
    End Set
  End Property

  Public Property Cantidad As Integer
    Get
      Return m_Cantidad
    End Get
    Set(value As Integer)
      m_Cantidad = value
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

  Public Property Precio As Decimal
    Get
      Return m_Precio
    End Get
    Set(value As Decimal)
      m_Precio = value
    End Set
  End Property

  Public Sub New()
    GuidArticulo = Nothing
    Nombre = "--"
    Codigo = "--"
    Descripcion = "--"
    Responsable = "--"
    Cantidad = 0
    GuidResponsable = Nothing
    CodigoBarras = "--"
    Precio = 0
  End Sub

  Public Overrides Function Equals(obj As Object) As Boolean
    If obj.GetType Is GetType(clsListaStorage) Then
      Return (CType(obj, clsListaStorage).GuidArticulo.Equals(Me.GuidArticulo) AndAlso CType(obj, clsListaStorage).GuidResponsable.Equals(Me.GuidResponsable))
    Else
      Return False
    End If
  End Function

#Region "Interface: ICloneable"

  Private Function ClonePrivate() As Object Implements ICloneable.Clone
    'Clonación Superficial
    Return Me.MemberwiseClone()
  End Function

  Public Function Clone() As clsListaStorage
    Return CType(ClonePrivate(), clsListaStorage)
  End Function

#End Region

  Public Function CompareTo(ByVal other As clsListaStorage) As Integer Implements IComparable(Of clsListaStorage).CompareTo
    Return Responsable.CompareTo(other.Responsable)
    '=0
    'own < other return -1
    'own > other return 1
    
  End Function


End Class
