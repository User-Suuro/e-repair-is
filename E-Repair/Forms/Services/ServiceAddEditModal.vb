﻿Imports System.ComponentModel.Design
Imports System.IO

Public Class ServiceAddEditModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim formModal As New Form

    Dim servConst As New ServiceDBConstants
    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants

    Private serviceID As Integer
    Private customerID As Integer

    Private deviceType As String
    Private deviceModel As String
    Private deviceBrand As String

    Private operatingSystem As String
    Private storageCapacity As String
    Private problemDescription As String

    Private dateAdded As String

    Private pending_commission As Integer
    Private onhold_commission As Integer
    Private canceled_commission As Integer
    Private completed_commission As Integer

    Private total_commision As Integer
    Private total_services As Integer

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property deviceImgPath As String

    ' ONLOAD
    Private Sub ServiceAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbDs(-1)
        If editMode Then LoadData()
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
        BtnSave.Text = "Edit Service"

        With servDt.Rows(0)
            customerID = .Item(servConst.custIDStr)
            InitCustCount(customerID)

            CustomerIDTxtBox.Text = customerID
            CustomerNameTxtBox.Text = formUtils.getCustomerName(.Item(servConst.custIDStr))

            TotalCommissionsTxtBox.Text = total_commision
            PendingCommisionsTxtBox.Text = pending_commission
            CompletedCommissionTxtBox.Text = completed_commission

            deviceImgPath = .Item(servConst.devProfilePathStr)
            DeviceBrandTxtBox.Text = .Item(servConst.devBrandStr)
            DeviceModelTxtBox.Text = .Item(servConst.devModelStr)
            StorageCapacityTxtBox.Text = .Item(servConst.storageCapStr)

            Dim deviceTypeIndex As Integer = formUtils.FindComboBoxItemByText(DeviceTypeCmbBox, .Item(servConst.devTypeStr))
            LoadCmbDs(deviceTypeIndex)

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
              { .cashierIDStr, Current.id},
              { .custNameStr, formUtils.getCustomerName(customerID)},
              { .devTypeStr, deviceType},
              { .devModelStr, deviceModel},
              { .devBrandStr, deviceBrand},
              { .osStr, operatingSystem},
              { .storageCapStr, storageCapacity},
              { .probDescStr, problemDescription},
              { .dateAddedStr, DateTime.Now()}
             }

            Dim imgData As New List(Of Object) From {
                .devProfilePathStr,
                deviceImgPath,
                constants.getDevicePicturesFolderName
            }

            If formUtils.AddRow(.svcTableStr, insertData, "Queued Service", 0, imgData) Then

                ' update cust transaction date
                Dim updateTransDate As New Dictionary(Of String, Object) From {
                    {custConst.custLastTransStr, DateTime.Now()}
                }

                dbHelper.UpdateRecord(custConst.custTableStr, custConst.custIDStr, customerID, updateTransDate)

                Me.Close()
            End If

        End With
    End Sub

    ' EDIT

    Private Sub EditDataFunction()

        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .custIDStr, customerID},
                { .custNameStr, formUtils.getCustomerName(customerID)},
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

            If formUtils.EditRow(.svcTableStr, .svcIDStr, selectedID, updateData, "Edited service: " & selectedID, 0, imgData) Then
                Me.Close()
            End If
        End With

        Me.Close()
    End Sub

    ' SELECT CUSTOMER
    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click

        customerID = formUtils.ShowModalWithHandler(
               Function(id)
                   Dim modal As New CustomerForm
                   modal.selectMode = True
                   Return modal
               End Function,
               -1,
               Function(modal)
                   Return modal.selectedCustID
               End Function
            )

        If customerID = -1 Then Exit Sub

        InitCustCount(customerID)

        CustomerIDTxtBox.Text = customerID
        CustomerNameTxtBox.Text = formUtils.getCustomerName(customerID)

        TotalCommissionsTxtBox.Text = total_commision
        PendingCommisionsTxtBox.Text = pending_commission
        CompletedCommissionTxtBox.Text = completed_commission
    End Sub

    Private Sub InitCustCount(custID As Integer)
        pending_commission = formUtils.getCustStatusNumber(constants.getPendingString, custID)
        onhold_commission = formUtils.getCustStatusNumber(constants.getOnholdString, custID)
        canceled_commission = formUtils.getCustStatusNumber(constants.getCanceledString, custID)
        completed_commission = formUtils.getCustStatusNumber(constants.getFinishedString, custID)
        total_commision = pending_commission + onhold_commission + canceled_commission + completed_commission
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
        deviceType = DeviceTypeCmbBox.SelectedItem
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



    ' BTN SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        formUtils.SaveEvent(editMode, AddressOf AddDataFunction, AddressOf EditDataFunction)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub



End Class