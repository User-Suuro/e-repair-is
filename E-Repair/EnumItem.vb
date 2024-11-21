Public Class EnumItem
    Public Property Name As String
    Public Property Value As Integer

    Public Sub New(name As String, value As Integer)
        Me.Name = name
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class