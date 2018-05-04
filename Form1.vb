Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, i, c, d, hasil As Integer
        Dim b As Double
        a = TextBox1.Text
        b = 1
        'rumus menghitung faktorial
        For i = 1 To a
            b = b * i
        Next (i)
        TextBox2.Text = b
        'rumus menghitung fibonaci
        c = 1
        d = 1
        For i = 3 To a
            hasil = c + d
            c = d
            d = hasil
        Next
        TextBox3.Text = hasil
        'rumus menghitung kuadrat
        TextBox4.Text = a * a

    End Sub
End Class
