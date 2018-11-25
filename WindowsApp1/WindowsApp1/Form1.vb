Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z, p
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = Val(TextBox3.Text)
        p = (x + y + z) / 2
        Dim S = Math.Sqrt(p * (p - x) * (p - y) * (p - z))
        Label1.Text = Format(S, "0.00")


    End Sub
    Private Sub Form_Load()

        Print("万紫千红")






    End Sub
    Private Sub Command1_Click()
        Cls
    End Sub

End Class
