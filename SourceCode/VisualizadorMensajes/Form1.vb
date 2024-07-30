Imports System
Public Class Form1

  Private m_lista As New List(Of clsIntercambio)
  Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
    Try
      Dim objResult As DialogResult
      Dim fileName As String = String.Empty
      Dim dataFecha As String = String.Empty
      ttlineaactual.Text = String.Empty
      Using objDialog As New OpenFileDialog
        objDialog.Filter = "link files|*.wdb"
        objDialog.Multiselect = False
        If IO.Directory.Exists("c:\mensajeria") Then
          objDialog.InitialDirectory = "c:\mensajeria"
        End If

        objResult = objDialog.ShowDialog(Me)
        If objResult = DialogResult.OK Then
          fileName = objDialog.FileName
          If objDialog.SafeFileName.Length >= 17 Then
            dataFecha = objDialog.SafeFileName.Substring(0, 17)
          End If
        End If
      End Using

      If objResult = DialogResult.OK Then
        'clear data
        m_lista.Clear()
        ClsIntercambioBindingSource1.DataSource = m_lista
        ClsIntercambioBindingSource1.ResetBindings(False)
        tp01.Text = "Lineas: 0"
        'load data
        Dim lstDatos As New List(Of String)
        LoadDatos(fileName, lstDatos)

        'Show data
        ShowDatos(lstDatos)
        tp02.Text = dataFecha
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub LoadDatos(ByVal pathFile As String, ByRef lstDatos As List(Of String))
    Try
      lstDatos.Clear()
      Using fs As New IO.FileStream(pathFile, IO.FileMode.Open, IO.FileAccess.Read)
        Using objStream As New IO.StreamReader(fs)
          Dim Linea As String = String.Empty
          Do
            Linea = objStream.ReadLine
            If Not (String.IsNullOrEmpty(Linea)) Then
              lstDatos.Add(Linea)
            End If
          Loop While Not String.IsNullOrEmpty(Linea)
        End Using
      End Using
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub ShowDatos(ByVal vDatos As List(Of String))
    Try

      For Each linea In vDatos
        Dim DataSplit As String() = linea.Split(CType(";", Char()), StringSplitOptions.None)
        If DataSplit.Length = 8 Then
          Dim entrada As New clsIntercambio
          entrada.Cliente = DataSplit(0)
          entrada.Telefono1 = DataSplit(1)
          entrada.Fecha_Pago = DataSplit(2)
          entrada.Cuota = DataSplit(3)
          entrada.Total_Cuotas = DataSplit(4)
          entrada.Valor_Cuota = DataSplit(5)
          entrada.Whatsapp_Link = DataSplit(6)
          entrada.Mensaje = DataSplit(7)
          m_lista.Add(entrada)
        End If
      Next
      ClsIntercambioBindingSource1.DataSource = m_lista
      ClsIntercambioBindingSource1.ResetBindings(False)
      tp01.Text = String.Format("Lineas: {0}", m_lista.Count)
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub dgvData1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData1.CellMouseDown
    Try

      Dim columna As DataGridViewColumn = dgvData1.Columns(e.ColumnIndex)
      If columna.DataPropertyName.ToUpper.Equals("WHATSAPP_LINK") Then
        If e.ColumnIndex <> -1 And e.RowIndex <> -1 Then
          If e.Button = Windows.Forms.MouseButtons.Left Then
            Process.Start(CStr(dgvData1.Item(e.ColumnIndex, e.RowIndex).Value))
          ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            dgvData1.Rows(e.RowIndex).Selected = True
            Dim aux As Rectangle = dgvData1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            ContextMenuStrip1.Show(dgvData1, aux.X, aux.Y)
            ttCopiar.Tag = CStr(dgvData1.Item(e.ColumnIndex, e.RowIndex).Value)
          End If
        End If
      End If

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      tp01.Text = "Lineas: 0"
      tp02.Text = ""
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub ttCopiar_Click(sender As Object, e As EventArgs) Handles ttCopiar.Click
    Try
      Dim valor As String = TryCast(ttCopiar.Tag, String)
      If Not (valor Is Nothing) Then
        My.Computer.Clipboard.SetText(valor)
        valor = String.Empty
      End If
      ContextMenuStrip1.Hide()
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub dgvData1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvData1.SelectionChanged
    Try
      If dgvData1.Rows.Count > 0 Then
        ttlineaactual.Text = dgvData1.SelectedRows(0).Index.ToString
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
End Class
