Public Class EmployeeForm
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants
    Dim formModal As Form
    Dim empConst As New EmployeesDBConstants

    ' SCHEMA
    Dim employeeID As Integer = -1
    Dim empArchived As Boolean = False

    Public Property selectedEmpID As Integer = -1
    Public Property selectMode As Boolean = False
    Public Property empPosition As String = ""
    Public Property empDT As DataTable

    ' INIT DATA
    Private Function InitData() As Boolean

        If Not formUtils.dgvValChecker(EmpDGV) Then Return False

        With EmpDGV.CurrentRow
            employeeID = .Cells("EMPLOYEE_ID").Value
            empArchived = .Cells("ARCHIVED").Value
            empPosition = .Cells("JOB_TYPE").Value
        End With

        Return True
    End Function

    Private Function restrictUser() As Boolean
        If empPosition = constants.getSuperAdminString AndAlso empPosition = constants.getAdminString Then
            MsgBox("Restricted Action")
        End If

        Return False
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
            LoadDataToDGV()
            Return Nothing
        End Function
        )
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
        formUtils.ArchiveRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID)
        LoadDataToDGV()
    End Sub

    ' DELETE
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If Not InitData() Then Exit Sub
        formUtils.DeleteRow(empArchived, empConst.empTableStr, empConst.empIDStr, employeeID)
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
        With empConst
            Dim searchValues() As String = {
              .empFirstStr,
              .empMidStr,
              .empLastStr,
              .empHiredStr,
              .empEmailStr,
              .empLastAccessedStr,
              .empAddDateStr
            }
            If Not selectMode Then empDT = dbHelper.GetAllData(.empTableStr)
            formUtils.LoadToDGV(EmpDGV, empDT, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex, searchTerm)
        End With

        formUtils.FormatDGVForArchive(EmpDGV)
        ' formUtils.FormatDGVForAddedBy(EmpDGV)
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