Public Class SuppliersDBConstants
    ' Table Name
    Private ReadOnly _supplierTable As String = "suppliers"

    ' Attribute Names
    Private ReadOnly _supplierID As String = "supplier_id"
    Private ReadOnly _companyName As String = "company_name"
    Private ReadOnly _companyDescription As String = "company_description"
    Private ReadOnly _contactPerson As String = "contact_person"
    Private ReadOnly _contactNumber As String = "contact_number"
    Private ReadOnly _companyEmail As String = "company_email"
    Private ReadOnly _location As String = "location"
    Private ReadOnly _supplierType As String = "supplier_type"
    Private ReadOnly _supplierContract As String = "supplier_contract"
    Private ReadOnly _bankDetails As String = "bank_details"
    Private ReadOnly _paymentTerms As String = "payment_terms"
    Private ReadOnly _estimatedDeliveryTime As String = "estimated_delivery_time"
    Private ReadOnly _totalPaid As String = "total_paid"
    Private ReadOnly _companyPicturePath As String = "company_picture_path"
    Private ReadOnly _dateAdded As String = "date_added"
    Private ReadOnly _addedBy As String = "added_by"
    Private ReadOnly _archived As String = "archived"
    Private ReadOnly _archivedBy As String = "archived_by"
    Private ReadOnly _dateArchived As String = "date_archived"

    ' Getters for each attribute name
    Public ReadOnly Property supTableStr As String
        Get
            Return _supplierTable
        End Get
    End Property

    Public ReadOnly Property supIDStr As String
        Get
            Return _supplierID
        End Get
    End Property

    Public ReadOnly Property compNameStr As String
        Get
            Return _companyName
        End Get
    End Property

    Public ReadOnly Property compDescStr As String
        Get
            Return _companyDescription
        End Get
    End Property

    Public ReadOnly Property contactPersonStr As String
        Get
            Return _contactPerson
        End Get
    End Property

    Public ReadOnly Property contactNumStr As String
        Get
            Return _contactNumber
        End Get
    End Property

    Public ReadOnly Property compEmailStr As String
        Get
            Return _companyEmail
        End Get
    End Property

    Public ReadOnly Property locationStr As String
        Get
            Return _location
        End Get
    End Property

    Public ReadOnly Property supTypeStr As String
        Get
            Return _supplierType
        End Get
    End Property

    Public ReadOnly Property supContractStr As String
        Get
            Return _supplierContract
        End Get
    End Property

    Public ReadOnly Property bankDetailsStr As String
        Get
            Return _bankDetails
        End Get
    End Property

    Public ReadOnly Property payTermsStr As String
        Get
            Return _paymentTerms
        End Get
    End Property

    Public ReadOnly Property estDeliveryStr As String
        Get
            Return _estimatedDeliveryTime
        End Get
    End Property

    Public ReadOnly Property totalPaidStr As String
        Get
            Return _totalPaid
        End Get
    End Property

    Public ReadOnly Property compPicPathStr As String
        Get
            Return _companyPicturePath
        End Get
    End Property

    Public ReadOnly Property dateAddedStr As String
        Get
            Return _dateAdded
        End Get
    End Property

    Public ReadOnly Property addedByStr As String
        Get
            Return _addedBy
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
