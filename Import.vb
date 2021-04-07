Imports System.IO
Public Class Import
    Public filePath As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtOpenFile_Click(sender As Object, e As EventArgs) Handles txtOpenFile.Click
        'Input valid filePath
        If ofDialog1.ShowDialog() <> 1 Then
            Return
        Else
            filePath = ofDialog1.FileName()
            txtFilePath.Text = filePath
            btnImport.Focus()
        End If


    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'Check if path in tetxbox exists in case it was input directly
        If Not File.Exists(txtFilePath.Text) Then
            MessageBox.Show("The file does not exist, please check.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFilePath.Focus()
            Return
        End If
        'Assign filePath
        filePath = txtFilePath.Text
        'check if csv
        If Path.GetExtension(filePath).ToLower <> ".csv" Then
            MessageBox.Show("Incorrect file format. Must be .csv", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFilePath.Focus()
            Return
        End If

        'Check inputs in obligatory table fields
        If txtRole.Text = String.Empty Or txtName.Text = String.Empty Then
            MessageBox.Show("Missing Data! Inputs must include entity Role (Vendor/Client) and Entity Name.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If txtName.Text = String.Empty Then txtName.Focus()
            If txtRole.Text = String.Empty Then txtRole.Focus()
            Return
        End If

        'Check separator validity
        Dim sep As String = txtSeparator.Text.Trim
        If Not (sep.Equals(";") Or sep.Equals(",")) Then
            MessageBox.Show("Unsupported separator string.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSeparator.Focus()
            Return
        End If
        'Display status window
        StatusWindow.Show()
        StatusWindow.lblStatusBar.Text = "Checking Inputs"

        'Read csv into dataTable
        'Create list of all entity properties
        Dim EmptyEntity As New Entity()
        Dim properties As Dictionary(Of String, String()) = getProperties(EmptyEntity)

        'get table separator


        'Read in table from csv
        Dim importTable As DataTable = csvToDatatable(filePath, sep)

        'Read properties names and parse with csv column names
        Dim parseDict As New Dictionary(Of String, String) 'Dictionary of property name as key and csv table column name as per info in import form.

        For Each key As String In properties.Keys
            For Each cntrl As Control In Me.Controls 'iterates through all controls in Import form
                If cntrl.Name.Contains(key) And cntrl.Text <> String.Empty Then 'txtBox names are same as property name with txt preceding the name, 
                    parseDict.Add(cntrl.Text.Trim, key) 'if match add value to dict
                End If
            Next
        Next key

        'Check validity of inputs (ID and Role)
        Dim idColumn As String = txtID.Text.Trim
        Dim roleColumn As String = txtRole.Text.Trim
        Dim counter As Integer = 1 'only for reporting row number, if error, otherwise not used

        For Each item As KeyValuePair(Of String, String) In parseDict
            If Not importTable.Columns.Contains(item.Key) Then
                StatusWindow.Close()
                MessageBox.Show("Column name " & item.Key & " not present in the imported .csv file", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        For Each row As DataRow In importTable.Rows
            'check if ID valid
            If row.Item(idColumn) <> String.Empty Then
                Dim testVal As Integer 'Only for tryParse
                If Not Integer.TryParse(row.Item(idColumn), testVal) Then
                    StatusWindow.Close()
                    MessageBox.Show("Invalid ID at row " & counter.ToString, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                'check duplicity in DB
                Dim query As String = "SELECT entity_id FROM entity WHERE entity_id=" & row.Item(idColumn).ToString
                If GetEntity(query).Rows.Count > 0 Then
                    StatusWindow.Close()
                    MessageBox.Show("Invalid ID at row " & counter.ToString & ". ID already in Database", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If

            If Not (row.Item(roleColumn) = "Vendor" Or row.Item(roleColumn) = "Client") Then
                StatusWindow.Close()
                MessageBox.Show("Invalid Entity Role at row " & counter.ToString & ". Only Vendor or Client values allowed.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            counter += 1 ' Increment counter
        Next


        'Parse values to entity properties
        counter = 1 'Reset counter
        For Each row As DataRow In importTable.Rows
            'Show Status Window with updated message
            StatusWindow.lblStatusBar.Text = "Processing row: " & counter
            Dim entity As New Entity
            'look up column Name
            For Each name As KeyValuePair(Of String, String) In parseDict
                Dim value As String = row(name.Key).ToString
                'setProperties(entity, name.Value, value) 'nefunguje tam setValue pro string() => nehází error ale nenastaví to property typu string(), pro string to funguje OPRAVIT
                If value <> String.Empty Then
                    Select Case name.Value 'Tupý workaround protože nejede řádek výše
                        Case "ID"
                            entity.ID = value
                        Case "Name"
                            entity.Name = value
                        Case "VAT_number"
                            entity.VAT_number = value
                        Case "Role"
                            entity.Role = value
                        Case "City"
                            entity.City(0) = value
                        Case "Street"
                            entity.Street(0) = value
                        Case "ZIP_code"
                            entity.ZIP_code(0) = value
                        Case "Country_code"
                            entity.Country_code(0) = value
                        Case "Bank_account"
                            entity.Bank_account(0) = value
                        Case "Iban"
                            entity.Iban(0) = value
                        Case "Bank_code"
                            entity.Bank_code(0) = value
                        Case "Bic_code"
                            entity.Bic_code(0) = value
                    End Select
                End If
            Next

            'get ID from DB if empty in import table
            If entity.ID Is Nothing Then
                'get ID from db
                Dim query As String = "SELECT MAX(entity_id) AS max_entity FROM entity WHERE entity_role ='" & entity.Role & "'"
                Dim outputTable = GetEntity(query)
                Dim newID As Integer = CInt(outputTable(0)("max_entity")) + 1
                'Assign to entity.ID property
                entity.ID = newID.ToString
            End If

            'Insert into DB
            Dim result As Integer
            Dim failed As Boolean = False
            result = InsertEntity("entity", entity)
            If result = 0 Then failed = True

            result = InsertEntity("address", entity)
            If result = 0 Then failed = True

            result = InsertEntity("bank_details", entity)
            If result = 0 Then failed = True

            If failed = True Then
                StatusWindow.Close()
                MessageBox.Show("Error at processing row " & counter.ToString & ". Could not insert into database, process stopped.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            'increment counter
            counter += 1
        Next
        'Close status window
        StatusWindow.Close()
        'Report success
        MessageBox.Show("Import successful.")

    End Sub
End Class