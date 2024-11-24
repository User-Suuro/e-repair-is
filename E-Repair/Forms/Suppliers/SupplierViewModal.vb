Imports System.IO

Public Class SupplierViewModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim supConstants As New SuppliersDBConstants

    Public Property selectedID As Integer = -1
    Private Sub AdminSupplierViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitValues()
    End Sub

    Private Sub InitValues()

        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

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
            ' NoSuppliedItemTxtBox.Text = .Item("")
            TotalPaidTxtBox.Text = .Item(supConstants.totalPaidStr)
            DateAddedTxtBox.Text = .Item(supConstants.dateAddedStr)
            CompanyPathTxtBox.Text = .Item(supConstants.compPicPathStr)
            AddedByTxtBox.Text = formUtils.getEmployeeName(.Item(supConstants.addedByStr))
        End With

        If File.Exists(CompanyPathTxtBox.Text) Then
            SupplierCirclePictureBox.Image = Image.FromFile(CompanyPathTxtBox.Text)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SeeSuppliedItemsBtn_Click(sender As Object, e As EventArgs) Handles SeeSuppliedItemsBtn.Click
        If selectedID = -1 Then Exit Sub

    End Sub

    Private Sub SupplierModalGroupBox_Click(sender As Object, e As EventArgs) Handles SupplierModalGroupBox.Click

    End Sub
End Class