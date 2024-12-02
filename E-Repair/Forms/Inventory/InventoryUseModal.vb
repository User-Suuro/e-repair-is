Public Class InventoryUseModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper

    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants
    Dim servConst As New ServiceDBConstants

    Dim constants As New Constants

    Private serviceID As Integer = -1

    Private quantity As Integer = -1
    Private totalCost As Decimal

    Private costPerItem As Decimal
    Private availableQuantity As Integer
    Private reasonForUsing As String

    Public Property selectedID As Integer = -1

    Private Sub InventoryUseModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()

        If Not formUtils.checkIfLoad(selectedID) Then
            Exit Sub
            Me.Close()
        End If

        Dim invDT As DataTable = dbHelper.GetRowByValue(invConst.invTableStr, invConst.invIDStr, selectedID)

        If invDT.Rows.Count = 0 Then Exit Sub

        With invDT.Rows(0)
            ItemIDTxtBox.Text = selectedID

            ItemNameTxtBox.Text = .Item(invConst.itemNameStr)
            costPerItem = .Item(invConst.costPerItem)
            availableQuantity = .Item(invConst.availableQtyStr)

            CostPerItemTxtBox.Text = costPerItem
            AvailQuantityTxtBox.Text = availableQuantity
            QuantityUsage.Maximum = availableQuantity
        End With

    End Sub


    Private Sub SelectServiceTxtBox_Click(sender As Object, e As EventArgs) Handles SelectServiceTxtBox.Click
        serviceID = formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New ServiceForm
           modal.PendingOnly = True
           modal.selectMode = True
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

            If itemUsedDT.Rows.Count = 0 Then
                ItemUsedTxtBox.Text = 0
                Exit Sub
            End If

            ItemUsedTxtBox.Text = formUtils.CalcIntegerDTCol(itemUsedDT, itemConst.quantityUsedStr)
        End With

    End Sub

    Private Sub QuantityUsage_ValueChanged(sender As Object, e As EventArgs) Handles QuantityUsage.ValueChanged
        quantity = QuantityUsage.Value
        totalCost = quantity * costPerItem
        TotalCostTxtBox.Text = totalCost
    End Sub

    Private Sub ReasonTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReasonTextBox.TextChanged
        reasonForUsing = ReasonTextBox.Text
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

        If quantity > availableQuantity Then
            MsgBox("Insufficient Quantity")
            Exit Sub
        End If

        Dim quantityResult As Integer = availableQuantity - quantity

        If quantityResult < 0 Then
            MsgBox("Insufficient Quantity")
            Exit Sub
        End If

        Dim totalCostResult As Decimal = quantityResult * totalCost

        ' insert items_used record
        With itemConst

            Dim insertData As New Dictionary(Of String, Object) From {
               { .ServiceId, serviceID},
               { .quantityUsedStr, quantity},
               { .totalCost, totalCost},
               { .reasonUsed, reasonForUsing},
               { .InventoryId, selectedID}
             }

            If formUtils.AddRow(.TableName, insertData) Then

                ' update inv
                Dim updateData As New Dictionary(Of String, Object) From {
                   {invConst.availableQtyStr, quantityResult},
                   {invConst.totalCostStr, totalCostResult}
                }

                If dbHelper.UpdateRecord(invConst.invTableStr, invConst.invIDStr, selectedID, updateData) Then

                    ' update serv

                    Dim currentQtyListCol As New List(Of String) From {
                        servConst.partsCostStr,
                        servConst.PartsUsed,
                        servConst.TotalCost,
                        servConst.techFeeStr,
                        servConst.svcIDStr
                    }

                    ' get current 
                    Dim currentQty As DataTable = dbHelper.GetRowByColValue(currentQtyListCol, servConst.svcTableStr, servConst.svcIDStr, serviceID)

                    If currentQty.Rows.Count = 0 Then Exit Sub

                    With currentQty.Rows(0)

                        Dim totalPartsUsed = quantity + .Item(servConst.PartsUsed)
                        Dim totalPartsCost = (costPerItem * quantity) + .Item(servConst.partsCostStr)

                        ' update serv
                        Dim updateServ As New Dictionary(Of String, Object) From {
                            {servConst.PartsUsed, totalPartsUsed},
                            {servConst.partsCostStr, totalPartsCost},
                            {servConst.TotalCost, .Item(servConst.techFeeStr) + totalPartsCost}
                        }

                        If dbHelper.UpdateRecord(servConst.svcTableStr, servConst.svcIDStr, serviceID, updateServ) Then
                            Me.Close()
                        End If
                    End With
                End If
            End If
        End With
    End Sub
End Class