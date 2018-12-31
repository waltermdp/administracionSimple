Imports manDB
Imports libCommon.Comunes
Public Class clsListaPrincipal
  Inherits clsList(Of clsInfoPrincipal)

  Public Sub New()
    Try
      Call Init(10)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
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
        Dim auxResult As Result = objDatos.GetData(objDB)
        If auxResult > 0 Then
          For Each fila As DataRow In objDatos.Table.Rows
            objInfoPrincipal = New clsInfoPrincipal
            objListProdInfo = New clsInfoProducto
            objResult = clsProducto.ProductoIgualDataRow(objListProdInfo, fila)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.FechaVenta = objListProdInfo.FechaVenta
            objInfoPrincipal.GuidProducto = objListProdInfo.GuidProducto
            objInfoPrincipal.CuotasTotales = objListProdInfo.TotalCuotas


            Dim objPersona As New ClsInfoPersona
            objResult = clsPersona.Load(objListProdInfo.GuidCliente, objPersona)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.NombreCliente = objPersona.ToString

            Dim objPagos As New List(Of clsInfoPagos)
            objResult = clsPago.Load(objPagos, objListProdInfo.GuidProducto)
            If objResult <> Result.OK Then Return objResult
            objInfoPrincipal.CuotasPagas = CuotasPagas(objPagos)
            objInfoPrincipal.ValorCuota = objPagos.First.ValorCuota
            m_Items.Add(objInfoPrincipal)
          Next

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
        If pago.EstadoPago = 1 Then
          pagadas += 1
        End If
      Next
      Return pagadas
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return -1
    End Try
  End Function

End Class
