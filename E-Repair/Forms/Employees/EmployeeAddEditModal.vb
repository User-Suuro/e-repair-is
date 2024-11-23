Imports System.IO

Public Class EmployeeAddEditModal

    Dim constants As New Constants
    Dim dbUtils As New DbHelper
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    ' CONSTANTS
    Private emailFirstValue As String = ""
    Private initialJobType As String = ""

    ' STATES
    Private isEmailDuplicate As Boolean = False

    ' SCHEMA
    Private firstName As String = ""
    Private middleName As String = ""
    Private lastName As String = ""
    Private sex As String = ""
    Private birthdate As Date
    Private civilStatus As String = ""
    Private address As String = ""
    Private contactNumber As String = ""
    Private contractStatus As String = ""
    Private dateHired As Date
    Private jobType As String = ""
    Private sss As String = ""
    Private nbi As String = ""
    Private tin As String = ""
    Private pagibig As String = ""
    Private email As String = ""
    Private password As String = ""
    Private confirmPassword As String = ""
    Private personnelDestination As String = ""
    Private adminPosition As String = ""
    Private othersTextBoxContent As String = ""
    Private Property profileImgPath As String = ""
    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1

    ' FORM ONLOAD
    Private Sub AdminEmployeeAddModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitCmbDs(-1, -1, -1, -1, -1)
        loadValues()
    End Sub

    ' EDIT MODE
    Private Sub loadValues()
        If selectedID = -1 Then Exit Sub

        EmployeeModalGroupBox.Text = "Edit Employee"

        Dim empDt As DataTable = dbHelper.GetRowByValue("employees", "employee_id", selectedID)

        If empDt.Rows.Count = 0 Then Exit Sub

        With empDt.Rows(0)
            FirstNameTextBox.Text = .Item("firstname")
            MiddleNameTextBox.Text = dbHelper.StrNullCheck(.Item("middlename"))
            LastNameTextBox.Text = .Item("lastname")
            BirthdateDateTimePicker.Value = DateTime.Parse(.Item("birthdate"))

            AddressTextBox.Text = .Item("address")
            ContactNumberTextBox.Text = .Item("contact_number")
            DateHiredDateTimePicker.Value = DateTime.Parse(.Item("date_hired"))

            SSSTextBox.Text = .Item("sss_no")
            PagIbigTextBox.Text = .Item("pagibig_no")
            TINTextBox.Text = .Item("tin_no")

            profileImgPath = .Item("profile_path")

            EmailTextBox.Text = .Item("email")

            PasswordTextBox.Text = dbHelper.DecryptPassword(.Item("password"), constants.EncryptionKey)
            ConfirmPasswordTextBox.Text = PasswordTextBox.Text

            Dim sexIndex = formUtils.FindComboBoxItemByText(SexComboBox, .Item("sex"))
            Dim civilIndex = formUtils.FindComboBoxItemByText(CivilStatusComboBox, .Item("civilstatus"))
            Dim contractStatusBoxIndex = formUtils.FindComboBoxItemByText(ContractStatusComboBox, .Item("employment_status"))
            Dim jobTypeIndex = formUtils.FindComboBoxItemByText(JobTypeComboBox, .Item("job_type"))
            Dim adminPosIndex = formUtils.FindComboBoxItemByText(PositionComboBox, .Item("admin_position"))

            AssignedLocationTextBox.Text = dbHelper.StrNullCheck(.Item("personnel_destination"))

            InitCmbDs(sexIndex, civilIndex, contractStatusBoxIndex, jobTypeIndex, adminPosIndex)
        End With

        ' PROFILE
        If File.Exists(profileImgPath) Then
            ProfileCirclePictureBox.Image = Image.FromFile(profileImgPath)
        End If
    End Sub

    ' INIT CMBDS
    Public Sub InitCmbDs(index01 As Integer, index02 As Integer, index03 As Integer, index04 As Integer, index05 As Integer)
        With dbHelper
            .LoadEnumsToCmb(SexComboBox, "employees", "sex", index01)
            .LoadEnumsToCmb(CivilStatusComboBox, "employees", "civilstatus", index02)
            .LoadEnumsToCmb(ContractStatusComboBox, "employees", "employment_status", index03)
            .LoadEnumsToCmb(JobTypeComboBox, "employees", "job_type", index04)
            .LoadEnumsToCmb(PositionComboBox, "employees", "admin_position", index05)
        End With
    End Sub

    ' CREATE EMPLOYEE
    Private Sub CreateEmpFunction()

        ' Exit if canceled
        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this employee?") Then Exit Sub

        Dim savedPath = formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, False)

        Dim empIDLogged As Integer = GlobalSession.CurrentSession.EmployeeID

        Dim insertData As New Dictionary(Of String, Object) From {
            {"middlename", middleName}, ' Exception
            {"sss_no", sss}, ' Exception
            {"pagibig_no", pagibig}, ' Exception
            {"tin_no", tin}, ' Exception
            {"firstname", firstName},
            {"lastname", lastName},
            {"sex", sex},
            {"birthdate", birthdate},
            {"civilstatus", civilStatus},
            {"address", address},
            {"contact_number", contactNumber},
            {"employment_status", contractStatus},
            {"date_hired", dateHired},
            {"job_type", jobType},
            {"profile_path", savedPath},
            {"email", email},
            {"password", dbUtils.EncryptPassword(password, constants.EncryptionKey)},
            {"added_by", empIDLogged}
        }

        ' start in index 4 cuz of some optional values
        If Not formUtils.AreAllValuesFilled(insertData, 4) Then Exit Sub

        ' Exception
        If password.Trim() = "" Then
            MsgBox("Please fill necessary details")
            Exit Sub
        End If

        ' UDPDATE FOREIGN VALUES

        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                {"admin_position", adminPosition}
        }

        Dim updateUtilityValues As New Dictionary(Of String, Object) From {
                {"personnel_destination", personnelDestination}
        }

        If jobType = constants.getAdminString Then
            ' Admin
            If Not formUtils.AreAllValuesFilled(updateAdminValues) Then Exit Sub
            For Each kvp In updateAdminValues
                insertData.Add(kvp.Key, kvp.Value)
            Next

        ElseIf jobType = constants.getUtilityPersonnelString Then
            ' Utility
            If Not formUtils.AreAllValuesFilled(updateUtilityValues) Then Exit Sub
            For Each kvp In updateUtilityValues
                insertData.Add(kvp.Key, kvp.Value)
            Next
        End If

        If Not dbHelper.InsertRecord("employees", insertData) Then
            MsgBox("Failed to save employee record")
            Exit Sub
        End If

        formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, True)

        MsgBox("Employee Successfully Added")

        Me.Close()
    End Sub

    Private Sub EditEmpFunction()

        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to update this employee?")) Then Exit Sub

        ' UPDATE EMPLOYEE
        Dim updateData As New Dictionary(Of String, Object) From {
            {"sss_no", sss},' Optional
            {"pagibig_no", pagibig}, ' Optional
            {"tin_no", tin},  ' Optional
            {"middlename", middleName}, ' Optional
            {"firstname", firstName},
            {"lastname", lastName},
            {"email", email},
            {"job_type", jobType},
            {"password", dbUtils.EncryptPassword(password, constants.EncryptionKey)},
            {"sex", sex},
            {"birthdate", birthdate},
            {"civilstatus", civilStatus},
            {"address", address},
            {"contact_number", contactNumber},
            {"employment_status", contractStatus},
            {"date_hired", dateHired}
        }

        If Not formUtils.AreAllValuesFilled(updateData, 4) Then Exit Sub

        ' get prev value
        Dim prevEmployeeValue As DataRow = dbUtils.GetRowByValue("employees", "employee_id", selectedID).Rows(0)

        ' UDPDATE FOREIGN VALUES

        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                {"admin_position", adminPosition}
        }

        Dim updateUtilityValues As New Dictionary(Of String, Object) From {
                {"personnel_destination", personnelDestination}
        }

        If jobType = constants.getAdminString Then
            ' Admin
            If Not formUtils.AreAllValuesFilled(updateAdminValues) Then Exit Sub
            For Each kvp In updateAdminValues
                updateData.Add(kvp.Key, kvp.Value)
            Next

        ElseIf jobType = constants.getUtilityPersonnelString Then
            ' Utility
            If Not formUtils.AreAllValuesFilled(updateUtilityValues) Then Exit Sub
            For Each kvp In updateUtilityValues
                updateData.Add(kvp.Key, kvp.Value)
            Next
        End If

        ' Save image locally
        If prevEmployeeValue("profile_path") <> profileImgPath Then updateAdminValues.Add("profile_path", formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, True))

        If dbHelper.UpdateRecord("employees", "employee_id", selectedID, updateData) Then
            MsgBox("Employee Details Sucessfully Updated")
        Else
            MsgBox("Db Failure")
        End If

        Me.Close()
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    ' BTN SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        ' Additional checkers
        If isEmailDuplicate AndAlso email <> emailFirstValue Then
            MsgBox("This email is already saved in database. Please try other emails")
            Exit Sub
        End If

        If confirmPassword <> password Then
            MsgBox("The confirmed password does not match")
            Exit Sub
        End If

        Try
            Cursor = Cursors.WaitCursor
            If editMode Then
                EditEmpFunction()
            Else
                CreateEmpFunction()
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Failed to Edit / Add Employee: " & ex.Message)
        End Try
    End Sub

    ' FIRST NAME
    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        firstName = FirstNameTextBox.Text
    End Sub

    ' MIDDLE NAME
    Private Sub MiddleNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MiddleNameTextBox.TextChanged
        middleName = MiddleNameTextBox.Text
    End Sub

    ' LAST NAME
    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged
        lastName = LastNameTextBox.Text
    End Sub

    ' SEX
    Private Sub SexComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SexComboBox.SelectedIndexChanged
        sex = SexComboBox.SelectedItem
    End Sub

    ' BIRTHDATE
    Private Sub BirthdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthdateDateTimePicker.ValueChanged
        birthdate = BirthdateDateTimePicker.Value.Date
    End Sub

    ' CIVIL STATUS
    Private Sub CivilStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CivilStatusComboBox.SelectedIndexChanged
        civilStatus = CivilStatusComboBox.SelectedItem
    End Sub

    ' ADDRESS
    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged
        address = AddressTextBox.Text
    End Sub

    ' CONCTACTS
    Private Sub ContactNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNumberTextBox.TextChanged
        contactNumber = ContactNumberTextBox.Text
    End Sub

    ' PROFILE PICTURE
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim imgPath = OpenFileDialog1.FileName
            If File.Exists(imgPath) Then
                ProfileCirclePictureBox.Image = Image.FromFile(imgPath)
                profileImgPath = imgPath
            End If
        End If
    End Sub

    ' CONTRACT STATUS
    Private Sub ContractStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContractStatusComboBox.SelectedIndexChanged

        'If ContractStatusComboBox.SelectedItem = "Others" Then
        '    With JobDetailsTableLayout
        '        .ColumnStyles(0).Width = 25.0F
        '        .ColumnStyles(1).Width = 25.0F
        '        .ColumnStyles(2).Width = 25.0F
        '        .ColumnStyles(3).Width = 25.0F
        '    End With
        'Else

        '    With JobDetailsTableLayout
        '        .ColumnStyles(0).Width = 33.3F
        '        .ColumnStyles(1).Width = 33.3F
        '        .ColumnStyles(2).Width = 33.3F
        '        .ColumnStyles(3).Width = 0.0F
        '    End With
        'End If

        contractStatus = ContractStatusComboBox.SelectedItem
    End Sub

    ' OTHERS TEXTBOX
    Private Sub OthersTextBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersTxtBox.TextChanged
        'If ContractStatusComboBox.SelectedItem = "Others" Then
        '    contractStatus = IfOthersTxtBox.Text
        'End If
    End Sub

    ' DATE HIRED
    Private Sub DateHiredDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateHiredDateTimePicker.ValueChanged
        dateHired = DateHiredDateTimePicker.Value.Date
    End Sub

    ' JOB TYPE
    Private Sub JobTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobTypeComboBox.SelectedIndexChanged

        personnelDestination = ""
        adminPosition = ""
        PositionComboBox.SelectedIndex = -1
        JobDescriptionFlowLayout.Visible = False

        If JobTypeComboBox.SelectedItem = JobTypeComboBox.Items(0) Then
            ' IF ADMIN THEN
            JobDescriptionFlowLayout.Visible = True
            PositionPanel.Visible = True
            AssignedLocationPanel.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = JobTypeComboBox.Items(1) Then
            ' IF TECHNICIAN THEN
            JobDescriptionFlowLayout.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = JobTypeComboBox.Items(2) Then
            ' IF CASHIER THEN
            JobDescriptionFlowLayout.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = JobTypeComboBox.Items(3) Then
            ' IF UTILITY PERSONNEL THEN
            JobDescriptionFlowLayout.Visible = True
            PositionPanel.Visible = False
            AssignedLocationPanel.Visible = True
        End If

        jobType = JobTypeComboBox.SelectedItem

    End Sub

    ' POSITION (ADMIN)
    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionComboBox.SelectedIndexChanged
        adminPosition = PositionComboBox.SelectedItem
    End Sub

    ' ASSIGNED LOCATION (UTILITY PERSONNEL)
    Private Sub AssignedLocationTextBox_TextChanged(sender As Object, e As EventArgs) Handles AssignedLocationTextBox.TextChanged
        personnelDestination = AssignedLocationTextBox.Text
    End Sub

    ' SSS
    Private Sub SSSTextBox_TextChanged(sender As Object, e As EventArgs) Handles SSSTextBox.TextChanged
        sss = SSSTextBox.Text
    End Sub

    ' PAGIBIG
    Private Sub PagIbigTextBox_TextChanged(sender As Object, e As EventArgs) Handles PagIbigTextBox.TextChanged
        pagibig = PagIbigTextBox.Text
    End Sub

    ' TIN
    Private Sub TINTextBox_TextChanged(sender As Object, e As EventArgs) Handles TINTextBox.TextChanged
        tin = TINTextBox.Text
    End Sub

    ' EMAIL
    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        email = EmailTextBox.Text

        Dim getEmailInDb As DataTable = dbHelper.GetRowByValue("employees", "email", email)

        If (getEmailInDb.Rows.Count = 0) Then
            AlreadyTakenLabel.Visible = False
            isEmailDuplicate = False
        Else
            AlreadyTakenLabel.Visible = True
            isEmailDuplicate = True
        End If

        ' Check if yours

        Dim getPrevEmail As DataTable = dbHelper.GetRowByValue("employees", "employee_id", selectedID)

        If getPrevEmail.Rows.Count = 0 Then Exit Sub

        With getPrevEmail.Rows(0)
            If (.Item("email") = email) Then
                AlreadyTakenLabel.Visible = False
                isEmailDuplicate = False
            End If
        End With

    End Sub

    ' PASSWORD
    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        password = PasswordTextBox.Text

        If (confirmPassword <> password) Then
            PassMismatchLabel.Visible = True
        Else
            PassMismatchLabel.Visible = False
        End If
    End Sub

    ' CONFIRM PASSWORD
    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        confirmPassword = ConfirmPasswordTextBox.Text

        If (confirmPassword <> password) Then
            PassMismatchLabel.Visible = True
        Else
            PassMismatchLabel.Visible = False
        End If
    End Sub


End Class