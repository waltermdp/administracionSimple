Imports libCommon.Comunes
Public Class clsHipotecario

  Private Const NROCONVENIO As Integer = 6248
  Private Const MONEDA As Integer = 80
  Private Const TIPOMOV As Integer = 1 '01 debitos 05 revisiones debito

  Private NROSERVICIO As String = " "
  Private NROEMPRESA As Integer = 0
  Private TIPOCUENTA As String = " "
  Private IDDEBITO As String = "COBROCUOTA"
  Private FECHATOPE As String = "00000000"
  Private DATOSRETORNO As String = "CUOTA"

  Private m_FechaGeneracion As Date
  Private m_Secuencial As Decimal

  Public ReadOnly Property Convenio As Integer
    Get
      Return NROCONVENIO
    End Get
  End Property

  Public Property FechaGeneracion As Date
    Get
      Return m_FechaGeneracion
    End Get
    Set(value As Date)
      m_FechaGeneracion = value
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

  Public Sub New()
    Try
      m_FechaGeneracion = g_Today
      m_Secuencial = 2
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoHipotecario), ByRef rlineas As List(Of String)) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0
      ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)
      If GenerarHeaderDebito(auxLinea, ImporteTotal, m_FechaGeneracion, m_Secuencial) <> Result.OK Then
        MsgBox("No se puede generar encabezado de debito Hipotecario")
        Return Result.NOK
      End If
      lstResult.Add(auxLinea)
      For Each mov In vlstRegistros
        auxLinea = String.Empty

        If GenerarDetalle(mov, auxLinea) <> Result.OK Then
          MsgBox("No se puede generar encabezado de debito Hipotecario")
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
      sResult += NROCONVENIO.ToString("D5")
      sResult += String.Format("{0,10}", " ")
      sResult += New String("0"c, 5) ' String.Format("D5", "0")
      sResult += vFechaGen.ToString("yyyyMMdd")
      sResult += vImporteTotal.ToString("D18")
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
      sResult += NROCONVENIO.ToString("D5")
      sResult += String.Format("{0,10}", " ")
      sResult += NROEMPRESA.ToString("D5")
      sResult += vMov.CodigoBanco.ToString("D3")
      sResult += vMov.CodigoSucCuenta.ToString("D4") 'vMov.CBU.Substring(0, 4) ' codsucCuenta.ToString("D4")
      sResult += String.Format("{0,1}", vMov.TipoCuenta)
      sResult += vMov.CuentaBanco.ToString("000000000000000") ' CBU.Substring(0, 15) 'cuentabanc.ToString("D15")
      sResult += String.Format("{0,-22}", vMov.NumeroComprobante)
      sResult += String.Format("{0,-15}", IDDEBITO)
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
      sResult += String.Format("{0,-40}", DATOSRETORNO)
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
