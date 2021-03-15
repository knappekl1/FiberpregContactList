Public Class Entity
    'Declare inside property variables
    Private _street(0) As String
    Private _city(0) As String
    Private _zip_code(0) As String
    Private _country_code(0) As String
    Private _bank_account(0) As String
    Private _bank_code(0) As String
    Private _iban(0) As String
    Private _bic_code(0) As String

    'Auto Implement simple properties
    Public Property ID As String
    Public Property Name As String
    Public Property VAT_number As String
    Public Property Role As String
    'Implement array properties (autoimplement cannot declare length)
    Public Property Street As String()
        Get
            Return _street
        End Get
        Set(value As String())
            _street = Street
        End Set
    End Property
    Public Property City As String()
        Get
            Return _city
        End Get
        Set(value As String())
            _city = City
        End Set
    End Property
    Public Property ZIP_code As String()
        Get
            Return _zip_code
        End Get
        Set(value As String())
            _zip_code = ZIP_code
        End Set
    End Property
    Public Property Country_code As String()
        Get
            Return _country_code
        End Get
        Set(value As String())
            _country_code = Country_code
        End Set
    End Property
    Public Property Bank_account As String()
        Get
            Return _bank_account
        End Get
        Set(value As String())
            _bank_account = Bank_account
        End Set
    End Property
    Public Property Bank_code As String()
        Get
            Return _bank_code
        End Get
        Set(value As String())
            _bank_code = Bank_code
        End Set
    End Property
    Public Property Iban As String()
        Get
            Return _iban
        End Get
        Set(value As String())
            _iban = Iban
        End Set
    End Property
    Public Property Bic_code As String()
        Get
            Return _bic_code
        End Get
        Set(value As String())
            _bic_code = Bic_code
        End Set
    End Property
    Public Sub LoadDetails(ID_number As String)
        'Set property ID
        ID = ID_number
        'Get all data from DB
        Dim query As String = "SELECT * FROM select_all WHERE entity_id = '" & ID_number & "'"
        Dim result As DataTable = GetEntity(query)

        'Parse results into properties
        Dim counter As Integer = 0
        For Each row As DataRow In result.Rows
            'Assign base entity data to properties
            Name = row.Item("entity_name").ToString
            If Not IsDBNull(row.Item("vat_number")) Then VAT_number = row.Item("vat_number") Else VAT_number = String.Empty
            If Not IsDBNull(row.Item("entity_role")) Then Role = row.Item("entity_role") Else Role = String.Empty

            'Get extended data (address, bank)
            'Assign street from db to property
            ReDim Street(counter)
            If Not IsDBNull(row.Item("street")) Then
                Street(counter) = row.Item("street")
            Else
                Street(counter) = String.Empty
            End If

            'Assign city
            ReDim City(counter)
            If Not IsDBNull(row.Item("city")) Then
                City(counter) = row.Item("city")
            Else
                City(counter) = String.Empty
            End If

            'Assign Zip code
            ReDim ZIP_code(counter)
            If Not IsDBNull(row.Item("zip_code")) Then
                ZIP_code(counter) = row.Item("zip_code")
            Else
                ZIP_code(counter) = String.Empty
            End If

            'Assign Country Code
            ReDim Country_code(counter)
            If Not IsDBNull(row.Item("country")) Then
                Country_code(counter) = row.Item("country")
            Else
                Country_code(counter) = String.Empty
            End If

            'assign Bank_account
            ReDim Bank_account(counter)
            If Not IsDBNull(row.Item("account_number")) Then
                Bank_account(counter) = row.Item("account_number")
            Else
                Bank_account(counter) = String.Empty
            End If

            'Assign Bank Code
            ReDim Bank_code(counter)
            If Not IsDBNull(row.Item("bank_code")) Then
                Bank_code(counter) = row.Item("bank_code")
            Else
                Bank_code(counter) = String.Empty
            End If

            'Assign IBAN
            ReDim Iban(counter)
            If Not IsDBNull(row.Item("iban_code")) Then
                Iban(counter) = row.Item("iban_code")
            Else
                Iban(counter) = String.Empty
            End If

            'Assign BIC
            ReDim Bic_code(counter)
            If Not IsDBNull(row.Item("bic_code")) Then
                Bic_code(counter) = row.Item("bic_code")
            Else
                Bic_code(counter) = String.Empty
            End If
            counter += 1
        Next row

    End Sub

    Public Sub SaveDetails()

    End Sub

End Class
