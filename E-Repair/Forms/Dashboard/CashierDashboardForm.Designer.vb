<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierDashboardForm
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CustCountLabel = New System.Windows.Forms.Label()
        Me.ServCountLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.StatusTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WelcomeMessageLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PaymentMethodChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DevTypeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GenderChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ServStatusChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DayStartCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MonthStartCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DayStopCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FetchAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.MonthEndCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.YearCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.StatusTableLayout.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PaymentMethodChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServStatusChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customers"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 4
        Me.Guna2Panel1.Controls.Add(Me.CustCountLabel)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(580, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(569, 85)
        Me.Guna2Panel1.TabIndex = 3
        '
        'CustCountLabel
        '
        Me.CustCountLabel.AutoSize = True
        Me.CustCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.CustCountLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustCountLabel.ForeColor = System.Drawing.Color.Black
        Me.CustCountLabel.Location = New System.Drawing.Point(20, 22)
        Me.CustCountLabel.Name = "CustCountLabel"
        Me.CustCountLabel.Size = New System.Drawing.Size(54, 60)
        Me.CustCountLabel.TabIndex = 3
        Me.CustCountLabel.Text = "0"
        '
        'ServCountLabel
        '
        Me.ServCountLabel.AutoSize = True
        Me.ServCountLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServCountLabel.ForeColor = System.Drawing.Color.Black
        Me.ServCountLabel.Location = New System.Drawing.Point(14, 22)
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
        Me.Label13.Size = New System.Drawing.Size(55, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Service"
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
        Me.Guna2Panel6.Size = New System.Drawing.Size(568, 85)
        Me.Guna2Panel6.TabIndex = 6
        '
        'StatusTableLayout
        '
        Me.StatusTableLayout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusTableLayout.BackColor = System.Drawing.Color.Transparent
        Me.StatusTableLayout.ColumnCount = 2
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.StatusTableLayout.Controls.Add(Me.Guna2Panel6, 0, 0)
        Me.StatusTableLayout.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.StatusTableLayout.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusTableLayout.Location = New System.Drawing.Point(18, 117)
        Me.StatusTableLayout.Name = "StatusTableLayout"
        Me.StatusTableLayout.RowCount = 1
        Me.StatusTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.StatusTableLayout.Size = New System.Drawing.Size(1161, 97)
        Me.StatusTableLayout.TabIndex = 8
        '
        'Timer4
        '
        '
        'Timer3
        '
        '
        'Timer2
        '
        '
        'Timer1
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(20, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cashier"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 19)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1149, 92)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PaymentMethodChart, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DevTypeChart, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GenderChart, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ServStatusChart, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(18, 248)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1149, 408)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'PaymentMethodChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.PaymentMethodChart.ChartAreas.Add(ChartArea1)
        Me.PaymentMethodChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.PaymentMethodChart.Legends.Add(Legend1)
        Me.PaymentMethodChart.Location = New System.Drawing.Point(577, 207)
        Me.PaymentMethodChart.Name = "PaymentMethodChart"
        Me.PaymentMethodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.PaymentMethodChart.Series.Add(Series1)
        Me.PaymentMethodChart.Size = New System.Drawing.Size(569, 198)
        Me.PaymentMethodChart.TabIndex = 3
        Me.PaymentMethodChart.Text = "Chart4"
        '
        'DevTypeChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.DevTypeChart.ChartAreas.Add(ChartArea2)
        Me.DevTypeChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.DevTypeChart.Legends.Add(Legend2)
        Me.DevTypeChart.Location = New System.Drawing.Point(3, 207)
        Me.DevTypeChart.Name = "DevTypeChart"
        Me.DevTypeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.DevTypeChart.Series.Add(Series2)
        Me.DevTypeChart.Size = New System.Drawing.Size(568, 198)
        Me.DevTypeChart.TabIndex = 2
        Me.DevTypeChart.Text = "Chart3"
        '
        'GenderChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.GenderChart.ChartAreas.Add(ChartArea3)
        Me.GenderChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.GenderChart.Legends.Add(Legend3)
        Me.GenderChart.Location = New System.Drawing.Point(577, 3)
        Me.GenderChart.Name = "GenderChart"
        Me.GenderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.GenderChart.Series.Add(Series3)
        Me.GenderChart.Size = New System.Drawing.Size(569, 198)
        Me.GenderChart.TabIndex = 1
        Me.GenderChart.Text = "Chart2"
        '
        'ServStatusChart
        '
        ChartArea4.Name = "ChartArea1"
        Me.ServStatusChart.ChartAreas.Add(ChartArea4)
        Me.ServStatusChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.ServStatusChart.Legends.Add(Legend4)
        Me.ServStatusChart.Location = New System.Drawing.Point(3, 3)
        Me.ServStatusChart.Name = "ServStatusChart"
        Me.ServStatusChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.ServStatusChart.Series.Add(Series4)
        Me.ServStatusChart.Size = New System.Drawing.Size(568, 198)
        Me.ServStatusChart.TabIndex = 0
        Me.ServStatusChart.Text = "Chart1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.Controls.Add(Me.DayStartCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel3)
        Me.Guna2Panel2.Controls.Add(Me.MonthStartCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel6)
        Me.Guna2Panel2.Controls.Add(Me.DayStopCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel4)
        Me.Guna2Panel2.Controls.Add(Me.FetchAllBtn)
        Me.Guna2Panel2.Controls.Add(Me.MonthEndCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel2)
        Me.Guna2Panel2.Controls.Add(Me.YearCmb)
        Me.Guna2Panel2.Controls.Add(Me.Panel1)
        Me.Guna2Panel2.Controls.Add(Me.BtnReload)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 217)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1149, 28)
        Me.Guna2Panel2.TabIndex = 34
        '
        'DayStartCmb
        '
        Me.DayStartCmb.Animated = True
        Me.DayStartCmb.BackColor = System.Drawing.Color.Transparent
        Me.DayStartCmb.BorderRadius = 4
        Me.DayStartCmb.DisplayMember = "(none)"
        Me.DayStartCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.DayStartCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DayStartCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DayStartCmb.FocusedColor = System.Drawing.Color.Empty
        Me.DayStartCmb.FocusedState.Parent = Me.DayStartCmb
        Me.DayStartCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DayStartCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DayStartCmb.FormattingEnabled = True
        Me.DayStartCmb.HoverState.Parent = Me.DayStartCmb
        Me.DayStartCmb.ItemHeight = 22
        Me.DayStartCmb.ItemsAppearance.Parent = Me.DayStartCmb
        Me.DayStartCmb.Location = New System.Drawing.Point(437, 0)
        Me.DayStartCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.DayStartCmb.Name = "DayStartCmb"
        Me.DayStartCmb.ShadowDecoration.Parent = Me.DayStartCmb
        Me.DayStartCmb.Size = New System.Drawing.Size(87, 28)
        Me.DayStartCmb.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(524, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 28)
        Me.Panel3.TabIndex = 75
        '
        'MonthStartCmb
        '
        Me.MonthStartCmb.Animated = True
        Me.MonthStartCmb.BackColor = System.Drawing.Color.Transparent
        Me.MonthStartCmb.BorderRadius = 4
        Me.MonthStartCmb.DisplayMember = "(none)"
        Me.MonthStartCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.MonthStartCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MonthStartCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthStartCmb.FocusedColor = System.Drawing.Color.Empty
        Me.MonthStartCmb.FocusedState.Parent = Me.MonthStartCmb
        Me.MonthStartCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MonthStartCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.MonthStartCmb.FormattingEnabled = True
        Me.MonthStartCmb.HoverState.Parent = Me.MonthStartCmb
        Me.MonthStartCmb.ItemHeight = 22
        Me.MonthStartCmb.ItemsAppearance.Parent = Me.MonthStartCmb
        Me.MonthStartCmb.Location = New System.Drawing.Point(534, 0)
        Me.MonthStartCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.MonthStartCmb.Name = "MonthStartCmb"
        Me.MonthStartCmb.ShadowDecoration.Parent = Me.MonthStartCmb
        Me.MonthStartCmb.Size = New System.Drawing.Size(127, 28)
        Me.MonthStartCmb.TabIndex = 74
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(661, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(40, 28)
        Me.Panel6.TabIndex = 73
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
        'DayStopCmb
        '
        Me.DayStopCmb.Animated = True
        Me.DayStopCmb.BackColor = System.Drawing.Color.Transparent
        Me.DayStopCmb.BorderRadius = 4
        Me.DayStopCmb.DisplayMember = "(none)"
        Me.DayStopCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.DayStopCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DayStopCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DayStopCmb.FocusedColor = System.Drawing.Color.Empty
        Me.DayStopCmb.FocusedState.Parent = Me.DayStopCmb
        Me.DayStopCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DayStopCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DayStopCmb.FormattingEnabled = True
        Me.DayStopCmb.HoverState.Parent = Me.DayStopCmb
        Me.DayStopCmb.ItemHeight = 22
        Me.DayStopCmb.ItemsAppearance.Parent = Me.DayStopCmb
        Me.DayStopCmb.Location = New System.Drawing.Point(701, 0)
        Me.DayStopCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.DayStopCmb.Name = "DayStopCmb"
        Me.DayStopCmb.ShadowDecoration.Parent = Me.DayStopCmb
        Me.DayStopCmb.Size = New System.Drawing.Size(87, 28)
        Me.DayStopCmb.TabIndex = 72
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(788, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 28)
        Me.Panel4.TabIndex = 71
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
        'MonthEndCmb
        '
        Me.MonthEndCmb.Animated = True
        Me.MonthEndCmb.BackColor = System.Drawing.Color.Transparent
        Me.MonthEndCmb.BorderRadius = 4
        Me.MonthEndCmb.DisplayMember = "(none)"
        Me.MonthEndCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.MonthEndCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MonthEndCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthEndCmb.FocusedColor = System.Drawing.Color.Empty
        Me.MonthEndCmb.FocusedState.Parent = Me.MonthEndCmb
        Me.MonthEndCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MonthEndCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.MonthEndCmb.FormattingEnabled = True
        Me.MonthEndCmb.HoverState.Parent = Me.MonthEndCmb
        Me.MonthEndCmb.ItemHeight = 22
        Me.MonthEndCmb.ItemsAppearance.Parent = Me.MonthEndCmb
        Me.MonthEndCmb.Location = New System.Drawing.Point(798, 0)
        Me.MonthEndCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.MonthEndCmb.Name = "MonthEndCmb"
        Me.MonthEndCmb.ShadowDecoration.Parent = Me.MonthEndCmb
        Me.MonthEndCmb.Size = New System.Drawing.Size(127, 28)
        Me.MonthEndCmb.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(925, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 28)
        Me.Panel2.TabIndex = 47
        '
        'YearCmb
        '
        Me.YearCmb.Animated = True
        Me.YearCmb.BackColor = System.Drawing.Color.Transparent
        Me.YearCmb.BorderRadius = 4
        Me.YearCmb.DisplayMember = "(none)"
        Me.YearCmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.YearCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.YearCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearCmb.FocusedColor = System.Drawing.Color.Empty
        Me.YearCmb.FocusedState.Parent = Me.YearCmb
        Me.YearCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.YearCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.YearCmb.FormattingEnabled = True
        Me.YearCmb.HoverState.Parent = Me.YearCmb
        Me.YearCmb.ItemHeight = 22
        Me.YearCmb.ItemsAppearance.Parent = Me.YearCmb
        Me.YearCmb.Location = New System.Drawing.Point(935, 0)
        Me.YearCmb.Margin = New System.Windows.Forms.Padding(12)
        Me.YearCmb.Name = "YearCmb"
        Me.YearCmb.ShadowDecoration.Parent = Me.YearCmb
        Me.YearCmb.Size = New System.Drawing.Size(118, 28)
        Me.YearCmb.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1053, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 28)
        Me.Panel1.TabIndex = 45
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
        'CashierDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 681)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusTableLayout)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CashierDashboardForm"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.StatusTableLayout.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PaymentMethodChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServStatusChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CustCountLabel As Label
    Friend WithEvents ServCountLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StatusTableLayout As TableLayoutPanel
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents WelcomeMessageLabel As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PaymentMethodChart As DataVisualization.Charting.Chart
    Friend WithEvents DevTypeChart As DataVisualization.Charting.Chart
    Friend WithEvents GenderChart As DataVisualization.Charting.Chart
    Friend WithEvents ServStatusChart As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DayStartCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MonthStartCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DayStopCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FetchAllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MonthEndCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents YearCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnReload As Guna.UI2.WinForms.Guna2Button
End Class
