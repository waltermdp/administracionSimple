
Imports System.Windows.Forms

Namespace Paginado

  Public MustInherit Class clsList(Of T As {New})
    Implements IDisposable

    Protected WithEvents m_Binding As New BindingSource

    Protected m_Cfg_Filtro As String
    Protected m_Cfg_Orden As String
    Protected m_Items As List(Of T)
    Protected m_Cfg_RegXPag As Integer = -1

    Protected MustOverride Function RefreshData_Private() As libCommon.Comunes.Result

    Public Property Binding() As BindingSource
      Get
        Return m_Binding
      End Get
      Set(ByVal value As BindingSource)
        If m_Binding IsNot Nothing Then m_Binding.Dispose()
        m_Binding = value
      End Set
    End Property

    Public Property Cfg_Filtro() As String
      Get
        Return m_Cfg_Filtro
      End Get
      Set(ByVal value As String)

        m_Cfg_Filtro = value

      End Set

    End Property
    Public Property Cfg_Orden() As String
      Get
        Return m_Cfg_Orden
      End Get
      Set(ByVal value As String)

        m_Cfg_Orden = value

      End Set

    End Property

    Public Overloads ReadOnly Property Items() As System.Collections.Generic.List(Of T)
      Get
        Return m_Items
      End Get
    End Property

    Public Function Find(ByVal item As T) As Integer

      Try
        Return m_Items.IndexOf(item)

      Catch ex As Exception
        Call libCommon.Comunes.Print_msg(ex.Message)
        Return 0
      End Try

    End Function

    Public Sub RefreshData()
      Try
        Call RefreshData_Private()
      Catch ex As Exception
        Call libCommon.Comunes.Print_msg(ex.Message)
      End Try
    End Sub


    Protected Sub RefreshCtrl()

      Try

        Binding.SuspendBinding()
        Binding.ResetBindings(False)
        Binding.ResumeBinding()

      Catch ex As Exception
        Call libCommon.Comunes.Print_msg(ex.Message)
      End Try

    End Sub

    Private Sub Binding_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingManagerDataErrorEventArgs) Handles m_Binding.DataError
      Try

      Catch ex As Exception
        Call libCommon.Comunes.Print_msg(ex.Message)
      End Try

    End Sub

#Region "IDisposable Support"

    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
      If Not Me.disposedValue Then
        If disposing Then
          ' TODO: Liberar otro estado (objetos administrados).
          If m_Binding.DataSource IsNot Nothing Then
            m_Binding.DataSource = Nothing
            m_Binding = Nothing
          End If
          'm_Ctrl = Nothing
        End If

        ' TODO: Liberar su propio estado (objetos no administrados).
        ' TODO: Establecer campos grandes como Null.
      End If
      Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
      ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
      Dispose(True)
      GC.SuppressFinalize(Me)
    End Sub

#End Region

  End Class

End Namespace