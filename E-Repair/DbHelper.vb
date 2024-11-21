Imports System.IO
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DbHelper

    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader
    Dim constants As New Constants

    ' -- Adjust your DB Details Here -- '
    Public db_server As String = "localhost"
    Public db_uid As String = "root"
    Public db_pwd As String = ""
    Public db_name As String = "e_repair_db"

    Public strConnection As String = String.Format("server={0};uid={1};password={2};database={3};allowuservariables='True'", db_server, db_uid, db_pwd, db_name)

    Public CurrentLoggedUser As LoggedUser = Nothing

    Public Structure LoggedUser
        Dim id As Integer
        Dim name As String
        Dim position As String
        Dim username As String
        Dim password As String
        Dim type As Integer
    End Structure

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

        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            cmd.Parameters.Clear()
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

    Sub Logs(ByVal transaction As String, Optional ByVal events As String = "*_Click")
        Try
            readQuery(String.Format("INSERT INTO `logs`(`dt`, `user_accounts_id`, `event`, `transactions`) VALUES ({0},{1},'{2}','{3}')", "now()",
                                    CurrentLoggedUser.id,
                                    events,
                                    transaction))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Custom Functions 

    Public Function StrNullCheck(cellValue As Object) As String
        Return If(IsDBNull(cellValue), "N/A", cellValue.ToString())
    End Function

    Public Function IntNullCheck(cellValue As Object) As Integer
        Return If(IsDBNull(cellValue), -1, cellValue.ToString())
    End Function

    ' Function Add Stuffs to Table (tableName, targetColumn, values) returns true if success otherwise false

    Public Function InsertRecord(tableName As String, valuesToInsert As Dictionary(Of String, Object)) As Boolean

        Dim columnsStr As String = String.Join(", ", valuesToInsert.Keys.Select(Function(col) $"`{col}`"))
        Dim parametersStr As String = String.Join(", ", valuesToInsert.Keys.Select(Function(key) $"@{key}"))

        Dim insertSql As String = $"INSERT INTO `{tableName}` ({columnsStr}) VALUES ({parametersStr})"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(insertSql, conn)

            For Each kvp As KeyValuePair(Of String, Object) In valuesToInsert
                cmd.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value)
            Next

            readQuery(insertSql, False)

            If cmdRead IsNot Nothing Then
                cmd.Parameters.Clear()
                cmdRead.Close()
            End If

            Return True

        Catch ex As Exception
            MsgBox("Error inserting record: " & ex.Message, MsgBoxStyle.Critical)
            Return False

        Finally
            ' Close connection if open
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    ' Function to Update Stuffs to Table (tableName, targetColumn, targetId, updatedValues in Dictionary) returns true if success otherwise false

    Public Function UpdateRecord(tableName As String, columnName As String, idValue As Integer, updatedValues As Dictionary(Of String, Object)) As Boolean
        Dim query As String = $"UPDATE `{tableName}` SET "
        Dim isFirstColumn As Boolean = True

        For Each kvp As KeyValuePair(Of String, Object) In updatedValues
            If Not isFirstColumn Then query &= ", "
            query &= $"{kvp.Key} = @{kvp.Key}"
            isFirstColumn = False
        Next

        query &= $" WHERE {columnName} = @idValue"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)

            For Each kvp As KeyValuePair(Of String, Object) In updatedValues
                cmd.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value)
            Next

            cmd.Parameters.AddWithValue("@idValue", idValue)

            readQuery(query, False)

            If cmdRead IsNot Nothing Then
                cmd.Parameters.Clear()
                cmdRead.Close()
            End If

            Return True

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    ' Get row base from value (tableName, targetColumn, targetValue)

    Public Function GetRowByValue(tableName As String, columnName As String, value As Object) As DataTable
        Dim resultTable As New DataTable()
        Dim query As String = $"SELECT * FROM `{tableName}` WHERE {columnName} = @value"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@value", value)
            readQuery(query)

            If cmdRead IsNot Nothing Then
                resultTable.Load(cmdRead)
                cmdRead.Close()
            End If
        Catch ex As Exception
            MsgBox("Error retrieving row: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return resultTable
    End Function

    Public Function GetRowByTwoValues(tableName As String, columnName01 As String, value01 As Object, columnName02 As String, value02 As Object) As DataTable
        Dim resultTable As New DataTable()
        Dim query As String = $"SELECT * FROM `{tableName}` WHERE {columnName01} = @value01 AND {columnName02} = @value02"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@value01", value01)
            cmd.Parameters.AddWithValue("@value02", value02)

            readQuery(query)

            If cmdRead IsNot Nothing Then
                resultTable.Load(cmdRead)
                cmdRead.Close()
            End If
        Catch ex As Exception
            MsgBox("Error retrieving row: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return resultTable
    End Function

    ' Get All Rows From Table (tableName)

    Public Function GetAllRowsFromTable(tableName As String, includeArchive As Boolean, Optional showArchivedOnly As Boolean = False) As DataTable
        Dim resultTable As New DataTable()
        Dim query As String

        If (includeArchive) Then
            query = $"SELECT * FROM `{tableName}`"
        Else
            query = $"SELECT * FROM `{tableName}` WHERE archived = 0"
        End If

        If showArchivedOnly Then
            query = $"SELECT * FROM `{tableName}` WHERE archived = 1"
        End If

        Try
            cmd.Parameters.Clear()

            readQuery(query)

            If cmdRead IsNot Nothing Then

                resultTable.Load(cmdRead)
                cmdRead.Close()

            End If
        Catch ex As Exception
            MsgBox("Error retrieving rows: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return resultTable
    End Function

    ' Delete Row By Id (tableName, targetColumn, targetId)

    Public Function DeleteRowById(tableName As String, columnName As String, id As Integer) As Boolean
        Dim query As String = $"DELETE FROM `{tableName}` WHERE {columnName} = @id"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)
            readQuery(query, False)

            If cmdRead IsNot Nothing Then
                cmd.Parameters.Clear()
                cmdRead.Close()
            End If

            Return True

        Catch ex As Exception
            MsgBox("Error deleting row: " & ex.Message, MsgBoxStyle.Critical)
            Return False

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    ' Enums
    Public Function GetEnums(tableName As String) As List(Of KeyValuePair(Of String, Integer))
        Dim enumValues As New List(Of KeyValuePair(Of String, Integer))()
        Dim query As String = $"SELECT Name, Value FROM `{tableName}`"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)
            readQuery(query)

            If cmdRead IsNot Nothing Then
                While cmdRead.Read()
                    Dim name As String = cmdRead("Name").ToString()
                    Dim value As Integer = Convert.ToInt32(cmdRead("Value"))
                    enumValues.Add(New KeyValuePair(Of String, Integer)(name, value))
                End While
                cmdRead.Close()
            End If
        Catch ex As Exception
            MsgBox("Error retrieving enum values: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return enumValues
    End Function

End Class
