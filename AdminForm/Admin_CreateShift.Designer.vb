﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_CreateShift
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnNurse = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewShift = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbShiftType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCreateShift = New System.Windows.Forms.Button()
        Me.btnAllocate = New System.Windows.Forms.Button()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtshiftName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpDateRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 107)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(29, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shift Sensei"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.Location = New System.Drawing.Point(4, 135)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(214, 69)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSchedule.Location = New System.Drawing.Point(3, 271)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(215, 69)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnNurse
        '
        Me.btnNurse.FlatAppearance.BorderSize = 0
        Me.btnNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNurse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNurse.Location = New System.Drawing.Point(3, 339)
        Me.btnNurse.Name = "btnNurse"
        Me.btnNurse.Size = New System.Drawing.Size(214, 69)
        Me.btnNurse.TabIndex = 4
        Me.btnNurse.Text = "Nurse"
        Me.btnNurse.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProfile.Location = New System.Drawing.Point(2, 475)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(215, 69)
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAccount.Location = New System.Drawing.Point(1, 544)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(217, 69)
        Me.btnAccount.TabIndex = 5
        Me.btnAccount.Text = "Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogOut.Location = New System.Drawing.Point(4, 654)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(214, 40)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btnReport)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnAccount)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnNurse)
        Me.Panel1.Controls.Add(Me.btnSchedule)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-4, -8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 1013)
        Me.Panel1.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReport.Location = New System.Drawing.Point(3, 407)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(215, 69)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreate.Location = New System.Drawing.Point(3, 203)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(214, 69)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create Shift"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnload)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DataGridViewShift)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(945, 305)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Previously created shifts "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(724, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Edit Shift"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnload
        '
        Me.btnload.BackColor = System.Drawing.Color.SteelBlue
        Me.btnload.FlatAppearance.BorderSize = 0
        Me.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnload.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnload.Location = New System.Drawing.Point(482, 35)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(203, 30)
        Me.btnload.TabIndex = 19
        Me.btnload.Text = "Load Shift"
        Me.btnload.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 19)
        Me.Label9.TabIndex = 24
        '
        'DataGridViewShift
        '
        Me.DataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShift.Location = New System.Drawing.Point(38, 75)
        Me.DataGridViewShift.Name = "DataGridViewShift"
        Me.DataGridViewShift.RowHeadersWidth = 51
        Me.DataGridViewShift.Size = New System.Drawing.Size(860, 199)
        Me.DataGridViewShift.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.cmbShiftType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnCreateShift)
        Me.GroupBox1.Controls.Add(Me.btnAllocate)
        Me.GroupBox1.Controls.Add(Me.cmbDepartment)
        Me.GroupBox1.Controls.Add(Me.dtpEndTime)
        Me.GroupBox1.Controls.Add(Me.dtpStartTime)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.txtshiftName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(253, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 301)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shift Details"
        '
        'cmbShiftType
        '
        Me.cmbShiftType.FormattingEnabled = True
        Me.cmbShiftType.Location = New System.Drawing.Point(163, 117)
        Me.cmbShiftType.Name = "cmbShiftType"
        Me.cmbShiftType.Size = New System.Drawing.Size(238, 27)
        Me.cmbShiftType.TabIndex = 18
        Me.cmbShiftType.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Shift Type:"
        '
        'btnCreateShift
        '
        Me.btnCreateShift.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCreateShift.FlatAppearance.BorderSize = 0
        Me.btnCreateShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateShift.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreateShift.Location = New System.Drawing.Point(695, 235)
        Me.btnCreateShift.Name = "btnCreateShift"
        Me.btnCreateShift.Size = New System.Drawing.Size(203, 40)
        Me.btnCreateShift.TabIndex = 16
        Me.btnCreateShift.Text = "Create Shift"
        Me.btnCreateShift.UseVisualStyleBackColor = False
        '
        'btnAllocate
        '
        Me.btnAllocate.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAllocate.FlatAppearance.BorderSize = 0
        Me.btnAllocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllocate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAllocate.Location = New System.Drawing.Point(465, 235)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(203, 40)
        Me.btnAllocate.TabIndex = 15
        Me.btnAllocate.Text = "Allocate Nurse"
        Me.btnAllocate.UseVisualStyleBackColor = False
        '
        'cmbDepartment
        '
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(579, 122)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(284, 27)
        Me.cmbDepartment.TabIndex = 12
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "hh:mm:ss"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(779, 60)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(118, 26)
        Me.dtpEndTime.TabIndex = 11
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "hh:mm:ss"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(550, 60)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(118, 26)
        Me.dtpStartTime.TabIndex = 10
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(165, 234)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(238, 26)
        Me.dtpEndDate.TabIndex = 9
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(165, 175)
        Me.dtpStartDate.MaxDate = New Date(9000, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(238, 26)
        Me.dtpStartDate.TabIndex = 8
        '
        'txtshiftName
        '
        Me.txtshiftName.Location = New System.Drawing.Point(163, 60)
        Me.txtshiftName.Name = "txtshiftName"
        Me.txtshiftName.Size = New System.Drawing.Size(238, 26)
        Me.txtshiftName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Dapartment:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(691, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "End time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Start time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "End Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Shift Name:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowToolStripMenuItem, Me.UpDateRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(140, 48)
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete Row"
        '
        'UpDateRowToolStripMenuItem
        '
        Me.UpDateRowToolStripMenuItem.Name = "UpDateRowToolStripMenuItem"
        Me.UpDateRowToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.UpDateRowToolStripMenuItem.Text = "UpDate Row"
        '
        'Admin_CreateShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_CreateShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnNurse As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewShift As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAllocate As Button
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents txtshiftName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateShift As Button
    Friend WithEvents cmbShiftType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpDateRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnload As Button
    Friend WithEvents Button1 As Button
End Class
