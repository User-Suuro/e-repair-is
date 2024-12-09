Public Class CustomersDBConstants
    ' Table Name
    Private ReadOnly _customerTable As String = "customers"

    ' Attribute Names
    Private ReadOnly _customerID As String = "customer_id"

    Private ReadOnly _firstName As String = "first_name"
    Private ReadOnly _lastName As String = "last_name"
    Private ReadOnly _middleName As String = "middle_name"

    Private ReadOnly _contactNumber As String = "contact_number"
    Private ReadOnly _address As String = "address"
    Private ReadOnly _gender As String = "gender"
    Private ReadOnly _email As String = "email"
    Private ReadOnly _totalPaid As String = "total_paid"
    Private ReadOnly _lastTransaction As String = "last_transaction"

    Private ReadOnly _dateAdded As String = "date_added"

    Private ReadOnly _archived As String = "archived"
    Private ReadOnly _dateArchived As String = "date_archived"
    Private ReadOnly _archivedBy As String = "archived_by_id"
    Private ReadOnly _addedByID As String = "added_by_id"


    Public ReadOnly Property getAddedByID As String
        Get
            Return _addedByID
        End Get
    End Property


    ' Getters for each attribute name
    Public ReadOnly Property custTableStr As String
        Get
            Return _customerTable
        End Get
    End Property

    Public ReadOnly Property custIDStr As String
        Get
            Return _customerID
        End Get
    End Property

    Public ReadOnly Property custFirstStr As String
        Get
            Return _firstName
        End Get
    End Property

    Public ReadOnly Property custLastStr As String
        Get
            Return _lastName
        End Get
    End Property

    Public ReadOnly Property custMidStr As String
        Get
            Return _middleName
        End Get
    End Property

    Public ReadOnly Property custContactStr As String
        Get
            Return _contactNumber
        End Get
    End Property

    Public ReadOnly Property custAddressStr As String
        Get
            Return _address
        End Get
    End Property

    Public ReadOnly Property custGenderStr As String
        Get
            Return _gender
        End Get
    End Property

    Public ReadOnly Property custEmailStr As String
        Get
            Return _email
        End Get
    End Property

    Public ReadOnly Property custTotalPaidStr As String
        Get
            Return _totalPaid
        End Get
    End Property

    Public ReadOnly Property custLastTransStr As String
        Get
            Return _lastTransaction
        End Get
    End Property

    Public ReadOnly Property custArchStr As String
        Get
            Return _archived
        End Get
    End Property

    Public ReadOnly Property custArchByIDStr As String
        Get
            Return _archivedBy
        End Get
    End Property

    Public ReadOnly Property custArchDateStr As String
        Get
            Return _dateArchived
        End Get
    End Property



    Public ReadOnly Property custDateAddedStr As String
        Get
            Return _dateAdded
        End Get
    End Property
End Class
