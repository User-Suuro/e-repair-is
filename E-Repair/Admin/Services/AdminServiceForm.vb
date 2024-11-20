Imports System.Linq.Expressions
Imports System.Net.Sockets
Imports Microsoft.ReportingServices.Rendering.ExcelOpenXmlRenderer

Public Class AdminServiceForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Dim serviceID As Integer = -1
    Dim customerID As Integer = -1
    Dim technicianID As Integer = -1
    Dim cashierID As Integer = -1

    Dim deviceType As String = ""
    Dim deviceModel As String = ""
    Dim deviceBrand As String = ""
    Dim deviceProfilePath As String = ""

    Dim operatingSystem As String = ""
    Dim storageCapacity As String = ""
    Dim problemDescription As String = ""
    Dim repairNotes As String = ""

    Dim serviceStatus As String = ""

    Dim technicianFee As Decimal
    Dim partsCost As Decimal
    Dim isPaid As Boolean = False
    Dim totalPaid As Decimal
    Dim customerChange As Decimal
    Dim paymentMethod As String = ""

    Dim dateCompleted As String = ""
    Dim dateClaimed As String = ""
    Dim dateAdded As String = ""

    Dim is_archived As Boolean = False
    Dim archivedByEmp As Integer = -1
    Dim dateArchivedEmp As String = ""

    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click

    End Sub

    Private Sub ViewServiceBtn_Click(sender As Object, e As EventArgs) Handles ViewServiceBtn.Click

    End Sub

    Private Sub AddServiceBtn_Click(sender As Object, e As EventArgs) Handles AddServiceBtn.Click
        Dim addEditModal As New ServiceAddEditModal

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
            EmployeeAddEditModal.Close()
        Finally
            EmployeeAddEditModal.Dispose()
            formModal.Dispose()
            ' LoadDataToDGV()
        End Try
    End Sub
    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        Dim serviceTable As DataTable

        If ShowArchiveCheckBox.Checked Then
            serviceTable = dbHelper.GetAllRowsFromTable("services", True, True)
        Else
            serviceTable = dbHelper.GetAllRowsFromTable("services", False)
        End If

        Dim searchValues() As String = {
            "customer_name",
            "device_model",
            "device_brand",
            "date_added"
        }

        Dim searchBy As String = searchValues(SearchComboBox.SelectedIndex)

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            serviceTable.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) Like '%{searchTerm}%'"
        Else
            serviceTable.DefaultView.RowFilter = ""
        End If

        ServiceDGV.AutoGenerateColumns = True
        ServiceDGV.DataSource = serviceTable

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
            ArchiveServiceBtn.Visible = False

            AddServiceBtn.Visible = False
            EditServiceBtn.Visible = False

            ServiceDGV.Columns("DATE_ARCHIVED").Visible = True
            ServiceDGV.Columns("ARCHIVED_BY").Visible = True

        Else
            DeleteServiceBtn.Visible = False
            ArchiveServiceBtn.Visible = True

            AddServiceBtn.Visible = True
            EditServiceBtn.Visible = True

            ServiceDGV.Columns("DATE_ARCHIVED").Visible = False
            ServiceDGV.Columns("ARCHIVED_BY").Visible = False
        End If
    End Sub

    ' ROW STYLES
    Private Sub FormatDataGridViewRows()
        Try
            For Each row As DataGridViewRow In ServiceDGV.Rows
                ' ARCHIVED
                If row.Cells("ARCHIVED_BY").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ARCHIVED_BY").Value) Then
                    Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ARCHIVED_BY").Value)

                    If getEmpData.Rows.Count > 0 Then
                        row.Cells("ARCHIVED_BY").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                    End If
                End If

                ' ARCHIVED BY
                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

                ' CUSTOMER NAME
                If row.Cells("CUSTOMER_NAME").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("CUSTOMER_NAME").Value) Then
                    Dim getCustData As DataTable = dbHelper.GetRowByValue("customers", "customer_id", row.Cells("CUSTOMER_ID").Value)

                    If getCustData.Rows.Count > 0 Then
                        row.Cells("CUSTOMER_NAME").Value = getCustData.Rows(0)("first_name") & " " & getCustData.Rows(0)("last_name")
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Unable to style DGV: " & ex.Message)
        End Try
    End Sub
End Class
