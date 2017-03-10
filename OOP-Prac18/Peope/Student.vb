Public Class Student
    Inherits Person
    Public Property year As Integer
    Public Property study As String

    Public Sub New(forename As String, surname As String, address As String, dob As Date, email As String, phone As String, year As Integer, study As String)
        MyBase.New(forename, surname, address, dob, email, phone)
        Me.year = year
        Me.study = study
    End Sub

    Public Overrides Function ToString() As String
        Return _
            $"{MyBase.ToString()}, " &
            $"Study: {study}, " &
            $"Year: {year}"
    End Function
End Class
