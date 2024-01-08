Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sentence As String
        Dim i As Integer
        Dim wc As Integer
        sentence = TextBox1.Text
        Dim arr() As Char = sentence.ToCharArray
        For i = 0 To arr.Length - 1
            If arr(i) = " " Then
                wc = wc + 1
            End If
        Next
        MsgBox("total number of words in sentence is= " & wc + 1)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub


End Class
