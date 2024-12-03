Imports Google.Protobuf.Compiler

Public Class SuppliersForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim exportUtils As New ExportUtils

    Dim supConst As New SuppliersDBConstants

    Private suppID As Integer
    Private archivedStatus As Boolean
    Private suppDT As DataTable = Nothing

    Public Property selectMode As Boolean = False
    Public Property selectedID As Integer = -1

    Private finishedLoad As Boolean = False

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
        RefForArch()
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
                 .archByStr, ' exclude
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
            searchValues.Remove(.archByStr)
            searchValues.Remove(.archivedStr)
            searchValues.Remove(.dateArchivedStr)

            formUtils.LoadToDGV(SuppliersDGV, suppDT, searchTerm, searchValues, SearchComboBox.SelectedIndex, ShowArchiveCheckBox)

            Cursor = Cursors.Default
        End With
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        RefForArch()
    End Sub

    Private Sub RefForArch()
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(SuppliersDGV, ShowArchiveCheckBox, DeleteSupplierBtn, ArchiveSupplierBtn, EditSupplierBtn, AddSupplierBtn)
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

    ' EXPORT
    Private Sub ExportToExcelBtn_Click(sender As Object, e As EventArgs) Handles ExportToExcelBtn.Click
        With supConst
            Dim columnHeaderMapping As New Dictionary(Of String, String) From {
              { .supIDStr, "Supplier ID"},
              { .compNameStr, "Company Name"},
              { .contactNumStr, "Contact Number"},
              { .contactPersonStr, "Contact Person"},
              { .compEmailStr, "Hazardous Classification"},
              { .locationStr, "Company Location"},
              { .supTypeStr, "Supplier Type"},
              { .supContractStr, "Contract Type"},
              { .bankDetailsStr, "Bank Details"},
              { .payTermsStr, "Payment Terms"},
              { .estDeliveryStr, "Estimated Delivery Time"},
              { .dateAddedStr, "Date Added"},
              { .addedByName, "Added By"},
              { .dateArchivedStr, "Date Archived"}
            }

            Dim keys As List(Of String) = formUtils.GetDictKey(columnHeaderMapping)
            Dim dt = dbHelper.GetAllByCol(keys, supConst.supTableStr)

            If dt.Rows.Count = 0 Then
                MsgBox("There is nothing to export")
                Exit Sub
            End If

            Dim title = "All Supplier Reports"

            If ExportUtils.ExportDataTableToExcel(dt, title, columnHeaderMapping) Then
                dbHelper.Logs(title, Current.id)
            End If
        End With
    End Sub

End Class