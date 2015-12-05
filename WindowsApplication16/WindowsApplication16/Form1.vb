Imports System.Data.SqlClient
Public Class Form1
    Public Property GridView1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENTDataSet.REGISTRATION' table. You can move, or remove it, as needed.
        Me.REGISTRATIONTableAdapter.Fill(Me.STUDENTDataSet.REGISTRATION)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=ANN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=true"
        Dim queryString As String = "INSERT INTO Registration (FName, Lname) values (@FName,@LName)"
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim command As New SqlCommand(queryString, connection)
                command.Parameters.AddWithValue("@FName", TextBox1.Text)
                command.Parameters.AddWithValue("@LName", TextBox2.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Exception : " + ex.ToString)
        End Try

        Me.REGISTRATIONTableAdapter.Fill(Me.STUDENTDataSet.REGISTRATION)

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GridView1.DataBind()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
