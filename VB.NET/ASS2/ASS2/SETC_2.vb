Public Class SETC_2
    Dim no1, no2, result As Integer
    Dim op As String = "+"

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        no2 = TextBox1.Text
        If op = "+" Then
            result = no1 + no2
            TextBox1.Text = result
        ElseIf op = "-" Then
            result = no1 - no2
            TextBox1.Text = result
        ElseIf op = "*" Then
            result = no1 * no2
            TextBox1.Text = result
        ElseIf op = "/" Then
            result = no1 / no2
            TextBox1.Text = result
        End If
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        If (TextBox1.Text.Contains(".")) Then
            TextBox1.Text = "." + TextBox1.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button18.Click, Button16.Click, Button14.Click, Button10.Click
        Dim b As Button = sender
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not TextBox1.Text.Contains(".")) Then
                TextBox1.Text = TextBox1.Text + b.Text
            End If
        Else
            TextBox1.Text = TextBox1.Text + b.Text
        End If
    End Sub

    Private Sub btncorrect_Click(sender As Object, e As EventArgs) Handles btncorrect.Click
        If (TextBox1.Text.Length > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub


    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles Button17.Click, Button15.Click, Button13.Click, Button11.Click
        Dim b As Button = sender
        no1 = TextBox1.Text
        op = b.Text
        TextBox1.Text = ""
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub



End Class