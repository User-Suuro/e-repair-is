<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm
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
        Me.AdminSidenavPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.ArchiveEmployeeBtn = New System.Windows.Forms.Button()
        Me.EditEmployeeBtn = New System.Windows.Forms.Button()
        Me.AddEmployeeBtn = New System.Windows.Forms.Button()
        Me.ViewEmployeeBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShowArchiveCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_ACCESSED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMG_PATH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERSONNEL_DESTINATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMIN_POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOB_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIN_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGIBIG_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSS_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_HIRED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYMENT_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVIL_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.EmpDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.AdminSidenavPanel.TabIndex = 32
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteEmployeeBtn)
        Me.Panel3.Controls.Add(Me.ArchiveEmployeeBtn)
        Me.Panel3.Controls.Add(Me.EditEmployeeBtn)
        Me.Panel3.Controls.Add(Me.AddEmployeeBtn)
        Me.Panel3.Controls.Add(Me.ViewEmployeeBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 61)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 488)
        Me.Panel3.TabIndex = 0
        '
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.DeleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(0, 300)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteEmployeeBtn.TabIndex = 29
        Me.DeleteEmployeeBtn.Text = "Delete"
        Me.DeleteEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteEmployeeBtn.UseVisualStyleBackColor = True
        Me.DeleteEmployeeBtn.Visible = False
        '
        'ArchiveEmployeeBtn
        '
        Me.ArchiveEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchiveEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchiveEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchiveEmployeeBtn.Location = New System.Drawing.Point(0, 225)
        Me.ArchiveEmployeeBtn.Name = "ArchiveEmployeeBtn"
        Me.ArchiveEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveEmployeeBtn.TabIndex = 28
        Me.ArchiveEmployeeBtn.TabStop = False
        Me.ArchiveEmployeeBtn.Text = "Archive"
        Me.ArchiveEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchiveEmployeeBtn.UseVisualStyleBackColor = True
        '
        'EditEmployeeBtn
        '
        Me.EditEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.EditEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EditEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditEmployeeBtn.Location = New System.Drawing.Point(0, 150)
        Me.EditEmployeeBtn.Name = "EditEmployeeBtn"
        Me.EditEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditEmployeeBtn.TabIndex = 27
        Me.EditEmployeeBtn.Text = "Edit"
        Me.EditEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditEmployeeBtn.UseVisualStyleBackColor = True
        '
        'AddEmployeeBtn
        '
        Me.AddEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddEmployeeBtn.Location = New System.Drawing.Point(0, 75)
        Me.AddEmployeeBtn.Name = "AddEmployeeBtn"
        Me.AddEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddEmployeeBtn.TabIndex = 26
        Me.AddEmployeeBtn.Text = "Add"
        Me.AddEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddEmployeeBtn.UseVisualStyleBackColor = True
        '
        'ViewEmployeeBtn
        '
        Me.ViewEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.ViewEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewEmployeeBtn.Location = New System.Drawing.Point(0, 0)
        Me.ViewEmployeeBtn.Name = "ViewEmployeeBtn"
        Me.ViewEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewEmployeeBtn.TabIndex = 19
        Me.ViewEmployeeBtn.Text = "Details"
        Me.ViewEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewEmployeeBtn.UseVisualStyleBackColor = True
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ShowArchiveCheckBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 28)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'ShowArchiveCheckBox
        '
        Me.ShowArchiveCheckBox.AutoSize = True
        Me.ShowArchiveCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.CheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.CheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowArchiveCheckBox.Location = New System.Drawing.Point(873, 3)
        Me.ShowArchiveCheckBox.Name = "ShowArchiveCheckBox"
        Me.ShowArchiveCheckBox.Size = New System.Drawing.Size(92, 22)
        Me.ShowArchiveCheckBox.TabIndex = 30
        Me.ShowArchiveCheckBox.Text = "Show Archive"
        Me.ShowArchiveCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckBox.UncheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.UncheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckBox.UseVisualStyleBackColor = True
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
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(484, 28)
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
        Me.SearchComboBox.FocusedState.Parent = Me.SearchComboBox
        Me.SearchComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SearchComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.HoverState.Parent = Me.SearchComboBox
        Me.SearchComboBox.ItemHeight = 22
        Me.SearchComboBox.Items.AddRange(New Object() {"First Name", "Middle Name", "Last Name", "Date Hired", "Email", "Last Accessed", "Date Added"})
        Me.SearchComboBox.ItemsAppearance.Parent = Me.SearchComboBox
        Me.SearchComboBox.Location = New System.Drawing.Point(261, 0)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(12)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.ShadowDecoration.Parent = Me.SearchComboBox
        Me.SearchComboBox.Size = New System.Drawing.Size(177, 28)
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
        Me.SearchTextBox.DisabledState.Parent = Me.SearchTextBox
        Me.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.FocusedState.Parent = Me.SearchTextBox
        Me.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.HoverState.Parent = Me.SearchTextBox
        Me.SearchTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 24, 5)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTextBox.PlaceholderText = "Search..."
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.ShadowDecoration.Parent = Me.SearchTextBox
        Me.SearchTextBox.Size = New System.Drawing.Size(245, 28)
        Me.SearchTextBox.TabIndex = 31
        '
        'BtnSelect
        '
        Me.BtnSelect.BorderRadius = 4
        Me.BtnSelect.CheckedState.Parent = Me.BtnSelect
        Me.BtnSelect.CustomImages.Parent = Me.BtnSelect
        Me.BtnSelect.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnSelect.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.HoverState.Parent = Me.BtnSelect
        Me.BtnSelect.Location = New System.Drawing.Point(882, 567)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.ShadowDecoration.Parent = Me.BtnSelect
        Me.BtnSelect.Size = New System.Drawing.Size(107, 32)
        Me.BtnSelect.TabIndex = 40
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BorderRadius = 4
        Me.BtnClose.CheckedState.Parent = Me.BtnClose
        Me.BtnClose.CustomImages.Parent = Me.BtnClose
        Me.BtnClose.FillColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.HoverState.Parent = Me.BtnClose
        Me.BtnClose.Location = New System.Drawing.Point(21, 567)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 39
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'DATE_ARCHIVED
        '
        Me.DATE_ARCHIVED.DataPropertyName = "date_archived"
        Me.DATE_ARCHIVED.HeaderText = "Date Archived"
        Me.DATE_ARCHIVED.Name = "DATE_ARCHIVED"
        Me.DATE_ARCHIVED.ReadOnly = True
        Me.DATE_ARCHIVED.Visible = False
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'LAST_ACCESSED
        '
        Me.LAST_ACCESSED.DataPropertyName = "last_accessed"
        Me.LAST_ACCESSED.HeaderText = "Last Accessed"
        Me.LAST_ACCESSED.Name = "LAST_ACCESSED"
        Me.LAST_ACCESSED.ReadOnly = True
        '
        'ARCHIVED_BY
        '
        Me.ARCHIVED_BY.DataPropertyName = "archived_by"
        Me.ARCHIVED_BY.HeaderText = "Archived By"
        Me.ARCHIVED_BY.Name = "ARCHIVED_BY"
        Me.ARCHIVED_BY.ReadOnly = True
        Me.ARCHIVED_BY.Visible = False
        '
        'ARCHIVED
        '
        Me.ARCHIVED.DataPropertyName = "archived"
        Me.ARCHIVED.HeaderText = "Archived"
        Me.ARCHIVED.Name = "ARCHIVED"
        Me.ARCHIVED.ReadOnly = True
        Me.ARCHIVED.Visible = False
        '
        'ADDED_BY_NAME
        '
        Me.ADDED_BY_NAME.HeaderText = "Added by"
        Me.ADDED_BY_NAME.Name = "ADDED_BY_NAME"
        Me.ADDED_BY_NAME.ReadOnly = True
        '
        'ADDED_BY
        '
        Me.ADDED_BY.DataPropertyName = "added_by"
        Me.ADDED_BY.HeaderText = "Added By"
        Me.ADDED_BY.Name = "ADDED_BY"
        Me.ADDED_BY.ReadOnly = True
        Me.ADDED_BY.Visible = False
        '
        'PASSWORD
        '
        Me.PASSWORD.DataPropertyName = "password"
        Me.PASSWORD.HeaderText = "Password"
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.ReadOnly = True
        Me.PASSWORD.Visible = False
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "email"
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'IMG_PATH
        '
        Me.IMG_PATH.DataPropertyName = "profile_path"
        Me.IMG_PATH.HeaderText = "Image Path"
        Me.IMG_PATH.Name = "IMG_PATH"
        Me.IMG_PATH.ReadOnly = True
        Me.IMG_PATH.Visible = False
        '
        'PERSONNEL_DESTINATION
        '
        Me.PERSONNEL_DESTINATION.DataPropertyName = "personnel_destination"
        Me.PERSONNEL_DESTINATION.HeaderText = "Personnel Destination"
        Me.PERSONNEL_DESTINATION.Name = "PERSONNEL_DESTINATION"
        Me.PERSONNEL_DESTINATION.ReadOnly = True
        Me.PERSONNEL_DESTINATION.Visible = False
        '
        'ADMIN_POSITION
        '
        Me.ADMIN_POSITION.DataPropertyName = "admin_position"
        Me.ADMIN_POSITION.HeaderText = "Admin Position"
        Me.ADMIN_POSITION.Name = "ADMIN_POSITION"
        Me.ADMIN_POSITION.ReadOnly = True
        Me.ADMIN_POSITION.Visible = False
        '
        'JOB_TYPE
        '
        Me.JOB_TYPE.DataPropertyName = "job_type"
        Me.JOB_TYPE.HeaderText = "Job Type"
        Me.JOB_TYPE.Name = "JOB_TYPE"
        Me.JOB_TYPE.ReadOnly = True
        '
        'TIN_NUMBER
        '
        Me.TIN_NUMBER.DataPropertyName = "tin_no"
        Me.TIN_NUMBER.HeaderText = "TIN"
        Me.TIN_NUMBER.Name = "TIN_NUMBER"
        Me.TIN_NUMBER.ReadOnly = True
        Me.TIN_NUMBER.Visible = False
        '
        'PAGIBIG_NUMBER
        '
        Me.PAGIBIG_NUMBER.DataPropertyName = "pagibig_no"
        Me.PAGIBIG_NUMBER.HeaderText = "PAG-IBIG"
        Me.PAGIBIG_NUMBER.Name = "PAGIBIG_NUMBER"
        Me.PAGIBIG_NUMBER.ReadOnly = True
        Me.PAGIBIG_NUMBER.Visible = False
        '
        'SSS_NUMBER
        '
        Me.SSS_NUMBER.DataPropertyName = "sss_no"
        Me.SSS_NUMBER.HeaderText = "SSS"
        Me.SSS_NUMBER.Name = "SSS_NUMBER"
        Me.SSS_NUMBER.ReadOnly = True
        Me.SSS_NUMBER.Visible = False
        '
        'DATE_HIRED
        '
        Me.DATE_HIRED.DataPropertyName = "date_hired"
        Me.DATE_HIRED.HeaderText = "Date Hired"
        Me.DATE_HIRED.Name = "DATE_HIRED"
        Me.DATE_HIRED.ReadOnly = True
        '
        'EMPLOYMENT_STATUS
        '
        Me.EMPLOYMENT_STATUS.DataPropertyName = "employment_status"
        Me.EMPLOYMENT_STATUS.HeaderText = "Employment Status"
        Me.EMPLOYMENT_STATUS.Name = "EMPLOYMENT_STATUS"
        Me.EMPLOYMENT_STATUS.ReadOnly = True
        Me.EMPLOYMENT_STATUS.Visible = False
        '
        'CONTACT
        '
        Me.CONTACT.DataPropertyName = "contact_number"
        Me.CONTACT.HeaderText = "Contact Number"
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.ReadOnly = True
        Me.CONTACT.Visible = False
        '
        'ADDRESS
        '
        Me.ADDRESS.DataPropertyName = "address"
        Me.ADDRESS.HeaderText = "Address"
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        Me.ADDRESS.Visible = False
        '
        'CIVIL_STATUS
        '
        Me.CIVIL_STATUS.DataPropertyName = "civilstatus"
        Me.CIVIL_STATUS.HeaderText = "Civil Status"
        Me.CIVIL_STATUS.Name = "CIVIL_STATUS"
        Me.CIVIL_STATUS.ReadOnly = True
        Me.CIVIL_STATUS.Visible = False
        '
        'BIRTHDATE
        '
        Me.BIRTHDATE.DataPropertyName = "birthdate"
        Me.BIRTHDATE.HeaderText = "Birth Date"
        Me.BIRTHDATE.Name = "BIRTHDATE"
        Me.BIRTHDATE.ReadOnly = True
        Me.BIRTHDATE.Visible = False
        '
        'SEX
        '
        Me.SEX.DataPropertyName = "sex"
        Me.SEX.HeaderText = "Sex"
        Me.SEX.Name = "SEX"
        Me.SEX.ReadOnly = True
        '
        'LAST_NAME
        '
        Me.LAST_NAME.DataPropertyName = "lastname"
        Me.LAST_NAME.HeaderText = "Last Name"
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.ReadOnly = True
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.DataPropertyName = "middlename"
        Me.MIDDLE_NAME.HeaderText = "Middle Name"
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.ReadOnly = True
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.DataPropertyName = "firstname"
        Me.FIRST_NAME.HeaderText = "First Name"
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.ReadOnly = True
        '
        'EMPLOYEE_ID
        '
        Me.EMPLOYEE_ID.DataPropertyName = "employee_id"
        Me.EMPLOYEE_ID.HeaderText = "ID"
        Me.EMPLOYEE_ID.Name = "EMPLOYEE_ID"
        Me.EMPLOYEE_ID.ReadOnly = True
        Me.EMPLOYEE_ID.Visible = False
        '
        'EmpDGV
        '
        Me.EmpDGV.AllowUserToAddRows = False
        Me.EmpDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EmpDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmpDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpDGV.BackgroundColor = System.Drawing.Color.White
        Me.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmpDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmpDGV.ColumnHeadersHeight = 48
        Me.EmpDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEE_ID, Me.FIRST_NAME, Me.MIDDLE_NAME, Me.LAST_NAME, Me.SEX, Me.BIRTHDATE, Me.CIVIL_STATUS, Me.ADDRESS, Me.CONTACT, Me.EMPLOYMENT_STATUS, Me.DATE_HIRED, Me.SSS_NUMBER, Me.PAGIBIG_NUMBER, Me.TIN_NUMBER, Me.JOB_TYPE, Me.ADMIN_POSITION, Me.PERSONNEL_DESTINATION, Me.IMG_PATH, Me.EMAIL, Me.PASSWORD, Me.ADDED_BY, Me.ADDED_BY_NAME, Me.ARCHIVED, Me.ARCHIVED_BY, Me.LAST_ACCESSED, Me.DATE_ADDED, Me.DATE_ARCHIVED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmpDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmpDGV.EnableHeadersVisualStyles = False
        Me.EmpDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EmpDGV.Location = New System.Drawing.Point(21, 70)
        Me.EmpDGV.Name = "EmpDGV"
        Me.EmpDGV.ReadOnly = True
        Me.EmpDGV.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.EmpDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpDGV.Size = New System.Drawing.Size(968, 479)
        Me.EmpDGV.TabIndex = 30
        Me.EmpDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.EmpDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.EmpDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.EmpDGV.ThemeStyle.ReadOnly = True
        Me.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmpDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.EmpDGV.ThemeStyle.RowsStyle.Height = 22
        Me.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.Controls.Add(Me.EmpDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1920, 1050)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.EmpDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdminSidenavPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteEmployeeBtn As Button
    Friend WithEvents ArchiveEmployeeBtn As Button
    Friend WithEvents EditEmployeeBtn As Button
    Friend WithEvents AddEmployeeBtn As Button
    Friend WithEvents ViewEmployeeBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ShowArchiveCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SearchComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents LAST_ACCESSED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY_NAME As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents IMG_PATH As DataGridViewTextBoxColumn
    Friend WithEvents PERSONNEL_DESTINATION As DataGridViewTextBoxColumn
    Friend WithEvents ADMIN_POSITION As DataGridViewTextBoxColumn
    Friend WithEvents JOB_TYPE As DataGridViewTextBoxColumn
    Friend WithEvents TIN_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents PAGIBIG_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents SSS_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents DATE_HIRED As DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYMENT_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents CIVIL_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents SEX As DataGridViewTextBoxColumn
    Friend WithEvents LAST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYEE_ID As DataGridViewTextBoxColumn
    Friend WithEvents EmpDGV As Guna.UI2.WinForms.Guna2DataGridView
End Class
