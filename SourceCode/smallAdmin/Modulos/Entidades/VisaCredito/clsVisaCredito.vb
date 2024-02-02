Option Strict Off
Imports libCommon.Comunes
Imports manDB
Imports Excel = Microsoft.Office.Interop.Excel

Public Class clsVisaCredito
    Private m_GuidTipoPago As Guid
    Private m_FechaVto As Date
    Private m_FechaPresentacion As Date

    Public m_RegistrosExportar As New List(Of clsInfoExportarVisaCredito)

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



    Public Sub New(ByVal vGuidConvenio As Guid)
        Try
            
            m_FechaPresentacion = g_Today
            m_FechaVto = g_Today.AddDays(2)
            
            m_GuidTipoPago = vGuidConvenio

        Catch ex As Exception
            Print_msg(ex.Message)
        End Try
    End Sub


#Region "Exportacion"

    Public ReadOnly Property countRegistrosAExportar As Integer
        Get
            Return m_RegistrosExportar.Where(Function(c) c.Exportar = True).Count
        End Get
    End Property

    Public ReadOnly Property countTotalRegistros As Integer
        Get
            Return m_RegistrosExportar.Count
        End Get
    End Property

    Public ReadOnly Property ImporteTotalAExportar As Decimal
        Get
            Return m_RegistrosExportar.Where(Function(c) c.Exportar = True).Sum(Function(c) c.Importe)
        End Get
    End Property

    Public Function CargarContratosAExportar(ByVal win32 As IWin32Window) As Result
        Try
            Dim vResult As Result
            Dim vMessge As String
            Using objForm As New frmProgreso(AddressOf taskGenerateResumen)
                objForm.ShowDialog(win32)
                vResult = objForm.ResultProcess
                vMessge = objForm.ResultMessage
            End Using
            If vResult <> Result.OK Then
                MsgBox(vMessge)
            End If

            Return vResult
        Catch ex As Exception
            Print_msg(ex.Message)
            Return Result.ErrorEx
        End Try
    End Function

  Private Sub taskGenerateResumen(ByRef rResult As Result, ByRef rMessage As String)
    Try

      Dim lstPago As New clsListPagos
      m_RegistrosExportar = New List(Of clsInfoExportarVisaCredito)
      Dim movimiento As clsInfoExportarVisaCredito

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe & " AND GuidCuenta IN (SELECT Cuentas.GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & m_GuidTipoPago.ToString & "})"
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoExportarVisaCredito

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "}" ' and GuidTipoPago = {" & m_GuidTipoPago.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
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
          .NumeroTarjeta = CDec(lstCuenta.Items.First.Codigo1)
          .IdentificadorDebito = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .NumeroComprobante = lstProducto.Items.First.NumComprobante
          '.Producto = Producto
          .FechaVto = FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          '.NroCuitEmpresa = NroCuitEmpresa
          '.ReferenciaDebito = ReferenciaDebito
          .FechaUltimaExportacion = item.FechaUltimaExportacion
          .GuidPago = item.GuidPago
          .EstadoContrato = lstProducto.Items.First.Estado
          .GuidProducto = lstProducto.Items.First.GuidProducto
          If bCodigoAlta Then
            .CodigoDeAlta = "E"
          Else
            .CodigoDeAlta = "N"
          End If
          If .EstadoContrato <= 0 Then
            .Exportar = True
          Else
            .Exportar = False
          End If
        End With
        m_RegistrosExportar.Add(movimiento)
      Next
      rMessage = "Finalizado OK"
      rResult = Result.OK
    Catch ex As Exception
      rMessage = ex.Message
      rResult = Result.ErrorEx
    End Try
  End Sub

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
      'todo: pasar solo los check exportar=true
      Dim Exportable As List(Of clsInfoExportarVisaCredito) = m_RegistrosExportar.Where(Function(c) c.Exportar = True).ToList

      If GetExportedFile(Exportable, lineas) <> Result.OK Then
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

      ''GUARDAR FECHA DE EXPORTACION
      For Each item In Exportable
        Dim objDebitos As New clsListPagos
        objDebitos.Cfg_Filtro = "WHERE GuidPago={" & item.GuidPago.ToString & "}"
        objDebitos.RefreshData()
        If objDebitos.Items.Count = 1 Then
          Dim objDebitoActualizado As manDB.clsInfoPagos = objDebitos.Items.First.Clone
          objDebitoActualizado.FechaUltimaExportacion = m_FechaPresentacion
          If clsPago.Save(objDebitoActualizado) <> Result.OK Then
            'TODO: take error
            rMessage = "No pudo guardarse el proceso"
            rResult = Result.NOK
          End If
        End If
      Next

      If Save(IO.Path.Combine(GetFolderExportacion, FileName), lineas) <> Result.OK Then
        rMessage = "Fallo guardando archivo"
        rResult = Result.NOK
        Exit Sub
      End If

      'GENERAR segundo Archivo
      ExportarAVisaCredito(Exportable)

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

  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoExportarVisaCredito), ByRef rlineas As List(Of String)) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0

      If vlstRegistros.Count <= 0 Then
        MsgBox("No hay registros seleccionados para Exportar")
        Return Result.CANCEL
      End If




      'ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)

      ExportVisaTXT(vlstRegistros, "DEBLIQC", rlineas)

      'If GenerateHeader(auxLinea) <> Result.OK Then
      '  MsgBox("No se puede generar encabezado del debito")
      '  Return Result.NOK
      'End If
      'lstResult.Add(auxLinea)
      'For Each mov In vlstRegistros
      '  auxLinea = String.Empty
      '  mov.FechaVto = m_FechaVto
      '  If GenerateRegistros(mov, auxLinea) <> Result.OK Then
      '    MsgBox("No se puede generar el registro de debito Hipotecario")
      '    Return Result.NOK
      '  End If
      '  lstResult.Add(auxLinea)
      'Next

      'If GenerateTail(vlstRegistros.Count, ImporteTotal, auxLinea) <> Result.OK Then
      '  MsgBox("No se puede generar final del archivo de debito")
      '  Return Result.NOK
      'End If
      'lstResult.Add(auxLinea)
      'rlineas = New List(Of String)
      'rlineas.AddRange(lstResult.ToList)

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function ExportarAVisaCredito(ByVal vMovimientos As List(Of clsInfoExportarVisaCredito)) As Result
    Try

      Dim xls As New Excel.Application
      Dim worksheet As Excel.Worksheet
      Dim workbook As Excel.Workbook
      IO.File.Copy(IO.Path.Combine(MODEL_PATH, "DEBLIQCempty.xls"), IO.Path.Combine(TEMP_PATH, "DEBLIQC.xls"), True)
      workbook = xls.Workbooks.Open(IO.Path.Combine(TEMP_PATH, "DEBLIQC.xls"))
      Try
        worksheet = CType(workbook.Worksheets("Facturas"), Excel.Worksheet)
        Dim lista As List(Of clsInfoExportarVisaCredito) = vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante)).ToList
        For i As Integer = 0 To vMovimientos.Count - 1 ' Each Movimiento In vMovimientos

          worksheet.Cells(i + 2, 1).value = lista(i).NumeroTarjeta.ToString
          worksheet.Cells(i + 2, 2).value = lista(i).NumeroComprobante
          worksheet.Cells(i + 2, 3).value = GetHoy.ToString("dd/MM/yyyy") ' vMovimientos(i - 2).Fecha
          worksheet.Cells(i + 2, 4).value = lista(i).Importe 'acepta 1.23
          worksheet.Cells(i + 2, 5).value = lista(i).IdentificadorDebito
          worksheet.Cells(i + 2, 6).value = lista(i).CodigoDeAlta  ' N o E ver especificacion
        Next

        workbook.SaveCopyAs(IO.Path.Combine(GetFolderExportacion, GetHoy.ToString("yyMMdd") & "_DEBLIQC.ree.xls"))

      Finally
        workbook.Close(False)
      End Try




      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  'Private Function GenerateHeader(ByRef rLinea As String) As Result
  '  Try
  '    Dim sResult As String = String.Empty
  '    m_Reserva = GetReserva()
  '    sResult += "H"
  '    sResult += m_NroCuitEmpresa.ToString("00000000000")
  '    sResult += String.Format("{0,-10}", m_Producto)       'longitud=10
  '    sResult += m_OrigenComercial.ToString("000")
  '    sResult += m_FechaPresentacion.ToString("ddMMyyyy")
  '    sResult += String.Format("{0,-12}", m_Reserva)
  '    sResult += String.Format("{0,-35}", m_RazonSocial)
  '    sResult += String.Format("{0,120}", " ")

  '    rLinea = sResult
  '    Return Result.OK
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  Private Function ExportVisaTXT(ByVal vMovimientos As List(Of clsInfoExportarVisaCredito), ByVal constante As String, ByRef rLineas As List(Of String)) As Result
    Try
      Dim lineas As New List(Of String)
      rLineas = New List(Of String)
      Dim aux As String = String.Empty
      Dim FechaGeneracion As Date = GetAhora()
      'HEADER
      aux = "0"
      aux += constante.PadRight(8, " ")
      aux += "40832883".PadLeft(10, "0") 'NUMERO DE ESTABLECIMIENTO 900000
      aux += "900000".PadRight(10, " ")
      aux += FechaGeneracion.ToString("yyyyMMdd").PadLeft(8)
      aux += FechaGeneracion.ToString("hhmm").PadLeft(4)
      aux += "0".PadLeft(1)
      aux += " ".PadLeft(2, " ")
      aux += " ".PadLeft(55, " ")
      aux += "*".PadLeft(1)
      lineas.Add(aux)

      'BODY
      For Each movimiento In vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante))
        aux = "1"
        aux += movimiento.NumeroTarjeta.ToString.PadLeft(16)
        aux += " ".PadLeft(3, " ")
        aux += movimiento.NumeroComprobante.ToString.PadLeft(8, "0")
        aux += GetHoy.ToString("yyyyMMdd").PadLeft(8)
        aux += "0005".PadLeft(4)
        aux += CInt(CSng(movimiento.Importe) * 100).ToString.PadLeft(15, "0")
        aux += movimiento.IdentificadorDebito.ToString.PadLeft(15, "0")
        aux += IIf(movimiento.CodigoDeAlta = "E", "E", " ").ToString
        aux += " ".PadLeft(2, " ")
        aux += " ".PadLeft(26, " ")
        aux += "*".PadLeft(1)
        lineas.Add(aux)
      Next

      'TAIL
      aux = "9"
      aux += constante.PadRight(8, " ")
      aux += "40832883".PadLeft(10, "0") 'NUMERO DE ESTABLECIMIENTO
      aux += "900000".PadRight(10, " ")
      aux += FechaGeneracion.ToString("yyyyMMdd").PadLeft(8)
      aux += FechaGeneracion.ToString("hhmm").PadLeft(4)
      aux += vMovimientos.Count.ToString.PadLeft(7, "0")
      aux += CInt(vMovimientos.Sum(Function(c) CSng(c.Importe)) * 100).ToString.PadLeft(15, "0")
      aux += " ".PadLeft(36, " ")
      aux += "*".PadLeft(1)
      lineas.Add(aux)

      rLineas.AddRange(lineas.ToArray)
      'Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, FechaGeneracion.ToString("yyyyMMddhhmm") & "_" & constante & ".txt"), lineas)
      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFileNameExport(ByRef rName As String) As Result
    Try
      'ORIddmms.nnn (ddmm/Dia/Mes - s/Secuencia -nnn/Numero de Origen)
      'Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, FechaGeneracion.ToString("yyyyMMddhhmm") & "_" & constante & ".txt"), lineas)
      rName = g_Today.ToString("yyyyMMddhhmm") & "_" & "DEBLIQC" & ".txt"
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "VisaCredito")
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

