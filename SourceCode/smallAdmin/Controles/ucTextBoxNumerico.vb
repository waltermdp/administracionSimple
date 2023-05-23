Imports libCommon.Comunes
Imports manDB
Public Class ucTextBoxNumerico

  Private m_Cultura As New System.Globalization.CultureInfo("es-AR")

  Private m_skip As Boolean
  Private m_moneda As Boolean
  Private m_limite As Integer = 22

  Public Property Moneda As Boolean
    Get
      Return m_moneda
    End Get
    Set(value As Boolean)
      m_moneda = value
    End Set
  End Property

  Public Property Limite As Integer
    Get
      Return m_limite
    End Get
    Set(value As Integer)
      m_limite = value
    End Set
  End Property

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
      Text = String.Format(m_Cultura, "{0:C}", Text)
      SelectionStart = Text.Length


    Catch ex As Exception
      Print_msg(ex.Message)
    Finally
      m_skip = False
    End Try
  End Sub


  Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
    Try
      'MyBase.OnKeyPress(e)
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
        Exit Sub
      End If

      If Char.IsNumber(e.KeyChar) AndAlso Text.Length >= m_limite Then
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
      If lstChar.Count >= 27 Then
        MsgBox("Excedio la cantidad de 27 digitos, el valor se anula.")
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

  Public Function GetDecimalValue() As Decimal
    Try
      Return Filter(Text)
    Catch ex As Exception
      Print_msg(ex.Message)
      Return 0
    End Try
  End Function

  Public Function GetStringNumericValue() As String
    Try
      Return Text.ToString()
    Catch ex As Exception
      Print_msg(ex.Message)
      Return String.Empty
    End Try
  End Function

  Protected Overrides Sub OnGotFocus(e As EventArgs)
    Try
      MyBase.OnGotFocus(e)
      SelectionStart = Text.Length
    Catch ex As Exception
      Print_msg(ex.Message)
    End Try
  End Sub


  Protected Overrides Sub OnTextChanged(e As EventArgs)
    Try
      If m_skip = True Then Exit Sub
      m_skip = True
      Dim posicion As Integer
      MyBase.OnTextChanged(e)
      posicion = Text.Length - SelectionStart

      If m_moneda Then
        Text = String.Format(m_Cultura, "{0:C}", CDec(Filter(Me.Text) / 100))
      Else
        'Text = Filter(Me.Text).ToString(New String("0"c, m_limite))
      End If


      Dim index As Integer = Text.Length - posicion
      If index <= 0 Then index = 0
      SelectionStart = index

      m_skip = False
    Catch ex As Exception
      Print_msg(ex.Message)
      m_skip = False
    End Try
  End Sub
End Class
