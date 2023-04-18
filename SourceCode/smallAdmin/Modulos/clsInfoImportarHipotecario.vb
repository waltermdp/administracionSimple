Imports libCommon.Comunes

Public Class clsInfoImportarHipotecario

  Private m_NroAbonado As Integer
  Private m_NroCuenta As Decimal
  Private m_cuota As Integer
  Private m_FechaDebito As Date
  Private m_ImporteADebitar As Decimal
  Private m_importeDebitado As Decimal
  Private m_ImporteBH As Decimal
  Private m_MotivoRechazo As String
  Private m_Importar As Boolean

  Public Property NroAbonado As Integer
    Get
      Return m_NroAbonado
    End Get
    Set(value As Integer)
      m_NroAbonado = value
    End Set
  End Property
  Public Property NroCuenta As Decimal
    Get
      Return m_NroCuenta
    End Get
    Set(value As Decimal)
      m_NroCuenta = value
    End Set
  End Property
  Public Property cuota As Integer
    Get
      Return m_cuota
    End Get
    Set(value As Integer)
      m_cuota = value
    End Set
  End Property
  Public Property FechaDebito As Date
    Get
      Return m_FechaDebito
    End Get
    Set(value As Date)
      m_FechaDebito = value
    End Set
  End Property
  Public Property ImporteADebitar As Decimal
    Get
      Return m_ImporteADebitar
    End Get
    Set(value As Decimal)
      m_ImporteADebitar = value
    End Set
  End Property
  Public Property importeDebitado As Decimal
    Get
      Return m_importeDebitado
    End Get
    Set(value As Decimal)
      m_importeDebitado = value
    End Set
  End Property
  Public Property ImporteBH As Decimal
    Get
      Return ImporteBH
    End Get
    Set(value As Decimal)
      m_ImporteBH = value
    End Set
  End Property
  Public Property MotivoRechazo As String
    Get
      Return m_MotivoRechazo
    End Get
    Set(value As String)
      m_MotivoRechazo = value
    End Set
  End Property

  Public Property Importar As Boolean
    Get
      Return m_Importar
    End Get
    Set(value As Boolean)
      m_Importar = value
    End Set
  End Property


  Public Sub New()
    Try
      m_NroAbonado = 0
      m_NroCuenta = 0
      m_cuota = 0
      m_FechaDebito = g_Today
      m_ImporteADebitar = 0
      m_importeDebitado = 0
      m_ImporteBH = 0
      m_MotivoRechazo = ""
      m_Importar = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
