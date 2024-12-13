Public Class Schedule
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        AddLabelDayToFlDay(1, 31)
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        ListFlDays.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"lblDay{i}"
            fl.Size = New Size(128, 99)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)

        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(131, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay(i - 1) + startDayAtFlNumber).Controls.Add()(lbl)
        Next
    End Sub
End Class