Public Class AdminSupplierAddEditModal
    ' TOOLS

    Dim formModal As Form
    Dim formUtils As FormUtils

    Public Property editMode As Boolean = False



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If editMode Then
            EditModeFunction()
            Exit Sub
        End If

        ' SAVE
        Try

        Catch ex As Exception

        End Try



    End Sub

    Private Sub EditModeFunction()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub SupplierTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierTypeCmbBox.SelectedIndexChanged
        If SupplierTypeCmbBox.SelectedItem = "Others" Then
            With SupplierTypeTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            With SupplierTypeTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If

    End Sub

    Private Sub BnkDetailsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BnkDetailsCmbBox.SelectedIndexChanged
        If BnkDetailsCmbBox.SelectedItem = "Others" Then
            With BankDetailsTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            With BankDetailsTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    Private Sub ContractTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContractTypeCmbBox.SelectedIndexChanged
        If ContractTypeCmbBox.SelectedItem = "Others" Then
            With ContractTypeTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            With ContractTypeTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    Private Sub PaymentTermsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentTermsCmbBox.SelectedIndexChanged
        If PaymentTermsCmbBox.SelectedItem = "Others" Then
            With PaymentTermsTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            With PaymentTermsTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub
End Class