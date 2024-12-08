
Imports System.IO
Imports System.Web.UI.WebControls
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

    Private finishedLoad As Boolean
    Private dateFormat As String = constants.getDateFormat

    Private strStartDate As String
    Private strStopDate As String

    Private daysListStart As List(Of Integer)
    Private daysListStop As List(Of Integer)


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

        empDT = dbHelper.GetRowByColValue(New List(Of String) From {empConst.empArchStr, empConst.empIDStr, empConst.empJobPosStr, empConst.empAddDateStr}, empConst.empTableStr, empConst.empArchStr, 0)
        servDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.dateAddedStr}, servConst.svcTableStr, servConst.archivedStr, 0)
        custDT = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custArchStr, custConst.custDateAddedStr}, custConst.custTableStr, custConst.custArchStr, 0)
        suppDT = dbHelper.GetRowByColValue(New List(Of String) From {supConst.archivedStr, supConst.supTypeStr, supConst.dateAddedStr}, supConst.supTableStr, supConst.archivedStr, 0)
        invDT = dbHelper.GetRowByColValue(New List(Of String) From {invConst.archivedStr, invConst.invIDStr, invConst.availableQtyStr, invConst.totalCostStr, invConst.dateAddedStr}, invConst.invTableStr, invConst.archivedStr, 0)
        itemDT = dbHelper.GetAllByCol(New List(Of String) From {itemConst.ServiceId, itemConst.quantityUsedStr, itemConst.dateUsedCol}, itemConst.TableName)

        ' CONVERT DATE FOR FILTERS

        empDT = formUtils.FormatSingleDateColumn(empDT, empConst.empAddDateStr, constants.getDateFormat)
        itemDT = formUtils.FormatSingleDateColumn(itemDT, itemConst.dateUsedCol, constants.getDateFormat)
        invDT = formUtils.FormatSingleDateColumn(invDT, invConst.dateAddedStr, constants.getDateFormat)
        suppDT = formUtils.FormatSingleDateColumn(suppDT, supConst.dateAddedStr, constants.getDateFormat)
        custDT = formUtils.FormatSingleDateColumn(custDT, custConst.custDateAddedStr, constants.getDateFormat)
        servDT = formUtils.FormatSingleDateColumn(servDT, servConst.dateAddedStr, constants.getDateFormat)
        itemDT = formUtils.FormatSingleDateColumn(itemDT, itemConst.dateUsedCol, constants.getDateFormat)

        'FILTERS

        With YearCmb
            .DataSource = constants.getYearList
            .BeginUpdate()
            .SelectedIndex = 0
            .EndUpdate()
        End With

        With MonthCmb
            .DataSource = constants.getMonthList
            .BeginUpdate()
            .SelectedIndex = formUtils.FindComboBoxItemByText(MonthCmb, DateTime.Now.ToString("MMMM"))
            .EndUpdate()
        End With

        Cursor = Cursors.Default
    End Sub

    ' FILTERS

    Private Sub DayStartCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DayStartCmb.SelectedIndexChanged
        reloadDayStop()
        reloadStrDate()
    End Sub

    Private Sub DayStopCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DayStopCmb.SelectedIndexChanged
        reloadDayStart()
        reloadStrDate()
    End Sub

    Private Sub MonthCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthCmb.SelectedIndexChanged
        loadDays()
        reloadStrDate()
    End Sub

    Private Sub YearCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearCmb.SelectedIndexChanged
        loadDays()
        reloadStrDate()
    End Sub

    ' FILTER FUNCTIONS

    Private Sub reloadStrDate()

        If Not finishedLoad AndAlso Not hasDayCmbValue() Then Exit Sub

        ' CODE
        strStartDate = MonthCmb.SelectedIndex + 1 & "/" & DayStartCmb.SelectedItem & "/" & YearCmb.SelectedItem
        strStopDate = MonthCmb.SelectedIndex + 1 & "/" & DayStopCmb.SelectedItem & "/" & YearCmb.SelectedItem

    End Sub


    Private Sub loadDays()

        If Not finishedLoad AndAlso Not hasDayCmbValue() Then Exit Sub
        daysListStart = formUtils.GetDaysInMonthList(YearCmb.SelectedItem, MonthCmb.SelectedIndex + 1)
        daysListStop = formUtils.GetDaysInMonthList(YearCmb.SelectedItem, MonthCmb.SelectedIndex + 1)

        DayStartCmb.DataSource = daysListStart

        With DayStopCmb
            .DataSource = daysListStop
            .BeginUpdate()
            .SelectedIndex = daysListStop.Count - 1
            .EndUpdate()
        End With

    End Sub

    Private Function hasDayCmbValue() As Boolean
        If YearCmb.SelectedItem IsNot Nothing AndAlso MonthCmb.SelectedItem IsNot Nothing AndAlso DayStartCmb.SelectedItem IsNot Nothing AndAlso DayStopCmb.SelectedItem IsNot Nothing Then
            Return True
        End If

        Return False
    End Function

    Private Sub reloadDayStop()
        If DayStartCmb.SelectedItem > DayStopCmb.SelectedItem Then
            DayStopCmb.SelectedIndex = formUtils.FindComboBoxItemByText(DayStopCmb, DayStartCmb.SelectedItem)
        End If
    End Sub

    Private Sub reloadDayStart()
        If DayStopCmb.SelectedItem < DayStartCmb.SelectedItem Then
            DayStartCmb.SelectedIndex = formUtils.FindComboBoxItemByText(DayStartCmb, DayStopCmb.SelectedItem)
        End If
    End Sub

    ' LOAD UI

    Private Sub loadStatus()
        EmployeesCountLabel.Text = empDT.Rows.Count - 1 ' don't count super admin
        ServicesNumberLabel.Text = servDT.Rows.Count
        CustomersNumberLabel.Text = custDT.Rows.Count
        SuppliersNumberLabel.Text = suppDT.Rows.Count
        ItemsCountLabel.Text = invDT.Rows.Count
    End Sub

    Private Sub loadWelcome()
        WelcomeMessageLabel.Text = "Welcome, " & formUtils.getEmployeeName(Current.id)
        Label10.Text = Current.position
    End Sub

    ' POSITIONS CHART

    Private Sub loadPositionChart()

        Dim series As New Series()

        Dim getPositionEnum = dbHelper.GetEnums(empConst.empTableStr, empConst.empAdminPosStr)

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Bar
        End With

        For Each position In getPositionEnum
            Dim totalCount As Integer = suppDT.Select($"{supConst.supTypeStr} = '{position}'").Length
            series.Points.AddXY(position, totalCount)
        Next

        With PositionsChart
            .Series.Clear()
            .Titles.Clear() ' Clears all chart titles
            .Legends.Clear() ' Clears all legends
            .ChartAreas.Clear() ' Clears all chart areas
            .Series.Add(series)
            .Titles.Add("Position Summary")
            .ChartAreas.Add(New ChartArea)
        End With

    End Sub

    ' INVENTORY AVAILABILITRY

    Private Sub loadInvUsedChart()
        Dim series As New Series()

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Available", formUtils.CalcIntegerDTCol(invDT, invConst.availableQtyStr))
            .Points.AddXY("Used", formUtils.CalcIntegerDTCol(itemDT, itemConst.quantityUsedStr))
        End With

        With InventoryGraph
            .Series.Clear()
            .Titles.Clear() ' Clears all chart titles
            .Legends.Clear() ' Clears all legends
            .ChartAreas.Clear() ' Clears all chart areas
            .Series.Add(series)
            .Titles.Add("Inventory Availability")
            .ChartAreas.Add(New ChartArea)
        End With

    End Sub

    ' SALES CHART

    Private Sub loadSalesChart()

        Dim series As New Series()

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Profit", formUtils.calcDecimalDTCol(servDT, servConst.TotalCost))
            .Points.AddXY("Expenses", formUtils.calcDecimalDTCol(invDT, invConst.totalCostStr))
        End With

        With SalesChart
            .Series.Clear()
            .Titles.Clear() ' Clears all chart titles
            .Legends.Clear() ' Clears all legends
            .ChartAreas.Clear() ' Clears all chart areas
            .Series.Add(series)
            .ChartAreas.Add(New ChartArea)
            .Titles.Add("Profit - Inventory Expenses")
        End With

    End Sub

    ' SUPPLIERS CHART

    Private Sub loadSupplierStatusChart()

        ' load enums
        Dim supType = dbHelper.GetEnums(supConst.supTableStr, supConst.supTypeStr)
        Dim series As New Series()

        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Bar

        For Each type In supType
            Dim totalCount As Integer = suppDT.Select($"{supConst.supTypeStr} = '{type}'").Length
            series.Points.AddXY(type, totalCount)
        Next

        With SupplierStatusChart
            .Series.Clear()
            .Titles.Clear() ' Clears all chart titles
            .Legends.Clear() ' Clears all legends
            .ChartAreas.Clear() ' Clears all chart areas
            .Series.Add(series)
            .ChartAreas.Add(New ChartArea)
            .Titles.Add("Supplier Type Count Summary")
        End With

    End Sub

    ' TIMER

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