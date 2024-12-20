Imports MySql.Data.MySqlClient
Public Class Admin_Schedule
    Private Const DaysInMonth As Integer = 42


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

    Private Sub Admin_Schedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        sizeContainers()
    End Sub
End Class
