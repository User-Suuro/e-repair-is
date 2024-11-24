
Public Class AdminDashboardForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmployeesCountLabel.Text = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empArchByStr, 0).Rows.Count + 1  ' don't count super admin
        ServicesNumberLabel.Text = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.archByStr, 0).Rows.Count
        CustomersNumberLabel.Text = dbHelper.GetRowByValue(custConst.custTableStr, custConst.custArchByStr, 0).Rows.Count
        SuppliersNumberLabel.Text = dbHelper.GetRowByValue(supConst.supTableStr, supConst.archByStr, 0).Rows.Count
        ItemsCountLabel.Text = dbHelper.GetRowByValue(invConst.invTableStr, invConst.archByStr, 0).Rows.Count

        Try

            WelcomeMessageLabel.Text = "Welcome, " & formUtils.getEmployeeName(LoggedUser.Current.id)

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

    Private Sub EmployeesCountLabel_Click(sender As Object, e As EventArgs) Handles EmployeesCountLabel.Click

    End Sub
End Class