Imports libCommon.Comunes
Public Class frmProgreso

  Public Delegate Sub dOperacionArgumentos(ByRef rResult As Result, ByRef rMessage As String)

  Private m_OperacionArgumentos As dOperacionArgumentos
  Private m_Result As Result
  Private m_ResultMessage As String = String.Empty

  Public ReadOnly Property ResultProcess As Result
    Get
      Return m_Result
    End Get
  End Property

  Public ReadOnly Property ResultMessage As String
    Get
      Return m_ResultMessage
    End Get
  End Property


  Public Sub New(ByVal subOperacion As dOperacionArgumentos)

    ' This call is required by the designer.
    InitializeComponent()
    Try
      m_OperacionArgumentos = subOperacion
      btnCancelar.Visible = False


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    Try
      'Call m_Operacion()
      m_OperacionArgumentos(m_Result, m_ResultMessage)
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    Try

      pbBarra.MarqueeAnimationSpeed = 0

    Catch ex As Exception
      Call Print_msg(ex.Message)
    Finally
      Close()
    End Try
  End Sub


  Private Sub frmProgreso_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try

      'Size = New Size(1280, 720)
      'Location = New Point(0, 0)
      'BackColor = Color.Transparent
      'Me.Visible = True
      pbBarra.MarqueeAnimationSpeed = 30
      BackgroundWorker1.RunWorkerAsync()
      'SetStyle(ControlStyles.SupportsTransparentBackColor, True)
     

      lblDescription.Text = "Cargando..."
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

 
End Class