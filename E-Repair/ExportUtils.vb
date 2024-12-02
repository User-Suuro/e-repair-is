Imports System.Runtime.InteropServices

Public Class ExportUtils
    Public Sub ExportDataTableToExcel(dataTable As DataTable, columnHeaderMapping As Dictionary(Of String, String))
        Dim excelApp As Object = Nothing
        Dim workBook As Object = Nothing
        Dim workSheet As Object = Nothing

        Try
            Cursor.Current = Cursors.WaitCursor

            excelApp = CreateObject("Excel.Application")
            workBook = excelApp.Workbooks.Add

            Dim sheetIndex As Integer = 1
            workSheet = workBook.Sheets(sheetIndex)
            Dim totalSheets As Integer = Math.Ceiling(dataTable.Rows.Count / 1000.0)

            For sheetIndex = 1 To totalSheets

                If sheetIndex > 1 Then
                    workSheet = workBook.Sheets.Add(After:=workBook.Sheets(workBook.Sheets.Count))
                End If

                workSheet.Name = $"Sheet{sheetIndex}" ' Assign a name like "Sheet1", "Sheet2", etc.

                ' Write headers for each sheet
                For i As Integer = 0 To dataTable.Columns.Count - 1
                    Dim originalColumnName As String = dataTable.Columns(i).ColumnName
                    Dim formalColumnName As String = If(columnHeaderMapping.ContainsKey(originalColumnName), columnHeaderMapping(originalColumnName), originalColumnName)
                    workSheet.Cells(1, i + 1).Value = formalColumnName
                Next

                Dim startRow As Integer = (sheetIndex - 1) * 1000
                Dim endRow As Integer = Math.Min(startRow + 1000, dataTable.Rows.Count)

                For i As Integer = startRow To endRow - 1
                    For j As Integer = 0 To dataTable.Columns.Count - 1
                        workSheet.Cells((i - startRow) + 2, j + 1).Value = dataTable.Rows(i)(j)

                        ' Format date/time if applicable
                        If dataTable.Columns(j).DataType Is GetType(DateTime) Then
                            workSheet.Cells((i - startRow) + 2, j + 1).NumberFormat = "dd/mm/yyyy"
                        End If
                    Next

                    workSheet.Rows((i - startRow) + 2).EntireRow.AutoFit()
                Next

                ' AutoFit for each sheet
                workSheet.Rows.AutoFit()
                workSheet.Columns.AutoFit()

                ' Wrap text for each column
                For i As Integer = 1 To workSheet.Columns.Count
                    workSheet.Columns(i).Style.WrapText = True
                Next
            Next

            'Dim totalEmployeesRow As Integer = dataTable.Rows.Count + 2
            'workSheet.Cells(totalEmployeesRow, 1).Value = "Total Employees"
            'workSheet.Cells(totalEmployeesRow, 2).Value = dataTable.Rows.Count

            ' Prompt user for file path (topmost)
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files|*.xlsx"
                saveFileDialog.Title = "Save Excel File"
                saveFileDialog.FileName = "EmployeeData.xlsx"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim savePath As String = saveFileDialog.FileName
                    workBook.SaveAs(savePath)
                    ShowTopMostMessageBox("Data exported successfully to " & savePath, "Success", MessageBoxIcon.Information)
                Else
                    ShowTopMostMessageBox("Export cancelled.", "Cancelled", MessageBoxIcon.Information)
                End If

            End Using

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ShowTopMostMessageBox("Error during export: " & ex.Message, "Export Error", MessageBoxIcon.Error)
        Finally
            ' Clean up
            If workBook IsNot Nothing Then workBook.Close(False)
            If excelApp IsNot Nothing Then excelApp.Quit()

            If workSheet IsNot Nothing Then Marshal.ReleaseComObject(workSheet)
            If workBook IsNot Nothing Then Marshal.ReleaseComObject(workBook)
            If excelApp IsNot Nothing Then Marshal.ReleaseComObject(excelApp)

            workSheet = Nothing
            workBook = Nothing
            excelApp = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()

            Cursor.Current = Cursors.Default

        End Try

        Cursor.Current = Cursors.Default
    End Sub


    Private Sub ShowTopMostMessageBox(message As String, title As String, icon As MessageBoxIcon)
        MessageBox.Show(message, title, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub
End Class
