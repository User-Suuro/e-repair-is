Public Class DummyModal
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Public Property quantityReturned As Integer = -1
    Public Property dataToBeGen As String = Nothing

    Private targetQuantity As Integer = -1

    Public Property selectedTechID As Integer = Nothing
    Public Property selectedCustID As Integer = Nothing
    Public Property selectedSuppID As Integer = Nothing

    Private Sub QuantityNumeric_ValueChanged(sender As Object, e As EventArgs) Handles QuantityNumeric.ValueChanged
        targetQuantity = QuantityNumeric.Value
    End Sub

    Private Sub DummyModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DummyTableLayout
            If dataToBeGen = constants.EmployeesTitle Then
                .ColumnStyles(1).Width = 0.0F
                .ColumnStyles(2).Width = 0.0F
                .ColumnStyles(3).Width = 0.0F
                .ColumnStyles(4).Width = 0.0F
                .ColumnStyles(5).Width = 0.0F
                .ColumnStyles(6).Width = 0.0F
            ElseIf dataToBeGen = constants.getCustomerTitle Then
                .ColumnStyles(1).Width = 0.0F
                .ColumnStyles(2).Width = 0.0F
                .ColumnStyles(3).Width = 0.0F
                .ColumnStyles(4).Width = 0.0F
                .ColumnStyles(5).Width = 0.0F
                .ColumnStyles(6).Width = 0.0F
            ElseIf dataToBeGen = constants.SuppliersTitle Then
                .ColumnStyles(1).Width = 0.0F
                .ColumnStyles(2).Width = 0.0F
                .ColumnStyles(3).Width = 0.0F
                .ColumnStyles(4).Width = 0.0F
                .ColumnStyles(5).Width = 0.0F
                .ColumnStyles(6).Width = 0.0F
            ElseIf dataToBeGen = constants.InventoryTitle Then
                .ColumnStyles(1).Width = 0.0F
                .ColumnStyles(2).Width = 0.0F
                .ColumnStyles(3).Width = 0.0F
                .ColumnStyles(4).Width = 0.0F
                .ColumnStyles(5).Width = 14.29F
                .ColumnStyles(6).Width = 14.29F
            ElseIf dataToBeGen = constants.ServicesTitle Then
                .ColumnStyles(1).Width = 14.29F
                .ColumnStyles(2).Width = 14.29F
                .ColumnStyles(3).Width = 14.29F
                .ColumnStyles(4).Width = 14.29F
                .ColumnStyles(5).Width = 0.0F
                .ColumnStyles(6).Width = 0.0F
            End If
        End With

    End Sub
    'If PaymentTermsCmbBox.SelectedItem = "Others" Then
    '    With PaymentTermsTableLayout
    '        .ColumnStyles(0).Width = 50.0F
    '        .ColumnStyles(1).Width = 50.0F
    '    End With
    'Else

    '    With PaymentTermsTableLayout
    '        .ColumnStyles(0).Width = 100.0F
    '        .ColumnStyles(1).Width = 0.0F
    '    End With
    'End If
    Private Function ShowMsg(quantity As Integer) As Boolean
        If targetQuantity <= 0 Then
            MsgBox("Please Add Quantity")
            Return False
        End If

        If formUtils.ShowMessageBoxResult("Caution", $"Are you sure you want to generate { quantity } dummy data? This action will greatly affect your database.") Then
            Return True
        End If

        Return False
    End Function

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        If Not ShowMsg(targetQuantity) Then Exit Sub
        quantityReturned = targetQuantity
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click
        selectedCustID = formUtils.ShowModalWithHandler(
             Function(id)
                 Dim modal As New CustomerForm
                 modal.selectMode = True
                 Return modal
             End Function,
             -1,
             Function(modal)
                 Return modal.selectedCustID
             End Function
          )

        If selectedCustID = -1 Then Exit Sub

        CustomerIDTxtBox.Text = selectedCustID
    End Sub

    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click
        selectedTechID = formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeForm
            modal.selectMode = True
            modal.techOnly = True
            Return modal
        End Function,
        -1,
        Function(modal)
            Return modal.selectedEmpID
        End Function
        )

        If selectedTechID = -1 Then Exit Sub

        TechnicianIDTxtBox.Text = selectedTechID

    End Sub

    Private Sub SelectSupplierBtn_Click(sender As Object, e As EventArgs) Handles SelectSupplierBtn.Click
        selectedSuppID = formUtils.ShowModalWithHandler(
      Function(id)
          Dim modal As New SuppliersForm
          modal.selectMode = True
          Return modal
      End Function,
      -1,
      Function(modal)
          Return modal.selectedID
      End Function
      )

        If selectedSuppID = -1 Then Exit Sub

        SupplierIDTxtBox.Text = selectedSuppID
    End Sub


End Class