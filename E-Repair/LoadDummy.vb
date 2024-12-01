Public Class LoadDummy
    Dim constants As New Constants
    Dim dbUtils As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants
    Dim dbHelper As New DbHelper

    Dim resourcesPath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources")
    Dim dummyImagePath As String = System.IO.Path.Combine(resourcesPath, "landscape-placeholder-svgrepo-com.png")

    Public Function LoadDummyDataToEmployees(numberOfRecords As Integer) As Boolean
        Dim rnd As New Random()

        Dim jobTypes As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empJobPosStr)
        Dim adminPositions As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empAdminPosStr)
        Dim civilStatuses As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empCivilStr)
        Dim employmentStatuses As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empStatusStr)

        Try
            For i As Integer = 1 To numberOfRecords
                With empConst
                    Dim firstName = $"FirstName{i}"
                    Dim middleName = If(rnd.Next(0, 2) = 0, $"MiddleName{i}", Nothing) ' Optional field
                    Dim lastName = $"LastName{i}"
                    Dim sex = If(rnd.Next(0, 2) = 0, "Male", "Female")
                    Dim birthdate = New Date(1980, 1, 1).AddDays(rnd.Next(0, 15000)) ' Random birthdate
                    Dim civilStatus = civilStatuses(rnd.Next(0, civilStatuses.Count))
                    Dim address = $"Address {i}"
                    Dim contactNumber = $"091234567{i Mod 10}"
                    Dim employmentStatus = employmentStatuses(rnd.Next(0, employmentStatuses.Count))
                    Dim dateHired = DateTime.Now.AddDays(-rnd.Next(0, 3650)) ' Hired within the last 10 years
                    Dim sssNo = If(rnd.Next(0, 2) = 0, $"SSS-{1000000000 + i}", Nothing) ' Optional field
                    Dim pagibigNo = If(rnd.Next(0, 2) = 0, $"PAGIBIG-{2000000000 + i}", Nothing) ' Optional field
                    Dim tinNo = If(rnd.Next(0, 2) = 0, $"TIN-{3000000000 + i}", Nothing) ' Optional field
                    Dim profilePath = $"{dummyImagePath}"
                    Dim email = $"user{i}@example.com"
                    Dim password = $"password{i}", ' Assume passwords are pre-encrypted
                    Dim addedBy = $"{formUtils.getEmployeeName(Current.id)}"
                    Dim addedByID = rnd.Next(1, 100)
                    Dim dateAdded = DateTime.Now.AddDays(-rnd.Next(0, 365))
                    Dim lastAccessed = If(rnd.Next(0, 2) = 0, DateTime.Now.AddDays(-rnd.Next(0, 365)), Nothing)
                    Dim jobType = jobTypes(rnd.Next(0, jobTypes.Count))
                    Dim adminPosition = If(jobType = "Admin" OrElse jobType = "Super Admin", adminPositions(rnd.Next(0, adminPositions.Count)), Nothing)
                    Dim personnelDestination = If(jobType = "Technician", $"Destination {i}", Nothing)
                    Dim unavailable = rnd.Next(0, 2) ' 0 or 1

                    Dim insertData As New Dictionary(Of String, Object) From {
                      { .empSSSStr, sssNo},' Optional
                      { .empPagibigStr, pagibigNo}, ' Optional
                      { .empTINStr, tinNo},  ' Optional
                      { .empMidStr, middleName}, ' Optional
                      { .empFirstStr, firstName},
                      { .empLastStr, lastName},
                      { .empEmailStr, email},
                      { .empJobPosStr, jobType},
                      { .empPassStr, dbUtils.EncryptPassword(password, constants.EncryptionKey)},
                      { .empSexStr, sex},
                      { .empBirthStr, birthdate},
                      { .empCivilStr, civilStatus},
                      { .empAddrStr, address},
                      { .empContactStr, contactNumber},
                      { .empStatusStr, employmentStatus},
                      { .empHiredStr, dateHired}
                    }

                    If jobType = constants.getAdminString Then
                        ' Admin

                        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                            { .empAdminPosStr, adminPosition}
                        }

                        For Each kvp In updateAdminValues
                            insertData.Add(kvp.Key, kvp.Value)
                        Next

                    ElseIf jobType = constants.getUtilityPersonnelString Then

                        ' Utility
                        Dim updateUtilityValues As New Dictionary(Of String, Object) From {
                            { .empDestStr, personnelDestination}
                        }

                        For Each kvp In updateUtilityValues
                            insertData.Add(kvp.Key, kvp.Value)
                        Next

                    End If

                    dbHelper.InsertRecord(empConst.empTableStr, insertData)
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        MessageBox.Show($"{numberOfRecords} employee records generated successfully!")
        Return True
    End Function

    Public Function LoadDummyDataToCustomers(numberOfRecords As Integer) As Boolean
        For i As Integer = 1 To numberOfRecords
            ' Generate randomized or sequential data
            Dim middleName = If(i Mod 5 = 0, $"Middle{i}", Nothing) ' Optional field
            Dim contactNumber = If(i Mod 3 = 0, $"091234567{i Mod 10}", Nothing) ' Optional field
            Dim address = If(i Mod 4 = 0, $"Address {i}", Nothing) ' Optional field
            Dim email = If(i Mod 2 = 0, $"customer{i}@example.com", Nothing) ' Optional field
            Dim firstName = $"FirstName{i}"
            Dim lastName = $"LastName{i}"
            Dim gender = If(i Mod 2 = 0, "Male", "Female")
            Dim dateAdded = DateTime.Now.AddMinutes(-i)

            ' Create the insert data dictionary
            Dim insertData As New Dictionary(Of String, Object) From {
            {custConst.custMidStr, middleName},  ' Optional
            {custConst.custContactStr, contactNumber},  ' Optional
            {custConst.custAddressStr, address},  ' Optional
            {custConst.custEmailStr, email},  ' Optional
            {custConst.custFirstStr, firstName},
            {custConst.custLastStr, lastName},
            {custConst.custGenderStr, gender},
            {custConst.custDateAddedStr, dateAdded},
            {custConst.getAddedByName, formUtils.getEmployeeName(Current.id)},
            {custConst.getAddedByID, Current.id}
        }

            ' Insert the row into the database
            dbHelper.InsertRecord(custConst.custTableStr, insertData)
        Next

        MessageBox.Show($"{numberOfRecords} customer records generated successfully!")


        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToSuppliers(numberOfRecords As Integer) As Boolean


        ' ur code here



        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToServices(numberOfRecords As Integer) As Boolean


        ' ur code here



        Return True ' return true if successful
    End Function


    Public Function LoadDummyDataToInventory(numberOfRecords As Integer) As Boolean

        ' ur code here



        Return True ' return true if successful
    End Function

End Class
