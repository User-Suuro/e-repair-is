
Imports System.Windows.Forms.DataVisualization.Charting

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


    ' FILTER VARS
    Private strStartDate As String
    Private strStopDate As String


    Private Sub loadData()
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

        loadDTPVal()
        reloadStrFilter()
        loadCharts()

        Cursor = Cursors.Default
    End Sub
    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStatus()
        loadWelcome()
        loadTimer()
    End Sub


    Private Sub loadCharts(Optional filterMode As Boolean = True)
        LoadJobChart(filterMode)
        loadInvUsedChart(filterMode)
        loadSalesChart(filterMode)
        loadSupplierStatusChart(filterMode)
    End Sub

    ' FILTER CONTROLS

    Private Sub loadDTPVal()
        CalendarFrom.Value = Date.Now
        CalendarTo.Value = Date.Now.AddMonths(1)
    End Sub

    Private Sub reloadStrFilter()
        strStartDate = CalendarFrom.Value.ToString(constants.getDateFormat)
        strStopDate = CalendarFrom.Value.ToString(constants.getDateFormat)
    End Sub

    ' FILTER EVENTS

    Private Sub CalendarFrom_ValueChanged(sender As Object, e As EventArgs) Handles CalendarFrom.ValueChanged
        formUtils.ReloadDayStart(CalendarFrom, CalendarTo)
    End Sub

    Private Sub CalendarTo_ValueChanged(sender As Object, e As EventArgs) Handles CalendarTo.ValueChanged
        formUtils.ReloadDayStop(CalendarFrom, CalendarTo)
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadStrFilter()
        loadCharts()
    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        loadCharts(False)
    End Sub


    ' POSITIONS CHART

    Private Sub LoadJobChart(Optional filterDate As Boolean = True)

        Dim series As New Series()
        Dim getPositionEnum = dbHelper.GetEnums(empConst.empTableStr, empConst.empJobPosStr).Skip(1)

        Dim localDT As DataTable = empDT

        If filterDate Then
            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, empConst.empAddDateStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Bar
        End With

        For Each jobType In getPositionEnum
            Dim totalCount As Integer = localDT.Select($"{empConst.empJobPosStr} = '{jobType}'").Length
            series.Points.AddXY(jobType, totalCount)
        Next

        formUtils.formatChart(JobsChart, series, "Job Summary Classifications")

    End Sub

    ' INVENTORY AVAILABILITRY

    Private Sub loadInvUsedChart(Optional filterDate As Boolean = True)
        Dim series As New Series()

        Dim localinvDT As DataTable = invDT
        Dim localitemDT As DataTable = itemDT

        If filterDate Then
            Try
                localinvDT = formUtils.FilterDates(localinvDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, invConst.dateAddedStr)
                localitemDT = formUtils.FilterDates(localitemDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, itemConst.dateUsedCol)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Available", formUtils.CalcIntegerDTCol(localinvDT, invConst.availableQtyStr))
            .Points.AddXY("Used", formUtils.CalcIntegerDTCol(localitemDT, itemConst.quantityUsedStr))
        End With

        formUtils.formatChart(InventoryGraph, series, "Inventory Availability")

    End Sub

    ' SALES CHART

    Private Sub loadSalesChart(Optional filterDate As Boolean = True)

        Dim series As New Series()

        Dim localinvDT As DataTable = invDT
        Dim localservDT As DataTable = servDT

        If filterDate Then
            Try
                localinvDT = formUtils.FilterDates(localinvDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, invConst.dateAddedStr)
                localservDT = formUtils.FilterDates(localservDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Profit", formUtils.calcDecimalDTCol(localservDT, servConst.TotalCost))
            .Points.AddXY("Expenses", formUtils.calcDecimalDTCol(localinvDT, invConst.totalCostStr))
        End With

        formUtils.formatChart(SalesChart, series, "Profit - Inventory Expenses")

    End Sub

    ' SUPPLIERS CHART

    Private Sub loadSupplierStatusChart(Optional filterDate As Boolean = True)
        Dim supType = dbHelper.GetEnums(supConst.supTableStr, supConst.supTypeStr)

        Dim series As New Series()

        Dim localsuppDT As DataTable = suppDT

        If filterDate Then
            Try
                localsuppDT = formUtils.FilterDates(localsuppDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, supConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Bar

        For Each type In supType
            Dim totalCount As Integer = localsuppDT.Select($"{supConst.supTypeStr} = '{type}'").Length
            series.Points.AddXY(type, totalCount)
        Next

        formUtils.formatChart(SupplierStatusChart, series, "Supplier Type Count Summary")
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


End Class