
Public Class AdminDashboardForm
    Dim dbHelper As New DbHelper

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmployeesCountLabel.Text = dbHelper.GetAllRowsFromTable("employees", False).Rows.Count
        ServicesNumberLabel.Text = dbHelper.GetAllRowsFromTable("services", False).Rows.Count
        CustomersNumberLabel.Text = dbHelper.GetAllRowsFromTable("customers", False).Rows.Count
        SuppliersNumberLabel.Text = dbHelper.GetAllRowsFromTable("suppliers", False).Rows.Count
        ItemsCountLabel.Text = dbHelper.GetAllRowsFromTable("items", False).Rows.Count

        Try
            Dim getActiveEmployee As DataRow = dbHelper.GetRowByValue("employees", "employee_id", GlobalSession.CurrentSession.EmployeeID).Rows(0)
            WelcomeMessageLabel.Text = "Welcome, " & getActiveEmployee("firstname") & " " & getActiveEmployee("lastname")

        Catch ex As Exception
            MsgBox("Cannot get active user ID without session")
        End Try

        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
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


End Class