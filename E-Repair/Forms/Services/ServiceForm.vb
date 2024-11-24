
Public Class ServiceForm
    Dim dbHelper As New DbHelper
    Dim formModal As New Form
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Private serviceID As Integer = -1
    Private is_archived As Boolean = False
    Private currentEmpPos = GlobalSession.CurrentSession.JobType

    Private Function InitData() As Boolean
        If Not formUtils.dgvValChecker(ServiceDGV) Then Return False

        ' INITIALIZE VALUES
        With ServiceDGV.CurrentRow
            serviceID = .Cells("SERVICE_ID").Value
            is_archived = .Cells("ARCHIVED").Value
        End With

        Return True
    End Function

    ' FORM ONLOAD
    Private Sub ServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDGV()
        loadUserDisplay()
    End Sub

    Private Sub loadUserDisplay()
        Select Case currentEmpPos
            Case constants.getSuperAdminString
                ClaimServiceBtn.Visible = True
                EvaluateServiceBtn.Visible = True
            Case constants.getCashierString
                ClaimServiceBtn.Visible = True
                ArchiveServiceBtn.Visible = False
                DeleteServiceBtn.Visible = False
            Case constants.getTechnicianString
                AddServiceBtn.Visible = False
                EvaluateServiceBtn.Visible = False
        End Select
    End Sub

    ' CLAIM
    Private Sub ClaimServiceBtn_Click(sender As Object, e As EventArgs) Handles ClaimServiceBtn.Click
        If Not InitData() Then Exit Sub

        ' DO ADDITIONAL CHECKERS FOR CLAIMING


    End Sub

    ' EVALUATE
    Private Sub EvaluateServiceBtn_Click(sender As Object, e As EventArgs) Handles EvaluateServiceBtn.Click
        If Not InitData() Then Exit Sub

        ' DO ADDITIONAL CHECKERS FOR EVALUATING

    End Sub

    ' VIEW
    Private Sub ViewServiceBtn_Click(sender As Object, e As EventArgs) Handles ViewServiceBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
           Function(id)
               Dim modal As New ServiceViewModal
               modal.selectedID = id
               Return modal
           End Function,
           serviceID,
           Function(modal)
               Return Nothing
           End Function
           )
    End Sub

    ' ADD 
    Private Sub AddServiceBtn_Click(sender As Object, e As EventArgs) Handles AddServiceBtn.Click
        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New ServiceAddEditModal()
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

    Private Sub EditServiceBtn_Click(sender As Object, e As EventArgs) Handles EditServiceBtn.Click
        If Not InitData() Then Exit Sub

        formUtils.ShowModalWithHandler(
        Function(id)
            Dim modal As New ServiceAddEditModal()
            modal.selectedID = id
            modal.editMode = True
            Return modal
        End Function,
        serviceID,
        Function(modal)
            Return Nothing
        End Function)

        LoadDataToDGV 
    End Sub


    ' LOAD DATA
    Private Sub LoadDataToDGV(Optional searchTerm As String = "")

        Dim searchValues() As String = {
            "customer_name",
            "device_model",
            "device_brand",
            "date_added"
        }

        Dim servicesDt = dbHelper.GetAllRowsFromTable("services", True)

        formUtils.LoadToDGV(ServiceDGV, servicesDt, ShowArchiveCheckBox, searchValues, SearchComboBox.SelectedIndex, searchTerm)
        formUtils.FormatDGVForArchive(ServiceDGV)
        ' formUtils.FormatDGVForCustomerName(ServiceDGV)

    End Sub

    ' SEARCH
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        LoadDataToDGV(SearchTextBox.Text)
    End Sub

    ' SHOW ARCHIVE CHECKBOX
    Private Sub ShowArchiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowArchiveCheckBox.CheckedChanged
        LoadDataToDGV()
    End Sub


End Class
