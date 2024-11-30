Public Class InventoryItemModal
    Dim dbHelper As New DbHelper

    Dim itemConst As New ItemsDBConstants

    Public Property inventoryID As Integer = -1
    Public Property serviceID As Integer = -1

    Private itemDT As DataTable = Nothing

    Private Sub InventoryItemModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If serviceID <> -1 Then
            itemDT = dbHelper.GetRowByValue(itemConst.TableName, itemConst.ServiceId, serviceID)
        End If

        If inventoryID <> -1 Then
            itemDT = dbHelper.GetRowByValue(itemConst.TableName, itemConst.InventoryId, inventoryID)
        End If

        ItemsDGV.DataSource = itemDT
    End Sub


    Private Sub loadToDGV()
        ' show service only

    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub




End Class