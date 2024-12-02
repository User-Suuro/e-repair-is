
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminDashboardForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim supConst As New SuppliersDBConstants

    Dim constants As New Constants

    Dim empDT As DataTable
    Dim servDT As DataTable
    Dim custDT As DataTable
    Dim suppDT As DataTable
    Dim invDT As DataTable

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor = Cursors.WaitCursor
        empDT = dbHelper.GetRowByColValue(New List(Of String) From {empConst.empArchStr, empConst.empIDStr, empConst.empJobPosStr, empConst.empProfileStr}, empConst.empTableStr, empConst.empArchStr, 0)
        servDT = dbHelper.GetRowByColValue(New List(Of String) From {servConst.archivedStr}, servConst.svcTableStr, servConst.archivedStr, 0)
        custDT = dbHelper.GetRowByColValue(New List(Of String) From {custConst.custArchStr}, custConst.custTableStr, custConst.custArchStr, 0)
        suppDT = dbHelper.GetRowByColValue(New List(Of String) From {supConst.archivedStr}, supConst.supTableStr, supConst.archivedStr, 0)
        invDT = dbHelper.GetRowByColValue(New List(Of String) From {invConst.archivedStr}, invConst.invTableStr, invConst.archivedStr, 0)
        Cursor = Cursors.Default

        LoadPic()
        loadStatus()
        loadWelcome()
        loadPositionChart()
        loadTimer()
    End Sub

    Private Sub LoadPic()
        Dim picRows() As DataRow = empDT.Select($"{empConst.empIDStr} = {Current.id}")

        If picRows.Length > 0 Then
            Dim row As DataRow = picRows(0)
            Dim profilePicturePath As String = row(empConst.empProfileStr).ToString()

            If File.Exists(profilePicturePath) Then
                GunaCirclePictureBox1.Image = Image.FromFile(profilePicturePath)
            Else
                MsgBox("Profile picture file does not exist.")
            End If
        End If
    End Sub

    Private Sub loadStatus()
        EmployeesCountLabel.Text = empDT.Rows.Count - 1 ' don't count super admin
        ServicesNumberLabel.Text = servDT.Rows.Count
        CustomersNumberLabel.Text = custDT.Rows.Count
        SuppliersNumberLabel.Text = suppDT.Rows.Count
        ItemsCountLabel.Text = invDT.Rows.Count
    End Sub

    Private Sub loadWelcome()
        WelcomeMessageLabel.Text = "Welcome, " & formUtils.getEmployeeName(LoggedUser.Current.id)
        Label10.Text = LoggedUser.Current.position
    End Sub


    Private Sub loadPositionChart()
        PositionsChart.Series.Clear()
        Dim posSeries As New Series("Positions")
        posSeries.ChartType = SeriesChartType.Bar

        posSeries.Points.AddXY("Admins", empDT.Select($"{empConst.empJobPosStr} = '{constants.getAdminString}'").Length)
        posSeries.Points.AddXY("Cashiers", empDT.Select($"{empConst.empJobPosStr} = '{constants.getCashierString }'").Length)
        posSeries.Points.AddXY("Technician", empDT.Select($"{empConst.empJobPosStr} = '{constants.getTechnicianString }'").Length)
        posSeries.Points.AddXY("Utility", empDT.Select($"{empConst.empJobPosStr} = '{constants.getUtilityPersonnelString }'").Length)

        PositionsChart.Series.Add(posSeries)
        PositionsChart.Titles.Add("Positions Counts")
    End Sub

    Private Sub loadTimer()
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now.ToString("yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label6.Text = Date.Now.ToString("MMMM dd")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label8.Text = Date.Now.ToString("dddd")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label7.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub


End Class