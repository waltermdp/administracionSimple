Imports libCommon.Comunes
Imports manDB
Public Class ucTextBoxNumerico

  Private m_Cultura As New System.Globalization.CultureInfo("es-AR")




  Public Sub New()

    ' This call is required by the designer.
    m_skip = True
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Try
      m_Cultura.NumberFormat.CurrencyDecimalDigits = 2
      m_Cultura.NumberFormat.CurrencyDecimalSeparator = ","
      m_Cultura.NumberFormat.CurrencyGroupSeparator = "."
      TextAlign = HorizontalAlignment.Right
      Text = "$0,00" ' String.Format(m_Cultura, "{0:C}", CDec(0))
      


    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub

  Private m_cursorPos As Integer = 0

  Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
    Try
      'MyBase.OnKeyPress(e)
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
        Exit Sub
      End If

    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub

  Private Function Filter(ByVal vTexto As String) As Decimal
    Try
      If String.IsNullOrEmpty(vTexto) Then Return 0
      If String.IsNullOrWhiteSpace(vTexto) Then Return 0
      Dim lstChar As IEnumerable(Of Char) = vTexto.ToList.Where(Function(c) Char.IsDigit(c))
     
      If lstChar.Count <= 0 Then
        Return 0
      End If
      Dim textFiltrado As String = New String(lstChar.ToArray)
      If IsNumeric(textFiltrado) Then
        Return CDec(textFiltrado)
      End If
      Return 0
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function


  Private m_skip As Boolean
  Protected Overrides Sub OnTextChanged(e As EventArgs)
    Try
      If m_skip = True Then Exit Sub
      m_skip = True

      MyBase.OnTextChanged(e)
      m_cursorPos = Text.Length - SelectionStart


      Text = String.Format(m_Cultura, "{0:C}", CDec(Filter(Me.Text) / 100))

      Dim index As Integer = Text.Length - m_cursorPos
      If index <= 0 Then index = 0
      SelectionStart = index

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub
End Class
