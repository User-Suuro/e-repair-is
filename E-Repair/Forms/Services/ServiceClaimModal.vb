Public Class ServiceClaimModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Public Property selectedID As Integer = -1

    Private Property totalPaid As Integer
    Private Property dateClaimed As DateTime
    Private Property change As Integer
    Private Property totalCost As Integer
    Private Property paymentMethod

    ' REQUIRED
    Private Sub ServiceClaimModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateClaimedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateClaimedTxtBox.TextChanged

    End Sub

    Private Sub TotalPaidTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalPaidTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TotalPaidTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPaidTxtBox.TextChanged

    End Sub
    Private Sub ChangeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ChangeTxtBox.TextChanged

    End Sub
    Private Sub PaymentMethodCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentMethodCmb.SelectedIndexChanged

    End Sub

    ' FOR VIEW

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged

    End Sub

    Private Sub RepairStatusTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairStatusTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub DateCompletedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateCompletedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub SeePartsBtn_Click(sender As Object, e As EventArgs) Handles SeePartsBtn.Click
        ' for view

        ' to do

    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles GenerateReceipt.Click

    End Sub


End Class