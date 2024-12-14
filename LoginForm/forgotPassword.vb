Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class forgotPassword

    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim ds As DataSet
    Dim adp As MySqlDataAdapter
    Dim dtable As DataTable
    Dim query As String
    Dim answer, LicenseNumber, newPass As String
    Dim securityQuestionId As Integer
    Dim reader As MySqlDataReader


    Private Sub forgotPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LicenseNumber = txtLicenseNumber.Text

        If String.IsNullOrEmpty(LicenseNumber) Then
            MessageBox.Show("Please enter your License Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            With cmd
                datacon.Open()
                query = "SELECT securityquestion FROM nurse WHERE nurseLicense = '" & txtLicenseNumber.Text & "'"
                cmd = New MySqlCommand(query, datacon)
                cmd.Parameters.AddWithValue("@nurseLicense", LicenseNumber)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    lblSecurityQuestion.Text = reader("SecurityQuestion").ToString()
                Else
                    MessageBox.Show("License number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If
            datacon.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgresult As New DialogResult
        LicenseNumber = txtLicenseNumber.Text

        answer = txtanswer.Text
        newPass = txtnewPass.Text

        If String.IsNullOrEmpty(answer) Then
            MessageBox.Show("Please enter an answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

        Catch ex As Exception

        End Try

        Dim storedAnswer As Object = cmd.ExecuteScalar()


        If storedAnswer IsNot Nothing AndAlso storedAnswer.ToString() = answer Then

            Dim newPassword As String = InputBox("Please enter your new password:", "New Password")

            If String.IsNullOrEmpty(newPassword) Then
                MessageBox.Show("Please enter a valid password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' This is where we Update the password in the database
            Dim updateQuery As String = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username"
            cmd = New MySqlCommand(updateQuery, datacon)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Your password has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        Else

            MessageBox.Show("The answer to the security question is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class