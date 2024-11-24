Imports System.IO
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class SupplierViewModal
    Dim dbHelper As New DbHelper

    Public Property selectedID As Integer = -1
    Private Sub AdminSupplierViewModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitValues()
    End Sub

    Private Sub InitValues()

        If selectedID = -1 Then
            MsgBox("Cannot view with empty values")
            Me.Close()
        End If

        Dim suppDT As DataTable = dbHelper.GetRowByValue("suppliers", "supplier_id", selectedID)

        If suppDT.Rows.Count = 0 Then Exit Sub

        With suppDT.Rows(0)
            CompanyNameTxtBox.Text = .Item("company_name")
            ContactPersonTxtBox.Text = .Item("contact_person")
            CompanyEmailTxtBox.Text = .Item("company_email")
            ContactNumberTxtBox.Text = .Item("contact_number")
            LocationTxtBox.Text = .Item("location")
            EstDelivTimeTxtBox.Text = dbHelper.StrNullCheck(.Item("estimated_delivery_time"))
            CompanyDescTxtBox.Text = .Item("company_description")
            SupplierTypeTxtBox.Text = .Item("supplier_type")
            ContractTypeTxtBox.Text = .Item("supplier_contract")
            BankDetailsTxtBox.Text = .Item("bank_details")
            PaymentTermsTxtBox.Text = .Item("payment_terms")
            SupplierIdTextBox.Text = .Item("supplier_id")
            ' NoSuppliedItemTxtBox.Text = .Item("")
            TotalPaidTxtBox.Text = .Item("total_paid")
            DateAddedTxtBox.Text = .Item("date_added")
            CompanyPathTxtBox.Text = .Item("company_picture_path")
        End With

        Dim empDT As DataTable = dbHelper.GetRowByValue("employees", "employee_id", AddedByTxtBox.Text)

        If empDT.Rows.Count = 0 Then Exit Sub

        With empDT.Rows(0)
            AddedByTxtBox.Text = .Item("firstname") & " " & .Item("lastname")
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


End Class