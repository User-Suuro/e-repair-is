Imports System.IO
Imports Guna.UI2.WinForms
Imports Mysqlx.Expr

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
    Public Function SaveImgToLocal(sourceFilePath As String, folderName As String, commit As Boolean) As String

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

        Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)

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

            dgv.DataSource = dt.DefaultView.ToTable()
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

    Public Sub FormatDGVForAddedBy(dgv As DataGridView)
        If Not dgv.Columns.Contains("ADDED_BY_NAME") Then
            dgv.Columns.Add("ADDED_BY_NAME", "Added By")
        End If

        Try
            If dgv.Columns.Contains("ADDED_BY_NAME") Then
                For Each row As DataGridViewRow In dgv.Rows
                    If row.Cells("ADDED_BY").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ADDED_BY").Value) Then
                        Dim getEmpData As DataTable = dbHelper.GetRowByValue("employees", "employee_id", row.Cells("ADDED_BY").Value)
                        If getEmpData.Rows.Count > 0 Then row.Cells("ADDED_BY_NAME").Value = getEmpData.Rows(0)("firstname") & " " & getEmpData.Rows(0)("lastname")
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox("Unable to format DGV for add by: " & ex.Message)
        End Try
    End Sub

    Public Sub FormatDGVForCustomerName(dgv As DataGridView)

        If Not dgv.Columns.Contains("CUSTOMER_NAME") Then
            dgv.Columns.Add("CUSTOMER_NAME", "Customer Name")
        End If

        If dgv.Columns.Contains("CUSTOMER_NAME") Then
            For Each row As DataGridViewRow In dgv.Rows
                Dim customerId = row.Cells("CUSTOMER_ID").Value
                If customerId IsNot Nothing Then
                    Dim getCustData As DataTable = dbHelper.GetRowByValue("customers", "customer_id", customerId)
                    If getCustData IsNot Nothing AndAlso getCustData.Rows.Count > 0 Then
                        Dim firstName As String = getCustData.Rows(0)("first_name").ToString()
                        Dim lastName As String = getCustData.Rows(0)("last_name").ToString()
                        row.Cells("CUSTOMER_NAME").Value = firstName & " " & lastName
                    End If
                End If
            Next
        End If

    End Sub
    ' Load dgv
    Public Sub LoadToDGV(dgv As DataGridView, dt As DataTable, showChkBox As CheckBox, searchValues() As String, searchIndex As Integer, Optional searchTerm As String = "")
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            dt = SearchFunction(dt, searchTerm, searchValues, searchIndex)
        End If

        If dt.Columns.Contains("archived") Then
            With dt.DefaultView
                If showChkBox.Checked Then
                    .RowFilter = "archived = True"
                Else
                    .RowFilter = "archived = False"
                End If
            End With
        End If

        If dt.Columns.Contains("job_type") Then
            With dt.DefaultView
                If showChkBox.Checked Then
                    .RowFilter = "archived = True AND job_type <> 'Super Admin'"
                Else
                    .RowFilter = "archived = False AND job_type <> 'Super Admin'"
                End If
            End With
        End If

        dgv.RowTemplate.Height = 25
        dgv.AutoGenerateColumns = False
        dgv.DataSource = dt
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

    Public Sub InitSelectMode(selectMode As Boolean, selectBtn As Guna2Button, closeBtn As Guna2Button, archiChk As CheckBox)
        If selectMode Then
            selectBtn.Visible = True
            closeBtn.Visible = True
            archiChk.Visible = False
        Else
            selectBtn.Visible = False
            closeBtn.Visible = False
            archiChk.Visible = True
        End If
    End Sub

    Public Function getCustomerName(customerID As Integer) As String
        Dim getCustDt As DataTable = dbHelper.GetRowByValue("customers", "customer_id", customerID)

        If getCustDt.Rows.Count = 0 Then Return Nothing

        With getCustDt.Rows(0)
            Return .Item("first_name") & " " & .Item("last_name")
        End With

        Return Nothing
    End Function

    Public Function getEmployeeName(empID As Integer) As String
        Dim dt As DataTable = dbHelper.GetRowByValue("employees", "employee_id", empID)

        If dt.Rows.Count = 0 Then Return Nothing

        With dt.Rows(0)
            Return .Item("firstname") & " " & .Item("lastname")
        End With

        Return Nothing
    End Function

    Public Function getTechStatsNumbers(status As String, techID As Integer) As Integer
        Return dbHelper.GetRowByTwoValues("services", "technician_id", techID, "service_status", status).Rows.Count
    End Function

    Public Function getCustStatusNumber(status As String, customerID As Integer) As Integer
        Return dbHelper.GetRowByTwoValues("services", "customer_id", customerID, "service_status", status).Rows.Count
    End Function

    ' show modal
    Public Function ShowModalWithHandler(Of T As {Form, New}, TResult)(
        createModal As Func(Of Object, T),
        selectedID As Object,
        Optional getResult As Func(Of T, TResult) = Nothing) As TResult

        Dim modalForm As T = Nothing
        Dim backgroundForm As Form = Nothing
        Dim result As TResult = Nothing

        Try
            backgroundForm = CreateBgFormModal()

            modalForm = createModal.Invoke(selectedID)
            modalForm.ShowDialog()

            If getResult IsNot Nothing Then
                result = getResult.Invoke(modalForm)
            End If

        Catch ex As Exception
            MsgBox("Unable to show modal: " & ex.Message)
            If backgroundForm IsNot Nothing Then backgroundForm.Close()
            If modalForm IsNot Nothing Then modalForm.Close()
        Finally
            If modalForm IsNot Nothing Then modalForm.Dispose()
            If backgroundForm IsNot Nothing Then backgroundForm.Dispose()
        End Try

        Return result
    End Function


    ' Add Row
    Public Function AddRow(dbTable As String, ByVal payload As Dictionary(Of String, Object),
                           Optional startCheckIndex As Integer = 0,
                           Optional imgData As List(Of String) = Nothing) As Boolean
        ' Exit if canceled
        If Not (ShowMessageBoxResult("Confirmation", "Are you sure you want to add this data")) Then Return False

        ' Check if imgData is provided and has sufficient data
        If imgData IsNot Nothing AndAlso imgData.Count = 3 Then
            Dim imgColName As String = imgData(0)
            Dim imgPath As String = imgData(1)
            Dim imgFolderName As String = imgData(2)

            If Not String.IsNullOrEmpty(imgPath) AndAlso Not String.IsNullOrEmpty(imgFolderName) Then
                If Not File.Exists(imgPath) Then
                    payload.Add(imgColName, imgPath)
                    SaveImgToLocal(imgPath, imgFolderName, True)
                End If
            End If
        End If

        If dbHelper.InsertRecord(dbTable, payload) Then
            MsgBox("Successfully Added")
            Return True
        End If

        MsgBox("Unable to edit this row")
        Return False
    End Function

    ' Edit Row
    Public Function EditRow(dbTable As String, targetID As Integer, targetColumn As String, payload As Dictionary(Of String, Object),
                          Optional startCheckIndex As Integer = 0,
                          Optional imgData As List(Of String) = Nothing) As Boolean
        ' Exit if canceled
        If Not (ShowMessageBoxResult("Confirmation", "Are you sure you want to edit data")) Then Return False

        If Not AreAllValuesFilled(payload) Then Return False

        ' Check if imgData is provided and has sufficient data
        If imgData IsNot Nothing AndAlso imgData.Count = 3 Then
            Dim imgColName As String = imgData(0)
            Dim imgPath As String = imgData(1)
            Dim imgFolderName As String = imgData(2)

            If Not String.IsNullOrEmpty(imgPath) AndAlso Not String.IsNullOrEmpty(imgFolderName) Then
                If Not File.Exists(imgPath) Then
                    payload.Add(imgColName, imgPath)
                    SaveImgToLocal(imgPath, imgFolderName, True)
                End If
            End If
        End If

        If dbHelper.UpdateRecord(dbTable, targetID, targetColumn, payload) Then
            MsgBox("Successfully Edited")
            Return True
        End If

        MsgBox("Unable to edit this row")
        Return False
    End Function


    ' Archive Row
    Public Sub ArchiveRow(archivedStatus As Boolean, tableName As String, columnName As String, targetID As Integer)

        If archivedStatus Then
            MsgBox("This row is already archived!")
            Exit Sub
        End If

        If Not ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this row?") Then Exit Sub

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", Current.id},
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

    Public Sub DeleteRow(archivedStatus As Boolean, tableName As String, columnName As String, targetID As Integer)

        If Not archivedStatus Then
            MsgBox("Archive the row first")
            Exit Sub
        End If

        If Not ShowMessageBoxResult("Confirmation", "Are you sure you want to delete this row") Then Exit Sub

        If dbHelper.DeleteRowByID(tableName, columnName, targetID) Then MsgBox("Successfully Deleted")
    End Sub

    ' Save
    Public Sub SaveEvent(editMode As Boolean, addFunction As Func(Of Boolean), editFunction As Func(Of Boolean))
        Try
            Cursor.Current = Cursors.WaitCursor

            If editMode Then
                addFunction.Invoke()
            Else
                editFunction.Invoke()
            End If

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Failed to save / edit row: " & ex.Message)
        End Try
    End Sub
End Class
