Imports System.Globalization
Public Class RandomPersonsGenerator
    Public Shared Function GenerateRandomPersonsList() As Person()

    End Function

    Public Shared Function GenerateRandomPerson() As Person
        Static rng As System.Random = New System.Random
        Dim name As String = My.Resources.namelist.Split(Environment.NewLine)(rng.Next(0, 50))
        Dim address As String = My.Resources.addresslist.Split(Environment.NewLine)(rng.Next(0, 50))
        Dim dob As Date = Date.ParseExact(My.Resources.doblist.Split(Environment.NewLine)(rng.Next(1, 51)).Substring(1, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture)
        Dim email As String = $"{name.Split(" ")(0).Substring(1, name.Split(" ")(0).Length - 1)}.{name.Split(" ")(1)}@gmail.com"
        Dim phone As String = $"{rng.Next(1000, 9999)} {rng.Next(100000, 999999)}"

        name = name.Substring(1, name.Length - 1)
        address = address.Substring(1, address.Length - 1)

        Dim checker As Integer = rng.Next(0, 3)

        If checker = 0 Then

        ElseIf checker = 1 Then

        End If

        Return New Person(name.Split(" ")(0), name.Split(" ")(1), address, dob, email, phone)
    End Function
End Class
