Imports System.Runtime.Remoting

Public Class InventoryForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim invConst As New InventoryDBConstants

    Private inventoryID As Integer = -1
    Private itemQuantity As Integer = -1
    Private is_archived As Boolean = False

    Public Property selectedID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property viewMode As Boolean = False
    Public Property invDT As DataTable = Nothing

    ' INIT DATA
    Private Function InitData() As Boolean
        If Not formUtils.dgvValChecker(InventoryDGV) Then Return False

        With InventoryDGV.CurrentRow
            inventoryID = .Cells(invConst.invIDStr).Value
            itemQuantity = .Cells(invConst.qtyStr).Value
            is_archived = .Cells(invConst.archivedStr).Value
        End With

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        InventoryDGV.ClearSelection()

        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)

        If viewMode Then BtnClose.Visible = True

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

        MsgBox(inventoryID)

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

        MsgBox(inventoryID)

        formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InvetoryAddEditModal
             modal.selectedID = id
             modal.editMode = True
             Return modal
         End Function,
         inventoryID,
         Function(modal)
             Return Nothing
         End Function
         )

        LoadDataToDGV()
    End Sub

    ' ARCHIVE
    Private Sub ArchivedBtn_Click(sender As Object, e As EventArgs) Handles ArchivedBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.ArchiveRow(is_archived, invConst.invTableStr, invConst.invIDStr, inventoryID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.DeleteRow(is_archived, invConst.invTableStr, invConst.invIDStr, inventoryID)
        RefForArch()
    End Sub

    ' LOAD DATA
    Public Sub LoadDataToDGV(Optional searchTerm As String = "")
        With invConst
            Dim searchValues As New List(Of String) From {
                .itemCatStr,
                .itemNameStr,
                .qtyStr,
                .physLocStr,
                .totalCostStr,
                .dateAddedStr,
                .addedByIdName
            }

            If Not selectMode Then invDT = dbHelper.GetAllData(.invTableStr)
            formUtils.LoadToDGV(InventoryDGV, invDT, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)
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
        RefForArch()
    End Sub

    Private Sub RefForArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(InventoryDGV, ShowArchiveCheckBox, DeleteBtn, ArchivedBtn, EdtBtn, AddBtn)
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

    End Sub

    ' SELECT

End Class