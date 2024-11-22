Imports System.IO
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports Guna.UI2.WinForms

Public Class FormUtils
    Dim dbHelper As New DbHelper

    Public Sub LoadFormIntoPanel(targetPanel As Panel, frm As Form)
        ' Remove existing controls in the target panel if any
        If targetPanel.Controls.Count > 0 Then
            targetPanel.Controls.RemoveAt(0)
        End If

        ' Set up the form properties for embedding
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        ' Add the form to the target panel and show it
        targetPanel.Controls.Add(frm)
        targetPanel.Tag = frm
        frm.Show()
    End Sub

    ' Ok cancel MsgBox
    Public Function ShowMessageBoxResult(title As String, content As String) As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show(content, title, MessageBoxButtons.OKCancel)

        If dialogResult = DialogResult.OK Then
            Return True
        ElseIf dialogResult = DialogResult.Cancel Then
            Return False
        End If

        Return False
    End Function

    ' Find combo box index by value
    Public Function FindComboBoxItemByText(comboBox As ComboBox, searchText As String) As Integer
        Dim index As Integer = -1

        For i As Integer = 0 To comboBox.Items.Count - 1
            If comboBox.Items(i).ToString() = searchText Then
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    ' Create Bg Form
    Public Function CreateBgFormModal() As Form

        Dim form As New Form

        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        form.StartPosition = FormStartPosition.CenterScreen
        form.Opacity = 0.5
        form.BackColor = Color.Black
        form.TopMost = True
        form.Show()

        Return form

    End Function

    ' Copy image to pc's appdata then return the path
    Public Function saveImgToLocal(sourceFilePath As String, folderName As String, commit As Boolean) As String

        If File.Exists(sourceFilePath) Then
            Dim image As Image = Image.FromFile(sourceFilePath)

            Dim imageFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "E-Repair Images")

            Dim specificFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "E-Repair Images", folderName)

            If Not Directory.Exists(imageFolder) Then
                Directory.CreateDirectory(imageFolder)
            End If

            If Not Directory.Exists(specificFolder) Then
                Directory.CreateDirectory(specificFolder)
            End If

            Dim combinedFolder As String = Path.Combine(imageFolder, specificFolder)

            Dim fileName As String = Path.GetFileName(sourceFilePath)
            Dim filePath As String = Path.Combine(combinedFolder, fileName)

            If File.Exists(filePath) Then Return filePath

            If commit Then image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png)

            Return filePath

        Else
            MessageBox.Show("Source file does not exist.")
            Return String.Empty
        End If
    End Function

    ' VALUE CHECKER
    Public Function AreAllValuesFilled(values As Dictionary(Of String, Object), Optional startingIndex As Integer = 0) As Boolean
        For i As Integer = startingIndex To values.Count - 1
            Dim kvp As KeyValuePair(Of String, Object) = values.ElementAt(i) ' Access key-value pair by index
            If kvp.Value Is Nothing OrElse kvp.Value.ToString().Trim() = "" OrElse kvp.Value.ToString() = "-1" Then
                MsgBox("Please fill all necessary details")
                Return False
            End If
        Next

        Return True
    End Function

    ' Search function
    Public Function SearchFunction(dt As DataTable, searchTerm As String, searchValues As String(), searchCmbSelectedIndex As Integer) As DataTable
        Dim searchBy As String = searchValues(0)

        If searchCmbSelectedIndex >= 0 AndAlso searchCmbSelectedIndex < searchValues.Length Then
            searchBy = searchValues(searchCmbSelectedIndex)
        End If

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            dt.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) LIKE '%{searchTerm}%'"
        Else
            dt.DefaultView.RowFilter = ""
        End If

        Return dt
    End Function

    ' Format dgv for archive
    Public Sub FormatChkBoxForArchive(dgv As DataGridView, chkbox As CheckBox, delBtn As Button, archBtn As Button, editBtn As Button, addBtn As Button)
        Try
            If chkbox.Checked Then
                delBtn.Visible = True
                archBtn.Visible = False

                editBtn.Visible = False
                addBtn.Visible = False

                dgv.Columns("DATE_ARCHIVED").Visible = True
                dgv.Columns("ARCHIVED_BY").Visible = True
            Else
                delBtn.Visible = False
                archBtn.Visible = True

                editBtn.Visible = True
                addBtn.Visible = True

                dgv.Columns("DATE_ARCHIVED").Visible = False
                dgv.Columns("ARCHIVED_BY").Visible = False
            End If
        Catch ex As Exception
            MsgBox("Unable to format checkbox for archive: " & ex.Message)
        End Try
    End Sub

    Public Sub FormatDGVForArchive(dgv As DataGridView)
        Try
            For Each row As DataGridViewRow In dgv.Rows

                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

                If row.Cells("ARCHIVED_BY").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ARCHIVED_BY").Value) Then
                    Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ARCHIVED_BY").Value)

                    If getEmpData.Rows.Count > 0 Then
                        row.Cells("ARCHIVED_BY").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Unable to format DGV for archive: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadToDGV(dgv As DataGridView, tableName As String, searchValues() As String, searchIndex As Integer, archivedChkBox As CheckBox, Optional searchTerm As String = "")
        Dim dt As DataTable

        If archivedChkBox.Checked Then
            dt = dbHelper.GetAllRowsFromTable(tableName, True, True)
        Else
            dt = dbHelper.GetAllRowsFromTable(tableName, False)
        End If

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            dt = SearchFunction(dt, searchTerm, searchValues, searchIndex)
        End If

        dgv.AutoGenerateColumns = True
        dgv.DataSource = dt
    End Sub

    ' Archive Row

    Public Sub archiveRow(archivedStatus As Boolean, tableName As String, columnName As String, targetID As Integer)
        Dim loggedUser As String

        If archivedStatus Then
            MsgBox("This row is already archived!")
            Exit Sub
        End If

        Try
            loggedUser = GlobalSession.CurrentSession.EmployeeID

        Catch ex As Exception
            loggedUser = "N/A"
            MsgBox("There is no current active user!")
        End Try

        If Not ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this row?") Then Exit Sub

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", loggedUser},
            {"date_archived", DateTime.Now}
}
        Try
            dbHelper.UpdateRecord(tableName, columnName, targetID, updatedValues)
            MsgBox("Successfull Archived")

        Catch ex As Exception
            MsgBox("Cannot archive the selected row: " & ex.Message)
        End Try
    End Sub

    ' del row

    Public Sub delRow(archivedStatus As Boolean, tableName As String, columnName As String, targetID As Integer)

        If Not archivedStatus Then
            MsgBox("Archive the row first")
            Exit Sub
        End If

        If Not ShowMessageBoxResult("Confirmation", "Are you sure you want to delete this row") Then Exit Sub

        If dbHelper.DeleteRowById(tableName, columnName, targetID) Then MsgBox("Successfully Deleted")

    End Sub

    ' add / edit row

    Public Sub ShowModalWithHandler(Of T As {Form, New})(createModal As Func(Of Object, T), selectedID As Object, dataReloadAction As Action)
        Dim modalForm As T = Nothing
        Dim backgroundForm As Form = Nothing

        Try
            backgroundForm = CreateBgFormModal()
            modalForm = createModal.Invoke(selectedID)
            modalForm.ShowDialog()

        Catch ex As Exception
            MsgBox("Unable to show modal: " & ex.Message)
            If backgroundForm IsNot Nothing Then backgroundForm.Close()
            If modalForm IsNot Nothing Then modalForm.Close()

        Finally
            If modalForm IsNot Nothing Then modalForm.Dispose()
            If backgroundForm IsNot Nothing Then backgroundForm.Dispose()
            If dataReloadAction IsNot Nothing Then dataReloadAction.Invoke()
        End Try
    End Sub

    Public Function dgvValChecker(dgv As DataGridView)
        If dgv.Rows.Count = 0 Then
            MsgBox("No Data Found!")
            Return False
        End If

        If dgv.CurrentRow Is Nothing Then
            MsgBox("No row is currently selected.")
            Return False
        End If

        If dgv.SelectedRows.Count <= 0 Then
            MsgBox("Please Select a Row First")
            Return False
        End If

        Return True
    End Function

End Class
