Public Class LoadDummy
    Dim constants As New Constants
    Dim dbUtils As New DbHelper
    Dim formUtils As New FormUtils

    Dim empConst As New EmployeesDBConstants
    Dim custConst As New CustomersDBConstants

    Private Function ShowMsg(quantity As Integer) As Boolean

        If formUtils.ShowMessageBoxResult("Caution", $"Are you sure you want to generate { quantity } dummy data? This action will greatly affect your database.") Then
            Return True
        End If

        Return False
    End Function

    Public Function LoadDummyDataToEmployees(numberOfRecords As Integer) As Boolean

        ' ur code here
        If Not ShowMsg(numberOfRecords) Then Return False


        For i As Integer = 1 To numberOfRecords
            ' Generate randomized or sequential data
            Dim middleName = $"Middle{i}"
            Dim sss = $"SSS-{1000000000 + i}"
            Dim pagibig = $"PAGIBIG-{2000000000 + i}"
            Dim tin = $"TIN-{3000000000 + i}"
            Dim firstName = $"FirstName{i}"
            Dim lastName = $"LastName{i}"
            Dim sex = If(i Mod 2 = 0, "Male", "Female")
            Dim birthdate = New Date(1990, 1, 1).AddDays(i Mod 365)
            Dim civilStatus = If(i Mod 2 = 0, "Single", "Married")
            Dim address = $"Address {i}"
            Dim contactNumber = $"091234567{i Mod 10}"
            Dim contractStatus = If(i Mod 3 = 0, "Active", "Inactive")
            Dim dateHired = DateTime.Now.AddDays(-i Mod 365)
            Dim jobType = If(i Mod 2 = 0, constants.getAdminString, constants.getUtilityPersonnelString)
            Dim email = $"user{i}@example.com"
            Dim password = $"password{i}"
            Dim adminPosition = If(jobType = constants.getAdminString, $"Admin Position {i}", Nothing)
            Dim personnelDestination = If(jobType = constants.getUtilityPersonnelString, $"Destination {i}", Nothing)

            ' Create the insert data dictionary
            Dim insertData As New Dictionary(Of String, Object) From {
                {empConst.empMidStr, middleName},
                {empConst.empSSSStr, sss},
                {empConst.empPagibigStr, pagibig},
                {empConst.empTINStr, tin},
                {empConst.empFirstStr, firstName},
                {empConst.empLastStr, lastName},
                {empConst.empSexStr, sex},
                {empConst.empBirthStr, birthdate},
                {empConst.empCivilStr, civilStatus},
                {empConst.empAddrStr, address},
                {empConst.empContactStr, contactNumber},
                {empConst.empStatusStr, contractStatus},
                {empConst.empHiredStr, dateHired},
                {empConst.empJobPosStr, jobType},
                {empConst.empEmailStr, email},
                {empConst.empPassStr, dbUtils.EncryptPassword(password, constants.EncryptionKey)},
                {empConst.empAddedByName, formUtils.getEmployeeName(Current.id)},
                {empConst.addedById, Current.id}
            }

            ' Add job-specific fields
            If jobType = constants.getAdminString Then
                insertData.Add(empConst.empAdminPosStr, adminPosition)
            ElseIf jobType = constants.getUtilityPersonnelString Then
                insertData.Add(empConst.empDestStr, personnelDestination)
            End If

            ' Insert the row into the database
            dbUtils.InsertRecord(empConst.empTableStr, insertData)
        Next

        MessageBox.Show($"{numberOfRecords} employee records generated successfully!")

        Return True
    End Function

    Public Function LoadDummyDataToCustomers(numberOfRecords As Integer) As Boolean
        If Not ShowMsg(numberOfRecords) Then Return False

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
            formUtils.AddRow(custConst.custTableStr, insertData, 4)
        Next

        MessageBox.Show($"{numberOfRecords} customer records generated successfully!")


        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToSuppliers(numberOfRecords As Integer) As Boolean
        If Not ShowMsg(numberOfRecords) Then Return False

        ' ur code here



        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToServices(numberOfRecords As Integer) As Boolean
        If Not ShowMsg(numberOfRecords) Then Return False

        ' ur code here



        Return True ' return true if successful
    End Function


    Public Function LoadDummyDataToInventory(numberOfRecords As Integer) As Boolean
        If Not ShowMsg(numberOfRecords) Then Return False

        ' ur code here



        Return True ' return true if successful
    End Function

End Class
