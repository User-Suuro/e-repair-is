Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class EmployeeExportPrintable
    Dim empConst As New EmployeesDBConstants
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub EmployeeExportPrintable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptDS As New ReportDataSource


        Dim currentDir As String = System.IO.Directory.GetCurrentDirectory()

        For i As Integer = 1 To 2
            currentDir = System.IO.Directory.GetParent(currentDir).FullName
        Next

        Dim reportsPath As String = currentDir & "\Reports\EmployeesReport.rdlc"

        Try
            If Not File.Exists(reportsPath) Then
                Throw New FileNotFoundException($"The report file was not found: {reportsPath}")
            End If

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
                Dim reportDataSource As New ReportDataSource(empConst.empTableStr, empDT)

                With ReportViewer1.LocalReport
                    .ReportPath = reportsPath
                    .DataSources.Clear()
                    .DataSources.Add(reportDataSource)
                End With

            End With

            ReportViewer1.RefreshReport()

        Catch ex As Exception
            ' Display the error message
            MsgBox($"An error occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class