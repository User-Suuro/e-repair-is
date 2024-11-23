Imports System.IO

Public Class ServiceViewModal
    Public Property selectedID As Integer = -1

    Private Sub ServiceViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(ProfilePathTxtBox.Text) Then
            SupplierCirclePictureBox.Image = Image.FromFile(ProfilePathTxtBox.Text)
        End If
    End Sub

    Private Sub SeeCustomerBtn_Click(sender As Object, e As EventArgs) Handles SeeCustomerBtn.Click

    End Sub

    Private Sub SeeTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SeeTechnicianBtn.Click

    End Sub

    Private Sub PartsUsedBtn_Click(sender As Object, e As EventArgs) Handles PartsUsedBtn.Click

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class