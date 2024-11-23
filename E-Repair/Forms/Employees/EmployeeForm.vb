Public Class EmployeeForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form

    ' SCHEMA
    Dim employeeID As Integer = -1
    Dim empArchived As Boolean = False

    Public Property selectedEmpID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property empDT As DataTable = dbHelper.GetAllRowsFromTable("employees", True)

    ' INIT DATA
    Private Function InitData() As Boolean
        If Not formUtils.dgvValChecker(EmpDGV) Then Return False

        With EmpDGV.CurrentRow
            employeeID = .Cells("EMPLOYEE_ID").Value
            empArchived = .Cells("ARCHIVED").Value
        End With

        Return True
    End Function

    ' VIEW
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewEmployeeBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeViewModal()
            modal.selectedID = id
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )
    End Sub

    ' ADD
    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
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

    ' EDIT
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditEmployeeBtn.Click

        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New EmployeeAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        employeeID,
        Function(modal)
            Return Nothing
        End Function
        )

        LoadDataToDGV()
    End Sub

    'ARCHIVE
    Private Sub BtnArchive_Click(sender As Object, e As EventArgs) Handles ArchiveEmployeeBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.archiveRow(empArchived, "employees", "employee_id", employeeID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.delRow(empArchived, "employees", "employee_id", employeeID)
        LoadDataToDGV()
    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
        formUtils.FormatChkBoxForArchive(EmpDGV, ShowArchiveCheckBox, DeleteEmployeeBtn, ArchiveEmployeeBtn, EditEmployeeBtn, AddEmployeeBtn)
    End Sub

    ' LOAD FORM
    Private Sub AdminEmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        EmpDGV.ClearSelection()
        formUtils.InitSelectMode(selectMode, BtnSelect, BtnClose, ShowArchiveCheckBox)
    End Sub

    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        Dim searchValues() As String = {
           "firstname",
           "middlename",
           "lastname",
           "date_hired",
           "email",
           "last_accessed",
           "date_added"
        }

        formUtils.LoadToDGV(EmpDGV, empDT, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex, searchTerm)
        formUtils.FormatDGVForArchive(EmpDGV)
        formUtils.FormatDGVForAddBy(EmpDGV)
    End Sub

    ' BTN CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' BTN SELECT
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Not InitData() Then Exit Sub

        selectedEmpID = employeeID

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub
End Class