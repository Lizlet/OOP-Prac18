Public Class Employe
    Inherits Person
    Public Property position As String
    Public Property payGrade As UInteger

    Public Sub New(forename As String, surname As String, address As String, dob As Date, email As String, phone As String, position As String, payGrade As UInteger)
        MyBase.New(forename, surname, address, dob, email, phone)
        Me.position = position
        Me.payGrade = payGrade
    End Sub

    Public Overrides Function ToString() As String
        Return _
            $"{MyBase.ToString()}, " &
            $"Position: {position}, " &
            $"Pay grade: {payGrade}"
    End Function
End Class
