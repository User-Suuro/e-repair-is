Public Class InventoryViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Public Property selectedID As Integer = -1
    Private Sub InventoryViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadValues()
    End Sub

    Private Sub loadValues()
        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        SupplierIDTxtBox.Text =

        CompanyName.

        ItemNameTxtBox.Text
        ItemsSuppliedTxtBox.Text = 

        Dim itemCategoryIndex As Integer =
        Dim hazardousIndex As Integer =
     

        ItemDescriptionTxtBox.Text =
        SerialNumberTxtBox.Text =
        PhysicalLocationTxtBox.Text = 

        TotalValueTxtBox.Text =
        QuantityTxtBox.Text = 

    End Sub



    Private Sub SeeSupplierBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliersBtn.Click

    End Sub

    Private Sub ViewModifyItemBtn_Click(sender As Object, e As EventArgs) Handles ViewModifyItemBtn.Click

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class