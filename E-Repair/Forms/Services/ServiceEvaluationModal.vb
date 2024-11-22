Public Class ServiceEvaluationModal
    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub


End Class