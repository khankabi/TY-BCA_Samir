Imports System

Imports System.Data

Imports System.Data.OleDb
Public Class Form2
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMP.accdb")

    Dim adpt As New OleDbDataAdapter("Select * from Emp", con)

    Dim ds As New DataSet

    Dim cmd As New OleDbCommand

    Public Function display()

        adpt.Fill(ds, "Emp")

        DataGridView1.DataSource = ds

        DataGridView1.DataMember = "Emp"

        Return ds

    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.Emp' table. You can move, or remove it, as needed.
        'Me.EmpTableAdapter.Fill(Me.EMPDataSet.Emp)'
        display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            cmd.Connection = con

            cmd.CommandType = CommandType.Text

            cmd.CommandText = "insert into Emp values(" & TextBox1.Text & ",'" & TextBox2.Text & "'," & TextBox3.Text & ")"

            con.Open()

            cmd.ExecuteNonQuery()

            con.Close()

            ds.Clear()

            display()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class