Imports libCommon.Comunes
Imports manDB
Public Class frmCliente

  Private WithEvents m_objProductList As clsListProductos = Nothing
  Private m_Persona As ClsInfoPersona

  Public Sub New(ByVal vPersona As ClsInfoPersona)
    InitializeComponent()
    Try
      If vPersona Is Nothing Then
        m_Persona = New ClsInfoPersona
        m_Persona.GuidCliente = Guid.NewGuid
      Else
        m_Persona = vPersona.Clone
      End If
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub Refresh_InfoCurrentCliente()
    Try
      With m_Persona
        txtNombre.Text = .Nombre
        txtApellido.Text = .Apellido
        txtID.Text = .DNI
        dtFechaNac.Value = .FechaNac
        txtCalle1.Text = .Calle
        txtNumero1.Text = .NumCalle
        dtFechaIngreso.Value = .FechaIngreso
        txtEmail.Text = .Email
        txtTelefono1.Text = .Tel1
        txtTelefono2.Text = .Tel2
        txtCiudad.Text = .Ciudad
        txtProvincia.Text = .Provincia
        txtCalle2.Text = .Calle2
        txtNumero2.Text = .NumCalle2
        txtCP.Text = .CodigoPostal
        txtComentario.Text = .Comentarios
        txtProfesion.Text = .Profesion
      End With

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

  Private Sub Save_InfoCurrentCliente()

    Try


      With m_Persona
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
      Dim auxpersona As Integer
      Dim CrearCuentaDefecto As Boolean = Not clsPersona.FindGuid(m_Persona.GuidCliente, auxpersona)

      vResult = clsPersona.Save(m_Persona)
      If vResult <> Result.OK Then
        MsgBox("No se guardo")
        Exit Sub
      End If
      'si es nuevo entonces crear 1 cuenta asociada = efectivo
      If CrearCuentaDefecto Then
        Dim Cuenta As New clsInfoCuenta
        Cuenta.GuidCliente = m_Persona.GuidCliente
        Cuenta.GuidCuenta = Guid.NewGuid
        Cuenta.TipoDeCuenta = g_TipoPago(0).GuidTipo
        If clsCuenta.Save(Cuenta) <> Result.OK Then
          MsgBox("No se pudo asociar cuenta por defecto")
        End If
      End If
      Me.Close()
      Exit Sub
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Try
      m_Persona = Nothing
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub GetClient(ByRef rPersona As ClsInfoPersona)
    Try
      If m_Persona IsNot Nothing Then
        rPersona = m_Persona.Clone
      End If

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub frmCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try

      Call Refresh_InfoCurrentCliente()

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


End Class