<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceEvaluationModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceEvaluationModal))
        Me.Groupbox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalCostTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TechnicianFeeTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PartsCostTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SeePartsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PartsUsedTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RepairNotesTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.RepairStatusTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.DateCompletedDTP = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RepairStatusCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.DeviceCirclePictureBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Groupbox.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.RepairStatusTableLayout.SuspendLayout()
        CType(Me.DeviceCirclePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupbox
        '
        Me.Groupbox.Controls.Add(Me.DeviceCirclePictureBox)
        Me.Groupbox.Controls.Add(Me.Guna2Panel2)
        Me.Groupbox.Controls.Add(Me.Guna2Panel8)
        Me.Groupbox.Controls.Add(Me.Guna2Panel7)
        Me.Groupbox.Controls.Add(Me.BtnSave)
        Me.Groupbox.Controls.Add(Me.BtnClose)
        Me.Groupbox.Controls.Add(Me.Guna2Separator1)
        Me.Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Groupbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Groupbox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groupbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Groupbox.Location = New System.Drawing.Point(0, 0)
        Me.Groupbox.Name = "Groupbox"
        Me.Groupbox.ShadowDecoration.Parent = Me.Groupbox
        Me.Groupbox.Size = New System.Drawing.Size(986, 313)
        Me.Groupbox.TabIndex = 3
        Me.Groupbox.Text = "Technician Service Evaluation"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.BorderRadius = 4
        Me.Guna2Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 187)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(957, 61)
        Me.Guna2Panel2.TabIndex = 55
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TotalCostTxtBox, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TechnicianFeeTxtBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PartsCostTxtBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SeePartsBtn, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PartsUsedTxtBox, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(949, 53)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'TotalCostTxtBox
        '
        Me.TotalCostTxtBox.BorderRadius = 4
        Me.TotalCostTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalCostTxtBox.DefaultText = ""
        Me.TotalCostTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalCostTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TotalCostTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalCostTxtBox.DisabledState.Parent = Me.TotalCostTxtBox
        Me.TotalCostTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalCostTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TotalCostTxtBox.Enabled = False
        Me.TotalCostTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalCostTxtBox.FocusedState.Parent = Me.TotalCostTxtBox
        Me.TotalCostTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalCostTxtBox.HoverState.Parent = Me.TotalCostTxtBox
        Me.TotalCostTxtBox.Location = New System.Drawing.Point(569, 24)
        Me.TotalCostTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TotalCostTxtBox.Name = "TotalCostTxtBox"
        Me.TotalCostTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalCostTxtBox.PlaceholderText = ""
        Me.TotalCostTxtBox.ReadOnly = True
        Me.TotalCostTxtBox.SelectedText = ""
        Me.TotalCostTxtBox.ShadowDecoration.Parent = Me.TotalCostTxtBox
        Me.TotalCostTxtBox.Size = New System.Drawing.Size(185, 26)
        Me.TotalCostTxtBox.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(570, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Total Cost"
        '
        'TechnicianFeeTxtBox
        '
        Me.TechnicianFeeTxtBox.BorderRadius = 4
        Me.TechnicianFeeTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TechnicianFeeTxtBox.DefaultText = ""
        Me.TechnicianFeeTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TechnicianFeeTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TechnicianFeeTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TechnicianFeeTxtBox.DisabledState.Parent = Me.TechnicianFeeTxtBox
        Me.TechnicianFeeTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TechnicianFeeTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TechnicianFeeTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TechnicianFeeTxtBox.FocusedState.Parent = Me.TechnicianFeeTxtBox
        Me.TechnicianFeeTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechnicianFeeTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TechnicianFeeTxtBox.HoverState.Parent = Me.TechnicianFeeTxtBox
        Me.TechnicianFeeTxtBox.Location = New System.Drawing.Point(2, 24)
        Me.TechnicianFeeTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TechnicianFeeTxtBox.Name = "TechnicianFeeTxtBox"
        Me.TechnicianFeeTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TechnicianFeeTxtBox.PlaceholderText = ""
        Me.TechnicianFeeTxtBox.SelectedText = ""
        Me.TechnicianFeeTxtBox.ShadowDecoration.Parent = Me.TechnicianFeeTxtBox
        Me.TechnicianFeeTxtBox.Size = New System.Drawing.Size(185, 26)
        Me.TechnicianFeeTxtBox.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Technician Fee"
        '
        'PartsCostTxtBox
        '
        Me.PartsCostTxtBox.BorderRadius = 4
        Me.PartsCostTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PartsCostTxtBox.DefaultText = ""
        Me.PartsCostTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PartsCostTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PartsCostTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PartsCostTxtBox.DisabledState.Parent = Me.PartsCostTxtBox
        Me.PartsCostTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PartsCostTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PartsCostTxtBox.Enabled = False
        Me.PartsCostTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PartsCostTxtBox.FocusedState.Parent = Me.PartsCostTxtBox
        Me.PartsCostTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartsCostTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PartsCostTxtBox.HoverState.Parent = Me.PartsCostTxtBox
        Me.PartsCostTxtBox.Location = New System.Drawing.Point(380, 24)
        Me.PartsCostTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PartsCostTxtBox.Name = "PartsCostTxtBox"
        Me.PartsCostTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PartsCostTxtBox.PlaceholderText = ""
        Me.PartsCostTxtBox.ReadOnly = True
        Me.PartsCostTxtBox.SelectedText = ""
        Me.PartsCostTxtBox.ShadowDecoration.Parent = Me.PartsCostTxtBox
        Me.PartsCostTxtBox.Size = New System.Drawing.Size(185, 26)
        Me.PartsCostTxtBox.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(381, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Parts Cost"
        '
        'SeePartsBtn
        '
        Me.SeePartsBtn.BorderRadius = 4
        Me.SeePartsBtn.CheckedState.Parent = Me.SeePartsBtn
        Me.SeePartsBtn.CustomImages.Parent = Me.SeePartsBtn
        Me.SeePartsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SeePartsBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeePartsBtn.ForeColor = System.Drawing.Color.White
        Me.SeePartsBtn.HoverState.Parent = Me.SeePartsBtn
        Me.SeePartsBtn.Location = New System.Drawing.Point(759, 23)
        Me.SeePartsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SeePartsBtn.Name = "SeePartsBtn"
        Me.SeePartsBtn.ShadowDecoration.Parent = Me.SeePartsBtn
        Me.SeePartsBtn.Size = New System.Drawing.Size(187, 28)
        Me.SeePartsBtn.TabIndex = 60
        Me.SeePartsBtn.Text = "See Parts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(759, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Parts Used"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(192, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Number of Parts Used"
        '
        'PartsUsedTxtBox
        '
        Me.PartsUsedTxtBox.BorderRadius = 4
        Me.PartsUsedTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PartsUsedTxtBox.DefaultText = ""
        Me.PartsUsedTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PartsUsedTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PartsUsedTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PartsUsedTxtBox.DisabledState.Parent = Me.PartsUsedTxtBox
        Me.PartsUsedTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PartsUsedTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PartsUsedTxtBox.Enabled = False
        Me.PartsUsedTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PartsUsedTxtBox.FocusedState.Parent = Me.PartsUsedTxtBox
        Me.PartsUsedTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartsUsedTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PartsUsedTxtBox.HoverState.Parent = Me.PartsUsedTxtBox
        Me.PartsUsedTxtBox.Location = New System.Drawing.Point(191, 24)
        Me.PartsUsedTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PartsUsedTxtBox.Name = "PartsUsedTxtBox"
        Me.PartsUsedTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PartsUsedTxtBox.PlaceholderText = ""
        Me.PartsUsedTxtBox.ReadOnly = True
        Me.PartsUsedTxtBox.SelectedText = ""
        Me.PartsUsedTxtBox.ShadowDecoration.Parent = Me.PartsUsedTxtBox
        Me.PartsUsedTxtBox.Size = New System.Drawing.Size(185, 26)
        Me.PartsUsedTxtBox.TabIndex = 55
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel8.BorderRadius = 4
        Me.Guna2Panel8.Controls.Add(Me.TableLayoutPanel7)
        Me.Guna2Panel8.Location = New System.Drawing.Point(12, 120)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Padding = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(824, 61)
        Me.Guna2Panel8.TabIndex = 54
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.RepairNotesTxtBox, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label31, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(816, 53)
        Me.TableLayoutPanel7.TabIndex = 8
        '
        'RepairNotesTxtBox
        '
        Me.RepairNotesTxtBox.BorderRadius = 4
        Me.RepairNotesTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RepairNotesTxtBox.DefaultText = ""
        Me.RepairNotesTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RepairNotesTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RepairNotesTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RepairNotesTxtBox.DisabledState.Parent = Me.RepairNotesTxtBox
        Me.RepairNotesTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RepairNotesTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.RepairNotesTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepairNotesTxtBox.FocusedState.Parent = Me.RepairNotesTxtBox
        Me.RepairNotesTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepairNotesTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepairNotesTxtBox.HoverState.Parent = Me.RepairNotesTxtBox
        Me.RepairNotesTxtBox.Location = New System.Drawing.Point(2, 24)
        Me.RepairNotesTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RepairNotesTxtBox.Name = "RepairNotesTxtBox"
        Me.RepairNotesTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RepairNotesTxtBox.PlaceholderText = ""
        Me.RepairNotesTxtBox.SelectedText = ""
        Me.RepairNotesTxtBox.ShadowDecoration.Parent = Me.RepairNotesTxtBox
        Me.RepairNotesTxtBox.Size = New System.Drawing.Size(812, 26)
        Me.RepairNotesTxtBox.TabIndex = 55
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 20)
        Me.Label31.TabIndex = 54
        Me.Label31.Text = "Repair Notes"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel7.BorderRadius = 4
        Me.Guna2Panel7.Controls.Add(Me.RepairStatusTableLayout)
        Me.Guna2Panel7.Location = New System.Drawing.Point(12, 53)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Padding = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(824, 61)
        Me.Guna2Panel7.TabIndex = 46
        '
        'RepairStatusTableLayout
        '
        Me.RepairStatusTableLayout.ColumnCount = 2
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RepairStatusTableLayout.Controls.Add(Me.DateCompletedDTP, 1, 1)
        Me.RepairStatusTableLayout.Controls.Add(Me.RepairStatusCmb, 0, 1)
        Me.RepairStatusTableLayout.Controls.Add(Me.Label25, 1, 0)
        Me.RepairStatusTableLayout.Controls.Add(Me.Label23, 0, 0)
        Me.RepairStatusTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepairStatusTableLayout.Location = New System.Drawing.Point(4, 4)
        Me.RepairStatusTableLayout.Name = "RepairStatusTableLayout"
        Me.RepairStatusTableLayout.RowCount = 2
        Me.RepairStatusTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.RepairStatusTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.RepairStatusTableLayout.Size = New System.Drawing.Size(816, 53)
        Me.RepairStatusTableLayout.TabIndex = 8
        '
        'DateCompletedDTP
        '
        Me.DateCompletedDTP.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DateCompletedDTP.BorderRadius = 4
        Me.DateCompletedDTP.BorderThickness = 1
        Me.DateCompletedDTP.CheckedState.Parent = Me.DateCompletedDTP
        Me.DateCompletedDTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateCompletedDTP.FillColor = System.Drawing.Color.White
        Me.DateCompletedDTP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCompletedDTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DateCompletedDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateCompletedDTP.HoverState.Parent = Me.DateCompletedDTP
        Me.DateCompletedDTP.Location = New System.Drawing.Point(411, 24)
        Me.DateCompletedDTP.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateCompletedDTP.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateCompletedDTP.Name = "DateCompletedDTP"
        Me.DateCompletedDTP.ShadowDecoration.Parent = Me.DateCompletedDTP
        Me.DateCompletedDTP.Size = New System.Drawing.Size(402, 25)
        Me.DateCompletedDTP.TabIndex = 61
        Me.DateCompletedDTP.Value = New Date(2024, 11, 1, 5, 3, 38, 85)
        '
        'RepairStatusCmb
        '
        Me.RepairStatusCmb.BackColor = System.Drawing.Color.Transparent
        Me.RepairStatusCmb.BorderRadius = 4
        Me.RepairStatusCmb.Dock = System.Windows.Forms.DockStyle.Top
        Me.RepairStatusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RepairStatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RepairStatusCmb.FocusedColor = System.Drawing.Color.Empty
        Me.RepairStatusCmb.FocusedState.Parent = Me.RepairStatusCmb
        Me.RepairStatusCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RepairStatusCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RepairStatusCmb.FormattingEnabled = True
        Me.RepairStatusCmb.HoverState.Parent = Me.RepairStatusCmb
        Me.RepairStatusCmb.ItemHeight = 20
        Me.RepairStatusCmb.ItemsAppearance.Parent = Me.RepairStatusCmb
        Me.RepairStatusCmb.Location = New System.Drawing.Point(3, 24)
        Me.RepairStatusCmb.Name = "RepairStatusCmb"
        Me.RepairStatusCmb.ShadowDecoration.Parent = Me.RepairStatusCmb
        Me.RepairStatusCmb.Size = New System.Drawing.Size(402, 26)
        Me.RepairStatusCmb.TabIndex = 44
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(411, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 20)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Date Completed"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 20)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Repair Status"
        '
        'BtnSave
        '
        Me.BtnSave.BorderRadius = 4
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(862, 269)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(107, 32)
        Me.BtnSave.TabIndex = 50
        Me.BtnSave.Text = "Finish Service"
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
        Me.BtnClose.Location = New System.Drawing.Point(12, 269)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 49
        Me.BtnClose.Text = "Close"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(-18, 253)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1059, 10)
        Me.Guna2Separator1.TabIndex = 44
        '
        'DeviceCirclePictureBox
        '
        Me.DeviceCirclePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.DeviceCirclePictureBox.Image = CType(resources.GetObject("DeviceCirclePictureBox.Image"), System.Drawing.Image)
        Me.DeviceCirclePictureBox.Location = New System.Drawing.Point(839, 53)
        Me.DeviceCirclePictureBox.Name = "DeviceCirclePictureBox"
        Me.DeviceCirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.DeviceCirclePictureBox.ShadowDecoration.Parent = Me.DeviceCirclePictureBox
        Me.DeviceCirclePictureBox.Size = New System.Drawing.Size(130, 128)
        Me.DeviceCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeviceCirclePictureBox.TabIndex = 56
        Me.DeviceCirclePictureBox.TabStop = False
        Me.DeviceCirclePictureBox.UseTransparentBackground = True
        '
        'ServiceEvaluationModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 313)
        Me.Controls.Add(Me.Groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServiceEvaluationModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServiceRepairResult"
        Me.TopMost = True
        Me.Groupbox.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.RepairStatusTableLayout.ResumeLayout(False)
        Me.RepairStatusTableLayout.PerformLayout()
        CType(Me.DeviceCirclePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Groupbox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DeviceCirclePictureBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PartsCostTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SeePartsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PartsUsedTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents RepairNotesTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents RepairStatusTableLayout As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents RepairStatusCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateCompletedDTP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TotalCostTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TechnicianFeeTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
