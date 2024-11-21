<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Me.SeeSuppliedItemsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ITEM_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIAL_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HAZARDOUS_CLASSIFICATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_VALUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHYSICAL_LOCATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESTOCK_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShowArchiveCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.ArchiveEmployeeBtn = New System.Windows.Forms.Button()
        Me.EditEmployeeBtn = New System.Windows.Forms.Button()
        Me.AddEmployeeBtn = New System.Windows.Forms.Button()
        Me.ViewEmployeeBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.SeeSuppliedItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeeSuppliedItemsDGV
        '
        Me.SeeSuppliedItemsDGV.AllowUserToAddRows = False
        Me.SeeSuppliedItemsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SeeSuppliedItemsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SeeSuppliedItemsDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeeSuppliedItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SeeSuppliedItemsDGV.BackgroundColor = System.Drawing.Color.White
        Me.SeeSuppliedItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SeeSuppliedItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SeeSuppliedItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SeeSuppliedItemsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SeeSuppliedItemsDGV.ColumnHeadersHeight = 48
        Me.SeeSuppliedItemsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_ID, Me.SERVICE_ID, Me.SUPPLIER_ID, Me.ITEM_CATEGORY, Me.ITEM_NAME, Me.ITEM_DESCRIPTION, Me.SERIAL_NUMBER, Me.HAZARDOUS_CLASSIFICATION, Me.QUANTITY, Me.TOTAL_VALUE, Me.ITEM_STATUS, Me.PHYSICAL_LOCATION, Me.RESTOCK_DATE, Me.DATE_ADDED, Me.ADDED_BY, Me.ARCHIVED, Me.ARCHIVED_BY, Me.DATE_ARCHIVED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SeeSuppliedItemsDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.SeeSuppliedItemsDGV.EnableHeadersVisualStyles = False
        Me.SeeSuppliedItemsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SeeSuppliedItemsDGV.Location = New System.Drawing.Point(27, 55)
        Me.SeeSuppliedItemsDGV.Name = "SeeSuppliedItemsDGV"
        Me.SeeSuppliedItemsDGV.ReadOnly = True
        Me.SeeSuppliedItemsDGV.RowHeadersVisible = False
        Me.SeeSuppliedItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SeeSuppliedItemsDGV.Size = New System.Drawing.Size(960, 505)
        Me.SeeSuppliedItemsDGV.TabIndex = 37
        Me.SeeSuppliedItemsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.SeeSuppliedItemsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SeeSuppliedItemsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SeeSuppliedItemsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SeeSuppliedItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SeeSuppliedItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SeeSuppliedItemsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SeeSuppliedItemsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.SeeSuppliedItemsDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.SeeSuppliedItemsDGV.ThemeStyle.ReadOnly = True
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.Height = 22
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.SeeSuppliedItemsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ITEM_ID
        '
        Me.ITEM_ID.DataPropertyName = "item_id"
        Me.ITEM_ID.HeaderText = "Item ID"
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.ReadOnly = True
        Me.ITEM_ID.Visible = False
        '
        'SERVICE_ID
        '
        Me.SERVICE_ID.DataPropertyName = "service_id"
        Me.SERVICE_ID.HeaderText = "Service ID"
        Me.SERVICE_ID.Name = "SERVICE_ID"
        Me.SERVICE_ID.ReadOnly = True
        Me.SERVICE_ID.Visible = False
        '
        'SUPPLIER_ID
        '
        Me.SUPPLIER_ID.DataPropertyName = "supplied_id"
        Me.SUPPLIER_ID.HeaderText = "Supplier ID"
        Me.SUPPLIER_ID.Name = "SUPPLIER_ID"
        Me.SUPPLIER_ID.ReadOnly = True
        Me.SUPPLIER_ID.Visible = False
        '
        'ITEM_CATEGORY
        '
        Me.ITEM_CATEGORY.DataPropertyName = "item_category"
        Me.ITEM_CATEGORY.HeaderText = "Category"
        Me.ITEM_CATEGORY.Name = "ITEM_CATEGORY"
        Me.ITEM_CATEGORY.ReadOnly = True
        '
        'ITEM_NAME
        '
        Me.ITEM_NAME.DataPropertyName = "item_name"
        Me.ITEM_NAME.HeaderText = "Item Name"
        Me.ITEM_NAME.Name = "ITEM_NAME"
        Me.ITEM_NAME.ReadOnly = True
        '
        'ITEM_DESCRIPTION
        '
        Me.ITEM_DESCRIPTION.DataPropertyName = "item_description"
        Me.ITEM_DESCRIPTION.HeaderText = "Item Description"
        Me.ITEM_DESCRIPTION.Name = "ITEM_DESCRIPTION"
        Me.ITEM_DESCRIPTION.ReadOnly = True
        Me.ITEM_DESCRIPTION.Visible = False
        '
        'SERIAL_NUMBER
        '
        Me.SERIAL_NUMBER.DataPropertyName = "serial_number"
        Me.SERIAL_NUMBER.HeaderText = "Serial Number"
        Me.SERIAL_NUMBER.Name = "SERIAL_NUMBER"
        Me.SERIAL_NUMBER.ReadOnly = True
        Me.SERIAL_NUMBER.Visible = False
        '
        'HAZARDOUS_CLASSIFICATION
        '
        Me.HAZARDOUS_CLASSIFICATION.DataPropertyName = "hazardous_classification"
        Me.HAZARDOUS_CLASSIFICATION.HeaderText = "Hazardous Classification"
        Me.HAZARDOUS_CLASSIFICATION.Name = "HAZARDOUS_CLASSIFICATION"
        Me.HAZARDOUS_CLASSIFICATION.ReadOnly = True
        Me.HAZARDOUS_CLASSIFICATION.Visible = False
        '
        'QUANTITY
        '
        Me.QUANTITY.DataPropertyName = "quantity"
        Me.QUANTITY.HeaderText = "Quantity"
        Me.QUANTITY.Name = "QUANTITY"
        Me.QUANTITY.ReadOnly = True
        '
        'TOTAL_VALUE
        '
        Me.TOTAL_VALUE.DataPropertyName = "total_value"
        Me.TOTAL_VALUE.HeaderText = "Total Value"
        Me.TOTAL_VALUE.Name = "TOTAL_VALUE"
        Me.TOTAL_VALUE.ReadOnly = True
        '
        'ITEM_STATUS
        '
        Me.ITEM_STATUS.DataPropertyName = "item_status"
        Me.ITEM_STATUS.HeaderText = "Item Status"
        Me.ITEM_STATUS.Name = "ITEM_STATUS"
        Me.ITEM_STATUS.ReadOnly = True
        '
        'PHYSICAL_LOCATION
        '
        Me.PHYSICAL_LOCATION.DataPropertyName = "physical_location"
        Me.PHYSICAL_LOCATION.HeaderText = "Physical Location"
        Me.PHYSICAL_LOCATION.Name = "PHYSICAL_LOCATION"
        Me.PHYSICAL_LOCATION.ReadOnly = True
        Me.PHYSICAL_LOCATION.Visible = False
        '
        'RESTOCK_DATE
        '
        Me.RESTOCK_DATE.DataPropertyName = "restock_date"
        Me.RESTOCK_DATE.HeaderText = "Restocked Date"
        Me.RESTOCK_DATE.Name = "RESTOCK_DATE"
        Me.RESTOCK_DATE.ReadOnly = True
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'ADDED_BY
        '
        Me.ADDED_BY.DataPropertyName = "added_by"
        Me.ADDED_BY.HeaderText = "Added By"
        Me.ADDED_BY.Name = "ADDED_BY"
        Me.ADDED_BY.ReadOnly = True
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1015, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteEmployeeBtn)
        Me.Panel3.Controls.Add(Me.ArchiveEmployeeBtn)
        Me.Panel3.Controls.Add(Me.EditEmployeeBtn)
        Me.Panel3.Controls.Add(Me.AddEmployeeBtn)
        Me.Panel3.Controls.Add(Me.ViewEmployeeBtn)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 61)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 488)
        Me.Panel3.TabIndex = 0
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(960, 28)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'ShowArchiveCheckBox
        '
        Me.ShowArchiveCheckBox.AutoSize = True
        Me.ShowArchiveCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.CheckedState.BorderRadius = 2
        Me.ShowArchiveCheckBox.CheckedState.BorderThickness = 0
        Me.ShowArchiveCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowArchiveCheckBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowArchiveCheckBox.Location = New System.Drawing.Point(865, 3)
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(480, 28)
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
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.DeleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteEmployeeBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteEmployeeBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(0, 375)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteEmployeeBtn.TabIndex = 40
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
        Me.ArchiveEmployeeBtn.Location = New System.Drawing.Point(0, 300)
        Me.ArchiveEmployeeBtn.Name = "ArchiveEmployeeBtn"
        Me.ArchiveEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchiveEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchiveEmployeeBtn.TabIndex = 39
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
        Me.EditEmployeeBtn.Location = New System.Drawing.Point(0, 225)
        Me.EditEmployeeBtn.Name = "EditEmployeeBtn"
        Me.EditEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EditEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.EditEmployeeBtn.TabIndex = 38
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
        Me.AddEmployeeBtn.Location = New System.Drawing.Point(0, 150)
        Me.AddEmployeeBtn.Name = "AddEmployeeBtn"
        Me.AddEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddEmployeeBtn.TabIndex = 37
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
        Me.ViewEmployeeBtn.Location = New System.Drawing.Point(0, 75)
        Me.ViewEmployeeBtn.Name = "ViewEmployeeBtn"
        Me.ViewEmployeeBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewEmployeeBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewEmployeeBtn.TabIndex = 36
        Me.ViewEmployeeBtn.Text = "Details"
        Me.ViewEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.Image = Global.E_Repair.My.Resources.Resources.hand_arrow_up_bold
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.Button1.Size = New System.Drawing.Size(65, 75)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Use"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
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
        Me.BtnSelect.Location = New System.Drawing.Point(880, 566)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.ShadowDecoration.Parent = Me.BtnSelect
        Me.BtnSelect.Size = New System.Drawing.Size(107, 32)
        Me.BtnSelect.TabIndex = 41
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
        Me.BtnClose.Location = New System.Drawing.Point(27, 567)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 40
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'AdminInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SeeSuppliedItemsDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminInventoryForm"
        Me.TopMost = True
        CType(Me.SeeSuppliedItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SeeSuppliedItemsDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ITEM_ID As DataGridViewTextBoxColumn
    Friend WithEvents SERVICE_ID As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIER_ID As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_CATEGORY As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_DESCRIPTION As DataGridViewTextBoxColumn
    Friend WithEvents SERIAL_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents HAZARDOUS_CLASSIFICATION As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_VALUE As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents PHYSICAL_LOCATION As DataGridViewTextBoxColumn
    Friend WithEvents RESTOCK_DATE As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ShowArchiveCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DeleteEmployeeBtn As Button
    Friend WithEvents ArchiveEmployeeBtn As Button
    Friend WithEvents EditEmployeeBtn As Button
    Friend WithEvents AddEmployeeBtn As Button
    Friend WithEvents ViewEmployeeBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
End Class
