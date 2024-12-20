﻿Public Class InvetoryAddEditModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim constants As New Constants
    Dim suppConst As New SuppliersDBConstants
    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants

    ' CONSTANTS
    Private initialQty As Integer


    Private supplierID As Integer
    Private itemName As String
    Private itemCategory As String
    Private hazardous As String
    Private itemDesc As String
    Private serialNumber As String
    Private physicalLocation As String

    Private totalValue As Decimal = -1
    Private quantity As Integer = -1
    Private costPerItem As Decimal = -1

    Public Property selectedID As Integer = -1
    Public Property editMode As Boolean = False

    Private Sub InvetoryAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbds(-1, -1)
        If editMode Then loadValues()
    End Sub

    ' LOAD CMBDS
    Private Sub LoadCmbds(index01 As Integer, index02 As Integer)
        With invConst
            dbHelper.LoadEnumsToCmb(ItemCategoryCmb, .invTableStr, .itemCatStr, index01)
            dbHelper.LoadEnumsToCmb(HazardousCmb, .invTableStr, .hazClassStr, index02)
        End With
    End Sub

    'SAVE
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Additional Checkers
        If (quantity < 0 Or totalValue < 0) Then
            MsgBox("Quantity cannot be less than 0")
            Exit Sub
        End If

        formUtils.SaveEvent(editMode, AddressOf AddData, AddressOf EditData)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' ADD DATA
    Private Sub AddData()
        With invConst
            Dim insertData As New Dictionary(Of String, Object) From {
                { .serialNumStr, serialNumber}, ' optional
                { .physLocStr, physicalLocation}, ' optional
                { .supIDStr, supplierID},
                { .itemNameStr, itemName},
                { .itemCatStr, itemCategory},
                { .hazClassStr, hazardous},
                { .itemDescStr, itemDesc},
                { .availableQtyStr, quantity},
                { .totalCostStr, totalValue},
                { .costPerItem, costPerItem},
                { .addedByIDStr, Current.id}
            }

            If formUtils.AddRow(invConst.invTableStr, insertData, "Added Inventory", 2) Then
                Me.Close()
            End If
        End With
    End Sub

    ' LOAD VALUES FOR EDIT
    Private Sub loadValues()

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim invDT As DataTable = dbHelper.GetRowByValue(invConst.invTableStr, invConst.invIDStr, selectedID)

        If invDT.Rows.Count = 0 Then Exit Sub

        Guna2GroupBox1.Text = "Edit Inventory"

        With invDT.Rows(0)
            supplierID = .Item(invConst.supIDStr)
            SupplierIDTxtBox.Text = supplierID

            ItemNameTxtBox.Text = .Item(invConst.itemNameStr)

            Dim suppDT As DataTable = dbHelper.GetRowByValue(suppConst.supTableStr, suppConst.supIDStr, supplierID)

            With suppDT.Rows(0)
                CompanyNameTxtBox.Text = .Item(suppConst.compNameStr)
                ItemsSuppliedTxtBox.Text = formUtils.GetSuppliedItems(supplierID)
            End With

            Dim itemCategoryIndex As Integer = formUtils.FindComboBoxItemByText(ItemCategoryCmb, .Item(invConst.itemCatStr))
            Dim hazardousIndex As Integer = formUtils.FindComboBoxItemByText(HazardousCmb, .Item(invConst.hazClassStr))
            LoadCmbds(itemCategoryIndex, hazardousIndex)

            ItemDescriptionTxtBox.Text = .Item(invConst.itemDescStr)
            SerialNumberTxtBox.Text = .Item(invConst.serialNumStr)
            PhysicalLocationTxtBox.Text = .Item(invConst.physLocStr)

            TotalValueTxtBox.Text = .Item(invConst.totalCostStr)
            CostPerItemTxtBox.Text = .Item(invConst.costPerItem)

            QuantityUsage.Value = .Item(invConst.availableQtyStr)
            initialQty = .Item(invConst.availableQtyStr)
        End With

    End Sub

    ' EDIT DATA
    Private Sub EditData()
        ' do your things
        With invConst

            Dim updateData As New Dictionary(Of String, Object) From {
                { .serialNumStr, serialNumber}, ' optional
                { .physLocStr, physicalLocation}, ' optional
                { .supIDStr, supplierID},
                { .itemNameStr, itemName},
                { .itemCatStr, itemCategory},
                { .hazClassStr, hazardous},
                { .itemDescStr, itemDesc},
                { .availableQtyStr, quantity},
                { .totalCostStr, totalValue},
                { .costPerItem, costPerItem}
            }

            ' update restock date
            If quantity > initialQty Then updateData.Add(.restockDateStr, DateTime.Now())

            If formUtils.EditRow(.invTableStr, .invIDStr, selectedID, updateData, "Edited Inventory: " & selectedID, 2) Then
                Me.Close()
            End If

        End With
    End Sub

    ' SELECT SUPPLIER ID
    Private Sub SelectSupplierBtn_Click(sender As Object, e As EventArgs) Handles SelectSupplierBtn.Click

        supplierID = formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SuppliersForm
            modal.selectMode = True
            Return modal
        End Function,
        -1,
        Function(modal)
            Return modal.selectedID
        End Function
        )

        If supplierID = -1 Then Exit Sub

        Dim suppDT As DataTable = dbHelper.GetRowByValue(suppConst.supTableStr, suppConst.supIDStr, supplierID)

        If suppDT.Rows.Count = 0 Then Exit Sub

        SupplierIDTxtBox.Text = supplierID

        With suppDT.Rows(0)
            CompanyNameTxtBox.Text = .Item(suppConst.compNameStr)
        End With

        ItemsSuppliedTxtBox.Text = formUtils.GetSuppliedItems(supplierID)
    End Sub

    ' SUPPLIER ID
    Private Sub SupplierIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierIDTxtBox.TextChanged
        ' for viewing
    End Sub

    ' COMPANY NAME
    Private Sub CompanyNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTxtBox.TextChanged
        ' for viewing
    End Sub

    ' ITEMS SUPPLIED
    Private Sub ItemsSuppliedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemsSuppliedTxtBox.TextChanged
        ' for viewing
    End Sub

    ' ITEM NAME
    Private Sub ItemNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTxtBox.TextChanged
        itemName = ItemNameTxtBox.Text
    End Sub

    ' ITEM CATEGORY
    Private Sub ItemCategoryCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemCategoryCmb.SelectedIndexChanged
        itemCategory = ItemCategoryCmb.SelectedItem
    End Sub

    ' HAZARDOUS
    Private Sub HazardousCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HazardousCmb.SelectedIndexChanged
        hazardous = HazardousCmb.SelectedItem
    End Sub

    ' ITEM DESC
    Private Sub ItemDescriptionTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemDescriptionTxtBox.TextChanged
        itemDesc = ItemDescriptionTxtBox.Text
    End Sub

    ' SERIAL NUMBER
    Private Sub SerialNumberTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SerialNumberTxtBox.TextChanged
        serialNumber = SerialNumberTxtBox.Text
    End Sub

    ' PHYSICAL LOC
    Private Sub PhysicalLocationTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PhysicalLocationTxtBox.TextChanged
        physicalLocation = PhysicalLocationTxtBox.Text
    End Sub

    ' TOTAL VALUE
    Private Sub CostPerItemTxtBox_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles CostPerItemTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateDecimalInput(CostPerItemTxtBox, e)
    End Sub

    Private Sub CostPerItemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CostPerItemTxtBox.TextChanged
        Decimal.TryParse(CostPerItemTxtBox.Text, costPerItem)
        totalValue = costPerItem * quantity
        TotalValueTxtBox.Text = totalValue
    End Sub

    ' QUANTITY
    Private Sub QuantityUsage_ValueChanged(sender As Object, e As EventArgs) Handles QuantityUsage.ValueChanged
        quantity = QuantityUsage.Value
        totalValue = costPerItem * quantity
        TotalValueTxtBox.Text = totalValue
    End Sub

    ' TOTAL VALUE
    Private Sub TotalValueTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalValueTxtBox.TextChanged
        ' for view
    End Sub


End Class