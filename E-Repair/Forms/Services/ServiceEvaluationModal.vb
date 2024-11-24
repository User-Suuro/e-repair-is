Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim fomrUtils As New FormUtils
    Public Property selectedID As Integer = -1


    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub GenerateReceiptBtn_Click(sender As Object, e As EventArgs) Handles GenerateReceiptBtn.Click

    End Sub
End Class