<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeReportModal
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmpRepDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EMPLOYEE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVIL_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYMENT_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_HIRED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSS_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGIBIG_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIN_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOB_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMIN_POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERSONNEL_DESTINATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMG_PATH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDED_BY_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_ACCESSED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ADDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ARCHIVED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.ExportToExcelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        CType(Me.EmpRepDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpRepDGV
        '
        Me.EmpRepDGV.AllowUserToAddRows = False
        Me.EmpRepDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EmpRepDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.EmpRepDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpRepDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpRepDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.EmpRepDGV.ColumnHeadersHeight = 48
        Me.EmpRepDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.EmpRepDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEE_ID, Me.FIRST_NAME, Me.MIDDLE_NAME, Me.LAST_NAME, Me.SEX, Me.BIRTHDATE, Me.CIVIL_STATUS, Me.ADDRESS, Me.CONTACT, Me.EMPLOYMENT_STATUS, Me.DATE_HIRED, Me.SSS_NUMBER, Me.PAGIBIG_NUMBER, Me.TIN_NUMBER, Me.JOB_TYPE, Me.ADMIN_POSITION, Me.PERSONNEL_DESTINATION, Me.IMG_PATH, Me.EMAIL, Me.PASSWORD, Me.ADDED_BY, Me.ADDED_BY_NAME, Me.ARCHIVED, Me.ARCHIVED_BY, Me.LAST_ACCESSED, Me.DATE_ADDED, Me.DATE_ARCHIVED})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmpRepDGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.EmpRepDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EmpRepDGV.Location = New System.Drawing.Point(22, 140)
        Me.EmpRepDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpRepDGV.Name = "EmpRepDGV"
        Me.EmpRepDGV.ReadOnly = True
        Me.EmpRepDGV.RowHeadersVisible = False
        Me.EmpRepDGV.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.EmpRepDGV.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.EmpRepDGV.Size = New System.Drawing.Size(1029, 438)
        Me.EmpRepDGV.TabIndex = 31
        Me.EmpRepDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.EmpRepDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.EmpRepDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EmpRepDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EmpRepDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EmpRepDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EmpRepDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.EmpRepDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.EmpRepDGV.ThemeStyle.HeaderStyle.Height = 48
        Me.EmpRepDGV.ThemeStyle.ReadOnly = True
        Me.EmpRepDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.EmpRepDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmpRepDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EmpRepDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.EmpRepDGV.ThemeStyle.RowsStyle.Height = 22
        Me.EmpRepDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.EmpRepDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'EMPLOYEE_ID
        '
        Me.EMPLOYEE_ID.DataPropertyName = "employee_id"
        Me.EMPLOYEE_ID.HeaderText = "ID"
        Me.EMPLOYEE_ID.MinimumWidth = 6
        Me.EMPLOYEE_ID.Name = "EMPLOYEE_ID"
        Me.EMPLOYEE_ID.ReadOnly = True
        Me.EMPLOYEE_ID.Visible = False
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.DataPropertyName = "firstname"
        Me.FIRST_NAME.HeaderText = "First Name"
        Me.FIRST_NAME.MinimumWidth = 6
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.ReadOnly = True
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.DataPropertyName = "middlename"
        Me.MIDDLE_NAME.HeaderText = "Middle Name"
        Me.MIDDLE_NAME.MinimumWidth = 6
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.ReadOnly = True
        '
        'LAST_NAME
        '
        Me.LAST_NAME.DataPropertyName = "lastname"
        Me.LAST_NAME.HeaderText = "Last Name"
        Me.LAST_NAME.MinimumWidth = 6
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.ReadOnly = True
        '
        'SEX
        '
        Me.SEX.DataPropertyName = "sex"
        Me.SEX.HeaderText = "Sex"
        Me.SEX.MinimumWidth = 6
        Me.SEX.Name = "SEX"
        Me.SEX.ReadOnly = True
        Me.SEX.Visible = False
        '
        'BIRTHDATE
        '
        Me.BIRTHDATE.DataPropertyName = "birthdate"
        Me.BIRTHDATE.HeaderText = "Birth Date"
        Me.BIRTHDATE.MinimumWidth = 6
        Me.BIRTHDATE.Name = "BIRTHDATE"
        Me.BIRTHDATE.ReadOnly = True
        Me.BIRTHDATE.Visible = False
        '
        'CIVIL_STATUS
        '
        Me.CIVIL_STATUS.DataPropertyName = "civilstatus"
        Me.CIVIL_STATUS.HeaderText = "Civil Status"
        Me.CIVIL_STATUS.MinimumWidth = 6
        Me.CIVIL_STATUS.Name = "CIVIL_STATUS"
        Me.CIVIL_STATUS.ReadOnly = True
        Me.CIVIL_STATUS.Visible = False
        '
        'ADDRESS
        '
        Me.ADDRESS.DataPropertyName = "address"
        Me.ADDRESS.HeaderText = "Address"
        Me.ADDRESS.MinimumWidth = 6
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        Me.ADDRESS.Visible = False
        '
        'CONTACT
        '
        Me.CONTACT.DataPropertyName = "contact_number"
        Me.CONTACT.HeaderText = "Contact Number"
        Me.CONTACT.MinimumWidth = 6
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.ReadOnly = True
        Me.CONTACT.Visible = False
        '
        'EMPLOYMENT_STATUS
        '
        Me.EMPLOYMENT_STATUS.DataPropertyName = "employment_status"
        Me.EMPLOYMENT_STATUS.HeaderText = "Employment Status"
        Me.EMPLOYMENT_STATUS.MinimumWidth = 6
        Me.EMPLOYMENT_STATUS.Name = "EMPLOYMENT_STATUS"
        Me.EMPLOYMENT_STATUS.ReadOnly = True
        Me.EMPLOYMENT_STATUS.Visible = False
        '
        'DATE_HIRED
        '
        Me.DATE_HIRED.DataPropertyName = "date_hired"
        Me.DATE_HIRED.HeaderText = "Date Hired"
        Me.DATE_HIRED.MinimumWidth = 6
        Me.DATE_HIRED.Name = "DATE_HIRED"
        Me.DATE_HIRED.ReadOnly = True
        '
        'SSS_NUMBER
        '
        Me.SSS_NUMBER.DataPropertyName = "sss_no"
        Me.SSS_NUMBER.HeaderText = "SSS"
        Me.SSS_NUMBER.MinimumWidth = 6
        Me.SSS_NUMBER.Name = "SSS_NUMBER"
        Me.SSS_NUMBER.ReadOnly = True
        Me.SSS_NUMBER.Visible = False
        '
        'PAGIBIG_NUMBER
        '
        Me.PAGIBIG_NUMBER.DataPropertyName = "pagibig_no"
        Me.PAGIBIG_NUMBER.HeaderText = "PAG-IBIG"
        Me.PAGIBIG_NUMBER.MinimumWidth = 6
        Me.PAGIBIG_NUMBER.Name = "PAGIBIG_NUMBER"
        Me.PAGIBIG_NUMBER.ReadOnly = True
        Me.PAGIBIG_NUMBER.Visible = False
        '
        'TIN_NUMBER
        '
        Me.TIN_NUMBER.DataPropertyName = "tin_no"
        Me.TIN_NUMBER.HeaderText = "TIN"
        Me.TIN_NUMBER.MinimumWidth = 6
        Me.TIN_NUMBER.Name = "TIN_NUMBER"
        Me.TIN_NUMBER.ReadOnly = True
        Me.TIN_NUMBER.Visible = False
        '
        'JOB_TYPE
        '
        Me.JOB_TYPE.DataPropertyName = "job_type"
        Me.JOB_TYPE.HeaderText = "Job Type"
        Me.JOB_TYPE.MinimumWidth = 6
        Me.JOB_TYPE.Name = "JOB_TYPE"
        Me.JOB_TYPE.ReadOnly = True
        '
        'ADMIN_POSITION
        '
        Me.ADMIN_POSITION.DataPropertyName = "admin_position"
        Me.ADMIN_POSITION.HeaderText = "Admin Position"
        Me.ADMIN_POSITION.MinimumWidth = 6
        Me.ADMIN_POSITION.Name = "ADMIN_POSITION"
        Me.ADMIN_POSITION.ReadOnly = True
        Me.ADMIN_POSITION.Visible = False
        '
        'PERSONNEL_DESTINATION
        '
        Me.PERSONNEL_DESTINATION.DataPropertyName = "personnel_destination"
        Me.PERSONNEL_DESTINATION.HeaderText = "Personnel Destination"
        Me.PERSONNEL_DESTINATION.MinimumWidth = 6
        Me.PERSONNEL_DESTINATION.Name = "PERSONNEL_DESTINATION"
        Me.PERSONNEL_DESTINATION.ReadOnly = True
        Me.PERSONNEL_DESTINATION.Visible = False
        '
        'IMG_PATH
        '
        Me.IMG_PATH.DataPropertyName = "profile_path"
        Me.IMG_PATH.HeaderText = "Image Path"
        Me.IMG_PATH.MinimumWidth = 6
        Me.IMG_PATH.Name = "IMG_PATH"
        Me.IMG_PATH.ReadOnly = True
        Me.IMG_PATH.Visible = False
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "email"
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.MinimumWidth = 6
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'PASSWORD
        '
        Me.PASSWORD.DataPropertyName = "password"
        Me.PASSWORD.HeaderText = "Password"
        Me.PASSWORD.MinimumWidth = 6
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.ReadOnly = True
        Me.PASSWORD.Visible = False
        '
        'ADDED_BY
        '
        Me.ADDED_BY.DataPropertyName = "added_by"
        Me.ADDED_BY.HeaderText = "Added By"
        Me.ADDED_BY.MinimumWidth = 6
        Me.ADDED_BY.Name = "ADDED_BY"
        Me.ADDED_BY.ReadOnly = True
        Me.ADDED_BY.Visible = False
        '
        'ADDED_BY_NAME
        '
        Me.ADDED_BY_NAME.HeaderText = "Added by"
        Me.ADDED_BY_NAME.MinimumWidth = 6
        Me.ADDED_BY_NAME.Name = "ADDED_BY_NAME"
        Me.ADDED_BY_NAME.ReadOnly = True
        Me.ADDED_BY_NAME.Visible = False
        '
        'ARCHIVED
        '
        Me.ARCHIVED.DataPropertyName = "archived"
        Me.ARCHIVED.HeaderText = "Archived"
        Me.ARCHIVED.MinimumWidth = 6
        Me.ARCHIVED.Name = "ARCHIVED"
        Me.ARCHIVED.ReadOnly = True
        Me.ARCHIVED.Visible = False
        '
        'ARCHIVED_BY
        '
        Me.ARCHIVED_BY.DataPropertyName = "archived_by"
        Me.ARCHIVED_BY.HeaderText = "Archived By"
        Me.ARCHIVED_BY.MinimumWidth = 6
        Me.ARCHIVED_BY.Name = "ARCHIVED_BY"
        Me.ARCHIVED_BY.ReadOnly = True
        Me.ARCHIVED_BY.Visible = False
        '
        'LAST_ACCESSED
        '
        Me.LAST_ACCESSED.DataPropertyName = "last_accessed"
        Me.LAST_ACCESSED.HeaderText = "Last Accessed"
        Me.LAST_ACCESSED.MinimumWidth = 6
        Me.LAST_ACCESSED.Name = "LAST_ACCESSED"
        Me.LAST_ACCESSED.ReadOnly = True
        '
        'DATE_ADDED
        '
        Me.DATE_ADDED.DataPropertyName = "date_added"
        Me.DATE_ADDED.HeaderText = "Date Added"
        Me.DATE_ADDED.MinimumWidth = 6
        Me.DATE_ADDED.Name = "DATE_ADDED"
        Me.DATE_ADDED.ReadOnly = True
        '
        'DATE_ARCHIVED
        '
        Me.DATE_ARCHIVED.DataPropertyName = "date_archived"
        Me.DATE_ARCHIVED.HeaderText = "Date Archived"
        Me.DATE_ARCHIVED.MinimumWidth = 6
        Me.DATE_ARCHIVED.Name = "DATE_ARCHIVED"
        Me.DATE_ARCHIVED.ReadOnly = True
        Me.DATE_ARCHIVED.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BorderRadius = 4
        Me.BtnClose.FillColor = System.Drawing.Color.DarkRed
        Me.BtnClose.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(30, 636)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(143, 39)
        Me.BtnClose.TabIndex = 40
        Me.BtnClose.Text = "Close"
        '
        'ExportToExcelBtn
        '
        Me.ExportToExcelBtn.BorderRadius = 4
        Me.ExportToExcelBtn.FillColor = System.Drawing.Color.DarkGreen
        Me.ExportToExcelBtn.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToExcelBtn.ForeColor = System.Drawing.Color.White
        Me.ExportToExcelBtn.Location = New System.Drawing.Point(879, 636)
        Me.ExportToExcelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportToExcelBtn.Name = "ExportToExcelBtn"
        Me.ExportToExcelBtn.Size = New System.Drawing.Size(143, 39)
        Me.ExportToExcelBtn.TabIndex = 41
        Me.ExportToExcelBtn.Text = "Export"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, -2)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1085, 42)
        Me.Guna2GroupBox1.TabIndex = 42
        Me.Guna2GroupBox1.Text = "Employee Report"
        '
        'EmployeeReportModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.ExportToExcelBtn)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.EmpRepDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeReportModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeReportModal"
        Me.TopMost = True
        CType(Me.EmpRepDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmpRepDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EMPLOYEE_ID As DataGridViewTextBoxColumn
    Friend WithEvents FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents LAST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents SEX As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents CIVIL_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT As DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYMENT_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents DATE_HIRED As DataGridViewTextBoxColumn
    Friend WithEvents SSS_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents PAGIBIG_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents TIN_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents JOB_TYPE As DataGridViewTextBoxColumn
    Friend WithEvents ADMIN_POSITION As DataGridViewTextBoxColumn
    Friend WithEvents PERSONNEL_DESTINATION As DataGridViewTextBoxColumn
    Friend WithEvents IMG_PATH As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY As DataGridViewTextBoxColumn
    Friend WithEvents ADDED_BY_NAME As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVED_BY As DataGridViewTextBoxColumn
    Friend WithEvents LAST_ACCESSED As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ADDED As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ARCHIVED As DataGridViewTextBoxColumn
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExportToExcelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
End Class
