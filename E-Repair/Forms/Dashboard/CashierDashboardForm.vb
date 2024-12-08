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

    Private FinishedLoad As Boolean = False

    Private strStartDate As String
    Private strStopDate As String

    Private Sub loadData()
        Cursor = Cursors.WaitCursor

        servDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.cashierIDStr, servConst.svcStatusStr, servConst.devTypeStr, servConst.payMethodStr, servConst.dateAddedStr}, servConst.svcTableStr, servConst.archivedStr, 0)
        custDT = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custArchStr, custConst.getAddedByID, custConst.custGenderStr, custConst.custDateAddedStr}, custConst.custTableStr, custConst.custArchStr, 0)

        servDT = formUtils.FormatSingleDateColumn(servDT, servConst.dateAddedStr, constants.getDateFormat)
        custDT = formUtils.FormatSingleDateColumn(custDT, custConst.custDateAddedStr, constants.getDateFormat)

        Cursor = Cursors.Default
    End Sub

    Private Sub CashierDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadTimer()
        loadStatus()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs)

    End Sub


    ' LOAD SERVICE CHART

    Private Sub loadServiceChart(Optional filterDate As Boolean = True)

        Dim series As New Series()
        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column

        Dim statusEnum = dbHelper.GetEnums(servConst.svcTableStr, servConst.svcStatusStr)

        Dim localDT As DataTable = servDT

        If filterDate Then
            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        For Each status In statusEnum
            Dim totalCount = localDT.Select($"{servConst.svcStatusStr} = '{status}'").Length
            series.Points.AddXY(status, totalCount)
        Next

        formUtils.formatChart(ServStatusChart, series, "Service Status Summary")

    End Sub

    ' LOAD GENDER CHART

    Private Sub loadGenderChart(Optional filterDate As Boolean = True)

        ' load enums
        Dim genders = dbHelper.GetEnums(custConst.custTableStr, custConst.custGenderStr)
        Dim series As New Series()

        series.ChartType = SeriesChartType.Bar
        series.IsVisibleInLegend = False

        Dim localDT As DataTable = custDT

        If filterDate Then
            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, custConst.custDateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try
        End If

        For Each gender In genders
            Dim totalCount As Integer = localDT.Select($"{custConst.custGenderStr} = '{gender}'").Length
            series.Points.AddXY(gender, totalCount)
        Next

        formUtils.formatChart(GenderChart, series, "Customer Gender Demographics")

    End Sub

    ' LOAD DEVICE TYPE CHART

    Private Sub loadDeviceTypeChart(Optional filterDate As Boolean = True)
        Dim localDT As DataTable = servDT

        If filterDate Then

            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format device chart: " & ex.Message)
                Exit Sub
            End Try

        End If

        Dim deviceTypes = dbHelper.GetEnums(servConst.svcTableStr, servConst.devTypeStr)

        Dim series As New Series()

        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Bar



        For Each devType In deviceTypes
            Dim totalCount As Integer = localDT.Select($"{servConst.devTypeStr} = '{devType}'").Length
            series.Points.AddXY(devType, totalCount)
        Next

        formUtils.formatChart(DevTypeChart, series, "Device Types Summary Count")

    End Sub

    ' LOAD PAYMENT METHOD CHART

    Private Sub loadPaymentMethodChart(Optional filterDate As Boolean = True)
        Dim payMethods = dbHelper.GetEnums(servConst.svcTableStr, servConst.payMethodStr)

        Dim series As New Series()
        Dim localDT As DataTable = servDT

        With series
            .IsVisibleInLegend = False
            .ChartType = SeriesChartType.Bar
        End With

        If filterDate Then

            Try
                localDT = formUtils.FilterDates(localDT, Date.Parse(strStartDate), Date.Parse(strStopDate), constants.getDateFormat, servConst.dateAddedStr)
            Catch ex As Exception
                MsgBox("Unable to filter date with invalid date format: " & ex.Message)
                Exit Sub
            End Try

        End If

        For Each method In payMethods
            Dim totalCount As Integer = localDT.Select($"{servConst.payMethodStr} = '{method}'").Length
            series.Points.AddXY(method, totalCount)
        Next

        formUtils.formatChart(PaymentMethodChart, series, "Payment Methods Summary")

    End Sub

    Private Sub loadStatus()
        ServCountLabel.Text = servDT.Rows.Count
        CustCountLabel.Text = custDT.Rows.Count
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