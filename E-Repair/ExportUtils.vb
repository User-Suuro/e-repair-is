Imports System.Runtime.InteropServices

Public Class ExportUtils
    Private Sub ExportDataTableToExcel(dataTable As DataTable)
        Dim excelApp As Object = Nothing
        Dim workBook As Object = Nothing
        Dim workSheet As Object = Nothing



        Try
            excelApp = CreateObject("Excel.Application")
            excelApp.Visible = True
            workBook = excelApp.Workbooks.Add
            workSheet = workBook.Sheets(1)

            ' Define a dictionary to map original column names to formal names
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
                {"employee_id", "Employee ID"},
                {"firstname", "First Name"},
                {"middlename", "Middle Name"},
                {"lastname", "Last Name"},
                {"sex", "Sex"},
                {"birthdate", "Birthdate"},
                {"civilstatus", "Civil Status"},
                {"address", "Address"},
                {"contact_number", "Contact Number"},
                {"employment_status", "Employment Status"},
                {"date_hired", "Date Hired"},
                {"sss_no", "SSS No."},
                {"pagibig_no", "Pag-ibig No."},
                {"tin_no", "Tin No."},
                {"profile_path", "Profile Path"},
                {"email", "Email"},
                {"password", "Password"},
                {"archived", "Archived"},
                {"archived_by", "Archived by"},
                {"archived_by_id", "Archived by ID"},
                {"date_archived", "Date Archived"},
                {"added_by", "Added By"},
                {"added_by_id", "Added by ID"},
                {"date_added", "Date Added"},
                {"last_accessed", "Last Accessed"},
                {"job_type", "Job Type"},
                {"admin_position", "Admin Position"},
                {"personnel_destination", "Personnel Destination"}
            }

            ' Add formal column headers to Excel, skipping the "password" column
            For i As Integer = 0 To dataTable.Columns.Count - 1
                Dim originalColumnName As String = dataTable.Columns(i).ColumnName

                ' Skip the "password" column from export
                If originalColumnName.ToLower() = "password" Then
                    Continue For ' Skip the password column and move to the next column
                End If

                ' Check if the column has a formal name in the mapping dictionary
                Dim formalColumnName As String = If(columnHeaderMapping.ContainsKey(originalColumnName), columnHeaderMapping(originalColumnName), originalColumnName)
                workSheet.Cells(1, i + 1).Value = formalColumnName
            Next

            ' Add data rows to Excel
            For i As Integer = 0 To dataTable.Rows.Count - 1
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    Dim originalColumnName As String = dataTable.Columns(j).ColumnName

                    ' Skip the "password" column's data
                    If originalColumnName.ToLower() = "password" Then
                        Continue For ' Skip the "password" column data
                    End If

                    ' Add the data to the cell
                    workSheet.Cells(i + 2, j + 1).Value = dataTable.Rows(i)(j)

                    ' Format the column as Date if the data type is DateTime
                    If dataTable.Columns(j).DataType Is GetType(DateTime) Then
                        workSheet.Cells(i + 2, j + 1).NumberFormat = "dd/mm/yyyy"
                    End If
                Next

                ' Auto-adjust row height for each row (to fit tall content)
                workSheet.Rows(i + 2).EntireRow.AutoFit()
            Next

            ' Auto-adjust column widths for all columns (to fit all data)
            workSheet.Columns.AutoFit()

            ' Wrap text for all columns to handle long content inside cells
            For i As Integer = 1 To workSheet.Columns.Count
                workSheet.Columns(i).Style.WrapText = True
            Next



            Dim totalEmployeesRow As Integer = dataTable.Rows.Count + 2
            workSheet.Cells(totalEmployeesRow, 1).Value = "Total Employees"
            workSheet.Cells(totalEmployeesRow, 2).Value = dataTable.Rows.Count
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
End Class
