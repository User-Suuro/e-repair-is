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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolbarPanel = New System.Windows.Forms.Panel()
        Me.ItemsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ITEM_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORY_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Used = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnApplyCost = New Guna.UI2.WinForms.Guna2Button()
        Me.CostTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DecreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolbarPanel.SuspendLayout()
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolbarPanel
        '
        Me.ToolbarPanel.Controls.Add(Me.Panel1)
        Me.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolbarPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarPanel.Name = "ToolbarPanel"
        Me.ToolbarPanel.Size = New System.Drawing.Size(1009, 44)
        Me.ToolbarPanel.TabIndex = 64
        Me.ToolbarPanel.Visible = False
        '
        'ItemsDGV
        '
        Me.ItemsDGV.AllowUserToAddRows = False
        Me.ItemsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ItemsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemsDGV.BackgroundColor = System.Drawing.Color.White
        Me.ItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ItemsDGV.ColumnHeadersHeight = 48
        Me.ItemsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_ID, Me.SERVICE_ID, Me.INVENTORY_ID, Me.ITEM_NAME, Me.COST, Me.Used})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsDGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.ItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsDGV.EnableHeadersVisualStyles = False
        Me.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ItemsDGV.Location = New System.Drawing.Point(0, 44)
        Me.ItemsDGV.Name = "ItemsDGV"
        Me.ItemsDGV.ReadOnly = True
        Me.ItemsDGV.RowHeadersVisible = False
        Me.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsDGV.Size = New System.Drawing.Size(1009, 485)
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
        Me.ITEM_NAME.DataPropertyName = "item_name"
        Me.ITEM_NAME.HeaderText = "Item Name"
        Me.ITEM_NAME.Name = "ITEM_NAME"
        Me.ITEM_NAME.ReadOnly = True
        '
        'COST
        '
        Me.COST.HeaderText = "Cost"
        Me.COST.Name = "COST"
        Me.COST.ReadOnly = True
        '
        'Used
        '
        Me.Used.DataPropertyName = "used"
        Me.Used.HeaderText = "Used"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Panel1.Controls.Add(Me.BtnApplyCost)
        Me.Panel1.Controls.Add(Me.CostTxtBox)
        Me.Panel1.Controls.Add(Me.DecreaseBtn)
        Me.Panel1.Controls.Add(Me.AddBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(442, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 44)
        Me.Panel1.TabIndex = 0
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderRadius = 4
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.Enabled = False
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(430, 6)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Add/Decrease Quantity"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(80, 32)
        Me.Guna2TextBox1.TabIndex = 71
        '
        'BtnApplyCost
        '
        Me.BtnApplyCost.BackColor = System.Drawing.Color.Transparent
        Me.BtnApplyCost.BorderRadius = 4
        Me.BtnApplyCost.CheckedState.Parent = Me.BtnApplyCost
        Me.BtnApplyCost.CustomImages.Parent = Me.BtnApplyCost
        Me.BtnApplyCost.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnApplyCost.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApplyCost.ForeColor = System.Drawing.Color.White
        Me.BtnApplyCost.HoverState.Parent = Me.BtnApplyCost
        Me.BtnApplyCost.Location = New System.Drawing.Point(314, 6)
        Me.BtnApplyCost.Name = "BtnApplyCost"
        Me.BtnApplyCost.ShadowDecoration.Parent = Me.BtnApplyCost
        Me.BtnApplyCost.Size = New System.Drawing.Size(59, 32)
        Me.BtnApplyCost.TabIndex = 70
        Me.BtnApplyCost.Text = "Apply"
        '
        'CostTxtBox
        '
        Me.CostTxtBox.BackColor = System.Drawing.Color.Transparent
        Me.CostTxtBox.BorderRadius = 4
        Me.CostTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CostTxtBox.DefaultText = ""
        Me.CostTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CostTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CostTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTxtBox.DisabledState.Parent = Me.CostTxtBox
        Me.CostTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTxtBox.Enabled = False
        Me.CostTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTxtBox.FocusedState.Parent = Me.CostTxtBox
        Me.CostTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTxtBox.HoverState.Parent = Me.CostTxtBox
        Me.CostTxtBox.Location = New System.Drawing.Point(134, 6)
        Me.CostTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CostTxtBox.Name = "CostTxtBox"
        Me.CostTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostTxtBox.PlaceholderText = "Change Cost"
        Me.CostTxtBox.SelectedText = ""
        Me.CostTxtBox.ShadowDecoration.Parent = Me.CostTxtBox
        Me.CostTxtBox.Size = New System.Drawing.Size(175, 32)
        Me.CostTxtBox.TabIndex = 69
        '
        'DecreaseBtn
        '
        Me.DecreaseBtn.BackColor = System.Drawing.Color.Transparent
        Me.DecreaseBtn.BorderRadius = 4
        Me.DecreaseBtn.CheckedState.Parent = Me.DecreaseBtn
        Me.DecreaseBtn.CustomImages.Parent = Me.DecreaseBtn
        Me.DecreaseBtn.FillColor = System.Drawing.Color.DarkRed
        Me.DecreaseBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecreaseBtn.ForeColor = System.Drawing.Color.White
        Me.DecreaseBtn.HoverState.Parent = Me.DecreaseBtn
        Me.DecreaseBtn.Image = Global.E_Repair.My.Resources.Resources.minus_bold
        Me.DecreaseBtn.Location = New System.Drawing.Point(386, 6)
        Me.DecreaseBtn.Name = "DecreaseBtn"
        Me.DecreaseBtn.ShadowDecoration.Parent = Me.DecreaseBtn
        Me.DecreaseBtn.Size = New System.Drawing.Size(39, 32)
        Me.DecreaseBtn.TabIndex = 68
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.Transparent
        Me.AddBtn.BorderRadius = 4
        Me.AddBtn.CheckedState.Parent = Me.AddBtn
        Me.AddBtn.CustomImages.Parent = Me.AddBtn
        Me.AddBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.AddBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.HoverState.Parent = Me.AddBtn
        Me.AddBtn.Image = Global.E_Repair.My.Resources.Resources.plus_bold1
        Me.AddBtn.Location = New System.Drawing.Point(515, 6)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(39, 32)
        Me.AddBtn.TabIndex = 67
        '
        'InventoryItemModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ItemsDGV)
        Me.Controls.Add(Me.ToolbarPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryItemModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryItemDgv"
        Me.TopMost = True
        Me.ToolbarPanel.ResumeLayout(False)
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolbarPanel As Panel
    Friend WithEvents ItemsDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ITEM_ID As DataGridViewTextBoxColumn
    Friend WithEvents SERVICE_ID As DataGridViewTextBoxColumn
    Friend WithEvents INVENTORY_ID As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents COST As DataGridViewTextBoxColumn
    Friend WithEvents Used As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnApplyCost As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CostTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DecreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
End Class
