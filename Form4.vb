Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("01")
        ComboBox1.Items.Add("02")
        ComboBox1.Items.Add("03")
        ComboBox1.Items.Add("04")
        ComboBox1.Items.Add("05")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "01"
                TextBox1.Text = "Bluberry Twist"
                TextBox2.Text = 18000
            Case "02"
                TextBox1.Text = "Toffe Caramel"
                TextBox2.Text = 27000
            Case "03"
                TextBox1.Text = "Chololate Tiramisu"
                TextBox2.Text = 16000
            Case "04"
                TextBox1.Text = "Chololate devil"
                TextBox2.Text = 24000
            Case "05"
                TextBox1.Text = "Milk Chololate"
                TextBox2.Text = 21000
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Then
            MsgBox("jumlah kue tidak ada")
        Else
            TextBox4.Text = Val(TextBox2.Text) * Val(TextBox3.Text)
        End If
        'menambahkan daftar di listbox
        Dim item As String
        item = TextBox4.Text
        ListBox1.Items.Add("harga kue = ") 'menambah kan "harga kue = " di dalam ListBox1
        ListBox1.Items.Add(item) 'menambahkan item ke dalam ListBox1
        TextBox4.Focus()
        'menghitung total di listbox
        Dim tot As Long
        tot = 0
        For t As Integer = 0 To ListBox1.Items.Count - 1
            tot = tot + Val(ListBox1.Items.Item(t))
        Next
        TextBox5.Text = tot ' TextBox5 berisikan tot

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = "" ' mengosongkan ComboBox
        TextBox1.Clear() 'membersihkan TextBox1
        TextBox2.Clear() 'membersihkan TextBox2
        TextBox3.Clear() 'membersihkan TextBox3
        TextBox4.Clear() 'membersihkan TextBox4
        TextBox5.Clear() 'membersihkan TextBox5
        ListBox1.Items.Clear() 'membersihkan listbox
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim response As MsgBoxResult
        response = MsgBox("Anda Yakin Ingin keluar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
End Class