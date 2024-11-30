Public Class InventoryUseModal
    Public Property selectedID As Integer = -1

    Private Sub SelectItemTxtBox_Click(sender As Object, e As EventArgs) Handles SelectItemTxtBox.Click

    End Sub

    Private Sub SelectServiceTxtBox_Click(sender As Object, e As EventArgs) Handles SelectServiceTxtBox.Click

    End Sub

    Private Sub QuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AvailQuantityTxtBox.TextChanged

    End Sub

    Private Sub QuantityUsage_ValueChanged(sender As Object, e As EventArgs) Handles QuantityUsage.ValueChanged

    End Sub
    Private Sub InventoryUseModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ItemIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemIDTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub ItemNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub AvailableQuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AvailableQuantityTxtBox.TextChanged
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