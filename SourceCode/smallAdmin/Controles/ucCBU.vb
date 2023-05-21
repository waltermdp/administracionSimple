Imports libCommon.Comunes
Imports manDB
Public Class ucCBU

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


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub SetData(ByVal vData As clsInfoCuenta)
    Try
      With vData
        UctxtCBU.Text = .Codigo1
  
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
        .Codigo1 = UctxtCBU.GetDecimalValue.ToString

        .TipoDeCuenta = m_TipodeCuenta
        .GuidCliente = m_GuidCliente
      End With
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  
End Class
