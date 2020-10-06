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
     
      For Each item As ListViewItem In lstViewResumen.SelectedItems '  mov In m_Movimientos.Where(Function(c) c.Estado = E_EstadoPago.Pago)
        If item.BackColor <> Color.LightGreen Then Continue For
        lstPagos = New clsListPagos
        lstPagos.Cfg_Filtro = "where NumComprobante=" & item.SubItems(6).ToString
        lstPagos.RefreshData()
        AplicarCuota(1, lstPagos.Items.First.GuidProducto)
      Next

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

  Structure S_EntradaCredito
    Public AplicarPago As Boolean
    Public IDCliente As String
    Public Nombre As String
    Public NumTarjeta As String
    Public Importe As String
    Public Estado As String
    Public Comprobante As String
    Public UltimaCuotapaga As String
    Public FechaUltimoPago As String
    Public FechapagoActual As String
    Public Detalle As String
    Public colorFondo As Color
    Public Descripcion As String
  End Structure

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
      Dim objResultado As S_EntradaCredito

      For Each movimiento In vMovimientos
        item = New ListViewItem()
        objResultado = New S_EntradaCredito
        ComprobarEntrada(movimiento, objResultado)
        item.SubItems.Add(objResultado.IDCliente) 'USUALMENTE DNI
        item.SubItems.Add(objResultado.Nombre)
        item.SubItems.Add(objResultado.NumTarjeta)
        item.SubItems.Add(objResultado.Importe)
        item.SubItems.Add(objResultado.Estado)
        item.SubItems.Add(objResultado.Comprobante)
        item.SubItems.Add(objResultado.UltimaCuotapaga)
        item.SubItems.Add(objResultado.FechaUltimoPago)
        item.SubItems.Add(objResultado.FechapagoActual)
        item.SubItems.Add(objResultado.Detalle)
        item.BackColor = objResultado.colorFondo
        item.Checked = objResultado.AplicarPago
        item.Tag = objResultado.Descripcion
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

  Private Function IDExiste(ByVal id As String, ByRef rInfoCliente As ClsInfoPersona) As libCommon.Comunes.Result
    Try
      Dim strFilterUser As String = ""
      Dim lstClientes As New clsListDatabase()
      lstClientes.Cfg_Filtro = "where NumCliente='" & CLng(id).ToString & "'"
      lstClientes.RefreshData()
      If lstClientes.Items.Count <> 1 Then Return Result.NOK
      rInfoCliente = lstClientes.Items(0).Clone

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function ComprobanteExiste(ByVal numComprobante As Integer, ByRef rInfoPago As clsInfoPagos, ByRef fechaUltimoPago As Date, ByRef UltimaCuotaPaga As Integer, ByRef vError As String, ByRef rGuid As Guid) As libCommon.Comunes.Result
    Try
      Dim aux As New clsListPagos()
      rGuid = Guid.Empty
      aux.Cfg_Filtro = "where NumComprobante=" & numComprobante
      aux.RefreshData()
      Dim vlstPagos = New List(Of clsInfoPagos)
      If aux.Items.Count <= 0 Then
        vError = "No existe el comprobante"
        Return Result.NOK
      End If
      'El comprobante existe
      vlstPagos.AddRange(aux.Items.ToList)
      rGuid = vlstPagos.First.GuidProducto
      For Each pago In vlstPagos.OrderByDescending(Function(c) c.NumCuota)
        If pago.EstadoPago <> E_EstadoPago.Pago Then Continue For
        fechaUltimoPago = pago.FechaPago
        UltimaCuotaPaga = pago.NumCuota
        Exit For
      Next


      Dim count As Integer = 0
      For Each pago In vlstPagos
        If pago.EstadoPago = E_EstadoPago.Debe Then count += 1
      Next
      If count = 0 Then
        vError = "No se encontraron cuotas pendientes"
        Return Result.NOK
      End If

      If count > 1 Then
        vError = "Hay dos deudas generadas al mismo producto"
        Return Result.NOK
      End If

      'hay un solo pago pendiente
      rInfoPago = vlstPagos.Find(Function(c) c.EstadoPago = E_EstadoPago.Debe).Clone

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub ComprobarEntrada(ByVal vEntrada As clsInfoMovimiento, ByRef rResultado As S_EntradaCredito)
    Try
      Dim Cliente As New ClsInfoPersona
      Dim ContieneErrores As Boolean = False

      If CInt(vEntrada.Codigo) = 0 Then
        rResultado.Estado = "Pago"
        rResultado.AplicarPago = True
        rResultado.colorFondo = Color.LightGreen
      Else
        rResultado.Estado = "Debe"
        rResultado.AplicarPago = False
        rResultado.colorFondo = Color.LightGray
        rResultado.Descripcion &= "No se realizo el pago" + " "
      End If
      rResultado.Detalle = vEntrada.Detalle

      rResultado.Nombre = "--"
      Dim vResult As libCommon.Comunes.Result = IDExiste(vEntrada.IdentificadorDebito, Cliente)
      If vResult <> Result.OK Then
        ContieneErrores = True
        rResultado.Descripcion &= "No se encuentra el cliente." + " "
      Else
        rResultado.Nombre = Cliente.ToString
      End If
      rResultado.IDCliente = CLng(vEntrada.IdentificadorDebito).ToString
      Dim PagoPendiente As New clsInfoPagos
      Dim auxDate As Date
      Dim auxCuota As Integer
      rResultado.FechaUltimoPago = "--/--/--"
      rResultado.UltimaCuotapaga = "--/--"
      Dim aux As String = String.Empty
      Dim GuidProducto As Guid = Guid.Empty
      vResult = ComprobanteExiste(vEntrada.NumeroComprobante, PagoPendiente, auxDate, auxCuota, aux, GuidProducto)
      If vResult <> Result.OK Then
        ContieneErrores = True
        rResultado.Descripcion &= aux + " "

      Else
        rResultado.FechaUltimoPago = auxDate.ToString("dd/MM/yyyy")
        rResultado.UltimaCuotapaga = auxCuota & "/"
        If CDec(vEntrada.Importe / 100) <> PagoPendiente.ValorCuota Then
          ContieneErrores = True
          rResultado.Descripcion &= "El valor a pagar es distinto." + " "
        End If
      End If

      rResultado.Comprobante = CInt(vEntrada.NumeroComprobante).ToString
      rResultado.Importe = String.Format("{0:N2}", CDec(vEntrada.Importe / 100))

      Dim producto As New clsInfoProducto
      vResult = clsProducto.Load(GuidProducto, producto)
      If vResult <> Result.OK Then
        ContieneErrores = True
        rResultado.Descripcion &= "No se encuentra el producto." + " "
      Else
        rResultado.UltimaCuotapaga &= producto.TotalCuotas
      End If


      Dim lstCuentas As New List(Of clsInfoCuenta)
      vResult = NumTarjetaExiste(vEntrada.NumeroTarjeta, lstCuentas)
      If vResult <> Result.OK Then
        ContieneErrores = True
        rResultado.Descripcion &= "No se encuentra el numero de tarjeta." + " "
      Else
        Dim existe As Boolean = False
        For Each cuenta In lstCuentas
          If cuenta.GuidCliente = Cliente.GuidCliente Then
            existe = True
            Exit For
          End If
        Next
        If existe = False Then
          ContieneErrores = True
          rResultado.Descripcion &= "El pago no coincide con el cliente encontrado." + " "
        End If
      End If
      rResultado.NumTarjeta = vEntrada.NumeroTarjeta

      

      If ContieneErrores Then
        rResultado.colorFondo = Color.LightYellow
        rResultado.AplicarPago = False
      End If

      rResultado.FechapagoActual = vEntrada.Fecha.Substring(0, 2) + "/" + vEntrada.Fecha.Substring(2, 2) + "/" + vEntrada.Fecha.Substring(4, 2)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Function NumTarjetaExiste(ByVal numTarjeta As String, ByRef rCuentas As List(Of clsInfoCuenta)) As libCommon.Comunes.Result
    Try
      Dim cuentas As New clsListaCuentas
      cuentas.Cfg_Filtro = "where Codigo1='" & numTarjeta & "'" ' "where Codigo1=" & numTarjeta

      cuentas.RefreshData()
      If cuentas.Items.Count <= 0 Then
        Return Result.NOK
      End If
      For Each objcuentas In cuentas.Items
        If objcuentas.Codigo1.ToUpper <> numTarjeta.ToUpper Then
          Return Result.NOK
        End If
      Next
      
      rCuentas.Clear()
      For Each cuent In cuentas.Items
        rCuentas.Add(cuent.Clone)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  'Private Function GetPagosHistorial(ByVal numComprobante As Integer, ByRef vlstPagos As List(Of clsInfoPagos), ByRef Nombre As String, ByRef fechaUltimoPago As Date, ByRef UltimaCuotaPaga As Integer, ByRef Cuotas As Integer) As libCommon.Comunes.Result
  '  Try
  '    Dim aux As New clsListPagos()
  '    aux.Cfg_Filtro = "where NumComprobante=" & numComprobante
  '    aux.RefreshData()
  '    vlstPagos = New List(Of clsInfoPagos)
  '    If aux.Items.Count <= 0 Then
  '      Return Result.NOK
  '    End If
  '    'El comprobante existe
  '    vlstPagos.AddRange(aux.Items.ToList)
  '    Dim auxProducto As New clsInfoProducto
  '    clsProducto.Load(vlstPagos.First.GuidProducto, auxProducto)
  '    Dim auxPersona As New ClsInfoPersona
  '    clsPersona.Load(auxProducto.GuidCliente, auxPersona)
  '    Nombre = auxPersona.ToString
  '    Cuotas = auxProducto.TotalCuotas
  '    For Each pago In vlstPagos.OrderByDescending(Function(c) c.NumCuota)
  '      If pago.EstadoPago <> E_EstadoPago.Pago Then Continue For
  '      fechaUltimoPago = pago.FechaPago
  '      UltimaCuotaPaga = pago.NumCuota
  '      Exit For
  '    Next


  '    Dim count As Integer = 0
  '    For Each pago In vlstPagos
  '      If pago.EstadoPago = E_EstadoPago.Debe Then count += 1
  '    Next
  '    If count = 0 Then Return Result.NOK
  '    If count > 1 Then Return Result.NOK
  '    'hay un solo pago pendiente

  '    Return Result.OK
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '    Return Result.ErrorEx
  '  End Try
  'End Function


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
        If item.SubItems(5).Text = "Debe" Then rechazados += 1
        If item.BackColor = Color.LightGreen Then aprobados += 1
        If item.BackColor = Color.LightYellow Then conflictos += 1
        If item.Checked = True Then PagosAProcesar += 1
      Next
      lblAprobados.Text = aprobados.ToString + " entradas OK"
      lblConflictos.Text = conflictos.ToString + " entradas con conflicos"
      lblRechazados.Text = rechazados.ToString + " entradas no pagaron"
      lblResumen.Text = String.Format("Existen {0} entradas tildadas de {1} disponibles", PagosAProcesar, aprobados)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub lstViewResumen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewResumen.SelectedIndexChanged
    Try
      lblDetalle.Text = ""
      btnViewDetail.Visible = False
      If lstViewResumen.SelectedIndices.Count > 0 Then
        Dim index As Integer = lstViewResumen.SelectedIndices(0)
        Dim row As ListViewItem = lstViewResumen.Items(index)
        If row.BackColor = Color.LightGreen Then Exit Sub
        lblDetalle.Text = row.Tag.ToString()
        If row.BackColor = Color.LightYellow Then
          btnViewDetail.Visible = True
        End If
        'Dim aux As String = row.SubItems(6).Text
        'Dim item As ListViewItem
        'Dim lstPagos As New List(Of clsInfoPagos)
        'Dim Cliente As String = String.Empty
        'Dim FechaUltimoPago As Date
        'Dim UltimaCuotaPaga As Integer
        'Dim cuotas As Integer
        'Dim vResult As libCommon.Comunes.Result
        'item = New ListViewItem()
        'lstPagos.Clear()
        'Cliente = String.Empty
        'UltimaCuotaPaga = 0
        'vResult = GetPagosHistorial(CInt(aux), lstPagos, Cliente, FechaUltimoPago, UltimaCuotaPaga, cuotas)
        'If vResult <> Result.OK Then
        '  If String.IsNullOrEmpty(Cliente) Then
        '    lblDetalle.Text = "No existe el cliente en la base de datos"
        '    Exit Sub
        '  End If

        'End If
        'If row.BackColor = Color.LightGray Then
        '  lblDetalle.Text = "No acredito Pago"
        '  Exit Sub
        'End If


        'btnViewDetail.Visible = True
        'lblDetalle.Text = "Ver detalles de los pagos"
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnViewDetail_Click(sender As Object, e As EventArgs) Handles btnViewDetail.Click
    Try
      If lstViewResumen.SelectedIndices.Count > 0 Then
        Dim index As Integer = lstViewResumen.SelectedIndices(0)
        Dim row As ListViewItem = lstViewResumen.Items(index)
        Dim s As String = row.SubItems(1).Text
        Dim entrada As clsInfoMovimiento = m_Movimientos(index)
      
        Dim cliente As New ClsInfoPersona
        Dim vResult As libCommon.Comunes.Result = IDExiste(entrada.IdentificadorDebito, cliente)
        If vResult = Result.OK Then
          Dim objResultado As New S_EntradaCredito
          ComprobarEntrada(entrada, objResultado)
          Using objForm As New frmDetalle(cliente, row.Tag.ToString, objResultado)
            objForm.ShowDialog(Me)
          End Using
        Else
          Exit Sub

        End If



      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class