Namespace Comunes

  Public Module modCommon

    Private Const RELEASE As Boolean = False
    Private g_Today As Date

    Public Enum E_EstadoPago As Integer
      Debe = 0 'actualmente esta debiendo este pago
      Pago = 1
      Anulo_Editado = 2  'Se anula el pago para generar uno nuevo
      Vencido = 3  'se anula el debe porque no pago dentro del plazo
      Observado = 4 ' el pago tiene algun defecto no se considera pagado ni debe 'MOSTRARLO SIEMPRE EN LA LISTA PRINCIPAL HASTA SACARLO DE ESTA SITUACION
      PagoParcial = 5
      Eliminado = 6
      DebeProximo = 7 'corresponde al proximo pago a ser debitado
      DebePendiente = 8 'corresponde al debito, posterior al proximo
      NA = -1 'No Asignado, valor inicial
    End Enum

    Enum Result As Integer
      ErrorEx = -1
      ErrorInt = -2
      OK = 255
      NOK = 254
      CANCEL = 253
    End Enum

    Public Sub Print_msg(ByVal campo As String)
      Try
        If RELEASE = True Then Exit Sub
        MsgBox(campo)
      Catch ex As Exception
        MsgBox(ex.ToString)
      End Try
    End Sub

    Public Sub SetFecha(ByVal vFecha As Date)
      Try
        g_Today = vFecha
      Catch ex As Exception
        MsgBox(ex.ToString)
      End Try
    End Sub

    Public Function GetHoy() As Date
      Try
        Return g_Today
      Catch ex As Exception
        Print_msg(ex.Message)
        Return Today
      End Try
    End Function

    Public Function GetAhora() As Date
      Try
        Return New Date(g_Today.Year, g_Today.Month, g_Today.Day, Now.Hour, Now.Minute, Now.Second)
      Catch ex As Exception
        Print_msg(ex.Message)
        Return Today
      End Try
    End Function

   

  End Module

End Namespace
