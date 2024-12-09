Imports System.IO
Imports Org.BouncyCastle.Asn1.X509

Public Class EmployeeViewModal
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim dbHelper As New DbHelper

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants
    Dim itemConst As New ItemsDBConstants

    Public Property selectedID As Integer = -1

    Private jobType As String

    Private Sub AdminViewEmployeeModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadValues()
        ManageJobDescriptionView()
    End Sub

    Private Sub loadValues()

        If Not formUtils.checkIfLoad(selectedID) Then
            Exit Sub
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

            SexTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empSexStr))
            CivilStatusTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empCivilStr))

            AddressTextBox.Text = .Item(empConst.empAddrStr)
            ContactNumberTextBox.Text = .Item(empConst.empContactStr)
            DateHiredTextBox.Text = .Item(empConst.empHiredStr)

            SSSTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empSSSStr))
            PagIbigTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empPagibigStr))
            TINTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empTINStr))

            jobType = .Item(empConst.empJobPosStr)

            JobTypeTextBox.Text = jobType
            ContractStatusTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empStatusStr))

            ' PROFILE
            ProfilePathTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empProfileStr))

            If ProfilePathTextBox.Text <> "N/A" Then
                If File.Exists(.Item(empConst.empProfileStr)) Then
                    ProfileCirclePictureBox.Image = Image.FromFile(.Item(empConst.empProfileStr))
                End If
            End If

            EmailTextBox.Text = .Item(empConst.empEmailStr)
            PasswordTextBox.Text = DecryptPassword(.Item(empConst.empPassStr), constants.EncryptionKey)

            ' ARCHIVE INFO
            ArchiveStatusTextBox.Text = .Item(empConst.empArchStr)
            DateAddedTextBox.Text = .Item(empConst.empAddDateStr)

            LastAccessedTextBox.Text = dbHelper.StrNullCheck(.Item(empConst.empLastAccessedStr))
            AddedByTextBox.Text = formUtils.getEmployeeName(.Item(empConst.addedById))

            Dim empJobType = .Item(empConst.empJobPosStr)

            ' JOB INFO
            Select Case empJobType
                Case constants.getAdminString
                    AdminPosTxtBox.Text = dbHelper.StrNullCheck(.Item(empConst.empAdminPosStr))
                    EmpAddedTxtBox.Text = dbHelper.GetRowByValue(empConst.empTableStr, empConst.addedById, selectedID).Rows.Count
                    SuppAddedTxtBox.Text = dbHelper.GetRowByValue(supConst.supTableStr, supConst.addedByID, selectedID).Rows.Count
                    InventoryAddedTxtBox.Text = dbHelper.GetRowByValue(invConst.invTableStr, invConst.addedByIDStr, selectedID).Rows.Count

                Case constants.getTechnicianString
                    FinishedTxtBox.Text = getTechStatsNumbers(constants.getFinishedString)
                    ClaimedTxtBox.Text = getTechStatsNumbers(constants.getClaimedString)
                    OnholdTxtBox.Text = getTechStatsNumbers(constants.getOnholdString)
                    PendingTxtBox.Text = getTechStatsNumbers(constants.getPendingString)

                Case constants.getCashierString
                    CustAddedTxtBox.Text = dbHelper.GetRowByValue(custConst.custTableStr, custConst.getAddedByID, selectedID).Rows.Count
                    ServiceAddedTxtBox.Text = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.cashierIDStr, selectedID).Rows.Count

                Case constants.getUtilityPersonnelString
                    PersonnelTxtBox.Text = .Item(empConst.empDestStr)
            End Select

        End With
    End Sub

    ' SET JOB DESC VIEW
    Private Sub ManageJobDescriptionView()

        If jobType = constants.getAdminString Then
            AdminTable.Visible = True

            CashierTable.Visible = False
            TechTable.Visible = False
            UtilityTable.Visible = False

        ElseIf jobType = constants.getTechnicianString Then
            TechTable.Visible = True

            CashierTable.Visible = False
            UtilityTable.Visible = False
            AdminTable.Visible = False

        ElseIf jobType = constants.getCashierString Then
            CashierTable.Visible = True

            UtilityTable.Visible = False
            AdminTable.Visible = False
            TechTable.Visible = False

        ElseIf jobType = constants.getUtilityPersonnelString Then
            UtilityTable.Visible = True

            AdminTable.Visible = False
            TechTable.Visible = False
            CashierTable.Visible = False
        End If
    End Sub


    ' FIND TECH STATS NUMS
    Public Function getTechStatsNumbers(status As String) As Integer
        Return formUtils.getTechStatsNumbers(status, selectedID)
    End Function

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class