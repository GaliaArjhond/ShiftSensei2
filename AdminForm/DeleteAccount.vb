Imports MySql.Data.MySqlClient

Public Class DeleteAccount
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim query As String
    Dim ds As DataSet
    Dim dtable As DataTable
    Dim adp As MySqlDataAdapter
    Dim nurseId As Integer
    Dim confirmPassword, reason, password As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Nurse.Show()
        Me.Hide()

    End Sub

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
        Dim dgresult As New DialogResult
        Try
            dgresult = MessageBox.Show("Are you sure you want to delete the account for this Nurse?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dgresult = Windows.Forms.DialogResult.Yes Then
                With cmd
                    datacon.Open()
                    .Connection = datacon
                    .CommandText = "DELETE FROM nurse WHERE nurseId = '" & cmbNurseName.SelectedValue & "'"
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        ' Successfully deleted
                        cmbNurseName.SelectedIndex = -1
                        rtbReason.Clear()
                        MessageBox.Show("Nurse account deleted successfully.")
                    Else
                        MsgBox("Failed to delete the nurse account.")
                    End If
                End With
                ClearData()

            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            datacon.Close()
        End Try
    End Sub
    Public Sub ClearData()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub
End Class

