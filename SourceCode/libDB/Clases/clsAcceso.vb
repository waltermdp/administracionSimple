Imports libCommon.Comunes
Imports System.Data.OleDb

Public Class clsAcceso

  Private m_Connection As OleDb.OleDbConnection
  Private m_strConnectionString As String
  Private CONST_OPERATIONS_TIMEOUT As Integer = 200

  Public Function Init(ByVal vConnectionString As String) As Result
    Try
      m_strConnectionString = vConnectionString
      m_Connection = New OleDb.OleDbConnection(m_strConnectionString)

      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function OpenDB(ByVal vConnectionString As String) As Result
    Try
      Dim vResult As Result = Init(vConnectionString)
      If vResult <> Result.OK Then Return vResult

      If m_Connection Is Nothing Then
        Return Result.ErrorInt
      End If

      If m_Connection.State = ConnectionState.Open Then
        Call Print_msg("Se llama a un Open y el estado ya es Open")
      End If

      m_Connection.Open()


      Dim intTimeout As Integer = CONST_OPERATIONS_TIMEOUT
      While (m_Connection.State <> ConnectionState.Open)

        If intTimeout <= 0 Then
          Return Result.ErrorInt
        End If
        System.Threading.Thread.Sleep(1)

        intTimeout -= 1

      End While



      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function CloseDB() As Result
    Try

      If m_Connection Is Nothing Then
        Return Result.ErrorInt
      End If

      If m_Connection.State <> ConnectionState.Closed Then
        m_Connection.Close()
      End If

      Dim intTimeout As Integer = CONST_OPERATIONS_TIMEOUT
      While m_Connection.State <> ConnectionState.Closed

        If intTimeout <= 0 Then
          Return Result.ErrorInt
        End If
        System.Threading.Thread.Sleep(1)
        intTimeout -= 1
      End While

      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function EjecutarConsulta(ByVal vCommand As String, ByRef rResult As Integer) As Result
    Try
      Dim objCommand As OleDbCommand = Nothing

      Try

        objCommand = New OleDbCommand(vCommand, m_Connection)
        Dim vResult As Object = objCommand.ExecuteScalar()
        rResult = CInt(vResult)
        Return Result.OK

      Catch ex As Exception
        Call Print_msg(ex.Message)
        Return Result.ErrorEx

      Finally
        If objCommand IsNot Nothing Then objCommand = Nothing
      End Try

      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetDato(ByVal vCommand As String, ByRef rDataTable As DataTable, Optional ByVal vFrom As Integer = -1, Optional ByVal vTo As Integer = -1) As Result
    Try
      Dim objCommand As OleDbCommand = Nothing
      Dim objReader As OleDbDataReader = Nothing

      Try

        objCommand = New OleDbCommand(vCommand, m_Connection)
        objReader = objCommand.ExecuteReader

        Dim schema As DataTable = objReader.GetSchemaTable()
        Dim columns(schema.Rows.Count - 1) As DataColumn
        Dim column As DataColumn
        'Build the schema for the table that will contain the data.
        For i As Integer = 0 To columns.GetUpperBound(0) Step 1
          column = New DataColumn
          column.AllowDBNull = CBool(schema.Rows(i)("AllowDBNull"))
          column.AutoIncrement = CBool(schema.Rows(i)("IsAutoIncrement"))
          column.ColumnName = CStr(schema.Rows(i)("ColumnName"))
          column.DataType = CType(schema.Rows(i)("DataType"), Type)
          If column.DataType Is GetType(String) Then
            column.MaxLength = CInt(schema.Rows(i)("ColumnSize"))
          End If
          column.ReadOnly = CBool(schema.Rows(i)("IsReadOnly"))
          column.Unique = CBool(schema.Rows(i)("IsUnique"))
          columns(i) = column
        Next i

        rDataTable = New DataTable
        rDataTable.Columns.AddRange(columns)

        If objReader.HasRows Then

          Dim auxRow As DataRow

          Dim intIndex As Integer = 0
          While objReader.Read()

            If (vFrom = -1) Or ((vFrom <> -1) And (intIndex >= vFrom)) Then

              auxRow = rDataTable.NewRow()

              For i As Integer = 0 To columns.GetUpperBound(0)
                auxRow(i) = objReader(i)
              Next i

              rDataTable.Rows.Add(auxRow)

            End If

                  intIndex += 1
                  If ((vTo <> -1) And (intIndex > vTo)) Then
                     Exit While
                  End If

               End While

            End If

            objReader.Close()

        If rDataTable.Rows.Count = 0 Then
          Return libCommon.Comunes.Result.NOK
        Else
          Return libCommon.Comunes.Result.OK
        End If

      Catch ex As Exception
        Call libCommon.Comunes.Print_msg(ex.Message)
        'rCodeError = Entorno.CodeErrors.DB_Access.Error_GetData
        Return libCommon.Comunes.Result.ErrorEx

      Finally
        If objCommand IsNot Nothing Then objCommand = Nothing
        If (objReader IsNot Nothing) AndAlso (objReader.IsClosed = False) Then objReader = Nothing

      End Try


      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetTabla() As Result
    Try


      Return Result.OK
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.ToString)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function ExecuteNonQuery(ByVal vCommand As String) As Result

    Dim objCommand As OleDbCommand = Nothing

    Try

      objCommand = New OleDbCommand(vCommand, m_Connection)


      Dim res As Integer = objCommand.ExecuteNonQuery()

      If res < 0 Then
        Return Result.ErrorInt
      Else
        Return Result.OK
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    Finally
      If objCommand IsNot Nothing Then objCommand = Nothing

    End Try
  End Function

  Public Shared Function Field_Correcting(ByVal vField As String) As String
    Try
      Return vField.Replace("""", "'")
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return vField
    End Try
  End Function

  Public Shared Function GetConectionString_MAccess(ByVal vPathDB As String, Optional ByVal vPass As String = "") As String
    Try

      If vPass = "" Then
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & vPathDB & """;Persist Security Info=True"
      Else
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & vPathDB & """;Persist Security Info=True; Jet OLEDB:Database Password=" & vPass
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      Return ""
    End Try
  End Function

End Class
