Imports MySql.Data.MySqlClient
Public Class assignForm
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim startDate, endDate As DateTime

    Private Sub assignForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        LoadAvailableNurses()
    End Sub

    Private Sub LoadAvailableNurses()
        Try
            query = "SELECT n.nurseId, CONCAT(n.fname, ' ', n.mname, ' ', n.Lname) AS NurseName
                    FROM Nurse n
                    LEFT JOIN ShiftAssignments sa ON n.nurseId = sa.nurseId
                    LEFT JOIN Shifts s ON sa.shiftId = s.shiftId
                    WHERE (sa.status IS NULL OR sa.status = 'Unassigned' 
                           OR NOT (s.startDate <= @desiredEndDate AND s.endDate >= @desiredStartDate))
                      AND n.isActive = 1"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            DataGridViewAvailableNurses.AutoResizeColumns()
            DataGridViewAvailableNurses.ScrollBars = ScrollBars.Both
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class