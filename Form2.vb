Public Class Form2
    Dim i As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, prima, kuadrat As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        ' mencari bilangan ganjil
        If (ComboBox1.SelectedIndex.Equals(0)) Then
            ListBox1.Items.Clear()  'membersihkan ListBox1
            ListBox1.Items.Add("bilangan ganjil : ")  'mengisi ListBox1 dengan bilangan ganjil
            For a = TextBox1.Text To b  'dari a sampai b
                If a Mod 2 = 1 Then  'rumus mencari bilangan ganjil
                    ListBox1.Items.Add(a)  'menambahkan item a ke dalam ListBox1
                End If
            Next
            ' mencari bilangan genap
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            ListBox1.Items.Clear()  'membersihkan ListBox1
            ListBox1.Items.Add("bilangan genap : ")  'mengisi ListBox1 dengan bilangan genap
            For a = TextBox1.Text To b 'dari a sampai b
                If a Mod 2 = 0 Then 'rumus mencari bilangan genap
                    ListBox1.Items.Add(a)  'menambahkan item a ke dalam ListBox1
                End If
            Next
            ' mencari bilangan prima
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            ListBox1.Items.Clear()  'membersihkan ListBox1
            ListBox1.Items.Add("bilangan prima : ")  'mengisi ListBox1 dengan bilangan prima
            Dim x As Integer
            Dim y As Integer
            Dim z As Integer
            For x = a To b
                z = 0
                For y = 2 To x
                    prima = x Mod y
                    If prima = 0 Then
                        z = z + 1
                    End If
                Next (y)
                If z <= 1 Then
                    ListBox1.Items.Add(x)  'menambahkan item x ke dalam ListBox1
                End If
            Next (x)
            ' mencari bilangan kuadrat
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            ListBox1.Items.Clear() 'membersihkan ListBox1
            ListBox1.Items.Add("bilangan kuadrat : ")  'mengisi ListBox1 dengan bilangan kuadrat
            For a = TextBox1.Text To b  'dari a sampai b
                If (a < b + 1) Then 'jika a kurang dari b + 1
                    kuadrat = a * a ' kuadrat = axa
                End If
                ListBox1.Items.Add(kuadrat)  'menambahkan item kuadrat ke dalam ListBox1
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim response As MsgBoxResult
        response = MsgBox("Anda Yakin Ingin keluar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
End Class