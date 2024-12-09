Imports Microsoft.Reporting.WinForms

Public Class ServiceSalesReport
    Dim serveConst As New ServiceDBConstants

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Dim servDT As New DataTable

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalendarFrom.Value.AddYears(-1)
        loadData()
        reloadRLDCData()
    End Sub

    Private Sub loadData()
        With serveConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .svcIDStr, "Service ID"},
              { .custIDStr, "Customer ID"},
              { .techIDStr, "Technician ID"},
              { .techNameStr, "Technician Name"},
              { .custNameStr, "Customer Name"},
              { .devTypeStr, "Device Type"},
              { .devBrandStr, "Device Brand"},
              { .devModelStr, "Deviec Model"},
              { .svcStatusStr, "Service Status"},
              { .techFeeStr, "Technician Fee"},
              { .PartsUsed, "Part Used"},
              { .partsCostStr, "Parts Cost"},
              { .TotalCost, "Total Cost"},
              { .dateAddedStr, "Date Added"},
              { .dateArchivedStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            servDT = dbHelper.GetRowByColValue(keys, serveConst.svcTableStr, serveConst.svcStatusStr, constants.getClaimedString)
        End With
    End Sub

    Private Sub reloadRLDCData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = servDT
        localDT = formUtils.FormatSingleDateColumn(servDT, serveConst.dateAddedStr, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, serveConst.dateAddedStr)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "SalesReport")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadRLDCData()
    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        reloadRLDCData(False)
    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport
        dbHelper.Logs("Printable Sales Reports", Current.id)
    End Sub

End Class