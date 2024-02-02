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

  Public m_RegistrosExportar As New List(Of clsInfoExportarPatagonia)
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
      m_RegistrosExportar = New List(Of clsInfoExportarPatagonia)
      Dim movimiento As clsInfoExportarPatagonia

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe & " AND GuidCuenta IN (SELECT Cuentas.GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & m_GuidTipoPago.ToString & "})"
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoExportarPatagonia



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
          .CBU = CDec(lstCuenta.Items.First.Codigo1)
          .Cuit_DNI = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .Contrato = lstProducto.Items.First.NumComprobante
          .Producto = Producto
          .FechaVto = FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .EstadoContrato = lstProducto.Items.First.Estado
          .GuidProducto = lstProducto.Items.First.GuidProducto
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          .NroCuitEmpresa = NroCuitEmpresa
          .ReferenciaDebito = ReferenciaDebito
          .FechaUltimaExportacion = item.FechaUltimaExportacion
          .GuidPago = item.GuidPago
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
      Dim Exportable As List(Of clsInfoExportarPatagonia) = m_RegistrosExportar.Where(Function(c) c.Exportar = True).ToList

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

  Private m_LineasArchivo As New List(Of String)
  Public m_Registros As New List(Of clsInfoImportarPatagonia)
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

  'Private Function GetLinesFromFile(ByRef rLineas As List(Of String)) As Result
  '  Try

  '    Dim AbrirArchivo As New OpenFileDialog
  '    If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then
  '      Return Result.NOK
  '    End If

  '    If modFile.Load(AbrirArchivo.FileName, rLineas) <> Result.OK Then
  '      MsgBox("Error al abrir archivo")
  '      Return Result.NOK
  '    End If
  '    Dim s As String = IO.Path.Combine(IMPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_" & AbrirArchivo.SafeFileName)

  '    IO.File.Copy(AbrirArchivo.FileName, s)
  '    Return Result.OK
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  Private Sub CargarInicioImp(ByRef rResult As Result, ByRef rMessage As String)
    Try
      m_Registros = New List(Of clsInfoImportarPatagonia)
      Dim length As Integer = m_LineasArchivo.Count

      Dim validacionBloque1 As String = String.Empty

      If length > 1 Then

        For Each linea In m_LineasArchivo '.GetRange(1, length - 3) 'este registro tiene Tail
          If linea.Substring(0, 1) = "H" Then
            FillEncabezado(linea, m_FechaEjecucion, m_CUITEmpresa)
            Continue For
          End If
          If linea.Substring(0, 1) = "T" Then
            ProcesarTail(linea, RegistrosCargados, m_TotalImporte)
            Exit For
          End If
          Dim registro As New clsInfoImportarPatagonia
          With registro
            'vResult = GenerateValidacionBloque1(linea.Substring(21, 3), linea.Substring(24, 4), validacionBloque1)
            'If vResult <> Result.OK Then
            '  MsgBox("Fallo la validacion de uno de los bloques de la cuenta, se cancela el proceso")
            '  Exit Sub
            'End If
            .CBU = CDec(linea.Substring(12, 22)) 'CBU
            .DNI_ID = CDec(linea.Substring(1, 11)) 'DNI que figura en el archivo de importacion
            .Contrato = CDec(linea.Substring(34, 11))  'el campo es de 22 de largo, pero solo tiene 11 asignado como numero
            .FechaDebito = New Date(CInt(linea.Substring(60, 4)), CInt(linea.Substring(58, 2)), CInt(linea.Substring(56, 2))) ' fecha vencimiento??
            .importeDebitado = CDec(CDec(linea.Substring(104, 10)) / 100)
            .MotivoRechazo = linea.Substring(151, 3) 'Es CODIGO

            'moneda 3 posiciones

            '.importeDebitado = CDec(CDec(linea.Substring(119, 13)) / 100)
            '.ImporteBH = 0
            .Importar = False
            .cuota = 0
          End With
          m_Registros.Add(registro)
        Next


      End If

      Procesar()
      'm_TotalImporte = m_Registros.Where(Function(c) c.Importar = True).Sum(Function(c) c.ImporteADebitar)
      rResult = Result.OK
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
        objVenta.Cfg_Filtro = "WHERE NumComprobante=" & item.Contrato.ToString & " and ValorCuotaFija=" & item.importeDebitado & " and GuidTipoPago={c3daf694-fdef-4e67-b02b-b7b3a9117927}"
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
          objCuentas.Cfg_Filtro = "WHERE GuidCuenta={" & objVenta.Items.First.GuidCuenta.ToString & "} and TipoDeCuenta={c3daf694-fdef-4e67-b02b-b7b3a9117927}"
          objCuentas.RefreshData()
          If objCuentas.Items.Count = 1 Then
            'comparo CBU con codigo1
            item.GuidCuenta = objCuentas.Items.First.GuidCuenta
            If item.CBU = CDec(objCuentas.Items.First.Codigo1) Then
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


  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoExportarPatagonia), ByRef rlineas As List(Of String)) As Result
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
      If vlstRegistros.Count <= 0 Then
        MsgBox("No hay registros seleccionados para Exportar")
        Return Result.CANCEL
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

  Private Function GenerateRegistros(ByVal vRegistro As clsInfoExportarPatagonia, ByRef rlinea As String) As Result
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
