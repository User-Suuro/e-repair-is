
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Reporting

Public Class AdminDashboardForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants
    Dim itemConst As New ItemsDBConstants

    Dim constants As New Constants

    Dim empDT As New DataTable
    Dim servDT As New DataTable
    Dim custDT As New DataTable
    Dim suppDT As New DataTable
    Dim invDT As New DataTable
    Dim itemDT As New DataTable

    Private finishedLoad

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' data
        finishedLoad = True
        loadData()

        ' text
        loadStatus()
        loadWelcome()

        ' charts
        loadPositionChart()
        loadInvUsedChart()
        loadSalesChart()
        loadSupplierStatusChart()

        ' timer
        loadTimer()

    End Sub


    Private Sub loadData()

        If Not finishedLoad Then Exit Sub

        Cursor = Cursors.WaitCursor

        empDT = dbHelper.GetRowByColValue(New List(Of String) From {empConst.empArchStr, empConst.empIDStr, empConst.empJobPosStr}, empConst.empTableStr, empConst.empArchStr, 0)
        servDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost}, servConst.svcTableStr, servConst.archivedStr, 0)

        custDT = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custArchStr}, custConst.custTableStr, custConst.custArchStr, 0)
        suppDT = dbHelper.GetRowByColValue(New List(Of String) From {supConst.archivedStr, supConst.supTypeStr}, supConst.supTableStr, supConst.archivedStr, 0)

        invDT = dbHelper.GetRowByColValue(New List(Of String) From {invConst.archivedStr, invConst.invIDStr, invConst.availableQtyStr, invConst.totalCostStr}, invConst.invTableStr, invConst.archivedStr, 0)
        itemDT = dbHelper.GetAllByCol(New List(Of String) From {itemConst.ServiceId, itemConst.quantityUsedStr}, itemConst.TableName)

        Cursor = Cursors.Default

    End Sub

    Private Sub loadStatus()
        EmployeesCountLabel.Text = empDT.Rows.Count - 1 ' don't count super admin
        ServicesNumberLabel.Text = servDT.Rows.Count
        CustomersNumberLabel.Text = custDT.Rows.Count
        SuppliersNumberLabel.Text = suppDT.Rows.Count
        ItemsCountLabel.Text = invDT.Rows.Count
    End Sub

    Private Sub loadWelcome()
        WelcomeMessageLabel.Text = "Welcome, " & formUtils.getEmployeeName(LoggedUser.Current.id)
        Label10.Text = LoggedUser.Current.position
    End Sub


    Private Sub loadPositionChart()
        PositionsChart.Series.Clear()
        Dim series As New Series("Positions")
        series.ChartType = SeriesChartType.Bar

        series.Points.AddXY("Admin", empDT.Select($"{empConst.empJobPosStr} = '{constants.getAdminString}'").Length)
        series.Points.AddXY("Cashiers", empDT.Select($"{empConst.empJobPosStr} = '{constants.getCashierString }'").Length)
        series.Points.AddXY("Technician", empDT.Select($"{empConst.empJobPosStr} = '{constants.getTechnicianString }'").Length)
        series.Points.AddXY("Utility", empDT.Select($"{empConst.empJobPosStr} = '{constants.getUtilityPersonnelString }'").Length)

        PositionsChart.Series.Add(series)
        PositionsChart.Titles.Add("Positions Counts")
    End Sub


    Private Sub loadInvUsedChart()
        InventoryGraph.Series.Clear()

        Dim qtySeries As New Series("Quantity")

        qtySeries.ChartType = SeriesChartType.Column

        qtySeries.Points.AddXY("Available", formUtils.CalcIntegerDTCol(invDT, invConst.availableQtyStr))
        qtySeries.Points.AddXY("Used", formUtils.CalcIntegerDTCol(itemDT, itemConst.quantityUsedStr))

        InventoryGraph.Series.Add(qtySeries)
        InventoryGraph.Titles.Add("Inventory Availability")
    End Sub

    Private Sub loadSalesChart()
        SalesChart.Series.Clear()

        'Dim aggregatedData = From row In servDT.AsEnumerable()
        '                     Where Not IsDBNull(row(servConst.dateClaimedStr)) ' Exclude NULL values
        '                     Group row By DateValue = Convert.ToDateTime(row(servConst.dateClaimedStr)) Into Group
        '                     Select New With {
        '                         .Date = DateValue,
        '                         .TotalSales = Group.Sum(Function(r) If(IsDBNull(r(servConst.TotalCost)), 0D, Convert.ToDecimal(r(servConst.TotalCost))))
        '                     }

        'Dim series As New Series("Sales")
        'series.ChartType = SeriesChartType.Line

        'For Each group In aggregatedData
        '    series.Points.AddXY(group.Date, group.TotalSales)
        'Next

        'SalesChart.Series.Add(series)
        'SalesChart.Titles.Add("Sales Overtime")

        'With SalesChart.ChartAreas(0).AxisX
        '    .LabelStyle.Format = "yyyy-MM-dd"
        '    .Interval = 1
        '    .IntervalType = DateTimeIntervalType.Days
        '    .LabelStyle.Angle = -45 ' Optional: Rotate labels
        '    .IsLabelAutoFit = True
        'End With

        Dim series As New Series("Value")
        series.ChartType = SeriesChartType.Column

        series.Points.AddXY("Profit", formUtils.calcDecimalDTCol(servDT, servConst.TotalCost))
        series.Points.AddXY("Expenses", formUtils.calcDecimalDTCol(invDT, invConst.totalCostStr))

        SalesChart.Series.Add(series)
        SalesChart.Titles.Add("Profit - Inventory Expenses")

    End Sub

    Private Sub loadServiceStatsChart()

        SupplierStatusChart.Series.Clear()

        Dim series As New Series("Value")
        series.ChartType = SeriesChartType.Column

        series.Points.AddXY("Pending", servDT.Select($"{servConst.svcStatusStr } = '{constants.getPendingString}'").Length)
        series.Points.AddXY("Finished", servDT.Select($"{servConst.svcStatusStr } = '{constants.getFinishedString}'").Length)
        series.Points.AddXY("Claimed", servDT.Select($"{servConst.svcStatusStr } = '{constants.getClaimedString}'").Length)
        series.Points.AddXY("Onhold", servDT.Select($"{servConst.svcStatusStr } = '{constants.getOnholdString}'").Length)
        series.Points.AddXY("Canceled", servDT.Select($"{servConst.svcStatusStr } = '{constants.getCanceledString}'").Length)

        SalesChart.Series.Add(series)
        SalesChart.Titles.Add("Service Status")

    End Sub

    Private Sub loadSupplierStatusChart()
        SupplierStatusChart.Series.Clear()
        ' load enums
        Dim supType = dbHelper.GetEnums(supConst.supTableStr, supConst.supTypeStr)
        Dim series As New Series("Amount")
        series.ChartType = SeriesChartType.Bar

        For Each type In supType
            Dim totalCount As Integer = custDT.Select($"{supConst.supTypeStr} = '{type}'").Length
            series.Points.AddXY(type, totalCount)
        Next

        SupplierStatusChart.Series.Add(series)
        SupplierStatusChart.Titles.Add("Supplier Type Count Summary")
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