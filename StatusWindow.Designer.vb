<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatusWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblStatusBar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStatusBar
        '
        Me.lblStatusBar.AutoSize = True
        Me.lblStatusBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblStatusBar.Location = New System.Drawing.Point(12, 29)
        Me.lblStatusBar.Name = "lblStatusBar"
        Me.lblStatusBar.Size = New System.Drawing.Size(0, 25)
        Me.lblStatusBar.TabIndex = 0
        '
        'StatusWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(176, 0)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatusBar)
        Me.Enabled = False
        Me.Name = "StatusWindow"
        Me.Text = "Importing"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatusBar As Label
End Class