#End Region


#Region "importacion"

  Private m_LineasArchivo As New List(Of String)
  Public m_Registros As New List(Of clsInfoImportarVisaCredito)
  Private m_FechaEjecucion As Date
  Private m_TotalImporte As Decimal
  Private m_CUITEmpresa As Decimal

  Public ReadOnly Property CUIT_empresa As String
    Get
      Return m_CUITEmpresa.ToString
    End Get
  End Property
  Public ReadOnly Property ImporteTotalImportado As Decimal
    Get
      Return m_TotalImporte
    End Get
  End Property

  Public ReadOnly Property FechaEjecucion As Date
    Get
      Return m_FechaEjecucion
    End Get
  End Property

  Public ReadOnly Property RegistrosCargados As Integer
    Get
      Return m_Registros.Count
    End Get
  End Property

  Public ReadOnly Property RegistrosAceptados As Integer
    Get
      Return m_Registros.Where(Function(c) c.Importar = True).Count()
    End Get
  End Property

  Public ReadOnly Property RegistrosRechazados As Integer
    Get
      Return RegistrosCargados - RegistrosAceptados
    End Get
  End Property

  Public Function LoadImportedFile(ByVal vOwn As IWin32Window) As libCommon.Comunes.Result
    Try
      Dim AbrirArchivo As New OpenFileDialog
      If AbrirArchivo.ShowDialog(vOwn) <> Windows.Forms.DialogResult.OK Then
        Return Result.CANCEL
      End If

      m_LineasArchivo = New List(Of String)
      If modFile.Load(AbrirArchivo.FileName, m_LineasArchivo) <> Result.OK Then
        MsgBox("Error al abrir archivo")
        Return Result.NOK
      End If
      Dim s As String = IO.Path.Combine(IMPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_" & AbrirArchivo.SafeFileName)

      IO.File.Copy(AbrirArchivo.FileName, s)
      Dim vResult As Result
      Dim vMessge As String
      Using objForm As New frmProgreso(AddressOf CargarInicioImp)
        objForm.ShowDialog(vOwn)
        vResult = objForm.ResultProcess
        vMessge = objForm.ResultMessage
      End Using
      If vResult <> Result.OK Then
        MsgBox(vMessge)
      End If

      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetCuerpoVISACredito(ByVal vLineas As List(Of String), ByRef rMovimiento As List(Of clsInfoImportarVisaCredito)) As Result
    Try

      rMovimiento = New List(Of clsInfoImportarVisaCredito)
      If vLineas.Count <= 0 Then Return Result.OK
      If vLineas.GetRange(1, vLineas.Count - 2).TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim aux As String = String.Empty
      Dim movimiento As clsInfoImportarVisaCredito
      m_FechaEjecucion = New Date(CInt(vLineas(0).Substring(29, 4)), CInt(vLineas(0).Substring(33, 2)), CInt(vLineas(0).Substring(35, 2)))
      m_CUITEmpresa = CDec(vLineas(0).Substring(19, 10))
      For Each linea In vLineas.GetRange(1, vLineas.Count - 2)
        movimiento = New clsInfoImportarVisaCredito
        With movimiento
          .NumeroTarjeta = CDec(linea.Substring(26, 16)) 'num tar
          .Contrato = CDec(linea.Substring(42, 8)) 'num comprobante
          'aux = linea.Substring(36, 4) 'c transac = 0005
          .importeDebitado = CDec(CDec(linea.Substring(62, 15)) / 100) 'importe incluye 2 dec
          .DNI_ID = CDec(linea.Substring(94, 15)) '79 identificador debito
          ''11 espacios
          '.Param1 = linea.Substring(81, 1) 'param1
          ''2 espacio 
          '.Param2 = linea.Substring(84, 1) 'param2
          ''15 espacios
          .Codigo = linea.Substring(129, 1) 'estado del movimiento 
          .MotivoRechazo = linea.Substring(130, 2) 'yy: Rechazo Código Motivo 1
          .Detalle = linea.Substring(132, 29) 'descripcion 1 del codigo 1
          .FechaDebito = New Date(2000 + CInt(linea.Substring(228, 2)), CInt(linea.Substring(226, 2)), CInt(linea.Substring(224, 2))) 'fecha DDMMAA 'linea.Substring(224, 6)

          .Importar = False
          .cuota = 0
        End With
        rMovimiento.Add(movimiento)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Private Sub CargarInicioImp(ByRef rResult As Result, ByRef rMessage As String)
    Try
      m_Registros = New List(Of clsInfoImportarVisaCredito)
      Dim length As Integer = m_LineasArchivo.Count
      Dim vResult As libCommon.Comunes.Result = Result.NOK
      Dim validacionBloque1 As String = String.Empty

      If length > 1 Then

        vResult = GetCuerpoVISACredito(m_LineasArchivo, m_Registros)
        If vResult <> Result.OK Then Exit Sub

      End If

      Procesar()
      'm_TotalImporte = m_Registros.Where(Function(c) c.Importar = True).Sum(Function(c) c.ImporteADebitar)
      rResult = vResult
      rMessage = "Finalizado OK"
    Catch ex As Exception
      Print_msg(ex.Message)
      rResult = Result.ErrorEx
      rMessage = ex.Message
    End Try
  End Sub

  Private Sub FillEncabezado(ByVal vLineaEncabezado As String, ByRef rFechaEjecucion As Date, ByRef rCUITEmpresa As Decimal)
    Try
      'validar encabezado
      'vLineaEncabezado.Length =xx
      If vLineaEncabezado.Substring(0, 1) <> "H" Then Exit Sub
      rFechaEjecucion = New Date(CInt(vLineaEncabezado.Substring(29, 4)), CInt(vLineaEncabezado.Substring(27, 2)), CInt(vLineaEncabezado.Substring(25, 2)))
      rCUITEmpresa = CDec(vLineaEncabezado.Substring(1, 11))
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ProcesarTail(ByVal vLineaTail As String, ByRef rCantidadRegistros As Integer, ByRef rImporte As Decimal)
    Try
      If vLineaTail.Substring(0, 1) <> "T" Then Exit Sub
      rCantidadRegistros = CInt(vLineaTail.Substring(1, 7))
      rImporte = CDec(CDec(vLineaTail.Substring(8, 15)) / 100)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Procesar()
    Try
      'toma cada registro y aplica si se realizo el pago correspondiente
      'validar cbu, id y valor debito contra db
      For Each item In m_Registros ' tmpRegistros
        ' If item.ImporteADebitar <> item.importeDebitado OrElse item.MotivoRechazo <> String.Empty Then Continue For
        Dim objVenta As New clsListProductos
        objVenta.Cfg_Filtro = "WHERE NumComprobante=" & item.Contrato.ToString & " and ValorCuotaFija=" & item.importeDebitado & " and GuidTipoPago={7580f2d4-d9ec-477b-9e3a-50afb7141ab5}"
        objVenta.RefreshData()
        If objVenta.Items.Count = 1 Then
          item.GuidProducto = objVenta.Items.First.GuidProducto
          'asocio un nombre
          Dim objCliente As New clsListDatabase
          objCliente.Cfg_Filtro = "Where GuidCliente={" & objVenta.Items.First.GuidCliente.ToString.ToUpper & "}"
          objCliente.RefreshData()
          If objCliente.Items.Count = 1 Then
            item.Nombre = objCliente.Items.First.ToString
          End If
          Dim objCuentas As New clsListaCuentas
          objCuentas.Cfg_Filtro = "WHERE GuidCuenta={" & objVenta.Items.First.GuidCuenta.ToString & "} and TipoDeCuenta={7580f2d4-d9ec-477b-9e3a-50afb7141ab5}"
          objCuentas.RefreshData()
          If objCuentas.Items.Count = 1 Then
            'comparo CBU con codigo1
            item.GuidCuenta = objCuentas.Items.First.GuidCuenta
            If item.NumeroTarjeta = CDec(objCuentas.Items.First.Codigo1) Then
              'confirmado
              'aplicar pago cuota actual a debitar
              Dim objPagos As New clsListPagos
              objPagos.Cfg_Filtro = "WHERE GuidProducto={" & objVenta.Items.First.GuidProducto.ToString & "} and EstadoPago=" & CInt(E_EstadoPago.Debe).ToString
              objPagos.RefreshData()
              If objPagos.Items.Count = 1 Then
                item.GuidPago = objPagos.Items.First.GuidPago
                item.FechaUltimaImportacion = objPagos.Items.First.FechaUltimaImportacion
                If (item.importeDebitado > 0) AndAlso (String.IsNullOrWhiteSpace(item.MotivoRechazo) Or item.MotivoRechazo = "R00" Or item.MotivoRechazo = "00") Then
                  item.Importar = True
                End If

                item.cuota = objPagos.Items.First.NumCuota
              End If
            End If
          End If
        Else
          'Marcar como rechazado
          item.Importar = False


          'MsgBox("no encontrado, marcar")
        End If

      Next

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Public Function ImportarSeleccionados(ByVal vHWND As IWin32Window) As Result
    Try
      Dim vResult As Result
      Dim vMessge As String
      Using objForm As New frmProgreso(AddressOf taskImportarSeleccionados)
        objForm.ShowDialog(vHWND)
        vResult = objForm.ResultProcess
        vMessge = objForm.ResultMessage
      End Using

      If vResult <> Result.OK Then
        MsgBox(vMessge)
      End If
      Return vResult
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub taskImportarSeleccionados(ByRef rResult As Result, ByRef rMessage As String)
    Try
      For Each item In m_Registros
        If item.Importar <> True Then Continue For
        Dim objDebitos As New clsListPagos
        objDebitos.Cfg_Filtro = "WHERE GuidPago={" & item.GuidPago.ToString & "}"
        objDebitos.RefreshData()
        If objDebitos.Items.Count = 1 Then
          Dim objDebitoActualizado As clsInfoPagos = objDebitos.Items.First.Clone
          objDebitoActualizado.EstadoPago = E_EstadoPago.Pago
          objDebitoActualizado.FechaPago = item.FechaDebito
          If clsPago.Save(objDebitoActualizado) <> Result.OK Then
            'TODO: take error
          End If
        End If

      Next
      rMessage = "Finalizado OK"
      rResult = Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      rMessage = ex.Message
      rResult = Result.ErrorEx
    End Try
  End Sub


#End Region


End Class
