<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
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
        Me.rbVendor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbClient = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.folderDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'rbVendor
        '
        Me.rbVendor.AutoSize = True
        Me.rbVendor.Location = New System.Drawing.Point(43, 54)
        Me.rbVendor.Name = "rbVendor"
        Me.rbVendor.Size = New System.Drawing.Size(93, 26)
        Me.rbVendor.TabIndex = 0
        Me.rbVendor.TabStop = True
        Me.rbVendor.Text = "Vendor"
        Me.rbVendor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Entity Type"
        '
        'rbClient
        '
        Me.rbClient.AutoSize = True
        Me.rbClient.Location = New System.Drawing.Point(43, 86)
        Me.rbClient.Name = "rbClient"
        Me.rbClient.Size = New System.Drawing.Size(112, 26)
        Me.rbClient.TabIndex = 0
        Me.rbClient.TabStop = True
        Me.rbClient.Text = "Customer"
        Me.rbClient.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(43, 118)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(55, 26)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(297, 46)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(130, 43)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 101)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 43)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exports all items from the database "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Save Path"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(20, 193)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(254, 28)
        Me.txtFilePath.TabIndex = 5
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(297, 186)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(130, 43)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "Select"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'folderDialog1
        '
        Me.folderDialog1.SelectedPath = "C:\Users"
        '
        'Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 285)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbAll)
        Me.Controls.Add(Me.rbClient)
        Me.Controls.Add(Me.rbVendor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "Export"
        Me.Text = "Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbVendor As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbClient As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents btnExport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents folderDialog1 As FolderBrowserDialog
End Class
