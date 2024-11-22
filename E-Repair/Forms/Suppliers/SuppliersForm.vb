Imports System.Linq.Expressions
Imports Google.Protobuf.Compiler

Public Class SuppliersForm
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

    Public selectMode As Boolean = False

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

    ' VIEW
    Private Sub ViewSupplierBtn_Click(sender As Object, e As EventArgs) Handles ViewSupplierBtn.Click
        Dim supplierViewModal As New SupplierViewModal

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
            MsgBox("Cannot create view supplier modal: " & ex.Message)
        Finally
            supplierViewModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    ' ADD
    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click
        Dim supplierAddEditModal As New SupplierAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With supplierAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Unable to show add suppliers modal: " & ex.Message)
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
        Dim supplierAddEditModal As New SupplierAddEditModal

        If Not InitValues() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            With supplierAddEditModal
                .Owner = formModal
                .SupplierModalGroupBox.Text = "Edit Supplier"
                .InitCmbDs(-1, -1, -1, -1)

                .CompanyNameTxtBox.Text = suppCompName
                .ContactPersonTxtBox.Text = contactPerson
                .CompanyEmailTxtBox.Text = email
                .ContactNumberTxtBox.Text = contactNumber
                .LocationTxtBox.Text = suppLoc
                .EstDelivTimeTxtBox.Text = deliveryTime
                .CompanyDescTxtBox.Text = companyDesc
                .compProfilePath = suppProfilePath

                Dim supplierIndex = formUtils.FindComboBoxItemByText(.SupplierTypeCmbBox, supplierType)
                Dim contractIndex = formUtils.FindComboBoxItemByText(.ContractTypeCmbBox, contractType)
                Dim BankIndex = formUtils.FindComboBoxItemByText(.BnkDetailsCmbBox, bankDetails)
                Dim paymentIndex = formUtils.FindComboBoxItemByText(.PaymentTermsCmbBox, paymentTerms)

                .InitCmbDs(supplierIndex, contractIndex, BankIndex, paymentIndex)

                'Dim othersChoice As String = "Others"

                'If supplierIndex = -1 Then
                '    .SupplierTypeCmbBox.SelectedItem = othersChoice
                '    .SupplierTypeIfOthersTxtBox.Text = supplierType
                'Else
                '    .SupplierTypeCmbBox.SelectedIndex = supplierIndex
                'End If

                'If contractIndex = -1 Then
                '    .ContractTypeCmbBox.SelectedItem = othersChoice
                '    .ContractTypeIfOthersTxtBox.Text = contractType
                'Else
                '    .ContractTypeCmbBox.SelectedIndex = contractIndex
                'End If

                'If BankIndex = -1 Then
                '    .BnkDetailsCmbBox.SelectedItem = othersChoice
                '    .BankDetailsIfOthersTxtBox.Text = bankDetails
                'Else
                '    .BnkDetailsCmbBox.SelectedIndex = BankIndex
                'End If

                'If paymentIndex = -1 Then
                '    .PaymentTermsCmbBox.SelectedItem = othersChoice
                '    .PaymentTermsIfOthersTxtBox.Text = paymentTerms
                'Else
                '    .PaymentTermsCmbBox.SelectedIndex = paymentIndex
                'End If

                .selectedSupplierID = suppID

                .editMode = True
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox("Unable to show add/edit modal: " & ex.Message)
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
        formUtils.archiveRow(archivedStatus, "suppliers", "supplier_id", suppID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.delRow(archivedStatus, "suppliers", "supplier_id", suppID)
        LoadDataToDGV()
    End Sub

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        SuppliersDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        Dim searchValues() As String = {
           "company_name",
           "contact_person",
           "contact_number",
           "company_email",
           "location",
           "estimated_delivery_time",
           "total_paid",
           "date_added"
        }

        formUtils.LoadToDGV(SuppliersDGV, "suppliers", searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox, searchTerm)
        formUtils.FormatDGVForArchive(SuppliersDGV)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(SuppliersDGV, ShowArchiveCheckBox, DeleteSupplierBtn, ArchiveSupplierBtn, EditSupplierBtn, AddSupplierBtn)
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub
End Class