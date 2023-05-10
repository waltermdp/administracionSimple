Imports libCommon.Comunes
Public Class clsHipotecario

  'Private Const NROCONVENIO As Integer = 6248
  Private Const MONEDA As Integer = 80
  Private Const TIPOMOV As Integer = 1 '01 debitos 05 revisiones debito

  Private NROSERVICIO As String = " "
  Private NROEMPRESA As Integer = 0
  Private TIPOCUENTA As String = " "
  'Private IDDEBITO As String = "COBROCUOTA"
  Private FECHATOPE As String = "00000000"
  'Private DATOSRETORNO As String = "CUOTA"
  Private m_Convenio As Integer
  Private m_IdDebito As String
  Private m_Concepto As String

  Private m_FechaGeneracion As Date
  Private m_FechaVencimiento As Date
  Private m_Secuencial As Decimal

  Public Property Convenio As Integer
    Get
      Return m_Convenio
    End Get
    Set(value As Integer)
      m_Convenio = value
    End Set
  End Property

  Public Property FechaGeneracion As Date
    Get
      Return m_FechaGeneracion
    End Get
    Set(value As Date)
      m_FechaGeneracion = value
    End Set
  End Property

  Public Property FechaVencimiento As Date
    Get
      Return m_FechaVencimiento
    End Get
    Set(value As Date)
      m_FechaVencimiento = value
    End Set
  End Property

  Public Property Secuencial As Decimal
    Get
      Return m_Secuencial
    End Get
    Set(value As Decimal)
      m_Secuencial = value
    End Set
  End Property

  Public Property ID_Debito As String
    Get
      Return m_IdDebito
    End Get
    Set(value As String)
      m_IdDebito = value
    End Set
  End Property

  Public Property Concepto As String
    Get
      Return m_Concepto
    End Get
    Set(value As String)
      m_Concepto = value
    End Set
  End Property

  Public Sub New()
    Try
      m_FechaGeneracion = g_Today
      m_FechaVencimiento = g_Today.AddDays(2)
      m_Secuencial = 0
      m_Convenio = 6248
      m_IdDebito = "COBROCUOTA"
      m_Concepto = "CUOTA"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoHipotecario), ByRef rlineas As List(Of String)) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0
      If m_Concepto.Length > 40 Then
        MsgBox("La longitud del campo CONCEPTO debe ser menor o igual a 40 caracteres")
        Return Result.NOK
      End If
      If m_IdDebito.Length > 15 Then
        MsgBox("La longitud del campo ID_DEBITO debe ser menor o igual a 15 caracteres")
        Return Result.NOK
      End If
      If m_Convenio <= 0 OrElse m_Convenio > 99999 Then
        MsgBox("El valor del campo CONVENIO debe estar entre 1 y 99999")
        Return Result.NOK
      End If
      If m_Secuencial < 0 OrElse m_Secuencial > 999 Then
        MsgBox("El valor del campo SECUENCIAL debe estar entre 0 y 999")
        Return Result.NOK
      End If
      If m_FechaVencimiento < m_FechaGeneracion Then
        MsgBox("La Fecha de vencimiento es menor que la fecha actual")
        Return Result.NOK
      End If


      ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)
      If GenerarHeaderDebito(auxLinea, CInt(ImporteTotal), m_FechaGeneracion, CInt(m_Secuencial)) <> Result.OK Then
        MsgBox("No se puede generar encabezado de debito Hipotecario")
        Return Result.NOK
      End If
      lstResult.Add(auxLinea)
      For Each mov In vlstRegistros
        auxLinea = String.Empty

        If GenerarDetalle(mov, auxLinea) <> Result.OK Then
          MsgBox("No se puede generar el registro de debito Hipotecario")
          Return Result.NOK
        End If
        lstResult.Add(auxLinea)
      Next
      rlineas = New List(Of String)
      rlineas.AddRange(lstResult.ToList)
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Function GenerarHeaderDebito(ByRef rHeader As String, ByVal vImporteTotal As Integer, ByVal vFechaGen As Date, ByVal vSecuencial As Integer) As Result
    Try
      Dim sResult As String = String.Empty

      sResult += "1"
      sResult += m_Convenio.ToString("D5")
      sResult += String.Format("{0,10}", " ")
      sResult += New String("0"c, 5) ' String.Format("D5", "0")
      sResult += vFechaGen.ToString("yyyyMMdd")
      sResult += (vImporteTotal * 100).ToString("D18")
      sResult += MONEDA.ToString("D3")
      sResult += TIPOMOV.ToString("D2")
      sResult += vSecuencial.ToString("D3")
      sResult += New String("0"c, 95) 'String.Format("D95", "0")
      sResult += String.Format("{0,69}", " ")
      sResult += "0"
      rHeader = sResult

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFileNameExport(ByRef rName As String) As Result
    Try
      Dim aux As String = Secuencial.ToString("000")
      rName = "ent" & m_Convenio.ToString & "_" & FechaGeneracion.ToString("yyMMdd") & "_sec_" & Secuencial.ToString("000") & ".txt"
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "Hipotecario")
      If Not IO.Directory.Exists(pathExportacion) Then
        IO.Directory.CreateDirectory(pathExportacion)
        If Not IO.Directory.Exists(pathExportacion) Then
          Return EXPORT_PATH
        End If
      End If
      Return pathExportacion
    Catch ex As Exception
      Print_msg(ex.Message)
      Return EXPORT_PATH
    End Try
  End Function

  Private Function GenerarDetalle(ByVal vMov As clsInfoHipotecario, ByRef rBody As String) As Result
    Try
      Dim sResult As String = String.Empty
      'Dim codBanco As Integer = 888 '!!!consultar
      'Dim codsucCuenta As integer=4 'CBU
      'Dim cuentabanc As Integer = 5 'CBU 
      'Dim IDActualCliente As String = "14000"
      'Dim fechaVencimiento As Date = Today '!!!!sumar n dias a la fecha actual
      'Dim importeadebitar As Integer = 3400 'sin decimal

      sResult += "0"
      sResult += m_Convenio.ToString("D5")
      sResult += String.Format("{0,10}", " ")
      sResult += NROEMPRESA.ToString("D5")
      sResult += vMov.CodigoBanco.ToString("D3")
      sResult += vMov.CodigoSucCuenta.ToString("D4") 'vMov.CBU.Substring(0, 4) ' codsucCuenta.ToString("D4")
      sResult += String.Format("{0,1}", vMov.TipoCuenta)
      sResult += vMov.CuentaBanco.ToString("000000000000000") ' CBU.Substring(0, 15) 'cuentabanc.ToString("D15")
      sResult += String.Format("{0,-22}", vMov.NumeroContrato)
      sResult += String.Format("{0,-15}", m_IdDebito)
      sResult += String.Format("{0,2}", " ")
      sResult += String.Format("{0,4}", " ")
      sResult += vMov.FechaVencimiento.ToString("yyyyMMdd")
      sResult += MONEDA.ToString("D3")
      sResult += CInt(vMov.Importe * 100).ToString("D13")
      sResult += FECHATOPE 'fechatope.ToString("yyyyMMdd")
      sResult += New String("0"c, 13)
      sResult += New String("0"c, 4)
      sResult += New String("0"c, 1)
      sResult += New String("0"c, 15)
      sResult += String.Format("{0,22}", " ")
      sResult += String.Format("{0,-40}", m_Concepto)
      sResult += String.Format("{0,5}", " ")
      sResult += "0"
      rBody = sResult

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
End Class
