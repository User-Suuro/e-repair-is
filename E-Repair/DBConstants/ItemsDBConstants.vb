Public Class ItemsDBConstants
    ' Define constants for column names in the items table
    Private ReadOnly _tableName As String = "used_items"
    Private ReadOnly _itemId As String = "item_id"
    Private ReadOnly _inventoryId As String = "inventory_id"
    Private ReadOnly _serviceId As String = "service_id"
    Private ReadOnly _costperitem As String = "cost"
    Private ReadOnly _itemstatus As String = "used"
    Private ReadOnly _quantityUsed As String = "quantity_used"
    Private ReadOnly _reasonUsed As String = "reason_used"
    Private ReadOnly _dateUsed As String = "dateUsed"

    Public ReadOnly Property reasonUsed As String
        Get
            Return _reasonUsed
        End Get
    End Property

    Public ReadOnly Property dateUsedCol As String
        Get
            Return _dateUsed
        End Get
    End Property

    Public ReadOnly Property quantityUsedStr As String
        Get
            Return _quantityUsed
        End Get
    End Property

    ' Getter for table name
    Public ReadOnly Property TableName As String
        Get
            Return _tableName
        End Get
    End Property

    ' Getter for ItemId column name
    Public ReadOnly Property ItemId As String
        Get
            Return _itemId
        End Get
    End Property

    ' Getter for InventoryId column name
    Public ReadOnly Property InventoryId As String
        Get
            Return _inventoryId
        End Get
    End Property

    ' Getter for ServiceId column name
    Public ReadOnly Property ServiceId As String
        Get
            Return _serviceId
        End Get
    End Property

    Public ReadOnly Property costPerItem As String
        Get
            Return _costperitem
        End Get
    End Property
    Public ReadOnly Property isUsed As String
        Get
            Return _itemstatus
        End Get
    End Property


End Class
