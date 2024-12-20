﻿
Public Class ServiceForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim servConst As New ServiceDBConstants
    Dim constants As New Constants

    Private serviceID As Integer = -1
    Private is_archived As Boolean = False
    Private serviceStatus As String = ""
    Private is_paid As Boolean = False

    ' CONSTANTS
    Private currentSearchVal As String = ""
    Private currentSearchCol As String = ""

    ' STATES
    Private finishedLoad As Boolean = False
    Private serviceDT As DataTable

    Public Property selectMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property pendingOnly As Boolean = False

    Private Function InitData() As Boolean

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
        finishedLoad = True
        LoadDataToDGV()
        ServiceDGV.ClearSelection()
        loadUserDisplay()
        loadToolsView()

        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckbox)

        If selectMode Then
            SearchStatusCmb.Visible = False
            ServiceExportBtn.Visible = False
            AcceptBtn.Visible = False
            EvaluateServiceBtn.Visible = False
            SearchStatusCmb.SelectedIndex = formUtils.FindComboBoxItemByText(SearchStatusCmb, constants.getPendingString)
        End If

    End Sub

    ' adjust view for posiitons
    Private Sub loadUserDisplay()
        Select Case Current.position
            Case constants.getSuperAdminString

                ClaimServiceBtn.Visible = True
                EvaluateServiceBtn.Visible = True

            Case constants.getCashierString

                ClaimServiceBtn.Visible = True
                EvaluateServiceBtn.Visible = False
                AcceptBtn.Visible = False

            Case constants.getTechnicianString

                EvaluateServiceBtn.Visible = True
                AcceptBtn.Visible = True

                AddServiceBtn.Visible = False
                EditServiceBtn.Visible = False
                ArchiveServiceBtn.Visible = False
                ClaimServiceBtn.Visible = False

        End Select
    End Sub

    ' CLAIM
    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click
        If Not InitData() AndAlso Not isFinished() AndAlso isPaid() Then Exit Sub

        If serviceStatus <> constants.getFinishedString Then
            MsgBox("You can only claim finished commissions")
            Exit Sub
        End If

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

        If serviceStatus <> constants.getPendingString Then
            MsgBox("You can only pending commissions")
            Exit Sub
        End If

        If is_paid Then
            MsgBox("Sevice was already claimed by the customer")
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

        LoadDataToDGV()
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

        LoadDataToDGV()
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

        LoadDataToDGV()
    End Sub

    ' ACCEPT COMMISSION
    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click

        ' CHECKERS
        If Not InitData() Then Exit Sub
        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to accept this service?") Then Exit Sub

        If serviceStatus <> constants.getQueuedStr Then
            MsgBox("You can only accept queued commissions")
            Exit Sub
        End If

        With servConst
            Dim update As New Dictionary(Of String, Object) From {
                { .techIDStr, Current.id},
                { .techNameStr, formUtils.getEmployeeName(Current.id)},
                { .svcStatusStr, constants.getPendingString},
                { .getDateAccepted, DateTime.Now}
            }

            If dbHelper.UpdateRecord(.svcTableStr, .svcIDStr, serviceID, update) Then
                MsgBox("You have accepted the commission")
                dbHelper.Logs($"Accepted Commission: {serviceID}", Current.id)
            End If
        End With

        LoadDataToDGV()
    End Sub

    ' ARCHIVE
    Private Sub ArchiveServiceBtn_Click(sender As Object, e As EventArgs) Handles ArchiveServiceBtn.Click
        If Not InitData() AndAlso isFinished() AndAlso isPaid() Then Exit Sub
        formUtils.ArchiveRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, serviceID, "Archived Service: " & serviceID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteServiceBtn_Click(sender As Object, e As EventArgs) Handles DeleteServiceBtn.Click
        If Not InitData() AndAlso isFinished() AndAlso isPaid() Then Exit Sub
        formUtils.DeleteRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, serviceID, "Deleted Service: " & serviceID)
        RefForArch()
    End Sub

    'Export button
    Private Sub serviceExportBtn_Click(sender As Object, e As EventArgs) Handles ServiceExportBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New ServicesExportModal()
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
    End Sub

    ' LOAD TO DGV
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        If Not finishedLoad Then Exit Sub

        With servConst
            Dim searchCols01 As New List(Of String) From {
                .custNameStr,
                .techNameStr,
                .devModelStr,
                .dateAddedStr,
                .svcStatusStr, ' exclude from search
                .dateArchivedStr,
                .archivedStr,
                .svcIDStr,
                .custIDStr,
                .techIDStr
            }

            Dim searchCols02 As New List(Of String) From {
                .svcStatusStr,
                .svcStatusStr,
                .svcStatusStr,
                .svcStatusStr,
                .svcStatusStr
            }

            Cursor = Cursors.WaitCursor


            If pendingOnly Then

                ' get technician pending only view
                If Current.position = constants.getTechnicianString Then
                    serviceDT = dbHelper.GetRowByTwoValues(.svcTableStr, .techIDStr, Current.id, .svcStatusStr, constants.getPendingString)
                Else
                    serviceDT = dbHelper.GetRowByValue(.svcTableStr, .svcStatusStr, constants.getPendingString)
                End If

            Else

                ' get all technician view
                If Current.position = constants.getTechnicianString Then

                    If SearchStatusCmb.SelectedItem = constants.getQueuedStr Then
                        serviceDT = dbHelper.GetRowByColValue(searchCols01, .svcTableStr, .svcStatusStr, constants.getQueuedStr)
                    Else
                        serviceDT = dbHelper.GetRowByColValue(searchCols01, .svcTableStr, .techIDStr, Current.id)
                    End If

                Else
                    serviceDT = dbHelper.GetAllByCol(searchCols01, .svcTableStr)
                End If

            End If

            ' exlucde from search
            searchCols01.Remove(.archivedStr)
            searchCols01.Remove(.dateArchivedStr)
            searchCols01.Remove(.svcStatusStr)
            searchCols01.Remove(.custIDStr)
            searchCols01.Remove(.svcIDStr)
            searchCols01.Remove(.techIDStr)

            ' this function is chonky af
            formUtils.LoadToDGVByTwoValues(ServiceDGV,
                                           serviceDT,
                                           searchTerm,
                                           currentSearchVal,
                                           searchCols01,
                                           searchCols02,
                                           SearchComboBox.SelectedIndex,
                                           SearchStatusCmb.SelectedIndex,
                                           ShowArchiveCheckBox)


            Cursor = Cursors.Default
        End With
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataToDGV(SearchTextBox.Text)
            e.SuppressKeyPress = True ' Prevents the beep sound when pressing Enter
        End If
    End Sub

    ' INIT CMBDS

    Private Sub initCmbds(index01 As Integer)
        Dim getStatusEnums As New List(Of String)(dbHelper.GetEnums(servConst.svcTableStr, servConst.svcStatusStr))

        ' rearrange  list
        Dim reArrangedList As New List(Of String) From {
            getStatusEnums(0), ' QUEUED
            getStatusEnums(2), ' PENDING
            getStatusEnums(3), ' FINISHED
            getStatusEnums(1), ' CLAIMED
            getStatusEnums(4), ' ONHOLD
            getStatusEnums(5), ' CANCELED
            "All"
        }

        SearchStatusCmb.DataSource = reArrangedList
        SearchStatusCmb.SelectedIndex = index01
    End Sub

    ' SEARCH STATUS CMB

    Private Sub SearchStatusCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchStatusCmb.SelectedIndexChanged
        currentSearchVal = SearchStatusCmb.SelectedItem

        If SearchStatusCmb.SelectedItem = "All" Then
            currentSearchVal = ""
        End If

        ' for claimed/finished

        loadToolsView()
        If finishedLoad Then LoadDataToDGV()
    End Sub

    ' REFRESH FOR ARCH

    Private Sub RefForArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(ServiceDGV, ShowArchiveCheckbox, DeleteServiceBtn, ArchiveServiceBtn, EditServiceBtn, AddServiceBtn)
    End Sub

    ' SHOW ARCH
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckbox.CheckedChanged
        If ShowArchiveCheckbox.Checked Then SearchStatusCmb.SelectedItem = constants.getClaimedString
        If finishedLoad Then RefForArch()

        If ShowArchiveCheckbox.Checked Then
            ClaimServiceBtn.Visible = False
        Else
            ClaimServiceBtn.Visible = True
        End If
    End Sub

    ' SEARCH CMB
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        If finishedLoad Then LoadDataToDGV(SearchTextBox.Text)
    End Sub


    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Then Exit Sub
        selectedID = serviceID
        Me.Close()
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' LOAD USER VIEW
    Private Sub loadToolsView()

        If SearchStatusCmb.SelectedItem = constants.getFinishedString Then
            ClaimServiceBtn.Visible = True
        Else
            ClaimServiceBtn.Visible = False
        End If

        If SearchStatusCmb.SelectedItem = constants.getQueuedStr Then
            AcceptBtn.Visible = True
        Else
            AcceptBtn.Visible = False
        End If

        If SearchStatusCmb.SelectedItem = constants.getPendingString Then
            EvaluateServiceBtn.Visible = True
        Else
            EvaluateServiceBtn.Visible = False
        End If

        If SearchStatusCmb.SelectedItem = constants.getClaimedString Then
            EvaluateServiceBtn.Visible = False
            ArchiveServiceBtn.Visible = True
        Else
            EvaluateServiceBtn.Visible = True
            ArchiveServiceBtn.Visible = False
        End If

        ' for archive / delete

        If SearchStatusCmb.SelectedItem = "All" Then
            EvaluateServiceBtn.Visible = False
            ClaimServiceBtn.Visible = False
        End If

        ' positions

        If Current.position = constants.getCashierString Then
            EvaluateServiceBtn.Visible = False
            AcceptBtn.Visible = False
        End If

        If Current.position = constants.getTechnicianString Then
            ClaimServiceBtn.Visible = False
            ArchiveServiceBtn.Visible = False
            AcceptBtn.Visible = True
        End If

        If selectMode Then
            EvaluateServiceBtn.Visible = False
            AcceptBtn.Visible = False
        End If

    End Sub


End Class
