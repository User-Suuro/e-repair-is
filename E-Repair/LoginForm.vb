Imports LibVLCSharp.WinForms
Imports LibVLCSharp.Shared
Imports System.Threading
Imports System.IO

Public Class LoginForm
    Dim dbHelper As New DbHelper
    Dim constant As New Constants
    Dim formUtils As New FormUtils
    Dim empConst As New EmployeesDBConstants

    Private libVLC As LibVLC
    Private mediaPlayer As MediaPlayer
    Private videoView As VideoView
    Private currentMedia As Media

    Private isConnected As Boolean

    Private Sub SetupDBBtn_Click(sender As Object, e As EventArgs) Handles SetupDBBtn.Click
        formUtils.ShowModalWithHandler(
       Function(id)
           Dim modal As New DBConfigModal
           Return modal
       End Function,
       -1,
       Function(modal)
           Return Nothing
       End Function
         )
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Cursor = Cursors.WaitCursor
        UpdateConnectionString()
        Cursor = Cursors.Default

        isConnected = isConnectedToLocalServer()

        If Not isConnected Then
            MsgBox("Not Connected")
            Exit Sub
        End If

        If (LoginEmailTextBox.Text.Trim = "" Or LoginPasswordTextBox.Text.Trim = "") Then
            MsgBox("Please Fill All Necessary Details")
            Exit Sub
        End If

        ' FIND THE EMAIL IN DB
        Dim empDT As DataTable = dbHelper.GetRowByValue(empConst.empTableStr, empConst.empEmailStr, LoginEmailTextBox.Text)

        ' IF NOT EXIST THEN WARN
        If (empDT.Rows.Count <= 0) Then
            MsgBox("Email Not Found")
            Exit Sub
        End If

        Dim empDataRows As DataRow = empDT.Rows(0)

        If empDataRows(empConst.empArchStr) Then
            MsgBox("This account is already archived")
            Exit Sub
        End If

        If Not (empDataRows(empConst.empEmailStr) = LoginEmailTextBox.Text AndAlso DecryptPassword(empDataRows(empConst.empPassStr), constant.EncryptionKey) = LoginPasswordTextBox.Text) Then
            MsgBox("Incorrect Email or Passsowrd")
            Exit Sub
        End If

        LoggedUser.InitializeSession(empDT)

        ' UPDATE ACCESS DATE

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {empConst.empLastAccessedStr, DateTime.Now}
        }

        dbHelper.UpdateRecord(empConst.empTableStr, empConst.empIDStr, Current.id, updatedValues)

        releaseMemory()

        Dim MainPanel As New MainPanel

        MainPanel.Show()

        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeVLC()
        UpdateConnectionString()
        isConnected = isConnectedToLocalServer()
        initSuperPanel()
    End Sub

    Private Sub initSuperPanel()

        If isConnected Then
            If dbHelper.GetRowByColValue(New List(Of String) From {empConst.empArchStr}, empConst.empTableStr, empConst.empArchStr, 0).Rows.Count = 0 Then
                CreateSuperAdminPanel.Visible = True
            End If
        End If

    End Sub

    Private Sub InitializeVLC()
        ' Initialize LibVLC
        Core.Initialize()

        libVLC = New LibVLC("--input-repeat=65545")
        mediaPlayer = New MediaPlayer(libVLC)

        Dim videoView As New VideoView With {
            .Dock = DockStyle.Fill,
            .MediaPlayer = mediaPlayer
        }

        VideoPanel.Controls.Add(videoView)

        Dim rootProjectPath As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName
        Dim videoPath As String = Path.Combine(rootProjectPath, "Videos", "sample.mp4")

        If IO.File.Exists(videoPath) Then
            ' Load and play the video
            currentMedia = New Media(libVLC, videoPath, FromType.FromPath)

            mediaPlayer.Play(currentMedia)

            AddHandler mediaPlayer.EndReached, AddressOf OnEndReached
        Else
            MessageBox.Show("Video file not found!")
        End If
    End Sub

    Private Sub OnEndReached(sender As Object, e As EventArgs)
        MsgBox("You have been inactive for a long time, closing form...")
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        releaseMemory()
        Environment.Exit(0)
    End Sub

    Private Sub releaseMemory()
        mediaPlayer?.Stop()
        mediaPlayer?.Dispose()
        libVLC?.Dispose()
    End Sub

    Private Sub CreateSuperbtn_Click(sender As Object, e As EventArgs) Handles CreateSuperbtn.Click
        ' CHECK IF CONNECTED TO DB
        If Not isConnected Then
            formUtils.ShowMessageBoxResult("ERROR", "DB NOT FOUND!")
            Exit Sub
        End If


        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New EmployeeAddEditModal
             modal.createSuperAdminAccMode = True
             modal.JobTypeComboBox.Enabled = False
             Return modal
         End Function,
         -1,
         Function(modal)
             Return Nothing
         End Function
       )

        initSuperPanel()
    End Sub

End Class