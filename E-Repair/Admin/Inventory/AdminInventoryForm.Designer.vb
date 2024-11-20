<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInventoryForm
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
        CType(Me.SeeSuppliedItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SeeSuppliedItemsDGV.Location = New System.Drawing.Point(29, 75)
        Me.SeeSuppliedItemsDGV.Name = "SeeSuppliedItemsDGV"
        Me.SeeSuppliedItemsDGV.ReadOnly = True
        Me.SeeSuppliedItemsDGV.RowHeadersVisible = False
        Me.SeeSuppliedItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SeeSuppliedItemsDGV.Size = New System.Drawing.Size(1006, 422)
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
        'AdminInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 572)
        Me.Controls.Add(Me.SeeSuppliedItemsDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminInventoryForm"
        Me.TopMost = True
        CType(Me.SeeSuppliedItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
