Public Class InventoryDBConstants
    ' Table Name
    Private ReadOnly _inventoryTable As String = "inventory"

    ' Attribute Names
    Private ReadOnly _inventoryID As String = "inventory_id"
    Private ReadOnly _supplierID As String = "supplier_id"
    Private ReadOnly _itemCategory As String = "item_category"

    Private ReadOnly _itemName As String = "item_name"
    Private ReadOnly _itemDescription As String = "item_description"
    Private ReadOnly _serialNumber As String = "serial_number"
    Private ReadOnly _hazardousClassification As String = "hazardous_classification"

    Private ReadOnly _quantity As String = "available_quantity"
    Private ReadOnly _costPerItem As String = "cost_per_item"

    Private ReadOnly _totalCost As String = "total_cost"
    Private ReadOnly _physicalLocation As String = "physical_location"
    Private ReadOnly _restockDate As String = "restock_date"
    Private ReadOnly _dateAdded As String = "date_added"

    Private ReadOnly _archived As String = "archived"
    Private ReadOnly _dateArchived As String = "date_archived"
    Private ReadOnly _archived_by_id As String = "archived_by_id"

    Private ReadOnly _addedById As String = "added_by_id"

    Public ReadOnly Property getArchivedByID As String
        Get
            Return _archived_by_id
        End Get
    End Property

    Public ReadOnly Property costPerItem As String
        Get
            Return _costPerItem
        End Get
    End Property

    Public ReadOnly Property availableQtyStr As String
        Get
            Return _quantity
        End Get
    End Property

    Public ReadOnly Property addedByIDStr As String
        Get
            Return _addedById
        End Get
    End Property

    ' Getters for each attribute name
    Public ReadOnly Property invTableStr As String
        Get
            Return _inventoryTable
        End Get
    End Property

    Public ReadOnly Property invIDStr As String
        Get
            Return _inventoryID
        End Get
    End Property

    Public ReadOnly Property supIDStr As String
        Get
            Return _supplierID
        End Get
    End Property

    Public ReadOnly Property itemCatStr As String
        Get
            Return _itemCategory
        End Get
    End Property

    Public ReadOnly Property itemNameStr As String
        Get
            Return _itemName
        End Get
    End Property

    Public ReadOnly Property itemDescStr As String
        Get
            Return _itemDescription
        End Get
    End Property

    Public ReadOnly Property serialNumStr As String
        Get
            Return _serialNumber
        End Get
    End Property

    Public ReadOnly Property hazClassStr As String
        Get
            Return _hazardousClassification
        End Get
    End Property



    Public ReadOnly Property totalCostStr As String
        Get
            Return _totalCost
        End Get
    End Property

    Public ReadOnly Property physLocStr As String
        Get
            Return _physicalLocation
        End Get
    End Property

    Public ReadOnly Property restockDateStr As String
        Get
            Return _restockDate
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

    Public ReadOnly Property dateArchivedStr As String
        Get
            Return _dateArchived
        End Get
    End Property
End Class
