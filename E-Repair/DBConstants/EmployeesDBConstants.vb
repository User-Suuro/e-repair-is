Public Class EmployeesDBConstants
    ' Table Name
    Private ReadOnly _employeeTable As String = "employees"

    ' Attribute Names
    Private ReadOnly _employeeID As String = "employee_id"
    Private ReadOnly _firstname As String = "firstname"
    Private ReadOnly _middlename As String = "middlename"
    Private ReadOnly _lastname As String = "lastname"
    Private ReadOnly _sex As String = "sex"
    Private ReadOnly _birthdate As String = "birthdate"
    Private ReadOnly _civilstatus As String = "civilstatus"
    Private ReadOnly _address As String = "address"
    Private ReadOnly _contactNumber As String = "contact_number"
    Private ReadOnly _employmentStatus As String = "employment_status"
    Private ReadOnly _dateHired As String = "date_hired"
    Private ReadOnly _sssNo As String = "sss_no"
    Private ReadOnly _pagibigNo As String = "pagibig_no"
    Private ReadOnly _tinNo As String = "tin_no"
    Private ReadOnly _jobType As String = "job_type"
    Private ReadOnly _adminPosition As String = "admin_position"

    Private ReadOnly _personnelDestination As String = "personnel_destination"
    Private ReadOnly _profilePath As String = "profile_path"
    Private ReadOnly _email As String = "email"
    Private ReadOnly _password As String = "password"
    Private ReadOnly _archived As String = "archived"
    Private ReadOnly _archivedBy As String = "archived_by"
    Private ReadOnly _lastAccessed As String = "last_accessed"
    Private ReadOnly _dateArchived As String = "date_archived"

    Private ReadOnly _dateAdded As String = "date_added"
    Private ReadOnly _addedByName As String = "added_by"
    Private ReadOnly _addedById As String = "added_by_id"

    Public ReadOnly Property addedById As String
        Get
            Return _addedById
        End Get
    End Property

    Public ReadOnly Property empAddedByName As String
        Get
            Return _addedByName
        End Get
    End Property


    Public ReadOnly Property empTableStr As String
        Get
            Return _employeeTable
        End Get
    End Property

    Public ReadOnly Property empIDStr As String
        Get
            Return _employeeID
        End Get
    End Property

    Public ReadOnly Property empFirstStr As String
        Get
            Return _firstname
        End Get
    End Property

    Public ReadOnly Property empMidStr As String
        Get
            Return _middlename
        End Get
    End Property

    Public ReadOnly Property empLastStr As String
        Get
            Return _lastname
        End Get
    End Property

    Public ReadOnly Property empSexStr As String
        Get
            Return _sex
        End Get
    End Property

    Public ReadOnly Property empBirthStr As String
        Get
            Return _birthdate
        End Get
    End Property

    Public ReadOnly Property empCivilStr As String
        Get
            Return _civilstatus
        End Get
    End Property

    Public ReadOnly Property empAddrStr As String
        Get
            Return _address
        End Get
    End Property

    Public ReadOnly Property empContactStr As String
        Get
            Return _contactNumber
        End Get
    End Property

    Public ReadOnly Property empStatusStr As String
        Get
            Return _employmentStatus
        End Get
    End Property

    Public ReadOnly Property empHiredStr As String
        Get
            Return _dateHired
        End Get
    End Property

    Public ReadOnly Property empSSSStr As String
        Get
            Return _sssNo
        End Get
    End Property

    Public ReadOnly Property empPagibigStr As String
        Get
            Return _pagibigNo
        End Get
    End Property

    Public ReadOnly Property empTINStr As String
        Get
            Return _tinNo
        End Get
    End Property

    Public ReadOnly Property empJobPosStr As String
        Get
            Return _jobType
        End Get
    End Property

    Public ReadOnly Property empAdminPosStr As String
        Get
            Return _adminPosition
        End Get
    End Property

    Public ReadOnly Property empDestStr As String
        Get
            Return _personnelDestination
        End Get
    End Property

    Public ReadOnly Property empProfileStr As String
        Get
            Return _profilePath
        End Get
    End Property

    Public ReadOnly Property empEmailStr As String
        Get
            Return _email
        End Get
    End Property

    Public ReadOnly Property empPassStr As String
        Get
            Return _password
        End Get
    End Property

    Public ReadOnly Property empArchStr As String
        Get
            Return _archived
        End Get
    End Property

    Public ReadOnly Property empArchByStr As String
        Get
            Return _archivedBy
        End Get
    End Property

    Public ReadOnly Property empLastAccessedStr As String
        Get
            Return _lastAccessed
        End Get
    End Property

    Public ReadOnly Property empArchDateStr As String
        Get
            Return _dateArchived
        End Get
    End Property



    Public ReadOnly Property empAddDateStr As String
        Get
            Return _dateAdded
        End Get
    End Property


End Class
