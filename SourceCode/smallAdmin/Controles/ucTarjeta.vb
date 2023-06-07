Imports libCommon.Comunes
Imports manDB
Public Class ucTarjeta

  Private m_GuidCliente As Guid = Guid.Empty
  Private m_TipodeCuenta As Guid = Guid.Empty
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub SetReadOnly(ByVal vReadOnly As Boolean)
    Try
      UctxtNumTarjeta.ReadOnly = vReadOnly
      uctxtCodSeguridad.ReadOnly = vReadOnly
      uctxtFechaVto.ReadOnly = vReadOnly


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub SetData(ByVal vData As clsInfoCuenta)
    Try
      With vData
        UctxtNumTarjeta.Text = .Codigo1
        uctxtCodSeguridad.Text = .Codigo2
        uctxtFechaVto.Text = .Codigo3

        m_TipodeCuenta = .TipoDeCuenta
        m_GuidCliente = .GuidCliente
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetData(ByRef rData As clsInfoCuenta) As Boolean
    Try
      If UctxtNumTarjeta.Text.Length <> 22 Then Return False
      With rData
        .Codigo1 = UctxtNumTarjeta.GetDecimalValue.ToString
        .Codigo2 = uctxtCodSeguridad.GetDecimalValue.ToString
        .Codigo3 = uctxtFechaVto.GetDecimalValue.ToString

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
      UctxtNumTarjeta.Text = String.Empty
      uctxtCodSeguridad.Text = String.Empty
      uctxtFechaVto.Text = String.Empty
      m_GuidCliente = Guid.Empty
      m_TipodeCuenta = Guid.Empty
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub UctxtCBU_TextChanged(sender As Object, e As EventArgs) Handles UctxtNumTarjeta.TextChanged
    Try
      If UctxtNumTarjeta.Text.Length <> 22 Then
        uctxtCodSeguridad.Text = "0"

        uctxtFechaVto.Text = "0"

      Else
        uctxtCodSeguridad.Text = UctxtNumTarjeta.Text.Substring(0, 3) '"Codigo Banco"
        uctxtFechaVto.Text = UctxtNumTarjeta.Text.Substring(3, 4) '"Numero Sucursal"

      End If
    Catch ex As Exception

    End Try
  End Sub

  Public Function EsValido() As Boolean
    Try
      Return False
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

End Class
