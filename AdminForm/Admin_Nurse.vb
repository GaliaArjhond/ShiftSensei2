Imports MySql.Data.MySqlClient
Public Class Admin_Nurse
    Dim querry As String
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter

    Private Sub Admin_Nurse_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        Dim font As New Font("Arial Bold", 8)
        dataRecord.DefaultCellStyle.Font = font
        dataRecord.ColumnHeadersDefaultCellStyle.Font = font

        dataRecord.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dataRecord.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            querry = "SELECT CONCAT(n.fname, ' ', n.mname, ' ', n.Lname) AS Nurse_Name, 
                            n.nurseLicense, 
                            d.departmentName, 
                            p.positionName, 
                            e.levelName,
                            isActive 
                        FROM 
                            nurse n 
                        JOIN 
                            department d ON n.departmentId = d.departmentId 
                        JOIN
                            position p ON n.positionId = p.positionId
                        JOIN
                            explvls e ON n.expLvlsId = e.expLvlsId"

            da = New MySqlDataAdapter(querry, datacon)
            tableInfo = New DataTable
            da.Fill(tableInfo)
            dataRecord.DataSource = tableInfo
            dataRecord.ScrollBars = ScrollBars.Both
            dataRecord.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dataRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            datacon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Admin_Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Admin_CreateShift.Show()
        Me.Hide()

    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Admin_Schedule.Show()
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
End Class
