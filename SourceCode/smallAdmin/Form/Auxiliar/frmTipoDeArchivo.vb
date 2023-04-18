Imports libCommon.Comunes
Imports manDB
Public Class frmTipoDeArchivo

  Private m_ExportImport As E_TIPO_INTERCAMBIO
  Private m_Movimientos As List(Of clsInfoMovimiento)
  Private m_TipoPagoSeleccionado As clsTipoPago = Nothing

  Public Enum E_TIPO_INTERCAMBIO As Integer
    Importar = 1
    Exportar = 2
  End Enum

  Public ReadOnly Property Movimientos As List(Of clsInfoMovimiento)
    Get
      Return m_Movimientos
    End Get
  End Property

  Public ReadOnly Property TipoPagoSeleccionado As clsTipoPago
    Get
      Return m_TipoPagoSeleccionado
    End Get
  End Property

  Public Sub New(ByVal vMood As E_TIPO_INTERCAMBIO)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      m_ExportImport = vMood
      Select Case vMood
        Case E_TIPO_INTERCAMBIO.Importar
          lblInfoImpExp.Text = "Seleccione el tipo de pago a Importar"
        Case E_TIPO_INTERCAMBIO.Exportar
          lblInfoImpExp.Text = "Seleccione el tipo de pago a Exportar"
        Case Else
          lblInfoImpExp.Text = "Seleccione el tipo de pago"
      End Select

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmTipoDeArchivo_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      cmbTipoPago.DataSource = g_TipoPago
      cmbTipoPago.SelectedIndex = 1
      m_Movimientos = New List(Of clsInfoMovimiento)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelImpExp.MouseClick
    Try
      DialogResult = Windows.Forms.DialogResult.Cancel
      Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnContinuarImpExp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnContinuarImpExp.MouseClick
    Try
      If cmbTipoPago.SelectedIndex < 0 Then
        MsgBox("Debe seleccionar un modo de pago/cobro")
        Exit Sub
      End If
      m_TipoPagoSeleccionado = CType(cmbTipoPago.SelectedItem, clsTipoPago)

      If m_ExportImport = E_TIPO_INTERCAMBIO.Exportar Then

        DialogResult = Windows.Forms.DialogResult.OK
        Close()
      ElseIf m_ExportImport = E_TIPO_INTERCAMBIO.Importar Then
        If m_TipoPagoSeleccionado.GuidTipo = Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117926") Then
          DialogResult = Windows.Forms.DialogResult.OK
          Close()
          Exit Sub
        End If
        Dim archivo As New List(Of String)
        Dim AbrirArchivo As New OpenFileDialog
        If AbrirArchivo.ShowDialog <> Windows.Forms.DialogResult.OK Then
          DialogResult = Windows.Forms.DialogResult.Cancel
          Me.Close()
          Exit Sub
        End If

        If modFile.Load(AbrirArchivo.FileName, archivo) <> Result.OK Then
          MsgBox("Error al abrir archivo")
          DialogResult = Windows.Forms.DialogResult.Cancel
          Close()
          Exit Sub
        End If
        Dim s As String = IO.Path.Combine(IMPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_" & AbrirArchivo.SafeFileName)

        IO.File.Copy(AbrirArchivo.FileName, s)
        Dim mov As New List(Of clsInfoMovimiento)
        Select Case m_TipoPagoSeleccionado.GuidTipo
          Case Guid.Parse("9ebcf274-f84f-42ac-b3de-d375bb3bd314") 'efectivo
            MsgBox("No implementado")
            DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
          Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito
            GetCuerpoVISADebito(archivo, mov)
            'FillResumenView(mov)
          Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
            GetCuerpoCBU(archivo, mov)
            'FillResumenViewCBU(mov)
          Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
            GetCuerpoVISACredito(archivo, mov)
            'FillResumenView(mov)
          Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito
            GetCuerpoFirstData(archivo, mov)
            'DialogResult = Windows.Forms.DialogResult.Cancel
            'Exit Sub
          Case Guid.Parse("598878be-b8b3-4b1b-9261-f989f0800afc")
            MsgBox("No implementado")
            DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
          Case Else
            MsgBox("No se encuentra tipo de pago")
            DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End Select
        DialogResult = Windows.Forms.DialogResult.OK
        m_Movimientos = New List(Of clsInfoMovimiento)
        m_Movimientos.AddRange(mov.ToList)
        Close()
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      Me.Close()
    End Try
  End Sub
End Class