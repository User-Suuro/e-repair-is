﻿Imports System.Runtime.ExceptionServices
Imports System.Security.Cryptography
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Mysqlx.XDevAPI.Common
Imports ZstdSharp.Unsafe

Public Class AdminEmployeeForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    ' SCHEMA

    Dim employeeID As Integer = -1
    Dim empFirstName As String = ""
    Dim empMiddleName As String = ""
    Dim empLastName As String = ""
    Dim empSex As String = ""
    Dim empBirthDate As String = ""

    Dim empCivilStatus As String = ""
    Dim empAddress As String = ""
    Dim empContactNumber As String = ""
    Dim empContractStatus As String = ""

    Dim empDateHired As String = ""
    Dim empSSS As String = ""
    Dim empTIN As String = ""
    Dim empPAGIBIG As String = ""

    Dim empjobType As String = ""

    Dim adminTotalEmployeeAdded As Integer = -1
    Dim adminPosition As String = ""

    Dim utilityPersonnelDestination As String = ""

    ' to do 
    Dim cashierTotalCustomersHandled As Integer = -1

    ' to do
    Dim techNumberPendingServices As Integer = -1
    Dim techNumberFinishedServices As Integer = -1

    Dim empProfilePath As String = ""
    Dim empEmail As String = ""
    Dim empPassword As String = ""
    Dim empIdAddedBy As Integer = -1
    Dim empArchived As Boolean = False

    Dim empLastAccessed As String = "" ' DATETIME
    Dim empDateAdded As String = "" ' DATETIME

    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        EmpDGV.ClearSelection()
    End Sub

    Private Function InitData() As Boolean
        If EmpDGV.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return False
        End If

        If EmpDGV.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return False
        End If

        If EmpDGV.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return False
        End If

        ' INITIALIZE VALUES

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
            empDateHired = EmpDGV.CurrentRow.Cells("DATE_HIRED").Value

            empSSS = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("SSS_NUMBER").Value)
            empPAGIBIG = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("PAGIBIG_NUMBER").Value)
            empTIN = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("TIN_NUMBER").Value)

            empjobType = EmpDGV.CurrentRow.Cells("JOB_TYPE").Value

            adminPosition = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("ADMIN_POSITION").Value)
            utilityPersonnelDestination = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("PERSONNEL_DESTINATION").Value)

            empProfilePath = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("IMG_PATH").Value)

            adminTotalEmployeeAdded = dbHelper.GetRowByValue("employees", "added_by", employeeID).Rows.Count

            ' to do: cashier values
            ' cashierTotalCustomersHandled =


            ' to do: tech values
            ' techNumberFinishedServices =
            ' techNumberPendingServices =

            empEmail = EmpDGV.CurrentRow.Cells("EMAIL").Value
            empPassword = EmpDGV.CurrentRow.Cells("PASSWORD").Value
            empIdAddedBy = EmpDGV.CurrentRow.Cells("ADDED_BY").Value
            empArchived = EmpDGV.CurrentRow.Cells("ARCHIVED").Value

            empLastAccessed = dbHelper.StrNullCheck(EmpDGV.CurrentRow.Cells("LAST_ACCESSED").Value)
            empDateAdded = EmpDGV.CurrentRow.Cells("DATE_ADDED").Value

        Catch ex As Exception
            MsgBox("Failed to initialized employee values: " + ex.Message)
            Return False
        End Try

        Return True
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        Dim employeeViewModal As New AdminEmployeeViewModal

        If Not InitData() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            With employeeViewModal
                ' LOAD FORM
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen

                ' BASIC INFO

                .EmployeeIDTextBox.Text = employeeID
                .FirstNameTextBox.Text = empFirstName
                .MiddleNameTextBox.Text = empMiddleName
                .LastNameTextBox.Text = empLastName
                .SexTextBox.Text = empSex
                .BirthDateTextBox.Text = empBirthDate
                .CivilStatusTextBox.Text = empCivilStatus
                .AddressTextBox.Text = empAddress
                .ContactNumberTextBox.Text = empContactNumber

                ' JOB INFO
                .ContractStatusTextBox.Text = empContractStatus
                .DateHiredTextBox.Text = empDateHired
                .JobTypeTextBox.Text = empjobType

                .SSSTextBox.Text = empSSS
                .PagIbigTextBox.Text = empPAGIBIG
                .TINTextBox.Text = empTIN
                .ProfilePathTextBox.Text = empProfilePath

                ' PROFILE
                Try
                    If (empProfilePath <> "") Then
                        .ProfileCirclePictureBox.Image = Image.FromFile(empProfilePath)
                    End If
                Catch ex As Exception

                End Try

                .EmailTextBox.Text = empEmail

                If (empPassword <> "") Then
                    .PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)
                Else
                    .PasswordTextBox.Text = "N/A"
                End If

                ' ARCHIVE INFO

                .ArchiveStatusTextBox.Text = empArchived
                .LastAccessedTextBox.Text = empLastAccessed
                .AddedByTextBox.Text = empIdAddedBy

                ' JOB INFO

                ' ADMIN
                .PositionTextBox.Text = adminPosition
                .EmployeeAddedTextBox.Text = adminTotalEmployeeAdded

                ' TECH
                .DevicesRepairedTextBox.Text = techNumberFinishedServices
                .NumberJobsAssignedTextBox.Text = techNumberPendingServices

                ' CASHIER
                .CustomersHandledTextBox.Text = cashierTotalCustomersHandled

                ' PERSONNEL
                .AssignedLocationTextBox.Text = utilityPersonnelDestination

                .DateAddedTextBox.Text = empDateAdded

                ' DISPLAY FORM
                .ShowDialog()
            End With


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
        Dim employeeAddModal As New AdminEmployeeAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With employeeAddModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

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

        If Not InitData() Then Exit Sub


        Dim employeeAddModal As New AdminEmployeeAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()

            With employeeAddModal
                ' LOAD FORM
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .editMode = True
                .EmployeeModalGroupBox.Text = "Edit Employee Details"

                ' BASIC INFO

                .selectedEmployeeId = employeeID
                .FirstNameTextBox.Text = empFirstName
                .MiddleNameTextBox.Text = empMiddleName
                .LastNameTextBox.Text = empLastName
                .SexComboBox.SelectedIndex = formUtils.FindComboBoxItemByText(.SexComboBox, empSex)

                .BirthdateDateTimePicker.Value = DateTime.Parse(empBirthDate)
                .CivilStatusComboBox.SelectedIndex = formUtils.FindComboBoxItemByText(.CivilStatusComboBox, empCivilStatus)
                .AddressTextBox.Text = empAddress
                .ContactNumberTextBox.Text = empContactNumber

                ' CONTRACT STATUS CMB
                Dim contractStatusBoxIndex = formUtils.FindComboBoxItemByText(.ContractStatusComboBox, empContractStatus)
                If contractStatusBoxIndex = -1 Then
                    .ContractStatusComboBox.SelectedItem = "Others"
                    .IfOthersTxtBox.Text = empContractStatus
                Else
                    .ContractStatusComboBox.SelectedIndex = contractStatusBoxIndex
                End If

                ' JOBS

                .DateHiredDateTimePicker.Value = DateTime.Parse(empDateHired)
                .JobTypeComboBox.SelectedIndex = formUtils.FindComboBoxItemByText(.JobTypeComboBox, empjobType)

                If .JobTypeComboBox.Text = constants.getAdminString Then
                    .PositionComboBox.SelectedIndex = formUtils.FindComboBoxItemByText(.PositionComboBox, adminPosition)
                ElseIf .JobTypeComboBox.Text = constants.getUtilityPersonnelString Then
                    .AssignedLocationTextBox.Text = utilityPersonnelDestination
                End If

                ' JOB INFO 

                .SSSTextBox.Text = empSSS
                .PagIbigTextBox.Text = empPAGIBIG
                .TINTextBox.Text = empTIN


                ' PROFILE
                Dim profileImagePath As String = empProfilePath

                If (profileImagePath <> "N/A") Then
                    .ProfileCirclePictureBox.Image = Image.FromFile(profileImagePath)
                End If

                .profileImgPath = profileImagePath

                ' EMAIL & PASSWORD
                .EmailTextBox.Text = empEmail
                .PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)
                .ConfirmPasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)

                .ShowDialog()
            End With

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

        Dim loggedUser As String

        If Not InitData() Then Exit Sub

        If empArchived Then
            MsgBox("This employee is already archived!")
            Exit Sub
        End If

        Try

            loggedUser = GlobalSession.CurrentSession.EmployeeID

            If (GlobalSession.CurrentSession.EmployeeID = employeeID) Then
                MsgBox("You cannot archive an active user!")
                Exit Sub
            End If

        Catch ex As Exception
            loggedUser = "N/A"
            MsgBox("There is no current active user!")
        End Try

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this Employee?") Then Exit Sub

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", loggedUser},
            {"date_archived", DateTime.Now}
        }

        Try
            dbHelper.UpdateRecord("employees", "employee_id", employeeID, updatedValues)
            MsgBox("Successfull Archived")
            LoadDataToDGV()

        Catch ex As Exception
            MsgBox("Cannot archived the selected employee: " & ex.Message)
        End Try

    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If InitData() Then Exit Sub

        If Not empArchived Then
            MsgBox("Please archive the given row first")
            Exit Sub
        End If

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you Sure you want to delete this employee?") Then Exit Sub

        dbHelper.DeleteRowById("employees", "employee_id", employeeID)

        MsgBox("Successfully Deleted")

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
            EmpDGV.Columns("ARCHIVED_BY").Visible = True
        Else
            DeleteEmployeeBtn.Visible = False
            ArchiveEmployeeBtn.Visible = True
            EmpDGV.Columns("DATE_ARCHIVED").Visible = False
            EmpDGV.Columns("ARCHIVED_BY").Visible = False
        End If
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim employeesTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            employeesTable = dbHelper.GetAllRowsFromTable("employees", True, True)
        Else
            employeesTable = dbHelper.GetAllRowsFromTable("employees", False)
        End If

        Dim searchBy As String = "firstname"

        With SearchComboBox
            If .SelectedIndex = 0 Then
                searchBy = "firstname"
            ElseIf .SelectedIndex = 1 Then
                searchBy = "middlename"
            ElseIf .SelectedIndex = 2 Then
                searchBy = "lastname"
            ElseIf .SelectedIndex = 3 Then
                searchBy = "date_hired"
            ElseIf .SelectedIndex = 4 Then
                searchBy = "email"
            ElseIf .SelectedIndex = 5 Then
                searchBy = "last_accessed"
            ElseIf .SelectedIndex = 6 Then
                searchBy = "date_added"
            End If
        End With


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

            For Each row As DataGridViewRow In EmpDGV.Rows
                If row.Cells("ARCHIVED_BY").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ARCHIVED_BY").Value) Then
                    Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ARCHIVED_BY").Value)

                    If getEmpData.Rows.Count > 0 Then
                        row.Cells("ARCHIVED_BY").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Unable to style the Employee DGV: " & ex.Message)
        End Try
    End Sub


End Class