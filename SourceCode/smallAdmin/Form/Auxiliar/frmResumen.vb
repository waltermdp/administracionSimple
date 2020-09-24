Imports libCommon.Comunes
Imports manDB

Public Class frmResumen
  Private m_Movimientos As New List(Of clsInfoMovimiento)
  Private m_TipoPagoSeleccionado As clsTipoPago = Nothing
  Private m_skip As Boolean = False

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
      If m_TipoPagoSeleccionado.GuidTipo = Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") Then
        MsgBox("No se encuentra tipo de pago")
        Me.Close()
      End If
      Dim lError As String = String.Empty
      'Simular pagos
      Dim lstNoExisten As New List(Of String)
      For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        lstPagos = New clsListPagos
        lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante
        lstPagos.RefreshData()
        If lstPagos.Items.Count = 0 Then
          lstNoExisten.Add(mov.NumeroComprobante)
        End If
      Next
      If lstNoExisten.Count > 0 Then
        For Each comp In lstNoExisten
          lError += comp + vbNewLine
        Next
        MsgBox("Estos comprobantes no existen la base de datos. Se cancela operacion" & vbNewLine & lError)
      End If
      Dim lstNoDebeCuota As New List(Of String)
      For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        lstPagos = New clsListPagos
        lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante & " and EstadoPago=0"
        lstPagos.RefreshData()
        If lstPagos.Items.Count = 0 Then
          lstNoDebeCuota.Add(mov.NumeroComprobante)
        End If
      Next
      lError = String.Empty
      If lstNoDebeCuota.Count > 0 Then
        For Each comp In lstNoDebeCuota
          lError += comp + vbNewLine
        Next
        MsgBox("Estos comprobantes no Deben cuota. Se cancela operacion" & vbNewLine & lError)
      End If

      For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        lstPagos = New clsListPagos
        lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante
        lstPagos.RefreshData()

        AplicarCuota(1, lstPagos.Items.First.GuidProducto)
      Next


      'For Each mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
      '  lstPagos = New clsListPagos
      '  Dim Pago As New clsInfoPagos
      '  If CInt(mov.NumeroComprobante) = 6251 Then
      '    Dim j = 9

      '  End If
      '  If CInt(mov.NumeroComprobante) = 6165 Then
      '    Dim j = 9

      '  End If



      '  lstPagos.Cfg_Filtro = "where NumComprobante=" & mov.NumeroComprobante & " and EstadoPago=0"
      '  lstPagos.RefreshData()
      '  If lstPagos.Items.Count = 0 Then
      '    MsgBox("No exite el comprobante " & mov.NumeroComprobante)
      '    Continue For
      '  End If
      '  'If lstPagos.Items.Count > 1 Then
      '  '  MsgBox("Existe mas de un producto con el mismo comprobante " & mov.NumeroComprobante)
      '  '  Exit Sub
      '  'End If
      '  Pago = lstPagos.Items.First.Clone

      '  lstProducto = New clsListProductos
      '  lstProducto.Cfg_Filtro = "where GuidProducto={" & Pago.GuidProducto.ToString & "}"
      '  lstProducto.RefreshData()
      '  Dim Producto As New clsInfoProducto
      '  Producto = lstProducto.Items.First.Clone
      '  Pago.EstadoPago = E_EstadoPago.Pago
      '  Pago.FechaPago = GetAhora()

      '  vResult = clsPago.Save(Pago)
      '  If vResult <> Result.OK Then
      '    MsgBox("Fallo guardar pagos")
      '    Exit Sub
      '  End If

      '  Dim auxPago As New clsInfoPagos
      '  If (lstProducto.Items.First.CuotasDebe - 1) > 0 Then
      '    auxPago = GetProximoPago(Pago.GuidProducto, Producto.NumComprobante, Producto.ValorCuotaFija, Pago.NumCuota + 1, Producto.FechaVenta, Pago.VencimientoCuota)
      '  End If
      '  If auxPago IsNot Nothing Then
      '    vResult = clsPago.Save(auxPago)
      '    If vResult <> Result.OK Then
      '      MsgBox("Fallo guardar nuevo pago")
      '      Exit Sub
      '    End If
      '  End If

      'Next

      ' ''collectar la informacion a mostrar antes de aplicar el pago elgido
      ''Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
      ''                                  "Nombre: {0}" & vbNewLine & _
      ''                                  "DNI: {1}" & vbNewLine & _
      ''                                  "Metodo Pago: {2}" & vbNewLine & _
      ''                                  "Numero: {3}" & vbNewLine & _
      ''                                  "Valor Cuota: {4}" & vbNewLine & _
      ''                                   "Fecha: {5}" & vbNewLine & " Desea continuar?.", m_CurrentProducto.NombreCliente, m_CurrentProducto.DNI, m_CurrentProducto.MetodoPago.ToString, m_CurrentProducto.NumPago, m_CurrentProducto.ValorCuota, Today)


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

  Private Sub FillResumenViewVisaCredito(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      m_skip = True
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.CheckBoxes = True
      lstViewResumen.Columns.Add("Aplicar Pago")

      lstViewResumen.Columns.Add("Identificador (DNI)")
      lstViewResumen.Columns.Add("Nombre")
      lstViewResumen.Columns.Add("NumTarjeta")
      lstViewResumen.Columns.Add("Importe")
      lstViewResumen.Columns.Add("Estado")
      lstViewResumen.Columns.Add("Comprobante")
      lstViewResumen.Columns.Add("Ultima Cuota Paga")
      lstViewResumen.Columns.Add("Fecha Ultimo Pago")
      lstViewResumen.Columns.Add("Fecha Pago Actual")
      lstViewResumen.Columns.Add("Detalle")
      lstViewResumen.Columns(0).DisplayIndex = 0 'ListView1.Columns.Count - 1 inidcar la posicion que tendra la columna
      Dim item As ListViewItem
      Dim lstPagos As New List(Of clsInfoPagos)
      Dim Cliente As String = String.Empty
      Dim FechaUltimoPago As Date
      Dim UltimaCuotaPaga As Integer
      Dim Cuotas As Integer
      Dim vResult As libCommon.Comunes.Result
      For Each movimiento In vMovimientos
        item = New ListViewItem()
        lstPagos.Clear()
        Cliente = String.Empty
        UltimaCuotaPaga = 0
        Cuotas = 0
        vResult = GetPagosHistorial(movimiento.NumeroComprobante, lstPagos, Cliente, FechaUltimoPago, UltimaCuotaPaga, Cuotas)

        item.SubItems.Add(CLng(movimiento.IdentificadorDebito).ToString) 'USUALMENTE DNI
        If vResult <> Result.OK Then Cliente = "--"
        item.SubItems.Add(Cliente)
        item.SubItems.Add(movimiento.NumeroTarjeta)
        item.SubItems.Add(String.Format("{0:N2}", CDec(movimiento.Importe / 100)))
        If CInt(movimiento.Codigo) = 0 Then
          movimiento.Estado = E_EstadoPago.Pago
          item.BackColor = Color.LightGreen
          item.Checked = True
        Else
          movimiento.Estado = E_EstadoPago.Debe
          item.Checked = False
          item.BackColor = Color.LightGray
        End If
        item.SubItems.Add(movimiento.Estado.ToString)
        item.SubItems.Add(CInt(movimiento.NumeroComprobante).ToString)
        If vResult = Result.OK Then
          item.SubItems.Add(String.Format("{0}/{1}", UltimaCuotaPaga, Cuotas))
          item.SubItems.Add(FechaUltimoPago.ToString("dd/MM/yyyy"))
        Else
          item.SubItems.Add("--")
          item.SubItems.Add("--")
        End If
        item.SubItems.Add(movimiento.Fecha.Substring(0, 2) + "/" + movimiento.Fecha.Substring(2, 2) + "/" + movimiento.Fecha.Substring(4, 2))
        item.SubItems.Add(movimiento.Detalle)
        If item.BackColor = Color.LightGreen AndAlso vResult <> Result.OK Then
          item.BackColor = Color.LightYellow
          item.Checked = False
        End If
        lstViewResumen.Items.Add(item)

      Next
      lstViewResumen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
      Call LoadInformacion()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Private Function GetPagosHistorial(ByVal numComprobante As Integer, ByRef vlstPagos As List(Of clsInfoPagos), ByRef Nombre As String, ByRef fechaUltimoPago As Date, ByRef UltimaCuotaPaga As Integer, ByRef Cuotas As Integer) As libCommon.Comunes.Result
    Try
      Dim aux As New clsListPagos()
      aux.Cfg_Filtro = "where NumComprobante=" & numComprobante
      aux.RefreshData()
      vlstPagos = New List(Of clsInfoPagos)
      If aux.Items.Count <= 0 Then
        Return Result.NOK
      End If
      vlstPagos.AddRange(aux.Items.ToList)
      Dim auxProducto As New clsInfoProducto
      clsProducto.Load(vlstPagos.First.GuidProducto, auxProducto)
      Dim auxPersona As New ClsInfoPersona
      clsPersona.Load(auxProducto.GuidCliente, auxPersona)
      Nombre = auxPersona.ToString
      Cuotas = auxProducto.TotalCuotas
      For Each pago In vlstPagos.OrderByDescending(Function(c) c.NumCuota)
        If pago.EstadoPago <> E_EstadoPago.Pago Then Continue For
        fechaUltimoPago = pago.FechaPago
        UltimaCuotaPaga = pago.NumCuota
        Exit For
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


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
          FillResumenViewVisaCredito(m_Movimientos)
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

  Private Sub btnReprocesarFile_Click(sender As Object, e As EventArgs) Handles btnReprocesarFile.Click
    Try
      Call frmResumen_Shown(Nothing, Nothing)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub lstViewResumen_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstViewResumen.ItemChecked
    Try
      If m_skip Then Exit Sub
      If e.Item.BackColor = Color.LightGray Then e.Item.Checked = False
      If e.Item.BackColor = Color.LightYellow Then e.Item.Checked = False
      Call LoadInformacion()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub LoadInformacion()
    Try

      Dim rechazados As Integer = 0
      Dim aprobados As Integer = 0
      Dim conflictos As Integer = 0
      Dim PagosAProcesar As Integer = 0
      Dim r As Integer = 0
      For Each item As ListViewItem In lstViewResumen.Items
        If item.BackColor = Color.LightGray Then rechazados += 1
        If item.BackColor = Color.LightGreen Then aprobados += 1
        If item.BackColor = Color.LightYellow Then conflictos += 1
        If item.Checked = True Then PagosAProcesar += 1
      Next
      lblAprobados.Text = aprobados.ToString + " entradas OK"
      lblConflictos.Text = conflictos.ToString + " entradas con conflicos"
      lblRechazados.Text = rechazados.ToString + " entradas rechazadas"
      lblResumen.Text = String.Format("Existen {0} entradas tildadas de {1} disponibles", PagosAProcesar, aprobados)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub lstViewResumen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewResumen.SelectedIndexChanged
    Try
      lblDetalle.Text = ""
      If lstViewResumen.SelectedIndices.Count > 0 Then
        Dim index As Integer = lstViewResumen.SelectedIndices(0)
        Dim row As ListViewItem = lstViewResumen.Items(index)
        If row.BackColor = Color.LightGreen Then Exit Sub
        Dim aux As String = row.SubItems(6).Text
        Dim item As ListViewItem
        Dim lstPagos As New List(Of clsInfoPagos)
        Dim Cliente As String = String.Empty
        Dim FechaUltimoPago As Date
        Dim UltimaCuotaPaga As Integer
        Dim cuotas As Integer
        Dim vResult As libCommon.Comunes.Result
        item = New ListViewItem()
        lstPagos.Clear()
        Cliente = String.Empty
        UltimaCuotaPaga = 0
        vResult = GetPagosHistorial(CInt(aux), lstPagos, Cliente, FechaUltimoPago, UltimaCuotaPaga, cuotas)
        If vResult <> Result.OK AndAlso String.IsNullOrEmpty(Cliente) Then
          lblDetalle.Text = "No existe el cliente en la base de datos"
        End If
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class