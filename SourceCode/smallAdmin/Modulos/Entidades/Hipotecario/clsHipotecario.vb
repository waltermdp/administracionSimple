Imports libCommon.Comunes

Public Class clsHipotecario


  Private Const MONEDA As Integer = 80
  Private Const TIPOMOV As Integer = 1 '01 debitos 05 revisiones debito

  Private NROSERVICIO As String = " "
  Private NROEMPRESA As Integer = 0
  Private TIPOCUENTA As String = " "
  Private FECHATOPE As String = "00000000"

  Private m_Convenio As Integer
  Private m_IdDebito As String
  Private m_Concepto As String

  Private m_FechaGeneracion As Date
  Private m_FechaVencimiento As Date

  Private m_Secuencial As Decimal

  Private m_GuidTipoPago As Guid

  Public Property Convenio As Integer
    Get
      Return m_Convenio
    End Get
    Set(value As Integer)
      m_Convenio = value
    End Set
  End Property

  Public Property FechaGeneracion As Date
    Get
      Return m_FechaGeneracion
    End Get
    Set(value As Date)
      m_FechaGeneracion = value
    End Set
  End Property

  Public Property FechaVencimiento As Date
    Get
      Return m_FechaVencimiento
    End Get
    Set(value As Date)
      m_FechaVencimiento = value
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

  Public Property ID_Debito As String
    Get
      Return m_IdDebito
    End Get
    Set(value As String)
      m_IdDebito = value
    End Set
  End Property

  Public Property Concepto As String
    Get
      Return m_Concepto
    End Get
    Set(value As String)
      m_Concepto = value
    End Set
  End Property




  Public Sub New(ByVal vGuidConvenio As Guid)
    Try
      m_FechaGeneracion = g_Today
      m_FechaVencimiento = g_Today.AddDays(2)
      m_Secuencial = 0
      If vGuidConvenio = New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117926") Then
        m_GuidTipoPago = vGuidConvenio
        m_Convenio = 6248
      ElseIf vGuidConvenio = New Guid("d1f63b6f-81a0-4699-924b-16a219b44ef7") Then
        m_GuidTipoPago = vGuidConvenio
        m_Convenio = 7465
      Else
        m_GuidTipoPago = Guid.Empty
        m_Convenio = 0
        MsgBox("Convenio no disponible")
      End If

      m_IdDebito = "COBROCUOTA"
      m_Concepto = "CUOTA"
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

