﻿Public Class LogsForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils

    Dim logsConst As New LogsDBConstants

    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogsDGV.DataSource = dbHelper.GetAllData(logsConst.TableName)
        LogsDGV.RowTemplate.Height = formUtils.rowHeight
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class