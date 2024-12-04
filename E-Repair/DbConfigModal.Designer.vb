<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBConfigModal
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
        Me.SupplierModalGroupBox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dbNameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dbPassTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.uidTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ServerTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SupplierModalGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierModalGroupBox
        '
        Me.SupplierModalGroupBox.Controls.Add(Me.Guna2Separator1)
        Me.SupplierModalGroupBox.Controls.Add(Me.SaveBtn)
        Me.SupplierModalGroupBox.Controls.Add(Me.CloseBtn)
        Me.SupplierModalGroupBox.Controls.Add(Me.dbNameTxtBox)
        Me.SupplierModalGroupBox.Controls.Add(Me.dbPassTxtBox)
        Me.SupplierModalGroupBox.Controls.Add(Me.uidTxtBox)
        Me.SupplierModalGroupBox.Controls.Add(Me.Guna2HtmlLabel2)
        Me.SupplierModalGroupBox.Controls.Add(Me.Guna2HtmlLabel1)
        Me.SupplierModalGroupBox.Controls.Add(Me.ServerTxtBox)
        Me.SupplierModalGroupBox.Controls.Add(Me.Guna2Separator3)
        Me.SupplierModalGroupBox.Controls.Add(Me.BtnSave)
        Me.SupplierModalGroupBox.Controls.Add(Me.BtnClose)
        Me.SupplierModalGroupBox.Controls.Add(Me.GunaLabel1)
        Me.SupplierModalGroupBox.Controls.Add(Me.Guna2TextBox2)
        Me.SupplierModalGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SupplierModalGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierModalGroupBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierModalGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SupplierModalGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.SupplierModalGroupBox.Name = "SupplierModalGroupBox"
        Me.SupplierModalGroupBox.ShadowDecoration.Parent = Me.SupplierModalGroupBox
        Me.SupplierModalGroupBox.Size = New System.Drawing.Size(594, 304)
        Me.SupplierModalGroupBox.TabIndex = 3
        Me.SupplierModalGroupBox.Text = "Database Settings"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 239)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(594, 13)
        Me.Guna2Separator1.TabIndex = 45
        '
        'SaveBtn
        '
        Me.SaveBtn.BorderRadius = 4
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.SaveBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(476, 258)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(107, 32)
        Me.SaveBtn.TabIndex = 44
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.Visible = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BorderRadius = 4
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.DarkRed
        Me.CloseBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(11, 258)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(107, 32)
        Me.CloseBtn.TabIndex = 43
        Me.CloseBtn.Text = "Close"
        '
        'dbNameTxtBox
        '
        Me.dbNameTxtBox.BackColor = System.Drawing.Color.White
        Me.dbNameTxtBox.BorderRadius = 4
        Me.dbNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbNameTxtBox.DefaultText = ""
        Me.dbNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dbNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dbNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dbNameTxtBox.DisabledState.Parent = Me.dbNameTxtBox
        Me.dbNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dbNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dbNameTxtBox.FocusedState.Parent = Me.dbNameTxtBox
        Me.dbNameTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dbNameTxtBox.HoverState.Parent = Me.dbNameTxtBox
        Me.dbNameTxtBox.Location = New System.Drawing.Point(11, 196)
        Me.dbNameTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dbNameTxtBox.Name = "dbNameTxtBox"
        Me.dbNameTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbNameTxtBox.PlaceholderText = "Your Database Name"
        Me.dbNameTxtBox.SelectedText = ""
        Me.dbNameTxtBox.ShadowDecoration.Parent = Me.dbNameTxtBox
        Me.dbNameTxtBox.Size = New System.Drawing.Size(572, 34)
        Me.dbNameTxtBox.TabIndex = 42
        '
        'dbPassTxtBox
        '
        Me.dbPassTxtBox.BackColor = System.Drawing.Color.White
        Me.dbPassTxtBox.BorderRadius = 4
        Me.dbPassTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbPassTxtBox.DefaultText = ""
        Me.dbPassTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dbPassTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dbPassTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dbPassTxtBox.DisabledState.Parent = Me.dbPassTxtBox
        Me.dbPassTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dbPassTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dbPassTxtBox.FocusedState.Parent = Me.dbPassTxtBox
        Me.dbPassTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbPassTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dbPassTxtBox.HoverState.Parent = Me.dbPassTxtBox
        Me.dbPassTxtBox.Location = New System.Drawing.Point(11, 156)
        Me.dbPassTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dbPassTxtBox.Name = "dbPassTxtBox"
        Me.dbPassTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbPassTxtBox.PlaceholderText = "Database Password: Could be None"
        Me.dbPassTxtBox.SelectedText = ""
        Me.dbPassTxtBox.ShadowDecoration.Parent = Me.dbPassTxtBox
        Me.dbPassTxtBox.Size = New System.Drawing.Size(572, 34)
        Me.dbPassTxtBox.TabIndex = 41
        '
        'uidTxtBox
        '
        Me.uidTxtBox.BackColor = System.Drawing.Color.White
        Me.uidTxtBox.BorderRadius = 4
        Me.uidTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.uidTxtBox.DefaultText = ""
        Me.uidTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.uidTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.uidTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.uidTxtBox.DisabledState.Parent = Me.uidTxtBox
        Me.uidTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.uidTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uidTxtBox.FocusedState.Parent = Me.uidTxtBox
        Me.uidTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uidTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uidTxtBox.HoverState.Parent = Me.uidTxtBox
        Me.uidTxtBox.Location = New System.Drawing.Point(11, 116)
        Me.uidTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.uidTxtBox.Name = "uidTxtBox"
        Me.uidTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.uidTxtBox.PlaceholderText = "User ID: e.g. root"
        Me.uidTxtBox.SelectedText = ""
        Me.uidTxtBox.ShadowDecoration.Parent = Me.uidTxtBox
        Me.uidTxtBox.Size = New System.Drawing.Size(572, 34)
        Me.uidTxtBox.TabIndex = 40
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(520, 55)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(33, 15)
        Me.Guna2HtmlLabel2.TabIndex = 39
        Me.Guna2HtmlLabel2.Text = "Status"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(421, 55)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 15)
        Me.Guna2HtmlLabel1.TabIndex = 38
        Me.Guna2HtmlLabel1.Text = "Connection Status:"
        '
        'ServerTxtBox
        '
        Me.ServerTxtBox.BackColor = System.Drawing.Color.White
        Me.ServerTxtBox.BorderRadius = 4
        Me.ServerTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ServerTxtBox.DefaultText = ""
        Me.ServerTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ServerTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ServerTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ServerTxtBox.DisabledState.Parent = Me.ServerTxtBox
        Me.ServerTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ServerTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerTxtBox.FocusedState.Parent = Me.ServerTxtBox
        Me.ServerTxtBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerTxtBox.HoverState.Parent = Me.ServerTxtBox
        Me.ServerTxtBox.Location = New System.Drawing.Point(11, 76)
        Me.ServerTxtBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ServerTxtBox.Name = "ServerTxtBox"
        Me.ServerTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ServerTxtBox.PlaceholderText = "Server: e.g. localhost or 8.8.8.8"
        Me.ServerTxtBox.SelectedText = ""
        Me.ServerTxtBox.ShadowDecoration.Parent = Me.ServerTxtBox
        Me.ServerTxtBox.Size = New System.Drawing.Size(572, 34)
        Me.ServerTxtBox.TabIndex = 37
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(1, 461)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(840, 13)
        Me.Guna2Separator3.TabIndex = 36
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
        Me.BtnSave.Location = New System.Drawing.Point(718, 476)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(107, 32)
        Me.BtnSave.TabIndex = 35
        Me.BtnSave.Text = "Save"
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
        Me.BtnClose.Location = New System.Drawing.Point(13, 477)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 34
        Me.BtnClose.Text = "Close"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(-79, 234)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(73, 20)
        Me.GunaLabel1.TabIndex = 10
        Me.GunaLabel1.Text = "First Name"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderRadius = 4
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(4117, 502)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(85, 69, 85, 69)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(1697, 189)
        Me.Guna2TextBox2.TabIndex = 6
        '
        'DBConfigModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 304)
        Me.Controls.Add(Me.SupplierModalGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DBConfigModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DbConfigModal"
        Me.TopMost = True
        Me.SupplierModalGroupBox.ResumeLayout(False)
        Me.SupplierModalGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SupplierModalGroupBox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ServerTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dbNameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dbPassTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents uidTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
