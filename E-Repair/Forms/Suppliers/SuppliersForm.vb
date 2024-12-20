﻿Imports Google.Protobuf.Compiler

Public Class SuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim supConst As New SuppliersDBConstants

    ' STATES
    Private suppID As Integer
    Private archivedStatus As Boolean
    Private suppDT As DataTable
    Private finishedLoad As Boolean = False

    Public Property selectMode As Boolean = False
    Public Property selectedID As Integer = -1




    ' INIT VALUES
    Private Function InitValues() As Boolean
        If Not formUtils.dgvValChecker(SuppliersDGV) Then Return False

        With SuppliersDGV.CurrentRow
            suppID = .Cells(supConst.supIDStr).Value
            archivedStatus = .Cells(supConst.archivedStr).Value
        End With

        Return True
    End Function

    ' VIEW
    Private Sub ViewSupplierBtn_Click(sender As Object, e As EventArgs) Handles ViewSupplierBtn.Click
        If Not InitValues() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SupplierViewModal()
            modal.selectedID = id
            Return modal
        End Function,
        suppID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    ' ADD
    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SupplierAddEditModal()
            modal.selectedID = id
            Return modal
        End Function,
        -1,
        Function(modal)
            Return Nothing
        End Function
          )

        LoadDataToDGV()
    End Sub

    'EDIT
    Private Sub EditSupplierBtn_Click(sender As Object, e As EventArgs) Handles EditSupplierBtn.Click
        If Not InitValues() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SupplierAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        suppID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    ' ARCHIVE
    Private Sub ArchiveSupplierBtn_Click(sender As Object, e As EventArgs) Handles ArchiveSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.ArchiveRow(archivedStatus, supConst.supTableStr, supConst.supIDStr, suppID, "Archived Supplier: " & suppID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.DeleteRow(archivedStatus, supConst.supTableStr, supConst.supIDStr, suppID, "Deleted Supplier: " & suppID)
        RefForArch()
    End Sub

    Private Sub SupplierExportBtn_Click(sender As Object, e As EventArgs) Handles SupplierExportBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New SuppliersExportModal()
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
    End Sub

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
        finishedLoad = True
        LoadDataToDGV()
        SuppliersDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        If Not finishedLoad Then Exit Sub

        With supConst
            Dim searchValues As New List(Of String) From {
                 .supIDStr, ' exclude
                 .archivedStr, ' exclude
                 .dateArchivedStr, ' exclude
                 .compNameStr,
                 .contactPersonStr,
                 .compEmailStr,
                 .locationStr,
                 .supContractStr,
                 .dateAddedStr
            }


            Cursor = Cursors.WaitCursor

            suppDT = dbHelper.GetAllByCol(searchValues, supConst.supTableStr)

            ' exclude for searching
            searchValues.Remove(.supIDStr)
            searchValues.Remove(.archivedStr)
            searchValues.Remove(.dateArchivedStr)

            formUtils.LoadToDGV(SuppliersDGV, suppDT, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)

            Cursor = Cursors.Default
        End With
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckbox.CheckedChanged
        RefForArch()
    End Sub

    Private Sub RefForArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(SuppliersDGV, ShowArchiveCheckbox, DeleteSupplierBtn, ArchiveSupplierBtn, EditSupplierBtn, AddSupplierBtn)
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataToDGV(SearchTextBox.Text)
            e.SuppressKeyPress = True ' Prevents the beep sound when pressing Enter
        End If
    End Sub

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitValues() Then Exit Sub
        selectedID = suppID
        Me.Close()
    End Sub

    ' SEARCH
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class