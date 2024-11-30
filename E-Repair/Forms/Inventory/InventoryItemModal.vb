Public Class InventoryItemModal

    Public Property editMode As Boolean = False
    Public Property inventoryID As Integer = -1
    Public Property serviceID As Integer = -1
    Public Property selectedColumn As String = Nothing

    Private Sub InventoryItemModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editMode Then EditPanel.Visible = True
    End Sub


    Private Sub loadToDGV()

        ' show service only




    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CostTxtBox.TextChanged

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnApplyCost.Click

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

    End Sub



End Class