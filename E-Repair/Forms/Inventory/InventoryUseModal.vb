Imports System.Runtime.Remoting

Public Class InventoryUseModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper

    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants
    Dim servConst As New ServiceDBConstants

    Dim constants As New Constants

    Private inventoryID As Integer = -1
    Private serviceID As Integer = -1

    Public Property selectedID As Integer = -1

    Private Sub InventoryUseModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectItemTxtBox_Click(sender As Object, e As EventArgs) Handles SelectItemTxtBox.Click
        inventoryID = formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New InventoryForm
            modal.invDT = dbHelper.GetAllData(invConst.invTableStr)
            modal.selectMode = True
            Return modal
        End Function,
        -1,
        Function(modal)
            Return modal.selectedID
        End Function)

        If inventoryID = -1 Then Exit Sub

        Dim invDT As DataTable = DbHelper.GetRowByValue(invConst.invTableStr, invConst.invIDStr, inventoryID)

        If invDT.Rows.Count = 0 Then Exit Sub

        With invDT.Rows(0)
            ItemIDTxtBox.Text = inventoryID
            ItemNameTxtBox.Text = .Item(invConst.itemNameStr).Value
            CostPerItemTxtBox.Text = .Item(invConst.costPerItem).Value
        End With
    End Sub

    Private Sub SelectServiceTxtBox_Click(sender As Object, e As EventArgs) Handles SelectServiceTxtBox.Click
        serviceID = formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New ServiceForm
           modal.selectedID = id
           modal.serviceDT = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcStatusStr, constants.getPendingString)
           Return modal
       End Function,
       -1,
       Function(modal)
           Return modal.selectedID
       End Function)

        If serviceID = -1 Then Exit Sub

        Dim servDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, serviceID)

        If servDT.Rows.Count = 0 Then Exit Sub

        With servDT.Rows(0)
            ServiceIDTxtBox.Text = serviceID
            DeviceNameTxtBox.Text = .Item(servConst.devModelStr)

            Dim itemUsedDT As DataTable = dbHelper.GetRowByValue(itemConst.TableName, itemConst.ServiceId, serviceID)

            If itemUsedDT.Rows.Count = 0 Then Exit Sub

            ItemUsedTxtBox.Text = formUtils.CalcIntegerDTCol(itemUsedDT, itemConst.quantityUsedStr)

        End With

    End Sub

    Private Sub QuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AvailQuantityTxtBox.TextChanged

    End Sub

    Private Sub QuantityUsage_ValueChanged(sender As Object, e As EventArgs) Handles QuantityUsage.ValueChanged

    End Sub

    Private Sub ItemIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemIDTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub ItemNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub AvailableQuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CostPerItemTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub ServiceIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ServiceIDTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub DeviceNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceNameTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub ItemUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemUsedTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub ItemCostTxtBox_TextChanged(sender As Object, e As EventArgs)
        ' for viewing
    End Sub

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles BtnUse.Click

    End Sub


End Class