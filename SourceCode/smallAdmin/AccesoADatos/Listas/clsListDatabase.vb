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
          MsgBox("Fallo refresh data")
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
          vInfoDatabase.Apellido = CStr(IIf(IsDBNull(.Item("Apellido")), "", .Item("Apellido")))
        Catch ex As Exception
          vInfoDatabase.Apellido = ""
          Call Print_msg(ex.Message)
        End Try


        'Try
        '  vInfoDatabase.Calle1 = CStr(IIf(IsDBNull(.Item("Calle1")), "", .Item("Calle1")))
        'Catch ex As Exception
        '  vInfoDatabase.Calle1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


        'Try
        '  vInfoDatabase.Ciudad = CStr(IIf(IsDBNull(.Item("Ciudad")), "", .Item("Ciudad")))
        'Catch ex As Exception
        '  vInfoDatabase.Ciudad = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.CodPost = CStr(IIf(IsDBNull(.Item("CodPost")), "", .Item("CodPost")))
        'Catch ex As Exception
        '  vInfoDatabase.CodPost = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Comentarios = CStr(IIf(IsDBNull(.Item("Comentarios")), "", .Item("Comentarios")))
        'Catch ex As Exception
        '  vInfoDatabase.Comentarios = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.DNI = CStr(IIf(IsDBNull(.Item("DNI")), "", .Item("DNI")))
        'Catch ex As Exception
        '  vInfoDatabase.DNI = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Email1 = CStr(IIf(IsDBNull(.Item("Email1")), "", .Item("Email1")))
        'Catch ex As Exception
        '  vInfoDatabase.Email1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Fecha = CDate(IIf(IsDBNull(.Item("Fecha")), Nothing, .Item("Fecha")))
        'Catch ex As Exception
        '  vInfoDatabase.Fecha = Date.Today
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.FechaNac = CDate(IIf(IsDBNull(.Item("FechaNac")), Nothing, .Item("FechaNac")))
        'Catch ex As Exception
        '  vInfoDatabase.FechaNac = Date.Today
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        Try
          
          vInfoDatabase.GuidCliente = CType(IIf(IsDBNull(.Item("GuidCliente")), Nothing, .Item("GuidCliente")), Guid)

        Catch ex As Exception
          vInfoDatabase.GuidCliente = Nothing
          Call Print_msg(ex.Message)
        End Try


        'Try

        '  If Entorno.cEndoSOLO Then
        '    vInfoDatabase.GuidOwner = CType(IIf(IsDBNull(.Item("GuidOwner")), Nothing, New Guid(CStr(.Item("GuidOwner")))), Guid)
        '  Else
        '    vInfoDatabase.GuidOwner = CType(IIf(IsDBNull(.Item("GuidOwner")), Nothing, .Item("GuidOwner")), Guid)
        '  End If

        'Catch ex As Exception
        '  vInfoDatabase.GuidOwner = Nothing
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Acceso = CInt(IIf(IsDBNull(.Item("Acceso")), Nothing, .Item("Acceso")))
        'Catch ex As Exception
        '  vInfoDatabase.Acceso = Nothing
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Institucion = CStr(IIf(IsDBNull(.Item("Institucion")), "", .Item("Institucion")))
        'Catch ex As Exception
        '  vInfoDatabase.Institucion = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.NHC = CStr(IIf(IsDBNull(.Item("NHC")), "", .Item("NHC")))

        'Catch ex As Exception
        '  vInfoDatabase.NHC = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


        Try
          vInfoDatabase.Nombre = CStr(IIf(IsDBNull(.Item("Nombre")), "", .Item("Nombre")))
        Catch ex As Exception
          vInfoDatabase.Nombre = ""
          Call Print_msg(ex.Message)
        End Try


        'Try
        '  vInfoDatabase.NumCalle1 = CStr(IIf(IsDBNull(.Item("NumCalle1")), "", .Item("NumCalle1")))
        'Catch ex As Exception
        '  vInfoDatabase.NumCalle1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.PathPac = CStr(IIf(IsDBNull(.Item("PathPac")), "", .Item("PathPac")))
        'Catch ex As Exception
        '  vInfoDatabase.PathPac = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.ProvEstado = CStr(IIf(IsDBNull(.Item("ProvEstado")), "", .Item("ProvEstado")))
        'Catch ex As Exception
        '  vInfoDatabase.ProvEstado = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

        'Try
        '  vInfoDatabase.Telefono1 = CStr(IIf(IsDBNull(.Item("Telefono1")), "", .Item("Telefono1")))
        'Catch ex As Exception
        '  vInfoDatabase.Telefono1 = ""
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try


        'Try
        '  vInfoDatabase.LastVisitDate = CDate(IIf(IsDBNull(.Item("LastVisitDate")), Nothing, .Item("LastVisitDate")))
        'Catch ex As Exception
        '  vInfoDatabase.LastVisitDate = Date.Today
        '  Call libCommon.Debug.Print_MsgBox(ex)
        'End Try

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
