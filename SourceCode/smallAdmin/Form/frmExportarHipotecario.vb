Imports libCommon.Comunes
Imports manDB

Public Class frmExportarHipotecario
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_Movimientos As New List(Of clsInfoMovimiento)
  Private m_MovimientosSeleccionados As New List(Of clsInfoMovimiento)
  Private m_skip As Boolean
  Private m_TipoPago As clsTipoPago

  Private m_Registros As New List(Of clsInfoHipotecario)

  Public Sub New(ByVal vTipoPago As manDB.clsTipoPago)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_TipoPago = vTipoPago.Clone

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub frmExportarResumen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Using objForm As New frmProgreso(AddressOf CargarInicio)
        objForm.ShowDialog(Me)
      End Using

      ClsInfoHipotecarioBindingSource.DataSource = m_Registros
      ClsInfoHipotecarioBindingSource.ResetBindings(False)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




  Private Sub CargarInicio(ByVal vTipoPago As manDB.clsTipoPago, ByRef rMovimientos As List(Of clsInfoMovimiento))
    Try

      Dim lstPago As New clsListPagos
      rMovimientos = New List(Of clsInfoMovimiento)
      Dim movimiento As New clsInfoMovimiento

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoMovimiento

        Dim lstProducto As New clsListProductos
        lstProducto.Cfg_Filtro = "where GuidProducto={" & item.GuidProducto.ToString & "} and GuidTipoPago = {" & vTipoPago.GuidTipo.ToString & "}"  '"where GuidProducto in (select GuidProducto from Pagos where NumComprobante=" & mov.NumeroComprobante & ")" '" and EstadoPago=" & E_EstadoPago.Debe & ")"
        lstProducto.RefreshData()
        If lstProducto.Items.Count <= 0 Then Continue For


        Dim lstCuenta As New clsListaCuentas
        lstCuenta.Cfg_Filtro = "where GuidCuenta={" & lstProducto.Items.First.GuidCuenta.ToString & "}"
        lstCuenta.RefreshData()

        Dim lstCliente As New clsListDatabase
        lstCliente.Cfg_Filtro = "where GuidCliente={" & lstProducto.Items.First.GuidCliente.ToString & "}"
        lstCliente.RefreshData()


        'auxPrimerPago.Cfg_Filtro = "where (TotalCuotas-CuotasDebe)>=1 and GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
        'auxPrimerPago.RefreshData()
        Dim bCodigoAlta As Boolean
        If item.NumCuota > 1 Then
          bCodigoAlta = False
        Else
          'verificar si es la primer cuota, buscan si la cuenta se uso en algun pago de cuota
          Dim auxPrimerPago As New clsListProductos
          Dim bAlta As Boolean = True
          auxPrimerPago.Cfg_Filtro = "where GuidCuenta={" & lstCuenta.Items.First.GuidCuenta.ToString & "}"
          auxPrimerPago.RefreshData()
          If auxPrimerPago.Items.Count > 1 Then

            For Each producto In auxPrimerPago.Items
              Dim aux As New clsListPagos
              aux.Cfg_Filtro = "where GuidProducto={" & producto.GuidProducto.ToString & "}"
              aux.RefreshData()
              For Each pago In aux.Items
                If pago.EstadoPago = E_EstadoPago.Pago Then
                  bAlta = False
                  Exit For
                End If
              Next
              If bAlta = False Then Exit For
            Next
          End If
          bCodigoAlta = bAlta
        End If

        With movimiento
          .NumeroTarjeta = lstCuenta.Items.First.Codigo1
          .NumeroComprobante = lstProducto.Items.First.NumComprobante
          .Importe = item.ValorCuota
          .IdentificadorDebito = lstCliente.Items.First.NumCliente
          .Fecha = g_Today

          If bCodigoAlta = False Then
            .CodigoDeAlta = "N"
            Dim aux As New clsListPagos
            aux.Cfg_Filtro = "where NumComprobante=" & lstProducto.Items.First.NumComprobante
            aux.RefreshData()
            For Each pago In aux.Items.OrderByDescending(Function(c) c.NumCuota)
              If pago.EstadoPago <> E_EstadoPago.Pago Then Continue For
              .CuotaActual = pago.NumCuota
              .UltimaFechPago = pago.FechaPago.ToString("dd/MM/yy")
              Exit For
            Next

          Else
            .CodigoDeAlta = "E"
          End If
          .Param2 = lstProducto.Items.First.TotalCuotas  'NUMERO TOTAL DE CUOTAS
          .Nombre = lstCliente.Items.First.ToString

        End With
        rMovimientos.Add(movimiento)
      Next
      If rMovimientos.Count < 0 Then
        MsgBox("Nada que exportar")
      End If








      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Sub
  End Sub

  Private Sub LlenarListviewSeguro(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub FillResumenViewVisaCredito(ByVal vMovimientos As List(Of clsInfoMovimiento))
    Try
      m_skip = True
      lstViewResumen.Clear()
      lstViewResumen.MultiSelect = False
      lstViewResumen.FullRowSelect = True
      lstViewResumen.CheckBoxes = True
      lstViewResumen.Columns.Add("Exportar")
      lstViewResumen.Columns.Add("Comprobante")
      lstViewResumen.Columns.Add("Identificador (DNI)")
      lstViewResumen.Columns.Add("Nombre")
      lstViewResumen.Columns.Add("NumTarjeta")
      lstViewResumen.Columns.Add("Importe")
      lstViewResumen.Columns.Add("Codigo Alta")
      lstViewResumen.Columns.Add("Total de Cuotas")
      lstViewResumen.Columns.Add("Ultima Cuota Paga")
      lstViewResumen.Columns.Add("Ultima fecha de pago")

      lstViewResumen.Columns(0).DisplayIndex = 0 'ListView1.Columns.Count - 1 inidcar la posicion que tendra la columna
      Dim item As ListViewItem




      For Each movimiento In vMovimientos.OrderBy(Function(c) c.NumeroComprobante)
        item = New ListViewItem()
        item.SubItems.Add(movimiento.NumeroComprobante)
        item.SubItems.Add(movimiento.IdentificadorDebito) 'USUALMENTE DNI
        'Dim aux As New ClsInfoPersona
        'IDExiste(movimiento.IdentificadorDebito, aux)
        item.SubItems.Add(movimiento.Nombre) 'aux.ToString
        item.SubItems.Add(movimiento.NumeroTarjeta)
        item.SubItems.Add(movimiento.Importe)
        item.SubItems.Add(movimiento.CodigoDeAlta)
        item.SubItems.Add(movimiento.Param2)
        item.SubItems.Add(movimiento.CuotaActual)
        item.SubItems.Add(movimiento.UltimaFechPago)
        item.Checked = True
        item.Tag = movimiento
        lstViewResumen.Items.Add(item)

      Next
      lstViewResumen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
      lblResumen.Text = String.Format("Total de registros: {0}" & vbNewLine & "Seleccionados para procesar: {1}", vMovimientos.Count, vMovimientos.Count)

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

  Private Sub lstViewResumen_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstViewResumen.ItemChecked
    Try
      If m_skip Then Exit Sub
      Dim count As Integer = 0
      lblResumen.Text = String.Format("Total de registros: {0}" & vbNewLine & "Seleccionados para procesar: {1}", lstViewResumen.Items.Count, lstViewResumen.CheckedItems.Count)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_Result = Result.CANCEL
    End Try
  End Sub

  Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    Try
      m_MovimientosSeleccionados.Clear()
      For Each item As ListViewItem In lstViewResumen.Items
        If item.Checked Then
          m_MovimientosSeleccionados.Add(m_Movimientos.Find(Function(c) CInt(c.NumeroComprobante) = CInt(item.SubItems(1).Text)))
        End If
      Next

      clsCobros.Exportar(m_MovimientosSeleccionados, m_TipoPago.GuidTipo)
      m_Result = Result.OK
      Dim msgResult As MsgBoxResult = MsgBox("Desea abrir la carpeta del archivo exportado?", MsgBoxStyle.YesNo)
      If msgResult = MsgBoxResult.Yes Then
        Process.Start(Entorno.EXPORT_PATH)
      End If
      'Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
      m_Result = Result.ErrorEx
    End Try
  End Sub



  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try
      lstViewResumen.Items.Clear()
      FillResumenViewVisaCredito(m_Movimientos)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




End Class