Imports manDB
Imports libCommon.Comunes
Public Class frmVenta

  Private m_Producto As clsInfoProducto


  Private m_skip As Boolean
  Private m_hayCambios As Boolean
  Public Sub New(Optional ByVal vProducto As clsInfoProducto = Nothing)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      If vProducto Is Nothing Then
        m_Producto = New clsInfoProducto
        m_Producto.GuidProducto = Guid.NewGuid
      Else
        m_Producto = vProducto.Clone
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      m_skip = True

      DateVenta.Value = Today
      cmbCuotas.DataSource = g_Cuotas
      cmbTipoPago.DataSource = g_TipoPago
      datePrimerPago.Value = Today
      txtPrecio.Text = 0
      m_hayCambios = False
    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Public Function HayCambios() As Boolean
    Try
      Return m_hayCambios
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Public Sub getCambios(ByRef rProducto As clsInfoProducto)
    Try
      rProducto = m_Producto.Clone

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
    Try

      Dim auxValue As String = CType(sender, TextBox).Text
      'Dim dec As Decimal
      'Dim esCorrecto As Boolean = Decimal.TryParse(auxValue, dec)
      'If (esCorrecto) Then
      '  txtPrecio.Text = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", dec)


      'End If
      'Exit Sub
      Dim dec As Decimal
      If text2decimal(auxValue, dec) Then
        Call GenerarPlanCuotas()
      End If
      
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function IsMoneyFormat(ByVal value As String) As Boolean
    Try
      If value = String.Empty Then Return False
      If value.Trim = String.Empty Then Return False
      Dim dec As Decimal
      Dim esCorrecto As Boolean = Decimal.TryParse(value, dec)
      If (esCorrecto) Then
        value = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", dec)
      End If


      If Not IsNumeric(value) Then
        Return False
      Else
        If value.Contains(",") Then
          If (value.Substring(value.IndexOf(",")).Count) > 2 Then
            Return False
          End If
        End If
      End If
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Sub cmbCuotas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuotas.SelectedIndexChanged
    Try
      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub cmbTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.SelectedIndexChanged
    Try
      Dim tipoPago As clsTipoPago = CType(cmbTipoPago.SelectedItem, clsTipoPago)
      If Not tipoPago.PermiteCuotas Then
        cmbCuotas.SelectedItem = g_Cuotas(0)
        cmbCuotas.Enabled = False
      Else
        cmbCuotas.Enabled = True
      End If
      Call GenerarPlanCuotas()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function text2decimal(ByVal vText As String, ByRef rValor As Decimal) As Boolean
    Try
      Dim esCorrecto As Boolean = Decimal.TryParse(vText, rValor)
      If esCorrecto = False Then Return False

      Dim auxString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", rValor)
      rValor = FormatNumber(rValor, 2)
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  Private Sub GenerarPlanCuotas()
    Try
      'If txtPrecio.Text = String.Empty Then Exit Sub
      'If Not IsNumeric(txtPrecio.Text) Then Exit Sub
      If cmbCuotas.SelectedIndex < 0 Then Exit Sub
      If cmbTipoPago.SelectedIndex < 0 Then Exit Sub
      m_Producto.ListaPagos.Clear()
      Dim auxCuotas As Integer = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
      Dim auxPrecio As Decimal
      If text2decimal(txtPrecio.Text, auxPrecio) = False Then Exit Sub
      Dim auxPrecioCuota As Decimal
      If auxCuotas = 0 Then
        auxPrecioCuota = auxPrecio
      Else
        auxPrecioCuota = CuotasIguales(auxPrecio, auxCuotas)
      End If

      Dim auxPago As New clsInfoPagos
      Dim auxinicio As Integer = 0
      If auxCuotas > 0 Then auxinicio = 1
      For i As Integer = auxinicio To auxCuotas
        auxPago = New clsInfoPagos
        auxPago.EstadoPago = 0
        auxPago.GuidProducto = m_Producto.GuidProducto
        auxPago.GuidPago = Guid.NewGuid
        auxPago.FechaPago = Nothing ' Vencimiento(auxCuotas, datePrimerPago.Value)
        auxPago.VencimientoCuota = Vencimiento(i, datePrimerPago.Value)
        auxPago.NumCuota = i
        auxPago.ValorCuota = auxPrecioCuota
        m_Producto.ListaPagos.Add(auxPago)
      Next
      m_Producto.FechaPrimerPago = Vencimiento(auxCuotas, datePrimerPago.Value)
      bsCuotas.DataSource = m_Producto.ListaPagos
      bsCuotas.ResetBindings(False)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function CuotasIguales(ByVal vPrecio As Decimal, ByVal cuotas As Integer) As Decimal
    Try
      Dim valorCuota As Decimal
      text2decimal(CDec(vPrecio / cuotas).ToString, valorCuota)
      Return valorCuota
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function

  Private Function Vencimiento(ByVal Cuota As Integer, ByVal PrimerPago As Date) As Date
    Try
      Return PrimerPago
    Catch ex As Exception
      Print_msg(ex.Message)
      Return PrimerPago
    End Try
  End Function

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
      m_hayCambios = False
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    Try

      With m_Producto
        .TotalCuotas = CType(cmbCuotas.SelectedItem, clsCuota).Cantidad
        .GuidTipoPago = CType(cmbTipoPago.SelectedItem, clsTipoPago).GuidTipo
        .FechaVenta = DateVenta.Value


        .Precio = CDec(txtPrecio.Text)
        .GuidVendedor = New Guid("09c216f0-a4a0-41d7-ab18-08c403968cf5")
      End With

      m_hayCambios = True
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class