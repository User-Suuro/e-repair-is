Imports System.IO
Imports Mysqlx.XDevAPI

Public Class LoginForm
    Dim dbHelper As New DbHelper
    Dim constant As New Constants
    Dim formUtils As New FormUtils
    Dim session As New Session

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (LoginEmailTextBox.Text = "" Or LoginPasswordTextBox.Text = "") Then
            MsgBox("Please Fill All Necessary Details", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' FIND THE EMAIL IN DB
        Dim getEmployeeData As DataTable = dbHelper.GetRowByValue("employees", "email", LoginEmailTextBox.Text)

        ' IF NOT EXIST THEN WARN
        If (getEmployeeData.Rows.Count <= 0) Then
            MsgBox("Email Not Found")
            Exit Sub
        End If

        Dim empDataRows As DataRow = getEmployeeData.Rows(0)

        If empDataRows("archived") Then
            MsgBox("This account is already archived")
            Exit Sub
        End If


        If (empDataRows("email") = LoginEmailTextBox.Text AndAlso dbHelper.DecryptPassword(empDataRows("password"), constant.EncryptionKey) = LoginPasswordTextBox.Text) Then
            ' CREATE SESSION 
            GlobalSession.InitializeSession(empDataRows)

            ' UPDATE ACCESS DATE

            Dim updatedValues As New Dictionary(Of String, Object) From {
                                {"last_accessed", DateTime.Now}
                            }

            Dim result As Boolean = dbHelper.UpdateRecord("employees", "employee_id", GlobalSession.CurrentSession.EmployeeID, updatedValues)

            ' GO TO UI BASE SA JOB TYPE

            If (empDataRows("job_type") = constant.getAdminString) Then

                Dim AdminForm As New AdminMainPanel

                AdminForm.Show()

                Me.Hide()
            ElseIf (empDataRows("job_type") = constant.getCashierString) Then
                MsgBox("Cashier Page coming soon")

            ElseIf (empDataRows("job_type") = constant.getTechnicianString) Then
                MsgBox("Technician Page coming soon")

            ElseIf (empDataRows("job_type") = constant.getUtilityPersonnelString) Then
                MsgBox("Utlity Personnel Page coming soon")

            End If

        Else
            MsgBox("Incorrect Email or Passsowrd")
            Exit Sub
        End If



    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.FormClosed
        ' CHECK IF CONNECTED TO DB
        If dbHelper.isConnectedToLocalServer() = False Then
            If formUtils.ShowMessageBoxResult("ERROR", "DB NOT FOUND!") Then
                Me.Close()
            End If
        End If

        GlobalSession.ClearSession()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Environment.Exit(0)
    End Sub


End Class