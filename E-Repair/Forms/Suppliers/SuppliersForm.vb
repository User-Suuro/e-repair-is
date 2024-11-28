Imports System.Linq.Expressions
Imports Google.Protobuf.Compiler

Public Class SuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils

    Dim supConst As New SuppliersDBConstants

    Private suppID As Integer
    Private archivedStatus As Boolean

    Public Property selectMode As Boolean = False
    Public Property suppDT As DataTable = Nothing
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
        formUtils.ArchiveRow(archivedStatus, supConst.supTableStr, supConst.supIDStr, suppID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteSupplierBtn.Click
        If Not InitValues() Then Exit Sub
        formUtils.DeleteRow(archivedStatus, supConst.supTableStr, supConst.supIDStr, suppID)
        LoadDataToDGV()
    End Sub

    ' FORM ONLOAD
    Private Sub AdminSuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        SuppliersDGV.ClearSelection()
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")
        With supConst
            Dim searchValues() As String = {
                 .compNameStr,
                 .contactPersonStr,
                 .contactNumStr,
                 .compEmailStr,
                 .locationStr,
                 .estDeliveryStr,
                 .totalPaidStr,
                 .dateAddedStr
            }

            If Not selectMode Then suppDT = dbHelper.GetAllData(.supTableStr)
            formUtils.LoadToDGV(SuppliersDGV, suppdt, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex, searchTerm)
        End With

        formUtils.FormatDGVForArchive(SuppliersDGV)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        formUtils.FormatChkBoxForArchive(SuppliersDGV, ShowArchiveCheckBox, DeleteSupplierBtn, ArchiveSupplierBtn, EditSupplierBtn, AddSupplierBtn)
        LoadDataToDGV()
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged

    End Sub
End Class