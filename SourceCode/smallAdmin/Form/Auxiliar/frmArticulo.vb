Imports libCommon.Comunes


Public Class frmArticulo

  Private m_Articulo As clsListaStorage = Nothing
  Private m_listResponsables As New List(Of clsInfoResponsable)
  Private m_IsNuevo As Boolean
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub SetListaResponsables(ByVal vLista As List(Of clsInfoResponsable))
    Try
      m_listResponsables.AddRange(vLista.ToList)
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Public Sub EditArticulo(ByVal vArticulo As clsListaStorage)
    Try
      If vArticulo Is Nothing Then Exit Sub

      m_Articulo = vArticulo.Clone
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Sub frmArticulo_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      If m_Articulo Is Nothing Then
        'new
        txtNombre.Text = "--"
        txtCodigo.Text = ""
        txtCodigoBarras.Text = ""
        txtDescripcion.Text = "--"
        txtPrecio.Text = "0,0"
        'FillResponsables()
        'responsable por defecto= DEPOSITO
        m_IsNuevo = True

      Else
        'edit
        txtNombre.Text = m_Articulo.Nombre
        txtCodigo.Text = m_Articulo.Codigo
        txtDescripcion.Text = m_Articulo.Descripcion
        txtPrecio.Text = m_Articulo.Precio.ToString
        txtCodigoBarras.Text = m_Articulo.CodigoBarras
        'mantiene el guid
        'mantiene el responsable
        m_IsNuevo = False
        btnLimpiarCampos.Visible = False
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Try
      Me.Close()
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    Try
      'Validar
      If String.IsNullOrEmpty(txtCodigo.Text.Trim) OrElse String.IsNullOrEmpty(txtCodigoBarras.Text.Trim) OrElse String.IsNullOrEmpty(txtNombre.Text.Trim) Then
        MsgBox("Los campos NOMBRE, CODIGO y CODIGO BARRAS deben contener algun dato")
        Exit Sub
      End If

      If m_IsNuevo Then
        'Buscar si existe el codigo de barras
        'Buscar si existe el nombre
        'Buscar si existe el codigo interno
        Dim vResult As Result = BuscarArticuloActual()
        If vResult = Result.NOK Then
          'continuar, no se encontro el articulo
        ElseIf vResult = Result.OK Then
          MsgBox("Ya existe un articulo con el mismo codigo y codigo de barras. Modifique alguno de los valores para poder ingresarlo.")
          Exit Sub
        Else
          If MsgBox("No se puede determinar si ya existe el articulo, si continua podrian existir nombres o codigos duplicados, Desea guardarlo de todos modos?", vbYesNo) <> MsgBoxResult.Yes Then
            'no continuar
            Exit Sub
          End If
        End If
        m_Articulo = New clsListaStorage
        m_Articulo.GuidArticulo = Guid.NewGuid
      End If

      With m_Articulo
        .Nombre = txtNombre.Text.Trim
        .Codigo = txtCodigo.Text.Trim
        .CodigoBarras = txtCodigoBarras.Text.Trim
        .Descripcion = txtDescripcion.Text.Trim
        If .Descripcion = "" Then .Descripcion = "--"

        If Not ConvStr2Dec(txtPrecio.Text.Trim, .Precio) Then
          MsgBox("EL precio debe contener solo numero y coma, Ej: 100.10")
          Exit Sub
        End If
      End With


      Dim aux As New manDB.clsInfoArticulos
      aux.GuidArticulo = m_Articulo.GuidArticulo
      aux.Nombre = m_Articulo.Nombre
      aux.Codigo = m_Articulo.Codigo
      aux.CodigoBarras = m_Articulo.CodigoBarras
      aux.Descripcion = m_Articulo.Descripcion
      aux.Precio = m_Articulo.Precio
      If clsArticulo.Save(aux) <> Result.OK Then
        MsgBox("No se puede guardar el articulo en la base de datos")
        Exit Sub
      End If
      If m_IsNuevo Then
        MsgBox("Articulo Agregado correctamente")
      Else
        MsgBox("Articulo editado correctamente")
      End If


    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub



  Private Function BuscarArticuloActual() As Result
    Try
      Dim objArticulosList As clsListArticulos = Nothing
      
      objArticulosList = New clsListArticulos()
      objArticulosList.Cfg_Orden = "ORDER BY Codigo ASC"
      objArticulosList.Cfg_Filtro = "WHERE Codigo Like '%" & txtCodigo.Text.Trim & "%' OR CodigoBarras Like '%" & txtCodigoBarras.Text.Trim & "%'"
      objArticulosList.RefreshData()
      For Each item In objArticulosList.Items

      Next

      If objArticulosList.Items.Count > 0 Then
        Return Result.OK
      Else
        Return Result.NOK
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

 


 

  Private Sub btnCopi2Bar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCopi2Bar.MouseClick
    Try
      txtCodigoBarras.Text = txtCodigo.Text
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub btnCopi2Code_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCopi2Code.MouseClick
    Try
      txtCodigo.Text = txtCodigoBarras.Text
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub btnLimpiarCampos_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLimpiarCampos.MouseClick
    Try
      'limpiar los campos actuales, solo en modo nuevo
      If Not m_IsNuevo Then
        Exit Sub
      End If

      txtNombre.Text = "--"
      txtCodigo.Text = ""
      txtCodigoBarras.Text = ""
      txtDescripcion.Text = "--"
      txtPrecio.Text = "0.0"
      'responsble deposito
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub
End Class