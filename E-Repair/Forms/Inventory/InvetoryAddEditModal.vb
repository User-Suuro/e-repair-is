Public Class InvetoryAddEditModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim constants As New Constants
    Dim suppConst As New SuppliersDBConstants
    Dim invConst As New InventoryDBConstants

    Private supplierID As Integer = -1
    Private itemName As String = ""
    Private itemCategory As String = ""
    Private hazardous As String = ""
    Private itemDesc As String = ""
    Private serialNumber As String = ""
    Private physicalLocation As String = ""

    Private costPerItem As Decimal
    Private quantity As Integer

    Public Property selectedID As Integer = -1
    Public Property editMode As Boolean = False


    Private Sub InvetoryAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editMode Then loadValues()
    End Sub
    Private Sub loadValues()
        formUtils.checkIfLoad(selectedID)
    End Sub

    Private Sub SelectSupplierBtn_Click(sender As Object, e As EventArgs) Handles SelectSupplierBtn.Click

        Dim resultID = formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SuppliersForm
            modal.selectedID = id
            modal.selectMode = True
            modal.suppDT = dbHelper.GetAllData(suppConst.supTableStr)
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function
        )

    End Sub
    Private Sub SupplierIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierIDTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub CompanyNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTxtBox.TextChanged
        ' for viewing
    End Sub

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

    ' ITEM DESc
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

    ' COST PER ITEM
    Private Sub CostPerItemTxtBox_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles CostPerItemTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateDecimalInput(CostPerItemTxtBox, e)
    End Sub

    Private Sub CostPerItemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CostPerItemTxtBox.TextChanged
        Decimal.TryParse(CostPerItemTxtBox.Text, costPerItem)
    End Sub

    ' QUANTITY
    Private Sub QuantityTxtBox_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles QuantityTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateIntegerInput(QuantityTxtBox, e)
    End Sub

    Private Sub QuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTxtBox.TextChanged
        Integer.TryParse(QuantityTxtBox.Text, quantity)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub


End Class