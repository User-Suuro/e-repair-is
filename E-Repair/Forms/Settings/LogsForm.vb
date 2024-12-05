Public Class LogsForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim logsConst As New LogsDBConstants

    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
    End Sub

    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        Dim logsDT = dbHelper.GetAllData(logsConst.TableName)

        Dim searchValues As New List(Of String) From {
           logsConst.LogId,
           logsConst.UserAccountsId,
           logsConst.Transactions,
           logsConst.DateAdded
        }

        formUtils.LoadToDGV(LogsDGV, logsDT, searchTerm, searchValues, SearchComboBox.SelectedIndex)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataToDGV(SearchTextBox.Text)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub
End Class