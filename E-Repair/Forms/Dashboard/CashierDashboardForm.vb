Imports System.Windows.Forms.DataVisualization.Charting

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

        servDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.cashierIDStr, servConst.svcStatusStr}, servConst.svcTableStr, servConst.archivedStr, 0)
        custDT = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custArchStr, custConst.getAddedByID, custConst.custGenderStr}, custConst.custTableStr, custConst.custArchStr, 0)

        Cursor = Cursors.Default

    End Sub
    Private Sub CashierDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadTimer()
        loadStatus()

        loadServiceChart()
        loadGenderChart()
    End Sub

    Private Sub loadStatus()
        ServCountLabel.Text = servDT.Rows.Count
        CustCountLabel.Text = custDT.Rows.Count
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

    Private Sub loadServiceChart()
        ServStatusChart.Series.Clear()

        Dim series As New Series("Value")
        series.ChartType = SeriesChartType.Column

        series.Points.AddXY("Pending", servDT.Select($"{servConst.svcStatusStr} = '{constants.getPendingString}'").Length)
        series.Points.AddXY("Finished", servDT.Select($"{servConst.svcStatusStr} = '{constants.getFinishedString}'").Length)
        series.Points.AddXY("Claimed", servDT.Select($"{servConst.svcStatusStr} = '{constants.getClaimedString}'").Length)
        series.Points.AddXY("Onhold", servDT.Select($"{servConst.svcStatusStr} = '{constants.getOnholdString}'").Length)
        series.Points.AddXY("Canceled", servDT.Select($"{servConst.svcStatusStr} = '{constants.getCanceledString}'").Length)

        ServStatusChart.Series.Add(series)
        ServStatusChart.Titles.Add("Service Status")
    End Sub

    Private Sub loadGenderChart()
        GenderChart.Series.Clear()
        ' load enums
        Dim genders = dbHelper.GetEnums(custConst.custTableStr, custConst.custGenderStr)
        Dim series As New Series("Amount")
        series.ChartType = SeriesChartType.Bar

        For Each gender In genders
            Dim totalCount As Integer = custDT.Select($"{custConst.custGenderStr} = '{gender}'").Length
            series.Points.AddXY(gender, totalCount)
        Next

        GenderChart.Series.Add(series)
        GenderChart.Titles.Add("Customer Gender Demographics")
    End Sub


End Class