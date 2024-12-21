Public Class Nurse_Account
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Nurse_Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Nurse_schedule2.Show()
        Me.Hide()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Nurse_Profile.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class
