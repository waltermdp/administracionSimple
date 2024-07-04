Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class Form1
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Try

         Dim bResult As Boolean
         Dim spreadsheetDocument As SpreadsheetDocument = clsExcel.CreateWorkbook("c:\demo.xlsx")
         Dim worksheet As DocumentFormat.OpenXml.Spreadsheet.Worksheet
         bResult = clsExcel.AddWorksheet(spreadsheetDocument, "uno")
         'bResult = clsExcel.AddBasicTheme(spreadsheetDocument)
         bResult = clsExcel.AddBasicStyles(spreadsheetDocument)
         worksheet = spreadsheetDocument.WorkbookPart.WorksheetParts.First.Worksheet
         bResult = clsExcel.SetStringCellValue(spreadsheetDocument, worksheet, 1, 1, "Nombre", False, True)
         bResult = clsExcel.SetStringCellValue(spreadsheetDocument, worksheet, 2, 1, "Demo Excel", False, True)
         bResult = clsExcel.SetDoubleCellValue(spreadsheetDocument, worksheet, 2, 2, 10.2, 0, True)
         bResult = clsExcel.SetHiperlinkCellValue(spreadsheetDocument, worksheet, 2, 3, "Link", 4, True)
         worksheet.Save()

         spreadsheetDocument.Dispose()
         MsgBox("Fin prueba, abrir el archivo que esta en c:\demo.xlsx")
         Me.Close()
         Exit Sub

         spreadsheetDocument = SpreadsheetDocument.Create("c:\test.xls", SpreadsheetDocumentType.Workbook)
         Dim workbookpart As WorkbookPart = spreadsheetDocument.AddWorkbookPart
         workbookpart.Workbook = New Workbook

         ' Add a WorksheetPart to the WorkbookPart.
         Dim worksheetPart As WorksheetPart = workbookpart.AddNewPart(Of WorksheetPart)()
         worksheetPart.Worksheet = New Worksheet(New SheetData())

         ' Add Sheets to the Workbook.
         Dim sheets As Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(Of Sheets)(New Sheets())

         ' Append a new worksheet and associate it with the workbook.
         Dim sheet As Sheet = New Sheet
         sheet.Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart)
         sheet.SheetId = 1
         sheet.Name = "links"

         Dim row As DocumentFormat.OpenXml.Spreadsheet.Row
         Dim loopCounter As Int32
         Dim rowIndex As Integer = 0
         Dim previousRow As DocumentFormat.OpenXml.Spreadsheet.Row = Nothing
         Dim columns As DocumentFormat.OpenXml.Spreadsheet.Columns
         Dim columnIndex As UInt32
         Dim previousColumn As DocumentFormat.OpenXml.Spreadsheet.Column = Nothing

         Dim sheetData As DocumentFormat.OpenXml.Spreadsheet.SheetData = worksheetPart.Worksheet.GetFirstChild(Of DocumentFormat.OpenXml.Spreadsheet.SheetData)()
         Dim rowQuery = From item In sheetData.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Row)()
                        Where DocumentFormat.OpenXml.UInt32Value.ToUInt32(item.RowIndex) = rowIndex
                        Select item

         If rowQuery.Count() <> 0 Then
            row = rowQuery.First()
         Else
            row = New DocumentFormat.OpenXml.Spreadsheet.Row() With {.RowIndex = rowIndex}
            Dim prevRowQuery = From item In sheetData.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Row)()
                               Where DocumentFormat.OpenXml.UInt32Value.ToUInt32(item.RowIndex) = loopCounter
                               Select item
            For counter As Int32 = rowIndex - 1 To 1 Step -1
               loopCounter = counter
               previousRow = prevRowQuery.FirstOrDefault()
               If Not (previousRow Is Nothing) Then
                  Exit For
               End If
            Next
            sheetData.InsertAfter(row, previousRow)
         End If

         ' Check if the cell exists, create if necessary
         'Dim cellQuery = From item In row.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Cell)()
         '                Where item.CellReference.Value = cellAddress
         '                Select item
         'If (cellQuery.Count() > 0) Then
         '   Cell = cellQuery.First()
         'Else
         '   ' Find the previous existing cell in the row
         '   Dim prevCellQuery = From item In row.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Cell)()
         '                       Where item.CellReference.Value = Excel.ColumnNameFromIndex(loopCounter) & rowIndex
         '   For counter As Int32 = columnIndex - 1 To 1 Step -1
         '      loopCounter = counter
         '      previousCell = prevCellQuery.FirstOrDefault()
         '      If Not (previousCell Is Nothing) Then
         '         Exit For
         '      End If
         '   Next
         '   Cell = New DocumentFormat.OpenXml.Spreadsheet.Cell() With {
         '       .CellReference = cellAddress
         '   }
         '   row.InsertAfter(Cell, previousCell)
         'End If

         ' Check if the column collection exists
         columns = worksheetPart.Worksheet.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Columns)().FirstOrDefault()
         If (columns Is Nothing) Then
            columns = worksheetPart.Worksheet.InsertAt(New DocumentFormat.OpenXml.Spreadsheet.Columns(), 0)
         End If
         ' Check if the column exists
         Dim colQuery = From item In columns.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Column)()
                        Where DocumentFormat.OpenXml.UInt32Value.ToUInt32(item.Min) = columnIndex
                        Select item
         If colQuery.Count() = 0 Then
            ' Find the previous existing column in the columns
            Dim prevColQuery = From item In columns.Elements(Of DocumentFormat.OpenXml.Spreadsheet.Column)()
                               Where DocumentFormat.OpenXml.UInt32Value.ToUInt32(item.Min) = loopCounter
                               Select item
            For counter As Int32 = columnIndex - 1 To 1 Step -1
               loopCounter = counter
               previousColumn = prevColQuery.FirstOrDefault()
               If Not (previousColumn Is Nothing) Then
                  Exit For
               End If
            Next
            columns.InsertAfter(
               New DocumentFormat.OpenXml.Spreadsheet.Column() With {
                  .Min = columnIndex,
                  .Max = columnIndex,
                  .CustomWidth = True,
                  .Width = 9
               }, previousColumn)
         End If

         Dim data As SheetData = New SheetData



         'For i As Integer = 0 To 7
         '   Dim aux As Cell = New Cell
         '   aux.DataType = New EnumValue(Of CellValues)(CellValues.SharedString)
         '   aux.CellValue = New CellValue("22")
         '   row.InsertAt(Of Cell)(aux, i)
         'Next
         'data.InsertAt(Of Row)(row, 0)
         'worksheetPart.Worksheet.Append(data)
         worksheetPart.Worksheet.Save()

         'For i As Integer = 0 To m_lstConsulta.Count - 1 ' Each Movimiento In vMovimientos

         '      worksheet.Cells(i + 2, 1).value = m_lstConsulta(i).Cliente.ToString
         '      worksheet.Cells(i + 2, 2).value = m_lstConsulta(i).Telefono1.ToString
         '      worksheet.Cells(i + 2, 3).value = m_lstConsulta(i).FechaPago.ToString("dd/MM/yyyy")
         '      worksheet.Cells(i + 2, 4).value = m_lstConsulta(i).CuotaNumero.ToString
         '      worksheet.Cells(i + 2, 5).value = m_lstConsulta(i).TotalCuotas.ToString
         '      worksheet.Cells(i + 2, 6).value = String.Format("{0:N2}", m_lstConsulta(i).ValorCuota)
         '      worksheet.Hyperlinks.Add(worksheet.Cells(i + 2, 7), m_lstConsulta(i).Mensaje.ToString, , "WhatsApp", "LINK")
         '      worksheet.Cells(i + 2, 8).value = m_lstConsulta(i).Mensaje.ToString  'a modo de saber lo que hay en el link mas rapido

         '   Next

         sheets.Append(sheet)

         workbookpart.Workbook.Save()

         ' Dispose the document.
         spreadsheetDocument.Dispose()

         MsgBox("fin test")
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub
End Class
