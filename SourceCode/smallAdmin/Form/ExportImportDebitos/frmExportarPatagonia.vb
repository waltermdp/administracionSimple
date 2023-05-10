Imports libCommon.Comunes
Imports manDB
Public Class frmExportarPatagonia
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_TipoPago As clsTipoPago

  Private m_Registros As New List(Of clsInfoPatagonia)
  Private m_Banco As clsPatagonia
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



  Private Sub frmExportarPatagonia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      m_Banco = New clsPatagonia
      m_skip = True
      dtCurrent.Value = m_Banco.FechaPresentacion
      dtVencimiento.MinDate = dtCurrent.Value
      dtVencimiento.Value = Today.AddDays(2)
      m_Banco.FechaVencimiento = dtVencimiento.Value
      m_Banco.FechaPresentacion = dtCurrent.Value
      txtProducto.Text = m_Banco.Producto
      txtRazonSocial.Text = m_Banco.RazonSocial
      txtNroCUIT.Text = m_Banco.NroCuitEmpresa.ToString
      txtReferencia.Text = m_Banco.ReferenciaDebito
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
      ClsInfoPatagoniaBindingSource.DataSource = m_Registros
      ClsInfoPatagoniaBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Registros.Count)
      txtImporteTotal.Text = m_Registros.Sum(Function(c) c.Importe).ToString
      txtProducto.Text = m_Banco.Producto
      txtRazonSocial.Text = m_Banco.RazonSocial
      txtNroCUIT.Text = m_Banco.NroCuitEmpresa.ToString
      txtReferencia.Text = m_Banco.ReferenciaDebito

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarInicio()
    Try
      m_Registros = New List(Of clsInfoPatagonia)
      GenerateResumen(m_TipoPago, dtVencimiento.Value, m_Registros)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GenerateResumen(ByVal vTipoPago As manDB.clsTipoPago, ByVal vFechaVencimiento As Date, ByRef rRegistros As List(Of clsInfoPatagonia)) As Result
    Try

      Dim lstPago As New clsListPagos
      rRegistros = New List(Of clsInfoPatagonia)
      Dim movimiento As clsInfoPatagonia

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoPatagonia

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
          .CBU = CDec(lstCuenta.Items.First.Codigo1)
          .Cuit_DNI = CDec(lstCliente.Items.First.DNI) ' lstCuenta.Items.First.Codigo2)
          .Nombre = lstCliente.Items.First.ToString
          .Contrato = lstProducto.Items.First.NumComprobante
          .Producto = m_Banco.Producto
          .FechaVto = m_Banco.FechaVencimiento ' lstCuenta.Items.First.Codigo3
          .Importe = item.ValorCuota
          .CuotaActual = item.NumCuota
          .NroCuitEmpresa = m_Banco.NroCuitEmpresa
          .ReferenciaDebito = m_Banco.ReferenciaDebito


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
        .RazonSocial = txtRazonSocial.Text
        .Producto = txtProducto.Text
        .NroCuitEmpresa = CDec(txtNroCUIT.Text)
        .FechaPresentacion = dtCurrent.Value
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
      m_Banco.FechaPresentacion = dtCurrent.Value
      If auxVen <> dtVencimiento.Value Then
        m_Banco.FechaVencimiento = dtVencimiento.Value
        For Each registro In m_Registros
          registro.FechaVto = dtVencimiento.Value
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
        registro.FechaVto = dtVencimiento.Value
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

 

  Private Sub txtNroCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroCUIT.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
      End If
      If txtNroCUIT.Text.Length >= 11 Then
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

  Private Sub txtNroCUIT_TextChanged(sender As Object, e As EventArgs) Handles txtNroCUIT.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If Not IsNumeric(txtNroCUIT.Text.Trim) Then
        m_skip = False
        Exit Sub
      End If

      'If txtNumeroConvenio.Text.Length <= 0 Then txtNumeroConvenio.Text = 0
      'If txtNumeroConvenio.Text.Length > 5 Then txtNumeroConvenio.Text = txtNumeroConvenio.Text.Substring(0, 5)
      m_Banco.NroCuitEmpresa = CDec(txtNroCUIT.Text)
      For Each registro In m_Registros
        registro.NroCuitEmpresa = m_Banco.NroCuitEmpresa
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      If txtReferencia.Text.Length >= 15 Then
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

  Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged
    Try
      'maximo 15
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.ReferenciaDebito = txtReferencia.Text
      For Each registro In m_Registros
        registro.ReferenciaDebito = m_Banco.ReferenciaDebito
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub


  Private Sub RefeshGrilla()
    Try
      ClsInfoPatagoniaBindingSource.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If txtProducto.Text.Length >= 10 Then
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

  Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.Producto = txtProducto.Text
      For Each registro In m_Registros
        registro.Producto = m_Banco.Producto
      Next
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub

  Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
    Try
      If m_skip Then Exit Sub
      m_skip = True
      If txtRazonSocial.Text.Length >= 35 Then
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

  Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
    Try
      If m_skip Then Exit Sub
      m_skip = True
      m_Banco.RazonSocial = txtRazonSocial.Text
      RefeshGrilla()
      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class