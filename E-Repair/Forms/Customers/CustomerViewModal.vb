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

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim custDt As DataTable = dbHelper.GetRowByValue(custConst.custTableStr, custConst.custIDStr, selectedID)

        If custDt.Rows.Count = 0 Then Exit Sub

        With custDt.Rows(0)
            FirstNameTextBox.Text = .Item(custConst.custFirstStr)
            MiddleNameTextBox.Text = dbHelper.StrNullCheck(.Item(custConst.custMidStr))
            LastNameTextBox.Text = .Item(custConst.custLastStr)

            GenderTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custGenderStr))
            EmailTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custEmailStr))
            ContactNumberTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custContactStr))

            AddressTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custAddressStr))
            TotalPaidTxtBox.Text = .Item(custConst.custTotalPaidStr)
            LastTransactionTxtBox.Text = dbHelper.StrNullCheck(.Item(custConst.custLastTransStr))

            DateAddedTxtBox.Text = .Item(custConst.custDateAddedStr)
            ArchivedStatusTxtBox.Text = .Item(custConst.custArchStr)
            ArchivedByTxtBox.Text = dbHelper.StrNullCheck(formUtils.getEmployeeName(dbHelper.IntNullCheck(.Item(custConst.custArchByIDStr))))

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


End Class