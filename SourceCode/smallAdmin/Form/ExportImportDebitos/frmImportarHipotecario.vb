﻿
Imports libCommon.Comunes
Imports manDB


Public Class frmImportarHipotecario

  Private m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_Banco As clsHipotecario
  Private m_TipoPago As clsTipoPago

  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try

      m_TipoPago = vTipoPago.Clone
      m_Banco = New clsHipotecario(vTipoPago.GuidTipo)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try
      Init()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmImportarHipotecario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Init()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Init()
    Try
     
      m_Banco.LoadImportedFile(Me)

      ClsInfoImportarHipotecarioBindingSource.DataSource = m_Banco.m_Registros
      ClsInfoImportarHipotecarioBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Banco.m_Registros.Count)
      lblRechazados.Text = String.Format("Registros Rechazados: {0}", m_Banco.RegistrosRechazados)
      txtFechaEjecucion.Text = m_Banco.FechaEjecucion.ToString("yyyy/MM/dd")
      txtConvenio.Text = m_Banco.Convenio.ToString ' m_Convenio.ToString
      txtImporteTotal.Text = m_Banco.ImporteTotalImportado.ToString
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_Result = Result.CANCEL
    End Try
  End Sub


  'Private Sub CargarInicio()
  '  Try
  '    m_Registros = New List(Of clsInfoImportarHipotecario)
  '    Dim length As Integer = m_LineasArchivo.Count
  '    Dim vResult As Result
  '    Dim validacionBloque1 As String = String.Empty

  '    If length > 1 Then
  '      FillEncabezado(m_LineasArchivo(0), m_Convenio, m_FechaEjecucion)
  '      'Verifica convenio
  '      If m_Convenio <> m_Banco.Convenio Then
  '        MsgBox("El convenio del archivo no se corresponde al seleccionado en la importacion")
  '        Exit Sub
  '      End If
  '      For Each linea In m_LineasArchivo.GetRange(1, length - 1)
  '        Dim registro As New clsInfoImportarHipotecario
  '        With registro
  '          vResult = modCommon.GetValidacionBloque1(linea.Substring(21, 3), linea.Substring(24, 4), validacionBloque1)
  '          If vResult <> Result.OK Then
  '            MsgBox("Fallo la validacion de uno de los bloques de la cuenta, se cancela el proceso")
  '            Exit Sub
  '          End If
  '          .NroCuenta = linea.Substring(21, 3) & linea.Substring(24, 4) & validacionBloque1 & linea.Substring(30, 14) 'linea.Substring(29, 15)
  '          .NroAbonado = CInt(linea.Substring(44, 22))
  '          .MotivoRechazo = linea.Substring(83, 4)
  '          .FechaDebito = New Date(CInt(linea.Substring(111, 4)), CInt(linea.Substring(111 + 4, 2)), CInt(linea.Substring(111 + 6, 2))) ' 
  '          'moneda 3 posiciones
  '          .ImporteADebitar = CDec(CDec(linea.Substring(98, 13)) / 100)
  '          .importeDebitado = CDec(CDec(linea.Substring(119, 13)) / 100)
  '          .ImporteBH = 0
  '          .Importar = False
  '          .cuota = 0
  '        End With
  '        m_Registros.Add(registro)
  '      Next

  '    End If

  '    Procesar()
  '    m_TotalImporte = m_Registros.Where(Function(c) c.Importar = True).Sum(Function(c) c.ImporteADebitar)

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

  'Private Sub Procesar()
  '  Try
  '    'toma cada registro y aplica si se realizo el pago correspondiente
  '    'validar cbu, id y valor debito contra db
  '    For Each item In m_Registros ' tmpRegistros
  '      ' If item.ImporteADebitar <> item.importeDebitado OrElse item.MotivoRechazo <> String.Empty Then Continue For
  '      Dim objVenta As New clsListProductos
  '      objVenta.Cfg_Filtro = "WHERE NumComprobante=" & item.NroAbonado.ToString
  '      objVenta.RefreshData()
  '      If objVenta.Items.Count = 1 Then
  '        item.GuidProducto = objVenta.Items.First.GuidProducto
  '        'asocio un nombre
  '        Dim objCliente As New clsListDatabase
  '        objCliente.Cfg_Filtro = "Where GuidCliente={" & objVenta.Items.First.GuidCliente.ToString.ToUpper & "}"
  '        objCliente.RefreshData()
  '        If objCliente.Items.Count = 1 Then
  '          item.Nombre = objCliente.Items.First.ToString
  '        End If
  '        Dim objCuentas As New clsListaCuentas
  '        objCuentas.Cfg_Filtro = "WHERE GuidCuenta={" & objVenta.Items.First.GuidCuenta.ToString & "} and TipoDeCuenta={" & m_TipoPago.GuidTipo.ToString & "}" '
  '        objCuentas.RefreshData()
  '        If objCuentas.Items.Count = 1 Then
  '          'comparo CBU con codigo1
  '          item.GuidCuenta = objCuentas.Items.First.GuidCuenta
  '          If item.NroCuenta = objCuentas.Items.First.Codigo1 Then
  '            'confirmado
  '            'aplicar pago cuota actual a debitar
  '            Dim objPagos As New clsListPagos
  '            objPagos.Cfg_Filtro = "WHERE GuidProducto={" & objVenta.Items.First.GuidProducto.ToString & "} and EstadoPago=" & CInt(E_EstadoPago.Debe).ToString
  '            objPagos.RefreshData()
  '            If objPagos.Items.Count = 1 Then
  '              item.GuidPago = objPagos.Items.First.GuidPago
  '              If (item.ImporteADebitar = item.importeDebitado) AndAlso String.IsNullOrWhiteSpace(item.MotivoRechazo) Then
  '                item.Importar = True
  '              End If

  '            End If
  '          End If
  '        End If
  '      Else
  '        'Marcar como no encontrado
  '        'MsgBox("no encontrado, marcar")
  '      End If

  '    Next
  '    Dim k As Integer = 0
  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub

 


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

  'Private Sub FillEncabezado(ByVal vLineaEncabezado As String, ByRef rConvenio As Integer, ByRef rFechaEjecucion As Date)
  '  Try
  '    'validar encabezado
  '    'vLineaEncabezado.Length =xx
  '    If vLineaEncabezado.Substring(0, 1) <> "1" Then Exit Sub
  '    rConvenio = CInt(vLineaEncabezado.Substring(1, 5))
  '    rFechaEjecucion = New Date(CInt(vLineaEncabezado.Substring(21, 4)), CInt(vLineaEncabezado.Substring(25, 2)), CInt(vLineaEncabezado.Substring(27, 2)))

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '  End Try
  'End Sub



  Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    Try
      'aplicar seleccionados
      If MsgBox("Los registros seleccionados seran aplicados como pagados. Desea continuar?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

      If m_Banco.ImportarSeleccionados(Me) <> Result.OK Then
        MsgBox("Existieron errores durante la importacion de los registros")
        Exit Sub
      End If

      MsgBox(String.Format("{0} registros importados correctamente", m_Banco.RegistrosAceptados))
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  
End Class