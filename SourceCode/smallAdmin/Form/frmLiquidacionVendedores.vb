Imports libCommon.Comunes
Imports manDB
Public Class frmLiquidacionVendedores
  Private m_Vendedor As clsInfoVendedor
  Private m_objListPagos As clsListPagos
  Private m_objListProductos As clsListProductos
  Private m_FechaInicio As Date
  Private m_FechaFin As Date
  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"


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
      Call SearchPagos()

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

      Next


      Dim k As Integer = 0
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
End Class