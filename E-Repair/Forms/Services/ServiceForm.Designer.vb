<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchStatusCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ShowArchiveCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.AdminSidenavPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteServiceBtn = New System.Windows.Forms.Button()
        Me.ArchiveServiceBtn = New System.Windows.Forms.Button()
        Me.EditServiceBtn = New System.Windows.Forms.Button()
        Me.AddServiceBtn = New System.Windows.Forms.Button()
        Me.ViewServiceBtn = New System.Windows.Forms.Button()
        Me.ClaimServiceBtn = New System.Windows.Forms.Button()
        Me.EvaluateServiceBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ServiceDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SERVICE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TECHNICIAN_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASHIER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TECHNICIAN_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVICE_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVICE_MODEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVICE_BRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERATING_SYSTEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STORAGE_CAPACITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROBLEM_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPAIR_NOTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICE_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TECHNICIAN_FEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTS_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEVICE_PROFILE_PATH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_CHANGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENT_METHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_COMPLETED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_CLAIMED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportToExcelBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ServiceDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(986, 28)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.SearchComboBox)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Controls.Add(Me.SearchTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(493, 28)
        Me.Guna2Panel1.TabIndex = 31
        '
        'SearchComboBox
        '
        Me.SearchComboBox.Animated = True
        Me.SearchComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchComboBox.BorderRadius = 4
        Me.SearchComboBox.DisplayMember = "(none)"
        Me.SearchComboBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SearchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.SearchComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SearchComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.ItemHeight = 22
        Me.SearchComboBox.Items.AddRange(New Object() {"Customer Name", "Technician Name", "Model", "Date Commissioned"})
        Me.SearchComboBox.Location = New System.Drawing.Point(261, 0)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(207, 28)
        Me.SearchComboBox.StartIndex = 0
        Me.SearchComboBox.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(245, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 28)
        Me.Panel2.TabIndex = 32
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BorderRadius = 4
        Me.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTextBox.DefaultText = ""
        Me.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 24, 5)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTextBox.PlaceholderText = "Search..."
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.Size = New System.Drawing.Size(245, 28)
        Me.SearchTextBox.TabIndex = 31
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.SearchStatusCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel4)
        Me.Guna2Panel2.Controls.Add(Me.ShowArchiveCheckBox)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(525, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(461, 28)
        Me.Guna2Panel2.TabIndex = 32
        '
        'SearchStatusCmb
        '
        Me.SearchStatusCmb.Animated = True
        Me.SearchStatusCmb.BackColor = System.Drawing.Color.Transparent
        Me.SearchStatusCmb.BorderRadius = 4
        Me.SearchStatusCmb.DisplayMember = "(none)"
        Me.SearchStatusCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchStatusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SearchStatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchStatusCmb.FocusedColor = System.Drawing.Color.Empty
        Me.SearchStatusCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SearchStatusCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SearchStatusCmb.FormattingEnabled = True
        Me.SearchStatusCmb.ItemHeight = 22
        Me.SearchStatusCmb.Location = New System.Drawing.Point(146, 0)
        Me.SearchStatusCmb.Margin = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.SearchStatusCmb.Name = "SearchStatusCmb"
        Me.SearchStatusCmb.Size = New System.Drawing.Size(207, 28)
        Me.SearchStatusCmb.TabIndex = 35
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(353, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(16, 28)
        Me.Panel4.TabIndex = 33
        '
        'ShowArchiveCheckBox
        '
        Me.ShowArchiveCheckBox.AutoSize = True
        Me.ShowArchiveCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.CheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.CheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowArchiveCheckBox.Location = New System.Drawing.Point(369, 0)
        Me.ShowArchiveCheckBox.Name = "ShowArchiveCheckBox"
        Me.ShowArchiveCheckBox.Size = New System.Drawing.Size(92, 28)
        Me.ShowArchiveCheckBox.TabIndex = 31
        Me.ShowArchiveCheckBox.Text = "Show Archive"
        Me.ShowArchiveCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckBox.UncheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.UncheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckBox.UseVisualStyleBackColor = True
        '
        'AdminSidenavPanel
        '
        Me.AdminSidenavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AdminSidenavPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.AdminSidenavPanel.Controls.Add(Me.Panel1)
        Me.AdminSidenavPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.AdminSidenavPanel.Location = New System.Drawing.Point(1015, 0)
        Me.AdminSidenavPanel.Name = "AdminSidenavPanel"
        Me.AdminSidenavPanel.Size = New System.Drawing.Size(65, 611)
        Me.AdminSidenavPanel.TabIndex = 38
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ExportToExcelBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66907!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.33093!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteServiceBtn)
        Me.Panel3.Controls.Add(Me.ArchiveServiceBtn)
        Me.Panel3.Controls.Add(Me.EditServiceBtn)
        Me.Panel3.Controls.Add(Me.AddServiceBtn)
        Me.Panel3.Controls.Add(Me.ViewServiceBtn)
        Me.Panel3.Controls.Add(Me.ClaimServiceBtn)
        Me.Panel3.Controls.Add(Me.EvaluateServiceBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 83)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 528)
        Me.Panel3.TabIndex = 0
        '
        'DeleteServiceBtn
        '
        Me.DeleteServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteServiceBtn.FlatAppearance.BorderSize = 0
        Me.DeleteServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteServiceBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteServiceBtn.Location = New System.Drawing.Point(0, 450)
        Me.DeleteServiceBtn.Name = "DeleteServiceBtn"
        Me.DeleteServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteServiceBtn.TabIndex = 41
        Me.DeleteServiceBtn.Text = "Delete"
        Me.DeleteServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteServiceBtn.UseVisualStyleBackColor = True
        Me.DeleteServiceBtn.Visible = False
        '
        'ArchiveServiceBtn
        '
        Me.ArchiveServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveServiceBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchiveServiceBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchiveServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchiveServiceBtn.Location = New System.Drawing.Point(0, 375)
        Me.ArchiveServiceBtn.Name = "ArchiveServiceBtn"
        Me.ArchiveServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveServiceBtn.TabIndex = 40
        Me.ArchiveServiceBtn.TabStop = False
        Me.ArchiveServiceBtn.Text = "Archive"
        Me.ArchiveServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchiveServiceBtn.UseVisualStyleBackColor = True
        Me.ArchiveServiceBtn.Visible = False
        '
        'EditServiceBtn
        '
        Me.EditServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditServiceBtn.FlatAppearance.BorderSize = 0
        Me.EditServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditServiceBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EditServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditServiceBtn.Location = New System.Drawing.Point(0, 300)
        Me.EditServiceBtn.Name = "EditServiceBtn"
        Me.EditServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditServiceBtn.TabIndex = 39
        Me.EditServiceBtn.Text = "Edit"
        Me.EditServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditServiceBtn.UseVisualStyleBackColor = True
        '
        'AddServiceBtn
        '
        Me.AddServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddServiceBtn.FlatAppearance.BorderSize = 0
        Me.AddServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddServiceBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddServiceBtn.Location = New System.Drawing.Point(0, 225)
        Me.AddServiceBtn.Name = "AddServiceBtn"
        Me.AddServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddServiceBtn.TabIndex = 38
        Me.AddServiceBtn.Text = "Add"
        Me.AddServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddServiceBtn.UseVisualStyleBackColor = True
        '
        'ViewServiceBtn
        '
        Me.ViewServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewServiceBtn.FlatAppearance.BorderSize = 0
        Me.ViewServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewServiceBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewServiceBtn.Location = New System.Drawing.Point(0, 150)
        Me.ViewServiceBtn.Name = "ViewServiceBtn"
        Me.ViewServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewServiceBtn.TabIndex = 37
        Me.ViewServiceBtn.Text = "Details"
        Me.ViewServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewServiceBtn.UseVisualStyleBackColor = True
        '
        'ClaimServiceBtn
        '
        Me.ClaimServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClaimServiceBtn.FlatAppearance.BorderSize = 0
        Me.ClaimServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClaimServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaimServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClaimServiceBtn.Image = Global.E_Repair.My.Resources.Resources.cash_register_bold
        Me.ClaimServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClaimServiceBtn.Location = New System.Drawing.Point(0, 75)
        Me.ClaimServiceBtn.Name = "ClaimServiceBtn"
        Me.ClaimServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ClaimServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.ClaimServiceBtn.TabIndex = 36
        Me.ClaimServiceBtn.Text = "Claim"
        Me.ClaimServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClaimServiceBtn.UseVisualStyleBackColor = True
        Me.ClaimServiceBtn.Visible = False
        '
        'EvaluateServiceBtn
        '
        Me.EvaluateServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EvaluateServiceBtn.FlatAppearance.BorderSize = 0
        Me.EvaluateServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EvaluateServiceBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EvaluateServiceBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EvaluateServiceBtn.Image = Global.E_Repair.My.Resources.Resources.check_square_bold
        Me.EvaluateServiceBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EvaluateServiceBtn.Location = New System.Drawing.Point(0, 0)
        Me.EvaluateServiceBtn.Name = "EvaluateServiceBtn"
        Me.EvaluateServiceBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EvaluateServiceBtn.Size = New System.Drawing.Size(65, 75)
        Me.EvaluateServiceBtn.TabIndex = 30
        Me.EvaluateServiceBtn.Text = "Evaluate"
        Me.EvaluateServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EvaluateServiceBtn.UseVisualStyleBackColor = True
        Me.EvaluateServiceBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(65, 0)
        Me.Panel1.TabIndex = 0
        '
        'ServiceDGV
        '
        Me.ServiceDGV.AllowUserToAddRows = False
        Me.ServiceDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ServiceDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ServiceDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServiceDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ServiceDGV.ColumnHeadersHeight = 48
        Me.ServiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ServiceDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SERVICE_ID, Me.CUSTOMER_ID, Me.TECHNICIAN_ID, Me.CASHIER_ID, Me.CUSTOMER_NAME, Me.TECHNICIAN_NAME, Me.DEVICE_TYPE, Me.DEVICE_MODEL, Me.DEVICE_BRAND, Me.OPERATING_SYSTEM, Me.STORAGE_CAPACITY, Me.PROBLEM_DESCRIPTION, Me.REPAIR_NOTES, Me.SERVICE_STATUS, Me.TECHNICIAN_FEE, Me.PARTS_COST, Me.TOTAL_PAID, Me.PAID, Me.DEVICE_PROFILE_PATH, Me.CUSTOMER_CHANGE, Me.PAYMENT_METHOD, Me.DATE_COMPLETED, Me.DATE_CLAIMED, Me.DATE_ADDED, Me.ARCHIVED, Me.ARCHIVED_BY, Me.DATE_ARCHIVED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServiceDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ServiceDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ServiceDGV.Location = New System.Drawing.Point(15, 59)
        Me.ServiceDGV.Name = "ServiceDGV"
        Me.ServiceDGV.ReadOnly = True
        Me.ServiceDGV.RowHeadersVisible = False
        Me.ServiceDGV.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.ServiceDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ServiceDGV.Size = New System.Drawing.Size(986, 498)
        Me.ServiceDGV.TabIndex = 40
        Me.ServiceDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.ServiceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ServiceDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ServiceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ServiceDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ServiceDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ServiceDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ServiceDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ServiceDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ServiceDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ServiceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ServiceDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.ServiceDGV.ThemeStyle.ReadOnly = True
        Me.ServiceDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ServiceDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ServiceDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ServiceDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ServiceDGV.ThemeStyle.RowsStyle.Height = 22
        Me.ServiceDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ServiceDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'SERVICE_ID
        '
        Me.SERVICE_ID.DataPropertyName = "service_id"
        Me.SERVICE_ID.HeaderText = "Service ID"
        Me.SERVICE_ID.MinimumWidth = 6
        Me.SERVICE_ID.Name = "SERVICE_ID"
        Me.SERVICE_ID.ReadOnly = True
        Me.SERVICE_ID.Visible = False
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.DataPropertyName = "customer_id"
        Me.CUSTOMER_ID.HeaderText = "Customer ID"
        Me.CUSTOMER_ID.MinimumWidth = 6
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.ReadOnly = True
        Me.CUSTOMER_ID.Visible = False
        '
        'TECHNICIAN_ID
        '
        Me.TECHNICIAN_ID.DataPropertyName = "technician_id"
        Me.TECHNICIAN_ID.HeaderText = "Technician ID"
        Me.TECHNICIAN_ID.MinimumWidth = 6
        Me.TECHNICIAN_ID.Name = "TECHNICIAN_ID"
        Me.TECHNICIAN_ID.ReadOnly = True
        Me.TECHNICIAN_ID.Visible = False
        '
        'CASHIER_ID
        '
        Me.CASHIER_ID.DataPropertyName = "cashier_id"
        Me.CASHIER_ID.HeaderText = "Cashier ID"
        Me.CASHIER_ID.MinimumWidth = 6
        Me.CASHIER_ID.Name = "CASHIER_ID"
        Me.CASHIER_ID.ReadOnly = True
        Me.CASHIER_ID.Visible = False
        '
        'CUSTOMER_NAME
        '
        Me.CUSTOMER_NAME.DataPropertyName = "cust_name"
        Me.CUSTOMER_NAME.HeaderText = "Customer Name"
        Me.CUSTOMER_NAME.MinimumWidth = 6
        Me.CUSTOMER_NAME.Name = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.ReadOnly = True
        '
        'TECHNICIAN_NAME
        '
        Me.TECHNICIAN_NAME.DataPropertyName = "tech_name"
        Me.TECHNICIAN_NAME.HeaderText = "Technician Name"
        Me.TECHNICIAN_NAME.MinimumWidth = 6
        Me.TECHNICIAN_NAME.Name = "TECHNICIAN_NAME"
        Me.TECHNICIAN_NAME.ReadOnly = True
        '
        'DEVICE_TYPE
        '
        Me.DEVICE_TYPE.DataPropertyName = "device_type"
        Me.DEVICE_TYPE.HeaderText = "Device Type"
        Me.DEVICE_TYPE.MinimumWidth = 6
        Me.DEVICE_TYPE.Name = "DEVICE_TYPE"
        Me.DEVICE_TYPE.ReadOnly = True
        Me.DEVICE_TYPE.Visible = False
        '
        'DEVICE_MODEL
        '
        Me.DEVICE_MODEL.DataPropertyName = "device_model"
        Me.DEVICE_MODEL.HeaderText = "Model"
        Me.DEVICE_MODEL.MinimumWidth = 6
        Me.DEVICE_MODEL.Name = "DEVICE_MODEL"
        Me.DEVICE_MODEL.ReadOnly = True
        '
        'DEVICE_BRAND
        '
        Me.DEVICE_BRAND.DataPropertyName = "device_brand"
        Me.DEVICE_BRAND.HeaderText = "Device Brand"
        Me.DEVICE_BRAND.MinimumWidth = 6
        Me.DEVICE_BRAND.Name = "DEVICE_BRAND"
        Me.DEVICE_BRAND.ReadOnly = True
        Me.DEVICE_BRAND.Visible = False
        '
        'OPERATING_SYSTEM
        '
        Me.OPERATING_SYSTEM.DataPropertyName = "operating_system"
        Me.OPERATING_SYSTEM.HeaderText = "Operating System"
        Me.OPERATING_SYSTEM.MinimumWidth = 6
        Me.OPERATING_SYSTEM.Name = "OPERATING_SYSTEM"
        Me.OPERATING_SYSTEM.ReadOnly = True
        Me.OPERATING_SYSTEM.Visible = False
        '
        'STORAGE_CAPACITY
        '
        Me.STORAGE_CAPACITY.DataPropertyName = "storage_capacity"
        Me.STORAGE_CAPACITY.HeaderText = "Storage Capacity"
        Me.STORAGE_CAPACITY.MinimumWidth = 6
        Me.STORAGE_CAPACITY.Name = "STORAGE_CAPACITY"
        Me.STORAGE_CAPACITY.ReadOnly = True
        Me.STORAGE_CAPACITY.Visible = False
        '
        'PROBLEM_DESCRIPTION
        '
        Me.PROBLEM_DESCRIPTION.DataPropertyName = "problem_description"
        Me.PROBLEM_DESCRIPTION.HeaderText = "Problem Description"
        Me.PROBLEM_DESCRIPTION.MinimumWidth = 6
        Me.PROBLEM_DESCRIPTION.Name = "PROBLEM_DESCRIPTION"
        Me.PROBLEM_DESCRIPTION.ReadOnly = True
        Me.PROBLEM_DESCRIPTION.Visible = False
        '
        'REPAIR_NOTES
        '
        Me.REPAIR_NOTES.DataPropertyName = "repair_notes"
        Me.REPAIR_NOTES.HeaderText = "Repair Notes"
        Me.REPAIR_NOTES.MinimumWidth = 6
        Me.REPAIR_NOTES.Name = "REPAIR_NOTES"
        Me.REPAIR_NOTES.ReadOnly = True
        Me.REPAIR_NOTES.Visible = False
        '
        'SERVICE_STATUS
        '
        Me.SERVICE_STATUS.DataPropertyName = "service_status"
        Me.SERVICE_STATUS.HeaderText = "Status"
        Me.SERVICE_STATUS.MinimumWidth = 6
        Me.SERVICE_STATUS.Name = "SERVICE_STATUS"
        Me.SERVICE_STATUS.ReadOnly = True
        '
        'TECHNICIAN_FEE
        '
        Me.TECHNICIAN_FEE.DataPropertyName = "technician_fee"
        Me.TECHNICIAN_FEE.HeaderText = "Technician Fee"
        Me.TECHNICIAN_FEE.MinimumWidth = 6
        Me.TECHNICIAN_FEE.Name = "TECHNICIAN_FEE"
        Me.TECHNICIAN_FEE.ReadOnly = True
        Me.TECHNICIAN_FEE.Visible = False
        '
        'PARTS_COST
        '
        Me.PARTS_COST.DataPropertyName = "parts_cost"
        Me.PARTS_COST.HeaderText = "Parts Cost"
        Me.PARTS_COST.MinimumWidth = 6
        Me.PARTS_COST.Name = "PARTS_COST"
        Me.PARTS_COST.ReadOnly = True
        Me.PARTS_COST.Visible = False
        '
        'TOTAL_PAID
        '
        Me.TOTAL_PAID.DataPropertyName = "total_paid"
        Me.TOTAL_PAID.HeaderText = "Total Paid"
        Me.TOTAL_PAID.MinimumWidth = 6
        Me.TOTAL_PAID.Name = "TOTAL_PAID"
        Me.TOTAL_PAID.ReadOnly = True
        Me.TOTAL_PAID.Visible = False
        '
        'PAID
        '
        Me.PAID.DataPropertyName = "paid"
        Me.PAID.HeaderText = "Payment Status"
        Me.PAID.MinimumWidth = 6
        Me.PAID.Name = "PAID"
        Me.PAID.ReadOnly = True
        Me.PAID.Visible = False
        '
        'DEVICE_PROFILE_PATH
        '
        Me.DEVICE_PROFILE_PATH.DataPropertyName = "device_profile_path"
        Me.DEVICE_PROFILE_PATH.HeaderText = "Profile Path"
        Me.DEVICE_PROFILE_PATH.MinimumWidth = 6
        Me.DEVICE_PROFILE_PATH.Name = "DEVICE_PROFILE_PATH"
        Me.DEVICE_PROFILE_PATH.ReadOnly = True
        Me.DEVICE_PROFILE_PATH.Visible = False
        '
        'CUSTOMER_CHANGE
        '
        Me.CUSTOMER_CHANGE.DataPropertyName = "customer_change"
        Me.CUSTOMER_CHANGE.HeaderText = "Change"
        Me.CUSTOMER_CHANGE.MinimumWidth = 6
        Me.CUSTOMER_CHANGE.Name = "CUSTOMER_CHANGE"
        Me.CUSTOMER_CHANGE.ReadOnly = True
        Me.CUSTOMER_CHANGE.Visible = False
        '
        'PAYMENT_METHOD
        '
        Me.PAYMENT_METHOD.DataPropertyName = "payment_method"
        Me.PAYMENT_METHOD.HeaderText = "Payment Method"
        Me.PAYMENT_METHOD.MinimumWidth = 6
        Me.PAYMENT_METHOD.Name = "PAYMENT_METHOD"
        Me.PAYMENT_METHOD.ReadOnly = True
        Me.PAYMENT_METHOD.Visible = False
        '
        'DATE_COMPLETED
        '
        Me.DATE_COMPLETED.DataPropertyName = "date_completed"
        Me.DATE_COMPLETED.HeaderText = "Date Completed"
        Me.DATE_COMPLETED.MinimumWidth = 6
        Me.DATE_COMPLETED.Name = "DATE_COMPLETED"
        Me.DATE_COMPLETED.ReadOnly = True
        Me.DATE_COMPLETED.Visible = False
        '
        'DATE_CLAIMED
        '
        Me.DATE_CLAIMED.DataPropertyName = "date_claimed"
        Me.DATE_CLAIMED.HeaderText = "Date Claimed"
        Me.DATE_CLAIMED.MinimumWidth = 6
        Me.DATE_CLAIMED.Name = "DATE_CLAIMED"
        Me.DATE_CLAIMED.ReadOnly = True
        Me.DATE_CLAIMED.Visible = False
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Commissioned"
        Me.DATE_ADDED.MinimumWidth = 6
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'ARCHIVED
        '
        Me.ARCHIVED.DataPropertyName = "archived"
        Me.ARCHIVED.HeaderText = "Archived"
        Me.ARCHIVED.MinimumWidth = 6
        Me.ARCHIVED.Name = "ARCHIVED"
        Me.ARCHIVED.ReadOnly = True
        Me.ARCHIVED.Visible = False
        '
        'ARCHIVED_BY
        '
        Me.ARCHIVED_BY.DataPropertyName = "archived_by"
        Me.ARCHIVED_BY.HeaderText = "Archived by"
        Me.ARCHIVED_BY.MinimumWidth = 6
        Me.ARCHIVED_BY.Name = "ARCHIVED_BY"
        Me.ARCHIVED_BY.ReadOnly = True
        Me.ARCHIVED_BY.Visible = False
        '
        'DATE_ARCHIVED
        '
        Me.DATE_ARCHIVED.DataPropertyName = "date_archived"
        Me.DATE_ARCHIVED.HeaderText = "Date Archived"
        Me.DATE_ARCHIVED.MinimumWidth = 6
        Me.DATE_ARCHIVED.Name = "DATE_ARCHIVED"
        Me.DATE_ARCHIVED.ReadOnly = True
        Me.DATE_ARCHIVED.Visible = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BorderRadius = 4
        Me.BtnSelect.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnSelect.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.Location = New System.Drawing.Point(894, 567)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(107, 32)
        Me.BtnSelect.TabIndex = 43
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BorderRadius = 4
        Me.BtnClose.FillColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(15, 567)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 42
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'ExportToExcelBtn
        '
        Me.ExportToExcelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExportToExcelBtn.FlatAppearance.BorderSize = 0
        Me.ExportToExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportToExcelBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToExcelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ExportToExcelBtn.Image = Global.E_Repair.My.Resources.Resources.files_bold
        Me.ExportToExcelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExportToExcelBtn.Location = New System.Drawing.Point(3, 3)
        Me.ExportToExcelBtn.Name = "ExportToExcelBtn"
        Me.ExportToExcelBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ExportToExcelBtn.Size = New System.Drawing.Size(59, 75)
        Me.ExportToExcelBtn.TabIndex = 31
        Me.ExportToExcelBtn.Text = "Report"
        Me.ExportToExcelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExportToExcelBtn.UseVisualStyleBackColor = True
        '
        'ServiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ServiceDGV)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "ServiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminServicesForm"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ServiceDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AdminSidenavPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ServiceDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EvaluateServiceBtn As Button
    Friend WithEvents DeleteServiceBtn As Button
    Friend WithEvents ArchiveServiceBtn As Button
    Friend WithEvents EditServiceBtn As Button
    Friend WithEvents AddServiceBtn As Button
    Friend WithEvents ViewServiceBtn As Button
    Friend WithEvents ClaimServiceBtn As Button
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchStatusCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ShowArchiveCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents SERVICE_ID As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ID As DataGridViewTextBoxColumn
    Friend WithEvents TECHNICIAN_ID As DataGridViewTextBoxColumn
    Friend WithEvents CASHIER_ID As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NAME As DataGridViewTextBoxColumn
    Friend WithEvents TECHNICIAN_NAME As DataGridViewTextBoxColumn
    Friend WithEvents DEVICE_TYPE As DataGridViewTextBoxColumn
    Friend WithEvents DEVICE_MODEL As DataGridViewTextBoxColumn
    Friend WithEvents DEVICE_BRAND As DataGridViewTextBoxColumn
    Friend WithEvents OPERATING_SYSTEM As DataGridViewTextBoxColumn
    Friend WithEvents STORAGE_CAPACITY As DataGridViewTextBoxColumn
    Friend WithEvents PROBLEM_DESCRIPTION As DataGridViewTextBoxColumn
    Friend WithEvents REPAIR_NOTES As DataGridViewTextBoxColumn
    Friend WithEvents SERVICE_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents TECHNICIAN_FEE As DataGridViewTextBoxColumn
    Friend WithEvents PARTS_COST As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PAID As DataGridViewTextBoxColumn
    Friend WithEvents PAID As DataGridViewTextBoxColumn
    Friend WithEvents DEVICE_PROFILE_PATH As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_CHANGE As DataGridViewTextBoxColumn
    Friend WithEvents PAYMENT_METHOD As DataGridViewTextBoxColumn
    Friend WithEvents DATE_COMPLETED As DataGridViewTextBoxColumn
    Friend WithEvents DATE_CLAIMED As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ExportToExcelBtn As Button
End Class
