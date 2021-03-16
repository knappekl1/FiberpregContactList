Public Class LandingForm
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'declarations
        Dim EntityNumberInput As String = txtNumber.Text
        Dim EntityNameInput As String = txtName.Text
        Dim EntityNumberConvert As Integer
        Dim QueryParam As String

        'check inputs
        'Check if either number or name present and output to variable
        If EntityNameInput = String.Empty And EntityNumberInput = String.Empty Then
            MessageBox.Show("No input to be searched for, please add name or number", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumber.Focus()
            Return
        ElseIf EntityNameInput <> String.Empty And EntityNumberInput = String.Empty Then
            QueryParam = EntityNameInput
        Else
            If Not Integer.TryParse(EntityNumberInput.Replace(" ", "").Trim, EntityNumberConvert) Then
                MessageBox.Show("Not a valid number please check your input", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtName.Focus()
                Return
            End If
            QueryParam = EntityNumberInput
        End If
        Console.WriteLine(QueryParam)

        'Get data from DB
        Dim queryString As String = "SELECT * FROM entity WHERE COALESCE(entity_id:: VARCHAR,'')||COALESCE(entity_name,'')||COALESCE(vat_number,'') ILIKE '%'||'" & QueryParam & "'||'%';"
        Dim result As DataTable = GetEntity(queryString)
        'Rename Columns for reading convenience
        result.Columns(0).ColumnName = "Entity ID"
        result.Columns(1).ColumnName = "Name"
        result.Columns(2).ColumnName = "VAT Number"
        result.Columns(3).ColumnName = "Role"

        'Show result in form, datagrid view
        FindResult.dgvSearchResult.DataSource = result
        FindResult.Show()

    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        DetailView.Show()

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Export.Show()
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        MessageBox.Show("Not implemented yet. Manual imports needed. Call me.")
    End Sub
End Class
