Public Class TechnicianDashboardForm

    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim servDT As New DataTable
    Dim invDT As New DataTable
    Dim itemDT As New DataTable

    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants

    Private Sub TechnicianDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadStatus()
    End Sub
    Private Sub loadData()
        invDT = dbHelper.GetRowByColValue(New List(Of String) From {invConst.archivedStr, invConst.invIDStr, invConst.availableQtyStr, invConst.totalCostStr}, invConst.invTableStr, invConst.archivedStr, 0)
        servDT = dbHelper.GetRowByColWTwoVal(New List(Of String) From {servConst.archivedStr, servConst.dateClaimedStr, servConst.TotalCost, servConst.techIDStr}, servConst.svcTableStr, servConst.archivedStr, 0, servConst.techIDStr, Current.id)

        ' load item DT used by technician in services

        Dim localItemsDT = dbHelper.GetAllByCol(New List(Of String) From {itemConst.ServiceId, itemConst.quantityUsedStr}, itemConst.TableName)

        For Each servRow As DataRow In servDT.Rows
            Dim serviceID = Convert.ToInt32(servRow(servConst.techIDStr))

            Dim matchingRows = localItemsDT.AsEnumerable().Where(Function(row) _
            Not IsDBNull(row(itemConst.ServiceId)) AndAlso Convert.ToInt32(row(itemConst.ServiceId)) = serviceID)

            For Each matchingRow As DataRow In matchingRows
                Dim newRow As DataRow = itemDT.NewRow()
                newRow.ItemArray = matchingRow.ItemArray.Clone()
                itemDT.Rows.Add(newRow)
            Next
        Next

    End Sub

    Private Sub loadStatus()
        ServCountLabel.Text = servDT.Rows.Count
        ItemsUsedLabelCount.Text = itemDT.Rows.Count
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