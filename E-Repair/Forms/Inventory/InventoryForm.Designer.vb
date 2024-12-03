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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.InventoryDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.inventory_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIAL_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HAZARDOUS_CLASSIFICATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COST_PER_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.available_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ExportToExcelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.ArchivedBtn = New System.Windows.Forms.Button()
        Me.EdtBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.UseBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShowArchiveCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InventoryDGV
        '
        Me.InventoryDGV.AllowUserToAddRows = False
        Me.InventoryDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.InventoryDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.InventoryDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InventoryDGV.BackgroundColor = System.Drawing.Color.White
        Me.InventoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InventoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InventoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.InventoryDGV.ColumnHeadersHeight = 48
        Me.InventoryDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inventory_id, Me.SERVICE_ID, Me.SUPPLIER_ID, Me.ITEM_CATEGORY, Me.ITEM_NAME, Me.ITEM_DESCRIPTION, Me.SERIAL_NUMBER, Me.HAZARDOUS_CLASSIFICATION, Me.COST_PER_ITEM, Me.available_quantity, Me.TOTAL_VALUE, Me.ITEM_STATUS, Me.PHYSICAL_LOCATION, Me.RESTOCK_DATE, Me.DATE_ADDED, Me.ADDED_BY, Me.ARCHIVED, Me.ARCHIVED_BY, Me.DATE_ARCHIVED})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InventoryDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.InventoryDGV.EnableHeadersVisualStyles = False
        Me.InventoryDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.InventoryDGV.Location = New System.Drawing.Point(27, 52)
        Me.InventoryDGV.Name = "InventoryDGV"
        Me.InventoryDGV.ReadOnly = True
        Me.InventoryDGV.RowHeadersVisible = False
        Me.InventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InventoryDGV.Size = New System.Drawing.Size(960, 494)
        Me.InventoryDGV.TabIndex = 37
        Me.InventoryDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.InventoryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.InventoryDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.InventoryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.InventoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.InventoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.InventoryDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.InventoryDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.InventoryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.InventoryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.InventoryDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.InventoryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.InventoryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.InventoryDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.InventoryDGV.ThemeStyle.ReadOnly = True
        Me.InventoryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.InventoryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InventoryDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.InventoryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.InventoryDGV.ThemeStyle.RowsStyle.Height = 22
        Me.InventoryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.InventoryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'inventory_id
        '
        Me.inventory_id.DataPropertyName = "inventory_id"
        Me.inventory_id.HeaderText = "Item ID"
        Me.inventory_id.Name = "inventory_id"
        Me.inventory_id.ReadOnly = True
        Me.inventory_id.Visible = False
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
        'COST_PER_ITEM
        '
        Me.COST_PER_ITEM.DataPropertyName = "cost_per_item"
        Me.COST_PER_ITEM.HeaderText = "Cost Per Item"
        Me.COST_PER_ITEM.Name = "COST_PER_ITEM"
        Me.COST_PER_ITEM.ReadOnly = True
        '
        'available_quantity
        '
        Me.available_quantity.DataPropertyName = "available_quantity"
        Me.available_quantity.HeaderText = "Quantity"
        Me.available_quantity.Name = "available_quantity"
        Me.available_quantity.ReadOnly = True
        '
        'TOTAL_VALUE
        '
        Me.TOTAL_VALUE.DataPropertyName = "total_cost"
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
        Me.ITEM_STATUS.Visible = False
        '
        'PHYSICAL_LOCATION
        '
        Me.PHYSICAL_LOCATION.DataPropertyName = "physical_location"
        Me.PHYSICAL_LOCATION.HeaderText = "Physical Location"
        Me.PHYSICAL_LOCATION.Name = "PHYSICAL_LOCATION"
        Me.PHYSICAL_LOCATION.ReadOnly = True
        '
        'RESTOCK_DATE
        '
        Me.RESTOCK_DATE.DataPropertyName = "restock_date"
        Me.RESTOCK_DATE.HeaderText = "Restocked Date"
        Me.RESTOCK_DATE.Name = "RESTOCK_DATE"
        Me.RESTOCK_DATE.ReadOnly = True
        Me.RESTOCK_DATE.Visible = False
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.05238!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.546645!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(65, 611)
        Me.TableLayoutPanel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ExportToExcelBtn)
        Me.Panel3.Controls.Add(Me.DeleteBtn)
        Me.Panel3.Controls.Add(Me.ArchivedBtn)
        Me.Panel3.Controls.Add(Me.EdtBtn)
        Me.Panel3.Controls.Add(Me.AddBtn)
        Me.Panel3.Controls.Add(Me.ViewBtn)
        Me.Panel3.Controls.Add(Me.UseBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 33)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 537)
        Me.Panel3.TabIndex = 0
        '
        'ExportToExcelBtn
        '
        Me.ExportToExcelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExportToExcelBtn.FlatAppearance.BorderSize = 0
        Me.ExportToExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportToExcelBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToExcelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ExportToExcelBtn.Image = CType(resources.GetObject("ExportToExcelBtn.Image"), System.Drawing.Image)
        Me.ExportToExcelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExportToExcelBtn.Location = New System.Drawing.Point(0, 450)
        Me.ExportToExcelBtn.Name = "ExportToExcelBtn"
        Me.ExportToExcelBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ExportToExcelBtn.Size = New System.Drawing.Size(65, 75)
        Me.ExportToExcelBtn.TabIndex = 41
        Me.ExportToExcelBtn.Text = "Report"
        Me.ExportToExcelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExportToExcelBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DeleteBtn.Image = Global.E_Repair.My.Resources.Resources.trash_bold
        Me.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteBtn.Location = New System.Drawing.Point(0, 375)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.DeleteBtn.Size = New System.Drawing.Size(65, 75)
        Me.DeleteBtn.TabIndex = 40
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'ArchivedBtn
        '
        Me.ArchivedBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchivedBtn.FlatAppearance.BorderSize = 0
        Me.ArchivedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchivedBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivedBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ArchivedBtn.Image = Global.E_Repair.My.Resources.Resources.archive_bold
        Me.ArchivedBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArchivedBtn.Location = New System.Drawing.Point(0, 300)
        Me.ArchivedBtn.Name = "ArchivedBtn"
        Me.ArchivedBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ArchivedBtn.Size = New System.Drawing.Size(65, 75)
        Me.ArchivedBtn.TabIndex = 39
        Me.ArchivedBtn.TabStop = False
        Me.ArchivedBtn.Text = "Archive"
        Me.ArchivedBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ArchivedBtn.UseVisualStyleBackColor = True
        '
        'EdtBtn
        '
        Me.EdtBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EdtBtn.FlatAppearance.BorderSize = 0
        Me.EdtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EdtBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdtBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EdtBtn.Image = Global.E_Repair.My.Resources.Resources.pencil_bold
        Me.EdtBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EdtBtn.Location = New System.Drawing.Point(0, 225)
        Me.EdtBtn.Name = "EdtBtn"
        Me.EdtBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.EdtBtn.Size = New System.Drawing.Size(65, 75)
        Me.EdtBtn.TabIndex = 38
        Me.EdtBtn.Text = "Edit"
        Me.EdtBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EdtBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AddBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold
        Me.AddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddBtn.Location = New System.Drawing.Point(0, 150)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.AddBtn.Size = New System.Drawing.Size(65, 75)
        Me.AddBtn.TabIndex = 37
        Me.AddBtn.Text = "Add"
        Me.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ViewBtn
        '
        Me.ViewBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewBtn.FlatAppearance.BorderSize = 0
        Me.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ViewBtn.Image = Global.E_Repair.My.Resources.Resources.eye_bold
        Me.ViewBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewBtn.Location = New System.Drawing.Point(0, 75)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.ViewBtn.Size = New System.Drawing.Size(65, 75)
        Me.ViewBtn.TabIndex = 36
        Me.ViewBtn.Text = "Details"
        Me.ViewBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'UseBtn
        '
        Me.UseBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.UseBtn.FlatAppearance.BorderSize = 0
        Me.UseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.UseBtn.Image = Global.E_Repair.My.Resources.Resources.hand_arrow_up_bold
        Me.UseBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UseBtn.Location = New System.Drawing.Point(0, 0)
        Me.UseBtn.Name = "UseBtn"
        Me.UseBtn.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.UseBtn.Size = New System.Drawing.Size(65, 75)
        Me.UseBtn.TabIndex = 35
        Me.UseBtn.Text = "Use"
        Me.UseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UseBtn.UseVisualStyleBackColor = True
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
        Me.SearchComboBox.Items.AddRange(New Object() {"Category", "Item Name", "Cost per item", "Quantity", "Physical Location", "Total Value", "Date Added", "Added By"})
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
        Me.BtnClose.Location = New System.Drawing.Point(27, 566)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 40
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Visible = False
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.InventoryDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminInventoryForm"
        Me.TopMost = True
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InventoryDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ShowArchiveCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SearchComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ArchivedBtn As Button
    Friend WithEvents EdtBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ViewBtn As Button
    Friend WithEvents UseBtn As Button
    Friend WithEvents BtnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents inventory_id As DataGridViewTextBoxColumn
    Friend WithEvents SERVICE_ID As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIER_ID As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_CATEGORY As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_DESCRIPTION As DataGridViewTextBoxColumn
    Friend WithEvents SERIAL_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents HAZARDOUS_CLASSIFICATION As DataGridViewTextBoxColumn
    Friend WithEvents COST_PER_ITEM As DataGridViewTextBoxColumn
    Friend WithEvents available_quantity As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_VALUE As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents PHYSICAL_LOCATION As DataGridViewTextBoxColumn
    Friend WithEvents RESTOCK_DATE As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ExportToExcelBtn As Button
End Class
