<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliersForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AdminSidenavPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SupplierExportBtn = New System.Windows.Forms.Button()
        Me.DeleteSupplierBtn = New System.Windows.Forms.Button()
        Me.ArchiveSupplierBtn = New System.Windows.Forms.Button()
        Me.EditSupplierBtn = New System.Windows.Forms.Button()
        Me.AddSupplierBtn = New System.Windows.Forms.Button()
        Me.ViewSupplierBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuppliersDGV = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.TOTAL_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIED_ITEMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PICTURE_PATH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.ShowArchiveCheckbox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.AdminSidenavPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SuppliersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ShowArchiveCheckbox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(986, 28)
        Me.TableLayoutPanel1.TabIndex = 36
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
        Me.SearchComboBox.FocusedState.Parent = Me.SearchComboBox
        Me.SearchComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SearchComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.HoverState.Parent = Me.SearchComboBox
        Me.SearchComboBox.ItemHeight = 22
        Me.SearchComboBox.Items.AddRange(New Object() {"Company Name", "Contact Person", "Email", "Location", "Contract Type", "Total Paid", "Date Added"})
        Me.SearchComboBox.ItemsAppearance.Parent = Me.SearchComboBox
        Me.SearchComboBox.Location = New System.Drawing.Point(261, 0)
        Me.SearchComboBox.Margin = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.ShadowDecoration.Parent = Me.SearchComboBox
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
        Me.SearchTextBox.DisabledState.Parent = Me.SearchTextBox
        Me.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.FocusedState.Parent = Me.SearchTextBox
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.AdminSidenavPanel.Location = New System.Drawing.Point(1015, 0)
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SupplierExportBtn)
        Me.Panel3.Controls.Add(Me.DeleteSupplierBtn)
        Me.Panel3.Controls.Add(Me.ArchiveSupplierBtn)
        Me.Panel3.Controls.Add(Me.EditSupplierBtn)
        Me.Panel3.Controls.Add(Me.AddSupplierBtn)
        Me.Panel3.Controls.Add(Me.ViewSupplierBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 450)
        Me.Panel3.TabIndex = 0
        '
        'SupplierExportBtn
        '
        Me.SupplierExportBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SupplierExportBtn.FlatAppearance.BorderSize = 0
        Me.SupplierExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierExportBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierExportBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SupplierExportBtn.Image = CType(resources.GetObject("SupplierExportBtn.Image"), System.Drawing.Image)
        Me.SupplierExportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SupplierExportBtn.Location = New System.Drawing.Point(0, 375)
        Me.SupplierExportBtn.Name = "SupplierExportBtn"
        Me.SupplierExportBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.SupplierExportBtn.Size = New System.Drawing.Size(65, 75)
        Me.SupplierExportBtn.TabIndex = 32
        Me.SupplierExportBtn.Text = "Report"
        Me.SupplierExportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SupplierExportBtn.UseVisualStyleBackColor = True
        '
        'DeleteSupplierBtn
        '
        Me.DeleteSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteSupplierBtn.FlatAppearance.BorderSize = 0
        Me.DeleteSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteSupplierBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteSupplierBtn.Location = New System.Drawing.Point(0, 300)
        Me.DeleteSupplierBtn.Name = "DeleteSupplierBtn"
        Me.DeleteSupplierBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteSupplierBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteSupplierBtn.TabIndex = 29
        Me.DeleteSupplierBtn.Text = "Delete"
        Me.DeleteSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteSupplierBtn.UseVisualStyleBackColor = True
        Me.DeleteSupplierBtn.Visible = False
        '
        'ArchiveSupplierBtn
        '
        Me.ArchiveSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveSupplierBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchiveSupplierBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchiveSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchiveSupplierBtn.Location = New System.Drawing.Point(0, 225)
        Me.ArchiveSupplierBtn.Name = "ArchiveSupplierBtn"
        Me.ArchiveSupplierBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveSupplierBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveSupplierBtn.TabIndex = 28
        Me.ArchiveSupplierBtn.TabStop = False
        Me.ArchiveSupplierBtn.Text = "Archive"
        Me.ArchiveSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchiveSupplierBtn.UseVisualStyleBackColor = True
        '
        'EditSupplierBtn
        '
        Me.EditSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditSupplierBtn.FlatAppearance.BorderSize = 0
        Me.EditSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EditSupplierBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EditSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditSupplierBtn.Location = New System.Drawing.Point(0, 150)
        Me.EditSupplierBtn.Name = "EditSupplierBtn"
        Me.EditSupplierBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditSupplierBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditSupplierBtn.TabIndex = 27
        Me.EditSupplierBtn.Text = "Edit"
        Me.EditSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditSupplierBtn.UseVisualStyleBackColor = True
        '
        'AddSupplierBtn
        '
        Me.AddSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddSupplierBtn.FlatAppearance.BorderSize = 0
        Me.AddSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddSupplierBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddSupplierBtn.Location = New System.Drawing.Point(0, 75)
        Me.AddSupplierBtn.Name = "AddSupplierBtn"
        Me.AddSupplierBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddSupplierBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddSupplierBtn.TabIndex = 26
        Me.AddSupplierBtn.Text = "Add"
        Me.AddSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddSupplierBtn.UseVisualStyleBackColor = True
        '
        'ViewSupplierBtn
        '
        Me.ViewSupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewSupplierBtn.FlatAppearance.BorderSize = 0
        Me.ViewSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSupplierBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewSupplierBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewSupplierBtn.Location = New System.Drawing.Point(0, 0)
        Me.ViewSupplierBtn.Name = "ViewSupplierBtn"
        Me.ViewSupplierBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewSupplierBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewSupplierBtn.TabIndex = 19
        Me.ViewSupplierBtn.Text = "Details"
        Me.ViewSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewSupplierBtn.UseVisualStyleBackColor = True
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
        'SuppliersDGV
        '
        Me.SuppliersDGV.AllowUserToAddRows = False
        Me.SuppliersDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SuppliersDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SuppliersDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuppliersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SuppliersDGV.BackgroundColor = System.Drawing.Color.White
        Me.SuppliersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SuppliersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SuppliersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SuppliersDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SuppliersDGV.ColumnHeadersHeight = 48
        Me.SuppliersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUPPLIER_ID, Me.COMPANY_NAME, Me.COMPANY_DESCRIPTION, Me.CONTACT_PERSON, Me.CONTACT_NUMBER, Me.COMPANY_EMAIL, Me.LOCATION, Me.SUPPLIER_TYPE, Me.SUPPLIER_CONTRACT, Me.BANK_DETAILS, Me.PAYMENT_TERMS, Me.ESTIMATED_DELIVERY_TIME, Me.TOTAL_PAID, Me.SUPPLIED_ITEMS, Me.PICTURE_PATH, Me.DATE_ADDED, Me.ADDED_BY, Me.ARCHIVED, Me.ARCHIVED_BY, Me.DATE_ARCHIVED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SuppliersDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.SuppliersDGV.EnableHeadersVisualStyles = False
        Me.SuppliersDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SuppliersDGV.Location = New System.Drawing.Point(12, 66)
        Me.SuppliersDGV.Name = "SuppliersDGV"
        Me.SuppliersDGV.ReadOnly = True
        Me.SuppliersDGV.RowHeadersVisible = False
        Me.SuppliersDGV.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.SuppliersDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SuppliersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SuppliersDGV.Size = New System.Drawing.Size(986, 495)
        Me.SuppliersDGV.TabIndex = 34
        Me.SuppliersDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SuppliersDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SuppliersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.SuppliersDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.SuppliersDGV.ThemeStyle.ReadOnly = True
        Me.SuppliersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.SuppliersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SuppliersDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SuppliersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.SuppliersDGV.ThemeStyle.RowsStyle.Height = 22
        Me.SuppliersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.SuppliersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'SUPPLIER_ID
        '
        Me.SUPPLIER_ID.DataPropertyName = "supplier_id"
        Me.SUPPLIER_ID.HeaderText = "ID"
        Me.SUPPLIER_ID.MinimumWidth = 6
        Me.SUPPLIER_ID.Name = "SUPPLIER_ID"
        Me.SUPPLIER_ID.ReadOnly = True
        Me.SUPPLIER_ID.Visible = False
        '
        'COMPANY_NAME
        '
        Me.COMPANY_NAME.DataPropertyName = "company_name"
        Me.COMPANY_NAME.HeaderText = "Company Name"
        Me.COMPANY_NAME.MinimumWidth = 6
        Me.COMPANY_NAME.Name = "COMPANY_NAME"
        Me.COMPANY_NAME.ReadOnly = True
        '
        'COMPANY_DESCRIPTION
        '
        Me.COMPANY_DESCRIPTION.DataPropertyName = "company_description"
        Me.COMPANY_DESCRIPTION.HeaderText = "Company Description"
        Me.COMPANY_DESCRIPTION.MinimumWidth = 6
        Me.COMPANY_DESCRIPTION.Name = "COMPANY_DESCRIPTION"
        Me.COMPANY_DESCRIPTION.ReadOnly = True
        Me.COMPANY_DESCRIPTION.Visible = False
        '
        'CONTACT_PERSON
        '
        Me.CONTACT_PERSON.DataPropertyName = "contact_person"
        Me.CONTACT_PERSON.HeaderText = "Contact Person"
        Me.CONTACT_PERSON.MinimumWidth = 6
        Me.CONTACT_PERSON.Name = "CONTACT_PERSON"
        Me.CONTACT_PERSON.ReadOnly = True
        '
        'CONTACT_NUMBER
        '
        Me.CONTACT_NUMBER.DataPropertyName = "contact_number"
        Me.CONTACT_NUMBER.HeaderText = "Contact Number"
        Me.CONTACT_NUMBER.MinimumWidth = 6
        Me.CONTACT_NUMBER.Name = "CONTACT_NUMBER"
        Me.CONTACT_NUMBER.ReadOnly = True
        Me.CONTACT_NUMBER.Visible = False
        '
        'COMPANY_EMAIL
        '
        Me.COMPANY_EMAIL.DataPropertyName = "company_email"
        Me.COMPANY_EMAIL.HeaderText = "Email"
        Me.COMPANY_EMAIL.MinimumWidth = 6
        Me.COMPANY_EMAIL.Name = "COMPANY_EMAIL"
        Me.COMPANY_EMAIL.ReadOnly = True
        '
        'LOCATION
        '
        Me.LOCATION.DataPropertyName = "location"
        Me.LOCATION.HeaderText = "Location"
        Me.LOCATION.MinimumWidth = 6
        Me.LOCATION.Name = "LOCATION"
        Me.LOCATION.ReadOnly = True
        '
        'SUPPLIER_TYPE
        '
        Me.SUPPLIER_TYPE.DataPropertyName = "supplier_type"
        Me.SUPPLIER_TYPE.HeaderText = "Supplier Type"
        Me.SUPPLIER_TYPE.MinimumWidth = 6
        Me.SUPPLIER_TYPE.Name = "SUPPLIER_TYPE"
        Me.SUPPLIER_TYPE.ReadOnly = True
        Me.SUPPLIER_TYPE.Visible = False
        '
        'SUPPLIER_CONTRACT
        '
        Me.SUPPLIER_CONTRACT.DataPropertyName = "supplier_contract"
        Me.SUPPLIER_CONTRACT.HeaderText = "Contract"
        Me.SUPPLIER_CONTRACT.MinimumWidth = 6
        Me.SUPPLIER_CONTRACT.Name = "SUPPLIER_CONTRACT"
        Me.SUPPLIER_CONTRACT.ReadOnly = True
        '
        'BANK_DETAILS
        '
        Me.BANK_DETAILS.DataPropertyName = "bank_details"
        Me.BANK_DETAILS.HeaderText = "Bank"
        Me.BANK_DETAILS.MinimumWidth = 6
        Me.BANK_DETAILS.Name = "BANK_DETAILS"
        Me.BANK_DETAILS.ReadOnly = True
        Me.BANK_DETAILS.Visible = False
        '
        'PAYMENT_TERMS
        '
        Me.PAYMENT_TERMS.DataPropertyName = "payment_terms"
        Me.PAYMENT_TERMS.HeaderText = "Payment Terms"
        Me.PAYMENT_TERMS.MinimumWidth = 6
        Me.PAYMENT_TERMS.Name = "PAYMENT_TERMS"
        Me.PAYMENT_TERMS.ReadOnly = True
        Me.PAYMENT_TERMS.Visible = False
        '
        'ESTIMATED_DELIVERY_TIME
        '
        Me.ESTIMATED_DELIVERY_TIME.DataPropertyName = "estimated_delivery_time"
        Me.ESTIMATED_DELIVERY_TIME.HeaderText = "Delivery Time"
        Me.ESTIMATED_DELIVERY_TIME.MinimumWidth = 6
        Me.ESTIMATED_DELIVERY_TIME.Name = "ESTIMATED_DELIVERY_TIME"
        Me.ESTIMATED_DELIVERY_TIME.ReadOnly = True
        Me.ESTIMATED_DELIVERY_TIME.Visible = False
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
        'SUPPLIED_ITEMS
        '
        Me.SUPPLIED_ITEMS.HeaderText = "Number of Supplied Items"
        Me.SUPPLIED_ITEMS.MinimumWidth = 6
        Me.SUPPLIED_ITEMS.Name = "SUPPLIED_ITEMS"
        Me.SUPPLIED_ITEMS.ReadOnly = True
        Me.SUPPLIED_ITEMS.Visible = False
        '
        'PICTURE_PATH
        '
        Me.PICTURE_PATH.DataPropertyName = "company_picture_path"
        Me.PICTURE_PATH.HeaderText = "Picture Path"
        Me.PICTURE_PATH.MinimumWidth = 6
        Me.PICTURE_PATH.Name = "PICTURE_PATH"
        Me.PICTURE_PATH.ReadOnly = True
        Me.PICTURE_PATH.Visible = False
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.MinimumWidth = 6
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'ADDED_BY
        '
        Me.ADDED_BY.DataPropertyName = "added_by"
        Me.ADDED_BY.HeaderText = "Added By"
        Me.ADDED_BY.MinimumWidth = 6
        Me.ADDED_BY.Name = "ADDED_BY"
        Me.ADDED_BY.ReadOnly = True
        Me.ADDED_BY.Visible = False
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
        Me.ARCHIVED_BY.HeaderText = "Archived By"
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
        Me.BtnSelect.CheckedState.Parent = Me.BtnSelect
        Me.BtnSelect.CustomImages.Parent = Me.BtnSelect
        Me.BtnSelect.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnSelect.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.HoverState.Parent = Me.BtnSelect
        Me.BtnSelect.Location = New System.Drawing.Point(891, 567)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.ShadowDecoration.Parent = Me.BtnSelect
        Me.BtnSelect.Size = New System.Drawing.Size(107, 32)
        Me.BtnSelect.TabIndex = 42
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
        Me.BtnClose.Location = New System.Drawing.Point(12, 567)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 41
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'ShowArchiveCheckbox
        '
        Me.ShowArchiveCheckbox.AutoSize = True
        Me.ShowArchiveCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckbox.CheckedState.BorderRadius = 2
        Me.ShowArchiveCheckbox.CheckedState.BorderThickness = 0
        Me.ShowArchiveCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckbox.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowArchiveCheckbox.Location = New System.Drawing.Point(891, 3)
        Me.ShowArchiveCheckbox.Name = "ShowArchiveCheckbox"
        Me.ShowArchiveCheckbox.Size = New System.Drawing.Size(92, 22)
        Me.ShowArchiveCheckbox.TabIndex = 37
        Me.ShowArchiveCheckbox.Text = "Show Archive"
        Me.ShowArchiveCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowArchiveCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckbox.UncheckedState.BorderRadius = 2
        Me.ShowArchiveCheckbox.UncheckedState.BorderThickness = 0
        Me.ShowArchiveCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowArchiveCheckbox.UseVisualStyleBackColor = True
        '
        'SuppliersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminSidenavPanel)
        Me.Controls.Add(Me.SuppliersDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuppliersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminSuppliersForm"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.AdminSidenavPanel.ResumeLayout(False)
        Me.AdminSidenavPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.SuppliersDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DeleteSupplierBtn As Button
    Friend WithEvents ArchiveSupplierBtn As Button
    Friend WithEvents EditSupplierBtn As Button
    Friend WithEvents AddSupplierBtn As Button
    Friend WithEvents ViewSupplierBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SuppliersDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents TOTAL_PAID As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIED_ITEMS As DataGridViewTextBoxColumn
    Friend WithEvents PICTURE_PATH As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents SupplierExportBtn As Button
    Friend WithEvents ShowArchiveCheckbox As Guna.UI2.WinForms.Guna2CheckBox
End Class
