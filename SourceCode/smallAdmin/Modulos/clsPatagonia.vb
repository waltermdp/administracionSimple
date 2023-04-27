Imports libCommon.Comunes
Imports manDB
Public Class clsPatagonia



  Private Function GenerateHeader() As Result
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
End Class
