<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.ViewControlPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginPasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LoginEmailTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VideoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ViewControlPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewControlPanel
        '
        Me.ViewControlPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ViewControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ViewControlPanel.Name = "ViewControlPanel"
        Me.ViewControlPanel.ShadowDecoration.Parent = Me.ViewControlPanel
        Me.ViewControlPanel.Size = New System.Drawing.Size(1264, 681)
        Me.ViewControlPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VideoPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 681.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 681.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 681)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.LoginButton)
        Me.Guna2Panel1.Controls.Add(Me.LoginPasswordTextBox)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel4)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel3)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.LoginEmailTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(632, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(632, 681)
        Me.Guna2Panel1.TabIndex = 0
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginButton.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.LoginButton.BorderRadius = 4
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(168, 431)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(289, 45)
        Me.LoginButton.TabIndex = 15
        Me.LoginButton.Text = "Login"
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginPasswordTextBox.BorderRadius = 4
        Me.LoginPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LoginPasswordTextBox.DefaultText = ""
        Me.LoginPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LoginPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LoginPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginPasswordTextBox.DisabledState.Parent = Me.LoginPasswordTextBox
        Me.LoginPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginPasswordTextBox.FocusedState.Parent = Me.LoginPasswordTextBox
        Me.LoginPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginPasswordTextBox.HoverState.Parent = Me.LoginPasswordTextBox
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(168, 365)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoginPasswordTextBox.PlaceholderText = ""
        Me.LoginPasswordTextBox.SelectedText = ""
        Me.LoginPasswordTextBox.ShadowDecoration.Parent = Me.LoginPasswordTextBox
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(289, 30)
        Me.LoginPasswordTextBox.TabIndex = 14
        Me.LoginPasswordTextBox.UseSystemPasswordChar = True
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.Location = New System.Drawing.Point(164, 342)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(69, 20)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "Password"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.Location = New System.Drawing.Point(164, 274)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(45, 20)
        Me.GunaLabel3.TabIndex = 12
        Me.GunaLabel3.Text = "Email"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(136, 204)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(76, 31)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Login"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Separator1.Location = New System.Drawing.Point(142, 238)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(355, 10)
        Me.Guna2Separator1.TabIndex = 10
        '
        'LoginEmailTextBox
        '
        Me.LoginEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginEmailTextBox.BorderRadius = 4
        Me.LoginEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LoginEmailTextBox.DefaultText = ""
        Me.LoginEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LoginEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LoginEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginEmailTextBox.DisabledState.Parent = Me.LoginEmailTextBox
        Me.LoginEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginEmailTextBox.FocusedState.Parent = Me.LoginEmailTextBox
        Me.LoginEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginEmailTextBox.HoverState.Parent = Me.LoginEmailTextBox
        Me.LoginEmailTextBox.Location = New System.Drawing.Point(168, 297)
        Me.LoginEmailTextBox.Name = "LoginEmailTextBox"
        Me.LoginEmailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoginEmailTextBox.PlaceholderText = ""
        Me.LoginEmailTextBox.SelectedText = ""
        Me.LoginEmailTextBox.ShadowDecoration.Parent = Me.LoginEmailTextBox
        Me.LoginEmailTextBox.Size = New System.Drawing.Size(289, 30)
        Me.LoginEmailTextBox.TabIndex = 9
        '
        'VideoPanel
        '
        Me.VideoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VideoPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.VideoPanel.Name = "VideoPanel"
        Me.VideoPanel.ShadowDecoration.Parent = Me.VideoPanel
        Me.VideoPanel.Size = New System.Drawing.Size(632, 681)
        Me.VideoPanel.TabIndex = 1
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ViewControlPanel)
        Me.MinimumSize = New System.Drawing.Size(1024, 720)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.ViewControlPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewControlPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoginPasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LoginEmailTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VideoPanel As Guna.UI2.WinForms.Guna2Panel
End Class
