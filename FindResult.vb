Public Class FindResult
    Public SelectedEntityID As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click, btnUpdate.Click
        'Get entity ID from search DB results. The results are passed to Data Grid for user to select and the code below reads row selected by the user and passes selected entity ID.
        If dgvSearchResult.SelectedRows.Count = 0 Then
            MessageBox.Show("No data to display, selection empty. Select entire non-empty row to continue", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnClose.Focus()
            Return
        End If

        If dgvSearchResult.SelectedRows.Item(0).Cells.Item(0).Value Is Nothing Then
            MessageBox.Show("No data to display, selection empty. Select entire non-empty row to continue", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnClose.Focus()
            Return
        End If
        SelectedEntityID = dgvSearchResult.SelectedRows.Item(0).Cells.Item(0).Value.ToString


        'Instantiate new entity with selected ID and populate with details from database
        Dim SelectEntity = New Entity()
        SelectEntity.LoadDetails(SelectedEntityID)

        'Show details in separate form (DetailView)
        DetailView.Text = "Detail View, ID: " & SelectEntity.ID
        DetailView.lblRole.Text = SelectEntity.Role & ":"
        DetailView.txtID.Text = SelectEntity.ID
        DetailView.txtName.Text = SelectEntity.Name
        DetailView.txtVatNo.Text = SelectEntity.VAT_number
        If SelectEntity.Role = "Vendor" Then DetailView.RadioVendor.Checked = True Else DetailView.RadioClient.Checked = True

        'Show addresses
        'Slider to move around multiple adresses
        DetailView.hsbAddress.Maximum = SelectEntity.City.Length - 1
        Dim addressIndex As Integer = DetailView.hsbAddress.Value()

        'Show address
        DetailView.txtStreet.Text = SelectEntity.Street(addressIndex)
        DetailView.txtCity.Text = SelectEntity.City(addressIndex)
        DetailView.txtZip.Text = SelectEntity.ZIP_code(addressIndex)
        DetailView.txtCountry.Text = SelectEntity.Country_code(addressIndex)

        'Show Bank details
        'Slider to move around multiple adresses
        DetailView.hsbBank.Maximum = SelectEntity.Iban.Length - 1
        Dim bankIndex As Integer = DetailView.hsbBank.Value()
        'Show address
        DetailView.txtAccount.Text = SelectEntity.Bank_account(bankIndex)
        DetailView.txtBankCode.Text = SelectEntity.Bank_code(bankIndex)
        DetailView.txtIBAN.Text = SelectEntity.Iban(bankIndex)
        DetailView.txtBIC.Text = SelectEntity.Bic_code(bankIndex)

        'Hide Update button if comming from "Show details" button
        If sender.Equals(Me.btnDetail) Then
            DetailView.btnSave.Hide()
        End If
        DetailView.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Get entity ID from search DB results. The results are passed to Data Grid for user to select and the code below reads row selected by the user and passes selected entity ID.
        If dgvSearchResult.SelectedRows.Count = 0 Then
            MessageBox.Show("No data to be deleted selected. Select entire non-empty row to continue", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnClose.Focus()
            Return
        End If

        If dgvSearchResult.SelectedRows.Item(0).Cells.Item(0).Value Is Nothing Then
            MessageBox.Show("No data to be deleted selected. Select entire non-empty row to continue", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnClose.Focus()
            Return
        End If
        Dim DeleteEntity As New Entity
        DeleteEntity.ID = dgvSearchResult.SelectedRows.Item(0).Cells.Item(0).Value.ToString
        DeleteEntity.Name = dgvSearchResult.SelectedRows.Item(0).Cells.Item(1).Value.ToString
        DeleteEntity.Role = dgvSearchResult.SelectedRows.Item(0).Cells.Item(3).Value.ToString

        'Confirm selection
        'Confirm Delete action
        Dim decision As DialogResult = MessageBox.Show($"Do you wish to permanently delete {DeleteEntity.Role} No: {DeleteEntity.ID}, {DeleteEntity.Name} from database?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If decision <> 6 Then Return

        'Delete from Db
        DeleteEntityByID(DeleteEntity.ID)

        'clear form at selected row
        ClearFindResultForm()


    End Sub
End Class