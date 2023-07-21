Public Class clsModoDebito

  Public Shared GUID_PATAGONIA As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117927")
  Public Shared GUID_HIPOTECARIO As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117926")
  Public Shared GUID_HIPOTECARIO_7464 As New Guid("d1f63b6f-81a0-4699-924b-16a219b44ef7")
  Public Shared GUID_VISA_DEBITO As New Guid("d167e036-b175-4a67-9305-a47c116e8f5c")
  Public Shared GUID_VISA_CREDITO As New Guid("7580f2d4-d9ec-477b-9e3a-50afb7141ab5")
  Public Shared GUID_CBU As New Guid("c3daf694-fdef-4e67-b02b-b7b3a9117924")
  Public Shared GUID_EFECTIVO As New Guid("9ebcf274-f84f-42ac-b3de-d375bb3bd314")
  Public Shared GUID_MASTER_DEBITO As New Guid("ea5d6084-90c3-4b66-82b2-9c4816c07523")
  Public Shared GUID_MERCADO_PAGO As New Guid("598878be-b8b3-4b1b-9261-f989f0800afc")

  Public Shared Function ATexto(ByVal vGuid As Guid) As String
    Try
      Select Case vGuid
        Case GUID_PATAGONIA
          Return "Patagonia"
        Case GUID_HIPOTECARIO
          Return "Hipotecario"
        Case GUID_HIPOTECARIO_7464
          Return "Hipotecario_7464"
        Case GUID_VISA_DEBITO
          Return "Visa Debito"
        Case GUID_VISA_CREDITO
          Return "Visa Credito"
        Case GUID_CBU
          Return "CBU"
        Case GUID_EFECTIVO
          Return "Efectivo"
        Case GUID_MASTER_DEBITO
          Return "Master Debito"
        Case GUID_MERCADO_PAGO
          Return "Mercado Pago"
        Case Else
          Return String.Empty
      End Select
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function


End Class