#Region "Importacion"

  Private m_LineasArchivo As New List(Of String)
  Public m_Registros As New List(Of clsInfoImportarHipotecario)
  Private m_FechaEjecucion As Date
  Private m_TotalImporte As Decimal

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
      Using objForm As New frmProgreso(AddressOf CargarInicio)
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

  Private Sub CargarInicio(ByRef rResult As Result, ByRef rMessage As String)
    Try
      m_Registros = New List(Of clsInfoImportarHipotecario)
      Dim length As Integer = m_LineasArchivo.Count
      Dim vResult As Result
      Dim validacionBloque1 As String = String.Empty
      Dim convenio As Integer
      If length > 1 Then
        FillEncabezado(m_LineasArchivo(0), convenio, m_FechaEjecucion)
        'Verifica convenio
        If m_Convenio <> convenio Then
          rMessage = "El convenio del archivo no se corresponde al seleccionado en la importacion"
          rResult = Result.NOK
          Exit Sub
        End If
        For Each linea In m_LineasArchivo.GetRange(1, length - 1)
          Dim registro As New clsInfoImportarHipotecario
          With registro
            vResult = modCommon.GetValidacionBloque1(linea.Substring(21, 3), linea.Substring(24, 4), validacionBloque1)
            If vResult <> Result.OK Then
              rMessage = "Fallo la validacion de uno de los bloques de la cuenta, se cancela el proceso"
              rResult = Result.NOK
              Exit Sub
            End If
            .NroCuenta = linea.Substring(21, 3) & linea.Substring(24, 4) & validacionBloque1 & linea.Substring(30, 14) 'linea.Substring(29, 15)
            .NroAbonado = CInt(linea.Substring(44, 22))
            .MotivoRechazo = linea.Substring(83, 4)
            .FechaDebito = New Date(CInt(linea.Substring(111, 4)), CInt(linea.Substring(111 + 4, 2)), CInt(linea.Substring(111 + 6, 2))) ' 
            'moneda 3 posiciones
            .ImporteADebitar = CDec(CDec(linea.Substring(98, 13)) / 100)
            .importeDebitado = CDec(CDec(linea.Substring(119, 13)) / 100)
            .ImporteBH = 0
            .Importar = False
            .cuota = 0
          End With
          m_Registros.Add(registro)
        Next

      End If

      ProcesarImportados()
      m_TotalImporte = m_Registros.Where(Function(c) c.Importar = True).Sum(Function(c) c.ImporteADebitar)

      rMessage = "Finalizado OK"
      rResult = Result.OK
      Exit Sub
    Catch ex As Exception
      Print_msg(ex.Message)
      rMessage = ex.Message
      rResult = Result.ErrorEx
    End Try
  End Sub

  Private Sub ProcesarImportados()
    Try
      'toma cada registro y aplica si se realizo el pago correspondiente
      'validar cbu, id y valor debito contra db
      For Each item In m_Registros ' tmpRegistros
        ' If item.ImporteADebitar <> item.importeDebitado OrElse item.MotivoRechazo <> String.Empty Then Continue For
        Dim objVenta As New clsListProductos
        objVenta.Cfg_Filtro = "WHERE NumComprobante=" & item.NroAbonado.ToString
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
          objCuentas.Cfg_Filtro = "WHERE GuidCuenta={" & objVenta.Items.First.GuidCuenta.ToString & "} and TipoDeCuenta={" & m_GuidTipoPago.ToString & "}" '
          objCuentas.RefreshData()
          If objCuentas.Items.Count = 1 Then
            'comparo CBU con codigo1
            item.GuidCuenta = objCuentas.Items.First.GuidCuenta
            If item.NroCuenta = objCuentas.Items.First.Codigo1 Then
              'confirmado
              'aplicar pago cuota actual a debitar
              Dim objPagos As New clsListPagos
              objPagos.Cfg_Filtro = "WHERE GuidProducto={" & objVenta.Items.First.GuidProducto.ToString & "} and EstadoPago=" & CInt(E_EstadoPago.Debe).ToString
              objPagos.RefreshData()
              If objPagos.Items.Count = 1 Then
                item.GuidPago = objPagos.Items.First.GuidPago
                item.FechaUltimaImportacion = objPagos.Items.First.FechaUltimaImportacion
                If (item.ImporteADebitar = item.importeDebitado) AndAlso String.IsNullOrWhiteSpace(item.MotivoRechazo) Then
                  item.Importar = True

                End If

              End If
            End If
          End If
        Else
          'Marcar como no encontrado
          'MsgBox("no encontrado, marcar")
        End If

      Next
      Dim k As Integer = 0
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillEncabezado(ByVal vLineaEncabezado As String, ByRef rConvenio As Integer, ByRef rFechaEjecucion As Date)
    Try
      'validar encabezado
      'vLineaEncabezado.Length =xx
      If vLineaEncabezado.Substring(0, 1) <> "1" Then Exit Sub
      rConvenio = CInt(vLineaEncabezado.Substring(1, 5))
      rFechaEjecucion = New Date(CInt(vLineaEncabezado.Substring(21, 4)), CInt(vLineaEncabezado.Substring(25, 2)), CInt(vLineaEncabezado.Substring(27, 2)))

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
          Dim objDebitoActualizado As manDB.clsInfoPagos = objDebitos.Items.First.Clone
          objDebitoActualizado.EstadoPago = E_EstadoPago.Pago
          objDebitoActualizado.FechaPago = item.FechaDebito
          objDebitoActualizado.FechaUltimaImportacion = g_Today
          If clsPago.Save(objDebitoActualizado) <> Result.OK Then
            'TODO: take error
            rMessage = "No pudo guardarse el proceso"
            rResult = Result.NOK
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

