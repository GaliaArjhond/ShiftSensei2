Imports MySql.Data.MySqlClient

Public Class Admin_EditShift
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter
    Dim shiftName As String
    Dim availableNurses As New List(Of Integer)
    Dim departmentId, totalAvailableHours, totalShiftDuration, idealShifts, assignedShifts, shiftTimeId, shiftId, index As Integer
    Dim startDate, endDate, startTime, endTime As DateTime

    Private rowIndex As Integer = -1
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New MySqlDataAdapter()



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

    Private Sub LoadShifts()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgresult As New DialogResult

        shiftName = txtShiftName.Text
        startDate = dtpStartDate.Value
        endDate = dtpEndDate.Value
        startTime = dtpStartTime.Value
        endTime = dtpEndTime.Value
        departmentId = cmbDepartment.SelectedValue
        shiftId = cmbShiftName.SelectedValue

        Try
            dgresult = MessageBox.Show("Do you really want to update the record?", "Please Select an action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dgresult = Windows.Forms.DialogResult.Yes Then
                With cmd
                    datacon.Open()
                    .Connection = datacon
                    .CommandText = "UPDATE shifts SET shiftName = '" & txtShiftName.Text & "', startDate = '" & startDate.ToString("yyyy-MM-dd HH:mm:ss") & "', endDate = '" & endDate.ToString("yyyy-MM-dd HH:mm:ss") & "', 
                                     startTime = '" & startTime.ToString("HH:mm:ss") & "', endTime = '" & endTime.ToString("HH:mm:ss") & "', departmentId = '" & cmbDepartment.SelectedValue & "' WHERE shiftId = '" & shiftId & "'"
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("Upadate Shift Successful!")
                        txtShiftName.Clear()
                        dtpStartDate.Value = DateTime.Now
                        dtpEndDate.Value = DateTime.Now
                        dtpStartTime.Value = DateTime.Now
                        dtpEndTime.Value = DateTime.Now
                        cmbDepartment.SelectedValue = -1
                        cmbShiftName.SelectedValue = -1
                    Else
                        MsgBox("Upadate Shift NOT Successful!")
                    End If
                End With
                ClearData()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            datacon.Close()

        End Try

    End Sub
    Public Sub ClearData()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If

            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If
            ' Uncheck CheckBox controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If

            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub



    Private Sub Admin_EditShift_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDepartments()
        databaseConnect()
        LoadShifts()
    End Sub
End Class
