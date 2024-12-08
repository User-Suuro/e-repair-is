Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class EmployeeExportPrintable
    Dim empConst As New EmployeesDBConstants
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim exportUtils As New ExportUtils

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub EmployeeExportPrintable_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub reloadRLDCData()
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
            Dim reportDataSource As New ReportDataSource(constants.getDataSetName, empDT)
            exportUtils.LoadToRLDC(ReportViewer1, reportDataSource, "EmployeesReport.rldc")
        End With
    End Sub


End Class