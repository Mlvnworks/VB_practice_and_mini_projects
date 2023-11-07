Public Class Form1
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If usernameInput.Text = "admin" And passwordInput.Text = "admin" Then
            MsgBox("Login completed!")
            Hide()
            Form2.Show()
        Else
            MsgBox("Failed to login!")
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Hide()
    End Sub
End Class
