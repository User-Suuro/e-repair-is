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

    ' STATES
    Private customerID As String = ""
    Private archivedStatus As Boolean = False
    Private custDT As DataTable

    Public Property selectMode As Boolean = False
    Public Property selectedCustID As Integer = -1

    Private finishedLoad As Boolean = False




    ' FORM ONLOAD
    Private Sub AdminCustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        finishedLoad = True
        LoadDataToDGV()
        CustomerDGV.ClearSelection()
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

    'Export button
    Private Sub CustomerExportBtn_Click(sender As Object, e As EventArgs) Handles CustomerExportBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New CustomerExportModal()
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
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

            custDT = dbHelper.GetAllByCol(searchValues, custConst.custTableStr)

            ' exclude for searching
            searchValues.Remove(.custIDStr)
            searchValues.Remove(.custArchByStr)
            searchValues.Remove(.custArchStr)
            searchValues.Remove(.custArchDateStr)

            formUtils.LoadToDGV(CustomerDGV, custDT, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckbox)

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
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckbox.CheckedChanged
        RefArch()
    End Sub
    Private Sub RefArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(CustomerDGV, ShowArchiveCheckbox, DeleteCustomerBtn, ArchiveCustomerBtn, EditCustomerBtn, AddCustomerBtn)
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


End Class