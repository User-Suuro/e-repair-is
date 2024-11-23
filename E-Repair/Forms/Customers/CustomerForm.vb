Public Class CustomerForm

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    ' SCHEMA
    Private customerID As String = ""
    Private archivedStatus As Boolean = False

    Public Property selectMode As Boolean = False
    Public Property selectedCustID As Integer = -1
    Public Property selectModeTable As DataTable

    ' VIEW
    Private Sub ViewCustomerBtn_Click(sender As Object, e As EventArgs) Handles ViewCustomerBtn.Click
        Dim AdminCustomerViewModal As New CustomerViewModal

    End Sub

    ' ADD
    Private Sub AddCustomerBtn_Click(sender As Object, e As EventArgs) Handles AddCustomerBtn.Click

        Dim addEditModal As New CustomerAddEditModal

    End Sub

    ' EDIT
    Private Sub EditCustomerBtn_Click(sender As Object, e As EventArgs) Handles EditCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        Dim addEditModal As New CustomerAddEditModal


    End Sub

    ' ARCHIVE
    Private Sub ArchiveCustomerBtn_Click(sender As Object, e As EventArgs) Handles ArchiveCustomerBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.archiveRow(archivedStatus, "customers", "customer_id", customerID)
        LoadDataToDGV()
    End Sub

    Private Sub DeleteCustomerBtn_Click(sender As Object, e As EventArgs) Handles DeleteCustomerBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.delRow(archivedStatus, "customers", "customer_id", customerID)
        LoadDataToDGV()
    End Sub

    ' INIT VALUES
    Private Function InitValues() As Boolean
        If Not formUtils.dgvValChecker(CustomerDGV) Then Return False

        With CustomerDGV.CurrentRow
            customerID = .Cells("CUSTOMER_ID").Value
            archivedStatus = .Cells("ARCHIVED").Value
        End With

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub AdminCustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        CustomerDGV.ClearSelection()
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim searchValues() As String = {
            "first_name",
            "middle_name",
            "last_name",
            "contact_number",
            "address",
            "email",
            "date_added"
        }

        formUtils.LoadToDGV(CustomerDGV, "customers", searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox, searchTerm)
        formUtils.FormatDGVForArchive(CustomerDGV)
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class