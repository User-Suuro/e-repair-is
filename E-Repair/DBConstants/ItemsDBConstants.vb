Public Class ItemsDBConstants
    ' Define constants for column names in the items table
    Private ReadOnly _tableName As String = "items"
    Private ReadOnly _itemId As String = "item_id"
    Private ReadOnly _inventoryId As String = "inventory_id"
    Private ReadOnly _serviceId As String = "service_id"


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

End Class
