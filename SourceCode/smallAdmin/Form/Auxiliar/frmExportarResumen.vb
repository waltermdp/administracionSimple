Imports libCommon.Comunes
Imports manDB

Public Class frmExportarResumen
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_Movimientos As New List(Of clsInfoMovimiento)
  Private m_MovimientosSeleccionados As New List(Of clsInfoMovimiento)
  Private m_skip As Boolean
  Private m_TipoPago As clsTipoPago

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
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarInicio()
    Try
      clsCobros.GenerateResumen(m_TipoPago, m_Movimientos)
      Select Case m_TipoPago.GuidTipo
        Case Guid.Parse("9ebcf274-f84f-42ac-b3de-d375bb3bd314") 'efectivo
          FillResumenViewVisaCredito(m_Movimientos)
        Case Guid.Parse("d167e036-b175-4a67-9305-a47c116e8f5c") 'visa debito 
          FillResumenViewVisaCredito(m_Movimientos)
        Case Guid.Parse("c3daf694-fdef-4e67-b02b-b7b3a9117924") 'CBU
          FillResumenViewVisaCredito(m_Movimientos)
        Case Guid.Parse("7580f2d4-d9ec-477b-9e3a-50afb7141ab5") 'visa credito
          lstViewResumen.Invoke(Sub() FillResumenViewVisaCredito(m_Movimientos)) ' FillResumenViewVisaCredito(m_Movimientos)
        Case Guid.Parse("ea5d6084-90c3-4b66-82b2-9c4816c07523") 'master debito
          FillResumenViewVisaCredito(m_Movimientos)
        Case Guid.Parse("598878be-b8b3-4b1b-9261-f989f0800afc") 'Mercado Pago
          FillResumenViewVisaCredito(m_Movimientos)
        Case Else
          MsgBox("No se encuentra tipo de pago")
      End Select
      'FillResumenViewVisaCredito(m_Movimientos)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
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