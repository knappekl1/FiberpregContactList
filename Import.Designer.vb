<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOpenFile = New System.Windows.Forms.Button()
        Me.ofDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtVAT_number = New System.Windows.Forms.TextBox()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZIP_code = New System.Windows.Forms.TextBox()
        Me.txtCountry_code = New System.Windows.Forms.TextBox()
        Me.txtBank_account = New System.Windows.Forms.TextBox()
        Me.txtBank_code = New System.Windows.Forms.TextBox()
        Me.txtIban = New System.Windows.Forms.TextBox()
        Me.txtBic_code = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entity ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(136, 44)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(273, 28)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "GP-Code"
        '
        'txtOpenFile
        '
        Me.txtOpenFile.Location = New System.Drawing.Point(690, 36)
        Me.txtOpenFile.Name = "txtOpenFile"
        Me.txtOpenFile.Size = New System.Drawing.Size(135, 42)
        Me.txtOpenFile.TabIndex = 2
        Me.txtOpenFile.Text = "Select File"
        Me.txtOpenFile.UseVisualStyleBackColor = True
        '
        'ofDialog1
        '
        Me.ofDialog1.InitialDirectory = "C:\Users"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VAT No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Type*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Street"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ZIP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Country"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Account No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bank Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "IBAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "BIC Code"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(136, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 28)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "GP-Name"
        '
        'txtVAT_number
        '
        Me.txtVAT_number.Location = New System.Drawing.Point(136, 119)
        Me.txtVAT_number.Name = "txtVAT_number"
        Me.txtVAT_number.Size = New System.Drawing.Size(273, 28)
        Me.txtVAT_number.TabIndex = 1
        Me.txtVAT_number.Text = "UID-Nummer"
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(136, 156)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(273, 28)
        Me.txtRole.TabIndex = 1
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(136, 193)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(273, 28)
        Me.txtStreet.TabIndex = 1
        Me.txtStreet.Text = "Straße Rechnungsadresse"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(136, 231)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(273, 28)
        Me.txtCity.TabIndex = 1
        Me.txtCity.Text = "Ort Rechnungsadresse"
        '
        'txtZIP_code
        '
        Me.txtZIP_code.Location = New System.Drawing.Point(136, 268)
        Me.txtZIP_code.Name = "txtZIP_code"
        Me.txtZIP_code.Size = New System.Drawing.Size(273, 28)
        Me.txtZIP_code.TabIndex = 1
        Me.txtZIP_code.Text = "PLZ Rechnungsadresse"
        '
        'txtCountry_code
        '
        Me.txtCountry_code.Location = New System.Drawing.Point(136, 306)
        Me.txtCountry_code.Name = "txtCountry_code"
        Me.txtCountry_code.Size = New System.Drawing.Size(273, 28)
        Me.txtCountry_code.TabIndex = 1
        Me.txtCountry_code.Text = "Land Rechnungsadresse"
        '
        'txtBank_account
        '
        Me.txtBank_account.Location = New System.Drawing.Point(136, 343)
        Me.txtBank_account.Name = "txtBank_account"
        Me.txtBank_account.Size = New System.Drawing.Size(273, 28)
        Me.txtBank_account.TabIndex = 1
        Me.txtBank_account.Text = "Standardkonto"
        '
        'txtBank_code
        '
        Me.txtBank_code.Location = New System.Drawing.Point(136, 380)
        Me.txtBank_code.Name = "txtBank_code"
        Me.txtBank_code.Size = New System.Drawing.Size(273, 28)
        Me.txtBank_code.TabIndex = 1
        Me.txtBank_code.Text = "Hausbank"
        '
        'txtIban
        '
        Me.txtIban.Location = New System.Drawing.Point(136, 418)
        Me.txtIban.Name = "txtIban"
        Me.txtIban.Size = New System.Drawing.Size(273, 28)
        Me.txtIban.TabIndex = 1
        Me.txtIban.Text = "Standard-IBAN der Bank"
        '
        'txtBic_code
        '
        Me.txtBic_code.Location = New System.Drawing.Point(136, 455)
        Me.txtBic_code.Name = "txtBic_code"
        Me.txtBic_code.Size = New System.Drawing.Size(273, 28)
        Me.txtBic_code.TabIndex = 1
        Me.txtBic_code.Text = "Standardbank BIC/SWIFT-Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 22)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Table Column Names"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(450, 43)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(234, 28)
        Me.txtFilePath.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(446, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Import From"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(690, 374)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(135, 42)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(690, 429)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 42)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(519, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 22)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Separator"
        '
        'txtSeparator
        '
        Me.txtSeparator.Location = New System.Drawing.Point(614, 101)
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(70, 28)
        Me.txtSeparator.TabIndex = 1
        Me.txtSeparator.Text = ";"
        '
        'Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 525)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtOpenFile)
        Me.Controls.Add(Me.txtBic_code)
        Me.Controls.Add(Me.txtIban)
        Me.Controls.Add(Me.txtBank_code)
        Me.Controls.Add(Me.txtBank_account)
        Me.Controls.Add(Me.txtCountry_code)
        Me.Controls.Add(Me.txtZIP_code)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.txtVAT_number)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSeparator)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MinimumSize = New System.Drawing.Size(886, 581)
        Me.Name = "Import"
        Me.Text = "Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtOpenFile As Button
    Friend WithEvents ofDialog1 As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtVAT_number As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZIP_code As TextBox
    Friend WithEvents txtCountry_code As TextBox
    Friend WithEvents txtBank_account As TextBox
    Friend WithEvents txtBank_code As TextBox
    Friend WithEvents txtIban As TextBox
    Friend WithEvents txtBic_code As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSeparator As TextBox
End Class
