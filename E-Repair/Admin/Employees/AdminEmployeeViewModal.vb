Public Class AdminEmployeeViewModal
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Private Sub AdminViewEmployeeModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManageJobDescriptionView()
    End Sub

    Private Sub ManageJobDescriptionView()
        AdminDescriptionPanel.Visible = False
        TechnicianDescriptionPanel.Visible = False
        CashierDescriptionPanel.Visible = False
        PersonnelDescriptionPanel.Visible = False

        If JobTypeTextBox.Text = constants.getAdminString Then
            JobDescriptionFlowLayout.Visible = True
            AdminDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getTechnicianString Then
            JobDescriptionFlowLayout.Visible = True
            TechnicianDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getCashierString Then
            JobDescriptionFlowLayout.Visible = True
            CashierDescriptionPanel.Visible = True

        ElseIf JobTypeTextBox.Text = constants.getUtilityPersonnelString Then
            JobDescriptionFlowLayout.Visible = True
            PersonnelDescriptionPanel.Visible = True
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class