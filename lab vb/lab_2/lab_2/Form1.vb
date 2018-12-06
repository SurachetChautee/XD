Public Class Form1
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles total_sales.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text
        Dim c As Integer = a + b
        total_sales.Text = c
        Dim d As Integer = a * 0.05
        com_1.Text = d
        Dim f As Integer = b * 0.1
        com_2.Text = f
        Dim z As Integer = d + f
        total_com.Text = z

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        total_sales.Text = ""
        com_1.Text = ""
        com_2.Text = ""
        total_com.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
