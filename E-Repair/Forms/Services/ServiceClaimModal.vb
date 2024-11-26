Public Class ServiceClaimModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim servConst As New ServiceDBConstants

    Public Property selectedID As Integer = -1
    Private Property totalPaid As Integer
    Private Property change As Integer
    Private Property paymentMethod As String

    ' REQUIRED
    Private Sub ServiceClaimModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbds(-1)

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        loadValues()
    End Sub

    Private Sub loadValues()

        Dim serviceDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.cashierIDStr, selectedID)

        If serviceDT.Rows.Count = 0 Then Exit Sub

        With serviceDT.Rows(0)
            RepairStatusTxtBox.Text = .Item(servConst.svcStatusStr)
            DateCompletedTxtBox.Text = .Item(servConst.dateCompletedStr)
            RepairNotesTxtBox.Text = .Item(servConst.repairNotesStr)
            PartsUsedTxtBox.Text = .Item(servConst.PartsUsed)
            TechnicianFeeTxtBox.Text = .Item(servConst.techFeeStr)
            TotalCostTxtBox.Text = .Item(servConst.TotalCost)
        End With

    End Sub

    Private Sub loadCmbds(index As Integer)
        dbHelper.LoadEnumsToCmb(PaymentMethodCmb, servConst.svcTableStr, servConst.payMethodStr, index)
    End Sub


    Private Sub DateClaimedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateClaimedTxtBox.TextChanged
        DateClaimedTxtBox.Text = DateTime.Now()
    End Sub

    Private Sub TotalPaidTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPaidTxtBox.TextChanged
        Decimal.TryParse(TotalPaidTxtBox.Text, totalPaid)
    End Sub

    Private Sub TotalPaidTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalPaidTxtBox.KeyPress
        formUtils.ValidateDecimalInput(TotalCostTxtBox, e)
    End Sub

    Private Sub ChangeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ChangeTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PaymentMethodCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentMethodCmb.SelectedIndexChanged
        paymentMethod = PaymentMethodCmb.SelectedItem
    End Sub

    ' FOR VIEW

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub RepairStatusTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairStatusTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub DateCompletedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateCompletedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub SeePartsBtn_Click(sender As Object, e As EventArgs) Handles SeePartsBtn.Click
        ' for view

        ' to do

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles GenerateReceipt.Click

        ' to do generate receipt
        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .totalPaidStr, totalPaid},
                { .dateClaimedStr, DateTime.Now()},
                { .custChangeStr, change},
                { .totalPaidStr, totalPaid},
                { .payMethodStr, paymentMethod}
            }

            If formUtils.EditRow(.svcTableStr, .svcIDStr, selectedID, updateData) Then
                Me.Close()
            End If
        End With

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class