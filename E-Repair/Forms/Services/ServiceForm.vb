Imports Org.BouncyCastle.Math.EC

Public Class ServiceForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants

    Private serviceID As Integer = -1
    Private is_archived As Boolean = False
    Private serviceStatus As String = ""
    Private is_paid As Boolean = False

    ' CONSTANTS
    Private currentSearchVal As String = ""
    Private currentSearchCol As String = ""
    Dim searchStatusList As List(Of String) = dbHelper.GetEnums(servConst.svcTableStr, servConst.svcStatusStr)

    Public Property selectMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property serviceDT As DataTable = Nothing

    Private Function InitData() As Boolean
        searchStatusList.Add("Archived")
        If Not formUtils.dgvValChecker(ServiceDGV) Then Return False

        ' INITIALIZE VALUES
        With ServiceDGV.CurrentRow
            serviceID = .Cells(servConst.svcIDStr).Value
            is_archived = .Cells(servConst.archivedStr).Value
            serviceStatus = .Cells(servConst.svcStatusStr).Value
            is_paid = .Cells(servConst.paidStr).Value
        End With

        Return True
    End Function

    Private Function isFinished() As Boolean
        If serviceStatus <> constants.getFinishedString Then
            MsgBox("Restricted Action due to pending/unclaimed service")
            Return False
        End If

        Return True
    End Function

    Private Function isPaid() As Boolean
        ' DO ADDITIONAL CHECKERS FOR EVALUATING
        If Not is_paid Then
            MsgBox("Restricted action due unpaid service")
            Return False
        End If

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub ServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initCmbds(0)
        currentSearchVal = searchStatusList(SearchStatusCmb.SelectedIndex)
        LoadDataToDGV()
        ServiceDGV.ClearSelection()
        loadUserDisplay()
    End Sub

    Private Sub loadUserDisplay()
        Select Case Current.position
            Case constants.getSuperAdminString
                ClaimServiceBtn.Visible = True
                EvaluateServiceBtn.Visible = True
            Case constants.getCashierString
                ClaimServiceBtn.Visible = True
                ArchiveServiceBtn.Visible = False
                DeleteServiceBtn.Visible = False
            Case constants.getTechnicianString
                AddServiceBtn.Visible = False
                EvaluateServiceBtn.Visible = False
        End Select
    End Sub

    ' CLAIM
    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click
        If Not InitData() Or Not isFinished() Then Exit Sub

        formUtils.ShowModalWithHandler(
          Function(id)
              Dim modal As New ServiceClaimModal
              modal.selectedID = id
              Return modal
          End Function,
          serviceID,
          Function(modal)
              Return Nothing
          End Function
          )

        LoadDataToDGV()
    End Sub

    ' EVALUATE
    Private Sub EvaluateServiceBtn_Click(sender As Object, e As EventArgs) Handles EvaluateServiceBtn.Click
        If Not InitData() Then Exit Sub

        If isPaid() Then
            MsgBox("This service is already claimed by customer")
            Exit Sub
        End If

        formUtils.ShowModalWithHandler(
          Function(id)
              Dim modal As New ServiceEvaluationModal
              modal.selectedID = id
              Return modal
          End Function,
          serviceID,
          Function(modal)
              Return Nothing
          End Function
          )

        LoadDataToDGV()
    End Sub

    ' VIEW
    Private Sub ViewServiceBtn_Click(sender As Object, e As EventArgs) Handles ViewServiceBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
           Function(id)
               Dim modal As New ServiceViewModal
               modal.selectedID = id
               Return modal
           End Function,
           serviceID,
           Function(modal)
               Return Nothing
           End Function
           )

        LoadDataToDGV(currentSearchVal)
    End Sub

    ' ADD 
    Private Sub AddServiceBtn_Click(sender As Object, e As EventArgs) Handles AddServiceBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New ServiceAddEditModal()
            modal.selectedID = id
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV(currentSearchVal)
    End Sub

    ' EDIT
    Private Sub EditServiceBtn_Click(sender As Object, e As EventArgs) Handles EditServiceBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New ServiceAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        serviceID,
        Function(modal)
            Return Nothing
        End Function)

        LoadDataToDGV(currentSearchVal)
    End Sub

    ' ARCHIVE
    Private Sub ArchiveServiceBtn_Click(sender As Object, e As EventArgs) Handles ArchiveServiceBtn.Click
        If Not InitData() Or Not isFinished() Or Not isPaid() Then Exit Sub
        formUtils.ArchiveRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, selectedID)
        LoadDataToDGV(currentSearchVal)
    End Sub

    ' DELETE
    Private Sub DeleteServiceBtn_Click(sender As Object, e As EventArgs) Handles DeleteServiceBtn.Click
        If Not InitData() Or Not isFinished() Or Not isPaid() Then Exit Sub
        formUtils.DeleteRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, selectedID)
        LoadDataToDGV(currentSearchVal)
    End Sub

    ' LOAD TO DGV
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim custCol As String = "customer_name"
        Dim techCol As String = "technician_name"

        With servConst

            Dim searchCols01 As New List(Of String) From {
                custCol,
                techCol,
                .devModelStr,
                .devBrandStr,
                .dateAddedStr
            }

            Dim searchCols02 As New List(Of String) From {
                .svcStatusStr,
                .svcStatusStr,
                .svcStatusStr,
                .svcStatusStr,
                .archivedStr
            }

            If Not selectMode Then serviceDT = dbHelper.GetAllData(.svcTableStr)

            ' Additonal payload
            serviceDT.Columns.Add(custCol, GetType(String))
            serviceDT.Columns.Add(techCol, GetType(String))

            For Each row As DataRow In serviceDT.Rows
                row(custCol) = formUtils.getCustomerName(row(servConst.custIDStr))
                row(techCol) = formUtils.getEmployeeName(row(servConst.techIDStr))
            Next

            formUtils.LoadToDGVByTwoValues(ServiceDGV,
                                           serviceDT,
                                           searchTerm,
                                           currentSearchVal,
                                           searchCols01,
                                           searchCols02,
                                           SearchComboBox.SelectedIndex,
                                           SearchStatusCmb.SelectedIndex)
        End With
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub


    ' INIT CMBDS
    Private Sub initCmbds(index01 As Integer)
        dbHelper.LoadEnumsToCmb(SearchStatusCmb, servConst.svcTableStr, servConst.svcStatusStr, index01)
    End Sub

    ' SEARCH TXT BOX
    Private Sub SearchStatusCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchStatusCmb.SelectedIndexChanged
        currentSearchVal = searchStatusList(SearchStatusCmb.SelectedIndex)

        If SearchStatusCmb.SelectedItem = "Archived" Then
            formUtils.FormatChkBoxForArchive(ServiceDGV, ShowArchiveCheckBox, DeleteServiceBtn, ArchiveServiceBtn, EditServiceBtn, AddServiceBtn)
        End If

        LoadDataToDGV()
    End Sub


End Class
