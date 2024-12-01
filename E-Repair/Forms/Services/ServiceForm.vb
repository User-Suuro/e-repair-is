

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
    Private serviceDT As DataTable = Nothing

    Public Property selectMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property pendingOnly As Boolean = False

    Private finishedLoad As Boolean = False

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

        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        If selectMode Then SearchStatusCmb.Visible = False
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
        If Not InitData() AndAlso Not isFinished() AndAlso isPaid() Then Exit Sub

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

    ' ARCHIVE
    Private Sub ArchiveServiceBtn_Click(sender As Object, e As EventArgs) Handles ArchiveServiceBtn.Click
        If Not InitData() AndAlso isFinished() AndAlso isPaid() Then Exit Sub
        formUtils.ArchiveRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, serviceID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteServiceBtn_Click(sender As Object, e As EventArgs) Handles DeleteServiceBtn.Click
        If Not InitData() AndAlso isFinished() AndAlso isPaid() Then Exit Sub
        formUtils.DeleteRow(is_archived, servConst.svcTableStr, servConst.svcIDStr, serviceID)
        RefForArch()
    End Sub

    ' LOAD TO DGV
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        If Not finishedLoad Then Exit Sub

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
                .svcStatusStr
            }

            If pendingOnly Then
                serviceDT = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcStatusStr, constants.getPendingString)
            Else
                serviceDT = dbHelper.GetAllData(.svcTableStr)
            End If

            ' Additonal payload
            serviceDT.Columns.Add(custCol, GetType(String))
            serviceDT.Columns.Add(techCol, GetType(String))

            For Each row As DataRow In serviceDT.Rows
                row(custCol) = formUtils.getCustomerName(row(servConst.custIDStr))
                row(techCol) = formUtils.getEmployeeName(row(servConst.techIDStr))
            Next

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
        End With
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' INIT CMBDS
    Private Sub initCmbds(index01 As Integer)
        Dim getStatusEnums As New List(Of String)(dbHelper.GetEnums(servConst.svcTableStr, servConst.svcStatusStr))

        ' rearrange  list
        Dim reArrangedList As New List(Of String) From {
            getStatusEnums(1),
            getStatusEnums(2),
            getStatusEnums(3),
            getStatusEnums(4),
            getStatusEnums(0),
            "All"
        }

        SearchStatusCmb.DataSource = reArrangedList
        SearchStatusCmb.SelectedIndex = index01
    End Sub

    ' SEARCH STATUS BOX
    Private Sub SearchStatusCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchStatusCmb.SelectedIndexChanged
        currentSearchVal = SearchStatusCmb.SelectedItem

        If SearchStatusCmb.SelectedItem = "All" Then
            currentSearchVal = ""
        End If

        ' for claimed/finished

        loadToolsView()
        LoadDataToDGV()
    End Sub

    Private Sub loadToolsView()

        If currentSearchVal = constants.getFinishedString Then
            ClaimServiceBtn.Visible = True
        Else
            ClaimServiceBtn.Visible = False
        End If

        If currentSearchVal = constants.getClaimedString Then
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
        End If

        If Current.position = constants.getTechnicianString Then
            ClaimServiceBtn.Visible = False
        End If

    End Sub

    Private Sub RefForArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(ServiceDGV, ShowArchiveCheckBox, DeleteServiceBtn, ArchiveServiceBtn, EditServiceBtn, AddServiceBtn)
    End Sub

    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        If ShowArchiveCheckBox.Checked Then SearchStatusCmb.SelectedItem = constants.getClaimedString
        RefForArch()

        If ShowArchiveCheckBox.Checked Then
            ClaimServiceBtn.Visible = False
        Else
            ClaimServiceBtn.Visible = True
        End If
    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Then Exit Sub
        selectedID = serviceID
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
