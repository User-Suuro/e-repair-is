Public Class SettingsForm

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    Dim custConst As New CustomersDBConstants
    Dim empConst As New EmployeesDBConstants


    ' MANAGE ENUMS

    Private Sub AdminSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EnumDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnumDGV.CellContentClick

    End Sub
    Private Sub CompletedWorkTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CompletedWorkTxtBox.TextChanged

    End Sub

    Private Sub TableNameCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TableNameCmb.SelectedIndexChanged

    End Sub

    Private Sub AttributesCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttributesCmb.SelectedIndexChanged

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub

    ' LOAD DUMMY

    Private Function openModal() As Integer
        Return formUtils.ShowModalWithHandler(
        Function(qty)
            Dim modal As New DummyModal
            Return modal
        End Function,
        -1,
        Function(modal)
            Return modal.quantityReturned
        End Function
        )
    End Function

    Private Sub GenerateEmp_Click(sender As Object, e As EventArgs) Handles GenerateEmp.Click
        Dim getQtyInModal As Integer = openModal()

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToEmployees(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateCust_Click(sender As Object, e As EventArgs) Handles GenerateCust.Click
        Dim getQtyInModal As Integer = openModal()

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToCustomers(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateSupp_Click(sender As Object, e As EventArgs) Handles GenerateSupp.Click
        Dim getQtyInModal As Integer = openModal()

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToSuppliers(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateServ_Click(sender As Object, e As EventArgs) Handles GenerateServ.Click
        Dim getQtyInModal As Integer = openModal()

        If getQtyInModal = -1 Then Exit Sub
        Cursor = Cursors.WaitCursor
        LoadDummyDataToServices(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateInv_Click(sender As Object, e As EventArgs) Handles GenerateInv.Click
        Dim getQtyInModal As Integer = openModal()

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToInventory(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    ' LOAD DUMMY FUNCTIONS

    Dim resourcesPath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources")
    Dim dummyImagePath As String = System.IO.Path.Combine(resourcesPath, "landscape-placeholder-svgrepo-com.png")
    Dim rnd As New Random()

    Public Function LoadDummyDataToEmployees(numberOfRecords As Integer) As Boolean


        Dim jobTypes As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empJobPosStr)
        Dim filteredJobType As New List(Of String)()

        For i As Integer = 1 To jobTypes.Count - 1 ' Start from index 1
            filteredJobType.Add(jobTypes(i))
        Next

        Dim adminPositions As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empAdminPosStr)
        Dim civilStatuses As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empCivilStr)
        Dim employmentStatuses As List(Of String) = dbHelper.GetEnums(empConst.empTableStr, empConst.empStatusStr)
        Dim getLatestID As Integer = dbHelper.GetAllByCol(New List(Of String) From {empConst.empIDStr}, empConst.empTableStr).Rows(0).Item(empConst.empIDStr)

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


                    Dim email = $"user{i + getLatestID}@example.com"
                    Dim pwd = $"password{i}" ' Assume passwords are pre-encrypted


                    Dim jobType = filteredJobType(rnd.Next(0, filteredJobType.Count))
                    Dim adminPosition = If(jobType = "Admin" OrElse jobType = "Super Admin", adminPositions(rnd.Next(0, adminPositions.Count)), Nothing)

                    Dim personnelDestination = $"destination{i}"
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
                      { .empPassStr, dbHelper.EncryptPassword(pwd, constants.EncryptionKey)},
                      { .empSexStr, sex},
                      { .empBirthStr, birthdate},
                      { .empCivilStr, civilStatus},
                      { .empAddrStr, address},
                      { .empContactStr, contactNumber},
                      { .empStatusStr, employmentStatus},
                      { .empHiredStr, dateHired},
                      { .empProfileStr, dummyImagePath},
                      { .addedById, Current.id},
                      { .empAddedByName, formUtils.getEmployeeName(Current.id)}
                    }

                    If jobType.Equals(constants.getAdminString) Then
                        ' Admin

                        Dim updateAdminValues As New Dictionary(Of String, Object) From {
                            { .empAdminPosStr, adminPosition}
                        }

                        For Each kvp In updateAdminValues
                            insertData.Add(kvp.Key, kvp.Value)
                        Next

                    ElseIf jobType.Equals(constants.getUtilityPersonnelString) Then

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
            MsgBox("Unable to query data" & ex.Message)
            Return False
        End Try

        MessageBox.Show($"{numberOfRecords} employee records generated successfully!")
        Return True

    End Function

    Public Function LoadDummyDataToCustomers(numberOfRecords As Integer) As Boolean

        Dim genderEnum As List(Of String) = dbHelper.GetEnums(custConst.custTableStr, custConst.custGenderStr)

        Try
            For i As Integer = 1 To numberOfRecords

                With custConst
                    ' Generate dummy data
                    Dim firstName = $"FirstName{i}"
                    Dim middleName = If(rnd.Next(0, 2) = 0, $"MiddleName{i}", Nothing) ' Optional field
                    Dim lastName = $"LastName{i}"
                    Dim contactNumber = $"091234567{i Mod 10}"
                    Dim address = $"Address {i}"
                    Dim gender = genderEnum(rnd.Next(0, genderEnum.Count))
                    Dim email = $"customer{i}@example.com"

                    Dim insertData As New Dictionary(Of String, Object) From {
                       { .custMidStr, middleName}, ' optional
                       { .custContactStr, contactNumber}, ' optional
                       { .custAddressStr, address}, ' optional
                       { .custEmailStr, email}, ' optional
                       { .custFirstStr, firstName},
                       { .custLastStr, lastName},
                       { .custGenderStr, gender},
                       { .getAddedByName, formUtils.getEmployeeName(Current.id)},
                       { .getAddedByID, Current.id}
                    }

                    dbHelper.InsertRecord(custConst.custTableStr, insertData)
                End With

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        MessageBox.Show($"{numberOfRecords} customer records generated successfully!")
        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToSuppliers(numberOfRecords As Integer) As Boolean

        Try
            For i As Integer = 1 To numberOfRecords




            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToServices(numberOfRecords As Integer) As Boolean

        Try
            For i As Integer = 1 To numberOfRecords




            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True ' return true if successful
    End Function


    Public Function LoadDummyDataToInventory(numberOfRecords As Integer) As Boolean

        Try
            For i As Integer = 1 To numberOfRecords



            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True ' return true if successful
    End Function

End Class