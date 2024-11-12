Module GlobalSession

    ' The Session class to hold the current user's data
    Public Class Session
        Public Property EmployeeID As Integer
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property LastName As String
        Public Property JobType As String
        Public Property Sex As String
        Public Property Birthdate As Date
        Public Property CivilStatus As String
        Public Property Address As String
        Public Property ContactNumber As String
        Public Property EmploymentStatus As String
        Public Property DateHired As Date
        Public Property SSSNo As String
        Public Property PagibigNo As String
        Public Property TinNo As String
        Public Property ProfilePath As String
    End Class

    Public CurrentSession As Session = Nothing

    Public Sub InitializeSession(empDataRow As DataRow)
        Try
            CurrentSession = New Session With {
            .EmployeeID = empDataRow("employee_id"),
            .FirstName = empDataRow("firstname").ToString(),
            .MiddleName = empDataRow("middlename").ToString(),
            .LastName = empDataRow("lastname").ToString(),
            .JobType = empDataRow("job_type").ToString(),
            .Sex = empDataRow("sex").ToString(),
            .Birthdate = Convert.ToDateTime(empDataRow("birthdate")),
            .CivilStatus = empDataRow("civilstatus").ToString(),
            .Address = empDataRow("address").ToString(),
            .ContactNumber = empDataRow("contact_number").ToString(),
            .EmploymentStatus = empDataRow("employment_status").ToString(),
            .DateHired = Convert.ToDateTime(empDataRow("date_hired")),
            .SSSNo = empDataRow("sss_no").ToString(),
            .PagibigNo = empDataRow("pagibig_no").ToString(),
            .TinNo = empDataRow("tin_no").ToString(),
            .ProfilePath = empDataRow("profile_path").ToString()
        }

        Catch ex As Exception
            MsgBox("Unable to Start Session: " + ex.Message)
        End Try
    End Sub

    Public Sub ClearSession()
        CurrentSession = Nothing
    End Sub

    Public Function IsSessionActive() As Boolean
        Return CurrentSession IsNot Nothing
    End Function

End Module