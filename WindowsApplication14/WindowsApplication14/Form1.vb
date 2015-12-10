Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sum.Click
        Dim num1, num2 As Integer
        num1 = Val(Number1.Text)
        num2 = Val(Number2.Text)
        TextBox3.Text = num1 + num2

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2 As Integer
        num1 = Val(Number1.Text)
        num2 = Val(Number2.Text)
        TextBox4.Text = num1 - num2

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2 As Integer
        num1 = Val(Number1.Text)
        num2 = Val(Number2.Text)
        TextBox5.Text = num1 * num2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2 As Integer
        num1 = Val(Number1.Text)
        num2 = Val(Number2.Text)
        TextBox6.Text = num1 / num2
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
