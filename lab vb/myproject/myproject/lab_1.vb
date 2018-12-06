Public Class lab_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_total.Text = TextBox1.Text * 12
        lbl_tax.Text = lbl_total.Text * 0.05
        lbl_total2.Text = lbl_total.Text - lbl_tax.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class