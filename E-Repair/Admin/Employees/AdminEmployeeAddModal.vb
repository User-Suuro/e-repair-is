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

        Try
            If editMode Then
                EditEmpFunction()
            Else
                CreateEmpFunction()
            End If
        Catch ex As Exception
            MsgBox("Failed to Edit / Add Employee: " & ex.Message)
        End Try

    End Sub
    ' CREATE EMPLOYEE
    Private Sub CreateEmpFunction()

        ' Exit if canceled
        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this employee?") Then Exit Sub

        Dim savedPath = formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, False)

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
            {"profile_path", profileImgPath},
            {"email", email},
            {"password", dbUtils.EncryptPassword(password, constants.EncryptionKey)}
        }

        ' start in index 4 cuz of some optional values
        If Not formUtils.AreAllValuesFilled(insertData, 4) Then Exit Sub

        ' UDPDATE FOREIGN VALUES

        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                {"admin_position", adminPosition}
        }

        Dim updateUtilityValues As New Dictionary(Of String, Object) From {
                {"personnel_destination", personnelDestination}
        }

        If jobType = constants.getAdminString Then
            ' Admin
            If Not formUtils.AreAllValuesFilled(updateAdminValues, 1) Then Exit Sub
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

        If Not dbHelper.InsertRecord("employees", insertData) Then Exit Sub

        MsgBox("Employee Successfully Added")

        formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, True)

        ' UPDATE TOTAL EMPLOYEEE ADDED

        Dim empIDLogged As Integer

        Try
            empIDLogged = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            Exit Sub
        End Try

        If empIDLogged = -1 Then Exit Sub

        Dim prevValues As DataTable = dbHelper.GetRowByValue("employees", "employee_id", empIDLogged)

        Dim updateTotal As New Dictionary(Of String, Object) From {
                {"added_by", empIDLogged}
         }

        dbHelper.UpdateRecord("employees", "employee_id", empIDLogged, updateTotal)

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
        Dim prevEmployeeValue As DataRow = dbUtils.GetRowByValue("employees", "employee_id", selectedEmployeeId).Rows(0)

        ' UDPDATE FOREIGN VALUES

        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                {"total_employee_added", prevEmployeeValue("total_employee_added")}, ' Optional
                {"admin_position", adminPosition}
        }

        Dim updateTechnicianValues As New Dictionary(Of String, Object) From {
                {"no_pending_services", prevEmployeeValue("no_pending_services")}, ' Optional
                {"no_finished_services", prevEmployeeValue("no_finished_services")} ' Optional
        }

        Dim updateCashierValues As New Dictionary(Of String, Object) From {
                {"no_customers_handled", prevEmployeeValue("no_customers_handled")} ' OPtional
        }

        Dim updateUtilityValues As New Dictionary(Of String, Object) From {
                {"personnel_destination", personnelDestination}
        }

        If jobType = constants.getAdminString Then
            ' Admin
            If Not formUtils.AreAllValuesFilled(updateAdminValues, 1) Then Exit Sub
            For Each kvp In updateAdminValues
                updateData.Add(kvp.Key, kvp.Value)
            Next

        ElseIf jobType = constants.getCashierString Then
            ' Cashier
            For Each kvp In updateCashierValues
                updateData.Add(kvp.Key, kvp.Value)
            Next

        ElseIf jobType = constants.getTechnicianString Then
            ' Technician
            For Each kvp In updateTechnicianValues
                updateData.Add(kvp.Key, kvp.Value)
            Next

        ElseIf jobType = constants.getUtilityPersonnelString Then
            ' Utility
            If Not formUtils.AreAllValuesFilled(updateUtilityValues) Then Exit Sub
            For Each kvp In updateCashierValues
                updateData.Add(kvp.Key, kvp.Value)
            Next
        End If


        ' Save image locally
        If prevEmployeeValue("profile_path") <> profileImgPath Then
            updateAdminValues.Add("profile_path", formUtils.saveImgToLocal(profileImgPath, constants.getEmpProfileFolderPath, True))
        End If

        If dbHelper.UpdateRecord("employees", "employee_id", selectedEmployeeId, updateData) Then
            MsgBox("Employee Details Sucessfully Updated")
        Else
            MsgBox("Db Failure")
        End If

        Me.Close()
    End Sub

End Class