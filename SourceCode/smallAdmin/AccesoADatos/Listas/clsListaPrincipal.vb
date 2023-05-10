Imports manDB
Imports libCommon.Comunes
Public Class clsListaPrincipal
  Inherits clsList(Of clsInfoPrincipal)



  Private m_str As String
  Private m_NameSort As String
  Private m_Order As String
  Private m_MetodoPago As Guid = Guid.Empty

  Public Sub New()
    Try
      Call Init(10)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Public Property Deben() As String
    Get
      Return m_str
    End Get
    Set(value As String)
      m_str = value
    End Set
  End Property

  Public Property MetodoPago As Guid
    Get
      Return m_MetodoPago
    End Get
    Set(value As Guid)
      m_MetodoPago = value
    End Set
  End Property

  Public Sub SetOrder(ByVal Name As String, Order As String)
    m_NameSort = Name
    m_Order = Order
  End Sub

  Protected Overrides Function RefreshData_Private() As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As libCommon.Comunes.Result = Result.OK

      Try
        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Return objResult

        Dim objInfoPrincipal As New clsInfoPrincipal

        Dim objListProdInfo As clsInfoProducto
        Dim strCommand As String = "Productos" ', (select max(bcospac.fecha) as LastVisitDate from BcosPac where BcosPac.idPac = Pac.idPac) as  LastVisitDate from Pac)"
        Dim objDatos As libDB.clsTabla
        objDatos = New libDB.clsTabla(strCommand)
        objDatos.Filter = m_Cfg_Filtro
        objDatos.Order = m_Cfg_Orden
        Dim auxResult As Integer = objDatos.GetData(objDB)
        Dim auxList As New List(Of clsInfoPrincipal)
        If auxResult > 0 Then

          For Each fila As DataRow In objDatos.Table.Rows

            objInfoPrincipal = New clsInfoPrincipal
            objListProdInfo = New clsInfoProducto
            objResult = clsProducto.ProductoIgualDataRow(objListProdInfo, fila)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.FechaVenta = objListProdInfo.FechaVenta
            objInfoPrincipal.GuidProducto = objListProdInfo.GuidProducto
            objInfoPrincipal.CuotasTotales = objListProdInfo.TotalCuotas
            objInfoPrincipal.Precio = objListProdInfo.Precio
            objInfoPrincipal.Adelanto = objListProdInfo.Adelanto
            objInfoPrincipal.ValorCuotaFija = objListProdInfo.ValorCuotaFija
            objInfoPrincipal.Comprobante = objListProdInfo.NumComprobante.ToString

            Dim objPersona As New ClsInfoPersona
            objResult = clsPersona.Load(objListProdInfo.GuidCliente, objPersona)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.Cliente = objPersona.ToString
            objInfoPrincipal.NumCliente = objPersona.DNI

            Dim objVendedor As New clsInfoVendedor
            objResult = clsVendedor.Load(objListProdInfo.GuidVendedor, objVendedor)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.Vendedor = objVendedor.ToString

            Dim ObjCuenta As New clsInfoCuenta
            objResult = clsCuenta.Load(objListProdInfo.GuidCuenta, ObjCuenta)
            If objResult <> Result.OK Then Return objResult

            If MetodoPago <> Guid.Empty Then
              If MetodoPago <> ObjCuenta.TipoDeCuenta Then Continue For ' no agregar a la lista, next
            End If
            ObjCuenta.SetDelegadoCustomString(New clsInfoCuenta.delToString(AddressOf GetName))
            objInfoPrincipal.MetodoPago = ObjCuenta.ToString

            Dim objPagos As New List(Of clsInfoPagos)
            objResult = clsPago.Load(objPagos, objListProdInfo.GuidProducto)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.CuotasPagas = CuotasPagas(objPagos)

            objInfoPrincipal.ValorCuota = objPagos.Last.ValorCuota
            objInfoPrincipal.FechaUltimoPago = UltimoPago(objPagos)

            Dim objArticulosVendidos As New List(Of clsInfoArticuloVendido)
            clsRelArtProd.Load(objArticulosVendidos, objListProdInfo.GuidProducto)
            objInfoPrincipal.ArticulosVendidos = objArticulosVendidos.Count

            If Deben = "0" Then
              '
            ElseIf Deben = "1" Then
              'Mostrar los productos que deben cuotas
              If objInfoPrincipal.CuotasPagas = objInfoPrincipal.CuotasTotales Then Continue For 'si tiene todo pago
              If DebePeriodoActual(objPagos) = False Then Continue For 'si pago el periodo actual
            ElseIf Deben = "2" Then
              'Mostrar solo los productos ya pagados
              If objInfoPrincipal.CuotasPagas <> objInfoPrincipal.CuotasTotales Then Continue For
            ElseIf Deben = "3" Then
              'Mostrar los productos con la cuota pagada
              If DebePeriodoActual(objPagos) = True Then Continue For 'todos los que ya pagaron este mes
            ElseIf Deben = "4" Then
              Dim consulta As String = ""
              Dim lstEntregados As New clsListRelArtProd
              lstEntregados.Cfg_Filtro = "where guidProducto={" & objInfoPrincipal.GuidProducto.ToString & "} and CantidadArticulos <> Entregados"
              lstEntregados.RefreshData()
              If lstEntregados.Items.Count <= 0 Then Continue For
            End If

            auxList.Add(objInfoPrincipal)
          Next

          'If m_NameSort <> Nothing AndAlso m_Order <> Nothing Then

          '  auxList = auxList.OrderBy(Function(c) c.GetType.GetProperty(m_NameSort).GetValue(c)).ToList()
          '  If m_Order = "ASC" Then auxList.Reverse()
          'End If
          If auxList.Count > 0 Then m_Items.AddRange(auxList.ToList)

        Else
          If auxResult < 0 Then
            MsgBox("Fallo refresh data")
          End If

        End If

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally

        If objDB IsNot Nothing Then

          If objResult <> libCommon.Comunes.Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If

        End If

      End Try

      Return objResult


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function CuotasPagas(ByVal lstPagos As List(Of clsInfoPagos)) As Integer
    Try
      Dim pagadas As Integer = 0
      For Each pago In lstPagos
        If pago.EstadoPago = E_EstadoPago.Pago Then

          pagadas += 1
        End If
      Next
      Return pagadas
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return -1
    End Try
  End Function

  Private Function UltimoPago(ByVal lstPagos As List(Of clsInfoPagos)) As Date
    Try
      Dim pagadas As Integer = 0
      If lstPagos.Count < 0 Then Return Nothing
      If lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago).ToList.Count <= 0 Then Return Nothing

      Dim auxpago As clsInfoPagos = lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago).OrderBy(Function(c) c.NumCuota).ToList.Last

      Return auxpago.FechaPago
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Nothing
    End Try
  End Function



  Private Function GetName(ByVal vGuidTipoCuenta As Guid) As String
    Return GetNameOfTipoPago(vGuidTipoCuenta)
  End Function



End Class
