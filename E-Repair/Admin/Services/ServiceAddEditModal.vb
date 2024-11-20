Imports System.Numerics
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class ServiceAddEditModal
    Dim formUtils As New FormUtils
    Dim dbHelper As New DbHelper
    Dim constants As New Constants
    Dim formModal As New Form

    Dim serviceID As Integer = -1
    Dim customerID As Integer = -1
    Dim technicianID As Integer = -1

    Dim deviceType As String = ""
    Dim deviceModel As String = ""
    Dim deviceBrand As String = ""

    Dim operatingSystem As String = ""
    Dim storageCapacity As String = ""
    Dim problemDescription As String = ""
    Dim repairNotes As String = ""

    Dim dateAdded As String = ""

    Public Property editMode As Boolean = False
    Public Property selectedID As Integer = -1
    Public Property profilePath As String

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If editMode Then
                EditDataFunction()
            Else
                AddDataFunction()
            End If
        Catch ex As Exception
            MsgBox("Failed to save / edit: " & ex.Message)
        End Try
    End Sub

    ' ADD 
    Private Sub AddDataFunction()

        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to add this service?")) Then Exit Sub

        Dim empIDLogged As Integer

        Try
            empIDLogged = GlobalSession.CurrentSession.EmployeeID
        Catch ex As Exception
            empIDLogged = -1
        End Try
    End Sub

    ' EDIT

    Private Sub EditDataFunction()
        ' Exit if canceled
        If Not (formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to edit this service?")) Then Exit Sub



    End Sub

    Private Sub SelectCustomerBtn_Click(sender As Object, e As EventArgs) Handles SelectCustomerBtn.Click

    End Sub

    Private Sub SelectTechnicianBtn_Click(sender As Object, e As EventArgs) Handles SelectTechnicianBtn.Click
        Dim employeeAddEditModal As New EmployeeAddEditModal

        Try
            formModal = formUtils.CreateBgFormModal()
            With employeeAddEditModal
                .Owner = formModal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            formModal.Close()
            employeeAddEditModal.Close()
        Finally
            employeeAddEditModal.Dispose()
            formModal.Dispose()
            'LoadDataToDGV()
        End Try
    End Sub

    Private Sub CustomerIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTxtBox.TextChanged

    End Sub

    Private Sub TechnicianIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianIDTxtBox.TextChanged

    End Sub

    Private Sub DeviceBrandTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceBrandTxtBox.TextChanged

    End Sub

    Private Sub DeviceModelTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceModelTxtBox.TextChanged

    End Sub

    Private Sub StorageCapacityTxtBox_TextChanged(sender As Object, e As EventArgs) Handles StorageCapacityTxtBox.TextChanged

    End Sub

    Private Sub DeviceCirclePictureBox_Click(sender As Object, e As EventArgs) Handles DeviceCirclePictureBox.Click

    End Sub

    Private Sub DeviceTypeCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceTypeCmbBox.SelectedIndexChanged

    End Sub
    Private Sub IfOthersDeviceTypeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersDeviceTypeTxtBox.TextChanged

    End Sub

    Private Sub OperatingSystemCmbBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OperatingSystemCmbBox.SelectedIndexChanged

    End Sub

    Private Sub IfOthersOperatingSystemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles IfOthersOperatingSystemTxtBox.TextChanged

    End Sub

    Private Sub DeviceProblemTxtBox_TextChanged(sender As Object, e As EventArgs) Handles DeviceProblemTxtBox.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub ServiceAddEditModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class