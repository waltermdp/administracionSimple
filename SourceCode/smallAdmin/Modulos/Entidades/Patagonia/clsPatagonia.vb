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

  Public m_RegistrosExportar As New List(Of clsInfoPatagonia)
  Private m_GuidTipoPago As Guid

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

  Public Sub New(ByVal vGuidConvenio As Guid)
    Try
      m_Producto = "CUOTA"
      m_NroCuitEmpresa = 30716028956
      m_OrigenComercial = 100
      m_FechaPresentacion = g_Today
      m_FechaVto = g_Today.AddDays(2)
      m_Reserva = GetReserva()
      m_RazonSocial = "EDIT EL FARO"
      m_ReferenciaDebito = "EDIT EL FARO"
      m_GuidTipoPago = vGuidConvenio
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

#Region "Exportacion"

  Public ReadOnly Property countRegistrosAExportar As Integer
    Get
      Return m_RegistrosExportar.Count
    End Get
  End Property

  Public ReadOnly Property ImporteTotalAExportar As String
    Get
      Return m_RegistrosExportar.Sum(Function(c) c.Importe).ToString
    End Get
  End Property

  Public Function CargarContratosAExportar(ByVal win32 As IWin32Window) As Result
    Try
      Dim vResult As Result
      Using objForm As New frmProgreso(AddressOf CargarInicio)
        objForm.ShowDialog(win32)
        vResult = objForm.ResultProcess
      End Using

      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub CargarInicio(ByRef rResult As Result, ByRef rMessage As String)
    Try
      m_RegistrosExportar = New List(Of clsInfoPatagonia)
      rResult = GenerateResumen(m_GuidTipoPago, m_RegistrosExportar)
      rMessage = "Finalizado OK"
    Catch ex As Exception
      Print_msg(ex.Message)
      rResult = Result.ErrorEx
      rMessage = ex.Message
    End Try
  End Sub

  Private Function GenerateResumen(ByVal vGuidPago As Guid, ByRef rRegistros As List(Of clsInfoPatagonia)) As Result
    Try

      Dim lstPago As New clsListPagos
      rRegistros = New List(Of clsInfoPatagonia)
      Dim movimiento As clsInfoPatagonia

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoPatagonia

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "} and GuidTipoPago = {" & vGuidPago.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()
        If lstProducto.Items.Count <= 0 Then Continue For


        Dim lstCuenta As New clsListaCuentas
        lstCuenta.Cfg_Filtro = "where GuidCuenta={" & lstProducto.Items.First.GuidCuenta.ToString & "}"
        lstCuenta.RefreshData()

        Dim lstCliente As New clsListDatabase
        lstCliente.Cfg_Filtro = "where GuidCliente={" & lstProducto.Items.First.GuidCliente.ToString & "}"
        lstCliente.RefreshData()

        Dim bCodigoAlta As Boolean
        If item.NumCuota > 1 Then
          bCodigoAlta = False
        Else
          'verificar si es la primer cuota, buscan si la cuenta se uso en algun pago de cuota
          Dim auxPrimerPago As New clsListProductos
          Dim bAlta As Boolean = True
          auxPrimerPago.Cfg_Filtro = "where GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
          auxPrimerPago.RefreshData()
          If auxPrimerPago.Items.Count > 1 Then

            For Each vProducto In auxPrimerPago.Items
              Dim aux As New clsListPagos
              aux.Cfg_Filtro = "where GuidProducto={" & vProducto.GuidProducto.ToString & "}"
              aux.RefreshData()
              For Each pago In aux.Items
                If pago.EstadoPago = E_EstadoPago.Pago Then
                  bAlta = False
                  Exit For
                End If
              Next
              If bAlta = False Then Exit For
            Next
          End If
          bCodigoAlta = bAlta
        End If

        With movimiento
          .CBU = CDec(lstCuenta.Items.First.Codigo1)
          .Cuit_DNI = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .Contrato = lstProducto.Items.First.NumComprobante
          .Producto = Producto
          .FechaVto = FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          .NroCuitEmpresa = NroCuitEmpresa
          .ReferenciaDebito = ReferenciaDebito
        End With
        rRegistros.Add(movimiento)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GenerarExportacion(ByVal win32 As IWin32Window) As Result
    Try
      Dim vResult As Result
      Dim msgResult As String
      Using objForm As New frmProgreso(AddressOf taskGenerarExportacion)
        objForm.ShowDialog(win32)
        vResult = objForm.ResultProcess
        msgResult = objForm.ResultMessage
      End Using
      If vResult <> Result.OK Then
        MsgBox(msgResult)
      End If
      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub taskGenerarExportacion(ByRef rResult As Result, ByRef rMessage As String)
    Try
      Dim lineas As New List(Of String)
      If GetExportedFile(m_RegistrosExportar, lineas) <> Result.OK Then
        rMessage = "Fallo generar archivo"
        rResult = Result.NOK
        Exit Sub
      End If
      Dim FileName As String = String.Empty
      If GetFileNameExport(FileName) <> Result.OK Then
        rMessage = "Fallo generar nombre"
        rResult = Result.NOK
        Exit Sub
      End If
      Dim FullFileName As String = IO.Path.Combine(GetFolderExportacion, FileName)
      If IO.File.Exists(FullFileName) Then
       
        Dim chFilename As String = String.Empty

        chFilename = FileName.Insert(FileName.IndexOf("."), "_" & Date.Now.ToString("yyyyMMddhhmmss"))

        FileSystem.Rename(FullFileName, IO.Path.Combine(GetFolderExportacion, chFilename))
      End If
      If Save(IO.Path.Combine(GetFolderExportacion, FileName), lineas) <> Result.OK Then
        rMessage = "Fallo guardando archivo"
        rResult = Result.NOK
        Exit Sub
      End If

      rMessage = "Finalizado OK"
      rResult = Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      rMessage = ex.Message
      rResult = Result.ErrorEx
    End Try
  End Sub

  Public Sub UpdateFechaVencimientoExportar(ByVal vDate As Date)
    Try
      m_FechaVto = vDate
      For Each registro In m_RegistrosExportar
        registro.FechaVto = vDate
      Next
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

#End Region

#Region "Importacion"

  Public Function LoadImportedFile(ByVal vOwn As IWin32Window) As libCommon.Comunes.Result
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



#End Region


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



End Class
