Imports libCommon.Comunes
Public Class ucProgreso

  Public Delegate Sub dOperacion()
  Private m_Operacion As dOperacion

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    Try
      btnCancelar.Visible = False
      Visible = False
      Location = New Point(0, 0)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
    ' Add any initialization after the InitializeComponent() call.

  End Sub



  Public Sub Start(ByVal subOperacion As dOperacion)
    Try
      m_Operacion = subOperacion
      Size = New Size(1280, 720)
      Location = New Point(0, 0)
      BackColor = Color.Transparent
      Me.Visible = True
      BackgroundWorker1.RunWorkerAsync()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      lblDescription.Text = "Cargando..."
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    Try
      Call m_Operacion()

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    Try
      Visible = False
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub


  Private Sub ucProgreso_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

  End Sub
End Class
