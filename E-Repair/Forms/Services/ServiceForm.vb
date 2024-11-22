
Public Class ServiceForm
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

    Dim technicianFee As Decimal = Nothing
    Dim partsCost As Decimal = Nothing
    Dim totalPaid As Decimal = Nothing

    Dim isPaid As Boolean = False

    Dim customerChange As Decimal
    Dim paymentMethod As String = ""

    Dim dateCompleted As String = ""
    Dim dateClaimed As String = ""

    Dim dateAdded As String = ""
    Dim addedBy As String = ""

    Dim is_archived As Boolean = False
    Dim archivedByEmp As Integer = -1
    Dim dateArchivedEmp As String = ""

    Dim customerName As String = ""
    Dim technicianName As String = ""

    Dim pending_commission As Integer = -1
    Dim onhold_commission As Integer = -1
    Dim canceled_commission As Integer = -1
    Dim completed_commission As Integer = -1
    Dim total_commisions As Integer = -1

    Dim pending_service As Integer = -1
    Dim onhold_service As Integer = -1
    Dim canceled_service As Integer = -1
    Dim completed_service As Integer = -1
    Dim total_service

    Private Function InitData(Optional enableChecker As Boolean = True) As Boolean
        If enableChecker Then
            If ServiceDGV.Rows.Count = 0 Then
                MsgBox("No Data Found!")
                Return False
            End If

            If ServiceDGV.CurrentRow Is Nothing Then
                MsgBox("No row is currently selected.")
                Return False
            End If

            If ServiceDGV.SelectedRows.Count <= 0 Then
                MsgBox("Please Select a Row First")
                Return False
            End If
        End If

        ' INITIALIZE VALUES

        Try
            With ServiceDGV.CurrentRow
                serviceID = .Cells("SERVICE_ID").Value
                customerID = .Cells("CUSTOMER_ID").Value
                technicianID = .Cells("TECHNICIAN_ID").Value
                cashierID = .Cells("CASHIER_ID").Value

                customerName = .Cells("CUSTOMER_NAME").Value

                Dim getTechnicianData As DataRow = dbHelper.GetRowByValue("employees", "employee_id", technicianID).Rows(0)
                technicianName = getTechnicianData("firstname") & " " & ("lastname")

                deviceType = .Cells("DEVICE_TYPE").Value
                deviceModel = .Cells("DEVICE_MODEL").Value
                deviceBrand = .Cells("DEVICE_BRAND").Value
                deviceProfilePath = .Cells("DEVICE_PROFILE_PATH").Value
                operatingSystem = .Cells("OPERATING_SYSTEM").Value
                storageCapacity = .Cells("STORAGE_CAPACITY").Value
                problemDescription = .Cells("PROBLEM_DESCRIPTION").Value
                repairNotes = .Cells("REPAIR_NOTES").Value

                serviceStatus = .Cells("SERVICE_STATUS").Value
                technicianFee = .Cells("TECHNICIAN_FEE").Value
                partsCost = .Cells("PARTS_COST").Value
                isPaid = .Cells("PAID").Value

                totalPaid = .Cells("TOTAL_PAID").Value
                customerChange = .Cells("CUSTOMER_CHANGE").Value
                paymentMethod = .Cells("PAYMENT_METHOD").Value

                dateCompleted = .Cells("DATE_COMPLETED").Value
                dateClaimed = .Cells("DATE_CLAIMED").Value
                dateAdded = .Cells("DATE_ADDED").Value

                is_archived = .Cells("ARCHIVED").Value
                archivedByEmp = .Cells("ARCHIVED_BY").Value
                dateArchivedEmp = .Cells("DATE_ARCHIVED").Value
            End With

            With dbHelper
                pending_service = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Pending").Rows.Count
                onhold_service = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Onhold").Rows.Count
                canceled_service = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Canceled").Rows.Count
                completed_service = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Finished").Rows.Count
                total_service = pending_service + onhold_service + canceled_service + completed_service

                pending_commission = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Pending").Rows.Count
                onhold_commission = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Onhold").Rows.Count
                canceled_commission = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Canceled").Rows.Count
                completed_commission = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Finished").Rows.Count
                total_commisions = pending_commission + onhold_commission + canceled_commission + completed_commission

            End With

        Catch ex As Exception
            MsgBox("Failed to initialized services values: " + ex.Message)
            Return False
        End Try

        Return True
    End Function


    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click
        If Not InitData() Then Exit Sub

        ' DO ADDITIONAL CHECKERS FOR CLAIMING


    End Sub

    Private Sub ViewServiceBtn_Click(sender As Object, e As EventArgs) Handles ViewServiceBtn.Click
        If Not InitData() Then Exit Sub

        Dim AdminServiceViewModal As New ServiceViewModal

        Try
            formModal = formUtils.CreateBgFormModal()

            With AdminServiceViewModal
                .CustomerIDTxtBox.Text = customerID
                .CustomerNameTxtBox.Text = customerName
                .TotalCommissionsTxtBoxx.Text = total_commisions
                .PendingCommissionsTxtBox.Text = pending_commission
                .CompletedCommissionsTxtBox.Text = completed_commission

                .TechnicianIDTxtBox.Text = technicianID
                .TechnicianNameTxtBox.Text = technicianName
                .TotalWorkDoneTxtBox.Text = total_service
                .PendingCommissionsTxtBox.Text = pending_service
                .CompletedWorkTxtBox.Text = completed_service

                .DeviceBrandTxtBox.Text = deviceBrand
                .DeviceModelTxtBox.Text = deviceModel
                .StorageCapacityTxtBox.Text = storageCapacity

                .DeviceTypeTxtBox.Text = deviceType
                .OperatingSystemTxtBox.Text = operatingSystem
                .ProblemDescTxtBox.Text = problemDescription

                Dim getCashierData As DataRow = dbHelper.GetRowByValue("employee", "employee_id", cashierID).Rows(0)
                .AddedByTxtBox.Text = getCashierData("firstname") & " " & getCashierData("lastname")

                .RepairStatusTxtBox.Text = serviceStatus
                .DateAddedTxtBox.Text = dateAdded
                .DateCompletedTxtBox.Text = dateCompleted
                .RepairNotesTxtBox.Text = repairNotes

                .TechnicianFeeTxtBox.Text = technicianFee
                .PartsCostTxtBoxx.Text = partsCost
                .TotalCostTxtBox.Text = technicianFee + partsCost

                .PaymentStatusTxtBox.Text = isPaid
                .PaymentMethodTxtBox.Text = paymentMethod
                .TotalPaidTxtBox.Text = totalPaid
                .CustomerChangeTxtBox.Text = customerChange
                .DateClaimedTxtBox.Text = dateClaimed

                .ProfilePathTxtBox.Text = deviceProfilePath

                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Cannot display customer view modal: " & ex.Message)
            formModal.Close()
            AdminServiceViewModal.Close()
        Finally
            formModal.Dispose()
        End Try

    End Sub
    ' ADD 
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
            MsgBox("Unable to show add service modal: " & ex.ToString)
            formModal.Close()
            EmployeeAddEditModal.Close()
        Finally
            EmployeeAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
    End Sub

    ' EDIT

    Private Sub EditServiceBtn_Click(sender As Object, e As EventArgs) Handles EditServiceBtn.Click
        Dim addEditModal As New ServiceAddEditModal

        If Not InitData() Then Exit Sub

        Try
            formModal = formUtils.CreateBgFormModal()

            With addEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
                .LoadCmbDs(-1)
                .Guna2GroupBox1.Text = "Edit Service"

                .CustomerIDTxtBox.Text = customerID
                .CustomerNameTxtBox.Text = customerName
                .TotalCommissionsTxtBox.Text = total_commisions
                .PendingCommisionsTxtBox.Text = pending_commission
                .CompletedCommissionTxtBox.Text = completed_commission

                .TechnicianIDTxtBox.Text = technicianID
                .TechnicianNameTxtBox.Text = technicianName
                .TotalWorkDoneTxtBox.Text = total_commisions
                .PendingCommisionsTxtBox.Text = pending_commission
                .CompletedCommissionTxtBox.Text = completed_commission



            End With

        Catch ex As Exception
            MsgBox("Unable to show add service modal: " & ex.ToString)
            formModal.Close()
            EmployeeAddEditModal.Close()
        Finally
            EmployeeAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
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

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            serviceTable = formUtils.SearchFunction(serviceTable, searchTerm, searchValues, SearchComboBox.SelectedIndex)
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
                If row.Cells("CUSTOMER_NAME").Value IsNot Nothing Then
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

    Private Sub ServiceDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDGV.CellContentClick
        InitData(False)

        If serviceStatus = "Finished" Then
            ClaimServiceBtn.Visible = True
        Else
            ClaimServiceBtn.Visible = False
        End If

    End Sub


    End Sub


End Class
