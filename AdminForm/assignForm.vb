Imports MySql.Data.MySqlClient
Public Class assignForm
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter
    Dim startDate, endDate As DateTime

    Private Sub assignForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        loadShiftName()

        Dim font As New Font("Arial Bold", 8)
        dataAvailable.DefaultCellStyle.Font = font
        dataAvailable.ColumnHeadersDefaultCellStyle.Font = font

        dataAvailable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dataAvailable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dataAssigned.DefaultCellStyle.Font = font
        dataAssigned.ColumnHeadersDefaultCellStyle.Font = font

        ' Add Allocate button to dataAvailable DataGridView
        Dim allocateButton As New DataGridViewButtonColumn()
        allocateButton.HeaderText = "Action"
        allocateButton.Text = "Allocate"
        allocateButton.Name = "AllocateButton" ' Set the Name property
        allocateButton.UseColumnTextForButtonValue = True
        dataAvailable.Columns.Add(allocateButton)

        ' Add Deallocate button to dataAssigned DataGridView
        Dim deallocateButton As New DataGridViewButtonColumn()
        deallocateButton.HeaderText = "Action"
        deallocateButton.Text = "Deallocate"
        deallocateButton.Name = "DeallocateButton" ' Set the Name property
        deallocateButton.UseColumnTextForButtonValue = True
        dataAssigned.Columns.Add(deallocateButton)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If datacon.State = ConnectionState.Closed Then
                datacon.Open()
            End If

            ' Query for assigned nurses
            Dim available As String = "SELECT CONCAT(n.fname, ' ', n.mname, ' ', n.Lname) AS Nurse_Name,
                                        n.nurseLicense, 
                                        d.departmentName, 
                                        p.positionName, 
                                        e.levelName,
                                        s.shiftTypeName
                                     FROM 
                                        nurse n 
                                     JOIN 
                                        department d ON n.departmentId = d.departmentId 
                                     JOIN
                                        position p ON n.positionId = p.positionId
                                     JOIN
                                        explvls e ON n.expLvlsId = e.expLvlsId
                                     JOIN
                                        shiftType s ON n.shiftTypeId = s.shiftTypeId
                                     WHERE
                                        n.shiftTypeId = 2" ' Filter for unassigned nurses

            ' Query for unassigned nurses
            Dim assigned As String = "SELECT CONCAT(n.fname, ' ', n.mname, ' ', n.Lname) AS Nurse_Name,
                                          n.nurseLicense, 
                                          d.departmentName, 
                                          p.positionName, 
                                          e.levelName,
                                          s.shiftTypeName
                                       FROM 
                                          nurse n 
                                       JOIN 
                                          department d ON n.departmentId = d.departmentId 
                                       JOIN
                                          position p ON n.positionId = p.positionId
                                       JOIN
                                          explvls e ON n.expLvlsId = e.expLvlsId
                                       JOIN
                                          shiftType s ON n.shiftTypeId = s.shiftTypeId
                                       WHERE
                                          n.shiftTypeId = 1" ' Filter for assigned nurses

            da = New MySqlDataAdapter(available, datacon)
            tableInfo = New DataTable
            da.Fill(tableInfo)
            dataAvailable.DataSource = tableInfo
            dataAvailable.ScrollBars = ScrollBars.Both
            dataAvailable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dataAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Hide the shiftTypeName column in assigned nurses DataGridView
            If dataAvailable.Columns.Contains("shiftTypeName") Then
                dataAvailable.Columns("shiftTypeName").Visible = False
            End If

            da = New MySqlDataAdapter(assigned, datacon)
            tableInfo = New DataTable
            da.Fill(tableInfo)
            dataAssigned.DataSource = tableInfo
            dataAssigned.ScrollBars = ScrollBars.Both
            dataAssigned.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dataAssigned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If dataAssigned.Columns.Contains("shiftTypeName") Then
                dataAssigned.Columns("shiftTypeName").Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

    Private Sub loadShiftName()
        Try
            query = "SELECT * FROM shiftsenseidb.shifts"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbShiftName.DataSource = dtable
            cmbShiftName.ValueMember = "shiftId"
            cmbShiftName.DisplayMember = "shiftName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dataAvailable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataAvailable.CellContentClick
        ' Ensure that the clicked column is the Allocate button column
        If e.ColumnIndex >= 0 AndAlso dataAvailable.Columns(e.ColumnIndex).Name = "AllocateButton" Then
            Try
                Dim nurseLicense As String = dataAvailable.Rows(e.RowIndex).Cells("nurseLicense").Value.ToString()
                Dim shiftId As Integer = CType(cmbShiftName.SelectedValue, Integer)

                query = "UPDATE nurse SET shiftTypeId = 1, shiftsId = @shiftId WHERE nurseLicense = @nurseLicense"
                cmd = New MySqlCommand(query, datacon)
                cmd.Parameters.AddWithValue("@nurseLicense", nurseLicense)
                cmd.Parameters.AddWithValue("@shiftId", shiftId)

                If datacon.State = ConnectionState.Closed Then datacon.Open()
                result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Nurse allocated to shift successfully.")
                    Button4_Click(Nothing, Nothing) ' Refresh data
                Else
                    MessageBox.Show("Failed to allocate nurse.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If datacon.State = ConnectionState.Open Then datacon.Close()
            End Try
        End If
    End Sub


    Private Sub dataAssigned_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataAssigned.CellContentClick
        ' Ensure that the clicked column is the Deallocate button column
        If e.ColumnIndex >= 0 AndAlso dataAssigned.Columns(e.ColumnIndex).Name = "DeallocateButton" Then
            Try
                Dim nurseLicense As String = dataAssigned.Rows(e.RowIndex).Cells("nurseLicense").Value.ToString()

                query = "UPDATE nurse SET shiftTypeId = 2, shiftsId = NULL WHERE nurseLicense = @nurseLicense"
                cmd = New MySqlCommand(query, datacon)
                cmd.Parameters.AddWithValue("@nurseLicense", nurseLicense)

                If datacon.State = ConnectionState.Closed Then datacon.Open()
                result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Nurse deallocated from shift successfully.")
                    Button4_Click(Nothing, Nothing) ' Refresh data
                Else
                    MessageBox.Show("Failed to deallocate nurse.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If datacon.State = ConnectionState.Open Then datacon.Close()
            End Try
        End If
    End Sub


End Class