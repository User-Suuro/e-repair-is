Imports System.IO
Imports System.Numerics
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports LibVLCSharp.[Shared]
Imports Microsoft.Reporting.Map.WebForms.BingMaps

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

    Dim dateAdded As String = ""

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property deviceImgPath As String = ""

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

        Dim savedPath = formUtils.saveImgToLocal(deviceImgPath, constants.getDevicePicturesFolderPath, False)

        Dim insertData As New Dictionary(Of String, Object) From {
          {"customer_id", customerID},
          {"technician_id", technicianID},
          {"cashier_id", empIDLogged},
          {"device_type", deviceType},
          {"device_profile_path", savedPath},
          {"device_model", deviceModel},
          {"device_brand", deviceBrand},
          {"operating_system", operatingSystem},
          {"storage_capacity", storageCapacity},
          {"problem_description", problemDescription}
        }

        If dbHelper.InsertRecord("services", insertData) Then
            formUtils.saveImgToLocal(deviceImgPath, constants.getDevicePicturesFolderPath, True)
            MsgBox("Service Successfully Added")
        Else
            MsgBox("Unable to save service record")
        End If


        Me.Close()
    End Sub

    ' EDIT

    Private Sub EditDataFunction()
        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this service?")) Then Exit Sub

        Dim updateData As New Dictionary(Of String, Object) From {
            {"customer_id", customerID},
            {"technician_id", technicianID},
            {"device_type", deviceType},
            {"device_profile_path", deviceImgPath},
            {"device_model", deviceModel},
            {"device_brand", deviceBrand},
            {"operating_system", operatingSystem},
            {"storage_capacity", storageCapacity},
            {"problem_description", problemDescription}
        }

        Dim prevServiceValue As DataRow = dbHelper.GetRowByValue("services", "service_id", selectedID).Rows(0)

        If prevServiceValue("device_profile_path") <> deviceImgPath Then updateData.Add("profile_path", formUtils.saveImgToLocal(deviceImgPath, constants.getDevicePicturesFolderPath, True))

        If dbHelper.UpdateRecord("services", "service_id", selectedID, updateData) Then
            MsgBox("Successfuly updated service details")
        Else
            MsgBox("Unable to update service details")
        End If

        Me.Close()
    End Sub

    ' SELECT CUSTOMER
    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click
        Dim customerForm As New CustomerForm
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
            MsgBox("Unable to customer modal: " & ex.ToString)
            formModal.Close()
            customerForm.Close()
        Finally
            customerForm.Dispose()
            formModal.Dispose()
        End Try


    End Sub

    ' SELECT TECHNICIAN
    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click
        Dim employeeForm As New EmployeeForm
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
            MsgBox("Unable to open employee modal: " & ex.ToString)
            formModal.Close()
            employeeForm.Close()
        Finally
            employeeForm.Dispose()
            formModal.Dispose()
        End Try

    End Sub

    'DEVICE BRAND
    Private Sub DeviceBrandTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceBrandTxtBox.TextChanged
        deviceBrand = DeviceBrandTxtBox.Text
    End Sub

    'DEVICE MODEL
    Private Sub DeviceModelTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceModelTxtBox.TextChanged
        deviceModel = DeviceModelTxtBox.Text
    End Sub

    ' STORAGE
    Private Sub StorageCapacityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles StorageCapacityTxtBox.TextChanged
        storageCapacity = StorageCapacityTxtBox.Text
    End Sub

    ' UPLOAD
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim imgPath = OpenFileDialog1.FileName
            DeviceCirclePictureBox.Image = Image.FromFile(imgPath)
            deviceImgPath = imgPath
        End If
    End Sub

    'DEVICE TYPE
    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged
        'With DeviceTypeTableLayout
        '    ' Default
        '    .ColumnStyles(0).Width = 100.0F
        '    .ColumnStyles(1).Width = 0.0F

        '    If DeviceTypeCmbBox.SelectedItem = "Others" Then
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    Else


        '        .ColumnStyles(0).Width = 100.0F
        '        .ColumnStyles(1).Width = 0.0F
        '    End If
        'End With

        deviceType = DeviceTypeCmbBox.SelectedItem
    End Sub

    ' DEVICE TYPE OTHERS
    'Private Sub IfOthersDeviceTypeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersDeviceTypeTxtBox.TextChanged
    '    If DeviceTypeCmbBox.SelectedItem = "Others" Then
    '        deviceType = IfOthersDeviceTypeTxtBox.Text
    '    End If
    'End Sub

    ' OPERATING SYSTEM
    Private Sub OperatingSystemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles OperatingSystemTxtBox.TextChanged
        operatingSystem = IfOthersOperatingSystemTxtBox.Text
    End Sub

    Private Sub DeviceProblemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceProblemTxtBox.TextChanged
        problemDescription = DeviceProblemTxtBox.Text
    End Sub

    ' BTN SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Cursor = Cursors.WaitCursor
            If editMode Then
                EditDataFunction()
            Else
                AddDataFunction()
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Failed to save / edit: " & ex.Message)
        End Try
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' ONLOAD
    Private Sub ServiceAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not editMode Then LoadCmbDs(-1)

        If File.Exists(deviceImgPath) Then
            DeviceCirclePictureBox.Image = Image.FromFile(deviceImgPath)
        End If

    End Sub

    ' LOAD ENUMS TO CMB
    Public Sub LoadCmbDs(index01)
        dbHelper.LoadEnumsToCmb(DeviceTypeCmbBox, "services", "device_type", index01)
    End Sub


End Class