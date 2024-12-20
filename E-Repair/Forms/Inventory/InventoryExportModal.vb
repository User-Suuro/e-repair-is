﻿Imports System.Runtime.CompilerServices

Public Class InventoryExportModal

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    Dim invConst As New InventoryDBConstants
    Dim exportUtils As New ExportUtils

    Private Sub ExportAllBtn_Click(sender As Object, e As EventArgs) Handles ExportAllBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

        With invConst
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
            Dim dt = dbHelper.GetAllByCol(keys, invConst.invTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"All Inventory Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With

    End Sub

    Private Sub ExportPrintBtn_Click(sender As Object, e As EventArgs) Handles ExportPrintBtn.Click

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New InventoryExportPrintable
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function
        )

    End Sub
    Private Sub ExportUsedBtn_Click(sender As Object, e As EventArgs) Handles ExportUsedBtn.Click
        formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New InventoryExportUsed
           Return modal
       End Function,
       -1,
       Function(modal)
           Return Nothing
       End Function
       )
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub


End Class