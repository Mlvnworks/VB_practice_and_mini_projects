Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This is button Click event")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox.CheckedChanged
        Dim taoCheck = Integer.Parse(checkbox.CheckState)

        If taoCheck = 1 Then
            MessageBox.Show("Sure ka? De jk sigi.")
        Else
            MessageBox.Show("HAHAHAHA!")
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox.SelectedIndexChanged
        MessageBox.Show(CheckedListBox.SelectedItem)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        MessageBox.Show(ComboBox.SelectedItem)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        MessageBox.Show(DateTimePicker1.Value)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://facebook.com")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MessageBox.Show(ListBox1.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Not passwordInput.PasswordChar = "*" Then
            Button2.Text = "Show"
            passwordInput.PasswordChar = "*"

        Else
            Button2.Text = "Hide"
            passwordInput.PasswordChar = ""

        End If
    End Sub
End Class
