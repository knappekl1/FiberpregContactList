Imports System.IO
Public Class Export
    Public selectedPath As String
    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        Dim result As String = folderDialog1.ShowDialog()

        If result <> "1" Then
            Return
        Else
            selectedPath = Path.Combine(folderDialog1.SelectedPath(), "dataExport.csv")
            txtFilePath.Text = selectedPath
            btnExport.Focus()
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim query As String
        If rbClient.Checked = True Then
            query = "SELECT * FROM select_all WHERE entity_role = 'Client'"
        ElseIf rbVendor.Checked = True Then
            query = "SELECT * FROM select_all WHERE entity_role = 'Vendor'"
        Else
            query = "SELECT * FROM select_all"
        End If

        'get datatable from SQL query
        Dim exportTable As DataTable = GetEntity(query)

        'Create csv format string
        Dim csvFile As String = CSVBuilder(exportTable, ";")

        'Write string to File
        Using writer As New StreamWriter(selectedPath, False, System.Text.Encoding.UTF8)
            writer.Write(csvFile)
            Me.Close()
        End Using
    End Sub
End Class