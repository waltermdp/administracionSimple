Imports libCommon.Comunes
Imports manDB

Public Class ucServicioVirtual
  Private m_GuidCliente As Guid = Guid.Empty
  Private m_TipodeCuenta As Guid = Guid.Empty

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub SetReadOnly(ByVal vReadOnly As Boolean)
    Try
      uctxtCVU.ReadOnly = vReadOnly
      txtAlias.ReadOnly = vReadOnly


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub SetData(ByVal vData As clsInfoCuenta)
    Try
      With vData
        txtAlias.Text = .Codigo1
        uctxtCVU.Text = .Codigo2
        m_TipodeCuenta = .TipoDeCuenta
        m_GuidCliente = .GuidCliente
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetData(ByRef rData As clsInfoCuenta) As Boolean
    Try
      If String.IsNullOrEmpty(uctxtCVU.Text) AndAlso String.IsNullOrEmpty(txtAlias.Text) Then Return False
      With rData
        .Codigo1 = txtAlias.Text.ToString
        .Codigo2 = uctxtCVU.Text.ToString
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
      uctxtCVU.Text = String.Empty
      txtAlias.Text = String.Empty
      m_GuidCliente = Guid.Empty
      m_TipodeCuenta = Guid.Empty
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Public Function EsValido() As Boolean
    Try
      If String.IsNullOrEmpty(uctxtCVU.Text) AndAlso String.IsNullOrEmpty(txtAlias.Text) Then Return False
      'If uctxtCVU.Text.Length <> 22 Then Return False
      If (txtAlias.Text.Count < 4) OrElse (txtAlias.Text.Count > 50) Then Return False
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

End Class
