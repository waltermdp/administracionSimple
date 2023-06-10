Imports libCommon.Comunes
Imports manDB

Public Class frmImportarPatagonia
  Private m_Result As libCommon.Comunes.Result = Result.CANCEL
  'Private m_Registros As New List(Of clsInfoImportarPatagonia)
  Private m_Banco As clsPatagonia
  'Private m_LineasArchivo As New List(Of String)
  Private m_TipoPago As clsTipoPago

  'Private m_FechaEjecucion As Date
  'Private m_CUITEmpresa As Decimal
  'Private m_TotalImporte As Decimal
  'Private m_totalRegistros As Integer
  'Private m_totalRegistosADebitar As Integer

  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_TipoPago = vTipoPago.Clone
      m_Banco = New clsPatagonia(vTipoPago.GuidTipo)
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

  Private Sub frmImportarPatagonia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Init()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Init()
    Try
      m_Banco.LoadImportedFile(Me)
      m_LineasArchivo = New List(Of String)
      Dim vResult As Result = GetLinesFromFile(m_LineasArchivo)
      If vResult = Result.OK Then
        Using objForm As New frmProgreso(AddressOf CargarInicio)
          objForm.ShowDialog(Me)
        End Using

      End If
      ClsInfoImportarPatagoniaBindingSource.DataSource = m_Registros
      ClsInfoImportarPatagoniaBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_totalRegistros)
      m_totalRegistosADebitar = m_Registros.Where(Function(c) c.Importar = True).Count
      txtTotalRegistrosDebitar.Text = m_totalRegistosADebitar.ToString
      lblRechazados.Text = String.Format("Registros Rechazados: {0}", m_totalRegistros - m_totalRegistosADebitar) '  m_Registros.Where(Function(c) (Not String.IsNullOrWhiteSpace(c.MotivoRechazo)) OrElse (c.importeDebitado = 0)).Count.ToString)

      txtFechaEjecucion.Text = m_FechaEjecucion.ToString("yyyy/MM/dd")
      txtCUITEmpresa.Text = m_CUITEmpresa.ToString
      txtImporteTotal.Text = m_TotalImporte.ToString


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GetLinesFromFile(ByRef rLineas As List(Of String)) As Result
    Try

      Dim AbrirArchivo As New OpenFileDialog
      If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then
        Return Result.NOK
      End If

      If modFile.Load(AbrirArchivo.FileName, rLineas) <> Result.OK Then
        MsgBox("Error al abrir archivo")
        Return Result.NOK
      End If
      Dim s As String = IO.Path.Combine(IMPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_" & AbrirArchivo.SafeFileName)

      IO.File.Copy(AbrirArchivo.FileName, s)
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

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

  Private Sub CargarInicio(ByRef rResult As Result, ByRef rMessage As String)
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
            ProcesarTail(linea, m_totalRegistros, m_TotalImporte)
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
                If (item.importeDebitado > 0) AndAlso String.IsNullOrWhiteSpace(item.MotivoRechazo) Then
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

  'Private Function GenerateValidacionBloque1(ByVal vBanco As String, ByVal vSucursal As String, ByRef rValidacion1 As String) As Result
  '  Try
  '    Dim Suma1 As Integer = CInt(vBanco.Substring(0, 1)) * 7 + CInt(vBanco.Substring(1, 1)) * 1 + CInt(vBanco.Substring(2, 1)) * 3 + CInt(vSucursal.Substring(0, 1)) * 9 + CInt(vSucursal.Substring(1, 1)) * 7 + CInt(vSucursal.Substring(2, 1)) * 1 + CInt(vSucursal.Substring(3, 1)) * 3
  '    Dim diferencial As Integer = 10 - CInt(Suma1 Mod 10)
  '    If diferencial = 10 Then
  '      rValidacion1 = "0"
  '      Return Result.OK
  '    End If
  '    If diferencial >= 0 AndAlso diferencial <= 9 Then
  '      rValidacion1 = CStr(diferencial)
  '      Return Result.OK
  '    Else
  '      Return Result.NOK
  '    End If

  '  Catch ex As Exception
  '    Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_Result = Result.CANCEL
    End Try
  End Sub

  

  Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    Try
      'aplicar seleccionados
      If MsgBox("Los registros seleccionados seran aplicados como pagados. Desea continuar?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

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
      MsgBox("Finalizados correctamente")
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


End Class