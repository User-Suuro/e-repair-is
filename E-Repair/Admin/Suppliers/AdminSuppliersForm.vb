Imports System.Linq.Expressions

Public Class AdminSuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSuppliersBtn.Click
        Dim supplerAddEditModal As New AdminSupplierAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            supplerAddEditModal.Owner = formModal
            supplerAddEditModal.StartPosition = FormStartPosition.CenterScreen
            AdminEmployeeAddModal.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            supplerAddEditModal.Close()
        Finally
            AdminEmployeeAddModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try

    End Sub

    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim suppliersTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            suppliersTable = dbHelper.GetAllRowsFromTable("suppliers", True, True)
        Else
            suppliersTable = dbHelper.GetAllRowsFromTable("suppliers", False)
        End If

        Dim searchBy As String = "company_name"

        If SearchComboBox.SelectedIndex = 0 Then
            searchBy = "company_name"
        ElseIf SearchComboBox.SelectedIndex = 1 Then
            searchBy = "contact_person"
        ElseIf SearchComboBox.SelectedIndex = 2 Then
            searchBy = "company_number"
        ElseIf SearchComboBox.SelectedIndex = 3 Then
            searchBy = "contact_email"
        ElseIf SearchComboBox.SelectedIndex = 4 Then
            searchBy = "location"
        ElseIf SearchComboBox.SelectedIndex = 5 Then
            searchBy = "estimated_delivery_time"
        ElseIf SearchComboBox.SelectedIndex = 6 Then
            searchBy = "total_paid"
        ElseIf SearchComboBox.SelectedIndex = 7 Then
            searchBy = "date_added"
        End If

        ' Search
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            suppliersTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            suppliersTable.DefaultView.RowFilter = ""
        End If

        EmpDGV.AutoGenerateColumns = True
        EmpDGV.DataSource = suppliersTable

        FormatDataGridViewRows()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
    End Sub

    Private Sub FormatDataGridViewRows()
        Try
            For Each row As DataGridViewRow In EmpDGV.Rows
                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

                Try
                    If row.Cells("SUPPLIER_ID").Value = GlobalSession.CurrentSession.EmployeeID Then
                        row.DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Catch ex As Exception

                End Try


            Next
        Catch ex As Exception
            MsgBox("Unable to style the Employee DGB with no current id session!")
        End Try
    End Sub

End Class