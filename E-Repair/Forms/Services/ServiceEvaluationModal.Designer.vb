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
        Me.GenerateReceiptBtn = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DeviceCirclePictureBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.TechnicianFeeTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeviceTypeCmbBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateCompletedTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GenerateReceiptBtn.SuspendLayout()
        CType(Me.DeviceCirclePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.RepairStatusTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenerateReceiptBtn
        '
        Me.GenerateReceiptBtn.Controls.Add(Me.DeviceCirclePictureBox)
        Me.GenerateReceiptBtn.Controls.Add(Me.Guna2Panel2)
        Me.GenerateReceiptBtn.Controls.Add(Me.Guna2Panel8)
        Me.GenerateReceiptBtn.Controls.Add(Me.Guna2Panel7)
        Me.GenerateReceiptBtn.Controls.Add(Me.BtnSave)
        Me.GenerateReceiptBtn.Controls.Add(Me.BtnClose)
        Me.GenerateReceiptBtn.Controls.Add(Me.Guna2Separator1)
        Me.GenerateReceiptBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GenerateReceiptBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenerateReceiptBtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateReceiptBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GenerateReceiptBtn.Location = New System.Drawing.Point(0, 0)
        Me.GenerateReceiptBtn.Name = "GenerateReceiptBtn"
        Me.GenerateReceiptBtn.ShadowDecoration.Parent = Me.GenerateReceiptBtn
        Me.GenerateReceiptBtn.Size = New System.Drawing.Size(986, 313)
        Me.GenerateReceiptBtn.TabIndex = 3
        Me.GenerateReceiptBtn.Text = "Technician Service Evaluation"
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
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PartsCostTxtBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SeePartsBtn, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PartsUsedTxtBox, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(949, 53)
        Me.TableLayoutPanel2.TabIndex = 8
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
        Me.PartsCostTxtBox.Location = New System.Drawing.Point(318, 24)
        Me.PartsCostTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PartsCostTxtBox.Name = "PartsCostTxtBox"
        Me.PartsCostTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PartsCostTxtBox.PlaceholderText = ""
        Me.PartsCostTxtBox.ReadOnly = True
        Me.PartsCostTxtBox.SelectedText = ""
        Me.PartsCostTxtBox.ShadowDecoration.Parent = Me.PartsCostTxtBox
        Me.PartsCostTxtBox.Size = New System.Drawing.Size(312, 26)
        Me.PartsCostTxtBox.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(319, 0)
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
        Me.SeePartsBtn.Location = New System.Drawing.Point(635, 23)
        Me.SeePartsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SeePartsBtn.Name = "SeePartsBtn"
        Me.SeePartsBtn.ShadowDecoration.Parent = Me.SeePartsBtn
        Me.SeePartsBtn.Size = New System.Drawing.Size(311, 28)
        Me.SeePartsBtn.TabIndex = 60
        Me.SeePartsBtn.Text = "See Parts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(635, 0)
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
        Me.Label6.Location = New System.Drawing.Point(3, 0)
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
        Me.PartsUsedTxtBox.Location = New System.Drawing.Point(2, 24)
        Me.PartsUsedTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PartsUsedTxtBox.Name = "PartsUsedTxtBox"
        Me.PartsUsedTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PartsUsedTxtBox.PlaceholderText = ""
        Me.PartsUsedTxtBox.ReadOnly = True
        Me.PartsUsedTxtBox.SelectedText = ""
        Me.PartsUsedTxtBox.ShadowDecoration.Parent = Me.PartsUsedTxtBox
        Me.PartsUsedTxtBox.Size = New System.Drawing.Size(312, 26)
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
        Me.RepairNotesTxtBox.ReadOnly = True
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
        Me.RepairStatusTableLayout.ColumnCount = 3
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.RepairStatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.RepairStatusTableLayout.Controls.Add(Me.TechnicianFeeTxtBox, 2, 1)
        Me.RepairStatusTableLayout.Controls.Add(Me.Label7, 2, 0)
        Me.RepairStatusTableLayout.Controls.Add(Me.DeviceTypeCmbBox, 0, 1)
        Me.RepairStatusTableLayout.Controls.Add(Me.DateCompletedTxtBox, 1, 1)
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
        Me.TechnicianFeeTxtBox.Location = New System.Drawing.Point(546, 24)
        Me.TechnicianFeeTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TechnicianFeeTxtBox.Name = "TechnicianFeeTxtBox"
        Me.TechnicianFeeTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TechnicianFeeTxtBox.PlaceholderText = ""
        Me.TechnicianFeeTxtBox.ReadOnly = True
        Me.TechnicianFeeTxtBox.SelectedText = ""
        Me.TechnicianFeeTxtBox.ShadowDecoration.Parent = Me.TechnicianFeeTxtBox
        Me.TechnicianFeeTxtBox.Size = New System.Drawing.Size(268, 26)
        Me.TechnicianFeeTxtBox.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(547, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Technician Fee"
        '
        'DeviceTypeCmbBox
        '
        Me.DeviceTypeCmbBox.BackColor = System.Drawing.Color.Transparent
        Me.DeviceTypeCmbBox.BorderRadius = 4
        Me.DeviceTypeCmbBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeviceTypeCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DeviceTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceTypeCmbBox.FocusedColor = System.Drawing.Color.Empty
        Me.DeviceTypeCmbBox.FocusedState.Parent = Me.DeviceTypeCmbBox
        Me.DeviceTypeCmbBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeviceTypeCmbBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DeviceTypeCmbBox.FormattingEnabled = True
        Me.DeviceTypeCmbBox.HoverState.Parent = Me.DeviceTypeCmbBox
        Me.DeviceTypeCmbBox.ItemHeight = 20
        Me.DeviceTypeCmbBox.ItemsAppearance.Parent = Me.DeviceTypeCmbBox
        Me.DeviceTypeCmbBox.Location = New System.Drawing.Point(3, 24)
        Me.DeviceTypeCmbBox.Name = "DeviceTypeCmbBox"
        Me.DeviceTypeCmbBox.ShadowDecoration.Parent = Me.DeviceTypeCmbBox
        Me.DeviceTypeCmbBox.Size = New System.Drawing.Size(266, 26)
        Me.DeviceTypeCmbBox.TabIndex = 44
        '
        'DateCompletedTxtBox
        '
        Me.DateCompletedTxtBox.BorderRadius = 4
        Me.DateCompletedTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateCompletedTxtBox.DefaultText = ""
        Me.DateCompletedTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DateCompletedTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DateCompletedTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DateCompletedTxtBox.DisabledState.Parent = Me.DateCompletedTxtBox
        Me.DateCompletedTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DateCompletedTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateCompletedTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateCompletedTxtBox.FocusedState.Parent = Me.DateCompletedTxtBox
        Me.DateCompletedTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCompletedTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateCompletedTxtBox.HoverState.Parent = Me.DateCompletedTxtBox
        Me.DateCompletedTxtBox.Location = New System.Drawing.Point(274, 24)
        Me.DateCompletedTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DateCompletedTxtBox.Name = "DateCompletedTxtBox"
        Me.DateCompletedTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DateCompletedTxtBox.PlaceholderText = ""
        Me.DateCompletedTxtBox.ReadOnly = True
        Me.DateCompletedTxtBox.SelectedText = ""
        Me.DateCompletedTxtBox.ShadowDecoration.Parent = Me.DateCompletedTxtBox
        Me.DateCompletedTxtBox.Size = New System.Drawing.Size(268, 26)
        Me.DateCompletedTxtBox.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(275, 0)
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
        Me.BtnClose.Text = "Cancel"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(-18, 253)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1059, 10)
        Me.Guna2Separator1.TabIndex = 44
        '
        'ServiceEvaluationModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 313)
        Me.Controls.Add(Me.GenerateReceiptBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServiceEvaluationModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServiceRepairResult"
        Me.TopMost = True
        Me.GenerateReceiptBtn.ResumeLayout(False)
        CType(Me.DeviceCirclePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.RepairStatusTableLayout.ResumeLayout(False)
        Me.RepairStatusTableLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenerateReceiptBtn As Guna.UI2.WinForms.Guna2GroupBox
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
    Friend WithEvents DateCompletedTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents DeviceTypeCmbBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TechnicianFeeTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
End Class
