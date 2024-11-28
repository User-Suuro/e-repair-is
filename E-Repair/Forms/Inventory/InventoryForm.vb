Imports System.Runtime.Remoting

Public Class InventoryForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim invConst As New InventoryDBConstants

    Private inventoryID As Integer = -1
    Private itemQuantity As Integer = -1
    Private is_archived = False

    Public Property selectedID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property invDT As DataTable = Nothing

    ' INIT DATA
    Private Function InitData() As Boolean
        If Not formUtils.dgvValChecker(InventoryDGV) Then Return False

        With InventoryDGV.CurrentRow
            inventoryID = .Cells(invConst.supIDStr).Value
            itemQuantity = .Cells(invConst.qtyStr).Value
            is_archived = .Cells(invConst.archivedStr)
        End With

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        InventoryDGV.ClearSelection()
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)

        If selectedID = -1 Then
            BtnSelect.Visible = False
        End If
    End Sub

    ' USE
    Private Sub UseBtn_Click(sender As Object, e As EventArgs) Handles UseBtn.Click
        If Not InitData() Then Exit Sub

        If itemQuantity = 0 Then
            MsgBox("Insufficient Quantity")
            Exit Sub
        End If

        formUtils.ShowModalWithHandler(
          Function(id)
              Dim modal As New InventoryUseModal
              modal.selectedID = id
              Return modal
          End Function,
          inventoryID,
          Function(modal)
              Return Nothing
          End Function
          )

        LoadDataToDGV()
    End Sub

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InventoryViewModal
             modal.selectedID = id
             Return modal
         End Function,
         inventoryID,
         Function(modal)
             Return Nothing
         End Function
         )

        LoadDataToDGV()
    End Sub

    ' ADD
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InvetoryAddEditModal
             Return modal
         End Function,
         -1,
         Function(modal)
             Return Nothing
         End Function
         )

        LoadDataToDGV()
    End Sub

    ' EDIT
    Private Sub EdtBtn_Click(sender As Object, e As EventArgs) Handles EdtBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InvetoryAddEditModal
             modal.selectedID = id
             Return modal
         End Function,
         inventoryID,
         Function(modal)
             Return Nothing
         End Function
         )

        LoadDataToDGV()
    End Sub

    ' ARCHIVED
    Private Sub ArchivedBtn_Click(sender As Object, e As EventArgs) Handles ArchivedBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.ArchiveRow(is_archived, invConst.invTableStr, invConst.svcIDStr, selectedID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.DeleteRow(is_archived, invConst.invTableStr, invConst.svcIDStr, selectedID)
        LoadDataToDGV()
    End Sub

    ' LOAD DATA
    Public Sub LoadDataToDGV(Optional searchTerm As String = "")
        With invConst
            Dim searchValues() As String = {
                .itemCatStr,
                .itemNameStr,
                .qtyStr,
                .physLocStr,
                .totalCostStr,
                .dateAddedStr,
                .addedByStr
            }

            If Not selectMode Then invDT = dbHelper.GetAllData(.invTableStr)
            formUtils.LoadToDGV(InventoryDGV, invDT, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex, searchTerm)
        End With
    End Sub

    ' SEARCH TEXT
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SEARCH CMB
    Private Sub SearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchComboBox.SelectedIndexChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(InventoryDGV, ShowArchiveCheckBox, DeleteBtn, ArchivedBtn, EdtBtn, AddBtn)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub
End Class