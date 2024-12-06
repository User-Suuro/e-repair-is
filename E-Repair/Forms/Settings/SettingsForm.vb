Public Class SettingsForm

    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants

    Dim custConst As New CustomersDBConstants
    Dim empConst As New EmployeesDBConstants
    Dim supConst As New SuppliersDBConstants
    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants

    Dim tableListName As New Dictionary(Of String, String)

    Dim cmbEmpListName As New Dictionary(Of String, String)
    Dim cmbCustListName As New Dictionary(Of String, String)
    Dim cmbServListName As New Dictionary(Of String, String)
    Dim cmbInvListName As New Dictionary(Of String, String)
    Dim cmbSuppListName As New Dictionary(Of String, String)

    Dim combinedDictionary As New Dictionary(Of String, String)

    Dim foundTable As String = Nothing
    Dim foundAtrr As String = Nothing

    Dim selectedEnumVal As String = Nothing

    Dim listEnums As List(Of String)

    ' MANAGE ENUMS

    Private Sub AdminSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' GET TABLE NAMES

        tableListName = New Dictionary(Of String, String) From {
            {empConst.empTableStr, constants.EmployeesTitle},
            {custConst.custTableStr, constants.getCustomerTitle},
            {supConst.supTableStr, constants.SuppliersTitle},
            {servConst.svcTableStr, constants.ServicesTitle},
            {invConst.invTableStr, constants.InventoryTitle}
        }

        ' GET COMBO BOX NAMES

        With empConst
            cmbEmpListName = New Dictionary(Of String, String) From {
                { .empSexStr, "Sex"},
                { .empCivilStr, "Civil Status"},
                { .empStatusStr, "Contract Status"},
                { .empAdminPosStr, "Admin Positions"}
            }
        End With

        With custConst
            cmbCustListName = New Dictionary(Of String, String) From {
                { .custGenderStr, "Gender"}
            }
        End With

        With supConst
            cmbSuppListName = New Dictionary(Of String, String) From {
                { .supTypeStr, "Supplier Type"},
                { .supContractStr, "Contract Type"},
                { .bankDetailsStr, "Bank Details"},
                { .payTermsStr, "Payment Terms"}
              }
        End With

        With invConst
            cmbInvListName = New Dictionary(Of String, String) From {
                { .itemCatStr, "Item Category"},
                { .hazClassStr, "Hazardous Classification"}
            }
        End With

        With servConst
            cmbServListName = New Dictionary(Of String, String) From {
                { .devTypeStr, "Device Type"}
            }
        End With

        ' COMBINE DICTIONARIES

        For Each kvp In cmbEmpListName
            Try
                combinedDictionary.Add(kvp.Key, kvp.Value)
            Catch ex As ArgumentException
                ' Handle the duplicate key (e.g., ignore or log the conflict)
            End Try
        Next

        For Each kvp In cmbCustListName
            Try
                combinedDictionary.Add(kvp.Key, kvp.Value)
            Catch ex As ArgumentException
                ' Handle the duplicate key
            End Try
        Next

        For Each kvp In cmbSuppListName
            Try
                combinedDictionary.Add(kvp.Key, kvp.Value)
            Catch ex As ArgumentException
                ' Handle the duplicate key
            End Try
        Next

        For Each kvp In cmbInvListName
            Try
                combinedDictionary.Add(kvp.Key, kvp.Value)
            Catch ex As ArgumentException
                ' Handle the duplicate key
            End Try
        Next

        For Each kvp In cmbServListName
            Try
                combinedDictionary.Add(kvp.Key, kvp.Value)
            Catch ex As ArgumentException
                ' Handle the duplicate key
            End Try
        Next

        ' INITIALIZE DEFAULT VALUES

        TableNameCmb.DataSource = formUtils.GetDictValues(tableListName)
        TableNameCmb.SelectedIndex = 0

        AttributesCmb.DataSource = formUtils.GetDictValues(cmbEmpListName)
        AttributesCmb.SelectedIndex = 0
    End Sub

    Private Sub TableNameCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TableNameCmb.SelectedIndexChanged

        Dim attrDataSource As List(Of String) = Nothing

        If TableNameCmb.SelectedItem = constants.EmployeesTitle Then
            attrDataSource = formUtils.GetDictValues(cmbEmpListName)

        ElseIf TableNameCmb.SelectedItem = constants.getCustomerTitle Then
            attrDataSource = formUtils.GetDictValues(cmbCustListName)

        ElseIf TableNameCmb.SelectedItem = constants.SuppliersTitle Then
            attrDataSource = formUtils.GetDictValues(cmbSuppListName)

        ElseIf TableNameCmb.SelectedItem = constants.InventoryTitle Then
            attrDataSource = formUtils.GetDictValues(cmbInvListName)

        ElseIf TableNameCmb.SelectedItem = constants.ServicesTitle Then
            attrDataSource = formUtils.GetDictValues(cmbServListName)

        End If

        AttributesCmb.DataSource = attrDataSource
        loadEnumsToDGV()
    End Sub

    Private Sub AttributesCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttributesCmb.SelectedIndexChanged
        loadEnumsToDGV()
    End Sub

    Private Sub loadEnumsToDGV()

        Dim selectedTable As String = TableNameCmb.SelectedItem
        Dim selectedAttr As String = AttributesCmb.SelectedItem

        For Each kvp In tableListName

            If kvp.Value = selectedTable Then
                foundTable = kvp.Key
                Exit For
            End If

        Next

        For Each kvp In combinedDictionary

            If kvp.Value = selectedAttr Then
                foundAtrr = kvp.Key
                Exit For
            End If

        Next

        If Not String.IsNullOrEmpty(foundTable) AndAlso Not String.IsNullOrEmpty(foundAtrr) Then
            listEnums = dbHelper.GetEnums(foundTable, foundAtrr)

            Dim dt As New DataTable()

            dt.Columns.Add("item_name")

            For Each item As String In listEnums
                dt.Rows.Add(item)
            Next

            EnumDGV.DataSource = dt
            EnumDGV.RowTemplate.Height = formUtils.rowHeight
        End If
    End Sub

    Private Function loadSelectedEnum() As Boolean
        If Not formUtils.dgvValChecker(EnumDGV) Then Return False

        With EnumDGV.CurrentRow
            selectedEnumVal = .Cells("item_name").Value
            EnumTxtBox.Text = selectedEnumVal
        End With

        Return True
    End Function

    ' delete enum
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Not loadSelectedEnum() Then Exit Sub

        If Not checkIfHasActive() Then Exit Sub

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to delete this value?") Then Exit Sub

        listEnums.Remove(EnumTxtBox.Text)

        EnumTxtBox.Text = Nothing
        dbHelper.AlterEnums(foundTable, foundAtrr, listEnums)
        loadEnumsToDGV()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If Not String.IsNullOrEmpty(selectedEnumVal) AndAlso Not loadSelectedEnum() Then
            ' edit
            If Not checkIfHasActive() Then Exit Sub

            If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this value?") Then Exit Sub
            Dim index As Integer = listEnums.FindIndex(Function(s) s = selectedEnumVal)
            listEnums(index) = EnumTxtBox.Text
        Else
            'add
            If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this value?") Then Exit Sub
            listEnums.Add(EnumTxtBox.Text)
        End If

        EnumTxtBox.Text = Nothing
        dbHelper.AlterEnums(foundTable, foundAtrr, listEnums)
        loadEnumsToDGV()
    End Sub

    Private Function checkIfHasActive() As Boolean

        If dbHelper.GetRowByValue(foundTable, foundAtrr, selectedEnumVal).Rows.Count > 0 Then
            MsgBox("You cannot delete/edit this value because it has active usage")
            Return False
        End If

        Return True

    End Function

    Private Sub EnumDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnumDGV.CellClick
        loadSelectedEnum()

        If selectedEnumVal IsNot Nothing Then
            BtnDelete.Visible = True
            ClearSelectBtn.Visible = True
            BtnAdd.Text = "Edit"
            EnumTxtBox.Text = selectedEnumVal
        Else
            ClearSelectBtn.Visible = False
            BtnDelete.Visible = False
            BtnAdd.Text = "Add"
        End If

    End Sub

    Private Sub ClearSelectBtn_Click(sender As Object, e As EventArgs) Handles ClearSelectBtn.Click
        EnumDGV.ClearSelection()
        EnumTxtBox.Text = Nothing
        selectedEnumVal = Nothing
        ClearSelectBtn.Visible = False
        BtnAdd.Text = "Add"
        BtnDelete.Visible = False
    End Sub

    ' OPEN LOGS
    Private Sub OpenLogsBtn_Click(sender As Object, e As EventArgs) Handles OpenLogsBtn.Click
        formUtils.ShowModalWithHandler(
        Function(qty)
            Dim modal As New LogsForm
            Return modal
        End Function,
        -1,
        Function(modal)
            ' Return multiple values in a tuple
            Return Nothing
        End Function
        )
    End Sub

    ' LOAD DUMMY
    Private Function openModal(dataBeGen As String) As Tuple(Of Integer, Integer, Integer, Integer)
        Return formUtils.ShowModalWithHandler(
        Function(qty)
            Dim modal As New DummyModal
            modal.dataToBeGen = dataBeGen
            modal.Guna2GroupBox1.Text = $"Generate {dataBeGen} Dummy Data"
            Return modal
        End Function,
        -1,
        Function(modal)
            ' Return multiple values in a tuple
            Return Tuple.Create(modal.quantityReturned, modal.selectedCustID, modal.selectedSuppID, modal.selectedTechID)
        End Function
        )
    End Function

    Private Sub GenerateEmp_Click(sender As Object, e As EventArgs) Handles GenerateEmp.Click
        Dim getReturnedValue As Tuple(Of Integer, Integer, Integer, Integer) = openModal(constants.EmployeesTitle)
        Dim getQtyInModal As Integer = getReturnedValue.Item1

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToEmployees(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateCust_Click(sender As Object, e As EventArgs) Handles GenerateCust.Click
        Dim getReturnedValue As Tuple(Of Integer, Integer, Integer, Integer) = openModal(constants.getCustomerTitle)
        Dim getQtyInModal As Integer = getReturnedValue.Item1

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToCustomers(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateSupp_Click(sender As Object, e As EventArgs) Handles GenerateSupp.Click
        Dim getReturnedValue As Tuple(Of Integer, Integer, Integer, Integer) = openModal(constants.SuppliersTitle)
        Dim getQtyInModal As Integer = getReturnedValue.Item1

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToSuppliers(getQtyInModal)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateServ_Click(sender As Object, e As EventArgs) Handles GenerateServ.Click
        Dim getReturnedValue As Tuple(Of Integer, Integer, Integer, Integer) = openModal(constants.ServicesTitle)

        Dim getQtyInModal As Integer = getReturnedValue.Item1
        Dim getCustID As Integer = getReturnedValue.Item2
        Dim getTechID As Integer = getReturnedValue.Item4

        If getQtyInModal = -1 Then Exit Sub

        If getCustID = -1 Or getCustID = Nothing Then
            MsgBox("Please select a customer")
            Exit Sub
        End If

        If getTechID = -1 Or getTechID = Nothing Then
            MsgBox("Please select a technician")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        LoadDummyDataToServices(getQtyInModal, getCustID, getTechID)
        Cursor = Cursors.Default

    End Sub

    Private Sub GenerateInv_Click(sender As Object, e As EventArgs) Handles GenerateInv.Click
        Dim getReturnedValue As Tuple(Of Integer, Integer, Integer, Integer) = openModal(constants.InventoryTitle)

        Dim getQtyInModal As Integer = getReturnedValue.Item1
        Dim selcetedSuppID As Integer = getReturnedValue.Item3

        If selcetedSuppID = -1 Then
            MsgBox("Please select a supplier")
            Exit Sub
        End If

        If getQtyInModal = -1 Then Exit Sub

        Cursor = Cursors.WaitCursor
        LoadDummyDataToInventory(getQtyInModal, selcetedSuppID)
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
                      { .empPassStr, EncryptPassword(pwd, constants.EncryptionKey)},
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
        With supConst
            Dim supplierTypes As List(Of String) = dbHelper.GetEnums(.supTableStr, .supTypeStr)
            Dim supplierContracts As List(Of String) = dbHelper.GetEnums(.supTableStr, .supContractStr)
            Dim bankDetails As List(Of String) = dbHelper.GetEnums(.supTableStr, .bankDetailsStr)
            Dim paymentTerms As List(Of String) = dbHelper.GetEnums(.supTableStr, .payTermsStr)

            Try
                For i As Integer = 1 To numberOfRecords
                    ' Generate dummy data
                    Dim companyName = $"CompanyName{i}"
                    Dim companyDescription = $"This is a description for CompanyName{i}."
                    Dim contactPerson = $"ContactPerson{i}"
                    Dim contactNumber = $"091234567{i Mod 10}"
                    Dim companyEmail = $"company{i}@example.com"
                    Dim location = $"Location{i}"

                    Dim supplierType = supplierTypes(rnd.Next(0, supplierTypes.Count))

                    Dim supplierContract = supplierContracts(rnd.Next(0, supplierContracts.Count))
                    Dim bankDetail = bankDetails(rnd.Next(0, bankDetails.Count))
                    Dim paymentTerm = paymentTerms(rnd.Next(0, paymentTerms.Count))

                    Dim estimatedDeliveryTime = If(rnd.Next(0, 2) = 0, $"{rnd.Next(1, 10)} days", Nothing) ' Optional field

                    Dim insertData As New Dictionary(Of String, Object) From {
                       { .estDeliveryStr, estimatedDeliveryTime}, ' optional
                       { .compNameStr, companyName},
                       { .compDescStr, companyDescription},
                       { .contactPersonStr, contactPerson},
                       { .contactNumStr, contactNumber},
                       { .compEmailStr, companyEmail},
                       { .locationStr, location},
                       { .supTypeStr, supplierType},
                       { .supContractStr, supplierContract},
                       { .bankDetailsStr, bankDetail},
                       { .payTermsStr, paymentTerm},
                       { .addedByName, formUtils.getEmployeeName(Current.id)},
                       { .addedByID, Current.id},
                       { .compPicPathStr, dummyImagePath}
                    }

                    dbHelper.InsertRecord(.supTableStr, insertData)

                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End With

        MessageBox.Show($"{numberOfRecords} supplier records generated successfully!")
        Return True ' return true if successful
    End Function

    Public Function LoadDummyDataToServices(numberOfRecords As Integer, custID As Integer, techID As Integer) As Boolean
        With servConst
            Dim paymentMethods As List(Of String) = dbHelper.GetEnums(.svcTableStr, .payMethodStr)
            Dim deviceTypes As List(Of String) = dbHelper.GetEnums(.svcTableStr, .devTypeStr)

            Try
                For i As Integer = 1 To numberOfRecords

                    Dim deviceModel = $"Model-{rnd.Next(1000, 9999)}"

                    Dim deviceBrand = $"Brand-{rnd.Next(1, 100)}"
                    Dim operatingSystem = $"OS-{rnd.Next(1, 15)}"

                    Dim storageCapacity = $"{rnd.Next(16, 512)}GB"
                    Dim problemDescription = $"Problem-{rnd.Next(1, 100)}"

                    Dim paymentMethod = paymentMethods(rnd.Next(0, paymentMethods.Count))
                    Dim deviceType = deviceTypes(rnd.Next(0, deviceTypes.Count))

                    Dim insertData As New Dictionary(Of String, Object) From {
                        { .custIDStr, custID},
                        { .techIDStr, techID},
                        { .custNameStr, formUtils.getCustomerName(custID)},
                        { .techNameStr, formUtils.getEmployeeName(techID)},
                        { .cashierIDStr, Current.id},
                        { .devTypeStr, deviceType},
                        { .devModelStr, deviceModel},
                        { .devBrandStr, deviceBrand},
                        { .osStr, operatingSystem},
                        { .storageCapStr, storageCapacity},
                        { .probDescStr, problemDescription},
                        { .getAddedByName, formUtils.getEmployeeName(Current.id)},
                        { .dateAddedStr, DateTime.Now()},
                        { .devProfilePathStr, dummyImagePath}
                    }

                    dbHelper.InsertRecord(.svcTableStr, insertData)

                Next

                ' update cust transaction date
                Dim updateTransDate As New Dictionary(Of String, Object) From {
                    {custConst.custLastTransStr, DateTime.Now()}
                }

                dbHelper.UpdateRecord(custConst.custTableStr, custConst.custIDStr, custID, updateTransDate)

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End With

        MessageBox.Show($"{numberOfRecords} service records generated successfully!")
        Return True ' return true if successful
    End Function


    Public Function LoadDummyDataToInventory(numberOfRecords As Integer, suppID As Integer) As Boolean
        With invConst

            Dim itemCategories As List(Of String) = dbHelper.GetEnums(.invTableStr, .itemCatStr)
            Dim hazardClassifications As List(Of String) = dbHelper.GetEnums(.invTableStr, .hazClassStr)

            Try
                For i As Integer = 1 To numberOfRecords
                    Dim itemCategory = itemCategories(rnd.Next(0, itemCategories.Count))

                    Dim itemName = $"{itemCategory}-Item-{rnd.Next(1000, 9999)}"
                    Dim itemDescription = $"This is a description for {itemName}."

                    Dim serialNumber = $"{itemCategory}-SN-{rnd.Next(1000000, 9999999)}"
                    Dim hazardousClassification = hazardClassifications(rnd.Next(0, hazardClassifications.Count))

                    Dim availableQuantity = rnd.Next(1, 100)
                    Dim costPerItem = Math.Round(rnd.NextDouble() * 1000 + 100, 2)
                    Dim totalCost = Math.Round(availableQuantity * costPerItem, 2)

                    Dim physicalLocation = $"Shelf-{rnd.Next(1, 20)}"

                    With invConst
                        Dim insertData As New Dictionary(Of String, Object) From {
                            { .serialNumStr, serialNumber}, ' optional
                            { .physLocStr, physicalLocation}, ' optional
                            { .supIDStr, suppID},
                            { .itemNameStr, itemName},
                            { .itemCatStr, itemCategory},
                            { .hazClassStr, hazardousClassification},
                            { .itemDescStr, itemDescription},
                            { .availableQtyStr, availableQuantity},
                            { .totalCostStr, totalCost},
                            { .costPerItem, costPerItem},
                            { .addedByIdName, formUtils.getEmployeeName(Current.id)},
                            { .addedByIDStr, Current.id}
                        }

                        dbHelper.InsertRecord(.invTableStr, insertData)
                    End With
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End With

        MessageBox.Show($"{numberOfRecords} inventory records generated successfully!")
        Return True ' return true if successful
    End Function


End Class