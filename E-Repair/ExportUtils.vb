Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Reporting.WinForms

Public Class ExportUtils


    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper

    Public Function ExportDataTableToExcel(dataTable As DataTable, title As String, columnHeaderMapping As Dictionary(Of String, String)) As Boolean
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

            Dim savePath As String = GetSaveFilePath($"{title}.xlsx", "Excel Files|*.xlsx")

            If Not String.IsNullOrEmpty(savePath) Then
                workBook.SaveAs(savePath)
                MsgBox($"Successfully saved in {savePath}")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " - Export Error")
            Return False
        Finally
            If excelApp IsNot Nothing Then excelApp.Interactive = True

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
        Return True
    End Function

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

    ' BY ROW MODE ( e.g receipt )

    Public Function ExportDataTableToExcel(dataTable As DataTable, columnHeaderMapping As Dictionary(Of String, String), title As String) As Boolean
        If dataTable.Rows.Count = 0 Then Return False ' No data to export.

        Try

            Dim excelApp = CreateObject("Excel.Application")
            Dim workbook = excelApp.Workbooks.Add
            Dim worksheet = workbook.Sheets(1)

            PopulateHeader(worksheet, title)
            PopulateDetails(worksheet, dataTable, columnHeaderMapping)

            worksheet.Columns().AutoFit()

            Dim savePath As String = GetSaveFilePath($"{title}.xlsx", "Excel Files|*.xlsx")
            If Not String.IsNullOrEmpty(savePath) Then
                workbook.SaveAs(savePath)
                MsgBox($"Successfully saved in {savePath}")
                dbHelper.Logs($"Generated {title} Excel Report", Current.id)
            End If

            workbook.Close()
            excelApp.Quit()
            Return True
        Catch ex As Exception
            MsgBox($"Error exporting report: {ex.Message}")
            Return False
        End Try
    End Function

    Private Sub PopulateHeader(worksheet As Object, title As String)
        worksheet.Cells("A1:B1").Merge = True
        worksheet.Cells(1, 1).Value = title
        worksheet.Cells(1, 1).Font.Bold = True
        worksheet.Cells(1, 1).Font.Size = 16
    End Sub

    Private Sub PopulateDetails(worksheet As Object, dataTable As DataTable, columnHeaderMapping As Dictionary(Of String, String))
        Dim currentRow As Integer = 2

        ' Add Headers
        Dim columnIndex As Integer = 1
        For Each columnName As String In columnHeaderMapping.Keys
            worksheet.Cells(currentRow, columnIndex).Value = columnHeaderMapping(columnName)
            worksheet.Cells(currentRow, columnIndex).Font.Bold = True
            columnIndex += 1
        Next

        ' Populate Data
        currentRow += 1
        For Each dataRow As DataRow In dataTable.Rows
            columnIndex = 1
            For Each columnName As String In columnHeaderMapping.Keys
                worksheet.Cells(currentRow, columnIndex).Value = dataRow(columnName)
                columnIndex += 1
            Next
            currentRow += 1
        Next
    End Sub


    ' RLDC

    Public Sub LoadToRLDC(reportView As ReportViewer, reportDataSource As ReportDataSource, rldcName As String)
        Dim rptDS As New ReportDataSource
        Dim currentDir As String = System.IO.Directory.GetCurrentDirectory()

        For i As Integer = 1 To 2
            currentDir = System.IO.Directory.GetParent(currentDir).FullName
        Next

        Dim reportsPath As String = currentDir & "\Reports\" & rldcName & ".rdlc"

        Try
            If Not File.Exists(reportsPath) Then
                Throw New FileNotFoundException($"RDLC not found: {reportsPath}")
            End If

            With reportView.LocalReport
                .ReportPath = reportsPath
                .DataSources.Clear()
                .DataSources.Add(reportDataSource)
            End With

            Dim pageSettings As New System.Drawing.Printing.PageSettings()

            With pageSettings
                .PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)
                .Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
                .Landscape = False
            End With

            With reportView
                .SetPageSettings(pageSettings)
                .ZoomMode = ZoomMode.PageWidth
                .RefreshReport()
            End With

        Catch ex As FileNotFoundException
            MsgBox($"File Error: {ex.Message}", MsgBoxStyle.Critical, "Error")
        Catch ex As ArgumentNullException
            MsgBox($"Data Source Error: {ex.Message}", MsgBoxStyle.Critical, "Error")
        Catch ex As Exception
            MsgBox($"An unexpected error occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



End Class
