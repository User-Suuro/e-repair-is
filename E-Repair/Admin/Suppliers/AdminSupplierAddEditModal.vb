Public Class AdminSupplierAddEditModal
    Public Property editMode As Boolean = False

    Dim formModal As Form
    Dim formUtils As FormUtils
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If editMode Then
            EditModeFunction()
            Exit Sub
        End If


    End Sub

    Private Sub EditModeFunction()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub
End Class