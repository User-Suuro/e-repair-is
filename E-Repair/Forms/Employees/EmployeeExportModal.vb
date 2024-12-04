Public Class EmployeeExportModal

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    Dim empConst As New EmployeesDBConstants
    Dim exportUtils As New ExportUtils


    Private Sub ExportAllBtn_Click(sender As Object, e As EventArgs) Handles ExportAllBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to this export table?") Then Exit Sub

        With empConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .empIDStr, "Employee ID"},
              { .empFirstStr, "First Name"},
              { .empMidStr, "Middle Name"},
              { .empLastStr, "Last Name"},
              { .empSexStr, "Sex"},
              { .empBirthStr, "Birthdate"},
              { .empCivilStr, "Civil Status"},
              { .empAddrStr, "Address"},
              { .empContactStr, "Contact Number"},
              { .empStatusStr, "Employment Status"},
              { .empHiredStr, "Date Hired"},
              { .empSSSStr, "SSS No."},
              { .empPagibigStr, "Pag-ibig No."},
              { .empTINStr, "Tin No."},
              { .empEmailStr, "Email"},
              { .empArchDateStr, "Date Archived"},
              { .empAddedByName, "Added By"},
              { .empAddDateStr, "Date Added"},
              { .empLastAccessedStr, "Last Accessed"},
              { .empJobPosStr, "Job Type"},
              { .empAdminPosStr, "Admin Position"},
              { .empDestStr, "Personnel Destination"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim empDT As DataTable = dbHelper.GetAllByCol(keys, .empTableStr)

            If empDT.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"All Employees Reports_{DateTime.Now:yyyy-MM-dd}"

            If exportUtils.ExportDataTableToExcel(empDT, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub ExportPrintBtn_Click(sender As Object, e As EventArgs) Handles ExportPrintBtn.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to this export table?") Then Exit Sub

        With empConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .empFirstStr, "First Name"},
              { .empStatusStr, "Employment Status"},
              { .empHiredStr, "Date Hired"},
              { .empJobPosStr, "Job Type"},
              { .empAdminPosStr, "Admin Position"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim empDT As DataTable = dbHelper.GetAllByCol(keys, .empTableStr)

            If empDT.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title As String = $"Employees Reports_{DateTime.Now:yyyy-MM-dd}"


            If exportUtils.ExportDataTableToExcel(empDT, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

End Class