Public Class SETB_1
    Dim text1 As New TextBox
    Dim text2 As New TextBox
    Dim text3 As New TextBox
    Private Sub SETB_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text1.SetBounds(151, 31, 152, 30)
        GroupBox1.Controls.Add(text1)
        text2.SetBounds(151, 82, 152, 30)
        GroupBox1.Controls.Add(text2)
        text3.SetBounds(151, 140, 152, 30)
        GroupBox1.Controls.Add(text3)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no1 As Integer
        Dim no2 As Integer
        Dim no3 As Integer
        Dim min, max As Integer
        no1 = Val(text1.Text)
        no2 = Val(text2.Text)
        no3 = Val(text3.Text)
        'for maximum value
        If no1 > no2 And no1 > no3 Then
            max = no1
        ElseIf no2 > no1 And no2 > no3 Then
            max = no2
        Else
            max = no3
        End If

        'for minimum value
        If no1 < no2 And no1 < no3 Then
            min = no1
        ElseIf no2 < no1 And no2 < no3 Then
            min = no2
        Else
            min = no3
        End If
        MessageBox.Show("Max is= " & max & " " & vbCrLf & "Min is= " & min)
    End Sub

End Class