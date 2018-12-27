Imports libCommon.Comunes
Imports manDB
Public Class frmVendedorData
 

  Private m_Vendedor As clsInfoVendedor


  Public Sub New(ByVal vVendedor As clsInfoVendedor)
    InitializeComponent()
    Try
      If vVendedor Is Nothing Then
        m_Vendedor = New clsInfoVendedor
        m_Vendedor.GuidVendedor = Guid.NewGuid
      Else
        m_Vendedor = vVendedor.Clone
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick
    Try
      If CargarData() <> Result.OK Then
        'Verificar datos invalidos
        Exit Sub
      End If
      If clsVendedor.Save(m_Vendedor) <> Result.OK Then
        MsgBox("No se puede guardar vendedor en la Base de Datos")
        Exit Sub
      End If
      'Guardar
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick
    Try

      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmVendedorData_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

      Dim vResult As Result

      vResult = clsVendedor.Load(m_Vendedor.GuidVendedor, m_Vendedor)
      If vResult <> Result.OK Then
        MsgBox("Falla buscar vendedor")
        Me.Close()
      End If
      Call FillData()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Validar(ByVal vEntrada As String) As Result
    Try

      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function CargarData() As Result
    Try
      With m_Vendedor
        .Apellido = txtApellido.Text.Trim
        If .Apellido = "" Then .Apellido = "--"
        .Nombre = txtNombre.Text.Trim
        If .Nombre = "" Then .Nombre = "--"
        .NumVendedor = txtNumVendedor.Text.Trim
        .Ciudad = txtCiudad.Text.Trim
        .Provincia = txtProvincia.Text.Trim
        .CodigoPostal = txtCodigoPostal.Text.Trim
        .ID = txtId.Text.Trim
        .Grupo = txtGrupo.Text.Trim
        .Tel1 = txtTel1.Text.Trim
        .Tel2 = txtTel2.Text.Trim
        .Email = txtEmail.Text.Trim
        .Categoria = txtCategoria.Text.Trim
        .Comentario = txtComentarios.Text.Trim
      End With
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function



  Private Sub FillData()
    Try
      With m_Vendedor
        txtNombre.Text = .Nombre
        txtApellido.Text = .Apellido
        txtNumVendedor.Text = .NumVendedor
        txtCiudad.Text = .Ciudad
        txtProvincia.Text = .Provincia
        txtCodigoPostal.Text = .Provincia
        txtId.Text = .ID
        txtGrupo.Text = .Grupo
        txtTel1.Text = .Tel1
        txtTel2.Text = .Tel2
        txtEmail.Text = .Email
        txtCategoria.Text = .Categoria
        txtComentarios.Text = .Comentario
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


End Class