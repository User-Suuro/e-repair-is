Imports System.Runtime.InteropServices

Public Class EmployeeReportModal

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim empDT As DataTable

    ' Initialize the form and UI components
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(EmpRepDGV)
        ExportToExcelBtn.Text = "Export to Excel"

        ' Bind the Export button event handler
        AddHandler ExportToExcelBtn.Click, AddressOf ExportToExcelBtn_Click

        ' Load data into the DataGridView
        LoadDataToDGV()
    End Sub

    ' Load Data into the DataGridView from DataTable
    Private Sub LoadDataToDGV()
        Try
            Dim query As String = "employees" ' Use your actual SQL query
            empDT = dbHelper.GetAllData(query)
            EmpRepDGV.DataSource = empDT
        Catch ex As Exception
            ShowTopMostMessageBox("Error loading data: " & ex.Message, "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Click event to export DataGridView data to Excel
    Private Sub ExportToExcelBtn_Click(sender As Object, e As EventArgs)
        If EmpRepDGV.Rows.Count > 0 Then
            Try
                ExportDataTableToExcel(empDT)
            Catch ex As Exception
                ShowTopMostMessageBox("Error exporting data: " & ex.Message, "Export Error", MessageBoxIcon.Error)
            End Try
        Else
            ShowTopMostMessageBox("No data to export.", "Warning", MessageBoxIcon.Warning)
        End If
    End Sub

    ' Function to export DataTable to Excel with custom file path
    Private Sub ExportDataTableToExcel(dataTable As DataTable)
        Dim excelApp As Object = Nothing
        Dim workBook As Object = Nothing
        Dim workSheet As Object = Nothing

        Try
            excelApp = CreateObject("Excel.Application")
            excelApp.Visible = True
            workBook = excelApp.Workbooks.Add
            workSheet = workBook.Sheets(1)

            ' Add column headers to Excel
            For i As Integer = 0 To dataTable.Columns.Count - 1
                workSheet.Cells(1, i + 1).Value = dataTable.Columns(i).ColumnName
            Next

            ' Add data rows to Excel
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    workSheet.Cells(i + 2, j + 1).Value = dataTable.Rows(i)(j)

                    ' Format the column as Date if the data type is DateTime
                    If dataTable.Columns(j).DataType Is GetType(DateTime) Then
                        workSheet.Cells(i + 2, j + 1).NumberFormat = "dd/mm/yyyy"
                    End If
                Next
            Next

            ' Add Total Employees row
            Dim totalEmployeesRow As Integer = dataTable.Rows.Count + 2
            workSheet.Cells(totalEmployeesRow, 1).Value = "Total Employees"
            workSheet.Cells(totalEmployeesRow, 2).Value = dataTable.Rows.Count

            ' Auto-fit columns
            workSheet.Columns.AutoFit()

            ' Prompt user for file path (topmost)
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files|*.xlsx"
                saveFileDialog.Title = "Save Excel File"
                saveFileDialog.FileName = "EmployeeData.xlsx"


                Me.TopMost = True
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim savePath As String = saveFileDialog.FileName
                    workBook.SaveAs(savePath)
                    ShowTopMostMessageBox("Data exported successfully to " & savePath, "Success", MessageBoxIcon.Information)
                Else
                    ShowTopMostMessageBox("Export cancelled.", "Cancelled", MessageBoxIcon.Information)
                End If
                Me.TopMost = False
            End Using

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
        End Try
    End Sub


    Private Sub ShowTopMostMessageBox(message As String, title As String, icon As MessageBoxIcon)
        MessageBox.Show(message, title, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

End Class
