Imports MySql.Data.MySqlClient
Public Class Admin_Dashboard
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim query As String
    Dim available, unavailable As Integer
    Dim reader As MySqlDataReader
    Dim availabilitySeries As chart


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Admin_CreateShift.Show()
        Me.Hide()

    End Sub
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Admin_Schedule.Show()
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
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Admin_Account1.Show()
        Me.Hide()

    End Sub

    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        PopulateNurseAvailabilityChart()
        'PopulateShiftDistributionChart()
    End Sub

    Private Sub PopulateNurseAvailabilityChart()
        Try
            datacon.Open()

            query = "SELECT 
                     SUM(CASE WHEN shiftTypeId = 1 THEN 1 ELSE 0 END) AS Available,
                     SUM(CASE WHEN shiftTypeId = 2 THEN 1 ELSE 0 END) AS Unavailable
                     FROM nurse"
            cmd = New MySqlCommand(query, datacon)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                available = reader("Available")
                unavailable = reader("Unavailable")
            End If
            reader.Close()

            NurseAvailabilityChart.Series.Clear()
            'Dim availabilitySeries As New Series("Nurse Availability")
            availabilitySeries.Points.AddXY("Available", available)
            availabilitySeries.Points.AddXY("Unavailable", unavailable)
            NurseAvailabilityChart.Series.Add(availabilitySeries)
            NurseAvailabilityChart.Titles.Clear()
            NurseAvailabilityChart.Titles.Add("Nurse Availability")
        Catch ex As Exception
            MessageBox.Show("Error loading Nurse Availability: " & ex.Message)
        Finally
            datacon.Close()
        End Try
    End Sub
End Class
