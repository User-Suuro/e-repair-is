Public Class ServiceClaimModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Public Property selectedID As Integer = -1


    Private Sub ServiceClaimModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GenerateReceiptBtn_Click(sender As Object, e As EventArgs) Handles GenerateReceiptBtn.Click

    End Sub

    Private Sub TotalPaidTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalPaidTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub ChangeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChangeTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class