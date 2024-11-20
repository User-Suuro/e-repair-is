Imports System.Numerics
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports LibVLCSharp.[Shared]

Public Class ServiceAddEditModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim formModal As New Form

    Dim serviceID As Integer = -1
    Dim customerID As Integer = -1
    Dim technicianID As Integer = -1

    Dim deviceType As String = ""
    Dim deviceModel As String = ""
    Dim deviceBrand As String = ""

    Dim operatingSystem As String = ""
    Dim storageCapacity As String = ""
    Dim problemDescription As String = ""
    Dim repairNotes As String = ""

    Dim dateAdded As String = ""

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property profilePath As String

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If editMode Then
                EditDataFunction()
            Else
                AddDataFunction()
            End If
        Catch ex As Exception
            MsgBox("Failed to save / edit: " & ex.Message)
        End Try
    End Sub

    ' ADD 
    Private Sub AddDataFunction()

        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this service?")) Then Exit Sub

        Dim empIDLogged As Integer

        Try
            empIDLogged = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            empIDLogged = -1
        End Try
    End Sub

    ' EDIT

    Private Sub EditDataFunction()
        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this service?")) Then Exit Sub

    End Sub

    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click
        Dim customerForm As New AdminCustomerForm
        Dim getCustomerTableData As DataTable = Nothing

        Try
            formModal = formUtils.CreateBgFormModal()

            With customerForm
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .selectMode = True

                getCustomerTableData = dbHelper.GetAllRowsFromTable("customers", False)

                .selectModeTable = getCustomerTableData


                If .ShowDialog() = DialogResult.OK Then
                    customerID = .selectedCustID

                    If Not customerID = -1 Then

                        ' LOAD SELECTED DATA
                        CustomerIDTxtBox.Text = customerID

                        With getCustomerTableData
                            CustomerNameTxtBox.Text = .Rows(0)("first_name") & " " & .Rows(0)("last_name")
                        End With

                        With dbHelper
                            Dim pending_C As Integer = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Pending").Rows.Count
                            Dim onHold_C As Integer = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Onhold").Rows.Count
                            Dim canceled_C As Integer = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Canceled").Rows.Count
                            Dim completed_C As Integer = .GetRowByTwoValues("services", "customer_id", customerID, "service_status", "Finished").Rows.Count

                            PendingCommisionsTxtBox.Text = pending_C
                            CompletedCommissionTxtBox.Text = completed_C
                            TotalCommissionsTxtBox.Text = pending_C + onHold_C + canceled_C + completed_C
                        End With
                    End If
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            customerForm.Close()
        Finally
            customerForm.Dispose()
            formModal.Dispose()
        End Try


    End Sub

    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click
        Dim employeeForm As New AdminEmployeeForm
        Dim getTechnicianTableData As DataTable = Nothing

        Try
            formModal = formUtils.CreateBgFormModal()

            With employeeForm
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .selectMode = True

                getTechnicianTableData = dbHelper.GetRowByValue("employees", "job_type", "Technician")

                .selectModeTable = getTechnicianTableData

                If .ShowDialog() = DialogResult.OK Then
                    technicianID = .selectedEmpID
                    If Not technicianID = -1 Then
                        ' LOAD SELECTED DATA
                        TechnicianIDTxtBox.Text = technicianID

                        With getTechnicianTableData
                            TechnicianNameTxtBox.Text = .Rows(0)("firstname") & " " & .Rows(0)("lastname")
                        End With

                        With dbHelper
                            Dim pending_C As Integer = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Pending").Rows.Count
                            Dim onHold_C As Integer = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Onhold").Rows.Count
                            Dim canceled_C As Integer = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Canceled").Rows.Count
                            Dim completed_C As Integer = .GetRowByTwoValues("services", "technician_id", technicianID, "service_status", "Finished").Rows.Count

                            PendingWorkTxtBox.Text = pending_C
                            CompletedWorkTxtBox.Text = completed_C
                            TotalWorkDoneTxtBox.Text = pending_C + onHold_C + canceled_C + completed_C
                        End With
                    End If
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeForm.Close()
        Finally


            employeeForm.Dispose()
            formModal.Dispose()
        End Try

    End Sub

    Private Sub CustomerIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTxtBox.TextChanged

    End Sub

    Private Sub TechnicianIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianIDTxtBox.TextChanged

    End Sub

    Private Sub DeviceBrandTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceBrandTxtBox.TextChanged

    End Sub

    Private Sub DeviceModelTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceModelTxtBox.TextChanged

    End Sub

    Private Sub StorageCapacityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles StorageCapacityTxtBox.TextChanged

    End Sub

    Private Sub DeviceCirclePictureBox_Click(sender As Object, e As EventArgs) Handles DeviceCirclePictureBox.Click

    End Sub

    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged

    End Sub
    Private Sub IfOthersDeviceTypeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersDeviceTypeTxtBox.TextChanged

    End Sub

    Private Sub OperatingSystemCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OperatingSystemCmbBox.SelectedIndexChanged

    End Sub

    Private Sub IfOthersOperatingSystemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersOperatingSystemTxtBox.TextChanged

    End Sub

    Private Sub DeviceProblemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceProblemTxtBox.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub ServiceAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class