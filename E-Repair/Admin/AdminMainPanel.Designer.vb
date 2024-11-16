<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMainPanel
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
        Me.AdminSidenavInventoryBtn = New System.Windows.Forms.Button()
        Me.AdminSidenavSuppliersBtn = New System.Windows.Forms.Button()
        Me.AdminSidenavServicesBtn = New System.Windows.Forms.Button()
        Me.AdminSidenavCustomersBtn = New System.Windows.Forms.Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.AdminSidenavEmployeesBtn = New System.Windows.Forms.Button()
        Me.AdminSidenavDashboardBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminTopNavPanel = New System.Windows.Forms.Panel()
        Me.AdminProfilePanel = New System.Windows.Forms.Panel()
        Me.AdminTopNavProfilePictureBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.AdminTopNavPositionLabel = New System.Windows.Forms.Label()
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
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavInventoryBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavSuppliersBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavServicesBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavCustomersBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.Guna2Separator1)
        Me.AdminSidenavPanel.Controls.Add(Me.LogoutBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavEmployeesBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.AdminSidenavDashboardBtn)
        Me.AdminSidenavPanel.Controls.Add(Me.Panel2)
        Me.AdminSidenavPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AdminSidenavPanel.Location = New System.Drawing.Point(0, 0)
        Me.AdminSidenavPanel.Name = "AdminSidenavPanel"
        Me.AdminSidenavPanel.Size = New System.Drawing.Size(82, 681)
        Me.AdminSidenavPanel.TabIndex = 23
        '
        'AdminSidenavInventoryBtn
        '
        Me.AdminSidenavInventoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavInventoryBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavInventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavInventoryBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavInventoryBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavInventoryBtn.Image = Global.E_Repair.My.Resources.Resources.package_bold
        Me.AdminSidenavInventoryBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavInventoryBtn.Location = New System.Drawing.Point(0, 375)
        Me.AdminSidenavInventoryBtn.Name = "AdminSidenavInventoryBtn"
        Me.AdminSidenavInventoryBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavInventoryBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavInventoryBtn.TabIndex = 24
        Me.AdminSidenavInventoryBtn.Text = "Inventory"
        Me.AdminSidenavInventoryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavInventoryBtn.UseVisualStyleBackColor = True
        '
        'AdminSidenavSuppliersBtn
        '
        Me.AdminSidenavSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.truck_bold
        Me.AdminSidenavSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavSuppliersBtn.Location = New System.Drawing.Point(0, 300)
        Me.AdminSidenavSuppliersBtn.Name = "AdminSidenavSuppliersBtn"
        Me.AdminSidenavSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavSuppliersBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavSuppliersBtn.TabIndex = 23
        Me.AdminSidenavSuppliersBtn.Text = "Suppliers"
        Me.AdminSidenavSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavSuppliersBtn.UseVisualStyleBackColor = True
        '
        'AdminSidenavServicesBtn
        '
        Me.AdminSidenavServicesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavServicesBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavServicesBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavServicesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavServicesBtn.Image = Global.E_Repair.My.Resources.Resources.screwdriver_bold
        Me.AdminSidenavServicesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavServicesBtn.Location = New System.Drawing.Point(0, 225)
        Me.AdminSidenavServicesBtn.Name = "AdminSidenavServicesBtn"
        Me.AdminSidenavServicesBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavServicesBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavServicesBtn.TabIndex = 22
        Me.AdminSidenavServicesBtn.Text = "Services"
        Me.AdminSidenavServicesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavServicesBtn.UseVisualStyleBackColor = True
        '
        'AdminSidenavCustomersBtn
        '
        Me.AdminSidenavCustomersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavCustomersBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavCustomersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavCustomersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavCustomersBtn.Image = Global.E_Repair.My.Resources.Resources.handshake_bold1
        Me.AdminSidenavCustomersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavCustomersBtn.Location = New System.Drawing.Point(0, 150)
        Me.AdminSidenavCustomersBtn.Name = "AdminSidenavCustomersBtn"
        Me.AdminSidenavCustomersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavCustomersBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavCustomersBtn.TabIndex = 21
        Me.AdminSidenavCustomersBtn.Text = "Customers"
        Me.AdminSidenavCustomersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavCustomersBtn.UseVisualStyleBackColor = True
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
        'AdminSidenavEmployeesBtn
        '
        Me.AdminSidenavEmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavEmployeesBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavEmployeesBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavEmployeesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavEmployeesBtn.Image = Global.E_Repair.My.Resources.Resources.users_three_bold
        Me.AdminSidenavEmployeesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavEmployeesBtn.Location = New System.Drawing.Point(0, 75)
        Me.AdminSidenavEmployeesBtn.Name = "AdminSidenavEmployeesBtn"
        Me.AdminSidenavEmployeesBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavEmployeesBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavEmployeesBtn.TabIndex = 13
        Me.AdminSidenavEmployeesBtn.Text = "Employees" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AdminSidenavEmployeesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavEmployeesBtn.UseVisualStyleBackColor = True
        '
        'AdminSidenavDashboardBtn
        '
        Me.AdminSidenavDashboardBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidenavDashboardBtn.FlatAppearance.BorderSize = 0
        Me.AdminSidenavDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSidenavDashboardBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSidenavDashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminSidenavDashboardBtn.Image = Global.E_Repair.My.Resources.Resources.chart_line_bold
        Me.AdminSidenavDashboardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminSidenavDashboardBtn.Location = New System.Drawing.Point(0, 0)
        Me.AdminSidenavDashboardBtn.Name = "AdminSidenavDashboardBtn"
        Me.AdminSidenavDashboardBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AdminSidenavDashboardBtn.Size = New System.Drawing.Size(82, 75)
        Me.AdminSidenavDashboardBtn.TabIndex = 12
        Me.AdminSidenavDashboardBtn.Text = "Dashboard"
        Me.AdminSidenavDashboardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminSidenavDashboardBtn.UseVisualStyleBackColor = True
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
        Me.AdminProfilePanel.Controls.Add(Me.AdminTopNavPositionLabel)
        Me.AdminProfilePanel.Controls.Add(Me.AdminTopNavUsernameLabel)
        Me.AdminProfilePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.AdminProfilePanel.Location = New System.Drawing.Point(914, 0)
        Me.AdminProfilePanel.Name = "AdminProfilePanel"
        Me.AdminProfilePanel.Size = New System.Drawing.Size(268, 70)
        Me.AdminProfilePanel.TabIndex = 0
        '
        'AdminTopNavProfilePictureBox
        '
        Me.AdminTopNavProfilePictureBox.Location = New System.Drawing.Point(35, 9)
        Me.AdminTopNavProfilePictureBox.Name = "AdminTopNavProfilePictureBox"
        Me.AdminTopNavProfilePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AdminTopNavProfilePictureBox.ShadowDecoration.Parent = Me.AdminTopNavProfilePictureBox
        Me.AdminTopNavProfilePictureBox.Size = New System.Drawing.Size(50, 50)
        Me.AdminTopNavProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminTopNavProfilePictureBox.TabIndex = 0
        Me.AdminTopNavProfilePictureBox.TabStop = False
        '
        'AdminTopNavPositionLabel
        '
        Me.AdminTopNavPositionLabel.AutoSize = True
        Me.AdminTopNavPositionLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.AdminTopNavPositionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminTopNavPositionLabel.Location = New System.Drawing.Point(97, 36)
        Me.AdminTopNavPositionLabel.Name = "AdminTopNavPositionLabel"
        Me.AdminTopNavPositionLabel.Size = New System.Drawing.Size(38, 15)
        Me.AdminTopNavPositionLabel.TabIndex = 2
        Me.AdminTopNavPositionLabel.Text = "Admin"
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
        'AdminMainPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.AdminContentPanel)
        Me.Controls.Add(Me.AdminTopNavPanel)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "AdminMainPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
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
    Friend WithEvents AdminSidenavEmployeesBtn As Button
    Friend WithEvents AdminSidenavDashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdminTopNavPanel As Panel
    Friend WithEvents AdminProfilePanel As Panel
    Friend WithEvents AdminTopNavProfilePictureBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents AdminTopNavPositionLabel As Label
    Friend WithEvents AdminTopNavUsernameLabel As Label
    Friend WithEvents AdminTopNavTitle As Label
    Friend WithEvents AdminContentPanel As Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents AdminSidenavCustomersBtn As Button
    Friend WithEvents AdminSidenavInventoryBtn As Button
    Friend WithEvents AdminSidenavSuppliersBtn As Button
    Friend WithEvents AdminSidenavServicesBtn As Button
End Class
