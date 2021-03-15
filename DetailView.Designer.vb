<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailView
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.pnlBase = New System.Windows.Forms.Panel()
        Me.pnlType = New System.Windows.Forms.Panel()
        Me.RadioVendor = New System.Windows.Forms.RadioButton()
        Me.RadioClient = New System.Windows.Forms.RadioButton()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVatNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlAddress = New System.Windows.Forms.Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.hsbAddress = New System.Windows.Forms.HScrollBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlBank = New System.Windows.Forms.Panel()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtBIC = New System.Windows.Forms.TextBox()
        Me.txtIBAN = New System.Windows.Forms.TextBox()
        Me.txtBankCode = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.hsbBank = New System.Windows.Forms.HScrollBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.pnlBase.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.pnlAddress.SuspendLayout()
        Me.pnlBank.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(459, 591)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 48)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Number:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(115, 39)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(264, 28)
        Me.txtID.TabIndex = 2
        '
        'pnlBase
        '
        Me.pnlBase.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlBase.Controls.Add(Me.pnlType)
        Me.pnlBase.Controls.Add(Me.lblRole)
        Me.pnlBase.Controls.Add(Me.Label3)
        Me.pnlBase.Controls.Add(Me.txtVatNo)
        Me.pnlBase.Controls.Add(Me.Label2)
        Me.pnlBase.Controls.Add(Me.txtName)
        Me.pnlBase.Controls.Add(Me.Label1)
        Me.pnlBase.Controls.Add(Me.txtID)
        Me.pnlBase.Location = New System.Drawing.Point(13, 13)
        Me.pnlBase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBase.Name = "pnlBase"
        Me.pnlBase.Size = New System.Drawing.Size(400, 212)
        Me.pnlBase.TabIndex = 3
        '
        'pnlType
        '
        Me.pnlType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlType.Controls.Add(Me.RadioVendor)
        Me.pnlType.Controls.Add(Me.RadioClient)
        Me.pnlType.Location = New System.Drawing.Point(115, 162)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(267, 32)
        Me.pnlType.TabIndex = 4
        '
        'RadioVendor
        '
        Me.RadioVendor.AutoSize = True
        Me.RadioVendor.Location = New System.Drawing.Point(17, 3)
        Me.RadioVendor.Name = "RadioVendor"
        Me.RadioVendor.Size = New System.Drawing.Size(93, 26)
        Me.RadioVendor.TabIndex = 3
        Me.RadioVendor.TabStop = True
        Me.RadioVendor.Text = "Vendor"
        Me.RadioVendor.UseVisualStyleBackColor = True
        '
        'RadioClient
        '
        Me.RadioClient.AutoSize = True
        Me.RadioClient.Location = New System.Drawing.Point(116, 3)
        Me.RadioClient.Name = "RadioClient"
        Me.RadioClient.Size = New System.Drawing.Size(81, 26)
        Me.RadioClient.TabIndex = 3
        Me.RadioClient.TabStop = True
        Me.RadioClient.Text = "Client"
        Me.RadioClient.UseVisualStyleBackColor = True
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRole.Location = New System.Drawing.Point(13, 12)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(51, 25)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Role"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "VAT Number:"
        '
        'txtVatNo
        '
        Me.txtVatNo.Location = New System.Drawing.Point(115, 127)
        Me.txtVatNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVatNo.Name = "txtVatNo"
        Me.txtVatNo.Size = New System.Drawing.Size(264, 28)
        Me.txtVatNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(115, 73)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(264, 46)
        Me.txtName.TabIndex = 2
        '
        'pnlAddress
        '
        Me.pnlAddress.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlAddress.Controls.Add(Me.lblAddress)
        Me.pnlAddress.Controls.Add(Me.txtCountry)
        Me.pnlAddress.Controls.Add(Me.txtZip)
        Me.pnlAddress.Controls.Add(Me.txtCity)
        Me.pnlAddress.Controls.Add(Me.txtStreet)
        Me.pnlAddress.Controls.Add(Me.hsbAddress)
        Me.pnlAddress.Controls.Add(Me.Label7)
        Me.pnlAddress.Controls.Add(Me.Label6)
        Me.pnlAddress.Controls.Add(Me.Label5)
        Me.pnlAddress.Controls.Add(Me.Label4)
        Me.pnlAddress.Location = New System.Drawing.Point(13, 244)
        Me.pnlAddress.Name = "pnlAddress"
        Me.pnlAddress.Size = New System.Drawing.Size(400, 184)
        Me.pnlAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(7, 9)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(85, 25)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(115, 141)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(264, 28)
        Me.txtCountry.TabIndex = 2
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(115, 108)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(264, 28)
        Me.txtZip.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(115, 75)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(264, 28)
        Me.txtCity.TabIndex = 2
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(115, 42)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(264, 28)
        Me.txtStreet.TabIndex = 2
        '
        'hsbAddress
        '
        Me.hsbAddress.LargeChange = 1
        Me.hsbAddress.Location = New System.Drawing.Point(286, 9)
        Me.hsbAddress.Maximum = 1
        Me.hsbAddress.Name = "hsbAddress"
        Me.hsbAddress.Size = New System.Drawing.Size(96, 15)
        Me.hsbAddress.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Street"
        '
        'pnlBank
        '
        Me.pnlBank.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlBank.Controls.Add(Me.lblBank)
        Me.pnlBank.Controls.Add(Me.txtBIC)
        Me.pnlBank.Controls.Add(Me.txtIBAN)
        Me.pnlBank.Controls.Add(Me.txtBankCode)
        Me.pnlBank.Controls.Add(Me.txtAccount)
        Me.pnlBank.Controls.Add(Me.hsbBank)
        Me.pnlBank.Controls.Add(Me.Label8)
        Me.pnlBank.Controls.Add(Me.Label9)
        Me.pnlBank.Controls.Add(Me.Label14)
        Me.pnlBank.Controls.Add(Me.Label10)
        Me.pnlBank.Controls.Add(Me.Label11)
        Me.pnlBank.Location = New System.Drawing.Point(12, 458)
        Me.pnlBank.Name = "pnlBank"
        Me.pnlBank.Size = New System.Drawing.Size(400, 184)
        Me.pnlBank.TabIndex = 4
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBank.Location = New System.Drawing.Point(8, 11)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(134, 25)
        Me.lblBank.TabIndex = 3
        Me.lblBank.Text = "Bank Account"
        '
        'txtBIC
        '
        Me.txtBIC.Location = New System.Drawing.Point(115, 141)
        Me.txtBIC.Name = "txtBIC"
        Me.txtBIC.Size = New System.Drawing.Size(264, 28)
        Me.txtBIC.TabIndex = 2
        '
        'txtIBAN
        '
        Me.txtIBAN.Location = New System.Drawing.Point(115, 108)
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.Size = New System.Drawing.Size(264, 28)
        Me.txtIBAN.TabIndex = 2
        '
        'txtBankCode
        '
        Me.txtBankCode.Location = New System.Drawing.Point(115, 75)
        Me.txtBankCode.Name = "txtBankCode"
        Me.txtBankCode.Size = New System.Drawing.Size(264, 28)
        Me.txtBankCode.TabIndex = 2
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(115, 42)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(264, 28)
        Me.txtAccount.TabIndex = 2
        '
        'hsbBank
        '
        Me.hsbBank.LargeChange = 1
        Me.hsbBank.Location = New System.Drawing.Point(287, 11)
        Me.hsbBank.Maximum = 1
        Me.hsbBank.Name = "hsbBank"
        Me.hsbBank.Size = New System.Drawing.Size(96, 15)
        Me.hsbBank.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "BIC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "IBAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Account No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bank Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 22)
        Me.Label11.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(459, 477)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 51)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(459, 534)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 50)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Location = New System.Drawing.Point(459, 14)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(144, 49)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "Copy to Clpbrd"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'DetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 651)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlBank)
        Me.Controls.Add(Me.pnlAddress)
        Me.Controls.Add(Me.pnlBase)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DetailView"
        Me.Text = "Detail View"
        Me.pnlBase.ResumeLayout(False)
        Me.pnlBase.PerformLayout()
        Me.pnlType.ResumeLayout(False)
        Me.pnlType.PerformLayout()
        Me.pnlAddress.ResumeLayout(False)
        Me.pnlAddress.PerformLayout()
        Me.pnlBank.ResumeLayout(False)
        Me.pnlBank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents pnlBase As Panel
    Friend WithEvents lblRole As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVatNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents RadioVendor As RadioButton
    Friend WithEvents RadioClient As RadioButton
    Friend WithEvents pnlType As Panel
    Friend WithEvents pnlAddress As Panel
    Friend WithEvents hsbAddress As HScrollBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents pnlBank As Panel
    Friend WithEvents lblBank As Label
    Friend WithEvents txtBIC As TextBox
    Friend WithEvents txtIBAN As TextBox
    Friend WithEvents txtBankCode As TextBox
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents hsbBank As HScrollBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCopy As Button
End Class
