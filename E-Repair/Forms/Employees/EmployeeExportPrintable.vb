Imports Microsoft.Reporting.WinForms

Public Class EmployeeExportPrintable

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub EmployeeExportPrintable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptDS As New ReportDataSource
        Dim ds As New DataSet1


        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\EmployeesReport.rdlc"
                .DataSources.Clear()
            End With

            ds.Tables("")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class