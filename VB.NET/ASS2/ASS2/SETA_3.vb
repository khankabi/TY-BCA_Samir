Public Class SETA_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = DateTimePicker1.Value.Day
        TextBox2.Text = DateTimePicker1.Value.Month
        TextBox3.Text = DateTimePicker1.Value.Year
        TextBox4.Text = DateTimePicker1.Value.Hour
        TextBox5.Text = DateTimePicker1.Value.Minute
        TextBox6.Text = DateTimePicker1.Value.Second
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class