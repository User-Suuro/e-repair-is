Public Class InventoryUseModal
    Public Property selectedID As Integer = -1


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles BtnUse.Click

    End Sub

    Private Sub ItemIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemIDTxtBox.TextChanged

    End Sub

    Private Sub ItemNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameTxtBox.TextChanged

    End Sub

    Private Sub AvailableQuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AvailableQuantityTxtBox.TextChanged

    End Sub

    Private Sub ServiceIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ServiceIDTxtBox.TextChanged

    End Sub

    Private Sub DeviceNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceNameTxtBox.TextChanged

    End Sub

    Private Sub ItemUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemUsedTxtBox.TextChanged

    End Sub

    Private Sub SelectItemTxtBox_Click(sender As Object, e As EventArgs) Handles SelectItemTxtBox.Click

    End Sub

    Private Sub SelectServiceTxtBox_Click(sender As Object, e As EventArgs) Handles SelectServiceTxtBox.Click

    End Sub

    Private Sub QuantityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTxtBox.TextChanged

    End Sub

    Private Sub ItemCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemCostTxtBox.TextChanged

    End Sub

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged

    End Sub
End Class