Imports MySql.Data.MySqlClient
Public Class Admin_CreateShift
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim shiftName As String
    Dim fairDistribution As Boolean
    Dim departmentId As Integer
    Dim startDate, endDate, startTime, endTime As DateTime
    Private Sub Admin_CreateShift_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        LoadDepartments()
        LoadshiftType()
    End Sub

    Private Sub ckbFair_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFair.CheckedChanged
        If ckbFair.Checked Then
            fairDistribution = True
        Else
            fairDistribution = False
        End If
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

    Enum shiftType
        day
        evening
        night
    End Enum
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


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        shiftName = txtshiftName.Text
        startDate = dtpStartDate.Value
        endDate = dtpEndDate.Value
        startTime = dtpStartTime.Value
        endTime = dtpEndTime.Value

        If txtshiftName.Text = "" OrElse dtpStartDate.Value > dtpEndDate.Value Then
            MessageBox.Show("Please ensure all fields are filled out correctly.")
            Return
        End If

        If cmbDepartment.SelectedValue IsNot Nothing Then
            departmentId = CType(cmbDepartment.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a department.")
            Return
        End If

        query = "INSERT INTO shifts (shiftName, startDate, endDate, startTime, endTime, departmentId, fairDistributionCheck) 
                 VALUES ('" & shiftName & "', '" & startDate & "','" & endDate & "','" & startTime & "','" & endTime & "','" & departmentId & "', '" & fairDistribution & "')"


        If txtshiftName.Text <> "" And dtpStartDate.Value <= dtpEndDate.Value Then
            Try
                With cmd
                    .Connection = datacon
                    .CommandText = query
                    result = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Shift created successfully.")
                        ' Clear input fields
                        txtshiftName.Clear()
                        dtpStartDate.Value = DateTime.Now
                        dtpEndDate.Value = DateTime.Now
                        dtpStartTime.Value = DateTime.Now
                        dtpEndTime.Value = DateTime.Now
                        cmbDepartment.SelectedIndex = -1
                        ckbFair.Checked = False
                    Else
                        MessageBox.Show("Failed to create shift.")
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please complete all fields.")
        End If
    End Sub

    Private Sub btnAllocate_Click(sender As Object, e As EventArgs) Handles btnAllocate.Click
        assignForm.Show()
    End Sub
End Class
