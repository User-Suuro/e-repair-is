<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSuppliersForm
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
        Me.DeleteSuppliersBtn = New System.Windows.Forms.Button()
        Me.ArchiveSuppliersBtn = New System.Windows.Forms.Button()
        Me.EditSuppliersBtn = New System.Windows.Forms.Button()
        Me.AddSuppliersBtn = New System.Windows.Forms.Button()
        Me.ViewSuppliersBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SUPPLIER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANY_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANY_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT_PERSON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANY_EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIER_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIER_CONTRACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BANK_DETAILS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENT_TERMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTIMATED_DELIVERY_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBER_SUPPLIED_ITEMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.EmpDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
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
        Me.SearchComboBox.ItemsAppearance.Parent = Me.SearchComboBox
        Me.SearchComboBox.Location = New System.Drawing.Point(261, 0)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(12)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.ShadowDecoration.Parent = Me.SearchComboBox
        Me.SearchComboBox.Size = New System.Drawing.Size(154, 28)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 681)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteSuppliersBtn)
        Me.Panel3.Controls.Add(Me.ArchiveSuppliersBtn)
        Me.Panel3.Controls.Add(Me.EditSuppliersBtn)
        Me.Panel3.Controls.Add(Me.AddSuppliersBtn)
        Me.Panel3.Controls.Add(Me.ViewSuppliersBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 102)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 476)
        Me.Panel3.TabIndex = 0
        '
        'DeleteSuppliersBtn
        '
        Me.DeleteSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.DeleteSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteSuppliersBtn.Location = New System.Drawing.Point(0, 300)
        Me.DeleteSuppliersBtn.Name = "DeleteSuppliersBtn"
        Me.DeleteSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteSuppliersBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteSuppliersBtn.TabIndex = 29
        Me.DeleteSuppliersBtn.Text = "Delete"
        Me.DeleteSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteSuppliersBtn.UseVisualStyleBackColor = True
        Me.DeleteSuppliersBtn.Visible = False
        '
        'ArchiveSuppliersBtn
        '
        Me.ArchiveSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchiveSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchiveSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchiveSuppliersBtn.Location = New System.Drawing.Point(0, 225)
        Me.ArchiveSuppliersBtn.Name = "ArchiveSuppliersBtn"
        Me.ArchiveSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveSuppliersBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveSuppliersBtn.TabIndex = 28
        Me.ArchiveSuppliersBtn.TabStop = False
        Me.ArchiveSuppliersBtn.Text = "Archive"
        Me.ArchiveSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchiveSuppliersBtn.UseVisualStyleBackColor = True
        '
        'EditSuppliersBtn
        '
        Me.EditSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.EditSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EditSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditSuppliersBtn.Location = New System.Drawing.Point(0, 150)
        Me.EditSuppliersBtn.Name = "EditSuppliersBtn"
        Me.EditSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditSuppliersBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditSuppliersBtn.TabIndex = 27
        Me.EditSuppliersBtn.Text = "Edit"
        Me.EditSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditSuppliersBtn.UseVisualStyleBackColor = True
        '
        'AddSuppliersBtn
        '
        Me.AddSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.AddSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddSuppliersBtn.Location = New System.Drawing.Point(0, 75)
        Me.AddSuppliersBtn.Name = "AddSuppliersBtn"
        Me.AddSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddSuppliersBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddSuppliersBtn.TabIndex = 26
        Me.AddSuppliersBtn.Text = "Add"
        Me.AddSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddSuppliersBtn.UseVisualStyleBackColor = True
        '
        'ViewSuppliersBtn
        '
        Me.ViewSuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewSuppliersBtn.FlatAppearance.BorderSize = 0
        Me.ViewSuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewSuppliersBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSuppliersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewSuppliersBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewSuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewSuppliersBtn.Location = New System.Drawing.Point(0, 0)
        Me.ViewSuppliersBtn.Name = "ViewSuppliersBtn"
        Me.ViewSuppliersBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewSuppliersBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewSuppliersBtn.TabIndex = 19
        Me.ViewSuppliersBtn.Text = "Details"
        Me.ViewSuppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewSuppliersBtn.UseVisualStyleBackColor = True
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
        'EmpDGV
        '
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
        Me.EmpDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUPPLIER_ID, Me.COMPANY_NAME, Me.COMPANY_DESCRIPTION, Me.CONTACT_PERSON, Me.CONTACT_NUMBER, Me.COMPANY_EMAIL, Me.LOCATION, Me.SUPPLIER_TYPE, Me.SUPPLIER_CONTRACT, Me.BANK_DETAILS, Me.PAYMENT_TERMS, Me.ESTIMATED_DELIVERY_TIME, Me.NUMBER_SUPPLIED_ITEMS, Me.TOTAL_PAID, Me.DATE_ADDED, Me.ARCHIVED_STATUS, Me.DATE_ARCHIVED})
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
        Me.EmpDGV.Location = New System.Drawing.Point(12, 61)
        Me.EmpDGV.Name = "EmpDGV"
        Me.EmpDGV.ReadOnly = True
        Me.EmpDGV.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.EmpDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpDGV.Size = New System.Drawing.Size(1070, 512)
        Me.EmpDGV.TabIndex = 34
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
        'SUPPLIER_ID
        '
        Me.SUPPLIER_ID.DataPropertyName = "supplier_id"
        Me.SUPPLIER_ID.HeaderText = "ID"
        Me.SUPPLIER_ID.Name = "SUPPLIER_ID"
        Me.SUPPLIER_ID.ReadOnly = True
        Me.SUPPLIER_ID.Visible = False
        '
        'COMPANY_NAME
        '
        Me.COMPANY_NAME.DataPropertyName = "company_name"
        Me.COMPANY_NAME.HeaderText = "Company Name"
        Me.COMPANY_NAME.Name = "COMPANY_NAME"
        Me.COMPANY_NAME.ReadOnly = True
        '
        'COMPANY_DESCRIPTION
        '
        Me.COMPANY_DESCRIPTION.DataPropertyName = "company_description"
        Me.COMPANY_DESCRIPTION.HeaderText = "Company Description"
        Me.COMPANY_DESCRIPTION.Name = "COMPANY_DESCRIPTION"
        Me.COMPANY_DESCRIPTION.ReadOnly = True
        Me.COMPANY_DESCRIPTION.Visible = False
        '
        'CONTACT_PERSON
        '
        Me.CONTACT_PERSON.DataPropertyName = "contact_person"
        Me.CONTACT_PERSON.HeaderText = "Contact Person"
        Me.CONTACT_PERSON.Name = "CONTACT_PERSON"
        Me.CONTACT_PERSON.ReadOnly = True
        '
        'CONTACT_NUMBER
        '
        Me.CONTACT_NUMBER.DataPropertyName = "contact_number"
        Me.CONTACT_NUMBER.HeaderText = "Contact Number"
        Me.CONTACT_NUMBER.Name = "CONTACT_NUMBER"
        Me.CONTACT_NUMBER.ReadOnly = True
        Me.CONTACT_NUMBER.Visible = False
        '
        'COMPANY_EMAIL
        '
        Me.COMPANY_EMAIL.DataPropertyName = "company_email"
        Me.COMPANY_EMAIL.HeaderText = "Email"
        Me.COMPANY_EMAIL.Name = "COMPANY_EMAIL"
        Me.COMPANY_EMAIL.ReadOnly = True
        '
        'LOCATION
        '
        Me.LOCATION.DataPropertyName = "location"
        Me.LOCATION.HeaderText = "Location"
        Me.LOCATION.Name = "LOCATION"
        Me.LOCATION.ReadOnly = True
        '
        'SUPPLIER_TYPE
        '
        Me.SUPPLIER_TYPE.DataPropertyName = "supplier_type"
        Me.SUPPLIER_TYPE.HeaderText = "Supplier Type"
        Me.SUPPLIER_TYPE.Name = "SUPPLIER_TYPE"
        Me.SUPPLIER_TYPE.ReadOnly = True
        '
        'SUPPLIER_CONTRACT
        '
        Me.SUPPLIER_CONTRACT.DataPropertyName = "supplier_contract"
        Me.SUPPLIER_CONTRACT.HeaderText = "Contract"
        Me.SUPPLIER_CONTRACT.Name = "SUPPLIER_CONTRACT"
        Me.SUPPLIER_CONTRACT.ReadOnly = True
        '
        'BANK_DETAILS
        '
        Me.BANK_DETAILS.DataPropertyName = "bank_details"
        Me.BANK_DETAILS.HeaderText = "Bank"
        Me.BANK_DETAILS.Name = "BANK_DETAILS"
        Me.BANK_DETAILS.ReadOnly = True
        Me.BANK_DETAILS.Visible = False
        '
        'PAYMENT_TERMS
        '
        Me.PAYMENT_TERMS.DataPropertyName = "payment_terms"
        Me.PAYMENT_TERMS.HeaderText = "Payment Terms"
        Me.PAYMENT_TERMS.Name = "PAYMENT_TERMS"
        Me.PAYMENT_TERMS.ReadOnly = True
        Me.PAYMENT_TERMS.Visible = False
        '
        'ESTIMATED_DELIVERY_TIME
        '
        Me.ESTIMATED_DELIVERY_TIME.DataPropertyName = "estimated_delivery_time"
        Me.ESTIMATED_DELIVERY_TIME.HeaderText = "Delivery Time"
        Me.ESTIMATED_DELIVERY_TIME.Name = "ESTIMATED_DELIVERY_TIME"
        Me.ESTIMATED_DELIVERY_TIME.ReadOnly = True
        Me.ESTIMATED_DELIVERY_TIME.Visible = False
        '
        'NUMBER_SUPPLIED_ITEMS
        '
        Me.NUMBER_SUPPLIED_ITEMS.DataPropertyName = "no_supplied_item"
        Me.NUMBER_SUPPLIED_ITEMS.HeaderText = "Supplied Items"
        Me.NUMBER_SUPPLIED_ITEMS.Name = "NUMBER_SUPPLIED_ITEMS"
        Me.NUMBER_SUPPLIED_ITEMS.ReadOnly = True
        '
        'TOTAL_PAID
        '
        Me.TOTAL_PAID.DataPropertyName = "total_paid"
        Me.TOTAL_PAID.HeaderText = "Total Paid"
        Me.TOTAL_PAID.Name = "TOTAL_PAID"
        Me.TOTAL_PAID.ReadOnly = True
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'ARCHIVED_STATUS
        '
        Me.ARCHIVED_STATUS.DataPropertyName = "archived_status"
        Me.ARCHIVED_STATUS.HeaderText = "Archived Status"
        Me.ARCHIVED_STATUS.Name = "ARCHIVED_STATUS"
        Me.ARCHIVED_STATUS.ReadOnly = True
        Me.ARCHIVED_STATUS.Visible = False
        '
        'DATE_ARCHIVED
        '
        Me.DATE_ARCHIVED.DataPropertyName = "date_archived"
        Me.DATE_ARCHIVED.HeaderText = "Date Archived"
        Me.DATE_ARCHIVED.Name = "DATE_ARCHIVED"
        Me.DATE_ARCHIVED.ReadOnly = True
        Me.DATE_ARCHIVED.Visible = False
        '
        'AdminSuppliersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.Controls.Add(Me.EmpDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminSuppliersForm"
        Me.Text = "AdminSuppliersForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.EmpDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DeleteSuppliersBtn As Button
    Friend WithEvents ArchiveSuppliersBtn As Button
    Friend WithEvents EditSuppliersBtn As Button
    Friend WithEvents AddSuppliersBtn As Button
    Friend WithEvents ViewSuppliersBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SUPPLIER_ID As DataGridViewTextBoxColumn
    Friend WithEvents COMPANY_NAME As DataGridViewTextBoxColumn
    Friend WithEvents COMPANY_DESCRIPTION As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT_PERSON As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents COMPANY_EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents LOCATION As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIER_TYPE As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIER_CONTRACT As DataGridViewTextBoxColumn
    Friend WithEvents BANK_DETAILS As DataGridViewTextBoxColumn
    Friend WithEvents PAYMENT_TERMS As DataGridViewTextBoxColumn
    Friend WithEvents ESTIMATED_DELIVERY_TIME As DataGridViewTextBoxColumn
    Friend WithEvents NUMBER_SUPPLIED_ITEMS As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PAID As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
End Class
