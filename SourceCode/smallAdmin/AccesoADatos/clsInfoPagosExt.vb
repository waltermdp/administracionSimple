Public Class clsInfoPagosExt
  Inherits manDB.clsInfoPagos

  Public ReadOnly Property MetodoDePago As String
    Get
      Try
        Return "2"
      Catch ex As Exception
        Return ""
      End Try
    End Get
  End Property
End Class
