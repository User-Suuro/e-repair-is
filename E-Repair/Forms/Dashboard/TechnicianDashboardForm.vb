Imports System.Windows.Forms.DataVisualization.Charting
Imports Org.BouncyCastle.Math.EC

Public Class TechnicianDashboardForm

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim servDT As New DataTable
    Dim invDT As New DataTable
    Dim itemDT As New DataTable
    Dim allQueuedDT As New DataTable

    Dim constants As New Constants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants

    Private strStartDate As String
    Private strStopDate As String
    Private Sub TechnicianDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadStatus()
        loadTimer()
    End Sub

    Private Sub loadData()

        invDT = dbHelper.GetRowByColValue(New List(Of String) From {invConst.dateAddedStr, invConst.archivedStr, invConst.invIDStr, invConst.availableQtyStr, invConst.totalCostStr}, invConst.invTableStr, invConst.archivedStr, 0)
        servDT = dbHelper.GetRowByColWTwoVal(New List(Of String) From {servConst.dateAddedStr, servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.techIDStr, servConst.svcStatusStr, servConst.devTypeStr}, servConst.svcTableStr, servConst.archivedStr, 0, servConst.techIDStr, Current.id)
        allQueuedDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.dateAddedStr}, servConst.svcTableStr, servConst.svcStatusStr, constants.getQueuedStr)

        itemDT = dbHelper.GetRowByValue(itemConst.TableName, itemConst.addedByID, Current.id)

        itemDT = formUtils.FormatSingleDateColumn(itemDT, itemConst.dateUsedCol, constants.getDateFormat)
        invDT = formUtils.FormatSingleDateColumn(invDT, invConst.dateAddedStr, constants.getDateFormat)
        servDT = formUtils.FormatSingleDateColumn(servDT, servConst.dateAddedStr, constants.getDateFormat)

        loadDTPVal()
        reloadStrFilter()
        loadCharts()

    End Sub

    ' FILTER CONTROLS

    Private Sub loadDTPVal()
        CalendarFrom.Value = Date.Now.AddYears(-1)
        CalendarTo.Value = Date.Now
    End Sub

    Private Sub reloadStrFilter()
        strStartDate = CalendarFrom.Value.ToString(constants.getDateFormat)
        strStopDate = CalendarTo.Value.ToString(constants.getDateFormat)
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

    Private Sub loadCharts(Optional filterMode As Boolean = True)
        loadServStatsChart(filterMode)
        loadInvUsedChart(filterMode)
        loadDeviceTypeChart(filterMode)
    End Sub

    Private Sub loadStatus()
        ServCountLabel.Text = servDT.Rows.Count
        QueuedServicesCount.Text = allQueuedDT.Rows.Count
        ItemsUsedLabelCount.Text = formUtils.CalcIntegerDTCol(itemDT, itemConst.quantityUsedStr)
    End Sub

    Private Sub loadServStatsChart(Optional filterDate As Boolean = True)
        ' load enums
        Dim serveType = dbHelper.GetEnums(servConst.svcTableStr, servConst.svcStatusStr).Skip(1) ' skip queue
        Dim series As New Series()

        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column

        Dim localDT As DataTable = servDT

        If filterDate Then
            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        For Each type In serveType
            Dim totalCount As Integer = localDT.Select($"{servConst.svcStatusStr} = '{type}'").Length
            series.Points.AddXY(type, totalCount)
        Next

        formUtils.formatChart(ServStatusChart, series, "Services Status Summary")
    End Sub

    Private Sub loadDeviceTypeChart(Optional filterDate As Boolean = True)
        ' load enums
        Dim deviceTypes = dbHelper.GetEnums(servConst.svcTableStr, servConst.devTypeStr)

        Dim series As New Series()

        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column

        Dim localDT As DataTable = servDT

        If filterDate Then
            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        For Each devType In deviceTypes
            Dim totalCount As Integer = localDT.Select($"{servConst.devTypeStr} = '{devType}'").Length
            series.Points.AddXY(devType, totalCount)
        Next

        formUtils.formatChart(DeviceTypeChart, series, "Device Type Summary Count")

    End Sub
    Private Sub loadInvUsedChart(Optional filterDate As Boolean = True)
        Dim series As New Series("Quantity")

        Dim localInvDT As DataTable = invDT
        Dim localItemDT As DataTable = itemDT

        If filterDate Then
            Try
                localInvDT = formUtils.FilterDates(localInvDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, invConst.dateAddedStr)
                localItemDT = formUtils.FilterDates(localItemDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, itemConst.dateUsedCol)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Available", formUtils.CalcIntegerDTCol(localInvDT, invConst.availableQtyStr))
            .Points.AddXY("Used", formUtils.CalcIntegerDTCol(localItemDT, itemConst.quantityUsedStr))
        End With

        formUtils.formatChart(InvetoryAvailChart, series, "Inventory Availability")

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