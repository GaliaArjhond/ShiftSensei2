Imports MySql.Data.MySqlClient

Public Class DeleteAccount
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim dtable As DataTable
    Dim adp As MySqlDataAdapter
    Dim nurseId, passwordMatch As Integer
    Dim confirmPassword, reason, password As String

    Private Sub DeleteAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        LoadNurses()
    End Sub

    Private Sub LoadNurses()
        Try
            ' Define your query to load nurses
            query = "SELECT nurseId, fname, lname, nurseLicense FROM Nurse"
            cmd = New MySqlCommand(query, datacon)
            adp = New MySqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds)
            dtable = ds.Tables(0)

            ' Bind the ComboBox with nurse's names
            cmbNurseName.DataSource = dtable
            cmbNurseName.DisplayMember = "fname"
            cmbNurseName.ValueMember = "nurseId"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Check if a valid nurse is selected
            If cmbNurseName.SelectedValue Is Nothing OrElse Not IsNumeric(cmbNurseName.SelectedValue) Then
                MessageBox.Show("Please select a valid nurse.")
                Return
            End If

            ' Confirm deletion
            If MessageBox.Show($"Are you sure you want to delete the account for nurse ID {nurseId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ' Prepare the delete query
                query = "DELETE FROM nurse WHERE nurseId = @nurseId"
                Try
                    Using cmd As New MySqlCommand(query, datacon)
                        cmd.Parameters.AddWithValue("@nurseId", cmbNurseName.SelectedValue)

                        ' Execute the delete command
                        Dim result As Integer = cmd.ExecuteNonQuery()
                        If result > 0 Then
                            ' Successfully deleted
                            cmbNurseName.SelectedIndex = -1
                            rtbReason.Clear()
                            txtConfrimPassword.Clear()
                            MessageBox.Show("Nurse account deleted successfully.")
                        Else
                            MsgBox("Failed to delete the nurse account.")
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub
End Class

