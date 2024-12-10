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
    Dim departmentId, totalAvailableHours, totalShiftDuration, idealShifts, assignedShifts, shiftTypeId As Integer
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
            shiftTypeId = CType(cmbShiftType.SelectedValue, Integer)
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
        query = "INSERT INTO shifts (shiftName, startDate, endDate, startTime, endTime, departmentId, shiftTypeId) VALUES 
            ('" & shiftName & "','" & startDate.ToString("yyyy-MM-dd") & "','" & endDate.ToString("yyyy-MM-dd") & "','" & startTime.ToString("HH:mm:ss") & "','" & endTime.ToString("HH:mm:ss") & "','" & departmentId & "','" & shiftTypeId & "')"

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
                    st.shiftTypeName AS Shift_Type
                FROM 
                    shiftsenseidb.shifts s
                JOIN 
                    shiftsenseidb.department d ON s.departmentId = d.departmentId
                JOIN 
                    shiftsenseidb.shifttype st ON s.shiftTypeId = st.shiftId
                ORDER BY s.createdAt DESC;"

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
        LoadShiftType()
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
    Private Sub LoadShiftType()
        Try
            query = "SELECT * FROM shiftsenseidb.shifttype"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbShiftType.DataSource = dtable
            cmbShiftType.ValueMember = "shiftId"
            cmbShiftType.DisplayMember = "shiftTypeName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnAllocate_Click(sender As Object, e As EventArgs) Handles btnAllocate.Click
        assignForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
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
            shiftTypeId = CType(cmbShiftType.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a shift type.")
            Return
        End If

        ' Insert query for creating a shift
        query = "INSERT INTO shifts (shiftName, startDate, endDate, startTime, endTime, departmentId, shiftTypeId) VALUES 
            ('" & shiftName & "','" & startDate.ToString("yyyy-MM-dd") & "','" & endDate.ToString("yyyy-MM-dd") & "','" & startTime.ToString("HH:mm:ss") & "','" & endTime.ToString("HH:mm:ss") & "','" & departmentId & "','" & shiftTypeId & "')"

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
            MsgBox("Error: " & ex.ToString())
        End Try
    End Sub
End Class
