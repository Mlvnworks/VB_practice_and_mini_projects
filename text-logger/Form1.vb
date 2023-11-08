

Imports System.Diagnostics.Tracing

Public Class Form1
    Dim words As New List(Of String)()

    Private Class Console
        Public Sub log()
            Dim currentDateTime As DateTime = DateTime.Now

            clear()
            For i As Integer = 0 To Form1.words.Count - 1
                Form1.OutputBox.AppendText(Form1.words(i) & " ---" & currentDateTime & Environment.NewLine)
            Next i
        End Sub

        Public Sub clear()
            Form1.OutputBox.Clear()
        End Sub
    End Class


    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim newWord As String = newWordInput.Text
        Dim console As Console = New Console

        If newWord = "" Then
            MessageBox.Show("Please enter word inside field")
        Else
            words.Add(newWord)
            console.log()
            newWordInput.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim console As Console = New Console

        If result = DialogResult.OK Then
            words.Clear()
            console.clear()
        End If

    End Sub
End Class
