Public Class ServiceDBConstants
    ' Table Name
    Private ReadOnly _serviceTable As String = "services"

    ' Attribute Names
    Private ReadOnly _serviceID As String = "service_id"
    Private ReadOnly _customerID As String = "customer_id"
    Private ReadOnly _technicianID As String = "technician_id"
    Private ReadOnly _cashierID As String = "cashier_id"
    Private ReadOnly _deviceType As String = "device_type"
    Private ReadOnly _deviceModel As String = "device_model"
    Private ReadOnly _deviceBrand As String = "device_brand"
    Private ReadOnly _deviceProfilePath As String = "device_profile_path"
    Private ReadOnly _operatingSystem As String = "operating_system"
    Private ReadOnly _storageCapacity As String = "storage_capacity"
    Private ReadOnly _problemDescription As String = "problem_description"
    Private ReadOnly _repairNotes As String = "repair_notes"
    Private ReadOnly _serviceStatus As String = "service_status"
    Private ReadOnly _technicianFee As String = "technician_fee"
    Private ReadOnly _partsCost As String = "parts_cost"
    Private ReadOnly _paid As String = "paid"
    Private ReadOnly _totalPaid As String = "total_paid"
    Private ReadOnly _customerChange As String = "customer_change"
    Private ReadOnly _paymentMethod As String = "payment_method"
    Private ReadOnly _dateCompleted As String = "date_completed"
    Private ReadOnly _dateClaimed As String = "date_claimed"
    Private ReadOnly _dateAdded As String = "date_added"
    Private ReadOnly _archived As String = "archived"
    Private ReadOnly _archivedBy As String = "archived_by"
    Private ReadOnly _dateArchived As String = "date_archived"

    ' Getters for each attribute name
    Public ReadOnly Property svcTableStr As String
        Get
            Return _serviceTable
        End Get
    End Property

    Public ReadOnly Property svcIDStr As String
        Get
            Return _serviceID
        End Get
    End Property

    Public ReadOnly Property custIDStr As String
        Get
            Return _customerID
        End Get
    End Property

    Public ReadOnly Property techIDStr As String
        Get
            Return _technicianID
        End Get
    End Property

    Public ReadOnly Property cashierIDStr As String
        Get
            Return _cashierID
        End Get
    End Property

    Public ReadOnly Property devTypeStr As String
        Get
            Return _deviceType
        End Get
    End Property

    Public ReadOnly Property devModelStr As String
        Get
            Return _deviceModel
        End Get
    End Property

    Public ReadOnly Property devBrandStr As String
        Get
            Return _deviceBrand
        End Get
    End Property

    Public ReadOnly Property devProfilePathStr As String
        Get
            Return _deviceProfilePath
        End Get
    End Property

    Public ReadOnly Property osStr As String
        Get
            Return _operatingSystem
        End Get
    End Property

    Public ReadOnly Property storageCapStr As String
        Get
            Return _storageCapacity
        End Get
    End Property

    Public ReadOnly Property probDescStr As String
        Get
            Return _problemDescription
        End Get
    End Property

    Public ReadOnly Property repairNotesStr As String
        Get
            Return _repairNotes
        End Get
    End Property

    Public ReadOnly Property svcStatusStr As String
        Get
            Return _serviceStatus
        End Get
    End Property

    Public ReadOnly Property techFeeStr As String
        Get
            Return _technicianFee
        End Get
    End Property

    Public ReadOnly Property partsCostStr As String
        Get
            Return _partsCost
        End Get
    End Property

    Public ReadOnly Property paidStr As String
        Get
            Return _paid
        End Get
    End Property

    Public ReadOnly Property totalPaidStr As String
        Get
            Return _totalPaid
        End Get
    End Property

    Public ReadOnly Property custChangeStr As String
        Get
            Return _customerChange
        End Get
    End Property

    Public ReadOnly Property payMethodStr As String
        Get
            Return _paymentMethod
        End Get
    End Property

    Public ReadOnly Property dateCompletedStr As String
        Get
            Return _dateCompleted
        End Get
    End Property

    Public ReadOnly Property dateClaimedStr As String
        Get
            Return _dateClaimed
        End Get
    End Property

    Public ReadOnly Property dateAddedStr As String
        Get
            Return _dateAdded
        End Get
    End Property

    Public ReadOnly Property archivedStr As String
        Get
            Return _archived
        End Get
    End Property

    Public ReadOnly Property archByStr As String
        Get
            Return _archivedBy
        End Get
    End Property

    Public ReadOnly Property dateArchivedStr As String
        Get
            Return _dateArchived
        End Get
    End Property

End Class
