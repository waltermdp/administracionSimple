﻿Imports manDB
Imports libCommon.Comunes
Public Class clsListaCuentas
  Inherits clsList(Of clsInfoCuenta)

  Public Sub New()
    Try
      Call Init(10)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Protected Overrides Function RefreshData_Private() As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As libCommon.Comunes.Result = Result.OK

      Try
        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Return objResult

        Dim objListCuentaInfo As clsInfoCuenta
        Dim strCommand As String = "Cuentas" ', (select max(bcospac.fecha) as LastVisitDate from BcosPac where BcosPac.idPac = Pac.idPac) as  LastVisitDate from Pac)"
        Dim objDatos As libDB.clsTabla
        objDatos = New libDB.clsTabla(strCommand)
        objDatos.Filter = m_Cfg_Filtro
        Dim auxResult As Integer = objDatos.GetData(objDB)
        If auxResult > 0 Then
          For Each fila As DataRow In objDatos.Table.Rows
            objListCuentaInfo = New clsInfoCuenta
            objResult = clsCuenta.CuentaIgualDataRow(objListCuentaInfo, fila)
            If objResult <> Result.OK Then Return objResult
            m_Items.Add(objListCuentaInfo)

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
End Class
