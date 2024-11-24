Public Class InventoryViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Public Property selectedID As Integer = -1

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click
        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If
    End Sub
End Class