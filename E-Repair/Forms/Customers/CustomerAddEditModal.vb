
Public Class CustomerAddEditModal
    ' TOOLS
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    ' SCHEMA
    Dim firstName As String = ""
    Dim middleName As String = ""
    Dim lastName As String = ""
    Dim gender As String = ""
    Dim email As String = ""
    Dim contactNumber As String = ""
    Dim address As String = ""

    Public Property editMode As Boolean = False
    Public Property selectedCustomerID As Integer = -1

    ' ONLOAD
    Private Sub CustomerAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not editMode Then InitCmbDs(-1)



    End Sub
    ' SAVE BTN
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Cursor = Cursors.WaitCursor
            If editMode Then
                EditCustomerFunction()
            Else
                AddCustomerFunction()
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Failed to save / edit customer: " & ex.Message)
        End Try
    End Sub

    ' ADD 
    Private Sub AddCustomerFunction()

        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this customer?")) Then Exit Sub

        Dim empIDLogged As Integer

        Try
            empIDLogged = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            empIDLogged = -1
        End Try

        Dim insertData As New Dictionary(Of String, Object) From {
            {"middle_name", middleName}, ' optional
            {"contact_number", contactNumber}, ' optional
            {"address", address}, ' optional
            {"email", email}, ' optional
            {"added_by", empIDLogged}, ' optional
            {"first_name", firstName},
            {"last_name", lastName},
            {"gender", gender},
            {"date_added", DateTime.Now()}
        }

        If Not formUtils.AreAllValuesFilled(insertData, 5) Then Exit Sub

        dbHelper.InsertRecord("customers", insertData)

        MsgBox("Customer Successfully Added")

        Me.Close()

    End Sub

    ' EDIT
    Private Sub EditCustomerFunction()
        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this customer?")) Then Exit Sub

        Dim insertUpdate As New Dictionary(Of String, Object) From {
            {"middle_name", middleName}, ' optional
            {"contact_number", contactNumber}, ' optional
            {"address", address}, ' optional
            {"email", email}, ' optional
            {"first_name", firstName},
            {"last_name", lastName},
            {"gender", gender}
        }

        If Not formUtils.AreAllValuesFilled(insertUpdate, 4) Then Exit Sub

        If dbHelper.UpdateRecord("customers", "customer_id", selectedCustomerID, insertUpdate) Then

            MsgBox("Customer Successfully Updated")
        Else
            MsgBox("Db Problem")
        End If

        Me.Close()

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

    ' INIT CMBDS
    Public Sub InitCmbDs(index01 As Integer)
        dbHelper.LoadEnumsToCmb(GenderComboBox, "customers", "gender", index01)
    End Sub


End Class

