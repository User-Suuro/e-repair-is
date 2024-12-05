<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryItemModal
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
        Me.ItemsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ITEM_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORY_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REASON_USED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Used = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemsDGV
        '
        Me.ItemsDGV.AllowUserToAddRows = False
        Me.ItemsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ItemsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemsDGV.BackgroundColor = System.Drawing.Color.White
        Me.ItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemsDGV.ColumnHeadersHeight = 48
        Me.ItemsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_ID, Me.SERVICE_ID, Me.INVENTORY_ID, Me.ITEM_NAME, Me.COST, Me.REASON_USED, Me.Used})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsDGV.EnableHeadersVisualStyles = False
        Me.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ItemsDGV.Location = New System.Drawing.Point(0, 0)
        Me.ItemsDGV.Name = "ItemsDGV"
        Me.ItemsDGV.ReadOnly = True
        Me.ItemsDGV.RowHeadersVisible = False
        Me.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsDGV.Size = New System.Drawing.Size(1009, 529)
        Me.ItemsDGV.TabIndex = 65
        Me.ItemsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.ItemsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ItemsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ItemsDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.ItemsDGV.ThemeStyle.ReadOnly = True
        Me.ItemsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.RowsStyle.Height = 22
        Me.ItemsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ItemsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'INVENTORY_ID
        '
        Me.INVENTORY_ID.DataPropertyName = "inventory_id"
        Me.INVENTORY_ID.HeaderText = "Inventory ID"
        Me.INVENTORY_ID.Name = "INVENTORY_ID"
        Me.INVENTORY_ID.ReadOnly = True
        Me.INVENTORY_ID.Visible = False
        '
        'ITEM_NAME
        '
        Me.ITEM_NAME.DataPropertyName = "quantity_used"
        Me.ITEM_NAME.HeaderText = "Quantity Used"
        Me.ITEM_NAME.Name = "ITEM_NAME"
        Me.ITEM_NAME.ReadOnly = True
        '
        'COST
        '
        Me.COST.DataPropertyName = "total_cost"
        Me.COST.HeaderText = "Total Cost"
        Me.COST.Name = "COST"
        Me.COST.ReadOnly = True
        '
        'REASON_USED
        '
        Me.REASON_USED.DataPropertyName = "reason_used"
        Me.REASON_USED.HeaderText = "Usage Reason"
        Me.REASON_USED.Name = "REASON_USED"
        Me.REASON_USED.ReadOnly = True
        '
        'Used
        '
        Me.Used.DataPropertyName = "date_used"
        Me.Used.HeaderText = "Date Used"
        Me.Used.Name = "Used"
        Me.Used.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.Guna2Separator3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 464)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1009, 65)
        Me.Panel2.TabIndex = 66
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
        Me.BtnClose.Location = New System.Drawing.Point(12, 22)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 63
        Me.BtnClose.Text = "Close"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 6)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(1009, 13)
        Me.Guna2Separator3.TabIndex = 64
        '
        'InventoryItemModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ItemsDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryItemModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryItemDgv"
        Me.TopMost = True
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemsDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ITEM_ID As DataGridViewTextBoxColumn
    Friend WithEvents SERVICE_ID As DataGridViewTextBoxColumn
    Friend WithEvents INVENTORY_ID As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents COST As DataGridViewTextBoxColumn
    Friend WithEvents REASON_USED As DataGridViewTextBoxColumn
    Friend WithEvents Used As DataGridViewTextBoxColumn
End Class
