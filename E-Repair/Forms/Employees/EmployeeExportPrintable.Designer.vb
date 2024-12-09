<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeExportPrintable
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New E_Repair.DataSet1()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalendarFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalendarTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FetchAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "employees"
        Me.EmployeesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.Button3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnClose)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1110, 611)
        Me.Guna2GroupBox1.TabIndex = 7
        Me.Guna2GroupBox1.Text = "Employee Report"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.CalendarFrom)
        Me.Guna2Panel1.Controls.Add(Me.Panel6)
        Me.Guna2Panel1.Controls.Add(Me.CalendarTo)
        Me.Guna2Panel1.Controls.Add(Me.Panel3)
        Me.Guna2Panel1.Controls.Add(Me.FetchAllBtn)
        Me.Guna2Panel1.Controls.Add(Me.BtnReload)
        Me.Guna2Panel1.Location = New System.Drawing.Point(15, 47)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1083, 28)
        Me.Guna2Panel1.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(419, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(64, 28)
        Me.Panel1.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "From"
        '
        'CalendarFrom
        '
        Me.CalendarFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.CalendarFrom.BorderRadius = 4
        Me.CalendarFrom.BorderThickness = 1
        Me.CalendarFrom.Checked = True
        Me.CalendarFrom.CheckedState.Parent = Me.CalendarFrom
        Me.CalendarFrom.Dock = System.Windows.Forms.DockStyle.Right
        Me.CalendarFrom.FillColor = System.Drawing.Color.White
        Me.CalendarFrom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CalendarFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.CalendarFrom.HoverState.Parent = Me.CalendarFrom
        Me.CalendarFrom.Location = New System.Drawing.Point(483, 0)
        Me.CalendarFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.CalendarFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.CalendarFrom.Name = "CalendarFrom"
        Me.CalendarFrom.ShadowDecoration.Parent = Me.CalendarFrom
        Me.CalendarFrom.Size = New System.Drawing.Size(232, 28)
        Me.CalendarFrom.TabIndex = 79
        Me.CalendarFrom.Value = New Date(2024, 11, 1, 5, 3, 38, 85)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(715, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(40, 28)
        Me.Panel6.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "To"
        '
        'CalendarTo
        '
        Me.CalendarTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.CalendarTo.BorderRadius = 4
        Me.CalendarTo.BorderThickness = 1
        Me.CalendarTo.Checked = True
        Me.CalendarTo.CheckedState.Parent = Me.CalendarTo
        Me.CalendarTo.Dock = System.Windows.Forms.DockStyle.Right
        Me.CalendarTo.FillColor = System.Drawing.Color.White
        Me.CalendarTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CalendarTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.CalendarTo.HoverState.Parent = Me.CalendarTo
        Me.CalendarTo.Location = New System.Drawing.Point(755, 0)
        Me.CalendarTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.CalendarTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.CalendarTo.Name = "CalendarTo"
        Me.CalendarTo.ShadowDecoration.Parent = Me.CalendarTo
        Me.CalendarTo.Size = New System.Drawing.Size(232, 28)
        Me.CalendarTo.TabIndex = 77
        Me.CalendarTo.Value = New Date(2024, 11, 1, 5, 3, 38, 85)
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(987, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 28)
        Me.Panel3.TabIndex = 75
        '
        'FetchAllBtn
        '
        Me.FetchAllBtn.BorderRadius = 4
        Me.FetchAllBtn.CheckedState.Parent = Me.FetchAllBtn
        Me.FetchAllBtn.CustomImages.Parent = Me.FetchAllBtn
        Me.FetchAllBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.FetchAllBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FetchAllBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetchAllBtn.ForeColor = System.Drawing.Color.White
        Me.FetchAllBtn.HoverState.Parent = Me.FetchAllBtn
        Me.FetchAllBtn.Location = New System.Drawing.Point(0, 0)
        Me.FetchAllBtn.Name = "FetchAllBtn"
        Me.FetchAllBtn.ShadowDecoration.Parent = Me.FetchAllBtn
        Me.FetchAllBtn.Size = New System.Drawing.Size(88, 28)
        Me.FetchAllBtn.TabIndex = 53
        Me.FetchAllBtn.Text = "All Time"
        '
        'BtnReload
        '
        Me.BtnReload.BorderRadius = 4
        Me.BtnReload.CheckedState.Parent = Me.BtnReload
        Me.BtnReload.CustomImages.Parent = Me.BtnReload
        Me.BtnReload.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnReload.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnReload.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.ForeColor = System.Drawing.Color.White
        Me.BtnReload.HoverState.Parent = Me.BtnReload
        Me.BtnReload.Location = New System.Drawing.Point(997, 0)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.ShadowDecoration.Parent = Me.BtnReload
        Me.BtnReload.Size = New System.Drawing.Size(86, 28)
        Me.BtnReload.TabIndex = 44
        Me.BtnReload.Text = "Reload"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.ForeColor = System.Drawing.Color.Black
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EmployeesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "E_Repair.EmployeesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 83)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1083, 458)
        Me.ReportViewer1.TabIndex = 57
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(2, 547)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(1108, 13)
        Me.Guna2Separator3.TabIndex = 55
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
        Me.Button3.Location = New System.Drawing.Point(17, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.ShadowDecoration.Parent = Me.Button3
        Me.Button3.Size = New System.Drawing.Size(107, 32)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Close"
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
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'EmployeesBindingSource1
        '
        Me.EmployeesBindingSource1.DataMember = "employees"
        Me.EmployeesBindingSource1.DataSource = Me.DataSet1
        '
        'EmployeeExportPrintable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 611)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeExportPrintable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeExportRLDC"
        Me.TopMost = True
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents EmployeesBindingSource1 As BindingSource
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CalendarFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CalendarTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FetchAllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReload As Guna.UI2.WinForms.Guna2Button
End Class
