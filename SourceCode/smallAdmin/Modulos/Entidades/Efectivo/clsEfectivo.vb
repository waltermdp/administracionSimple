﻿Option Strict Off
Imports Excel = Microsoft.Office.Interop.Excel
Imports libCommon.Comunes

Public Class clsEfectivo
  Private m_GuidTipoPago As Guid
  Private m_FechaVto As Date
  Private m_FechaPresentacion As Date

  Public m_RegistrosExportar As New List(Of clsInfoExportarEfectivo)

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
      m_RegistrosExportar = New List(Of clsInfoExportarEfectivo)
      Dim movimiento As clsInfoExportarEfectivo

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe & " AND GuidCuenta IN (SELECT Cuentas.GuidCuenta FROM Cuentas WHERE TipoDeCuenta={" & m_GuidTipoPago.ToString & "})"
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoExportarEfectivo

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

          .IdentificadorDebito = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .NumeroComprobante = lstProducto.Items.First.NumComprobante
          '.Producto = Producto
          .FechaVto = FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          '.NroCuitEmpresa = NroCuitEmpresa
          '.ReferenciaDebito = ReferenciaDebito
          '.FechaUltimaExportacion = item.FechaUltimaExportacion
          '.GuidPago = item.GuidPago
          .FechaUltimaExportacion = item.FechaUltimaExportacion
          .GuidPago = item.GuidPago
          .EstadoContrato = lstProducto.Items.First.Estado
          .GuidProducto = lstProducto.Items.First.GuidProducto
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
      Dim Exportable As List(Of clsInfoExportarEfectivo) = m_RegistrosExportar.Where(Function(c) c.Exportar = True).ToList

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

  Public Function GetExportedFile(ByVal vlstRegistros As List(Of clsInfoExportarEfectivo), ByRef rlineas As List(Of String)) As Result
    Try
      Dim auxLinea As String = String.Empty
      Dim lstResult As New List(Of String)
      Dim ImporteTotal As Decimal = 0

      If vlstRegistros.Count <= 0 Then
        MsgBox("No hay registros seleccionados para Exportar")
        Return Result.CANCEL
      End If



      ImporteTotal = vlstRegistros.Sum(Function(c) c.Importe)
      ExportTXT(vlstRegistros, rlineas)
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

  Private Shared Function ExportTXT(ByVal vMovimientos As List(Of clsInfoExportarEfectivo), ByRef rLineas As List(Of String)) As Result
    Try
      Dim lineas As New List(Of String)
      rLineas = New List(Of String)
      Dim aux As String = String.Empty
      Dim FechaGeneracion As Date = GetAhora()
      'HEADER
      aux += FechaGeneracion.ToString("yyyyMMdd").PadLeft(8)

      lineas.Add(aux)

      'BODY

      For Each movimiento In vMovimientos.OrderBy(Function(d) CInt(d.NumeroComprobante))
        With movimiento
          aux = String.Format("{0,25}", CStr(.NumeroComprobante))
          aux += String.Format("{0,25}", CStr(.Nombre))
          aux += String.Format("{0,25}", CStr(.Importe))
          aux += String.Format("{0,25}", CStr(.FechaVto.ToString("yyyy/MM/dd")))
          aux += String.Format("{0,25}", CStr(.CuotaActual))

        End With
        lineas.Add(aux)
      Next

      'TAIL
      aux += CInt(vMovimientos.Sum(Function(c) CSng(c.Importe)) * 100).ToString.PadLeft(15, "0")

      lineas.Add(aux)
      rLineas.AddRange(lineas.ToArray)

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

  

  Public Function GetFileNameExport(ByRef rName As String) As Result
    Try

      rName = g_Today.ToString("yyyyMMddhhmm") & "_" & "Efectivo" & ".txt"
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetFolderExportacion() As String
    Try
      Dim pathExportacion As String = IO.Path.Combine(EXPORT_PATH, "Efectivo")
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



#End Region


End Class
