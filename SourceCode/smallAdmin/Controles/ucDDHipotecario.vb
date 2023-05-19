Imports libCommon.Comunes
Imports manDB
Public Class ucDDHipotecario

  Private m_GuidCliente As Guid = Guid.Empty
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

        m_GuidCliente = .GuidCliente
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetData(ByRef rData As clsInfoCuenta)
    Try
      With rData
        .TipoDeCuenta = clsModoDebito.GUID_HIPOTECARIO
        .Codigo1 = UctxtCBU.GetDecimalValue.ToString
        .Codigo2 = uctxtCodigoBanco.GetDecimalValue.ToString
        .Codigo3 = uctxtSucursal.GetDecimalValue.ToString
        .Codigo4 = uctxtCuenta.GetDecimalValue.ToString
        .Codigo5 = uctxtTipoCuenta.GetDecimalValue.ToString
        .GuidCliente = m_GuidCliente
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




  'Private Sub NombrarCampos(ByVal vTipoDeCuenta As clsTipoPago)
  '  Try
  '    If vTipoDeCuenta Is Nothing Then
  '      UctxtCBU.Visible = False
  '      uctxtCodigoBanco.Visible = False
  '      uctxtSucursal.Visible = False
  '      uctxtCuenta.Visible = False
  '      uctxtTipoCuenta.Visible = False
  '      Exit Sub
  '    End If
  '    lblCodigo1.Text = vTipoDeCuenta.NombreCodigo1
  '    lblCodigo1.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo1)
  '    txtCodigo1.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo1)

  '    lblCodigo2.Text = vTipoDeCuenta.NombreCodigo2
  '    lblCodigo2.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo2)
  '    txtCodigo2.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo2)

  '    lblCodigo3.Text = vTipoDeCuenta.NombreCodigo3
  '    lblCodigo3.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo3)
  '    txtCodigo3.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo3)

  '    lblCodigo4.Text = vTipoDeCuenta.NombreCodigo4
  '    lblCodigo4.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo4)
  '    txtCodigo4.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo4)

  '    lblCodigo5.Text = vTipoDeCuenta.NombreCodigo5
  '    lblCodigo5.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo5)
  '    txtCodigo5.Visible = Not String.IsNullOrEmpty(vTipoDeCuenta.NombreCodigo5)

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

End Class
