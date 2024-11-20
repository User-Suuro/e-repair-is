<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShowArchiveCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AdminSidenavPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteCustomerBtn = New System.Windows.Forms.Button()
        Me.ArchiveCustomerBtn = New System.Windows.Forms.Button()
        Me.EditCustomerBtn = New System.Windows.Forms.Button()
        Me.AddCustomerBtn = New System.Windows.Forms.Button()
        Me.ViewCustomerBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustomerDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_TRANSACTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1070, 28)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'ShowArchiveCheckBox
        '
        Me.ShowArchiveCheckBox.AutoSize = True
        Me.ShowArchiveCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.CheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.CheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowArchiveCheckBox.Location = New System.Drawing.Point(975, 3)
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(535, 28)
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
        Me.SearchComboBox.Items.AddRange(New Object() {"First Name", "Middle Name", "Last Name", "Contact Number", "Address", "Email", "Date Added"})
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
        'AdminSidenavPanel
        '
        Me.AdminSidenavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AdminSidenavPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.AdminSidenavPanel.Controls.Add(Me.Panel1)
        Me.AdminSidenavPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.AdminSidenavPanel.Location = New System.Drawing.Point(1099, 0)
        Me.AdminSidenavPanel.Name = "AdminSidenavPanel"
        Me.AdminSidenavPanel.Size = New System.Drawing.Size(65, 611)
        Me.AdminSidenavPanel.TabIndex = 35
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteCustomerBtn)
        Me.Panel3.Controls.Add(Me.ArchiveCustomerBtn)
        Me.Panel3.Controls.Add(Me.EditCustomerBtn)
        Me.Panel3.Controls.Add(Me.AddCustomerBtn)
        Me.Panel3.Controls.Add(Me.ViewCustomerBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 427)
        Me.Panel3.TabIndex = 0
        '
        'DeleteCustomerBtn
        '
        Me.DeleteCustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteCustomerBtn.FlatAppearance.BorderSize = 0
        Me.DeleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteCustomerBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteCustomerBtn.Location = New System.Drawing.Point(0, 300)
        Me.DeleteCustomerBtn.Name = "DeleteCustomerBtn"
        Me.DeleteCustomerBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteCustomerBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteCustomerBtn.TabIndex = 29
        Me.DeleteCustomerBtn.Text = "Delete"
        Me.DeleteCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteCustomerBtn.UseVisualStyleBackColor = True
        Me.DeleteCustomerBtn.Visible = False
        '
        'ArchiveCustomerBtn
        '
        Me.ArchiveCustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveCustomerBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchiveCustomerBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchiveCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchiveCustomerBtn.Location = New System.Drawing.Point(0, 225)
        Me.ArchiveCustomerBtn.Name = "ArchiveCustomerBtn"
        Me.ArchiveCustomerBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveCustomerBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveCustomerBtn.TabIndex = 28
        Me.ArchiveCustomerBtn.TabStop = False
        Me.ArchiveCustomerBtn.Text = "Archive"
        Me.ArchiveCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchiveCustomerBtn.UseVisualStyleBackColor = True
        '
        'EditCustomerBtn
        '
        Me.EditCustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditCustomerBtn.FlatAppearance.BorderSize = 0
        Me.EditCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditCustomerBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EditCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditCustomerBtn.Location = New System.Drawing.Point(0, 150)
        Me.EditCustomerBtn.Name = "EditCustomerBtn"
        Me.EditCustomerBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditCustomerBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditCustomerBtn.TabIndex = 27
        Me.EditCustomerBtn.Text = "Edit"
        Me.EditCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditCustomerBtn.UseVisualStyleBackColor = True
        '
        'AddCustomerBtn
        '
        Me.AddCustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddCustomerBtn.FlatAppearance.BorderSize = 0
        Me.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddCustomerBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddCustomerBtn.Location = New System.Drawing.Point(0, 75)
        Me.AddCustomerBtn.Name = "AddCustomerBtn"
        Me.AddCustomerBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddCustomerBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddCustomerBtn.TabIndex = 26
        Me.AddCustomerBtn.Text = "Add"
        Me.AddCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddCustomerBtn.UseVisualStyleBackColor = True
        '
        'ViewCustomerBtn
        '
        Me.ViewCustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewCustomerBtn.FlatAppearance.BorderSize = 0
        Me.ViewCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewCustomerBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewCustomerBtn.Location = New System.Drawing.Point(0, 0)
        Me.ViewCustomerBtn.Name = "ViewCustomerBtn"
        Me.ViewCustomerBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewCustomerBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewCustomerBtn.TabIndex = 19
        Me.ViewCustomerBtn.Text = "Details"
        Me.ViewCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewCustomerBtn.UseVisualStyleBackColor = True
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
        'CustomerDGV
        '
        Me.CustomerDGV.AllowUserToAddRows = False
        Me.CustomerDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CustomerDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerDGV.BackgroundColor = System.Drawing.Color.White
        Me.CustomerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDGV.ColumnHeadersHeight = 48
        Me.CustomerDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMER_ID, Me.FIRST_NAME, Me.MIDDLE_NAME, Me.LAST_NAME, Me.CONTACT_NUMBER, Me.ADDRESS, Me.GENDER, Me.EMAIL, Me.TOTAL_PAID, Me.LAST_TRANSACTION, Me.ARCHIVED, Me.ARCHIVED_BY, Me.DATE_ARCHIVED, Me.ADDED_BY, Me.DATE_ADDED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerDGV.EnableHeadersVisualStyles = False
        Me.CustomerDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.CustomerDGV.Location = New System.Drawing.Point(11, 61)
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.ReadOnly = True
        Me.CustomerDGV.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDGV.Size = New System.Drawing.Size(1070, 497)
        Me.CustomerDGV.TabIndex = 34
        Me.CustomerDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CustomerDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CustomerDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.CustomerDGV.ThemeStyle.ReadOnly = True
        Me.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.CustomerDGV.ThemeStyle.RowsStyle.Height = 22
        Me.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.DataPropertyName = "customer_id"
        Me.CUSTOMER_ID.HeaderText = "Customer ID"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.ReadOnly = True
        Me.CUSTOMER_ID.Visible = False
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.DataPropertyName = "first_name"
        Me.FIRST_NAME.HeaderText = "First Name"
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.ReadOnly = True
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.DataPropertyName = "middle_name"
        Me.MIDDLE_NAME.HeaderText = "Middle Name"
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.ReadOnly = True
        '
        'LAST_NAME
        '
        Me.LAST_NAME.DataPropertyName = "last_name"
        Me.LAST_NAME.HeaderText = "Last Name"
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.ReadOnly = True
        '
        'CONTACT_NUMBER
        '
        Me.CONTACT_NUMBER.DataPropertyName = "contact_number"
        Me.CONTACT_NUMBER.HeaderText = "Contact Number"
        Me.CONTACT_NUMBER.Name = "CONTACT_NUMBER"
        Me.CONTACT_NUMBER.ReadOnly = True
        '
        'ADDRESS
        '
        Me.ADDRESS.DataPropertyName = "address"
        Me.ADDRESS.HeaderText = "Address"
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        '
        'GENDER
        '
        Me.GENDER.DataPropertyName = "gender"
        Me.GENDER.HeaderText = "Gender"
        Me.GENDER.Name = "GENDER"
        Me.GENDER.ReadOnly = True
        Me.GENDER.Visible = False
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "email"
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'TOTAL_PAID
        '
        Me.TOTAL_PAID.DataPropertyName = "total_paid"
        Me.TOTAL_PAID.HeaderText = "Total Paid"
        Me.TOTAL_PAID.Name = "TOTAL_PAID"
        Me.TOTAL_PAID.ReadOnly = True
        Me.TOTAL_PAID.Visible = False
        '
        'LAST_TRANSACTION
        '
        Me.LAST_TRANSACTION.DataPropertyName = "last_transaction"
        Me.LAST_TRANSACTION.HeaderText = "Last Transaction Date"
        Me.LAST_TRANSACTION.Name = "LAST_TRANSACTION"
        Me.LAST_TRANSACTION.ReadOnly = True
        '
        'ARCHIVED
        '
        Me.ARCHIVED.DataPropertyName = "archived"
        Me.ARCHIVED.HeaderText = "Archived"
        Me.ARCHIVED.Name = "ARCHIVED"
        Me.ARCHIVED.ReadOnly = True
        Me.ARCHIVED.Visible = False
        '
        'ARCHIVED_BY
        '
        Me.ARCHIVED_BY.DataPropertyName = "archived_by"
        Me.ARCHIVED_BY.HeaderText = "Archived By"
        Me.ARCHIVED_BY.Name = "ARCHIVED_BY"
        Me.ARCHIVED_BY.ReadOnly = True
        Me.ARCHIVED_BY.Visible = False
        '
        'DATE_ARCHIVED
        '
        Me.DATE_ARCHIVED.DataPropertyName = "date_archived"
        Me.DATE_ARCHIVED.HeaderText = "Date Archived"
        Me.DATE_ARCHIVED.Name = "DATE_ARCHIVED"
        Me.DATE_ARCHIVED.ReadOnly = True
        Me.DATE_ARCHIVED.Visible = False
        '
        'ADDED_BY
        '
        Me.ADDED_BY.DataPropertyName = "added_by"
        Me.ADDED_BY.HeaderText = "Added By"
        Me.ADDED_BY.Name = "ADDED_BY"
        Me.ADDED_BY.ReadOnly = True
        Me.ADDED_BY.Visible = False
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
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
        Me.BtnSelect.Location = New System.Drawing.Point(974, 568)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.ShadowDecoration.Parent = Me.BtnSelect
        Me.BtnSelect.Size = New System.Drawing.Size(107, 32)
        Me.BtnSelect.TabIndex = 38
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
        Me.BtnClose.Location = New System.Drawing.Point(12, 571)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 37
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'AdminCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.Controls.Add(Me.CustomerDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminCustomerForm"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ShowArchiveCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AdminSidenavPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteCustomerBtn As Button
    Friend WithEvents ArchiveCustomerBtn As Button
    Friend WithEvents EditCustomerBtn As Button
    Friend WithEvents AddCustomerBtn As Button
    Friend WithEvents ViewCustomerBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustomerDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CUSTOMER_ID As DataGridViewTextBoxColumn
    Friend WithEvents FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents LAST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents GENDER As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PAID As DataGridViewTextBoxColumn
    Friend WithEvents LAST_TRANSACTION As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
End Class
