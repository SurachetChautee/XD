Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn3.Click, btn2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim hours As Integer
        Dim payrate, total, tax As Double
        hours = Val(TextBox1.Text)
        payrate = Val(TextBox2.Text)

        total = hours * payrate
        tax = total * 3 / 100


        lbl_total.Text = total
        lbl_tax.Text = tax




    End Sub
End Class
