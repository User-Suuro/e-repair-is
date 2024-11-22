Public Class CustomerViewModal
    Dim dbHelper As New DbHelper

    Public Property selectedCustomerID As Integer = -1

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CustomerViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selectedCustomerID = -1 Then Exit Sub

        Dim custDt As DataTable = dbHelper.GetRowByValue("customers", "customer_id", selectedCustomerID)

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
            LastTransactionTxtBox.Text = .Item("last_transaction")
            DateAddedTxtBox.Text = .Item("date_added")
            ArchivedStatusTxtBox.Text = .Item("archived")
            ArchivedByTxtBox.Text = .Item("archived_by")
            DateAddedTxtBox.Text = ("date_added")

            Dim empDt As DataRow = dbHelper.GetRowByValue("employees", "employee_id", .Item("added_by")).Rows(0)
            AddedByTxtBox.Text = empDt("firstname") & " " & empDt("lastname")
        End With

        With dbHelper
            Dim pending = .GetRowByTwoValues("services", "customer_id", selectedCustomerID, "service_status", "Pending").Rows.Count
            Dim onHold = .GetRowByTwoValues("services", "customer_id", selectedCustomerID, "service_status", "Onhold").Rows.Count
            Dim canceled = .GetRowByTwoValues("services", "customer_id", selectedCustomerID, "service_status", "Canceled").Rows.Count
            Dim completed = .GetRowByTwoValues("services", "customer_id", selectedCustomerID, "service_status", "Finished").Rows.Count
            Dim totalServices = pending + onHold + canceled

            OnholdTxtBox.Text = onHold
            CanceledTxtBox.Text = canceled
            CompletedServicesTxtBox.Text = completed
            TotalServicesTxtBox.Text = totalServices
            PendingServicesTxtBox.Text = pending
        End With
    End Sub
End Class