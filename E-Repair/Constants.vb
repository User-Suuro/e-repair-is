Public Class Constants
    Private ReadOnly _dashboardTitle As String = "DASHBOARD"
    Private ReadOnly _servicesTitle As String = "SERVICES"
    Private ReadOnly _customersTitle As String = "CUSTOMERS"
    Private ReadOnly _employeesTitle As String = "EMPLOYEES"
    Private ReadOnly _suppliersTitle As String = "SUPPLIERS"
    Private ReadOnly _settingsTitle As String = "SETTINGS"
    Private ReadOnly _inventoryTitle As String = "INVENTORY"

    ' Role
    Private ReadOnly _adminString As String = "Admin"
    Private ReadOnly _cashierString As String = "Cashier"
    Private ReadOnly _utilityPersonnelString As String = "Utility Personnel"
    Private ReadOnly _technicianString As String = "Technician"
    Private ReadOnly _superAdminString As String = "Super Admin"

    ' Service Status
    Private ReadOnly _finishedString As String = "Finished"
    Private ReadOnly _claimedString As String = "Claimed"
    Private ReadOnly _canceledString As String = "Canceled"
    Private ReadOnly _onholdString As String = "Onhold"
    Private ReadOnly _pendingString As String = "Pending"

    ' Security
    Private ReadOnly _encryptionKey As String = "0123456789abcdef0123456789abcdef"

    ' Folder Names
    Private ReadOnly _employeesProfileFolderName = "Employee Profiles"
    Private ReadOnly _suppliersProfileFolderName = "Supplier Profiles"
    Private ReadOnly _devicePicturesFolderName = "Device Pictures"

    ' Date format
    Private ReadOnly _dateFormat As String = "MM/dd/yyyy"
    Private ReadOnly _monthsList As New List(Of String) From {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Private ReadOnly _yearsList As New List(Of Integer)(Enumerable.Range(DateTime.Now.Year - 5 + 1, 5).Reverse())

    Private ReadOnly _dataSetName As String = "DataSet1"
    Public ReadOnly Property getDataSetName As String
        Get
            Return _dataSetName
        End Get
    End Property


    Public ReadOnly Property getYearList As List(Of Integer)
        Get
            Return _yearsList
        End Get
    End Property

    Public ReadOnly Property getMonthList As List(Of String)
        Get
            Return _monthsList
        End Get
    End Property


    Public ReadOnly Property getDateFormat As String
        Get
            Return _dateFormat
        End Get
    End Property

    Public ReadOnly Property getClaimedString As String
        Get
            Return _claimedString
        End Get
    End Property

    Public ReadOnly Property getFinishedString As String
        Get
            Return _finishedString
        End Get
    End Property

    Public ReadOnly Property getOnholdString As String
        Get
            Return _onholdString
        End Get
    End Property

    Public ReadOnly Property getPendingString As String
        Get
            Return _pendingString
        End Get
    End Property
    Public ReadOnly Property getCanceledString As String
        Get
            Return _canceledString
        End Get
    End Property

    Public ReadOnly Property getSuperAdminString As String
        Get
            Return _superAdminString
        End Get
    End Property

    Public ReadOnly Property getDevicePicturesFolderName As String
        Get
            Return _devicePicturesFolderName
        End Get
    End Property

    Public ReadOnly Property getCustomerTitle As String
        Get
            Return _customersTitle
        End Get
    End Property


    Public ReadOnly Property getEmpProfileFolderName As String
        Get
            Return _employeesProfileFolderName
        End Get
    End Property

    Public ReadOnly Property getSuppProfileFolderName As String
        Get
            Return _suppliersProfileFolderName
        End Get
    End Property

    Public ReadOnly Property getAdminString As String
        Get
            Return _adminString
        End Get
    End Property

    Public ReadOnly Property getCashierString As String
        Get
            Return _cashierString
        End Get
    End Property

    Public ReadOnly Property getUtilityPersonnelString As String
        Get
            Return _utilityPersonnelString
        End Get
    End Property

    Public ReadOnly Property getTechnicianString As String
        Get
            Return _technicianString
        End Get
    End Property


    Public ReadOnly Property DashboardTitle As String
        Get
            Return _dashboardTitle
        End Get
    End Property

    Public ReadOnly Property ServicesTitle As String
        Get
            Return _servicesTitle
        End Get
    End Property

    Public ReadOnly Property EmployeesTitle As String
        Get
            Return _employeesTitle
        End Get
    End Property

    Public ReadOnly Property SuppliersTitle As String
        Get
            Return _suppliersTitle
        End Get
    End Property

    Public ReadOnly Property SettingsTitle As String
        Get
            Return _settingsTitle
        End Get
    End Property

    Public ReadOnly Property InventoryTitle As String
        Get
            Return _inventoryTitle
        End Get
    End Property

    Public ReadOnly Property EncryptionKey As String
        Get
            Return _encryptionKey
        End Get
    End Property
End Class