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
        Me.QtyTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ProceedBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.QtyTextBox)
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
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(800, 154)
        Me.Guna2GroupBox1.TabIndex = 4
        Me.Guna2GroupBox1.Text = "Generate Dummy Data"
        '
        'QtyTextBox
        '
        Me.QtyTextBox.BorderRadius = 4
        Me.QtyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QtyTextBox.DefaultText = ""
        Me.QtyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QtyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QtyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QtyTextBox.DisabledState.Parent = Me.QtyTextBox
        Me.QtyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QtyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QtyTextBox.FocusedState.Parent = Me.QtyTextBox
        Me.QtyTextBox.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QtyTextBox.HoverState.Parent = Me.QtyTextBox
        Me.QtyTextBox.Location = New System.Drawing.Point(11, 48)
        Me.QtyTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QtyTextBox.PlaceholderText = "Please enter the amount to be Generated"
        Me.QtyTextBox.SelectedText = ""
        Me.QtyTextBox.ShadowDecoration.Parent = Me.QtyTextBox
        Me.QtyTextBox.Size = New System.Drawing.Size(776, 38)
        Me.QtyTextBox.TabIndex = 38
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 88)
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
        Me.ProceedBtn.Location = New System.Drawing.Point(681, 107)
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
        Me.BtnClose.Location = New System.Drawing.Point(12, 107)
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
        Me.ClientSize = New System.Drawing.Size(800, 154)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DummyModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DummyModal"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ProceedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents QtyTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
