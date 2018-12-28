Imports libCommon.Comunes
Imports manDB
Public Class frmCuenta

  Private m_objCuentaCurrent As clsInfoCuenta
  Private WithEvents m_objCuentaList As clsListaCuentas = Nothing
  Private m_GuidCliente As Guid

  Public Sub New(ByVal vGuidClient As Guid)
    InitializeComponent()
    Try
      m_GuidCliente = vGuidClient
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Dim vResult As Result

      Call AllowEditNew(False)

      cmbTipoDeCuenta.DataSource = g_TipoPago



    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AllowEditNew(ByVal permitir As Boolean)
    Try
      btnNuevo.Visible = Not permitir
      btnVolver.Visible = Not permitir
      lstCuentas.Visible = Not permitir
      btnGuardar.Visible = permitir
      btnCancelar.Visible = permitir
      cmbTipoDeCuenta.Enabled = permitir
      txtCodigo1.ReadOnly = Not permitir
      txtCodigo2.ReadOnly = Not permitir
      txtCodigo3.ReadOnly = Not permitir
      txtCodigo4.ReadOnly = Not permitir
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCuenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Call MostrarListaCuentas()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarListaCuentas()
    Try
      If m_objCuentaList IsNot Nothing Then m_objCuentaList.Dispose()

      m_objCuentaList = New clsListaCuentas()
      m_objCuentaList.Cfg_Filtro = "WHERE GuidCliente={" & m_GuidCliente.ToString & "}"
      bsCuenta.DataSource = m_objCuentaList.Binding

      Call CuentaList_RefreshData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CuentaList_RefreshData()
    Try
      m_objCuentaList.RefreshData()
      bsCuenta.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub FillData()
    Try
      With m_objCuentaCurrent
        txtCodigo1.Text = .Codigo1
        txtCodigo2.Text = .Codigo2
        txtCodigo3.Text = .Codigo3
        txtCodigo4.Text = .Codigo4
        cmbTipoDeCuenta.SelectedItem = g_TipoPago.First(Function(c) c.Equals(.TipoDeCuenta))
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

 

  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      If Validar() = False Then
        MsgBox("Algunos campos son invalidos, no se puede guardar")
        Exit Sub
      End If

      Call CargarData()

      If clsCuenta.Save(m_objCuentaCurrent) <> Result.OK Then
        MsgBox("No se puede guardar Cuenta en la Base de Datos")
        Exit Sub
      End If

      Call AllowEditNew(False)
      Call MostrarListaCuentas()
      lstCuentas.SelectedItem = m_objCuentaCurrent
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnVolver_MouseClick(sender As Object, e As MouseEventArgs) Handles btnVolver.MouseClick
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Validar() As Boolean
    Try


      'TODO: validar los campos
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function

  
  Private Sub FillCuentaData()
    Try
      With m_objCuentaCurrent
        If g_TipoPago.Exists(Function(c) c.GuidTipo = m_objCuentaCurrent.TipoDeCuenta) Then
          cmbTipoDeCuenta.SelectedItem = g_TipoPago.Find(Function(c) c.GuidTipo = m_objCuentaCurrent.TipoDeCuenta)
        Else
          cmbTipoDeCuenta.SelectedIndex = -1
        End If

        txtCodigo1.Text = .Codigo1
        txtCodigo2.Text = .Codigo2
        txtCodigo3.Text = .Codigo3
        txtCodigo4.Text = .Codigo4
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub CargarData()
    Try
      With m_objCuentaCurrent
        .TipoDeCuenta = CType(cmbTipoDeCuenta.SelectedItem, clsTipoPago).GuidTipo
        .Codigo1 = txtCodigo1.Text
        .Codigo2 = txtCodigo2.Text
        .Codigo3 = txtCodigo3.Text
        .Codigo4 = txtCodigo4.Text
        .GuidCliente = m_GuidCliente
      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        lstCuentas.ClearSelected()
        Exit Sub
      End If
      If (indice >= 0) Then
        m_objCuentaCurrent = CType(lstCuentas.SelectedItem, clsInfoCuenta)
      End If

      Call FillCuentaData()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub lstCuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCuentas.SelectedIndexChanged
    Try
      Call Refresh_Selection(lstCuentas.SelectedIndex)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnNuevo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseClick
    Try
      m_objCuentaCurrent = New clsInfoCuenta
      m_objCuentaCurrent.GuidCuenta = Guid.NewGuid
      Call FillCuentaData()
      Call AllowEditNew(True)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnCancelar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseClick
    Try
      Call AllowEditNew(False)
      m_objCuentaCurrent = New clsInfoCuenta
      Call FillCuentaData()
      m_objCuentaCurrent = Nothing
      Call Refresh_Selection(-1)
      Call MostrarListaCuentas()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetCuentaSeleccionada(ByRef rCuenta As clsInfoCuenta)
    Try
      If m_objCuentaCurrent IsNot Nothing Then
        rCuenta = m_objCuentaCurrent.Clone
      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

End Class