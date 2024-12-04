Imports System.Runtime.Remoting

Public Class InventoryForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim invConst As New InventoryDBConstants
    Dim constants As New Constants

    Private inventoryID As Integer = -1
    Private itemQuantity As Integer = -1
    Private is_archived As Boolean = False


    Public Property selectedID As Integer = -1
    Public Property selectMode As Boolean = False

    Public Property supplierMode As Boolean = False
    Private finishedLoad As Boolean = False

    ' VIEW MODE
    Public Property viewMode As Boolean = False
    Public Property invDT As DataTable = Nothing

    ' INIT DATA
    Private Function InitData() As Boolean
        If Not formUtils.dgvValChecker(InventoryDGV) Then Return False

        With InventoryDGV.CurrentRow
            inventoryID = .Cells(invConst.invIDStr).Value
            itemQuantity = .Cells(invConst.availableQtyStr).Value
            is_archived = .Cells(invConst.archivedStr).Value
        End With

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        finishedLoad = True
        LoadDataToDGV()
        InventoryDGV.ClearSelection()

        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)

        If viewMode Then BtnClose.Visible = True

        If selectedID = -1 Then
            BtnSelect.Visible = False
        End If

        ' Adjust view for positions
        If Current.position = constants.getTechnicianString Then
            AddBtn.Visible = False
            ArchivedBtn.Visible = False
            EdtBtn.Visible = False
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

    Private Sub InventoryExportBtn_Click(sender As Object, e As EventArgs) Handles InventoryExportBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New InventoryExportModal()
            Return modal
        End Function,
        -1,
        Function(modal)
            LoadDataToDGV()
            Return Nothing
        End Function
        )
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

    'Category
    'Item Name
    'Cost per item
    'Quantity
    'Physical Location
    'Total Value
    'Date Added
    'Added By

    ' LOAD DATA
    Public Sub LoadDataToDGV(Optional searchTerm As String = "")
        If Not finishedLoad Then Exit Sub

        With invConst
            Dim searchValues As New List(Of String) From {
                .itemCatStr,
                .itemNameStr,
                .costPerItem,
                .availableQtyStr,
                .physLocStr,
                .totalCostStr,
                .dateAddedStr,
                .addedByIdName,
                .totalCostStr,' exclude
                .invIDStr,
                .archivedStr,
                .archByStr,
                .dateArchivedStr
            }

            If Not viewMode Then

                If supplierMode Then
                    invDT = dbHelper.GetRowByValue(.invTableStr, .supIDStr, selectedID)
                Else
                    invDT = dbHelper.GetAllByCol(searchValues, .invTableStr)
                End If

            End If

            searchValues.Remove(.totalCostStr)
            searchValues.Remove(.invIDStr)
            searchValues.Remove(.archivedStr)
            searchValues.Remove(.archByStr)
            searchValues.Remove(.dateArchivedStr)

            formUtils.LoadToDGV(InventoryDGV, invDT, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)
        End With
    End Sub

    ' SEARCH TEXT
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

    ' SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        selectedID = inventoryID
        Me.Close()
    End Sub
End Class