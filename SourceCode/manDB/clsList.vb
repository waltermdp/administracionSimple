Imports System.Windows.Forms
Imports libCommon.Comunes
Public MustInherit Class clsList(Of T As {New})
  Inherits libDB.Paginado.clsList(Of T)

  Protected Sub Init(ByVal vCFG_RegXPag As Integer, Optional ByVal vCFG_Filtro As String = "")

    Try

      m_Items = New List(Of T)
      Binding.DataSource = Items



      m_Cfg_Filtro = vCFG_Filtro
      m_Cfg_Orden = ""
      m_Cfg_RegXPag = vCFG_RegXPag


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try

  End Sub

End Class
