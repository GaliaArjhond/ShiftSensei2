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
    Dim query As String

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect() 'connection for database
        LoadDepartments() 'combobox for departments 
        LoadPosition() 'combobox for Position
        LoadExp() 'combobox for experience
        LoadSecurityQuestion()
    End Sub


    Private Sub LoadSecurityQuestion()
        Try
            query = "SELECT * FROM shiftsenseidb.securityquestion"
            cmd = New MySqlCommand(query, datacon)
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
            query = "SELECT * FROM shiftsenseidb.explvls"
            cmd = New MySqlCommand(query, datacon)
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
            query = "SELECT * FROM shiftsenseidb.position"
            cmd = New MySqlCommand(query, datacon)
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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin_Account1.Show()
        Me.Hide()
    End Sub
End Class