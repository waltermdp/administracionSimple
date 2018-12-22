Imports libCommon.Comunes
Imports manDB
Public Class frmCuenta

  Private m_Cuenta As clsInfoCuenta

  Public Sub New(ByVal vCuenta As clsInfoCuenta, ByVal vGuidClient As Guid)
    InitializeComponent()
    Try
      If vCuenta Is Nothing Then
        m_Cuenta = New clsInfoCuenta
        m_Cuenta.GuidCuenta = Guid.NewGuid
        m_Cuenta.GuidCliente = vGuidClient
      Else
        m_Cuenta = vCuenta.Clone
        m_Cuenta.GuidCliente = vGuidClient
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

      Dim vResult As Result

      vResult = clsCuenta.Load(m_Cuenta.GuidCuenta, m_Cuenta)
      If vResult <> Result.OK Then
        MsgBox("Falla buscar Cuenta")
        Me.Close()
      End If
      cmbTipoDeCuenta.DataSource = g_TipoPago

      Call FillData()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub FillData()
    Try
      With m_Cuenta
        txtCodigo1.Text = .Codigo1
        txtCodigo2.Text = .Codigo2
        txtCodigo3.Text = .Codigo3
        txtCodigo4.Text = .Codigo4
        cmbTipoDeCuenta.SelectedItem = g_TipoPago.First(Function(c) c.Equals(.TipoDeCuenta))
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AplicarCambios()
    Try
      With m_Cuenta
        .TipoDeCuenta = cmbTipoDeCuenta.SelectedItem
        .Codigo1 = txtCodigo1.Text
        .Codigo2 = txtCodigo2.Text
        .Codigo3 = txtCodigo3.Text
        .Codigo4 = txtCodigo4.Text
      End With

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      If Validar() = False Then
        MsgBox("Algunos campos son invalidos, no se puede guardar")
        Exit Sub
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Validar() As Boolean
    Try
      Call AplicarCambios()
      'TODO: validar los campos
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

End Class