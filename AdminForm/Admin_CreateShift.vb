Imports MySql.Data.MySqlClient
Public Class Admin_CreateShift
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim querry As String
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim shiftName As String
    Dim fairDistribution As Boolean
    Dim availableNurses As New List(Of Integer)
    Dim departmentId, totalAvailableHours, totalShiftDuration, idealShifts, assignedShifts, shiftTimeId, shiftId As Integer
    Dim startDate, endDate, startTime, endTime As DateTime


    Private Sub btnCreateShift_Click(sender As Object, e As EventArgs) Handles btnCreateShift.Click
        shiftName = txtshiftName.Text
        startDate = dtpStartDate.Value
        endDate = dtpEndDate.Value
        startTime = dtpStartTime.Value
        endTime = dtpEndTime.Value

        ' Check if a department has been selected
        If cmbDepartment.SelectedValue IsNot Nothing Then
            departmentId = CType(cmbDepartment.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a department.")
            Return
        End If

        ' Check if a shift type has been selected
        If cmbShiftType.SelectedValue IsNot Nothing Then
            shiftTimeId = CType(cmbShiftType.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a shift type.")
            Return
        End If

        ' Validate required fields
        If String.IsNullOrEmpty(shiftName) OrElse startDate > endDate Then
            MessageBox.Show("Please ensure all fields are filled out correctly.")
            Return
        End If

        ' Insert query for creating a shift
        query = "INSERT INTO shifts (shiftName, startDate, endDate, startTime, endTime, departmentId, shiftTimeId) VALUES 
            ('" & shiftName & "','" & startDate.ToString("yyyy-MM-dd") & "','" & endDate.ToString("yyyy-MM-dd") & "','" & startTime.ToString("HH:mm:ss") & "','" & endTime.ToString("HH:mm:ss") & "','" & departmentId & "','" & shiftTimeId & "')"

        Try
            If shiftName <> "" Then
                With cmd
                    .Connection = datacon
                    .CommandText = query
                    result = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MsgBox("Shift created successfully.")
                        ' Clear form fields after successful insertion
                        txtshiftName.Clear()
                        dtpStartDate.Value = DateTime.Now
                        dtpEndDate.Value = DateTime.Now
                        dtpStartTime.Value = DateTime.Now
                        dtpEndTime.Value = DateTime.Now
                        cmbDepartment.SelectedIndex = -1
                        cmbShiftType.SelectedIndex = -1
                        ckbFair.Checked = False
                    Else
                        MsgBox("Failed to create shift.")
                    End If
                End With
            Else
                MsgBox("Please fill out all fields.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If datacon.State = ConnectionState.Closed Then
                datacon.Open()
            End If

            query = "SELECT 
                    s.shiftName,
                    s.startDate,
                    s.endDate,
                    s.startTime,
                    s.endTime,
                    d.departmentName AS Department,
                    t.shiftTimeName AS Shift_Time
                FROM 
                    shiftsenseidb.shifts s
                JOIN 
                    shiftsenseidb.department d ON s.departmentId = d.departmentId
                JOIN
                    shiftsenseidb.shifttime t ON s.shiftTimeId = t.shiftTimeId
                ORDER BY 
                    s.createdAt DESC;
"

            da = New MySqlDataAdapter(query, datacon)
            tableInfo = New DataTable
            da.Fill(tableInfo)

            DataGridViewShift.DataSource = tableInfo

            DataGridViewShift.ScrollBars = ScrollBars.Both
            DataGridViewShift.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridViewShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        Finally
            ' Ensure the connection is closed
            If datacon.State = ConnectionState.Open Then
                datacon.Close()
            End If
        End Try

    End Sub

    Private Sub Admin_CreateShift_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        LoadDepartments()
        LoadShiftTime()

        Dim font As New Font("Arial Bold", 8)
        DataGridViewShift.DefaultCellStyle.Font = font
        DataGridViewShift.ColumnHeadersDefaultCellStyle.Font = font
        DataGridViewShift.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewShift.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Dim editButton As New DataGridViewButtonColumn()
        Dim deleteButton As New DataGridViewButtonColumn()

        deleteButton.HeaderText = "Delete"
        deleteButton.Text = "Delete"
        deleteButton.Name = "deleteButton"
        deleteButton.UseColumnTextForButtonValue = True

        editButton.HeaderText = "Edit"
        editButton.Text = "Edit"
        editButton.Name = "editButton" ' Set the Name property
        editButton.UseColumnTextForButtonValue = True

        DataGridViewShift.Columns.Add(deleteButton)
        DataGridViewShift.Columns.Add(editButton)
    End Sub

    Private Sub LoadDepartments()
        Try
            query = "SELECT * FROM shiftsenseidb.department;"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbDepartment.DataSource = dtable
            cmbDepartment.ValueMember = "departmentId"
            cmbDepartment.DisplayMember = "departmentName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadShiftTime()
        Try
            query = "SELECT * FROM shiftsenseidb.shiftTime"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbShiftType.DataSource = dtable
            cmbShiftType.ValueMember = "shiftTimeId"
            cmbShiftType.DisplayMember = "shiftTimeName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnAllocate_Click(sender As Object, e As EventArgs) Handles btnAllocate.Click
        assignForm.Show()
    End Sub

    Private Sub DataGridViewShift_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShift.CellContentClick
        If e.ColumnIndex >= 0 Then
            ' Check if the clicked column is the "editButton"
            If DataGridViewShift.Columns(e.ColumnIndex).Name = "editButton" Then
                Admin_EditShift.Show()
                ' Check if the clicked column is the "deleteButton"
            ElseIf DataGridViewShift.Columns(e.ColumnIndex).Name = "deleteButton" Then
                ' Show confirmation message box
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the this shift?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    query = "DELETE FROM shiftsenseidb.shifts WHERE shiftId =  '" & shiftId & "'"
                    If result > 0 Then

                        MessageBox.Show("Shift deleted successfully.")
                    Else
                        MsgBox("Failed to delete the nurse account.")
                    End If
                End If
            End If
        End If
    End Sub

End Class
