Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms.Suite

Public Class MainPanel
    Dim constants As New Constants
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim empConst As New EmployeesDBConstants

    Private position As String = Nothing
    Private username As String = Nothing

    Private Sub AdminMainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        position = Current.position
        username = Current.name

        If File.Exists(Current.profilePath) Then
            AdminTopNavProfilePictureBox.Image = Image.FromFile(Current.profilePath)
        Else
            MsgBox("Unable to find profile")
        End If

        dashboardHandler()
        sideNavHandler()
        topNavHandler()
        dashboardHandler()
    End Sub

    Private Sub topNavHandler()
        AdminTopNavTitle.Text = constants.DashboardTitle
        AdminTopNavUsernameLabel.Text = username
        TopNavPositionLabel.Text = position
    End Sub

    Private Sub sideNavHandler()
        With constants
            Select Case position
                Case .getSuperAdminString
                    SettingsBtn.Visible = True
                    SidenavInventoryBtn.Visible = True
                    SidenavSuppliersBtn.Visible = True
                    SidenavServicesBtn.Visible = True
                    SidenavCustomersBtn.Visible = True
                    SidenavEmployeesBtn.Visible = True

                Case .getAdminString
                    SidenavInventoryBtn.Visible = True
                    SidenavSuppliersBtn.Visible = True
                    SidenavServicesBtn.Visible = True
                    SidenavCustomersBtn.Visible = True
                    SidenavEmployeesBtn.Visible = True

                Case .getCashierString
                    SidenavServicesBtn.Visible = True
                    SidenavCustomersBtn.Visible = True

                Case .getTechnicianString
                    SidenavCustomersBtn.Visible = True
                    SidenavInventoryBtn.Visible = True
                    SidenavServicesBtn.Visible = True
            End Select
        End With

    End Sub

    Private Sub dashboardHandler()
        With constants
            Select Case position
                Case .getAdminString
                    formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New AdminDashboardForm)
                Case .getSuperAdminString
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
    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        formUtils.LoadFormIntoPanel(Me.AdminContentPanel, New SettingsForm)
        AdminTopNavTitle.Text = constants.SettingsTitle
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
    End Sub

    Private Sub AdminMainPanel_Close(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LoggedUser.ClearSession()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class
