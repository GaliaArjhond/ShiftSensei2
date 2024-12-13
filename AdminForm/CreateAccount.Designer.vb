<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.dtpDateOfBIrth = New System.Windows.Forms.DateTimePicker()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbExp = New System.Windows.Forms.ComboBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmbSQ = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-17, -12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 93)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(340, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfBIrth)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.txtMname)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 514)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(32, 427)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(268, 22)
        Me.txtaddress.TabIndex = 19
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(32, 370)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(268, 22)
        Me.txtphone.TabIndex = 18
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(32, 313)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(268, 22)
        Me.txtemail.TabIndex = 17
        '
        'dtpDateOfBIrth
        '
        Me.dtpDateOfBIrth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfBIrth.Location = New System.Drawing.Point(32, 254)
        Me.dtpDateOfBIrth.MaxDate = New Date(9000, 12, 31, 0, 0, 0, 0)
        Me.dtpDateOfBIrth.Name = "dtpDateOfBIrth"
        Me.dtpDateOfBIrth.Size = New System.Drawing.Size(268, 22)
        Me.dtpDateOfBIrth.TabIndex = 16
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(32, 182)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(268, 22)
        Me.txtLname.TabIndex = 15
        '
        'txtMname
        '
        Me.txtMname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(32, 124)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(268, 22)
        Me.txtMname.TabIndex = 14
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(32, 67)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(268, 22)
        Me.txtFname.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Last Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Middle Name:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(29, 230)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(91, 16)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Date of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbExp)
        Me.GroupBox2.Controls.Add(Me.cmbPosition)
        Me.GroupBox2.Controls.Add(Me.cmbDepartment)
        Me.GroupBox2.Controls.Add(Me.txtLicense)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 646)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 291)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Professional Info"
        '
        'cmbExp
        '
        Me.cmbExp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExp.FormattingEnabled = True
        Me.cmbExp.Location = New System.Drawing.Point(32, 182)
        Me.cmbExp.Name = "cmbExp"
        Me.cmbExp.Size = New System.Drawing.Size(273, 24)
        Me.cmbExp.TabIndex = 23
        '
        'cmbPosition
        '
        Me.cmbPosition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Location = New System.Drawing.Point(32, 124)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(273, 24)
        Me.cmbPosition.TabIndex = 22
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"--Select Department--"})
        Me.cmbDepartment.Location = New System.Drawing.Point(32, 67)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(273, 24)
        Me.cmbDepartment.TabIndex = 21
        '
        'txtLicense
        '
        Me.txtLicense.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicense.Location = New System.Drawing.Point(32, 240)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(273, 22)
        Me.txtLicense.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 16)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "License Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Experience:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Position:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Department:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtpassword)
        Me.GroupBox4.Controls.Add(Me.txtAnswer)
        Me.GroupBox4.Controls.Add(Me.cmbSQ)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(406, 646)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 216)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Security"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(27, 170)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(273, 22)
        Me.txtpassword.TabIndex = 20
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(27, 117)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(273, 22)
        Me.txtAnswer.TabIndex = 19
        '
        'cmbSQ
        '
        Me.cmbSQ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSQ.FormattingEnabled = True
        Me.cmbSQ.Location = New System.Drawing.Point(27, 62)
        Me.cmbSQ.Name = "cmbSQ"
        Me.cmbSQ.Size = New System.Drawing.Size(273, 24)
        Me.cmbSQ.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Password:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Answer:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Security Question:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpEndTime)
        Me.GroupBox3.Controls.Add(Me.dtpStartTime)
        Me.GroupBox3.Controls.Add(Me.dtpEndDate)
        Me.GroupBox3.Controls.Add(Me.dtpStartDate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(406, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 514)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Availability"
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "hh:mm:ss" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.dtpEndTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(34, 301)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(100, 22)
        Me.dtpEndTime.TabIndex = 23
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "hh:mm:ss"
        Me.dtpStartTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(32, 225)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(100, 22)
        Me.dtpStartTime.TabIndex = 22
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Location = New System.Drawing.Point(30, 142)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(153, 22)
        Me.dtpEndDate.TabIndex = 21
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Location = New System.Drawing.Point(30, 65)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(153, 22)
        Me.dtpStartDate.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Start Time:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "End Time:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "End Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Start Date:"
        '
        'btncreate
        '
        Me.btncreate.Location = New System.Drawing.Point(36, 958)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(233, 68)
        Me.btncreate.TabIndex = 33
        Me.btncreate.Text = "Create Account"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(549, 958)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(199, 68)
        Me.btnback.TabIndex = 34
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(814, 653)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents dtpDateOfBIrth As DateTimePicker
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents cmbSQ As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLicense As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btncreate As Button
    Friend WithEvents btnback As Button
    Friend WithEvents cmbExp As ComboBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
End Class
