Imports System.ComponentModel.Design
Imports System.IO

Public Class ServiceAddEditModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim formModal As New Form

    Dim servConst As New ServiceDBConstants
    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants

    Private serviceID As Integer = -1
    Private customerID As Integer = -1
    Private technicianID As Integer = -1

    Private deviceType As String = ""
    Private deviceModel As String = ""
    Private deviceBrand As String = ""

    Private operatingSystem As String = ""
    Private storageCapacity As String = ""
    Private problemDescription As String = ""

    Private dateAdded As String = ""

    Private pending_commission As Integer = -1
    Private onhold_commission As Integer = -1
    Private canceled_commission As Integer = -1
    Private completed_commission As Integer = -1

    Private total_commision As Integer = -1

    Private techNumberFinishedServices As Integer = -1
    Private techNumberPendingServices As Integer = -1
    Private techNumberCanceledServices As Integer = -1
    Private techNumberOnholdServices As Integer = -1

    Private total_services As Integer = -1

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property deviceImgPath As String = ""

    ' ONLOAD
    Private Sub ServiceAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbDs(-1)
    End Sub

    ' LOAD DATA
    Private Sub LoadData()

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim servDt As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If servDt.Rows.Count = 0 Then Exit Sub

        Guna2GroupBox1.Text = "Edit Service"

        With servDt.Rows(0)
            customerID = .Item(servConst.custIDStr)
            technicianID = .Item(servConst.techIDStr)

            InitCustCount(customerID)
            InitTechCount(technicianID)

            CustomerIDTxtBox.Text = customerID
            CustomerNameTxtBox.Text = formUtils.getCustomerName(.Item(servConst.custIDStr))

            TotalCommissionsTxtBox.Text = total_commision
            PendingCommisionsTxtBox.Text = pending_commission
            CompletedCommissionTxtBox.Text = completed_commission

            TechnicianIDTxtBox.Text = technicianID
            TechnicianNameTxtBox.Text = formUtils.getEmployeeName(technicianID)

            TotalWorkDoneTxtBox.Text = total_services
            PendingWorkTxtBox.Text = pending_commission
            CompletedWorkTxtBox.Text = techNumberFinishedServices

            deviceImgPath = .Item(servConst.devProfilePathStr)
            DeviceBrandTxtBox.Text = .Item(servConst.devBrandStr)
            DeviceModelTxtBox.Text = .Item(servConst.devModelStr)
            StorageCapacityTxtBox.Text = .Item(servConst.storageCapStr)

            Dim deviceTypeIndex = formUtils.FindComboBoxItemByText(DeviceTypeCmbBox, .Item(servConst.devTypeStr))
            LoadCmbDs(deviceType)

            OperatingSystemTxtBox.Text = .Item(servConst.osStr)
            DeviceProblemTxtBox.Text = .Item(servConst.probDescStr)
        End With

        If File.Exists(deviceImgPath) Then
            DeviceCirclePictureBox.Image = Image.FromFile(deviceImgPath)
        End If
    End Sub

    ' LOAD ENUMS TO CMB
    Private Sub LoadCmbDs(index01 As Integer)
        dbHelper.LoadEnumsToCmb(DeviceTypeCmbBox, servConst.svcTableStr, servConst.devTypeStr, index01)
    End Sub
    ' ADD 
    Private Sub AddDataFunction()

        With servConst
            Dim insertData As New Dictionary(Of String, Object) From {
              { .custIDStr, customerID},
              { .techIDStr, technicianID},
              { .cashierIDStr, formUtils.getEmployeeName(Current.id)},
              { .devTypeStr, deviceType},
              { .devModelStr, deviceModel},
              { .devBrandStr, deviceBrand},
              { .osStr, operatingSystem},
              { .storageCapStr, storageCapacity},
              { .probDescStr, problemDescription}
            }

            Dim imgData As New List(Of Object) From {
                .devProfilePathStr,
                deviceImgPath,
                constants.getDevicePicturesFolderName
            }

            If formUtils.AddRow(.svcTableStr, insertData, 0, imgData) Then
                Me.Close()
            End If

        End With
    End Sub

    ' EDIT

    Private Sub EditDataFunction()
        LoadData()

        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .custIDStr, customerID},
                { .techIDStr, technicianID},
                { .devTypeStr, deviceType},
                { .devModelStr, deviceModel},
                { .devBrandStr, deviceBrand},
                { .osStr, operatingSystem},
                { .storageCapStr, storageCapacity},
                { .probDescStr, problemDescription}
            }

            Dim imgData As New List(Of Object) From {
                .devProfilePathStr,
                deviceImgPath,
                constants.getDevicePicturesFolderName
            }

            If formUtils.EditRow(.svcTableStr, .svcIDStr, selectedID, updateData, 0, imgData) Then
                Me.Close()
            End If
        End With

        Me.Close()
    End Sub

    ' SELECT CUSTOMER
    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click

        Dim idResult As Integer = formUtils.ShowModalWithHandler(
               Function(id)
                   Dim modal As New CustomerForm
                   modal.selectMode = True
                   modal.customersDt = dbHelper.GetAllData(custConst.custTableStr)
                   Return modal
               End Function,
               -1,
               Function(modal)
                   Return modal.selectedCustID
               End Function
            )

        If idResult = -1 Then Exit Sub

        InitCustCount(idResult)

        CustomerIDTxtBox.Text = idResult
        CustomerNameTxtBox.Text = formUtils.getCustomerName(idResult)

        TotalCommissionsTxtBox.Text = total_commision
        PendingCommisionsTxtBox.Text = pending_commission
        CompletedCommissionTxtBox.Text = completed_commission
    End Sub

    ' SELECT TECHNICIAN
    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click

        Dim idResult As Integer = formUtils.ShowModalWithHandler(
           Function(id)
               Dim modal As New EmployeeForm
               modal.selectMode = True
               modal.empDT = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empJobPosStr, constants.getTechnicianString)
               Return modal
           End Function,
           -1,
           Function(modal)
               Return modal.selectedEmpID
           End Function
        )

        If idResult = -1 Then Exit Sub

        InitTechCount(idResult)

        TechnicianIDTxtBox.Text = idResult
        TechnicianNameTxtBox.Text = formUtils.getEmployeeName(idResult)

        TotalWorkDoneTxtBox.Text = total_services
        CompletedWorkTxtBox.Text = techNumberFinishedServices
        PendingWorkTxtBox.Text = techNumberPendingServices
    End Sub

    Private Sub InitCustCount(custID As Integer)
        pending_commission = formUtils.getCustStatusNumber(constants.getPendingString, custID)
        onhold_commission = formUtils.getCustStatusNumber(constants.getOnholdString, custID)
        canceled_commission = formUtils.getCustStatusNumber(constants.getCanceledString, custID)
        completed_commission = formUtils.getCustStatusNumber(constants.getFinishedString, custID)
        total_commision = pending_commission + onhold_commission + canceled_commission + completed_commission
    End Sub

    Private Sub InitTechCount(techID As Integer)
        techNumberFinishedServices = formUtils.getTechStatsNumbers(constants.getFinishedString, techID)
        techNumberPendingServices = formUtils.getTechStatsNumbers(constants.getPendingString, techID)
        techNumberCanceledServices = formUtils.getTechStatsNumbers(constants.getFinishedString, techID)
        techNumberOnholdServices = formUtils.getTechStatsNumbers(constants.getOnholdString, techID)
        total_services = techNumberFinishedServices + techNumberPendingServices + techNumberCanceledServices + techNumberOnholdServices
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
        operatingSystem = OperatingSystemTxtBox.Text
    End Sub

    Private Sub DeviceProblemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceProblemTxtBox.TextChanged
        problemDescription = DeviceProblemTxtBox.Text
    End Sub

    Private Sub CustomerIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTxtBox.TextChanged
        Dim value As Integer
        If Integer.TryParse(CustomerIDTxtBox.Text, value) Then
            customerID = value
        Else
            customerID = 0
        End If
    End Sub

    Private Sub TechnicianIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianIDTxtBox.TextChanged
        Dim value As Integer
        If Integer.TryParse(TechnicianIDTxtBox.Text, value) Then
            technicianID = value
        Else
            technicianID = 0
        End If
    End Sub

    ' BTN SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        formUtils.SaveEvent(editMode, AddressOf AddDataFunction, AddressOf EditDataFunction)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class