Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim root1 As Decimal
    Dim root2 As Decimal

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RootBox1.Text = ""
        RootBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = (b ^ 2) - (4 * a * c)
        root1 = (-b + Math.Sqrt(d)) / (2 * a)
        root2 = (-b - Math.Sqrt(d)) / (2 * a)
        RootBox1.Text = root1
        RootBox2.Text = root2
    End Sub
End Class
