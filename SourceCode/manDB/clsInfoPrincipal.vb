﻿Imports libCommon.Comunes

Public Class clsInfoPrincipal
  Implements ICloneable

  Private m_FechaVenta As Date
  Private m_GuidProducto As Guid
  Private m_NombreCliente As String
  Private m_NombreVendedor As String
  Private m_Precio As Decimal
  Private m_CuotasTotales As Integer
  Private m_CuotasPagas As Integer
  Private m_Adelanto As Decimal
  Private m_ValorCuotaFija As Decimal
  Private m_ValorCouta As Decimal
  Private m_MetodoPago As String
  Private m_CantidadArticulosVendidos As Integer
  Private m_NumCliente As String
  Private m_NumPago As String
  Private m_FechaUltimoPago As Date


  Public Property FechaVenta As Date
    Get
      Return m_FechaVenta
    End Get
    Set(value As Date)
      m_FechaVenta = value
    End Set
  End Property

  Public Property GuidProducto As Guid
    Get
      Return m_GuidProducto
    End Get
    Set(value As Guid)
      m_GuidProducto = value
    End Set
  End Property

  Public Property Cliente As String
    Get
      Return m_NombreCliente
    End Get
    Set(value As String)
      m_NombreCliente = value
    End Set
  End Property

  Public Property Vendedor As String
    Get
      Return m_NombreVendedor
    End Get
    Set(value As String)
      m_NombreVendedor = value
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

  Public Property CuotasTotales As Integer
    Get
      Return m_CuotasTotales
    End Get
    Set(value As Integer)
      m_CuotasTotales = value
    End Set
  End Property

  Public Property CuotasPagas As Integer
    Get
      Return m_CuotasPagas
    End Get
    Set(value As Integer)
      m_CuotasPagas = value
    End Set
  End Property

  Public Property ValorCuota As Decimal
    Get
      Return m_ValorCouta
    End Get
    Set(value As Decimal)
      m_ValorCouta = value
    End Set
  End Property

  Public Property Adelanto As Decimal
    Get
      Return m_Adelanto
    End Get
    Set(value As Decimal)
      m_Adelanto = value
    End Set
  End Property

  Public Property ValorCuotaFija As Decimal
    Get
      Return m_ValorCuotaFija
    End Get
    Set(value As Decimal)
      m_ValorCuotaFija = value
    End Set
  End Property

  Public Property MetodoPago As String
    Get
      Return m_MetodoPago
    End Get
    Set(value As String)
      m_MetodoPago = value
    End Set
  End Property

  Public Property ArticulosVendidos As Integer
    Get
      Return m_CantidadArticulosVendidos
    End Get
    Set(value As Integer)
      m_CantidadArticulosVendidos = value
    End Set
  End Property

  Public Property NumCliente As String
    Get
      Return m_NumCliente
    End Get
    Set(value As String)
      m_NumCliente = value
    End Set
  End Property

  Public Property Comprobante As String
    Get
      Return m_NumPago
    End Get
    Set(value As String)
      m_NumPago = value
    End Set
  End Property

  Public Property FechaUltimoPago As Date
    Get
      Return m_FechaUltimoPago
    End Get
    Set(value As Date)
      m_FechaUltimoPago = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    FechaVenta = GetAhora
    CuotasPagas = -1
    m_NombreCliente = "--"
    m_GuidProducto = Nothing
    m_ValorCouta = 0
    m_MetodoPago = "--"
    m_CantidadArticulosVendidos = 0
    m_NumCliente = "--"
    m_NumPago = "--"
    m_FechaUltimoPago = Date.MaxValue
  End Sub



#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoPrincipal
    Return CType(ClonePrivate(), clsInfoPrincipal)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoPrincipal

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoPrincipal)

    Return objResult

  End Function

#End Region
End Class
