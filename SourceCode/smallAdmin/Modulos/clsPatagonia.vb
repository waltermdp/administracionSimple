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
  Private m_FechaVto As Date
  Private m_ReferenciaDebito As String

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

  Public Property ReferenciaDebito As String
    Get
      Return m_ReferenciaDebito
    End Get
    Set(value As String)
      m_ReferenciaDebito = value
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

  Public Property FechaVencimiento As Date
    Get
      Return m_FechaVto
    End Get
    Set(value As Date)
      m_FechaVto = value
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



  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoPatagonia), ByRef rlineas As List(Of String)) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0
      If m_Producto.Length > 10 Then
        MsgBox("La longitud del campo PRODUCTO debe ser menor o igual a 10 caracteres")
        Return Result.NOK
      End If
      If m_RazonSocial.Length > 35 Then
        MsgBox("La longitud del campo RAZON SOCIAL debe ser menor o igual a 35 caracteres")
        Return Result.NOK
      End If
      'If m_Convenio <= 0 OrElse m_Convenio > 99999 Then
      '  MsgBox("El valor del campo CONVENIO debe estar entre 1 y 99999")
      '  Return Result.NOK
      'End If
      'If m_Secuencial < 0 OrElse m_Secuencial > 999 Then
      '  MsgBox("El valor del campo SECUENCIAL debe estar entre 0 y 999")
      '  Return Result.NOK
      'End If
      'If m_FechaVto < m_FechaPresentacion Then
      '  MsgBox("La Fecha de vencimiento es menor que la fecha de presentacion")
      '  Return Result.NOK
      'End If


      ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)
      If GenerateHeader(auxLinea) <> Result.OK Then
        MsgBox("No se puede generar encabezado del debito")
        Return Result.NOK
      End If
      lstResult.Add(auxLinea)
      For Each mov In vlstRegistros
        auxLinea = String.Empty
        mov.ReferenciaDebito = m_ReferenciaDebito
        mov.FechaVto = m_FechaVto
        If GenerateRegistros(mov, auxLinea) <> Result.OK Then
          MsgBox("No se puede generar el registro de debito Hipotecario")
          Return Result.NOK
        End If
        lstResult.Add(auxLinea)
      Next

      If GenerateTail(vlstRegistros.Count, ImporteTotal, auxLinea) <> Result.OK Then
        MsgBox("No se puede generar final del archivo de debito")
        Return Result.NOK
      End If
      lstResult.Add(auxLinea)
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
      m_Reserva = GetReserva()
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
      sResult += String.Format("{0,-22}", vRegistro.Contrato.ToString.PadLeft(11, "0"c)) '22
      sResult += vRegistro.FechaVto.ToString("ddMMyyyy")                '8
      sResult += String.Format("{0,-10}", vRegistro.Producto)           '10 
      sResult += String.Format("{0,15}", " ")
      sResult += String.Format("{0,-15}", vRegistro.ReferenciaDebito)   '15
      sResult += CDec(vRegistro.Importe * 100).ToString("0000000000")   '10
      sResult += vRegistro.TipoMoneda.ToString                          '1
      sResult += String.Format("{0,22}", " ")                           '22
      sResult += String.Format("{0,2}", " ")
      sResult += String.Format("{0,11}", " ")
      sResult += String.Format("{0,1}", " ")
      sResult += String.Format("{0,3}", " ")
      sResult += String.Format("{0,3}", " ")
      '74
      sResult += String.Format("{0,7}", " ")
      sResult += String.Format("{0,8}", " ")
      sResult += String.Format("{0,8}", " ")
      sResult += String.Format("{0,9}", " ")
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

  Private Function GetReserva() As String
    Try
      Return String.Format("ORI{0}{1}.100", m_FechaPresentacion.ToString("ddMM"), "0")
    Catch ex As Exception
      Print_msg(ex.Message)
      Return String.Format("ORI{0}{1}.100", Today.ToString("ddMM"), "0")
    End Try
  End Function

  Public Sub New()
    Try
      m_Producto = "CUOTA"
      m_NroCuitEmpresa = 30716028956
      m_OrigenComercial = 100
      m_FechaPresentacion = g_Today
      m_FechaVto = g_Today.AddDays(2)
      m_Reserva = GetReserva()
      m_RazonSocial = "EDIT EL FARO"
      m_ReferenciaDebito = "EDIT EL FARO"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

End Class
