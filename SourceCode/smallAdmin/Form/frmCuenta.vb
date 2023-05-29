Imports libCommon.Comunes
Imports manDB
Public Class frmCuenta

  Private m_objCuentaCurrent As clsInfoCuenta
  Private WithEvents m_objCuentaList As clsListaCuentas = Nothing
  Private m_GuidCliente As Guid
  Private m_skip As Boolean

  Public Sub New(ByVal vGuidClient As Guid, Optional ByVal vCancelar As Boolean = False)
    InitializeComponent()
    Try
      m_GuidCliente = vGuidClient
      m_skip = True
      Try
        cmbTipoDeCuenta.DataSource = g_TipoPago
      Finally
        m_skip = False
      End Try

      btnSalirSinCambios.Visible = vCancelar

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  'new del...(address of MiFuncion)
  Private Function GetName(ByVal vGuidTipoCuenta As Guid) As String
    Return GetNameOfTipoPago(vGuidTipoCuenta)
  End Function

  Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try


      Call AllowEditNew(False)


      cmbTipoDeCuenta.SelectedIndex = -1


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub AllowEditNew(ByVal permitir As Boolean)
    Try
      btnEditar.Visible = Not permitir
      btnNuevo.Visible = Not permitir
      btnVolver.Visible = Not permitir
      lstCuentas.Visible = Not permitir
      btnSalirSinCambios.Visible = Not permitir
      btnGuardar.Visible = permitir
      btnCancelar.Visible = permitir
      cmbTipoDeCuenta.Enabled = permitir
      UcCBU1.Enabled = permitir
      UcDDHipotecario1.Enabled = permitir
      UcTarjeta1.Enabled = permitir
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCuenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      UcCBU1.Visible = False
      UcDDHipotecario1.Visible = False
      UcTarjeta1.Visible = False

      Call MostrarListaCuentas()
      m_objCuentaCurrent = Nothing
      Call Refresh_Selection(-1)
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
      For Each cuenta In m_objCuentaList.Items
        cuenta.SetDelegadoCustomString(New clsInfoCuenta.delToString(AddressOf GetName))
      Next
      bsCuenta.ResetBindings(False)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub FillData()
    Try
      With m_objCuentaCurrent

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

      If UcCBU1.Visible Then
        UcCBU1.GetData(m_objCuentaCurrent)
      ElseIf UcDDHipotecario1.Visible Then
        UcDDHipotecario1.GetData(m_objCuentaCurrent)
      ElseIf UcTarjeta1.Visible Then
        UcTarjeta1.GetData(m_objCuentaCurrent)
      End If

      If clsCuenta.Save(m_objCuentaCurrent) <> Result.OK Then
        MsgBox("No se puede guardar Cuenta en la Base de Datos")
        Exit Sub
      End If

      Call AllowEditNew(False)
      Call MostrarListaCuentas()
      lstCuentas.SelectedItem = m_objCuentaCurrent
      Refresh_Selection(lstCuentas.SelectedIndex)
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
        If m_objCuentaCurrent IsNot Nothing Then
          If g_TipoPago.Exists(Function(c) c.GuidTipo = m_objCuentaCurrent.TipoDeCuenta) Then
            cmbTipoDeCuenta.SelectedItem = g_TipoPago.Find(Function(c) c.GuidTipo = m_objCuentaCurrent.TipoDeCuenta)
          Else
            cmbTipoDeCuenta.SelectedIndex = -1
          End If
        Else
          cmbTipoDeCuenta.SelectedIndex = -1
        End If
        
        If UcCBU1.Visible Then
          UcCBU1.SetData(m_objCuentaCurrent)
        ElseIf UcDDHipotecario1.Visible Then
          UcDDHipotecario1.SetData(m_objCuentaCurrent)
        ElseIf UcTarjeta1.Visible Then
          UcTarjeta1.SetData(m_objCuentaCurrent)
        End If

      End With
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  'Private Sub CargarData()
  '  Try
  '    With m_objCuentaCurrent
  '      .TipoDeCuenta = CType(cmbTipoDeCuenta.SelectedItem, clsTipoPago).GuidTipo
  '      .Codigo1 = txtCodigo1.Text
  '      .Codigo2 = txtCodigo2.Text
  '      .Codigo3 = txtCodigo3.Text
  '      .Codigo4 = txtCodigo4.Text
  '      .Codigo5 = txtCodigo5.Text
  '      .Codigo6 = txtcodigo6.Text
  '      .GuidCliente = m_GuidCliente
  '    End With
  '  Catch ex As Exception
  '    Call Print_msg(ex.Message)
  '  End Try
  'End Sub

  Private Sub Refresh_Selection(ByVal indice As Integer)
    Try
      If indice < 0 Then
        lstCuentas.ClearSelected()
        FillCuentaData()
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
      m_objCuentaCurrent.GuidCliente = m_GuidCliente
      UcCBU1.Clear()
      UcDDHipotecario1.Clear()
      UcTarjeta1.Clear()
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
      'Call FillCuentaData()
      m_objCuentaCurrent = Nothing
      Call Refresh_Selection(-1)
      Call MostrarListaCuentas()
      lstCuentas.ClearSelected()
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

  

  Private Sub cmbTipoDeCuenta_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoDeCuenta.SelectedValueChanged
    Try
      If m_skip Then Exit Sub
      Dim objCMB As ComboBox = TryCast(sender, ComboBox)
      UcCBU1.Visible = False
      UcDDHipotecario1.Visible = False
      UcTarjeta1.Visible = False

      If objCMB.SelectedIndex >= 0 Then
        Dim TipodePago = CType(objCMB.SelectedItem, clsTipoPago)
        If TipodePago.Es(clsModoDebito.GUID_HIPOTECARIO) OrElse TipodePago.Es(clsModoDebito.GUID_HIPOTECARIO_7464) Then
          m_objCuentaCurrent.TipoDeCuenta = TipodePago.GuidTipo
          UcDDHipotecario1.SetData(m_objCuentaCurrent)
          UcDDHipotecario1.Visible = True
        ElseIf TipodePago.Es(clsModoDebito.GUID_PATAGONIA) OrElse TipodePago.Es(clsModoDebito.GUID_CBU) Then
          m_objCuentaCurrent.TipoDeCuenta = TipodePago.GuidTipo
          UcCBU1.SetData(m_objCuentaCurrent)
          UcCBU1.Visible = True
        ElseIf TipodePago.Es(clsModoDebito.GUID_MASTER_DEBITO) OrElse TipodePago.Es(clsModoDebito.GUID_VISA_CREDITO) OrElse TipodePago.Es(clsModoDebito.GUID_VISA_DEBITO) Then
          m_objCuentaCurrent.TipoDeCuenta = TipodePago.GuidTipo
          UcTarjeta1.SetData(m_objCuentaCurrent)
          UcTarjeta1.Visible = True
        End If
      Else
        Dim j As Integer = 9
      End If



    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnSalirSinCambios_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSalirSinCambios.MouseClick
    Try
      m_objCuentaCurrent = Nothing
      Me.Close()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
    Try
      If m_objCuentaCurrent Is Nothing Then
        MsgBox("Debe seleccionar una cuenta")
        Exit Sub
      End If
      'Call FillCuentaData()
      Call AllowEditNew(True)
      cmbTipoDeCuenta.Enabled = False
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  
End Class