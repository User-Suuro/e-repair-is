Public Class DummyModal
    Dim formUtils As New FormUtils

    Public Property quantityReturned As Integer = -1
    Private targetQuantity As Integer = -1
    Private Sub QuantityNumeric_ValueChanged(sender As Object, e As EventArgs) Handles QuantityNumeric.ValueChanged
        targetQuantity = QuantityNumeric.Value
    End Sub


    Private Function ShowMsg(quantity As Integer) As Boolean
        If targetQuantity <= 0 Then
            MsgBox("Please Add Quantity")
            Return False
        End If

        If formUtils.ShowMessageBoxResult("Caution", $"Are you sure you want to generate { quantity } dummy data? This action will greatly affect your database.") Then
            Return True
        End If

        Return False
    End Function

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        If Not ShowMsg(targetQuantity) Then Exit Sub
        quantityReturned = targetQuantity
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class