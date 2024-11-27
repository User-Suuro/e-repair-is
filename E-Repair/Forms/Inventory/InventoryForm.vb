Public Class InventoryForm

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InventoryDGV.ClearSelection()
    End Sub


    Private Sub UseBtn_Click(sender As Object, e As EventArgs) Handles UseBtn.Click

    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

    End Sub

    Private Sub EdtBtn_Click(sender As Object, e As EventArgs) Handles EdtBtn.Click

    End Sub

    Private Sub ArchivedBtn_Click(sender As Object, e As EventArgs) Handles ArchivedBtn.Click

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged

    End Sub
End Class