Imports System.IO
Imports Guna.UI2.WinForms

Public Class FormUtils
    Public Sub LoadFormIntoPanel(targetPanel As Panel, frm As Form)
        ' Remove existing controls in the target panel if any
        If targetPanel.Controls.Count > 0 Then
            targetPanel.Controls.RemoveAt(0)
        End If

        ' Set up the form properties for embedding
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        ' Add the form to the target panel and show it
        targetPanel.Controls.Add(frm)
        targetPanel.Tag = frm
        frm.Show()
    End Sub

    ' Ok cancel MsgBox
    Public Function ShowMessageBoxResult(title As String, content As String) As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show(content, title, MessageBoxButtons.OKCancel)

        If dialogResult = DialogResult.OK Then
            Return True
        ElseIf dialogResult = DialogResult.Cancel Then
            Return False
        End If

        Return False
    End Function

    ' Find combo box index by value
    Public Function FindComboBoxItemByText(comboBox As ComboBox, searchText As String) As Integer
        Dim index As Integer = -1

        For i As Integer = 0 To comboBox.Items.Count - 1
            If comboBox.Items(i).ToString() = searchText Then
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    ' CREATE BG FORM

    Public Function CreateBgFormModal() As Form

        Dim form As New Form

        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        form.StartPosition = FormStartPosition.CenterScreen
        form.Opacity = 0.5
        form.BackColor = Color.Black
        form.TopMost = True
        form.Show()

        Return form

    End Function

    ' Copy image to pc's appdata then return the path
    Public Function saveImgToLocal(sourceFilePath As String, folderName As String, commit As Boolean) As String

        If File.Exists(sourceFilePath) Then
            Dim image As Image = Image.FromFile(sourceFilePath)

            Dim imageFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "E-Repair Images")

            Dim specificFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "E-Repair Images", folderName)

            If Not Directory.Exists(imageFolder) Then
                Directory.CreateDirectory(imageFolder)
            End If

            If Not Directory.Exists(specificFolder) Then
                Directory.CreateDirectory(specificFolder)
            End If

            Dim combinedFolder As String = Path.Combine(imageFolder, specificFolder)

            Dim fileName As String = Path.GetFileName(sourceFilePath)
            Dim filePath As String = Path.Combine(combinedFolder, fileName)

            If File.Exists(filePath) Then Return filePath

            If commit Then image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png)

            Return filePath

        Else
            MessageBox.Show("Source file does not exist.")
            Return String.Empty
        End If
    End Function

    ' VALUE CHECKER
    Public Function AreAllValuesFilled(values As Dictionary(Of String, Object), Optional startingIndex As Integer = 0) As Boolean
        For i As Integer = startingIndex To values.Count - 1
            Dim kvp As KeyValuePair(Of String, Object) = values.ElementAt(i) ' Access key-value pair by index
            If kvp.Value Is Nothing OrElse kvp.Value.ToString().Trim() = "" OrElse kvp.Value.ToString() = "-1" Then
                MsgBox("Please fill all necessary details")
                Return False
            End If
        Next

        Return True
    End Function

    ' Search function
    Public Function SearchFunction(dt As DataTable, searchTerm As String, searchValues As String(), searchCmbSelectedIndex As Integer) As DataTable
        Dim searchBy As String = searchValues(0)

        If searchCmbSelectedIndex >= 0 AndAlso searchCmbSelectedIndex < searchValues.Length Then
            searchBy = searchValues(searchCmbSelectedIndex)
        End If

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            dt.DefaultView.RowFilter = $"CONVERT([{searchBy}], System.String) LIKE '%{searchTerm}%'"
        Else
            dt.DefaultView.RowFilter = ""
        End If

        Return dt
    End Function

End Class
