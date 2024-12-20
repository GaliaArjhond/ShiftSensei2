Imports MySql.Data.MySqlClient
Public Class Admin_Schedule
    Private Const DaysInMonth As Integer = 42
    Private calendarInfo As MonthlyCalendarInfo

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Admin_CreateShift.Show()
        Me.Hide()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Admin_Dashboard.Show()
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

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Admin_Account1.Show()
        Me.Hide()

    End Sub

    Private Sub sizeContainers()
        ' Define the total panel dimensions and the left tab width
        Dim totalWidth As Integer = 1250
        Dim totalHeight As Integer = 718
        Dim tabWidth As Integer = 217

        ' Calculate the available width and height
        Dim availableWidth As Integer = totalWidth - tabWidth
        Dim availableHeight As Integer = totalHeight

        ' MonthYearContainer
        MonthYearContainer.Size = New Size(availableWidth, 55)
        MonthYearContainer.Location = New Point(tabWidth, 0) ' Shift by tabWidth to account for the left tab

        ' DaysOfWeekContainer
        DaysOfWeekContainer.Size = New Size(availableWidth, 30)
        DaysOfWeekContainer.Location = New Point(tabWidth, MonthYearContainer.Height)

        ' Calculate daysHeight and daysYStart
        Dim daysHeight As Integer = (availableHeight - MonthYearContainer.Height - DaysOfWeekContainer.Height) / 6
        Dim daysYStart As Integer = MonthYearContainer.Height + DaysOfWeekContainer.Height

        ' DaysRow Containers
        DaysRow0Container.Size = New Size(availableWidth, daysHeight)
        DaysRow0Container.Location = New Point(tabWidth, daysYStart)

        DaysRow1Container.Size = New Size(availableWidth, daysHeight)
        DaysRow1Container.Location = New Point(tabWidth, daysYStart + daysHeight)

        DaysRow2Container.Size = New Size(availableWidth, daysHeight)
        DaysRow2Container.Location = New Point(tabWidth, daysYStart + (daysHeight * 2))

        DaysRow3Container.Size = New Size(availableWidth, daysHeight)
        DaysRow3Container.Location = New Point(tabWidth, daysYStart + (daysHeight * 3))

        DaysRow4Container.Size = New Size(availableWidth, daysHeight)
        DaysRow4Container.Location = New Point(tabWidth, daysYStart + (daysHeight * 4))

        DaysRow5Container.Size = New Size(availableWidth, daysHeight)
        DaysRow5Container.Location = New Point(tabWidth, daysYStart + (daysHeight * 5))


    End Sub

    Private Sub SizeMonthYearLabel()

        Dim x As Integer
        Dim y As Integer
        Dim label As Label

        If MonthYearContainer.Controls.Count > 0 Then

            label = MonthYearContainer.Controls.Find("LblMonthYear", False).First
            x = (MonthYearContainer.Width - label.Width) / 2
            y = (MonthYearContainer.Height - label.Height) / 2
            label.Location = New Point(x, y)

        End If

    End Sub

    Private Sub CreateMonthYearLabel()
        Dim label As New Label()

        label.Name = "LblMonthYear"
        label.Font = New Font("Arial", 20, FontStyle.Bold)
        label.AutoSize = True
        label.Text = "Month Year"

        ' Add the label to the container first to calculate its size
        MonthYearContainer.Controls.Add(label)

        ' Center the label horizontally and vertically within the container
        label.Location = New Point(
        (MonthYearContainer.Width - label.Width) \ 2, ' Center horizontally
        (MonthYearContainer.Height - label.Height) \ 2 ' Center vertically
    )
    End Sub

    Private Sub CreateDaysOfWeekLabels()
        ' Define the days of the week
        Dim days As String() = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}

        ' Clear any existing controls in the container
        DaysOfWeekContainer.Controls.Clear()

        ' Calculate the width of each label based on the container's width
        Dim labelWidth As Integer = DaysOfWeekContainer.Width \ days.Length
        Dim labelHeight As Integer = DaysOfWeekContainer.Height

        For i As Integer = 0 To days.Length - 1
            ' Create a new label for each day
            Dim label As New Label()
            label.Name = $"Lbl{days(i)}"
            label.Text = days(i)
            label.Size = New Size(labelWidth, labelHeight)
            label.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            label.TextAlign = ContentAlignment.MiddleCenter

            ' Set the label's location based on its index
            label.Location = New Point(i * labelWidth, 0)

            ' Add the label to the container
            DaysOfWeekContainer.Controls.Add(label)
        Next
    End Sub

    Private Sub SizeDaysOfWeekLabels()

        SizeWidthEqually(DaysOfWeekContainer)

    End Sub

    Private Sub SizeWidthEqually(ByVal c As Control)
        ' Ensure there are child controls to process
        If c.Controls.Count = 0 Then
            Return
        End If

        ' Calculate the width for each control
        Dim width As Integer = c.Width \ c.Controls.Count
        Dim x As Integer = 0 ' Initialize starting position for controls

        ' Iterate through each child control and set its size and position
        For Each control As Control In c.Controls
            control.Height = c.Height
            control.Width = width
            control.Location = New Point(x, 0)
            x += width ' Update x for the next control
        Next
    End Sub

    Private Sub CreateDaysControls()

        Dim dayPanel As Panel
        Dim dayOfMonthLbl As Label

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                dayPanel = New Panel
                dayPanel.Name = String.Format("PnlDay{0}{1}", rowIndex, colIndex)
                dayOfMonthLbl = New Label
                dayOfMonthLbl.Name = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                dayOfMonthLbl.Text = dayOfMonthLbl.Name
                dayOfMonthLbl.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                dayPanel.Controls.Add(dayOfMonthLbl)

                Select Case rowIndex
                    Case 0
                        DaysRow0Container.Controls.Add(dayPanel)
                    Case 1
                        DaysRow1Container.Controls.Add(dayPanel)
                    Case 2
                        DaysRow2Container.Controls.Add(dayPanel)
                    Case 3
                        DaysRow3Container.Controls.Add(dayPanel)
                    Case 4
                        DaysRow4Container.Controls.Add(dayPanel)
                    Case 5
                        DaysRow5Container.Controls.Add(dayPanel)
                End Select

            Next
        Next

    End Sub

    Private Sub SizeDaysControls()
        ' Array to hold all day row containers
        Dim dayRowContainers As Panel() = {
        DaysRow0Container, DaysRow1Container, DaysRow2Container,
        DaysRow3Container, DaysRow4Container, DaysRow5Container
    }

        ' Apply SizeWidthEqually to each container
        For Each container As Panel In dayRowContainers
            SizeWidthEqually(container)
        Next
    End Sub

    Private Sub MonthYearContainer_Click(sender As Object, e As EventArgs) Handles MonthYearContainer.Click

        Dim pointClicked As Point
        Dim midPointX As Integer
        Dim activeMonth As DateTime
        Dim newMonth As DateTime

        midPointX = MonthYearContainer.Width / 2
        pointClicked = MonthYearContainer.PointToClient(Cursor.Position)
        activeMonth = New Date(calendarInfo.Year, calendarInfo.Month, 1)

        If pointClicked.X < midPointX Then
            newMonth = activeMonth.AddMonths(-1)
        Else
            newMonth = activeMonth.AddMonths(1)
        End If

        calendarInfo.GoToMonth(newMonth.Year, newMonth.Month)

        PopulateCalendarInfo()


    End Sub

    Private Sub PopulateCalendarInfo()

        Dim label As Control
        Dim labelName As String
        Dim shifts As New Dictionary(Of DateTime, String)

        ' MySQL query to fetch shifts
        Try
            Dim query As String = "SELECT shift_date, shift_name FROM shifts WHERE MONTH(shift_date) = @month AND YEAR(shift_date) = @year"
            Dim command As New MySqlCommand(query, datacon)
            command.Parameters.AddWithValue("@month", calendarInfo.Month)
            command.Parameters.AddWithValue("@year", calendarInfo.Year)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim shiftDate As DateTime = reader.GetDateTime("shift_date")
                Dim shiftName As String = reader.GetString("shift_name")
                shifts(shiftDate) = shiftName
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading shifts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Update the calendar with days and shift information
        label = MonthYearContainer.Controls.Find("LblMonthYear", False).First
        label.Text = String.Format("{0} {1}", MonthName(calendarInfo.Month), calendarInfo.Year)

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                labelName = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                label = Me.Controls.Find(labelName, True).First
                Dim dayDate As DateTime = calendarInfo.DayInMonth(rowIndex, colIndex)

                ' Update day label text
                label.Text = dayDate.Day.ToString()

                ' Style the day based on its status
                If calendarInfo.isActiveMonth(rowIndex, colIndex) Then
                    label.ForeColor = Color.Black
                Else
                    label.ForeColor = Color.Gray
                End If

                If calendarInfo.isToday(rowIndex, colIndex) Then
                    label.ForeColor = Color.Red
                End If

                ' Display shift information if available
                If shifts.ContainsKey(dayDate) Then
                    Dim parentPanelName As String = String.Format("PnlDay{0}{1}", rowIndex, colIndex)
                    Dim parentPanel As Control = Me.Controls.Find(parentPanelName, True).FirstOrDefault()

                    If parentPanel IsNot Nothing Then
                        Dim shiftLabel As New Label With {
                        .Text = shifts(dayDate),
                        .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                        .ForeColor = Color.Blue,
                        .Dock = DockStyle.Bottom,
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                        parentPanel.Controls.Add(shiftLabel)
                    End If
                End If
            Next
        Next

        SizeMonthYearLabel()
    End Sub


    Private Sub Admin_Schedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        sizeContainers()
        CreateMonthYearLabel()
        SizeMonthYearLabel()
        CreateDaysOfWeekLabels()
        SizeDaysOfWeekLabels()
        CreateDaysControls()
        SizeDaysControls()
        calendarInfo = New MonthlyCalendarInfo(2024, 12)
        PopulateCalendarInfo()
    End Sub
End Class
