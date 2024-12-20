Public Class MonthlyCalendarInfo
    Private _Month As Integer
    Private _Year As Integer
    Private ReadOnly _Days(5, 6) As DateTime

    Public ReadOnly Property Month
        Get
            Return _Month
        End Get
    End Property

    Public ReadOnly Property Year
        Get
            Return _Year
        End Get
    End Property

    Public Sub New(v As Integer, v1 As Integer)
        _Month = Now.Month
        _Year = Now.Year
        setDays()
    End Sub

    Private Sub setDays()
        Dim firstDayOfMonth As DateTime
        Dim column As Integer
        Dim firstDayOfGrid As DateTime
        Dim gridDate As DateTime

        firstDayOfMonth = New Date(_Year, _Month, 1)
        column = CInt(firstDayOfMonth.DayOfWeek)
        firstDayOfGrid = firstDayOfMonth.AddDays(column * -1)

        gridDate = firstDayOfGrid
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                _Days(rowIndex, colIndex) = gridDate
                gridDate = gridDate.AddDays(1)
            Next
        Next

        Return
    End Sub

    Public Sub GoToMonth(year As Integer, month As Integer)
        If year < 1 Or year > 9999 Then
            Throw New ArgumentOutOfRangeException("Year")
        End If

        If month < 1 Or month > 12 Then
            Throw New ArgumentOutOfRangeException("Month")
        End If

        _Year = year
        _Month = month
        setDays()

    End Sub

    Public Function DayInMonth(row As Integer, column As Integer) As Integer
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("Row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("Column")
        End If

        Return _Days(row, column).Day
    End Function

    Public Function isActiveMonth(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("Row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("Column")
        End If

        Return _Days(row, column).Month = Month
    End Function

    Public Function isToday(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("Row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("Column")
        End If

        Return _Days(row, column).Date = Now.Date
    End Function

    Public Function row(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0

        For rowIndex = 0 To 5
            If _Days(rowIndex, colIndex) = dt Then
                Return rowIndex
            End If
        Next

        Return -1
    End Function

    Public Function col(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0

        For rowIndex = 0 To 5
            If _Days(rowIndex, colIndex) = dt Then
                Return rowIndex
            End If
        Next

        Return -1
    End Function

    Public Function dateExists(dt As DateTime) As Boolean
        If row(dt) > -1 Then
            Return True
        End If

        Return False
    End Function

End Class
