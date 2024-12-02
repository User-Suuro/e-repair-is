Imports System.Runtime.InteropServices
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer

Public Class ExportUtils
    Public Sub ExportDataTableToExcel(dataTable As DataTable, columnHeaderMapping As Dictionary(Of String, String))
        Dim excelApp As Object = Nothing
        Dim workBook As Object = Nothing
        Dim workSheet As Object = Nothing

        Try
            Cursor.Current = Cursors.WaitCursor

            ' Initialize Excel application
            excelApp = CreateObject("Excel.Application")
            excelApp.Interactive = False

            workBook = excelApp.Workbooks.Add
            workSheet = workBook.Sheets(1)

            Dim headers(dataTable.Columns.Count - 1) As String
            For i As Integer = 0 To dataTable.Columns.Count - 1
                Dim originalColumnName As String = dataTable.Columns(i).ColumnName
                headers(i) = If(columnHeaderMapping.ContainsKey(originalColumnName), columnHeaderMapping(originalColumnName), originalColumnName)
            Next

            Dim headerRange As Object = workSheet.Range(workSheet.Cells(1, 1), workSheet.Cells(1, dataTable.Columns.Count))
            headerRange.Value = headers

            ' Prepare data array
            Dim dataArray(dataTable.Rows.Count - 1, dataTable.Columns.Count - 1) As Object
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    dataArray(i, j) = dataTable.Rows(i)(j)
                Next
            Next

            ' Write data to Excel in bulk
            Dim dataRange As Object = workSheet.Range(workSheet.Cells(2, 1), workSheet.Cells(dataTable.Rows.Count + 1, dataTable.Columns.Count))
            dataRange.Value = dataArray

            ' Apply formatting (e.g., date/time, autofit)
            For j As Integer = 0 To dataTable.Columns.Count - 1
                If dataTable.Columns(j).DataType Is GetType(DateTime) Then
                    workSheet.Columns(j + 1).NumberFormat = "dd/mm/yyyy"
                End If
            Next

            workSheet.Rows.AutoFit()
            workSheet.Columns.AutoFit()
            workSheet.Rows(1 & ":" & (dataTable.Rows.Count + 1)).EntireRow.AutoFit()
            ' Save to file
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files|*.xlsx"
                saveFileDialog.Title = "Save Excel File"
                saveFileDialog.FileName = "EmployeeData.xlsx"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim savePath As String = saveFileDialog.FileName
                    workBook.SaveAs(savePath)
                    MsgBox("Data exported successfully to " & savePath, "Success", MessageBoxIcon.Information)
                Else
                    MsgBox("Export cancelled.", "Cancelled", MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error during export: " & ex.Message, "Export Error", MessageBoxIcon.Error)
        Finally
            ' Re-enable user interaction
            If excelApp IsNot Nothing Then excelApp.Interactive = True

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



    ' Function to open SaveFileDialog
    Public Function GetSaveFilePath(defaultFileName As String, filter As String) As String
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = filter
            saveFileDialog.Title = "Save File"
            saveFileDialog.FileName = defaultFileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Return saveFileDialog.FileName
            Else
                Return String.Empty ' Return empty string if canceled
            End If
        End Using
    End Function


End Class
