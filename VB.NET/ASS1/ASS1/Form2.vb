Public Class Form2
    Dim numconverter As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result = MessageBox.Show("Are you sure ???", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numconverter = Integer.Parse(TextBox1.Text)
        TextBox2.Text = Convert.ToString(numconverter, 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numconverter = Integer.Parse(TextBox1.Text)
        TextBox2.Text = Convert.ToString(numconverter, 8)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numconverter = Integer.Parse(TextBox1.Text)
        TextBox2.Text = Convert.ToString(numconverter, 16)
    End Sub
End Class/85.3/
