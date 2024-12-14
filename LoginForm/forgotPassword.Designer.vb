<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPassword
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLicenseNumber = New System.Windows.Forms.TextBox()
        Me.lblSecurityQuestion = New System.Windows.Forms.Label()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnewPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(41, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scheduling System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(79, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shift Sensei: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 561)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(631, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Forgot Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "License Number:"
        '
        'txtLicenseNumber
        '
        Me.txtLicenseNumber.Location = New System.Drawing.Point(459, 163)
        Me.txtLicenseNumber.Name = "txtLicenseNumber"
        Me.txtLicenseNumber.Size = New System.Drawing.Size(464, 26)
        Me.txtLicenseNumber.TabIndex = 4
        '
        'lblSecurityQuestion
        '
        Me.lblSecurityQuestion.AutoSize = True
        Me.lblSecurityQuestion.Location = New System.Drawing.Point(455, 222)
        Me.lblSecurityQuestion.Name = "lblSecurityQuestion"
        Me.lblSecurityQuestion.Size = New System.Drawing.Size(151, 19)
        Me.lblSecurityQuestion.TabIndex = 5
        Me.lblSecurityQuestion.Text = "Security Question:"
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(459, 342)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(464, 26)
        Me.txtanswer.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(455, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Answer:"
        '
        'txtnewPass
        '
        Me.txtnewPass.Location = New System.Drawing.Point(459, 439)
        Me.txtnewPass.Name = "txtnewPass"
        Me.txtnewPass.Size = New System.Drawing.Size(464, 26)
        Me.txtnewPass.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(455, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "New Password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(763, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(459, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 27)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Retrieve Question"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'forgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnewPass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSecurityQuestion)
        Me.Controls.Add(Me.txtLicenseNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "forgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents txtanswer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnewPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
