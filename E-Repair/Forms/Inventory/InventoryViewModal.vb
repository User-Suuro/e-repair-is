Public Class InventoryViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants
    Dim itemConst As New ItemsDBConstants

    Public Property selectedID As Integer = -1
    Private Sub InventoryViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadValues()
    End Sub

    Private Sub loadValues()
        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim invDT As DataTable = dbHelper.GetRowByValue(invConst.invTableStr, invConst.invIDStr, selectedID )

        If invDT.Rows.Count = 0 Then Exit Sub

        With invDT.Rows(0)
            Dim supplierID As Integer = .Item(invConst.supIDStr)
            SupplierIDTxtBox.Text = supplierID
            Dim supDT As DataTable = dbHelper.GetRowByValue(supConst.supTableStr, supConst.supIDStr, supplierID)

            If supDT.Rows.Count = 0 Then Exit Sub

            With supDT.Rows(0)
                CompanyNameTxtBox.Text = .Item(supConst.compNameStr)
            End With

            ItemNameTxtBox.Text = .Item(invConst.itemNameStr)
            ItemCategoryTextBox.Text = .Item(invConst.itemCatStr)
            ItemsSuppliedTxtBox.Text = formUtils.GetSuppliedItems(supplierID)

            ItemDescriptionTxtBox.Text = .Item(invConst.itemDescStr)

            SerialNumberTxtBox.Text = dbHelper.StrNullCheck(.Item(invConst.serialNumStr))
            PhysicalLocationTxtBox.Text = dbHelper.StrNullCheck(.Item(invConst.physLocStr))

            QuantityTxtBox.Text = .Item(invConst.qtyStr)
            TotalValueTxtBox.Text = .Item(invConst.totalCostStr)

            RestockDateTxtBox.Text = dbHelper.StrNullCheck(.Item(invConst.restockDateStr))
            DateAddedTxtBox.Text = .Item(invConst.dateAddedStr)
            AddedByTxtBox.Text = .Item(invConst.addedByStr)

            ArchivedByTxtBox.Text = dbHelper.StrNullCheck(.Item(invConst.archByStr))
            DateArchivedTxtBox.Text = dbHelper.StrNullCheck(.Item(invConst.dateArchivedStr))

        End With
    End Sub


    Private Sub SeeSupplierBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliersBtn.Click

        formUtils.ShowModalWithHandler(
              Function(id)
                  Dim modal As New SupplierViewModal
                  modal.selectedID = id
                  Return modal
              End Function,
             selectedID,
              Function(modal)
                  Return Nothing
              End Function
           )

    End Sub

    Private Sub ViewModifyItemBtn_Click(sender As Object, e As EventArgs) Handles ViewModifyItemBtn.Click

        formUtils.ShowModalWithHandler(
              Function(id)
                  Dim modal As New InventoryItemModal
                  modal.inventoryID = id
                  modal.selectedColumn = invConst.invIDStr
                  Return modal
              End Function,
             selectedID,
              Function(modal)
                  Return Nothing
              End Function
        )

        loadValues()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class