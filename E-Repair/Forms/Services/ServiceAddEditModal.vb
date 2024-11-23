Imports System.IO
Imports System.Numerics
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Web.UI.Design
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

        LoadCmbDs(-1)

        If selectedID = -1 Then Exit Sub

        LoadData()

    End Sub

    ' LOAD DATA
    Private Sub LoadData()
        Dim servDt As DataTable = dbHelper.GetRowByValue("services", "service_id", selectedID)

        If servDt.Rows.Count = 0 Then Exit Sub

        Guna2GroupBox1.Text = "Edit Service"

        With servDt.Rows(0)
            CustomerIDTxtBox.Text = .Item("customer_id")
            CustomerNameTxtBox.Text = formUtils.getCustomerName(.Item("customer_id"))
            TotalCommissionsTxtBox.Text = getCustStatsNumber("Finished") + getCustStatsNumber("Pending") + getCustStatsNumber("Onhold") + getCustStatsNumber("Canceled")
            PendingCommisionsTxtBox.Text = getCustStatsNumber("Pending")
            CompletedCommissionTxtBox.Text = getCustStatsNumber("Finished")

            TechnicianIDTxtBox.Text = .Item("technician_id")
            TechnicianNameTxtBox.Text = formUtils.getTechnicianName(.Item("technician_id"))
            TotalWorkDoneTxtBox.Text = getTechStatsNumber("Finished") + getTechStatsNumber("Pending") + getTechStatsNumber("Onhold") + getTechStatsNumber("Canceled")
            PendingCommisionsTxtBox.Text = getTechStatsNumber("Pending")

            deviceImgPath = .Item("device_profile_path")
            DeviceBrandTxtBox.Text = .Item("device_brand")
            DeviceModelTxtBox.Text = .Item("device_model")
            StorageCapacityTxtBox.Text = .Item("storage_capacity")

            Dim deviceTypeIndex = formUtils.FindComboBoxItemByText(DeviceTypeCmbBox, .Item("device_type"))
            LoadCmbDs(deviceType)

            OperatingSystemTxtBox.Text = .Item("operating_system")
            DeviceProblemTxtBox.Text = .Item("problem_description")
        End With

        If File.Exists(deviceImgPath) Then
            DeviceCirclePictureBox.Image = Image.FromFile(deviceImgPath)
        End If
    End Sub

    ' LOAD ENUMS TO CMB
    Public Sub LoadCmbDs(index01)
        dbHelper.LoadEnumsToCmb(DeviceTypeCmbBox, "services", "device_type", index01)
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

        Dim idResult As Integer = Nothing

        formUtils.ShowModalWithHandler(
               Function(id)
                   Dim modal As New CustomerForm
                   modal.selectMode = True
                   modal.selectModeTable = dbHelper.GetAllRowsFromTable("customers", False)
                   idResult = modal.selectedCustID
                   Return modal
               End Function,
               -1,
               Sub()
               End Sub
         )

        Dim pending_commission = formUtils.getCustStatusNumber("Pending", idResult)
        Dim onhold_commission = formUtils.getCustStatusNumber("Onhold", idResult)
        Dim canceled_commission = formUtils.getCustStatusNumber("Canceled", idResult)
        Dim completed_commission = formUtils.getCustStatusNumber("Finished", idResult)

        Dim total_commisions = pending_commission + onhold_commission + canceled_commission + completed_commission

        CustomerIDTxtBox.Text = idResult
        CustomerNameTxtBox.Text = formUtils.getCustomerName(idResult)
        TotalCommissionsTxtBox.Text = total_commisions
        PendingCommisionsTxtBox.Text = pending_commission
        CompletedCommissionTxtBox.Text = completed_commission
    End Sub

    ' SELECT TECHNICIAN
    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click
        Dim idResult As Integer = Nothing

        formUtils.ShowModalWithHandler(
           Function(id)
               Dim modal As New EmployeeForm
               modal.selectMode = True
               modal.selectModeTable = dbHelper.GetRowByValue("employees", "job_type", "Technician")
               idResult = modal.selectedEmpID
               Return modal
           End Function,
           -1,
           Sub()
           End Sub
        )

        Dim techNumberFinishedServices = formUtils.getTechStatsNumbers("Finished", idResult)
        Dim techNumberPendingServices = formUtils.getTechStatsNumbers("Pending", idResult)
        Dim techNumberCanceledServices = formUtils.getTechStatsNumbers("Canceled", idResult)
        Dim techNumberOnholdServices = formUtils.getTechStatsNumbers("Onhold", idResult)

        TechnicianIDTxtBox.Text = idResult
        TechnicianNameTxtBox.Text = formUtils.getTechnicianName(idResult)
        TotalCommissionsTxtBox.Text = techNumberFinishedServices + techNumberPendingServices + techNumberCanceledServices + techNumberOnholdServices
        PendingCommisionsTxtBox.Text = techNumberPendingServices
        CompletedCommissionTxtBox.Text = techNumberFinishedServices
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
    Private Sub IfOthersDeviceTypeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersDeviceTypeTxtBox.TextChanged
        '    If DeviceTypeCmbBox.SelectedItem = "Others" Then
        '        deviceType = IfOthersDeviceTypeTxtBox.Text
        '    End If
    End Sub

    ' OPERATING SYSTEM
    Private Sub OperatingSystemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles OperatingSystemTxtBox.TextChanged
        operatingSystem = IfOthersOperatingSystemTxtBox.Text
    End Sub

    Private Sub DeviceProblemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceProblemTxtBox.TextChanged
        problemDescription = DeviceProblemTxtBox.Text
    End Sub

    ' GET TECH NUMBER
    Private Function getTechStatsNumber(status As String) As Integer
        Return formUtils.getTechStatsNumbers(status, selectedID)
    End Function

    ' GET CUST NUMBER
    Private Function getCustStatsNumber(status As String) As Integer
        Return formUtils.getCustStatusNumber(status, selectedID)
    End Function

End Class