Imports System.IO
Imports Google.Protobuf.WellKnownTypes

Public Class EmployeeViewModal
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim dbHelper As New DbHelper

    Public Property selectedID As Integer = -1


    Private Sub AdminViewEmployeeModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManageJobDescriptionView()
        loadValues()
    End Sub

    Private Sub loadValues()
        If selectedID = -1 Then Exit Sub

        Dim empDt As DataTable = dbHelper.GetRowByValue("employees", "employee_id", selectedID)

        If empDt.Rows.Count = 0 Then Exit Sub

        With empDt.Rows(0)
            FirstNameTextBox.Text = .Item("firstname")
            MiddleNameTextBox.Text = dbHelper.StrNullCheck(.Item("middlename"))
            LastNameTextBox.Text = .Item("lastname")
            BirthDateTextBox.Text = .Item("birthdate")

            AddressTextBox.Text = .Item("address")
            ContactNumberTextBox.Text = .Item("contact_number")
            DateHiredTextBox.Text = .Item("date_hired")

            SSSTextBox.Text = .Item("sss_no")
            PagIbigTextBox.Text = .Item("pagibig_no")
            TINTextBox.Text = .Item("tin_no")

            JobTypeTextBox.Text = .Item("job_type")
            ContractStatusTextBox.Text = .Item("employment_status")

            ' PROFILE
            ProfilePathTextBox.Text = dbHelper.StrNullCheck(.Item("profile_path"))
            If File.Exists(.Item("profile_path")) Then
                ProfileCirclePictureBox.Image = Image.FromFile(.Item("profile_path"))
            End If

            EmailTextBox.Text = .Item("email")
            PasswordTextBox.Text = dbHelper.DecryptPassword(.Item("password"), constants.EncryptionKey)

            ' ARCHIVE INFO
            ArchiveStatusTextBox.Text = .Item("archived")

            LastAccessedTextBox.Text = dbHelper.StrNullCheck(.Item("last_accessed"))

            Dim getAddedByData As DataRow = dbHelper.GetRowByValue("employees", "employee_id", .Item("added_by")).Rows(0)
            AddedByTextBox.Text = getAddedByData("firstname") & " " & getAddedByData("lastname")

            Dim empJobType = .Item("job_type")

            ' JOB INFO

            If empJobType = constants.getAdminString Then
                ' ADMIN
                PositionTextBox.Text = .Item("admin_position")
                EmployeeAddedTextBox.Text = dbHelper.GetRowByValue("employees", "added_by", selectedID).Rows.Count

            ElseIf empJobType = constants.getTechnicianString Then
                ' TECH
                DevicesRepairedTextBox.Text = getTechnicianStatus("Finished")
                NumberJobsAssignedTextBox.Text = getTechnicianStatus("Pending") + getTechnicianStatus("Finished") + getTechnicianStatus("Onhold") + getTechnicianStatus("Canceled")

            ElseIf empjobType = constants.getCashierString Then
                ' CASHIER
                CustomersHandledTextBox.Text = dbHelper.GetRowByValue("customers", "added_by", selectedID).Rows.Count
                ServiceHandledTxtBox.Text = dbHelper.GetRowByValue("services", "cashier_id", selectedID).Rows.Count

            ElseIf empjobType = constants.getUtilityPersonnelString Then
                ' PERSONNEL
                AssignedLocationTextBox.Text = .Item("personnel_destination")
            End If

        End With



    End Sub

    Private Function getTechnicianStatus(status As String) As Integer
        Return dbHelper.GetRowByTwoValues("services", "technician_id", selectedID, "service_status", status).Rows.Count
    End Function

    Private Sub ManageJobDescriptionView()
        AdminDescriptionPanel.Visible = False
        TechnicianDescriptionPanel.Visible = False
        CashierDescriptionPanel.Visible = False
        PersonnelDescriptionPanel.Visible = False

        If JobTypeTextBox.Text = constants.getAdminString Then
            JobDescriptionFlowLayout.Visible = True
            AdminDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getTechnicianString Then
            JobDescriptionFlowLayout.Visible = True
            TechnicianDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getCashierString Then
            JobDescriptionFlowLayout.Visible = True
            CashierDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getUtilityPersonnelString Then
            JobDescriptionFlowLayout.Visible = True
            PersonnelDescriptionPanel.Visible = True
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class