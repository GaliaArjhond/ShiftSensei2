Imports MySql.Data.MySqlClient
Public Class CreateAccount
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim fname, mname, lname, password, email, address, phoneNumber,
        answer, nurseLicense As String
    Dim departmentId, positionId, expLvlsId, securityQuestionId As Integer
    Dim dateOfBirth, startDate, endDate, startTime, endTime As DateTime
    Dim querry As String

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect() 'connection for database
        LoadDepartments() 'combobox for departments 
        LoadPosition() 'combobox for Position
        LoadExp() 'combobox for experience
        LoadSecurityQuestion()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        fname = txtFname.Text
        mname = txtMname.Text
        lname = txtLname.Text
        email = txtemail.Text
        phoneNumber = txtphone.Text
        address = txtaddress.Text
        password = txtpassword.Text
        answer = txtAnswer.Text
        nurseLicense = txtLicense.Text
        dateOfBirth = dtpDateOfBIrth.Value
        startDate = dtpStartDate.Value
        endDate = dtpEndDate.Value
        startTime = dtpStartTime.Value
        endTime = dtpEndTime.Value

        If cmbDepartment.SelectedValue IsNot Nothing Then
            departmentId = CType(cmbDepartment.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a department.")
            Return
        End If

        If cmbPosition.SelectedValue IsNot Nothing Then
            positionId = CType(cmbPosition.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a position.")
            Return
        End If

        If cmbExp.SelectedValue IsNot Nothing Then
            expLvlsId = CType(cmbExp.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select an experience level.")
            Return
        End If

        If cmbSQ.SelectedValue IsNot Nothing Then
            securityQuestionId = CType(cmbSQ.SelectedValue, Integer)
        Else
            MessageBox.Show("Please select a security question.")
            Return
        End If

        querry = "INSERT INTO nurse (fname, mname, Lname, email, address, phoneNumber, nurseLicense, departmentId, positionId, expLvlsId, securityQuestionId, SecurityAnswerHash, passwordHash, dateOfBirth, startDate, endDate, startTime, endTime)  VALUES 
                 ('" & fname & "','" & mname & "','" & lname & "','" & email & "','" & address & "','" & phoneNumber & "','" & nurseLicense & "','" & departmentId & "','" & positionId & "',
                 '" & expLvlsId & "','" & securityQuestionId & "','" & answer & "','" & password & "','" & dateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") & "','" & startDate.ToString("yyyy-MM-dd HH:mm:ss") & "',
                 '" & endDate.ToString("yyyy-MM-dd HH:mm:ss") & "','" & startTime.ToString("HH:mm:ss") & "','" & endTime.ToString("HH:mm:ss") & "')"
        If fname <> "" And mname <> "" And lname <> "" And email <> "" And address <> "" And phoneNumber <> "" And nurseLicense <> "" Then
            Try
                With cmd
                    .Connection = datacon
                    .CommandText = querry
                    result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MsgBox("Account created successfully")
                        txtFname.Clear()
                        txtMname.Clear()
                        txtLname.Clear()
                        txtemail.Clear()
                        txtphone.Clear()
                        txtaddress.Clear()
                        txtpassword.Clear()
                        txtAnswer.Clear()
                    Else
                        MsgBox("Failed to insert all fields")
                    End If
                End With
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox("Please fill out all fields")
        End If
    End Sub

    Private Sub LoadSecurityQuestion()
        Try
            querry = "SELECT * FROM shiftsenseidb.securityquestion"
            cmd = New MySqlCommand(querry, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbSQ.DataSource = dtable
            cmbSQ.ValueMember = "securityQuestionId"
            cmbSQ.DisplayMember = "SecurityQuestion"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadExp()
        Try
            querry = "SELECT * FROM shiftsenseidb.explvls"
            cmd = New MySqlCommand(querry, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbExp.DataSource = dtable
            cmbExp.ValueMember = "expLvlsId"
            cmbExp.DisplayMember = "levelName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadPosition()
        Try
            querry = "SELECT * FROM shiftsenseidb.position"
            cmd = New MySqlCommand(querry, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            cmbPosition.DataSource = dtable
            cmbPosition.ValueMember = "positionId"
            cmbPosition.DisplayMember = "positionName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'make a load for department
    Private Sub LoadDepartments()
        Try
            querry = "SELECT * FROM shiftsenseidb.department;"
            cmd = New MySqlCommand(querry, datacon)
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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin_Account1.Show()
        Me.Hide()
    End Sub
End Class