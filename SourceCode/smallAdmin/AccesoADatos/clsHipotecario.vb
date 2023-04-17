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

  Public ReadOnly Property Convenio As Integer
    Get
      Return NROCONVENIO
    End Get
  End Property




  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoHipotecario), ByRef rlineas As List(Of String), ByVal vSecuencial As Integer) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0
      ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)
      If GenerarHeaderDebito(auxLinea, ImporteTotal, g_Today, vSecuencial) <> Result.OK Then
        MsgBox("No se puede generar encabezado de debito Hipotecario")
        Return Result.NOK
      End If
      lstResult.Add(auxLinea)
      For Each mov In vlstRegistros
        auxLinea = String.Empty

        If GenerarDetalle(mov, 0, g_Today.AddDays(2), auxLinea) <> Result.OK Then
          MsgBox("No se puede generar encabezado de debito Hipotecario")
          Return Result.NOK
        End If
        lstResult.Add(auxLinea)
      Next

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



  Private Function GenerarDetalle(ByVal vMov As clsInfoHipotecario, ByVal vCodBanco As Integer, ByVal vFechaVencimiento As Date, ByRef rBody As String) As Result
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
      sResult += vCodBanco.ToString("D3")
      sResult += vMov.CBU.Substring(0, 4) ' codsucCuenta.ToString("D4")
      sResult += String.Format("{0,1}", TIPOCUENTA)
      sResult += vMov.CBU.Substring(0, 15) 'cuentabanc.ToString("D15")
      sResult += String.Format("{0,-22}", vMov.IdentificadorDebito)
      sResult += String.Format("{0,-15}", IDDEBITO)
      sResult += String.Format("{0,2}", " ")
      sResult += String.Format("{0,4}", " ")
      sResult += vFechaVencimiento.ToString("yyyyMMdd")
      sResult += MONEDA.ToString("D3")
      sResult += CDec(vMov.Importe).ToString("D13")
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
