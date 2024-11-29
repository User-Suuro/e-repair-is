Public Class InventoryItemModal

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1

    Private Sub InventoryItemModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editMode Then EditPanel.Visible = True

    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class