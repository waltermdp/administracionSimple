﻿Imports libCommon.Comunes
Imports manDB
Public Class main

  Private m_CurrentSortColumnName As String
  Private m_CurrentSortDirection As String
  Private m_CurrentSortColumn As DataGridViewColumn
  Private WithEvents m_objDatabaseList As clsListDatabase = Nothing


  Private WithEvents m_objVendedorList As clsListVendedores = Nothing
  Private Const CONST_COUNT_PACS_FOR_PAGE As Integer = 10

  Private m_objPersona_Current As clsInfoPersona = Nothing

  

  Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Dim vResult As libCommon.Comunes.Result
      vResult = Entorno.init
      If vResult <> Result.OK Then
        MsgBox("No continua application, error init")
      End If

      m_CurrentSortColumnName = "Nombre"
      m_CurrentSortDirection = "DESC"

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      MostrarClientes()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarClientes()
    Try
      Dim strFilterUser As String = ""

      If m_objDatabaseList IsNot Nothing Then m_objDatabaseList.Dispose()
      'If m_objProductList IsNot Nothing Then m_objProductList.Dispose()
      'If m_objVendedorList IsNot Nothing Then m_objVendedorList.Dispose()


      Dim objResult As Result
     
      m_objDatabaseList = New clsListDatabase(Entorno.DB_SLocal_ConnectionString, CONST_COUNT_PACS_FOR_PAGE)
      'm_objVisitList = New clsListBancos(clsList(Of Global.DllEDCS.clsInfoBco).E_Source.sLocal, CONST_COUNT_VISITS_FOR_PAGE)
      'm_objProfPacList = New clsListProfPac(clsList(Of Global.DllEDCS.clsInfoProfesional).E_Source.sLocal)

      'm_objDatabaseList.Cfg_Filtro = "WHERE Acceso=" & CInt(clsClienteDataAccess.E_Modo.Privado).ToString & " AND " & strFilterUser

      'SetColorDefecto(dgvData, True)
      'SetColorDefecto(dgvVisits, True)




      'Asocio el Control de Paginación y la Grilla a la Base de Datos
      'm_objDatabaseList.LinkCtrl(CType(UcControlPaginadoV1, libDB.Paginado.IPaginado))
      'UcControlPaginadoV1.IsCurrentMoving = AddressOf Attend_PaginateV1CurrentMoving
      'UcControlPaginadoV1.CurrentBeforeChange = AddressOf Attend_PaginateV1CurrentBeforeChange
      'UcControlPaginadoV1.CurrentAfterChange = AddressOf Attend_PaginateV1CurrentAfterChange

      'm_objVisitList.LinkCtrl(CType(UcControlPaginadoV2, libDB.Paginado.IPaginado))
      'UcControlPaginadoV2.IsCurrentMoving = AddressOf Attend_PaginateV2CurrentMoving


      '///////////////TODO_A: OJO ver order by. Agregar icono asc desc //////////////////////////////////////
      m_CurrentSortDirection = "DESC"
      m_CurrentSortColumnName = "Nombre" 'Nothing
      m_objDatabaseList.Cfg_Orden = "ORDER BY " & m_CurrentSortColumnName & " " & m_CurrentSortDirection
      '///////////////////////////////////////////////////////////////////////////}


      bsInfoCliente.DataSource = m_objDatabaseList.Binding
      'ClsInfoBcoBindingSource.DataSource = m_objVisitList.Binding

      m_objPersona_Current = Nothing
      Call Refresh_InfoCliente()


      Call ClientList_RefreshData()
      bsInfoCliente.ResetBindings(False)



    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub ClientList_RefreshData()
    Try
      m_objDatabaseList.RefreshData()


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub dgvData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvData1.SelectionChanged

    Try

      If dgvData1.SelectedRows.Count <> 1 Then Exit Sub

      'Cada vez que se actualizen los Datos automáticamente
      'If m_blnRefresh_By_Paginated_Or_Sort = True Then Exit Sub
      'If m_blnRefresh_By_Delete = True Then Exit Sub
      Call Refresh_Selection(dgvData1.SelectedRows(0).Index)

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub dgvData_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvData1.DataError
    Try
      Dim ew As Integer = 0
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub bsInfoCliente_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsInfoCliente.ListChanged
    Try
      Dim i As Integer = 0
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
    Try
      Call MostrarClientes()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)

    Try


      If indice < 0 Then
        dgvData1.ClearSelection()
        Exit Sub
      End If

      If (indice >= 0) Then
        m_objPersona_Current = CType(dgvData1.Rows(indice).DataBoundItem, ClsInfoPersona)
        Call Refresh_InfoCliente()
      End If

      If dgvData1.Rows(indice).Selected <> True Then
        dgvData1.Rows(indice).Selected = True
      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)

    End Try

  End Sub


  Private Sub Refresh_InfoCliente()

    Try

      Dim iResult As Integer

      If m_objPersona_Current Is Nothing Then
        'Paciente
        'txtPaciente.Text = ""
        'txtChart.Text = ""
        'txtID.Text = ""

        'Profesional
        'txtRequestBy.Text = ""

        'Lista de Visitas

        'm_objVisitList.Cfg_Filtro = "WHERE False"


        'm_objVisitList.Cfg_Orden = "ORDER BY Fecha DESC"
        'iResult = VisitList_RefreshData()
        'If iResult <> libCommon.E_OpResult.OK Then Exit Sub
      Else

        With m_objPersona_Current
          'Paciente
          'txtPaciente.Text = .ToString
          'txtChart.Text = .NHC
          'txtID.Text = .DNI

          'Profesional
          'txtRequestBy.Text = ""
          'm_objProfPacList.Cfg_Filtro = "WHERE IdPac = " & .IdPac
          'iResult = ProfPacList_RefreshData()
          'If iResult <> libCommon.E_OpResult.OK Then Exit Sub

          'If m_objProfPacList.Items.Count > 0 Then
          '  'Muestro el Primero (No debería haber más)
          '  txtRequestBy.Text = m_objProfPacList.Items.First.ToString
          'End If

          'Lista de Visitas
          'm_objVisitList.Cfg_Filtro = "WHERE IdPac = " & .IdPac
          'm_objVisitList.Cfg_Orden = "ORDER BY Fecha DESC"
          'iResult = VisitList_RefreshData()
          'If iResult <> libCommon.E_OpResult.OK Then Exit Sub

        End With
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    Try
      Dim vResult As Result
      If m_objPersona_Current Is Nothing Then
        MsgBox("Debe seleccionar un cliente")
        Exit Sub
      End If
      Dim LDataCliente As New clsInfoCliente
      vResult = clsCliente.Cliente_Load(m_objPersona_Current.GuidCliente, LDataCliente)
      If vResult <> Result.OK Then
        MsgBox("no existe cliente")
        Exit Sub
      End If
      gCliente = LDataCliente.Clone
      Dim objDialog As New frmCliente(frmCliente.E_Modo.Edicion)
      objDialog.ShowDialog()
      objDialog.Dispose()

      'Salgo guardando


      'Call RefreshDatabse
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    Try

      Dim objDialog As New frmCliente(frmCliente.E_Modo.Nuevo)
      objDialog.ShowDialog()
      objDialog.Dispose()

      'Salgo guardando


      'Call refreshDatabase

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

 


  Private Sub btnDeben_Click(sender As Object, e As EventArgs) Handles btnDeben.Click
    Try
      Using objForm As New frmDeben
        objForm.ShowDialog()
      End Using
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub
End Class
