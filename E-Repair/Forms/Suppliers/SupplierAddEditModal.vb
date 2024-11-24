Imports System.IO

Public Class SupplierAddEditModal
    ' TOOLS
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    Dim supConst As New SuppliersDBConstants 

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
    Private compImgPath As String = ""

    Public Property selectedID As Integer = -1
    Public Property editMode As Integer = -1

    ' ONLOAD
    Private Sub SupplierAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitData()
    End Sub

    Private Sub InitData()
        If selectedID = -1 Then Exit Sub

        SupplierModalGroupBox.Text = "Edit Supplier"

        Dim suppDT As DataTable = dbHelper.GetRowByValue(supConst.supTableStr, supConst.supIDStr, selectedID)

        If suppDT.Rows.Count = 0 Then Exit Sub

        With suppDT.Rows(0)
            CompanyNameTxtBox.Text = .Item(supConst.compNameStr)
            ContactPersonTxtBox.Text = .Item(supConst.contactPersonStr)
            CompanyEmailTxtBox.Text = .Item(supConst.compEmailStr)
            ContactNumberTxtBox.Text = .Item(supConst.contactNumStr)
            LocationTxtBox.Text = .Item(supConst.locationStr)
            EstDelivTimeTxtBox.Text = .Item(supConst.estDeliveryStr)
            CompanyDescTxtBox.Text = .Item(supConst.compDescStr)
            compImgPath = .Item(supConst.compPicPathStr)

            InitCmbDs(-1, -1, -1, -1)

            Dim supplierIndex = formUtils.FindComboBoxItemByText(SupplierTypeCmbBox, .Item(supConst.supTypeStr))
            Dim contractIndex = formUtils.FindComboBoxItemByText(ContractTypeCmbBox, .Item(supConst.supContractStr))
            Dim BankIndex = formUtils.FindComboBoxItemByText(BnkDetailsCmbBox, .Item(supConst.bankDetailsStr))
            Dim paymentIndex = formUtils.FindComboBoxItemByText(PaymentTermsCmbBox, .Item(supConst.payTermsStr))

            InitCmbDs(supplierIndex, contractIndex, BankIndex, paymentIndex)
        End With

        If File.Exists(compImgPath) Then
            SupplierCirclePictureBox.Image = Image.FromFile(compImgPath)
        End If
    End Sub

    Public Sub InitCmbDs(index01 As Integer, index02 As Integer, index03 As Integer, index04 As Integer)
        With dbHelper
            .LoadEnumsToCmb(SupplierTypeCmbBox, supConst.supTableStr, supConst.supTypeStr, index01)
            .LoadEnumsToCmb(ContractTypeCmbBox, supConst.supTableStr, supConst.supContractStr, index02)
            .LoadEnumsToCmb(BnkDetailsCmbBox, supConst.supTableStr, supConst.bankDetailsStr, index03)
            .LoadEnumsToCmb(PaymentTermsCmbBox, supConst.supTableStr, supConst.payTermsStr, index04)
        End With
    End Sub

    ' SAVE BTN
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        formUtils.SaveEvent(editMode, AddressOf AddSupplierFunction, AddressOf EditModeFunction)
    End Sub

    ' ADD 
    Private Sub AddSupplierFunction()

        With supConst
            Dim insertData As New Dictionary(Of String, Object) From {
               { .estDeliveryStr, estDelivTime}, ' optional
               { .compNameStr, compName},
               { .compDescStr, compDesc},
               { .contactPersonStr, compContactPerson},
               { .contactNumStr, compContactNumber},
               { .compEmailStr, compEmail},
               { .locationStr, compLoc},
               { .supTypeStr, supplierType},
               { .supContractStr, contractType},
               { .bankDetailsStr, bankDetails},
               { .payTermsStr, paymentTerms},
               { .addedByStr, Current.id}
            }

            Dim imgData As New List(Of String) From {
                .compPicPathStr,
                compImgPath,
                constants.getSuppProfileFolderName
            }
            formUtils.AddRow(.supTableStr, insertData, 1, imgData)
        End With

        Me.Close()

    End Sub

    ' EDIT
    Private Sub EditModeFunction()

        With supConst
            Dim insertUpdate As New Dictionary(Of String, Object) From {
               { .estDeliveryStr, estDelivTime}, ' optional
               { .compNameStr, compName},
               { .compDescStr, compDesc},
               { .contactPersonStr, compContactPerson},
               { .contactNumStr, compContactNumber},
               { .compEmailStr, compEmail},
               { .locationStr, compLoc},
               { .supTypeStr, supplierType},
               { .supContractStr, contractType},
               { .bankDetailsStr, bankDetails},
               { .payTermsStr, paymentTerms}
            }

            Dim imgData As New List(Of String) From {
                .compPicPathStr,
                compImgPath,
                constants.getSuppProfileFolderName
            }


            formUtils.EditRow(.supTableStr, selectedID, .supIDStr, insertUpdate, 1, imgData)
        End With

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
        'If ContractTypeCmbBox.SelectedItem = "Others" Then
        '    With ContractTypeTableLayout
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    End With
        'Else

        '    With ContractTypeTableLayout
        '        .ColumnStyles(0).Width = 100.0F
        '        .ColumnStyles(1).Width = 0.0F
        '    End With
        'End If

        contractType = ContractTypeCmbBox.SelectedItem
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
            compImgPath = imgPath
        End If
    End Sub

    Private Sub SupplierModalGroupBox_Click(sender As Object, e As EventArgs) Handles SupplierModalGroupBox.Click

    End Sub
End Class