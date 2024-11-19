Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class AdminCustomerForm

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    ' SCHEMA
    Private customerID As String = ""
    Private firstName As String = ""
    Private middleName As String = ""
    Private lastName As String = ""
    Private custGender As String = ""
    Private custEmail As String = ""
    Private contactNumber As String = ""
    Private custAddress As String = ""

    Private pending As Integer = -1
    Private onHold As Integer = -1
    Private canceled As Integer = -1
    Private completed As Integer = -1
    Private totalServices As Integer = -1

    Private totalPaid As Decimal

    Private lastTransaction As String = ""
    Private addedBy As String = ""
    Private dateAdded As String = ""

    Private archivedStatus As Boolean = False
    Private archivedBy As String = ""
    Private dateArchived As String = ""

    Private Sub ViewCustomerBtn_Click(sender As Object, e As EventArgs) Handles ViewCustomerBtn.Click
        Dim AdminCustomerViewModal As New AdminCustomerViewModal

        If Not InitValues() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()
            Dim getEmpData As DataRow = dbHelper.GetRowByValue("employees", "employee_id", addedBy).Rows(0)

            With AdminCustomerViewModal
                .Owner = formModal

                .FirstNameTextBox.Text = firstName
                .MiddleNameTextBox.Text = middleName
                .LastNameTextBox.Text = lastName
                .GenderTxtBox.Text = custGender
                .EmailTxtBox.Text = custEmail
                .ContactNumberTxtBox.Text = contactNumber
                .AddressTxtBox.Text = custAddress

                .PendingServicesTxtBox.Text = pending
                .OnholdTxtBox.Text = onHold
                .CanceledTxtBox.Text = canceled
                .CompletedServicesTxtBox.Text = completed
                .TotalServicesTxtBox.Text = totalServices

                .TotalPaidTxtBox.Text = totalPaid
                .LastTransactionTxtBox.Text = lastTransaction

                .AddedByTxtBox.Text = getEmpData("firstname") & " " & getEmpData("lastname")
                .DateAddedTxtBox.Text = dateAdded

                .ArchivedStatusTxtBox.Text = archivedStatus

                .ArchivedByTxtBox.Text = archivedBy
                .DateAddedTxtBox.Text = dateAdded

                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Cannot display customer view modal: " & ex.Message)
            formModal.Close()
            AdminCustomerViewModal.Close()
        Finally
            formModal.Dispose()
        End Try


    End Sub

    Private Sub AddCustomerBtn_Click(sender As Object, e As EventArgs) Handles AddCustomerBtn.Click

        Dim addEditModal As New AdminCustomerAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()

            With addEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            addEditModal.Close()
        Finally
            addEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    Private Sub EditCustomerBtn_Click(sender As Object, e As EventArgs) Handles EditCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        Dim addEditModal As New AdminCustomerAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()

            With addEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .CustomerModalGroupBox.Text = "Edit Customer"

                .selectedCustomerID = customerID
                .FirstNameTxtBox.Text = firstName
                .MiddleNameTxtBox.Text = middleName
                .LastNameTxtBox.Text = lastName

                Dim genderIndex = formUtils.FindComboBoxItemByText(.GenderComboBox, custGender)

                If genderIndex <> -1 Then
                    .GenderComboBox.SelectedIndex = genderIndex
                Else
                    .GenderComboBox.SelectedItem = "Others"
                    .GenderOthersTxtBox.Text = custGender
                End If

                .EmailTxtBox.Text = custEmail
                .editMode = True

                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            addEditModal.Close()
        Finally
            addEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try

    End Sub

    Private Sub ArchiveCustomerBtn_Click(sender As Object, e As EventArgs) Handles ArchiveCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        Dim loggedUser As String

        If archivedStatus Then
            MsgBox("This employee is already archived!")
            Exit Sub
        End If

        Try
            loggedUser = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            loggedUser = "N/A"
            MsgBox("There is no current active user!")
        End Try

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this Customer") Then Exit Sub

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", loggedUser},
            {"date_archived", DateTime.Now}
        }

        Try
            dbHelper.UpdateRecord("customers", "customer_id", customerID, updatedValues)
            MsgBox("Successfull Archived")
            LoadDataToDGV()

        Catch ex As Exception
            MsgBox("Cannot archived the selected customer: " & ex.Message)
        End Try

    End Sub

    Private Sub DeleteCustomerBtn_Click(sender As Object, e As EventArgs) Handles DeleteCustomerBtn.Click
        If Not InitValues() Then Exit Sub

        If Not archivedStatus Then
            MsgBox("Please archive the given row first")
            Exit Sub
        End If

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you Sure you want to delete this customer?") Then Exit Sub

        dbHelper.DeleteRowById("customers", "customer_id", customerID)

        MsgBox("Successfully Deleted")

        LoadDataToDGV()
    End Sub

    ' INIT VALUES
    Private Function InitValues() As Boolean
        If CustomerDGV.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return False
        End If

        If CustomerDGV.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return False
        End If

        If CustomerDGV.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return False
        End If

        Try
            With CustomerDGV.CurrentRow
                customerID = .Cells("CUSTOMER_ID").Value
                firstName = .Cells("FIRST_NAME").Value

                middleName = dbHelper.StrNullCheck(.Cells("MIDDLE_NAME").Value)
                lastName = .Cells("LAST_NAME").Value
                custGender = .Cells("GENDER").Value
                custEmail = dbHelper.StrNullCheck(.Cells("EMAIL").Value)
                contactNumber = dbHelper.StrNullCheck(.Cells("CONTACT_NUMBER").Value)
                custAddress = dbHelper.StrNullCheck(.Cells("ADDRESS").Value)

                totalPaid = .Cells("TOTAL_PAID").Value
                lastTransaction = dbHelper.StrNullCheck(.Cells("LAST_TRANSACTION").Value)
                addedBy = .Cells("ADDED_BY").Value
                dateAdded = .Cells("DATE_ADDED").Value

                archivedStatus = .Cells("ARCHIVED").Value
                archivedBy = dbHelper.StrNullCheck(.Cells("ARCHIVED_BY").Value)
                dateArchived = dbHelper.StrNullCheck(.Cells("DATE_ARCHIVED").Value)

            End With

            With dbHelper

                pending = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Pending").Rows.Count
                onHold = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Onhold").Rows.Count
                canceled = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Canceled").Rows.Count
                completed = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Finished").Rows.Count
                totalServices = pending + onHold + canceled

                'Dim getServiceData As DataTable = .GetRowByTwoValues("services", "customer_id", customerID, "total_paid", 1)

                'For i As Integer = 0 To getServiceData.Rows.Count - 1
                'totalPaid += getServiceData.Rows(i)("technician_fee").Value
                'totalPaid += getServiceData.Rows(i)("parts_cost").value
                'Next
            End With

        Catch ex As Exception
            MsgBox("Cannot initialize customers value: " & ex.Message)
            Return False
        End Try

        LoadDataToDGV()

        Return True
    End Function


    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        CustomerDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim customersTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            customersTable = dbHelper.GetAllRowsFromTable("customers", True, True)
        Else
            customersTable = dbHelper.GetAllRowsFromTable("customers", False)
        End If

        Dim searchBy As String = "first_name"

        With SearchComboBox
            If .SelectedIndex = 0 Then
                searchBy = "first_name"
            ElseIf .SelectedIndex = 1 Then
                searchBy = "middle_name"
            ElseIf .SelectedIndex = 2 Then
                searchBy = "last_name"
            ElseIf .SelectedIndex = 3 Then
                searchBy = "contact_number"
            ElseIf .SelectedIndex = 4 Then
                searchBy = "address"
            ElseIf .SelectedIndex = 5 Then
                searchBy = "email"
            ElseIf .SelectedIndex = 6 Then
                searchBy = "date_added"
            End If
        End With

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            customersTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            customersTable.DefaultView.RowFilter = ""
        End If

        CustomerDGV.AutoGenerateColumns = True
        CustomerDGV.DataSource = customersTable

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
            DeleteCustomerBtn.Visible = True
            ArchiveCustomerBtn.Visible = False
            AddCustomerBtn.Visible = False
            EditCustomerBtn.Visible = False
            CustomerDGV.Columns("DATE_ARCHIVED").Visible = True
            CustomerDGV.Columns("ARCHIVED_BY").Visible = True

        Else
            DeleteCustomerBtn.Visible = False
            ArchiveCustomerBtn.Visible = True
            AddCustomerBtn.Visible = True
            EditCustomerBtn.Visible = True
            CustomerDGV.Columns("DATE_ARCHIVED").Visible = False
            CustomerDGV.Columns("ARCHIVED_BY").Visible = False
        End If
    End Sub

    ' ROW STYLES
    Private Sub FormatDataGridViewRows()
        CustomerDGV.AutoGenerateColumns = False

        Try
            For Each row As DataGridViewRow In CustomerDGV.Rows

                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If
            Next

            For Each row As DataGridViewRow In CustomerDGV.Rows
                If row.Cells("ARCHIVED_BY").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ARCHIVED_BY").Value) Then
                    Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ARCHIVED_BY").Value)

                    If getEmpData.Rows.Count > 0 Then
                        row.Cells("ARCHIVED_BY").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Unable to style DGV: " & ex.Message)
        End Try
    End Sub
End Class