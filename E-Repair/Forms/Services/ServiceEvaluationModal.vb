Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants

    Private selectedDeviceType As String = Nothing
    Private dateCompleted As DateTime = Nothing
    Private technicianFee As Decimal = Nothing
    Private repairNotes As String = Nothing

    Public Property selectedID As Integer = -1

    Private Sub ServiceEvaluationModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbds(-1)
        loadVals()
    End Sub

    Private Sub loadVals()
        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub LoadCmbds(index As Integer)
        With dbHelper
            .LoadEnumsToCmb(DeviceTypeCmbBox, servConst.svcTableStr, servConst.devTypeStr, index)
        End With
    End Sub

    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged
        Decimal.TryParse(TechnicianFeeTxtBox.Text, technicianFee)
    End Sub

    Private Sub DateCompletedDTP_ValueChanged(sender As Object, e As EventArgs) Handles DateCompletedDTP.ValueChanged
        DateCompletedDTP.Value = DateTime.Now()
        dateCompleted = DateCompletedDTP.Value
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        TechnicianFeeTxtBox.Text = technicianFee
    End Sub

    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        ElseIf e.KeyChar = "." AndAlso TechnicianFeeTxtBox.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged
        repairNotes = RepairNotesTxtBox.Text
    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub SeePartsBtn_Click(sender As Object, e As EventArgs) Handles SeePartsBtn.Click
        ' for viewing
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click





    End Sub

    Private Sub Groupbox_Click(sender As Object, e As EventArgs) Handles Groupbox.Click

    End Sub
End Class
