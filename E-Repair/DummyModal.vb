Public Class DummyModal

    Public Property quantityReturned As Integer = -1

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        Integer.TryParse(QtyTextBox.Text, quantityReturned)
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub QtyTextBox_TextChanged(sender As Object, e As EventArgs) Handles QtyTextBox.TextChanged

    End Sub
End Class