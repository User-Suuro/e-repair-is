﻿
Public Class EmployeeForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    Dim empConst As New EmployeesDBConstants
    Dim exportUtils As New ExportUtils

    ' STATES
    Private employeeID As Integer = -1
    Private empArchived As Boolean = False
    Private empPosition As String = ""
    Private finishedLoad As Boolean = False
    Private empDT As DataTable

    Public Property selectedEmpID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property techOnly As Boolean = False


    ' INIT DATA
    Private Function InitData() As Boolean

        If Not formUtils.dgvValChecker(EmpDGV) Then Return False

        With EmpDGV.CurrentRow
            employeeID = .Cells(empConst.empIDStr).Value
            empArchived = .Cells(empConst.empArchStr).Value
            empPosition = .Cells(empConst.empJobPosStr).Value
        End With

        Return True
    End Function

    Private Function hasPendingWork() As Boolean
        If empPosition = constants.getTechnicianString Then
            Dim pendingWork As Integer = formUtils.getTechStatsNumbers(constants.getPendingString, employeeID)

            If pendingWork <> 0 Then
                MsgBox("You cannot archive employee that has " & pendingWork & " pending work")
                Return False
            End If

            Return True
        End If

        Return True
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeViewModal()
            modal.selectedID = id
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )
    End Sub

    ' ADD
    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
            modal.selectedID = id
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
    End Sub

    ' EDIT
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click

        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    'ARCHIVE
    Private Sub BtnArchive_Click(sender As Object, e As EventArgs) Handles ArchiveEmployeeBtn.Click
        If Not InitData() Then Exit Sub
        If Not hasPendingWork() Then Exit Sub
        formUtils.ArchiveRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID, "Archived Employee: " & employeeID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If Not InitData() Or Not hasPendingWork() Then Exit Sub
        formUtils.DeleteRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID, "Deleted Employee: " & employeeID)
        RefreshForArchive()
    End Sub

    Private Sub EmployeeExportBtn_Click(sender As Object, e As EventArgs) Handles EmployeeExportBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeExportModal()
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataToDGV(SearchTextBox.Text)
            e.SuppressKeyPress = True ' Prevents the beep sound when pressing Enter
        End If
    End Sub

    ' SEARCH CMB
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckbox.CheckedChanged
        RefreshForArchive()
    End Sub

    Private Sub RefreshForArchive()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(EmpDGV, ShowArchiveCheckBox, DeleteEmployeeBtn, ArchiveEmployeeBtn, EditEmployeeBtn, AddEmployeeBtn)
    End Sub

    ' LOAD FORM
    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        finishedLoad = True
        LoadDataToDGV()
        EmpDGV.ClearSelection()

        ArchiveEmployeeBtn.Visible = False
        DeleteEmployeeBtn.Visible = False
        AddEmployeeBtn.Visible = False
        EmployeeExportBtn.Visible = False
        EditEmployeeBtn.Visible = False

        If Current.position = constants.getAdminString Or Current.position = constants.getSuperAdminString Then
            ArchiveEmployeeBtn.Visible = True
            DeleteEmployeeBtn.Visible = True
            AddEmployeeBtn.Visible = True
            EmployeeExportBtn.Visible = True
            EditEmployeeBtn.Visible = True
        End If

    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        If Not finishedLoad Then Exit Sub

        With empConst

            Dim colValues As New List(Of String) From {
              .empIDStr, ' exclude
              .empArchDateStr,  ' exclude
              .empArchStr,  ' exclude
              .empFirstStr,
              .empMidStr,
              .empLastStr,
              .empHiredStr,
              .empEmailStr,
              .empLastAccessedStr,
              .empAddDateStr,
              .empJobPosStr
            }

            Cursor = Cursors.WaitCursor

            If Not techOnly Then
                empDT = dbHelper.GetAllByCol(colValues, empConst.empTableStr)
            Else
                empDT = dbHelper.GetRowByColValue(colValues, empConst.empTableStr, empConst.empJobPosStr, constants.getTechnicianString)
            End If

            ' exlucde to search
            colValues.Remove(.empIDStr)
            colValues.Remove(.empArchStr)
            colValues.Remove(.empArchDateStr)

            formUtils.LoadToDGV(EmpDGV, empDT, searchTerm, colValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)

            Cursor = Cursors.Default
        End With
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' BTN SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Or Not selectMode Then Exit Sub

        selectedEmpID = employeeID

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub


End Class