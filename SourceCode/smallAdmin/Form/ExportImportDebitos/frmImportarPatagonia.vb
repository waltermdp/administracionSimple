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
     
      ClsInfoImportarPatagoniaBindingSource.DataSource = m_Banco.m_Registros
      ClsInfoImportarPatagoniaBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Banco.RegistrosCargados.ToString)
      'm_totalRegistosADebitar = m_Registros.Where(Function(c) c.Importar = True).Count
      txtTotalRegistrosDebitar.Text = m_Banco.RegistrosAceptados.ToString
      lblRechazados.Text = String.Format("Registros Rechazados: {0}", m_Banco.RegistrosRechazados) '  m_Registros.Where(Function(c) (Not String.IsNullOrWhiteSpace(c.MotivoRechazo)) OrElse (c.importeDebitado = 0)).Count.ToString)

      txtFechaEjecucion.Text = m_Banco.FechaEjecucion.ToString("yyyy/MM/dd")
      txtCUITEmpresa.Text = m_Banco.CUIT_empresa
      txtImporteTotal.Text = m_Banco.ImporteTotalImportado.ToString


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