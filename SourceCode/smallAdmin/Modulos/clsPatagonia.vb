Imports libCommon.Comunes
Imports manDB
Public Class clsPatagonia
  'header
  Private m_NroCuitEmpresa As Decimal
  Private m_Producto As String
  Private m_FechaPresentacion As Date
  Private m_Reserva As String

  Private m_OrigenComercial As Decimal
  Private m_RazonSocial As String
  'body

  'tail
  'T
  Private m_CantidadRegistros As Decimal
  Private m_ImporteTotal As Decimal

  Public Property Producto As String
    Get
      Return m_Producto
    End Get
    Set(value As String)
      m_Producto = value
    End Set
  End Property

  Public Property RazonSocial As String
    Get
      Return m_RazonSocial
    End Get
    Set(value As String)
      m_RazonSocial = value
    End Set
  End Property

  Public Property FechaPresentacion As Date
    Get
      Return m_FechaPresentacion
    End Get
    Set(value As Date)
      m_FechaPresentacion = value
    End Set
  End Property

  Public Property NroCuitEmpresa As Decimal
    Get
      Return m_NroCuitEmpresa
    End Get
    Set(value As Decimal)
      m_NroCuitEmpresa = value
    End Set
  End Property

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
      If GenerarHeaderDebito(auxLinea, ImporteTotal, m_FechaGeneracion, m_Secuencial) <> Result.OK Then
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

  Public Function GetFileNameExport(ByRef rName As String) As Result
    Try
      'ORIddmms.nnn (ddmm/Dia/Mes - s/Secuencia -nnn/Numero de Origen)
      rName = "ORI" & m_FechaPresentacion.ToString("ddMM") & "0" & "." & m_OrigenComercial.ToString("000")
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "Patagonia")
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

      sResult += vRegistro.TipoNovedad.ToString                         '1
      sResult += vRegistro.Cuit_DNI.ToString("00000000000")             '11
      sResult += vRegistro.CBU.ToString("0000000000000000000000")       '22
      sResult += String.Format("{0,-22}", vRegistro.ID_Cliente_Empresa) '22
      sResult += vRegistro.FechaVto.ToString("ddMMyyyy")                '8
      sResult += String.Format("{0,-10}", vRegistro.Producto)           '10 
      sResult += String.Format("{0,-15}", vRegistro.ReferenciaDebito)   '15
      sResult += CDec(vRegistro.Importe * 100).ToString("0000000000")   '11
      sResult += vRegistro.TipoMoneda.ToString                          '1
      sResult += String.Format("{0,25}", " ")                           '25
      sResult += vRegistro.NroCuitEmpresa.ToString("00000000000")       '11
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
      m_NroCuitEmpresa = 0
      m_OrigenComercial = 100
      m_FechaPresentacion = g_Today
      m_Reserva = "ORI21040.100"
      m_RazonSocial = "EDIT EL FARO"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

End Class
