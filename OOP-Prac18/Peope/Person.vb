Public Class Person
    Public Property forename As String
    Public Property surname As String
    Public Property address As String
    Public Property dob As Date
    Public Property email As String
    Public Property phone As String

    Public Sub New(forename As String, surname As String, address As String, dob As Date, email As String, phone As String)
        Me.forename = forename
        Me.surname = surname
        Me.address = address
        Me.dob = dob
        Me.email = email
        Me.phone = phone
    End Sub

    Public Overrides Function ToString() As String
        Return _
            $"Name: {forename} {surname}, " &
            $"Born: {dob.Day.ToString("00")}/" &
                  $"{dob.Month.ToString("00")}-" &
                  $"{dob.Year.ToString("0000")}, " & 'in the offchance that a person is over 1017 years old.
            $"address : {address}, " &
            $"email: {email}, " &
            $"phone {phone}"
    End Function

End Class
