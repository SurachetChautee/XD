Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = a * 12
        TextBox2.Text = b
        Dim c As Integer = b * 0.05
        TextBox3.Text = c
        Dim d As Integer = b - c
        TextBox4.Text = d

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
