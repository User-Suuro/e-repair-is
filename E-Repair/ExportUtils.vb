Imports System.Runtime.InteropServices

Public Class ExportUtils
    Public Sub ExportDataTableToExcel(dataTable As DataTable, columnHeaderMapping As Dictionary(Of String, String))
        Dim excelApp As Object = Nothing
        Dim workBook As Object = Nothing
        Dim workSheet As Object = Nothing

        Try
            Cursor.Current = Cursors.WaitCursor

            excelApp = CreateObject("Excel.Application")
            excelApp.Visible = True
            workBook = excelApp.Workbooks.Add
            workSheet = workBook.Sheets(1)

            ' cols
            For i As Integer = 0 To dataTable.Columns.Count - 1
                Dim originalColumnName As String = dataTable.Columns(i).ColumnName
                Dim formalColumnName As String = If(columnHeaderMapping.ContainsKey(originalColumnName), columnHeaderMapping(originalColumnName), originalColumnName)
                workSheet.Cells(1, i + 1).Value = formalColumnName
            Next

            ' Add data rows to Excel
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1

                    Dim originalColumnName As String = dataTable.Columns(j).ColumnName
                    workSheet.Cells(i + 2, j + 1).Value = dataTable.Rows(i)(j)

                    ' format date time
                    If dataTable.Columns(j).DataType Is GetType(DateTime) Then
                        workSheet.Cells(i + 2, j + 1).NumberFormat = "dd/mm/yyyy"
                    End If
                Next

                workSheet.Rows(i + 2).EntireRow.AutoFit()
            Next

            workSheet.Columns.AutoFit()
            For i As Integer = 1 To workSheet.Columns.Count
                workSheet.Columns(i).Style.WrapText = True
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
