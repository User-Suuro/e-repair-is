Public Class SettingsForm
    Dim loadDummy As New LoadDummy
    Dim formUtils As New FormUtils

    ' MANAGE ENUMS

    Private Sub AdminSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EnumDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnumDGV.CellContentClick

    End Sub
    Private Sub CompletedWorkTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompletedWorkTxtBox.TextChanged

    End Sub

    Private Sub TableNameCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TableNameCmb.SelectedIndexChanged

    End Sub

    Private Sub AttributesCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttributesCmb.SelectedIndexChanged

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub

    ' LOAD DUMMY

    Private Function openModal() As Integer
        Return formUtils.ShowModalWithHandler(
        Function(qty)
            Dim modal As New DummyModal
            Return modal
        End Function,
        -1,
        Function(modal)
            Return modal.quantityReturned
        End Function
        )
    End Function

    Private Sub GenerateEmp_Click(sender As Object, e As EventArgs) Handles GenerateEmp.Click
        If openModal() = -1 Then Exit Sub
        loadDummy.LoadDummyDataToEmployees(openModal())
    End Sub

    Private Sub GenerateCust_Click(sender As Object, e As EventArgs) Handles GenerateCust.Click
        If openModal() = -1 Then Exit Sub
        loadDummy.LoadDummyDataToEmployees(openModal())
    End Sub

    Private Sub GenerateSupp_Click(sender As Object, e As EventArgs) Handles GenerateSupp.Click
        If openModal() = -1 Then Exit Sub
        loadDummy.LoadDummyDataToSuppliers(openModal())
    End Sub

    Private Sub GenerateServ_Click(sender As Object, e As EventArgs) Handles GenerateServ.Click
        If openModal() = -1 Then Exit Sub
        loadDummy.LoadDummyDataToServices(openModal())
    End Sub

    Private Sub GenerateInv_Click(sender As Object, e As EventArgs) Handles GenerateInv.Click
        If openModal() = -1 Then Exit Sub
        loadDummy.LoadDummyDataToInventory(openModal())
    End Sub


End Class