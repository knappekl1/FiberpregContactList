Module Module1
    Public Function GetEntity(queryString As String) As DataTable

        'Connect DB and log status
        Dim status As String
        Dim query As String = queryString
        Dim connection As Odbc.OdbcConnection = New Odbc.OdbcConnection("DSN=FiberpregDB")
        Try
            connection.Open()
            System.Console.WriteLine("State: " + connection.State.ToString())
            status = connection.State.ToString()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Exit code here
        End Try

        Dim command As Odbc.OdbcCommand = New Odbc.OdbcCommand(query, connection)
            Dim reader As Odbc.OdbcDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
        Dim results As New DataTable
        results.Load(reader)

        reader.Close()
        connection.Close()
        Return results
    End Function

    Public Sub DeleteEntityByID(ByVal Entity_ID As String)
        'Connect DB and log status
        Dim status As String
        Dim qResult As String
        Dim connection As Odbc.OdbcConnection = New Odbc.OdbcConnection("DSN=FiberpregDB")
        Try
            connection.Open()
            System.Console.WriteLine("State: " + connection.State.ToString())
            status = connection.State.ToString()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        'Delete from table entity (DB shall have FKs ON DELETE CASCADE)
        Using cmd As New Odbc.OdbcCommand("DELETE FROM entity WHERE entity_id='" & Entity_ID & "'", connection)
            qResult = cmd.ExecuteNonQuery()
        End Using
        connection.Close()
        'Report outcome
        If qResult > 0 Then
            MessageBox.Show("Delete Successful")
        Else
            MessageBox.Show("Item with this ID not in database")
        End If

    End Sub
    Public Function InsertEntity(DbTableName As String, ByVal entity As Entity) As Integer
        'Declare
        Dim query As String
        Dim qResult As Integer = 0

        'Try to connect to DB
        Dim status As String
        Dim connection As Odbc.OdbcConnection = New Odbc.OdbcConnection("DSN=FiberpregDB")
        Try
            connection.Open()
            System.Console.WriteLine("State: " + connection.State.ToString())
            status = connection.State.ToString()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return qResult
        End Try

        'Setup query 
        If DbTableName = "entity" Then
            'Set query parameters and run Query
            query = "INSERT INTO entity(entity_id, entity_name, vat_number, entity_role) VALUES (?, ?, ?,?)"
            Dim cmd As New Odbc.OdbcCommand(query, connection)
            cmd.Parameters.AddWithValue("entity_id", entity.ID)
            cmd.Parameters.AddWithValue("entity_name", entity.Name)
            cmd.Parameters.AddWithValue("vat_number", If(String.IsNullOrEmpty(entity.VAT_number), DBNull.Value, entity.VAT_number))
            cmd.Parameters.AddWithValue("role", entity.Role)
            qResult = cmd.ExecuteNonQuery()
            connection.Close()

        ElseIf DbTableName = "address" Then
            query = "INSERT INTO address(entity_id, street, city, zip_code, country, primary_address) VALUES (?, ?, ?, ?, ?,'Yes')"
            Dim cmd As New Odbc.OdbcCommand(query, connection)
            cmd.Parameters.AddWithValue("entity_id", entity.ID)
            cmd.Parameters.AddWithValue("Street", If(String.IsNullOrEmpty(entity.Street(0)), DBNull.Value, entity.Street(0)))
            cmd.Parameters.AddWithValue("City", If(String.IsNullOrEmpty(entity.City(0)), DBNull.Value, entity.City(0)))
            cmd.Parameters.AddWithValue("ZIP_code", If(String.IsNullOrEmpty(entity.ZIP_code(0)), DBNull.Value, entity.ZIP_code(0)))
            cmd.Parameters.AddWithValue("Country_code", If(String.IsNullOrEmpty(entity.Country_code(0)), DBNull.Value, entity.Country_code(0)))

            qResult = cmd.ExecuteNonQuery()
            connection.Close()
        Else
            query = "INSERT INTO bank_details(entity_id, account_number, bank_code, iban_code, bic_code) VALUES (?, ?, ?, ?, ?)"
            Dim cmd As New Odbc.OdbcCommand(query, connection)
            cmd.Parameters.AddWithValue("entity_id", entity.ID)
            cmd.Parameters.AddWithValue("Bank_account", If(String.IsNullOrEmpty(entity.Bank_account(0)), DBNull.Value, entity.Bank_account(0)))
            cmd.Parameters.AddWithValue("Bank_code", If(String.IsNullOrEmpty(entity.Bank_code(0)), DBNull.Value, entity.Bank_code(0)))
            cmd.Parameters.AddWithValue("Iban", If(String.IsNullOrEmpty(entity.Iban(0)), DBNull.Value, entity.Iban(0)))
            cmd.Parameters.AddWithValue("Bic_code", If(String.IsNullOrEmpty(entity.Bic_code(0)), DBNull.Value, entity.Bic_code(0)))

            qResult = cmd.ExecuteNonQuery()
            connection.Close()
        End If

        Return qResult

    End Function

    Public Function UpdateEntityDB(DbTableName As String, ByVal entity As Entity) As Integer
        'Declare
        Dim query As String
        Dim qResult As Integer = 0

        'Try to connect to DB
        Dim status As String
        Dim connection As Odbc.OdbcConnection = New Odbc.OdbcConnection("DSN=FiberpregDB")
        Try
            connection.Open()
            System.Console.WriteLine("State: " + connection.State.ToString())
            status = connection.State.ToString()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return qResult
        End Try

        'Setup query 
        If DbTableName = "entity" Then
            'Set query parameters and run Query
            query = "UPDATE entity SET (entity_name, vat_number, entity_role) = (?,?,?) WHERE entity_id = ?"
            Dim cmd As New Odbc.OdbcCommand(query, connection)

            cmd.Parameters.AddWithValue("entity_name", entity.Name)
            cmd.Parameters.AddWithValue("vat_number", If(String.IsNullOrEmpty(entity.VAT_number), DBNull.Value, entity.VAT_number))
            cmd.Parameters.AddWithValue("role", entity.Role)
            cmd.Parameters.AddWithValue("entity_id", entity.ID)

            qResult = cmd.ExecuteNonQuery()
            connection.Close()

        ElseIf DbTableName = "address" Then
            query = "UPDATE address SET (street, city, zip_code, country) = (?,?,?,?) WHERE entity_id = ?"
            Dim cmd As New Odbc.OdbcCommand(query, connection)
            cmd.Parameters.AddWithValue("Street", If(String.IsNullOrEmpty(entity.Street(0)), DBNull.Value, entity.Street(0)))
            cmd.Parameters.AddWithValue("City", If(String.IsNullOrEmpty(entity.City(0)), DBNull.Value, entity.City(0)))
            cmd.Parameters.AddWithValue("ZIP_code", If(String.IsNullOrEmpty(entity.ZIP_code(0)), DBNull.Value, entity.ZIP_code(0)))
            cmd.Parameters.AddWithValue("Country_code", If(String.IsNullOrEmpty(entity.Country_code(0)), DBNull.Value, entity.Country_code(0)))
            cmd.Parameters.AddWithValue("entity_id", entity.ID)

            qResult = cmd.ExecuteNonQuery()
            connection.Close()
        Else
            query = "UPDATE bank_details SET (account_number, bank_code, iban_code, bic_code) = (?,?,?,?) WHERE entity_id = ?"
            Dim cmd As New Odbc.OdbcCommand(query, connection)
            cmd.Parameters.AddWithValue("Bank_account", If(String.IsNullOrEmpty(entity.Bank_account(0)), DBNull.Value, entity.Bank_account(0)))
            cmd.Parameters.AddWithValue("Bank_code", If(String.IsNullOrEmpty(entity.Bank_code(0)), DBNull.Value, entity.Bank_code(0)))
            cmd.Parameters.AddWithValue("Iban", If(String.IsNullOrEmpty(entity.Iban(0)), DBNull.Value, entity.Iban(0)))
            cmd.Parameters.AddWithValue("Bic_code", If(String.IsNullOrEmpty(entity.Bic_code(0)), DBNull.Value, entity.Bic_code(0)))
            cmd.Parameters.AddWithValue("entity_id", entity.ID)

            qResult = cmd.ExecuteNonQuery()
            connection.Close()
        End If

        Return qResult

    End Function
    Public Sub ClearDetailForm()
        Dim cntrlList = New List(Of Control) From {DetailView.pnlBase, DetailView.pnlAddress, DetailView.pnlBank, DetailView.pnlType} 'Define panels in which the textboxes are nested
        For Each pnl As Panel In cntrlList
            For Each cnt As Control In pnl.Controls
                If cnt.GetType Is GetType(TextBox) Then
                    cnt.ResetText()
                End If
            Next cnt
        Next
        If DetailView.RadioClient.Checked = True Then DetailView.RadioClient.Checked = False Else DetailView.RadioClient.Checked = False
        Return
    End Sub

    Public Sub ClearFindResultForm()
        If FindResult.dgvSearchResult.SelectedRows.Count > 0 Then
            For Each row In FindResult.dgvSearchResult.SelectedRows
                FindResult.dgvSearchResult.Rows.Remove(row)
            Next row
        End If
    End Sub
    Public Function ReadDetailForm() As Dictionary(Of String, String)
        Dim txtDict As New Dictionary(Of String, String)
        Dim cntrlList = New List(Of Control) From {DetailView.pnlBase, DetailView.pnlAddress, DetailView.pnlBank, DetailView.pnlType} 'Define panels in which the textboxes are nested
        For Each pnl As Panel In cntrlList
            For Each cnt As Control In pnl.Controls
                If cnt.GetType Is GetType(TextBox) Then
                    If cnt.Text = String.Empty Then
                        txtDict.Add(cnt.Name, Nothing)
                    Else
                        txtDict.Add(cnt.Name, cnt.Text)
                    End If

                End If
            Next cnt
        Next
        If DetailView.RadioClient.Checked = True Then
            txtDict.Add("type", "Client")
        ElseIf DetailView.RadioVendor.Checked = True Then
            txtDict.Add("type", "Vendor")
        Else
            txtDict.Add("type", String.Empty)
        End If
        Return txtDict
    End Function

    Public Sub ParseEntity(ByRef Target_Entity As Entity, ByRef Data_Dictionary As Dictionary(Of String, String))
        Target_Entity.Role = Data_Dictionary("type")
        Target_Entity.ID = Data_Dictionary("txtID")
        Target_Entity.Name = Data_Dictionary("txtName")
        Target_Entity.VAT_number = Data_Dictionary("txtVatNo")
        Target_Entity.Street(0) = Data_Dictionary("txtStreet")
        Target_Entity.City(0) = Data_Dictionary("txtCity")
        Target_Entity.ZIP_code(0) = Data_Dictionary("txtZip")
        Target_Entity.Country_code(0) = Data_Dictionary("txtCountry")
        Target_Entity.Bank_account(0) = Data_Dictionary("txtAccount")
        Target_Entity.Bank_code(0) = Data_Dictionary("txtBankCode")
        Target_Entity.Iban(0) = Data_Dictionary("txtIBAN")
        Target_Entity.Bic_code(0) = Data_Dictionary("txtBIC")

        'Dim outputText As String = $"{txtDict("txtID")}; {txtDict("txtName")}; {txtDict("txtVatNo")}; {txtDict("txtStreet")}; {txtDict("txtCity")};_
        '{txtDict("txtZip")}; {txtDict("txtCountry")}; {txtDict("txtAccount")}; {txtDict("txtBankCode")}; {txtDict("txtIBAN")}; {txtDict("txtBIC")}"
    End Sub

    Public Function getProperties(entity As Entity) As Dictionary(Of String, String())
        Dim propDict As New Dictionary(Of String, String())
        Dim compareType() As Reflection.PropertyInfo = entity.GetType().GetProperties()
        For Each prop As Reflection.PropertyInfo In compareType
            Dim propValue(0) As String
            Dim propType As String = prop.PropertyType.Name()
            If Not prop.PropertyType.Name().Equals("String") Then
                propValue = prop.GetValue(entity)
                propDict.Add(prop.Name, propValue)
            Else
                propValue(0) = prop.GetValue(entity)
                propDict.Add(prop.Name, propValue)
            End If
        Next prop
        Return propDict
    End Function
End Module
