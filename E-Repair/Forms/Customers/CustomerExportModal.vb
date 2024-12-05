Public Class CustomerExportModal

    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Dim exportUtils As New ExportUtils

    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants

    Private Sub ExportAllBtn_Click(sender As Object, e As EventArgs) Handles ExportAllBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

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
              { .getAddedByName, "Physical Location"},
              { .custDateAddedStr, "Restock Date"},
              { .custArchDateStr, "Added by"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, custConst.custTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"All Customer Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub ExportPrintlBtn_Click(sender As Object, e As EventArgs) Handles ExportPrintBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to export this table?") Then Exit Sub

        With custConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .custFirstStr, "First Name"},
              { .custLastStr, "Last Name"},
              { .custEmailStr, "Email"},
              { .custTotalPaidStr, "Total Paid"},
              { .custLastTransStr, "Last Transaction"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, custConst.custTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"Customer Printable Reports_{DateTime.Now:yyyy-MM-dd}"

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