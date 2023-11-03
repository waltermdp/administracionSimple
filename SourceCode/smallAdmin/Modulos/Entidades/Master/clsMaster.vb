Imports libCommon.Comunes
Imports manDB

Public Class clsMaster
  'header

  Private m_Producto As String
  Private m_FechaPresentacion As Date
  Private m_Reserva As String

  Private m_NroComercio As Decimal
  Private m_RazonSocial As String

  'body
  Private m_FechaVto As Date
  Private m_ReferenciaDebito As String

  'tail
  'T
  Private m_CantidadRegistros As Decimal
  Private m_ImporteTotal As Decimal

  Public m_RegistrosExportar As New List(Of clsInfoExportarMaster)
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

  Public ReadOnly Property NroComercio As Decimal
    Get
      Return m_NroComercio
    End Get
  End Property
    

  Public Sub New(ByVal vGuidConvenio As Guid)
    Try
      m_Producto = "CUOTA"
      m_NroComercio = 24063119
      m_FechaPresentacion = g_Today
      m_FechaVto = g_Today.AddDays(2)
      'm_Reserva = GetReserva()
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
      m_RegistrosExportar = New List(Of clsInfoExportarMaster)
      Dim movimiento As clsInfoExportarMaster

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe & " AND GuidCuenta IN (SELECT Cuentas.GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & m_GuidTipoPago.ToString & "})"
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoExportarMaster

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "}" ' and GuidTipoPago = {" & m_GuidTipoPago.ToString & "}"
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
          .NroTarjeta = CDec(lstCuenta.Items.First.Codigo1)
          .Cuit_DNI = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .Contrato = lstProducto.Items.First.NumComprobante
          .Producto = Producto
          .FechaVto = FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .EstadoContrato = lstProducto.Items.First.Estado
          .GuidProducto = lstProducto.Items.First.GuidProducto
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          .PlanCuotas = lstProducto.Items.First.TotalCuotas
          '.NroCuitEmpresa = NroCuitEmpresa
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
      Dim Exportable As List(Of clsInfoExportarMaster) = m_RegistrosExportar.Where(Function(c) c.Exportar = True).ToList

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
  Public m_Registros As New List(Of clsInfoImportarMaster)
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


  Private Sub CargarInicioImp(ByRef rResult As Result, ByRef rMessage As String)
    Try
      m_Registros = New List(Of clsInfoImportarMaster)
      Dim length As Integer = m_LineasArchivo.Count

      Dim validacionBloque1 As String = String.Empty

      If length > 1 Then
        FillEncabezado(m_LineasArchivo(0), m_FechaEjecucion, m_CUITEmpresa)
        For i As Integer = 1 To m_LineasArchivo.Count - 1 ' Each linea In m_LineasArchivo 
          Dim registro As New clsInfoImportarMaster
          With registro
            If m_LineasArchivo(i).Substring(0, 3) <> "AC2" Then Continue For
            .NroTarjeta = CDec(m_LineasArchivo(i).Substring(3, 16))
            .Contrato = CDec(m_LineasArchivo(i).Substring(26, 12))  'el campo es de 22 de largo, pero solo tiene 11 asignado como numero
            .importeDebitado = CDec(CDec(m_LineasArchivo(i).Substring(40, 11)) / 100)
            .cuota = CInt(m_LineasArchivo(i).Substring(51, 3))
            .MotivoRechazo = m_LineasArchivo(i).Substring(58, 2) 'Es CODIGO
            .Periodo = m_LineasArchivo(i).Substring(60, 5) 'Periodo
            If Not String.IsNullOrWhiteSpace(m_LineasArchivo(i).Substring(71, 40)) Then
              If IsNumeric(m_LineasArchivo(i).Substring(71, 40).Trim) Then
                .DNI_ID = CDec(m_LineasArchivo(i).Substring(71, 40)) 'DNI que figura en el archivo de importacion
              End If

            End If


            .FechaDebito = New Date(2000 + CInt(m_LineasArchivo(i).Substring(65 + 4, 2)), CInt(m_LineasArchivo(i).Substring(65 + 2, 2)), CInt(m_LineasArchivo(i).Substring(65, 2))) ' fecha vencimiento??



            'moneda 3 posiciones

            '.importeDebitado = CDec(CDec(linea.Substring(119, 13)) / 100)
            '.ImporteBH = 0
            .Importar = False
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
      m_Registros = New List(Of clsInfoImportarMaster)
      rResult = Result.ErrorEx
      rMessage = ex.Message
    End Try
  End Sub

  Private Sub FillEncabezado(ByVal vLineaEncabezado As String, ByRef rFechaEjecucion As Date, ByRef rNroComercio As Decimal)
    Try
      'validar encabezado
      'vLineaEncabezado.Length =xx
      If vLineaEncabezado.Substring(0, 10) <> "AC1DEB-AUT" Then Exit Sub
      '24063119
      rNroComercio = CDec(vLineaEncabezado.Substring(12, 8))
      rFechaEjecucion = New Date(2000 + CInt(vLineaEncabezado.Substring(20 + 4, 2)), CInt(vLineaEncabezado.Substring(20 + 2, 2)), CInt(vLineaEncabezado.Substring(20, 2)))

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub ProcesarTail(ByVal vLineaTail As String, ByRef rCantidadRegistros As Integer, ByRef rImporte As Decimal)
  '  Try
  '    If vLineaTail.Substring(0, 1) <> "T" Then Exit Sub
  '    rCantidadRegistros = CInt(vLineaTail.Substring(1, 7))
  '    rImporte = CDec(CDec(vLineaTail.Substring(8, 15)) / 100)
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub Procesar()
    Try
      'toma cada registro y aplica si se realizo el pago correspondiente
      'validar cbu, id y valor debito contra db
      For Each item In m_Registros ' tmpRegistros
        ' If item.ImporteADebitar <> item.importeDebitado OrElse item.MotivoRechazo <> String.Empty Then Continue For
        Dim objVenta As New clsListProductos
        objVenta.Cfg_Filtro = "WHERE NumComprobante=" & item.Contrato.ToString & " and ValorCuotaFija=" & item.importeDebitado & " and GuidTipoPago={ea5d6084-90c3-4b66-82b2-9c4816c07523}"
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
          objCuentas.Cfg_Filtro = "WHERE GuidCuenta={" & objVenta.Items.First.GuidCuenta.ToString & "} and TipoDeCuenta={ea5d6084-90c3-4b66-82b2-9c4816c07523}"
          objCuentas.RefreshData()
          If objCuentas.Items.Count = 1 Then
            'comparo CBU con codigo1
            item.GuidCuenta = objCuentas.Items.First.GuidCuenta
            If item.NroTarjeta = CDec(objCuentas.Items.First.Codigo1) Then
              'confirmado
              'aplicar pago cuota actual a debitar
              Dim objPagos As New clsListPagos
              objPagos.Cfg_Filtro = "WHERE GuidProducto={" & objVenta.Items.First.GuidProducto.ToString & "} and EstadoPago=" & CInt(E_EstadoPago.Debe).ToString
              objPagos.RefreshData()
              If objPagos.Items.Count = 1 Then
                item.GuidPago = objPagos.Items.First.GuidPago
                item.FechaUltimaImportacion = objPagos.Items.First.FechaUltimaImportacion
                If (item.importeDebitado > 0) AndAlso (String.IsNullOrWhiteSpace(item.MotivoRechazo) Or item.MotivoRechazo = "00") Then
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


  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoExportarMaster), ByRef rlineas As List(Of String)) As Result
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
      If GenerateHeader(vlstRegistros.Count, ImporteTotal, auxLinea) <> Result.OK Then
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

      'If GenerateTail(vlstRegistros.Count, ImporteTotal, auxLinea) <> Result.OK Then
      '  MsgBox("No se puede generar final del archivo de debito")
      '  Return Result.NOK
      'End If
      'lstResult.Add(auxLinea)
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
      rName = "PRESENTATION_MASTER" & m_FechaPresentacion.ToString("ddMMyy") & ".txt" ' & "0" & "." & m_OrigenComercial.ToString("000")
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "Master")
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

  'Private Shared Function ExportAMaster(ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
  '  Try

  '    Dim lineas As New List(Of String)
  '    'NUMERO DE COMERCIO
  '    For Each item In vMovimientos
  '      item.Param1 = "24063119"
  '    Next
  '    Dim periodo As String = GetAhora.ToString("MM/yy")

  '    'HEADER
  '    Dim header As String = String.Empty
  '    header += vMovimientos.First.Param1.PadLeft(8, "0") 'Numero de comercio
  '    header += "1" 'identificador fijo
  '    header += GetAhora.ToString("ddMMyy").PadLeft(6)
  '    header += vMovimientos.Count.ToString.PadLeft(7, "0") 'Cantidad de registros
  '    header += "0" 'signo
  '    header += vMovimientos.Sum(Function(c) c.Importe * 100).ToString.PadLeft(14, "0")
  '    header += " ".PadLeft(91, " ")


  '    lineas.Add(header)
  '    Dim linea As String = String.Empty
  '    For i As Integer = 0 To vMovimientos.Count - 1
  '      linea = vMovimientos(i).Param1.PadLeft(8, "0") 'NUMERO DE COMERCIO
  '      linea += "2" 'Tipo de registro 2 o 3
  '      linea += vMovimientos(i).NumeroTarjeta.PadLeft(16, "0")
  '      linea += vMovimientos(i).IdentificadorDebito.PadLeft(12, "0") 'NUMERO DE REFERENCIA' identificacion del socio
  '      linea += "1".PadLeft(3, "0")  'cuotas
  '      linea += vMovimientos(i).Param2.PadLeft(3, "0") 'CUOTAS PLAN
  '      linea += "01" 'FRECUENCIA DB
  '      linea += (vMovimientos(i).Importe * 100).ToString.PadLeft(11, "0") 'IMPORTE
  '      linea += periodo.PadLeft(5, " ") 'PERIODO
  '      linea += " "
  '      linea += GetAhora.AddMonths(1).ToString("ddMMyy").PadLeft(6) 'FECHA VENCIMIENTO PAGO
  '      linea += vMovimientos(i).NumeroComprobante.PadLeft(40, " ") 'datos auxiliares
  '      linea += " ".PadLeft(20, " ") 'filler
  '      lineas.Add(linea)
  '    Next
  '    Dim vResult As Result = Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_Master.txt"), lineas)
  '    MsgBox("Finalizo exportacion a txt")

  '    Return Result.OK
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  Private Function GenerateHeader(ByVal nRegistros As Integer, ByVal vImporteTotal As Decimal, ByRef rLinea As String) As Result
    Try
      Dim header As String = String.Empty
      header += m_NroComercio.ToString("00000000") ' vMovimientos.First.Param1.PadLeft(8, "0") 'Numero de comercio
      header += "1" 'identificador fijo
      header += m_FechaPresentacion.ToString("ddMMyy").PadLeft(6) ' GetAhora.ToString("ddMMyy").PadLeft(6)
      header += nRegistros.ToString("0000000") 'vMovimientos.Count.ToString.PadLeft(7, "0") 'Cantidad de registros
      header += "0" 'signo
      header += CDec(vImporteTotal * 100).ToString("00000000000000") 'vMovimientos.Sum(Function(c) c.Importe * 100).ToString.PadLeft(14, "0")
      header += String.Format("{0,91}", " ") '" ".PadLeft(91, " ")

      'm_Reserva = GetReserva()
      'sResult += "H"
      'sResult += m_NroCuitEmpresa.ToString("00000000000")
      'sResult += String.Format("{0,-10}", m_Producto)       'longitud=10
      'sResult += m_OrigenComercial.ToString("000")
      'sResult += m_FechaPresentacion.ToString("ddMMyyyy")
      'sResult += String.Format("{0,-12}", m_Reserva)
      'sResult += String.Format("{0,-35}", m_RazonSocial)
      'sResult += String.Format("{0,120}", " ")

      rLinea = header
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GenerateRegistros(ByVal vRegistro As clsInfoExportarMaster, ByRef rlinea As String) As Result
    Try

      Dim linea As String = String.Empty

      linea = m_NroComercio.ToString("00000000") '  vMovimientos(i).Param1.PadLeft(8, "0") 'NUMERO DE COMERCIO
      linea += "2" 'Tipo de registro 2 o 3
      linea += vRegistro.NroTarjeta.ToString("0000000000000000") ' vMovimientos(i).NumeroTarjeta.PadLeft(16, "0")
      linea += String.Format("{0,12}", vRegistro.Contrato.ToString.PadLeft(12, "0"c)) ' vMovimientos(i).IdentificadorDebito.PadLeft(12, "0") 'NUMERO DE REFERENCIA' identificacion del socio
      linea += vRegistro.CuotaActual.ToString.PadLeft(3, "0"c) ' "001" '"1".PadLeft(3, "0")  'cuotas
      linea += String.Format("{0,3}", vRegistro.PlanCuotas.ToString.PadLeft(3, "0"c)) '  ("000") vMovimientos(i).Param2.PadLeft(3, "0") 'CUOTAS PLAN
      linea += "01" 'FRECUENCIA DB
      linea += CDec(vRegistro.Importe * 100).ToString("00000000000") '(vMovimientos(i).Importe * 100).ToString.PadLeft(11, "0") 'IMPORTE
      linea += vRegistro.FechaVto.ToString("MM/yy") 'String.Format("{0}/{1}", vRegistro.FechaVto.Month, vRegistro.FechaVto.Year.ToString("yy")) ' periodo.PadLeft(5, " ") 'PERIODO
      linea += " "
      linea += vRegistro.FechaVto.ToString("ddMMyy")    ' GetAhora.AddMonths(1).ToString("ddMMyy").PadLeft(6) 'FECHA VENCIMIENTO PAGO
      linea += String.Format("{0,-40}", vRegistro.Cuit_DNI.ToString) 'vMovimientos(i).NumeroComprobante.PadLeft(40, " ") 'datos auxiliares
      linea += String.Format("{0,20}", " ") ' " ".PadLeft(20, " ") 'filler

      rlinea = linea

      'sResult += vRegistro.TipoNovedad.ToString                         '1
      'sResult += vRegistro.Cuit_DNI.ToString("00000000000")             '11
      'sResult += vRegistro.NroTarjeta.ToString("0000000000000000000000")       '22
      'sResult += String.Format("{0,-22}", vRegistro.Contrato.ToString.PadLeft(11, "0"c)) '22
      'sResult += vRegistro.FechaVto.ToString("ddMMyyyy")                '8
      'sResult += String.Format("{0,-10}", vRegistro.Producto)           '10 
      'sResult += String.Format("{0,15}", " ")
      'sResult += String.Format("{0,-15}", vRegistro.ReferenciaDebito)   '15
      'sResult += CDec(vRegistro.Importe * 100).ToString("0000000000")   '10
      'sResult += vRegistro.TipoMoneda.ToString                          '1
      'sResult += String.Format("{0,22}", " ")                           '22
      'sResult += String.Format("{0,2}", " ")
      'sResult += String.Format("{0,11}", " ")
      'sResult += String.Format("{0,1}", " ")
      'sResult += String.Format("{0,3}", " ")
      'sResult += String.Format("{0,3}", " ")
      ''74
      'sResult += String.Format("{0,7}", " ")
      'sResult += String.Format("{0,8}", " ")
      'sResult += String.Format("{0,8}", " ")
      'sResult += String.Format("{0,9}", " ")
      'sResult += vRegistro.NroCuitEmpresa.ToString("00000000000")       '11
      'sResult += String.Format("{0,177}", " ")

      'rlinea = sResult
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  'Private Function GenerateTail(ByVal vNroCasos As Decimal, ByVal vImporteTotal As Decimal, ByRef rlinea As String) As Result
  '  Try
  '    Dim sResult As String = String.Empty

  '    sResult += "T"
  '    sResult += vNroCasos.ToString("0000000")                            '7
  '    sResult += CDec(vImporteTotal * 100).ToString("000000000000000")    '15
  '    sResult += String.Format("{0,177}", " ")

  '    rlinea = sResult
  '    Return Result.OK
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  'Private Function GetReserva() As String
  '  Try
  '    Return String.Format("ORI{0}{1}.100", m_FechaPresentacion.ToString("ddMM"), "0")
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return String.Format("ORI{0}{1}.100", Today.ToString("ddMM"), "0")
  '  End Try
  'End Function



End Class
