Module LoggedUser
    Dim empCust As New EmployeesDBConstants
    Dim formUtils As New FormUtils

    ' The Session class to hold the current user's data
    Public Class LoggedConstructor
        Public Property id As Integer
        Public Property name As String
        Public Property position As String
        Public Property email As String
        Public Property password As String
    End Class

    Public CurrentUsr As LoggedConstructor = Nothing

    Public Sub InitializeSession(dt As DataTable)

        If dt.Rows.Count = 0 Then
            MsgBox("Cannot Initialize Session With Empty Value")
            Exit Sub
        End If

        Dim empDtRow As DataRow = dt.Rows(0)

        Dim empID As Integer
        If Not Integer.TryParse(empCust.empIDStr, empID) Then
            MsgBox("Invalid Employee ID")
            Return
        End If

        CurrentUsr = New LoggedConstructor With {
            .id = empID,
            .name = formUtils.getEmployeeName(empCust.empIDStr),
            .position = empDtRow(empCust.empJobPosStr),
            .email = empDtRow(empCust.empEmailStr),
            .password = empDtRow(empCust.empPassStr)
        }

    End Sub

    Public Sub ClearSession()
        CurrentUsr = Nothing
    End Sub

    Public Function IsSessionActive() As Boolean
        Return CurrentUsr IsNot Nothing
    End Function
End Module