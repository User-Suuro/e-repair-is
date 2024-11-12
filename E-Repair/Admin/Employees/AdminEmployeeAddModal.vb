Public Class AdminEmployeeAddModal

    Dim constants As New Constants
    Dim dbUtils As New DbHelper
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    ' CONSTANTS
    Dim emailFirstValue As String
    Dim initialJobType As String

    ' IMPORTED STATES
    Public Property editMode As Boolean = False
    Public Property selectedEmployeeId As Integer = -1

    ' STATES
    Dim isEmailDuplicate As Boolean = False

    ' SCHEMA
    Dim firstName As String = ""
    Dim middleName As String = ""
    Dim lastName As String = ""
    Dim sex As String = ""
    Dim birthdate As Date
    Dim civilStatus As String = ""
    Dim address As String = ""
    Dim contactNumber As String = ""
    Dim contractStatus As String = ""
    Dim dateHired As Date
    Dim jobType As String = ""
    Dim sss As String = ""
    Dim nbi As String = ""
    Dim tin As String = ""
    Dim pagibig As String = ""
    Dim email As String = ""
    Dim password As String = ""
    Dim confirmPassword As String = ""
    Public Property profileImgPath As String = ""

    ' FOREIGN SCHEMA
    Dim personnelDestination As String = ""
    Dim adminPosition As String = ""

    Dim othersTextBoxContent As String = ""

    Private Sub AdminEmployeeAddModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailFirstValue = EmailTextBox.Text
        initialJobType = JobTypeComboBox.Text

        AlreadyTakenLabel.Visible = False
        isEmailDuplicate = False
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
            ProfileCirclePictureBox.Image = Image.FromFile(imgPath)
            profileImgPath = imgPath
        End If
    End Sub

    ' CONTRACT STATUS
    Private Sub ContractStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContractStatusComboBox.SelectedIndexChanged
        If ContractStatusComboBox.SelectedItem = "Others" Then
            With JobDetailsTableLayout
                .ColumnStyles(0).Width = 25.0F
                .ColumnStyles(1).Width = 25.0F
                .ColumnStyles(2).Width = 25.0F
                .ColumnStyles(3).Width = 25.0F
            End With
        Else
            contractStatus = ContractStatusComboBox.SelectedItem
            With JobDetailsTableLayout
                .ColumnStyles(0).Width = 33.3F
                .ColumnStyles(1).Width = 33.3F
                .ColumnStyles(2).Width = 33.3F
                .ColumnStyles(3).Width = 0.0F
            End With
        End If
    End Sub

    ' OTHERS TEXTBOX
    Private Sub OthersTextBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersTxtBox.TextChanged
        If ContractStatusComboBox.SelectedItem = "Others" Then
            contractStatus = IfOthersTxtBox.Text
        End If
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

        If (getEmailInDb.Rows.Count > 0) Then
            AlreadyTakenLabel.Visible = True
            isEmailDuplicate = True
        Else
            AlreadyTakenLabel.Visible = False
            isEmailDuplicate = False
        End If

        If (email = emailFirstValue) Then
            AlreadyTakenLabel.Visible = False
            isEmailDuplicate = False
        End If

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

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    ' BTN SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If isEmailDuplicate AndAlso email <> emailFirstValue Then
            MsgBox("This email is already saved in database. Please try other emails")
            Exit Sub
        End If

        If confirmPassword <> password Then
            MsgBox("The confirmed password does not match")
            Exit Sub
        End If

        If CheckFilled() = False Then
            MsgBox("Please fill all necessary details")
            Exit Sub
        End If

        Try
            If editMode Then
                ' UPDATE EMPLOYEE
                Dim updatedEmployeeValues As New Dictionary(Of String, Object) From {
                    {"firstname", firstName},
                    {"middlename", middleName},
                    {"lastname", lastName},
                    {"email", email},
                    {"password", dbUtils.EncryptPassword(password, constants.EncryptionKey)},
                    {"sex", sex},
                    {"birthdate", birthdate},
                    {"civilstatus", civilStatus},
                    {"address", address},
                    {"contact_number", contactNumber},
                    {"employment_status", contractStatus},
                    {"date_hired", dateHired},
                    {"sss_no", sss},
                    {"job_type", jobType},
                    {"pagibig_no", pagibig},
                    {"tin_no", tin}
                }

                ' get prev value
                Dim prevEmployeeValue As DataTable = dbUtils.GetRowByValue("employees", "employee_id", selectedEmployeeId)
                Dim prevEmployeeRow As DataRow = prevEmployeeValue.Rows(0)

                If jobType = constants.getAdminString Then
                    updatedEmployeeValues.Add("admin_position", adminPosition)
                    updatedEmployeeValues.Add("total_employee_added", prevEmployeeRow("total_employee_added"))
                ElseIf jobType = constants.getCashierString Then
                    updatedEmployeeValues.Add("no_customers_handled", prevEmployeeRow("no_customers_handled"))
                ElseIf jobType = constants.getTechnicianString Then
                    updatedEmployeeValues.Add("no_pending_services", prevEmployeeRow("no_pending_services"))
                    updatedEmployeeValues.Add("no_finished_services", prevEmployeeRow("no_finished_services"))
                ElseIf jobType = constants.getUtilityPersonnelString Then
                    updatedEmployeeValues.Add("personnel_destination", personnelDestination)
                End If

                If (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to update this employee?")) Then

                    If prevEmployeeRow("profile_path") <> profileImgPath Then
                        ' delete previous

                        ' formUtils.DeleteImageFile(prevEmployeeRow("profile_path"))

                        updatedEmployeeValues.Add("profile_path", formUtils.CopyImageFileToProjectFolder(profileImgPath))
                    End If

                    dbHelper.UpdateRecord("employees", "employee_id", selectedEmployeeId, updatedEmployeeValues)

                        MsgBox("Employee Details Sucessfully Update")

                        Me.Close()
                    End If

                Else
                ' CREATE EMPLOYEE
                Dim employeeColumns As New List(Of String) From {
                    "firstname",
                    "middlename",
                    "lastname",
                    "sex",
                    "birthdate",
                    "civilstatus",
                    "address",
                    "contact_number",
                    "employment_status",
                    "date_hired",
                    "job_type",
                    "sss_no",
                    "pagibig_no",
                    "tin_no",
                    "profile_path",
                    "email",
                    "password",
                    "added_by"
                }

                ' GET EMPLOYEE KEY BY CURRENT SESSION
                Dim empIDLogged As Integer

                Try
                    empIDLogged = GlobalSession.CurrentSession.EmployeeID
                Catch ex As Exception
                    empIDLogged = -1
                End Try



                If formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this employee?") Then

                    ' Save Image Locally
                    Dim savedPath = formUtils.CopyImageFileToProjectFolder(profileImgPath)

                    Dim employeeValues As New List(Of Object) From {
                        firstName,
                        middleName,
                        lastName,
                        sex,
                        birthdate,
                        civilStatus,
                        address,
                        contactNumber,
                        contractStatus,
                        dateHired,
                        jobType,
                        sss,
                        pagibig,
                        tin,
                        savedPath,
                        email,
                        dbUtils.EncryptPassword(password, constants.EncryptionKey),
                        empIDLogged
                    }

                    dbHelper.InsertIntoTable("employees", employeeColumns, employeeValues)

                    ' UDPDATE FOREIGN VALUES
                    Dim updateJobValues As New Dictionary(Of String, Object)

                    If jobType = constants.getAdminString Then
                        updateJobValues.Add("admin_position", adminPosition)
                        updateJobValues.Add("total_employee_added", 0)
                    ElseIf jobType = constants.getCashierString Then
                        updateJobValues.Add("no_customers_handled", 0)
                    ElseIf jobType = constants.getTechnicianString Then
                        updateJobValues.Add("no_pending_services", 0)
                        updateJobValues.Add("no_finished_services", 0)
                    ElseIf jobType = constants.getUtilityPersonnelString Then
                        updateJobValues.Add("personnel_destination", personnelDestination)
                    End If

                    dbHelper.UpdateRecord("employees", "employee_id", selectedEmployeeId, updateJobValues)

                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    ' CHECK IF ALL FILLED

    Public Function CheckFilled() As Boolean
        If firstName <> "" AndAlso
            lastName <> "" AndAlso
            sex <> "" AndAlso
            civilStatus <> "" AndAlso
            profileImgPath <> "" AndAlso
            address <> "" AndAlso
            contactNumber <> "" AndAlso
            contractStatus <> "" AndAlso
            email <> "" AndAlso
            password <> "" AndAlso
            confirmPassword <> "" AndAlso
            jobType <> "" Then

            ' Additional Checker For Jobs
            If jobType = JobTypeComboBox.Items(0) Then
                Return adminPosition <> ""
            ElseIf jobType = JobTypeComboBox.Items(3) Then
                Return personnelDestination <> ""
            Else
                ' If jobType is neither "Admin" nor "Utility Personnel"
                Return True
            End If

        Else
            ' If any required field is missing
            Return False
        End If
    End Function


End Class