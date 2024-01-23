'Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SETB_3
    Dim a(5), i As Integer
    '--------------CODE FOR EXIT BUTTON---------------------------------------------
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    '----------------------CODE FOR ADDITION OF LIST ITEMS ELEMENT------------------
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As Integer
        For i = 0 To 4
            s = s + a(i)
        Next
        TextBox2.Text = "Sum of Array is:=" & s
    End Sub
    '-----------------------CODE FOR DISPLAY ITEMS----------------------------------
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For i = 0 To 4
            ListBox1.Items.Add(a(i))
        Next
    End Sub
    '-----------------------CODE FOR FIND MAXIMUM VALUES----------------------------
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim m As Integer
        m = a(i)
        For i = 0 To 4
            If (m < a(i)) Then
                m = a(i)
            End If
        Next
        TextBox1.Text = "Maximum Number is:=" & m
    End Sub
    '-----------------------CODE FOR CLEAR BUTTON-------------------------------
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    '-----------------------CODE FOR INPUT VALUES-----------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 4
            a(i) = InputBox("Enter any value:")
            If (a(i) < 0) Then
                MsgBox("Value Should be greater than Zero")
                Me.Close()
            End If
        Next
    End Sub
End Class