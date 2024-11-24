Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim fomrUtils As New FormUtils
    Dim constants As New Constants

    Public Property selectedID As Integer = -1


    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub GenerateReceiptBtn_Click(sender As Object, e As EventArgs) Handles GenerateReceiptBtn.Click

    End Sub


    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged
        'If PaymentTermsCmbBox.SelectedItem = "Others" Then
        '    With PaymentTermsTableLayout
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    End With
        'Else

        If DeviceTypeCmbBox.SelectedItem = constants.getFinishedString Then

        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class