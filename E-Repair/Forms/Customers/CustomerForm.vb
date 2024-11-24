Imports System.Runtime.Remoting.Messaging

Public Class CustomerForm

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim custConst As New CustomersDBConstants 

    ' SCHEMA
    Private customerID As String = ""
    Private archivedStatus As Boolean = False

    Public Property selectMode As Boolean = False
    Public Property selectedCustID As Integer = -1
    Public Property selectModeTable As DataTable

    ' INIT VALUES
    Private Function InitValues() As Boolean
        If Not formUtils.dgvValChecker(CustomerDGV) Then Return False

        With CustomerDGV.CurrentRow
            customerID = .Cells("CUSTOMER_ID").Value
            archivedStatus = .Cells("ARCHIVED").Value
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
        formUtils.archiveRow(archivedStatus, custConst.custTableStr, custConst.custIDStr, customerID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteCustomerBtn_Click(sender As Object, e As EventArgs) Handles DeleteCustomerBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.delRow(archivedStatus, custConst.custTableStr, custConst.custIDStr, customerID)
        LoadDataToDGV()
    End Sub

    ' FORM ONLOAD
    Private Sub AdminCustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDGV.ClearSelection()
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        LoadDataToDGV()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        With custConst
            Dim searchValues() As String = {
                .custFirstStr,
                .custMidStr,
                .custLastStr,
                .custContactStr,
                .custAddressStr,
                .custEmailStr,
                .custDateAddedStr
            }
            Dim customersDt = dbHelper.GetAllRowsFromTable(.custTableStr, True)
            formUtils.LoadToDGV(CustomerDGV, customersDt, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex)
            formUtils.FormatDGVForArchive(CustomerDGV)
        End With
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(CustomerDGV, ShowArchiveCheckBox, DeleteCustomerBtn, ArchiveCustomerBtn, EditCustomerBtn, AddCustomerBtn)
    End Sub

    ' SELECT MODE
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitValues() Then Exit Sub

        selectedCustID = customerID

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class