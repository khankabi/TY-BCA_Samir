Public Class Form1
    Dim counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counter = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        TextBox1.Text = counter
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
    End Sub
End Class
