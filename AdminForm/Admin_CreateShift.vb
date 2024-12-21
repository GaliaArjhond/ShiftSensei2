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
    Dim dgresult As New DialogResult
    Dim availableNurses As New List(Of Integer)
    Dim departmentId, totalAvailableHours, totalShiftDuration, idealShifts, assignedShifts, shiftTimeId, shiftId, index As Integer
    Dim startDate, endDate, startTime, endTime As DateTime

    Private rowIndex As Integer = -1
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New MySqlDataAdapter()

    Private Sub GetData(ByVal selectCommand As String)
        Try
            dataAdapter = New MySqlDataAdapter(selectCommand, datacon)
            Dim commandBuilder As New MySqlCommandBuilder(dataAdapter)
            Dim table As New DataTable()
            dataAdapter.Fill(table)

            bindingSource1.DataSource = table
            DataGridViewShift.DataSource = bindingSource1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


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


    Public Sub DeleteRecord()
        Dim dgresult As New DialogResult

        Try
            dgresult = MessageBox.Show("Do you really want to delete the record?", "Please select an action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dgresult = DialogResult.Yes Then
                With cmd
                    datacon.Open()
                    .Connection = datacon
                    .CommandText = "DELETE FROM shifts WHERE shiftId = " & Val(DataGridViewShift.CurrentRow.Cells(10).Value)
                    result = .ExecuteNonQuery()
                    If result > 0 Then
                        MsgBox("Deletion successful!")
                        LoadRecord() ' Refresh the DataGridView
                    Else
                        MsgBox("Deletion not successful!")
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            datacon.Close()
        End Try
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        LoadRecord()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Admin_Dashboard.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_EditShift.Show()

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


    Private Sub Admin_CreateShift_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        LoadDepartments()
        LoadShiftTime()

        Dim shiftIdColumn As New DataGridViewTextBoxColumn()
        shiftIdColumn.Name = "shiftId"
        shiftIdColumn.HeaderText = "Shift ID"
        DataGridViewShift.Columns.Add(shiftIdColumn)
        DataGridViewShift.Columns("shiftId").Visible = False

        Dim font As New Font("Arial Bold", 8)
        DataGridViewShift.DefaultCellStyle.Font = font
        DataGridViewShift.ColumnHeadersDefaultCellStyle.Font = font
        DataGridViewShift.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewShift.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Dim buttonDelete As DataGridViewButtonColumn

        buttonDelete = New DataGridViewButtonColumn()
        buttonDelete.HeaderText = "Delete Rows"
        buttonDelete.Name = "remove"
        buttonDelete.Text = "Remove"
        buttonDelete.UseColumnTextForButtonValue = True
        buttonDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        buttonDelete.FlatStyle = FlatStyle.Standard
        buttonDelete.CellTemplate.Style.BackColor = Color.Beige

        DataGridViewShift.Columns.Add(buttonDelete)


        Me.DataGridViewShift.DefaultCellStyle.BackColor = Color.AliceBlue

        Me.DataGridViewShift.DataSource = Me.bindingSource1
        GetData("SELECT 
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
                s.createdAt DESC")
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
        If e.ColumnIndex = DataGridViewShift.Columns("remove").Index Then
            DeleteRecord()
        ElseIf e.ColumnIndex = DataGridViewShift.Columns("update").Index Then
            UpdateRecord()
        End If
    End Sub


    Private Sub DeleteRowToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        DeleteRecord()
    End Sub

    Public Sub UpdateRecord()
        Admin_EditShift.Show()
    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridViewShift.CellMouseUp
        If e.Button = MouseButtons.Right Then
            If e.RowIndex >= 0 Then
                Me.DataGridViewShift.Rows(e.RowIndex).Selected = True
                Me.DataGridViewShift.CurrentCell = Me.DataGridViewShift.Rows(e.RowIndex).Cells(1) ' Focus on a specific cell
                Me.ContextMenuStrip1.Show(Me.DataGridViewShift, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub


End Class