#Region "Exportacion"

  Public m_RegistrosExportar As New List(Of clsInfoExportarHipotecario)

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

  Public Sub UpdateFechaVencimientoExportar(ByVal vDate As Date)
    Try
      m_FechaVencimiento = vDate
      For Each registro In m_RegistrosExportar
        registro.FechaVencimiento = vDate
      Next
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

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
      m_RegistrosExportar = New List(Of clsInfoExportarHipotecario)
      Dim movimiento As clsInfoExportarHipotecario

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoExportarHipotecario

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "} and GuidTipoPago = {" & m_GuidTipoPago.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
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

            For Each producto In auxPrimerPago.Items
              Dim aux As New clsListPagos
              aux.Cfg_Filtro = "where GuidProducto={" & producto.GuidProducto.ToString & "}"
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
          .CBU = lstCuenta.Items.First.Codigo1
          .CodigoBanco = CDec(lstCuenta.Items.First.Codigo2)
          .CodigoSucCuenta = CInt(lstCuenta.Items.First.Codigo3)
          .CuentaBanco = CDec(lstCuenta.Items.First.Codigo4)
          .TipoCuenta = lstCuenta.Items.First.Codigo5
          .NumeroContrato = lstProducto.Items.First.NumComprobante
          .Importe = item.ValorCuota
          .idCliente = lstCliente.Items.First.NumCliente

          .FechaVencimiento = m_FechaVencimiento
          .CuotaActual = item.NumCuota
          .Nombre = lstCliente.Items.First.ToString
          .FechaUltimaExportacion = item.FechaUltimaExportacion
          .GuidPago = item.GuidPago
          .Exportar = True
        End With
        m_RegistrosExportar.Add(movimiento)
      Next
      rMessage = "Finalizado OK"
      rResult = Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
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
      Dim Exportable As List(Of clsInfoExportarHipotecario) = m_RegistrosExportar.Where(Function(c) c.Exportar = True).ToList
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
        'FALTA CARGAR GUID de pago
        objDebitos.Cfg_Filtro = "WHERE GuidPago={" & item.GuidPago.ToString & "}"
        objDebitos.RefreshData()
        If objDebitos.Items.Count = 1 Then
          Dim objDebitoActualizado As manDB.clsInfoPagos = objDebitos.Items.First.Clone
          objDebitoActualizado.FechaUltimaExportacion = m_FechaGeneracion 'Date.MinValue '
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

  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoExportarHipotecario), ByRef rlineas As List(Of String)) As Result
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

      If GenerarHeaderDebito(auxLinea, CInt(ImporteTotal), m_FechaGeneracion, CInt(m_Secuencial)) <> Result.OK Then
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

#End Region





  Private Function GenerarHeaderDebito(ByRef rHeader As String, ByVal vImporteTotal As Integer, ByVal vFechaGen As Date, ByVal vSecuencial As Integer) As Result
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

  Public Function GetFileNameExport(ByRef rName As String) As Result
    Try
      Dim aux As String = Secuencial.ToString("000")
      rName = "ent" & m_Convenio.ToString & "_" & FechaGeneracion.ToString("yyMMdd") & "_sec_" & Secuencial.ToString("000") & ".txt"
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "Hipotecario")
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

  Private Function GenerarDetalle(ByVal vMov As clsInfoExportarHipotecario, ByRef rBody As String) As Result
    Try
      Dim sResult As String = String.Empty
      'Dim codBanco As Integer = 888 '!!!consultar
      'Dim codsucCuenta As integer=4 'CBU
      'Dim cuentabanc As Integer = 5 'CBU 
      'Dim IDActualCliente As String = "14000"
      'Dim fechaVencimiento As Date = Today '!!!!sumar n dias a la fecha actual
      'Dim importeadebitar As Integer = 3400 'sin decimal

      sResult += "0"
      sResult += m_Convenio.ToString("D5")
      sResult += String.Format("{0,10}", " ")
      sResult += NROEMPRESA.ToString("D5")
      sResult += vMov.CodigoBanco.ToString("000") 'D3")
      sResult += vMov.CodigoSucCuenta.ToString("D4") 'vMov.CBU.Substring(0, 4) ' codsucCuenta.ToString("D4")
      sResult += String.Format("{0,1}", vMov.TipoCuenta)
      If vMov.CodigoBanco = CDec(44) Then
        'hipotecario
        sResult += vMov.CuentaBanco.ToString("000000000000000") ' CBU.Substring(0, 15) 'cuentabanc.ToString("D15")
      Else
        sResult += "0" + vMov.CBU.Substring(8, 14) ' CuentaBanco.ToString("000000000000000") ' CBU.Substring(0, 15) 'cuentabanc.ToString("D15")
      End If
      sResult += String.Format("{0,-22}", vMov.NumeroContrato)
      sResult += String.Format("{0,-15}", m_IdDebito)
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
      sResult += String.Format("{0,-40}", m_Concepto)
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
