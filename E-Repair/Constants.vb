Public Class Constants
    ' Styles
    Private ReadOnly _saffron As Color = ColorTranslator.FromHtml("#ECC642")
    Private ReadOnly _borderThickness As Integer = 1

    Private ReadOnly _dashboardTitle As String = "DASHBOARD"
    Private ReadOnly _servicesTitle As String = "SERVICES"
    Private ReadOnly _employeesTitle As String = "EMPLOYEES"
    Private ReadOnly _suppliersTitle As String = "SUPPLIERS"
    Private ReadOnly _settingsTitle As String = "SETTINGS"
    Private ReadOnly _inventoryTitle As String = "INVENTORY"

    ' Role
    Private ReadOnly _adminString As String = "Admin"
    Private ReadOnly _cashierString As String = "Cashier"
    Private ReadOnly _utilityPersonnelString As String = "Utility Personnel"
    Private ReadOnly _technicianString As String = "Technician"

    ' Security
    Private ReadOnly _encryptionKey As String = "0123456789abcdef0123456789abcdef"

    ' Paths
    Private ReadOnly _noImgPath As String = "C:\Users\User\source\repos\E-Repair\E-Repair\bin\Debug\Images\no-image.png"

    Public ReadOnly Property getNoImgPath As String
        Get
            Return _noImgPath
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


    ' Public properties (getters)
    Public ReadOnly Property Saffron As Color
        Get
            Return _saffron
        End Get
    End Property

    Public ReadOnly Property BorderThickness As Integer
        Get
            Return _borderThickness
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