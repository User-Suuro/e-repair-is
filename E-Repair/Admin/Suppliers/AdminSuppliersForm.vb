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
    Private addedBy As String
    Private archivedStatus As Boolean
    Private dateArchived As DateTime

    ' VIEW
    Private Sub ViewSupplierBtn_Click(sender As Object, e As EventArgs) Handles ViewSupplierBtn.Click
        Dim supplierViewModal As New AdminSupplierViewModal

        If Not InitValues() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", addedBy)

            With supplierViewModal
                .CompanyNameTxtBox.Text = suppCompName
                .ContactPersonTxtBox.Text = contactPerson
                .CompanyEmailTxtBox.Text = email
                .ContactNumberTxtBox.Text = contactNumber
                .LocationTxtBox.Text = suppLoc
                .EstDelivTimeTxtBox.Text = deliveryTime
                .CompanyDescTxtBox.Text = companyDesc
                .SupplierTypeTxtBox.Text = supplierType
                .ContractTypeTxtBox.Text = contractType
                .BankDetailsTxtBox.Text = bankDetails
                .PaymentTermsTxtBox.Text = paymentTerms
                .SupplierIdTextBox.Text = suppID
                .NoSuppliedItemTxtBox.Text = noSuppliedItems
                .TotalPaidTxtBox.Text = totalPaid
                .DateAddedTxtBox.Text = dateAdded
                .AddedByTxtBox.Text = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                .CompanyPathTxtBox.Text = suppProfilePath
                .ShowDialog()
            End With

        Catch ex As Exception

        Finally
            supplierViewModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try


    End Sub

    ' ADD
    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click
        Dim supplierAddEditModal As New AdminSupplierAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With supplierAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
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

    'EDIT
    Private Sub EditSupplierBtn_Click(sender As Object, e As EventArgs) Handles EditSupplierBtn.Click
        Dim supplierAddEditModal As New AdminSupplierAddEditModal

        If Not InitValues() Then Exit Sub

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
                Dim othersChoice As String = "Others"

                If supplierIndex = -1 Then
                    .SupplierTypeCmbBox.SelectedItem = othersChoice
                    .SupplierTypeIfOthersTxtBox.Text = supplierType
                Else
                    .SupplierTypeCmbBox.SelectedIndex = supplierIndex
                End If

                If contractIndex = -1 Then
                    .ContractTypeCmbBox.SelectedItem = othersChoice
                    .ContractTypeIfOthersTxtBox.Text = contractType
                Else
                    .ContractTypeCmbBox.SelectedIndex = contractIndex
                End If

                If BankIndex = -1 Then
                    .BnkDetailsCmbBox.SelectedItem = othersChoice
                    .BankDetailsIfOthersTxtBox.Text = bankDetails
                Else
                    .BnkDetailsCmbBox.SelectedIndex = BankIndex
                End If

                If paymentIndex = -1 Then
                    .PaymentTermsCmbBox.SelectedItem = othersChoice
                    .PaymentTermsIfOthersTxtBox.Text = paymentTerms
                Else
                    .PaymentTermsCmbBox.SelectedIndex = paymentIndex
                End If

                .selectedSupplierID = suppID
                .compProfilePath = suppProfilePath

                .editMode = True
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

    ' ARCHIVE
    Private Sub ArchiveSupplierBtn_Click(sender As Object, e As EventArgs) Handles ArchiveSupplierBtn.Click
        If Not InitValues() Then Exit Sub

        Dim loggedUser As String

        If archivedStatus Then
            MsgBox("This supplier is already archived!")
            Exit Sub
        End If

        Try
            loggedUser = GlobalSession.CurrentSession.EmployeeID

        Catch ex As Exception
            loggedUser = "N/A"
            MsgBox("There is no current active user!")
        End Try

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this Suppplier?") Then Exit Sub

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", loggedUser},
            {"date_archived", DateTime.Now}
        }

        Try
            dbHelper.UpdateRecord("suppliers", "supplier_id", suppID, updatedValues)

            MsgBox("Successfull Archived")
            LoadDataToDGV()

        Catch ex As Exception
            MsgBox("Cannot archive the selected supplier: " & ex.Message)
        End Try
    End Sub

    ' DELETE
    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteServiceBtn.Click
        If Not InitValues() Then Exit Sub

        If Not archivedStatus Then
            MsgBox("Archive the supplier first")
            Exit Sub
        End If

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to delete this Suppplier?") Then Exit Sub

        If dbHelper.DeleteRowById("suppliers", "supplier_id", suppID) Then MsgBox("Successfull Deleted")

        LoadDataToDGV()
    End Sub

    ' INIT VALUES
    Private Function InitValues() As Boolean

        If SuppliersDGV.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return False
        End If

        If SuppliersDGV.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return False
        End If

        If SuppliersDGV.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return False
        End If

        Try
            With SuppliersDGV.CurrentRow
                suppID = .Cells("SUPPLIER_ID").Value
                suppCompName = .Cells("COMPANY_NAME").Value
                companyDesc = .Cells("COMPANY_DESCRIPTION").Value
                contactPerson = .Cells("CONTACT_PERSON").Value
                contactNumber = .Cells("CONTACT_NUMBER").Value
                email = .Cells("COMPANY_EMAIL").Value
                suppLoc = .Cells("LOCATION").Value
                supplierType = .Cells("SUPPLIER_TYPE").Value
                contractType = .Cells("SUPPLIER_CONTRACT").Value
                bankDetails = .Cells("BANK_DETAILS").Value
                paymentTerms = .Cells("PAYMENT_TERMS").Value
                deliveryTime = .Cells("ESTIMATED_DELIVERY_TIME").Value
                noSuppliedItems = dbHelper.GetRowByValue("items", "supplier_id", suppID).Rows.Count
                totalPaid = .Cells("TOTAL_PAID").Value
                suppProfilePath = .Cells("PICTURE_PATH").Value
                dateAdded = .Cells("DATE_ADDED").Value
                addedBy = .Cells("ADDED_BY").Value
                archivedStatus = .Cells("ARCHIVED").Value
            End With

        Catch ex As Exception
            MsgBox("Cannot initialize suppliers value: " & ex.Message)
            Return False
        End Try

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        SuppliersDGV.ClearSelection()
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

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            suppliersTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            suppliersTable.DefaultView.RowFilter = ""
        End If

        SuppliersDGV.AutoGenerateColumns = True
        SuppliersDGV.DataSource = suppliersTable

        FormatDataGridViewRows()
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()

        If ShowArchiveCheckBox.Checked Then
            DeleteServiceBtn.Visible = True
            ArchiveSupplierBtn.Visible = False
            EditSupplierBtn.Visible = False
            AddSupplierBtn.Visible = False

            SuppliersDGV.Columns("DATE_ARCHIVED").Visible = True
        Else
            DeleteServiceBtn.Visible = False
            ArchiveSupplierBtn.Visible = True
            EditSupplierBtn.Visible = True
            AddSupplierBtn.Visible = True
            SuppliersDGV.Columns("DATE_ARCHIVED").Visible = False
        End If
    End Sub

    ' ROW STYLES
    Private Sub FormatDataGridViewRows()


        Try
            For Each row As DataGridViewRow In SuppliersDGV.Rows

                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

                If row.Cells("SUPPLIED_ITEMS").Value Then
                    row.Cells("SUPPLIED_ITEMS").Value = dbHelper.GetRowByValue("suppliers", "supplier_id", row.Cells("supplier_id").Value).Rows.Count
                End If

            Next
        Catch ex As Exception
            MsgBox("Unable to style DGV: " & ex.Message)
        End Try
    End Sub
End Class