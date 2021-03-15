Public Class DetailView
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DetailView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAddress.Text = "Adrress " & (hsbAddress.Value + 1).ToString
        lblBank.Text = "Bank Account " & (hsbBank.Value + 1).ToString
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        'Get data from windows.form to clipboard
        Dim txtDict = ReadDetailForm()

        'Create text to put in clipboard
        Dim outputText As String = $"{txtDict("txtID")}; {txtDict("txtName")}; {txtDict("txtVatNo")}; {txtDict("txtStreet")}; {txtDict("txtCity")}; {txtDict("txtZip")}; {txtDict("txtCountry")}; {txtDict("txtAccount")}; {txtDict("txtBankCode")}; {txtDict("txtIBAN")}; {txtDict("txtBIC")}"

        'Put string into clipboard
        Clipboard.Clear()
        Clipboard.SetText(outputText)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Intitialize new Entity
        Dim DeleteEntity As New Entity()

        'Read data from Detail form
        Dim DataDict = ReadDetailForm()

        'Parse read data to entity properties
        ParseEntity(DeleteEntity, DataDict)

        'Confirm Delete action
        Dim decision As DialogResult = MessageBox.Show($"Do you wish to permanently delete {DeleteEntity.Role} No:{DeleteEntity.ID}, {DeleteEntity.Name} from database?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If decision <> 6 Then Return

        DeleteEntityByID(DeleteEntity.ID)

        ClearDetailForm()
        ClearFindResultForm()

        'MessageBox.Show($"{DeleteEntity.ID}; {DeleteEntity.Name}; {DeleteEntity.VAT_number};{DeleteEntity.Role};
        '{DeleteEntity.Street(0)}; {DeleteEntity.City(0)};{DeleteEntity.ZIP_code(0)}; {DeleteEntity.Country_code(0)};
        '{DeleteEntity.Bank_account(0)}; {DeleteEntity.Bank_code(0)}; {DeleteEntity.Iban(0)}; {DeleteEntity.Bic_code(0)}")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'read in form data into Dictionary
        Dim txtDict As Dictionary(Of String, String) = ReadDetailForm()
        Dim query As String
        Dim queryType As String
        Dim qResult As Integer
        Dim failed As Boolean = False

        'Instantiate entity and parse input data
        Dim updateEntity As New Entity
        ParseEntity(updateEntity, txtDict)

        'Check if role and Name not empty (not NULL constraint in db)
        If updateEntity.Role = String.Empty Or updateEntity.Name = String.Empty Then
            MessageBox.Show("Missing Data! Inputs must include entity Role (Vendor/Client) and Entity Name.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If updateEntity.Name = String.Empty Then txtName.Focus()
            If updateEntity.Role = String.Empty Then RadioVendor.Checked = True
            Return
        End If

        'Check if ID in DB (if empty, get next serial number)
        If updateEntity.ID = String.Empty Then
            If updateEntity.Role = "Vendor" Then
                query = "SELECT MAX(entity_id) AS max_id FROM entity WHERE entity_id > 50000"
            Else
                query = "SELECT MAX(entity_id) AS max_id FROM entity WHERE entity_id < 50000"
            End If
            'get max ID from Db
            Dim newID As DataTable = GetEntity(query)
            'Parse and add 1 to get incremented entity ID
            updateEntity.ID = newID.Rows(0).Item("max_id") + 1
            txtID.Text = updateEntity.ID
            queryType = "INSERT"
            If MessageBox.Show("Auto selected Entity ID. Continue?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> 6 Then
                txtID.Focus()
                Return
            End If
        Else
            'Check if format correct (INT)
            Dim IDnumber As Integer
            If Not Integer.TryParse(updateEntity.ID, IDnumber) Then
                MessageBox.Show("Incorrect data format in ID Number field. Must be an Integer.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtID.Focus()
                Return
            End If
            'Check if in database
            query = "SELECT entity_id FROM entity WHERE entity_id=" & updateEntity.ID
            Dim resultTable As DataTable = GetEntity(query)
            If resultTable.Rows.Count = 0 Then
                queryType = "INSERT"
            Else
                queryType = "UPDATE"
            End If
        End If

        'Confirm database action
        If MessageBox.Show("Please confirm " & queryType & " the database data. This action is permanent", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> 6 Then
            Return
        End If

        If queryType = "INSERT" Then
            qResult = InsertEntity("entity", updateEntity)
            If qResult = 0 Then failed = True
            qResult = InsertEntity("address", updateEntity)
            If qResult = 0 Then failed = True
            qResult = InsertEntity("Bank_details", updateEntity)
            If qResult = 0 Then failed = True
        End If

        'Report Insert reuslt
        If failed Then
            MessageBox.Show("Could not insert into the database", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Insert data successful")
        End If
    End Sub
End Class