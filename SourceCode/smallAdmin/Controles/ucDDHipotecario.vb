Imports libCommon.Comunes
Imports manDB
Public Class ucDDHipotecario

  Private m_GuidCliente As Guid = Guid.Empty
  Private m_TipodeCuenta As Guid = Guid.Empty
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub SetReadOnly(ByVal vReadOnly As Boolean)
    Try
      UctxtCBU.ReadOnly = vReadOnly
      uctxtCodigoBanco.ReadOnly = vReadOnly
      uctxtSucursal.ReadOnly = vReadOnly
      uctxtCuenta.ReadOnly = vReadOnly
      uctxtTipoCuenta.ReadOnly = vReadOnly

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub SetData(ByVal vData As clsInfoCuenta)
    Try
      With vData
        UctxtCBU.Text = .Codigo1
        uctxtCodigoBanco.Text = .Codigo2
        uctxtSucursal.Text = .Codigo3
        uctxtCuenta.Text = .Codigo4
        uctxtTipoCuenta.Text = .Codigo5
        m_TipodeCuenta = .TipoDeCuenta
        m_GuidCliente = .GuidCliente
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetData(ByRef rData As clsInfoCuenta) As Boolean
    Try
      If UctxtCBU.Text.Length <> 22 Then Return False
      With rData
        .Codigo1 = UctxtCBU.Text.ToString
        .Codigo2 = uctxtCodigoBanco.Text.ToString
        .Codigo3 = uctxtSucursal.Text.ToString
        .Codigo4 = uctxtCuenta.Text.ToString
        .Codigo5 = uctxtTipoCuenta.Text.ToString
        .TipoDeCuenta = m_TipodeCuenta
        .GuidCliente = m_GuidCliente
      End With
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Public Sub Clear()
    Try
      UctxtCBU.Text = String.Empty
      uctxtCodigoBanco.Text = String.Empty
      uctxtSucursal.Text = String.Empty
      uctxtCuenta.Text = String.Empty
      uctxtTipoCuenta.Text = String.Empty
      m_GuidCliente = Guid.Empty
      m_TipodeCuenta = Guid.Empty
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub UctxtCBU_TextChanged(sender As Object, e As EventArgs) Handles UctxtCBU.TextChanged
    Try
      If UctxtCBU.Text.Length <> 22 Then
        uctxtCodigoBanco.Text = "0"
        uctxtCuenta.Text = "0"
        uctxtSucursal.Text = "0"
        uctxtTipoCuenta.Text = " "
      Else
        uctxtCodigoBanco.Text = UctxtCBU.Text.Substring(0, 3) '"Codigo Banco"
        uctxtSucursal.Text = UctxtCBU.Text.Substring(3, 4) '"Numero Sucursal"
        uctxtCuenta.Text = UctxtCBU.Text.Substring(8, 14) '"Numero de cuenta"
        uctxtTipoCuenta.Text = " " '"Tipo Cuenta"
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class
