Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim fomrUtils As New FormUtils
    Dim constants As New Constants

    Public Property selectedID As Integer = -1


    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub



    Private Sub LoadCmds(index As Integer)

    End Sub

    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged

    End Sub

    Private Sub DateCompletedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateCompletedTxtBox.TextChanged

    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged

    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged

    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged

    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged

    End Sub

    Private Sub GenerateReceiptBtn_Click(sender As Object, e As EventArgs) Handles GenerateReceiptBtn.Click

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class