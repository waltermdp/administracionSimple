Imports libCommon.Comunes
Imports manDB
Public Class frmVendedorData
 

  Private m_Vendedor As clsInfoVendedor
  Private m_Grupos As New clsListGrupos

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
      m_Grupos.RefreshData()
      cmbGrupo.DataSource = m_Grupos.Items ' [Enum].GetNames(GetType(GRUPOS))
      cmbCategoria.DataSource = [Enum].GetNames(GetType(CATEGORIA))
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
        If .NumVendedor = "" Then .NumVendedor = "--"
        .Ciudad = txtCiudad.Text.Trim
        If .Ciudad = "" Then .Ciudad = "--"
        .Provincia = txtProvincia.Text.Trim
        If .Provincia = "" Then .Provincia = "--"
        .CodigoPostal = txtCodigoPostal.Text.Trim
        If .CodigoPostal = "" Then .CodigoPostal = "--"
        .ID = txtId.Text.Trim
        If .ID = "" Then .ID = "--"
        .Grupo = cmbGrupo.SelectedItem.ToString
        
        .Tel1 = txtTel1.Text.Trim
        If .Tel1 = "" Then .Tel1 = "--"
        .Tel2 = txtTel2.Text.Trim
        If .Tel2 = "" Then .Tel2 = "--"
        .Email = txtEmail.Text.Trim
        If .Email = "" Then .Email = "--"
        .Categoria = cmbCategoria.SelectedItem

        .Comentario = txtComentarios.Text.Trim
        If .Comentario = "" Then .Comentario = "--"
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


        If m_Grupos.Items.Exists(Function(c) c.Nombre.ToUpper = .Grupo.ToUpper) Then
          cmbGrupo.SelectedItem = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = .Grupo.ToUpper)
        Else
          cmbGrupo.SelectedItem = m_Grupos.Items.First(Function(c) c.Nombre.ToUpper = "NINGUNO")
        End If



        txtTel1.Text = .Tel1
        txtTel2.Text = .Tel2
        txtEmail.Text = .Email
        cmbCategoria.SelectedItem = .Categoria
        txtComentarios.Text = .Comentario
      End With
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



End Class