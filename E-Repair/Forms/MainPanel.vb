Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms.Suite

Public Class MainPanel
    Dim constants As New Constants()
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim session As New Session

    Private userPosition As String

    Private Sub AdminMainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminTopNavTitle.Text = constants.DashboardTitle

        ' READ SESSION VALUES
        Try
            AdminTopNavUsernameLabel.Text = GlobalSession.CurrentSession.FirstName + " " + GlobalSession.CurrentSession.LastName

            ' SET UP DISPLAY
            userPosition = GlobalSession.CurrentSession.JobType
            TopNavPositionLabel.Text = userPosition

            Dim imgPath = GlobalSession.CurrentSession.ProfilePath

            If File.Exists(imgPath) Then
                AdminTopNavProfilePictureBox.Image = Image.FromFile(imgPath)
            End If

            ' SET UP SIDENAVS
            With constants
                Select Case userPosition
                    Case .getAdminString
                        SidenavCustomersBtn.Visible = True
                        SidenavServicesBtn.Visible = True
                        SidenavSuppliersBtn.Visible = True
                        SidenavInventoryBtn.Visible = True
                    Case .getCashierString
                        SidenavCustomersBtn.Visible = True
                        SidenavServicesBtn.Visible = True
                    Case .getTechnicianString
                        SidenavServicesBtn.Visible = True
                        SidenavInventoryBtn.Visible = True
                End Select
            End With

            formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
        Catch ex As Exception
            MsgBox("Cannot get session value to load the main panel: " & ex.Message)
        End Try

        ' load the form depends on posisiton
        dashboardHandler()
    End Sub
    Private Sub dashboardHandler()
        With constants
            Select Case userPosition
                Case .getAdminString
                    formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
                Case .getCashierString
                    formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New CashierDashboardForm)
                Case .getTechnicianString
                    formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New TechnicianDashboardForm)
            End Select
        End With
    End Sub

    ' FUNCTIONS FOR NAVIGATION

    Private Sub SidenavDashboardBtn_Click(sender As Object, e As EventArgs) Handles SidenavDashboardBtn.Click
        ' Do additional handlers for dashboard
        dashboardHandler()
        AdminTopNavTitle.Text = constants.DashboardTitle
    End Sub

    Private Sub SidenavEmployeesBtn_Click(sender As Object, e As EventArgs) Handles SidenavEmployeesBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New EmployeeForm)
        AdminTopNavTitle.Text = constants.EmployeesTitle
    End Sub

    Private Sub AdminSidenavCustomersBtn_Click(sender As Object, e As EventArgs) Handles SidenavCustomersBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New CustomerForm)
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
