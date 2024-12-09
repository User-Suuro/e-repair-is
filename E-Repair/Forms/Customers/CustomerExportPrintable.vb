Imports Microsoft.Reporting.WinForms

Public Class CustomerExportPrintable

    Dim custConst As New CustomersDBConstants

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Dim custDT As New DataTable

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub EmployeeExportPrintable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalendarFrom.Value.AddYears(-1)
        loadData()
        reloadRLDCData()
    End Sub

    Private Sub loadData()
        With custConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .custIDStr, "Customer ID"},
              { .custFirstStr, "First Name"},
              { .custMidStr, "Middle Name"},
              { .custLastStr, "Last Name"},
              { .custContactStr, "Contact Number"},
              { .custAddressStr, "Address"},
              { .custGenderStr, "Gender"},
              { .custEmailStr, "Email"},
              { .custTotalPaidStr, "Total Paid"},
              { .custLastTransStr, "Last Transaction"},
              { .custDateAddedStr, "Date Added"},
              { .custArchDateStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            custDT = dbHelper.GetAllByCol(keys, .custTableStr)
        End With
    End Sub

    Private Sub reloadRLDCData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = custDT
        localDT = formUtils.FormatSingleDateColumn(custDT, custConst.custDateAddedStr, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, empConst.empAddDateStr)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "CustomersReport")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadRLDCData()
    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        reloadRLDCData(False)
    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport
        dbHelper.Logs("Printable Customers Reports", Current.id)
    End Sub

End Class