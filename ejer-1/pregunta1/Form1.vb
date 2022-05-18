Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a >= b And a >= c Then If b >= c Then GoTo orden1 Else GoTo orden2 Else If b >= a And b >= c Then If a >= c Then GoTo orden3 Else GoTo orden4 Else If c >= a And c >= b Then If a >= b Then GoTo orden5 Else GoTo orden6
orden1:
        TextBox4.Text = a.ToString() + " " + b.ToString() + " " + c.ToString()
        GoTo salir
orden2:
        TextBox4.Text = a.ToString() + " " + c.ToString() + " " + b.ToString()
        GoTo salir
orden3:
        TextBox4.Text = b.ToString() + " " + a.ToString() + " " + c.ToString()
        GoTo salir
orden4:
        TextBox4.Text = b.ToString() + " " + c.ToString() + " " + a.ToString()
        GoTo salir
orden5:
        TextBox4.Text = c.ToString() + " " + a.ToString() + " " + b.ToString()
        GoTo salir
orden6:
        TextBox4.Text = c.ToString() + " " + b.ToString() + " " + a.ToString()
        GoTo salir
salir:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
