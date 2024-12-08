Public Class ServicesExportModal

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim servConst As New ServiceDBConstants
    Dim constants As New Constants

    Private Sub ExportAllBtn_Click(sender As Object, e As EventArgs) Handles ExportAllBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

        With servConst
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
            Dim dt = dbHelper.GetAllByCol(keys, servConst.svcTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"All Service Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub ExportSummBtn_Click(sender As Object, e As EventArgs) Handles ExportSummBtn.Click
        formUtils.ShowModalWithHandler(
      Function(id)
          Dim modal As New ServicePrintableReport
          Return modal
      End Function,
      -1,
      Function(modal)
          Return Nothing
      End Function
      )

    End Sub

    Private Sub ExportClmdBtn_Click(sender As Object, e As EventArgs) Handles ExportClmdBtn.Click
        formUtils.ShowModalWithHandler(
      Function(id)
          Dim modal As New ServiceSalesReport
          Return modal
      End Function,
      -1,
      Function(modal)
          Return Nothing
      End Function
      )


    End Sub

    Private Sub ExportPendBtn_Click(sender As Object, e As EventArgs) Handles ExportPendBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

        With servConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .PartsUsed, "Part Used"},
              { .partsCostStr, "Parts Cost"},
              { .TotalCost, "Total Cost"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetRowByColValue(keys, servConst.svcTableStr, servConst.svcStatusStr, constants.getPendingString)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"Service Pending Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
    End Sub

End Class