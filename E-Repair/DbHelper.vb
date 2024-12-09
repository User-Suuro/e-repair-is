Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class DbHelper
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader

    ' Originally from modDB, readQuery must be the same variables as cmd and cmdRead that also uses these variables

    ' Open connection to db

    Public Sub openConn(ByVal db_name As String)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = getStrCon()
                .Open()
            End With
        Catch ex As Exception
            MsgBox("Error opening connection: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Read query to db

    Public Sub readQuery(ByVal sql As String, Optional ByVal isSelectQuery As Boolean = True)
        Try

            openConn(getDbName)

            With cmd
                .Connection = conn
                .CommandText = sql
                If isSelectQuery Then
                    cmdRead = .ExecuteReader()  ' SELECT / READ
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

    Public Sub Logs(ByVal transaction As String, ByVal id As Integer, Optional ByVal events As String = "*_Click")
        Try
            readQuery(String.Format("INSERT INTO `logs`(`user_accounts_id`, `event`, `transactions`, `date_added`) VALUES ({0}, '{1}', '{2}', '{3}')",
                                    id,
                                    events,
                                    transaction,
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                    ))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Custom Functions 

    Public Function StrNullCheck(cellValue As Object) As String
        Try
            Return If(cellValue Is Nothing OrElse IsDBNull(cellValue), "N/A", cellValue.ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "N/A"
        End Try
    End Function

    Public Function IntNullCheck(cellValue As Object) As Integer
        Try
            Return If(cellValue Is Nothing OrElse IsDBNull(cellValue), -1, Convert.ToInt32(cellValue))
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
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

    ' Getters

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

    Public Function GetAllByCol(columns As List(Of String), tableName As String) As DataTable
        Dim resultTable As New DataTable()
        Dim selectedColumns As String = If(columns IsNot Nothing AndAlso columns.Count > 0,
                                       String.Join(", ", columns.Select(Function(c) $"`{c}`")),
                                       "*")

        Dim query As String = $"SELECT {selectedColumns} FROM `{tableName}`"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)

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

    Public Function GetRowByColValue(columns As List(Of String), tableName As String, columnName As String, value As Object) As DataTable
        Dim resultTable As New DataTable()

        Dim selectedColumns As String = If(columns IsNot Nothing AndAlso columns.Count > 0,
                                    String.Join(", ", columns.Select(Function(c) $"`{c}`")),
                                    "*")

        Dim query As String = $"SELECT {selectedColumns} FROM `{tableName}` WHERE `{columnName}` = @value"

        Try
            cmd.Parameters.Clear()
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@value", value)

            readQuery(query)

            ' Check if the command read returned data
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

    Public Function GetRowByColWTwoVal(columns As List(Of String), tableName As String, columnName01 As String, value01 As Object, columnName02 As String, value02 As Object) As DataTable
        Dim resultTable As New DataTable()

        Dim selectedColumns As String = If(columns IsNot Nothing AndAlso columns.Count > 0,
                                       String.Join(", ", columns.Select(Function(c) $"`{c}`")),
                                       "*")
        Dim query As String = $"SELECT {selectedColumns} FROM `{tableName}` WHERE `{columnName01}` = @value01 AND `{columnName02}` = @value02"

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
            MsgBox("Error retrieving rows: " & ex.Message, MsgBoxStyle.Critical)
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

    Public Function GetAllData(tableName As String) As DataTable
        Dim resultTable As New DataTable()
        Dim query As String = $"SELECT * FROM `{tableName}`"

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

    Public Function DeleteRowByID(tableName As String, columnName As String, id As Integer) As Boolean
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

    ' Get
    Public Function GetEnums(tableName As String, columnName As String) As List(Of String)
        Dim enumValues As New List(Of String)()
        Dim query As String = $"SHOW COLUMNS FROM `{tableName}` WHERE Field = @columnName"

        Try
            cmd.Parameters.Clear()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@columnName", columnName)
            readQuery(query, True)

            If cmdRead IsNot Nothing AndAlso cmdRead.Read() Then
                Dim columnType As String = cmdRead("Type").ToString()

                'remove quotes
                Dim match As Match = Regex.Match(columnType, "^enum\('(.*)'\)$")

                If match.Success Then
                    ' Remove commas, trim values, and exclude blank entries
                    enumValues = match.Groups(1).Value.Split("','").
                                  Select(Function(v) v.Replace(",", "").Trim()).
                                  Where(Function(v) Not String.IsNullOrWhiteSpace(v)).
                                  ToList()
                End If
                cmdRead.Close()
            End If

        Catch ex As Exception
            MsgBox("Error retrieving enum values: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return enumValues
    End Function

    ' Update

    Public Sub AlterEnums(tableName As String, columnName As String, enumValues As List(Of String))
        Try
            If enumValues Is Nothing OrElse enumValues.Count = 0 Then
                Throw New ArgumentException("The provided list must contain values.")
            End If

            Dim enumValuesString As String = String.Join(",", enumValues.Select(Function(v) $"'{v}'"))
            Dim query As String = $"ALTER TABLE `{tableName}` MODIFY COLUMN `{columnName}` ENUM({enumValuesString})"

            cmd.Parameters.Clear()
            cmd = New MySqlCommand(query, conn)
            readQuery(query)

        Catch ex As Exception
            MsgBox("Error altering enum values: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' load to cmb

    Public Sub LoadEnumsToCmb(cmb As ComboBox, tableName As String,
                              columnName As String,
                              Optional selectedIndex As Integer = -1,
                              Optional startingIndex As Integer = 0)
        Try
            Dim enumValues As List(Of String) = GetEnums(tableName, columnName)

            If startingIndex >= 0 AndAlso startingIndex < enumValues.Count Then
                enumValues = enumValues.Skip(startingIndex).ToList()
            ElseIf startingIndex < 0 OrElse startingIndex >= enumValues.Count Then
                Throw New ArgumentOutOfRangeException(
                "startingIndex",
                $"Starting index {startingIndex} is out of range for the enum values list."
            )
            End If

            cmb.DataSource = enumValues

            If selectedIndex = -1 Then
                cmb.SelectedIndex = -1
            ElseIf selectedIndex >= 0 AndAlso selectedIndex < enumValues.Count Then
                cmb.SelectedIndex = selectedIndex
            Else
                Throw New ArgumentOutOfRangeException(
                "selectedIndex",
                $"Selected index {selectedIndex} is out of range for the ComboBox items."
            )
            End If

        Catch ex As Exception
            MsgBox("Error populating ComboBox: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
