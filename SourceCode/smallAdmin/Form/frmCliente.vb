﻿Imports libCommon.Comunes
Imports manDB
Public Class frmCliente

  Private WithEvents m_objProductList As clsListProductos = Nothing

  Public Enum E_Modo As Integer
    Nuevo = 1
    Edicion = 2
  End Enum

  Private m_Modo As E_Modo
  Private m_Cliente As clsInfoCliente

  Public Sub New(ByVal vModo As E_Modo)
    Try
      InitializeComponent()
      m_Modo = vModo

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_InfoCurrentCliente()
    Try
      With m_Cliente.Personal
        txtApellido.Text = CStr(IIf(.Apellido = "--" And m_Modo = E_Modo.Nuevo, "", .Apellido))
        txtNombre.Text = CStr(IIf(.Nombre = "--" And m_Modo = E_Modo.Nuevo, "", .Nombre))
      End With
      Call MostrarProductos()
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub Save_InfoCurrentCliente()

    Try


      With m_Cliente.Personal
        .Nombre = txtNombre.Text.Trim
        If .Nombre = "" Then .Nombre = "--"
        .Apellido = txtApellido.Text.Trim
        If .Apellido = "" Then .Apellido = "--"
        .DNI = txtID.Text.Trim
        If .DNI = "" Then .DNI = "--"
        .FechaNac = dtFechaNac.Value
        .Calle = txtCalle1.Text.Trim
        If .Calle = "" Then .Calle = "--"
        .NumCalle = txtNumero1.Text.Trim
        If .NumCalle = "" Then .NumCalle = "--"
        .FechaIngreso = dtFechaIngreso.Value
        .Email = txtEmail.Text.Trim
        If .Email = "" Then .Email = "--"
        .Tel1 = txtTelefono1.Text.Trim
        If .Tel1 = "" Then .Tel1 = "--"
        .Tel2 = txtTelefono2.Text.Trim
        If .Tel2 = "" Then .Tel2 = "--"
        .Ciudad = txtCiudad.Text.Trim
        If .Ciudad = "" Then .Ciudad = "--"
        .Provincia = txtProvincia.Text.Trim
        If .Provincia = "" Then .Provincia = "--"
        .Calle2 = txtCalle2.Text.Trim
        If .Calle2 = "" Then .Calle2 = "--"
        .NumCalle2 = txtNumero2.Text.Trim
        If .NumCalle2 = "" Then .NumCalle2 = "--"
        .NumCliente = txtNumCliente.Text.Trim
        If .NumCliente = "" Then .NumCliente = "--"
        .CodigoPostal = txtCP.Text.Trim
        If .CodigoPostal = "" Then .CodigoPostal = "--"
        .Comentarios = txtComentario.Text.Trim
        If .Comentarios = "" Then .Comentarios = "--"
        .Profesion = txtProfesion.Text.Trim
        If .Profesion = "" Then .Profesion = "--"

      End With

    Catch ex As Exception
      Call Print_msg(ex.Message)

    End Try

  End Sub

  Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    Try
      Dim vResult As libCommon.Comunes.Result
      Call Save_InfoCurrentCliente()

      vResult = clsCliente.SavePersonal(m_Cliente)
      If vResult <> Result.OK Then
        MsgBox("No se guardo")
        Exit Sub
      End If

      Me.Close()
      Exit Sub
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Try
      m_Cliente = Nothing
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetClient(ByRef rCliente As clsInfoCliente)
    Try
      If m_Cliente IsNot Nothing Then
        rCliente = m_Cliente.Clone
      Else
        rCliente = Nothing
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      m_Cliente = New clsInfoCliente()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try

      If m_Modo = E_Modo.Edicion Then
        m_Cliente = gCliente.clone

      Else 'nuevo
        m_Cliente = New clsInfoCliente
        m_Cliente.Personal.GuidCliente = Guid.NewGuid
      End If

      Call Refresh_InfoCurrentCliente()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnAgregarProducto_MouseClick(sender As Object, e As MouseEventArgs)
    Try
      Dim lProducto As New clsInfoProducto

      Using objVenta As New frmVenta()
        objVenta.ShowDialog()
        If objVenta.HayCambios Then
          objVenta.getCambios(lProducto)
          lProducto.GuidCliente = m_Cliente.Personal.GuidCliente
          m_Cliente.ListaProductos.Add(lProducto)
        End If
      End Using

      Call Refresh_InfoCurrentCliente()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub MostrarProductos()
    Try
      'If m_objProductList IsNot Nothing Then m_objProductList.Dispose()
      'm_objProductList = New clsListProductos()

      bsinfoProductos.DataSource = m_Cliente.ListaProductos  'm_objProductList.Binding
      'm_objPersona_Current = Nothing
      'Call Refresh_InfoCliente()


      'Call ClientList_RefreshData()
      bsinfoProductos.ResetBindings(False)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



 


End Class