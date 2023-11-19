Public Class Form1
    ' Convertion type
    Public type As String



    ' Celsius to Farenheit 
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        type = "c_to_f"
    End Sub

    ' Farenheit to celsius
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        type = "f_to_c"
    End Sub

    ' celsius to kevin
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        type = "c_to_k"
    End Sub

    ' kevin to celsius
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        type = "k_to_c"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Single
        Try
            Dim input = Single.Parse(tempInput.Text)

            If Not type = "" Then
                If type = "c_to_f" Then
                    ' Celsius to Farenheit formula 
                    result = (input * (9 / 5)) + 32

                ElseIf type = "f_to_c" Then
                    ' Farenheit to Celsius  Formula
                    result = (input - 32) * (5 / 9)

                ElseIf type = "c_to_k" Then

                    ' celsius to kevin Formula
                    result = input + 273.15

                ElseIf type = "k_to_c" Then

                    ' kevin to celsius
                    result = input - 273.15

                End If

                MessageBox.Show(result)

            Else
                MessageBox.Show("Please select a conversion type.")
            End If


        Catch ex As Exception
            MessageBox.Show("Cannot convert temperate.")
        End Try

    End Sub
End Class
