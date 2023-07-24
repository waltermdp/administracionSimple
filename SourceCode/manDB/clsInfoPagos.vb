Public Class clsInfoPagos
  Implements ICloneable


  Private m_IdPago As Integer
  Private m_GuidProducto As Guid
  Private m_GuidPago As Guid
  Private m_NumCuota As Integer
  Private m_ValorCuota As Decimal
  Private m_VencimientoCuota As Date
  Private m_FechaPago As Date
  Private m_EstadoPago As libCommon.Comunes.E_EstadoPago
  Private m_NumComprobante As Integer
  Private m_FechaUltimaExportacion As Date
  Private m_FechaUltimaImportacion As Date
  Private m_GuidCuenta As Guid
  Private m_MetodoPago As String

  Public Property MetodoDePago As String
    Get
      Return m_MetodoPago
    End Get
    Set(value As String)
      m_MetodoPago = value
    End Set
  End Property



  Public Property FechaUltimaExportacion As Date
    Get
      Return m_FechaUltimaExportacion
    End Get
    Set(value As Date)
      m_FechaUltimaExportacion = value
    End Set
  End Property

  Public Property FechaUltimaImportacion As Date
    Get
      Return m_FechaUltimaImportacion
    End Get
    Set(value As Date)
      m_FechaUltimaImportacion = value
    End Set
  End Property



  Public Property IdPago As Integer
    Get
      Return m_IdPago
    End Get
    Set(value As Integer)
      m_IdPago = value
    End Set
  End Property

  Public Property NumComprobante As Integer
    Get
      Return m_NumComprobante
    End Get
    Set(value As Integer)
      m_NumComprobante = value
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

  Public Property GuidPago As Guid
    Get
      Return m_GuidPago
    End Get
    Set(value As Guid)
      m_GuidPago = value
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

  Public Property NumCuota As Integer
    Get
      Return m_NumCuota
    End Get
    Set(value As Integer)
      m_NumCuota = value
    End Set
  End Property

  Public Property ValorCuota As Decimal
    Get
      Return m_ValorCuota
    End Get
    Set(value As Decimal)
      m_ValorCuota = value
    End Set
  End Property

  Public Property VencimientoCuota As Date
    Get
      Return m_VencimientoCuota
    End Get
    Set(value As Date)
      m_VencimientoCuota = value
    End Set
  End Property

  Public Property FechaPago As Date
    Get
      Return m_FechaPago
    End Get
    Set(value As Date)
      m_FechaPago = value
    End Set
  End Property

  Public Property EstadoPago As libCommon.Comunes.E_EstadoPago
    Get
      Return m_EstadoPago
    End Get
    Set(value As libCommon.Comunes.E_EstadoPago)
      m_EstadoPago = value
    End Set
  End Property


  'FECHAS para datagridview
  Public ReadOnly Property toFechaDePago As String
    Get
      Return Date2String(m_FechaPago)
    End Get
  End Property

  Public ReadOnly Property toFechaDeVencimiento As String
    Get
      Return Date2String(m_VencimientoCuota)
    End Get
  End Property

  Public ReadOnly Property toFechaUltimaExportacion As String
    Get
      Return Date2String(m_FechaUltimaExportacion)
    End Get
  End Property

  Public ReadOnly Property toFechaUltimaimportacion As String
    Get
      Return Date2String(m_FechaUltimaImportacion)
    End Get
  End Property

  Public Function Date2String(ByVal vFecha As Date) As String
    Try

      If vFecha <= Date.MinValue OrElse vFecha.Year < 1950 Then
        Return String.Empty
      Else
        Return vFecha.ToString("dd/MM/yyyy")
      End If
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function

  Public Sub New()
    MyBase.New()
    Try
      IdPago = -1
      GuidPago = Nothing
      GuidProducto = Nothing
      m_GuidCuenta = Guid.Empty
      NumCuota = -1
      ValorCuota = 0
      VencimientoCuota = Nothing
      FechaPago = Nothing
      EstadoPago = libCommon.Comunes.E_EstadoPago.NA
      NumComprobante = -1
      FechaUltimaExportacion = Date.MinValue
      FechaUltimaImportacion = Date.MinValue
      m_MetodoPago = String.Empty
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

#Region "Interfaz ICloneable"
  Public Function Clone() As clsInfoPagos
    Return CType(ClonePrivate(), clsInfoPagos)
  End Function
  Private Function ClonePrivate() As Object Implements ICloneable.Clone

    Dim objResult As New clsInfoPagos

    'Clonación Superficial
    objResult = CType(Me.MemberwiseClone, clsInfoPagos)

    Return objResult

  End Function

#End Region
End Class

Public Class clsModoDebito

  Public Shared GUID_PATAGONIA As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117927")
  Public Shared GUID_HIPOTECARIO As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117926")
  Public Shared GUID_HIPOTECARIO_7464 As New Guid("d1f63b6f-81a0-4699-924b-16a219b44ef7")
  Public Shared GUID_VISA_DEBITO As New Guid("d167e036-b175-4a67-9305-a47c116e8f5c")
  Public Shared GUID_VISA_CREDITO As New Guid("7580f2d4-d9ec-477b-9e3a-50afb7141ab5")
  Public Shared GUID_CBU As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117924")
  Public Shared GUID_EFECTIVO As New Guid("9ebcf274-f84f-42ac-b3de-d375bb3bd314")
  Public Shared GUID_MASTER_DEBITO As New Guid("ea5d6084-90c3-4b66-82b2-9c4816c07523")
  Public Shared GUID_MERCADO_PAGO As New Guid("598878be-b8b3-4b1b-9261-f989f0800afc")

  Public Shared Function ATexto(ByVal vGuid As Guid) As String
    Try
      Select Case vGuid
        Case GUID_PATAGONIA
          Return "Patagonia"
        Case GUID_HIPOTECARIO
          Return "Hipotecario"
        Case GUID_HIPOTECARIO_7464
          Return "Hipotecario_7464"
        Case GUID_VISA_DEBITO
          Return "Visa Debito"
        Case GUID_VISA_CREDITO
          Return "Visa Credito"
        Case GUID_CBU
          Return "CBU"
        Case GUID_EFECTIVO
          Return "Efectivo"
        Case GUID_MASTER_DEBITO
          Return "Master Debito"
        Case GUID_MERCADO_PAGO
          Return "Mercado Pago"
        Case Else
          Return String.Empty
      End Select
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function


End Class
