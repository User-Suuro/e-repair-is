Imports System.Linq.Expressions

Public Class AdminSuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Private suppID As String
    Private suppCompName As String
    Private companyDesc As String
    Private contactPerson As String
    Private contactNumber As String
    Private email As String
    Private suppLoc As String
    Private supplierType As String
    Private contractType As String
    Private bankDetails As String
    Private paymentTerms As String
    Private deliveryTime As String
    Private noSuppliedItems As Integer
    Private totalPaid As Decimal
    Private suppProfilePath As String
    Private dateAdded As DateTime
    Private archivedStatus As Boolean
    Private dateArchived As DateTime

    ' INIT VALUES
    Private Function InitValues() As Boolean

        If CheckIfInvalid() Then Return True

        Try
            suppID = SupplierDGV.CurrentRow.Cells("SUPPLIER_ID").Value
            suppCompName = SupplierDGV.CurrentRow.Cells("COMPANY_NAME").Value
            companyDesc = SupplierDGV.CurrentRow.Cells("COMPANY_DESCRIPTION").Value
            contactNumber = SupplierDGV.CurrentRow.Cells("CONTACT_NUMBER").Value
            email = SupplierDGV.CurrentRow.Cells("COMPANY_EMAIL").Value
            suppLoc = SupplierDGV.CurrentRow.Cells("LOCATION").Value
            supplierType = SupplierDGV.CurrentRow.Cells("SUPPLIER_TYPE").Value
            contractType = SupplierDGV.CurrentRow.Cells("CONTRACT_TYPE").Value
            bankDetails = SupplierDGV.CurrentRow.Cells("BANK_DETAILS").Value
            paymentTerms = SupplierDGV.CurrentRow.Cells("PAYMENT_TERMS").Value
            deliveryTime = SupplierDGV.CurrentRow.Cells("ESTIMATED_DELIVERY_TIME").Value
            noSuppliedItems = SupplierDGV.CurrentRow.Cells("NUMBER_SUPPLIED_ITEMS").Value
            totalPaid = SupplierDGV.CurrentRow.Cells("TOTAL_PAID").Value
            suppProfilePath = SupplierDGV.CurrentRow.Cells("PICTURE_PATH").Value
            dateAdded = SupplierDGV.CurrentRow.Cells("DATE_ADDED").Value
            archivedStatus = SupplierDGV.CurrentRow.Cells("ARCHIVED").Value
            dateArchived = SupplierDGV.CurrentRow.Cells("DATE_ARCHIVED").Value

        Catch ex As Exception
            MsgBox("Cannot put values to form modal: " & ex.Message)
        End Try

        Return False
    End Function

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        SupplierDGV.ClearSelection()
    End Sub

    ' ADD
    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click
        Dim supplierAddEditModal As New AdminSupplierAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            supplierAddEditModal.Owner = formModal
            supplierAddEditModal.StartPosition = FormStartPosition.CenterScreen
            supplierAddEditModal.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            supplierAddEditModal.Close()
        Finally
            supplierAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    'EDIT
    Private Sub EditSupplierBtn_Click(sender As Object, e As EventArgs) Handles EditSupplierBtn.Click
        Dim supplierAddEditModal As New AdminSupplierAddEditModal

        If InitValues() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            With supplierAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen

                .CompanyNameTxtBox.Text = suppCompName
                .ContactPersonTxtBox.Text = contactPerson
                .CompanyEmailTxtBox.Text = email
                .ContactNumberTxtBox.Text = contactNumber
                .LocationTxtBox.Text = suppLoc
                .EstDelivTimeTxtBox.Text = deliveryTime
                .CompanyDescTxtBox.Text = companyDesc

                Dim supplierIndex = formUtils.FindComboBoxItemByText(.SupplierTypeCmbBox, supplierType)
                Dim contractIndex = formUtils.FindComboBoxItemByText(.ContractTypeCmbBox, contractType)
                Dim BankIndex = formUtils.FindComboBoxItemByText(.BnkDetailsCmbBox, bankDetails)
                Dim paymentIndex = formUtils.FindComboBoxItemByText(.PaymentTermsCmbBox, paymentTerms)

                If supplierIndex = -1 Then
                    .SupplierTypeCmbBox.SelectedItem = "Others"
                    .SupplierTypeIfOthersTxtBox.Text = supplierType
                Else
                    .SupplierTypeCmbBox.SelectedIndex = supplierIndex
                End If

                If contractIndex = -1 Then
                    .ContractTypeCmbBox.SelectedItem = "Others"
                    .ContractTypeIfOthersTxtBox.Text = contractType
                Else
                    .ContractTypeCmbBox.SelectedIndex = contractIndex
                End If

                If BankIndex = -1 Then
                    .BnkDetailsCmbBox.SelectedItem = "Others"
                    .ContractTypeIfOthersTxtBox.Text = bankDetails
                Else
                    .BnkDetailsCmbBox.SelectedIndex = BankIndex
                End If

                If paymentIndex = -1 Then
                    .PaymentTermsCmbBox.SelectedItem = "Others"
                    .PaymentTermsIfOthersTxtBox.Text = paymentTerms
                Else
                    .PaymentTermsCmbBox.SelectedIndex = paymentIndex
                End If

                .selectedSupplierID = suppID
                .compProfilePath = suppProfilePath

                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            supplierAddEditModal.Close()
        Finally
            supplierAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim suppliersTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            suppliersTable = dbHelper.GetAllRowsFromTable("suppliers", True, True)
        Else
            suppliersTable = dbHelper.GetAllRowsFromTable("suppliers", False)
        End If

        Dim searchBy As String = "company_name"

        With SearchComboBox
            If .SelectedIndex = 0 Then
                searchBy = "company_name"
            ElseIf .SelectedIndex = 1 Then
                searchBy = "contact_person"
            ElseIf .SelectedIndex = 2 Then
                searchBy = "company_number"
            ElseIf .SelectedIndex = 3 Then
                searchBy = "contact_email"
            ElseIf .SelectedIndex = 4 Then
                searchBy = "location"
            ElseIf .SelectedIndex = 5 Then
                searchBy = "estimated_delivery_time"
            ElseIf .SelectedIndex = 6 Then
                searchBy = "total_paid"
            ElseIf .SelectedIndex = 7 Then
                searchBy = "date_added"
            End If
        End With

        ' Search
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            suppliersTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            suppliersTable.DefaultView.RowFilter = ""
        End If

        SupplierDGV.AutoGenerateColumns = True
        SupplierDGV.DataSource = suppliersTable

        FormatDataGridViewRows()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()

        If ShowArchiveCheckBox.Checked Then
            DeleteSupplierBtn.Visible = True
            ArchiveSupplierBtn.Visible = False
            SupplierDGV.Columns("DATE_ARCHIVED").Visible = True
        Else
            DeleteSupplierBtn.Visible = False
            ArchiveSupplierBtn.Visible = True
            SupplierDGV.Columns("DATE_ARCHIVED").Visible = False
        End If
    End Sub

    Private Sub FormatDataGridViewRows()
        Try
            For Each row As DataGridViewRow In SupplierDGV.Rows
                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If
            Next
        Catch ex As Exception
            MsgBox("Unable to style the Employee DGB with no current id session!")
        End Try
    End Sub

    Private Function CheckIfInvalid() As Boolean
        If SupplierDGV.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return True
        End If

        If SupplierDGV.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return True
        End If

        If SupplierDGV.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return True
        End If

        Return False
    End Function

End Class