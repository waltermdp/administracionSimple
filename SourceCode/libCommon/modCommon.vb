Namespace Comunes

  Public Module modCommon

    Private Const RELEASE As Boolean = False

    Public Enum E_EstadoPago As Integer
      Debe = 0
      Pago = 1
      Anulo_Editado = 2  'Se anula el pago para generar uno nuevo
      Vencido = 3  'se anula el pago porque no pago dentro del plazo
      Observado = 4 ' el pago tiene algun defecto no se considera pagado ni debe 'MOSTRARLO SIEMPRE EN LA LISTA PRINCIPAL HASTA SACARLO DE ESTA SITUACION
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

  End Module

End Namespace
