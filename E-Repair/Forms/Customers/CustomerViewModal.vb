Public Class CustomerViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Public Property selectedID As Integer = -1

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CustomerViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

        Dim custDt As DataTable = dbHelper.GetRowByValue("customers", "customer_id", selectedID)

        If custDt.Rows.Count = 0 Then Exit Sub

        With custDt.Rows(0)
            FirstNameTextBox.Text = .Item("first_name")
            MiddleNameTextBox.Text = .Item("middle_name")
            LastNameTextBox.Text = .Item("last_name")
            GenderTxtBox.Text = .Item("gender")
            EmailTxtBox.Text = .Item("email")
            ContactNumberTxtBox.Text = .Item("contact_number")
            AddressTxtBox.Text = .Item("address")
            TotalPaidTxtBox.Text = .Item("total_paid")
            LastTransactionTxtBox.Text = dbHelper.StrNullCheck(.Item("last_transaction"))
            DateAddedTxtBox.Text = .Item("date_added")
            ArchivedStatusTxtBox.Text = .Item("archived")
            ArchivedByTxtBox.Text = dbHelper.StrNullCheck(.Item("archived_by"))
            DateAddedTxtBox.Text = ("date_added")

            Dim empDt As DataRow = dbHelper.GetRowByValue("employees", "employee_id", .Item("added_by")).Rows(0)
            AddedByTxtBox.Text = empDt("firstname") & " " & empDt("lastname")
        End With

        With dbHelper
            Dim pending = getStatusNumber("Pending")
            Dim onHold = getStatusNumber("Onhold")
            Dim canceled = getStatusNumber("Canceled")
            Dim completed = getStatusNumber("Finished")
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