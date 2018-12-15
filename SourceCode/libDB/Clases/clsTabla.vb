Public Class clsTabla

  Private m_strOriginalSelect As String
  Private m_strOriginalSelect_Count As String
  Private m_dtTable As DataTable
  Private m_strFilter As String
  Private m_strOrder As String

  Public Property Filter() As String
    Get
      Return m_strFilter
    End Get
    Set(ByVal value As String)
      m_strFilter = value
    End Set
  End Property
  Public Property Order() As String
    Get
      Return m_strOrder
    End Get
    Set(ByVal value As String)
      m_strOrder = value
    End Set
  End Property

  Public Property Table() As DataTable
    Get
      Return m_dtTable
    End Get
    Set(ByVal value As DataTable)
      m_dtTable = value
    End Set
  End Property

  Public Sub New(ByVal vTableName As String)
    Try
      m_strOriginalSelect = "SELECT * FROM " & vTableName
      m_strOriginalSelect_Count = "SELECT COUNT(*) FROM " & vTableName

      Table = New DataTable
      Filter = ""
      Order = ""
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
    End Try
  End Sub

  Public Function GetData(ByVal vObjDB As clsAcceso) As Integer
    Try
      Table.Clear()
      Return GetData(vObjDB, Table)


    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return -1
    End Try

  End Function

  Public Function GetData(ByVal vObjDB As clsAcceso, ByRef rTable As DataTable, Optional ByRef rCodeError As Integer = 0) As Integer

    Try

      Dim objResult As libCommon.Comunes.Result = libCommon.Comunes.Result.OK

      'ARMO RESPUESTA (Contempla Filtro y Orden)
      '-----------------------------------------
      Dim strSQL As String = ""
      Dim strSQL_Filter As String = ""

      If Filter <> String.Empty Then strSQL_Filter &= " " & Filter.ToString
      strSQL = m_strOriginalSelect_Count & strSQL_Filter
      Dim intCount As Integer = -1
      objResult = vObjDB.EjecutarConsulta(strSQL, intCount)
      If objResult <> libCommon.Comunes.Result.OK Then Return -1


      'SIN REGISTROS => Salgo
      If intCount <= 0 Then Return 0

      '--- Obtengo los Datos -->
      If Order <> String.Empty Then strSQL_Filter &= " " & Order.ToString
      strSQL = m_strOriginalSelect & strSQL_Filter

      'If (ObjPaginated.RegXPag > 0) Then
      '  objResult = vObjDB.Get_Data(strSQL, _
      '                              rTable, _
      '                              ObjPaginated.Register_From, _
      '                              ObjPaginated.Register_To, _
      '                              rCodeError)
      'Else
      objResult = vObjDB.GetDato(strSQL, rTable)
      'End If

      If objResult = libCommon.Comunes.Result.NOK Then Return 0
      If objResult <> libCommon.Comunes.Result.OK Then Return -1
      '<-- Obtengo los Datos ---

      Return rTable.Rows.Count

    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      rTable = Nothing
      Return -1

    End Try

  End Function

End Class
