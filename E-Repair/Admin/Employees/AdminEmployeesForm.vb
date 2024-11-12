Imports System.Runtime.ExceptionServices
Imports System.Security.Cryptography
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Mysqlx.XDevAPI.Common
Imports ZstdSharp.Unsafe

Public Class AdminEmployeesForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    ' SCHEMA

    Dim employeeID As Integer
    Dim empFirstName As String
    Dim empMiddleName As String
    Dim empLastName As String
    Dim empSex As String
    Dim empBirthDate As Date
    Dim empCivilStatus As String
    Dim empAddress As String
    Dim empContactNumber As String
    Dim empContractStatus As String
    Dim empDateHired As Date
    Dim empSSS As String
    Dim empTIN As String
    Dim empPAGIBIG As String

    Dim empjobType As String

    Dim adminTotalEmployeeAdded As Integer
    Dim adminPosition As String

    Dim utilityPersonnelDestination As String

    Dim cashierTotalCustomersHandled As Integer

    Dim techNumberPendingServices As Integer
    Dim techNumberFinishedServices As Integer

    Dim empProfilePath As String
    Dim empEmail As String
    Dim empPassword As String
    Dim empIdAddedBy As Integer
    Dim empArchived As Boolean

    Dim empLastAccessed As String ' DATETIME
    Dim empDateAdded As String ' DATETIME

    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        EmpDGV.ClearSelection()
    End Sub

    Private Function CheckIfInvalidValues() As Boolean
        If EmpDGV.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return True
        End If

        If EmpDGV.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return True
        End If

        If EmpDGV.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return True
        End If

        Try
            employeeID = EmpDGV.CurrentRow.Cells("EMPLOYEE_ID").Value
            empFirstName = EmpDGV.CurrentRow.Cells("FIRST_NAME").Value
            empMiddleName = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("MIDDLE_NAME").Value)
            empLastName = EmpDGV.CurrentRow.Cells("LAST_NAME").Value

            empSex = EmpDGV.CurrentRow.Cells("SEX").Value
            empBirthDate = EmpDGV.CurrentRow.Cells("BIRTHDATE").Value
            empCivilStatus = EmpDGV.CurrentRow.Cells("CIVIL_STATUS").Value
            empAddress = EmpDGV.CurrentRow.Cells("ADDRESS").Value

            empContactNumber = EmpDGV.CurrentRow.Cells("CONTACT").Value
            empContractStatus = EmpDGV.CurrentRow.Cells("EMPLOYMENT_STATUS").Value
            empDateHired = Date.Parse(EmpDGV.CurrentRow.Cells("DATE_HIRED").Value)

            empSSS = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("SSS_NUMBER").Value)
            empPAGIBIG = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("PAGIBIG_NUMBER").Value)
            empTIN = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("TIN_NUMBER").Value)

            empjobType = EmpDGV.CurrentRow.Cells("JOB_TYPE").Value

            adminTotalEmployeeAdded = dbHelper.IntNullCheck(EmpDGV.CurrentRow.Cells("TOTAL_EMPLOYEE_ADDED").Value)
            adminPosition = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("ADMIN_POSITION").Value)

            utilityPersonnelDestination = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("PERSONNEL_DESTINATION").Value)

            cashierTotalCustomersHandled = dbHelper.IntNullCheck(EmpDGV.CurrentRow.Cells("NO_CUSTOMERS_HANDLED").Value)

            techNumberPendingServices = dbHelper.IntNullCheck(EmpDGV.CurrentRow.Cells("NO_PENDING_SERVICES").Value)
            techNumberFinishedServices = dbHelper.IntNullCheck(EmpDGV.CurrentRow.Cells("NO_FINISHED_SERVICES").Value)

            empProfilePath = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("IMG_PATH").Value)

            empEmail = EmpDGV.CurrentRow.Cells("EMAIL").Value
            empPassword = EmpDGV.CurrentRow.Cells("PASSWORD").Value
            empIdAddedBy = EmpDGV.CurrentRow.Cells("ADDED_BY").Value
            empArchived = EmpDGV.CurrentRow.Cells("ARCHIVED").Value

            empLastAccessed = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("LAST_ACCESSED").Value)
            empDateAdded = EmpDGV.CurrentRow.Cells("DATE_ADDED").Value
        Catch ex As Exception
            MsgBox("Failed to initialized employee values: " + ex.Message)
        End Try
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        Dim employeeViewModal As New AdminEmployeeViewModal

        If CheckIfInvalidValues() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            ' LOAD FORM
            employeeViewModal.Owner = formModal
            employeeViewModal.StartPosition = FormStartPosition.CenterScreen

            ' LOAD DATA IN TEXTBOXES

            employeeViewModal.EmployeeIDTextBox.Text = employeeID

            employeeViewModal.FirstNameTextBox.Text = empFirstName
            employeeViewModal.MiddleNameTextBox.Text = empMiddleName
            employeeViewModal.LastNameTextBox.Text = empLastName
            employeeViewModal.SexTextBox.Text = empSex
            employeeViewModal.BirthDateTextBox.Text = empBirthDate
            employeeViewModal.CivilStatusTextBox.Text = empCivilStatus
            employeeViewModal.AddressTextBox.Text = empAddress

            employeeViewModal.ContactNumberTextBox.Text = empContactNumber
            employeeViewModal.ContractStatusTextBox.Text = empContractStatus
            employeeViewModal.DateHiredTextBox.Text = empDateHired

            employeeViewModal.JobTypeTextBox.Text = empjobType

            employeeViewModal.SSSTextBox.Text = empSSS
            employeeViewModal.PagIbigTextBox.Text = empPAGIBIG
            employeeViewModal.TINTextBox.Text = empTIN

            employeeViewModal.ProfilePathTextBox.Text = empProfilePath

            Try
                If (empProfilePath <> "") Then
                    employeeViewModal.ProfileCirclePictureBox.Image = Image.FromFile(empProfilePath)
                End If
            Catch ex As Exception
                employeeViewModal.ProfileCirclePictureBox.Image = Image.FromFile(constants.getNoImgPath)
            End Try


            employeeViewModal.EmailTextBox.Text = empEmail

            If (empPassword <> "") Then
                employeeViewModal.PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)
            Else
                employeeViewModal.PasswordTextBox.Text = "N/A"
            End If

            employeeViewModal.ArchiveStatusTextBox.Text = empArchived

            employeeViewModal.LastAccessedTextBox.Text = empLastAccessed

            employeeViewModal.AddedByTextBox.Text = empIdAddedBy

            employeeViewModal.PositionTextBox.Text = adminPosition
            employeeViewModal.EmployeeAddedTextBox.Text = adminTotalEmployeeAdded

            employeeViewModal.DevicesRepairedTextBox.Text = techNumberFinishedServices
            employeeViewModal.NumberJobsAssignedTextBox.Text = techNumberPendingServices

            employeeViewModal.CustomersHandledTextBox.Text = cashierTotalCustomersHandled

            employeeViewModal.AssignedLocationTextBox.Text = utilityPersonnelDestination

            employeeViewModal.DateAddedTextBox.Text = empDateAdded

            ' DISPLAY FORM
            employeeViewModal.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeViewModal.Close()
        Finally
            employeeViewModal.Dispose()
            formModal.Dispose()
        End Try
    End Sub

    ' ADD
    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        Dim employeeAddModal As New AdminEmployeeAddModal

        Try
            formModal = formUtils.CreateBgFormModal()
            employeeAddModal.Owner = formModal
            employeeAddModal.StartPosition = FormStartPosition.CenterScreen
            AdminEmployeeAddModal.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeAddModal.Close()
        Finally
            AdminEmployeeAddModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub


    ' EDIT
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click

        If CheckIfInvalidValues() Then Exit Sub

        Dim employeeAddModal As New AdminEmployeeAddModal

        Try
            formModal = formUtils.CreateBgFormModal()

            ' LOAD FORM
            employeeAddModal.Owner = formModal
            employeeAddModal.StartPosition = FormStartPosition.CenterScreen
            employeeAddModal.editMode = True
            employeeAddModal.EmployeeModalGroupBox.Text = "Edit Employee Details"


            employeeAddModal.selectedEmployeeId = employeeID

            employeeAddModal.FirstNameTextBox.Text = empFirstName
            employeeAddModal.MiddleNameTextBox.Text = empMiddleName
            employeeAddModal.LastNameTextBox.Text = empLastName

            Dim selectedSexIndex = formUtils.FindComboBoxItemByText(employeeAddModal.SexComboBox, empSex)
            employeeAddModal.SexComboBox.SelectedIndex = selectedSexIndex

            employeeAddModal.BirthdateDateTimePicker.Value = DateTime.Parse(empBirthDate)

            Dim selectedCivilStatusIndex = formUtils.FindComboBoxItemByText(employeeAddModal.CivilStatusComboBox, empCivilStatus)
            employeeAddModal.CivilStatusComboBox.SelectedIndex = selectedCivilStatusIndex

            employeeAddModal.AddressTextBox.Text = empAddress

            employeeAddModal.ContactNumberTextBox.Text = empContactNumber

            Dim selectedContractStatusIndex = formUtils.FindComboBoxItemByText(employeeAddModal.ContractStatusComboBox, empContractStatus)
            employeeAddModal.ContractStatusComboBox.SelectedIndex = selectedContractStatusIndex

            employeeAddModal.DateHiredDateTimePicker.Value = DateTime.Parse(empDateHired)

            Dim selectedJobTypeIndex = formUtils.FindComboBoxItemByText(employeeAddModal.JobTypeComboBox, empjobType)
            employeeAddModal.JobTypeComboBox.SelectedIndex = selectedJobTypeIndex

            If employeeAddModal.JobTypeComboBox.Text = constants.getAdminString Then

                employeeAddModal.PositionComboBox.SelectedIndex = formUtils.FindComboBoxItemByText(employeeAddModal.PositionComboBox, adminPosition)

            ElseIf employeeAddModal.JobTypeComboBox.Text = constants.getTechnicianString Then


            ElseIf employeeAddModal.JobTypeComboBox.Text = constants.getCashierString Then


            ElseIf employeeAddModal.JobTypeComboBox.Text = constants.getUtilityPersonnelString Then


                employeeAddModal.AssignedLocationTextBox.Text = utilityPersonnelDestination

            End If

            employeeAddModal.SSSTextBox.Text = empSSS
            employeeAddModal.PagIbigTextBox.Text = empPAGIBIG
            employeeAddModal.TINTextBox.Text = empTIN

            Dim profileImagePath As String = empProfilePath

            If (profileImagePath <> "N/A") Then
                employeeAddModal.ProfileCirclePictureBox.Image = Image.FromFile(profileImagePath)
            End If

            employeeAddModal.profileImgPath = profileImagePath

            employeeAddModal.EmailTextBox.Text = empEmail

            employeeAddModal.PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)
            employeeAddModal.ConfirmPasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)

            employeeAddModal.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeAddModal.Close()
        Finally
            AdminEmployeeAddModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    'ARCHIVE
    Private Sub BtnArchive_Click(sender As Object, e As EventArgs) Handles ArchiveEmployeeBtn.Click

        If CheckIfInvalidValues() Then Exit Sub

        Try
            If (GlobalSession.CurrentSession.EmployeeID = employeeID) Then
                MsgBox("You cannot archive an active user!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("There is no current active user!")
        End Try


        Try
            If (empArchived = False AndAlso formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this Employee?")) Then

                Dim updatedValues As New Dictionary(Of String, Object) From {
                                {"archived", True},
                                {"date_archived", DateTime.Now}
                            }

                Dim result As Boolean = dbHelper.UpdateRecord("employees", "employee_id", employeeID, updatedValues)

                LoadDataToDGV()

                If (result) Then
                    MsgBox("Successfull Archived")
                Else
                    MsgBox("Something went wrong")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If CheckIfInvalidValues() Then Exit Sub

        If empArchived = False Then
            MsgBox("Please archive the given row first")
            Exit Sub
        End If

        If formUtils.ShowMessageBoxResult("Confirmation", "Are you Sure you want to delete this employee?") Then
            Dim result As Boolean = dbHelper.DeleteRowById("employees", "employee_id", employeeID)

            If (result) Then
                MsgBox("Successfully Deleted")
            Else
                MsgBox("Something went wrong")
            End If
        End If

        LoadDataToDGV()
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged

        LoadDataToDGV()

        If ShowArchiveCheckBox.Checked Then
            DeleteEmployeeBtn.Visible = True
            ArchiveEmployeeBtn.Visible = False
            EmpDGV.Columns("DATE_ARCHIVED").Visible = True
        Else
            DeleteEmployeeBtn.Visible = False
            ArchiveEmployeeBtn.Visible = True
            EmpDGV.Columns("DATE_ARCHIVED").Visible = False
        End If
    End Sub

    ' LOAD FORM


    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim employeesTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            employeesTable = dbHelper.GetAllRowsFromTable("employees", True, True)
        Else
            employeesTable = dbHelper.GetAllRowsFromTable("employees", False)
        End If

        Dim searchBy As String = "firstname"

        If SearchComboBox.SelectedIndex = 0 Then
            searchBy = "firstname"
        ElseIf SearchComboBox.SelectedIndex = 1 Then
            searchBy = "middlename"
        ElseIf SearchComboBox.SelectedIndex = 2 Then
            searchBy = "lastname"
        ElseIf SearchComboBox.SelectedIndex = 3 Then
            searchBy = "date_hired"
        ElseIf SearchComboBox.SelectedIndex = 4 Then
            searchBy = "email"
        ElseIf SearchComboBox.SelectedIndex = 5 Then
            searchBy = "last_accessed"
        ElseIf SearchComboBox.SelectedIndex = 6 Then
            searchBy = "date_added"
        End If

        ' Search
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            employeesTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            employeesTable.DefaultView.RowFilter = ""
        End If

        EmpDGV.AutoGenerateColumns = True
        EmpDGV.DataSource = employeesTable

        FormatDataGridViewRows()
    End Sub

    Private Sub FormatDataGridViewRows()
        Try
            For Each row As DataGridViewRow In EmpDGV.Rows
                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

                Try
                    If row.Cells("EMPLOYEE_ID").Value = GlobalSession.CurrentSession.EmployeeID Then
                        row.DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Catch ex As Exception

                End Try


            Next
        Catch ex As Exception
            MsgBox("Unable to style the Employee DGB with no current id session!")
        End Try
    End Sub


End Class