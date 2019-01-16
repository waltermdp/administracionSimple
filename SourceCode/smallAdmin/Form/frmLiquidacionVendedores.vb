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


  Private Structure Liquidacion
    Dim TotalesIntervalos(,,,) As Decimal
    Dim CantidadLibros As Integer
    Dim ImporteTotal As Decimal
    Dim PremioZona As Decimal
    Dim VLiquidadas50 As Decimal
    Dim Auto As Decimal
  End Structure

  Private m_lstResumenVentas As New List(Of clsInfoResumenVenta)
  Private fuente As New Font("Arial", 14)

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
      m_Liq.Auto = 3
      m_Liq.TotalesIntervalos.Initialize()


      For Each item In m_lstResumenVentas

      Next
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
      g.DrawString(m_Vendedor.ToString, fuente, Brushes.Black, 0, 0)
      'espacio

      renglon = 2
      For i As Integer = 0 To 3
        renglon += 1
        g.DrawString("FECHA", fuente, Brushes.Black, 0, RenAltura * renglon)
        g.DrawString("NOMBRE", fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
        g.DrawString("DOCUMENTO", fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
        g.DrawString("CANT LIBROS", fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
        g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
        g.DrawString(Comision(i), fuente, Brushes.Black, Columna * 5, RenAltura * renglon)
        'llenar los campos
        CantidadItems = 0
        SumImporte = 0
        SumComision = 0
        For Each item In m_lstResumenVentas.Where(Function(c) c.Cuotas >= Intervalos(i, 0) AndAlso c.Cuotas <= Intervalos(i, 1)).OrderBy(Function(c) c.Fecha)
          renglon += 1
          g.DrawString(item.Fecha.ToString("dd/MM/yyyy"), fuente, Brushes.Black, 0, RenAltura * renglon)
          g.DrawString(item.Cliente, fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
          g.DrawString(item.DNI, fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
          g.DrawString(item.CantItems, fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
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
        renglon += 1
      Next
      renglon += 1
      renglon += 1
      renglon += 1
      'Comisiones
      g.DrawString("COMISIONES VENTA", fuente, Brushes.Black, 0, RenAltura * renglon)
      renglon += 1
      g.DrawString("VENTAS", fuente, Brushes.Black, 0, RenAltura * renglon)
      g.DrawString("PORCENTAJES", fuente, Brushes.Black, Columna * 1, RenAltura * renglon)
      g.DrawString("CANT. DE LIBROS", fuente, Brushes.Black, Columna * 2, RenAltura * renglon)
      g.DrawString("IMPORTE", fuente, Brushes.Black, Columna * 3, RenAltura * renglon)
      g.DrawString("TOTAL", fuente, Brushes.Black, Columna * 4, RenAltura * renglon)
      renglon += 1

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