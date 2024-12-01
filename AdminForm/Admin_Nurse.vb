Imports MySql.Data.MySqlClient
Public Class Admin_Nurse
    Dim querry As String
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter

    Private Sub Admin_Nurse_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
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
End Class
