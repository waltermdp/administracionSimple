﻿Imports libCommon.Comunes
Imports manDB
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D

Public Class frmLiquidacionVendedores
  Private m_Vendedor As clsInfoVendedor
  Private m_objListPagos As clsListPagos
  Private m_objListProductos As clsListProductos
  Private m_FechaInicio As Date
  Private m_FechaFin As Date
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"

  'Private pVenta1 As Integer = 22
  'Private pVenta2 As Integer = 18
  'Private pVenta3 As Integer = 12
  'Private pVenta4 As Integer = 9
  Private m_porcentajeVentaPorCuota() As Decimal
  Private Zona As Integer = 5
  Private VLiquidadas50 As Integer = 3
  Private VLiquidadas70 As Integer = 4
  Private VLiquidadas90 As Integer = 5
  Private VLiquidadas110 As Integer = 6
  Private PremMen80Vent As Integer = 1
  Private CarpetaDeProb As Integer = 2
  Private Auto As Integer = 2
  Private Vendedores As Integer = 4
  Private Vales As Decimal = 0
  Private Aguinaldo As Integer = 1
  Private ImporteParcial As Decimal

  Private Structure Liquidacion
    Dim TotalesIntervalos()() As Decimal
    Dim CantidadLibros As Integer
    Dim ImporteTotal As Decimal
    Dim ComisionTotal As Decimal
    Dim Zona As Decimal
    Dim VLiquidadas50 As Decimal
    Dim VLiquidadas70 As Decimal
    Dim VLiquidadas90 As Decimal
    Dim VLiquidadas110 As Decimal
    Dim PremMen80Vent As Decimal
    Dim CarpetaDeProb As Decimal
    Dim Auto As Decimal
    Dim Vendedores As Decimal
    Dim Vales As Decimal
    Dim Aguinaldo As Decimal
    Dim PorcentajeFijoPorVenta As Decimal
    Dim Total As Decimal
  End Structure

  Private m_lstResumenVentas As New List(Of clsInfoResumenVenta)
  Private fuente As New Font("Arial", 10)
  Private m_fuenteBold As New Font("Curier new", 10, FontStyle.Bold)

  Private m_Liq As New Liquidacion
  Private WithEvents m_PrintDoc As New PrintDocument
  Private m_CantidadRenglones As Integer = 0
  Private TotalPaginas As Integer = 0
  Private Const MAX_RENGLONES As Integer = 70

  Public Sub New(ByVal vVendedor As manDB.clsInfoVendedor)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      If vVendedor Is Nothing Then
        m_Vendedor = Nothing
        Exit Sub
      End If
      m_Vendedor = vVendedor.Clone
      m_Liq = Nothing
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmLiquidacionVendedores_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      'dtFrom.Format = DateTimePickerFormat.Custom
      'dtTo.Format = DateTimePickerFormat.Custom
      'dtInicio.CustomFormat = "MMMM, yyyy"
      dtFrom.Value = New Date(g_Today.Year, g_Today.Month, 1)
      dtTo.Value = New Date(g_Today.Year, g_Today.Month, Date.DaysInMonth(g_Today.Year, g_Today.Month))
      dtTo.MinDate = dtFrom.Value
      dtFrom.MaxDate = dtTo.Value

      m_porcentajeVentaPorCuota = {10, 10, 10, 10}

      chk110.Enabled = False
      chk50.Enabled = False
      chk70.Enabled = False
      chk90.Enabled = False
      chkCarpetaProb.Enabled = False
      chkPremio80Vent.Enabled = False
      chkVendedores.Enabled = False
      chkZona.Enabled = False

      chk110.Visible = False
      chk50.Visible = False
      chk70.Visible = False
      chk90.Visible = False
      chkCarpetaProb.Visible = False
      chkPremio80Vent.Visible = False
      chkVendedores.Visible = False
      chkZona.Visible = False

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmLiquidacionVendedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      lblTitulo.Text = "VENDEDOR: " & m_Vendedor.ToString
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnLiquidar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLiquidar.MouseClick
    Try

      'Buscar los pagos realizados entre el periodo de tiempo
      m_lstResumenVentas = New List(Of clsInfoResumenVenta)

      Call SearchPagos()
      Call SearchAdelantos()

      Call ResolverLiquidacion()
      chkEnable.Size = New Size(chkEnable.Size.Width, 80 * 20)
      Call chkEnable.Refresh()
      chkEnable.Height = m_CantidadRenglones * 20
      Call chkEnable.Refresh()
      btnImprimir.Visible = True

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub SearchPagos()
    Try
      If m_objListPagos IsNot Nothing Then m_objListPagos.Dispose()


      m_FechaFin = New Date(dtTo.Value.Year, dtTo.Value.Month, dtTo.Value.Day)
      m_FechaInicio = New Date(dtFrom.Value.Year, dtFrom.Value.Month, dtFrom.Value.Day)

      m_objListPagos = New clsListPagos
      m_objListPagos.Cfg_Filtro = "where EstadoPago = " & E_EstadoPago.Pago & " and NumCuota=1 and FechaPago between #" & Format(m_FechaInicio, strFormatoAnsiStdFecha) & "# and #" & Format(m_FechaFin, strFormatoAnsiStdFecha) & "#"
      m_objListPagos.RefreshData()

      If m_objListProductos IsNot Nothing Then m_objListProductos.Dispose()
      m_objListProductos = New clsListProductos

      m_objListProductos.Cfg_Filtro = "where GuidVendedor ={" & m_Vendedor.GuidVendedor.ToString & "} and GuidProducto in (select GuidProducto from Pagos " & m_objListPagos.Cfg_Filtro & ")"  'strFilter
      m_objListProductos.RefreshData()

      Dim objCliente As New ClsInfoPersona


      Dim ResumenVenta As clsInfoResumenVenta
      For Each producto In m_objListProductos.Items
        ResumenVenta = New clsInfoResumenVenta
        objCliente = New ClsInfoPersona
        clsPersona.Load(producto.GuidCliente, objCliente)

        clsRelArtProd.Load(producto.ListaArticulos, producto.GuidProducto)

        With ResumenVenta
          .Fecha = producto.FechaVenta
          .Cliente = objCliente.ToString
          .DNI = objCliente.DNI
          .CantItems = producto.ListaArticulos.Count
          .Importe = producto.Precio
          .Cuotas = producto.TotalCuotas
          .IDContrato = producto.NumComprobante

        End With
        m_lstResumenVentas.Add(ResumenVenta)
      Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub SearchAdelantos()
    Try

      If m_objListPagos IsNot Nothing Then m_objListPagos.Dispose()

      m_FechaFin = New Date(dtTo.Value.Year, dtTo.Value.Month, dtTo.Value.Day)
      m_FechaInicio = New Date(dtFrom.Value.Year, dtFrom.Value.Month, dtFrom.Value.Day)

      Dim Adelantos As New clsListAdelantos
      Adelantos.Cfg_Filtro = "where GuidVendedor={" & m_Vendedor.GuidVendedor.ToString & "} and Fecha between #" & Format(m_FechaInicio, strFormatoAnsiStdFecha) & "# and #" & Format(m_FechaFin, strFormatoAnsiStdFecha) & "#"
      Adelantos.RefreshData()
      Dim valor As Decimal = 0
      For Each adelanto In Adelantos.Items
        valor += adelanto.Valor
      Next
      lblAdelantos.Text = "Adelantos: " & valor.ToString
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ResolverLiquidacion()
    Try
      m_Liq = New Liquidacion
      m_Liq.TotalesIntervalos = New Decimal(4)() {}
      m_Liq.TotalesIntervalos(0) = New Decimal() {1, 4, 0, 0, 0}
      m_Liq.TotalesIntervalos(1) = New Decimal() {5, 8, 0, 0, 0}
      m_Liq.TotalesIntervalos(2) = New Decimal() {9, 12, 0, 0, 0}
      m_Liq.TotalesIntervalos(3) = New Decimal() {13, 18, 0, 0, 0}
      'm_lstResumenVentas.Where(Function(c) c.Cuotas >= Intervalos(i, 0) AndAlso c.Cuotas <= Intervalos(i, 1)).OrderBy(Function(c) c.Fecha)

      Dim pVenta As Single
      For Each venta In m_lstResumenVentas
        If venta.Cuotas >= 1 AndAlso venta.Cuotas <= 4 Then
          pVenta = m_porcentajeVentaPorCuota(0) '  pVenta1
        ElseIf venta.Cuotas >= 5 AndAlso venta.Cuotas <= 8 Then
          pVenta = m_porcentajeVentaPorCuota(1) 'pVenta2
        ElseIf venta.Cuotas >= 9 AndAlso venta.Cuotas <= 12 Then
          pVenta = m_porcentajeVentaPorCuota(2) 'pVenta3
        ElseIf venta.Cuotas >= 13 AndAlso venta.Cuotas <= 18 Then
          pVenta = m_porcentajeVentaPorCuota(3) 'pVenta4
        Else
          MsgBox("Plan de cuotas fuera de lo establecido")
          Exit Sub
        End If
        venta.Comision = CDec(venta.Importe * pVenta / 100)
        'Aplicar aca si es % por cada producto vendido
      Next

      For i As Integer = 0 To 3
        m_Liq.TotalesIntervalos(i)(2) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.CantItems)
        m_Liq.TotalesIntervalos(i)(3) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.Importe)
        m_Liq.TotalesIntervalos(i)(4) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.Comision)
        m_Liq.CantidadLibros += CInt(m_Liq.TotalesIntervalos(i)(2))
        m_Liq.ImporteTotal += m_Liq.TotalesIntervalos(i)(3)
        m_Liq.ComisionTotal += m_Liq.TotalesIntervalos(i)(4)
      Next

      Dim esCorrecto As Boolean = Decimal.TryParse(txtVale.Text, Vales)
      If Not esCorrecto Then Vales = 0
      'Dim auxString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", rValor)
      Vales = CDec(FormatNumber(Vales, 2))

      With m_Liq
        If chkZona.Checked Then .Zona = Zona * m_Liq.ImporteTotal / 100
        If chk50.Checked Then .VLiquidadas50 = VLiquidadas50 * m_Liq.ImporteTotal / 100
        If chk70.Checked Then .VLiquidadas70 = VLiquidadas70 * m_Liq.ImporteTotal / 100
        If chk90.Checked Then .VLiquidadas90 = VLiquidadas90 * m_Liq.ImporteTotal / 100
        If chk110.Checked Then .VLiquidadas110 = VLiquidadas110 * m_Liq.ImporteTotal / 100
        If chkPremio80Vent.Checked Then .PremMen80Vent = PremMen80Vent * m_Liq.ImporteTotal / 100
        If chkCarpetaProb.Checked Then .CarpetaDeProb = CarpetaDeProb * m_Liq.ImporteTotal / 100
        If chkAuto.Checked Then .Auto = Auto * m_Liq.ImporteTotal / 100
        If chkVendedores.Checked Then .Vendedores = Vendedores * m_Liq.ImporteTotal / 100
        If chkAguinaldo.Checked Then .Aguinaldo = Aguinaldo * m_Liq.ImporteTotal / 100
        'Aplicar aca si es % sobre el importe total

        If chkEnablePorcentaje1.Checked Then
          .PorcentajeFijoPorVenta = CDec(m_Liq.ImporteTotal * nPorcentaje1.Value / 100)
        End If
        .Vales = Vales
        ImporteParcial = .ComisionTotal + .VLiquidadas50 + .VLiquidadas70 + .VLiquidadas90 + .VLiquidadas110 + .Zona + .PremMen80Vent + .CarpetaDeProb + .Auto + .Vendedores + .PorcentajeFijoPorVenta
        .Total = ImporteParcial - .Vales
      End With





    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnVolver_MouseClick(sender As Object, e As MouseEventArgs) Handles btnVolver.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub pbxResumen_Paint(sender As Object, e As PaintEventArgs) Handles chkEnable.Paint
    Try
      If m_Liq.TotalesIntervalos Is Nothing Then Exit Sub
      e.Graphics.Clear(Color.White)

      Call Preview(e.Graphics)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub m_PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles m_PrintDoc.PrintPage
    Try
      If m_Liq.TotalesIntervalos Is Nothing Then Exit Sub


      If TotalPaginas <= 0 Then
        e.HasMorePages = False
        Exit Sub
      End If

      Dim c0 As GraphicsContainer = e.Graphics.BeginContainer
      e.Graphics.ScaleTransform(0.8, 0.8)

      e.Graphics.TranslateTransform(40, CSng(-20 * MAX_RENGLONES * (Math.Ceiling(m_CantidadRenglones / MAX_RENGLONES) - TotalPaginas))) 'desplazar n renglones con cada hoja extra
      e.Graphics.Clip = New Region(New Rectangle(0, CInt(20 * MAX_RENGLONES * (Math.Ceiling(m_CantidadRenglones / MAX_RENGLONES) - TotalPaginas)), chkEnable.Width, 20 * MAX_RENGLONES))
      e.Graphics.Clear(Color.White)

      Call Preview(e.Graphics)
      e.Graphics.EndContainer(c0)

      TotalPaginas -= 1
      e.HasMorePages = TotalPaginas > 0





    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub Preview(ByRef g As Graphics)
    Try
      Dim renglon As Integer = 1
      Dim RenAltura As Integer = 20
      Dim Columna As Integer = 150
      'Dim Comision() As String = {"1 A 4 CUOTAS", "5 A 8 CUOTAS", "9 A 12 CUOTAS", "12 A 18 CUOTAS"}
      Dim Intervalos(,) As Integer = {{1, 4}, {5, 8}, {9, 12}, {13, 18}}

      Dim CantidadItems As Integer = 0
      Dim SumImporte As Decimal = 0
      Dim SumComision As Decimal = 0
      Dim sf As New Drawing.StringFormat
      sf.Trimming = StringTrimming.Word

      g.DrawString("LIQUIDACION Desde " & dtFrom.Value.ToString("yyyy/MM/dd").ToUpper & " Hasta " & dtTo.Value.ToString("yyyy/MM/dd").ToUpper & ": " & m_Vendedor.ToString, m_fuenteBold, Brushes.Black, 0, 0)
      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura), New Point(500, RenAltura))

      'espacio

      renglon = 2


      renglon += 1
      g.DrawString("VENTAS", m_fuenteBold, Brushes.Black, 0, RenAltura * renglon)
      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon + 1)), New Point(200, RenAltura * (renglon + 1)))
      renglon += 1
      g.DrawString("FECHA", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString("NOMBRE", fuente, Brushes.Black, 100, RenAltura * renglon)
      g.DrawString("DOCUMENTO", fuente, Brushes.Black, 450, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString("CANT ITEMS", fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString(String.Format("COMISION {0}%", m_porcentajeVentaPorCuota(0)), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))

      'llenar los campos
      CantidadItems = 0
      SumImporte = 0
      SumComision = 0
      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon + 1)), New Point(Columna * 6, RenAltura * (renglon + 1)))
      For Each item In m_lstResumenVentas.OrderBy(Function(c) c.Fecha)
        renglon += 1
        g.DrawString(item.Fecha.ToString("dd/MM/yyyy"), fuente, Brushes.Black, 0, RenAltura * renglon)
        g.DrawString(item.Cliente, fuente, Brushes.Black, New Rectangle(100, RenAltura * renglon, 250, RenAltura))
        g.DrawString(item.DNI, fuente, Brushes.Black, 450, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
        sf.Alignment = StringAlignment.Center
        g.DrawString(item.CantItems.ToString, fuente, Brushes.Black, Columna * 4, RenAltura * renglon, sf)
        g.DrawString(String.Format(g_Cultura, "{0:C}", item.Importe), fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
        g.DrawString(String.Format(g_Cultura, "{0:C}", item.Comision), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
        CantidadItems += item.CantItems
        SumImporte += item.Importe
        SumComision += item.Comision
      Next
      renglon += 1
      g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(CantidadItems.ToString, fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
      g.DrawString(String.Format(g_Cultura, "{0:C}", SumImporte), fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString(String.Format(g_Cultura, "{0:C}", SumComision), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
      renglon += 1


      renglon += 1
      renglon += 1
      renglon += 1
      'Comisiones
      Dim aux1 As Integer = 250
      g.DrawString("COMISIONES VENTA", fuente, Brushes.Black, 0, RenAltura * renglon)
      renglon += 2
      g.DrawString("TOTAL DE ITEMS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.CantidadLibros.ToString, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      renglon += 1
      g.DrawString("TOTAL VENDIDO", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      renglon += 2
      g.DrawString("VENTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString("%", fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString("REFERENCIA", fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      'g.DrawString("TOTAL", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
      renglon += 1
      sf = New StringFormat(StringFormatFlags.DirectionRightToLeft)
      sf.Alignment = StringAlignment.Center
      g.DrawString("VENTA", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_porcentajeVentaPorCuota(0) & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.ComisionTotal), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      renglon += 1
      

      g.DrawString("FIJO", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(String.Format("{0}%", nPorcentaje1.Value), fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.PorcentajeFijoPorVenta), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      renglon += 1
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
      g.DrawString("PARCIAL", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(String.Format(g_Cultura, "{0:C}", ImporteParcial), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      renglon += 1
      renglon += 1
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
      g.DrawString("VALES", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Vales), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      renglon += 1
      renglon += 1

      g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Total), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      renglon += 1
      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon - 1)), New Point(Columna * 6, RenAltura * (renglon - 1)))
      'g.DrawString("AGUINALDO", fuente, Brushes.Black, 0, RenAltura * renglon)
      'g.DrawString(Aguinaldo & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
      'g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.ImporteTotal), fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
      'g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Aguinaldo), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))

      renglon += 4
      g.DrawString("FIRMA", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))
      renglon += 2
      g.DrawString("ACLARACION", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))


      m_CantidadRenglones = renglon

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Private Sub Preview(ByRef g As Graphics)
  '  Try
  '    Dim renglon As Integer = 1
  '    Dim RenAltura As Integer = 20
  '    Dim Columna As Integer = 150
  '    Dim Comision() As String = {"1 A 4 CUOTAS", "5 A 8 CUOTAS", "9 A 12 CUOTAS", "12 A 18 CUOTAS"}
  '    Dim Intervalos(,) As Integer = {{1, 4}, {5, 8}, {9, 12}, {13, 18}}

  '    Dim CantidadItems As Integer = 0
  '    Dim SumImporte As Decimal = 0
  '    Dim SumComision As Decimal = 0
  '    Dim sf As New Drawing.StringFormat
  '    sf.Trimming = StringTrimming.Word

  '    g.DrawString("LIQUIDACION Desde " & dtFrom.Value.ToString("yyyy/MM/dd").ToUpper & " Hasta " & dtTo.Value.ToString("yyyy/MM/dd").ToUpper & ": " & m_Vendedor.ToString, m_fuenteBold, Brushes.Black, 0, 0)
  '    g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura), New Point(500, RenAltura))

  '    'espacio

  '    renglon = 2

  '    For i As Integer = 0 To 3
  '      renglon += 1
  '      g.DrawString(Comision(i), m_fuenteBold, Brushes.Black, 0, RenAltura * renglon)
  '      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon + 1)), New Point(200, RenAltura * (renglon + 1)))
  '      renglon += 1
  '      g.DrawString("FECHA", fuente, Brushes.Black, 0, RenAltura * renglon)
  '      g.DrawString("NOMBRE", fuente, Brushes.Black, 100, RenAltura * renglon)
  '      g.DrawString("DOCUMENTO", fuente, Brushes.Black, 450, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '      g.DrawString("CANT ITEMS", fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '      g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '      g.DrawString(String.Format("COMISION {0}%", m_porcentajeVentaPorCuota(i)), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))

  '      'llenar los campos
  '      CantidadItems = 0
  '      SumImporte = 0
  '      SumComision = 0
  '      g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon + 1)), New Point(Columna * 6, RenAltura * (renglon + 1)))
  '      For Each item In m_lstResumenVentas.Where(Function(c) c.Cuotas >= Intervalos(i, 0) AndAlso c.Cuotas <= Intervalos(i, 1)).OrderBy(Function(c) c.Fecha)
  '        renglon += 1
  '        g.DrawString(item.Fecha.ToString("dd/MM/yyyy"), fuente, Brushes.Black, 0, RenAltura * renglon)
  '        g.DrawString(item.Cliente, fuente, Brushes.Black, New Rectangle(100, RenAltura * renglon, 250, RenAltura))
  '        g.DrawString(item.DNI, fuente, Brushes.Black, 450, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '        sf.Alignment = StringAlignment.Center
  '        g.DrawString(item.CantItems.ToString, fuente, Brushes.Black, Columna * 4, RenAltura * renglon, sf)
  '        g.DrawString(String.Format(g_Cultura, "{0:C}", item.Importe), fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '        g.DrawString(String.Format(g_Cultura, "{0:C}", item.Comision), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '        CantidadItems += item.CantItems
  '        SumImporte += item.Importe
  '        SumComision += item.Comision
  '      Next
  '      renglon += 1
  '      g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
  '      g.DrawString(CantidadItems.ToString, fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
  '      g.DrawString(String.Format(g_Cultura, "{0:C}", SumImporte), fuente, Brushes.Black, Columna * 5, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '      g.DrawString(String.Format(g_Cultura, "{0:C}", SumComision), fuente, Brushes.Black, Columna * 6, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
  '      renglon += 1
  '    Next
  '    renglon += 1
  '    renglon += 1
  '    renglon += 1
  '    'Comisiones
  '    Dim aux1 As Integer = 250
  '    g.DrawString("COMISIONES VENTA", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    renglon += 2
  '    g.DrawString("TOTAL DE ITEMS", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_Liq.CantidadLibros.ToString, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
  '    renglon += 1
  '    g.DrawString("TOTAL VENDIDO", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
  '    renglon += 2
  '    g.DrawString("VENTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString("%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString("REFERENCIA", fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    'g.DrawString("TOTAL", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
  '    renglon += 1
  '    sf = New StringFormat(StringFormatFlags.DirectionRightToLeft)
  '    sf.Alignment = StringAlignment.Center
  '    g.DrawString(Comision(0), fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_porcentajeVentaPorCuota(0) & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.TotalesIntervalos(0)(3).ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.TotalesIntervalos(0)(4)), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString(Comision(1), fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_porcentajeVentaPorCuota(1) & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.TotalesIntervalos(1)(3).ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.TotalesIntervalos(1)(4)), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString(Comision(2), fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_porcentajeVentaPorCuota(2) & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.TotalesIntervalos(2)(3).ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.TotalesIntervalos(2)(4)), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString(Comision(3), fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(m_porcentajeVentaPorCuota(3) & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.TotalesIntervalos(3)(3).ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.TotalesIntervalos(3)(4)), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1

  '    g.DrawString("ZONA", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(Zona & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Zona), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("V. LIQUIDADAS 50", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(VLiquidadas50 & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.VLiquidadas50), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("V. LIQUIDADAS 70", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(VLiquidadas70 & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.VLiquidadas70), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("V. LIQUIDADAS 90", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(VLiquidadas90 & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.VLiquidadas90), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("V. LIQUIDADAS 110", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(VLiquidadas110 & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.VLiquidadas110), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("PREMIO MENSUAL 80 VTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(PremMen80Vent & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.PremMen80Vent), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("CARPETA DE PROBLEMAS + DE 5", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(CarpetaDeProb & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.CarpetaDeProb), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("AUTO", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(Auto & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Auto), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("VENDEDORES", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(Vendedores & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Vendedores), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawString("FIJO", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(String.Format("{0}%", nPorcentaje1.Value), fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    g.DrawString(m_Liq.ImporteTotal.ToString, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.PorcentajeFijoPorVenta), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
  '    g.DrawString("PARCIAL", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", ImporteParcial), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    renglon += 1
  '    g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
  '    g.DrawString("VALES", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Vales), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    renglon += 1

  '    g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Total), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    renglon += 1
  '    g.DrawLine(New Pen(Brushes.Black, 2), New Point(0, RenAltura * (renglon - 1)), New Point(Columna * 6, RenAltura * (renglon - 1)))
  '    'g.DrawString("AGUINALDO", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    'g.DrawString(Aguinaldo & "%", fuente, Brushes.Black, aux1, RenAltura * renglon)
  '    'g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.ImporteTotal), fuente, Brushes.Black, Columna * 3, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))
  '    'g.DrawString(String.Format(g_Cultura, "{0:C}", m_Liq.Aguinaldo), fuente, Brushes.Black, Columna * 4, RenAltura * renglon, New StringFormat(StringFormatFlags.DirectionRightToLeft))

  '    renglon += 4
  '    g.DrawString("FIRMA", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))
  '    renglon += 2
  '    g.DrawString("ACLARACION", fuente, Brushes.Black, 0, RenAltura * renglon)
  '    g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))


  '    m_CantidadRenglones = renglon

  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub btnImprimir_MouseClick(sender As Object, e As MouseEventArgs) Handles btnImprimir.MouseClick
    Try
      Dim obj As New PrintDialog
      If obj.ShowDialog = Windows.Forms.DialogResult.OK Then

        m_PrintDoc.PrinterSettings = obj.PrinterSettings
       
        TotalPaginas = CInt(Math.Ceiling(m_CantidadRenglones / MAX_RENGLONES))

        m_PrintDoc.Print()
      End If
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dtTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTo.ValueChanged
    Try

      dtFrom.MaxDate = dtTo.Value
      dtTo.Refresh()
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dtFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged
    Try
      dtTo.MinDate = dtFrom.Value
      dtFrom.Refresh()
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub
End Class