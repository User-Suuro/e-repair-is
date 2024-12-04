Public Class CashierDashboardForm

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants
    Dim itemConst As New ItemsDBConstants

    Dim constants As New Constants

    Dim servDT As New DataTable
    Dim custDT As New DataTable


    Private Sub loadData()

        Cursor = Cursors.WaitCursor

        servDT = dbHelper.GetRowByColWTwoVal(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.cashierIDStr}, servConst.svcTableStr, servConst.archivedStr, 0, servConst.cashierIDStr, Current.id)
        custDT = dbHelper.GetRowByColWTwoVal(New List(Of String) From {custConst.custArchStr, custConst.getAddedByID}, custConst.custTableStr, custConst.custArchStr, 0, custConst.getAddedByID, Current.id)

        Cursor = Cursors.Default

    End Sub
    Private Sub CashierDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadTimer()
        loadStatus()
    End Sub

    Private Sub loadStatus()
        ServCountLabel.Text = servDT.Rows.Count
        CustCountLabel.Text = custDT.Rows.Count

        PendingCountLabel.Text = servDT.Select($"{servConst.svcStatusStr } = '{constants.getPendingString}'").Length
        ClaimedCountLabel.Text = servDT.Select($"{servConst.svcStatusStr } = '{constants.getClaimedString}'").Length
    End Sub

    Private Sub loadTimer()
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