﻿Imports System.Linq.Expressions
Imports Google.Protobuf.Compiler

Public Class SuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Private suppID As Integer
    Private archivedStatus As Boolean
    Public selectMode As Boolean = False

    ' INIT VALUES
    Private Function InitValues() As Boolean
        If Not formUtils.dgvValChecker(SuppliersDGV) Then Return False

        With SuppliersDGV.CurrentRow
            suppID = .Cells("SUPPLIER_ID").Value
            archivedStatus = .Cells("ARCHIVED").Value
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
        Sub()
            LoadDataToDGV()
        End Sub
    )
    End Sub

    ' ADD
    Private Sub AddSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click
        Dim supplierAddEditModal As New SupplierAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With supplierAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("Unable to show add suppliers modal: " & ex.Message)
            formModal.Close()
            supplierAddEditModal.Close()
        Finally
            supplierAddEditModal.Dispose()
            formModal.Dispose()
            LoadDataToDGV()
        End Try
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
        Sub()
            LoadDataToDGV()
        End Sub
    )
    End Sub

    ' ARCHIVE
    Private Sub ArchiveSupplierBtn_Click(sender As Object, e As EventArgs) Handles ArchiveSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.archiveRow(archivedStatus, "suppliers", "supplier_id", suppID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.delRow(archivedStatus, "suppliers", "supplier_id", suppID)
        LoadDataToDGV()
    End Sub

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        SuppliersDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        Dim searchValues() As String = {
           "company_name",
           "contact_person",
           "contact_number",
           "company_email",
           "location",
           "estimated_delivery_time",
           "total_paid",
           "date_added"
        }

        formUtils.LoadToDGV(SuppliersDGV, "suppliers", searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox, searchTerm)
        formUtils.FormatDGVForArchive(SuppliersDGV)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(SuppliersDGV, ShowArchiveCheckBox, DeleteSupplierBtn, ArchiveSupplierBtn, EditSupplierBtn, AddSupplierBtn)
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub
End Class