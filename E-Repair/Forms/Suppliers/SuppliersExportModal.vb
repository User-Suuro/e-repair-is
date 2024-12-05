Public Class SuppliersExportModal

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim supConst As New SuppliersDBConstants

    Private Sub ExportAllBtn_Click(sender As Object, e As EventArgs) Handles ExportAllBtn.Click
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
              { .addedByName, "Added By"},
              { .dateArchivedStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, supConst.supTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"All Supplier Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub ExportPrintBtn_Click(sender As Object, e As EventArgs) Handles ExportPrintBtn.Click
        With supConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .compNameStr, "Company Name"},
              { .supTypeStr, "Supplier Type"},
              { .supContractStr, "Contract Type"},
              { .bankDetailsStr, "Bank Details"},
              { .payTermsStr, "Payment Terms"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, supConst.supTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"Supplier Printable Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class