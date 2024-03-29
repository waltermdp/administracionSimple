﻿Imports libCommon.Comunes
Imports manDB

Public Class clsPago


  Public Shared Function Load(ByRef rlistPagos As List(Of clsInfoPagos), ByVal vGuidProducto As Guid) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rlistPagos, vGuidProducto)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally
        If objDB IsNot Nothing Then
          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If
        End If
      End Try

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function Init(ByVal vObjDB As libDB.clsAcceso, ByRef rlistPagos As List(Of clsInfoPagos), ByVal vGuidProducto As Guid, Optional ByRef rCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result = Result.OK
      Dim dt As DataTable = Nothing
      Dim strSQL As String

      'strSQL = "SELECT Pat.* FROM Pat INNER JOIN PatPac ON Pat.IdPat = PatPac.IdPat WHERE [Pagos.GuidProducto]={" & vGuidProducto.ToString & "}" ' WHERE [Pagos.GuidProducto]= " & vGuidProducto.ToString
      strSQL = "SELECT * FROM [Pagos] WHERE [Pagos.GuidProducto]={" & vGuidProducto.ToString & "}"

      objResult = vObjDB.GetDato(strSQL, dt)

      '--- Devuelvo OK cuando no hay resultados -->
      If objResult = Result.NOK Then Return Result.OK
      If objResult <> Result.OK Then Return objResult
      '<-- Devuelvo OK cuando no hay resultados ---

      '<-- Comando en DB ---


      Dim auxInfoPago As clsInfoPagos = Nothing
      For Each dr As DataRow In dt.Rows
        auxInfoPago = New clsInfoPagos
        objResult = clsPago.PagoIgualDataRow(auxInfoPago, dr)
        If objResult <> Result.OK Then Exit For
        rlistPagos.Add(auxInfoPago)
      Next

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Save(ByVal vObjDB As libDB.clsAcceso, ByRef rListPagos As List(Of clsInfoPagos)) As Result
    Try
      Dim objResult As Result = Result.OK
      For Each pago In rListPagos
        objResult = SavePago(vObjDB, pago)
        If objResult <> Result.OK Then Exit For
      Next
      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Save(ByRef rInfoPagos As manDB.clsInfoPagos) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = SavePago(objDB, rInfoPagos)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally

        If objDB IsNot Nothing Then

          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If

        End If

      End Try

      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try
  End Function

  Public Shared Function PagoIgualDataRow(ByRef vInfoPago As clsInfoPagos, ByVal vData As DataRow) As Result
    Try
      With vData
        Try
          vInfoPago.IdPago = CInt(IIf(IsDBNull(.Item("IdPago")), -1, .Item("IdPago")))
        Catch ex As Exception
          vInfoPago.IdPago = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.GuidPago = CType(IIf(IsDBNull(.Item("GuidPago")), Nothing, .Item("GuidPago")), Guid)
        Catch ex As Exception
          vInfoPago.GuidPago = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.GuidCuenta = CType(IIf(IsDBNull(.Item("GuidCuenta")), Nothing, .Item("GuidCuenta")), Guid)
        Catch ex As Exception
          vInfoPago.GuidCuenta = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.GuidProducto = CType(IIf(IsDBNull(.Item("GuidProducto")), Nothing, .Item("GuidProducto")), Guid)
        Catch ex As Exception
          vInfoPago.GuidProducto = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.NumCuota = CInt(IIf(IsDBNull(.Item("NumCuota")), -1, .Item("NumCuota")))
        Catch ex As Exception
          vInfoPago.NumCuota = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.ValorCuota = CDec(IIf(IsDBNull(.Item("ValorCuota")), 0, .Item("ValorCuota")))
        Catch ex As Exception
          vInfoPago.ValorCuota = 0
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.VencimientoCuota = CDate(IIf(IsDBNull(.Item("VencimientoCuota")), Nothing, .Item("VencimientoCuota")))
        Catch ex As Exception
          vInfoPago.VencimientoCuota = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.FechaPago = CDate(IIf(IsDBNull(.Item("FechaPago")), Nothing, .Item("FechaPago")))
        Catch ex As Exception
          vInfoPago.FechaPago = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.EstadoPago = CType(IIf(IsDBNull(.Item("EstadoPago")), E_EstadoPago.NA, .Item("EstadoPago")), E_EstadoPago)
        Catch ex As Exception
          vInfoPago.EstadoPago = E_EstadoPago.NA
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.NumComprobante = CInt(IIf(IsDBNull(.Item("NumComprobante")), -1, .Item("NumComprobante")))
        Catch ex As Exception
          vInfoPago.NumComprobante = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoPago.FechaUltimaExportacion = CDate(IIf(IsDBNull(.Item("FechaUltimaExportacion")), Date.MinValue, .Item("FechaUltimaExportacion")))
          'If IsDBNull(.Item("FechaUltimaExportacion")) Then
          '  Dim j As Integer = 0
          'Else
          '  Dim k As Date = CDate(.Item("FechaUltimaExportacion"))
          '  Dim jj As Long = k.Ticks
          '  k = Date.MinValue
          '  jj = k.Ticks
          '  Dim ll As String = k.ToShortDateString
          '  Dim g As Integer = 9
          'End If
        Catch ex As Exception
          vInfoPago.FechaUltimaExportacion = Date.MinValue
          Call Print_msg(ex.Message)
        End Try
        Try
          vInfoPago.FechaUltimaImportacion = CDate(IIf(IsDBNull(.Item("FechaUltimaImportacion")), Date.MinValue, .Item("FechaUltimaImportacion")))
        Catch ex As Exception
          vInfoPago.FechaUltimaImportacion = Date.MinValue
          Call Print_msg(ex.Message)
        End Try

      End With

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function SavePago(ByVal vObjDB As libDB.clsAcceso, ByRef rInfoPagos As manDB.clsInfoPagos) As Result
    Try
      Dim objResult As Result

      If Not (rInfoPagos.GuidProducto = Nothing) Then


        '--- Comando en DB -->

        objResult = vObjDB.EjecutarConsulta("SELECT [IdPago] FROM [Pagos] WHERE [GuidPago]={" & rInfoPagos.GuidPago.ToString & "}", rInfoPagos.IdPago)
        If objResult <> Result.OK Then Return objResult

        Dim strSQL As New System.Text.StringBuilder("")

        With rInfoPagos

          If rInfoPagos.IdPago <= 0 Then
            'Insert

            strSQL.Append("INSERT INTO [Pagos] ")

            strSQL.Append("(")

            strSQL.Append("[GuidPago],")
            strSQL.Append("[GuidProducto],")
            strSQL.Append("[NumCuota],")
            strSQL.Append("[ValorCuota],")
            strSQL.Append("[VencimientoCuota],")
            strSQL.Append("[FechaPago],")
            strSQL.Append("[EstadoPago],")
            strSQL.Append("[NumComprobante],")
            strSQL.Append("[FechaUltimaExportacion],")
            strSQL.Append("[FechaUltimaImportacion],")
            strSQL.Append("[GuidCuenta]")

            strSQL.Append(") VALUES (")

            strSQL.Append("""{" & .GuidPago.ToString & "}"",")
            strSQL.Append("""{" & .GuidProducto.ToString & "}"",")
            strSQL.Append("""" & .NumCuota.ToString & """,")
            strSQL.Append("""" & .ValorCuota & """,")
            strSQL.Append("""" & .VencimientoCuota & """,")
            strSQL.Append("""" & .FechaPago & """,")
            strSQL.Append("""" & .EstadoPago & """,")
            strSQL.Append("""" & .NumComprobante & """,")
            strSQL.Append("""" & .FechaUltimaExportacion & """,")
            strSQL.Append("""" & .FechaUltimaImportacion & """,")
            strSQL.Append("""{" & .GuidCuenta.ToString & "}""")

            strSQL.Append(")")

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult
            Dim strCommand As String


            strCommand = "Select @@IDENTITY"


            objResult = vObjDB.EjecutarConsulta(strCommand, rInfoPagos.IdPago)
            If objResult <> Result.OK Then Return objResult

          Else

            'Update
            strSQL.Append("UPDATE [Pagos] SET ")
            strSQL.Append("[GuidPago]=""{" & .GuidPago.ToString & "}"",")
            strSQL.Append("[GuidProducto]=""{" & .GuidProducto.ToString & "}"",")
            strSQL.Append("[NumCuota]=""" & .NumCuota.ToString & """,")
            strSQL.Append("[ValorCuota]=""" & .ValorCuota.ToString & """,")
            strSQL.Append("[VencimientoCuota]=""" & .VencimientoCuota & """,")
            strSQL.Append("[FechaPago]=""" & .FechaPago & """,")
            strSQL.Append("[EstadoPago]=""" & .EstadoPago & """,")
            strSQL.Append("[NumComprobante]=""" & .NumComprobante.ToString & """,")
            strSQL.Append("[FechaUltimaExportacion]=""" & .FechaUltimaExportacion & """,")
            strSQL.Append("[FechaUltimaImportacion]=""" & .FechaUltimaImportacion & """,")
            strSQL.Append("[GuidCuenta]=""{" & .GuidCuenta.ToString & "}""")

            strSQL.Append(" WHERE [IdPago]=" & .IdPago)

            objResult = vObjDB.ExecuteNonQuery(strSQL.ToString)
            If objResult <> Result.OK Then Return objResult

          End If

        End With
        '<-- Comando en DB ---

      Else
        objResult = Result.ErrorInt
      End If




      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Private Shared Function Delete(ByVal vObjDB As libDB.clsAcceso, ByVal vIdpac As Integer) As Result
    Try

      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String = "DELETE * FROM [Pagos] WHERE [IdPago]=" & vIdpac


      objResult = vObjDB.ExecuteNonQuery(strCommand)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Private Shared Function Delete(ByVal vObjDB As libDB.clsAcceso, ByVal vGuidProducto As Guid) As Result
    Try

      Dim objResult As Result

      '--- Comando en DB -->
      Dim strCommand As String = "DELETE * FROM [Pagos] WHERE [GuidProducto]={" & vGuidProducto.ToString & "}"


      objResult = vObjDB.ExecuteNonQuery(strCommand)
      If objResult <> Result.OK Then Return objResult
      '<-- Comando en DB ---

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx

    End Try

  End Function

  Public Shared Function Delete(ByVal GuidProduto As Guid) As Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Delete(objDB, GuidProduto)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally

        If objDB IsNot Nothing Then

          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If

        End If

      End Try

      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Delete(ByVal vIdpac As Integer) As Integer
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try
        objDB = New libDB.clsAcceso


        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Delete(objDB, vIdpac)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally

        If objDB IsNot Nothing Then

          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If

        End If

      End Try

      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

End Class
