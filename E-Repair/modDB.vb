Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module modDB
    Public conn, myadocon As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader

    Private constants As New Constants

    ' -- Adjust your DB Details Here (get stuffs from dbconfig) -- '
    Private Property db_server As String = Nothing
    Private Property db_uid As String = Nothing
    Private Property db_pwd As String = Nothing
    Private Property db_name As String = Nothing

    Private Property strConnection As String = String.Format("server={0};uid={1};password={2};database={3};allowuservariables='True'", db_server, db_uid, db_pwd, db_name)


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

    ' Open connection to db

    Public Sub openConn(ByVal db_name As String)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
        Catch ex As Exception
            MsgBox("Error opening connection: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Read query to db

    Public Sub readQuery(ByVal sql As String, Optional ByVal isSelectQuery As Boolean = True)
        Try

            openConn(db_name)

            With cmd
                .Connection = conn
                .CommandText = sql
                If isSelectQuery Then
                    cmdRead = .ExecuteReader()  ' SELECT
                Else
                    .ExecuteNonQuery() ' UPDATE, INSERT, DELETE
                End If
            End With

        Catch ex As Exception
            MsgBox("Unable to read query: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cmd.Parameters.Clear()
        End Try
    End Sub

    ' Function to Load Data to DGV

    Function LoadToDGV(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return 0
    End Function

    ' Function to Load and Display data to dgv

    Function LoadToDGVForDisplay(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            If dgv.ColumnCount > 1 Then
                dgv.Columns(0).Visible = False
            End If
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return 0
    End Function

    ' Function to EncryptPassword

    Public Function EncryptPassword(clearText As String, key As String) As String
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(constants.EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    ' Function to DecryptPassword

    Public Function DecryptPassword(cipherText As String, key As String) As String
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(constants.EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

End Module

