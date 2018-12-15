Namespace Comunes

  Public Module modCommon

    Private Const RELEASE As Boolean = False

    Enum Result As Integer
      ErrorEx = -1
      ErrorInt = -2
      OK = 255
      NOK = 254
    End Enum

    Public Sub Print_msg(ByVal campo As String)
      Try
        If RELEASE = True Then Exit Sub
        MsgBox(campo)
      Catch ex As Exception
        MsgBox(ex.ToString)
      End Try
    End Sub

  End Module

End Namespace
