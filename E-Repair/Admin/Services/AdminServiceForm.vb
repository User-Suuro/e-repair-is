Imports System.Linq.Expressions

Public Class AdminServiceForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Dim serviceID As Integer = -1
    Dim customerID As Integer = -1
    Dim technicianID As Integer = -1
    Dim cashierID As Integer = -1

    Dim deviceType As String = ""
    Dim deviceModel As String = ""
    Dim deviceBrand As String = ""
    Dim deviceProfilePath As String = ""

    Dim operatingSystem As String = ""
    Dim storageCapacity As String = ""
    Dim problemDescription As String = ""
    Dim repairNotes As String = ""

    Dim serviceStatus As String = ""

    Dim technicianFee As Decimal
    Dim partsCost As Decimal
    Dim isPaid As Boolean = False
    Dim totalPaid As Decimal
    Dim customerChange As Decimal
    Dim paymentMethod As String = ""

    Dim dateCompleted As String = ""
    Dim dateClaimed As String = ""
    Dim dateAdded As String = ""

    Dim archived As Boolean = False
    Dim archivedBy As Integer = -1
    Dim dateArchived As String = ""

    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click

    End Sub

    Private Sub ViewServiceBtn_Click(sender As Object, e As EventArgs) Handles ViewServiceBtn.Click

    End Sub

    Private Sub AddServiceBtn_Click_1(sender As Object, e As EventArgs) Handles AddServiceBtn.Click

    End Sub

    Private Sub EditServiceBtn_Click(sender As Object, e As EventArgs) Handles EditServiceBtn.Click

    End Sub

    Private Sub ArchiveServiceBtn_Click(sender As Object, e As EventArgs) Handles ArchiveServiceBtn.Click

    End Sub

    Private Sub DeleteServiceBtn_Click(sender As Object, e As EventArgs) Handles DeleteServiceBtn.Click

    End Sub

    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged

    End Sub

    Private Sub ServiceDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDGV.CellContentClick

    End Sub
End Class
