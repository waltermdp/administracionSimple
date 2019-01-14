
Imports manDB
Imports libCommon.Comunes

Public Class clsInfoResumen

  Private m_Cliente As ClsInfoPersona
  Private m_Producto As clsInfoProducto
  Private m_Pago As clsInfoPagos
  Private m_Estado As E_EstadoPago


  Public Property Cliente As ClsInfoPersona
    Get
      Return m_Cliente
    End Get
    Set(value As ClsInfoPersona)
      m_Cliente = value.Clone
    End Set
  End Property

  Public Property Producto As clsInfoProducto
    Get
      Return m_Producto
    End Get
    Set(value As clsInfoProducto)
      m_Producto = value.Clone
    End Set
  End Property

  Public Property Pago As clsInfoPagos
    Get
      Return m_Pago
    End Get
    Set(value As clsInfoPagos)
      m_Pago = value.Clone
    End Set
  End Property

  Public Property Estado As E_EstadoPago
    Get
      Return m_Estado
    End Get
    Set(value As E_EstadoPago)
      m_Estado = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    Cliente = New ClsInfoPersona
    Producto = New clsInfoProducto
    Pago = New clsInfoPagos
  End Sub

End Class
