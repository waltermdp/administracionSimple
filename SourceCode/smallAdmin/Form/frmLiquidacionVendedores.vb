Imports libCommon.Comunes
Imports manDB
Imports System.Drawing
Public Class frmLiquidacionVendedores
  Private m_Vendedor As clsInfoVendedor
  Private m_objListPagos As clsListPagos
  Private m_objListProductos As clsListProductos
  Private m_FechaInicio As Date
  Private m_FechaFin As Date
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"

  Private pVenta1 As Integer = 22
  Private pVenta2 As Integer = 18
  Private pVenta3 As Integer = 12
  Private pVenta4 As Integer = 9
  Private Zona As Integer = 5
  Private VLiquidadas50 As Integer = 3
  Private VLiquidadas70 As Integer = 4
  Private VLiquidadas90 As Integer = 5
  Private VLiquidadas110 As Integer = 6
  Private PremMen80Vent As Integer = 1
  Private CarpetaDeProb As Integer = 2
  Private Auto As Integer = 4
  Private Vendedores As Integer = 4
  Private Vales As Decimal = 0
  Private Aguinaldo As Integer = 0

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
    Dim Total As Decimal
  End Structure

  Private m_lstResumenVentas As New List(Of clsInfoResumenVenta)
  Private fuente As New Font("Arial", 10)

  Private m_Liq As New Liquidacion


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
      'DateTimePicker1.Format = DateTimePickerFormat.Custom
      'DateTimePicker1.MaxDate = Today
      'DateTimePicker1.CustomFormat = "MMMM YYYYY"
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmLiquidacionVendedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown

  End Sub

  Private Sub btnLiquidar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLiquidar.MouseClick
    Try
      'Buscar los pagos realizados entre el periodo de tiempo
      m_lstResumenVentas = New List(Of clsInfoResumenVenta)

      Call SearchPagos()
      Call ResolverLiquidacion()
      pbxResumen.Size = New Size(pbxResumen.Size.Width, 80 * 20)
      Call pbxResumen.Refresh()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub SearchPagos()
    Try
      If m_objListPagos IsNot Nothing Then m_objListPagos.Dispose()

      m_objListPagos = New clsListPagos
      m_objListPagos.Cfg_Filtro = "where EstadoPago = " & E_EstadoPago.Pago & " and NumCuota=1 and FechaPago between #" & Format(dtInicio.Value, strFormatoAnsiStdFecha) & "# and #" & Format(dtFinal.Value, strFormatoAnsiStdFecha) & "#"
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
        End With
        m_lstResumenVentas.Add(ResumenVenta)
      Next






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
          pVenta = pVenta1
        ElseIf venta.Cuotas >= 5 AndAlso venta.Cuotas <= 8 Then
          pVenta = pVenta2
        ElseIf venta.Cuotas >= 9 AndAlso venta.Cuotas <= 12 Then
          pVenta = pVenta3
        ElseIf venta.Cuotas >= 13 AndAlso venta.Cuotas <= 18 Then
          pVenta = pVenta4
        Else
          MsgBox("Plan de cuotas fuera de lo establecido")
          Exit Sub
        End If
        venta.Comision = (venta.Importe * pVenta / 100)
      Next

      For i As Integer = 0 To 3
        m_Liq.TotalesIntervalos(i)(2) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.CantItems)
        m_Liq.TotalesIntervalos(i)(3) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.Importe)
        m_Liq.TotalesIntervalos(i)(4) = m_lstResumenVentas.Where(Function(c) c.Cuotas >= m_Liq.TotalesIntervalos(i)(0) AndAlso c.Cuotas <= m_Liq.TotalesIntervalos(i)(1)).Sum(Function(c) c.Comision)
        m_Liq.CantidadLibros += m_Liq.TotalesIntervalos(i)(2)
        m_Liq.ImporteTotal += m_Liq.TotalesIntervalos(i)(3)
        m_Liq.ComisionTotal += m_Liq.TotalesIntervalos(i)(4)
      Next

 
      With m_Liq
        .Zona = Zona * .Zona / 100
        .VLiquidadas50 = VLiquidadas50 * .VLiquidadas50 / 100
        .VLiquidadas70 = VLiquidadas70 * .VLiquidadas70 / 100
        .VLiquidadas90 = VLiquidadas90 * .VLiquidadas90 / 100
        .VLiquidadas110 = VLiquidadas110 * .VLiquidadas110 / 100
        .PremMen80Vent = PremMen80Vent * .PremMen80Vent / 100
        .CarpetaDeProb = CarpetaDeProb * .CarpetaDeProb / 100
        .Auto = Auto * .Auto / 100
        .Vendedores = Vendedores * .Vendedores / 100
        .Aguinaldo = Aguinaldo * .Aguinaldo / 100
        .Vales = Vales

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

  Private Sub pbxResumen_Paint(sender As Object, e As PaintEventArgs) Handles pbxResumen.Paint
    Try
      If m_Liq.TotalesIntervalos Is Nothing Then Exit Sub
      e.Graphics.Clear(Color.White)
      Call Preview(e.Graphics)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Preview(ByRef g As Graphics)
    Try
      Dim renglon As Integer = 1
      Dim RenAltura As Integer = 20
      Dim Columna As Integer = 150
      Dim Comision() As String = {"1 A 4 CUOTAS", "5 A 8 CUOTAS", "9 A 12 CUOTAS", "12 A 18 CUOTAS"}
      Dim Intervalos(,) As Integer = {{1, 4}, {5, 8}, {9, 12}, {13, 18}}

      Dim CantidadItems As Integer = 0
      Dim SumImporte As Decimal = 0
      Dim SumComision As Decimal = 0
      Dim sf As New Drawing.StringFormat
      sf.Trimming = StringTrimming.Word

      g.DrawString("LIQUIDACION " & m_Vendedor.ToString, fuente, Brushes.Black, 0, 0)
      g.DrawLine(New Pen(Brushes.Black, 3), New Point(0, RenAltura), New Point(300, RenAltura))

      'espacio

      renglon = 2
      For i As Integer = 0 To 3
        renglon += 1
        g.DrawString("FECHA", fuente, Brushes.Black, 0, RenAltura * renglon)
        g.DrawString("NOMBRE", fuente, Brushes.Black, 100, RenAltura * renglon)
        g.DrawString("DOCUMENTO", fuente, Brushes.Black, 350, RenAltura * renglon)
        g.DrawString("CANT LIBROS", fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
        g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
        g.DrawString(Comision(i), fuente, Brushes.Black, Columna * 5, RenAltura * renglon)
        'llenar los campos
        CantidadItems = 0
        SumImporte = 0
        SumComision = 0
        g.DrawLine(New Pen(Brushes.Black, 3), New Point(0, RenAltura * (renglon + 1)), New Point(Columna * 6, RenAltura * (renglon + 1)))
        For Each item In m_lstResumenVentas.Where(Function(c) c.Cuotas >= Intervalos(i, 0) AndAlso c.Cuotas <= Intervalos(i, 1)).OrderBy(Function(c) c.Fecha)
          renglon += 1
          g.DrawString(item.Fecha.ToString("dd/MM/yyyy"), fuente, Brushes.Black, 0, RenAltura * renglon)
          g.DrawString(item.Cliente, fuente, Brushes.Black, New Rectangle(100, RenAltura * renglon, 250, RenAltura))
          g.DrawString(item.DNI, fuente, Brushes.Black, 350, RenAltura * renglon)
          sf.Alignment = StringAlignment.Center
          g.DrawString(item.CantItems, fuente, Brushes.Black, Columna * 3, RenAltura * renglon, sf)
          g.DrawString(item.Importe, fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
          g.DrawString(item.Comision, fuente, Brushes.Black, Columna * 5, RenAltura * renglon)
          CantidadItems += item.CantItems
          SumImporte += item.Importe
          SumComision += item.Comision
        Next
        renglon += 1
        g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
        g.DrawString(CantidadItems, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
        g.DrawString(SumImporte, fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
        g.DrawString(SumComision, fuente, Brushes.Black, Columna * 5, RenAltura * renglon)
        g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
        renglon += 1
      Next
      renglon += 1
      renglon += 1
      renglon += 1
      'Comisiones
      Dim aux1 As Integer = 250
      g.DrawString("COMISIONES VENTA", fuente, Brushes.Black, 0, RenAltura * renglon)
      renglon += 2
      g.DrawString("TOTAL DE LIBROS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.CantidadLibros, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      renglon += 1
      g.DrawString("TOTAL VENDIDO", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.ImporteTotal, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      renglon += 1
      g.DrawString("VENTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString("PORCENTAJES", fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString("CANT. DE LIBROS", fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      'g.DrawString("TOTAL", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
      renglon += 1
      g.DrawString(Comision(0), fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(pVenta1, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(0)(3), fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(0)(4), fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString(Comision(1), fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(pVenta2, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(1)(3), fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(1)(4), fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString(Comision(2), fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(pVenta3, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(2)(3), fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(2)(4), fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString(Comision(3), fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(pVenta4, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(3)(3), fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString(m_Liq.TotalesIntervalos(3)(4), fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1

      g.DrawString("ZONA", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(Zona, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.Zona, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("V. LIQUIDADAS 50", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(VLiquidadas50, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.VLiquidadas50, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("V. LIQUIDADAS 70", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(VLiquidadas70, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.VLiquidadas70, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("V. LIQUIDADAS 90", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(VLiquidadas90, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.VLiquidadas90, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("V. LIQUIDADAS 110", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(VLiquidadas110, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.VLiquidadas110, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("PREMIO MENSUAL 80 VTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(PremMen80Vent, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.PremMen80Vent, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("CARPETA DE PROBLEMAS + DE 5", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(CarpetaDeProb, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.CarpetaDeProb, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("AUTO", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(Auto, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.Auto, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("VENDEDORES", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(Vendedores, fuente, Brushes.Black, aux1, RenAltura * renglon)
      g.DrawString(m_Liq.Vendedores, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("PARCIAL", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.Total, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
      g.DrawString("VALES", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.Vales, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawString("TOTAL", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.Total, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      renglon += 1
      g.DrawLine(New Pen(Brushes.Black, 3), New Point(0, RenAltura * (renglon)), New Point(Columna * 6, RenAltura * (renglon)))
      g.DrawString("AGUINALDO", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString(m_Liq.Aguinaldo, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)

      renglon += 4
      g.DrawString("FIRMA", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))
      renglon += 2
      g.DrawString("ACLARACION", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawLine(New Pen(Brushes.Black, 1), New Point(0, RenAltura * (renglon)), New Point(500, RenAltura * (renglon)))

      'g.DrawString(Comision(0), fuente, Brushes.Black, 0, RenAltura * renglon)

      'g.DrawString(Comision(1), fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      'g.DrawString(Comision(2), fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      'g.DrawString("CANT LIBROS", fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      'g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
      'g.DrawString(Comision(i), fuente, Brushes.Black, Columna * 5, RenAltura * renglon)


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class