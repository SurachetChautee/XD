Public Class lab_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gluta As Integer = txt_gluta.Text
        Dim computer As Integer = txt_com.Text
        Dim total, com1, com2, total2 As Double

        total = Val(gluta) + Val(computer)
        com1 = gluta * 0.05
        com2 = computer * 0.1
        total2 = com1 + com2

        lbl_total.Text = total
        lbl_com_gluta.Text = com1
        lbl_com_computer.Text = com2
        lbl_total_com.Text = total2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_gluta.Clear()
        txt_com.Clear()
        lbl_total.Text = ""
        lbl_com_gluta.Text = ""
        lbl_com_computer.Text = ""
        lbl_total_com.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class