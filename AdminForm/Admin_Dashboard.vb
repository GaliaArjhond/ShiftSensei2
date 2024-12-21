Imports MySql.Data.MySqlClient
Public Class Admin_Dashboard
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim query As String
    Dim available, unavailable As Integer
    Dim reader As MySqlDataReader
    Dim totalNurses, unassignedNurses, assignedNurses, totalMorning, totalEvening, totalNight As Integer
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Admin_CreateShift.Show()
        Me.Hide()

    End Sub
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Nurse_Schedule.Show()
        Me.Hide()

    End Sub
    Private Sub btnNurse_Click(sender As Object, e As EventArgs) Handles btnNurse.Click
        Admin_Nurse.Show()
        Me.Hide()

    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Admin_Report.Show()
        Me.Hide()

    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Admin_Profile.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Admin_Account1.Show()
        Me.Hide()

    End Sub

    Private Sub totalNurse()
        Try
            query = "SELECT COUNT(*) FROM nurse"
            cmd = New MySqlCommand(query, datacon)
            totalNurses = Convert.ToInt32(cmd.ExecuteScalar())

            query = "SELECT COUNT(*) FROM nurse WHERE shiftTypeId = 1"
            cmd = New MySqlCommand(query, datacon)
            assignedNurses = Convert.ToInt32(cmd.ExecuteScalar())

            query = "SELECT COUNT(*) FROM nurse WHERE shiftTypeId = 2"
            cmd = New MySqlCommand(query, datacon)
            unassignedNurses = Convert.ToInt32(cmd.ExecuteScalar())

            lblTotalNurse.Text = totalNurses
            lblnurseAssigned.Text = assignedNurses
            lbltotalUnassigned.Text = unassignedNurses

        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadShiftDistribution()
        Try
            With cmd
                datacon.Open()
                .Connection = datacon
                .CommandText = "SELECT 
                                COUNT(CASE WHEN shiftTimeId = 1 THEN 1 END) AS MorningShift,
                                COUNT(CASE WHEN shiftTimeId = 2 THEN 1 END) AS EveningShift,
                                COUNT(CASE WHEN shiftTimeId = 3 THEN 1 END) AS NightShift
                                FROM shifts"

                If reader.Read() Then
                    Chart1.Series("ShiftDistribution").Points.Clear()

                    totalMorning = Convert.ToInt32(reader("MorningShift"))
                    totalEvening = Convert.ToInt32(reader("EveningShift"))
                    totalNight = Convert.ToInt32(reader("NightShift"))

                    lblmorning.Text = totalMorning
                    lblevening.Text = totalEvening
                    lblnight.Text = totalNight
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            datacon.Close()

        End Try
    End Sub
    Private Sub LoadRecord()
        Try
            Dim query As String =
                    "SELECT 
                s.shiftName,
                s.startDate,
                s.endDate,
                s.startTime,
                s.endTime,
                d.departmentName AS Department,
                t.shiftTimeName AS Shift_Time,
                s.shiftId
            FROM 
                shiftsenseidb.shifts s
            JOIN 
                shiftsenseidb.department d ON s.departmentId = d.departmentId
            JOIN
                shiftsenseidb.shifttime t ON s.shiftTimeId = t.shiftTimeId
            ORDER BY 
                s.createdAt DESC"
            Dim adapter As New MySqlDataAdapter(query, datacon)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridViewShift.DataSource = table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        PopulateNurseAvailabilityChart()
        LoadRecord()
        totalNurse()
        'PopulateShiftDistributionChart()
        Dim font As New Font("Arial Bold", 8)
        DataGridViewShift.DefaultCellStyle.Font = font
        DataGridViewShift.ColumnHeadersDefaultCellStyle.Font = font
        DataGridViewShift.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewShift.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub PopulateNurseAvailabilityChart()

    End Sub


End Class
