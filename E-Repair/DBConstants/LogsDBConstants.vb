Public Class LogsDBConstants
    ' Define constants for column names in the log table
    Private ReadOnly _tableName As String = "logs"

    Private ReadOnly _logId As String = "log_id"
    Private ReadOnly _userAccountsId As String = "user_accounts_id"
    Private ReadOnly _transactions As String = "transactions"
    Private ReadOnly _event As String = "event"
    Private ReadOnly _dateAdded As String = "date_added"

    ' Getter for table name
    Public ReadOnly Property TableName As String
        Get
            Return _tableName
        End Get
    End Property

    ' Getter for LogId column name
    Public ReadOnly Property LogId As String
        Get
            Return _logId
        End Get
    End Property

    ' Getter for UserAccountsId column name
    Public ReadOnly Property UserAccountsId As String
        Get
            Return _userAccountsId
        End Get
    End Property

    ' Getter for Transactions column name
    Public ReadOnly Property Transactions As String
        Get
            Return _transactions
        End Get
    End Property

    ' Getter for Event column name
    Public ReadOnly Property EventColumn As String
        Get
            Return _event
        End Get
    End Property

    ' Getter for DateAdded column name
    Public ReadOnly Property DateAdded As String
        Get
            Return _dateAdded
        End Get
    End Property
End Class
