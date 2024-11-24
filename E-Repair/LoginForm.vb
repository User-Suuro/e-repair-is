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

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If (LoginEmailTextBox.Text.Trim = "" Or LoginPasswordTextBox.Text.Trim = "") Then
            MsgBox("Please Fill All Necessary Details", MessageBoxButtons.OK)
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

        If Not (empDataRows(empConst.empEmailStr) = LoginEmailTextBox.Text AndAlso dbHelper.DecryptPassword(empDataRows(empConst.empPassStr), constant.EncryptionKey) = LoginPasswordTextBox.Text) Then
            MsgBox("Incorrect Email or Passsowrd")
            Exit Sub
        End If

        LoggedUser.InitializeSession(empDT)

        ' UPDATE ACCESS DATE

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {empConst.empLastAccessedStr, DateTime.Now}
        }

        dbHelper.UpdateRecord(empConst.empTableStr, empConst.empIDStr, LoggedUser.Current.id, updatedValues)

        Dim MainPanel As New MainPanel

        MainPanel.Show()

        Me.Hide()

        releaseMemory()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' CONNECT TO DB -> dbconfig.txt
        dbHelper.UpdateConnectionString()

        ' CHECK IF CONNECTED TO DB
        If Not dbHelper.isConnectedToLocalServer() Then
            formUtils.ShowMessageBoxResult("ERROR", "DB NOT FOUND!")
            Me.Close()
        End If

        InitializeVLC()

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

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub Guna2Separator2_Click(sender As Object, e As EventArgs) Handles Guna2Separator2.Click

    End Sub
End Class