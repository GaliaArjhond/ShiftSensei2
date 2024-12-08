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





    Private Sub cmbNurseName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNurseName.SelectedIndexChanged
        If cmbNurseName.SelectedValue IsNot Nothing AndAlso TypeOf cmbNurseName.SelectedValue Is Integer Then

            Dim nurseId As Integer = Convert.ToInt32(cmbNurseName.SelectedValue)

            query = "SELECT nurseLicense FROM Nurse WHERE nurseId = @nurseId"
            cmd = New MySqlCommand(query, datacon)
            cmd.Parameters.AddWithValue("@nurseId", nurseId)

            ' Execute the query and get the license number
            Dim licenseNumber As String = cmd.ExecuteScalar()?.ToString()
            ' Display the retrieved license number in a label
            lblLicenseNumber.Text = "License Number: " & licenseNumber

        Else
            ' If no valid item is selected, clear the label
            lblLicenseNumber.Text = "License Number:"
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If cmbNurseName.SelectedValue Is Nothing OrElse Not IsNumeric(cmbNurseName.SelectedValue) Then
                MessageBox.Show("Please select a valid nurse.")
            End If

            If String.IsNullOrEmpty(reason) Then
                query = "INSERT INTO deletionlogs (nurseId, reason, deletionDate) VALUES ('" & nurseId & "','" & reason & "', NOW())"
                Try
                    With cmd
                        .Connection = datacon
                        .CommandText = query
                        result = cmd.ExecuteNonQuery()
                        If result > 0 Then
                            MessageBox.Show("Deletion reason logged successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to log deletion reason.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End With
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            If String.IsNullOrEmpty(txtConfrimPassword.Text) OrElse txtConfrimPassword.Text = password Then
                If MessageBox.Show($"Are you sure you want to delete the account for nurse ID {nurseId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    query = "DELETE FROM nurse WHERE nurseId = '" & nurseId & "'"
                    Try
                        With cmd
                            .Connection = datacon
                            .CommandText = query
                            result = cmd.ExecuteNonQuery()
                            If result > 0 Then
                                cmbNurseName.SelectedIndex = -1
                                rtbReason.Clear()
                                txtConfrimPassword.Clear()
                            Else
                                MsgBox("Failed to insert all fields")
                            End If
                        End With
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Please fill out all fields")
        End Try
    End Sub
End Class