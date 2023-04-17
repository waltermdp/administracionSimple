﻿Imports libCommon.Comunes
Imports manDB

Public Class frmExportarHipotecario
  Public m_Result As libCommon.Comunes.Result = Result.CANCEL
  Private m_TipoPago As clsTipoPago

  Private m_Registros As New List(Of clsInfoHipotecario)
  Private m_Banco As New clsHipotecario

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
      dtCurrent.Value = g_Today
      dtVencimiento.Value = Today.AddDays(2)
      txtNumeroConvenio.Text = m_Banco.Convenio
      RecargarValores()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub RecargarValores()
    Try
      Using objForm As New frmProgreso(AddressOf CargarInicio)
        objForm.ShowDialog(Me)
      End Using
      ClsInfoHipotecarioBindingSource.DataSource = m_Registros
      ClsInfoHipotecarioBindingSource.ResetBindings(False)
      lblResumen.Text = String.Format("Total de registros: {0}", m_Registros.Count)
      txtImporteTotal.Text = m_Registros.Sum(Function(c) c.Importe).ToString
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarInicio()
    Try
      m_Registros = New List(Of clsInfoHipotecario)
      GenerateResumen(m_TipoPago, dtVencimiento.Value, m_Registros)

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function GenerateResumen(ByVal vTipoPago As manDB.clsTipoPago, ByVal vFechaVencimiento As Date, ByRef rRegistros As List(Of clsInfoHipotecario)) As Result
    Try

      Dim lstPago As New clsListPagos
      rRegistros = New List(Of clsInfoHipotecario)
      Dim movimiento As clsInfoHipotecario

      lstPago.Cfg_Filtro = "where EstadoPago=" & E_EstadoPago.Debe
      lstPago.RefreshData()


      For Each item In lstPago.Items
        movimiento = New clsInfoHipotecario

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
          .CBU = lstCuenta.Items.First.Codigo1
          .NumeroComprobante = lstProducto.Items.First.NumComprobante
          .Importe = item.ValorCuota
          .IdentificadorDebito = lstCliente.Items.First.NumCliente
          .CodigoBanco = 0
          .FechaVencimiento = vFechaVencimiento
          .CuotaActual = item.NumCuota
          .Nombre = lstCliente.Items.First.ToString

        End With
        rRegistros.Add(movimiento)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  

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

      Dim lineas As New List(Of String)
      If m_Banco.GetExportedFile(m_Registros, lineas, CInt(txtSecuencial.Text)) <> Result.OK Then
        MsgBox("Fallo generar archivo")
        Exit Sub
      End If

      If Save(IO.Path.Combine(EXPORT_PATH, GetAhora.ToString("yyyyMMddhhmmss") & "_CBU.txt"), lineas) <> Result.OK Then
        MsgBox("Fallo guardando archivo")
        Exit Sub
      End If

      MsgBox("La exportacion finalizo correctamente")

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
      RecargarValores()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub




End Class