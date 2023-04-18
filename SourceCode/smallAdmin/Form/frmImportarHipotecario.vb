
Imports libCommon.Comunes
Imports manDB


Public Class frmImportarHipotecario

  Private m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_Registros As New List(Of clsInfoImportarHipotecario)
  Private m_Banco As clsHipotecario
  Private m_LineasArchivo As New List(Of String)
  Private Sub frmImportarHipotecario_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

      ClsInfoImportarHipotecarioBindingSource.DataSource = m_Registros
      ClsInfoImportarHipotecarioBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Registros.Count)
      'txtImporteTotal.Text = m_Registros.Sum(Function(c) c.Importe).ToString
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

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try

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

  Private Sub frmImportarHipotecario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      m_LineasArchivo = New List(Of String)
      Dim vResult As Result = GetLinesFromFile(m_LineasArchivo)
      If vResult = Result.OK Then
        Using objForm As New frmProgreso(AddressOf CargarInicio)
          objForm.ShowDialog(Me)
        End Using

      End If


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarInicio()
    Try
      m_Registros = New List(Of clsInfoImportarHipotecario)
      Dim length As Integer = m_LineasArchivo.Count
      Dim vResult As Result
      Dim validacionBloque1 As String = String.Empty
      If length > 1 Then
        For Each linea In m_LineasArchivo.GetRange(1, length - 1)
          Dim registro As New clsInfoImportarHipotecario
          With registro
            vResult = GenerateValidacionBloque1(linea.Substring(21, 3), linea.Substring(24, 4), validacionBloque1)
            If vResult <> Result.OK Then
              MsgBox("Fallo la validacion de uno de los bloques de la cuenta, se cancela el proceso")
              Exit Sub
            End If

            .NroCuenta = linea.Substring(21, 3) & linea.Substring(24, 4) & validacionBloque1 & linea.Substring(30, 15) 'linea.Substring(29, 15)
            .NroAbonado = linea.Substring(44, 22)
            .MotivoRechazo = linea.Substring(83, 4)
            .FechaDebito = linea.Substring(87, 8)
            'moneda 3 posiciones
            .ImporteADebitar = linea.Substring(98, 13)
            .importeDebitado = linea.Substring(119, 13)
            .ImporteBH = 0
            .Importar = False
            .cuota = 0

          End With

        Next
      End If




    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GenerateValidacionBloque1(ByVal vBanco As String, ByVal vSucursal As String, ByRef rValidacion1 As String) As Result
    Try
      Dim Suma1 As Integer = CInt(vBanco.Substring(0, 1)) * 7 + CInt(vBanco.Substring(1, 1)) * 1 + CInt(vBanco.Substring(2, 1)) * 3 + CInt(vSucursal.Substring(0, 1)) * 9 + CInt(vSucursal.Substring(1, 1)) * 7 + CInt(vSucursal.Substring(2, 1)) * 1 + CInt(vSucursal.Substring(2, 1)) * 3
      Dim diferencial As Integer = 10 - CInt(Suma1 Mod 10)
      If diferencial >= 0 AndAlso diferencial <= 9 Then
        rValidacion1 = CStr(diferencial)
        Return Result.OK
      Else
        Return Result.NOK
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class