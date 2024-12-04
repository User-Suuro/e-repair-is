<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicesExportModal
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
        Me.button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExportPendBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportClmdBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportSummBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.button3)
        Me.Guna2GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnClose)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(498, 260)
        Me.Guna2GroupBox1.TabIndex = 4
        Me.Guna2GroupBox1.Text = "Services Report"
        '
        'button3
        '
        Me.button3.BorderRadius = 4
        Me.button3.FillColor = System.Drawing.Color.DarkRed
        Me.button3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Location = New System.Drawing.Point(13, 208)
        Me.button3.Margin = New System.Windows.Forms.Padding(4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(143, 39)
        Me.button3.TabIndex = 41
        Me.button3.Text = "Close"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ExportPendBtn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ExportClmdBtn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ExportAllBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExportSummBtn, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(485, 129)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'ExportPendBtn
        '
        Me.ExportPendBtn.BorderRadius = 4
        Me.ExportPendBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportPendBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportPendBtn.ForeColor = System.Drawing.Color.White
        Me.ExportPendBtn.Location = New System.Drawing.Point(246, 67)
        Me.ExportPendBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportPendBtn.Name = "ExportPendBtn"
        Me.ExportPendBtn.Size = New System.Drawing.Size(227, 48)
        Me.ExportPendBtn.TabIndex = 43
        Me.ExportPendBtn.Text = "Export Pending"
        '
        'ExportClmdBtn
        '
        Me.ExportClmdBtn.BorderRadius = 4
        Me.ExportClmdBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportClmdBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportClmdBtn.ForeColor = System.Drawing.Color.White
        Me.ExportClmdBtn.Location = New System.Drawing.Point(4, 67)
        Me.ExportClmdBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportClmdBtn.Name = "ExportClmdBtn"
        Me.ExportClmdBtn.Size = New System.Drawing.Size(234, 48)
        Me.ExportClmdBtn.TabIndex = 42
        Me.ExportClmdBtn.Text = "Export Claimed"
        '
        'ExportAllBtn
        '
        Me.ExportAllBtn.BorderRadius = 4
        Me.ExportAllBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportAllBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportAllBtn.ForeColor = System.Drawing.Color.White
        Me.ExportAllBtn.Location = New System.Drawing.Point(246, 4)
        Me.ExportAllBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportAllBtn.Name = "ExportAllBtn"
        Me.ExportAllBtn.Size = New System.Drawing.Size(227, 48)
        Me.ExportAllBtn.TabIndex = 41
        Me.ExportAllBtn.Text = "Export All"
        '
        'ExportSummBtn
        '
        Me.ExportSummBtn.BorderRadius = 4
        Me.ExportSummBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportSummBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportSummBtn.ForeColor = System.Drawing.Color.White
        Me.ExportSummBtn.Location = New System.Drawing.Point(4, 4)
        Me.ExportSummBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportSummBtn.Name = "ExportSummBtn"
        Me.ExportSummBtn.Size = New System.Drawing.Size(234, 48)
        Me.ExportSummBtn.TabIndex = 40
        Me.ExportSummBtn.Text = "Export Summary"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 823)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1139, 12)
        Me.Guna2Separator1.TabIndex = 35
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BorderRadius = 4
        Me.BtnClose.FillColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(12, 839)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(143, 39)
        Me.BtnClose.TabIndex = 34
        Me.BtnClose.Text = "Close"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 182)
        Me.Guna2Separator3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(498, 16)
        Me.Guna2Separator3.TabIndex = 42
        '
        'ServicesExportModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 260)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServicesExportModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServicesExportModal"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportPendBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportClmdBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportAllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportSummBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
End Class
