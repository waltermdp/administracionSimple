Imports libCommon.Comunes
Imports manDB

Public Class frmResumen
  Private m_Movimientos As New List(Of clsInfoMovimiento)
  Private m_TipoPagoSeleccionado As clsTipoPago = Nothing

  Public Property Movimientos As List(Of clsInfoMovimiento)
    Get
      Return m_Movimientos
    End Get
    Set(value As List(Of clsInfoMovimiento))
      m_Movimientos = value.ToList
    End Set
  End Property

  Public Property TipoDePago As clsTipoPago
    Get
      Return m_TipoPagoSeleccionado
    End Get
    Set(value As clsTipoPago)
      m_TipoPagoSeleccionado = value
    End Set
  End Property


  Private Sub btnOK_MouseClick(sender As Object, e As MouseEventArgs) Handles btnOK.MouseClick
    Try
      'aplicar pagos
      If m_Movimientos Is Nothing Then Exit Sub
      Dim vResult As Result
      Dim lstPagos As clsListPagos
      Dim lstProducto = New clsListProductos

      For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        lstPagos = New clsListPagos
        Dim Pago As New clsInfoPagos

        If m_TipoPagoSeleccionado.GuidTipo = Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") Then
          MsgBox("No se encuentra tipo de pago")
          Me.Close()
        End If

        lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante & " and EstadoPago=0"
        lstPagos.RefreshData()
        If lstPagos.Items.Count = 0 Then
          MsgBox("No exite el comprobante " & mov.NumeroComprobante)
          Continue For
        End If
        'If lstPagos.Items.Count > 1 Then
        '  MsgBox("Existe mas de un producto con el mismo comprobante " & mov.NumeroComprobante)
        '  Exit Sub
        'End If
        Pago = lstPagos.Items.First.Clone

        lstProducto = New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & Pago.GuidProducto.ToString & "}"
        lstProducto.RefreshData()
        Dim Producto As New clsInfoProducto
        Producto = lstProducto.Items.First.Clone
        Pago.EstadoPago = E_EstadoPago.Pago
        Pago.FechaPago = Date.Now

        vResult = clsPago.Save(Pago)
        If vResult <> Result.OK Then
          MsgBox("Fallo guardar pagos")
          Exit Sub
        End If

        Dim auxPago As New clsInfoPagos
        If (lstProducto.Items.First.CuotasDebe - 1) > 0 Then
          auxPago = GetProximoPago(Pago.GuidProducto, Producto.NumComprobante, Producto.ValorCuotaFija, Pago.NumCuota + 1, Producto.FechaVenta, Pago.VencimientoCuota)
        End If
        If auxPago IsNot Nothing Then
          vResult = clsPago.Save(auxPago)
          If vResult <> Result.OK Then
            MsgBox("Fallo guardar nuevo pago")
            Exit Sub
          End If
        End If

      Next

      ''collectar la informacion a mostrar antes de aplicar el pago elgido
      'Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
      '                                  "Nombre: {0}" & vbNewLine & _
      '                                  "DNI: {1}" & vbNewLine & _
      '                                  "Metodo Pago: {2}" & vbNewLine & _
      '                                  "Numero: {3}" & vbNewLine & _
      '                                  "Valor Cuota: {4}" & vbNewLine & _
      '                                   "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.NombreCliente, m_CurrentProducto.DNI, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.NumPago, m_CurrentProducto.ValorCuota, Today)


    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      Me.Close()
    End Try
  End Sub

  Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick
    Try

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      Me.Close()
    End Try
  End Sub

  Private Sub FillResumenView(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.Columns.Add("NumComprobante")
      lstViewResumen.Columns.Add("NumTarjeta")
      lstViewResumen.Columns.Add("Estado")
      lstViewResumen.Columns.Add("Importe")
      lstViewResumen.Columns.Add("Detalle")
      Dim item As ListViewItem
      For Each movimiento In vMovimientos
        item = New ListViewItem
        item.Text = CLng(movimiento.NumeroComprobante).ToString
        item.SubItems.Add(movimiento.NumeroTarjeta)
        If IsNumeric(movimiento.Codigo) Then
          movimiento.Estado = E_EstadoPago.Debe
          item.SubItems.Add(E_EstadoPago.Debe.ToString)
        Else
          movimiento.Estado = E_EstadoPago.Pago
          item.SubItems.Add(E_EstadoPago.Pago.ToString)
        End If
        item.SubItems.Add(String.Format("{0:N2}", CDec(movimiento.Importe / 100)))
        item.SubItems.Add(movimiento.Detalle)
        lstViewResumen.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally

    End Try
  End Sub

  Private Sub FillResumenViewMASTER(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.Columns.Add("NumComprobante")
      lstViewResumen.Columns.Add("NumTarjeta")
      lstViewResumen.Columns.Add("Estado")
      lstViewResumen.Columns.Add("Importe")
      lstViewResumen.Columns.Add("Detalle")
      Dim item As ListViewItem
      For Each movimiento In vMovimientos
        item = New ListViewItem
        item.Text = CInt(movimiento.NumeroComprobante).ToString
        item.SubItems.Add(movimiento.NumeroTarjeta)
        If movimiento.Codigo <> "00" Then
          movimiento.Estado = E_EstadoPago.Debe
          item.SubItems.Add(E_EstadoPago.Debe.ToString)
        Else
          movimiento.Estado = E_EstadoPago.Pago
          item.SubItems.Add(E_EstadoPago.Pago.ToString)
        End If
        item.SubItems.Add(String.Format("{0:N2}", CDec(movimiento.Importe / 100)))
        item.SubItems.Add(movimiento.Detalle)
        lstViewResumen.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally

    End Try
  End Sub

  Private Sub FillResumenViewCBU(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.Columns.Add("Identificador")
      lstViewResumen.Columns.Add("CBU")
      lstViewResumen.Columns.Add("Concepto")
      lstViewResumen.Columns.Add("Importe Cobrado")
      lstViewResumen.Columns.Add("Detalle")
      Dim item As ListViewItem

      For Each movimiento In vMovimientos

        item = New ListViewItem
        item.Text = movimiento.IdentificadorDebito
        item.SubItems.Add(movimiento.NumeroTarjeta)
        If Not IsNumeric(movimiento.Importe) Then
          movimiento.Estado = E_EstadoPago.Debe
          item.SubItems.Add(E_EstadoPago.Debe.ToString)
          item.SubItems.Add(CDec(0.0))
        Else
          movimiento.Estado = E_EstadoPago.Pago
          item.SubItems.Add(E_EstadoPago.Pago.ToString)
          item.SubItems.Add(String.Format("{0:N2}", CDec(movimiento.Importe / 100)))
        End If

        item.SubItems.Add(movimiento.Detalle)
        lstViewResumen.Items.Add(item)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally

    End Try
  End Sub

  Private Sub frmResumen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      If m_Movimientos Is Nothing Then
        MsgBox("movimientos vacios")
        Me.Close()

      End If

      Select Case m_TipoPagoSeleccionado.GuidTipo

        Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito
          FillResumenView(m_Movimientos)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
          FillResumenViewCBU(m_Movimientos)
        Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
          FillResumenView(m_Movimientos)
        Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito
          FillResumenViewMASTER(m_Movimientos)
        Case Else
          MsgBox("No se encuentra tipo de pago")
          Me.Close()
      End Select
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class