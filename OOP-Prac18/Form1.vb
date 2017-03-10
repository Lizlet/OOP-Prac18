Imports System.Globalization
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Static rng As System.Random = New System.Random

        For x = 0 To 100
            Debug.WriteLine(RandomPersonsGenerator.GenerateRandomPerson)
        Next
    End Sub
End Class
