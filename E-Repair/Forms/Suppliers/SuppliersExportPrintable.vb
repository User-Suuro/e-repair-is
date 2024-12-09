Imports Microsoft.Reporting.WinForms

Public Class SuppliersExportPrintable
    Dim supConst As New SuppliersDBConstants

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Dim supDT As New DataTable

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalendarFrom.Value.AddYears(-1)
        loadData()
        reloadRLDCData()
    End Sub

    Private Sub loadData()
        With supConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .supIDStr, "Supplier ID"},
              { .compNameStr, "Company Name"},
              { .contactNumStr, "Contact Number"},
              { .contactPersonStr, "Contact Person"},
              { .compEmailStr, "Hazardous Classification"},
              { .locationStr, "Company Location"},
              { .supTypeStr, "Supplier Type"},
              { .supContractStr, "Contract Type"},
              { .bankDetailsStr, "Bank Details"},
              { .payTermsStr, "Payment Terms"},
              { .estDeliveryStr, "Estimated Delivery Time"},
              { .dateAddedStr, "Date Added"},
              { .dateArchivedStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            supDT = dbHelper.GetAllByCol(keys, .supTableStr)
        End With
    End Sub

    Private Sub reloadRLDCData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = supDT
        localDT = formUtils.FormatSingleDateColumn(supDT, supConst.dateAddedStr, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, supConst.dateAddedStr)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "SuppliersReport")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadRLDCData()
    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        reloadRLDCData(False)
    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport
        dbHelper.Logs("Printable Suppliers Reports", Current.id)
    End Sub


End Class