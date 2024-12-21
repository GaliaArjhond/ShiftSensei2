Imports MySql.Data.MySqlClient

Public Class Login
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim license As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If String.IsNullOrWhiteSpace(license) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both License and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            cmd = New MySqlCommand()
            datacon.Open()
            cmd.Connection = datacon

            ' Check if user is an admin
            cmd.CommandText = "SELECT adminId FROM admin WHERE adminLicense = @license AND passwordHash = @passwordHash"
            cmd.Parameters.AddWithValue("@license", license)
            cmd.Parameters.AddWithValue("@passwordHash", password) ' Add hashing for the password

            Dim adminId As Object = cmd.ExecuteScalar()
            If adminId IsNot Nothing Then
                ' Redirect to Admin Dashboard
                Admin_Dashboard.Show()
                Me.Hide()
                Return
            End If

            ' Clear previous parameters
            cmd.Parameters.Clear()

            ' Check if user is a nurse
            cmd.CommandText = "SELECT nurseId FROM nurse WHERE nurseLicense = @license AND passwordHash = @passwordHash"
            cmd.Parameters.AddWithValue("@license", license)
            cmd.Parameters.AddWithValue("@passwordHash", password) ' Add hashing for the password

            Dim nurseId As Object = cmd.ExecuteScalar()
            If nurseId IsNot Nothing Then
                ' Redirect to Nurse Dashboard
                Nurse_Dashboard.Show()
                Me.Hide()
                Return
            End If

            ' If no match is found
            MessageBox.Show("Invalid License or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If datacon.State = ConnectionState.Open Then datacon.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
    End Sub
End Class
