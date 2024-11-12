
Public Class AdminDashboardForm
    Dim dbHelper As New DbHelper

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim employeeData As DataTable = dbHelper.GetAllRowsFromTable("employees", False)

        EmployeesCountLabel.Text = employeeData.Rows.Count


    End Sub


End Class