Public Class InvetoryAddEditModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Public Property selectedID As Integer = -1
    Public Property editMode As Boolean = False


    Private Sub InvetoryAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editMode Then loadValues()
    End Sub
    Private Sub loadValues()
        formUtils.checkIfLoad(selectedID)
    End Sub

    Private Sub SupplierIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierIDTxtBox.TextChanged

    End Sub

    Private Sub CompanyNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTxtBox.TextChanged

    End Sub

    Private Sub ItemsSuppliedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemsSuppliedTxtBox.TextChanged

    End Sub

    Private Sub ItemNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTxtBox.TextChanged

    End Sub

    Private Sub ItemCategoryCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemCategoryCmb.SelectedIndexChanged

    End Sub

    Private Sub HazardousCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HazardousCmb.SelectedIndexChanged

    End Sub

    Private Sub ItemDescriptionTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemDescriptionTxtBox.TextChanged

    End Sub

    Private Sub SerialNumberTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SerialNumberTxtBox.TextChanged

    End Sub

    Private Sub PhysicalLocationTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PhysicalLocationTxtBox.TextChanged

    End Sub

    Private Sub CostPerItemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CostPerItemTxtBox.TextChanged

    End Sub

    Private Sub QuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTxtBox.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub

    Private Sub SelectSupplierBtn_Click(sender As Object, e As EventArgs) Handles SelectSupplierBtn.Click

    End Sub
End Class