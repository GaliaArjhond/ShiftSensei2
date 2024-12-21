Public Class Admin_Account1
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) 
        CreateAccount.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Admin_Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Admin_CreateShift.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
End Class
