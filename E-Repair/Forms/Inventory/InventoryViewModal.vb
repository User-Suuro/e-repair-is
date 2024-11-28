Public Class InventoryViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Public Property selectedID As Integer = -1
    Private Sub loadValues()
        formUtils.checkIfLoad(selectedID)
    End Sub

    Private Sub InventoryViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formUtils.checkIfLoad(-1) Then
            Me.Close()
            Exit Sub
        End If

        loadValues()
    End Sub

    Private Sub SeeSupplierBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliersBtn.Click

    End Sub

    Private Sub ViewModifyItemBtn_Click(sender As Object, e As EventArgs) Handles ViewModifyItemBtn.Click

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class