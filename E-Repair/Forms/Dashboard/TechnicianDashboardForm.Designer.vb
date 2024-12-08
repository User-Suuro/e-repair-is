<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechnicianDashboardForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ItemsUsedLabelCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ServCountLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WelcomeMessageLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.InvetoryAvailChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DeviceTypeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ServStatusChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalendarFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalendarTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FetchAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.StatusTableLayout.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.InvetoryAvailChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeviceTypeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServStatusChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusTableLayout
        '
        Me.StatusTableLayout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusTableLayout.BackColor = System.Drawing.Color.Transparent
        Me.StatusTableLayout.ColumnCount = 2
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatusTableLayout.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.StatusTableLayout.Controls.Add(Me.Guna2Panel6, 0, 0)
        Me.StatusTableLayout.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusTableLayout.Location = New System.Drawing.Point(9, 115)
        Me.StatusTableLayout.Name = "StatusTableLayout"
        Me.StatusTableLayout.RowCount = 1
        Me.StatusTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.StatusTableLayout.Size = New System.Drawing.Size(1161, 100)
        Me.StatusTableLayout.TabIndex = 10
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 4
        Me.Guna2Panel1.Controls.Add(Me.ItemsUsedLabelCount)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(580, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(569, 88)
        Me.Guna2Panel1.TabIndex = 7
        '
        'ItemsUsedLabelCount
        '
        Me.ItemsUsedLabelCount.AutoSize = True
        Me.ItemsUsedLabelCount.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsUsedLabelCount.ForeColor = System.Drawing.Color.Black
        Me.ItemsUsedLabelCount.Location = New System.Drawing.Point(14, 24)
        Me.ItemsUsedLabelCount.Name = "ItemsUsedLabelCount"
        Me.ItemsUsedLabelCount.Size = New System.Drawing.Size(54, 60)
        Me.ItemsUsedLabelCount.TabIndex = 3
        Me.ItemsUsedLabelCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Items Used"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderRadius = 4
        Me.Guna2Panel6.Controls.Add(Me.ServCountLabel)
        Me.Guna2Panel6.Controls.Add(Me.Label13)
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(568, 88)
        Me.Guna2Panel6.TabIndex = 6
        '
        'ServCountLabel
        '
        Me.ServCountLabel.AutoSize = True
        Me.ServCountLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServCountLabel.ForeColor = System.Drawing.Color.Black
        Me.ServCountLabel.Location = New System.Drawing.Point(14, 24)
        Me.ServCountLabel.Name = "ServCountLabel"
        Me.ServCountLabel.Size = New System.Drawing.Size(54, 60)
        Me.ServCountLabel.TabIndex = 3
        Me.ServCountLabel.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Services"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1149, 93)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 4
        Me.Guna2Panel4.Controls.Add(Me.Label9)
        Me.Guna2Panel4.Controls.Add(Me.Label8)
        Me.Guna2Panel4.Controls.Add(Me.Label7)
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(737, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(48, 0, 0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(412, 92)
        Me.Guna2Panel4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(243, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "2024"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Friday"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "11:59:00 "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(242, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "September 28"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 4
        Me.Guna2Panel3.Controls.Add(Me.Label10)
        Me.Guna2Panel3.Controls.Add(Me.WelcomeMessageLabel)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(689, 92)
        Me.Guna2Panel3.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(20, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Technician"
        '
        'WelcomeMessageLabel
        '
        Me.WelcomeMessageLabel.AutoSize = True
        Me.WelcomeMessageLabel.BackColor = System.Drawing.Color.White
        Me.WelcomeMessageLabel.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.WelcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.WelcomeMessageLabel.Location = New System.Drawing.Point(18, 17)
        Me.WelcomeMessageLabel.Name = "WelcomeMessageLabel"
        Me.WelcomeMessageLabel.Size = New System.Drawing.Size(166, 26)
        Me.WelcomeMessageLabel.TabIndex = 15
        Me.WelcomeMessageLabel.Text = "Welcome, User"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.InvetoryAvailChart, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DeviceTypeChart, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ServStatusChart, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 249)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1149, 401)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'InvetoryAvailChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.InvetoryAvailChart.ChartAreas.Add(ChartArea1)
        Me.InvetoryAvailChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.InvetoryAvailChart.Legends.Add(Legend1)
        Me.InvetoryAvailChart.Location = New System.Drawing.Point(769, 3)
        Me.InvetoryAvailChart.Name = "InvetoryAvailChart"
        Me.InvetoryAvailChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.InvetoryAvailChart.Series.Add(Series1)
        Me.InvetoryAvailChart.Size = New System.Drawing.Size(377, 395)
        Me.InvetoryAvailChart.TabIndex = 2
        Me.InvetoryAvailChart.Text = "Chart2"
        '
        'DeviceTypeChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.DeviceTypeChart.ChartAreas.Add(ChartArea2)
        Me.DeviceTypeChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.DeviceTypeChart.Legends.Add(Legend2)
        Me.DeviceTypeChart.Location = New System.Drawing.Point(386, 3)
        Me.DeviceTypeChart.Name = "DeviceTypeChart"
        Me.DeviceTypeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.DeviceTypeChart.Series.Add(Series2)
        Me.DeviceTypeChart.Size = New System.Drawing.Size(377, 395)
        Me.DeviceTypeChart.TabIndex = 1
        Me.DeviceTypeChart.Text = "Chart2"
        '
        'ServStatusChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.ServStatusChart.ChartAreas.Add(ChartArea3)
        Me.ServStatusChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.ServStatusChart.Legends.Add(Legend3)
        Me.ServStatusChart.Location = New System.Drawing.Point(3, 3)
        Me.ServStatusChart.Name = "ServStatusChart"
        Me.ServStatusChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.ServStatusChart.Series.Add(Series3)
        Me.ServStatusChart.Size = New System.Drawing.Size(377, 395)
        Me.ServStatusChart.TabIndex = 0
        Me.ServStatusChart.Text = "Chart1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.Controls.Add(Me.Panel1)
        Me.Guna2Panel2.Controls.Add(Me.CalendarFrom)
        Me.Guna2Panel2.Controls.Add(Me.Panel6)
        Me.Guna2Panel2.Controls.Add(Me.CalendarTo)
        Me.Guna2Panel2.Controls.Add(Me.Panel3)
        Me.Guna2Panel2.Controls.Add(Me.FetchAllBtn)
        Me.Guna2Panel2.Controls.Add(Me.BtnReload)
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 218)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1149, 28)
        Me.Guna2Panel2.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(485, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(64, 28)
        Me.Panel1.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
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
        Me.CalendarFrom.Location = New System.Drawing.Point(549, 0)
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
        Me.Panel6.Location = New System.Drawing.Point(781, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(40, 28)
        Me.Panel6.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
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
        Me.CalendarTo.Location = New System.Drawing.Point(821, 0)
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
        Me.Panel3.Location = New System.Drawing.Point(1053, 0)
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
        Me.BtnReload.Location = New System.Drawing.Point(1063, 0)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.ShadowDecoration.Parent = Me.BtnReload
        Me.BtnReload.Size = New System.Drawing.Size(86, 28)
        Me.BtnReload.TabIndex = 44
        Me.BtnReload.Text = "Reload"
        '
        'TechnicianDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 681)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusTableLayout)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TechnicianDashboardForm"
        Me.Text = "Form2"
        Me.StatusTableLayout.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.InvetoryAvailChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeviceTypeChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServStatusChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusTableLayout As TableLayoutPanel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ServCountLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents WelcomeMessageLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DeviceTypeChart As DataVisualization.Charting.Chart
    Friend WithEvents ServStatusChart As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ItemsUsedLabelCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InvetoryAvailChart As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
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
