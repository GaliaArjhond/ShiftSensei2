Imports MySql.Data.MySqlClient

Public Class Nurse_Schedule
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
                dayPanel.BorderStyle = BorderStyle.FixedSingle

                dayOfMonthLbl = New Label
                dayOfMonthLbl.Name = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                dayOfMonthLbl.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                dayOfMonthLbl.Dock = DockStyle.Top
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
        Dim shifts As New Dictionary(Of DateTime, (String, DateTime, Integer))

        ' MySQL query to fetch shifts
        Try
            Dim query As String = "SELECT startDate, endDate, shiftName, shiftTimeId FROM shifts WHERE MONTH(startDate) = @month AND YEAR(startDate) = @year"
            Dim command As New MySqlCommand(query, datacon)
            command.Parameters.AddWithValue("@month", calendarInfo.Month)
            command.Parameters.AddWithValue("@year", calendarInfo.Year)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim shiftDate As DateTime = reader.GetDateTime("startDate")
                Dim endDate As DateTime = reader.GetDateTime("endDate")
                Dim shiftName As String = reader.GetString("shiftName")
                Dim shiftTimeId As Integer = reader.GetInt32("shiftTimeId")
                shifts(shiftDate) = (shiftName, endDate, shiftTimeId)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading shifts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Update the month-year label
        label = MonthYearContainer.Controls.Find("LblMonthYear", False).FirstOrDefault()
        If label IsNot Nothing Then
            label.Text = String.Format("{0} {1}", MonthName(calendarInfo.Month), calendarInfo.Year)
        End If

        ' Clear existing shift labels and update the calendar with days and shift information
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                Dim parentPanelName As String = String.Format("PnlDay{0}{1}", rowIndex, colIndex)
                Dim parentPanel As Control = Me.Controls.Find(parentPanelName, True).FirstOrDefault()
                If parentPanel IsNot Nothing Then
                    parentPanel.Controls.Clear()

                    ' Create a day label for the number
                    Dim dayDate As DateTime = calendarInfo.DayInMonth(rowIndex, colIndex)
                    Dim dayOfMonthLbl As New Label With {
                        .Text = dayDate.Day.ToString(),
                        .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                        .Dock = DockStyle.Top
                    }

                    ' Check if the date is today and set the color to red
                    If dayDate.Date = DateTime.Today Then
                        dayOfMonthLbl.ForeColor = Color.Red
                    End If

                    parentPanel.Controls.Add(dayOfMonthLbl)

                    ' Display shift information if available and the endDate has not passed
                    If shifts.ContainsKey(dayDate) AndAlso shifts(dayDate).Item2 >= DateTime.Now Then
                        ' Access the tuple elements directly from the dictionary
                        Dim shiftInfo = shifts(dayDate)
                        Dim shiftName = shiftInfo.Item1
                        Dim endDate = shiftInfo.Item2
                        Dim shiftTimeId = shiftInfo.Item3

                        ' Create and configure the shift label
                        Dim shiftLabel As New Label With {
                            .Text = String.Format("{0} ({1:HH:mm} - {2:HH:mm})", shiftName, dayDate, endDate),
                            .Font = New Font("Arial", 8, FontStyle.Bold Or FontStyle.Italic),
                            .ForeColor = GetShiftColor(shiftTimeId),
                            .Dock = DockStyle.Bottom,
                            .TextAlign = ContentAlignment.MiddleCenter
                        }
                        AddHandler shiftLabel.Click, AddressOf ShiftLabel_Click
                        shiftLabel.Tag = dayDate ' Store the shift date in the Tag property
                        parentPanel.Controls.Add(shiftLabel)

                        ' Draw a line to the endDate if the shift spans multiple days
                        If dayDate.Date <> endDate.Date Then
                            Dim endDayPanelName As String = String.Format("PnlDay{0}{1}", endDate.Day \ 7, endDate.Day Mod 7)
                            Dim endDayPanel As Control = Me.Controls.Find(endDayPanelName, True).FirstOrDefault()
                            If endDayPanel IsNot Nothing Then
                                Dim line As New Label With {
                                    .BackColor = Color.Black,
                                    .Height = 2,
                                    .Dock = DockStyle.Bottom
                                }
                                parentPanel.Controls.Add(line)
                            End If
                        End If
                    End If
                End If
            Next
        Next

        SizeMonthYearLabel()
    End Sub

    Private Function GetShiftColor(shiftTimeId As Integer) As Color
        Select Case shiftTimeId
            Case 1 ' Morning Shift
                Return Color.Green
            Case 2 ' Evening Shift
                Return Color.Blue
            Case 3 ' Night Shift
                Return Color.Salmon
            Case Else
                Return Color.Gray ' Default color for unknown shiftTimeId
        End Select
    End Function

    Private Sub ShiftLabel_Click(sender As Object, e As EventArgs)
        Dim shiftLabel As Label = CType(sender, Label)
        Dim shiftDate As DateTime = CType(shiftLabel.Tag, DateTime)

        ' Fetch detailed information about the shift
        Dim shiftName As String = ""
        Dim startTime As String = ""
        Dim endTime As String = ""
        Dim nurseList As New List(Of String)

        Try
            ' Query to get shift details
            Dim shiftQuery As String = "SELECT shiftName, startTime, endTime FROM shifts WHERE startDate = @startDate"
            Dim shiftCommand As New MySqlCommand(shiftQuery, datacon)
            shiftCommand.Parameters.AddWithValue("@startDate", shiftDate)

            Dim reader As MySqlDataReader = shiftCommand.ExecuteReader()
            If reader.Read() Then
                shiftName = reader.GetString("shiftName")
                startTime = reader.GetTimeSpan("startTime").ToString()
                endTime = reader.GetTimeSpan("endTime").ToString()
            End If
            reader.Close()

            ' Query to get assigned nurses for the shift
            Dim nurseQuery As String = "SELECT n.fname, n.lname 
                            FROM shift_nurses sn 
                            INNER JOIN nurse n ON sn.nurseId = n.nurseId 
                            INNER JOIN shifts s ON sn.shiftId = s.shiftId 
                            WHERE s.startDate = @startDate"

            Dim nurseCommand As New MySqlCommand(nurseQuery, datacon)
            nurseCommand.Parameters.AddWithValue("@startDate", shiftDate)

            reader = nurseCommand.ExecuteReader()
            While reader.Read()
                nurseList.Add(reader.GetString("fname") & " " & reader.GetString("lname"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading shift details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Prepare nurse information
        Dim nurseDetails As String
        If nurseList.Count > 0 Then
            nurseDetails = String.Join(Environment.NewLine, nurseList)
        Else
            nurseDetails = "No nurses assigned to this shift."
        End If

        ' Display the detailed information
        Dim details As String = String.Format(
        "Shift Name: {0}{1}" &
        "Start Time: {2}{1}" &
        "End Time: {3}{1}" &
        "Assigned Nurses ({4}):{1}{5}",
        shiftName, Environment.NewLine, startTime, endTime, nurseList.Count, nurseDetails)

        MessageBox.Show(details, "Shift Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class