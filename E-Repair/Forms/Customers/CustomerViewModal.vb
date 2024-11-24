Public Class CustomerViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim custConst As New CustomersDBConstants

    Public Property selectedID As Integer = -1

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CustomerViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

        Dim custDt As DataTable = dbHelper.GetRowByValue(custConst.custTableStr, custConst.custIDStr, selectedID)

        If custDt.Rows.Count = 0 Then Exit Sub

        With custDt.Rows(0)
            FirstNameTextBox.Text = .Item(custConst.custFirstStr)
            MiddleNameTextBox.Text = .Item(custConst.custMidStr)
            LastNameTextBox.Text = .Item(custConst.custLastStr)

            GenderTxtBox.Text = .Item(custConst.custGenderStr)
            EmailTxtBox.Text = .Item(custConst.custEmailStr)
            ContactNumberTxtBox.Text = .Item(custConst.custContactStr)

            AddressTxtBox.Text = .Item(custConst.custAddressStr)
            TotalPaidTxtBox.Text = .Item(custConst.custTotalPaidStr)
            LastTransactionTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custLastTransStr))

            DateAddedTxtBox.Text = .Item(custConst.custDateAddedStr)
            ArchivedStatusTxtBox.Text = .Item(custConst.custArchStr)
            ArchivedByTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custArchByStr))

            DateAddedTxtBox.Text = .Item(custConst.custDateAddedStr)
            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item(custConst.custIDStr))
        End With

        With dbHelper
            Dim pending = getStatusNumber(constants.getAdminString)
            Dim onHold = getStatusNumber(constants.getOnholdString)
            Dim canceled = getStatusNumber(constants.getCanceledString)
            Dim completed = getStatusNumber(constants.getFinishedString)
            Dim totalServices = pending + onHold + canceled

            OnholdTxtBox.Text = onHold
            CanceledTxtBox.Text = canceled
            CompletedServicesTxtBox.Text = completed
            TotalServicesTxtBox.Text = totalServices
            PendingServicesTxtBox.Text = pending
        End With
    End Sub

    Private Function getStatusNumber(status As String) As Integer
        Return formUtils.getCustStatusNumber(status, selectedID)
    End Function

    Private Sub CustomerModalGroupBox_Click(sender As Object, e As EventArgs) Handles CustomerModalGroupBox.Click

    End Sub
End Class