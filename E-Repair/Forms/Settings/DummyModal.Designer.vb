<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DummyModal
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DummyTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SupplierIDTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SelectSupplierBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TechnicianIDTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SelectTechnicianBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CustomerIDTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SelectCustomerBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.QuantityNumeric = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ProceedBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.DummyTableLayout.SuspendLayout()
        CType(Me.QuantityNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.DummyTableLayout)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.ProceedBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnClose)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(794, 174)
        Me.Guna2GroupBox1.TabIndex = 5
        Me.Guna2GroupBox1.Text = "Generate Dummy Data"
        '
        'DummyTableLayout
        '
        Me.DummyTableLayout.BackColor = System.Drawing.Color.Transparent
        Me.DummyTableLayout.ColumnCount = 7
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.DummyTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DummyTableLayout.Controls.Add(Me.SupplierIDTxtBox, 6, 0)
        Me.DummyTableLayout.Controls.Add(Me.SelectSupplierBtn, 5, 0)
        Me.DummyTableLayout.Controls.Add(Me.TechnicianIDTxtBox, 4, 0)
        Me.DummyTableLayout.Controls.Add(Me.SelectTechnicianBtn, 3, 0)
        Me.DummyTableLayout.Controls.Add(Me.CustomerIDTxtBox, 2, 0)
        Me.DummyTableLayout.Controls.Add(Me.SelectCustomerBtn, 1, 0)
        Me.DummyTableLayout.Controls.Add(Me.QuantityNumeric, 0, 0)
        Me.DummyTableLayout.Location = New System.Drawing.Point(12, 53)
        Me.DummyTableLayout.Name = "DummyTableLayout"
        Me.DummyTableLayout.RowCount = 1
        Me.DummyTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DummyTableLayout.Size = New System.Drawing.Size(770, 41)
        Me.DummyTableLayout.TabIndex = 51
        '
        'SupplierIDTxtBox
        '
        Me.SupplierIDTxtBox.BorderRadius = 4
        Me.SupplierIDTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SupplierIDTxtBox.DefaultText = ""
        Me.SupplierIDTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SupplierIDTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SupplierIDTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SupplierIDTxtBox.DisabledState.Parent = Me.SupplierIDTxtBox
        Me.SupplierIDTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SupplierIDTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SupplierIDTxtBox.Enabled = False
        Me.SupplierIDTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierIDTxtBox.FocusedState.Parent = Me.SupplierIDTxtBox
        Me.SupplierIDTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierIDTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierIDTxtBox.HoverState.Parent = Me.SupplierIDTxtBox
        Me.SupplierIDTxtBox.Location = New System.Drawing.Point(656, 3)
        Me.SupplierIDTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SupplierIDTxtBox.Name = "SupplierIDTxtBox"
        Me.SupplierIDTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SupplierIDTxtBox.PlaceholderText = ""
        Me.SupplierIDTxtBox.SelectedText = ""
        Me.SupplierIDTxtBox.ShadowDecoration.Parent = Me.SupplierIDTxtBox
        Me.SupplierIDTxtBox.Size = New System.Drawing.Size(112, 35)
        Me.SupplierIDTxtBox.TabIndex = 57
        '
        'SelectSupplierBtn
        '
        Me.SelectSupplierBtn.BorderRadius = 4
        Me.SelectSupplierBtn.CheckedState.Parent = Me.SelectSupplierBtn
        Me.SelectSupplierBtn.CustomImages.Parent = Me.SelectSupplierBtn
        Me.SelectSupplierBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SelectSupplierBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSupplierBtn.ForeColor = System.Drawing.Color.White
        Me.SelectSupplierBtn.HoverState.Parent = Me.SelectSupplierBtn
        Me.SelectSupplierBtn.Location = New System.Drawing.Point(548, 2)
        Me.SelectSupplierBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectSupplierBtn.Name = "SelectSupplierBtn"
        Me.SelectSupplierBtn.ShadowDecoration.Parent = Me.SelectSupplierBtn
        Me.SelectSupplierBtn.Size = New System.Drawing.Size(103, 36)
        Me.SelectSupplierBtn.TabIndex = 56
        Me.SelectSupplierBtn.Text = "Select Supplier"
        '
        'TechnicianIDTxtBox
        '
        Me.TechnicianIDTxtBox.BorderRadius = 4
        Me.TechnicianIDTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TechnicianIDTxtBox.DefaultText = ""
        Me.TechnicianIDTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TechnicianIDTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TechnicianIDTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TechnicianIDTxtBox.DisabledState.Parent = Me.TechnicianIDTxtBox
        Me.TechnicianIDTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TechnicianIDTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TechnicianIDTxtBox.Enabled = False
        Me.TechnicianIDTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TechnicianIDTxtBox.FocusedState.Parent = Me.TechnicianIDTxtBox
        Me.TechnicianIDTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechnicianIDTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TechnicianIDTxtBox.HoverState.Parent = Me.TechnicianIDTxtBox
        Me.TechnicianIDTxtBox.Location = New System.Drawing.Point(438, 3)
        Me.TechnicianIDTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TechnicianIDTxtBox.Name = "TechnicianIDTxtBox"
        Me.TechnicianIDTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TechnicianIDTxtBox.PlaceholderText = ""
        Me.TechnicianIDTxtBox.SelectedText = ""
        Me.TechnicianIDTxtBox.ShadowDecoration.Parent = Me.TechnicianIDTxtBox
        Me.TechnicianIDTxtBox.Size = New System.Drawing.Size(105, 35)
        Me.TechnicianIDTxtBox.TabIndex = 55
        '
        'SelectTechnicianBtn
        '
        Me.SelectTechnicianBtn.BorderRadius = 4
        Me.SelectTechnicianBtn.CheckedState.Parent = Me.SelectTechnicianBtn
        Me.SelectTechnicianBtn.CustomImages.Parent = Me.SelectTechnicianBtn
        Me.SelectTechnicianBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SelectTechnicianBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectTechnicianBtn.ForeColor = System.Drawing.Color.White
        Me.SelectTechnicianBtn.HoverState.Parent = Me.SelectTechnicianBtn
        Me.SelectTechnicianBtn.Location = New System.Drawing.Point(330, 2)
        Me.SelectTechnicianBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectTechnicianBtn.Name = "SelectTechnicianBtn"
        Me.SelectTechnicianBtn.ShadowDecoration.Parent = Me.SelectTechnicianBtn
        Me.SelectTechnicianBtn.Size = New System.Drawing.Size(103, 37)
        Me.SelectTechnicianBtn.TabIndex = 54
        Me.SelectTechnicianBtn.Text = "Select Technician"
        '
        'CustomerIDTxtBox
        '
        Me.CustomerIDTxtBox.BorderRadius = 4
        Me.CustomerIDTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerIDTxtBox.DefaultText = ""
        Me.CustomerIDTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CustomerIDTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CustomerIDTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CustomerIDTxtBox.DisabledState.Parent = Me.CustomerIDTxtBox
        Me.CustomerIDTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CustomerIDTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomerIDTxtBox.Enabled = False
        Me.CustomerIDTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerIDTxtBox.FocusedState.Parent = Me.CustomerIDTxtBox
        Me.CustomerIDTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerIDTxtBox.HoverState.Parent = Me.CustomerIDTxtBox
        Me.CustomerIDTxtBox.Location = New System.Drawing.Point(220, 3)
        Me.CustomerIDTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CustomerIDTxtBox.Name = "CustomerIDTxtBox"
        Me.CustomerIDTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CustomerIDTxtBox.PlaceholderText = ""
        Me.CustomerIDTxtBox.SelectedText = ""
        Me.CustomerIDTxtBox.ShadowDecoration.Parent = Me.CustomerIDTxtBox
        Me.CustomerIDTxtBox.Size = New System.Drawing.Size(105, 35)
        Me.CustomerIDTxtBox.TabIndex = 53
        '
        'SelectCustomerBtn
        '
        Me.SelectCustomerBtn.BorderRadius = 4
        Me.SelectCustomerBtn.CheckedState.Parent = Me.SelectCustomerBtn
        Me.SelectCustomerBtn.CustomImages.Parent = Me.SelectCustomerBtn
        Me.SelectCustomerBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SelectCustomerBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectCustomerBtn.ForeColor = System.Drawing.Color.White
        Me.SelectCustomerBtn.HoverState.Parent = Me.SelectCustomerBtn
        Me.SelectCustomerBtn.Location = New System.Drawing.Point(112, 2)
        Me.SelectCustomerBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectCustomerBtn.Name = "SelectCustomerBtn"
        Me.SelectCustomerBtn.ShadowDecoration.Parent = Me.SelectCustomerBtn
        Me.SelectCustomerBtn.Size = New System.Drawing.Size(103, 37)
        Me.SelectCustomerBtn.TabIndex = 52
        Me.SelectCustomerBtn.Text = "Select Customer"
        '
        'QuantityNumeric
        '
        Me.QuantityNumeric.BackColor = System.Drawing.Color.Transparent
        Me.QuantityNumeric.BorderRadius = 4
        Me.QuantityNumeric.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityNumeric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityNumeric.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityNumeric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityNumeric.DisabledState.Parent = Me.QuantityNumeric
        Me.QuantityNumeric.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.QuantityNumeric.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.QuantityNumeric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityNumeric.FocusedState.Parent = Me.QuantityNumeric
        Me.QuantityNumeric.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityNumeric.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.QuantityNumeric.Location = New System.Drawing.Point(3, 3)
        Me.QuantityNumeric.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.QuantityNumeric.Name = "QuantityNumeric"
        Me.QuantityNumeric.ShadowDecoration.Parent = Me.QuantityNumeric
        Me.QuantityNumeric.Size = New System.Drawing.Size(103, 35)
        Me.QuantityNumeric.TabIndex = 51
        Me.QuantityNumeric.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.QuantityNumeric.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(-6, 110)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(800, 13)
        Me.Guna2Separator3.TabIndex = 37
        '
        'ProceedBtn
        '
        Me.ProceedBtn.BorderRadius = 4
        Me.ProceedBtn.CheckedState.Parent = Me.ProceedBtn
        Me.ProceedBtn.CustomImages.Parent = Me.ProceedBtn
        Me.ProceedBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ProceedBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProceedBtn.ForeColor = System.Drawing.Color.White
        Me.ProceedBtn.HoverState.Parent = Me.ProceedBtn
        Me.ProceedBtn.Location = New System.Drawing.Point(675, 129)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.ShadowDecoration.Parent = Me.ProceedBtn
        Me.ProceedBtn.Size = New System.Drawing.Size(107, 32)
        Me.ProceedBtn.TabIndex = 36
        Me.ProceedBtn.Text = "Proceed"
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
        Me.BtnClose.Location = New System.Drawing.Point(6, 129)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 35
        Me.BtnClose.Text = "Close"
        '
        'DummyModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 174)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DummyModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.DummyTableLayout.ResumeLayout(False)
        CType(Me.QuantityNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ProceedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DummyTableLayout As TableLayoutPanel
    Friend WithEvents QuantityNumeric As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents SelectCustomerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CustomerIDTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TechnicianIDTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SelectTechnicianBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupplierIDTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SelectSupplierBtn As Guna.UI2.WinForms.Guna2Button
End Class
