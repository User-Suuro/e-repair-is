
Public Class CustomerAddEditModal
    ' TOOLS
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper

    Dim constants As New Constants
    Dim custConst As New CustomersDBConstants

    ' SCHEMA
    Dim firstName As String
    Dim middleName As String
    Dim lastName As String
    Dim gender As String
    Dim email As String
    Dim contactNumber As String
    Dim address As String

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1

    ' ONLOAD
    Private Sub CustomerAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitCmbDs(-1)
        If editMode Then InitValues()
    End Sub

    ' INIT VALUES
    Private Sub InitValues()
        If Not formUtils.checkIfLoad(selectedID) Then
            Me.Close()
            Exit Sub
        End If

        Dim custDt As DataTable = dbHelper.GetRowByValue(custConst.custTableStr, custConst.custIDStr, selectedID)

        If custDt.Rows.Count = 0 Then Exit Sub

        CustomerModalGroupBox.Text = "Edit Customer"

        With custDt.Rows(0)
            FirstNameTxtBox.Text = .Item(custConst.custFirstStr)
            MiddleNameTxtBox.Text = .Item(custConst.custMidStr)
            LastNameTxtBox.Text = .Item(custConst.custLastStr)
            EmailTxtBox.Text = .Item(custConst.custEmailStr)
            ContactTxtBox.Text = .Item(custConst.custEmailStr)
            AddressTxtBox.Text = .Item(custConst.custAddressStr)

            Dim genderIndex = formUtils.FindComboBoxItemByText(GenderComboBox, .Item(custConst.custGenderStr))

            InitCmbDs(genderIndex)
        End With
    End Sub

    ' INIT CMBDS
    Public Sub InitCmbDs(index01 As Integer)
        dbHelper.LoadEnumsToCmb(GenderComboBox, custConst.custTableStr, custConst.custGenderStr, index01)
    End Sub

    ' SAVE BTN
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        formUtils.SaveEvent(editMode, AddressOf AddCustomerFunction, AddressOf EditCustomerFunction)
    End Sub

    ' ADD 
    Private Sub AddCustomerFunction()
        With custConst
            Dim insertData As New Dictionary(Of String, Object) From {
                { .custMidStr, middleName}, ' optional
                { .custContactStr, contactNumber}, ' optional
                { .custAddressStr, address}, ' optional
                { .custEmailStr, email}, ' optional
                { .custFirstStr, firstName},
                { .custLastStr, lastName},
                { .custGenderStr, gender},
                { .custDateAddedStr, DateTime.Now()},
                { .getAddedByName, formUtils.getEmployeeName(Current.id)},
                { .getAddedByID, Current.id}
            }


            If formUtils.AddRow(.custTableStr, insertData, 4) Then
                Me.Close()
            End If
        End With
    End Sub

    ' EDIT
    Private Sub EditCustomerFunction()
        With custConst
            Dim insertUpdate As New Dictionary(Of String, Object) From {
                { .custMidStr, middleName}, ' optional
                { .custContactStr, contactNumber}, ' optional
                { .custAddressStr, address}, ' optional
                { .custEmailStr, email}, ' optional
                { .custFirstStr, firstName},
                { .custLastStr, lastName},
                { .custGenderStr, gender}
            }

            If formUtils.EditRow(.custTableStr, .custIDStr, selectedID, insertUpdate, 4) Then
                Me.Close()
            End If
        End With
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' FIRST NAME
    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTxtBox.TextChanged
        firstName = FirstNameTxtBox.Text
    End Sub

    ' MIDDLE NAME
    Private Sub MiddleNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MiddleNameTxtBox.TextChanged
        middleName = MiddleNameTxtBox.Text
    End Sub

    ' LAST NAME
    Private Sub LastNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTxtBox.TextChanged
        lastName = LastNameTxtBox.Text
    End Sub

    ' GENDER COMBO BOX
    Private Sub GenderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderComboBox.SelectedIndexChanged

        'With GenderTableLayout
        '    ' Default
        '    .ColumnStyles(0).Width = 100.0F
        '    .ColumnStyles(1).Width = 0.0F
        '    If GenderComboBox.SelectedItem = "Others" Then
        '        .ColumnStyles(0).Width = 50.0F
        '        .ColumnStyles(1).Width = 50.0F
        '    Else
        '        gender = GenderComboBox.SelectedItem
        '        .ColumnStyles(0).Width = 100.0F
        '        .ColumnStyles(1).Width = 0.0F
        '    End If
        'End With

        gender = GenderComboBox.SelectedItem
    End Sub

    ' GENDER OTHERS
    Private Sub GenderOthersTxtBox_TextChanged(sender As Object, e As EventArgs) Handles GenderOthersTxtBox.TextChanged
        'If GenderComboBox.SelectedItem = "Others" Then
        '    gender = GenderOthersTxtBox.Text
        'End If
    End Sub

    ' EMAIL
    Private Sub EmailTxtBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTxtBox.TextChanged
        email = EmailTxtBox.Text
    End Sub

    ' CONTACT TXT
    Private Sub ContactTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ContactTxtBox.TextChanged
        contactNumber = ContactTxtBox.Text
    End Sub

    ' ADDRESS TXT
    Private Sub AddressTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTxtBox.TextChanged
        address = AddressTxtBox.Text
    End Sub

    Private Sub CustomerModalGroupBox_Click(sender As Object, e As EventArgs) Handles CustomerModalGroupBox.Click

    End Sub
End Class

