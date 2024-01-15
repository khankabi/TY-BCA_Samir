Public Class SETA_2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub
End Class