Imports libCommon.Comunes
Imports manDB

Public Class frmExportarHipotecario
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_TipoPago As clsTipoPago
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
      m_Banco.CargarContratosAExportar(Me)
      ClsInfoHipotecarioBindingSource.DataSource = m_Banco.m_RegistrosExportar
      ClsInfoHipotecarioBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Banco.countRegistrosAExportar)
      txtImporteTotal.Text = m_Banco.ImporteTotalAExportar
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
      Dim vResult As Result
      vResult = m_Banco.GenerarExportacion(Me)
      If vResult = Result.OK Then
        '      MsgBox("La exportacion finalizo correctamente")
        Dim msgResult As MsgBoxResult = MsgBox("Desea abrir la carpeta del archivo exportado?", MsgBoxStyle.YesNo)
        If msgResult = MsgBoxResult.Yes Then
          Process.Start(m_Banco.GetFolderExportacion)
        End If
        m_Result = Result.OK
        Me.Close()
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
        m_Banco.UpdateFechaVencimientoExportar(dtVencimiento.Value)
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
      m_Banco.UpdateFechaVencimientoExportar(dtVencimiento.Value)
      
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