Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module modDB
    Public conn, myadocon As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader

    Private constants As New Constants
    Dim empCust As New EmployeesDBConstants
    Dim formUtils As New FormUtils

    ' -- Adjust your DB Details Here (get stuffs from dbconfig) -- '

    Private Property db_server As String = Nothing
    Private Property db_uid As String = Nothing
    Private Property db_pwd As String = Nothing
    Private Property db_name As String = Nothing

    Private Property strConnection As String = String.Format("server={0};uid={1};password={2};database={3};allowuservariables='True'", db_server, db_uid, db_pwd, db_name)

    Public Class LoggedUser
        Public Property id As Integer
        Public Property name As String
        Public Property position As String
        Public Property email As String
        Public Property password As String
        Public Property profilePath As String
    End Class

    Public Current As LoggedUser = Nothing

    Public Sub InitializeSession(dt As DataTable)

        If dt.Rows.Count = 0 Then
            MsgBox("Cannot Initialize Session With Empty Value")
            Exit Sub
        End If

        Dim empDtRow As DataRow = dt.Rows(0)

        Dim empID As Integer = Nothing

        If Not Integer.TryParse(empDtRow(empCust.empIDStr), empID) Then
            MsgBox("Invalid ID")
            Exit Sub
        End If

        Current = New LoggedUser With {
            .id = empID,
            .name = formUtils.getEmployeeName(empID),
            .position = empDtRow(empCust.empJobPosStr),
            .email = empDtRow(empCust.empEmailStr),
            .password = empDtRow(empCust.empPassStr),
            .profilePath = empDtRow(empCust.empProfileStr)
        }

    End Sub

    Public Sub ClearSession()
        Current = Nothing
    End Sub

    Public Function IsSessionActive() As Boolean
        Return Current IsNot Nothing
    End Function

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

    Public Function getDbName() As String
        Return db_name
    End Function

    Public Function getStrCon() As String
        Return strConnection
    End Function

End Module

