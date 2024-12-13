<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Dashboard
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.NurseAvailabilityChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbltotalUnassigned = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbltotalActive = New System.Windows.Forms.Label()
        Me.labell = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblnurseAssigned = New System.Windows.Forms.Label()
        Me.lable = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalNurse = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.DataGridViewShift = New System.Windows.Forms.DataGridView()
        CType(Me.NurseAvailabilityChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NurseAvailabilityChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.NurseAvailabilityChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.NurseAvailabilityChart.Legends.Add(Legend3)
        Me.NurseAvailabilityChart.Location = New System.Drawing.Point(241, 42)
        Me.NurseAvailabilityChart.Name = "NurseAvailabilityChart"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.NurseAvailabilityChart.Series.Add(Series3)
        Me.NurseAvailabilityChart.Size = New System.Drawing.Size(367, 267)
        Me.NurseAvailabilityChart.TabIndex = 10
        Me.NurseAvailabilityChart.Text = "Chart2"
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(241, 334)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(367, 271)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Controls.Add(Me.lbltotalUnassigned)
        Me.Panel6.Controls.Add(Me.label)
        Me.Panel6.Location = New System.Drawing.Point(962, 185)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(223, 124)
        Me.Panel6.TabIndex = 6
        '
        'lbltotalUnassigned
        '
        Me.lbltotalUnassigned.AutoSize = True
        Me.lbltotalUnassigned.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalUnassigned.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotalUnassigned.Location = New System.Drawing.Point(94, 28)
        Me.lbltotalUnassigned.Name = "lbltotalUnassigned"
        Me.lbltotalUnassigned.Size = New System.Drawing.Size(30, 32)
        Me.lbltotalUnassigned.TabIndex = 7
        Me.lbltotalUnassigned.Text = "0"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label.Location = New System.Drawing.Point(51, 76)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(118, 24)
        Me.label.TabIndex = 6
        Me.label.Text = "Total Open"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.lbltotalActive)
        Me.Panel5.Controls.Add(Me.labell)
        Me.Panel5.Location = New System.Drawing.Point(703, 185)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(223, 124)
        Me.Panel5.TabIndex = 7
        '
        'lbltotalActive
        '
        Me.lbltotalActive.AutoSize = True
        Me.lbltotalActive.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalActive.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotalActive.Location = New System.Drawing.Point(100, 28)
        Me.lbltotalActive.Name = "lbltotalActive"
        Me.lbltotalActive.Size = New System.Drawing.Size(30, 32)
        Me.lbltotalActive.TabIndex = 6
        Me.lbltotalActive.Text = "0"
        '
        'labell
        '
        Me.labell.AutoSize = True
        Me.labell.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labell.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labell.Location = New System.Drawing.Point(17, 76)
        Me.labell.Name = "labell"
        Me.labell.Size = New System.Drawing.Size(192, 24)
        Me.labell.TabIndex = 5
        Me.labell.Text = "Total Active Nurse"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Controls.Add(Me.lblnurseAssigned)
        Me.Panel4.Controls.Add(Me.lable)
        Me.Panel4.Location = New System.Drawing.Point(962, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 124)
        Me.Panel4.TabIndex = 8
        '
        'lblnurseAssigned
        '
        Me.lblnurseAssigned.AutoSize = True
        Me.lblnurseAssigned.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnurseAssigned.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblnurseAssigned.Location = New System.Drawing.Point(95, 28)
        Me.lblnurseAssigned.Name = "lblnurseAssigned"
        Me.lblnurseAssigned.Size = New System.Drawing.Size(30, 32)
        Me.lblnurseAssigned.TabIndex = 5
        Me.lblnurseAssigned.Text = "0"
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lable.Location = New System.Drawing.Point(10, 76)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(207, 24)
        Me.lable.TabIndex = 4
        Me.lable.Text = "Total Nurse on Duty"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.lblTotalNurse)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(703, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 124)
        Me.Panel3.TabIndex = 5
        '
        'lblTotalNurse
        '
        Me.lblTotalNurse.AutoSize = True
        Me.lblTotalNurse.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNurse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalNurse.Location = New System.Drawing.Point(95, 28)
        Me.lblTotalNurse.Name = "lblTotalNurse"
        Me.lblTotalNurse.Size = New System.Drawing.Size(30, 32)
        Me.lblTotalNurse.TabIndex = 4
        Me.lblTotalNurse.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(52, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Nurse"
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
        'DataGridViewShift
        '
        Me.DataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShift.Location = New System.Drawing.Point(638, 334)
        Me.DataGridViewShift.Name = "DataGridViewShift"
        Me.DataGridViewShift.Size = New System.Drawing.Size(564, 271)
        Me.DataGridViewShift.TabIndex = 11
        '
        'Admin_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.Controls.Add(Me.DataGridViewShift)
        Me.Controls.Add(Me.NurseAvailabilityChart)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.NurseAvailabilityChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NurseAvailabilityChart As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbltotalUnassigned As Label
    Friend WithEvents label As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbltotalActive As Label
    Friend WithEvents labell As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblnurseAssigned As Label
    Friend WithEvents lable As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotalNurse As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents DataGridViewShift As DataGridView
End Class
