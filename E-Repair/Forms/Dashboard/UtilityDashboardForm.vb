Public Class UtilityDashboardForm
    Dim dbHelper As New DbHelper

    Dim empDT As DataTable

    Dim empConst As New EmployeesDBConstants

    Private Sub UtilityDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True

        empDT = dbHelper.GetRowByColWTwoVal(New List(Of String) From {empConst.empArchStr, empConst.empIDStr, empConst.empJobPosStr, empConst.empDestStr}, empConst.empTableStr, empConst.empArchStr, 0, empConst.empIDStr, Current.id)

        If empDT.Rows.Count = 0 Then Exit Sub

        With empDT.Rows(0)
            PersonnelTxtBox.Text = .Item(empConst.empDestStr)
        End With
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