Public Class CashierDashboardForm
    Private Sub SuppliersNumberLabel_Click(sender As Object, e As EventArgs) Handles SuppliersNumberLabel.Click

    End Sub

    Private Sub CustomersNumberLabel_Click(sender As Object, e As EventArgs) Handles CustomersNumberLabel.Click

    End Sub

    Private Sub ServicesNumberLabel_Click(sender As Object, e As EventArgs) Handles ServicesNumberLabel.Click

    End Sub

    Private Sub EmployeesCountLabel_Click(sender As Object, e As EventArgs) Handles EmployeesCountLabel.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now.ToString("yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label6.Text = Date.Now.ToString("MMMM dd")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label8.Text = Date.Now.ToString("dddd")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label7.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub CashierDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub
End Class