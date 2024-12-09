Imports System.Runtime.Remoting
Imports Microsoft.Reporting.WinForms

Public Class InventoryExportUsed

    Dim itemConst As New ItemsDBConstants

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Dim itemDT As New DataTable

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalendarFrom.Value.AddYears(-1)
        loadInvData()
        reloadRLDCData()
    End Sub

    ' INV DATA

    Private Sub loadInvData()
        With itemConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
               { .ItemId, "Item ID"},
               { .ServiceId, "Service ID"},
               { .quantityUsedStr, "Quantity Used"},
               { .totalCost, "Total Cost"},
               { .reasonUsed, "Reason For Used"},
               { .InventoryId, "Inventory ID"},
               { .dateUsedCol, "Used Data"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            itemDT = dbHelper.GetAllByCol(keys, .TableName)
        End With
    End Sub

    ' INVENTORY REPORT

    Private Sub reloadRLDCData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = itemDT
        localDT = formUtils.FormatSingleDateColumn(itemDT, itemConst.dateUsedCol, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, itemConst.dateUsedCol)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "UsedItemsReport")
    End Sub

    ' BTN RELOAD

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadRLDCData()
    End Sub

    ' FETCH ALL

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        reloadRLDCData(False)
    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport
        dbHelper.Logs("Printable Used Items Reports", Current.id)
    End Sub


End Class