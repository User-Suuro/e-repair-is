Imports System.IO

Public Class ServiceViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Public Property selectedID As Integer = -1

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
    Private deviceImgPath As String = ""

    Private Sub ServiceViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

        Dim serviceDT As DataTable = dbHelper.GetRowByValue("services", "service_id", selectedID)

        If serviceDT.Rows.Count = 0 Then Exit Sub

        With serviceDT.Rows(0)
            Dim customerID = .Item("customer_id")
            Dim technicianID = .Item("technician_id")

            InitCustCount(customerID)
            InitTechCount(technicianID)

            CustomerIDTxtBox.Text = customerID
            CustomerNameTxtBox.Text = formUtils.getCustomerName(.Item("customer_id"))

            TotalCommissionsTxtBoxx.Text = total_commision
            CompletedCommissionsTxtBox.Text = completed_commission
            PendingCommissionsTxtBox.Text = pending_commission

            TechnicianIDTxtBox.Text = technicianID
            TechnicianNameTxtBox.Text = formUtils.getEmployeeName(.Item("technician_id"))

            TotalWorkDoneTxtBox.Text = total_services
            PendingWorkTxtBox.Text = techNumberPendingServices
            CompletedWorkTxtBox.Text = techNumberFinishedServices

            DeviceBrandTxtBox.Text = .Item("device_brand")
            DeviceModelTxtBox.Text = .Item("device_model")
            StorageCapacityTxtBox.Text = .Item("storage_capacity")
            deviceImgPath = .Item("device_profile_path")
            DeviceImgPathTxtBox.Text = deviceImgPath

            DeviceTypeTxtBox.Text = .Item("device_type")
            OperatingSystemTxtBox.Text = .Item("operating_system")
            ProblemDescTxtBox.Text = .Item("problem_description")

            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item("cashier_id"))
            RepairStatusTxtBox.Text = .Item("service_status")
            DateAddedTxtBox.Text = .Item("date_added")

            RepairNotesTxtBox.Text = dbHelper.StrNullCheck(.Item("repair_notes"))
            TechnicianFeeTxtBox.Text = .Item("technician_fee")
            PartsCostTxtBoxx.Text = .Item("parts_cost")
            TotalCostTxtBox.Text = .Item("technician_fee") + .Item("parts_cost")

            PaymentStatusTxtBox.Text = .Item("paid")
            PaymentMethodTxtBox.Text = dbHelper.StrNullCheck(.Item("payment_method"))
            TotalPaidTxtBox.Text = .Item("total_paid")
            CustomerChangeTxtBox.Text = .Item("customer_change")

            DateClaimedTxtBox.Text = dbHelper.StrNullCheck(.Item("date_claimed"))

        End With

        Dim empDT As DataTable = DbHelper.GetRowByValue("employees", "employee_id", AddedByTxtBox.Text)

        If empDT.Rows.Count = 0 Then Exit Sub

        With empDT.Rows(0)
            AddedByTxtBox.Text = .Item("firstname") & " " & .Item("lastname")
        End With

        If File.Exists(DeviceImgPathTxtBox.Text) Then
            ServiceCirclePictureBox.Image = Image.FromFile(DeviceImgPathTxtBox.Text)
        End If
    End Sub

    Private Sub InitCustCount(custID As Integer)
        pending_commission = formUtils.getCustStatusNumber("Pending", custID)
        onhold_commission = formUtils.getCustStatusNumber("Onhold", custID)
        canceled_commission = formUtils.getCustStatusNumber("Canceled", custID)
        completed_commission = formUtils.getCustStatusNumber("Finished", custID)
        total_commision = pending_commission + onhold_commission + canceled_commission + completed_commission
    End Sub

    Private Sub InitTechCount(techID As Integer)
        techNumberFinishedServices = formUtils.getTechStatsNumbers("Finished", techID)
        techNumberPendingServices = formUtils.getTechStatsNumbers("Pending", techID)
        techNumberCanceledServices = formUtils.getTechStatsNumbers("Canceled", techID)
        techNumberOnholdServices = formUtils.getTechStatsNumbers("Onhold", techID)
        total_services = techNumberFinishedServices + techNumberPendingServices + techNumberCanceledServices + techNumberOnholdServices
    End Sub



    Private Sub PartsUsedBtn_Click(sender As Object, e As EventArgs) Handles PartsUsedBtn.Click

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class