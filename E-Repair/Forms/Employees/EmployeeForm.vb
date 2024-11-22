Imports System.IO
Imports System.Runtime.ExceptionServices
Imports System.Security.Cryptography
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Mysqlx.XDevAPI.Common
Imports ZstdSharp.Unsafe

Public Class EmployeeForm
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
    Dim cashierTotalServicesHandled As Integer = -1

    ' to do
    Dim techNumberPendingServices As Integer = -1
    Dim techNumberFinishedServices As Integer = -1
    Dim techNumberOnholdServices As Integer = -1
    Dim techNumberCanceledServices As Integer = -1

    Dim empProfilePath As String = ""
    Dim empEmail As String = ""
    Dim empPassword As String = ""
    Dim empIdAddedBy As Integer = -1

    Dim empArchived As Boolean = False

    Dim empLastAccessed As String = "" ' DATETIME
    Dim empDateAdded As String = "" ' DATETIME

    Public Property selectedEmpID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property selectModeTable As DataTable

    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        EmpDGV.ClearSelection()

        If selectMode Then
            BtnClose.Visible = True
            BtnSelect.Visible = True
            ShowArchiveCheckBox.Visible = False
        Else
            BtnClose.Visible = False
            BtnSelect.Visible = False
            ShowArchiveCheckBox.Visible = True
        End If

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
            With EmpDGV.CurrentRow
                employeeID = .Cells("EMPLOYEE_ID").Value
                empFirstName = .Cells("FIRST_NAME").Value
                empMiddleName = dbHelper.StrNullCheck(.Cells("MIDDLE_NAME").Value)
                empLastName = .Cells("LAST_NAME").Value

                empSex = .Cells("SEX").Value
                empBirthDate = .Cells("BIRTHDATE").Value
                empCivilStatus = .Cells("CIVIL_STATUS").Value
                empAddress = .Cells("ADDRESS").Value

                empContactNumber = .Cells("CONTACT").Value
                empContractStatus = .Cells("EMPLOYMENT_STATUS").Value
                empDateHired = .Cells("DATE_HIRED").Value

                empSSS = dbHelper.StrNullCheck(.Cells("SSS_NUMBER").Value)
                empPAGIBIG = dbHelper.StrNullCheck(.Cells("PAGIBIG_NUMBER").Value)
                empTIN = dbHelper.StrNullCheck(.Cells("TIN_NUMBER").Value)

                empjobType = .Cells("JOB_TYPE").Value

                adminPosition = dbHelper.StrNullCheck(.Cells("ADMIN_POSITION").Value)
                utilityPersonnelDestination = dbHelper.StrNullCheck(.Cells("PERSONNEL_DESTINATION").Value)

                empProfilePath = dbHelper.StrNullCheck(.Cells("IMG_PATH").Value)

                empEmail = .Cells("EMAIL").Value
                empPassword = .Cells("PASSWORD").Value
                empIdAddedBy = .Cells("ADDED_BY").Value
                empArchived = .Cells("ARCHIVED").Value

                empLastAccessed = dbHelper.StrNullCheck(.Cells("LAST_ACCESSED").Value)
                empDateAdded = .Cells("DATE_ADDED").Value
            End With


        Catch ex As Exception
            MsgBox("Failed to initialized employee values: " + ex.Message)
            Return False
        End Try

        Return True
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        Dim employeeViewModal As New EmployeeViewModal

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
                If File.Exists(empProfilePath) Then
                    .ProfileCirclePictureBox.Image = Image.FromFile(empProfilePath)
                End If

                .EmailTextBox.Text = empEmail


                .PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)


                ' ARCHIVE INFO

                .ArchiveStatusTextBox.Text = empArchived
                .LastAccessedTextBox.Text = empLastAccessed

                Dim getAddedByData As DataRow = dbHelper.GetRowByValue("employees", "employee_id", empIdAddedBy).Rows(0)
                .AddedByTextBox.Text = getAddedByData("firstname") & " " & getAddedByData("lastname")

                ' JOB INFO


                If empjobType = constants.getAdminString Then
                    ' ADMIN
                    adminTotalEmployeeAdded = dbHelper.GetRowByValue("employees", "added_by", employeeID).Rows.Count

                    .PositionTextBox.Text = adminPosition
                    .EmployeeAddedTextBox.Text = adminTotalEmployeeAdded

                ElseIf empjobType = constants.getTechnicianString Then
                    ' TECH
                    techNumberFinishedServices = dbHelper.GetRowByTwoValues("services", "technician_id", employeeID, "service_status", "Finished").Rows.Count
                    techNumberPendingServices = dbHelper.GetRowByTwoValues("services", "technician_id", employeeID, "service_status", "Pending").Rows.Count
                    techNumberCanceledServices = dbHelper.GetRowByTwoValues("services", "technician_id", employeeID, "service_status", "Canceled").Rows.Count
                    techNumberOnholdServices = dbHelper.GetRowByTwoValues("services", "technician_id", employeeID, "service_status", "Onhold").Rows.Count

                    .DevicesRepairedTextBox.Text = techNumberFinishedServices
                    .NumberJobsAssignedTextBox.Text = techNumberPendingServices

                ElseIf empjobType = constants.getCashierString Then

                    ' CASHIER
                    cashierTotalCustomersHandled = dbHelper.GetRowByValue("customers", "added_by", employeeID).Rows.Count
                    cashierTotalServicesHandled = dbHelper.GetRowByValue("services", "cashier_id", employeeID).Rows.Count
                    .CustomersHandledTextBox.Text = cashierTotalCustomersHandled

                ElseIf empjobType = constants.getUtilityPersonnelString Then
                    ' PERSONNEL
                    .AssignedLocationTextBox.Text = utilityPersonnelDestination

                End If

                .DateAddedTextBox.Text = empDateAdded

                ' DISPLAY FORM
                .ShowDialog()
            End With


        Catch ex As Exception
            MsgBox("Unable to show view employee modal: " & ex.ToString)
            formModal.Close()
            employeeViewModal.Close()
        Finally
            employeeViewModal.Dispose()
            formModal.Dispose()
        End Try
    End Sub

    ' ADD
    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        Dim employeeAddEditModal As New EmployeeAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With employeeAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox("Unable to show add employee modal: " & ex.Message)
            formModal.Close()
            employeeAddEditModal.Close()
        Finally
            employeeAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub


    ' EDIT
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click

        If Not InitData() Then Exit Sub

        Dim employeeAddEditModal As New EmployeeAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()

            With employeeAddEditModal
                ' LOAD FORM
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .editMode = True
                .EmployeeModalGroupBox.Text = "Edit Employee Details"
                .InitCmbDs(-1, -1, -1, -1, -1)

                ' BASIC INFO
                .selectedEmployeeId = employeeID
                .FirstNameTextBox.Text = empFirstName
                .MiddleNameTextBox.Text = empMiddleName
                .LastNameTextBox.Text = empLastName

                Dim sexIndex = formUtils.FindComboBoxItemByText(.SexComboBox, empSex)
                Dim civilIndex = formUtils.FindComboBoxItemByText(.CivilStatusComboBox, empCivilStatus)
                Dim contractStatusBoxIndex = formUtils.FindComboBoxItemByText(.ContractStatusComboBox, empContractStatus)
                Dim adminPosIndex = formUtils.FindComboBoxItemByText(.PositionComboBox, adminPosition)
                Dim jobTypeIndex = formUtils.FindComboBoxItemByText(.JobTypeComboBox, empjobType)

                .BirthdateDateTimePicker.Value = DateTime.Parse(empBirthDate)

                .AddressTextBox.Text = empAddress
                .ContactNumberTextBox.Text = empContactNumber

                ' CONTRACT STATUS CMB

                If contractStatusBoxIndex = -1 Then
                    .ContractStatusComboBox.SelectedItem = "Others"
                    .IfOthersTxtBox.Text = empContractStatus
                Else
                    .ContractStatusComboBox.SelectedIndex = contractStatusBoxIndex
                End If

                ' JOBS
                .DateHiredDateTimePicker.Value = DateTime.Parse(empDateHired)
                .AssignedLocationTextBox.Text = utilityPersonnelDestination

                ' JOB INFO 

                .SSSTextBox.Text = empSSS
                .PagIbigTextBox.Text = empPAGIBIG
                .TINTextBox.Text = empTIN


                ' PROFILE
                If File.Exists(empProfilePath) Then
                    .ProfileCirclePictureBox.Image = Image.FromFile(empProfilePath)
                End If

                .profileImgPath = empProfilePath

                ' EMAIL & PASSWORD
                .EmailTextBox.Text = empEmail
                .PasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)
                .ConfirmPasswordTextBox.Text = dbHelper.DecryptPassword(empPassword, constants.EncryptionKey)

                .InitCmbDs(sexIndex, civilIndex, contractStatusBoxIndex, jobTypeIndex, adminPosIndex)

                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeAddEditModal.Close()
        Finally
            employeeAddEditModal.Dispose()
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
        If Not InitData() Then Exit Sub

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
            AddEmployeeBtn.Visible = False
            EditEmployeeBtn.Visible = False

            EmpDGV.Columns("DATE_ARCHIVED").Visible = True
            EmpDGV.Columns("ARCHIVED_BY").Visible = True
        Else
            DeleteEmployeeBtn.Visible = False
            ArchiveEmployeeBtn.Visible = True
            AddEmployeeBtn.Visible = True
            EditEmployeeBtn.Visible = True
            EmpDGV.Columns("DATE_ARCHIVED").Visible = False
            EmpDGV.Columns("ARCHIVED_BY").Visible = False
        End If
    End Sub

    ' LOAD DATA

    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim employeesTable As DataTable

        If Not selectMode Then
            If ShowArchiveCheckBox.Checked Then
                employeesTable = dbHelper.GetAllRowsFromTable("employees", True, True)
            Else
                employeesTable = dbHelper.GetAllRowsFromTable("employees", False)
            End If
        Else
            employeesTable = selectModeTable
        End If

        Dim searchValues() As String = {
           "firstname",
           "middlename",
           "lastname",
           "date_hired",
           "email",
           "last_accessed",
           "date_added"
        }

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            employeesTable = formUtils.SearchFunction(employeesTable, searchTerm, searchValues, SearchComboBox.SelectedIndex)
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

                    If getEmpData.Rows.Count > 0 Then row.Cells("ARCHIVED_BY").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")

                End If
            Next

            For Each row As DataGridViewRow In EmpDGV.Rows

                Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ADDED_BY").Value)

                If getEmpData.Rows.Count > 0 Then row.Cells("ADDED_BY_NAME").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")

            Next

        Catch ex As Exception
            MsgBox("Unable to style the Employee DGV: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Then Exit Sub

        selectedEmpID = employeeID

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub

    Private Sub EmpDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpDGV.CellContentClick

    End Sub
End Class