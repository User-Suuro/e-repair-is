Imports System.Net.Sockets
Imports System.Runtime.CompilerServices

Public Class CustomerForm

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Dim exportUtils As New ExportUtils

    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants

    Dim constants As New Constants

    ' SCHEMA
    Private customerID As String = ""
    Private archivedStatus As Boolean = False

    Public Property selectMode As Boolean = False
    Public Property selectedCustID As Integer = -1

    Private customersDt As DataTable = Nothing

    Private finishedLoad As Boolean = False


    ' disable cud
    Private Sub disableCud()

        AddCustomerBtn.Visible = False
        EditCustomerBtn.Visible = False
        ArchiveCustomerBtn.Visible = False
        DeleteCustomerBtn.Visible = False

    End Sub

    ' FORM ONLOAD
    Private Sub AdminCustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        finishedLoad = True
        LoadDataToDGV()
        CustomerDGV.ClearSelection()

        ' adjust views for positions
        If Current.position = constants.getTechnicianString Then disableCud()
    End Sub



    ' INIT VALUES
    Private Function InitValues() As Boolean
        If Not formUtils.dgvValChecker(CustomerDGV) Then Return False

        With CustomerDGV.CurrentRow
            customerID = .Cells(custConst.custIDStr).Value
            archivedStatus = .Cells(custConst.custArchStr).Value
        End With

        Return True
    End Function

    ' VIEW
    Private Sub ViewCustomerBtn_Click(sender As Object, e As EventArgs) Handles ViewCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        Dim result = formUtils.ShowModalWithHandler(
            Function(id As Object)
                Dim modal As New CustomerViewModal()
                modal.selectedID = id
                Return modal
            End Function,
            customerID,
            Function(modal)
                Return Nothing
            End Function
            )
    End Sub

    ' ADD
    Private Sub AddCustomerBtn_Click(sender As Object, e As EventArgs) Handles AddCustomerBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New CustomerAddEditModal()
            modal.selectedID = id
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function)

        LoadDataToDGV()
    End Sub

    ' EDIT
    Private Sub EditCustomerBtn_Click(sender As Object, e As EventArgs) Handles EditCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New CustomerAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        customerID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    ' ARCHIVE
    Private Sub ArchiveCustomerBtn_Click(sender As Object, e As EventArgs) Handles ArchiveCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        Dim pendingCommissions As Integer = dbHelper.GetRowByTwoValues(servConst.svcTableStr, servConst.custIDStr, customerID, servConst.svcStatusStr, constants.getPendingString).Rows.Count

        If pendingCommissions <> 0 Then
            MsgBox("You cannot archive customers that has " & pendingCommissions & " pending commissions")
            Exit Sub
        End If

        formUtils.ArchiveRow(archivedStatus, custConst.custTableStr, custConst.custIDStr, customerID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteCustomerBtn_Click(sender As Object, e As EventArgs) Handles DeleteCustomerBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.DeleteRow(archivedStatus, custConst.custTableStr, custConst.custIDStr, customerID)
        RefArch()
    End Sub



    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        If Not finishedLoad Then Exit Sub

        With custConst
            Dim searchValues As New List(Of String) From {
                .custIDStr,
                .custArchStr,
                .custArchDateStr,
                .custArchByStr,
                .custFirstStr,
                .custMidStr,
                .custLastStr,
                .custContactStr,
                .custAddressStr,
                .custEmailStr,
                .custDateAddedStr
            }

            Cursor = Cursors.WaitCursor

            customersDt = dbHelper.GetAllByCol(searchValues, custConst.custTableStr)

            ' exclude for searching
            searchValues.Remove(.custIDStr)
            searchValues.Remove(.custArchByStr)
            searchValues.Remove(.custArchStr)
            searchValues.Remove(.custArchDateStr)

            formUtils.LoadToDGV(CustomerDGV, customersDt, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)

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

    ' SEARCH CMB
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        RefArch()
    End Sub
    Private Sub RefArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(CustomerDGV, ShowArchiveCheckBox, DeleteCustomerBtn, ArchiveCustomerBtn, EditCustomerBtn, AddCustomerBtn)
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' SELECT MODE
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitValues() Or Not selectMode Then Exit Sub

        selectedCustID = customerID

        Me.Close()
    End Sub

    Private Sub ExportToExcelBtn_Click(sender As Object, e As EventArgs) Handles ExportToExcelBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

        With custConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .custIDStr, "Customer ID"},
              { .custFirstStr, "First Name"},
              { .custMidStr, "Middle Name"},
              { .custLastStr, "Last Name"},
              { .custContactStr, "Contact Number"},
              { .custAddressStr, "Address"},
              { .custGenderStr, "Gender"},
              { .custEmailStr, "Email"},
              { .custTotalPaidStr, "Total Paid"},
              { .getAddedByName, "Added by"},
              { .custDateAddedStr, "Date Added"},
              { .custArchDateStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, custConst.custTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title = "All Inventory Reports"

            If ExportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub
End Class