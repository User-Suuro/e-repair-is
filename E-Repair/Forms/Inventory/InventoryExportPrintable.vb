Imports System.Runtime.Remoting
Imports Microsoft.Reporting.WinForms

Public Class InventoryExportPrintable

    Dim invCOnst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Dim invDT As New DataTable
    Dim itemDT As New DataTable

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalendarFrom.Value.AddYears(-1)
        loadInvData()
        reloadRLDCData()
    End Sub

    Private Sub loadInvData()
        With invCOnst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .invIDStr, "Inventory ID"},
              { .supIDStr, "Supplier ID"},
              { .itemCatStr, "Item Category"},
              { .itemNameStr, "Item Name"},
              { .itemDescStr, "Item Description"},
              { .serialNumStr, "Serial Number"},
              { .hazClassStr, "Hazardous Classification"},
              { .availableQtyStr, "Available Quantity"},
              { .costPerItem, "Cost Per Item"},
              { .totalCostStr, "Total Cost"},
              { .physLocStr, "Physical Location"},
              { .restockDateStr, "Restock Date"},
              { .archivedStr, "Archived Status"},
              { .dateArchivedStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            invDT = dbHelper.GetAllByCol(keys, .invTableStr)
        End With
    End Sub

    Private Sub loadUsedItemsData()
        With itemConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
                { .ServiceId, "Service ID"},
                { .dateUsedCol, "Date Used"},
                { .quantityUsedStr, "Quantity Used"},
                { .totalCost, "Total Cost"},
                { .reasonUsed, "Reason Used"},
                { .InventoryId, "Inventory ID"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            itemDT = dbHelper.GetAllByCol(keys, .TableName)
        End With
    End Sub

    Private Sub AvailableBtn_Click(sender As Object, e As EventArgs) Handles AvailableBtn.Click
        loadInvData()
    End Sub

    Private Sub UsedItemsBtn_Click(sender As Object, e As EventArgs) Handles UsedItemsBtn.Click
        loadUsedItemsData()
    End Sub

    ' USED ITEMS REPORT

    Private Sub reloadRLDCUsedItemData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = itemDT
        localDT = formUtils.FormatSingleDateColumn(itemDT, itemConst.dateUsedCol, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, itemConst.dateUsedCol)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "UsedItemsReport")
    End Sub

    ' INVENTORY REPORT

    Private Sub reloadRLDCData(Optional filterMode As Boolean = True)
        Dim localDT As DataTable = invDT
        localDT = formUtils.FormatSingleDateColumn(invDT, invCOnst.dateAddedStr, constants.getDateFormat)

        If filterMode Then
            ' filter stuffs
            localDT = formUtils.FilterDates(localDT, Date.Parse(CalendarFrom.Value.ToString(constants.getDateFormat)), Date.Parse(CalendarTo.Value.ToString(constants.getDateFormat)), constants.getDateFormat, invCOnst.dateAddedStr)
        End If

        Dim reportDataSource As New ReportDataSource(constants.getDataSetName, localDT)
        exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "InventoryReport")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        reloadRLDCData()
    End Sub

    Private Sub FetchAllBtn_Click(sender As Object, e As EventArgs) Handles FetchAllBtn.Click
        reloadRLDCData(False)
    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport
        dbHelper.Logs("Printable Inventory Reports", Current.id)
    End Sub


End Class