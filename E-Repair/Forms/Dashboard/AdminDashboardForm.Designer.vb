<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardForm
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
        Me.StatusTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ItemsPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ItemsCountLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuppliersPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuppliersNumberLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmployeesPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.EmployeesCountLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CustomersPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.CustomersNumberLabel = New System.Windows.Forms.Label()
        Me.StatusCustomersLabel = New System.Windows.Forms.Label()
        Me.ServicesPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ServicesNumberLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SalesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.InventoryGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PositionsChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.StatusTableLayout.SuspendLayout()
        Me.ItemsPanel.SuspendLayout()
        Me.SuppliersPanel.SuspendLayout()
        Me.EmployeesPanel.SuspendLayout()
        Me.CustomersPanel.SuspendLayout()
        Me.ServicesPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(34, 22)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1113, 100)
        Me.TableLayoutPanel1.TabIndex = 3
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
        Me.Guna2Panel4.Location = New System.Drawing.Point(715, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(48, 0, 0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(398, 92)
        Me.Guna2Panel4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(236, 24)
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
        Me.Label6.Location = New System.Drawing.Point(235, 43)
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
        Me.Guna2Panel3.Size = New System.Drawing.Size(667, 92)
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
        Me.Label10.Size = New System.Drawing.Size(58, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Admin"
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
        'StatusTableLayout
        '
        Me.StatusTableLayout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusTableLayout.BackColor = System.Drawing.Color.Transparent
        Me.StatusTableLayout.ColumnCount = 5
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.StatusTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.StatusTableLayout.Controls.Add(Me.ItemsPanel, 4, 0)
        Me.StatusTableLayout.Controls.Add(Me.SuppliersPanel, 3, 0)
        Me.StatusTableLayout.Controls.Add(Me.EmployeesPanel, 0, 0)
        Me.StatusTableLayout.Controls.Add(Me.CustomersPanel, 2, 0)
        Me.StatusTableLayout.Controls.Add(Me.ServicesPanel, 1, 0)
        Me.StatusTableLayout.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusTableLayout.Location = New System.Drawing.Point(34, 137)
        Me.StatusTableLayout.Name = "StatusTableLayout"
        Me.StatusTableLayout.RowCount = 1
        Me.StatusTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.StatusTableLayout.Size = New System.Drawing.Size(1125, 97)
        Me.StatusTableLayout.TabIndex = 6
        '
        'ItemsPanel
        '
        Me.ItemsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ItemsPanel.BorderRadius = 4
        Me.ItemsPanel.Controls.Add(Me.ItemsCountLabel)
        Me.ItemsPanel.Controls.Add(Me.Label2)
        Me.ItemsPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ItemsPanel.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ItemsPanel.Location = New System.Drawing.Point(900, 0)
        Me.ItemsPanel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.ItemsPanel.Name = "ItemsPanel"
        Me.ItemsPanel.ShadowDecoration.Parent = Me.ItemsPanel
        Me.ItemsPanel.Size = New System.Drawing.Size(213, 85)
        Me.ItemsPanel.TabIndex = 8
        '
        'ItemsCountLabel
        '
        Me.ItemsCountLabel.AutoSize = True
        Me.ItemsCountLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsCountLabel.ForeColor = System.Drawing.Color.Black
        Me.ItemsCountLabel.Location = New System.Drawing.Point(16, 22)
        Me.ItemsCountLabel.Name = "ItemsCountLabel"
        Me.ItemsCountLabel.Size = New System.Drawing.Size(54, 60)
        Me.ItemsCountLabel.TabIndex = 3
        Me.ItemsCountLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inventory"
        '
        'SuppliersPanel
        '
        Me.SuppliersPanel.BackColor = System.Drawing.Color.Transparent
        Me.SuppliersPanel.BorderRadius = 4
        Me.SuppliersPanel.Controls.Add(Me.SuppliersNumberLabel)
        Me.SuppliersPanel.Controls.Add(Me.Label11)
        Me.SuppliersPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.SuppliersPanel.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.SuppliersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuppliersPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SuppliersPanel.Location = New System.Drawing.Point(675, 0)
        Me.SuppliersPanel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.SuppliersPanel.Name = "SuppliersPanel"
        Me.SuppliersPanel.ShadowDecoration.Parent = Me.SuppliersPanel
        Me.SuppliersPanel.Size = New System.Drawing.Size(213, 85)
        Me.SuppliersPanel.TabIndex = 7
        '
        'SuppliersNumberLabel
        '
        Me.SuppliersNumberLabel.AutoSize = True
        Me.SuppliersNumberLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.SuppliersNumberLabel.Location = New System.Drawing.Point(16, 22)
        Me.SuppliersNumberLabel.Name = "SuppliersNumberLabel"
        Me.SuppliersNumberLabel.Size = New System.Drawing.Size(54, 60)
        Me.SuppliersNumberLabel.TabIndex = 3
        Me.SuppliersNumberLabel.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(22, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Suppliers"
        '
        'EmployeesPanel
        '
        Me.EmployeesPanel.BackColor = System.Drawing.Color.Transparent
        Me.EmployeesPanel.BorderRadius = 4
        Me.EmployeesPanel.Controls.Add(Me.EmployeesCountLabel)
        Me.EmployeesPanel.Controls.Add(Me.Label13)
        Me.EmployeesPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.EmployeesPanel.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.EmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeesPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmployeesPanel.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.EmployeesPanel.Name = "EmployeesPanel"
        Me.EmployeesPanel.ShadowDecoration.Parent = Me.EmployeesPanel
        Me.EmployeesPanel.Size = New System.Drawing.Size(213, 85)
        Me.EmployeesPanel.TabIndex = 6
        '
        'EmployeesCountLabel
        '
        Me.EmployeesCountLabel.AutoSize = True
        Me.EmployeesCountLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesCountLabel.ForeColor = System.Drawing.Color.Black
        Me.EmployeesCountLabel.Location = New System.Drawing.Point(13, 22)
        Me.EmployeesCountLabel.Name = "EmployeesCountLabel"
        Me.EmployeesCountLabel.Size = New System.Drawing.Size(54, 60)
        Me.EmployeesCountLabel.TabIndex = 3
        Me.EmployeesCountLabel.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Employees"
        '
        'CustomersPanel
        '
        Me.CustomersPanel.BackColor = System.Drawing.Color.Transparent
        Me.CustomersPanel.BorderRadius = 4
        Me.CustomersPanel.Controls.Add(Me.CustomersNumberLabel)
        Me.CustomersPanel.Controls.Add(Me.StatusCustomersLabel)
        Me.CustomersPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.CustomersPanel.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomersPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustomersPanel.Location = New System.Drawing.Point(450, 0)
        Me.CustomersPanel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.CustomersPanel.Name = "CustomersPanel"
        Me.CustomersPanel.ShadowDecoration.Parent = Me.CustomersPanel
        Me.CustomersPanel.Size = New System.Drawing.Size(213, 85)
        Me.CustomersPanel.TabIndex = 5
        '
        'CustomersNumberLabel
        '
        Me.CustomersNumberLabel.AutoSize = True
        Me.CustomersNumberLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.CustomersNumberLabel.Location = New System.Drawing.Point(18, 22)
        Me.CustomersNumberLabel.Name = "CustomersNumberLabel"
        Me.CustomersNumberLabel.Size = New System.Drawing.Size(54, 60)
        Me.CustomersNumberLabel.TabIndex = 3
        Me.CustomersNumberLabel.Text = "0"
        '
        'StatusCustomersLabel
        '
        Me.StatusCustomersLabel.AutoSize = True
        Me.StatusCustomersLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusCustomersLabel.ForeColor = System.Drawing.Color.Black
        Me.StatusCustomersLabel.Location = New System.Drawing.Point(24, 4)
        Me.StatusCustomersLabel.Name = "StatusCustomersLabel"
        Me.StatusCustomersLabel.Size = New System.Drawing.Size(76, 20)
        Me.StatusCustomersLabel.TabIndex = 2
        Me.StatusCustomersLabel.Text = "Customers"
        '
        'ServicesPanel
        '
        Me.ServicesPanel.BackColor = System.Drawing.Color.Transparent
        Me.ServicesPanel.BorderRadius = 4
        Me.ServicesPanel.Controls.Add(Me.ServicesNumberLabel)
        Me.ServicesPanel.Controls.Add(Me.Label3)
        Me.ServicesPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ServicesPanel.CustomBorderThickness = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.ServicesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicesPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ServicesPanel.Location = New System.Drawing.Point(225, 0)
        Me.ServicesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.ServicesPanel.Name = "ServicesPanel"
        Me.ServicesPanel.ShadowDecoration.Parent = Me.ServicesPanel
        Me.ServicesPanel.Size = New System.Drawing.Size(213, 85)
        Me.ServicesPanel.TabIndex = 3
        '
        'ServicesNumberLabel
        '
        Me.ServicesNumberLabel.AutoSize = True
        Me.ServicesNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.ServicesNumberLabel.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.ServicesNumberLabel.Location = New System.Drawing.Point(20, 22)
        Me.ServicesNumberLabel.Name = "ServicesNumberLabel"
        Me.ServicesNumberLabel.Size = New System.Drawing.Size(54, 60)
        Me.ServicesNumberLabel.TabIndex = 3
        Me.ServicesNumberLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Services"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Chart4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SalesChart, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.InventoryGraph, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PositionsChart, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(34, 240)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1113, 417)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Chart4
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea1)
        Me.Chart4.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend1)
        Me.Chart4.Location = New System.Drawing.Point(559, 211)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart4.Series.Add(Series1)
        Me.Chart4.Size = New System.Drawing.Size(551, 203)
        Me.Chart4.TabIndex = 3
        Me.Chart4.Text = "Chart4"
        '
        'SalesChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.SalesChart.ChartAreas.Add(ChartArea2)
        Me.SalesChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.SalesChart.Legends.Add(Legend2)
        Me.SalesChart.Location = New System.Drawing.Point(3, 211)
        Me.SalesChart.Name = "SalesChart"
        Me.SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.SalesChart.Series.Add(Series2)
        Me.SalesChart.Size = New System.Drawing.Size(550, 203)
        Me.SalesChart.TabIndex = 2
        Me.SalesChart.Text = "SalesChart"
        '
        'InventoryGraph
        '
        ChartArea3.Name = "ChartArea1"
        Me.InventoryGraph.ChartAreas.Add(ChartArea3)
        Me.InventoryGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.InventoryGraph.Legends.Add(Legend3)
        Me.InventoryGraph.Location = New System.Drawing.Point(559, 3)
        Me.InventoryGraph.Name = "InventoryGraph"
        Me.InventoryGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.InventoryGraph.Series.Add(Series3)
        Me.InventoryGraph.Size = New System.Drawing.Size(551, 202)
        Me.InventoryGraph.TabIndex = 1
        Me.InventoryGraph.Text = "Chart2"
        '
        'PositionsChart
        '
        ChartArea4.Name = "ChartArea1"
        Me.PositionsChart.ChartAreas.Add(ChartArea4)
        Me.PositionsChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.PositionsChart.Legends.Add(Legend4)
        Me.PositionsChart.Location = New System.Drawing.Point(3, 3)
        Me.PositionsChart.Name = "PositionsChart"
        Me.PositionsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.PositionsChart.Series.Add(Series4)
        Me.PositionsChart.Size = New System.Drawing.Size(550, 202)
        Me.PositionsChart.TabIndex = 0
        Me.PositionsChart.Text = "Chart1"
        '
        'AdminDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 681)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusTableLayout)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboardForm"
        Me.Text = "AdminDashboardForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.StatusTableLayout.ResumeLayout(False)
        Me.ItemsPanel.ResumeLayout(False)
        Me.ItemsPanel.PerformLayout()
        Me.SuppliersPanel.ResumeLayout(False)
        Me.SuppliersPanel.PerformLayout()
        Me.EmployeesPanel.ResumeLayout(False)
        Me.EmployeesPanel.PerformLayout()
        Me.CustomersPanel.ResumeLayout(False)
        Me.CustomersPanel.PerformLayout()
        Me.ServicesPanel.ResumeLayout(False)
        Me.ServicesPanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusTableLayout As TableLayoutPanel
    Friend WithEvents ItemsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ItemsCountLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SuppliersPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SuppliersNumberLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents EmployeesPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents EmployeesCountLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CustomersPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CustomersNumberLabel As Label
    Friend WithEvents StatusCustomersLabel As Label
    Friend WithEvents ServicesPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ServicesNumberLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents WelcomeMessageLabel As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PositionsChart As DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents SalesChart As DataVisualization.Charting.Chart
    Friend WithEvents InventoryGraph As DataVisualization.Charting.Chart
End Class
