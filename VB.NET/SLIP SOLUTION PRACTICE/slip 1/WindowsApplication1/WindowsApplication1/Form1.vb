Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()
        TextBox2.Text = TextBox2.Text + 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Second(DateTime.Now)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = 0
    End Sub
End Class
