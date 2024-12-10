Imports System.IO
Imports System.Runtime.Remoting

Public Class ServiceEvaluationModal
    Dim dbHelper As New DbHelper
    Dim formUtils As New FormUtils
    Dim constants As New Constants

    Dim servConst As New ServiceDBConstants
    Dim invConst As New InventoryDBConstants
    Dim itemConst As New ItemsDBConstants

    Private repairStatus As String = Nothing
    Private technicianFee As Decimal = Nothing
    Private repairNotes As String = Nothing

    Dim partsCost As Decimal = Nothing
    Dim totalCost As Decimal = Nothing

    Public Property selectedID As Integer = -1

    Private Sub ServiceEvaluationModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbds(-1)
        loadVals()
    End Sub

    Private Sub loadVals()

        If selectedID = -1 Then Exit Sub

        ' SERVICE

        Dim servDT As DataTable = dbHelper.GetRowByValue(servConst.svcTableStr, servConst.svcIDStr, selectedID)

        If servDT.Rows.Count = 0 Then Exit Sub

        With servDT.Rows(0)
            ' device type
            Dim deviceIndex As Integer = formUtils.FindComboBoxItemByText(RepairStatusCmb, .Item(servConst.svcStatusStr))
            LoadCmbds(deviceIndex)

            ' load image
            Dim deviceImgPath = .Item(servConst.devProfilePathStr)
            If File.Exists(deviceImgPath) Then
                DeviceCirclePictureBox.Image = Image.FromFile(deviceImgPath)
            End If

            TechnicianFeeTxtBox.Text = .Item(servConst.techFeeStr) ' load the current fee
            RepairNotesTxtBox.Text = dbHelper.StrNullCheck(.Item(servConst.repairNotesStr))

            PartsUsedTxtBox.Text = .Item(servConst.PartsUsed)
            partsCost = .Item(servConst.partsCostStr) ' get existing parts cost

            PartsCostTxtBox.Text = partsCost
        End With


    End Sub

    Private Sub LoadCmbds(index As Integer)
        With dbHelper
            .LoadEnumsToCmb(RepairStatusCmb, servConst.svcTableStr, servConst.svcStatusStr, index, 2) 'skip by two
        End With
    End Sub

    Private Sub RepairStatusCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepairStatusCmb.SelectedIndexChanged
        repairStatus = RepairStatusCmb.SelectedItem

        If RepairStatusCmb.SelectedItem <> constants.getFinishedString Then
            TechnicianFeeTxtBox.Enabled = False
            RepairNotesTxtBox.Enabled = False

        Else
            TechnicianFeeTxtBox.Enabled = True
            RepairNotesTxtBox.Enabled = True
            RepairNotesTxtBox.Text = ""
            TechnicianFeeTxtBox.Text = ""
        End If

    End Sub


    Private Sub TechnicianFeeTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TechnicianFeeTxtBox.KeyPress
        e.Handled = Not formUtils.ValidateDecimalInput(TechnicianFeeTxtBox, e)
    End Sub

    Private Sub TechnicianFeeTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TechnicianFeeTxtBox.TextChanged
        Decimal.TryParse(TechnicianFeeTxtBox.Text, technicianFee)
        totalCost = technicianFee + partsCost
        TotalCostTxtBox.Text = totalCost
    End Sub

    Private Sub RepairNotesTxtBox_TextChanged(sender As Object, e As EventArgs) Handles RepairNotesTxtBox.TextChanged
        repairNotes = RepairNotesTxtBox.Text
    End Sub

    Private Sub PartsUsedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsUsedTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub PartsCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles PartsCostTxtBox.TextChanged
        ' for viewing
    End Sub
    Private Sub TotalCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTxtBox.TextChanged
        ' for viewing
    End Sub

    Private Sub SeePartsBtn_Click(sender As Object, e As EventArgs) Handles SeePartsBtn.Click
        ' for viewing
        Dim resultID As Integer = formUtils.ShowModalWithHandler(
         Function(id)
             Dim modal As New InventoryItemModal
             modal.serviceID = id
             Return modal
         End Function,
         selectedID,
         Function(modal)
             Return Nothing
         End Function
         )
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If Not formUtils.ShowMessageBoxResult("Confirmation", "Are you sure you want to evaluate this service?") Then Exit Sub

        With servConst
            Dim updateData As New Dictionary(Of String, Object) From {
                { .svcStatusStr, repairStatus}
            }

            ' QUEUE AGAIN IF CANCELED BY TECH
            If repairStatus = constants.getCanceledString Then
                updateData.Add(.techIDStr, Nothing)
                updateData.Add(.techNameStr, Nothing)
                updateData.Add(.getDateAccepted, Nothing)
            End If

            If repairStatus = constants.getFinishedString Then
                updateData.Add(.techFeeStr, technicianFee)
                updateData.Add(.TotalCost, totalCost)
                updateData.Add(.dateCompletedStr, DateTime.Now)
                updateData.Add(.repairNotesStr, repairNotes)
                If Not formUtils.AreAllDictValuesFilled(updateData, 0) Then Exit Sub

                If technicianFee <= partsCost Then
                    MsgBox("Please fill the minimum technician fee, must be greater than overall parts cost (" & partsCost & ")")
                    Exit Sub
                End If

            End If

            If dbHelper.UpdateRecord(.svcTableStr, .svcIDStr, selectedID, updateData) Then
                dbHelper.Logs("Evaluated Service: " & selectedID & " to " & repairStatus, Current.id)
                Me.Close()
            End If

        End With

    End Sub


End Class
