﻿Imports System.IO
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Guna.UI2.HtmlRenderer.Core

Public Class SupplierAddEditModal
    ' TOOLS
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    ' SCHEMA
    Private compName As String = ""
    Private compContactPerson As String = ""
    Private compEmail As String = ""
    Private compContactNumber As String = ""
    Private compLoc As String = ""
    Private estDelivTime As String = ""
    Private compDesc As String = ""

    Private supplierType As String = ""
    Private contractType As String = ""
    Private bankDetails As String = ""
    Private paymentTerms As String = ""
    Private compProfilePath As String = ""
    Public Property selectedID As Integer = -1
    Public Property editMode As Integer = -1

    ' ONLOAD
    Private Sub SupplierAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitData()
    End Sub

    Private Sub InitData()
        If selectedID = -1 Then Exit Sub

        SupplierModalGroupBox.Text = "Edit Supplier"

        Dim suppDT As DataTable = dbHelper.GetRowByValue("suppliers", "supplier_id", selectedID)

        If suppDT.Rows.Count = 0 Then Exit Sub

        With suppDT.Rows(0)
            CompanyNameTxtBox.Text = .Item("company_name")
            ContactPersonTxtBox.Text = .Item("contact_person")
            CompanyEmailTxtBox.Text = .Item("company_email")
            ContactNumberTxtBox.Text = .Item("contact_number")
            LocationTxtBox.Text = .Item("location")
            EstDelivTimeTxtBox.Text = .Item("estimated_delivery_time")
            CompanyDescTxtBox.Text = .Item("company_description")
            compProfilePath = .Item("company_profile_path")

            InitCmbDs(-1, -1, -1, -1)

            Dim supplierIndex = formUtils.FindComboBoxItemByText(SupplierTypeCmbBox, .Item("supplier_type"))
            Dim contractIndex = formUtils.FindComboBoxItemByText(ContractTypeCmbBox, .Item("supplier_contract"))
            Dim BankIndex = formUtils.FindComboBoxItemByText(BnkDetailsCmbBox, .Item("bank_details"))
            Dim paymentIndex = formUtils.FindComboBoxItemByText(PaymentTermsCmbBox, .Item("payment_terms"))

            InitCmbDs(supplierIndex, contractIndex, BankIndex, paymentIndex)
        End With

        If File.Exists(compProfilePath) Then
            SupplierCirclePictureBox.Image = Image.FromFile(compProfilePath)
        End If
    End Sub

    Public Sub InitCmbDs(index01 As Integer, index02 As Integer, index03 As Integer, index04 As Integer)
        With dbHelper
            .LoadEnumsToCmb(SupplierTypeCmbBox, "suppliers", "supplier_type", index01)
            .LoadEnumsToCmb(ContractTypeCmbBox, "suppliers", "supplier_contract", index02)
            .LoadEnumsToCmb(BnkDetailsCmbBox, "suppliers", "bank_details", index03)
            .LoadEnumsToCmb(PaymentTermsCmbBox, "suppliers", "payment_terms", index04)
        End With
    End Sub

    ' SAVE BTN
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try
            Cursor = Cursors.WaitCursor
            If editMode Then
                EditModeFunction()
            Else
                AddSupplierFunction()
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Failed to save / edit supplier: " & ex.Message)
        End Try
    End Sub

    ' ADD 

    Private Sub AddSupplierFunction()

        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this supplier?")) Then Exit Sub

        ' Save Image Locally
        Dim savedPath = formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, False)

        Dim insertData As New Dictionary(Of String, Object) From {
            {"estimated_delivery_time", estDelivTime}, ' optional
            {"company_name", compName},
            {"company_description", compDesc},
            {"contact_person", compContactPerson},
            {"contact_number", compContactNumber},
            {"company_email", compEmail},
            {"location", compLoc},
            {"supplier_type", supplierType},
            {"supplier_contract", contractType},
            {"bank_details", bankDetails},
            {"payment_terms", paymentTerms},
            {"company_picture_path", savedPath},
            {"added_by", GlobalSession.CurrentSession.EmployeeID}
        }

        If Not formUtils.AreAllValuesFilled(insertData, 1) Then Exit Sub

        If dbHelper.InsertRecord("suppliers", insertData) Then
            formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, True)
            MsgBox("Supplier Successfully Added")
        Else
            MsgBox("Db Failure!")
        End If

        Me.Close()

    End Sub

    ' EDIT
    Private Sub EditModeFunction()
        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this supplier?")) Then Exit Sub

        Dim savedPath = formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, False)

        Dim insertUpdate As New Dictionary(Of String, Object) From {
            {"estimated_delivery_time", estDelivTime}, ' optional
            {"company_name", compName},
            {"company_description", compDesc},
            {"contact_person", compContactPerson},
            {"contact_number", compContactNumber},
            {"company_email", compEmail},
            {"location", compLoc},
            {"supplier_type", supplierType},
            {"supplier_contract", contractType},
            {"bank_details", bankDetails},
            {"payment_terms", paymentTerms}
        }

        If Not formUtils.AreAllValuesFilled(insertUpdate, 1) Then Exit Sub

        ' COMPARE PREV VALUE
        Dim getSupplierPrevValue As DataRow = dbHelper.GetRowByValue("suppliers", "supplier_id", selectedID).Rows(0)

        If savedPath <> getSupplierPrevValue("company_picture_path") Then insertUpdate.Add("company_picture_path", formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, True))

        If dbHelper.UpdateRecord("suppliers", "supplier_id", selectedID, insertUpdate) Then
            MsgBox("Supplier Successfully Updated")
        Else
            MsgBox("Db Failure!")
        End If

        Me.Close()

    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' COMPANY NAME
    Private Sub CompanyNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTxtBox.TextChanged
        compName = CompanyNameTxtBox.Text
    End Sub

    ' CONTACT PERSON
    Private Sub ContactPersonTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ContactPersonTxtBox.TextChanged
        compContactPerson = ContactPersonTxtBox.Text
    End Sub

    ' COMPANY EMAIL
    Private Sub CompanyEmailTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyEmailTxtBox.TextChanged
        compEmail = CompanyEmailTxtBox.Text
    End Sub

    ' CONTACT NUMBER
    Private Sub ContactNumberTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNumberTxtBox.TextChanged
        compContactNumber = ContactNumberTxtBox.Text
    End Sub

    ' LOCATION
    Private Sub LocationTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LocationTxtBox.TextChanged
        compLoc = LocationTxtBox.Text
    End Sub

    ' ESTIMATED DELIVERY TIME
    Private Sub EstDelivTimeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles EstDelivTimeTxtBox.TextChanged
        estDelivTime = EstDelivTimeTxtBox.Text
    End Sub

    ' COMPANY DESCRIPTION
    Private Sub CompanyDescTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyDescTxtBox.TextChanged
        compDesc = CompanyDescTxtBox.Text
    End Sub

    ' SUPPLIER TYPE
    Private Sub SupplierTypeIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierTypeIfOthersTxtBox.TextChanged
        'If SupplierTypeCmbBox.SelectedItem = "Others" Then supplierType = SupplierTypeIfOthersTxtBox.Text
    End Sub
    Private Sub SupplierTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierTypeCmbBox.SelectedIndexChanged
        'If SupplierTypeCmbBox.SelectedItem = "Others" Then
        '    With SupplierTypeTableLayout
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    End With
        'Else
        '    supplierType = SupplierTypeCmbBox.SelectedItem
        '    With SupplierTypeTableLayout
        '        .ColumnStyles(0).Width = 100.0F
        '        .ColumnStyles(1).Width = 0.0F
        '    End With
        'End If

        supplierType = SupplierTypeCmbBox.SelectedItem
    End Sub

    ' CONTRACT TYPE
    Private Sub ContractTypeIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ContractTypeIfOthersTxtBox.TextChanged
        ' If ContractTypeCmbBox.SelectedItem = "Others" Then contractType = ContractTypeIfOthersTxtBox.Text

    End Sub
    Private Sub ContractTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContractTypeCmbBox.SelectedIndexChanged
        If ContractTypeCmbBox.SelectedItem = "Others" Then
            With ContractTypeTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            contractType = ContractTypeCmbBox.SelectedItem
            With ContractTypeTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    ' BANK DETAILS
    Private Sub BankDetailsIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles BankDetailsIfOthersTxtBox.TextChanged
        ' If BnkDetailsCmbBox.SelectedItem = "Others" Then bankDetails = BankDetailsIfOthersTxtBox.Text
    End Sub

    Private Sub BnkDetailsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BnkDetailsCmbBox.SelectedIndexChanged
        'If BnkDetailsCmbBox.SelectedItem = "Others" Then
        '    With BankDetailsTableLayout
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    End With
        'Else

        '    With BankDetailsTableLayout
        '        .ColumnStyles(0).Width = 100.0F
        '        .ColumnStyles(1).Width = 0.0F
        '    End With
        'End If

        bankDetails = BnkDetailsCmbBox.SelectedItem
    End Sub

    ' PAYMENT TERMS
    Private Sub PaymentTermsIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentTermsIfOthersTxtBox.TextChanged
        ' If PaymentTermsCmbBox.SelectedItem = "Others" Then paymentTerms = PaymentTermsIfOthersTxtBox.Text
    End Sub
    Private Sub PaymentTermsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentTermsCmbBox.SelectedIndexChanged
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

        paymentTerms = PaymentTermsCmbBox.SelectedItem
    End Sub

    ' BTN UPLOAD
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        If SupplierFileDialog.ShowDialog = DialogResult.OK Then
            Dim imgPath = SupplierFileDialog.FileName
            SupplierCirclePictureBox.Image = Image.FromFile(imgPath)
            compProfilePath = imgPath
        End If
    End Sub
End Class