Imports System.IO
Imports Microsoft.Reporting.Map.WebForms.BingMaps

Public Class EmployeeAddEditModal

    Dim constants As New Constants
    Dim dbUtils As New DbHelper
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim servConst As New ServiceDBConstants

    ' CONSTANTS
    Private emailFirstValue As String
    Private initialJobType As String

    ' STATES
    Private isEmailDuplicate As Boolean = False
    Private hasWorkToDo As Boolean = False

    ' SCHEMA
    Private firstName As String
    Private middleName As String
    Private lastName As String
    Private sex As String
    Private birthdate As Date
    Private civilStatus As String
    Private address As String
    Private contactNumber As String
    Private contractStatus As String
    Private dateHired As Date
    Private jobType As String
    Private sss As String
    Private nbi As String
    Private tin As String
    Private pagibig As String
    Private email As String
    Private password As String
    Private confirmPassword As String
    Private personnelDestination As String
    Private adminPosition As String
    Private othersTextBoxContent As String
    Private Property profileImgPath As String


    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property createAccMode As Boolean = False

    ' FORM ONLOAD
    Private Sub AdminEmployeeAddModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitCmbDs(-1, -1, -1, -1, -1)
        If editMode Then loadValues()
    End Sub

    ' EDIT MODE
    Private Sub loadValues()


        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        EmployeeModalGroupBox.Text = "Edit Employee"

        Dim empDt As DataTable = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empIDStr, selectedID)

        If empDt.Rows.Count = 0 Then Exit Sub

        With empDt.Rows(0)
            FirstNameTextBox.Text = .Item(empConst.empFirstStr)
            MiddleNameTextBox.Text = dbHelper.StrNullCheck(empConst.empMidStr)
            LastNameTextBox.Text = .Item(empConst.empLastStr)
            BirthdateDateTimePicker.Value = DateTime.Parse(.Item(empConst.empBirthStr))

            AddressTextBox.Text = .Item(empConst.empAddrStr)
            ContactNumberTextBox.Text = .Item(empConst.empContactStr)
            DateHiredDateTimePicker.Value = DateTime.Parse(.Item(empConst.empHiredStr))

            SSSTextBox.Text = .Item(empConst.empSSSStr)
            PagIbigTextBox.Text = .Item(empConst.empPagibigStr)
            TINTextBox.Text = .Item(empConst.empTINStr)

            profileImgPath = .Item(empConst.empProfileStr)

            EmailTextBox.Text = .Item(empConst.empEmailStr)

            PasswordTextBox.Text = dbHelper.DecryptPassword(.Item(empConst.empPassStr), constants.EncryptionKey)
            ConfirmPasswordTextBox.Text = PasswordTextBox.Text

            Dim sexIndex = formUtils.FindComboBoxItemByText(SexComboBox, .Item(empConst.empSexStr))
            Dim civilIndex = formUtils.FindComboBoxItemByText(CivilStatusComboBox, .Item(empConst.empCivilStr))
            Dim contractStatusBoxIndex = formUtils.FindComboBoxItemByText(ContractStatusComboBox, .Item(empConst.empStatusStr))
            Dim jobTypeIndex = formUtils.FindComboBoxItemByText(JobTypeComboBox, .Item(empConst.empJobPosStr))
            Dim adminPosIndex = formUtils.FindComboBoxItemByText(PositionComboBox, .Item(empConst.empAdminPosStr))

            AssignedLocationTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empDestStr))

            InitCmbDs(sexIndex, civilIndex, contractStatusBoxIndex, jobTypeIndex, adminPosIndex)
        End With

        ' PROFILE
        If File.Exists(profileImgPath) Then
            ProfileCirclePictureBox.Image = Image.FromFile(profileImgPath)
        End If
    End Sub

    ' INIT CMBDS
    Public Sub InitCmbDs(index01 As Integer, index02 As Integer, index03 As Integer, index04 As Integer, index05 As Integer, Optional createAcc As Integer = 1)
        With dbHelper
            .LoadEnumsToCmb(SexComboBox, empConst.empTableStr, empConst.empSexStr, index01)
            .LoadEnumsToCmb(CivilStatusComboBox, empConst.empTableStr, empConst.empCivilStr, index02)
            .LoadEnumsToCmb(ContractStatusComboBox, empConst.empTableStr, empConst.empStatusStr, index03)
            .LoadEnumsToCmb(JobTypeComboBox, empConst.empTableStr, empConst.empJobPosStr, index04, createAcc) ' SUPER ADMIN MUST NOT BE SEEN
            .LoadEnumsToCmb(PositionComboBox, empConst.empTableStr, empConst.empAdminPosStr, index05)
        End With
    End Sub

    ' CREATE EMPLOYEE
    Private Sub CreateEmpFunction()
        With empConst
            Dim insertData As New Dictionary(Of String, Object) From {
                { .empMidStr, middleName}, ' Exception
                { .empSSSStr, sss}, ' Exception
                { .empPagibigStr, pagibig}, ' Exception
                { .empTINStr, tin}, ' Exception
                { .empFirstStr, firstName},
                { .empLastStr, lastName},
                { .empSexStr, sex},
                { .empBirthStr, birthdate},
                { .empCivilStr, civilStatus},
                { .empAddrStr, address},
                { .empContactStr, contactNumber},
                { .empStatusStr, contractStatus},
                { .empHiredStr, dateHired},
                { .empJobPosStr, jobType},
                { .empEmailStr, email},
                { .empPassStr, dbUtils.EncryptPassword(password, constants.EncryptionKey)},
                { .empAddedByName, formUtils.getEmployeeName(Current.id)},
                { .addedById, Current.id}
            }

            ' UDPDATE FOREIGN VALUES

            If jobType.Equals(constants.getAdminString) Then insertData.Add(.empAdminPosStr, adminPosition)
            If jobType.Equals(constants.getUtilityPersonnelString) Then insertData.Add(.empDestStr, personnelDestination)

            Dim imgData As New List(Of Object) From {
                .empProfileStr,
                profileImgPath,
                constants.getEmpProfileFolderName
            }

            If formUtils.AddRow(.empTableStr, insertData, 4, imgData) Then
                Me.Close()
            End If
        End With

    End Sub

    Private Sub EditEmpFunction()
        With empConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .empSSSStr, sss},' Optional
                { .empPagibigStr, pagibig}, ' Optional
                { .empTINStr, tin},  ' Optional
                { .empMidStr, middleName}, ' Optional
                { .empFirstStr, firstName},
                { .empLastStr, lastName},
                { .empEmailStr, email},
                { .empJobPosStr, jobType},
                { .empPassStr, dbUtils.EncryptPassword(password, constants.EncryptionKey)},
                { .empSexStr, sex},
                { .empBirthStr, birthdate},
                { .empCivilStr, civilStatus},
                { .empAddrStr, address},
                { .empContactStr, contactNumber},
                { .empStatusStr, contractStatus},
                { .empHiredStr, dateHired}
            }

            ' UDPDATE FOREIGN VALUES

            If jobType.Equals(constants.getAdminString) Then updateData.Add(.empAdminPosStr, adminPosition)
            If jobType.Equals(constants.getUtilityPersonnelString) Then updateData.Add(.empDestStr, personnelDestination)

            Dim imgData As New List(Of Object) From {
                .empProfileStr,
                profileImgPath,
                constants.getEmpProfileFolderName
            }

            ' check active work, if has one cannot change job type
            If jobType <> constants.getTechnicianString Then

                Dim pendingWork As Integer = formUtils.getTechStatsNumbers(constants.getPendingString, selectedID)

                If pendingWork <> 0 Then
                    MsgBox("You cannot change this employee job type because it has " & pendingWork & " pending work to do")
                    Exit Sub
                End If

            End If

            If formUtils.EditRow(.empTableStr, .empIDStr, selectedID, updateData, 4, imgData) Then
                Me.Close()
            End If
        End With

    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
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

        If password.Trim() = "" Then
            MsgBox("Please fill necessary details")
            Exit Sub
        End If

        formUtils.SaveEvent(editMode, AddressOf CreateEmpFunction, AddressOf EditEmpFunction)
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

        personnelDestination = Nothing
        adminPosition = Nothing
        PositionComboBox.SelectedIndex = -1
        JobDescriptionFlowLayout.Visible = False

        If JobTypeComboBox.SelectedItem = constants.getAdminString Then
            ' IF ADMIN THEN
            JobDescriptionFlowLayout.Visible = True
            PositionPanel.Visible = True
            AssignedLocationPanel.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = constants.getTechnicianString Then
            ' IF TECHNICIAN THEN
            JobDescriptionFlowLayout.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = constants.getCashierString Then
            ' IF CASHIER THEN
            JobDescriptionFlowLayout.Visible = False

        ElseIf JobTypeComboBox.SelectedItem = constants.getUtilityPersonnelString Then
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

        Dim getEmailInDb As DataTable = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empEmailStr, email)

        If (getEmailInDb.Rows.Count = 0) Then
            AlreadyTakenLabel.Visible = False
            isEmailDuplicate = False
        Else
            AlreadyTakenLabel.Visible = True
            isEmailDuplicate = True
        End If

        ' Check if yours

        Dim getPrevEmail As DataTable = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empIDStr, selectedID)

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