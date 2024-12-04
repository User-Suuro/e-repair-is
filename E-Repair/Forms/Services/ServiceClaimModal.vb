Imports System.IO
Imports System.Runtime.InteropServices

Public Class ServiceClaimModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants
    Dim itemConst As New ItemsDBConstants
    Dim custConst As New CustomersDBConstants

    Dim exportUtils As New ExportUtils

    Public Property selectedID As Integer = -1
    Private Property totalPaid As Decimal
    Private Property change As Decimal
    Private Property paymentMethod As String
    Private Property totalCost As Decimal
    Private Property archivedStatus As Boolean = False
    Private Property customerID

    ' REQUIRED
    Private Sub ServiceClaimModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbds(-1)

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        loadValues()
    End Sub

    Private Sub loadValues()

        Dim serviceDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If serviceDT.Rows.Count = 0 Then Exit Sub

        With serviceDT.Rows(0)
            customerID = .Item(servConst.custIDStr)
            RepairStatusTxtBox.Text = .Item(servConst.svcStatusStr)
            DateCompletedTxtBox.Text = .Item(servConst.dateCompletedStr)
            RepairNotesTxtBox.Text = .Item(servConst.repairNotesStr)

            PartsUsedTxtBox.Text = .Item(servConst.PartsUsed)

            TechnicianFeeTxtBox.Text = .Item(servConst.techFeeStr)
            totalCost = .Item(servConst.TotalCost)
            PartsCostTxtBox.Text = .Item(servConst.partsCostStr)
            TotalCostTxtBox.Text = totalCost

            archivedStatus = .Item(servConst.archivedStr)

            Dim deviceImg = .Item(servConst.devProfilePathStr)
            If File.Exists(deviceImg) Then
                DeviceCirclePictureBox.Image = Image.FromFile(deviceImg)
            End If

        End With

    End Sub

    Private Sub loadCmbds(index As Integer)
        dbHelper.LoadEnumsToCmb(PaymentMethodCmb, servConst.svcTableStr, servConst.payMethodStr, index)
    End Sub


    Private Sub DateClaimedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateClaimedTxtBox.TextChanged
        DateClaimedTxtBox.Text = DateTime.Now()
    End Sub

    Private Sub TotalPaidTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPaidTxtBox.TextChanged
        Decimal.TryParse(TotalPaidTxtBox.Text, totalPaid)
        change = totalPaid - totalCost
        ChangeTxtBox.Text = change
    End Sub

    Private Sub TotalPaidTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalPaidTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateDecimalInput(TotalPaidTxtBox, e)
    End Sub

    Private Sub ChangeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ChangeTxtBox.TextChanged

    End Sub

    Private Sub PaymentMethodCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentMethodCmb.SelectedIndexChanged
        paymentMethod = PaymentMethodCmb.SelectedItem
    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged

    End Sub
    ' FOR VIEW

    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub RepairStatusTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairStatusTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub DateCompletedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DateCompletedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        ' for view
    End Sub

    Private Sub SeePartsBtn_Click(sender As Object, e As EventArgs) Handles SeePartsBtn.Click
        ' for view

        Dim resultID As Integer = formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InventoryItemModal
             modal.serviceID = id
             Return modal
         End Function,
         selectedID,
         Function(modal)
             Return Nothing
         End Function
         )

    End Sub

    Private Sub GenerateReceiptBtn_Click(sender As Object, e As EventArgs) Handles GenerateReceiptBtn.Click

        If change < 0 Then
            MsgBox("Insufficient Payment")
            Exit Sub
        End If

        ' to do generate receipt
        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .svcStatusStr, constants.getClaimedString},
                { .totalPaidStr, totalPaid},
                { .dateClaimedStr, DateTime.Now()},
                { .custChangeStr, change},
                { .payMethodStr, paymentMethod},
                { .paidStr, True}
            }

            If formUtils.EditRow(.svcTableStr, .svcIDStr, selectedID, updateData) Then

                ' update customer
                With custConst
                    Dim custDT As DataTable = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custIDStr, custConst.custTotalPaidStr}, custConst.custTableStr, custConst.custIDStr, customerID)

                    If custDT.Rows.Count = 0 Then Exit Sub

                    Dim getPreviousTotalPaid As Decimal

                    With custDT.Rows(0)
                        getPreviousTotalPaid = .Item(custConst.custTotalPaidStr)
                    End With

                    Dim updateCustData As New Dictionary(Of String, Object) From {
                         { .custTotalPaidStr, totalPaid + getPreviousTotalPaid}
                    }

                    If dbHelper.UpdateRecord(custConst.custTableStr, custConst.custIDStr, customerID, updateCustData) Then
                        ' Generate the Excel receipt
                        GenerateExcelReceipt()
                        Me.Close()
                    End If
                End With
            End If

        End With

    End Sub
    Private Sub GenerateExcelReceipt()

        Dim serviceDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If serviceDT.Rows.Count = 0 Then Exit Sub

        Try
            With serviceDT.Rows(0)
                ' Create a new Excel application
                Dim excelApp = CreateObject("Excel.Application")
                Dim workbook = excelApp.Workbooks.Add
                Dim worksheet = workbook.Sheets(1)

                worksheet.Cells(1, 1).Value = "Receipt"
                worksheet.Cells(1, 1).Font.Bold = True
                worksheet.Cells(1, 1).Font.Size = 16

                worksheet.Cells(2, 1).Value = "Service ID:"
                worksheet.Cells(2, 2).Value = selectedID

                worksheet.Cells(3, 1).Value = "Date Commissioned:"
                worksheet.Cells(3, 2).Value = .Item(servConst.dateAddedStr)

                worksheet.Cells(4, 1).Value = "Date Claimed:"
                worksheet.Cells(4, 2).Value = .Item(servConst.dateClaimedStr)

                worksheet.Cells(6, 1).Value = "Technician ID:"
                worksheet.Cells(6, 2).Value = .Item(servConst.techIDStr)

                worksheet.Cells(6, 1).Value = "Technician Name:"
                worksheet.Cells(6, 2).Value = .Item(servConst.techNameStr)

                worksheet.Cells(7, 1).Value = "Technician Fee:"
                worksheet.Cells(7, 2).Value = .Item(servConst.totalPaidStr)

                worksheet.Cells(8, 1).Value = "Parts Used:"
                worksheet.Cells(8, 2).Value = .Item(servConst.PartsUsed)

                worksheet.Cells(9, 1).Value = "Parts Cost:"
                worksheet.Cells(9, 2).Value = .Item(servConst.partsCostStr)

                worksheet.Cells(11, 1).Value = "Total Cost:"
                worksheet.Cells(11, 2).Value = .Item(servConst.TotalCost)

                worksheet.Cells(12, 1).Value = "Total Paid:"
                worksheet.Cells(12, 2).Value = .Item(servConst.totalPaidStr)

                worksheet.Cells(13, 1).Value = "Change Given:"
                worksheet.Cells(13, 2).Value = .Item(servConst.custChangeStr)

                worksheet.Cells(15, 1).Value = "Payment Method:"
                worksheet.Cells(15, 2).Value = .Item(servConst.payMethodStr)

                worksheet.Cells(17, 1).Value = "Parts Details"
                worksheet.Cells(17, 1).Font.Bold = True
                worksheet.Cells(17, 1).Font.Size = 14

                ' Add a header row for item details
                Dim currentRow As Integer = 18 ' Start row for item details

                worksheet.Cells(currentRow, 1).Value = "Quantity"
                worksheet.Cells(currentRow, 2).Value = "Total Cost"
                worksheet.Cells(currentRow, 3).Value = "Reason used"

                worksheet.Rows(currentRow).Font.Bold = True

                ' Loop through the items in the DataTable (itemUsedDt)
                Dim itemDT = dbHelper.GetRowByValue(itemConst.TableName, itemConst.ServiceId, selectedID)

                If itemDT.Rows.Count > 0 Then
                    For Each row As DataRow In itemDT.Rows
                        currentRow += 1
                        worksheet.Cells(currentRow, 1).Value = row(itemConst.quantityUsedStr) ' Replace with your column name for "Quantity"
                        worksheet.Cells(currentRow, 2).Value = row(itemConst.totalCost) ' Replace with your column name for "Unit Price"
                        worksheet.Cells(currentRow, 3).Value = row(itemConst.reasonUsed)
                    Next
                End If

                worksheet.Columns().AutoFit()

                Dim savePath As String = exportUtils.GetSaveFilePath($"Receipt for Service { selectedID }.xlsx", "Excel Files|*.xlsx")

                If Not String.IsNullOrEmpty(savePath) Then
                    workbook.SaveAs(savePath)
                    MsgBox($"Successfully Saved in {savePath}")
                End If

                workbook.Close()
                excelApp.Quit()

                ' Release Excel objects
                Marshal.ReleaseComObject(worksheet)
                Marshal.ReleaseComObject(workbook)
                Marshal.ReleaseComObject(excelApp)
            End With


        Catch ex As Exception
            MsgBox("An error occurred while generating the receipt: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class