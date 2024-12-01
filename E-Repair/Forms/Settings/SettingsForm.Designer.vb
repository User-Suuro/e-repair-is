<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EnumDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ITEM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CompletedWorkTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AttributesCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableNameCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GenerateInv = New System.Windows.Forms.Button()
        Me.GenerateServ = New System.Windows.Forms.Button()
        Me.GenerateSupp = New System.Windows.Forms.Button()
        Me.GenerateCust = New System.Windows.Forms.Button()
        Me.GenerateEmp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EnumDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnumDGV
        '
        Me.EnumDGV.AllowUserToAddRows = False
        Me.EnumDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EnumDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.EnumDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnumDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EnumDGV.BackgroundColor = System.Drawing.Color.White
        Me.EnumDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnumDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EnumDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EnumDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.EnumDGV.ColumnHeadersHeight = 48
        Me.EnumDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_NAME})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EnumDGV.DefaultCellStyle = DataGridViewCellStyle11
        Me.EnumDGV.EnableHeadersVisualStyles = False
        Me.EnumDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EnumDGV.Location = New System.Drawing.Point(24, 58)
        Me.EnumDGV.Name = "EnumDGV"
        Me.EnumDGV.ReadOnly = True
        Me.EnumDGV.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        Me.EnumDGV.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.EnumDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EnumDGV.Size = New System.Drawing.Size(956, 528)
        Me.EnumDGV.TabIndex = 42
        Me.EnumDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.EnumDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EnumDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EnumDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EnumDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EnumDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EnumDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.EnumDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EnumDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EnumDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.EnumDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EnumDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EnumDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.EnumDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.EnumDGV.ThemeStyle.ReadOnly = True
        Me.EnumDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.EnumDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EnumDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EnumDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.EnumDGV.ThemeStyle.RowsStyle.Height = 22
        Me.EnumDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.EnumDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ITEM_NAME
        '
        Me.ITEM_NAME.HeaderText = "Item Name"
        Me.ITEM_NAME.Name = "ITEM_NAME"
        Me.ITEM_NAME.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(24, 24)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(956, 28)
        Me.TableLayoutPanel2.TabIndex = 41
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BtnDelete)
        Me.Guna2Panel1.Controls.Add(Me.Panel4)
        Me.Guna2Panel1.Controls.Add(Me.CompletedWorkTxtBox)
        Me.Guna2Panel1.Controls.Add(Me.Panel3)
        Me.Guna2Panel1.Controls.Add(Me.BtnAdd)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Controls.Add(Me.AttributesCmb)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.TableNameCmb)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(956, 28)
        Me.Guna2Panel1.TabIndex = 31
        '
        'BtnDelete
        '
        Me.BtnDelete.BorderRadius = 4
        Me.BtnDelete.CheckedState.Parent = Me.BtnDelete
        Me.BtnDelete.CustomImages.Parent = Me.BtnDelete
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnDelete.FillColor = System.Drawing.Color.DarkRed
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.HoverState.Parent = Me.BtnDelete
        Me.BtnDelete.Location = New System.Drawing.Point(587, 0)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.ShadowDecoration.Parent = Me.BtnDelete
        Me.BtnDelete.Size = New System.Drawing.Size(71, 28)
        Me.BtnDelete.TabIndex = 72
        Me.BtnDelete.Text = "Delete"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(658, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(17, 28)
        Me.Panel4.TabIndex = 71
        '
        'CompletedWorkTxtBox
        '
        Me.CompletedWorkTxtBox.BorderRadius = 4
        Me.CompletedWorkTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompletedWorkTxtBox.DefaultText = ""
        Me.CompletedWorkTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CompletedWorkTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CompletedWorkTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompletedWorkTxtBox.DisabledState.Parent = Me.CompletedWorkTxtBox
        Me.CompletedWorkTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompletedWorkTxtBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CompletedWorkTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompletedWorkTxtBox.FocusedState.Parent = Me.CompletedWorkTxtBox
        Me.CompletedWorkTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletedWorkTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompletedWorkTxtBox.HoverState.Parent = Me.CompletedWorkTxtBox
        Me.CompletedWorkTxtBox.Location = New System.Drawing.Point(675, 0)
        Me.CompletedWorkTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CompletedWorkTxtBox.Name = "CompletedWorkTxtBox"
        Me.CompletedWorkTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompletedWorkTxtBox.PlaceholderText = ""
        Me.CompletedWorkTxtBox.ReadOnly = True
        Me.CompletedWorkTxtBox.SelectedText = ""
        Me.CompletedWorkTxtBox.ShadowDecoration.Parent = Me.CompletedWorkTxtBox
        Me.CompletedWorkTxtBox.Size = New System.Drawing.Size(187, 28)
        Me.CompletedWorkTxtBox.TabIndex = 70
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(862, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(17, 28)
        Me.Panel3.TabIndex = 69
        '
        'BtnAdd
        '
        Me.BtnAdd.BorderRadius = 4
        Me.BtnAdd.CheckedState.Parent = Me.BtnAdd
        Me.BtnAdd.CustomImages.Parent = Me.BtnAdd
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAdd.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnAdd.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.HoverState.Parent = Me.BtnAdd
        Me.BtnAdd.Location = New System.Drawing.Point(879, 0)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(77, 28)
        Me.BtnAdd.TabIndex = 67
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(409, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(22, 28)
        Me.Panel2.TabIndex = 45
        '
        'AttributesCmb
        '
        Me.AttributesCmb.Animated = True
        Me.AttributesCmb.BackColor = System.Drawing.Color.Transparent
        Me.AttributesCmb.BorderRadius = 4
        Me.AttributesCmb.DisplayMember = "(none)"
        Me.AttributesCmb.Dock = System.Windows.Forms.DockStyle.Left
        Me.AttributesCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.AttributesCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttributesCmb.FocusedColor = System.Drawing.Color.Empty
        Me.AttributesCmb.FocusedState.Parent = Me.AttributesCmb
        Me.AttributesCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AttributesCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.AttributesCmb.FormattingEnabled = True
        Me.AttributesCmb.HoverState.Parent = Me.AttributesCmb
        Me.AttributesCmb.ItemHeight = 22
        Me.AttributesCmb.ItemsAppearance.Parent = Me.AttributesCmb
        Me.AttributesCmb.Location = New System.Drawing.Point(220, 0)
        Me.AttributesCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.AttributesCmb.Name = "AttributesCmb"
        Me.AttributesCmb.ShadowDecoration.Parent = Me.AttributesCmb
        Me.AttributesCmb.Size = New System.Drawing.Size(189, 28)
        Me.AttributesCmb.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(198, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 28)
        Me.Panel1.TabIndex = 43
        '
        'TableNameCmb
        '
        Me.TableNameCmb.Animated = True
        Me.TableNameCmb.BackColor = System.Drawing.Color.Transparent
        Me.TableNameCmb.BorderRadius = 4
        Me.TableNameCmb.DisplayMember = "(none)"
        Me.TableNameCmb.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableNameCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TableNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TableNameCmb.FocusedColor = System.Drawing.Color.Empty
        Me.TableNameCmb.FocusedState.Parent = Me.TableNameCmb
        Me.TableNameCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TableNameCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TableNameCmb.FormattingEnabled = True
        Me.TableNameCmb.HoverState.Parent = Me.TableNameCmb
        Me.TableNameCmb.ItemHeight = 22
        Me.TableNameCmb.Items.AddRange(New Object() {"Employees", "Services", "Inventory", "Customers", "Suppliers"})
        Me.TableNameCmb.ItemsAppearance.Parent = Me.TableNameCmb
        Me.TableNameCmb.Location = New System.Drawing.Point(0, 0)
        Me.TableNameCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.TableNameCmb.Name = "TableNameCmb"
        Me.TableNameCmb.ShadowDecoration.Parent = Me.TableNameCmb
        Me.TableNameCmb.Size = New System.Drawing.Size(198, 28)
        Me.TableNameCmb.StartIndex = 0
        Me.TableNameCmb.TabIndex = 39
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1012, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(68, 611)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GenerateInv)
        Me.Panel5.Controls.Add(Me.GenerateServ)
        Me.Panel5.Controls.Add(Me.GenerateSupp)
        Me.Panel5.Controls.Add(Me.GenerateCust)
        Me.Panel5.Controls.Add(Me.GenerateEmp)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 61)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(68, 488)
        Me.Panel5.TabIndex = 0
        '
        'GenerateInv
        '
        Me.GenerateInv.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerateInv.FlatAppearance.BorderSize = 0
        Me.GenerateInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateInv.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateInv.Image = Global.E_Repair.My.Resources.Resources.package_bold
        Me.GenerateInv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GenerateInv.Location = New System.Drawing.Point(0, 300)
        Me.GenerateInv.Name = "GenerateInv"
        Me.GenerateInv.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.GenerateInv.Size = New System.Drawing.Size(68, 75)
        Me.GenerateInv.TabIndex = 39
        Me.GenerateInv.Text = "Inventory"
        Me.GenerateInv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateInv.UseVisualStyleBackColor = True
        '
        'GenerateServ
        '
        Me.GenerateServ.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerateServ.FlatAppearance.BorderSize = 0
        Me.GenerateServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateServ.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateServ.Image = Global.E_Repair.My.Resources.Resources.screwdriver_bold
        Me.GenerateServ.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GenerateServ.Location = New System.Drawing.Point(0, 225)
        Me.GenerateServ.Name = "GenerateServ"
        Me.GenerateServ.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.GenerateServ.Size = New System.Drawing.Size(68, 75)
        Me.GenerateServ.TabIndex = 38
        Me.GenerateServ.Text = "Services"
        Me.GenerateServ.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateServ.UseVisualStyleBackColor = True
        '
        'GenerateSupp
        '
        Me.GenerateSupp.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerateSupp.FlatAppearance.BorderSize = 0
        Me.GenerateSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateSupp.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateSupp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateSupp.Image = Global.E_Repair.My.Resources.Resources.truck_bold
        Me.GenerateSupp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GenerateSupp.Location = New System.Drawing.Point(0, 150)
        Me.GenerateSupp.Name = "GenerateSupp"
        Me.GenerateSupp.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.GenerateSupp.Size = New System.Drawing.Size(68, 75)
        Me.GenerateSupp.TabIndex = 37
        Me.GenerateSupp.Text = "Suppliers"
        Me.GenerateSupp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateSupp.UseVisualStyleBackColor = True
        '
        'GenerateCust
        '
        Me.GenerateCust.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerateCust.FlatAppearance.BorderSize = 0
        Me.GenerateCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateCust.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateCust.Image = Global.E_Repair.My.Resources.Resources.handshake_bold
        Me.GenerateCust.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GenerateCust.Location = New System.Drawing.Point(0, 75)
        Me.GenerateCust.Name = "GenerateCust"
        Me.GenerateCust.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.GenerateCust.Size = New System.Drawing.Size(68, 75)
        Me.GenerateCust.TabIndex = 36
        Me.GenerateCust.Text = "Customers"
        Me.GenerateCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateCust.UseVisualStyleBackColor = True
        '
        'GenerateEmp
        '
        Me.GenerateEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenerateEmp.FlatAppearance.BorderSize = 0
        Me.GenerateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateEmp.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateEmp.Image = Global.E_Repair.My.Resources.Resources.users_three_bold
        Me.GenerateEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GenerateEmp.Location = New System.Drawing.Point(0, 0)
        Me.GenerateEmp.Name = "GenerateEmp"
        Me.GenerateEmp.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.GenerateEmp.Size = New System.Drawing.Size(68, 75)
        Me.GenerateEmp.TabIndex = 35
        Me.GenerateEmp.Text = "Employees"
        Me.GenerateEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateEmp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4, 8, 4, 4)
        Me.Label1.Size = New System.Drawing.Size(62, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Generate Dummy Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.EnumDGV)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.Text = "AdminSettingsForm"
        CType(Me.EnumDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EnumDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableNameCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents AttributesCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CompletedWorkTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ITEM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GenerateServ As Button
    Friend WithEvents GenerateSupp As Button
    Friend WithEvents GenerateCust As Button
    Friend WithEvents GenerateEmp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GenerateInv As Button
End Class
