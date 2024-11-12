Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Guna.UI2.WinForms.Suite

Public Class AdminMainPanel
    Dim constants As New Constants()
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim session As New Session

    Private Sub AdminMainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
        AdminTopNavTitle.Text = constants.DashboardTitle

        ' READ SESSION VALUES

        Try
            AdminTopNavUsernameLabel.Text = GlobalSession.CurrentSession.FirstName + " " + GlobalSession.CurrentSession.LastName
            AdminTopNavPositionLabel.Text = GlobalSession.CurrentSession.JobType
            AdminTopNavProfilePictureBox.Image = Image.FromFile(GlobalSession.CurrentSession.ProfilePath)
        Catch ex As Exception
            AdminTopNavProfilePictureBox.Image = Image.FromFile(constants.getNoImgPath)
        End Try
    End Sub


    ' FUNCTIONS FOR NAVIGATION

    Private Sub SidenavDashboardBtn_Click(sender As Object, e As EventArgs) Handles AdminSidenavDashboardBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
        AdminTopNavTitle.Text = constants.DashboardTitle
    End Sub

    Private Sub SidenavEmployeesBtn_Click(sender As Object, e As EventArgs) Handles AdminSidenavEmployeesBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminEmployeesForm)
        AdminTopNavTitle.Text = constants.EmployeesTitle
    End Sub

    Private Sub SidenavServicesBtn_Click(sender As Object, e As EventArgs) Handles AdminSidenavServicesBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminServicesForm)
        AdminTopNavTitle.Text = constants.ServicesTitle
    End Sub

    Private Sub SidenavSuppliersBtn_Click(sender As Object, e As EventArgs) Handles AdminSidenavSuppliersBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminSuppliersForm)
        AdminTopNavTitle.Text = constants.SuppliersTitle
    End Sub


    Private Sub AdminSidenavInventoryBtn_Click(sender As Object, e As EventArgs) Handles AdminSidenavInventoryBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminInventoryForm)
        AdminTopNavTitle.Text = constants.InventoryTitle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdminTopNavSettingsBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminSettingsForm)
        AdminTopNavTitle.Text = constants.SettingsTitle
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
    End Sub

    Private Sub AdminMainPanel_Close(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GlobalSession.ClearSession()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub


End Class
