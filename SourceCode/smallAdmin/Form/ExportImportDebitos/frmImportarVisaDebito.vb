Imports libCommon.Comunes
Imports manDB

Public Class frmImportarVisaDebito

  Private m_Result As libCommon.Comunes.Result = Result.CANCEL

  Private m_Banco As clsVisaDebito

  Private m_TipoPago As clsTipoPago


  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_TipoPago = vTipoPago.Clone
      m_Banco = New clsVisaDebito(vTipoPago.GuidTipo)
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

      ClsInfoImportarVisaDebitoBindingSource.DataSource = m_Banco.m_Registros
      ClsInfoImportarVisaDebitoBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Banco.RegistrosCargados.ToString)

      txtTotalRegistrosDebitar.Text = m_Banco.RegistrosAceptados.ToString
      lblRechazados.Text = String.Format("Registros Rechazados: {0}", m_Banco.RegistrosRechazados)

      txtFechaEjecucion.Text = m_Banco.FechaEjecucion.ToString("yyyy/MM/dd")
      txtCUITEmpresa.Text = m_Banco.CUIT_empresa
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