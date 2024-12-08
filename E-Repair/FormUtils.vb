Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.Devices

Public Class FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    Dim empCosnt As New EmployeesDBConstants
    Dim invConst As New InventoryDBConstants
    Dim custConst As New CustomersDBConstants
    Dim servConst As New ServiceDBConstants

    Public Property rowHeight As Integer = 40

    Public Sub LoadFormIntoPanel(targetPanel As Panel, frm As Form)
        If targetPanel.Controls.Count > 0 Then
            targetPanel.Controls.RemoveAt(0)
        End If

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

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



    ' Search function

    ' Format dgv for archive
    Public Sub FormatChkBoxForArchive(dgv As DataGridView, chkbox As CheckBox, delBtn As Button, archBtn As Button, editBtn As Button, addBtn As Button)

        Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)

        Try
            If chkbox.Checked Then

                If Current.position = constants.getAdminString Or Current.position = constants.getSuperAdminString Then
                    delBtn.Visible = True
                End If

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


            FormatDGVForArchive(dgv)

        Catch ex As Exception
            MsgBox("Unable to format checkbox for archive: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDGVForArchive(dgv As DataGridView)
        Try
            For Each row As DataGridViewRow In dgv.Rows

                If row.Cells("ARCHIVED").Value IsNot Nothing AndAlso CBool(row.Cells("ARCHIVED").Value) = True Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Default color
                End If

            Next
        Catch ex As Exception
            MsgBox("Unable to format DGV for archive: " & ex.Message)
        End Try
    End Sub

    ' Load dgv
    Public Sub LoadToDGV(dgv As DataGridView, dt As DataTable,
                      Optional searchTerm As String = Nothing,
                      Optional searchValues As List(Of String) = Nothing,
                      Optional searchIndex As Integer = Nothing,
                      Optional showChkBox As CheckBox = Nothing)

        Try
            Dim filter As String = ""

            ' Handle search
            If searchValues IsNot Nothing Then
                Dim searchBy As String = If(searchIndex >= 0, searchValues(searchIndex), searchValues(0))

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    filter = $"CONVERT([{searchBy}], System.String) LIKE '%{searchTerm}%'"
                End If
            End If

            ' Handle checkbox for archived
            If showChkBox IsNot Nothing AndAlso dt.Columns.Contains("archived") Then
                Dim archivedFilter As String = If(showChkBox.Checked, "archived = True", "archived = False")
                If Not String.IsNullOrWhiteSpace(filter) Then
                    filter &= $" AND {archivedFilter}"
                Else
                    filter = archivedFilter
                End If
            End If

            ' Handle additional "job_type" filtering
            If dt.Columns.Contains(empCosnt.empJobPosStr) Then
                Dim jobTypeFilter As String = $"{empCosnt.empJobPosStr} <> '{constants.getSuperAdminString}'"
                If Not String.IsNullOrWhiteSpace(filter) Then
                    filter &= $" AND {jobTypeFilter}"
                Else
                    filter = jobTypeFilter
                End If
            End If

            dt.DefaultView.RowFilter = filter
            dgv.AutoGenerateColumns = False

            dgv.AllowUserToResizeRows = False
            dgv.AllowUserToResizeColumns = False

            dgv.RowTemplate.Height = rowHeight
            dgv.DataSource = dt.DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadToDGVByTwoValues(dgv As DataGridView, dt As DataTable,
                                 Optional searchTerm As String = Nothing,
                                 Optional secondSearchTerm As String = Nothing,
                                 Optional searchValues1 As List(Of String) = Nothing,
                                 Optional searchValues2 As List(Of String) = Nothing,
                                 Optional searchIndex1 As Integer = -1,
                                 Optional searchIndex2 As Integer = -1,
                                 Optional showChkBox As CheckBox = Nothing
                                )

        Try
            Dim filters As New List(Of String)

            ' Handle the first search term
            If searchValues1 IsNot Nothing AndAlso searchIndex1 >= 0 AndAlso searchIndex1 < searchValues1.Count Then
                Dim searchBy1 As String = searchValues1(searchIndex1)
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    filters.Add($"CONVERT([{searchBy1}], System.String) LIKE '%{searchTerm}%'")
                End If
            End If

            ' Handle the second search term
            If searchValues2 IsNot Nothing AndAlso searchIndex2 >= 0 AndAlso searchIndex2 < searchValues2.Count Then
                Dim searchBy2 As String = searchValues2(searchIndex2)
                If Not String.IsNullOrWhiteSpace(secondSearchTerm) Then
                    filters.Add($"CONVERT([{searchBy2}], System.String) LIKE '%{secondSearchTerm}%'")
                End If
            End If

            ' Handle checkbox for archived
            If showChkBox IsNot Nothing AndAlso dt.Columns.Contains("archived") Then
                Dim archivedFilter As String = If(showChkBox.Checked, "archived = True", "archived = False")
                filters.Add(archivedFilter)
            End If

            ' Handle additional "job_type" filtering
            If dt.Columns.Contains(empCosnt.empJobPosStr) Then
                Dim jobTypeFilter As String = $"{empCosnt.empJobPosStr} <> '{constants.getSuperAdminString}'"
                filters.Add(jobTypeFilter)
            End If

            ' Combine all filters
            Dim combinedFilter As String = String.Join(" AND ", filters)

            ' Apply the combined filter
            dt.DefaultView.RowFilter = combinedFilter

            dgv.AutoGenerateColumns = False
            dgv.RowTemplate.Height = rowHeight
            dgv.DataSource = dt.DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
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
        Dim listCol As New List(Of String) From {
            custConst.custIDStr,
            custConst.custFirstStr,
            custConst.custLastStr
        }

        Dim getCustDt As DataTable = dbHelper.GetRowByColValue(listCol, custConst.custTableStr, custConst.custIDStr, customerID)

        If getCustDt.Rows.Count = 0 Then Return Nothing

        With getCustDt.Rows(0)
            Return .Item(custConst.custFirstStr) & " " & .Item(custConst.custLastStr)
        End With

        Return Nothing
    End Function

    Public Function getEmployeeName(empID As Integer) As String
        Dim listCol As New List(Of String) From {
            empCosnt.empIDStr,
            empCosnt.empFirstStr,
            empCosnt.empLastStr
        }

        Dim dt As DataTable = dbHelper.GetRowByColValue(listCol, empCosnt.empTableStr, empCosnt.empIDStr, empID)

        If dt.Rows.Count = 0 Then Return Nothing

        With dt.Rows(0)
            Return .Item(empCosnt.empFirstStr) & " " & .Item(empCosnt.empLastStr)
        End With

        Return Nothing
    End Function

    Public Function getTechStatsNumbers(status As String, techID As Integer) As Integer
        Dim listCol As New List(Of String) From {
            servConst.techIDStr,
            servConst.svcStatusStr
        }

        Return dbHelper.GetRowByColWTwoVal(listCol, servConst.svcTableStr, servConst.techIDStr, techID, servConst.svcStatusStr, status).Rows.Count
    End Function

    Public Function getCustStatusNumber(status As String, customerID As Integer) As Integer

        Dim listCol As New List(Of String) From {
            servConst.custIDStr,
            servConst.svcStatusStr
        }

        Return dbHelper.GetRowByColWTwoVal(listCol, servConst.svcTableStr, servConst.custIDStr, customerID, servConst.svcStatusStr, status).Rows.Count

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

    ' VALUE CHECKERS
    Public Function AreAllDictValuesFilled(values As Dictionary(Of String, Object), Optional startingIndex As Integer = 0) As Boolean
        For i As Integer = startingIndex To values.Count - 1
            Dim kvp As KeyValuePair(Of String, Object) = values.ElementAt(i) ' Access key-value pair by index
            If kvp.Value Is Nothing OrElse kvp.Value.ToString().Trim() = "" OrElse kvp.Value.ToString() = "-1" Then
                MsgBox("Please fill all necessary details")
                Return False
            End If
        Next

        Return True
    End Function

    Public Function AreAllListValuesFilled(values As List(Of Object), Optional startingIndex As Integer = 0) As Boolean

        For i As Integer = startingIndex To values.Count - 1
            Dim value As Object = values(i) ' Access value by index
            If value Is Nothing OrElse value.ToString().Trim() = "" OrElse value.ToString() = "-1" Then
                MsgBox("Please fill all necessary details")
                Return False
            End If
        Next

        Return True
    End Function

    ' Add Row
    Public Function AddRow(dbTable As String, ByVal payload As Dictionary(Of String, Object),
                           Optional startCheckIndex As Integer = 0,
                           Optional imgData As List(Of Object) = Nothing) As Boolean
        ' Exit if canceled
        If Not (ShowMessageBoxResult("Confirmation", "Are you sure you want to add this data")) Then Return False

        If Not AreAllDictValuesFilled(payload, startCheckIndex) Then Return False

        ' Check if imgData is provided and has sufficient data
        If imgData IsNot Nothing Then

            If Not AreAllListValuesFilled(imgData) Then Return False

            Dim imgColName As String = imgData(0)
            Dim imgPath As String = imgData(1)
            Dim imgFolderName As String = imgData(2)

            If Not String.IsNullOrEmpty(imgPath) AndAlso Not String.IsNullOrEmpty(imgFolderName) Then

                Dim savedPath = SaveImgToLocal(imgPath, imgFolderName, True)
                payload.Add(imgColName, savedPath)

            End If
        End If


        If dbHelper.InsertRecord(dbTable, payload) Then
            MsgBox("Successfully Added")
            Return True
        End If

        MsgBox("Unable to add this row")
        Return False
    End Function

    ' Edit Row
    Public Function EditRow(dbTable As String, targetColumn As String, targetID As Integer, payload As Dictionary(Of String, Object),
                          Optional startCheckIndex As Integer = 0,
                          Optional imgData As List(Of Object) = Nothing) As Boolean
        If Not (ShowMessageBoxResult("Confirmation", "Are you sure you want to modify data")) Then Return False

        If Not AreAllDictValuesFilled(payload, startCheckIndex) Then Return False

        If imgData IsNot Nothing Then
            If Not AreAllListValuesFilled(imgData) Then Return False

            Dim imgColName As String = imgData(0)
            Dim imgPath As String = imgData(1)
            Dim imgFolderName As String = imgData(2)

            If Not String.IsNullOrEmpty(imgPath) AndAlso Not String.IsNullOrEmpty(imgFolderName) Then

                Dim savedPath = SaveImgToLocal(imgPath, imgFolderName, True)
                payload.Add(imgColName, savedPath)

            End If
        End If

        If dbHelper.UpdateRecord(dbTable, targetColumn, targetID, payload) Then
            MsgBox("Successfully Modified")
            Return True
        End If

        MsgBox("Unable to edit this row")
        Return False
    End Function


    ' Archive Row
    Public Sub ArchiveRow(archivedStatus As Boolean, tableName As String, columnName As String, targetID As Integer, Optional ByPassMsg As Boolean = False)

        If archivedStatus Then
            MsgBox("This row is already archived!")
            Exit Sub
        End If

        Dim updatedValues As New Dictionary(Of String, Object) From {
            {"archived", True},
            {"archived_by", getEmployeeName(Current.id)},
            {"archived_by_id", Current.id},
            {"date_archived", DateTime.Now}
        }

        If ByPassMsg Then
            dbHelper.UpdateRecord(tableName, columnName, targetID, updatedValues)
            Exit Sub
        End If

        If Not ShowMessageBoxResult("Confirmation", "Are you sure you want to archive this row?") Then Exit Sub

        Try
            If dbHelper.UpdateRecord(tableName, columnName, targetID, updatedValues) Then
                MsgBox("Successfull Archived")
            End If


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
    Public Sub SaveEvent(editMode As Boolean, addFunction As Action, editFunction As Action)
        Try

            If editMode Then
                editFunction.Invoke()
            Else
                addFunction.Invoke()
            End If

        Catch ex As Exception
            MsgBox("Failed to save / edit row: " & ex.Message)
        End Try
    End Sub


    Public Function checkIfLoad(selectedID As Integer) As Boolean

        If selectedID = -1 Then
            MsgBox("You cannot modify this row without active value")
            Return False
        End If

        Return True
    End Function

    Public Function calcDecimalDTCol(dt As DataTable, columnName As String) As Decimal

        Try
            Return dt.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)(columnName))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function CalcIntegerDTCol(dt As DataTable, columnName As String) As Integer
        Try
            Return dt.AsEnumerable().Sum(Function(row) row.Field(Of Integer)(columnName))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function GetSuppliedItems(supplierID As Integer) As Integer
        Dim invSuppDT As DataTable = dbHelper.GetRowByColValue(New List(Of String) From {invConst.supIDStr, invConst.invIDStr, invConst.availableQtyStr}, invConst.invTableStr, invConst.supIDStr, supplierID)
        Return CalcIntegerDTCol(invSuppDT, invConst.availableQtyStr)
    End Function

    Public Function GetTotalPaid(supplierID As Integer) As Integer
        Dim invSuppDT As DataTable = dbHelper.GetRowByColValue(New List(Of String) From {invConst.supIDStr, invConst.invIDStr, invConst.totalCostStr}, invConst.invTableStr, invConst.supIDStr, supplierID)
        Return calcDecimalDTCol(invSuppDT, invConst.totalCostStr)
    End Function

    Public Function FilterDataTable(ByVal sourceTable As DataTable, ByVal filterExpression As String, Optional ByVal sortOrder As String = "") As DataTable
        Dim filteredRows As DataRow() = sourceTable.Select(filterExpression, sortOrder)

        If filteredRows.Any() Then
            Return filteredRows.CopyToDataTable()
        Else
            Return sourceTable.Clone()
        End If
    End Function

    ' Decimal Validator
    Public Function ValidateDecimalInput(txtBox As Guna2TextBox, e As KeyPressEventArgs) As Boolean
        If Char.IsControl(e.KeyChar) Then
            Return True ' Allow the keypress
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            Return False
        End If

        If e.KeyChar = "." Then
            If txtBox.Text.Contains(".") Then
                Return False
            End If
        End If

        If txtBox.Text.Contains(".") Then
            Dim decimalPointIndex As Integer = txtBox.Text.IndexOf(".")
            Dim decimalsAfterPoint As String = txtBox.Text.Substring(decimalPointIndex + 1)

            If decimalsAfterPoint.Length >= 2 Then
                Return False
            End If
        End If

        Return True
    End Function

    ' Integer Validator

    Public Function ValidateIntegerInput(txtBox As Guna2TextBox, e As KeyPressEventArgs) As Boolean
        If Char.IsControl(e.KeyChar) Then
            Return True ' Allow the keypress
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            Return False
        End If


        Return True
    End Function

    Public Function GetLatestIDInDT(dataTable As DataTable, idColumnName As String) As Integer
        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            Return dataTable.AsEnumerable().
                    Where(Function(row) Not IsDBNull(row(idColumnName))).
                    Max(Function(row) Convert.ToInt32(row(idColumnName)))
        Else
            Return 0 ' Return 0 or any default value if the table is empty
        End If
    End Function

    Function GetDictKey(columnHeaderMapping As Dictionary(Of String, String)) As List(Of String)
        Dim resultList As New List(Of String)
        For Each kvp In columnHeaderMapping
            resultList.Add($"{kvp.Key}")
        Next

        Return resultList
    End Function

    Function GetDictValues(columnHeaderMapping As Dictionary(Of String, String)) As List(Of String)
        Dim resultList As New List(Of String)

        For Each kvp In columnHeaderMapping
            resultList.Add($"{kvp.Value}")
        Next

        Return resultList
    End Function

    Public Function FormatSingleDateColumn(dt As DataTable, columnName As String, format As String) As DataTable
        Dim updatedDT As DataTable = dt.Copy() ' Create a copy to preserve the original
        For Each row As DataRow In updatedDT.Rows
            If Not IsDBNull(row(columnName)) Then
                Dim originalDate As DateTime = Convert.ToDateTime(row(columnName))
                row(columnName) = originalDate.ToString(format)
            End If
        Next
        Return updatedDT
    End Function

    Public Function GetDaysInMonthList(year As Integer, month As Integer) As List(Of Integer)
        Try
            If month < 1 OrElse month > 12 Then
                MsgBox(NameOf(month), "Month must be between 1 and 12.")
                Return Nothing
            End If

            Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)

            Dim daysList As New List(Of Integer)

            For day As Integer = 1 To daysInMonth
                daysList.Add(day)
            Next

            Return daysList
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Function FilterDates(dt As DataTable, dateStart As Date, dateStop As Date, format As String, dateCol As String) As DataTable

        If dateStart > dateStop Then
            MsgBox("'dateStart' must be earlier than or equal to 'dateStop'.")
            Return Nothing
        End If

        Dim formattedDateStart As String = dateStart.ToString(format)
        Dim formattedDateStop As String = dateStop.ToString(format)

        Dim filteredRows As DataRow() = dt.Select($"{dateCol} >= #{formattedDateStart}# AND {dateCol} <= #{formattedDateStop}#")
        Dim filteredTable As DataTable = dt.Clone()

        For Each row As DataRow In filteredRows
            filteredTable.ImportRow(row)
        Next

        Return filteredTable

    End Function

    Public Sub formatChart(ByVal myChart As Chart, ByVal series As Series, Optional title As String = "", Optional chartAreaType As String = "Default")
        With myChart
            .Series.Clear()
            .Titles.Clear()
            .ChartAreas.Clear()

            Dim chartArea As New ChartArea(chartAreaType)
            .ChartAreas.Add(chartArea)

            .Series.Add(series)
            .Titles.Add(title)

            .Invalidate()
        End With
    End Sub

    ' FILTER DAYS CONTROLS

    Public Sub reloadDayStop(ByVal DayStartCmb, ByVal DayStopCmb)
        If DayStartCmb.SelectedItem > DayStopCmb.SelectedItem Then
            DayStopCmb.SelectedIndex = FindComboBoxItemByText(DayStopCmb, DayStartCmb.SelectedItem)
        End If
    End Sub

    Public Sub reloadDayStart(ByVal DayStartCmb, ByVal DayStopCmb)
        If DayStopCmb.SelectedItem < DayStartCmb.SelectedItem Then
            DayStartCmb.SelectedIndex = FindComboBoxItemByText(DayStartCmb, DayStopCmb.SelectedItem)
        End If
    End Sub

    ' FILTER CONTROLS VALUE CHECKER

    Public Function hasDayCmbValue(ByVal DayStartCmb, ByVal DayStopCmb)
        If DayStartCmb.SelectedItem IsNot Nothing AndAlso DayStopCmb.SelectedItem IsNot Nothing Then
            Return True
        End If

        Return False
    End Function

    Public Function hasYrMonthCmbValue(ByVal YearCmb, ByVal MonthCmb) As Boolean
        If YearCmb.SelectedItem IsNot Nothing AndAlso MonthCmb.SelectedItem IsNot Nothing Then
            Return True
        End If

        Return False
    End Function

    Public Sub InitYearMonthCmb(ByVal YearCmb, ByVal MonthCmb)

        With YearCmb
            .DataSource = constants.getYearList
            .BeginUpdate()
            .SelectedIndex = 0
            .EndUpdate()
        End With

        With MonthCmb
            .DataSource = constants.getMonthList
            .BeginUpdate()
            .SelectedIndex = FindComboBoxItemByText(MonthCmb, DateTime.Now.ToString("MMMM"))
            .EndUpdate()
        End With

    End Sub

    Public Sub InitDayToEndCmb(ByVal DayStartCmb, ByVal DayStopCmb, ByVal YearCmb, ByVal MonthCmb)

        Dim daysStart = GetDaysInMonthList(YearCmb.SelectedItem, MonthCmb.SelectedIndex + 1)
        Dim daysEnd = GetDaysInMonthList(YearCmb.SelectedItem, MonthCmb.SelectedIndex + 1)


        With DayStartCmb
            .DataSource = daysStart
            .SelectedIndex = 0
        End With

        With DayStopCmb
            .DataSource = daysEnd
            .SelectedIndex = daysEnd.Count - 1
        End With

    End Sub

End Class
