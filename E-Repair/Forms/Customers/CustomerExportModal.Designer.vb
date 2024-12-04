<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerExportModal
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
        Me.Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExportAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportPrintBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.ProfileCirclePictureBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ProfileCirclePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.Button3)
        Me.Guna2GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnClose)
        Me.Guna2GroupBox1.Controls.Add(Me.ProfileCirclePictureBox)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(420, 181)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Customer Report"
        '
        'Button3
        '
        Me.Button3.BorderRadius = 4
        Me.Button3.CheckedState.Parent = Me.Button3
        Me.Button3.CustomImages.Parent = Me.Button3
        Me.Button3.FillColor = System.Drawing.Color.DarkRed
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.HoverState.Parent = Me.Button3
        Me.Button3.Location = New System.Drawing.Point(14, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.ShadowDecoration.Parent = Me.Button3
        Me.Button3.Size = New System.Drawing.Size(107, 32)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Close"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ExportAllBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExportPrintBtn, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 49)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(398, 46)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'ExportAllBtn
        '
        Me.ExportAllBtn.BorderRadius = 4
        Me.ExportAllBtn.CheckedState.Parent = Me.ExportAllBtn
        Me.ExportAllBtn.CustomImages.Parent = Me.ExportAllBtn
        Me.ExportAllBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportAllBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportAllBtn.ForeColor = System.Drawing.Color.White
        Me.ExportAllBtn.HoverState.Parent = Me.ExportAllBtn
        Me.ExportAllBtn.Location = New System.Drawing.Point(202, 3)
        Me.ExportAllBtn.Name = "ExportAllBtn"
        Me.ExportAllBtn.ShadowDecoration.Parent = Me.ExportAllBtn
        Me.ExportAllBtn.Size = New System.Drawing.Size(193, 39)
        Me.ExportAllBtn.TabIndex = 40
        Me.ExportAllBtn.Text = "Export All"
        '
        'ExportPrintBtn
        '
        Me.ExportPrintBtn.BorderRadius = 4
        Me.ExportPrintBtn.CheckedState.Parent = Me.ExportPrintBtn
        Me.ExportPrintBtn.CustomImages.Parent = Me.ExportPrintBtn
        Me.ExportPrintBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportPrintBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ExportPrintBtn.ForeColor = System.Drawing.Color.White
        Me.ExportPrintBtn.HoverState.Parent = Me.ExportPrintBtn
        Me.ExportPrintBtn.Location = New System.Drawing.Point(3, 3)
        Me.ExportPrintBtn.Name = "ExportPrintBtn"
        Me.ExportPrintBtn.ShadowDecoration.Parent = Me.ExportPrintBtn
        Me.ExportPrintBtn.Size = New System.Drawing.Size(193, 39)
        Me.ExportPrintBtn.TabIndex = 39
        Me.ExportPrintBtn.Text = "Export Printable"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 669)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(854, 10)
        Me.Guna2Separator1.TabIndex = 35
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BorderRadius = 4
        Me.BtnClose.CheckedState.Parent = Me.BtnClose
        Me.BtnClose.CustomImages.Parent = Me.BtnClose
        Me.BtnClose.FillColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.HoverState.Parent = Me.BtnClose
        Me.BtnClose.Location = New System.Drawing.Point(9, 682)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(107, 32)
        Me.BtnClose.TabIndex = 34
        Me.BtnClose.Text = "Close"
        '
        'ProfileCirclePictureBox
        '
        Me.ProfileCirclePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ProfileCirclePictureBox.Image = Global.E_Repair.My.Resources.Resources.landscape_placeholder_svgrepo_com
        Me.ProfileCirclePictureBox.Location = New System.Drawing.Point(678, 54)
        Me.ProfileCirclePictureBox.Name = "ProfileCirclePictureBox"
        Me.ProfileCirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProfileCirclePictureBox.ShadowDecoration.Parent = Me.ProfileCirclePictureBox
        Me.ProfileCirclePictureBox.Size = New System.Drawing.Size(158, 153)
        Me.ProfileCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfileCirclePictureBox.TabIndex = 28
        Me.ProfileCirclePictureBox.TabStop = False
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 118)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(420, 13)
        Me.Guna2Separator3.TabIndex = 39
        '
        'CustomerExportModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 181)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CustomerExportModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerExportModal"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ProfileCirclePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProfileCirclePictureBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportAllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportPrintBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
End Class
