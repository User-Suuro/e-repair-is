Imports System.IO

Public Class SupplierViewModal
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub AdminSupplierViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(CompanyPathTxtBox.Text) Then
            SupplierCirclePictureBox.Image = Image.FromFile(CompanyPathTxtBox.Text)
        End If

    End Sub

    ' TO DO
    Private Sub SeeSuppliedItemsBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliedItemsBtn.Click

    End Sub


End Class