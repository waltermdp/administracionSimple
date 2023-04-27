Imports libCommon.Comunes
Imports manDB
Public Class clsPatagonia
  'header
  Private m_NroCuitEmpresa As Decimal
  Private m_Producto As String
  Private m_OrigenComercial As Decimal
  Private m_FechaPresentacion As Date
  Private m_Reserva As String
  Private m_RazonSocial As String
  'body

  'tail
  'T
  Private m_CantidadRegistros As Decimal
  Private m_ImporteTotal As Decimal


  Private Function GenerateHeader(ByRef rLinea As String) As Result
    Try
      Dim sResult As String = String.Empty

      sResult += "H"
      sResult += m_NroCuitEmpresa.ToString("00000000000")
      sResult += String.Format("{0,-10}", m_Producto)       'longitud=10
      sResult += m_OrigenComercial.ToString("000")
      sResult += m_FechaPresentacion.ToString("ddMMyyyy")
      sResult += String.Format("{0,-12}", m_Reserva)
      sResult += String.Format("{0,-35}", m_RazonSocial)
      sResult += String.Format("{0,120}", " ")

      rLinea = sResult
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GenerateRegistros(ByVal vRegistro As clsInfoPatagonia, ByRef rlinea As String) As Result
    Try
      Dim sResult As String = String.Empty

      sResult += vRegistro.ToString()
      sResult += vRegistro.vRegistro.vNroCasos.ToString("0000000")                            '7
      'sResult += CDec(vImporteTotal * 100).ToString("000000000000000")    '15
      'sResult += String.Format("{0,177}", " ")

      rlinea = sResult
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GenerateTail(ByVal vNroCasos As Decimal, ByVal vImporteTotal As Decimal, ByRef rlinea As String) As Result
    Try
      Dim sResult As String = String.Empty

      sResult += "T"
      sResult += vNroCasos.ToString("0000000")                            '7
      sResult += CDec(vImporteTotal * 100).ToString("000000000000000")    '15
      sResult += String.Format("{0,177}", " ")

      rlinea = sResult
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Sub New()
    Try
      m_Producto = "CUOTA"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

End Class
