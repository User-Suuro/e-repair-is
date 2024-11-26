Imports System.IO

Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants
    Dim itemConst As New ItemsDBConstants

    Private repairStatus As String = Nothing
    Private dateCompleted As DateTime = Nothing
    Private technicianFee As Decimal = Nothing
    Private repairNotes As String = Nothing

    Dim partsCost As Decimal = Nothing
    Dim totalCost As Decimal = Nothing

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

        ' SERVICE

        Dim servDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If servDT.Rows.Count = 0 Then Exit Sub

        With servDT.Rows(0)
            ' device type
            Dim deviceIndex As Integer = formUtils.FindComboBoxItemByText(RepairStatusCmb, .Item(servConst.svcStatusStr))
            LoadCmbds(deviceIndex)

            ' load image
            Dim deviceImgPath = .Item(servConst.devProfilePathStr)
            If File.Exists(deviceImgPath) Then
                DeviceCirclePictureBox.Image = Image.FromFile(deviceImgPath)
            End If

            TechnicianFeeTxtBox.Text = (.Item(servConst.techFeeStr)) ' load the current fee
            PartsUsedTxtBox.Text = (.Item(servConst.PartsUsed))

            partsCost = .Item(servConst.partsCostStr) ' get existing parts cost
            PartsCostTxtBox.Text = partsCost
        End With

        ' ITEMS
        DateCompletedDTP.Value = DateTime.Now()
    End Sub

    Private Sub LoadCmbds(index As Integer)
        With dbHelper
            .LoadEnumsToCmb(RepairStatusCmb, servConst.svcTableStr, servConst.svcStatusStr, index)
        End With
    End Sub

    Private Sub RepairStatusCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepairStatusCmb.SelectedIndexChanged
        repairStatus = RepairStatusCmb.SelectedItem
    End Sub

    Private Sub DateCompletedDTP_ValueChanged(sender As Object, e As EventArgs) Handles DateCompletedDTP.ValueChanged
        dateCompleted = DateCompletedDTP.Value
    End Sub
    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateDecimalInput(TechnicianFeeTxtBox, e)
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        Decimal.TryParse(TechnicianFeeTxtBox.Text, technicianFee)
        totalCost = technicianFee + partsCost
        TotalCostTxtBox.Text = totalCost
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

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .svcStatusStr, repairStatus},
                { .dateCompletedStr, dateCompleted},
                { .repairNotesStr, repairStatus},
                { .techFeeStr, technicianFee},
                { .TotalCost, totalCost}
            }

            If formUtils.EditRow(.svcTableStr, .svcIDStr, selectedID, updateData) Then
                Me.Close()
            End If
        End With
    End Sub

    Private Sub Groupbox_Click(sender As Object, e As EventArgs) Handles Groupbox.Click

    End Sub
End Class
