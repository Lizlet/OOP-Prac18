Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(RandomPersonsGenerator.GenerateRandomPersonsList)
    End Sub
End Class
