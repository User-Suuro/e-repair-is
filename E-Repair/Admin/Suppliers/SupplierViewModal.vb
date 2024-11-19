Public Class SupplierViewModal
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub AdminSupplierViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SupplierCirclePictureBox.Image = Image.FromFile(CompanyPathTxtBox.Text)
        Catch ex As Exception
            MsgBox("Failed to read company image path")
        End Try
    End Sub

    Private Sub SeeSuppliedItemsBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliedItemsBtn.Click



    End Sub


End Class