Imports System.IO

Public Class ServiceViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants
    Dim empConst As New EmployeesDBConstants
    Dim itemConst As New ItemsDBConstants

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
        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim serviceDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If serviceDT.Rows.Count = 0 Then Exit Sub

        With serviceDT.Rows(0)
            Dim customerID = .Item(servConst.custIDStr)
            Dim technicianID = .Item(servConst.techIDStr)

            InitCustCount(customerID)
            InitTechCount(technicianID)

            CustomerIDTxtBox.Text = customerID
            CustomerNameTxtBox.Text = formUtils.getCustomerName(.Item(servConst.custIDStr))

            TotalCommissionsTxtBoxx.Text = total_commision
            CompletedCommissionsTxtBox.Text = completed_commission
            PendingCommissionsTxtBox.Text = pending_commission

            TechnicianIDTxtBox.Text = technicianID
            TechnicianNameTxtBox.Text = formUtils.getEmployeeName(.Item(servConst.techIDStr))

            TotalWorkDoneTxtBox.Text = total_services
            PendingWorkTxtBox.Text = techNumberPendingServices
            CompletedWorkTxtBox.Text = techNumberFinishedServices

            DeviceBrandTxtBox.Text = .Item(servConst.devBrandStr)
            DeviceModelTxtBox.Text = .Item(servConst.devModelStr)
            StorageCapacityTxtBox.Text = .Item(servConst.storageCapStr)

            deviceImgPath = .Item(servConst.devProfilePathStr)
            DeviceImgPathTxtBox.Text = deviceImgPath

            DeviceTypeTxtBox.Text = .Item(servConst.devTypeStr)
            OperatingSystemTxtBox.Text = .Item(servConst.osStr)
            ProblemDescTxtBox.Text = .Item(servConst.probDescStr)

            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item(servConst.cashierIDStr))
            RepairStatusTxtBox.Text = .Item(servConst.svcStatusStr)
            DateAddedTxtBox.Text = .Item(servConst.dateAddedStr)

            RepairNotesTxtBox.Text = dbHelper.StrNullCheck(.Item(servConst.repairNotesStr))
            TechnicianFeeTxtBox.Text = .Item(servConst.techFeeStr)
            PartsCostTxtBoxx.Text = .Item(servConst.partsCostStr)
            TotalCostTxtBox.Text = .Item(servConst.techFeeStr) + .Item(servConst.partsCostStr)

            PaymentStatusTxtBox.Text = .Item(servConst.paidStr)
            PaymentMethodTxtBox.Text = dbHelper.StrNullCheck(.Item(servConst.payMethodStr))
            TotalPaidTxtBox.Text = .Item(servConst.totalPaidStr)
            CustomerChangeTxtBox.Text = .Item(servConst.custChangeStr)

            DateClaimedTxtBox.Text = dbHelper.StrNullCheck(.Item(servConst.dateClaimedStr))
            DateCompletedTxtBox.Text = dbHelper.StrNullCheck(.Item(servConst.dateCompletedStr))

            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item(servConst.cashierIDStr))
        End With

        If File.Exists(DeviceImgPathTxtBox.Text) Then
            ServiceCirclePictureBox.Image = Image.FromFile(DeviceImgPathTxtBox.Text)
        End If
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
        techNumberCanceledServices = formUtils.getTechStatsNumbers(constants.getCanceledString, techID)
        techNumberOnholdServices = formUtils.getTechStatsNumbers(constants.getOnholdString, techID)
        total_services = techNumberFinishedServices + techNumberPendingServices + techNumberCanceledServices + techNumberOnholdServices
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SeeCustomerBtn_Click(sender As Object, e As EventArgs) Handles SeeCustomerBtn.Click
        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New CustomerViewModal
             modal.selectedID = id
             Return modal
         End Function,
         selectedID,
         Function(modal)
             Return Nothing
         End Function
        )
    End Sub

    Private Sub SeeTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SeeTechnicianBtn.Click
        formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New EmployeeViewModal
           modal.selectedID = id
           Return modal
       End Function,
       selectedID,
       Function(modal)
           Return Nothing
       End Function
       )
    End Sub
    Private Sub PartsUsedBtn_Click(sender As Object, e As EventArgs) Handles PartsUsedBtn.Click

        Dim resultID As Integer = formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New InventoryItemModal
           modal.itemDT = dbHelper.GetRowByValue(itemConst.TableName, itemConst.ServiceId, selectedID)
           Return modal
       End Function,
       selectedID,
       Function(modal)
           Return Nothing
       End Function
       )
    End Sub
End Class