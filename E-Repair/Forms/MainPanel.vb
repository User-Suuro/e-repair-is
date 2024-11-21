Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms.Suite

Public Class MainPanel
    Dim constants As New Constants()
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim session As New Session

    Private Sub AdminMainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminTopNavTitle.Text = constants.DashboardTitle

        ' READ SESSION VALUES
        Try
            AdminTopNavUsernameLabel.Text = GlobalSession.CurrentSession.FirstName + " " + GlobalSession.CurrentSession.LastName
            TopNavPositionLabel.Text = GlobalSession.CurrentSession.JobType

            Dim imgPath = GlobalSession.CurrentSession.ProfilePath

            If File.Exists(imgPath) Then
                AdminTopNavProfilePictureBox.Image = Image.FromFile(imgPath)
            End If

            formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
        Catch ex As Exception
            MsgBox("Cannot get session value to load the main panel: " & ex.Message)
        End Try

        ' load the form depends on posisiton



    End Sub

    ' FUNCTIONS FOR NAVIGATION

    Private Sub SidenavDashboardBtn_Click(sender As Object, e As EventArgs) Handles SidenavDashboardBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
        AdminTopNavTitle.Text = constants.DashboardTitle
    End Sub

    Private Sub SidenavEmployeesBtn_Click(sender As Object, e As EventArgs) Handles SidenavEmployeesBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New EmployeeForm)
        AdminTopNavTitle.Text = constants.EmployeesTitle
    End Sub

    Private Sub AdminSidenavCustomersBtn_Click(sender As Object, e As EventArgs) Handles SidenavCustomersBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminCustomerForm)
        AdminTopNavTitle.Text = constants.getCustomerTitle
    End Sub

    Private Sub SidenavServicesBtn_Click(sender As Object, e As EventArgs) Handles SidenavServicesBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New ServiceForm)
        AdminTopNavTitle.Text = constants.ServicesTitle
    End Sub

    Private Sub SidenavSuppliersBtn_Click(sender As Object, e As EventArgs) Handles SidenavSuppliersBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New SuppliersForm)
        AdminTopNavTitle.Text = constants.SuppliersTitle
    End Sub


    Private Sub AdminSidenavInventoryBtn_Click(sender As Object, e As EventArgs) Handles SidenavInventoryBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New InventoryForm)
        AdminTopNavTitle.Text = constants.InventoryTitle
    End Sub

    Private Sub AdminSideNavCustomerBtn_Click(sender As Object, e As EventArgs)
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New SettingsForm)
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
