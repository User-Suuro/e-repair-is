Imports System.IO

Public Class EmployeeViewModal
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim dbHelper As New DbHelper

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants

    Public Property selectedID As Integer = -1

    Private Sub AdminViewEmployeeModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManageJobDescriptionView()
        loadValues()
    End Sub

    Private Sub loadValues()

        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

        Dim empDt As DataTable = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empIDStr, selectedID)

        If empDt.Rows.Count = 0 Then Exit Sub

        With empDt.Rows(0)
            EmployeeIDTextBox.Text = selectedID

            FirstNameTextBox.Text = .Item(empConst.empFirstStr)
            MiddleNameTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empMidStr))
            LastNameTextBox.Text = .Item(empConst.empLastStr)
            BirthDateTextBox.Text = .Item(empConst.empBirthStr)
            SexTextBox.Text = .Item(empConst.empSexStr)
            CivilStatusTextBox.Text = .Item(empConst.empCivilStr)

            AddressTextBox.Text = .Item(empConst.empAddrStr)
            ContactNumberTextBox.Text = .Item(empConst.empContactStr)
            DateHiredTextBox.Text = .Item(empConst.empHiredStr)

            SSSTextBox.Text = .Item(empConst.empSSSStr)
            PagIbigTextBox.Text = .Item(empConst.empPagibigStr)
            TINTextBox.Text = .Item(empConst.empTINStr)

            JobTypeTextBox.Text = .Item(empConst.empJobPosStr)
            ContractStatusTextBox.Text = .Item(empConst.empStatusStr)

            ' PROFILE
            ProfilePathTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empProfileStr))

            If File.Exists(.Item(empConst.empProfileStr)) Then
                ProfileCirclePictureBox.Image = Image.FromFile(.Item(empConst.empProfileStr))
            End If

            EmailTextBox.Text = .Item(empConst.empEmailStr)
            PasswordTextBox.Text = dbHelper.DecryptPassword(.Item(empConst.empPassStr), constants.EncryptionKey)

            ' ARCHIVE INFO
            ArchiveStatusTextBox.Text = .Item(empConst.empArchStr)
            DateAddedTextBox.Text = .Item(empConst.empAddDateStr)

            LastAccessedTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empLastAccessedStr))
            AddedByTextBox.Text = formUtils.getEmployeeName(.Item(empConst.empAddedByStr))
            Dim empJobType = .Item(empConst.empJobPosStr)

            ' JOB INFO
            Select Case empJobType
                Case constants.getAdminString
                    PositionTextBox.Text = .Item(empConst.empAdminPosStr)
                    EmployeeAddedTextBox.Text = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empAddedByStr, selectedID).Rows.Count

                Case constants.getTechnicianString
                    DevicesRepairedTextBox.Text = getTechStatsNumbers(constants.getFinishedString)
                    NumberJobsAssignedTextBox.Text = getTechStatsNumbers(constants.getPendingString) + getTechStatsNumbers(constants.getFinishedString) + getTechStatsNumbers(constants.getOnholdString) + getTechStatsNumbers(constants.getCanceledString)

                Case constants.getCashierString
                    CustomersHandledTextBox.Text = dbHelper.GetRowByValue(custConst.custTableStr, custConst.custAddedByStr, selectedID).Rows.Count
                    ServiceHandledTxtBox.Text = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.cashierIDStr, selectedID).Rows.Count

                Case constants.getUtilityPersonnelString
                    AssignedLocationTextBox.Text = .Item(empConst.empDestStr)
            End Select

        End With
    End Sub

    Public Function getTechStatsNumbers(status As String) As Integer
        Return formUtils.getTechStatsNumbers(status, selectedID)
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


End Class