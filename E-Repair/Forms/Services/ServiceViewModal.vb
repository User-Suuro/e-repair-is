Imports System.IO

Public Class ServiceViewModal
    Private Sub ServiceViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(ProfilePathTxtBox.Text) Then
            SupplierCirclePictureBox.Image = Image.FromFile(ProfilePathTxtBox.Text)
        End If
    End Sub
End Class