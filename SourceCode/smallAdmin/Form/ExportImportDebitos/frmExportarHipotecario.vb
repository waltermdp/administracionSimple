Imports libCommon.Comunes
Imports manDB

Public Class frmExportarHipotecario
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_TipoPago As clsTipoPago

  Private m_Registros As New List(Of clsInfoHipotecario)
  Private m_Banco As clsHipotecario

  Private m_skip As Boolean = False

  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_TipoPago = vTipoPago.Clone

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub frmExportarResumen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      m_Banco = New clsHipotecario(m_TipoPago.GuidTipo)
      m_skip = True
      dtCurrent.Value = m_Banco.FechaGeneracion
      dtVencimiento.MinDate = dtCurrent.Value
      dtVencimiento.Value = Today.AddDays(2)
      txtNumeroConvenio.Text = m_Banco.Convenio.ToString
      txtSecuencial.Text = m_Banco.Secuencial.ToString
      txtIdDebito.Text = m_Banco.ID_Debito
      txtConcepto.Text = m_Banco.Concepto
      m_skip = False
      RecargarValores()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub RecargarValores()
    Try
      Using objForm As New frmProgreso(AddressOf CargarInicio)
        objForm.ShowDialog(Me)
      End Using
      ClsInfoHipotecarioBindingSource.DataSource = m_Registros
      ClsInfoHipotecarioBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Registros.Count)
      txtImporteTotal.Text = m_Registros.Sum(Function(c) c.Importe).ToString
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarInicio()
    Try
      m_Registros = New List(Of clsInfoHipotecario)
      GenerateResumen(m_TipoPago, dtVencimiento.Value, m_Registros)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GenerateResumen(ByVal vTipoPago As manDB.clsTipoPago, ByVal vFechaVencimiento As Date, ByRef rRegistros As List(Of clsInfoHipotecario)) As Result
    Try

      Dim lstPago As New clsListPagos
      rRegistros = New List(Of clsInfoHipotecario)
      Dim movimiento As clsInfoHipotecario

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoHipotecario

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "} and GuidTipoPago = {" & vTipoPago.GuidTipo.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
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

          .FechaVencimiento = vFechaVencimiento
          .CuotaActual = item.NumCuota
          .Nombre = lstCliente.Items.First.ToString

        End With
        rRegistros.Add(movimiento)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  

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
      With m_Banco
        .Concepto = txtConcepto.Text
        .Convenio = CInt(txtNumeroConvenio.Text)
        .ID_Debito = txtIdDebito.Text
        .Secuencial = CDec(txtSecuencial.Text)
        .FechaGeneracion = dtCurrent.Value
        .FechaVencimiento = dtVencimiento.Value
      End With


      Dim lineas As New List(Of String)
      If m_Banco.GetExportedFile(m_Registros, lineas) <> Result.OK Then
        MsgBox("Fallo generar archivo")
        Exit Sub
      End If
      Dim FileName As String = String.Empty
      If m_Banco.GetFileNameExport(FileName) <> Result.OK Then
        MsgBox("Fallo generar nombre")
        Exit Sub
      End If
      Dim FullFileName As String = IO.Path.Combine(m_Banco.GetFolderExportacion, FileName)
      If IO.File.Exists(FullFileName) Then
        If MsgBox(String.Format("El archivo ""{0}"" ya existe, si continua se renombra el archivo anterior. Desea continuar?", FileName), MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
          Exit Sub
        End If
        Dim chFilename As String = String.Empty

        chFilename = FileName.Insert(FileName.IndexOf("."), "_" & Date.Now.ToString("yyyyMMddhhmmss"))

        FileSystem.Rename(FullFileName, IO.Path.Combine(m_Banco.GetFolderExportacion, chFilename))
      End If
      If Save(IO.Path.Combine(m_Banco.GetFolderExportacion, FileName), lineas) <> Result.OK Then
        MsgBox("Fallo guardando archivo")
        Exit Sub
      End If

      MsgBox("La exportacion finalizo correctamente")

      Dim msgResult As MsgBoxResult = MsgBox("Desea abrir la carpeta del archivo exportado?", MsgBoxStyle.YesNo)
      If msgResult = MsgBoxResult.Yes Then
        Process.Start(m_Banco.GetFolderExportacion)
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.ErrorEx
    End Try
  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try
      RecargarValores()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dtCurrent_ValueChanged(sender As Object, e As EventArgs) Handles dtCurrent.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      Dim auxVen As Date = dtVencimiento.Value
      dtVencimiento.MinDate = dtCurrent.Value
      m_Banco.FechaGeneracion = dtCurrent.Value
      If auxVen <> dtVencimiento.Value Then
        m_Banco.FechaVencimiento = dtVencimiento.Value
        For Each registro In m_Registros
          registro.FechaVencimiento = dtVencimiento.Value
        Next
        RefeshGrilla()
      End If
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub dtVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtVencimiento.ValueChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.FechaVencimiento = dtVencimiento.Value
      For Each registro In m_Registros
        registro.FechaVencimiento = dtVencimiento.Value
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
    Try
      'maximo 40
      If m_skip Then Exit Sub
      m_skip = True
      If txtConcepto.Text.Length >= 40 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs) Handles txtConcepto.TextChanged
    Try
      'maximo 40
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.Concepto = txtConcepto.Text
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtIdDebito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDebito.KeyPress
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      If txtIdDebito.Text.Length >= 15 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtIdDebito_TextChanged(sender As Object, e As EventArgs) Handles txtIdDebito.TextChanged
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.ID_Debito = txtIdDebito.Text
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtNumeroConvenio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroConvenio.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
      End If
      If txtNumeroConvenio.Text.Length >= 5 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtNumeroConvenio_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroConvenio.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not IsNumeric(txtNumeroConvenio.Text.Trim) Then
        m_skip = False
        Exit Sub
      End If

      m_Banco.Convenio = CInt(txtNumeroConvenio.Text)
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtSecuencial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecuencial.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
      End If
      If txtSecuencial.Text.Length >= 3 Then
        If Not Char.IsControl(e.KeyChar) Then
          e.Handled = True
        End If
      End If

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub



  Private Sub txtSecuencial_TextChanged(sender As Object, e As EventArgs) Handles txtSecuencial.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not IsNumeric(txtSecuencial.Text.Trim) Then
        m_skip = False
        Exit Sub
      End If

      m_Banco.Secuencial = CDec(txtSecuencial.Text)
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub



  Private Sub RefeshGrilla()
    Try
      ClsInfoHipotecarioBindingSource.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

 


End Class