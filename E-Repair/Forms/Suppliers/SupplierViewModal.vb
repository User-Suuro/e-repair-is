Imports System.IO

Public Class SupplierViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim supConstants As New SuppliersDBConstants
    Dim invConst As New InventoryDBConstants

    Private supplierID As Integer

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

            SupplierTypeTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.supTypeStr))
            ContractTypeTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.supContractStr))
            BankDetailsTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.bankDetailsStr))
            PaymentTermsTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.payTermsStr))

            supplierID = .Item(supConstants.supIDStr)
            SupplierIdTextBox.Text = supplierID

            NoSuppliedItemTxtBox.Text = formUtils.GetSuppliedItems(selectedID)
            TotalPaidTxtBox.Text = formUtils.GetTotalPaid(selectedID)

            DateAddedTxtBox.Text = .Item(supConstants.dateAddedStr)
            CompanyPathTxtBox.Text = dbHelper.StrNullCheck(.Item(supConstants.compPicPathStr))
            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item(supConstants.addedByID))
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
            modal.supplierMode = True
            modal.selectedID = id
            modal.BtnSelect.Visible = False
            modal.BtnClose.Visible = True
            Return modal
        End Function,
        supplierID,
        Function(modal)
            Return Nothing
        End Function
        )
    End Sub



End Class