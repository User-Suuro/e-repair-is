Imports MySql.Data.MySqlClient

Module DbProperties
    Public conn, myadocon As New MySqlConnection

    ' -- Adjust your DB Details Here -- '
    Private Property db_server As String = ""
    Private Property db_uid As String = ""
    Private Property db_pwd As String = ""
    Private Property db_name As String = ""

    Public Property strConnection As String = String.Format("server={0};uid={1};password={2};database={3};allowuservariables='True'", db_server, db_uid, db_pwd, db_name)


    ' Update connection string
    Public Sub UpdateConnectionString()
        Try
            Dim currentDir As String = System.IO.Directory.GetCurrentDirectory()

            For i As Integer = 1 To 3
                currentDir = System.IO.Directory.GetParent(currentDir).FullName
            Next

            Dim config As String = currentDir & "\dbconfig.txt"

            Dim text As String = Nothing
            If System.IO.File.Exists(config) Then
                Using reader As System.IO.StreamReader = New System.IO.StreamReader(config)
                    text = reader.ReadToEnd
                End Using

                Dim arr_text() As String = Split(text, vbCrLf)

                db_server = Split(arr_text(0), "=")(1)
                db_uid = Split(arr_text(1), "=")(1)
                db_pwd = Split(arr_text(2), "=")(1)
                db_name = Split(arr_text(3), "=")(1)

                strConnection = String.Format("server={0};uid={1};password={2};database={3};allowuservariables='True'", db_server, db_uid, db_pwd, db_name)
            Else
                MsgBox("Do not exist")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Open connection to db
    Public Sub openConn(ByVal db_name As String)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Function to check if user is connected to local db
    Public Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Try
            myadocon = New MySqlConnection
            myadocon.ConnectionString = strConnection

            Try
                myadocon.Open()
                If myadocon.State = ConnectionState.Open Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As Exception
                Return False
            End Try
            If myadocon.State = ConnectionState.Open Then
                myadocon.Close()
            End If
        Catch
            Return False
        End Try
        Return result
    End Function

    Public Function getCurrentDbName() As String
        Return db_name
    End Function
End Module

