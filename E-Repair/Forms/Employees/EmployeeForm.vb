Imports System.ComponentModel
Imports LibVLCSharp.[Shared]
Imports System.Runtime.InteropServices

Public Class EmployeeForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form
    Dim empConst As New EmployeesDBConstants

    ' SCHEMA
    Private employeeID As Integer = -1
    Private empArchived As Boolean = False
    Private empPosition As String = ""

    Public Property selectedEmpID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property techOnly As Boolean = False

    Private empDT As DataTable = Nothing

    Private finishedLoad As Boolean = False


    ' RESTRICT ACTIONS
    Private Function isRestricted() As Boolean
        If empPosition = constants.getSuperAdminString AndAlso empPosition = constants.getAdminString Then
            MsgBox("Restricted Action")
            Return False
        End If

        Return True
    End Function

    ' INIT DATA
    Private Function InitData() As Boolean

        If Not formUtils.dgvValChecker(EmpDGV) Then Return False

        With EmpDGV.CurrentRow
            employeeID = .Cells(empConst.empIDStr).Value
            empArchived = .Cells(empConst.empArchStr).Value
            empPosition = .Cells(empConst.empJobPosStr).Value
        End With

        Return True
    End Function


    Private Function hasPendingWork() As Boolean
        If empPosition = constants.getTechnicianString Then
            Dim pendingWork As Integer = formUtils.getTechStatsNumbers(constants.getPendingString, employeeID)

            If pendingWork <> 0 Then
                MsgBox("You cannot archive employee that has " & pendingWork & " pending work")
                Return False
            End If

            Return True
        End If

        Return True
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeViewModal()
            modal.selectedID = id
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )
    End Sub

    ' ADD
    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
            modal.selectedID = id
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
    End Sub

    ' EDIT
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click

        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    'ARCHIVE
    Private Sub BtnArchive_Click(sender As Object, e As EventArgs) Handles ArchiveEmployeeBtn.Click
        If Not InitData() Then Exit Sub
        If Not hasPendingWork() Then Exit Sub
        formUtils.ArchiveRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If Not InitData() Or Not hasPendingWork() Then Exit Sub
        formUtils.DeleteRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID)
        RefreshForArchive()
    End Sub



    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SEARCH CMB
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        RefreshForArchive()
    End Sub

    Private Sub RefreshForArchive()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(EmpDGV, ShowArchiveCheckBox, DeleteEmployeeBtn, ArchiveEmployeeBtn, EditEmployeeBtn, AddEmployeeBtn)
    End Sub

    ' LOAD FORM
    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        finishedLoad = True
        LoadDataToDGV()
        EmpDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        If Not finishedLoad Then Exit Sub

        With empConst

            Dim colValues As New List(Of String) From {
              .empIDStr, ' exclude
              .empArchByStr,  ' exclude
              .empArchDateStr,  ' exclude
              .empArchStr,  ' exclude
              .empFirstStr,
              .empMidStr,
              .empLastStr,
              .empHiredStr,
              .empEmailStr,
              .empLastAccessedStr,
              .empAddDateStr,
              .empJobPosStr
            }

            Cursor = Cursors.WaitCursor

            If Not techOnly Then
                empDT = dbHelper.GetAllByCol(colValues, empConst.empTableStr)
            Else
                empDT = dbHelper.GetRowByColValue(colValues, empConst.empTableStr, empConst.empJobPosStr, constants.getTechnicianString)
            End If

            ' exlucde to search
            colValues.Remove(.empIDStr)
            colValues.Remove(.empArchStr)
            colValues.Remove(.empArchDateStr)
            colValues.Remove(.empArchByStr)

            formUtils.LoadToDGV(EmpDGV, empDT, searchTerm, colValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)

            Cursor = Cursors.Default
        End With
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' BTN SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Or Not selectMode Then Exit Sub

        selectedEmpID = employeeID

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub

    'REPORT

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(EmpDGV)

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
            EmpDGV.DataSource = empDT
        Catch ex As Exception
            ShowTopMostMessageBox("Error loading data: " & ex.Message, "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Click event to export DataGridView data to Excel
    Private Sub ExportToExcelBtn_Click(sender As Object, e As EventArgs)
        If EmpDGV.Rows.Count > 0 Then
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

End Class