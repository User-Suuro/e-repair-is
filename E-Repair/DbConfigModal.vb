Imports Microsoft.SqlServer

Public Class DBConfigModal

    Dim dbHelper As New DbHelper

    Dim server As String = ""
    Dim uid As String = ""
    Dim password As String = ""
    Dim database As String = ""

    Dim config As String

    Private Sub DBConfigModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDbConfigData()
        updateStatusConn()
    End Sub

    Private Sub getDbConfigData()
        Cursor = Cursors.WaitCursor()

        ' get values from dbconfig.txt
        Dim currentDir As String = System.IO.Directory.GetCurrentDirectory()

        For i As Integer = 1 To 3
            currentDir = System.IO.Directory.GetParent(currentDir).FullName
        Next

        config = currentDir & "\dbconfig.txt"

        Dim text As String = Nothing

        If System.IO.File.Exists(config) Then
            Using reader As System.IO.StreamReader = New System.IO.StreamReader(config)
                text = reader.ReadToEnd
            End Using


            Dim lines() As String = text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

            For Each line As String In lines
                If line.StartsWith("server=") Then
                    server = line.Substring("server=".Length)
                ElseIf line.StartsWith("uid=") Then
                    uid = line.Substring("uid=".Length)
                ElseIf line.StartsWith("password=") Then
                    password = line.Substring("password=".Length)
                ElseIf line.StartsWith("database=") Then
                    database = line.Substring("database=".Length)
                End If
            Next

            ServerTxtBox.Text = server
            uidTxtBox.Text = uid
            dbPassTxtBox.Text = password
            dbNameTxtBox.Text = database

        End If

        dbHelper.UpdateConnectionString()
        Cursor = Cursors.Default()
    End Sub

    Private Sub updateStatusConn()
        If Not dbHelper.isConnectedToLocalServer() Then
            ConnStatusLabel.Text = "Not Connected"
            ConnStatusLabel.ForeColor = Color.Red
        Else
            ConnStatusLabel.Text = "Connected"
            ConnStatusLabel.ForeColor = Color.Green
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click


        getDbConfigData()
        updateStatusConn()
        Me.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub


End Class