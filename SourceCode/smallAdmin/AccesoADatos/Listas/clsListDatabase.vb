Imports manDB
Imports libCommon.Comunes
Public Class clsListDatabase

  Inherits clsList(Of clsInfoDatabase)
  Private m_DBConnectionString As String

  Public Sub New(ByVal vDBConnectionString As String, ByVal vCFG_RegXPag As Integer, Optional ByVal vCFG_Filtro As String = "")
    Try
      Call InitDB()
      m_DBConnectionString = vDBConnectionString

      Call Init(vCFG_RegXPag, vCFG_Filtro)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  'Refreshdata must heredar
  Protected Overrides Function RefreshData_Private() As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As libCommon.Comunes.Result = Result.OK

      Try
        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(m_DBConnectionString)
        If objResult <> Result.OK Then Return objResult

        Dim objListDBInfo As clsInfoDatabase
        Dim strCommand As String = "Clientes" ', (select max(bcospac.fecha) as LastVisitDate from BcosPac where BcosPac.idPac = Pac.idPac) as  LastVisitDate from Pac)"
        Dim objDatos As libDB.clsTabla
        objDatos = New libDB.clsTabla(strCommand)
        Dim auxResult As Result = objDatos.GetData(objDB)
        If auxResult > 0 Then
          For Each fila As DataRow In objDatos.Table.Rows

            objListDBInfo = New clsInfoDatabase()
            objResult = InfoDatabaseIgualDataRow(objListDBInfo, fila)
            If objResult <> Result.OK Then Return objResult
            m_Items.Add(objListDBInfo)

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

  Public Shared Function InfoDatabaseIgualDataRow(ByRef vInfoDatabase As clsInfoDatabase, ByVal vData As DataRow) As Result
    Try

      With vData
        Try
          vInfoDatabase.IDCliente = CInt(IIf(IsDBNull(.Item("IdCliente")), -1, .Item("IdCliente")))
        Catch ex As Exception
          vInfoDatabase.IDCliente = -1
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.GuidCliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Nothing, .Item("GuidCliente")), Guid)
        Catch ex As Exception
          vInfoDatabase.GuidCliente = Nothing
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoDatabase.Nombre = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Apellido = CStr(IIf(IsDBNull(.Item("Apellido")), "", .Item("Apellido")))
        Catch ex As Exception
          vInfoDatabase.Apellido = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.DNI = CStr(IIf(IsDBNull(.Item("ID")), "", .Item("ID")))
        Catch ex As Exception
          vInfoDatabase.DNI = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.FechaNac = CDate(IIf(IsDBNull(.Item("FechaNac")), Nothing, .Item("FechaNac")))
        Catch ex As Exception
          vInfoDatabase.FechaNac = Date.Today
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Calle = CStr(IIf(IsDBNull(.Item("Calle")), "", .Item("Calle")))
        Catch ex As Exception
          vInfoDatabase.Calle = ""
          Call Print_msg(ex.Message)
        End Try


        Try
          vInfoDatabase.NumCalle = CStr(IIf(IsDBNull(.Item("NumCalle")), "", .Item("NumCalle")))
        Catch ex As Exception
          vInfoDatabase.NumCalle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.FechaIngreso = CDate(IIf(IsDBNull(.Item("FechaIngreso")), Nothing, .Item("FechaIngreso")))
        Catch ex As Exception
          vInfoDatabase.FechaIngreso = Date.Today
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Email = CStr(IIf(IsDBNull(.Item("Email")), "", .Item("Email")))
        Catch ex As Exception
          vInfoDatabase.Email = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Tel1 = CStr(IIf(IsDBNull(.Item("Tel1")), "", .Item("Tel1")))
        Catch ex As Exception
          vInfoDatabase.Tel1 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Tel2 = CStr(IIf(IsDBNull(.Item("Tel2")), "", .Item("Tel2")))
        Catch ex As Exception
          vInfoDatabase.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Ciudad = CStr(IIf(IsDBNull(.Item("Ciudad")), "", .Item("Ciudad")))
        Catch ex As Exception
          vInfoDatabase.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Provincia = CStr(IIf(IsDBNull(.Item("Provincia")), "", .Item("Provincia")))
        Catch ex As Exception
          vInfoDatabase.Tel2 = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Calle2 = CStr(IIf(IsDBNull(.Item("Calle2")), "", .Item("Calle2")))
        Catch ex As Exception
          vInfoDatabase.Calle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.NumCalle2 = CStr(IIf(IsDBNull(.Item("NumCalle2")), "", .Item("NumCalle2")))
        Catch ex As Exception
          vInfoDatabase.NumCalle = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.NumCliente = CStr(IIf(IsDBNull(.Item("NumCliente")), "", .Item("NumCliente")))
        Catch ex As Exception
          vInfoDatabase.NumCliente = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.CodigoPostal = CStr(IIf(IsDBNull(.Item("CodigoPostal")), "", .Item("CodigoPostal")))
        Catch ex As Exception
          vInfoDatabase.CodigoPostal = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Comentarios = CStr(IIf(IsDBNull(.Item("Comentarios")), "", .Item("Comentarios")))
        Catch ex As Exception
          vInfoDatabase.Comentarios = ""
          Call Print_msg(ex.Message)
        End Try

        Try
          vInfoDatabase.Profesion = CStr(IIf(IsDBNull(.Item("Profesion")), "", .Item("Profesion")))
        Catch ex As Exception
          vInfoDatabase.Profesion = ""
          Call Print_msg(ex.Message)
        End Try


      End With

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Sub InitDB()
    Try
      m_DBConnectionString = ""

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

End Class
