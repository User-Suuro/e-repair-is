<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AdminSidenavPanel = New System.Windows.Forms.Panel()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.SidenavInventoryBtn = New System.Windows.Forms.Button()
        Me.SidenavSuppliersBtn = New System.Windows.Forms.Button()
        Me.SidenavServicesBtn = New System.Windows.Forms.Button()
        Me.SidenavCustomersBtn = New System.Windows.Forms.Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.SidenavEmployeesBtn = New System.Windows.Forms.Button()
        Me.SidenavDashboardBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminTopNavPanel = New System.Windows.Forms.Panel()
        Me.AdminProfilePanel = New System.Windows.Forms.Panel()
        Me.AdminTopNavProfilePictureBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TopNavPositionLabel = New System.Windows.Forms.Label()
        Me.AdminTopNavUsernameLabel = New System.Windows.Forms.Label()
        Me.AdminTopNavTitle = New System.Windows.Forms.Label()
        Me.AdminContentPanel = New System.Windows.Forms.Panel()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.AdminTopNavPanel.SuspendLayout()
        Me.AdminProfilePanel.SuspendLayout()
        CType(Me.AdminTopNavProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminSidenavPanel
        '
        Me.AdminSidenavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AdminSidenavPanel.Controls.Add(Me.SettingsBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavInventoryBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavSuppliersBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavServicesBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavCustomersBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.Guna2Separator1)
        Me.AdminSidenavPanel.Controls.Add(Me.LogoutBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavEmployeesBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.SidenavDashboardBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.Panel2)
        Me.AdminSidenavPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AdminSidenavPanel.Location = New System.Drawing.Point(0, 0)
        Me.AdminSidenavPanel.Name = "AdminSidenavPanel"
        Me.AdminSidenavPanel.Size = New System.Drawing.Size(82, 681)
        Me.AdminSidenavPanel.TabIndex = 23
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsBtn.FlatAppearance.BorderSize = 0
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SettingsBtn.Image = Global.E_Repair.My.Resources.Resources.gear_bold
        Me.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SettingsBtn.Location = New System.Drawing.Point(0, 450)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SettingsBtn.Size = New System.Drawing.Size(82, 75)
        Me.SettingsBtn.TabIndex = 25
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SettingsBtn.UseVisualStyleBackColor = True
        Me.SettingsBtn.Visible = False
        '
        'SidenavInventoryBtn
        '
        Me.SidenavInventoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavInventoryBtn.FlatAppearance.BorderSize = 0
        Me.SidenavInventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavInventoryBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavInventoryBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavInventoryBtn.Image = Global.E_Repair.My.Resources.Resources.package_bold
        Me.SidenavInventoryBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavInventoryBtn.Location = New System.Drawing.Point(0, 375)
        Me.SidenavInventoryBtn.Name = "SidenavInventoryBtn"
        Me.SidenavInventoryBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavInventoryBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavInventoryBtn.TabIndex = 24
        Me.SidenavInventoryBtn.Text = "Inventory"
        Me.SidenavInventoryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavInventoryBtn.UseVisualStyleBackColor = True
        Me.SidenavInventoryBtn.Visible = False
        '
        'SidenavSuppliersBtn
        '
        Me.SidenavSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.SidenavSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.truck_bold
        Me.SidenavSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavSuppliersBtn.Location = New System.Drawing.Point(0, 300)
        Me.SidenavSuppliersBtn.Name = "SidenavSuppliersBtn"
        Me.SidenavSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavSuppliersBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavSuppliersBtn.TabIndex = 23
        Me.SidenavSuppliersBtn.Text = "Suppliers"
        Me.SidenavSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavSuppliersBtn.UseVisualStyleBackColor = True
        Me.SidenavSuppliersBtn.Visible = False
        '
        'SidenavServicesBtn
        '
        Me.SidenavServicesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavServicesBtn.FlatAppearance.BorderSize = 0
        Me.SidenavServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavServicesBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavServicesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavServicesBtn.Image = Global.E_Repair.My.Resources.Resources.screwdriver_bold
        Me.SidenavServicesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavServicesBtn.Location = New System.Drawing.Point(0, 225)
        Me.SidenavServicesBtn.Name = "SidenavServicesBtn"
        Me.SidenavServicesBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavServicesBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavServicesBtn.TabIndex = 22
        Me.SidenavServicesBtn.Text = "Services"
        Me.SidenavServicesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavServicesBtn.UseVisualStyleBackColor = True
        Me.SidenavServicesBtn.Visible = False
        '
        'SidenavCustomersBtn
        '
        Me.SidenavCustomersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavCustomersBtn.FlatAppearance.BorderSize = 0
        Me.SidenavCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavCustomersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavCustomersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavCustomersBtn.Image = Global.E_Repair.My.Resources.Resources.handshake_bold1
        Me.SidenavCustomersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavCustomersBtn.Location = New System.Drawing.Point(0, 150)
        Me.SidenavCustomersBtn.Name = "SidenavCustomersBtn"
        Me.SidenavCustomersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavCustomersBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavCustomersBtn.TabIndex = 21
        Me.SidenavCustomersBtn.Text = "Customers"
        Me.SidenavCustomersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavCustomersBtn.UseVisualStyleBackColor = True
        Me.SidenavCustomersBtn.Visible = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 596)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(82, 10)
        Me.Guna2Separator1.TabIndex = 20
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LogoutBtn.Image = Global.E_Repair.My.Resources.Resources.sign_out_bold
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 606)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.LogoutBtn.Size = New System.Drawing.Size(82, 75)
        Me.LogoutBtn.TabIndex = 19
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'SidenavEmployeesBtn
        '
        Me.SidenavEmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavEmployeesBtn.FlatAppearance.BorderSize = 0
        Me.SidenavEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavEmployeesBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavEmployeesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavEmployeesBtn.Image = Global.E_Repair.My.Resources.Resources.users_three_bold
        Me.SidenavEmployeesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavEmployeesBtn.Location = New System.Drawing.Point(0, 75)
        Me.SidenavEmployeesBtn.Name = "SidenavEmployeesBtn"
        Me.SidenavEmployeesBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavEmployeesBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavEmployeesBtn.TabIndex = 13
        Me.SidenavEmployeesBtn.Text = "Employees" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SidenavEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavEmployeesBtn.UseVisualStyleBackColor = True
        Me.SidenavEmployeesBtn.Visible = False
        '
        'SidenavDashboardBtn
        '
        Me.SidenavDashboardBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SidenavDashboardBtn.FlatAppearance.BorderSize = 0
        Me.SidenavDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidenavDashboardBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidenavDashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SidenavDashboardBtn.Image = Global.E_Repair.My.Resources.Resources.chart_line_bold
        Me.SidenavDashboardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SidenavDashboardBtn.Location = New System.Drawing.Point(0, 0)
        Me.SidenavDashboardBtn.Name = "SidenavDashboardBtn"
        Me.SidenavDashboardBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SidenavDashboardBtn.Size = New System.Drawing.Size(82, 75)
        Me.SidenavDashboardBtn.TabIndex = 12
        Me.SidenavDashboardBtn.Text = "Dashboard"
        Me.SidenavDashboardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SidenavDashboardBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 0)
        Me.Panel2.TabIndex = 0
        '
        'AdminTopNavPanel
        '
        Me.AdminTopNavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.AdminTopNavPanel.Controls.Add(Me.AdminProfilePanel)
        Me.AdminTopNavPanel.Controls.Add(Me.AdminTopNavTitle)
        Me.AdminTopNavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminTopNavPanel.Location = New System.Drawing.Point(82, 0)
        Me.AdminTopNavPanel.Name = "AdminTopNavPanel"
        Me.AdminTopNavPanel.Size = New System.Drawing.Size(1182, 70)
        Me.AdminTopNavPanel.TabIndex = 24
        '
        'AdminProfilePanel
        '
        Me.AdminProfilePanel.Controls.Add(Me.AdminTopNavProfilePictureBox)
        Me.AdminProfilePanel.Controls.Add(Me.TopNavPositionLabel)
        Me.AdminProfilePanel.Controls.Add(Me.AdminTopNavUsernameLabel)
        Me.AdminProfilePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.AdminProfilePanel.Location = New System.Drawing.Point(914, 0)
        Me.AdminProfilePanel.Name = "AdminProfilePanel"
        Me.AdminProfilePanel.Size = New System.Drawing.Size(268, 70)
        Me.AdminProfilePanel.TabIndex = 0
        '
        'AdminTopNavProfilePictureBox
        '
        Me.AdminTopNavProfilePictureBox.Image = Global.E_Repair.My.Resources.Resources.landscape_placeholder_svgrepo_com
        Me.AdminTopNavProfilePictureBox.Location = New System.Drawing.Point(35, 9)
        Me.AdminTopNavProfilePictureBox.Name = "AdminTopNavProfilePictureBox"
        Me.AdminTopNavProfilePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AdminTopNavProfilePictureBox.ShadowDecoration.Parent = Me.AdminTopNavProfilePictureBox
        Me.AdminTopNavProfilePictureBox.Size = New System.Drawing.Size(50, 50)
        Me.AdminTopNavProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminTopNavProfilePictureBox.TabIndex = 0
        Me.AdminTopNavProfilePictureBox.TabStop = False
        '
        'TopNavPositionLabel
        '
        Me.TopNavPositionLabel.AutoSize = True
        Me.TopNavPositionLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TopNavPositionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TopNavPositionLabel.Location = New System.Drawing.Point(97, 36)
        Me.TopNavPositionLabel.Name = "TopNavPositionLabel"
        Me.TopNavPositionLabel.Size = New System.Drawing.Size(38, 15)
        Me.TopNavPositionLabel.TabIndex = 2
        Me.TopNavPositionLabel.Text = "Admin"
        '
        'AdminTopNavUsernameLabel
        '
        Me.AdminTopNavUsernameLabel.AutoSize = True
        Me.AdminTopNavUsernameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTopNavUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminTopNavUsernameLabel.Location = New System.Drawing.Point(97, 20)
        Me.AdminTopNavUsernameLabel.Name = "AdminTopNavUsernameLabel"
        Me.AdminTopNavUsernameLabel.Size = New System.Drawing.Size(67, 16)
        Me.AdminTopNavUsernameLabel.TabIndex = 1
        Me.AdminTopNavUsernameLabel.Text = "John Doe"
        '
        'AdminTopNavTitle
        '
        Me.AdminTopNavTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminTopNavTitle.AutoSize = True
        Me.AdminTopNavTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTopNavTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminTopNavTitle.Location = New System.Drawing.Point(517, 23)
        Me.AdminTopNavTitle.Name = "AdminTopNavTitle"
        Me.AdminTopNavTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminTopNavTitle.Size = New System.Drawing.Size(67, 24)
        Me.AdminTopNavTitle.TabIndex = 8
        Me.AdminTopNavTitle.Text = "PAGE"
        Me.AdminTopNavTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminContentPanel
        '
        Me.AdminContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AdminContentPanel.Location = New System.Drawing.Point(82, 70)
        Me.AdminContentPanel.Name = "AdminContentPanel"
        Me.AdminContentPanel.Size = New System.Drawing.Size(1182, 611)
        Me.AdminContentPanel.TabIndex = 25
        '
        'MainPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.AdminContentPanel)
        Me.Controls.Add(Me.AdminTopNavPanel)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "MainPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.AdminTopNavPanel.ResumeLayout(False)
        Me.AdminTopNavPanel.PerformLayout()
        Me.AdminProfilePanel.ResumeLayout(False)
        Me.AdminProfilePanel.PerformLayout()
        CType(Me.AdminTopNavProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminSidenavPanel As Panel
    Friend WithEvents SidenavEmployeesBtn As Button
    Friend WithEvents SidenavDashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdminTopNavPanel As Panel
    Friend WithEvents AdminProfilePanel As Panel
    Friend WithEvents AdminTopNavProfilePictureBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TopNavPositionLabel As Label
    Friend WithEvents AdminTopNavUsernameLabel As Label
    Friend WithEvents AdminTopNavTitle As Label
    Friend WithEvents AdminContentPanel As Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents SidenavCustomersBtn As Button
    Friend WithEvents SidenavInventoryBtn As Button
    Friend WithEvents SidenavSuppliersBtn As Button
    Friend WithEvents SidenavServicesBtn As Button
    Friend WithEvents SettingsBtn As Button
End Class
