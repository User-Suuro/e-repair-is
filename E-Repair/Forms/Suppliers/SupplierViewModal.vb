Imports System.IO

Public Class SupplierViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim supConstants As New SuppliersDBConstants
    Dim invConst As New InventoryDBConstants

    Public Property selectedID As Integer = -1
    Private Sub AdminSupplierViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        InitValues()
    End Sub

    Private Sub InitValues()

        Dim suppDT As DataTable = dbHelper.GetRowByValue(supConstants.supTableStr, supConstants.supIDStr, selectedID)

        If suppDT.Rows.Count = 0 Then Exit Sub

        With suppDT.Rows(0)
            CompanyNameTxtBox.Text = .Item(supConstants.compNameStr)
            ContactPersonTxtBox.Text = .Item(supConstants.contactPersonStr)
            CompanyEmailTxtBox.Text = .Item(supConstants.compEmailStr)
            ContactNumberTxtBox.Text = .Item(supConstants.contactPersonStr)
            LocationTxtBox.Text = .Item(supConstants.locationStr)
            EstDelivTimeTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.estDeliveryStr))
            CompanyDescTxtBox.Text = .Item(supConstants.compDescStr)
            SupplierTypeTxtBox.Text = .Item(supConstants.supTypeStr)
            ContractTypeTxtBox.Text = .Item(supConstants.supContractStr)
            BankDetailsTxtBox.Text = .Item(supConstants.bankDetailsStr)
            PaymentTermsTxtBox.Text = .Item(supConstants.payTermsStr)
            SupplierIdTextBox.Text = .Item(supConstants.supIDStr)
            NoSuppliedItemTxtBox.Text = formUtils.GetSuppliedItems(selectedID)
            TotalPaidTxtBox.Text = .Item(supConstants.totalPaidStr)
            DateAddedTxtBox.Text = .Item(supConstants.dateAddedStr)
            CompanyPathTxtBox.Text = .Item(supConstants.compPicPathStr)
            AddedByTxtBox.Text = .Item(supConstants.addedByName)
        End With

        If File.Exists(CompanyPathTxtBox.Text) Then
            SupplierCirclePictureBox.Image = Image.FromFile(CompanyPathTxtBox.Text)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SeeSuppliedItemsBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliedItemsBtn.Click
        Dim resultID As Integer = formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New InventoryForm
            modal.invDT = dbHelper.GetRowByValue(invConst.invTableStr, invConst.supIDStr, selectedID)
            modal.viewMode = True
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function
        )
    End Sub
End Class