Imports System.IO
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Guna.UI2.HtmlRenderer.Core

Public Class AdminSupplierAddEditModal
    ' TOOLS
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    ' SCHEMA
    Dim compName As String = ""
    Dim compContactPerson As String = ""
    Dim compEmail As String = ""
    Dim compContactNumber As String = ""
    Dim compLoc As String = ""
    Dim estDelivTime As String = ""
    Dim compDesc As String = ""

    Dim supplierType As String = ""
    Dim contractType As String = ""
    Dim bankDetails As String = ""
    Dim paymentTerms As String = ""

    Public Property editMode As Boolean = False
    Public Property selectedSupplierID As Integer = -1
    Public Property compProfilePath As String

    ' SAVE BTN
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try
            If editMode Then
                EditModeFunction()
            Else
                AddSupplierFunction()
            End If
        Catch ex As Exception
            MsgBox("Failed to save / edit supplier: " & ex.Message)
        End Try

    End Sub

    ' ADD 

    Private Sub AddSupplierFunction()

        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this supplier?")) Then Exit Sub

        Dim empIDLogged As Integer

        Try
            empIDLogged = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            empIDLogged = -1
        End Try

        ' Save Image Locally
        Dim savedPath = formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, False)

        Dim insertData As New Dictionary(Of String, Object) From {
            {"added_by", empIDLogged}, ' optional
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
            {"estimated_delivery_time", estDelivTime},
            {"company_picture_path", savedPath},
            {"date_added", DateTime.Now}
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
            {"estimated_delivery_time", estDelivTime},
            {"company_picture_path", savedPath}
        }

        If Not formUtils.AreAllValuesFilled(insertUpdate) Then Exit Sub

        If dbHelper.UpdateRecord("suppliers", "supplier_id", selectedSupplierID, insertUpdate) Then
            MsgBox("Supplier Successfully Updated")
        Else
            MsgBox("Db Failure!")
        End If

        If Not File.Exists(savedPath) Then formUtils.saveImgToLocal(compProfilePath, constants.getSuppProfileFolderPath, True)

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
        If SupplierTypeCmbBox.SelectedItem = "Others" Then
            supplierType = SupplierTypeIfOthersTxtBox.Text
        End If
    End Sub
    Private Sub SupplierTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierTypeCmbBox.SelectedIndexChanged
        If SupplierTypeCmbBox.SelectedItem = "Others" Then
            With SupplierTypeTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            supplierType = SupplierTypeCmbBox.SelectedItem
            With SupplierTypeTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    ' CONTRACT TYPE
    Private Sub ContractTypeIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ContractTypeIfOthersTxtBox.TextChanged
        If ContractTypeCmbBox.SelectedItem = "Others" Then
            contractType = ContractTypeIfOthersTxtBox.Text
        End If
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
        If BnkDetailsCmbBox.SelectedItem = "Others" Then
            bankDetails = BankDetailsIfOthersTxtBox.Text
        End If
    End Sub

    Private Sub BnkDetailsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BnkDetailsCmbBox.SelectedIndexChanged
        If BnkDetailsCmbBox.SelectedItem = "Others" Then
            With BankDetailsTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            bankDetails = BnkDetailsCmbBox.SelectedItem
            With BankDetailsTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    ' PAYMENT TERMS
    Private Sub PaymentTermsIfOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentTermsIfOthersTxtBox.TextChanged
        If PaymentTermsCmbBox.SelectedItem = "Others" Then
            paymentTerms = PaymentTermsIfOthersTxtBox.Text
        End If
    End Sub
    Private Sub PaymentTermsCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentTermsCmbBox.SelectedIndexChanged
        If PaymentTermsCmbBox.SelectedItem = "Others" Then
            With PaymentTermsTableLayout
                .ColumnStyles(0).Width = 50.0F
                .ColumnStyles(1).Width = 50.0F
            End With
        Else
            paymentTerms = PaymentTermsCmbBox.SelectedItem
            With PaymentTermsTableLayout
                .ColumnStyles(0).Width = 100.0F
                .ColumnStyles(1).Width = 0.0F
            End With
        End If
    End Sub

    ' BTN UPLOAD
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        If SupplierFileDialog.ShowDialog = DialogResult.OK Then
            Dim imgPath = SupplierFileDialog.FileName
            SupplierCirclePictureBox.Image = Image.FromFile(imgPath)
            compProfilePath = imgPath
        End If
    End Sub

    ' CIRCLE BOX
    Private Sub SupplierCirclePictureBox_Paint(sender As Object, e As PaintEventArgs) Handles SupplierCirclePictureBox.Paint
        Try
            SupplierCirclePictureBox.Image = Image.FromFile(compProfilePath)
        Catch ex As Exception

        End Try
    End Sub


End Class