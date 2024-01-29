Public Class SETC_1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("please enter name")
        Else
            Dim age, gender As String
            age = ""
            gender = ""
            If rdmale.Checked Then
                gender = "Chad"
            ElseIf rdfemale.Checked Then
                gender = "papa ki pari"
            ElseIf rdcustom.Checked Then
                gender = "Pata nahi"
            End If

            If rd18.Checked Then
                age = "Less then 18 can't drive"
            ElseIf rd1940.Checked Then
                age = "Between 18 to 40, can drive"
            ElseIf rd40.Checked Then
                age = "Above 40, All right"
            End If
            MessageBox.Show("Name: " + TextBox1.Text + "" + vbCrLf + "Age: " + age + vbCrLf + "Gender: " + gender)
        End If
    End Sub

    Private Sub rd18_CheckedChanged(sender As Object, e As EventArgs) Handles rd18.CheckedChanged
        If rd18.Checked Then
            chkcant.Checked = True
        Else
            chkcant.Checked = False
        End If
    End Sub

    Private Sub rd1940_CheckedChanged(sender As Object, e As EventArgs) Handles rd1940.CheckedChanged
        If rd1940.Checked Then
            chkcan.Checked = True
        Else
            chkcan.Checked = False
        End If
    End Sub

    Private Sub rd40_CheckedChanged(sender As Object, e As EventArgs) Handles rd40.CheckedChanged
        If rd40.Checked Then
            chkright.Checked = True
        Else
            chkright.Checked = False
        End If
    End Sub
End Class